// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Reflection;

using Dbg = System.Management.Automation.Diagnostics;

//
// Now define the set of commands for manipulating modules.
//

namespace Microsoft.PowerShell.Commands
{
    [Cmdlet(VerbsCommon.Remove, "Module", SupportsShouldProcess = true, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096802")]
    public sealed class RemoveModuleCommand : ModuleCmdletBase
    {
        [Parameter(Mandatory = true, ParameterSetName = "name", ValueFromPipeline = true, Position = 0)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public string[] Name
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1539, 1302, 1324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 1308, 1322);

                    _name = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1539, 1302, 1324);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1539, 1003, 1372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1539, 1003, 1372);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1539, 1340, 1361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 1346, 1359);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1539, 1340, 1361);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1539, 1003, 1372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1539, 1003, 1372);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string[] _name;

        [Parameter(Mandatory = true, ParameterSetName = "FullyQualifiedName", ValueFromPipeline = true, Position = 0)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public ModuleSpecification[] FullyQualifiedName { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "ModuleInfo", ValueFromPipeline = true, Position = 0)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public PSModuleInfo[] ModuleInfo
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1539, 2329, 2357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 2335, 2355);

                    _moduleInfo = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1539, 2329, 2357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1539, 2012, 2411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1539, 2012, 2411);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1539, 2373, 2400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 2379, 2398);

                    return _moduleInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1539, 2373, 2400);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1539, 2012, 2411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1539, 2012, 2411);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSModuleInfo[] _moduleInfo;

        [Parameter]
        public SwitchParameter Force
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1539, 2705, 2730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 2711, 2728);

                    return f_1539_2718_2727();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1539, 2705, 2730);

                    bool
                    f_1539_2718_2727()
                    {
                        var return_v = BaseForce;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 2718, 2727);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1539, 2631, 2783);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1539, 2631, 2783);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1539, 2746, 2772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 2752, 2770);

                    BaseForce = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1539, 2746, 2772);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1539, 2631, 2783);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1539, 2631, 2783);
                }
            }
        }

        private int _numberRemoved;

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1539, 3050, 12267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 3383, 3497);

                Dictionary<PSModuleInfo, List<PSModuleInfo>>
                modulesToRemove = f_1539_3446_3496()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 3513, 3673);
                    foreach (var m in f_1539_3531_3571_I(f_1539_3531_3571(f_1539_3531_3546(f_1539_3531_3538()), _name, false)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 3513, 3673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 3605, 3658);

                        f_1539_3605_3657(modulesToRemove, m, new List<PSModuleInfo> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => m, 1539, 3628, 3656) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 3513, 3673);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 161);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 3689, 4319) || true) && (f_1539_3693_3711() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 3689, 4319);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 4119, 4304);
                        foreach (var m in f_1539_4137_4190_I(f_1539_4137_4190(f_1539_4137_4152(f_1539_4137_4144()), f_1539_4164_4182(), false)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 4119, 4304);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 4232, 4285);

                            f_1539_4232_4284(modulesToRemove, m, new List<PSModuleInfo> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => m, 1539, 4255, 4283) });
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 4119, 4304);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 186);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 186);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 3689, 4319);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 4335, 4466);
                    foreach (var m in f_1539_4353_4364_I(_moduleInfo))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 4335, 4466);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 4398, 4451);

                        f_1539_4398_4450(modulesToRemove, m, new List<PSModuleInfo> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => m, 1539, 4421, 4449) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 4335, 4466);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 4578, 4690);

                Dictionary<PSModuleInfo, List<PSModuleInfo>>
                nestedModules = f_1539_4639_4689()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 4704, 5219);
                    foreach (var entry in f_1539_4726_4741_I(modulesToRemove))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 4704, 5219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 4775, 4798);

                        var
                        module = entry.Key
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 4816, 5204) || true) && (f_1539_4820_4840(module) != null && (DynAbs.Tracing.TraceSender.Expression_True(1539, 4820, 4882) && f_1539_4852_4878(f_1539_4852_4872(module)) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 4816, 5204);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 4924, 5007);

                            List<PSModuleInfo>
                            nestedModulesWithNoCircularReference = f_1539_4982_5006()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 5029, 5099);

                            f_1539_5029_5098(this, module, ref nestedModulesWithNoCircularReference);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 5121, 5185);

                            f_1539_5121_5184(nestedModules, module, nestedModulesWithNoCircularReference);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 4816, 5204);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 4704, 5219);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 516);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 5504, 5602);

                HashSet<PSModuleInfo>
                globalListOfModules = f_1539_5548_5601(f_1539_5574_5600())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 5618, 6314) || true) && (f_1539_5622_5641(nestedModules) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 5618, 6314);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 5679, 6299);
                        foreach (var entry in f_1539_5701_5714_I(nestedModules))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 5679, 6299);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 5756, 5789);

                            List<PSModuleInfo>
                            values = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 5811, 6280) || true) && (f_1539_5815_5865(modulesToRemove, entry.Key, out values))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 5811, 6280);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 5915, 6257);
                                    foreach (var module in f_1539_5938_5949_I(entry.Value))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 5915, 6257);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 6007, 6230) || true) && (!f_1539_6012_6048(globalListOfModules, module))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 6007, 6230);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 6114, 6133);

                                            f_1539_6114_6132(values, module);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 6167, 6199);

                                            f_1539_6167_6198(globalListOfModules, module);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 6007, 6230);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 5915, 6257);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 343);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 343);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 5811, 6280);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 5679, 6299);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 621);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 621);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 5618, 6314);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 6437, 6557);

                Dictionary<PSModuleInfo, List<PSModuleInfo>>
                actualModulesToRemove = f_1539_6506_6556()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 6802, 10448);
                    foreach (var entry in f_1539_6824_6839_I(modulesToRemove))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 6802, 10448);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 6873, 6930);

                        List<PSModuleInfo>
                        moduleList = f_1539_6905_6929()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 6957, 6982);
                            for (int
            i = f_1539_6961_6978(entry.Value) - 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 6948, 10367) || true) && (i >= 0)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 6992, 6995)
            , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 6948, 10367))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 6948, 10367);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 7037, 7074);

                                PSModuleInfo
                                module = f_1539_7059_7073(entry.Value, i)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 7153, 7739) || true) && (f_1539_7157_7174(module) == ModuleAccessMode.Constant)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 7153, 7739);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 7253, 7327);

                                    string
                                    message = f_1539_7270_7326(f_1539_7288_7312(), f_1539_7314_7325(module))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 7353, 7437);

                                    InvalidOperationException
                                    moduleNotRemoved = f_1539_7398_7436(message)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 7463, 7640);

                                    ErrorRecord
                                    er = f_1539_7480_7639(moduleNotRemoved, "Modules_ModuleIsConstant", ErrorCategory.PermissionDenied, module)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 7666, 7681);

                                    f_1539_7666_7680(this, er);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 7707, 7716);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 7153, 7739);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 7820, 8716) || true) && (f_1539_7824_7841(module) == ModuleAccessMode.ReadOnly && (DynAbs.Tracing.TraceSender.Expression_True(1539, 7824, 7884) && f_1539_7874_7884_M(!BaseForce)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 7820, 8716);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 7934, 8008);

                                    string
                                    message = f_1539_7951_8007(f_1539_7969_7993(), f_1539_7995_8006(module))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 8036, 8656) || true) && (f_1539_8040_8095(f_1539_8083_8094(module)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 8036, 8656);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 8153, 8175);

                                        f_1539_8153_8174(this, message);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 8036, 8656);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 8036, 8656);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 8289, 8373);

                                        InvalidOperationException
                                        moduleNotRemoved = f_1539_8334_8372(message)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 8403, 8584);

                                        ErrorRecord
                                        er = f_1539_8420_8583(moduleNotRemoved, "Modules_ModuleIsReadOnly", ErrorCategory.PermissionDenied, module)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 8614, 8629);

                                        f_1539_8614_8628(this, er);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 8036, 8656);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 8684, 8693);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 7820, 8716);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 8740, 8914) || true) && (!f_1539_8745_8832(this, f_1539_8759_8831(f_1539_8777_8804(), f_1539_8806_8817(module), f_1539_8819_8830(module))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 8740, 8914);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 8882, 8891);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 8740, 8914);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 9148, 10250) || true) && (f_1539_9152_9193(this, module))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 9148, 10250);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 9243, 9675) || true) && (f_1539_9247_9294(f_1539_9282_9293(module)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 9243, 9675);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 9352, 9607) || true) && (f_1539_9356_9366_M(!BaseForce))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 9352, 9607);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 9432, 9515);

                                            string
                                            message = f_1539_9449_9514(f_1539_9467_9500(), f_1539_9502_9513(module))
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 9549, 9576);

                                            f_1539_9549_9575(this, message);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 9352, 9607);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 9639, 9648);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 9243, 9675);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 9857, 9922);

                                    string
                                    moduleName = (DynAbs.Tracing.TraceSender.Conditional_F1(1539, 9877, 9896) || (((f_1539_9878_9890(_name) == 1) && DynAbs.Tracing.TraceSender.Conditional_F2(1539, 9899, 9907)) || DynAbs.Tracing.TraceSender.Conditional_F3(1539, 9910, 9921))) ? _name[0] : f_1539_9910_9921(module)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 9950, 10174);

                                    PSInvalidOperationException
                                    invalidOperation =
                                    f_1539_10026_10173(f_1539_10103_10127(), moduleName)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 10202, 10227);

                                    throw (invalidOperation);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 9148, 10250);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 10325, 10348);

                                f_1539_10325_10347(
                                                    // Add module to remove list.
                                                    moduleList, module);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 3420);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 3420);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 10387, 10433);

                        actualModulesToRemove[entry.Key] = moduleList;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 6802, 10448);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 3647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 3647);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 10552, 10646);

                Dictionary<PSModuleInfo, List<PSModuleInfo>>
                requiredDependencies = f_1539_10620_10645(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 10662, 12256);
                    foreach (var entry in f_1539_10684_10705_I(actualModulesToRemove))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 10662, 12256);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 10739, 12241);
                            foreach (var module in f_1539_10762_10773_I(entry.Value))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 10739, 12241);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 10815, 12115) || true) && (f_1539_10819_10829_M(!BaseForce))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 10815, 12115);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 10879, 10916);

                                    List<PSModuleInfo>
                                    requiredBy = null
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 10944, 12092) || true) && (f_1539_10948_11004(requiredDependencies, module, out requiredBy))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 10944, 12092);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 11071, 11095);
                                            for (int
                i = f_1539_11075_11091(requiredBy) - 1
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 11062, 11389) || true) && (i >= 0)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 11105, 11108)
                , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 11062, 11389))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 11062, 11389);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 11174, 11358) || true) && (f_1539_11178_11226(actualModulesToRemove, f_1539_11212_11225(requiredBy, i)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 11174, 11358);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 11300, 11323);

                                                    f_1539_11300_11322(requiredBy, i);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 11174, 11358);
                                                }
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 328);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 328);
                                        }
                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 11421, 12065) || true) && (f_1539_11425_11441(requiredBy) > 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 11421, 12065);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 11511, 11605);

                                            string
                                            message = f_1539_11528_11604(f_1539_11546_11570(), f_1539_11572_11583(module), f_1539_11585_11603(f_1539_11585_11598(requiredBy, 0)))
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 11639, 11723);

                                            InvalidOperationException
                                            moduleNotRemoved = f_1539_11684_11722(message)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 11757, 11942);

                                            ErrorRecord
                                            er = f_1539_11774_11941(moduleNotRemoved, "Modules_ModuleIsRequired", ErrorCategory.PermissionDenied, module)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 11976, 11991);

                                            f_1539_11976_11990(this, er);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 12025, 12034);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 11421, 12065);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 10944, 12092);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 10815, 12115);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 12139, 12156);

                                _numberRemoved++;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 12180, 12222);

                                f_1539_12180_12221(
                                                    this, module, f_1539_12206_12220(entry.Key));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 10739, 12241);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 1503);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 1503);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 10662, 12256);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 1595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 1595);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1539, 3050, 12267);

                System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                f_1539_3446_3496()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 3446, 3496);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1539_3531_3538()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 3531, 3538);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1539_3531_3546(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 3531, 3546);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1539_3531_3571(System.Management.Automation.ModuleIntrinsics
                this_param, string[]
                patterns, bool
                all)
                {
                    var return_v = this_param.GetModules(patterns, all);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 3531, 3571);
                    return return_v;
                }


                int
                f_1539_3605_3657(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                this_param, System.Management.Automation.PSModuleInfo
                key, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 3605, 3657);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1539_3531_3571_I(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 3531, 3571);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1539_3693_3711()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 3693, 3711);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1539_4137_4144()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 4137, 4144);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1539_4137_4152(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 4137, 4152);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1539_4164_4182()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 4164, 4182);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1539_4137_4190(System.Management.Automation.ModuleIntrinsics
                this_param, Microsoft.PowerShell.Commands.ModuleSpecification[]
                fullyQualifiedName, bool
                all)
                {
                    var return_v = this_param.GetModules(fullyQualifiedName, all);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 4137, 4190);
                    return return_v;
                }


                int
                f_1539_4232_4284(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                this_param, System.Management.Automation.PSModuleInfo
                key, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 4232, 4284);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1539_4137_4190_I(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 4137, 4190);
                    return return_v;
                }


                int
                f_1539_4398_4450(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                this_param, System.Management.Automation.PSModuleInfo
                key, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 4398, 4450);
                    return 0;
                }


                System.Management.Automation.PSModuleInfo[]
                f_1539_4353_4364_I(System.Management.Automation.PSModuleInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 4353, 4364);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                f_1539_4639_4689()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 4639, 4689);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1539_4820_4840(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 4820, 4840);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1539_4852_4872(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 4852, 4872);
                    return return_v;
                }


                int
                f_1539_4852_4878(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 4852, 4878);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1539_4982_5006()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 4982, 5006);
                    return return_v;
                }


                int
                f_1539_5029_5098(Microsoft.PowerShell.Commands.RemoveModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                module, ref System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                nestedModulesWithNoCircularReference)
                {
                    this_param.GetAllNestedModules(module, ref nestedModulesWithNoCircularReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 5029, 5098);
                    return 0;
                }


                int
                f_1539_5121_5184(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                this_param, System.Management.Automation.PSModuleInfo
                key, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 5121, 5184);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                f_1539_4726_4741_I(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 4726, 4741);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfoComparer
                f_1539_5574_5600()
                {
                    var return_v = new System.Management.Automation.PSModuleInfoComparer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 5574, 5600);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Management.Automation.PSModuleInfo>
                f_1539_5548_5601(System.Management.Automation.PSModuleInfoComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<System.Management.Automation.PSModuleInfo>((System.Collections.Generic.IEqualityComparer<System.Management.Automation.PSModuleInfo>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 5548, 5601);
                    return return_v;
                }


                int
                f_1539_5622_5641(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 5622, 5641);
                    return return_v;
                }


                bool
                f_1539_5815_5865(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                this_param, System.Management.Automation.PSModuleInfo
                key, out System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 5815, 5865);
                    return return_v;
                }


                bool
                f_1539_6012_6048(System.Collections.Generic.HashSet<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 6012, 6048);
                    return return_v;
                }


                int
                f_1539_6114_6132(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 6114, 6132);
                    return 0;
                }


                bool
                f_1539_6167_6198(System.Collections.Generic.HashSet<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 6167, 6198);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1539_5938_5949_I(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 5938, 5949);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                f_1539_5701_5714_I(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 5701, 5714);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                f_1539_6506_6556()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 6506, 6556);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1539_6905_6929()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 6905, 6929);
                    return return_v;
                }


                int
                f_1539_6961_6978(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 6961, 6978);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1539_7059_7073(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 7059, 7073);
                    return return_v;
                }


                System.Management.Automation.ModuleAccessMode
                f_1539_7157_7174(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 7157, 7174);
                    return return_v;
                }


                string
                f_1539_7288_7312()
                {
                    var return_v = Modules.ModuleIsConstant;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 7288, 7312);
                    return return_v;
                }


                string
                f_1539_7314_7325(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 7314, 7325);
                    return return_v;
                }


                string
                f_1539_7270_7326(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 7270, 7326);
                    return return_v;
                }


                System.InvalidOperationException
                f_1539_7398_7436(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 7398, 7436);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1539_7480_7639(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSModuleInfo
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 7480, 7639);
                    return return_v;
                }


                int
                f_1539_7666_7680(Microsoft.PowerShell.Commands.RemoveModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 7666, 7680);
                    return 0;
                }


                System.Management.Automation.ModuleAccessMode
                f_1539_7824_7841(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 7824, 7841);
                    return return_v;
                }


                bool
                f_1539_7874_7884_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 7874, 7884);
                    return return_v;
                }


                string
                f_1539_7969_7993()
                {
                    var return_v = Modules.ModuleIsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 7969, 7993);
                    return return_v;
                }


                string
                f_1539_7995_8006(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 7995, 8006);
                    return return_v;
                }


                string
                f_1539_7951_8007(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 7951, 8007);
                    return return_v;
                }


                string
                f_1539_8083_8094(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 8083, 8094);
                    return return_v;
                }


                bool
                f_1539_8040_8095(string
                moduleName)
                {
                    var return_v = InitialSessionState.IsConstantEngineModule(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 8040, 8095);
                    return return_v;
                }


                int
                f_1539_8153_8174(Microsoft.PowerShell.Commands.RemoveModuleCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 8153, 8174);
                    return 0;
                }


                System.InvalidOperationException
                f_1539_8334_8372(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 8334, 8372);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1539_8420_8583(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSModuleInfo
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 8420, 8583);
                    return return_v;
                }


                int
                f_1539_8614_8628(Microsoft.PowerShell.Commands.RemoveModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 8614, 8628);
                    return 0;
                }


                string
                f_1539_8777_8804()
                {
                    var return_v = Modules.ConfirmRemoveModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 8777, 8804);
                    return return_v;
                }


                string
                f_1539_8806_8817(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 8806, 8817);
                    return return_v;
                }


                string
                f_1539_8819_8830(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 8819, 8830);
                    return return_v;
                }


                string
                f_1539_8759_8831(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 8759, 8831);
                    return return_v;
                }


                bool
                f_1539_8745_8832(Microsoft.PowerShell.Commands.RemoveModuleCommand
                this_param, string
                target)
                {
                    var return_v = this_param.ShouldProcess(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 8745, 8832);
                    return return_v;
                }


                bool
                f_1539_9152_9193(Microsoft.PowerShell.Commands.RemoveModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                module)
                {
                    var return_v = this_param.ModuleProvidesCurrentSessionDrive(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 9152, 9193);
                    return return_v;
                }


                string
                f_1539_9282_9293(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 9282, 9293);
                    return return_v;
                }


                bool
                f_1539_9247_9294(string
                moduleName)
                {
                    var return_v = InitialSessionState.IsEngineModule(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 9247, 9294);
                    return return_v;
                }


                bool
                f_1539_9356_9366_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 9356, 9366);
                    return return_v;
                }


                string
                f_1539_9467_9500()
                {
                    var return_v = Modules.CoreModuleCannotBeRemoved;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 9467, 9500);
                    return return_v;
                }


                string
                f_1539_9502_9513(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 9502, 9513);
                    return return_v;
                }


                string
                f_1539_9449_9514(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 9449, 9514);
                    return return_v;
                }


                int
                f_1539_9549_9575(Microsoft.PowerShell.Commands.RemoveModuleCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 9549, 9575);
                    return 0;
                }


                int
                f_1539_9878_9890(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 9878, 9890);
                    return return_v;
                }


                string
                f_1539_9910_9921(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 9910, 9921);
                    return return_v;
                }


                string
                f_1539_10103_10127()
                {
                    var return_v = Modules.ModuleDriveInUse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 10103, 10127);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1539_10026_10173(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 10026, 10173);
                    return return_v;
                }


                int
                f_1539_10325_10347(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 10325, 10347);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                f_1539_6824_6839_I(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 6824, 6839);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                f_1539_10620_10645(Microsoft.PowerShell.Commands.RemoveModuleCommand
                this_param)
                {
                    var return_v = this_param.GetRequiredDependencies();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 10620, 10645);
                    return return_v;
                }


                bool
                f_1539_10819_10829_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 10819, 10829);
                    return return_v;
                }


                bool
                f_1539_10948_11004(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                this_param, System.Management.Automation.PSModuleInfo
                key, out System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 10948, 11004);
                    return return_v;
                }


                int
                f_1539_11075_11091(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 11075, 11091);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1539_11212_11225(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 11212, 11225);
                    return return_v;
                }


                bool
                f_1539_11178_11226(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                this_param, System.Management.Automation.PSModuleInfo
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 11178, 11226);
                    return return_v;
                }


                int
                f_1539_11300_11322(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 11300, 11322);
                    return 0;
                }


                int
                f_1539_11425_11441(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 11425, 11441);
                    return return_v;
                }


                string
                f_1539_11546_11570()
                {
                    var return_v = Modules.ModuleIsRequired;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 11546, 11570);
                    return return_v;
                }


                string
                f_1539_11572_11583(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 11572, 11583);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1539_11585_11598(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 11585, 11598);
                    return return_v;
                }


                string
                f_1539_11585_11603(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 11585, 11603);
                    return return_v;
                }


                string
                f_1539_11528_11604(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 11528, 11604);
                    return return_v;
                }


                System.InvalidOperationException
                f_1539_11684_11722(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 11684, 11722);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1539_11774_11941(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSModuleInfo
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 11774, 11941);
                    return return_v;
                }


                int
                f_1539_11976_11990(Microsoft.PowerShell.Commands.RemoveModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 11976, 11990);
                    return 0;
                }


                string
                f_1539_12206_12220(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 12206, 12220);
                    return return_v;
                }


                int
                f_1539_12180_12221(Microsoft.PowerShell.Commands.RemoveModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                module, string
                moduleNameInRemoveModuleCmdlet)
                {
                    this_param.RemoveModule(module, moduleNameInRemoveModuleCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 12180, 12221);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1539_10762_10773_I(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 10762, 10773);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                f_1539_10684_10705_I(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 10684, 10705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1539, 3050, 12267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1539, 3050, 12267);
            }
        }

        private bool ModuleProvidesCurrentSessionDrive(PSModuleInfo module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1539, 12279, 13600);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 12371, 13560) || true) && (f_1539_12375_12392(module) == ModuleType.Binary)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 12371, 13560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 12447, 12537);

                    Dictionary<string, List<ProviderInfo>>
                    providers = f_1539_12498_12536(f_1539_12498_12526(f_1539_12498_12505()))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 12555, 13545);
                        foreach (KeyValuePair<string, List<ProviderInfo>> pList in f_1539_12614_12623_I(providers))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 12555, 13545);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 12665, 12767);

                            f_1539_12665_12766(pList.Value != null, "There should never be a null list of entries in the provider table");
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 12789, 13526);
                                foreach (ProviderInfo pInfo in f_1539_12820_12831_I(pList.Value))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 12789, 13526);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 12881, 12956);

                                    string
                                    implTypeAssemblyLocation = f_1539_12915_12955(f_1539_12915_12946(f_1539_12915_12937(pInfo)))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 12982, 13503) || true) && (f_1539_12986_13066(implTypeAssemblyLocation, f_1539_13018_13029(module), StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 12982, 13503);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 13124, 13476);
                                            foreach (PSDriveInfo dInfo in f_1539_13154_13219_I(f_1539_13154_13219(f_1539_13154_13182(f_1539_13154_13161()), f_1539_13204_13218(pInfo))))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 13124, 13476);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 13285, 13445) || true) && (dInfo == f_1539_13298_13324(f_1539_13298_13316(f_1539_13298_13310())))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 13285, 13445);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 13398, 13410);

                                                    return true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 13285, 13445);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 13124, 13476);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 353);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 353);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 12982, 13503);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 12789, 13526);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 738);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 738);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 12555, 13545);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 991);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 991);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 12371, 13560);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 13576, 13589);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1539, 12279, 13600);

                System.Management.Automation.ModuleType
                f_1539_12375_12392(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 12375, 12392);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1539_12498_12505()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 12498, 12505);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1539_12498_12526(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TopLevelSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 12498, 12526);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1539_12498_12536(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 12498, 12536);
                    return return_v;
                }


                int
                f_1539_12665_12766(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 12665, 12766);
                    return 0;
                }


                System.Type
                f_1539_12915_12937(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 12915, 12937);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1539_12915_12946(System.Type
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 12915, 12946);
                    return return_v;
                }


                string
                f_1539_12915_12955(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 12915, 12955);
                    return return_v;
                }


                string
                f_1539_13018_13029(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 13018, 13029);
                    return return_v;
                }


                bool
                f_1539_12986_13066(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 12986, 13066);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1539_13154_13161()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 13154, 13161);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1539_13154_13182(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TopLevelSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 13154, 13182);
                    return return_v;
                }


                string
                f_1539_13204_13218(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 13204, 13218);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                f_1539_13154_13219(System.Management.Automation.SessionStateInternal
                this_param, string
                providerId)
                {
                    var return_v = this_param.GetDrivesForProvider(providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 13154, 13219);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1539_13298_13310()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 13298, 13310);
                    return return_v;
                }


                System.Management.Automation.DriveManagementIntrinsics
                f_1539_13298_13316(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 13298, 13316);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1539_13298_13324(System.Management.Automation.DriveManagementIntrinsics
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 13298, 13324);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                f_1539_13154_13219_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 13154, 13219);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                f_1539_12820_12831_I(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 12820, 12831);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1539_12614_12623_I(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 12614, 12623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1539, 12279, 13600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1539, 12279, 13600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetAllNestedModules(PSModuleInfo module, ref List<PSModuleInfo> nestedModulesWithNoCircularReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1539, 13612, 14505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 13751, 13811);

                List<PSModuleInfo>
                nestedModules = f_1539_13786_13810()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 13825, 14494) || true) && (f_1539_13829_13849(module) != null && (DynAbs.Tracing.TraceSender.Expression_True(1539, 13829, 13891) && f_1539_13861_13887(f_1539_13861_13881(module)) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 13825, 14494);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 13925, 14285);
                        foreach (var nestedModule in f_1539_13954_13974_I(f_1539_13954_13974(module)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 13925, 14285);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 14016, 14266) || true) && (!f_1539_14021_14080(nestedModulesWithNoCircularReference, nestedModule))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 14016, 14266);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 14130, 14185);

                                f_1539_14130_14184(nestedModulesWithNoCircularReference, nestedModule);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 14211, 14243);

                                f_1539_14211_14242(nestedModules, nestedModule);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 14016, 14266);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 13925, 14285);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 361);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 361);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 14305, 14479);
                        foreach (PSModuleInfo child in f_1539_14336_14349_I(nestedModules))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 14305, 14479);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 14391, 14460);

                            f_1539_14391_14459(this, child, ref nestedModulesWithNoCircularReference);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 14305, 14479);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 175);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 175);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 13825, 14494);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1539, 13612, 14505);

                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1539_13786_13810()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 13786, 13810);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1539_13829_13849(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 13829, 13849);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1539_13861_13881(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 13861, 13881);
                    return return_v;
                }


                int
                f_1539_13861_13887(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 13861, 13887);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1539_13954_13974(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 13954, 13974);
                    return return_v;
                }


                bool
                f_1539_14021_14080(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 14021, 14080);
                    return return_v;
                }


                int
                f_1539_14130_14184(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 14130, 14184);
                    return 0;
                }


                int
                f_1539_14211_14242(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 14211, 14242);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1539_13954_13974_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 13954, 13974);
                    return return_v;
                }


                int
                f_1539_14391_14459(Microsoft.PowerShell.Commands.RemoveModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                module, ref System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                nestedModulesWithNoCircularReference)
                {
                    this_param.GetAllNestedModules(module, ref nestedModulesWithNoCircularReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 14391, 14459);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1539_14336_14349_I(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 14336, 14349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1539, 13612, 14505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1539, 13612, 14505);
            }
        }

        private Dictionary<PSModuleInfo, List<PSModuleInfo>> GetRequiredDependencies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1539, 14645, 15543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 14748, 14867);

                Dictionary<PSModuleInfo, List<PSModuleInfo>>
                requiredDependencies = f_1539_14816_14866()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 14883, 15488);
                    foreach (PSModuleInfo module in f_1539_14915_14970_I(f_1539_14915_14970(f_1539_14915_14930(f_1539_14915_14922()), new string[] { "*" }, false)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 14883, 15488);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 15004, 15473);
                            foreach (PSModuleInfo requiredModule in f_1539_15044_15066_I(f_1539_15044_15066(module)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 15004, 15473);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 15108, 15149);

                                List<PSModuleInfo>
                                requiredByList = null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 15173, 15403) || true) && (!f_1539_15178_15246(requiredDependencies, requiredModule, out requiredByList))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 15173, 15403);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 15296, 15380);

                                    f_1539_15296_15379(requiredDependencies, requiredModule, requiredByList = f_1539_15354_15378());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 15173, 15403);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 15427, 15454);

                                f_1539_15427_15453(
                                                    requiredByList, module);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 15004, 15473);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 470);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 470);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 14883, 15488);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 606);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 15504, 15532);

                return requiredDependencies;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1539, 14645, 15543);

                System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                f_1539_14816_14866()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 14816, 14866);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1539_14915_14922()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 14915, 14922);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1539_14915_14930(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 14915, 14930);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1539_14915_14970(System.Management.Automation.ModuleIntrinsics
                this_param, string[]
                patterns, bool
                all)
                {
                    var return_v = this_param.GetModules(patterns, all);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 14915, 14970);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1539_15044_15066(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.RequiredModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 15044, 15066);
                    return return_v;
                }


                bool
                f_1539_15178_15246(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                this_param, System.Management.Automation.PSModuleInfo
                key, out System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 15178, 15246);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1539_15354_15378()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 15354, 15378);
                    return return_v;
                }


                int
                f_1539_15296_15379(System.Collections.Generic.Dictionary<System.Management.Automation.PSModuleInfo, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>>
                this_param, System.Management.Automation.PSModuleInfo
                key, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 15296, 15379);
                    return 0;
                }


                int
                f_1539_15427_15453(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 15427, 15453);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1539_15044_15066_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 15044, 15066);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1539_14915_14970_I(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 14915, 14970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1539, 14645, 15543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1539, 14645, 15543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1539, 15662, 17391);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 16019, 17380) || true) && (_numberRemoved == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1539, 16023, 16097) && !f_1539_16047_16097(f_1539_16047_16075(f_1539_16047_16059()), "WhatIf")))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 16019, 17380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 16131, 16156);

                    bool
                    hasWildcards = true
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 16174, 16201);

                    bool
                    isEngineModule = true
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 16219, 16566);
                        foreach (string n in f_1539_16240_16245_I(_name))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 16219, 16566);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 16287, 16425) || true) && (!f_1539_16292_16329(n))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 16287, 16425);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 16379, 16402);

                                isEngineModule = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 16287, 16425);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 16449, 16547) || true) && (!f_1539_16454_16499(n))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 16449, 16547);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 16526, 16547);

                                hasWildcards = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 16449, 16547);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 16219, 16566);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1539, 1, 348);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1539, 1, 348);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 16586, 16796) || true) && (f_1539_16590_16608() != null && (DynAbs.Tracing.TraceSender.Expression_True(1539, 16590, 16712) && (f_1539_16621_16711(f_1539_16621_16639(), moduleSpec => !InitialSessionState.IsEngineModule(moduleSpec.Name)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 16586, 16796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 16754, 16777);

                        isEngineModule = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 16586, 16796);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 16816, 17365) || true) && (!isEngineModule && (DynAbs.Tracing.TraceSender.Expression_True(1539, 16820, 16947) && (!hasWildcards || (DynAbs.Tracing.TraceSender.Expression_False(1539, 16840, 16880) || f_1539_16857_16875(_moduleInfo) != 0) || (DynAbs.Tracing.TraceSender.Expression_False(1539, 16840, 16946) || (f_1539_16885_16903() != null && (DynAbs.Tracing.TraceSender.Expression_True(1539, 16885, 16945) && f_1539_16915_16940(f_1539_16915_16933()) != 0))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1539, 16816, 17365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 16989, 17050);

                        string
                        message = f_1539_17006_17049(f_1539_17024_17048())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 17072, 17149);

                        InvalidOperationException
                        invalidOp = f_1539_17110_17148(message)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 17171, 17309);

                        ErrorRecord
                        er = f_1539_17188_17308(invalidOp, "Modules_NoModulesRemoved", ErrorCategory.ResourceUnavailable, null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 17331, 17346);

                        f_1539_17331_17345(this, er);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 16816, 17365);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1539, 16019, 17380);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1539, 15662, 17391);

                System.Management.Automation.InvocationInfo
                f_1539_16047_16059()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 16047, 16059);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1539_16047_16075(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 16047, 16075);
                    return return_v;
                }


                bool
                f_1539_16047_16097(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 16047, 16097);
                    return return_v;
                }


                bool
                f_1539_16292_16329(string
                moduleName)
                {
                    var return_v = InitialSessionState.IsEngineModule(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 16292, 16329);
                    return return_v;
                }


                bool
                f_1539_16454_16499(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 16454, 16499);
                    return return_v;
                }


                string[]
                f_1539_16240_16245_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 16240, 16245);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1539_16590_16608()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 16590, 16608);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1539_16621_16639()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 16621, 16639);
                    return return_v;
                }


                bool
                f_1539_16621_16711(Microsoft.PowerShell.Commands.ModuleSpecification[]
                source, System.Func<Microsoft.PowerShell.Commands.ModuleSpecification, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.PowerShell.Commands.ModuleSpecification>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 16621, 16711);
                    return return_v;
                }


                int
                f_1539_16857_16875(System.Management.Automation.PSModuleInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 16857, 16875);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1539_16885_16903()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 16885, 16903);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1539_16915_16933()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 16915, 16933);
                    return return_v;
                }


                int
                f_1539_16915_16940(Microsoft.PowerShell.Commands.ModuleSpecification[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 16915, 16940);
                    return return_v;
                }


                string
                f_1539_17024_17048()
                {
                    var return_v = Modules.NoModulesRemoved;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1539, 17024, 17048);
                    return return_v;
                }


                string
                f_1539_17006_17049(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 17006, 17049);
                    return return_v;
                }


                System.InvalidOperationException
                f_1539_17110_17148(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 17110, 17148);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1539_17188_17308(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 17188, 17308);
                    return return_v;
                }


                int
                f_1539_17331_17345(Microsoft.PowerShell.Commands.RemoveModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 17331, 17345);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1539, 15662, 17391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1539, 15662, 17391);
            }
        }

        public RemoveModuleCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1539, 679, 17398);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 1401, 1430);
            this._name = f_1539_1409_1430();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 1557, 1886);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 2446, 2487);
            this._moduleInfo = f_1539_2460_2487();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1539, 2807, 2825);
            this._numberRemoved = 0;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1539, 679, 17398);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1539, 679, 17398);
        }


        static RemoveModuleCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1539, 679, 17398);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1539, 679, 17398);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1539, 679, 17398);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1539, 679, 17398);

        string[]
        f_1539_1409_1430()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 1409, 1430);
            return return_v;
        }


        System.Management.Automation.PSModuleInfo[]
        f_1539_2460_2487()
        {
            var return_v = Array.Empty<PSModuleInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1539, 2460, 2487);
            return return_v;
        }

    }
}
