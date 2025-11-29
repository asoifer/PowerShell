// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation.Configuration;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Tracing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace System.Management.Automation
{
    internal enum CompileInterpretChoice
    {
        NeverCompile,
        AlwaysCompile,
        CompileOnDemand
    }

    internal enum ScriptBlockClauseToInvoke
    {
        Begin,
        Process,
        End,
        ProcessBlockOnly,
    }
    internal class CompiledScriptBlockData
    {
        internal CompiledScriptBlockData(IParameterMetadataProvider ast, bool isFilter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1562, 1137, 1341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 10492, 10503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 10643, 10647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11258, 11308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11318, 11379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11389, 11456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11466, 11544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11554, 11615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11627, 11691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11701, 11776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11786, 11843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11853, 11921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11931, 11990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12000, 12070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12080, 12135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12145, 12211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12223, 12276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12328, 12362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12393, 12404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12428, 12446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12470, 12488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12512, 12532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12556, 12577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12602, 12616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12627, 12669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12679, 12726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12786, 12823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12833, 12872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12882, 12926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 14171, 14189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 16712, 16754);
                this._expAttribute = ExperimentalAttribute.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 1241, 1252);

                _ast = ast;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 1266, 1291);

                this.IsFilter = isFilter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 1305, 1330);

                this.Id = Guid.NewGuid();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1562, 1137, 1341);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 1137, 1341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 1137, 1341);
            }
        }

        internal CompiledScriptBlockData(string scriptText, bool isProductCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1562, 1353, 1569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 10492, 10503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 10643, 10647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11258, 11308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11318, 11379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11389, 11456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11466, 11544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11554, 11615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11627, 11691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11701, 11776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11786, 11843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11853, 11921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11931, 11990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12000, 12070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12080, 12135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12145, 12211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12223, 12276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12328, 12362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12393, 12404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12428, 12446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12470, 12488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12512, 12532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12556, 12577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12602, 12616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12627, 12669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12679, 12726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12786, 12823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12833, 12872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 12882, 12926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 14171, 14189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 16712, 16754);
                this._expAttribute = ExperimentalAttribute.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 1449, 1480);

                _isProductCode = isProductCode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 1494, 1519);

                _scriptText = scriptText;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 1533, 1558);

                this.Id = Guid.NewGuid();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1562, 1353, 1569);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 1353, 1569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 1353, 1569);
            }
        }

        internal bool Compile(bool optimized)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 1581, 2468);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 1643, 1736) || true) && (_attributes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 1643, 1736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 1700, 1721);

                    f_1562_1700_1720(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 1643, 1736);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 1966, 2073) || true) && (optimized && (DynAbs.Tracing.TraceSender.Expression_True(1562, 1970, 2005) && f_1562_1983_1997() == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 1966, 2073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2039, 2058);

                    f_1562_2039_2057(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 1966, 2073);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2089, 2176);

                optimized = optimized && (DynAbs.Tracing.TraceSender.Expression_True(1562, 2101, 2175) && !f_1562_2115_2175(f_1562_2160_2174()));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2192, 2424) || true) && (!optimized && (DynAbs.Tracing.TraceSender.Expression_True(1562, 2196, 2231) && !_compiledUnoptimized))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 2192, 2424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2265, 2286);

                    f_1562_2265_2285(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 2192, 2424);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 2192, 2424);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2320, 2424) || true) && (optimized && (DynAbs.Tracing.TraceSender.Expression_True(1562, 2324, 2356) && !_compiledOptimized))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 2320, 2424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2390, 2409);

                        f_1562_2390_2408(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 2320, 2424);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 2192, 2424);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2440, 2457);

                return optimized;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 1581, 2468);

                int
                f_1562_1700_1720(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    this_param.InitializeMetadata();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 1700, 1720);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, int>
                f_1562_1983_1997()
                {
                    var return_v = NameToIndexMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 1983, 1997);
                    return return_v;
                }


                int
                f_1562_2039_2057(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    this_param.CompileOptimized();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 2039, 2057);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, int>
                f_1562_2160_2174()
                {
                    var return_v = NameToIndexMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 2160, 2174);
                    return return_v;
                }


                bool
                f_1562_2115_2175(System.Collections.Generic.Dictionary<string, int>
                variableNames)
                {
                    var return_v = VariableAnalysis.AnyVariablesCouldBeAllScope(variableNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 2115, 2175);
                    return return_v;
                }


                int
                f_1562_2265_2285(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    this_param.CompileUnoptimized();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 2265, 2285);
                    return 0;
                }


                int
                f_1562_2390_2408(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    this_param.CompileOptimized();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 2390, 2408);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 1581, 2468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 1581, 2468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void InitializeMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 2480, 4500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2544, 2548);
                lock (this)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2582, 2748) || true) && (_attributes != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 2582, 2748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2722, 2729);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 2582, 2748);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2768, 2791);

                    Attribute[]
                    attributes
                    = default(Attribute[]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2809, 2862);

                    CmdletBindingAttribute
                    cmdletBindingAttribute = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2880, 3950) || true) && (!f_1562_2885_2918(f_1562_2885_2888()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 2880, 3950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 2960, 2998);

                        attributes = f_1562_2973_2997();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 2880, 3950);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 2880, 3950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 3080, 3134);

                        attributes = f_1562_3093_3133(f_1562_3093_3123(f_1562_3093_3096()));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 3156, 3855);
                            foreach (var attribute in f_1562_3182_3192_I(attributes))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 3156, 3855);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 3242, 3832) || true) && (attribute is CmdletBindingAttribute c)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 3242, 3832);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 3341, 3394);

                                    cmdletBindingAttribute = cmdletBindingAttribute ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.CmdletBindingAttribute>(1562, 3366, 3393) ?? c);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 3242, 3832);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 3242, 3832);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 3452, 3832) || true) && (attribute is DebuggerHiddenAttribute)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 3452, 3832);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 3550, 3572);

                                        DebuggerHidden = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 3452, 3832);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 3452, 3832);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 3630, 3832) || true) && (attribute is DebuggerStepThroughAttribute || (DynAbs.Tracing.TraceSender.Expression_False(1562, 3634, 3720) || attribute is DebuggerNonUserCodeAttribute))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 3630, 3832);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 3778, 3805);

                                            DebuggerStepThrough = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 3630, 3832);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 3452, 3832);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 3242, 3832);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 3156, 3855);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1562, 1, 700);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1562, 1, 700);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 3879, 3931);

                        _usesCmdletBinding = cmdletBindingAttribute != null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 2880, 3950);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 3970, 4070);

                    bool
                    automaticPosition = cmdletBindingAttribute == null || (DynAbs.Tracing.TraceSender.Expression_False(1562, 3995, 4069) || f_1562_4029_4069(cmdletBindingAttribute))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 4088, 4217);

                    var
                    runtimeDefinedParameterDictionary =
                    f_1562_4149_4216(f_1562_4149_4152(), automaticPosition, ref _usesCmdletBinding)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 4360, 4385);

                    _attributes = attributes;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 4403, 4474);

                    _runtimeDefinedParameterDictionary = runtimeDefinedParameterDictionary;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 2480, 4500);

                System.Management.Automation.Language.IParameterMetadataProvider
                f_1562_2885_2888()
                {
                    var return_v = Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 2885, 2888);
                    return return_v;
                }


                bool
                f_1562_2885_2918(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.HasAnyScriptBlockAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 2885, 2918);
                    return return_v;
                }


                System.Attribute[]
                f_1562_2973_2997()
                {
                    var return_v = Array.Empty<Attribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 2973, 2997);
                    return return_v;
                }


                System.Management.Automation.Language.IParameterMetadataProvider
                f_1562_3093_3096()
                {
                    var return_v = Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 3093, 3096);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Attribute>
                f_1562_3093_3123(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.GetScriptBlockAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 3093, 3123);
                    return return_v;
                }


                System.Attribute[]
                f_1562_3093_3133(System.Collections.Generic.IEnumerable<System.Attribute>
                source)
                {
                    var return_v = source.ToArray<System.Attribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 3093, 3133);
                    return return_v;
                }


                System.Attribute[]
                f_1562_3182_3192_I(System.Attribute[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 3182, 3192);
                    return return_v;
                }


                bool
                f_1562_4029_4069(System.Management.Automation.CmdletBindingAttribute
                this_param)
                {
                    var return_v = this_param.PositionalBinding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 4029, 4069);
                    return return_v;
                }


                System.Management.Automation.Language.IParameterMetadataProvider
                f_1562_4149_4152()
                {
                    var return_v = Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 4149, 4152);
                    return return_v;
                }


                System.Management.Automation.RuntimeDefinedParameterDictionary
                f_1562_4149_4216(System.Management.Automation.Language.IParameterMetadataProvider
                this_param, bool
                automaticPositions, ref bool
                usesCmdletBinding)
                {
                    var return_v = this_param.GetParameterMetadata(automaticPositions, ref usesCmdletBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 4149, 4216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 2480, 4500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 2480, 4500);
            }
        }

        private void CompileUnoptimized()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 4512, 4912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 4576, 4580);
                lock (this)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 4614, 4799) || true) && (_compiledUnoptimized)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 4614, 4799);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 4773, 4780);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 4614, 4799);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 4819, 4840);

                    f_1562_4819_4839(this, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 4858, 4886);

                    _compiledUnoptimized = true;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 4512, 4912);

                int
                f_1562_4819_4839(System.Management.Automation.CompiledScriptBlockData
                this_param, bool
                optimize)
                {
                    this_param.ReallyCompile(optimize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 4819, 4839);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 4512, 4912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 4512, 4912);
            }
        }

        private void CompileOptimized()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 4924, 5317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 4986, 4990);
                lock (this)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 5024, 5207) || true) && (_compiledOptimized)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 5024, 5207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 5181, 5188);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 5024, 5207);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 5227, 5247);

                    f_1562_5227_5246(this, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 5265, 5291);

                    _compiledOptimized = true;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 4924, 5317);

                int
                f_1562_5227_5246(System.Management.Automation.CompiledScriptBlockData
                this_param, bool
                optimize)
                {
                    this_param.ReallyCompile(optimize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 5227, 5246);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 4924, 5317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 4924, 5317);
            }
        }

        private void ReallyCompile(bool optimize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 5329, 6300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 5488, 5540);

                bool
                etwEnabled = f_1562_5506_5539(ParserEventSource.Log)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 5554, 5892) || true) && (etwEnabled)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 5554, 5892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 5602, 5632);

                    var
                    extent = f_1562_5615_5631(f_1562_5615_5624(_ast))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 5650, 5673);

                    var
                    text = f_1562_5661_5672(extent)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 5691, 5877);

                    f_1562_5691_5876(ParserEventSource.Log, FileName: f_1562_5758_5810(f_1562_5792_5803(extent), text), f_1562_5833_5844(text), optimize);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 5554, 5892);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 5908, 5932);

                f_1562_5908_5931(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 5948, 5983);

                Compiler
                compiler = f_1562_5968_5982()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 5997, 6030);

                f_1562_5997_6029(compiler, this, optimize);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 6237, 6289) || true) && (etwEnabled)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 6237, 6289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 6253, 6289);

                    f_1562_6253_6288(ParserEventSource.Log);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 6237, 6289);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 5329, 6300);

                bool
                f_1562_5506_5539(System.Management.Automation.Language.ParserEventSource
                this_param)
                {
                    var return_v = this_param.IsEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 5506, 5539);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_5615_5624(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 5615, 5624);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1562_5615_5631(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 5615, 5631);
                    return return_v;
                }


                string
                f_1562_5661_5672(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 5661, 5672);
                    return return_v;
                }


                string
                f_1562_5792_5803(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 5792, 5803);
                    return return_v;
                }


                string
                f_1562_5758_5810(string
                fileName, string
                input)
                {
                    var return_v = ParserEventSource.GetFileOrScript(fileName, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 5758, 5810);
                    return return_v;
                }


                int
                f_1562_5833_5844(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 5833, 5844);
                    return return_v;
                }


                int
                f_1562_5691_5876(System.Management.Automation.Language.ParserEventSource
                this_param, string
                FileName, int
                Length, bool
                Optimized)
                {
                    this_param.CompileStart(FileName: FileName, Length, Optimized);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 5691, 5876);
                    return 0;
                }


                int
                f_1562_5908_5931(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    this_param.PerformSecurityChecks();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 5908, 5931);
                    return 0;
                }


                System.Management.Automation.Language.Compiler
                f_1562_5968_5982()
                {
                    var return_v = new System.Management.Automation.Language.Compiler();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 5968, 5982);
                    return return_v;
                }


                int
                f_1562_5997_6029(System.Management.Automation.Language.Compiler
                this_param, System.Management.Automation.CompiledScriptBlockData
                scriptBlock, bool
                optimize)
                {
                    this_param.Compile(scriptBlock, optimize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 5997, 6029);
                    return 0;
                }


                int
                f_1562_6253_6288(System.Management.Automation.Language.ParserEventSource
                this_param)
                {
                    this_param.CompileStop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 6253, 6288);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 5329, 6300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 5329, 6300);
            }
        }

        private void PerformSecurityChecks()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 6312, 10388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 6373, 6416);

                var
                scriptBlockAst = f_1562_6394_6397() as ScriptBlockAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 6430, 6573) || true) && (scriptBlockAst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 6430, 6573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 6551, 6558);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 6430, 6573);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 6589, 6630);

                var
                scriptExtent = f_1562_6608_6629(scriptBlockAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 6644, 6679);

                var
                scriptFile = f_1562_6661_6678(scriptExtent)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 6695, 7048) || true) && (scriptFile != null
                && (DynAbs.Tracing.TraceSender.Expression_True(1562, 6699, 6837) && f_1562_6738_6837(scriptFile, StringLiterals.PowerShellDataFileExtension, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1562, 6699, 6893) && f_1562_6858_6893()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 6695, 7048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 7026, 7033);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 6695, 7048);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 7153, 7223);

                var
                amsiResult = f_1562_7170_7222(f_1562_7192_7209(scriptExtent), scriptFile)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 7239, 8270) || true) && (amsiResult == AmsiUtils.AmsiNativeMethods.AMSI_RESULT.AMSI_RESULT_DETECTED)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 7239, 8270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 7351, 7543);

                    var
                    parseError = f_1562_7368_7542(scriptExtent, "ScriptContainedMaliciousContent", f_1562_7496_7541())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 7561, 7608);

                    throw f_1562_7567_7607(new[] { parseError });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 7239, 8270);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 7239, 8270);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 7642, 8270) || true) && (amsiResult >= AmsiUtils.AmsiNativeMethods.AMSI_RESULT.AMSI_RESULT_BLOCKED_BY_ADMIN_BEGIN
                    && (DynAbs.Tracing.TraceSender.Expression_True(1562, 7646, 7841) && amsiResult <= AmsiUtils.AmsiNativeMethods.AMSI_RESULT.AMSI_RESULT_BLOCKED_BY_ADMIN_END))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 7642, 8270);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 7973, 8190);

                        var
                        parseError = f_1562_7990_8189(scriptExtent, "ScriptHasAdminBlockedContent", f_1562_8115_8188(f_1562_8133_8175(), amsiResult))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 8208, 8255);

                        throw f_1562_8214_8254(new[] { parseError });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 7642, 8270);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 7239, 8270);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 8286, 8425) || true) && (f_1562_8290_8340(scriptBlockAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 8286, 8425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 8382, 8410);

                    HasSuspiciousContent = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 8286, 8425);
                }

                bool IsScriptBlockInFactASafeHashtable()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 8537, 10377);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 8974, 9459) || true) && (f_1562_8978_9003(scriptBlockAst) != null
                        || (DynAbs.Tracing.TraceSender.Expression_False(1562, 8978, 9071) || f_1562_9036_9063(scriptBlockAst) != null
                        ) || (DynAbs.Tracing.TraceSender.Expression_False(1562, 8978, 9129) || f_1562_9096_9121(scriptBlockAst) != null
                        ) || (DynAbs.Tracing.TraceSender.Expression_False(1562, 8978, 9194) || f_1562_9154_9186(scriptBlockAst) != null
                        ) || (DynAbs.Tracing.TraceSender.Expression_False(1562, 8978, 9260) || f_1562_9219_9252(scriptBlockAst) != null
                        ) || (DynAbs.Tracing.TraceSender.Expression_False(1562, 8978, 9325) || f_1562_9285_9321(f_1562_9285_9315(scriptBlockAst)) > 0
                        ) || (DynAbs.Tracing.TraceSender.Expression_False(1562, 8978, 9385) || f_1562_9350_9381(f_1562_9350_9375(scriptBlockAst)) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 8974, 9459);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 9427, 9440);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 8974, 9459);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 9479, 9528);

                        NamedBlockAst
                        endBlock = f_1562_9504_9527(scriptBlockAst)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 9546, 9701) || true) && (f_1562_9550_9567_M(!endBlock.Unnamed) || (DynAbs.Tracing.TraceSender.Expression_False(1562, 9550, 9593) || f_1562_9571_9585(endBlock) != null) || (DynAbs.Tracing.TraceSender.Expression_False(1562, 9550, 9627) || f_1562_9597_9622(f_1562_9597_9616(endBlock)) != 1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 9546, 9701);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 9669, 9682);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 9546, 9701);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 9721, 9785);

                        PipelineAst
                        pipelineAst = f_1562_9747_9769(f_1562_9747_9766(endBlock), 0) as PipelineAst
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 9803, 9900) || true) && (pipelineAst == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 9803, 9900);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 9868, 9881);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 9803, 9900);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 9920, 9996);

                        HashtableAst
                        hashtableAst = f_1562_9948_9979(pipelineAst) as HashtableAst
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 10014, 10112) || true) && (hashtableAst == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 10014, 10112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 10080, 10093);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 10014, 10112);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 10304, 10362);

                        return f_1562_10311_10361(IsSafeValueVisitor.Default, hashtableAst);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 8537, 10377);

                        System.Management.Automation.Language.NamedBlockAst
                        f_1562_8978_9003(System.Management.Automation.Language.ScriptBlockAst
                        this_param)
                        {
                            var return_v = this_param.BeginBlock;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 8978, 9003);
                            return return_v;
                        }


                        System.Management.Automation.Language.NamedBlockAst
                        f_1562_9036_9063(System.Management.Automation.Language.ScriptBlockAst
                        this_param)
                        {
                            var return_v = this_param.ProcessBlock;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9036, 9063);
                            return return_v;
                        }


                        System.Management.Automation.Language.ParamBlockAst
                        f_1562_9096_9121(System.Management.Automation.Language.ScriptBlockAst
                        this_param)
                        {
                            var return_v = this_param.ParamBlock;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9096, 9121);
                            return return_v;
                        }


                        System.Management.Automation.Language.NamedBlockAst
                        f_1562_9154_9186(System.Management.Automation.Language.ScriptBlockAst
                        this_param)
                        {
                            var return_v = this_param.DynamicParamBlock;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9154, 9186);
                            return return_v;
                        }


                        System.Management.Automation.Language.ScriptRequirements
                        f_1562_9219_9252(System.Management.Automation.Language.ScriptBlockAst
                        this_param)
                        {
                            var return_v = this_param.ScriptRequirements;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9219, 9252);
                            return return_v;
                        }


                        System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.UsingStatementAst>
                        f_1562_9285_9315(System.Management.Automation.Language.ScriptBlockAst
                        this_param)
                        {
                            var return_v = this_param.UsingStatements;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9285, 9315);
                            return return_v;
                        }


                        int
                        f_1562_9285_9321(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.UsingStatementAst>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9285, 9321);
                            return return_v;
                        }


                        System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                        f_1562_9350_9375(System.Management.Automation.Language.ScriptBlockAst
                        this_param)
                        {
                            var return_v = this_param.Attributes;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9350, 9375);
                            return return_v;
                        }


                        int
                        f_1562_9350_9381(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9350, 9381);
                            return return_v;
                        }


                        System.Management.Automation.Language.NamedBlockAst
                        f_1562_9504_9527(System.Management.Automation.Language.ScriptBlockAst
                        this_param)
                        {
                            var return_v = this_param.EndBlock;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9504, 9527);
                            return return_v;
                        }


                        bool
                        f_1562_9550_9567_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9550, 9567);
                            return return_v;
                        }


                        System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TrapStatementAst>
                        f_1562_9571_9585(System.Management.Automation.Language.NamedBlockAst
                        this_param)
                        {
                            var return_v = this_param.Traps;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9571, 9585);
                            return return_v;
                        }


                        System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                        f_1562_9597_9616(System.Management.Automation.Language.NamedBlockAst
                        this_param)
                        {
                            var return_v = this_param.Statements;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9597, 9616);
                            return return_v;
                        }


                        int
                        f_1562_9597_9622(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9597, 9622);
                            return return_v;
                        }


                        System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                        f_1562_9747_9766(System.Management.Automation.Language.NamedBlockAst
                        this_param)
                        {
                            var return_v = this_param.Statements;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9747, 9766);
                            return return_v;
                        }


                        System.Management.Automation.Language.StatementAst
                        f_1562_9747_9769(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 9747, 9769);
                            return return_v;
                        }


                        System.Management.Automation.Language.ExpressionAst
                        f_1562_9948_9979(System.Management.Automation.Language.PipelineAst
                        this_param)
                        {
                            var return_v = this_param.GetPureExpression();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 9948, 9979);
                            return return_v;
                        }


                        bool
                        f_1562_10311_10361(System.Management.Automation.Language.IsSafeValueVisitor
                        this_param, System.Management.Automation.Language.HashtableAst
                        ast)
                        {
                            var return_v = this_param.IsAstSafe((System.Management.Automation.Language.Ast)ast);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 10311, 10361);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 8537, 10377);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 8537, 10377);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 6312, 10388);

                System.Management.Automation.Language.IParameterMetadataProvider
                f_1562_6394_6397()
                {
                    var return_v = Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 6394, 6397);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1562_6608_6629(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 6608, 6629);
                    return return_v;
                }


                string
                f_1562_6661_6678(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 6661, 6678);
                    return return_v;
                }


                bool
                f_1562_6738_6837(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 6738, 6837);
                    return return_v;
                }


                bool
                f_1562_6858_6893()
                {
                    var return_v = IsScriptBlockInFactASafeHashtable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 6858, 6893);
                    return return_v;
                }


                string
                f_1562_7192_7209(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 7192, 7209);
                    return return_v;
                }


                System.Management.Automation.AmsiUtils.AmsiNativeMethods.AMSI_RESULT
                f_1562_7170_7222(string
                content, string
                sourceMetadata)
                {
                    var return_v = AmsiUtils.ScanContent(content, sourceMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 7170, 7222);
                    return return_v;
                }


                string
                f_1562_7496_7541()
                {
                    var return_v = ParserStrings.ScriptContainedMaliciousContent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 7496, 7541);
                    return return_v;
                }


                System.Management.Automation.Language.ParseError
                f_1562_7368_7542(System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                message)
                {
                    var return_v = new System.Management.Automation.Language.ParseError(extent, errorId, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 7368, 7542);
                    return return_v;
                }


                System.Management.Automation.ParseException
                f_1562_7567_7607(System.Management.Automation.Language.ParseError[]
                errors)
                {
                    var return_v = new System.Management.Automation.ParseException(errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 7567, 7607);
                    return return_v;
                }


                string
                f_1562_8133_8175()
                {
                    var return_v = ParserStrings.ScriptHasAdminBlockedContent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 8133, 8175);
                    return return_v;
                }


                string
                f_1562_8115_8188(string
                formatSpec, System.Management.Automation.AmsiUtils.AmsiNativeMethods.AMSI_RESULT
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 8115, 8188);
                    return return_v;
                }


                System.Management.Automation.Language.ParseError
                f_1562_7990_8189(System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                message)
                {
                    var return_v = new System.Management.Automation.Language.ParseError(extent, errorId, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 7990, 8189);
                    return return_v;
                }


                System.Management.Automation.ParseException
                f_1562_8214_8254(System.Management.Automation.Language.ParseError[]
                errors)
                {
                    var return_v = new System.Management.Automation.ParseException(errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 8214, 8254);
                    return return_v;
                }


                string
                f_1562_8290_8340(System.Management.Automation.Language.ScriptBlockAst
                scriptBlockAst)
                {
                    var return_v = ScriptBlock.CheckSuspiciousContent((System.Management.Automation.Language.Ast)scriptBlockAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 8290, 8340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 6312, 10388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 6312, 10388);
            }
        }

        private string _scriptText;

        internal IParameterMetadataProvider Ast
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 10560, 10593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 10563, 10593);
                    return _ast ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.IParameterMetadataProvider>(1562, 10563, 10593) ?? f_1562_10571_10593(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 10560, 10593);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 10514, 10596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 10514, 10596);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private IParameterMetadataProvider _ast;

        private IParameterMetadataProvider DelayParseScriptText()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 10660, 11246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 10748, 10752);
                lock (this)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 10786, 10875) || true) && (_ast != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 10786, 10875);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 10844, 10856);

                        return _ast;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 10786, 10875);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 10895, 10915);

                    ParseError[]
                    errors
                    = default(ParseError[]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 10933, 11017);

                    _ast = f_1562_10940_11016((f_1562_10941_10953()), null, _scriptText, null, out errors, ParseMode.Default);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11035, 11151) || true) && (f_1562_11039_11052(errors) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 11035, 11151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11099, 11132);

                        throw f_1562_11105_11131(errors);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 11035, 11151);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11171, 11190);

                    _scriptText = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 11208, 11220);

                    return _ast;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 10660, 11246);

                System.Management.Automation.Language.Parser
                f_1562_10941_10953()
                {
                    var return_v = new System.Management.Automation.Language.Parser();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 10941, 10953);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_10940_11016(System.Management.Automation.Language.Parser
                this_param, string
                fileName, string
                input, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                tokenList, out System.Management.Automation.Language.ParseError[]
                errors, System.Management.Automation.Language.ParseMode
                parseMode)
                {
                    var return_v = this_param.Parse(fileName, input, tokenList, out errors, parseMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 10940, 11016);
                    return return_v;
                }


                int
                f_1562_11039_11052(System.Management.Automation.Language.ParseError[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 11039, 11052);
                    return return_v;
                }


                System.Management.Automation.ParseException
                f_1562_11105_11131(System.Management.Automation.Language.ParseError[]
                errors)
                {
                    var return_v = new System.Management.Automation.ParseException(errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 11105, 11131);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 10660, 11246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 10660, 11246);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Type LocalsMutableTupleType { get; set; }

        internal Type UnoptimizedLocalsMutableTupleType { get; set; }

        internal Func<MutableTuple> LocalsMutableTupleCreator { get; set; }

        internal Func<MutableTuple> UnoptimizedLocalsMutableTupleCreator { get; set; }

        internal Dictionary<string, int> NameToIndexMap { get; set; }

        internal Action<FunctionContext> DynamicParamBlock { get; set; }

        internal Action<FunctionContext> UnoptimizedDynamicParamBlock { get; set; }

        internal Action<FunctionContext> BeginBlock { get; set; }

        internal Action<FunctionContext> UnoptimizedBeginBlock { get; set; }

        internal Action<FunctionContext> ProcessBlock { get; set; }

        internal Action<FunctionContext> UnoptimizedProcessBlock { get; set; }

        internal Action<FunctionContext> EndBlock { get; set; }

        internal Action<FunctionContext> UnoptimizedEndBlock { get; set; }

        internal IScriptExtent[] SequencePoints { get; set; }

        private RuntimeDefinedParameterDictionary _runtimeDefinedParameterDictionary;

        private Attribute[] _attributes;

        private bool _usesCmdletBinding;

        private bool _compiledOptimized;

        private bool _compiledUnoptimized;

        private bool _hasSuspiciousContent;

        private bool? _isProductCode;

        internal bool DebuggerHidden { get; set; }

        internal bool DebuggerStepThrough { get; set; }

        internal Guid Id { get; private set; }

        internal bool HasLogged { get; set; }

        internal bool SkipLogging { get; set; }

        internal bool IsFilter { get; private set; }

        internal bool IsProductCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 12990, 13250);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 13026, 13187) || true) && (_isProductCode == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 13026, 13187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 13094, 13168);

                        _isProductCode = f_1562_13111_13167(f_1562_13143_13166(f_1562_13143_13161(((Ast)_ast))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 13026, 13187);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 13207, 13235);

                    return f_1562_13214_13234(_isProductCode);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 12990, 13250);

                    System.Management.Automation.Language.IScriptExtent
                    f_1562_13143_13161(System.Management.Automation.Language.Ast
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 13143, 13161);
                        return return_v;
                    }


                    string
                    f_1562_13143_13166(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.File;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 13143, 13166);
                        return return_v;
                    }


                    bool
                    f_1562_13111_13167(string
                    file)
                    {
                        var return_v = SecuritySupport.IsProductBinary(file);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 13111, 13167);
                        return return_v;
                    }


                    bool
                    f_1562_13214_13234(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 13214, 13234);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 12938, 13261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 12938, 13261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool GetIsConfiguration()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 13273, 13714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 13581, 13625);

                var
                scriptBlockAst = _ast as ScriptBlockAst
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 13639, 13703);

                return scriptBlockAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1562, 13646, 13702) && f_1562_13672_13702(scriptBlockAst));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 13273, 13714);

                bool
                f_1562_13672_13702(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.IsConfiguration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 13672, 13702);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 13273, 13714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 13273, 13714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasSuspiciousContent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 13785, 14056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 13821, 13994);

                    f_1562_13821_13993(_compiledOptimized || (DynAbs.Tracing.TraceSender.Expression_False(1562, 13862, 13904) || _compiledUnoptimized), "HasSuspiciousContent is not set correctly before being compiled");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 14012, 14041);

                    return _hasSuspiciousContent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 13785, 14056);

                    int
                    f_1562_13821_13993(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 13821, 13993);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 13726, 14120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 13726, 14120);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 14076, 14108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 14079, 14108);
                    _hasSuspiciousContent = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 14076, 14108);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 13726, 14120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 13726, 14120);
                }
            }
        }

        private MergedCommandParameterMetadata _parameterMetadata;

        internal List<Attribute> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 14202, 14595);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 14267, 14360) || true) && (_attributes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 14267, 14360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 14324, 14345);

                    f_1562_14324_14344(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 14267, 14360);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 14376, 14542);

                f_1562_14376_14541(_attributes != null, "after initialization, attributes is never null, must be an empty list if no attributes.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 14556, 14584);

                return f_1562_14563_14583(_attributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 14202, 14595);

                int
                f_1562_14324_14344(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    this_param.InitializeMetadata();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 14324, 14344);
                    return 0;
                }


                int
                f_1562_14376_14541(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 14376, 14541);
                    return 0;
                }


                System.Collections.Generic.List<System.Attribute>
                f_1562_14563_14583(System.Attribute[]
                source)
                {
                    var return_v = source.ToList<System.Attribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 14563, 14583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 14202, 14595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 14202, 14595);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool UsesCmdletBinding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 14663, 14875);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 14699, 14809) || true) && (_attributes != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 14699, 14809);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 14764, 14790);

                        return _usesCmdletBinding;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 14699, 14809);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 14829, 14860);

                    return f_1562_14836_14859(f_1562_14836_14839());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 14663, 14875);

                    System.Management.Automation.Language.IParameterMetadataProvider
                    f_1562_14836_14839()
                    {
                        var return_v = Ast;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 14836, 14839);
                        return return_v;
                    }


                    bool
                    f_1562_14836_14859(System.Management.Automation.Language.IParameterMetadataProvider
                    this_param)
                    {
                        var return_v = this_param.UsesCmdletBinding();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 14836, 14859);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 14607, 14886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 14607, 14886);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal RuntimeDefinedParameterDictionary RuntimeDefinedParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 14990, 15231);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 15026, 15154) || true) && (_runtimeDefinedParameterDictionary == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 15026, 15154);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 15114, 15135);

                        f_1562_15114_15134(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 15026, 15154);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 15174, 15216);

                    return _runtimeDefinedParameterDictionary;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 14990, 15231);

                    int
                    f_1562_15114_15134(System.Management.Automation.CompiledScriptBlockData
                    this_param)
                    {
                        this_param.InitializeMetadata();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 15114, 15134);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 14898, 15242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 14898, 15242);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CmdletBindingAttribute CmdletBindingAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 15333, 15700);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 15369, 15497) || true) && (_runtimeDefinedParameterDictionary == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 15369, 15497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 15457, 15478);

                        f_1562_15457_15477(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 15369, 15497);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 15517, 15685);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 15524, 15542) || ((_usesCmdletBinding
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 15566, 15656)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 15680, 15684))) ? (CmdletBindingAttribute)f_1562_15590_15656(_attributes, attr => attr is CmdletBindingAttribute) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 15333, 15700);

                    int
                    f_1562_15457_15477(System.Management.Automation.CompiledScriptBlockData
                    this_param)
                    {
                        this_param.InitializeMetadata();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 15457, 15477);
                        return 0;
                    }


                    System.Attribute
                    f_1562_15590_15656(System.Attribute[]
                    source, System.Func<System.Attribute, bool>
                    predicate)
                    {
                        var return_v = source.FirstOrDefault<System.Attribute>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 15590, 15656);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 15254, 15711);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 15254, 15711);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ObsoleteAttribute ObsoleteAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 15792, 16079);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 15828, 15956) || true) && (_runtimeDefinedParameterDictionary == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 15828, 15956);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 15916, 15937);

                        f_1562_15916_15936(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 15828, 15956);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 15976, 16064);

                    return (ObsoleteAttribute)f_1562_16002_16063(_attributes, attr => attr is ObsoleteAttribute);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 15792, 16079);

                    int
                    f_1562_15916_15936(System.Management.Automation.CompiledScriptBlockData
                    this_param)
                    {
                        this_param.InitializeMetadata();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 15916, 15936);
                        return 0;
                    }


                    System.Attribute
                    f_1562_16002_16063(System.Attribute[]
                    source, System.Func<System.Attribute, bool>
                    predicate)
                    {
                        var return_v = source.FirstOrDefault<System.Attribute>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 16002, 16063);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 15723, 16090);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 15723, 16090);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ExperimentalAttribute ExperimentalAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 16179, 16659);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 16215, 16603) || true) && (_expAttribute == ExperimentalAttribute.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 16215, 16603);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 16310, 16314);
                        lock (this)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 16364, 16561) || true) && (_expAttribute == ExperimentalAttribute.None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 16364, 16561);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 16469, 16534);

                                _expAttribute = f_1562_16485_16533(f_1562_16485_16516(f_1562_16485_16488()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 16364, 16561);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 16215, 16603);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 16623, 16644);

                    return _expAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 16179, 16659);

                    System.Management.Automation.Language.IParameterMetadataProvider
                    f_1562_16485_16488()
                    {
                        var return_v = Ast;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 16485, 16488);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Management.Automation.ExperimentalAttribute>
                    f_1562_16485_16516(System.Management.Automation.Language.IParameterMetadataProvider
                    this_param)
                    {
                        var return_v = this_param.GetExperimentalAttributes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 16485, 16516);
                        return return_v;
                    }


                    System.Management.Automation.ExperimentalAttribute
                    f_1562_16485_16533(System.Collections.Generic.IEnumerable<System.Management.Automation.ExperimentalAttribute>
                    source)
                    {
                        var return_v = source.FirstOrDefault<System.Management.Automation.ExperimentalAttribute>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 16485, 16533);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 16102, 16670);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 16102, 16670);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ExperimentalAttribute _expAttribute;

        public MergedCommandParameterMetadata GetParameterMetadata(ScriptBlock scriptBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 16767, 17474);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 16875, 17421) || true) && (_parameterMetadata == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 16875, 17421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 16945, 16949);
                    lock (this)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 16991, 17387) || true) && (_parameterMetadata == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 16991, 17387);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 17071, 17277);

                            CommandMetadata
                            metadata = f_1562_17098_17276(scriptBlock, string.Empty, f_1562_17233_17275())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 17303, 17364);

                            _parameterMetadata = f_1562_17324_17363(metadata);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 16991, 17387);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 16875, 17421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 17437, 17463);

                return _parameterMetadata;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 16767, 17474);

                System.Management.Automation.ExecutionContext
                f_1562_17233_17275()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 17233, 17275);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1562_17098_17276(System.Management.Automation.ScriptBlock
                scriptblock, string
                commandName, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandMetadata(scriptblock, commandName, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 17098, 17276);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1562_17324_17363(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.StaticCommandParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 17324, 17363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 16767, 17474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 16767, 17474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 17486, 18435);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 17544, 17635) || true) && (_scriptText != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 17544, 17635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 17601, 17620);

                    return _scriptText;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 17544, 17635);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 17651, 17772) || true) && (_ast is ScriptBlockAst sbAst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 17651, 17772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 17717, 17757);

                    return f_1562_17724_17756(sbAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 17651, 17772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 17788, 17864);

                var
                generatedMemberFunctionAst = _ast as CompilerGeneratedMemberFunctionAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 17878, 18011) || true) && (generatedMemberFunctionAst != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 17878, 18011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 17950, 17996);

                    return f_1562_17957_17995(f_1562_17957_17990(generatedMemberFunctionAst));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 17878, 18011);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 18027, 18070);

                var
                funcDefn = (FunctionDefinitionAst)_ast
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 18084, 18212) || true) && (f_1562_18088_18107(funcDefn) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 18084, 18212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 18149, 18197);

                    return f_1562_18156_18196(f_1562_18156_18169(funcDefn));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 18084, 18212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 18228, 18257);

                var
                sb = f_1562_18237_18256()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 18271, 18323);

                f_1562_18271_18322(sb, f_1562_18281_18321(funcDefn));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 18337, 18389);

                f_1562_18337_18388(sb, f_1562_18347_18387(f_1562_18347_18360(funcDefn)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 18403, 18424);

                return f_1562_18410_18423(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 17486, 18435);

                string
                f_1562_17724_17756(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ToStringForSerialization();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 17724, 17756);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1562_17957_17990(System.Management.Automation.Language.CompilerGeneratedMemberFunctionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 17957, 17990);
                    return return_v;
                }


                string
                f_1562_17957_17995(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 17957, 17995);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                f_1562_18088_18107(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 18088, 18107);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_18156_18169(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 18156, 18169);
                    return return_v;
                }


                string
                f_1562_18156_18196(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ToStringForSerialization();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 18156, 18196);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1562_18237_18256()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 18237, 18256);
                    return return_v;
                }


                string
                f_1562_18281_18321(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.GetParamTextFromParameterList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 18281, 18321);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1562_18271_18322(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 18271, 18322);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_18347_18360(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 18347, 18360);
                    return return_v;
                }


                string
                f_1562_18347_18387(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ToStringForSerialization();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 18347, 18387);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1562_18337_18388(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 18337, 18388);
                    return return_v;
                }


                string
                f_1562_18410_18423(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 18410, 18423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 17486, 18435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 17486, 18435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompiledScriptBlockData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1562, 1082, 18442);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1562, 1082, 18442);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 1082, 18442);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1562, 1082, 18442);

        System.Management.Automation.Language.IParameterMetadataProvider
        f_1562_10571_10593(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.DelayParseScriptText();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 10571, 10593);
            return return_v;
        }

    }
    [Serializable]
    public partial class ScriptBlock : ISerializable
    {
        private readonly CompiledScriptBlockData _scriptBlockData;

        internal ScriptBlock(IParameterMetadataProvider ast, bool isFilter)
            // LAFHIS : IMPROVE BASE CALLS
            //: this(f_1562_18693_18735_C(f_1562_18693_18735(ast, isFilter)))
            : this(f_1562_18693_18735(ast, isFilter))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1562, 18605, 18758);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1562, 18605, 18758);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 18605, 18758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 18605, 18758);
            }
        }

        private ScriptBlock(CompiledScriptBlockData scriptBlockData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1562, 18770, 19943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 28857, 28908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 31643, 31707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 18576, 18592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 30707, 30762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 18855, 18890);

                _scriptBlockData = scriptBlockData;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 19739, 19809);

                ExecutionContext
                context = f_1562_19766_19808()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 19823, 19932) || true) && (context != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 19823, 19932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 19876, 19917);

                    this.LanguageMode = f_1562_19896_19916(context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 19823, 19932);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1562, 18770, 19943);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 18770, 19943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 18770, 19943);
            }
        }

        protected ScriptBlock(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1562, 20063, 20156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 28857, 28908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 31643, 31707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 18576, 18592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 30707, 30762);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1562, 20063, 20156);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 20063, 20156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 20063, 20156);
            }
        }

        private static readonly ConcurrentDictionary<Tuple<string, string>, ScriptBlock> s_cachedScripts;

        internal static ScriptBlock TryGetCachedScriptBlock(string fileName, string fileContents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 20353, 21070);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 20467, 20572) || true) && (InternalTestHooks.IgnoreScriptBlockCache)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 20467, 20572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 20545, 20557);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 20467, 20572);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 20588, 20612);

                ScriptBlock
                scriptBlock
                = default(ScriptBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 20626, 20673);

                var
                key = f_1562_20636_20672(fileName, fileContents)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 20687, 21031) || true) && (f_1562_20691_20740(s_cachedScripts, key, out scriptBlock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 20687, 21031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 20774, 20971);

                    f_1562_20774_20970(f_1562_20815_20847(scriptBlock) == null, "A cached scriptblock should not have it's session state bound, that causes a memory leak.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 20989, 21016);

                    return f_1562_20996_21015(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 20687, 21031);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 21047, 21059);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 20353, 21070);

                System.Tuple<string, string>
                f_1562_20636_20672(string
                item1, string
                item2)
                {
                    var return_v = Tuple.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 20636, 20672);
                    return return_v;
                }


                bool
                f_1562_20691_20740(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<string, string>, System.Management.Automation.ScriptBlock>
                this_param, System.Tuple<string, string>
                key, out System.Management.Automation.ScriptBlock
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 20691, 20740);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_20815_20847(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 20815, 20847);
                    return return_v;
                }


                int
                f_1562_20774_20970(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 20774, 20970);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1562_20996_21015(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 20996, 21015);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 20353, 21070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 20353, 21070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsDynamicKeyword(Ast ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 21141, 21202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 21144, 21202);
                return ast is CommandAst cmdAst && (DynAbs.Tracing.TraceSender.Expression_True(1562, 21144, 21202) && f_1562_21172_21194(cmdAst) != null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 21141, 21202);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 21141, 21202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 21141, 21202);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Language.DynamicKeyword
            f_1562_21172_21194(System.Management.Automation.Language.CommandAst
            this_param)
            {
                var return_v = this_param.DefiningKeyword;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 21172, 21194);
                return return_v;
            }

        }

        private static bool IsUsingTypes(Ast ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 21270, 21348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 21273, 21348);
                return ast is UsingStatementAst cmdAst && (DynAbs.Tracing.TraceSender.Expression_True(1562, 21273, 21348) && f_1562_21308_21340(cmdAst) == true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 21270, 21348);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 21270, 21348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 21270, 21348);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_1562_21308_21340(System.Management.Automation.Language.UsingStatementAst
            this_param)
            {
                var return_v = this_param.IsUsingModuleOrAssembly();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 21308, 21340);
                return return_v;
            }

        }

        internal static void CacheScriptBlock(ScriptBlock scriptBlock, string fileName, string fileContents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 21361, 22690);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 21486, 21586) || true) && (InternalTestHooks.IgnoreScriptBlockCache)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 21486, 21586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 21564, 21571);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 21486, 21586);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 22234, 22440) || true) && (f_1562_22238_22291(f_1562_22238_22253(scriptBlock), ast => IsUsingTypes(ast), false) != null
                || (DynAbs.Tracing.TraceSender.Expression_False(1562, 22238, 22384) || f_1562_22320_22376(f_1562_22320_22335(scriptBlock), ast => IsDynamicKeyword(ast), true) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 22234, 22440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 22418, 22425);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 22234, 22440);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 22456, 22561) || true) && (f_1562_22460_22481(s_cachedScripts) > 1024)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 22456, 22561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 22522, 22546);

                    f_1562_22522_22545(s_cachedScripts);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 22456, 22561);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 22577, 22624);

                var
                key = f_1562_22587_22623(fileName, fileContents)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 22638, 22679);

                f_1562_22638_22678(s_cachedScripts, key, scriptBlock);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 21361, 22690);

                System.Management.Automation.Language.Ast
                f_1562_22238_22253(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 22238, 22253);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1562_22238_22291(System.Management.Automation.Language.Ast
                this_param, System.Func<System.Management.Automation.Language.Ast, bool>
                predicate, bool
                searchNestedScriptBlocks)
                {
                    var return_v = this_param.Find(predicate, searchNestedScriptBlocks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 22238, 22291);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1562_22320_22335(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 22320, 22335);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1562_22320_22376(System.Management.Automation.Language.Ast
                this_param, System.Func<System.Management.Automation.Language.Ast, bool>
                predicate, bool
                searchNestedScriptBlocks)
                {
                    var return_v = this_param.Find(predicate, searchNestedScriptBlocks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 22320, 22376);
                    return return_v;
                }


                int
                f_1562_22460_22481(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<string, string>, System.Management.Automation.ScriptBlock>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 22460, 22481);
                    return return_v;
                }


                int
                f_1562_22522_22545(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<string, string>, System.Management.Automation.ScriptBlock>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 22522, 22545);
                    return 0;
                }


                System.Tuple<string, string>
                f_1562_22587_22623(string
                item1, string
                item2)
                {
                    var return_v = Tuple.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 22587, 22623);
                    return return_v;
                }


                bool
                f_1562_22638_22678(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<string, string>, System.Management.Automation.ScriptBlock>
                this_param, System.Tuple<string, string>
                key, System.Management.Automation.ScriptBlock
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 22638, 22678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 21361, 22690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 21361, 22690);
            }
        }

        internal static void ClearScriptBlockCache()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 22794, 22898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 22863, 22887);

                f_1562_22863_22886(s_cachedScripts);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 22794, 22898);

                int
                f_1562_22863_22886(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<string, string>, System.Management.Automation.ScriptBlock>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 22863, 22886);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 22794, 22898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 22794, 22898);
            }
        }

        internal static ScriptBlock EmptyScriptBlock;

        internal static ScriptBlock Create(Parser parser, string fileName, string fileContents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 23058, 24022);
                System.Management.Automation.Language.ParseError[] errors = default(System.Management.Automation.Language.ParseError[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 23170, 23236);

                var
                scriptBlock = f_1562_23188_23235(fileName, fileContents)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 23250, 23341) || true) && (scriptBlock != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 23250, 23341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 23307, 23326);

                    return scriptBlock;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 23250, 23341);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 23357, 23454);

                var
                ast = f_1562_23367_23453(parser, fileName, fileContents, null, out errors, ParseMode.Default)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 23468, 23572) || true) && (f_1562_23472_23485(errors) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 23468, 23572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 23524, 23557);

                    throw f_1562_23530_23556(errors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 23468, 23572);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 23588, 23639);

                var
                result = f_1562_23601_23638(ast, isFilter: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 23653, 23702);

                f_1562_23653_23701(result, fileName, fileContents);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 23989, 24011);

                return f_1562_23996_24010(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 23058, 24022);

                System.Management.Automation.ScriptBlock
                f_1562_23188_23235(string
                fileName, string
                fileContents)
                {
                    var return_v = TryGetCachedScriptBlock(fileName, fileContents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 23188, 23235);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_23367_23453(System.Management.Automation.Language.Parser
                this_param, string
                fileName, string
                input, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                tokenList, out System.Management.Automation.Language.ParseError[]
                errors, System.Management.Automation.Language.ParseMode
                parseMode)
                {
                    var return_v = this_param.Parse(fileName, input, tokenList, out errors, parseMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 23367, 23453);
                    return return_v;
                }


                int
                f_1562_23472_23485(System.Management.Automation.Language.ParseError[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 23472, 23485);
                    return return_v;
                }


                System.Management.Automation.ParseException
                f_1562_23530_23556(System.Management.Automation.Language.ParseError[]
                errors)
                {
                    var return_v = new System.Management.Automation.ParseException(errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 23530, 23556);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1562_23601_23638(System.Management.Automation.Language.ScriptBlockAst
                ast, bool
                isFilter)
                {
                    var return_v = new System.Management.Automation.ScriptBlock((System.Management.Automation.Language.IParameterMetadataProvider)ast, isFilter: isFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 23601, 23638);
                    return return_v;
                }


                int
                f_1562_23653_23701(System.Management.Automation.ScriptBlock
                scriptBlock, string
                fileName, string
                fileContents)
                {
                    CacheScriptBlock(scriptBlock, fileName, fileContents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 23653, 23701);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1562_23996_24010(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 23996, 24010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 23058, 24022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 23058, 24022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ScriptBlock Clone()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 24063, 24099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 24066, 24099);
                return f_1562_24066_24099(_scriptBlockData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 24063, 24099);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 24063, 24099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 24063, 24099);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.ScriptBlock
            f_1562_24066_24099(System.Management.Automation.CompiledScriptBlockData
            scriptBlockData)
            {
                var return_v = new System.Management.Automation.ScriptBlock(scriptBlockData);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 24066, 24099);
                return return_v;
            }

        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 24305, 24335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 24308, 24335);
                return f_1562_24308_24335(_scriptBlockData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 24305, 24335);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 24305, 24335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 24305, 24335);
            }
            throw new System.Exception("Slicer error: unreachable code");

            string
            f_1562_24308_24335(System.Management.Automation.CompiledScriptBlockData
            this_param)
            {
                var return_v = this_param.ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 24308, 24335);
                return return_v;
            }

        }

        internal string ToStringWithDollarUsingHandling(
                    Tuple<List<VariableExpressionAst>, string> usingVariablesTuple)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 24486, 25627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 24636, 24674);

                FunctionDefinitionAst
                funcDefn = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 24688, 24722);

                var
                sbAst = f_1562_24700_24703() as ScriptBlockAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 24736, 24880) || true) && (sbAst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 24736, 24880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 24787, 24825);

                    funcDefn = (FunctionDefinitionAst)f_1562_24821_24824();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 24843, 24865);

                    sbAst = f_1562_24851_24864(funcDefn);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 24736, 24880);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 24896, 25014);

                string
                sbText = f_1562_24912_25013(sbAst, usingVariablesTuple, f_1562_24964_24988(f_1562_24964_24976(sbAst)), f_1562_24990_25012(f_1562_24990_25002(sbAst)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 25028, 25119) || true) && (f_1562_25032_25048(sbAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 25028, 25119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 25090, 25104);

                    return sbText;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 25028, 25119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 25135, 25152);

                string
                paramText
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 25166, 25221);

                string
                additionalNewParams = f_1562_25195_25220(usingVariablesTuple)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 25235, 25544) || true) && (funcDefn == null || (DynAbs.Tracing.TraceSender.Expression_False(1562, 25239, 25286) || f_1562_25259_25278(funcDefn) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 25235, 25544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 25320, 25391);

                    paramText = "param(" + additionalNewParams + ")" + f_1562_25371_25390();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 25235, 25544);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 25235, 25544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 25457, 25529);

                    paramText = f_1562_25469_25528(funcDefn, usingVariablesTuple);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 25235, 25544);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 25560, 25588);

                sbText = paramText + sbText;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 25602, 25616);

                return sbText;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 24486, 25627);

                System.Management.Automation.Language.Ast
                f_1562_24700_24703()
                {
                    var return_v = Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 24700, 24703);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1562_24821_24824()
                {
                    var return_v = Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 24821, 24824);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_24851_24864(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 24851, 24864);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1562_24964_24976(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 24964, 24976);
                    return return_v;
                }


                int
                f_1562_24964_24988(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 24964, 24988);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1562_24990_25002(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 24990, 25002);
                    return return_v;
                }


                int
                f_1562_24990_25012(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 24990, 25012);
                    return return_v;
                }


                string
                f_1562_24912_25013(System.Management.Automation.Language.ScriptBlockAst
                this_param, System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>, string>
                usingVariablesTuple, int
                initialStartOffset, int
                initialEndOffset)
                {
                    var return_v = this_param.ToStringForSerialization(usingVariablesTuple, initialStartOffset, initialEndOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 24912, 25013);
                    return return_v;
                }


                System.Management.Automation.Language.ParamBlockAst
                f_1562_25032_25048(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 25032, 25048);
                    return return_v;
                }


                string
                f_1562_25195_25220(System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>, string>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 25195, 25220);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                f_1562_25259_25278(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 25259, 25278);
                    return return_v;
                }


                string
                f_1562_25371_25390()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 25371, 25390);
                    return return_v;
                }


                string
                f_1562_25469_25528(System.Management.Automation.Language.FunctionDefinitionAst
                this_param, System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>, string>
                usingVariablesTuple)
                {
                    var return_v = this_param.GetParamTextFromParameterList(usingVariablesTuple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 25469, 25528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 24486, 25627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 24486, 25627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 25740, 26170);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 25848, 25972) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 25848, 25972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 25898, 25957);

                    throw f_1562_25904_25956(nameof(info));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 25848, 25972);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 25988, 26031);

                string
                serializedContent = f_1562_26015_26030(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 26045, 26092);

                f_1562_26045_26091(info, "ScriptText", serializedContent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 26106, 26159);

                f_1562_26106_26158(info, typeof(ScriptBlockSerializationHelper));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 25740, 26170);

                System.Management.Automation.PSArgumentNullException
                f_1562_25904_25956(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 25904, 25956);
                    return return_v;
                }


                string
                f_1562_26015_26030(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 26015, 26030);
                    return return_v;
                }


                int
                f_1562_26045_26091(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 26045, 26091);
                    return 0;
                }


                int
                f_1562_26106_26158(System.Runtime.Serialization.SerializationInfo
                this_param, System.Type
                type)
                {
                    this_param.SetType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 26106, 26158);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 25740, 26170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 25740, 26170);
            }
        }

        internal PowerShell GetPowerShellImpl(
                    ExecutionContext context,
                    Dictionary<string, object> variables,
                    bool isTrustedInput,
                    bool filterNonUsingVariables,
                    bool? createLocalScope,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 26182, 26716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 26484, 26705);

                return f_1562_26491_26704(f_1562_26491_26502(), context, variables, isTrustedInput, filterNonUsingVariables, createLocalScope, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 26182, 26716);

                System.Management.Automation.Language.IParameterMetadataProvider
                f_1562_26491_26502()
                {
                    var return_v = AstInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 26491, 26502);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1562_26491_26704(System.Management.Automation.Language.IParameterMetadataProvider
                this_param, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.Dictionary<string, object>
                variables, bool
                isTrustedInput, bool
                filterNonUsingVariables, bool?
                createLocalScope, params object[]
                args)
                {
                    var return_v = this_param.GetPowerShell(context, variables, isTrustedInput, filterNonUsingVariables, createLocalScope, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 26491, 26704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 26182, 26716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 26182, 26716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SteppablePipeline GetSteppablePipelineImpl(CommandOrigin commandOrigin, object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 26730, 27414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 26850, 26993);

                var
                pipelineAst = f_1562_26868_26992(this, resourceString => { throw PSTraceSource.NewInvalidOperationException(resourceString); })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 27007, 27094);

                f_1562_27007_27093(pipelineAst != null, "This should be checked by GetSimplePipeline");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 27110, 27307) || true) && (!(f_1562_27116_27147(f_1562_27116_27144(pipelineAst), 0) is CommandAst))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 27110, 27307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 27196, 27292);

                    throw f_1562_27202_27291(f_1562_27245_27290());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 27110, 27307);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 27323, 27403);

                return f_1562_27330_27402(pipelineAst, commandOrigin, this, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 26730, 27414);

                System.Management.Automation.Language.PipelineAst
                f_1562_26868_26992(System.Management.Automation.ScriptBlock
                this_param, System.Func<string, System.Management.Automation.Language.PipelineAst>
                errorHandler)
                {
                    var return_v = this_param.GetSimplePipeline(errorHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 26868, 26992);
                    return return_v;
                }


                int
                f_1562_27007_27093(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 27007, 27093);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1562_27116_27144(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 27116, 27144);
                    return return_v;
                }


                System.Management.Automation.Language.CommandBaseAst
                f_1562_27116_27147(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 27116, 27147);
                    return return_v;
                }


                string
                f_1562_27245_27290()
                {
                    var return_v = AutomationExceptions.CantConvertEmptyPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 27245, 27290);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1562_27202_27291(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 27202, 27291);
                    return return_v;
                }


                System.Management.Automation.SteppablePipeline
                f_1562_27330_27402(System.Management.Automation.Language.PipelineAst
                pipelineAst, System.Management.Automation.CommandOrigin
                commandOrigin, System.Management.Automation.ScriptBlock
                scriptBlock, object[]
                args)
                {
                    var return_v = PipelineOps.GetSteppablePipeline(pipelineAst, commandOrigin, scriptBlock, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 27330, 27402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 26730, 27414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 26730, 27414);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PipelineAst GetSimplePipeline(Func<string, PipelineAst> errorHandler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 27426, 28822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 27528, 27571);

                errorHandler = errorHandler ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Func<string, System.Management.Automation.Language.PipelineAst>>(1562, 27543, 27570) ?? (_ => null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 27587, 27738) || true) && (f_1562_27591_27604() || (DynAbs.Tracing.TraceSender.Expression_False(1562, 27591, 27623) || f_1562_27608_27623()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 27587, 27738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 27657, 27723);

                    return f_1562_27664_27722(errorHandler, f_1562_27677_27721());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 27587, 27738);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 27754, 27776);

                var
                ast = f_1562_27764_27775()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 27790, 27836);

                var
                statements = f_1562_27807_27835(f_1562_27807_27824(f_1562_27807_27815(ast)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 27850, 27987) || true) && (!f_1562_27855_27871(statements))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 27850, 27987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 27905, 27972);

                    return f_1562_27912_27971(errorHandler, f_1562_27925_27970());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 27850, 27987);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 28003, 28144) || true) && (f_1562_28007_28023(statements) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 28003, 28144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 28061, 28129);

                    return f_1562_28068_28128(errorHandler, f_1562_28081_28127());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 28003, 28144);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 28160, 28350) || true) && (f_1562_28164_28187(f_1562_28164_28181(f_1562_28164_28172(ast))) != null && (DynAbs.Tracing.TraceSender.Expression_True(1562, 28164, 28228) && f_1562_28199_28228(f_1562_28199_28222(f_1562_28199_28216(f_1562_28199_28207(ast))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 28160, 28350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 28262, 28335);

                    return f_1562_28269_28334(errorHandler, f_1562_28282_28333());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 28160, 28350);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 28366, 28409);

                var
                pipeAst = f_1562_28380_28393(statements, 0) as PipelineAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 28423, 28559) || true) && (pipeAst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 28423, 28559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 28476, 28544);

                    return f_1562_28483_28543(errorHandler, f_1562_28496_28542());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 28423, 28559);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 28796, 28811);

                return pipeAst;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 27426, 28822);

                bool
                f_1562_27591_27604()
                {
                    var return_v = HasBeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 27591, 27604);
                    return return_v;
                }


                bool
                f_1562_27608_27623()
                {
                    var return_v = HasProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 27608, 27623);
                    return return_v;
                }


                string
                f_1562_27677_27721()
                {
                    var return_v = AutomationExceptions.CanConvertOneClauseOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 27677, 27721);
                    return return_v;
                }


                System.Management.Automation.Language.PipelineAst
                f_1562_27664_27722(System.Func<string, System.Management.Automation.Language.PipelineAst>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 27664, 27722);
                    return return_v;
                }


                System.Management.Automation.Language.IParameterMetadataProvider
                f_1562_27764_27775()
                {
                    var return_v = AstInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 27764, 27775);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_27807_27815(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 27807, 27815);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1562_27807_27824(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 27807, 27824);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                f_1562_27807_27835(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 27807, 27835);
                    return return_v;
                }


                bool
                f_1562_27855_27871(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.Language.StatementAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 27855, 27871);
                    return return_v;
                }


                string
                f_1562_27925_27970()
                {
                    var return_v = AutomationExceptions.CantConvertEmptyPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 27925, 27970);
                    return return_v;
                }


                System.Management.Automation.Language.PipelineAst
                f_1562_27912_27971(System.Func<string, System.Management.Automation.Language.PipelineAst>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 27912, 27971);
                    return return_v;
                }


                int
                f_1562_28007_28023(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28007, 28023);
                    return return_v;
                }


                string
                f_1562_28081_28127()
                {
                    var return_v = AutomationExceptions.CanOnlyConvertOnePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28081, 28127);
                    return return_v;
                }


                System.Management.Automation.Language.PipelineAst
                f_1562_28068_28128(System.Func<string, System.Management.Automation.Language.PipelineAst>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 28068, 28128);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_28164_28172(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28164, 28172);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1562_28164_28181(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28164, 28181);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TrapStatementAst>
                f_1562_28164_28187(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Traps;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28164, 28187);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_28199_28207(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28199, 28207);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1562_28199_28216(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28199, 28216);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TrapStatementAst>
                f_1562_28199_28222(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Traps;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28199, 28222);
                    return return_v;
                }


                bool
                f_1562_28199_28228(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TrapStatementAst>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.Language.TrapStatementAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 28199, 28228);
                    return return_v;
                }


                string
                f_1562_28282_28333()
                {
                    var return_v = AutomationExceptions.CantConvertScriptBlockWithTrap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28282, 28333);
                    return return_v;
                }


                System.Management.Automation.Language.PipelineAst
                f_1562_28269_28334(System.Func<string, System.Management.Automation.Language.PipelineAst>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 28269, 28334);
                    return return_v;
                }


                System.Management.Automation.Language.StatementAst
                f_1562_28380_28393(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28380, 28393);
                    return return_v;
                }


                string
                f_1562_28496_28542()
                {
                    var return_v = AutomationExceptions.CanOnlyConvertOnePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28496, 28542);
                    return return_v;
                }


                System.Management.Automation.Language.PipelineAst
                f_1562_28483_28543(System.Func<string, System.Management.Automation.Language.PipelineAst>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 28483, 28543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 27426, 28822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 27426, 28822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<Attribute> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 28875, 28910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 28878, 28910);
                return f_1562_28878_28910(_scriptBlockData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 28875, 28910);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 28875, 28910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 28875, 28910);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.List<System.Attribute>
            f_1562_28878_28910(System.Management.Automation.CompiledScriptBlockData
            this_param)
            {
                var return_v = this_param.GetAttributes();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 28878, 28910);
                return return_v;
            }

        }

        internal string GetFileName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 28953, 28984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 28956, 28984);
                return f_1562_28956_28984(f_1562_28956_28979(f_1562_28956_28972(f_1562_28956_28967())));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 28953, 28984);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 28953, 28984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 28953, 28984);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Language.IParameterMetadataProvider
            f_1562_28956_28967()
            {
                var return_v = AstInternal;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28956, 28967);
                return return_v;
            }


            System.Management.Automation.Language.ScriptBlockAst
            f_1562_28956_28972(System.Management.Automation.Language.IParameterMetadataProvider
            this_param)
            {
                var return_v = this_param.Body;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28956, 28972);
                return return_v;
            }


            System.Management.Automation.Language.IScriptExtent
            f_1562_28956_28979(System.Management.Automation.Language.ScriptBlockAst
            this_param)
            {
                var return_v = this_param.Extent;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28956, 28979);
                return return_v;
            }


            string
            f_1562_28956_28984(System.Management.Automation.Language.IScriptExtent
            this_param)
            {
                var return_v = this_param.File;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 28956, 28984);
                return return_v;
            }

        }

        internal bool IsMetaConfiguration()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 29091, 29163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 29094, 29163);
                return f_1562_29094_29163(f_1562_29094_29157(f_1562_29094_29109(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 29091, 29163);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 29091, 29163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 29091, 29163);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.List<System.Attribute>
            f_1562_29094_29109(System.Management.Automation.ScriptBlock
            this_param)
            {
                var return_v = this_param.GetAttributes();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 29094, 29109);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<System.Management.Automation.DscLocalConfigurationManagerAttribute>
            f_1562_29094_29157(System.Collections.Generic.List<System.Attribute>
            source)
            {
                var return_v = source.OfType<System.Management.Automation.DscLocalConfigurationManagerAttribute>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 29094, 29157);
                return return_v;
            }


            bool
            f_1562_29094_29163(System.Collections.Generic.IEnumerable<System.Management.Automation.DscLocalConfigurationManagerAttribute>
            source)
            {
                var return_v = source.Any<System.Management.Automation.DscLocalConfigurationManagerAttribute>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 29094, 29163);
                return return_v;
            }

        }

        internal PSToken GetStartPosition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 29212, 29238);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 29215, 29238);
                return f_1562_29215_29238(f_1562_29227_29237(f_1562_29227_29230()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 29212, 29238);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 29212, 29238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 29212, 29238);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Language.Ast
            f_1562_29227_29230()
            {
                var return_v = Ast;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 29227, 29230);
                return return_v;
            }


            System.Management.Automation.Language.IScriptExtent
            f_1562_29227_29237(System.Management.Automation.Language.Ast
            this_param)
            {
                var return_v = this_param.Extent;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 29227, 29237);
                return return_v;
            }


            System.Management.Automation.PSToken
            f_1562_29215_29238(System.Management.Automation.Language.IScriptExtent
            extent)
            {
                var return_v = new System.Management.Automation.PSToken(extent);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 29215, 29238);
                return return_v;
            }

        }

        internal MergedCommandParameterMetadata ParameterMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 29337, 29383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 29340, 29383);
                    return f_1562_29340_29383(_scriptBlockData, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 29337, 29383);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 29251, 29395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 29251, 29395);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool UsesCmdletBinding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 29445, 29482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 29448, 29482);
                    return f_1562_29448_29482(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 29445, 29482);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 29407, 29485);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 29407, 29485);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasDynamicParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 29538, 29583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 29541, 29583);
                    return f_1562_29541_29575(f_1562_29541_29557(f_1562_29541_29552())) != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 29538, 29583);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 29497, 29586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 29497, 29586);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool DebuggerHidden
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 29729, 29763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 29732, 29763);
                    return f_1562_29732_29763(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 29729, 29763);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 29674, 29836);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 29674, 29836);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 29782, 29824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 29785, 29824);
                    _scriptBlockData.DebuggerHidden = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 29782, 29824);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 29674, 29836);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 29674, 29836);
                }
            }
        }

        public Guid Id
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 29965, 29987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 29968, 29987);
                    return f_1562_29968_29987(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 29965, 29987);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 29944, 29990);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 29944, 29990);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool DebuggerStepThrough
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 30060, 30112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 30066, 30110);

                    return f_1562_30073_30109(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 30060, 30112);

                    bool
                    f_1562_30073_30109(System.Management.Automation.CompiledScriptBlockData
                    this_param)
                    {
                        var return_v = this_param.DebuggerStepThrough;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 30073, 30109);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 30002, 30192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 30002, 30192);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 30128, 30181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 30134, 30179);

                    _scriptBlockData.DebuggerStepThrough = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 30128, 30181);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 30002, 30192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 30002, 30192);
                }
            }
        }

        internal RuntimeDefinedParameterDictionary RuntimeDefinedParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 30300, 30344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 30303, 30344);
                    return f_1562_30303_30344(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 30300, 30344);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 30204, 30356);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 30204, 30356);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasLogged
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 30420, 30449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 30423, 30449);
                    return f_1562_30423_30449(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 30420, 30449);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 30368, 30517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 30368, 30517);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 30468, 30505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 30471, 30505);
                    _scriptBlockData.HasLogged = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 30468, 30505);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 30368, 30517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 30368, 30517);
                }
            }
        }

        internal bool SkipLogging
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 30579, 30623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 30585, 30621);

                    return f_1562_30592_30620(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 30579, 30623);

                    bool
                    f_1562_30592_30620(System.Management.Automation.CompiledScriptBlockData
                    this_param)
                    {
                        var return_v = this_param.SkipLogging;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 30592, 30620);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 30529, 30695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 30529, 30695);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 30639, 30684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 30645, 30682);

                    _scriptBlockData.SkipLogging = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 30639, 30684);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 30529, 30695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 30529, 30695);
                }
            }
        }

        internal Assembly AssemblyDefiningPSTypes { set; get; }

        internal HelpInfo GetHelpInfo(
                    ExecutionContext context,
                    CommandInfo commandInfo,
                    bool dontSearchOnRemoteComputer,
                    Dictionary<Ast, Token[]> scriptBlockTokenCache,
                    out string helpFile,
                    out string helpUriFromDotLink)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 30774, 31709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 31091, 31117);

                helpUriFromDotLink = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 31133, 31229);

                var
                commentTokens = f_1562_31153_31228(f_1562_31193_31204(), scriptBlockTokenCache)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 31243, 31640) || true) && (commentTokens != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 31243, 31640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 31302, 31625);

                    return f_1562_31309_31624(context, commandInfo, f_1562_31433_31452(commentTokens), f_1562_31475_31494(commentTokens), dontSearchOnRemoteComputer, out helpFile, out helpUriFromDotLink);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 31243, 31640);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 31656, 31672);

                helpFile = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 31686, 31698);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 30774, 31709);

                System.Management.Automation.Language.IParameterMetadataProvider
                f_1562_31193_31204()
                {
                    var return_v = AstInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 31193, 31204);
                    return return_v;
                }


                System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.Token>, System.Collections.Generic.List<string>>
                f_1562_31153_31228(System.Management.Automation.Language.IParameterMetadataProvider
                ipmp, System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>
                scriptBlockTokenCache)
                {
                    var return_v = HelpCommentsParser.GetHelpCommentTokens(ipmp, scriptBlockTokenCache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 31153, 31228);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1562_31433_31452(System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.Token>, System.Collections.Generic.List<string>>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 31433, 31452);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1562_31475_31494(System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.Token>, System.Collections.Generic.List<string>>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 31475, 31494);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1562_31309_31624(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.CommandInfo
                commandInfo, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                comments, System.Collections.Generic.List<string>
                parameterDescriptions, bool
                dontSearchOnRemoteComputer, out string
                helpFile, out string
                helpUriFromDotLink)
                {
                    var return_v = HelpCommentsParser.CreateFromComments(context, commandInfo, comments, parameterDescriptions, dontSearchOnRemoteComputer, out helpFile, out helpUriFromDotLink);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 31309, 31624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 30774, 31709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 30774, 31709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void CheckRestrictedLanguage(
                    IEnumerable<string> allowedCommands,
                    IEnumerable<string> allowedVariables,
                    bool allowEnvironmentVariables)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 32389, 33753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 32596, 32625);

                Parser
                parser = f_1562_32612_32624()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 32641, 32663);

                var
                ast = f_1562_32651_32662()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 32677, 33101) || true) && (f_1562_32681_32694() || (DynAbs.Tracing.TraceSender.Expression_False(1562, 32681, 32713) || f_1562_32698_32713()) || (DynAbs.Tracing.TraceSender.Expression_False(1562, 32681, 32744) || f_1562_32717_32736(f_1562_32717_32725(ast)) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 32677, 33101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 32778, 32866);

                    Ast
                    errorAst = f_1562_32793_32812(f_1562_32793_32801(ast)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.NamedBlockAst>(1562, 32793, 32865) ?? (Ast)f_1562_32821_32842(f_1562_32821_32829(ast)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.Ast>(1562, 32816, 32865) ?? f_1562_32846_32865(f_1562_32846_32854(ast))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 32884, 33086);

                    f_1562_32884_33085(parser, f_1562_32925_32940(errorAst), nameof(ParserStrings.InvalidScriptBlockInDataSection), f_1562_33039_33084());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 32677, 33101);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 33117, 33598) || true) && (f_1562_33121_33132())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 33117, 33598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 33166, 33361);

                    var
                    rlc = f_1562_33176_33360(parser, allowedCommands, allowedVariables, allowEnvironmentVariables)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 33381, 33583);

                    f_1562_33381_33582(rlc, f_1562_33461_33484(f_1562_33461_33478(f_1562_33461_33469(ast))), f_1562_33507_33535(f_1562_33507_33524(f_1562_33507_33515(ast))), AstVisitAction.Continue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 33117, 33598);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 33614, 33742) || true) && (f_1562_33618_33640(f_1562_33618_33634(parser)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 33614, 33742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 33674, 33727);

                    throw f_1562_33680_33726(f_1562_33699_33725(f_1562_33699_33715(parser)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 33614, 33742);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 32389, 33753);

                System.Management.Automation.Language.Parser
                f_1562_32612_32624()
                {
                    var return_v = new System.Management.Automation.Language.Parser();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 32612, 32624);
                    return return_v;
                }


                System.Management.Automation.Language.IParameterMetadataProvider
                f_1562_32651_32662()
                {
                    var return_v = AstInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 32651, 32662);
                    return return_v;
                }


                bool
                f_1562_32681_32694()
                {
                    var return_v = HasBeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 32681, 32694);
                    return return_v;
                }


                bool
                f_1562_32698_32713()
                {
                    var return_v = HasProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 32698, 32713);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_32717_32725(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 32717, 32725);
                    return return_v;
                }


                System.Management.Automation.Language.ParamBlockAst
                f_1562_32717_32736(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 32717, 32736);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_32793_32801(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 32793, 32801);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1562_32793_32812(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.BeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 32793, 32812);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_32821_32829(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 32821, 32829);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1562_32821_32842(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 32821, 32842);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_32846_32854(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 32846, 32854);
                    return return_v;
                }


                System.Management.Automation.Language.ParamBlockAst
                f_1562_32846_32865(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 32846, 32865);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1562_32925_32940(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 32925, 32940);
                    return return_v;
                }


                string
                f_1562_33039_33084()
                {
                    var return_v = ParserStrings.InvalidScriptBlockInDataSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 33039, 33084);
                    return return_v;
                }


                int
                f_1562_32884_33085(System.Management.Automation.Language.Parser
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportError(extent, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 32884, 33085);
                    return 0;
                }


                bool
                f_1562_33121_33132()
                {
                    var return_v = HasEndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 33121, 33132);
                    return return_v;
                }


                System.Management.Automation.Language.RestrictedLanguageChecker
                f_1562_33176_33360(System.Management.Automation.Language.Parser
                parser, System.Collections.Generic.IEnumerable<string>
                allowedCommands, System.Collections.Generic.IEnumerable<string>
                allowedVariables, bool
                allowEnvironmentVariables)
                {
                    var return_v = new System.Management.Automation.Language.RestrictedLanguageChecker(parser, allowedCommands, allowedVariables, allowEnvironmentVariables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 33176, 33360);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_33461_33469(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 33461, 33469);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1562_33461_33478(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 33461, 33478);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TrapStatementAst>
                f_1562_33461_33484(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Traps;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 33461, 33484);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1562_33507_33515(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 33507, 33515);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1562_33507_33524(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 33507, 33524);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                f_1562_33507_33535(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 33507, 33535);
                    return return_v;
                }


                System.Management.Automation.Language.AstVisitAction
                f_1562_33381_33582(System.Management.Automation.Language.RestrictedLanguageChecker
                visitor, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TrapStatementAst>
                traps, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                statements, System.Management.Automation.Language.AstVisitAction
                action)
                {
                    var return_v = StatementBlockAst.InternalVisit((System.Management.Automation.Language.AstVisitor)visitor, traps, statements, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 33381, 33582);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
                f_1562_33618_33634(System.Management.Automation.Language.Parser
                this_param)
                {
                    var return_v = this_param.ErrorList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 33618, 33634);
                    return return_v;
                }


                bool
                f_1562_33618_33640(System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.Language.ParseError>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 33618, 33640);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
                f_1562_33699_33715(System.Management.Automation.Language.Parser
                this_param)
                {
                    var return_v = this_param.ErrorList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 33699, 33715);
                    return return_v;
                }


                System.Management.Automation.Language.ParseError[]
                f_1562_33699_33725(System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 33699, 33725);
                    return return_v;
                }


                System.Management.Automation.ParseException
                f_1562_33680_33726(System.Management.Automation.Language.ParseError[]
                errors)
                {
                    var return_v = new System.Management.Automation.ParseException(errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 33680, 33726);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 32389, 33753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 32389, 33753);
            }
        }

        internal string GetWithInputHandlingForInvokeCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 33820, 33873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 33823, 33873);
                return f_1562_33823_33873(f_1562_33823_33834());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 33820, 33873);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 33820, 33873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 33820, 33873);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Language.IParameterMetadataProvider
            f_1562_33823_33834()
            {
                var return_v = AstInternal;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 33823, 33834);
                return return_v;
            }


            string
            f_1562_33823_33873(System.Management.Automation.Language.IParameterMetadataProvider
            this_param)
            {
                var return_v = this_param.GetWithInputHandlingForInvokeCommand();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 33823, 33873);
                return return_v;
            }

        }

        internal string GetWithInputHandlingForInvokeCommandWithUsingExpression(
                    Tuple<List<VariableExpressionAst>, string> usingVariablesTuple)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 33886, 34372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 34060, 34197);

                Tuple<string, string>
                result =
                f_1562_34108_34196(f_1562_34108_34119(), usingVariablesTuple)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 34288, 34361);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 34295, 34315) || ((f_1562_34295_34307(result) == null && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 34318, 34330)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 34333, 34360))) ? f_1562_34318_34330(result) : f_1562_34333_34345(result) + f_1562_34348_34360(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 33886, 34372);

                System.Management.Automation.Language.IParameterMetadataProvider
                f_1562_34108_34119()
                {
                    var return_v = AstInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 34108, 34119);
                    return return_v;
                }


                System.Tuple<string, string>
                f_1562_34108_34196(System.Management.Automation.Language.IParameterMetadataProvider
                this_param, System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>, string>
                usingVariablesTuple)
                {
                    var return_v = this_param.GetWithInputHandlingForInvokeCommandWithUsingExpression(usingVariablesTuple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 34108, 34196);
                    return return_v;
                }


                string
                f_1562_34295_34307(System.Tuple<string, string>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 34295, 34307);
                    return return_v;
                }


                string
                f_1562_34318_34330(System.Tuple<string, string>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 34318, 34330);
                    return return_v;
                }


                string
                f_1562_34333_34345(System.Tuple<string, string>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 34333, 34345);
                    return return_v;
                }


                string
                f_1562_34348_34360(System.Tuple<string, string>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 34348, 34360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 33886, 34372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 33886, 34372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsUsingDollarInput()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 34419, 34462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 34422, 34462);
                return f_1562_34422_34462(f_1562_34453_34461(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 34419, 34462);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 34419, 34462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 34419, 34462);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Language.Ast
            f_1562_34453_34461(System.Management.Automation.ScriptBlock
            this_param)
            {
                var return_v = this_param.Ast;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 34453, 34461);
                return return_v;
            }


            bool
            f_1562_34422_34462(System.Management.Automation.Language.Ast
            ast)
            {
                var return_v = AstSearcher.IsUsingDollarInput(ast);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 34422, 34462);
                return return_v;
            }

        }

        internal void InvokeWithPipeImpl(
                    bool createLocalScope,
                    Dictionary<string, ScriptBlock> functionsToDefine,
                    List<PSVariable> variablesToDefine,
                    ErrorHandlingBehavior errorHandlingBehavior,
                    object dollarUnder,
                    object input,
                    object scriptThis,
                    Pipe outputPipe,
                    InvocationInfo invocationInfo,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 34475, 35348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 34941, 35337);

                f_1562_34941_35336(this, ScriptBlockClauseToInvoke.ProcessBlockOnly, createLocalScope, functionsToDefine, variablesToDefine, errorHandlingBehavior, dollarUnder, input, scriptThis, outputPipe, invocationInfo, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 34475, 35348);

                int
                f_1562_34941_35336(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.ScriptBlockClauseToInvoke
                clauseToInvoke, bool
                createLocalScope, System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                functionsToDefine, System.Collections.Generic.List<System.Management.Automation.PSVariable>
                variablesToDefine, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, object
                dollarUnder, object
                input, object
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, params object[]
                args)
                {
                    this_param.InvokeWithPipeImpl(clauseToInvoke, createLocalScope, functionsToDefine, variablesToDefine, errorHandlingBehavior, dollarUnder, input, scriptThis, outputPipe, invocationInfo, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 34941, 35336);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 34475, 35348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 34475, 35348);
            }
        }

        internal void InvokeWithPipeImpl(
                    ScriptBlockClauseToInvoke clauseToInvoke,
                    bool createLocalScope,
                    Dictionary<string, ScriptBlock> functionsToDefine,
                    List<PSVariable> variablesToDefine,
                    ErrorHandlingBehavior errorHandlingBehavior,
                    object dollarUnder,
                    object input,
                    object scriptThis,
                    Pipe outputPipe,
                    InvocationInfo invocationInfo,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 35360, 48542);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 35881, 36190) || true) && ((clauseToInvoke == ScriptBlockClauseToInvoke.Begin && (DynAbs.Tracing.TraceSender.Expression_True(1562, 35886, 35953) && f_1562_35939_35953_M(!HasBeginBlock)))
                || (DynAbs.Tracing.TraceSender.Expression_False(1562, 35885, 36048) || (clauseToInvoke == ScriptBlockClauseToInvoke.Process && (DynAbs.Tracing.TraceSender.Expression_True(1562, 35976, 36047) && f_1562_36031_36047_M(!HasProcessBlock)))
                ) || (DynAbs.Tracing.TraceSender.Expression_False(1562, 35885, 36134) || (clauseToInvoke == ScriptBlockClauseToInvoke.End && (DynAbs.Tracing.TraceSender.Expression_True(1562, 36070, 36133) && f_1562_36121_36133_M(!HasEndBlock)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 35881, 36190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 36168, 36175);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 35881, 36190);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 36206, 36253);

                ExecutionContext
                context = f_1562_36233_36252(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 36267, 36497);

                f_1562_36267_36496(f_1562_36304_36324() == null || (DynAbs.Tracing.TraceSender.Expression_False(1562, 36304, 36384) || f_1562_36336_36373(f_1562_36336_36356()) == context), "The scriptblock is being invoked in a runspace different than the one where it was created");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 36513, 36634) || true) && (f_1562_36517_36548(context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 36513, 36634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 36582, 36619);

                    throw f_1562_36588_36618();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 36513, 36634);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 36787, 37013);

                f_1562_36787_37012(createLocalScope == true || (DynAbs.Tracing.TraceSender.Expression_False(1562, 36824, 36877) || functionsToDefine == null), "When calling ScriptBlock.InvokeWithContext(), if 'functionsToDefine' != null then 'createLocalScope' must be true");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 37027, 37253);

                f_1562_37027_37252(createLocalScope == true || (DynAbs.Tracing.TraceSender.Expression_False(1562, 37064, 37117) || variablesToDefine == null), "When calling ScriptBlock.InvokeWithContext(), if 'variablesToDefine' != null then 'createLocalScope' must be true");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 37269, 37363) || true) && (args == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 37269, 37363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 37319, 37348);

                    args = f_1562_37326_37347();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 37269, 37363);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 37379, 37453);

                bool
                runOptimized = (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 37399, 37425) || ((context._debuggingMode > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 37428, 37433)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 37436, 37452))) ? false : createLocalScope
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 37467, 37536);

                var
                codeToInvoke = f_1562_37486_37535(this, ref runOptimized, clauseToInvoke)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 37550, 37630) || true) && (codeToInvoke == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 37550, 37630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 37608, 37615);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 37550, 37630);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 37646, 37848) || true) && (outputPipe == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 37646, 37848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 37791, 37833);

                    outputPipe = new Pipe { NullPipe = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1562, 37804, 37832) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 37646, 37848);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 37864, 37907);

                var
                locals = f_1562_37877_37906(this, runOptimized)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 37923, 38089) || true) && (dollarUnder != f_1562_37942_37962())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 37923, 38089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 37996, 38074);

                    f_1562_37996_38073(locals, AutomaticVariable.Underbar, dollarUnder, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 37923, 38089);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 38105, 38256) || true) && (input != f_1562_38118_38138())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 38105, 38256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 38172, 38241);

                    f_1562_38172_38240(locals, AutomaticVariable.Input, input, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 38105, 38256);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 38272, 38432) || true) && (scriptThis != f_1562_38290_38310())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 38272, 38432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 38344, 38417);

                    f_1562_38344_38416(locals, AutomaticVariable.This, scriptThis, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 38272, 38432);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 38448, 38497);

                f_1562_38448_38496(this, locals, context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 38513, 38588);

                var
                oldShellFunctionErrorOutputPipe = f_1562_38551_38587(context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 38602, 38659);

                var
                oldExternalErrorOutput = f_1562_38631_38658(context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 38673, 38746);

                var
                oldScopeOrigin = f_1562_38694_38745(f_1562_38694_38733(f_1562_38694_38720(context)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 38760, 38809);

                var
                oldSessionState = f_1562_38782_38808(context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 38951, 38990);

                PSLanguageMode?
                oldLanguageMode = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 39004, 39043);

                PSLanguageMode?
                newLanguageMode = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 39057, 39752) || true) && (f_1562_39061_39087(f_1562_39061_39078(this)) && (DynAbs.Tracing.TraceSender.Expression_True(1562, 39061, 39149) && f_1562_39108_39125(this) != f_1562_39129_39149(context)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 39057, 39752);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 39383, 39737) || true) && (f_1562_39387_39404(this) != PSLanguageMode.FullLanguage
                    || (DynAbs.Tracing.TraceSender.Expression_False(1562, 39387, 39476) || createLocalScope
                    ) || (DynAbs.Tracing.TraceSender.Expression_False(1562, 39387, 39579) || f_1562_39501_39548_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1562_39501_39534(f_1562_39501_39527(context)), 1562, 39501, 39548)?.LanguageMode) == PSLanguageMode.FullLanguage))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 39383, 39737);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 39621, 39660);

                        oldLanguageMode = f_1562_39639_39659(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 39682, 39718);

                        newLanguageMode = f_1562_39700_39717(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 39383, 39737);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 39057, 39752);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 39768, 39824);

                Dictionary<string, PSVariable>
                backupWhenDotting = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 39874, 39912);

                    var
                    myInvocationInfo = invocationInfo
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 39930, 40334) || true) && (myInvocationInfo == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 39930, 40334);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 40000, 40066);

                        var
                        callerFrame = f_1562_40018_40065(f_1562_40018_40049(f_1562_40018_40034(context)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 40088, 40232);

                        var
                        extent = (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 40101, 40122) || (((callerFrame != null)
                        && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 40150, 40193)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 40221, 40231))) ? f_1562_40150_40193(f_1562_40150_40177(callerFrame)) : f_1562_40221_40231(f_1562_40221_40224())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 40254, 40315);

                        myInvocationInfo = f_1562_40273_40314(null, extent, context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 39930, 40334);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 40354, 40441);

                    f_1562_40354_40440(
                                    locals, AutomaticVariable.MyInvocation, myInvocationInfo, context);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 40461, 40604) || true) && (f_1562_40465_40485() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 40461, 40604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 40535, 40585);

                        context.EngineSessionState = f_1562_40564_40584();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 40461, 40604);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 40698, 41350);

                    switch (errorHandlingBehavior)
                    {

                        case ErrorHandlingBehavior.WriteToCurrentErrorPipe:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 40698, 41350);
                            DynAbs.Tracing.TraceSender.TraceBreak(1562, 40897, 40903);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 40698, 41350);

                        case ErrorHandlingBehavior.WriteToExternalErrorPipe:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 40698, 41350);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 41003, 41047);

                            context.ShellFunctionErrorOutputPipe = null;
                            DynAbs.Tracing.TraceSender.TraceBreak(1562, 41073, 41079);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 40698, 41350);

                        case ErrorHandlingBehavior.SwallowErrors:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 40698, 41350);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 41168, 41212);

                            context.ShellFunctionErrorOutputPipe = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 41238, 41299);

                            context.ExternalErrorOutput = f_1562_41268_41298();
                            DynAbs.Tracing.TraceSender.TraceBreak(1562, 41325, 41331);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 40698, 41350);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 41370, 45094) || true) && (createLocalScope)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 41370, 45094);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 41432, 41490);

                        var
                        newScope = f_1562_41447_41489(f_1562_41447_41473(context), false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 41512, 41563);

                        f_1562_41512_41538(context).CurrentScope = newScope;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 41585, 41615);

                        newScope.LocalsTuple = locals;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 41703, 42970) || true) && (functionsToDefine != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 41703, 42970);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 41782, 42947);
                                foreach (var def in f_1562_41802_41819_I(functionsToDefine))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 41782, 42947);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 41877, 42330) || true) && (f_1562_41881_41915(def.Key))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 41877, 42330);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 41981, 42157);

                                        PSInvalidOperationException
                                        e = f_1562_42013_42156(f_1562_42094_42155())
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 42193, 42257);

                                        f_1562_42193_42256(
                                                                        e, "EmptyFunctionNameInFunctionDefinitionDictionary");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 42291, 42299);

                                        throw e;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 41877, 42330);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 42362, 42805) || true) && (def.Value == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 42362, 42805);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 42449, 42633);

                                        PSInvalidOperationException
                                        e = f_1562_42481_42632(f_1562_42562_42622(), def.Key)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 42669, 42732);

                                        f_1562_42669_42731(
                                                                        e, "NullFunctionBodyInFunctionDefinitionDictionary");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 42766, 42774);

                                        throw e;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 42362, 42805);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 42837, 42920);

                                    f_1562_42837_42919(f_1562_42837_42859(newScope), def.Key, f_1562_42873_42918(def.Key, def.Value, context));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 41782, 42947);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1562, 1, 1166);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1562, 1, 1166);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 41703, 42970);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 43058, 44341) || true) && (variablesToDefine != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 43058, 44341);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 43137, 43151);

                            int
                            index = 0
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 43177, 44318);
                                foreach (var psvar in f_1562_43199_43216_I(variablesToDefine))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 43177, 44318);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 43330, 43743) || true) && (psvar == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 43330, 43743);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 43413, 43583);

                                        PSInvalidOperationException
                                        e = f_1562_43445_43582(f_1562_43526_43574(), index)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 43619, 43670);

                                        f_1562_43619_43669(
                                                                        e, "NullEntryInVariablesDefinitionList");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 43704, 43712);

                                        throw e;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 43330, 43743);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 43775, 43800);

                                    string
                                    name = f_1562_43789_43799(psvar)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 43830, 44187);

                                    f_1562_43830_44186(!(f_1562_43885_43912(name, "this") || (DynAbs.Tracing.TraceSender.Expression_False(1562, 43885, 43940) || f_1562_43916_43940(name, "_")) || (DynAbs.Tracing.TraceSender.Expression_False(1562, 43885, 43972) || f_1562_43944_43972(name, "input"))), "The list of variables to set in the scriptblock's scope cannot contain 'this', '_' or 'input'. These variables should be removed before passing the collection to this routine.");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 44217, 44225);

                                    index++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 44255, 44291);

                                    f_1562_44255_44290(f_1562_44255_44273(newScope), name, psvar);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 43177, 44318);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1562, 1, 1142);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1562, 1, 1142);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 43058, 44341);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 41370, 45094);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 41370, 45094);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 44423, 45075) || true) && (f_1562_44427_44478(f_1562_44427_44466(f_1562_44427_44453(context))) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 44423, 45075);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 44744, 44805);

                            f_1562_44744_44783(f_1562_44744_44770(context)).LocalsTuple = locals;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 44423, 45075);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 44423, 45075);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 44903, 44969);

                            f_1562_44903_44968(f_1562_44903_44955(f_1562_44903_44942(f_1562_44903_44929(context))), locals);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 44995, 45052);

                            backupWhenDotting = f_1562_45015_45051();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 44423, 45075);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 41370, 45094);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 45156, 45290) || true) && (f_1562_45160_45184(newLanguageMode))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 45156, 45290);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 45226, 45271);

                        context.LanguageMode = f_1562_45249_45270(newLanguageMode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 45156, 45290);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 45310, 45597);

                    args = f_1562_45317_45596(f_1562_45400_45429(f_1562_45400_45424()), args, context, !createLocalScope, backupWhenDotting, locals);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 45615, 45682);

                    f_1562_45615_45681(locals, AutomaticVariable.Args, args, context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 45702, 45779);

                    f_1562_45702_45741(f_1562_45702_45728(context)).ScopeOrigin = CommandOrigin.Internal;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 45799, 46287);

                    var
                    functionContext = new FunctionContext
                    {
                        _executionContext = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => context, 1562, 45821, 46286),
                        _outputPipe = outputPipe,
                        _localsTuple = locals,
                        _scriptBlock = this,
                        _file = f_1562_46072_46081(this),
                        _debuggerHidden = f_1562_46122_46141(this),
                        _debuggerStepThrough = f_1562_46187_46211(this),
                        _sequencePoints = f_1562_46252_46266()
                    }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 46307, 46381);

                    f_1562_46307_46380(this, f_1562_46345_46379(f_1562_46345_46368(context)));

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 46445, 46475);

                        f_1562_46445_46474(codeToInvoke, functionContext);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1562, 46512, 46651);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 46560, 46632);

                        f_1562_46560_46631(this, f_1562_46596_46630(f_1562_46596_46619(context)));
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1562, 46512, 46651);
                    }
                }
                catch (TargetInvocationException tie)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1562, 46680, 46854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 46814, 46839);

                    throw f_1562_46820_46838(tie);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1562, 46680, 46854);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1562, 46868, 48531);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 46954, 47088) || true) && (f_1562_46958_46982(oldLanguageMode))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 46954, 47088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 47024, 47069);

                        context.LanguageMode = f_1562_47047_47068(oldLanguageMode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 46954, 47088);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 47159, 47230);

                    context.ShellFunctionErrorOutputPipe = oldShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 47248, 47301);

                    context.ExternalErrorOutput = oldExternalErrorOutput;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 47382, 47451);

                    f_1562_47382_47421(f_1562_47382_47408(context)).ScopeOrigin = oldScopeOrigin;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 47471, 48406) || true) && (createLocalScope)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 47471, 48406);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 47533, 47613);

                        f_1562_47533_47612(f_1562_47533_47559(context), f_1562_47572_47611(f_1562_47572_47598(context)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 47471, 48406);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 47471, 48406);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 47655, 48406) || true) && (backupWhenDotting != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 47655, 48406);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 47726, 47785);

                            f_1562_47726_47784(f_1562_47726_47778(f_1562_47726_47765(f_1562_47726_47752(context))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 47809, 47899);

                            f_1562_47809_47898(backupWhenDotting != null, "when dotting, this dictionary isn't null");
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 47921, 48387);
                                foreach (var pair in f_1562_47942_47959_I(backupWhenDotting))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 47921, 48387);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 48009, 48364) || true) && (pair.Value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 48009, 48364);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 48089, 48171);

                                        f_1562_48089_48170(f_1562_48089_48115(context), pair.Value, false, CommandOrigin.Internal);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 48009, 48364);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 48009, 48364);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 48285, 48337);

                                        f_1562_48285_48336(f_1562_48285_48311(context), pair.Key);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 48009, 48364);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 47921, 48387);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1562, 1, 467);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1562, 1, 467);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 47655, 48406);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 47471, 48406);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 48471, 48516);

                    context.EngineSessionState = oldSessionState;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1562, 46868, 48531);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 35360, 48542);

                bool
                f_1562_35939_35953_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 35939, 35953);
                    return return_v;
                }


                bool
                f_1562_36031_36047_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 36031, 36047);
                    return return_v;
                }


                bool
                f_1562_36121_36133_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 36121, 36133);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_36233_36252(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.GetContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 36233, 36252);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_36304_36324()
                {
                    var return_v = SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 36304, 36324);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_36336_36356()
                {
                    var return_v = SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 36336, 36356);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_36336_36373(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 36336, 36373);
                    return return_v;
                }


                int
                f_1562_36267_36496(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 36267, 36496);
                    return 0;
                }


                bool
                f_1562_36517_36548(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 36517, 36548);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1562_36588_36618()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 36588, 36618);
                    return return_v;
                }


                int
                f_1562_36787_37012(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 36787, 37012);
                    return 0;
                }


                int
                f_1562_37027_37252(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 37027, 37252);
                    return 0;
                }


                object[]
                f_1562_37326_37347()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 37326, 37347);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_37486_37535(System.Management.Automation.ScriptBlock
                this_param, ref bool
                optimized, System.Management.Automation.ScriptBlockClauseToInvoke
                clauseToInvoke)
                {
                    var return_v = this_param.GetCodeToInvoke(ref optimized, clauseToInvoke);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 37486, 37535);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1562_37877_37906(System.Management.Automation.ScriptBlock
                this_param, bool
                createLocalScope)
                {
                    var return_v = this_param.MakeLocalsTuple(createLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 37877, 37906);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1562_37942_37962()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 37942, 37962);
                    return return_v;
                }


                int
                f_1562_37996_38073(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 37996, 38073);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1562_38118_38138()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 38118, 38138);
                    return return_v;
                }


                int
                f_1562_38172_38240(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 38172, 38240);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1562_38290_38310()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 38290, 38310);
                    return return_v;
                }


                int
                f_1562_38344_38416(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 38344, 38416);
                    return 0;
                }


                int
                f_1562_38448_38496(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.MutableTuple
                locals, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetPSScriptRootAndPSCommandPath(locals, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 38448, 38496);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1562_38551_38587(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 38551, 38587);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineWriter
                f_1562_38631_38658(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExternalErrorOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 38631, 38658);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_38694_38720(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 38694, 38720);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1562_38694_38733(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 38694, 38733);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1562_38694_38745(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScopeOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 38694, 38745);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_38782_38808(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 38782, 38808);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1562_39061_39078(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 39061, 39078);
                    return return_v;
                }


                bool
                f_1562_39061_39087(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 39061, 39087);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1562_39108_39125(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 39108, 39125);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1562_39129_39149(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 39129, 39149);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1562_39387_39404(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 39387, 39404);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_39501_39527(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 39501, 39527);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1562_39501_39534(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 39501, 39534);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1562_39501_39548_M(System.Management.Automation.PSLanguageMode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 39501, 39548);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1562_39639_39659(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 39639, 39659);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1562_39700_39717(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 39700, 39717);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1562_40018_40034(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 40018, 40034);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CallStackFrame>
                f_1562_40018_40049(System.Management.Automation.ScriptDebugger
                this_param)
                {
                    var return_v = this_param.GetCallStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 40018, 40049);
                    return return_v;
                }


                System.Management.Automation.CallStackFrame
                f_1562_40018_40065(System.Collections.Generic.IEnumerable<System.Management.Automation.CallStackFrame>
                source)
                {
                    var return_v = source.LastOrDefault<System.Management.Automation.CallStackFrame>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 40018, 40065);
                    return return_v;
                }


                System.Management.Automation.Language.FunctionContext
                f_1562_40150_40177(System.Management.Automation.CallStackFrame
                this_param)
                {
                    var return_v = this_param.FunctionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 40150, 40177);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1562_40150_40193(System.Management.Automation.Language.FunctionContext
                this_param)
                {
                    var return_v = this_param.CurrentPosition
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 40150, 40193);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1562_40221_40224()
                {
                    var return_v = Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 40221, 40224);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1562_40221_40231(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 40221, 40231);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1562_40273_40314(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 40273, 40314);
                    return return_v;
                }


                int
                f_1562_40354_40440(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, System.Management.Automation.InvocationInfo
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, (object)value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 40354, 40440);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_40465_40485()
                {
                    var return_v = SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 40465, 40485);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_40564_40584()
                {
                    var return_v = SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 40564, 40584);
                    return return_v;
                }


                System.Management.Automation.Runspaces.DiscardingPipelineWriter
                f_1562_41268_41298()
                {
                    var return_v = new System.Management.Automation.Runspaces.DiscardingPipelineWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 41268, 41298);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_41447_41473(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 41447, 41473);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1562_41447_41489(System.Management.Automation.SessionStateInternal
                this_param, bool
                isScriptScope)
                {
                    var return_v = this_param.NewScope(isScriptScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 41447, 41489);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_41512_41538(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 41512, 41538);
                    return return_v;
                }


                bool
                f_1562_41881_41915(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 41881, 41915);
                    return return_v;
                }


                string
                f_1562_42094_42155()
                {
                    var return_v = ParserStrings.EmptyFunctionNameInFunctionDefinitionDictionary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 42094, 42155);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1562_42013_42156(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 42013, 42156);
                    return return_v;
                }


                int
                f_1562_42193_42256(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 42193, 42256);
                    return 0;
                }


                string
                f_1562_42562_42622()
                {
                    var return_v = ParserStrings.NullFunctionBodyInFunctionDefinitionDictionary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 42562, 42622);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1562_42481_42632(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 42481, 42632);
                    return return_v;
                }


                int
                f_1562_42669_42731(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 42669, 42731);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                f_1562_42837_42859(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.FunctionTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 42837, 42859);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1562_42873_42918(string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.FunctionInfo(name, function, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 42873, 42918);
                    return return_v;
                }


                int
                f_1562_42837_42919(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                this_param, string
                key, System.Management.Automation.FunctionInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 42837, 42919);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                f_1562_41802_41819_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 41802, 41819);
                    return return_v;
                }


                string
                f_1562_43526_43574()
                {
                    var return_v = ParserStrings.NullEntryInVariablesDefinitionList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 43526, 43574);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1562_43445_43582(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 43445, 43582);
                    return return_v;
                }


                int
                f_1562_43619_43669(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 43619, 43669);
                    return 0;
                }


                string
                f_1562_43789_43799(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 43789, 43799);
                    return return_v;
                }


                bool
                f_1562_43885_43912(string
                a, string
                b)
                {
                    var return_v = string.Equals(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 43885, 43912);
                    return return_v;
                }


                bool
                f_1562_43916_43940(string
                a, string
                b)
                {
                    var return_v = string.Equals(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 43916, 43940);
                    return return_v;
                }


                bool
                f_1562_43944_43972(string
                a, string
                b)
                {
                    var return_v = string.Equals(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 43944, 43972);
                    return return_v;
                }


                int
                f_1562_43830_44186(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 43830, 44186);
                    return 0;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.PSVariable>
                f_1562_44255_44273(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 44255, 44273);
                    return return_v;
                }


                int
                f_1562_44255_44290(System.Collections.Generic.IDictionary<string, System.Management.Automation.PSVariable>
                this_param, string
                key, System.Management.Automation.PSVariable
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 44255, 44290);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSVariable>
                f_1562_43199_43216_I(System.Collections.Generic.List<System.Management.Automation.PSVariable>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 43199, 43216);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_44427_44453(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 44427, 44453);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1562_44427_44466(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 44427, 44466);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1562_44427_44478(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.LocalsTuple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 44427, 44478);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_44744_44770(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 44744, 44770);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1562_44744_44783(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 44744, 44783);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_44903_44929(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 44903, 44929);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1562_44903_44942(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 44903, 44942);
                    return return_v;
                }


                System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                f_1562_44903_44955(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.DottedScopes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 44903, 44955);
                    return return_v;
                }


                int
                f_1562_44903_44968(System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                this_param, System.Management.Automation.MutableTuple
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 44903, 44968);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                f_1562_45015_45051()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 45015, 45051);
                    return return_v;
                }


                bool
                f_1562_45160_45184(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 45160, 45184);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1562_45249_45270(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 45249, 45270);
                    return return_v;
                }


                System.Management.Automation.RuntimeDefinedParameterDictionary
                f_1562_45400_45424()
                {
                    var return_v = RuntimeDefinedParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 45400, 45424);
                    return return_v;
                }


                object
                f_1562_45400_45429(System.Management.Automation.RuntimeDefinedParameterDictionary
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 45400, 45429);
                    return return_v;
                }


                object[]
                f_1562_45317_45596(object
                parameters, object[]
                args, System.Management.Automation.ExecutionContext
                context, bool
                dotting, System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                backupWhenDotting, System.Management.Automation.MutableTuple
                locals)
                {
                    var return_v = BindArgumentsForScriptblockInvoke((System.Management.Automation.RuntimeDefinedParameter[])parameters, args, context, dotting, backupWhenDotting, locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 45317, 45596);
                    return return_v;
                }


                int
                f_1562_45615_45681(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object[]
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, (object)value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 45615, 45681);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_45702_45728(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 45702, 45728);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1562_45702_45741(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 45702, 45741);
                    return return_v;
                }


                string
                f_1562_46072_46081(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 46072, 46081);
                    return return_v;
                }


                bool
                f_1562_46122_46141(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.DebuggerHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 46122, 46141);
                    return return_v;
                }


                bool
                f_1562_46187_46211(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.DebuggerStepThrough;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 46187, 46211);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent[]
                f_1562_46252_46266()
                {
                    var return_v = SequencePoints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 46252, 46266);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1562_46345_46368(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 46345, 46368);
                    return return_v;
                }


                System.Guid
                f_1562_46345_46379(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 46345, 46379);
                    return return_v;
                }


                int
                f_1562_46307_46380(System.Management.Automation.ScriptBlock
                scriptBlock, System.Guid
                runspaceId)
                {
                    ScriptBlock.LogScriptBlockStart(scriptBlock, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 46307, 46380);
                    return 0;
                }


                int
                f_1562_46445_46474(System.Action<System.Management.Automation.Language.FunctionContext>
                this_param, System.Management.Automation.Language.FunctionContext
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 46445, 46474);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1562_46596_46619(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 46596, 46619);
                    return return_v;
                }


                System.Guid
                f_1562_46596_46630(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 46596, 46630);
                    return return_v;
                }


                int
                f_1562_46560_46631(System.Management.Automation.ScriptBlock
                scriptBlock, System.Guid
                runspaceId)
                {
                    ScriptBlock.LogScriptBlockEnd(scriptBlock, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 46560, 46631);
                    return 0;
                }


                System.Exception
                f_1562_46820_46838(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 46820, 46838);
                    return return_v;
                }


                bool
                f_1562_46958_46982(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 46958, 46982);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1562_47047_47068(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 47047, 47068);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_47382_47408(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 47382, 47408);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1562_47382_47421(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 47382, 47421);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_47533_47559(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 47533, 47559);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_47572_47598(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 47572, 47598);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1562_47572_47611(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 47572, 47611);
                    return return_v;
                }


                int
                f_1562_47533_47612(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.SessionStateScope
                scope)
                {
                    this_param.RemoveScope(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 47533, 47612);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_47726_47752(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 47726, 47752);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1562_47726_47765(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 47726, 47765);
                    return return_v;
                }


                System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                f_1562_47726_47778(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.DottedScopes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 47726, 47778);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1562_47726_47784(System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 47726, 47784);
                    return return_v;
                }


                int
                f_1562_47809_47898(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 47809, 47898);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_48089_48115(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 48089, 48115);
                    return return_v;
                }


                object
                f_1562_48089_48170(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.PSVariable
                variable, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(variable, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 48089, 48170);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_48285_48311(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 48285, 48311);
                    return return_v;
                }


                int
                f_1562_48285_48336(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    this_param.RemoveVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 48285, 48336);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                f_1562_47942_47959_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 47942, 47959);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 35360, 48542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 35360, 48542);
            }
        }

        internal MutableTuple MakeLocalsTuple(bool createLocalScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 48554, 49419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 48639, 48659);

                MutableTuple
                locals
                = default(MutableTuple);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 48673, 49378) || true) && (createLocalScope)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 48673, 49378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 48727, 48941);

                    locals = f_1562_48736_48940(f_1562_48781_48820(_scriptBlockData), f_1562_48843_48874(_scriptBlockData), f_1562_48897_48939(_scriptBlockData));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 48673, 49378);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 48673, 49378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 49007, 49363);

                    locals = f_1562_49016_49362(f_1562_49061_49111(_scriptBlockData), (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 49134, 49151) || ((f_1562_49134_49151() && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 49179, 49224)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 49252, 49285))) ? Compiler.DottedScriptCmdletLocalsNameIndexMap
                    : Compiler.DottedLocalsNameIndexMap, f_1562_49308_49361(_scriptBlockData));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 48673, 49378);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 49394, 49408);

                return locals;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 48554, 49419);

                System.Type
                f_1562_48781_48820(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.LocalsMutableTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 48781, 48820);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, int>
                f_1562_48843_48874(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.NameToIndexMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 48843, 48874);
                    return return_v;
                }


                System.Func<System.Management.Automation.MutableTuple>
                f_1562_48897_48939(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.LocalsMutableTupleCreator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 48897, 48939);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1562_48736_48940(System.Type
                tupleType, System.Collections.Generic.Dictionary<string, int>
                nameToIndexMap, System.Func<System.Management.Automation.MutableTuple>
                creator)
                {
                    var return_v = MutableTuple.MakeTuple(tupleType, nameToIndexMap, creator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 48736, 48940);
                    return return_v;
                }


                System.Type
                f_1562_49061_49111(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.UnoptimizedLocalsMutableTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 49061, 49111);
                    return return_v;
                }


                bool
                f_1562_49134_49151()
                {
                    var return_v = UsesCmdletBinding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 49134, 49151);
                    return return_v;
                }


                System.Func<System.Management.Automation.MutableTuple>
                f_1562_49308_49361(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.UnoptimizedLocalsMutableTupleCreator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 49308, 49361);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1562_49016_49362(System.Type
                tupleType, System.Collections.Generic.Dictionary<string, int>
                nameToIndexMap, System.Func<System.Management.Automation.MutableTuple>
                creator)
                {
                    var return_v = MutableTuple.MakeTuple(tupleType, nameToIndexMap, creator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 49016, 49362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 48554, 49419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 48554, 49419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object[] BindArgumentsForScriptblockInvoke(
                    RuntimeDefinedParameter[] parameters,
                    object[] args,
                    ExecutionContext context,
                    bool dotting,
                    Dictionary<string, PSVariable> backupWhenDotting,
                    MutableTuple locals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 49431, 52382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 49757, 49807);

                var
                boundParameters = f_1562_49779_49806()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 49823, 49910) || true) && (f_1562_49827_49844(parameters) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 49823, 49910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 49883, 49895);

                    return args;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 49823, 49910);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 49935, 49940);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 49926, 51833) || true) && (i < f_1562_49946_49963(parameters))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 49965, 49968)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 49926, 51833))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 49926, 51833);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 50002, 50032);

                        var
                        parameter = parameters[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 50050, 50069);

                        object
                        valueToBind
                        = default(object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 50087, 50113);

                        bool
                        wasDefaulted = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 50131, 50753) || true) && (i >= f_1562_50140_50151(args))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 50131, 50753);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 50193, 50223);

                            valueToBind = f_1562_50207_50222(parameter);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 50245, 50586) || true) && (valueToBind is Compiler.DefaultValueExpressionWrapper)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 50245, 50586);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 50471, 50563);

                                valueToBind = f_1562_50485_50562(((Compiler.DefaultValueExpressionWrapper)valueToBind), context, null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 50245, 50586);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 50610, 50630);

                            wasDefaulted = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 50131, 50753);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 50131, 50753);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 50712, 50734);

                            valueToBind = args[i];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 50131, 50753);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 50773, 50795);

                        bool
                        valueSet = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 50813, 51191) || true) && (dotting && (DynAbs.Tracing.TraceSender.Expression_True(1562, 50817, 50853) && backupWhenDotting != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 50813, 51191);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 50895, 51027);

                            backupWhenDotting[f_1562_50913_50927(parameter)] =
                            f_1562_50956_51026(f_1562_50956_50982(context), f_1562_51002_51016(parameter), "local");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 50813, 51191);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 50813, 51191);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 51109, 51172);

                            valueSet = f_1562_51120_51171(locals, f_1562_51143_51157(parameter), valueToBind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 50813, 51191);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 51211, 51593) || true) && (!valueSet)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 51211, 51593);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 51266, 51472);

                            var
                            variable = f_1562_51281_51471(f_1562_51322_51336(parameter), valueToBind, ScopedItemOptions.None, f_1562_51450_51470(parameter))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 51494, 51574);

                            f_1562_51494_51573(f_1562_51494_51520(context), variable, false, CommandOrigin.Internal);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 51211, 51593);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 51613, 51818) || true) && (!wasDefaulted)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 51613, 51818);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 51672, 51721);

                            f_1562_51672_51720(boundParameters, f_1562_51692_51706(parameter), valueToBind);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 51743, 51799);

                            f_1562_51743_51798(boundParameters, f_1562_51783_51797(parameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 51613, 51818);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1562, 1, 1908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1562, 1, 1908);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 51849, 52028);

                f_1562_51849_52027(
                            locals, AutomaticVariable.PSBoundParameters, f_1562_51949_52000(boundParameters), context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 52044, 52095);

                var
                leftOverArgs = f_1562_52063_52074(args) - f_1562_52077_52094(parameters)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 52109, 52208) || true) && (leftOverArgs <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 52109, 52208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 52164, 52193);

                    return f_1562_52171_52192();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 52109, 52208);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 52224, 52267);

                object[]
                result = new object[leftOverArgs]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 52281, 52343);

                f_1562_52281_52342(args, f_1562_52298_52315(parameters), result, 0, f_1562_52328_52341(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 52357, 52371);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 49431, 52382);

                System.Management.Automation.CommandLineParameters
                f_1562_49779_49806()
                {
                    var return_v = new System.Management.Automation.CommandLineParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 49779, 49806);
                    return return_v;
                }


                int
                f_1562_49827_49844(System.Management.Automation.RuntimeDefinedParameter[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 49827, 49844);
                    return return_v;
                }


                int
                f_1562_49946_49963(System.Management.Automation.RuntimeDefinedParameter[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 49946, 49963);
                    return return_v;
                }


                int
                f_1562_50140_50151(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 50140, 50151);
                    return return_v;
                }


                object
                f_1562_50207_50222(System.Management.Automation.RuntimeDefinedParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 50207, 50222);
                    return return_v;
                }


                object
                f_1562_50485_50562(System.Management.Automation.Language.Compiler.DefaultValueExpressionWrapper
                this_param, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionStateInternal
                sessionStateInternal)
                {
                    var return_v = this_param.GetValue(context, sessionStateInternal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 50485, 50562);
                    return return_v;
                }


                string
                f_1562_50913_50927(System.Management.Automation.RuntimeDefinedParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 50913, 50927);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_50956_50982(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 50956, 50982);
                    return return_v;
                }


                string
                f_1562_51002_51016(System.Management.Automation.RuntimeDefinedParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 51002, 51016);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1562_50956_51026(System.Management.Automation.SessionStateInternal
                this_param, string
                name, string
                scopeID)
                {
                    var return_v = this_param.GetVariableAtScope(name, scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 50956, 51026);
                    return return_v;
                }


                string
                f_1562_51143_51157(System.Management.Automation.RuntimeDefinedParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 51143, 51157);
                    return return_v;
                }


                bool
                f_1562_51120_51171(System.Management.Automation.MutableTuple
                this_param, string
                name, object
                value)
                {
                    var return_v = this_param.TrySetParameter(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 51120, 51171);
                    return return_v;
                }


                string
                f_1562_51322_51336(System.Management.Automation.RuntimeDefinedParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 51322, 51336);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1562_51450_51470(System.Management.Automation.RuntimeDefinedParameter
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 51450, 51470);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1562_51281_51471(string
                name, object
                value, System.Management.Automation.ScopedItemOptions
                options, System.Collections.ObjectModel.Collection<System.Attribute>
                attributes)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, value, options, attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 51281, 51471);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1562_51494_51520(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 51494, 51520);
                    return return_v;
                }


                object
                f_1562_51494_51573(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.PSVariable
                variable, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(variable, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 51494, 51573);
                    return return_v;
                }


                string
                f_1562_51692_51706(System.Management.Automation.RuntimeDefinedParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 51692, 51706);
                    return return_v;
                }


                int
                f_1562_51672_51720(System.Management.Automation.CommandLineParameters
                this_param, string
                name, object
                value)
                {
                    this_param.Add(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 51672, 51720);
                    return 0;
                }


                string
                f_1562_51783_51797(System.Management.Automation.RuntimeDefinedParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 51783, 51797);
                    return return_v;
                }


                int
                f_1562_51743_51798(System.Management.Automation.CommandLineParameters
                this_param, string
                name)
                {
                    this_param.MarkAsBoundPositionally(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 51743, 51798);
                    return 0;
                }


                object
                f_1562_51949_52000(System.Management.Automation.CommandLineParameters
                this_param)
                {
                    var return_v = this_param.GetValueToBindToPSBoundParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 51949, 52000);
                    return return_v;
                }


                int
                f_1562_51849_52027(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 51849, 52027);
                    return 0;
                }


                int
                f_1562_52063_52074(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 52063, 52074);
                    return return_v;
                }


                int
                f_1562_52077_52094(System.Management.Automation.RuntimeDefinedParameter[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 52077, 52094);
                    return return_v;
                }


                object[]
                f_1562_52171_52192()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 52171, 52192);
                    return return_v;
                }


                int
                f_1562_52298_52315(System.Management.Automation.RuntimeDefinedParameter[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 52298, 52315);
                    return return_v;
                }


                int
                f_1562_52328_52341(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 52328, 52341);
                    return return_v;
                }


                int
                f_1562_52281_52342(object[]
                sourceArray, int
                sourceIndex, object[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 52281, 52342);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 49431, 52382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 49431, 52382);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void SetAutomaticVariable(AutomaticVariable variable, object value, MutableTuple locals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 52512, 52552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 52515, 52552);
                f_1562_52515_52552(locals, variable, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 52512, 52552);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 52512, 52552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 52512, 52552);
            }

            int
            f_1562_52515_52552(System.Management.Automation.MutableTuple
            this_param, System.Management.Automation.AutomaticVariable
            index, object
            value)
            {
                this_param.SetValue((int)index, value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 52515, 52552);
                return 0;
            }

        }

        private Action<FunctionContext> GetCodeToInvoke(ref bool optimized, ScriptBlockClauseToInvoke clauseToInvoke)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 52565, 54292);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 52699, 52988) || true) && (clauseToInvoke == ScriptBlockClauseToInvoke.ProcessBlockOnly
                && (DynAbs.Tracing.TraceSender.Expression_True(1562, 52703, 52835) && (f_1562_52785_52798() || (DynAbs.Tracing.TraceSender.Expression_False(1562, 52785, 52834) || (f_1562_52803_52814() && (DynAbs.Tracing.TraceSender.Expression_True(1562, 52803, 52833) && f_1562_52818_52833()))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 52699, 52988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 52869, 52973);

                    throw f_1562_52875_52972(f_1562_52918_52971());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 52699, 52988);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 53004, 53052);

                optimized = f_1562_53016_53051(_scriptBlockData, optimized);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 53068, 53690) || true) && (optimized)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 53068, 53690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 53115, 53675);

                    switch (clauseToInvoke)
                    {

                        case ScriptBlockClauseToInvoke.Begin:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 53115, 53675);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 53242, 53277);

                            return f_1562_53249_53276(_scriptBlockData);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 53115, 53675);

                        case ScriptBlockClauseToInvoke.Process:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 53115, 53675);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 53364, 53401);

                            return f_1562_53371_53400(_scriptBlockData);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 53115, 53675);

                        case ScriptBlockClauseToInvoke.End:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 53115, 53675);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 53484, 53517);

                            return f_1562_53491_53516(_scriptBlockData);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 53115, 53675);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 53115, 53675);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 53573, 53656);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 53580, 53595) || ((f_1562_53580_53595() && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 53598, 53627)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 53630, 53655))) ? f_1562_53598_53627(_scriptBlockData) : f_1562_53630_53655(_scriptBlockData);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 53115, 53675);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 53068, 53690);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 53706, 54281);

                switch (clauseToInvoke)
                {

                    case ScriptBlockClauseToInvoke.Begin:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 53706, 54281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 53821, 53867);

                        return f_1562_53828_53866(_scriptBlockData);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 53706, 54281);

                    case ScriptBlockClauseToInvoke.Process:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 53706, 54281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 53946, 53994);

                        return f_1562_53953_53993(_scriptBlockData);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 53706, 54281);

                    case ScriptBlockClauseToInvoke.End:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 53706, 54281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 54069, 54113);

                        return f_1562_54076_54112(_scriptBlockData);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 53706, 54281);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 53706, 54281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 54161, 54266);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 54168, 54183) || ((f_1562_54168_54183() && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 54186, 54226)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 54229, 54265))) ? f_1562_54186_54226(_scriptBlockData) : f_1562_54229_54265(_scriptBlockData);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 53706, 54281);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 52565, 54292);

                bool
                f_1562_52785_52798()
                {
                    var return_v = HasBeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 52785, 52798);
                    return return_v;
                }


                bool
                f_1562_52803_52814()
                {
                    var return_v = HasEndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 52803, 52814);
                    return return_v;
                }


                bool
                f_1562_52818_52833()
                {
                    var return_v = HasProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 52818, 52833);
                    return return_v;
                }


                string
                f_1562_52918_52971()
                {
                    var return_v = AutomationExceptions.ScriptBlockInvokeOnOneClauseOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 52918, 52971);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1562_52875_52972(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 52875, 52972);
                    return return_v;
                }


                bool
                f_1562_53016_53051(System.Management.Automation.CompiledScriptBlockData
                this_param, bool
                optimized)
                {
                    var return_v = this_param.Compile(optimized);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 53016, 53051);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_53249_53276(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.BeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 53249, 53276);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_53371_53400(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.ProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 53371, 53400);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_53491_53516(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 53491, 53516);
                    return return_v;
                }


                bool
                f_1562_53580_53595()
                {
                    var return_v = HasProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 53580, 53595);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_53598_53627(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.ProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 53598, 53627);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_53630_53655(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 53630, 53655);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_53828_53866(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.UnoptimizedBeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 53828, 53866);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_53953_53993(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.UnoptimizedProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 53953, 53993);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_54076_54112(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.UnoptimizedEndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 54076, 54112);
                    return return_v;
                }


                bool
                f_1562_54168_54183()
                {
                    var return_v = HasProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 54168, 54183);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_54186_54226(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.UnoptimizedProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 54186, 54226);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_54229_54265(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.UnoptimizedEndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 54229, 54265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 52565, 54292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 52565, 54292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CmdletBindingAttribute CmdletBindingAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 54365, 54407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 54368, 54407);
                    return f_1562_54368_54407(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 54365, 54407);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 54304, 54410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 54304, 54410);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ObsoleteAttribute ObsoleteAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 54473, 54510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 54476, 54510);
                    return f_1562_54476_54510(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 54473, 54510);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 54422, 54513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 54422, 54513);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ExperimentalAttribute ExperimentalAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 54584, 54625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 54587, 54625);
                    return f_1562_54587_54625(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 54584, 54625);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 54525, 54628);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 54525, 54628);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool Compile(bool optimized)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 54678, 54716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 54681, 54716);
                return f_1562_54681_54716(_scriptBlockData, optimized);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 54678, 54716);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 54678, 54716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 54678, 54716);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_1562_54681_54716(System.Management.Automation.CompiledScriptBlockData
            this_param, bool
            optimized)
            {
                var return_v = this_param.Compile(optimized);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 54681, 54716);
                return return_v;
            }

        }

        internal static void LogScriptBlockCreation(ScriptBlock scriptBlock, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 54729, 57415);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 54834, 55071) || true) && (f_1562_54838_54859(scriptBlock) && (DynAbs.Tracing.TraceSender.Expression_True(1562, 54838, 54905) && !InternalTestHooks.ForceScriptBlockLogging))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 54834, 55071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 55049, 55056);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 54834, 55071);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 55087, 55150);

                ScriptBlockLogging
                logSetting = f_1562_55119_55149()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 55164, 57404) || true) && (force || (DynAbs.Tracing.TraceSender.Expression_False(1562, 55168, 55221) || f_1562_55177_55213_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(logSetting, 1562, 55177, 55213)?.EnableScriptBlockLogging) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 55164, 57404);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 55398, 55634) || true) && (f_1562_55402_55438_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(logSetting, 1562, 55402, 55438)?.EnableScriptBlockLogging) == false
                    || (DynAbs.Tracing.TraceSender.Expression_False(1562, 55402, 55513) || f_1562_55472_55513(f_1562_55472_55499(scriptBlock))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 55398, 55634);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 55555, 55586);

                        scriptBlock.SkipLogging = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 55608, 55615);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 55398, 55634);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 55654, 55707);

                    string
                    scriptBlockText = f_1562_55679_55706(f_1562_55679_55701(f_1562_55679_55694(scriptBlock)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 55725, 55746);

                    bool
                    written = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 55885, 57171) || true) && (f_1562_55889_55911(scriptBlockText) < 20000)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 55885, 57171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 55961, 56041);

                        written = f_1562_55971_56040(scriptBlock, 0, 1, f_1562_56012_56039(f_1562_56012_56034(f_1562_56012_56027(scriptBlock))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 55885, 57171);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 55885, 57171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 56389, 56442);

                        int
                        segmentSize = 10000 + f_1562_56415_56441((f_1562_56416_56428()), 10000)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 56464, 56547);

                        int
                        segments = (int)f_1562_56484_56542((f_1562_56504_56526(scriptBlockText) / segmentSize)) + 1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 56569, 56593);

                        int
                        currentLocation = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 56615, 56642);

                        int
                        currentSegmentSize = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 56675, 56686);

                            for (int
        segment = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 56666, 57152) || true) && (segment < segments)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 56708, 56717)
        , segment++, DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 56666, 57152))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 56666, 57152);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 56767, 56807);

                                currentLocation = segment * segmentSize;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 56833, 56918);

                                currentSegmentSize = f_1562_56854_56917(segmentSize, f_1562_56876_56898(scriptBlockText) - currentLocation);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 56946, 57028);

                                string
                                textToLog = f_1562_56965_57027(scriptBlockText, currentLocation, currentSegmentSize)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 57054, 57129);

                                written = f_1562_57064_57128(scriptBlock, segment, segments, textToLog);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1562, 1, 487);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1562, 1, 487);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 55885, 57171);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 57191, 57292) || true) && (written)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 57191, 57292);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 57244, 57273);

                        scriptBlock.HasLogged = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 57191, 57292);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 55164, 57404);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 55164, 57404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 57358, 57389);

                    scriptBlock.SkipLogging = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 55164, 57404);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 54729, 57415);

                bool
                f_1562_54838_54859(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.HasLogged;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 54838, 54859);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_1562_55119_55149()
                {
                    var return_v = GetScriptBlockLoggingSetting();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 55119, 55149);
                    return return_v;
                }


                bool?
                f_1562_55177_55213_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 55177, 55213);
                    return return_v;
                }


                bool?
                f_1562_55402_55438_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 55402, 55438);
                    return return_v;
                }


                System.Management.Automation.CompiledScriptBlockData
                f_1562_55472_55499(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ScriptBlockData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 55472, 55499);
                    return return_v;
                }


                bool
                f_1562_55472_55513(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.IsProductCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 55472, 55513);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1562_55679_55694(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 55679, 55694);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1562_55679_55701(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 55679, 55701);
                    return return_v;
                }


                string
                f_1562_55679_55706(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 55679, 55706);
                    return return_v;
                }


                int
                f_1562_55889_55911(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 55889, 55911);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1562_56012_56027(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 56012, 56027);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1562_56012_56034(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 56012, 56034);
                    return return_v;
                }


                string
                f_1562_56012_56039(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 56012, 56039);
                    return return_v;
                }


                bool
                f_1562_55971_56040(System.Management.Automation.ScriptBlock
                scriptBlock, int
                segment, int
                segments, string
                textToLog)
                {
                    var return_v = WriteScriptBlockToLog(scriptBlock, segment, segments, textToLog);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 55971, 56040);
                    return return_v;
                }


                System.Random
                f_1562_56416_56428()
                {
                    var return_v = new System.Random();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 56416, 56428);
                    return return_v;
                }


                int
                f_1562_56415_56441(System.Random
                this_param, int
                maxValue)
                {
                    var return_v = this_param.Next(maxValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 56415, 56441);
                    return return_v;
                }


                int
                f_1562_56504_56526(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 56504, 56526);
                    return return_v;
                }


                double
                f_1562_56484_56542(int
                d)
                {
                    var return_v = Math.Floor((double)d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 56484, 56542);
                    return return_v;
                }


                int
                f_1562_56876_56898(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 56876, 56898);
                    return return_v;
                }


                int
                f_1562_56854_56917(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 56854, 56917);
                    return return_v;
                }


                string
                f_1562_56965_57027(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 56965, 57027);
                    return return_v;
                }


                bool
                f_1562_57064_57128(System.Management.Automation.ScriptBlock
                scriptBlock, int
                segment, int
                segments, string
                textToLog)
                {
                    var return_v = WriteScriptBlockToLog(scriptBlock, segment, segments, textToLog);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 57064, 57128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 54729, 57415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 54729, 57415);
            }
        }

        private static bool WriteScriptBlockToLog(ScriptBlock scriptBlock, int segment, int segments, string textToLog)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 57427, 62571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 57776, 57902);

                ProtectedEventLogging
                logSetting =
                f_1562_57828_57901(Utils.SystemWideOnlyConfig)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 57916, 57940);

                bool
                wasEncoded = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 57954, 61323) || true) && (logSetting != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 57954, 61323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 58016, 58028);
                    lock (s_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 58372, 58448);

                        bool
                        couldLog = f_1562_58388_58447(scriptBlock, logSetting)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 58470, 58569) || true) && (!couldLog)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 58470, 58569);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 58533, 58546);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 58470, 58569);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 58740, 61289) || true) && (s_encryptionRecipients != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 58740, 61289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 58990, 59069);

                            ExecutionContext
                            executionContext = f_1562_59026_59068()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 59095, 59120);

                            ErrorRecord
                            error = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 59146, 59214);

                            byte[]
                            contentBytes = f_1562_59168_59213(f_1562_59168_59193(), textToLog)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 59240, 59478);

                            string
                            encodedContent = f_1562_59264_59477(contentBytes, s_encryptionRecipients, f_1562_59407_59436(executionContext), out error)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 59616, 61266) || true) && (error != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 59616, 61266);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 60259, 60475);

                                string
                                errorMessage = f_1562_60281_60474(f_1562_60333_60378(), textToLog, f_1562_60457_60473(error))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 60505, 61050);

                                f_1562_60505_61049(id: PSEventId.ScriptBlock_Compile_Detail, opcode: PSOpcode.Create, task: PSTask.ExecuteCommand, keyword: PSKeyword.UseAlwaysOperational, 0, 0, errorMessage, scriptBlock.Id.ToString(), f_1562_61016_61032(scriptBlock) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1562, 61016, 61048) ?? string.Empty));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 59616, 61266);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 59616, 61266);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 61164, 61191);

                                textToLog = encodedContent;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 61221, 61239);

                                wasEncoded = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 59616, 61266);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 58740, 61289);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 57954, 61323);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 61339, 61442) || true) && (!wasEncoded)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 61339, 61442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 61388, 61427);

                    textToLog = f_1562_61400_61426(textToLog);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 61339, 61442);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 61458, 62532) || true) && (f_1562_61462_61511(scriptBlock._scriptBlockData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 61458, 62532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 61545, 61998);

                    f_1562_61545_61997(id: PSEventId.ScriptBlock_Compile_Detail, opcode: PSOpcode.Create, task: PSTask.ExecuteCommand, keyword: PSKeyword.UseAlwaysOperational, segment + 1, segments, textToLog, scriptBlock.Id.ToString(), f_1562_61964_61980(scriptBlock) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1562, 61964, 61996) ?? string.Empty));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 61458, 62532);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 61458, 62532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 62064, 62517);

                    f_1562_62064_62516(id: PSEventId.ScriptBlock_Compile_Detail, opcode: PSOpcode.Create, task: PSTask.ExecuteCommand, keyword: PSKeyword.UseAlwaysOperational, segment + 1, segments, textToLog, scriptBlock.Id.ToString(), f_1562_62483_62499(scriptBlock) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1562, 62483, 62515) ?? string.Empty));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 61458, 62532);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 62548, 62560);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 57427, 62571);

                System.Management.Automation.Configuration.ProtectedEventLogging
                f_1562_57828_57901(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 57828, 57901);
                    return return_v;
                }


                bool
                f_1562_58388_58447(System.Management.Automation.ScriptBlock
                scriptBlock, System.Management.Automation.Configuration.ProtectedEventLogging
                logSetting)
                {
                    var return_v = GetAndValidateEncryptionRecipients(scriptBlock, logSetting);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 58388, 58447);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_59026_59068()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 59026, 59068);
                    return return_v;
                }


                System.Text.Encoding
                f_1562_59168_59193()
                {
                    var return_v = System.Text.Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 59168, 59193);
                    return return_v;
                }


                byte[]
                f_1562_59168_59213(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 59168, 59213);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1562_59407_59436(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 59407, 59436);
                    return return_v;
                }


                string
                f_1562_59264_59477(byte[]
                contentBytes, System.Management.Automation.CmsMessageRecipient[]
                recipients, System.Management.Automation.SessionState
                sessionState, out System.Management.Automation.ErrorRecord
                error)
                {
                    var return_v = CmsUtils.Encrypt(contentBytes, recipients, sessionState, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 59264, 59477);
                    return return_v;
                }


                string
                f_1562_60333_60378()
                {
                    var return_v = SecuritySupportStrings.CouldNotEncryptContent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 60333, 60378);
                    return return_v;
                }


                string
                f_1562_60457_60473(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 60457, 60473);
                    return return_v;
                }


                string
                f_1562_60281_60474(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 60281, 60474);
                    return return_v;
                }


                string
                f_1562_61016_61032(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 61016, 61032);
                    return return_v;
                }


                int
                f_1562_60505_61049(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id: id, opcode: opcode, task: task, keyword: keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 60505, 61049);
                    return 0;
                }


                string
                f_1562_61400_61426(string
                textToLog)
                {
                    var return_v = FormatLogString(textToLog);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 61400, 61426);
                    return return_v;
                }


                bool
                f_1562_61462_61511(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.HasSuspiciousContent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 61462, 61511);
                    return return_v;
                }


                string
                f_1562_61964_61980(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 61964, 61980);
                    return return_v;
                }


                int
                f_1562_61545_61997(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalWarning(id: id, opcode: opcode, task: task, keyword: keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 61545, 61997);
                    return 0;
                }


                string
                f_1562_62483_62499(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 62483, 62499);
                    return return_v;
                }


                int
                f_1562_62064_62516(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalVerbose(id: id, opcode: opcode, task: task, keyword: keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 62064, 62516);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 57427, 62571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 57427, 62571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string FormatLogString(string textToLog)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 62583, 64598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 62663, 62701);

                const char
                NullControlChar = '\u0000'
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 62755, 62792);

                const char
                NullSymbolChar = '\u2400'
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 64521, 64579);

                return f_1562_64528_64578(textToLog, NullControlChar, NullSymbolChar);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 62583, 64598);

                string
                f_1562_64528_64578(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 64528, 64578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 62583, 64598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 62583, 64598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool GetAndValidateEncryptionRecipients(
                    ScriptBlock scriptBlock,
                    ProtectedEventLogging logSetting)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 64610, 70832);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 64833, 70793) || true) && (f_1562_64837_64875(logSetting) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 64833, 70793);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 64968, 70778) || true) && (f_1562_64972_65004(logSetting) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 64968, 70778);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 65054, 65079);

                        ErrorRecord
                        error = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 65101, 65180);

                        ExecutionContext
                        executionContext = f_1562_65137_65179()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 65202, 65235);

                        SessionState
                        sessionState = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 65346, 65492) || true) && (executionContext != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 65346, 65492);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 65424, 65469);

                            sessionState = f_1562_65439_65468(executionContext);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 65346, 65492);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 65744, 65854) || true) && (sessionState == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 65744, 65854);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 65818, 65831);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 65744, 65854);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 65878, 65977);

                        string
                        fullCertificateContent = f_1562_65910_65976(f_1562_65922_65941(), f_1562_65943_65975(logSetting))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 66092, 66146);

                        f_1562_66092_66145(fullCertificateContent);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 66253, 66372) || true) && (s_encryptionRecipients != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 66253, 66372);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 66337, 66349);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 66253, 66372);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 66574, 66688) || true) && (s_hasProcessedCertificate)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 66574, 66688);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 66653, 66665);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 66574, 66688);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 66775, 66855);

                        CmsMessageRecipient
                        recipient = f_1562_66807_66854(fullCertificateContent)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 66877, 66950);

                        f_1562_66877_66949(recipient, sessionState, ResolutionPurpose.Encryption, out error);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 66972, 67005);

                        s_hasProcessedCertificate = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 67243, 68633) || true) && (error != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 67243, 68633);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 67871, 68035);

                            string
                            errorMessage = f_1562_67893_68034(f_1562_67941_67986(), f_1562_68017_68033(error))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 68061, 68570);

                            f_1562_68061_68569(id: PSEventId.ScriptBlock_Compile_Detail, opcode: PSOpcode.Create, task: PSTask.ExecuteCommand, keyword: PSKeyword.UseAlwaysOperational, 0, 0, errorMessage, scriptBlock.Id.ToString(), f_1562_68536_68552(scriptBlock) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1562, 68536, 68568) ?? string.Empty));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 68598, 68610);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 67243, 68633);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 68757, 68822);

                        s_encryptionRecipients = new CmsMessageRecipient[] { recipient };
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 69050, 70759);
                            foreach (X509Certificate2 validationCertificate in f_1562_69101_69123_I(f_1562_69101_69123(recipient)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 69050, 70759);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 69173, 70736) || true) && (f_1562_69177_69212(validationCertificate))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 69173, 70736);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 69642, 69692);

                                    string
                                    certificateForLog = fullCertificateContent
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 69722, 69922) || true) && (f_1562_69726_69765(f_1562_69726_69758(logSetting)) > 1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 69722, 69922);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 69835, 69891);

                                        certificateForLog = f_1562_69855_69887(logSetting)[1];
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 69722, 69922);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 69954, 70134);

                                    string
                                    errorMessage = f_1562_69976_70133(f_1562_70028_70080(), certificateForLog)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 70164, 70709);

                                    f_1562_70164_70708(id: PSEventId.ScriptBlock_Compile_Detail, opcode: PSOpcode.Create, task: PSTask.ExecuteCommand, keyword: PSKeyword.UseAlwaysOperational, 0, 0, errorMessage, scriptBlock.Id.ToString(), f_1562_70675_70691(scriptBlock) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1562, 70675, 70707) ?? string.Empty));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 69173, 70736);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 69050, 70759);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1562, 1, 1710);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1562, 1, 1710);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 64968, 70778);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 64833, 70793);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 70809, 70821);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 64610, 70832);

                bool?
                f_1562_64837_64875(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EnableProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 64837, 64875);
                    return return_v;
                }


                string[]
                f_1562_64972_65004(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EncryptionCertificate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 64972, 65004);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_65137_65179()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 65137, 65179);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1562_65439_65468(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 65439, 65468);
                    return return_v;
                }


                string
                f_1562_65922_65941()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 65922, 65941);
                    return return_v;
                }


                string[]
                f_1562_65943_65975(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EncryptionCertificate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 65943, 65975);
                    return return_v;
                }


                string
                f_1562_65910_65976(string
                separator, params string[]
                value)
                {
                    var return_v = string.Join(separator, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 65910, 65976);
                    return return_v;
                }


                int
                f_1562_66092_66145(string
                certificate)
                {
                    ResetCertificateCacheIfNeeded(certificate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 66092, 66145);
                    return 0;
                }


                System.Management.Automation.CmsMessageRecipient
                f_1562_66807_66854(string
                identifier)
                {
                    var return_v = new System.Management.Automation.CmsMessageRecipient(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 66807, 66854);
                    return return_v;
                }


                int
                f_1562_66877_66949(System.Management.Automation.CmsMessageRecipient
                this_param, System.Management.Automation.SessionState
                sessionState, System.Management.Automation.ResolutionPurpose
                purpose, out System.Management.Automation.ErrorRecord
                error)
                {
                    this_param.Resolve(sessionState, purpose, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 66877, 66949);
                    return 0;
                }


                string
                f_1562_67941_67986()
                {
                    var return_v = SecuritySupportStrings.CouldNotUseCertificate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 67941, 67986);
                    return return_v;
                }


                string
                f_1562_68017_68033(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 68017, 68033);
                    return return_v;
                }


                string
                f_1562_67893_68034(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 67893, 68034);
                    return return_v;
                }


                string
                f_1562_68536_68552(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 68536, 68552);
                    return return_v;
                }


                int
                f_1562_68061_68569(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id: id, opcode: opcode, task: task, keyword: keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 68061, 68569);
                    return 0;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1562_69101_69123(System.Management.Automation.CmsMessageRecipient
                this_param)
                {
                    var return_v = this_param.Certificates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 69101, 69123);
                    return return_v;
                }


                bool
                f_1562_69177_69212(System.Security.Cryptography.X509Certificates.X509Certificate2
                this_param)
                {
                    var return_v = this_param.HasPrivateKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 69177, 69212);
                    return return_v;
                }


                string[]
                f_1562_69726_69758(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EncryptionCertificate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 69726, 69758);
                    return return_v;
                }


                int
                f_1562_69726_69765(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 69726, 69765);
                    return return_v;
                }


                string[]
                f_1562_69855_69887(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EncryptionCertificate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 69855, 69887);
                    return return_v;
                }


                string
                f_1562_70028_70080()
                {
                    var return_v = SecuritySupportStrings.CertificateContainsPrivateKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 70028, 70080);
                    return return_v;
                }


                string
                f_1562_69976_70133(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 69976, 70133);
                    return return_v;
                }


                string
                f_1562_70675_70691(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 70675, 70691);
                    return return_v;
                }


                int
                f_1562_70164_70708(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id: id, opcode: opcode, task: task, keyword: keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 70164, 70708);
                    return 0;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1562_69101_69123_I(System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 69101, 69123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 64610, 70832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 64610, 70832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object s_syncObject;

        private static string s_lastSeenCertificate;

        private static bool s_hasProcessedCertificate;

        private static CmsMessageRecipient[] s_encryptionRecipients;

        private static Lazy<ScriptBlockLogging> s_sbLoggingSettingCache;

        private static void ResetCertificateCacheIfNeeded(string certificate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 71424, 71794);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 71518, 71783) || true) && (!f_1562_71523_71598(s_lastSeenCertificate, certificate, StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 71518, 71783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 71632, 71666);

                    s_hasProcessedCertificate = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 71684, 71720);

                    s_lastSeenCertificate = certificate;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 71738, 71768);

                    s_encryptionRecipients = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 71518, 71783);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 71424, 71794);

                bool
                f_1562_71523_71598(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 71523, 71598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 71424, 71794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 71424, 71794);
            }
        }

        private static ScriptBlockLogging GetScriptBlockLoggingSetting()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 71806, 72143);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 71895, 72079) || true) && (InternalTestHooks.BypassGroupPolicyCaching)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 71895, 72079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 71975, 72064);

                    return f_1562_71982_72063(Utils.SystemWideThenCurrentUserConfig);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 71895, 72079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 72095, 72132);

                return f_1562_72102_72131(s_sbLoggingSettingCache);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 71806, 72143);

                System.Management.Automation.Configuration.ScriptBlockLogging
                f_1562_71982_72063(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 71982, 72063);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_1562_72102_72131(System.Lazy<System.Management.Automation.Configuration.ScriptBlockLogging>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 72102, 72131);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 71806, 72143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 71806, 72143);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string CheckSuspiciousContent(Ast scriptBlockAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 72317, 73317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 72407, 72487);

                var
                foundSignature = f_1562_72428_72486(f_1562_72459_72485(f_1562_72459_72480(scriptBlockAst)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 72501, 72598) || true) && (foundSignature != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 72501, 72598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 72561, 72583);

                    return foundSignature;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 72501, 72598);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 72614, 73278) || true) && (f_1562_72618_72653(scriptBlockAst))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 72614, 73278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 72687, 73011);

                    Ast
                    foundAst = f_1562_72702_73010(scriptBlockAst, ast =>
                                        {
                        // Try to find the lowest AST that was not considered suspicious, but its parent was.
                        return (!ast.HasSuspiciousContent) && ast.Parent.HasSuspiciousContent;
                                        }, true)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 73031, 73263) || true) && (foundAst != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 73031, 73263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 73093, 73128);

                        return f_1562_73100_73127(f_1562_73100_73122(f_1562_73100_73115(foundAst)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 73031, 73263);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 73031, 73263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 73210, 73244);

                        return f_1562_73217_73243(f_1562_73217_73238(scriptBlockAst));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 73031, 73263);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 72614, 73278);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 73294, 73306);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 72317, 73317);

                System.Management.Automation.Language.IScriptExtent
                f_1562_72459_72480(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 72459, 72480);
                    return return_v;
                }


                string
                f_1562_72459_72485(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 72459, 72485);
                    return return_v;
                }


                string
                f_1562_72428_72486(string
                text)
                {
                    var return_v = SuspiciousContentChecker.Match(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 72428, 72486);
                    return return_v;
                }


                bool
                f_1562_72618_72653(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.HasSuspiciousContent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 72618, 72653);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1562_72702_73010(System.Management.Automation.Language.Ast
                this_param, System.Func<System.Management.Automation.Language.Ast, bool>
                predicate, bool
                searchNestedScriptBlocks)
                {
                    var return_v = this_param.Find(predicate, searchNestedScriptBlocks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 72702, 73010);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1562_73100_73115(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 73100, 73115);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1562_73100_73122(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 73100, 73122);
                    return return_v;
                }


                string
                f_1562_73100_73127(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 73100, 73127);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1562_73217_73238(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 73217, 73238);
                    return return_v;
                }


                string
                f_1562_73217_73243(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 73217, 73243);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 72317, 73317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 72317, 73317);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        class SuspiciousContentChecker
        {
            private const uint
            LCG = 31
            ;

            static string LookupHash(uint h)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 74054, 82249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 74119, 82234);

                    switch (h)
                    {

                        case 3012981990:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 74228, 74246);

                            return "Add-Type";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3359423881:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 74285, 74304);

                            return "DllImport";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2713126922:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 74422, 74453);

                            return "DefineDynamicAssembly";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2407049616:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 74492, 74521);

                            return "DefineDynamicModule";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3276870517:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 74560, 74580);

                            return "DefineType";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 419507039:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 74618, 74645);

                            return "DefineConstructor";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1370182198:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 74684, 74704);

                            return "CreateType";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1973546644:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 74743, 74766);

                            return "DefineLiteral";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3276413244:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 74805, 74825);

                            return "DefineEnum";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2785322015:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 74864, 74885);

                            return "DefineField";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 837002512:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 74923, 74944);

                            return "ILGenerator";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3117011:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 74980, 74994);

                            return "Emit";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 883134515:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75032, 75067);

                            return "UnverifiableCodeAttribute";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2920989166:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75106, 75135);

                            return "DefinePInvokeMethod";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1996222179:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75174, 75192);

                            return "GetTypes";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3935635674:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75231, 75254);

                            return "GetAssemblies";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 955534258:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75292, 75309);

                            return "Methods";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3368914227:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75348, 75368);

                            return "Properties";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 398423780:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75474, 75498);

                            return "GetConstructor";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3761202703:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75537, 75562);

                            return "GetConstructors";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1998297230:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75601, 75628);

                            return "GetDefaultMembers";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1982269700:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75667, 75685);

                            return "GetEvent";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1320818671:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75724, 75743);

                            return "GetEvents";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1982805860:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75782, 75800);

                            return "GetField";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1337439631:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75839, 75858);

                            return "GetFields";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2784018083:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75897, 75919);

                            return "GetInterface";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2864332761:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 75958, 75983);

                            return "GetInterfaceMap";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 405214768:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76021, 76044);

                            return "GetInterfaces";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1534378352:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76083, 76102);

                            return "GetMember";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 321088771:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76140, 76160);

                            return "GetMembers";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1534592951:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76199, 76218);

                            return "GetMethod";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 327741340:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76256, 76276);

                            return "GetMethods";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1116240007:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76315, 76338);

                            return "GetNestedType";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 243701964:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76376, 76400);

                            return "GetNestedTypes";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1077700873:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76439, 76462);

                            return "GetProperties";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1020114731:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76501, 76522);

                            return "GetProperty";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 257791250:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76560, 76582);

                            return "InvokeMember";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3217683173:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76621, 76644);

                            return "MakeArrayType";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 821968872:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76682, 76705);

                            return "MakeByRefType";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3538448099:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76744, 76769);

                            return "MakeGenericType";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3207725129:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76808, 76833);

                            return "MakePointerType";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1617553224:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76872, 76897);

                            return "DeclaringMethod";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3152745313:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76936, 76959);

                            return "DeclaringType";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 4144122198:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 76998, 77021);

                            return "ReflectedType";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3455789538:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77060, 77080);

                            return "TypeHandle";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 624373608:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77118, 77143);

                            return "TypeInitializer";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 637454598:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77181, 77211);

                            return "UnderlyingSystemType";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1855303451:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77325, 77350);

                            return "InteropServices";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 839491486:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77388, 77405);

                            return "Marshal";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1928879414:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77444, 77466);

                            return "AllocHGlobal";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3180922282:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77505, 77529);

                            return "PtrToStructure";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1718292736:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77568, 77592);

                            return "StructureToPtr";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3390778911:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77631, 77652);

                            return "FreeHGlobal";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3111215263:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77691, 77707);

                            return "IntPtr";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1606191041:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77792, 77814);

                            return "MemoryStream";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2147536747:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77853, 77876);

                            return "DeflateStream";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1820815050:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77915, 77941);

                            return "FromBase64String";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3656724093:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 77980, 78004);

                            return "EncodedCommand";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2920836328:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78043, 78059);

                            return "Bypass";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3473847323:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78098, 78122);

                            return "ToBase64String";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 4192166699:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78161, 78183);

                            return "ExpandString";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2462813217:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78222, 78245);

                            return "GetPowerShell";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2123968741:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78337, 78358);

                            return "OpenProcess";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3630248714:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78397, 78419);

                            return "VirtualAlloc";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3303847927:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78458, 78479);

                            return "VirtualFree";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 512407217:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78517, 78545);

                            return "WriteProcessMemory";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2357873553:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78584, 78610);

                            return "CreateUserThread";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 756544032:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78648, 78669);

                            return "CloseHandle";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3400025495:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78708, 78747);

                            return "GetDelegateForFunctionPointer";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 314128220:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78785, 78803);

                            return "kernel32";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2469462534:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78842, 78864);

                            return "CreateThread";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3217199031:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78903, 78919);

                            return "memcpy";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2283745557:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 78958, 78979);

                            return "LoadLibrary";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3317813738:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79018, 79043);

                            return "GetModuleHandle";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2491894472:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79082, 79106);

                            return "GetProcAddress";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1757922660:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79145, 79169);

                            return "VirtualProtect";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2693938383:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79208, 79229);

                            return "FreeLibrary";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2873914970:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79268, 79295);

                            return "ReadProcessMemory";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2717270220:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79334, 79362);

                            return "CreateRemoteThread";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2867203884:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79401, 79432);

                            return "AdjustTokenPrivileges";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2889068903:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79471, 79490);

                            return "WriteByte";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3667925519:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79529, 79549);

                            return "WriteInt32";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2742077861:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79588, 79613);

                            return "OpenThreadToken";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2826980154:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79652, 79673);

                            return "PtrToString";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3735047487:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79712, 79748);

                            return "ZeroFreeGlobalAllocUnicode";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 788615220:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79786, 79812);

                            return "OpenProcessToken";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1264589033:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79851, 79880);

                            return "GetTokenInformation";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2165372045:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79919, 79943);

                            return "SetThreadToken";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 197357349:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 79981, 80014);

                            return "ImpersonateLoggedOnUser";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1259149099:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80053, 80075);

                            return "RevertToSelf";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2446460563:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80114, 80143);

                            return "GetLogonSessionData";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2534763616:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80182, 80214);

                            return "CreateProcessWithToken";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3512478977:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80253, 80279);

                            return "DuplicateTokenEx";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3126049082:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80318, 80345);

                            return "OpenWindowStation";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3990594194:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80384, 80405);

                            return "OpenDesktop";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3195806696:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80444, 80471);

                            return "MiniDumpWriteDump";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3990234693:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80510, 80538);

                            return "AddSecurityPackage";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 611728017:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80576, 80611);

                            return "EnumerateSecurityPackages";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 4283779521:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80650, 80676);

                            return "GetProcessHandle";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 845600244:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80714, 80742);

                            return "DangerousGetHandle";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2691669189:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80833, 80864);

                            return "CryptoServiceProvider";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1413809388:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80903, 80925);

                            return "Cryptography";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 4113841312:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 80964, 80989);

                            return "RijndaelManaged";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1650652922:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81028, 81049);

                            return "SHA1Managed";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1759701889:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81088, 81110);

                            return "CryptoStream";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2439640460:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81149, 81174);

                            return "CreateEncryptor";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1446703796:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81213, 81238);

                            return "CreateDecryptor";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1638240579:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81277, 81306);

                            return "TransformFinalBlock";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1464730593:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81345, 81370);

                            return "DeviceIoControl";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3966822309:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81409, 81440);

                            return "SetInformationProcess";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 851965993:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81478, 81507);

                            return "PasswordDeriveBytes";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 793353336:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81582, 81608);

                            return "GetAsyncKeyState";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 293877108:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81646, 81672);

                            return "GetKeyboardState";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 2448894537:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81711, 81740);

                            return "GetForegroundWindow";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 4059335458:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81826, 81848);

                            return "BindingFlags";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 1085624182:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81887, 81906);

                            return "NonPublic";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 904148605:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 81996, 82024);

                            return "ScriptBlockLogging";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 4150524432:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 82063, 82100);

                            return "LogPipelineExecutionDetails";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        case 3704712755:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 82139, 82170);

                            return "ProtectedEventLogging";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 74119, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 82203, 82215);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 74119, 82234);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 74054, 82249);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 74054, 82249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 74054, 82249);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static string CheckForMatches(uint[] runningHash, int upTo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 82806, 83388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 82906, 82939);

                    var
                    upToMax = f_1562_82920_82938(runningHash)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 82957, 83064) || true) && (upTo == 0 || (DynAbs.Tracing.TraceSender.Expression_False(1562, 82961, 82988) || upTo > upToMax))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 82957, 83064);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 83030, 83045);

                        upTo = upToMax;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 82957, 83064);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 83093, 83098);

                        for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 83084, 83341) || true) && (i < upTo)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 83110, 83113)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 83084, 83341))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 83084, 83341);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 83155, 83195);

                            var
                            result = f_1562_83168_83194(runningHash[i])
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 83217, 83322) || true) && (result != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 83217, 83322);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 83285, 83299);

                                return result;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 83217, 83322);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1562, 1, 258);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1562, 1, 258);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 83361, 83373);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 82806, 83388);

                    int
                    f_1562_82920_82938(uint[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 82920, 82938);
                        return return_v;
                    }


                    string
                    f_1562_83168_83194(uint
                    h)
                    {
                        var return_v = LookupHash(h);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 83168, 83194);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 82806, 83388);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 82806, 83388);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static string Match(string text)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 84300, 86705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 84585, 84616);

                    var
                    runningHash = new uint[29]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 84636, 84667);

                    int
                    longestPossiblePattern = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 84694, 84699);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 84685, 86631) || true) && (i < f_1562_84705_84716(text))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 84718, 84721)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 84685, 86631))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 84685, 86631);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 84763, 84780);

                            uint
                            h = f_1562_84772_84779(text, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 84802, 85280) || true) && (h >= 'A' && (DynAbs.Tracing.TraceSender.Expression_True(1562, 84806, 84826) && h <= 'Z'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 84802, 85280);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 84876, 84889);

                                h = h | 0x20;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 84802, 85280);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 84802, 85280);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 84950, 85280) || true) && (!((h >= 'a' && (DynAbs.Tracing.TraceSender.Expression_True(1562, 84957, 84977) && h <= 'z')) || (DynAbs.Tracing.TraceSender.Expression_False(1562, 84956, 84990) || h == '-')))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 84950, 85280);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 85195, 85222);

                                    longestPossiblePattern = 0;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 85248, 85257);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 84950, 85280);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 84802, 85280);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 85313, 85352);

                                for (int
            j = f_1562_85317_85348(i, f_1562_85329_85347(runningHash)) - 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 85304, 86313) || true) && (j > 0)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 85361, 85364)
            , j--, DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 85304, 86313))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 85304, 86313);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 86244, 86290);

                                    runningHash[j] = LCG * runningHash[j - 1] + h;
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1562, 1, 1010);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1562, 1, 1010);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 86337, 86356);

                            runningHash[0] = h;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 86380, 86612) || true) && (++longestPossiblePattern >= 4)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 86380, 86612);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 86463, 86529);

                                var
                                result = f_1562_86476_86528(runningHash, longestPossiblePattern)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 86555, 86589) || true) && (result != null)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 86555, 86589);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 86575, 86589);

                                    return result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 86555, 86589);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 86380, 86612);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1562, 1, 1947);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1562, 1, 1947);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 86651, 86690);

                    return f_1562_86658_86689(runningHash, 0);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 84300, 86705);

                    int
                    f_1562_84705_84716(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 84705, 84716);
                        return return_v;
                    }


                    char
                    f_1562_84772_84779(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 84772, 84779);
                        return return_v;
                    }


                    int
                    f_1562_85329_85347(uint[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 85329, 85347);
                        return return_v;
                    }


                    int
                    f_1562_85317_85348(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 85317, 85348);
                        return return_v;
                    }


                    string
                    f_1562_86476_86528(uint[]
                    runningHash, int
                    upTo)
                    {
                        var return_v = CheckForMatches(runningHash, upTo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 86476, 86528);
                        return return_v;
                    }


                    string
                    f_1562_86658_86689(uint[]
                    runningHash, int
                    upTo)
                    {
                        var return_v = CheckForMatches(runningHash, upTo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 86658, 86689);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 84300, 86705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 84300, 86705);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SuspiciousContentChecker()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1562, 73329, 87668);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1562, 73329, 87668);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 73329, 87668);
            }


            static SuspiciousContentChecker()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1562, 73329, 87668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 73515, 73523);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1562, 73329, 87668);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 73329, 87668);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1562, 73329, 87668);
        }

        internal static void LogScriptBlockStart(ScriptBlock scriptBlock, Guid runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 87680, 88843);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 87851, 88341) || true) && (f_1562_87855_87879_M(!scriptBlock.SkipLogging))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 87851, 88341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 88014, 88088);

                    bool
                    forceLogCreation = f_1562_88038_88087(scriptBlock._scriptBlockData)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 88272, 88326);

                    f_1562_88272_88325(scriptBlock, forceLogCreation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 87851, 88341);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 88357, 88832) || true) && (f_1562_88361_88427_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1562_88361_88391(), 1562, 88361, 88427)?.EnableScriptBlockInvocationLogging) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 88357, 88832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 88469, 88817);

                    f_1562_88469_88816(id: PSEventId.ScriptBlock_Invoke_Start_Detail, opcode: PSOpcode.Create, task: PSTask.CommandStart, keyword: PSKeyword.UseAlwaysOperational, scriptBlock.Id.ToString(), runspaceId.ToString());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 88357, 88832);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 87680, 88843);

                bool
                f_1562_87855_87879_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 87855, 87879);
                    return return_v;
                }


                bool
                f_1562_88038_88087(System.Management.Automation.CompiledScriptBlockData
                this_param)
                {
                    var return_v = this_param.HasSuspiciousContent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 88038, 88087);
                    return return_v;
                }


                int
                f_1562_88272_88325(System.Management.Automation.ScriptBlock
                scriptBlock, bool
                force)
                {
                    LogScriptBlockCreation(scriptBlock, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 88272, 88325);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_1562_88361_88391()
                {
                    var return_v = GetScriptBlockLoggingSetting();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 88361, 88391);
                    return return_v;
                }


                bool?
                f_1562_88361_88427_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 88361, 88427);
                    return return_v;
                }


                int
                f_1562_88469_88816(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalVerbose(id: id, opcode: opcode, task: task, keyword: keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 88469, 88816);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 87680, 88843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 87680, 88843);
            }
        }

        internal static void LogScriptBlockEnd(ScriptBlock scriptBlock, Guid runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1562, 88855, 89448);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 88960, 89437) || true) && (f_1562_88964_89030_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1562_88964_88994(), 1562, 88964, 89030)?.EnableScriptBlockInvocationLogging) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 88960, 89437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 89072, 89422);

                    f_1562_89072_89421(id: PSEventId.ScriptBlock_Invoke_Complete_Detail, opcode: PSOpcode.Create, task: PSTask.CommandStop, keyword: PSKeyword.UseAlwaysOperational, scriptBlock.Id.ToString(), runspaceId.ToString());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 88960, 89437);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1562, 88855, 89448);

                System.Management.Automation.Configuration.ScriptBlockLogging
                f_1562_88964_88994()
                {
                    var return_v = GetScriptBlockLoggingSetting();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 88964, 88994);
                    return return_v;
                }


                bool?
                f_1562_88964_89030_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 88964, 89030);
                    return return_v;
                }


                int
                f_1562_89072_89421(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalVerbose(id: id, opcode: opcode, task: task, keyword: keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 89072, 89421);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 88855, 89448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 88855, 89448);
            }
        }

        internal CompiledScriptBlockData ScriptBlockData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 89515, 89534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 89518, 89534);
                    return _scriptBlockData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 89515, 89534);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 89460, 89537);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 89460, 89537);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Ast Ast
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 89681, 89709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 89684, 89709);
                    return (Ast)f_1562_89689_89709(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 89681, 89709);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 89681, 89709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 89681, 89709);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IParameterMetadataProvider AstInternal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 89778, 89801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 89781, 89801);
                    return f_1562_89781_89801(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 89778, 89801);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 89724, 89804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 89724, 89804);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IScriptExtent[] SequencePoints
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 89862, 89896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 89865, 89896);
                    return f_1562_89865_89896(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 89862, 89896);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 89816, 89899);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 89816, 89899);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Action<FunctionContext> DynamicParamBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 89968, 90005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 89971, 90005);
                    return f_1562_89971_90005(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 89968, 90005);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 89911, 90008);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 89911, 90008);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Action<FunctionContext> UnoptimizedDynamicParamBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 90088, 90136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 90091, 90136);
                    return f_1562_90091_90136(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 90088, 90136);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 90020, 90139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 90020, 90139);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Action<FunctionContext> BeginBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 90201, 90231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 90204, 90231);
                    return f_1562_90204_90231(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 90201, 90231);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 90151, 90234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 90151, 90234);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Action<FunctionContext> UnoptimizedBeginBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 90307, 90348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 90310, 90348);
                    return f_1562_90310_90348(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 90307, 90348);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 90246, 90351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 90246, 90351);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Action<FunctionContext> ProcessBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 90415, 90447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 90418, 90447);
                    return f_1562_90418_90447(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 90415, 90447);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 90363, 90450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 90363, 90450);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Action<FunctionContext> UnoptimizedProcessBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 90525, 90568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 90528, 90568);
                    return f_1562_90528_90568(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 90525, 90568);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 90462, 90571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 90462, 90571);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Action<FunctionContext> EndBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 90631, 90659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 90634, 90659);
                    return f_1562_90634_90659(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 90631, 90659);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 90583, 90662);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 90583, 90662);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Action<FunctionContext> UnoptimizedEndBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 90733, 90772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 90736, 90772);
                    return f_1562_90736_90772(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 90733, 90772);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 90674, 90775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 90674, 90775);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasBeginBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 90821, 90859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 90824, 90859);
                    return f_1562_90824_90851(f_1562_90824_90840(f_1562_90824_90835())) != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 90821, 90859);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 90787, 90862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 90787, 90862);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasProcessBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 90910, 90950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 90913, 90950);
                    return f_1562_90913_90942(f_1562_90913_90929(f_1562_90913_90924())) != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 90910, 90950);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 90874, 90953);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 90874, 90953);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasEndBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 90997, 91033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 91000, 91033);
                    return f_1562_91000_91025(f_1562_91000_91016(f_1562_91000_91011())) != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 90997, 91033);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 90965, 91036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 90965, 91036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static System.Management.Automation.CompiledScriptBlockData
        f_1562_18693_18735(System.Management.Automation.Language.IParameterMetadataProvider
        ast, bool
        isFilter)
        {
            // LAFHIS
            DynAbs.Tracing.TraceSender.TraceBaseCall(1562, 18605, 18758);

            var return_v = new System.Management.Automation.CompiledScriptBlockData(ast, isFilter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 18693, 18735);
            return return_v;
        }


        static System.Management.Automation.CompiledScriptBlockData
        f_1562_18693_18735_C(System.Management.Automation.CompiledScriptBlockData
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1562, 18605, 18758);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1562_19766_19808()
        {
            var return_v = LocalPipeline.GetExecutionContextFromTLS();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 19766, 19808);
            return return_v;
        }


        System.Management.Automation.PSLanguageMode
        f_1562_19896_19916(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.LanguageMode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 19896, 19916);
            return return_v;
        }


        System.Management.Automation.MergedCommandParameterMetadata
        f_1562_29340_29383(System.Management.Automation.CompiledScriptBlockData
        this_param, System.Management.Automation.ScriptBlock
        scriptBlock)
        {
            var return_v = this_param.GetParameterMetadata(scriptBlock);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 29340, 29383);
            return return_v;
        }


        bool
        f_1562_29448_29482(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.UsesCmdletBinding;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 29448, 29482);
            return return_v;
        }


        System.Management.Automation.Language.IParameterMetadataProvider
        f_1562_29541_29552()
        {
            var return_v = AstInternal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 29541, 29552);
            return return_v;
        }


        System.Management.Automation.Language.ScriptBlockAst
        f_1562_29541_29557(System.Management.Automation.Language.IParameterMetadataProvider
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 29541, 29557);
            return return_v;
        }


        System.Management.Automation.Language.NamedBlockAst
        f_1562_29541_29575(System.Management.Automation.Language.ScriptBlockAst
        this_param)
        {
            var return_v = this_param.DynamicParamBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 29541, 29575);
            return return_v;
        }


        bool
        f_1562_29732_29763(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.DebuggerHidden;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 29732, 29763);
            return return_v;
        }


        System.Guid
        f_1562_29968_29987(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 29968, 29987);
            return return_v;
        }


        System.Management.Automation.RuntimeDefinedParameterDictionary
        f_1562_30303_30344(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.RuntimeDefinedParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 30303, 30344);
            return return_v;
        }


        bool
        f_1562_30423_30449(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.HasLogged;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 30423, 30449);
            return return_v;
        }


        System.Management.Automation.CmdletBindingAttribute
        f_1562_54368_54407(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.CmdletBindingAttribute;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 54368, 54407);
            return return_v;
        }


        System.ObsoleteAttribute
        f_1562_54476_54510(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.ObsoleteAttribute;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 54476, 54510);
            return return_v;
        }


        System.Management.Automation.ExperimentalAttribute
        f_1562_54587_54625(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.ExperimentalAttribute;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 54587, 54625);
            return return_v;
        }


        System.Management.Automation.Language.IParameterMetadataProvider
        f_1562_89689_89709(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.Ast;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 89689, 89709);
            return return_v;
        }


        System.Management.Automation.Language.IParameterMetadataProvider
        f_1562_89781_89801(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.Ast;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 89781, 89801);
            return return_v;
        }


        System.Management.Automation.Language.IScriptExtent[]
        f_1562_89865_89896(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.SequencePoints;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 89865, 89896);
            return return_v;
        }


        System.Action<System.Management.Automation.Language.FunctionContext>
        f_1562_89971_90005(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.DynamicParamBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 89971, 90005);
            return return_v;
        }


        System.Action<System.Management.Automation.Language.FunctionContext>
        f_1562_90091_90136(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.UnoptimizedDynamicParamBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 90091, 90136);
            return return_v;
        }


        System.Action<System.Management.Automation.Language.FunctionContext>
        f_1562_90204_90231(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.BeginBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 90204, 90231);
            return return_v;
        }


        System.Action<System.Management.Automation.Language.FunctionContext>
        f_1562_90310_90348(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.UnoptimizedBeginBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 90310, 90348);
            return return_v;
        }


        System.Action<System.Management.Automation.Language.FunctionContext>
        f_1562_90418_90447(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.ProcessBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 90418, 90447);
            return return_v;
        }


        System.Action<System.Management.Automation.Language.FunctionContext>
        f_1562_90528_90568(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.UnoptimizedProcessBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 90528, 90568);
            return return_v;
        }


        System.Action<System.Management.Automation.Language.FunctionContext>
        f_1562_90634_90659(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.EndBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 90634, 90659);
            return return_v;
        }


        System.Action<System.Management.Automation.Language.FunctionContext>
        f_1562_90736_90772(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.UnoptimizedEndBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 90736, 90772);
            return return_v;
        }


        System.Management.Automation.Language.IParameterMetadataProvider
        f_1562_90824_90835()
        {
            var return_v = AstInternal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 90824, 90835);
            return return_v;
        }


        System.Management.Automation.Language.ScriptBlockAst
        f_1562_90824_90840(System.Management.Automation.Language.IParameterMetadataProvider
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 90824, 90840);
            return return_v;
        }


        System.Management.Automation.Language.NamedBlockAst
        f_1562_90824_90851(System.Management.Automation.Language.ScriptBlockAst
        this_param)
        {
            var return_v = this_param.BeginBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 90824, 90851);
            return return_v;
        }


        System.Management.Automation.Language.IParameterMetadataProvider
        f_1562_90913_90924()
        {
            var return_v = AstInternal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 90913, 90924);
            return return_v;
        }


        System.Management.Automation.Language.ScriptBlockAst
        f_1562_90913_90929(System.Management.Automation.Language.IParameterMetadataProvider
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 90913, 90929);
            return return_v;
        }


        System.Management.Automation.Language.NamedBlockAst
        f_1562_90913_90942(System.Management.Automation.Language.ScriptBlockAst
        this_param)
        {
            var return_v = this_param.ProcessBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 90913, 90942);
            return return_v;
        }


        System.Management.Automation.Language.IParameterMetadataProvider
        f_1562_91000_91011()
        {
            var return_v = AstInternal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 91000, 91011);
            return return_v;
        }


        System.Management.Automation.Language.ScriptBlockAst
        f_1562_91000_91016(System.Management.Automation.Language.IParameterMetadataProvider
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 91000, 91016);
            return return_v;
        }


        System.Management.Automation.Language.NamedBlockAst
        f_1562_91000_91025(System.Management.Automation.Language.ScriptBlockAst
        this_param)
        {
            var return_v = this_param.EndBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 91000, 91025);
            return return_v;
        }

    }
    [Serializable]
    internal class ScriptBlockSerializationHelper : ISerializable, IObjectReference
    {
        private readonly string _scriptText;

        private ScriptBlockSerializationHelper(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1562, 91215, 91673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 91191, 91202);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 91328, 91439) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 91328, 91439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 91378, 91424);

                    throw f_1562_91384_91423(nameof(info));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 91328, 91439);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 91455, 91523);

                _scriptText = f_1562_91469_91512(info, "ScriptText", typeof(string)) as string;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 91537, 91662) || true) && (_scriptText == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 91537, 91662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 91594, 91647);

                    throw f_1562_91600_91646("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 91537, 91662);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1562, 91215, 91673);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 91215, 91673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 91215, 91673);
            }
        }

        public object GetRealObject(StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 92045, 92079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 92048, 92079);
                return f_1562_92048_92079(_scriptText);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 92045, 92079);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 92045, 92079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 92045, 92079);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.ScriptBlock
            f_1562_92048_92079(string
            script)
            {
                var return_v = ScriptBlock.Create(script);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 92048, 92079);
                return return_v;
            }

        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 92487, 92523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 92490, 92523);
                throw f_1562_92496_92523();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 92487, 92523);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 92487, 92523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 92487, 92523);
            }

            System.NotSupportedException
            f_1562_92496_92523()
            {
                var return_v = new System.NotSupportedException();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 92496, 92523);
                return return_v;
            }

        }

        static ScriptBlockSerializationHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1562, 91051, 92531);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1562, 91051, 92531);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 91051, 92531);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1562, 91051, 92531);

        System.ArgumentNullException
        f_1562_91384_91423(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 91384, 91423);
            return return_v;
        }


        object?
        f_1562_91469_91512(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name, System.Type
        type)
        {
            var return_v = this_param.GetValue(name, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 91469, 91512);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1562_91600_91646(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 91600, 91646);
            return return_v;
        }

    }
    internal sealed class PSScriptCmdlet : PSCmdlet, IDynamicParameters, IDisposable
    {
        private readonly ArrayList _input;

        private readonly ScriptBlock _scriptBlock;

        private readonly bool _fromScriptFile;

        private readonly bool _useLocalScope;

        private readonly bool _runOptimized;

        private bool _rethrowExitException;

        private MshCommandRuntime _commandRuntime;

        private readonly MutableTuple _localsTuple;

        private bool _exitWasCalled;

        private readonly FunctionContext _functionContext;

        public PSScriptCmdlet(ScriptBlock scriptBlock, bool useNewScope, bool fromScriptFile, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1562, 93141, 94386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 92663, 92687);
                this._input = f_1562_92672_92687();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 92727, 92739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 92772, 92787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 92820, 92834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 92867, 92880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 92904, 92925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 92962, 92977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 93018, 93030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 93054, 93068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 93112, 93128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 104922, 104931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 93277, 93304);

                _scriptBlock = scriptBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 93318, 93347);

                _useLocalScope = useNewScope;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 93361, 93394);

                _fromScriptFile = fromScriptFile;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 93408, 93506);

                _runOptimized = f_1562_93424_93505(_scriptBlock, optimized: (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 93456, 93482) || ((context._debuggingMode > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 93485, 93490)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 93493, 93504))) ? false : useNewScope);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 93520, 93579);

                _localsTuple = f_1562_93535_93578(_scriptBlock, _runOptimized);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 93593, 93670);

                f_1562_93593_93669(_localsTuple, AutomaticVariable.PSCmdlet, this, context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 93684, 93752);

                f_1562_93684_93751(_scriptBlock, _localsTuple, context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 93766, 94219);

                _functionContext = new FunctionContext
                {
                    _localsTuple = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => _localsTuple, 1562, 93785, 94218),
                    _scriptBlock = _scriptBlock,
                    _file = f_1562_93937_93954(_scriptBlock),
                    _sequencePoints = f_1562_93991_94018(_scriptBlock),
                    _debuggerHidden = f_1562_94055_94082(_scriptBlock),
                    _debuggerStepThrough = f_1562_94124_94156(_scriptBlock),
                    _executionContext = context
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 94233, 94305);

                _rethrowExitException = f_1562_94257_94304(context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 94319, 94375);

                context.ScriptCommandProcessorShouldRethrowExit = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1562, 93141, 94386);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 93141, 94386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 93141, 94386);
            }
        }

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 94398, 95569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 94846, 94898);

                _commandRuntime = (MshCommandRuntime)commandRuntime;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 95142, 95200);

                _functionContext._outputPipe = f_1562_95173_95199(_commandRuntime);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 95216, 95241);

                f_1562_95216_95240(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 95257, 95558) || true) && (f_1562_95261_95287(_scriptBlock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 95257, 95558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 95321, 95543);

                    f_1562_95321_95542(this, clause: (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 95361, 95374) || ((_runOptimized && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 95377, 95400)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 95403, 95437))) ? f_1562_95377_95400(_scriptBlock) : f_1562_95403_95437(_scriptBlock), dollarUnderbar: f_1562_95476_95496(), inputToProcess: _input);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 95257, 95558);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 94398, 95569);

                System.Management.Automation.Internal.Pipe
                f_1562_95173_95199(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 95173, 95199);
                    return return_v;
                }


                int
                f_1562_95216_95240(System.Management.Automation.PSScriptCmdlet
                this_param)
                {
                    this_param.SetPreferenceVariables();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 95216, 95240);
                    return 0;
                }


                bool
                f_1562_95261_95287(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.HasBeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 95261, 95287);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_95377_95400(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.BeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 95377, 95400);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_95403_95437(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UnoptimizedBeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 95403, 95437);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1562_95476_95496()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 95476, 95496);
                    return return_v;
                }


                int
                f_1562_95321_95542(System.Management.Automation.PSScriptCmdlet
                this_param, System.Action<System.Management.Automation.Language.FunctionContext>
                clause, System.Management.Automation.PSObject
                dollarUnderbar, System.Collections.ArrayList
                inputToProcess)
                {
                    this_param.RunClause(clause: clause, dollarUnderbar: (object)dollarUnderbar, inputToProcess: (object)inputToProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 95321, 95542);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 94398, 95569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 94398, 95569);
            }
        }

        internal override void DoProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 95581, 96388);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 95646, 95720) || true) && (_exitWasCalled)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 95646, 95720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 95698, 95705);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 95646, 95720);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 95736, 95755);

                object
                dollarUnder
                = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 95769, 96030) || true) && (f_1562_95773_95794() == f_1562_95798_95818())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 95769, 96030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 95852, 95871);

                    dollarUnder = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 95769, 96030);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 95769, 96030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 95937, 95973);

                    dollarUnder = f_1562_95951_95972();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 95991, 96015);

                    f_1562_95991_96014(_input, dollarUnder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 95769, 96030);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 96046, 96377) || true) && (f_1562_96050_96078(_scriptBlock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 96046, 96377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 96112, 96329);

                    f_1562_96112_96328(this, clause: (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 96152, 96165) || ((_runOptimized && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 96168, 96193)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 96196, 96232))) ? f_1562_96168_96193(_scriptBlock) : f_1562_96196_96232(_scriptBlock), dollarUnderbar: dollarUnder, inputToProcess: _input);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 96347, 96362);

                    f_1562_96347_96361(_input);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 96046, 96377);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 95581, 96388);

                System.Management.Automation.PSObject
                f_1562_95773_95794()
                {
                    var return_v = CurrentPipelineObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 95773, 95794);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1562_95798_95818()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 95798, 95818);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1562_95951_95972()
                {
                    var return_v = CurrentPipelineObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 95951, 95972);
                    return return_v;
                }


                int
                f_1562_95991_96014(System.Collections.ArrayList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 95991, 96014);
                    return return_v;
                }


                bool
                f_1562_96050_96078(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.HasProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 96050, 96078);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_96168_96193(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 96168, 96193);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_96196_96232(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UnoptimizedProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 96196, 96232);
                    return return_v;
                }


                int
                f_1562_96112_96328(System.Management.Automation.PSScriptCmdlet
                this_param, System.Action<System.Management.Automation.Language.FunctionContext>
                clause, object
                dollarUnderbar, System.Collections.ArrayList
                inputToProcess)
                {
                    this_param.RunClause(clause: clause, dollarUnderbar: dollarUnderbar, inputToProcess: (object)inputToProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 96112, 96328);
                    return 0;
                }


                int
                f_1562_96347_96361(System.Collections.ArrayList
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 96347, 96361);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 95581, 96388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 95581, 96388);
            }
        }

        internal override void DoEndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 96400, 96871);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 96465, 96539) || true) && (_exitWasCalled)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 96465, 96539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 96517, 96524);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 96465, 96539);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 96555, 96860) || true) && (f_1562_96559_96583(_scriptBlock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 96555, 96860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 96617, 96845);

                    f_1562_96617_96844(this, clause: (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 96657, 96670) || ((_runOptimized && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 96673, 96694)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 96697, 96729))) ? f_1562_96673_96694(_scriptBlock) : f_1562_96697_96729(_scriptBlock), dollarUnderbar: f_1562_96768_96788(), inputToProcess: f_1562_96827_96843(_input));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 96555, 96860);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 96400, 96871);

                bool
                f_1562_96559_96583(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.HasEndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 96559, 96583);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_96673_96694(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 96673, 96694);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_96697_96729(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UnoptimizedEndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 96697, 96729);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1562_96768_96788()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 96768, 96788);
                    return return_v;
                }


                object?[]
                f_1562_96827_96843(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 96827, 96843);
                    return return_v;
                }


                int
                f_1562_96617_96844(System.Management.Automation.PSScriptCmdlet
                this_param, System.Action<System.Management.Automation.Language.FunctionContext>
                clause, System.Management.Automation.PSObject
                dollarUnderbar, object?[]
                inputToProcess)
                {
                    this_param.RunClause(clause: clause, dollarUnderbar: (object)dollarUnderbar, inputToProcess: (object)inputToProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 96617, 96844);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 96400, 96871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 96400, 96871);
            }
        }

        private void EnterScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 96883, 96985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 96933, 96974);

                f_1562_96933_96973(_commandRuntime);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 96883, 96985);

                int
                f_1562_96933_96973(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.SetVariableListsInPipe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 96933, 96973);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 96883, 96985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 96883, 96985);
            }
        }

        private void ExitScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 96997, 97101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 97046, 97090);

                f_1562_97046_97089(_commandRuntime);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 96997, 97101);

                int
                f_1562_97046_97089(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.RemoveVariableListsInPipe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 97046, 97089);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 96997, 97101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 96997, 97101);
            }
        }

        private void RunClause(Action<FunctionContext> clause, object dollarUnderbar, object inputToProcess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 97113, 100253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 97238, 97306);

                Pipe
                oldErrorOutputPipe = f_1562_97264_97305(f_1562_97264_97276(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 97448, 97487);

                PSLanguageMode?
                oldLanguageMode = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 97501, 97540);

                PSLanguageMode?
                newLanguageMode = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 97554, 97812) || true) && (f_1562_97558_97592(f_1562_97558_97583(_scriptBlock)) && (DynAbs.Tracing.TraceSender.Expression_True(1562, 97558, 97662) && f_1562_97613_97638(_scriptBlock) != f_1562_97642_97662(f_1562_97642_97649())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 97554, 97812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 97696, 97735);

                    oldLanguageMode = f_1562_97714_97734(f_1562_97714_97721());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 97753, 97797);

                    newLanguageMode = f_1562_97771_97796(_scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 97554, 97812);
                }

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 97908, 97921);

                        f_1562_97908_97920(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 97945, 98355) || true) && (f_1562_97949_97977(_commandRuntime) == MshCommandRuntime.MergeDataStream.Output)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 97945, 98355);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 98071, 98125);

                            f_1562_98071_98124(f_1562_98071_98078(), f_1562_98097_98123(_commandRuntime));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 97945, 98355);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 97945, 98355);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 98175, 98355) || true) && (f_1562_98179_98223(f_1562_98179_98210(_commandRuntime)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 98175, 98355);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 98273, 98332);

                                f_1562_98273_98331(f_1562_98273_98280(), f_1562_98299_98330(_commandRuntime));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 98175, 98355);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 97945, 98355);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 98379, 98581) || true) && (dollarUnderbar != f_1562_98401_98421())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 98379, 98581);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 98471, 98558);

                            f_1562_98471_98557(_localsTuple, AutomaticVariable.Underbar, dollarUnderbar, f_1562_98549_98556());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 98379, 98581);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 98605, 98804) || true) && (inputToProcess != f_1562_98627_98647())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 98605, 98804);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 98697, 98781);

                            f_1562_98697_98780(_localsTuple, AutomaticVariable.Input, inputToProcess, f_1562_98772_98779());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 98605, 98804);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 98874, 99020) || true) && (f_1562_98878_98902(newLanguageMode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 98874, 99020);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 98952, 98997);

                            f_1562_98952_98959().LanguageMode = f_1562_98975_98996(newLanguageMode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 98874, 99020);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 99044, 99069);

                        f_1562_99044_99068(clause, _functionContext);
                    }
                    catch (TargetInvocationException tie)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1562, 99106, 99302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 99258, 99283);

                        throw f_1562_99264_99282(tie);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1562, 99106, 99302);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1562, 99320, 99689);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 99368, 99418);

                        f_1562_99368_99417(f_1562_99368_99380(this), oldErrorOutputPipe);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 99488, 99634) || true) && (f_1562_99492_99516(oldLanguageMode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 99488, 99634);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 99566, 99611);

                            f_1562_99566_99573().LanguageMode = f_1562_99589_99610(oldLanguageMode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 99488, 99634);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 99658, 99670);

                        f_1562_99658_99669(this);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1562, 99320, 99689);
                    }
                }
                catch (ExitException ee)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1562, 99718, 100242);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 99775, 99887) || true) && (!_fromScriptFile || (DynAbs.Tracing.TraceSender.Expression_False(1562, 99779, 99820) || _rethrowExitException))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 99775, 99887);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 99862, 99868);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 99775, 99887);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 99907, 99929);

                    _exitWasCalled = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 99949, 99981);

                    int
                    exitCode = (int)f_1562_99969_99980(ee)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 99999, 100072);

                    f_1562_99999_100071(f_1562_99999_100011(this), SpecialVariables.LastExitCodeVarPath, exitCode);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 100092, 100227) || true) && (exitCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 100092, 100227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 100151, 100208);

                        f_1562_100151_100184(_commandRuntime).ExecutionFailed = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 100092, 100227);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1562, 99718, 100242);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 97113, 100253);

                System.Management.Automation.ExecutionContext
                f_1562_97264_97276(System.Management.Automation.PSScriptCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 97264, 97276);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1562_97264_97305(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 97264, 97305);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1562_97558_97583(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 97558, 97583);
                    return return_v;
                }


                bool
                f_1562_97558_97592(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 97558, 97592);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1562_97613_97638(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 97613, 97638);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_97642_97649()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 97642, 97649);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1562_97642_97662(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 97642, 97662);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_97714_97721()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 97714, 97721);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1562_97714_97734(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 97714, 97734);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1562_97771_97796(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 97771, 97796);
                    return return_v;
                }


                int
                f_1562_97908_97920(System.Management.Automation.PSScriptCmdlet
                this_param)
                {
                    this_param.EnterScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 97908, 97920);
                    return 0;
                }


                System.Management.Automation.MshCommandRuntime.MergeDataStream
                f_1562_97949_97977(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorMergeTo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 97949, 97977);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_98071_98078()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 98071, 98078);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1562_98097_98123(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 98097, 98123);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1562_98071_98124(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.Internal.Pipe
                newPipe)
                {
                    var return_v = this_param.RedirectErrorPipe(newPipe);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 98071, 98124);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1562_98179_98210(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 98179, 98210);
                    return return_v;
                }


                bool
                f_1562_98179_98223(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.IsRedirected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 98179, 98223);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_98273_98280()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 98273, 98280);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1562_98299_98330(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 98299, 98330);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1562_98273_98331(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.Internal.Pipe
                newPipe)
                {
                    var return_v = this_param.RedirectErrorPipe(newPipe);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 98273, 98331);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1562_98401_98421()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 98401, 98421);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_98549_98556()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 98549, 98556);
                    return return_v;
                }


                int
                f_1562_98471_98557(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 98471, 98557);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1562_98627_98647()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 98627, 98647);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_98772_98779()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 98772, 98779);
                    return return_v;
                }


                int
                f_1562_98697_98780(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 98697, 98780);
                    return 0;
                }


                bool
                f_1562_98878_98902(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 98878, 98902);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_98952_98959()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 98952, 98959);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1562_98975_98996(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 98975, 98996);
                    return return_v;
                }


                int
                f_1562_99044_99068(System.Action<System.Management.Automation.Language.FunctionContext>
                this_param, System.Management.Automation.Language.FunctionContext
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 99044, 99068);
                    return 0;
                }


                System.Exception
                f_1562_99264_99282(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 99264, 99282);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_99368_99380(System.Management.Automation.PSScriptCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 99368, 99380);
                    return return_v;
                }


                int
                f_1562_99368_99417(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.Internal.Pipe
                pipe)
                {
                    this_param.RestoreErrorPipe(pipe);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 99368, 99417);
                    return 0;
                }


                bool
                f_1562_99492_99516(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 99492, 99516);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_99566_99573()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 99566, 99573);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1562_99589_99610(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 99589, 99610);
                    return return_v;
                }


                int
                f_1562_99658_99669(System.Management.Automation.PSScriptCmdlet
                this_param)
                {
                    this_param.ExitScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 99658, 99669);
                    return 0;
                }


                object
                f_1562_99969_99980(System.Management.Automation.ExitException
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 99969, 99980);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_99999_100011(System.Management.Automation.PSScriptCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 99999, 100011);
                    return return_v;
                }


                int
                f_1562_99999_100071(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, int
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 99999, 100071);
                    return 0;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1562_100151_100184(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 100151, 100184);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 97113, 100253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 97113, 100253);
            }
        }

        public object GetDynamicParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 100265, 101396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 100326, 100378);

                _commandRuntime = (MshCommandRuntime)commandRuntime;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 100394, 101357) || true) && (f_1562_100398_100431(_scriptBlock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 100394, 101357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 100465, 100501);

                    var
                    resultList = f_1562_100482_100500()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 100519, 100614);

                    f_1562_100519_100613(_functionContext._outputPipe == null, "Output pipe should not be set yet.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 100632, 100684);

                    _functionContext._outputPipe = f_1562_100663_100683(resultList);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 100702, 100952);

                    f_1562_100702_100951(this, clause: (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 100742, 100755) || ((_runOptimized && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 100758, 100788)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 100791, 100832))) ? f_1562_100758_100788(_scriptBlock) : f_1562_100791_100832(_scriptBlock), dollarUnderbar: f_1562_100871_100891(), inputToProcess: f_1562_100930_100950());

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 100970, 101255) || true) && (f_1562_100974_100990(resultList) > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 100970, 101255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 101036, 101236);

                        throw f_1562_101042_101235(f_1562_101111_101158(), f_1562_101185_101234(f_1562_101209_101221(this), resultList));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 100970, 101255);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 101275, 101342);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 101282, 101303) || ((f_1562_101282_101298(resultList) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 101306, 101310)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 101313, 101341))) ? null : f_1562_101313_101341(f_1562_101327_101340(resultList, 0));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 100394, 101357);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 101373, 101385);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 100265, 101396);

                bool
                f_1562_100398_100431(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.HasDynamicParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 100398, 100431);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1562_100482_100500()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 100482, 100500);
                    return return_v;
                }


                int
                f_1562_100519_100613(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 100519, 100613);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1562_100663_100683(System.Collections.Generic.List<object>
                resultList)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(resultList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 100663, 100683);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_100758_100788(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.DynamicParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 100758, 100788);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1562_100791_100832(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UnoptimizedDynamicParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 100791, 100832);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1562_100871_100891()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 100871, 100891);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1562_100930_100950()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 100930, 100950);
                    return return_v;
                }


                int
                f_1562_100702_100951(System.Management.Automation.PSScriptCmdlet
                this_param, System.Action<System.Management.Automation.Language.FunctionContext>
                clause, System.Management.Automation.PSObject
                dollarUnderbar, System.Management.Automation.PSObject
                inputToProcess)
                {
                    this_param.RunClause(clause: clause, dollarUnderbar: (object)dollarUnderbar, inputToProcess: (object)inputToProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 100702, 100951);
                    return 0;
                }


                int
                f_1562_100974_100990(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 100974, 100990);
                    return return_v;
                }


                string
                f_1562_101111_101158()
                {
                    var return_v = AutomationExceptions.DynamicParametersWrongType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 101111, 101158);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_101209_101221(System.Management.Automation.PSScriptCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 101209, 101221);
                    return return_v;
                }


                string
                f_1562_101185_101234(System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.List<object>
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, (object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 101185, 101234);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1562_101042_101235(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 101042, 101235);
                    return return_v;
                }


                int
                f_1562_101282_101298(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 101282, 101298);
                    return return_v;
                }


                object
                f_1562_101327_101340(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 101327, 101340);
                    return return_v;
                }


                object
                f_1562_101313_101341(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 101313, 101341);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 100265, 101396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 100265, 101396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetLocalsTupleForNewScope(SessionStateScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 101586, 101835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 101675, 101777);

                f_1562_101675_101776(f_1562_101694_101711(scope) == null, "a newly created scope shouldn't have it's tuple set.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 101791, 101824);

                scope.LocalsTuple = _localsTuple;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 101586, 101835);

                System.Management.Automation.MutableTuple
                f_1562_101694_101711(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.LocalsTuple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 101694, 101711);
                    return return_v;
                }


                int
                f_1562_101675_101776(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 101675, 101776);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 101586, 101835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 101586, 101835);
            }
        }

        internal void PushDottedScope(SessionStateScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 102077, 102117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 102080, 102117);
                f_1562_102080_102117(f_1562_102080_102098(scope), _localsTuple);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 102077, 102117);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 102077, 102117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 102077, 102117);
            }

            System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
            f_1562_102080_102098(System.Management.Automation.SessionStateScope
            this_param)
            {
                var return_v = this_param.DottedScopes;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 102080, 102098);
                return return_v;
            }


            int
            f_1562_102080_102117(System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
            this_param, System.Management.Automation.MutableTuple
            item)
            {
                this_param.Push(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 102080, 102117);
                return 0;
            }

        }

        internal void PopDottedScope(SessionStateScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 102360, 102387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 102363, 102387);
                f_1562_102363_102387(f_1562_102363_102381(scope));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 102360, 102387);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 102360, 102387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 102360, 102387);
            }

            System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
            f_1562_102363_102381(System.Management.Automation.SessionStateScope
            this_param)
            {
                var return_v = this_param.DottedScopes;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 102363, 102381);
                return return_v;
            }


            System.Management.Automation.MutableTuple
            f_1562_102363_102387(System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
            this_param)
            {
                var return_v = this_param.Pop();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 102363, 102387);
                return return_v;
            }

        }

        internal void PrepareForBinding(CommandLineParameters commandLineParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 102400, 102830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 102501, 102704);

                f_1562_102501_102703(_localsTuple, AutomaticVariable.PSBoundParameters, value: f_1562_102614_102671(commandLineParameters), f_1562_102690_102702(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 102718, 102819);

                f_1562_102718_102818(_localsTuple, AutomaticVariable.MyInvocation, value: f_1562_102791_102803(), f_1562_102805_102817(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 102400, 102830);

                object
                f_1562_102614_102671(System.Management.Automation.CommandLineParameters
                this_param)
                {
                    var return_v = this_param.GetValueToBindToPSBoundParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 102614, 102671);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_102690_102702(System.Management.Automation.PSScriptCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 102690, 102702);
                    return return_v;
                }


                int
                f_1562_102501_102703(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, value: value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 102501, 102703);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1562_102791_102803()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 102791, 102803);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1562_102805_102817(System.Management.Automation.PSScriptCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 102805, 102817);
                    return return_v;
                }


                int
                f_1562_102718_102818(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, System.Management.Automation.InvocationInfo
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, value: (object)value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 102718, 102818);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 102400, 102830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 102400, 102830);
            }
        }

        private void SetPreferenceVariables()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 102842, 104549);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 102904, 103178) || true) && (f_1562_102908_102938(_commandRuntime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 102904, 103178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 102972, 103163);

                    f_1562_102972_103162(_localsTuple, PreferenceVariable.Debug, (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 103076, 103097) || ((f_1562_103076_103097(_commandRuntime) && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 103100, 103125)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 103128, 103161))) ? ActionPreference.Continue : ActionPreference.SilentlyContinue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 102904, 103178);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 103194, 103474) || true) && (f_1562_103198_103230(_commandRuntime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 103194, 103474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 103264, 103459);

                    f_1562_103264_103458(_localsTuple, PreferenceVariable.Verbose, (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 103370, 103393) || ((f_1562_103370_103393(_commandRuntime) && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 103396, 103421)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 103424, 103457))) ? ActionPreference.Continue : ActionPreference.SilentlyContinue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 103194, 103474);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 103490, 103665) || true) && (f_1562_103494_103526(_commandRuntime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 103490, 103665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 103560, 103650);

                    f_1562_103560_103649(_localsTuple, PreferenceVariable.Error, f_1562_103621_103648(_commandRuntime));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 103490, 103665);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 103681, 103866) || true) && (f_1562_103685_103719(_commandRuntime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 103681, 103866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 103753, 103851);

                    f_1562_103753_103850(_localsTuple, PreferenceVariable.Warning, f_1562_103816_103849(_commandRuntime));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 103681, 103866);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 103882, 104079) || true) && (f_1562_103886_103924(_commandRuntime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 103882, 104079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 103958, 104064);

                    f_1562_103958_104063(_localsTuple, PreferenceVariable.Information, f_1562_104025_104062(_commandRuntime));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 103882, 104079);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 104095, 104265) || true) && (f_1562_104099_104130(_commandRuntime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 104095, 104265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 104164, 104250);

                    f_1562_104164_104249(_localsTuple, PreferenceVariable.WhatIf, f_1562_104226_104248(_commandRuntime));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 104095, 104265);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 104281, 104538) || true) && (f_1562_104285_104317(_commandRuntime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 104281, 104538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 104351, 104523);

                    f_1562_104351_104522(_localsTuple, PreferenceVariable.Confirm, (DynAbs.Tracing.TraceSender.Conditional_F1(1562, 104457, 104480) || ((f_1562_104457_104480(_commandRuntime) && DynAbs.Tracing.TraceSender.Conditional_F2(1562, 104483, 104500)) || DynAbs.Tracing.TraceSender.Conditional_F3(1562, 104503, 104521))) ? ConfirmImpact.Low : ConfirmImpact.None);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 104281, 104538);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 102842, 104549);

                bool
                f_1562_102908_102938(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsDebugFlagSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 102908, 102938);
                    return return_v;
                }


                bool
                f_1562_103076_103097(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 103076, 103097);
                    return return_v;
                }


                int
                f_1562_102972_103162(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.PreferenceVariable
                pref, System.Management.Automation.ActionPreference
                value)
                {
                    this_param.SetPreferenceVariable(pref, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 102972, 103162);
                    return 0;
                }


                bool
                f_1562_103198_103230(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsVerboseFlagSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 103198, 103230);
                    return return_v;
                }


                bool
                f_1562_103370_103393(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 103370, 103393);
                    return return_v;
                }


                int
                f_1562_103264_103458(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.PreferenceVariable
                pref, System.Management.Automation.ActionPreference
                value)
                {
                    this_param.SetPreferenceVariable(pref, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 103264, 103458);
                    return 0;
                }


                bool
                f_1562_103494_103526(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsErrorActionSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 103494, 103526);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1562_103621_103648(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 103621, 103648);
                    return return_v;
                }


                int
                f_1562_103560_103649(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.PreferenceVariable
                pref, System.Management.Automation.ActionPreference
                value)
                {
                    this_param.SetPreferenceVariable(pref, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 103560, 103649);
                    return 0;
                }


                bool
                f_1562_103685_103719(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsWarningActionSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 103685, 103719);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1562_103816_103849(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.WarningPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 103816, 103849);
                    return return_v;
                }


                int
                f_1562_103753_103850(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.PreferenceVariable
                pref, System.Management.Automation.ActionPreference
                value)
                {
                    this_param.SetPreferenceVariable(pref, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 103753, 103850);
                    return 0;
                }


                bool
                f_1562_103886_103924(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsInformationActionSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 103886, 103924);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1562_104025_104062(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.InformationPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 104025, 104062);
                    return return_v;
                }


                int
                f_1562_103958_104063(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.PreferenceVariable
                pref, System.Management.Automation.ActionPreference
                value)
                {
                    this_param.SetPreferenceVariable(pref, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 103958, 104063);
                    return 0;
                }


                bool
                f_1562_104099_104130(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsWhatIfFlagSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 104099, 104130);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1562_104226_104248(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.WhatIf;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 104226, 104248);
                    return return_v;
                }


                int
                f_1562_104164_104249(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.PreferenceVariable
                pref, System.Management.Automation.SwitchParameter
                value)
                {
                    this_param.SetPreferenceVariable(pref, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 104164, 104249);
                    return 0;
                }


                bool
                f_1562_104285_104317(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsConfirmFlagSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 104285, 104317);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1562_104457_104480(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.Confirm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 104457, 104480);
                    return return_v;
                }


                int
                f_1562_104351_104522(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.PreferenceVariable
                pref, System.Management.Automation.ConfirmImpact
                value)
                {
                    this_param.SetPreferenceVariable(pref, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 104351, 104522);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 102842, 104549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 102842, 104549);
            }
        }


        internal event EventHandler
StoppingEvent
;

        protected override void StopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 104682, 104847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 104747, 104800);

                f_1562_104747_104799(this.StoppingEvent, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 104814, 104836);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.StopProcessing(), 1562, 104814, 104835);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 104682, 104847);

                int
                f_1562_104747_104799(System.EventHandler
                eventHandler, System.Management.Automation.PSScriptCmdlet
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 104747, 104799);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 104682, 104847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 104682, 104847);
            }
        }

        private bool _disposed;

        internal event EventHandler
DisposingEvent
;

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1562, 105190, 105685);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 105236, 105305) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1562, 105236, 105305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 105283, 105290);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1562, 105236, 105305);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 105321, 105375);

                f_1562_105321_105374(
                            this.DisposingEvent, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 105389, 105411);

                commandRuntime = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 105425, 105456);

                currentObjectInPipeline = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 105470, 105485);

                f_1562_105470_105484(_input);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 105616, 105643);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InternalDispose(true), 1562, 105616, 105642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 105657, 105674);

                _disposed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1562, 105190, 105685);

                int
                f_1562_105321_105374(System.EventHandler
                eventHandler, System.Management.Automation.PSScriptCmdlet
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 105321, 105374);
                    return 0;
                }


                int
                f_1562_105470_105484(System.Collections.ArrayList
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 105470, 105484);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1562, 105190, 105685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 105190, 105685);
            }
        }

        static PSScriptCmdlet()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1562, 92539, 105723);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1562, 92539, 105723);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1562, 92539, 105723);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1562, 92539, 105723);

        System.Collections.ArrayList
        f_1562_92672_92687()
        {
            var return_v = new System.Collections.ArrayList();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 92672, 92687);
            return return_v;
        }


        bool
        f_1562_93424_93505(System.Management.Automation.ScriptBlock
        this_param, bool
        optimized)
        {
            var return_v = this_param.Compile(optimized: optimized);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 93424, 93505);
            return return_v;
        }


        System.Management.Automation.MutableTuple
        f_1562_93535_93578(System.Management.Automation.ScriptBlock
        this_param, bool
        createLocalScope)
        {
            var return_v = this_param.MakeLocalsTuple(createLocalScope);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 93535, 93578);
            return return_v;
        }


        int
        f_1562_93593_93669(System.Management.Automation.MutableTuple
        this_param, System.Management.Automation.AutomaticVariable
        auto, System.Management.Automation.PSScriptCmdlet
        value, System.Management.Automation.ExecutionContext
        context)
        {
            this_param.SetAutomaticVariable(auto, (object)value, context);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 93593, 93669);
            return 0;
        }


        int
        f_1562_93684_93751(System.Management.Automation.ScriptBlock
        this_param, System.Management.Automation.MutableTuple
        locals, System.Management.Automation.ExecutionContext
        context)
        {
            this_param.SetPSScriptRootAndPSCommandPath(locals, context);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 93684, 93751);
            return 0;
        }


        string
        f_1562_93937_93954(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.File;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 93937, 93954);
            return return_v;
        }


        System.Management.Automation.Language.IScriptExtent[]
        f_1562_93991_94018(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.SequencePoints;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 93991, 94018);
            return return_v;
        }


        bool
        f_1562_94055_94082(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.DebuggerHidden;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 94055, 94082);
            return return_v;
        }


        bool
        f_1562_94124_94156(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.DebuggerStepThrough;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 94124, 94156);
            return return_v;
        }


        bool
        f_1562_94257_94304(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.ScriptCommandProcessorShouldRethrowExit;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1562, 94257, 94304);
            return return_v;
        }

    }
}
