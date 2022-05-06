// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation.Configuration;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Text;
using System.Threading;

using Microsoft.PowerShell.Commands;
using Microsoft.Win32;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal static class Constants
    {
        public const string
        PSModulePathEnvVar = "PSModulePath"
        ;

        static Constants()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1532, 558, 669);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 626, 661);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1532, 558, 669);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 558, 669);
        }

    }
    public class ModuleIntrinsics
    {
        [TraceSource("Modules", "Module loading and analysis")]
        internal static PSTraceSource Tracer;

        private static readonly string s_windowsPowerShellPSHomeModulePath;

        internal ModuleIntrinsics(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1532, 1450, 1638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 1684, 1692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 1748, 1884);
                this.ModuleTable = f_1532_1813_1883(f_1532_1850_1882());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 2094, 2196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 2966, 3019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 1526, 1545);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 1611, 1627);

                f_1532_1611_1626();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1532, 1450, 1638);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 1450, 1638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 1450, 1638);
            }
        }

        private readonly ExecutionContext _context;

        internal Dictionary<string, PSModuleInfo> ModuleTable { get; }

        private const int
        MaxModuleNestingDepth = 10
        ;

        internal bool IsImplicitRemotingModuleLoaded
        {
            get;
            set;
        }

        internal void IncrementModuleNestingDepth(PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1532, 2208, 2842);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 2304, 2831) || true) && (f_1532_2308_2328_M(++ModuleNestingDepth) > MaxModuleNestingDepth)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 2304, 2831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 2386, 2481);

                    string
                    message = f_1532_2403_2480(f_1532_2421_2450(), path, MaxModuleNestingDepth)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 2499, 2570);

                    InvalidOperationException
                    ioe = f_1532_2531_2569(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 2588, 2718);

                    ErrorRecord
                    er = f_1532_2605_2717(ioe, "Modules_ModuleTooDeeplyNested", ErrorCategory.InvalidOperation, path)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 2783, 2816);

                    f_1532_2783_2815(                // NOTE: this call will throw
                                    cmdlet, er);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 2304, 2831);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1532, 2208, 2842);

                int
                f_1532_2308_2328_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 2308, 2328);
                    return return_v;
                }


                string
                f_1532_2421_2450()
                {
                    var return_v = Modules.ModuleTooDeeplyNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 2421, 2450);
                    return return_v;
                }


                string
                f_1532_2403_2480(string
                formatSpec, string
                o1, int
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 2403, 2480);
                    return return_v;
                }


                System.InvalidOperationException
                f_1532_2531_2569(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 2531, 2569);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1532_2605_2717(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 2605, 2717);
                    return return_v;
                }


                int
                f_1532_2783_2815(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 2783, 2815);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 2208, 2842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 2208, 2842);
            }
        }

        internal void DecrementModuleNestingCount()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1532, 2854, 2954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 2922, 2943);

                f_1532_2922_2942_M(--ModuleNestingDepth);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1532, 2854, 2954);

                int
                f_1532_2922_2942_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 2922, 2942);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 2854, 2954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 2854, 2954);
            }
        }

        internal int ModuleNestingDepth { get; private set; }

        internal PSModuleInfo CreateModule(string name, string path, ScriptBlock scriptBlock, SessionState ss, out List<object> results, params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1532, 3867, 4157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 4047, 4146);

                return f_1532_4054_4145(this, name, path, scriptBlock, null, ss, null, out results, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1532, 3867, 4157);

                System.Management.Automation.PSModuleInfo
                f_1532_4054_4145(System.Management.Automation.ModuleIntrinsics
                this_param, string
                name, string
                path, System.Management.Automation.ScriptBlock
                moduleCode, System.Management.Automation.Language.IScriptExtent
                scriptPosition, System.Management.Automation.SessionState
                ss, object
                privateData, out System.Collections.Generic.List<object>
                result, params object[]
                arguments)
                {
                    var return_v = this_param.CreateModuleImplementation(name, path, (object)moduleCode, scriptPosition, ss, privateData, out result, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 4054, 4145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 3867, 4157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 3867, 4157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSModuleInfo CreateModule(string path, ExternalScriptInfo scriptInfo, IScriptExtent scriptPosition, SessionState ss, object privateData, params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1532, 4925, 5313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 5122, 5142);

                List<object>
                result
                = default(List<object>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 5156, 5302);

                return f_1532_5163_5301(this, f_1532_5190_5226(path), path, scriptInfo, scriptPosition, ss, privateData, out result, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1532, 4925, 5313);

                string
                f_1532_5190_5226(string
                path)
                {
                    var return_v = ModuleIntrinsics.GetModuleName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 5190, 5226);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_5163_5301(System.Management.Automation.ModuleIntrinsics
                this_param, string
                name, string
                path, System.Management.Automation.ExternalScriptInfo
                moduleCode, System.Management.Automation.Language.IScriptExtent
                scriptPosition, System.Management.Automation.SessionState
                ss, object
                privateData, out System.Collections.Generic.List<object>
                result, params object[]
                arguments)
                {
                    var return_v = this_param.CreateModuleImplementation(name, path, (object)moduleCode, scriptPosition, ss, privateData, out result, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 5163, 5301);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 4925, 5313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 4925, 5313);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSModuleInfo CreateModuleImplementation(string name, string path, object moduleCode, IScriptExtent scriptPosition, SessionState ss, object privateData, out List<object> result, params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1532, 6530, 11408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 6766, 6781);

                ScriptBlock
                sb
                = default(ScriptBlock);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 7243, 7350) || true) && (ss == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 7243, 7350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 7291, 7335);

                    ss = f_1532_7296_7334(_context, true, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 7243, 7350);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 7452, 7519);

                SessionStateInternal
                oldSessionState = f_1532_7491_7518(_context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 7533, 7598);

                PSModuleInfo
                module = f_1532_7555_7597(name, path, _context, ss)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 7612, 7640);

                f_1532_7612_7623(ss).Module = module;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 7654, 7687);

                module.PrivateData = privateData;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 7703, 7728);

                bool
                setExitCode = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 7742, 7759);

                int
                exitCode = 0
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 7811, 7853);

                    _context.EngineSessionState = f_1532_7841_7852(ss);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8004, 8069);

                    ExternalScriptInfo
                    scriptInfo = moduleCode as ExternalScriptInfo
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8087, 8949) || true) && (scriptInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 8087, 8949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8151, 8179);

                        sb = f_1532_8156_8178(scriptInfo);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8203, 8252);

                        f_1532_8203_8251(f_1532_8203_8220(_context), scriptInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 8087, 8949);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 8087, 8949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8334, 8365);

                        sb = moduleCode as ScriptBlock;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8387, 8930) || true) && (sb != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 8387, 8930);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8451, 8504);

                            PSLanguageMode?
                            moduleLanguageMode = f_1532_8488_8503(sb)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8530, 8546);

                            sb = f_1532_8535_8545(sb);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8572, 8609);

                            sb.LanguageMode = moduleLanguageMode;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8637, 8658);

                            sb.SessionState = ss;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 8387, 8930);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 8387, 8930);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8756, 8790);

                            var
                            sbText = moduleCode as string
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8816, 8907) || true) && (sbText != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 8816, 8907);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8865, 8907);

                                sb = f_1532_8870_8906(_context, sbText);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 8816, 8907);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 8387, 8930);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 8087, 8949);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 8969, 9057) || true) && (sb == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 8969, 9057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 9006, 9057);

                        throw f_1532_9012_9056();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 8969, 9057);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 9077, 9115);

                    sb.SessionStateInternal = f_1532_9103_9114(ss);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 9133, 9171);

                    module.LanguageMode = f_1532_9155_9170(sb);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 9191, 9270);

                    InvocationInfo
                    invocationInfo = f_1532_9223_9269(scriptInfo, scriptPosition)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 9333, 9374);

                    module._definitionExtent = f_1532_9360_9373(f_1532_9360_9366(sb));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 9392, 9409);

                    var
                    ast = f_1532_9402_9408(sb)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 9427, 9530) || true) && (f_1532_9434_9444(ast) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 9427, 9530);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 9494, 9511);

                            ast = f_1532_9500_9510(ast);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 9427, 9530);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 9427, 9530);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 9427, 9530);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 9660, 9830);

                    f_1532_9660_9829(f_1532_9679_9734(f_1532_9679_9722(f_1532_9679_9709(f_1532_9679_9700(_context)))) == null, "No locals tuple should have been created yet.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 9850, 9895);

                    List<object>
                    resultList = f_1532_9876_9894()
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 9959, 9998);

                        Pipe
                        outputPipe = f_1532_9977_9997(resultList)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 10073, 10592);

                        f_1532_10073_10591(
                                            // And run the scriptblock...
                                            sb, useLocalScope: false, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1532_10284_10304(), input: f_1532_10338_10358(), scriptThis: f_1532_10397_10417(), outputPipe: outputPipe, invocationInfo: invocationInfo, args: arguments ?? (DynAbs.Tracing.TraceSender.Expression_Null<object[]>(1532, 10556, 10590) ?? f_1532_10569_10590()));
                    }
                    catch (ExitException ee)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1532, 10629, 10782);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 10694, 10722);

                        exitCode = (int)f_1532_10710_10721(ee);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 10744, 10763);

                        setExitCode = true;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1532, 10629, 10782);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 10802, 10822);

                    result = resultList;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1532, 10851, 10952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 10891, 10937);

                    _context.EngineSessionState = oldSessionState;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1532, 10851, 10952);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 10968, 11101) || true) && (setExitCode)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 10968, 11101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 11017, 11086);

                    f_1532_11017_11085(_context, SpecialVariables.LastExitCodeVarPath, exitCode);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 10968, 11101);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 11117, 11174);

                module.ImplementingAssembly = f_1532_11147_11173(sb);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 11304, 11367);

                f_1532_11304_11366(            // We force re-population of ExportedTypeDefinitions, now with the actual RuntimeTypes, created above.
                            module, f_1532_11341_11347(sb) as ScriptBlockAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 11383, 11397);

                return module;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1532, 6530, 11408);

                System.Management.Automation.SessionState
                f_1532_7296_7334(System.Management.Automation.ExecutionContext
                context, bool
                createAsChild, bool
                linkToGlobal)
                {
                    var return_v = new System.Management.Automation.SessionState(context, createAsChild, linkToGlobal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 7296, 7334);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_7491_7518(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 7491, 7518);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_7555_7597(string
                name, string
                path, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionState
                sessionState)
                {
                    var return_v = new System.Management.Automation.PSModuleInfo(name, path, context, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 7555, 7597);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_7612_7623(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 7612, 7623);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_7841_7852(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 7841, 7852);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1532_8156_8178(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 8156, 8178);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1532_8203_8220(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 8203, 8220);
                    return return_v;
                }


                int
                f_1532_8203_8251(System.Management.Automation.ScriptDebugger
                this_param, System.Management.Automation.ExternalScriptInfo
                scriptCommandInfo)
                {
                    this_param.RegisterScriptFile(scriptCommandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 8203, 8251);
                    return 0;
                }


                System.Management.Automation.PSLanguageMode?
                f_1532_8488_8503(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 8488, 8503);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1532_8535_8545(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 8535, 8545);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1532_8870_8906(System.Management.Automation.ExecutionContext
                context, string
                script)
                {
                    var return_v = ScriptBlock.Create(context, script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 8870, 8906);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1532_9012_9056()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 9012, 9056);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_9103_9114(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 9103, 9114);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1532_9155_9170(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 9155, 9170);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1532_9223_9269(System.Management.Automation.ExternalScriptInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition)
                {
                    var return_v = new System.Management.Automation.InvocationInfo((System.Management.Automation.CommandInfo)commandInfo, scriptPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 9223, 9269);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1532_9360_9366(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 9360, 9366);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1532_9360_9373(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 9360, 9373);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1532_9402_9408(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 9402, 9408);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1532_9434_9444(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 9434, 9444);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1532_9500_9510(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 9500, 9510);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1532_9679_9700(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 9679, 9700);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_9679_9709(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 9679, 9709);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1532_9679_9722(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 9679, 9722);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1532_9679_9734(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.LocalsTuple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 9679, 9734);
                    return return_v;
                }


                int
                f_1532_9660_9829(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 9660, 9829);
                    return 0;
                }


                System.Collections.Generic.List<object>
                f_1532_9876_9894()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 9876, 9894);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1532_9977_9997(System.Collections.Generic.List<object>
                resultList)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(resultList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 9977, 9997);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1532_10284_10304()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 10284, 10304);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1532_10338_10358()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 10338, 10358);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1532_10397_10417()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 10397, 10417);
                    return return_v;
                }


                object[]
                f_1532_10569_10590()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 10569, 10590);
                    return return_v;
                }


                int
                f_1532_10073_10591(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, System.Management.Automation.PSObject
                input, System.Management.Automation.PSObject
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, object[]
                args)
                {
                    this_param.InvokeWithPipe(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, outputPipe: outputPipe, invocationInfo: invocationInfo, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 10073, 10591);
                    return 0;
                }


                object
                f_1532_10710_10721(System.Management.Automation.ExitException
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 10710, 10721);
                    return return_v;
                }


                int
                f_1532_11017_11085(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, int
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 11017, 11085);
                    return 0;
                }


                System.Reflection.Assembly
                f_1532_11147_11173(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.AssemblyDefiningPSTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 11147, 11173);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1532_11341_11347(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 11341, 11347);
                    return return_v;
                }


                int
                f_1532_11304_11366(System.Management.Automation.PSModuleInfo
                this_param, System.Management.Automation.Language.Ast
                moduleContentScriptBlockAsts)
                {
                    this_param.CreateExportedTypeDefinitions((System.Management.Automation.Language.ScriptBlockAst)moduleContentScriptBlockAsts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 11304, 11366);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 6530, 11408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 6530, 11408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ScriptBlock CreateBoundScriptBlock(ExecutionContext context, ScriptBlock sb, bool linkToGlobal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1532, 11893, 12156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 12022, 12084);

                PSModuleInfo
                module = f_1532_12044_12083(context, linkToGlobal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 12098, 12145);

                return f_1532_12105_12144(module, sb, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1532, 11893, 12156);

                System.Management.Automation.PSModuleInfo
                f_1532_12044_12083(System.Management.Automation.ExecutionContext
                context, bool
                linkToGlobal)
                {
                    var return_v = new System.Management.Automation.PSModuleInfo(context, linkToGlobal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 12044, 12083);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1532_12105_12144(System.Management.Automation.PSModuleInfo
                this_param, System.Management.Automation.ScriptBlock
                scriptBlockToBind, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = this_param.NewBoundScriptBlock(scriptBlockToBind, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 12105, 12144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 11893, 12156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 11893, 12156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<PSModuleInfo> GetModules(string[] patterns, bool all)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1532, 12168, 12314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 12260, 12303);

                return f_1532_12267_12302(this, patterns, all, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1532, 12168, 12314);

                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1532_12267_12302(System.Management.Automation.ModuleIntrinsics
                this_param, string[]
                patterns, bool
                all, bool
                exactMatch)
                {
                    var return_v = this_param.GetModuleCore(patterns, all, exactMatch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 12267, 12302);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 12168, 12314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 12168, 12314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<PSModuleInfo> GetExactMatchModules(string moduleName, bool all, bool exactMatch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1532, 12326, 12593);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 12445, 12499) || true) && (moduleName == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 12445, 12499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 12471, 12497);

                    moduleName = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 12445, 12499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 12515, 12582);

                return f_1532_12522_12581(this, new string[] { moduleName }, all, exactMatch);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1532, 12326, 12593);

                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1532_12522_12581(System.Management.Automation.ModuleIntrinsics
                this_param, string[]
                patterns, bool
                all, bool
                exactMatch)
                {
                    var return_v = this_param.GetModuleCore(patterns, all, exactMatch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 12522, 12581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 12326, 12593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 12326, 12593);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<PSModuleInfo> GetModuleCore(string[] patterns, bool all, bool exactMatch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1532, 12605, 16056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 12716, 12747);

                string
                targetModuleName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 12761, 12821);

                List<WildcardPattern>
                wcpList = f_1532_12793_12820()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 12837, 13427) || true) && (exactMatch)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 12837, 13427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 12885, 12998);

                    f_1532_12885_12997(f_1532_12896_12911(patterns) == 1, "The 'patterns' should only contain one element when it is for an exact match");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 13016, 13047);

                    targetModuleName = patterns[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 12837, 13427);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 12837, 13427);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 13113, 13226) || true) && (patterns == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 13113, 13226);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 13175, 13207);

                        patterns = new string[] { "*" };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 13113, 13226);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 13246, 13412);
                        foreach (string pattern in f_1532_13273_13281_I(patterns))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 13246, 13412);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 13323, 13393);

                            f_1532_13323_13392(wcpList, f_1532_13335_13391(pattern, WildcardOptions.IgnoreCase));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 13246, 13412);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 167);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 167);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 12837, 13427);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 13443, 13504);

                List<PSModuleInfo>
                modulesMatched = f_1532_13479_13503()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 13520, 15977) || true) && (all)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 13520, 15977);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 13561, 14049);
                        foreach (PSModuleInfo module in f_1532_13593_13611_I(f_1532_13593_13611(f_1532_13593_13604())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 13561, 14049);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 13716, 14030) || true) && ((exactMatch && (DynAbs.Tracing.TraceSender.Expression_True(1532, 13721, 13807) && f_1532_13735_13807(f_1532_13735_13746(module), targetModuleName, StringComparison.OrdinalIgnoreCase))) || (DynAbs.Tracing.TraceSender.Expression_False(1532, 13720, 13930) || (!exactMatch && (DynAbs.Tracing.TraceSender.Expression_True(1532, 13838, 13929) && f_1532_13853_13929(f_1532_13901_13912(module), wcpList, false)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 13716, 14030);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 13980, 14007);

                                f_1532_13980_14006(modulesMatched, module);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 13716, 14030);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 13561, 14049);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 489);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 489);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 13520, 15977);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 13520, 15977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 14283, 14379);

                    Dictionary<string, bool>
                    found = f_1532_14316_14378(f_1532_14345_14377())
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 14397, 15040);
                        foreach (var pair in f_1532_14418_14457_I(f_1532_14418_14457(f_1532_14418_14445(_context))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 14397, 15040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 14499, 14522);

                            string
                            path = pair.Key
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 14544, 14577);

                            PSModuleInfo
                            module = pair.Value
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 14662, 15021) || true) && ((exactMatch && (DynAbs.Tracing.TraceSender.Expression_True(1532, 14667, 14753) && f_1532_14681_14753(f_1532_14681_14692(module), targetModuleName, StringComparison.OrdinalIgnoreCase))) || (DynAbs.Tracing.TraceSender.Expression_False(1532, 14666, 14876) || (!exactMatch && (DynAbs.Tracing.TraceSender.Expression_True(1532, 14784, 14875) && f_1532_14799_14875(f_1532_14847_14858(module), wcpList, false)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 14662, 15021);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 14926, 14953);

                                f_1532_14926_14952(modulesMatched, module);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 14979, 14998);

                                found[path] = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 14662, 15021);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 14397, 15040);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 644);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 644);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 15060, 15962) || true) && (f_1532_15064_15091(_context) != f_1532_15095_15124(_context))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 15060, 15962);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 15166, 15943);
                            foreach (var pair in f_1532_15187_15228_I(f_1532_15187_15228(f_1532_15187_15216(_context))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 15166, 15943);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 15278, 15301);

                                string
                                path = pair.Key
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 15327, 15920) || true) && (!f_1532_15332_15355(found, path))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 15327, 15920);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 15413, 15446);

                                    PSModuleInfo
                                    module = pair.Value
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 15547, 15893) || true) && ((exactMatch && (DynAbs.Tracing.TraceSender.Expression_True(1532, 15552, 15638) && f_1532_15566_15638(f_1532_15566_15577(module), targetModuleName, StringComparison.OrdinalIgnoreCase))) || (DynAbs.Tracing.TraceSender.Expression_False(1532, 15551, 15769) || (!exactMatch && (DynAbs.Tracing.TraceSender.Expression_True(1532, 15677, 15768) && f_1532_15692_15768(f_1532_15740_15751(module), wcpList, false)))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 15547, 15893);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 15835, 15862);

                                        f_1532_15835_15861(modulesMatched, module);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 15547, 15893);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 15327, 15920);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 15166, 15943);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 778);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 778);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 15060, 15962);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 13520, 15977);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 15993, 16045);

                return f_1532_16000_16044(f_1532_16000_16035(modulesMatched, m => m.Name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1532, 12605, 16056);

                System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                f_1532_12793_12820()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPattern>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 12793, 12820);
                    return return_v;
                }


                int
                f_1532_12896_12911(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 12896, 12911);
                    return return_v;
                }


                int
                f_1532_12885_12997(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 12885, 12997);
                    return 0;
                }


                System.Management.Automation.WildcardPattern
                f_1532_13335_13391(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 13335, 13391);
                    return return_v;
                }


                int
                f_1532_13323_13392(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                this_param, System.Management.Automation.WildcardPattern
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 13323, 13392);
                    return 0;
                }


                string[]
                f_1532_13273_13281_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 13273, 13281);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1532_13479_13503()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 13479, 13503);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1532_13593_13604()
                {
                    var return_v = ModuleTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 13593, 13604);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
                f_1532_13593_13611(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 13593, 13611);
                    return return_v;
                }


                string
                f_1532_13735_13746(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 13735, 13746);
                    return return_v;
                }


                bool
                f_1532_13735_13807(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 13735, 13807);
                    return return_v;
                }


                string
                f_1532_13901_13912(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 13901, 13912);
                    return return_v;
                }


                bool
                f_1532_13853_13929(string
                text, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 13853, 13929);
                    return return_v;
                }


                int
                f_1532_13980_14006(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 13980, 14006);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
                f_1532_13593_13611_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 13593, 13611);
                    return return_v;
                }


                System.StringComparer
                f_1532_14345_14377()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 14345, 14377);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, bool>
                f_1532_14316_14378(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, bool>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 14316, 14378);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_14418_14445(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 14418, 14445);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1532_14418_14457(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ModuleTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 14418, 14457);
                    return return_v;
                }


                string
                f_1532_14681_14692(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 14681, 14692);
                    return return_v;
                }


                bool
                f_1532_14681_14753(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 14681, 14753);
                    return return_v;
                }


                string
                f_1532_14847_14858(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 14847, 14858);
                    return return_v;
                }


                bool
                f_1532_14799_14875(string
                text, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 14799, 14875);
                    return return_v;
                }


                int
                f_1532_14926_14952(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 14926, 14952);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1532_14418_14457_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 14418, 14457);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_15064_15091(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 15064, 15091);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_15095_15124(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TopLevelSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 15095, 15124);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_15187_15216(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TopLevelSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 15187, 15216);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1532_15187_15228(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ModuleTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 15187, 15228);
                    return return_v;
                }


                bool
                f_1532_15332_15355(System.Collections.Generic.Dictionary<string, bool>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 15332, 15355);
                    return return_v;
                }


                string
                f_1532_15566_15577(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 15566, 15577);
                    return return_v;
                }


                bool
                f_1532_15566_15638(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 15566, 15638);
                    return return_v;
                }


                string
                f_1532_15740_15751(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 15740, 15751);
                    return return_v;
                }


                bool
                f_1532_15692_15768(string
                text, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 15692, 15768);
                    return return_v;
                }


                int
                f_1532_15835_15861(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 15835, 15861);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1532_15187_15228_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 15187, 15228);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Management.Automation.PSModuleInfo>
                f_1532_16000_16035(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                source, System.Func<System.Management.Automation.PSModuleInfo, string>
                keySelector)
                {
                    var return_v = source.OrderBy<System.Management.Automation.PSModuleInfo, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 16000, 16035);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1532_16000_16044(System.Linq.IOrderedEnumerable<System.Management.Automation.PSModuleInfo>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 16000, 16044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 12605, 16056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 12605, 16056);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<PSModuleInfo> GetModules(ModuleSpecification[] fullyQualifiedName, bool all)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1532, 16068, 18652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 16183, 16244);

                List<PSModuleInfo>
                modulesMatched = f_1532_16219_16243()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 16260, 18573) || true) && (all)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 16260, 18573);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 16301, 16759);
                        foreach (var moduleSpec in f_1532_16328_16346_I(fullyQualifiedName))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 16301, 16759);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 16388, 16740);
                                foreach (PSModuleInfo module in f_1532_16420_16438_I(f_1532_16420_16438(f_1532_16420_16431())))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 16388, 16740);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 16555, 16717) || true) && (f_1532_16559_16605(module, moduleSpec))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 16555, 16717);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 16663, 16690);

                                        f_1532_16663_16689(modulesMatched, module);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 16555, 16717);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 16388, 16740);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 353);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 353);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 16301, 16759);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 459);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 459);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 16260, 18573);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 16260, 18573);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 16825, 18558);
                        foreach (var moduleSpec in f_1532_16852_16870_I(fullyQualifiedName))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 16825, 18558);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 17088, 17184);

                            Dictionary<string, bool>
                            found = f_1532_17121_17183(f_1532_17150_17182())
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 17206, 17725);
                                foreach (var pair in f_1532_17227_17266_I(f_1532_17227_17266(f_1532_17227_17254(_context))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 17206, 17725);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 17316, 17339);

                                    string
                                    path = pair.Key
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 17365, 17398);

                                    PSModuleInfo
                                    module = pair.Value
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 17491, 17702) || true) && (f_1532_17495_17541(module, moduleSpec))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 17491, 17702);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 17599, 17626);

                                        f_1532_17599_17625(modulesMatched, module);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 17656, 17675);

                                        found[path] = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 17491, 17702);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 17206, 17725);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 520);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 520);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 17749, 18539) || true) && (f_1532_17753_17780(_context) != f_1532_17784_17813(_context))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 17749, 18539);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 17863, 18516);
                                    foreach (var pair in f_1532_17884_17925_I(f_1532_17884_17925(f_1532_17884_17913(_context))))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 17863, 18516);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 17983, 18006);

                                        string
                                        path = pair.Key
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 18036, 18489) || true) && (!f_1532_18041_18064(found, path))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 18036, 18489);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 18130, 18163);

                                            PSModuleInfo
                                            module = pair.Value
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 18272, 18458) || true) && (f_1532_18276_18322(module, moduleSpec))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 18272, 18458);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 18396, 18423);

                                                f_1532_18396_18422(modulesMatched, module);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 18272, 18458);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 18036, 18489);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 17863, 18516);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 654);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 654);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 17749, 18539);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 16825, 18558);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 1734);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 1734);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 16260, 18573);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 18589, 18641);

                return f_1532_18596_18640(f_1532_18596_18631(modulesMatched, m => m.Name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1532, 16068, 18652);

                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1532_16219_16243()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 16219, 16243);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1532_16420_16431()
                {
                    var return_v = ModuleTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 16420, 16431);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
                f_1532_16420_16438(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 16420, 16438);
                    return return_v;
                }


                bool
                f_1532_16559_16605(System.Management.Automation.PSModuleInfo
                moduleInfo, Microsoft.PowerShell.Commands.ModuleSpecification
                moduleSpec)
                {
                    var return_v = IsModuleMatchingModuleSpec(moduleInfo, moduleSpec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 16559, 16605);
                    return return_v;
                }


                int
                f_1532_16663_16689(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 16663, 16689);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
                f_1532_16420_16438_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 16420, 16438);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1532_16328_16346_I(Microsoft.PowerShell.Commands.ModuleSpecification[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 16328, 16346);
                    return return_v;
                }


                System.StringComparer
                f_1532_17150_17182()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 17150, 17182);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, bool>
                f_1532_17121_17183(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, bool>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 17121, 17183);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_17227_17254(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 17227, 17254);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1532_17227_17266(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ModuleTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 17227, 17266);
                    return return_v;
                }


                bool
                f_1532_17495_17541(System.Management.Automation.PSModuleInfo
                moduleInfo, Microsoft.PowerShell.Commands.ModuleSpecification
                moduleSpec)
                {
                    var return_v = IsModuleMatchingModuleSpec(moduleInfo, moduleSpec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 17495, 17541);
                    return return_v;
                }


                int
                f_1532_17599_17625(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 17599, 17625);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1532_17227_17266_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 17227, 17266);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_17753_17780(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 17753, 17780);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_17784_17813(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TopLevelSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 17784, 17813);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_17884_17913(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TopLevelSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 17884, 17913);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1532_17884_17925(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ModuleTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 17884, 17925);
                    return return_v;
                }


                bool
                f_1532_18041_18064(System.Collections.Generic.Dictionary<string, bool>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 18041, 18064);
                    return return_v;
                }


                bool
                f_1532_18276_18322(System.Management.Automation.PSModuleInfo
                moduleInfo, Microsoft.PowerShell.Commands.ModuleSpecification
                moduleSpec)
                {
                    var return_v = IsModuleMatchingModuleSpec(moduleInfo, moduleSpec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 18276, 18322);
                    return return_v;
                }


                int
                f_1532_18396_18422(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 18396, 18422);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1532_17884_17925_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 17884, 17925);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1532_16852_16870_I(Microsoft.PowerShell.Commands.ModuleSpecification[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 16852, 16870);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Management.Automation.PSModuleInfo>
                f_1532_18596_18631(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                source, System.Func<System.Management.Automation.PSModuleInfo, string>
                keySelector)
                {
                    var return_v = source.OrderBy<System.Management.Automation.PSModuleInfo, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 18596, 18631);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1532_18596_18640(System.Linq.IOrderedEnumerable<System.Management.Automation.PSModuleInfo>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 18596, 18640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 16068, 18652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 16068, 18652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsModuleMatchingModuleSpec(
                    PSModuleInfo moduleInfo,
                    ModuleSpecification moduleSpec,
                    bool skipNameCheck = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 19242, 19566);
                System.Management.Automation.ModuleMatchFailure matchFailureReason = default(System.Management.Automation.ModuleMatchFailure);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 19439, 19555);

                return f_1532_19446_19554(out matchFailureReason, moduleInfo, moduleSpec, skipNameCheck);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 19242, 19566);

                bool
                f_1532_19446_19554(out System.Management.Automation.ModuleMatchFailure
                matchFailureReason, System.Management.Automation.PSModuleInfo
                moduleInfo, Microsoft.PowerShell.Commands.ModuleSpecification
                moduleSpec, bool
                skipNameCheck)
                {
                    var return_v = IsModuleMatchingModuleSpec(out matchFailureReason, moduleInfo, moduleSpec, skipNameCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 19446, 19554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 19242, 19566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 19242, 19566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsModuleMatchingModuleSpec(
                    out ModuleMatchFailure matchFailureReason,
                    PSModuleInfo moduleInfo,
                    ModuleSpecification moduleSpec,
                    bool skipNameCheck = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 20262, 21110);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 20515, 20681) || true) && (moduleSpec == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 20515, 20681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 20571, 20635);

                    matchFailureReason = ModuleMatchFailure.NullModuleSpecification;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 20653, 20666);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 20515, 20681);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 20697, 21099);

                return f_1532_20704_21098(out matchFailureReason, moduleInfo, (DynAbs.Tracing.TraceSender.Conditional_F1(1532, 20820, 20833) || ((skipNameCheck && DynAbs.Tracing.TraceSender.Conditional_F2(1532, 20836, 20840)) || DynAbs.Tracing.TraceSender.Conditional_F3(1532, 20843, 20858))) ? null : f_1532_20843_20858(moduleSpec), f_1532_20877_20892(moduleSpec), f_1532_20911_20937(moduleSpec), f_1532_20956_20974(moduleSpec), (DynAbs.Tracing.TraceSender.Conditional_F1(1532, 20993, 21026) || ((f_1532_20993_21018(moduleSpec) == null && DynAbs.Tracing.TraceSender.Conditional_F2(1532, 21029, 21033)) || DynAbs.Tracing.TraceSender.Conditional_F3(1532, 21036, 21097))) ? null : f_1532_21036_21097(f_1532_21071_21096(moduleSpec)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 20262, 21110);

                string
                f_1532_20843_20858(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 20843, 20858);
                    return return_v;
                }


                System.Guid?
                f_1532_20877_20892(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 20877, 20892);
                    return return_v;
                }


                System.Version
                f_1532_20911_20937(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 20911, 20937);
                    return return_v;
                }


                System.Version
                f_1532_20956_20974(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 20956, 20974);
                    return return_v;
                }


                string
                f_1532_20993_21018(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 20993, 21018);
                    return return_v;
                }


                string
                f_1532_21071_21096(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 21071, 21096);
                    return return_v;
                }


                System.Version
                f_1532_21036_21097(string
                stringVersion)
                {
                    var return_v = ModuleCmdletBase.GetMaximumVersion(stringVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 21036, 21097);
                    return return_v;
                }


                bool
                f_1532_20704_21098(out System.Management.Automation.ModuleMatchFailure
                matchFailureReason, System.Management.Automation.PSModuleInfo
                moduleInfo, string
                name, System.Guid?
                guid, System.Version
                requiredVersion, System.Version
                minimumVersion, System.Version
                maximumVersion)
                {
                    var return_v = IsModuleMatchingConstraints(out matchFailureReason, moduleInfo, name, guid, requiredVersion, minimumVersion, maximumVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 20704, 21098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 20262, 21110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 20262, 21110);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsModuleMatchingConstraints(
                    PSModuleInfo moduleInfo,
                    string name = null,
                    Guid? guid = null,
                    Version requiredVersion = null,
                    Version minimumVersion = null,
                    Version maximumVersion = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 21967, 22559);
                System.Management.Automation.ModuleMatchFailure matchFailureReason = default(System.Management.Automation.ModuleMatchFailure);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 22277, 22548);

                return f_1532_22284_22547(out matchFailureReason, moduleInfo, name, guid, requiredVersion, minimumVersion, maximumVersion);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 21967, 22559);

                bool
                f_1532_22284_22547(out System.Management.Automation.ModuleMatchFailure
                matchFailureReason, System.Management.Automation.PSModuleInfo
                moduleInfo, string
                name, System.Guid?
                guid, System.Version
                requiredVersion, System.Version
                minimumVersion, System.Version
                maximumVersion)
                {
                    var return_v = IsModuleMatchingConstraints(out matchFailureReason, moduleInfo, name, guid, requiredVersion, minimumVersion, maximumVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 22284, 22547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 21967, 22559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 21967, 22559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsModuleMatchingConstraints(
                    out ModuleMatchFailure matchFailureReason,
                    PSModuleInfo moduleInfo,
                    string name,
                    Guid? guid,
                    Version requiredVersion,
                    Version minimumVersion,
                    Version maximumVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 23522, 24488);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 23925, 24078) || true) && (moduleInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 23925, 24078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 23981, 24032);

                    matchFailureReason = ModuleMatchFailure.NullModule;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 24050, 24063);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 23925, 24078);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 24094, 24477);

                return f_1532_24101_24476(out matchFailureReason, f_1532_24195_24210(moduleInfo), f_1532_24229_24244(moduleInfo), f_1532_24263_24278(moduleInfo), f_1532_24297_24315(moduleInfo), name, guid, requiredVersion, minimumVersion, maximumVersion);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 23522, 24488);

                string
                f_1532_24195_24210(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 24195, 24210);
                    return return_v;
                }


                string
                f_1532_24229_24244(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 24229, 24244);
                    return return_v;
                }


                System.Guid
                f_1532_24263_24278(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 24263, 24278);
                    return return_v;
                }


                System.Version
                f_1532_24297_24315(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 24297, 24315);
                    return return_v;
                }


                bool
                f_1532_24101_24476(out System.Management.Automation.ModuleMatchFailure
                matchFailureReason, string
                moduleName, string
                modulePath, System.Guid
                moduleGuid, System.Version
                moduleVersion, string
                requiredName, System.Guid?
                requiredGuid, System.Version
                requiredVersion, System.Version
                minimumRequiredVersion, System.Version
                maximumRequiredVersion)
                {
                    var return_v = AreModuleFieldsMatchingConstraints(out matchFailureReason, moduleName, modulePath, (System.Guid?)moduleGuid, moduleVersion, requiredName, requiredGuid, requiredVersion, minimumRequiredVersion, maximumRequiredVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 24101, 24476);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 23522, 24488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 23522, 24488);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool AreModuleFieldsMatchingConstraints(
                    string moduleName = null,
                    string modulePath = null,
                    Guid? moduleGuid = null,
                    Version moduleVersion = null,
                    string requiredName = null,
                    Guid? requiredGuid = null,
                    Version requiredVersion = null,
                    Version minimumRequiredVersion = null,
                    Version maximumRequiredVersion = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 25564, 26445);
                System.Management.Automation.ModuleMatchFailure matchFailureReason = default(System.Management.Automation.ModuleMatchFailure);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 26034, 26434);

                return f_1532_26041_26433(out matchFailureReason, moduleName, modulePath, moduleGuid, moduleVersion, requiredName, requiredGuid, requiredVersion, minimumRequiredVersion, maximumRequiredVersion);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 25564, 26445);

                bool
                f_1532_26041_26433(out System.Management.Automation.ModuleMatchFailure
                matchFailureReason, string
                moduleName, string
                modulePath, System.Guid?
                moduleGuid, System.Version
                moduleVersion, string
                requiredName, System.Guid?
                requiredGuid, System.Version
                requiredVersion, System.Version
                minimumRequiredVersion, System.Version
                maximumRequiredVersion)
                {
                    var return_v = AreModuleFieldsMatchingConstraints(out matchFailureReason, moduleName, modulePath, moduleGuid, moduleVersion, requiredName, requiredGuid, requiredVersion, minimumRequiredVersion, maximumRequiredVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 26041, 26433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 25564, 26445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 25564, 26445);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool AreModuleFieldsMatchingConstraints(
                    out ModuleMatchFailure matchFailureReason,
                    string moduleName,
                    string modulePath,
                    Guid? moduleGuid,
                    Version moduleVersion,
                    string requiredName,
                    Guid? requiredGuid,
                    Version requiredVersion,
                    Version minimumRequiredVersion,
                    Version maximumRequiredVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 27612, 29021);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 28259, 28562) || true) && (requiredName != null
                && (DynAbs.Tracing.TraceSender.Expression_True(1532, 28263, 28372) && !f_1532_28305_28372(requiredName, moduleName, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1532, 28263, 28437) && !f_1532_28394_28437(modulePath, requiredName)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 28259, 28562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 28471, 28516);

                    matchFailureReason = ModuleMatchFailure.Name;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 28534, 28547);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 28259, 28562);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 28634, 28819) || true) && (requiredGuid != null && (DynAbs.Tracing.TraceSender.Expression_True(1532, 28638, 28694) && !requiredGuid.Equals(moduleGuid)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 28634, 28819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 28728, 28773);

                    matchFailureReason = ModuleMatchFailure.Guid;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 28791, 28804);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 28634, 28819);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 28870, 29010);

                return f_1532_28877_29009(out matchFailureReason, moduleVersion, requiredVersion, minimumRequiredVersion, maximumRequiredVersion);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 27612, 29021);

                bool
                f_1532_28305_28372(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 28305, 28372);
                    return return_v;
                }


                bool
                f_1532_28394_28437(string
                modulePath, string
                requiredPath)
                {
                    var return_v = MatchesModulePath(modulePath, requiredPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 28394, 28437);
                    return return_v;
                }


                bool
                f_1532_28877_29009(out System.Management.Automation.ModuleMatchFailure
                matchFailureReason, System.Version
                version, System.Version
                requiredVersion, System.Version
                minimumVersion, System.Version
                maximumVersion)
                {
                    var return_v = IsVersionMatchingConstraints(out matchFailureReason, version, requiredVersion, minimumVersion, maximumVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 28877, 29009);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 27612, 29021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 27612, 29021);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsVersionMatchingConstraints(
                    Version version,
                    Version requiredVersion = null,
                    Version minimumVersion = null,
                    Version maximumVersion = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 29906, 30292);
                System.Management.Automation.ModuleMatchFailure matchFailureReason = default(System.Management.Automation.ModuleMatchFailure);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 30144, 30281);

                return f_1532_30151_30280(out matchFailureReason, version, requiredVersion, minimumVersion, maximumVersion);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 29906, 30292);

                bool
                f_1532_30151_30280(out System.Management.Automation.ModuleMatchFailure
                matchFailureReason, System.Version
                version, System.Version
                requiredVersion, System.Version
                minimumVersion, System.Version
                maximumVersion)
                {
                    var return_v = IsVersionMatchingConstraints(out matchFailureReason, version, requiredVersion, minimumVersion, maximumVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 30151, 30280);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 29906, 30292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 29906, 30292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsVersionMatchingConstraints(
                    out ModuleMatchFailure matchFailureReason,
                    Version version,
                    Version requiredVersion = null,
                    Version minimumVersion = null,
                    Version maximumVersion = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 31264, 32568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 31558, 31642);

                f_1532_31558_31641(version != null, $"Caller to verify that {nameof(version)} is not null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 31740, 31929) || true) && (requiredVersion != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 31740, 31929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 31801, 31857);

                    matchFailureReason = ModuleMatchFailure.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 31875, 31914);

                    return f_1532_31882_31913(requiredVersion, version);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 31740, 31929);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 32011, 32200) || true) && (minimumVersion != null && (DynAbs.Tracing.TraceSender.Expression_True(1532, 32015, 32065) && version < minimumVersion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 32011, 32200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 32099, 32154);

                    matchFailureReason = ModuleMatchFailure.MinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 32172, 32185);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 32011, 32200);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 32281, 32470) || true) && (maximumVersion != null && (DynAbs.Tracing.TraceSender.Expression_True(1532, 32285, 32335) && version > maximumVersion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 32281, 32470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 32369, 32424);

                    matchFailureReason = ModuleMatchFailure.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 32442, 32455);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 32281, 32470);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 32486, 32531);

                matchFailureReason = ModuleMatchFailure.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 32545, 32557);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 31264, 32568);

                int
                f_1532_31558_31641(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 31558, 31641);
                    return 0;
                }


                bool
                f_1532_31882_31913(System.Version
                this_param, System.Version
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 31882, 31913);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 31264, 32568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 31264, 32568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool MatchesModulePath(string modulePath, string requiredPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 33166, 34978);
                System.Version? unused = default(System.Version?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 33269, 33363);

                f_1532_33269_33362(requiredPath != null, $"Caller to verify that {nameof(requiredPath)} is not null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 33379, 33463) || true) && (modulePath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 33379, 33463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 33435, 33448);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 33379, 33463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 33561, 33622);

                StringComparison
                strcmp = StringComparison.OrdinalIgnoreCase
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 34070, 34174) || true) && (f_1532_34074_34113(modulePath, requiredPath, strcmp))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 34070, 34174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 34147, 34159);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 34070, 34174);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 34452, 34562) || true) && (!f_1532_34457_34500(modulePath, requiredPath, strcmp))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 34452, 34562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 34534, 34547);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 34452, 34562);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 34578, 34635);

                string
                moduleDirPath = f_1532_34601_34634(modulePath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 34726, 34901) || true) && (f_1532_34730_34799(f_1532_34747_34778(moduleDirPath), out unused))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 34726, 34901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 34833, 34886);

                    moduleDirPath = f_1532_34849_34885(moduleDirPath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 34726, 34901);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 34917, 34967);

                return f_1532_34924_34966(moduleDirPath, requiredPath, strcmp);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 33166, 34978);

                int
                f_1532_33269_33362(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 33269, 33362);
                    return 0;
                }


                bool
                f_1532_34074_34113(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 34074, 34113);
                    return return_v;
                }


                bool
                f_1532_34457_34500(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 34457, 34500);
                    return return_v;
                }


                string?
                f_1532_34601_34634(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 34601, 34634);
                    return return_v;
                }


                string?
                f_1532_34747_34778(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 34747, 34778);
                    return return_v;
                }


                bool
                f_1532_34730_34799(string
                input, out System.Version
                result)
                {
                    var return_v = Version.TryParse(input, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 34730, 34799);
                    return return_v;
                }


                string?
                f_1532_34849_34885(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 34849, 34885);
                    return return_v;
                }


                bool
                f_1532_34924_34966(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 34924, 34966);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 33166, 34978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 33166, 34978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string NormalizeModuleName(
                    string moduleName,
                    string basePath,
                    ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 36102, 37720);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 36280, 36363) || true) && (moduleName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 36280, 36363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 36336, 36348);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 36280, 36363);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 36484, 36584) || true) && (!f_1532_36489_36517(moduleName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 36484, 36584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 36551, 36569);

                    return moduleName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 36484, 36584);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 36748, 36856);

                moduleName = f_1532_36761_36855(moduleName, StringLiterals.AlternatePathSeparator, StringLiterals.DefaultPathSeparator);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 36989, 37117) || true) && (!f_1532_36994_37023(moduleName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 36989, 37117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 37057, 37102);

                    moduleName = f_1532_37070_37101(basePath, moduleName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 36989, 37117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 37322, 37455);

                string
                normalizedPath = f_1532_37346_37454_I(f_1532_37346_37408(moduleName, executionContext).TrimEnd(StringLiterals.DefaultPathSeparator))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 37655, 37709);

                return normalizedPath ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1532, 37662, 37708) ?? f_1532_37680_37708(moduleName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 36102, 37720);

                bool
                f_1532_36489_36517(string
                moduleName)
                {
                    var return_v = IsModuleNamePath(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 36489, 36517);
                    return return_v;
                }


                string
                f_1532_36761_36855(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 36761, 36855);
                    return return_v;
                }


                bool
                f_1532_36994_37023(string
                path)
                {
                    var return_v = Path.IsPathRooted(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 36994, 37023);
                    return return_v;
                }


                string
                f_1532_37070_37101(string
                path1, string
                path2)
                {
                    var return_v = Path.Join(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 37070, 37101);
                    return return_v;
                }


                string
                f_1532_37346_37408(string
                filePath, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = ModuleCmdletBase.GetResolvedPath(filePath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 37346, 37408);
                    return return_v;
                }


                string
                f_1532_37346_37454_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 37346, 37454);
                    return return_v;
                }


                string
                f_1532_37680_37708(string
                path)
                {
                    var return_v = Path.GetFullPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 37680, 37708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 36102, 37720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 36102, 37720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsModuleNamePath(string moduleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 38026, 38348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 38107, 38337);

                return f_1532_38114_38170(moduleName, StringLiterals.DefaultPathSeparator) || (DynAbs.Tracing.TraceSender.Expression_False(1532, 38114, 38249) || f_1532_38191_38249(moduleName, StringLiterals.AlternatePathSeparator)) || (DynAbs.Tracing.TraceSender.Expression_False(1532, 38114, 38293) || f_1532_38270_38293(moduleName, "..")) || (DynAbs.Tracing.TraceSender.Expression_False(1532, 38114, 38336) || f_1532_38314_38336(moduleName, "."));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 38026, 38348);

                bool
                f_1532_38114_38170(string
                this_param, char
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 38114, 38170);
                    return return_v;
                }


                bool
                f_1532_38191_38249(string
                this_param, char
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 38191, 38249);
                    return return_v;
                }


                bool
                f_1532_38270_38293(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 38270, 38293);
                    return return_v;
                }


                bool
                f_1532_38314_38336(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 38314, 38336);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 38026, 38348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 38026, 38348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Version GetManifestModuleVersion(string manifestPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 38360, 39187);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 38490, 38683);

                    Hashtable
                    dataFileSetting =
                    f_1532_38539_38682(manifestPath, PsUtils.ManifestModuleVersionPropertyName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 38703, 38758);

                    object
                    versionValue = f_1532_38725_38757(dataFileSetting, "ModuleVersion")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 38776, 39067) || true) && (versionValue != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 38776, 39067);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 38842, 38864);

                        Version
                        moduleVersion
                        = default(Version);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 38886, 39048) || true) && (f_1532_38890_38954(versionValue, out moduleVersion))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 38886, 39048);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 39004, 39025);

                            return moduleVersion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 38886, 39048);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 38776, 39067);
                    }
                }
                catch (PSInvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1532, 39096, 39135);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1532, 39096, 39135);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 39151, 39176);

                return f_1532_39158_39175(0, 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 38360, 39187);

                System.Collections.Hashtable
                f_1532_38539_38682(string
                psDataFilePath, string[]
                keys)
                {
                    var return_v = PsUtils.GetModuleManifestProperties(psDataFilePath, keys);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 38539, 38682);
                    return return_v;
                }


                object
                f_1532_38725_38757(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 38725, 38757);
                    return return_v;
                }


                bool
                f_1532_38890_38954(object
                valueToConvert, out System.Version
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 38890, 38954);
                    return return_v;
                }


                System.Version
                f_1532_39158_39175(int
                major, int
                minor)
                {
                    var return_v = new System.Version(major, minor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 39158, 39175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 38360, 39187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 38360, 39187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Guid GetManifestGuid(string manifestPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 39199, 39956);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 39317, 39501);

                    Hashtable
                    dataFileSetting =
                    f_1532_39366_39500(manifestPath, PsUtils.ManifestGuidPropertyName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 39521, 39564);

                    object
                    guidValue = f_1532_39540_39563(dataFileSetting, "GUID")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 39582, 39843) || true) && (guidValue != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 39582, 39843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 39645, 39657);

                        Guid
                        guidID
                        = default(Guid);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 39679, 39824) || true) && (f_1532_39683_39737(guidValue, out guidID))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 39679, 39824);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 39787, 39801);

                            return guidID;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 39679, 39824);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 39582, 39843);
                    }
                }
                catch (PSInvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1532, 39872, 39911);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1532, 39872, 39911);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 39927, 39945);

                return f_1532_39934_39944();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 39199, 39956);

                System.Collections.Hashtable
                f_1532_39366_39500(string
                psDataFilePath, string[]
                keys)
                {
                    var return_v = PsUtils.GetModuleManifestProperties(psDataFilePath, keys);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 39366, 39500);
                    return return_v;
                }


                object
                f_1532_39540_39563(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 39540, 39563);
                    return return_v;
                }


                bool
                f_1532_39683_39737(object
                valueToConvert, out System.Guid
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 39683, 39737);
                    return return_v;
                }


                System.Guid
                f_1532_39934_39944()
                {
                    var return_v = new System.Guid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 39934, 39944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 39199, 39956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 39199, 39956);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ExperimentalFeature[] GetExperimentalFeature(string manifestPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 39968, 41982);
                System.Collections.Hashtable[] features = default(System.Collections.Hashtable[]);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 40110, 40301);

                    Hashtable
                    dataFileSetting =
                    f_1532_40159_40300(manifestPath, PsUtils.ManifestPrivateDataPropertyName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 40321, 40373);

                    object
                    privateData = f_1532_40342_40372(dataFileSetting, "PrivateData")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 40391, 41845) || true) && (privateData is Hashtable hashData && (DynAbs.Tracing.TraceSender.Expression_True(1532, 40395, 40470) && f_1532_40432_40450(hashData, "PSData") is Hashtable psData))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 40391, 41845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 40512, 40568);

                        object
                        expFeatureValue = f_1532_40537_40567(psData, "ExperimentalFeatures")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 40590, 41826) || true) && (expFeatureValue != null && (DynAbs.Tracing.TraceSender.Expression_True(1532, 40594, 40720) && f_1532_40646_40720(expFeatureValue, out features)) && (DynAbs.Tracing.TraceSender.Expression_True(1532, 40594, 40768) && f_1532_40749_40764(features) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 40590, 41826);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 40818, 40883);

                            string
                            moduleName = f_1532_40838_40882(manifestPath)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 40909, 40962);

                            var
                            expFeatureList = f_1532_40930_40961()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 40988, 41743);
                                foreach (Hashtable feature in f_1532_41018_41026_I(features))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 40988, 41743);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 41084, 41131);

                                    string
                                    featureName = f_1532_41105_41120(feature, "Name") as string
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 41161, 41213) || true) && (f_1532_41165_41198(featureName))
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 41161, 41213);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 41202, 41211);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 41161, 41213);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 41245, 41716) || true) && (f_1532_41249_41313(featureName, moduleName))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 41245, 41716);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 41379, 41440);

                                        string
                                        featureDescription = f_1532_41407_41429(feature, "Description") as string
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 41474, 41685);

                                        f_1532_41474_41684(expFeatureList, f_1532_41493_41683(featureName, featureDescription, manifestPath, f_1532_41640_41682(featureName)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 41245, 41716);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 40988, 41743);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 756);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 756);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 41771, 41803);

                            return f_1532_41778_41802(expFeatureList);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 40590, 41826);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 40391, 41845);
                    }
                }
                catch (PSInvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1532, 41874, 41913);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1532, 41874, 41913);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 41929, 41971);

                return f_1532_41936_41970();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 39968, 41982);

                System.Collections.Hashtable
                f_1532_40159_40300(string
                psDataFilePath, string[]
                keys)
                {
                    var return_v = PsUtils.GetModuleManifestProperties(psDataFilePath, keys);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 40159, 40300);
                    return return_v;
                }


                object
                f_1532_40342_40372(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 40342, 40372);
                    return return_v;
                }


                object
                f_1532_40432_40450(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 40432, 40450);
                    return return_v;
                }


                object
                f_1532_40537_40567(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 40537, 40567);
                    return return_v;
                }


                bool
                f_1532_40646_40720(object
                valueToConvert, out System.Collections.Hashtable[]
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 40646, 40720);
                    return return_v;
                }


                int
                f_1532_40749_40764(System.Collections.Hashtable[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 40749, 40764);
                    return return_v;
                }


                string
                f_1532_40838_40882(string
                path)
                {
                    var return_v = ModuleIntrinsics.GetModuleName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 40838, 40882);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ExperimentalFeature>
                f_1532_40930_40961()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.ExperimentalFeature>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 40930, 40961);
                    return return_v;
                }


                object
                f_1532_41105_41120(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 41105, 41120);
                    return return_v;
                }


                bool
                f_1532_41165_41198(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 41165, 41198);
                    return return_v;
                }


                bool
                f_1532_41249_41313(string
                featureName, string
                moduleName)
                {
                    var return_v = ExperimentalFeature.IsModuleFeatureName(featureName, moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 41249, 41313);
                    return return_v;
                }


                object
                f_1532_41407_41429(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 41407, 41429);
                    return return_v;
                }


                bool
                f_1532_41640_41682(string
                featureName)
                {
                    var return_v = ExperimentalFeature.IsEnabled(featureName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 41640, 41682);
                    return return_v;
                }


                System.Management.Automation.ExperimentalFeature
                f_1532_41493_41683(string
                name, string
                description, string
                source, bool
                isEnabled)
                {
                    var return_v = new System.Management.Automation.ExperimentalFeature(name, description, source, isEnabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 41493, 41683);
                    return return_v;
                }


                int
                f_1532_41474_41684(System.Collections.Generic.List<System.Management.Automation.ExperimentalFeature>
                this_param, System.Management.Automation.ExperimentalFeature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 41474, 41684);
                    return 0;
                }


                System.Collections.Hashtable[]
                f_1532_41018_41026_I(System.Collections.Hashtable[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 41018, 41026);
                    return return_v;
                }


                System.Management.Automation.ExperimentalFeature[]
                f_1532_41778_41802(System.Collections.Generic.List<System.Management.Automation.ExperimentalFeature>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 41778, 41802);
                    return return_v;
                }


                System.Management.Automation.ExperimentalFeature[]
                f_1532_41936_41970()
                {
                    var return_v = Array.Empty<ExperimentalFeature>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 41936, 41970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 39968, 41982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 39968, 41982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string[] PSModuleProcessableExtensions;

        internal static string[] PSModuleExtensions;

        internal static bool IsPowerShellModuleExtension(string extension)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 43779, 44107);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 43870, 44067);
                    foreach (string ext in f_1532_43893_43922_I(PSModuleProcessableExtensions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 43870, 44067);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 43956, 44052) || true) && (f_1532_43960_44017(extension, ext, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 43956, 44052);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 44040, 44052);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 43956, 44052);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 43870, 44067);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 44083, 44096);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 43779, 44107);

                bool
                f_1532_43960_44017(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 43960, 44017);
                    return return_v;
                }


                string[]
                f_1532_43893_43922_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 43893, 43922);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 43779, 44107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 43779, 44107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetModuleName(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 44331, 45105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 44405, 44476);

                string
                fileName = (DynAbs.Tracing.TraceSender.Conditional_F1(1532, 44423, 44435) || ((path == null && DynAbs.Tracing.TraceSender.Conditional_F2(1532, 44438, 44450)) || DynAbs.Tracing.TraceSender.Conditional_F3(1532, 44453, 44475))) ? string.Empty : f_1532_44453_44475(path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 44490, 44501);

                string
                ext
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 44515, 44822) || true) && (f_1532_44519_44620(fileName, StringLiterals.PowerShellNgenAssemblyExtension, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 44515, 44822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 44654, 44707);

                    ext = StringLiterals.PowerShellNgenAssemblyExtension;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 44515, 44822);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 44515, 44822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 44773, 44807);

                    ext = f_1532_44779_44806(fileName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 44515, 44822);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 44838, 45094) || true) && (!f_1532_44843_44868(ext) && (DynAbs.Tracing.TraceSender.Expression_True(1532, 44842, 44904) && f_1532_44872_44904(ext)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 44838, 45094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 44938, 44997);

                    return f_1532_44945_44996(fileName, 0, f_1532_44967_44982(fileName) - f_1532_44985_44995(ext));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 44838, 45094);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 44838, 45094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 45063, 45079);

                    return fileName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 44838, 45094);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 44331, 45105);

                string?
                f_1532_44453_44475(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 44453, 44475);
                    return return_v;
                }


                bool
                f_1532_44519_44620(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 44519, 44620);
                    return return_v;
                }


                string?
                f_1532_44779_44806(string
                path)
                {
                    var return_v = Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 44779, 44806);
                    return return_v;
                }


                bool
                f_1532_44843_44868(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 44843, 44868);
                    return return_v;
                }


                bool
                f_1532_44872_44904(string
                extension)
                {
                    var return_v = IsPowerShellModuleExtension(extension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 44872, 44904);
                    return return_v;
                }


                int
                f_1532_44967_44982(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 44967, 44982);
                    return return_v;
                }


                int
                f_1532_44985_44995(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 44985, 44995);
                    return return_v;
                }


                string
                f_1532_44945_44996(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 44945, 44996);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 44331, 45105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 44331, 45105);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetPersonalModulePath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 45262, 45570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 45442, 45551);

                return f_1532_45449_45550(f_1532_45462_45526(Environment.SpecialFolder.MyDocuments), Utils.ModuleDirectory);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 45262, 45570);

                string
                f_1532_45462_45526(System.Environment.SpecialFolder
                folder)
                {
                    var return_v = Environment.GetFolderPath(folder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 45462, 45526);
                    return return_v;
                }


                string
                f_1532_45449_45550(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 45449, 45550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 45262, 45570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 45262, 45570);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetPSHomeModulePath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 45792, 47207);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 45861, 45966) || true) && (s_psHomeModulePath != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 45861, 45966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 45925, 45951);

                    return s_psHomeModulePath;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 45861, 45966);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 46018, 46065);

                    string
                    psHome = f_1532_46034_46064()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 46083, 47054) || true) && (!f_1532_46088_46116(psHome))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 46083, 47054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 46839, 46914);

                        psHome = f_1532_46848_46913(f_1532_46848_46873(psHome), "\\syswow64\\", "\\system32\\");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 46944, 47035);

                        f_1532_46944_47034(ref s_psHomeModulePath, f_1532_46996_47027(psHome, "Modules"), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 46083, 47054);
                    }
                }
                catch (System.Security.SecurityException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1532, 47083, 47154);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1532, 47083, 47154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 47170, 47196);

                return s_psHomeModulePath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 45792, 47207);

                string
                f_1532_46034_46064()
                {
                    var return_v = Utils.DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 46034, 46064);
                    return return_v;
                }


                bool
                f_1532_46088_46116(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 46088, 46116);
                    return return_v;
                }


                string
                f_1532_46848_46873(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 46848, 46873);
                    return return_v;
                }


                string
                f_1532_46848_46913(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 46848, 46913);
                    return return_v;
                }


                string
                f_1532_46996_47027(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 46996, 47027);
                    return return_v;
                }


                string
                f_1532_46944_47034(ref string
                location1, string
                value, string
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 46944, 47034);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 45792, 47207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 45792, 47207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string s_psHomeModulePath;

        private static string GetSharedModulePath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 47501, 48012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 47680, 47772);

                string
                sharedModulePath = f_1532_47706_47771(Environment.SpecialFolder.ProgramFiles)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 47788, 47953) || true) && (!f_1532_47793_47831(sharedModulePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 47788, 47953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 47865, 47938);

                    sharedModulePath = f_1532_47884_47937(sharedModulePath, Utils.ModuleDirectory);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 47788, 47953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 47969, 47993);

                return sharedModulePath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 47501, 48012);

                string
                f_1532_47706_47771(System.Environment.SpecialFolder
                folder)
                {
                    var return_v = Environment.GetFolderPath(folder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 47706, 47771);
                    return return_v;
                }


                bool
                f_1532_47793_47831(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 47793, 47831);
                    return return_v;
                }


                string
                f_1532_47884_47937(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 47884, 47937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 47501, 48012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 47501, 48012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetWindowsPowerShellPSHomeModulePath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 48330, 48676);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 48416, 48606) || true) && (!f_1532_48421_48496(InternalTestHooks.TestWindowsPowerShellPSHomeLocation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 48416, 48606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 48530, 48591);

                    return InternalTestHooks.TestWindowsPowerShellPSHomeLocation;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 48416, 48606);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 48622, 48665);

                return s_windowsPowerShellPSHomeModulePath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 48330, 48676);

                bool
                f_1532_48421_48496(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 48421, 48496);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 48330, 48676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 48330, 48676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string CombineSystemModulePaths()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 48897, 49666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 48970, 49018);

                string
                psHomeModulePath = f_1532_48996_49017()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 49032, 49080);

                string
                sharedModulePath = f_1532_49058_49079()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 49096, 49166);

                bool
                isPSHomePathNullOrEmpty = f_1532_49127_49165(psHomeModulePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 49180, 49250);

                bool
                isSharedPathNullOrEmpty = f_1532_49211_49249(sharedModulePath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 49266, 49437) || true) && (!isPSHomePathNullOrEmpty && (DynAbs.Tracing.TraceSender.Expression_True(1532, 49270, 49322) && !isSharedPathNullOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 49266, 49437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 49356, 49422);

                    return (sharedModulePath + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Path.PathSeparator).ToString(), 1532, 49383, 49401) + psHomeModulePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 49266, 49437);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 49453, 49627) || true) && (!isPSHomePathNullOrEmpty || (DynAbs.Tracing.TraceSender.Expression_False(1532, 49457, 49509) || !isSharedPathNullOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 49453, 49627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 49543, 49612);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1532, 49550, 49573) || ((isPSHomePathNullOrEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(1532, 49576, 49592)) || DynAbs.Tracing.TraceSender.Conditional_F3(1532, 49595, 49611))) ? sharedModulePath : psHomeModulePath;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 49453, 49627);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 49643, 49655);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 48897, 49666);

                string
                f_1532_48996_49017()
                {
                    var return_v = GetPSHomeModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 48996, 49017);
                    return return_v;
                }


                string
                f_1532_49058_49079()
                {
                    var return_v = GetSharedModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 49058, 49079);
                    return return_v;
                }


                bool
                f_1532_49127_49165(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 49127, 49165);
                    return return_v;
                }


                bool
                f_1532_49211_49249(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 49211, 49249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 48897, 49666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 48897, 49666);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetExpandedEnvironmentVariable(string name, EnvironmentVariableTarget target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 49678, 50061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 49803, 49868);

                string
                result = f_1532_49819_49867(name, target)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 49882, 50020) || true) && (!f_1532_49887_49915(result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 49882, 50020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 49949, 50005);

                    result = f_1532_49958_50004(result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 49882, 50020);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 50036, 50050);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 49678, 50061);

                string?
                f_1532_49819_49867(string
                variable, System.EnvironmentVariableTarget
                target)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 49819, 49867);
                    return return_v;
                }


                bool
                f_1532_49887_49915(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 49887, 49915);
                    return return_v;
                }


                string
                f_1532_49958_50004(string
                name)
                {
                    var return_v = Environment.ExpandEnvironmentVariables(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 49958, 50004);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 49678, 50061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 49678, 50061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int PathContainsSubstring(string pathToScan, string pathToLookFor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 50569, 52424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 50794, 50904);

                f_1532_50794_50903(pathToScan != null, "pathToScan should not be null according to contract of the function");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 50918, 51034);

                f_1532_50918_51033(pathToLookFor != null, "pathToLookFor should not be null according to contract of the function");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 51050, 51062);

                int
                pos = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 51127, 51223);

                string[]
                substrings = f_1532_51149_51222(pathToScan, Utils.Separators.PathSeparator, StringSplitOptions.None)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 51273, 51358);

                string
                goodPathToLookFor = f_1532_51300_51357(f_1532_51300_51320(pathToLookFor), Path.DirectorySeparatorChar)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 51446, 52324);
                    foreach (string substring in f_1532_51475_51485_I(substrings))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 51446, 52324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 51519, 51596);

                        string
                        goodSubstring = f_1532_51542_51595(f_1532_51542_51558(substring), Path.DirectorySeparatorChar)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 51944, 52309) || true) && (f_1532_51948_52031(goodSubstring, goodPathToLookFor, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 51944, 52309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 52073, 52084);

                            return pos;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 51944, 52309);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 51944, 52309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 52229, 52257);

                            pos += f_1532_52236_52252(substring) + 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 51944, 52309);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 51446, 52324);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 879);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 52403, 52413);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 50569, 52424);

                int
                f_1532_50794_50903(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 50794, 50903);
                    return 0;
                }


                int
                f_1532_50918_51033(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 50918, 51033);
                    return 0;
                }


                string[]
                f_1532_51149_51222(string
                this_param, char[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 51149, 51222);
                    return return_v;
                }


                string
                f_1532_51300_51320(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 51300, 51320);
                    return return_v;
                }


                string
                f_1532_51300_51357(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 51300, 51357);
                    return return_v;
                }


                string
                f_1532_51542_51558(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 51542, 51558);
                    return return_v;
                }


                string
                f_1532_51542_51595(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 51542, 51595);
                    return return_v;
                }


                bool
                f_1532_51948_52031(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 51948, 52031);
                    return return_v;
                }


                int
                f_1532_52236_52252(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 52236, 52252);
                    return return_v;
                }


                string[]
                f_1532_51475_51485_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 51475, 51485);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 50569, 52424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 50569, 52424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string AddToPath(string basePath, string pathToAdd, int insertPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 52944, 55416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 53174, 53280);

                f_1532_53174_53279(basePath != null, "basePath should not be null according to contract of the function");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 53294, 53402);

                f_1532_53294_53401(pathToAdd != null, "pathToAdd should not be null according to contract of the function");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 53418, 53469);

                StringBuilder
                result = f_1532_53441_53468(basePath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 53485, 55364) || true) && (!f_1532_53490_53521(pathToAdd))
                ) // we don't want to append empty paths

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 53485, 55364);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 53594, 55349);
                        foreach (string subPathToAdd in f_1532_53626_53712_I(f_1532_53626_53712(pathToAdd, Utils.Separators.PathSeparator, StringSplitOptions.RemoveEmptyEntries)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 53594, 55349);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 53818, 53888);

                            int
                            position = f_1532_53833_53887(f_1532_53855_53872(result), subPathToAdd)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 54020, 55330) || true) && (position == -1)
                            ) // subPathToAdd not found - add it

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 54020, 55330);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 54123, 55307) || true) && (insertPosition == -1)
                                ) // append subPathToAdd to the end

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 54123, 55307);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 54239, 54274);

                                    bool
                                    endsWithPathSeparator = false
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 54304, 54401) || true) && (f_1532_54308_54321(result) > 0)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 54304, 54401);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 54327, 54401);

                                        endsWithPathSeparator = (f_1532_54352_54377(result, f_1532_54359_54372(result) - 1) == Path.PathSeparator);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 54304, 54401);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 54433, 54638) || true) && (endsWithPathSeparator)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 54433, 54638);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 54493, 54521);

                                        f_1532_54493_54520(result, subPathToAdd);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 54433, 54638);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 54433, 54638);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 54589, 54638);

                                        f_1532_54589_54637(result, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Path.PathSeparator).ToString(), 1532, 54603, 54621) + subPathToAdd);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 54433, 54638);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 54123, 55307);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 54123, 55307);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 54696, 55307) || true) && (insertPosition > f_1532_54717_54730(result))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 54696, 55307);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 54889, 54944);

                                        f_1532_54889_54943(f_1532_54889_54922(                            // handle case where path is a singleton with no path seperator already
                                                                    result, Path.PathSeparator), subPathToAdd);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 54696, 55307);
                                    }

                                    else // insert at the requested location (this is used by DSC (<Program Files> location) and by 'user-specific location' (SpecialFolder.MyDocuments or EVT.User))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 54696, 55307);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 55215, 55280);

                                        f_1532_55215_55279(result, insertPosition, subPathToAdd + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Path.PathSeparator).ToString(), 1532, 55260, 55278));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 54696, 55307);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 54123, 55307);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 54020, 55330);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 53594, 55349);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 1756);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 1756);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 53485, 55364);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 55380, 55405);

                return f_1532_55387_55404(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 52944, 55416);

                int
                f_1532_53174_53279(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 53174, 53279);
                    return 0;
                }


                int
                f_1532_53294_53401(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 53294, 53401);
                    return 0;
                }


                System.Text.StringBuilder
                f_1532_53441_53468(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 53441, 53468);
                    return return_v;
                }


                bool
                f_1532_53490_53521(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 53490, 53521);
                    return return_v;
                }


                string[]
                f_1532_53626_53712(string
                this_param, char[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 53626, 53712);
                    return return_v;
                }


                string
                f_1532_53855_53872(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 53855, 53872);
                    return return_v;
                }


                int
                f_1532_53833_53887(string
                pathToScan, string
                pathToLookFor)
                {
                    var return_v = PathContainsSubstring(pathToScan, pathToLookFor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 53833, 53887);
                    return return_v;
                }


                int
                f_1532_54308_54321(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 54308, 54321);
                    return return_v;
                }


                int
                f_1532_54359_54372(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 54359, 54372);
                    return return_v;
                }


                char
                f_1532_54352_54377(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 54352, 54377);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1532_54493_54520(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 54493, 54520);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1532_54589_54637(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 54589, 54637);
                    return return_v;
                }


                int
                f_1532_54717_54730(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 54717, 54730);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1532_54889_54922(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 54889, 54922);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1532_54889_54943(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 54889, 54943);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1532_55215_55279(System.Text.StringBuilder
                this_param, int
                index, string
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 55215, 55279);
                    return return_v;
                }


                string[]
                f_1532_53626_53712_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 53626, 53712);
                    return return_v;
                }


                string
                f_1532_55387_55404(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 55387, 55404);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 52944, 55416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 52944, 55416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetModulePath(string currentProcessModulePath, string hklmMachineModulePath, string hkcuUserModulePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 55587, 58515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 55736, 55788);

                string
                personalModulePath = f_1532_55764_55787()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 55802, 55850);

                string
                sharedModulePath = f_1532_55828_55849()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 55896, 55944);

                string
                psHomeModulePath = f_1532_55922_55943()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 56064, 58456) || true) && (currentProcessModulePath == null)
                )  // EVT.Process does Not exist - really corner case

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 56064, 58456);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 56233, 56725) || true) && (f_1532_56237_56277(hkcuUserModulePath))
                    ) // EVT.User does Not exist -> set to <SpecialFolder.MyDocuments> location

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 56233, 56725);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 56393, 56439);

                        currentProcessModulePath = personalModulePath;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 56233, 56725);
                    }

                    else // EVT.User exists -> set to EVT.User

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 56233, 56725);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 56646, 56692);

                        currentProcessModulePath = hkcuUserModulePath;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 56233, 56725);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 56745, 56792);

                    currentProcessModulePath += Path.PathSeparator;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 56810, 57196) || true) && (f_1532_56814_56857(hklmMachineModulePath))
                    ) // EVT.Machine does Not exist

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 56810, 57196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 56929, 56984);

                        currentProcessModulePath += f_1532_56957_56983();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 56810, 57196);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 56810, 57196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 57109, 57159);

                        currentProcessModulePath += hklmMachineModulePath;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 56810, 57196);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 56064, 58456);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 56064, 58456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 57380, 57496);

                    string
                    personalModulePathToUse = (DynAbs.Tracing.TraceSender.Conditional_F1(1532, 57413, 57453) || ((f_1532_57413_57453(hkcuUserModulePath) && DynAbs.Tracing.TraceSender.Conditional_F2(1532, 57456, 57474)) || DynAbs.Tracing.TraceSender.Conditional_F3(1532, 57477, 57495))) ? personalModulePath : hkcuUserModulePath
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 57514, 57632);

                    string
                    systemModulePathToUse = (DynAbs.Tracing.TraceSender.Conditional_F1(1532, 57545, 57588) || ((f_1532_57545_57588(hklmMachineModulePath) && DynAbs.Tracing.TraceSender.Conditional_F2(1532, 57591, 57607)) || DynAbs.Tracing.TraceSender.Conditional_F3(1532, 57610, 57631))) ? psHomeModulePath : hklmMachineModulePath
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 57847, 57938);

                    currentProcessModulePath = f_1532_57874_57937(currentProcessModulePath, personalModulePathToUse, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 57956, 58084);

                    int
                    insertIndex = f_1532_57974_58046(currentProcessModulePath, personalModulePathToUse) + f_1532_58049_58079(personalModulePathToUse) + 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 58102, 58196);

                    currentProcessModulePath = f_1532_58129_58195(currentProcessModulePath, sharedModulePath, insertIndex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 58214, 58324);

                    insertIndex = f_1532_58228_58293(currentProcessModulePath, sharedModulePath) + f_1532_58296_58319(sharedModulePath) + 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 58342, 58441);

                    currentProcessModulePath = f_1532_58369_58440(currentProcessModulePath, systemModulePathToUse, insertIndex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 56064, 58456);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 58472, 58504);

                return currentProcessModulePath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 55587, 58515);

                string
                f_1532_55764_55787()
                {
                    var return_v = GetPersonalModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 55764, 55787);
                    return return_v;
                }


                string
                f_1532_55828_55849()
                {
                    var return_v = GetSharedModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 55828, 55849);
                    return return_v;
                }


                string
                f_1532_55922_55943()
                {
                    var return_v = GetPSHomeModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 55922, 55943);
                    return return_v;
                }


                bool
                f_1532_56237_56277(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 56237, 56277);
                    return return_v;
                }


                bool
                f_1532_56814_56857(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 56814, 56857);
                    return return_v;
                }


                string
                f_1532_56957_56983()
                {
                    var return_v = CombineSystemModulePaths();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 56957, 56983);
                    return return_v;
                }


                bool
                f_1532_57413_57453(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 57413, 57453);
                    return return_v;
                }


                bool
                f_1532_57545_57588(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 57545, 57588);
                    return return_v;
                }


                string
                f_1532_57874_57937(string
                basePath, string
                pathToAdd, int
                insertPosition)
                {
                    var return_v = AddToPath(basePath, pathToAdd, insertPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 57874, 57937);
                    return return_v;
                }


                int
                f_1532_57974_58046(string
                pathToScan, string
                pathToLookFor)
                {
                    var return_v = PathContainsSubstring(pathToScan, pathToLookFor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 57974, 58046);
                    return return_v;
                }


                int
                f_1532_58049_58079(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 58049, 58079);
                    return return_v;
                }


                string
                f_1532_58129_58195(string
                basePath, string
                pathToAdd, int
                insertPosition)
                {
                    var return_v = AddToPath(basePath, pathToAdd, insertPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 58129, 58195);
                    return return_v;
                }


                int
                f_1532_58228_58293(string
                pathToScan, string
                pathToLookFor)
                {
                    var return_v = PathContainsSubstring(pathToScan, pathToLookFor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 58228, 58293);
                    return return_v;
                }


                int
                f_1532_58296_58319(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 58296, 58319);
                    return return_v;
                }


                string
                f_1532_58369_58440(string
                basePath, string
                pathToAdd, int
                insertPosition)
                {
                    var return_v = AddToPath(basePath, pathToAdd, insertPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 58369, 58440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 55587, 58515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 55587, 58515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetModulePath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 58793, 59029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 58856, 58979);

                string
                currentModulePath = f_1532_58883_58978(Constants.PSModulePathEnvVar, EnvironmentVariableTarget.Process)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 58993, 59018);

                return currentModulePath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 58793, 59029);

                string
                f_1532_58883_58978(string
                name, System.EnvironmentVariableTarget
                target)
                {
                    var return_v = GetExpandedEnvironmentVariable(name, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 58883, 58978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 58793, 59029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 58793, 59029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetWindowsPowerShellModulePath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 59370, 60478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 59450, 59493);

                string
                currentModulePath = f_1532_59477_59492()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 59509, 59599) || true) && (currentModulePath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 59509, 59599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 59572, 59584);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 59509, 59599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 59724, 60104);

                var
                excludeModulePaths = new HashSet<string>(f_1532_59769_59801()) {
DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1532_59822_59845(),1532,59749,60103),f_1532_59864_59885(),f_1532_59904_59925(),f_1532_59944_60005(                PowerShellConfig.Instance, ConfigScope.AllUsers),f_1532_60024_60088(                PowerShellConfig.Instance, ConfigScope.CurrentUser)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 60120, 60160);

                var
                modulePathList = f_1532_60141_60159()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 60174, 60396);
                    foreach (var path in f_1532_60195_60223_I(f_1532_60195_60223(currentModulePath, ';')))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 60174, 60396);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 60257, 60381) || true) && (!f_1532_60262_60295(excludeModulePaths, path))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 60257, 60381);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 60337, 60362);

                            f_1532_60337_60361(modulePathList, path);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 60257, 60381);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 60174, 60396);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 60412, 60467);

                return f_1532_60419_60466(Path.PathSeparator, modulePathList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 59370, 60478);

                string
                f_1532_59477_59492()
                {
                    var return_v = GetModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 59477, 59492);
                    return return_v;
                }


                System.StringComparer
                f_1532_59769_59801()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 59769, 59801);
                    return return_v;
                }


                string
                f_1532_59822_59845()
                {
                    var return_v = GetPersonalModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 59822, 59845);
                    return return_v;
                }


                string
                f_1532_59864_59885()
                {
                    var return_v = GetSharedModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 59864, 59885);
                    return return_v;
                }


                string
                f_1532_59904_59925()
                {
                    var return_v = GetPSHomeModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 59904, 59925);
                    return return_v;
                }


                string
                f_1532_59944_60005(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetModulePath(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 59944, 60005);
                    return return_v;
                }


                string
                f_1532_60024_60088(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetModulePath(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 60024, 60088);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1532_60141_60159()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 60141, 60159);
                    return return_v;
                }


                string[]
                f_1532_60195_60223(string
                this_param, char
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 60195, 60223);
                    return return_v;
                }


                bool
                f_1532_60262_60295(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 60262, 60295);
                    return return_v;
                }


                int
                f_1532_60337_60361(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 60337, 60361);
                    return 0;
                }


                string[]
                f_1532_60195_60223_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 60195, 60223);
                    return return_v;
                }


                string
                f_1532_60419_60466(char
                separator, System.Collections.Generic.List<string>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 60419, 60466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 59370, 60478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 59370, 60478);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string SetModulePath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 60764, 62124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 60826, 60949);

                string
                currentModulePath = f_1532_60853_60948(Constants.PSModulePathEnvVar, EnvironmentVariableTarget.Process)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 61189, 61538) || true) && (f_1532_61193_61327(f_1532_61215_61307(Constants.PSModulePathEnvVar, EnvironmentVariableTarget.User), currentModulePath) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 61189, 61538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 61366, 61523);

                    currentModulePath = currentModulePath + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Path.PathSeparator).ToString(), 1532, 61406, 61424) + f_1532_61427_61522(Constants.PSModulePathEnvVar, EnvironmentVariableTarget.Machine);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 61189, 61538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 61560, 61650);

                string
                allUsersModulePath = f_1532_61588_61649(PowerShellConfig.Instance, ConfigScope.AllUsers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 61664, 61757);

                string
                personalModulePath = f_1532_61692_61756(PowerShellConfig.Instance, ConfigScope.CurrentUser)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 61771, 61873);

                string
                newModulePathString = f_1532_61800_61872(currentModulePath, allUsersModulePath, personalModulePath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 61889, 62070) || true) && (!f_1532_61894_61935(newModulePathString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 61889, 62070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 61969, 62055);

                    f_1532_61969_62054(Constants.PSModulePathEnvVar, newModulePathString);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 61889, 62070);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 62086, 62113);

                return newModulePathString;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 60764, 62124);

                string
                f_1532_60853_60948(string
                name, System.EnvironmentVariableTarget
                target)
                {
                    var return_v = GetExpandedEnvironmentVariable(name, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 60853, 60948);
                    return return_v;
                }


                string
                f_1532_61215_61307(string
                name, System.EnvironmentVariableTarget
                target)
                {
                    var return_v = GetExpandedEnvironmentVariable(name, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 61215, 61307);
                    return return_v;
                }


                int
                f_1532_61193_61327(string
                strA, string
                strB)
                {
                    var return_v = string.CompareOrdinal(strA, strB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 61193, 61327);
                    return return_v;
                }


                string
                f_1532_61427_61522(string
                name, System.EnvironmentVariableTarget
                target)
                {
                    var return_v = GetExpandedEnvironmentVariable(name, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 61427, 61522);
                    return return_v;
                }


                string
                f_1532_61588_61649(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetModulePath(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 61588, 61649);
                    return return_v;
                }


                string
                f_1532_61692_61756(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetModulePath(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 61692, 61756);
                    return return_v;
                }


                string
                f_1532_61800_61872(string
                currentProcessModulePath, string
                hklmMachineModulePath, string
                hkcuUserModulePath)
                {
                    var return_v = GetModulePath(currentProcessModulePath, hklmMachineModulePath, hkcuUserModulePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 61800, 61872);
                    return return_v;
                }


                bool
                f_1532_61894_61935(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 61894, 61935);
                    return return_v;
                }


                int
                f_1532_61969_62054(string
                variable, string
                value)
                {
                    Environment.SetEnvironmentVariable(variable, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 61969, 62054);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 60764, 62124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 60764, 62124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<string> GetModulePath(bool includeSystemModulePath, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 63153, 64257);

                var listYield = new List<String>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 63283, 63393);

                string
                modulePathString = f_1532_63309_63373(Constants.PSModulePathEnvVar) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1532, 63309, 63392) ?? f_1532_63377_63392())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 63409, 63498);

                HashSet<string>
                processedPathSet = f_1532_63444_63497(f_1532_63464_63496())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 63514, 63970) || true) && (!f_1532_63519_63562(modulePathString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 63514, 63970);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 63596, 63955);
                        foreach (string envPath in f_1532_63623_63716_I(f_1532_63623_63716(modulePathString, Utils.Separators.PathSeparator, StringSplitOptions.RemoveEmptyEntries)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 63596, 63955);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 63758, 63835);

                            var
                            processedPath = f_1532_63778_63834(context, envPath, processedPathSet)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 63857, 63936) || true) && (processedPath != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 63857, 63936);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 63909, 63936);

                                listYield.Add(processedPath);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 63857, 63936);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 63596, 63955);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 360);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 360);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 63514, 63970);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 63986, 64246) || true) && (includeSystemModulePath)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 63986, 64246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 64047, 64138);

                    var
                    processedPath = f_1532_64067_64137(context, f_1532_64097_64118(), processedPathSet)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 64156, 64231) || true) && (processedPath != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 64156, 64231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 64204, 64231);

                        listYield.Add(processedPath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 64156, 64231);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 63986, 64246);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 63153, 64257);

                return listYield;

                string?
                f_1532_63309_63373(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 63309, 63373);
                    return return_v;
                }


                string
                f_1532_63377_63392()
                {
                    var return_v = SetModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 63377, 63392);
                    return return_v;
                }


                System.StringComparer
                f_1532_63464_63496()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 63464, 63496);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1532_63444_63497(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 63444, 63497);
                    return return_v;
                }


                bool
                f_1532_63519_63562(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 63519, 63562);
                    return return_v;
                }


                string[]
                f_1532_63623_63716(string
                this_param, char[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 63623, 63716);
                    return return_v;
                }


                string
                f_1532_63778_63834(System.Management.Automation.ExecutionContext
                context, string
                envPath, System.Collections.Generic.HashSet<string>
                processedPathSet)
                {
                    var return_v = ProcessOneModulePath(context, envPath, processedPathSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 63778, 63834);
                    return return_v;
                }


                string[]
                f_1532_63623_63716_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 63623, 63716);
                    return return_v;
                }


                string
                f_1532_64097_64118()
                {
                    var return_v = GetPSHomeModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 64097, 64118);
                    return return_v;
                }


                string
                f_1532_64067_64137(System.Management.Automation.ExecutionContext
                context, string
                envPath, System.Collections.Generic.HashSet<string>
                processedPathSet)
                {
                    var return_v = ProcessOneModulePath(context, envPath, processedPathSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 64067, 64137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 63153, 64257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 63153, 64257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string ProcessOneModulePath(ExecutionContext context, string envPath, HashSet<string> processedPathSet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 64269, 67253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 64412, 64451);

                string
                trimmedenvPath = f_1532_64436_64450(envPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 64467, 64512);

                bool
                isUnc = f_1532_64480_64511(trimmedenvPath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 64526, 65050) || true) && (!isUnc)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 64526, 65050);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 64761, 64975) || true) && (f_1532_64765_64842(trimmedenvPath, "filesystem::", StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 64761, 64975);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 64884, 64956);

                        trimmedenvPath = f_1532_64901_64955(trimmedenvPath, 0, 12);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 64761, 64975);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 64995, 65035);

                    isUnc = f_1532_65003_65034(trimmedenvPath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 64526, 65050);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 65159, 65239) || true) && (isUnc)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 65159, 65239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 65202, 65224);

                    return trimmedenvPath;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 65159, 65239);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 65607, 67214) || true) && (f_1532_65611_65688(f_1532_65611_65637(context), f_1532_65655_65687(f_1532_65655_65676(context))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 65607, 67214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 65722, 65751);

                    ProviderInfo
                    provider = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 65769, 65810);

                    IEnumerable<string>
                    resolvedPaths = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 65872, 66028);

                        resolvedPaths = f_1532_65888_66027(f_1532_65888_65913(f_1532_65888_65908(context)), f_1532_65974_66012(trimmedenvPath), out provider);
                    }
                    catch (ItemNotFoundException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1532, 66065, 66201);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1532, 66065, 66201);
                        // silently skip directories that are not found
                    }
                    catch (DriveNotFoundException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1532, 66219, 66351);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1532, 66219, 66351);
                        // silently skip drives that are not found
                    }
                    catch (NotSupportedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1532, 66369, 66705);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1532, 66369, 66705);
                        // silently skip invalid path
                        // NotSupportedException is thrown if path contains a colon (":") that is not part of a
                        // volume identifier (for example, "c:\" is Supported but not "c:\temp\Z:\invalidPath")
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 66725, 67073) || true) && (provider != null && (DynAbs.Tracing.TraceSender.Expression_True(1532, 66729, 66770) && resolvedPaths != null) && (DynAbs.Tracing.TraceSender.Expression_True(1532, 66729, 66827) && f_1532_66774_66827(provider, f_1532_66794_66826(f_1532_66794_66815(context)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 66725, 67073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 66869, 66913);

                        var
                        result = f_1532_66882_66912(resolvedPaths)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 66935, 67054) || true) && (f_1532_66939_66967(processedPathSet, result))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 66935, 67054);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 67017, 67031);

                            return result;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 66935, 67054);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 66725, 67073);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 65607, 67214);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 65607, 67214);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 67107, 67214) || true) && (f_1532_67111_67143(trimmedenvPath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 67107, 67214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 67177, 67199);

                        return trimmedenvPath;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 67107, 67214);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 65607, 67214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 67230, 67242);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 64269, 67253);

                string
                f_1532_64436_64450(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 64436, 64450);
                    return return_v;
                }


                bool
                f_1532_64480_64511(string
                path)
                {
                    var return_v = Utils.PathIsUnc(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 64480, 64511);
                    return return_v;
                }


                bool
                f_1532_64765_64842(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 64765, 64842);
                    return return_v;
                }


                string
                f_1532_64901_64955(string
                this_param, int
                startIndex, int
                count)
                {
                    var return_v = this_param.Remove(startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 64901, 64955);
                    return return_v;
                }


                bool
                f_1532_65003_65034(string
                path)
                {
                    var return_v = Utils.PathIsUnc(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 65003, 65034);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_65611_65637(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 65611, 65637);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1532_65655_65676(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 65655, 65676);
                    return return_v;
                }


                string
                f_1532_65655_65687(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 65655, 65687);
                    return return_v;
                }


                bool
                f_1532_65611_65688(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.IsProviderLoaded(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 65611, 65688);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1532_65888_65908(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 65888, 65908);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1532_65888_65913(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 65888, 65913);
                    return return_v;
                }


                string
                f_1532_65974_66012(string
                pattern)
                {
                    var return_v = WildcardPattern.Escape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 65974, 66012);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1532_65888_66027(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetResolvedProviderPathFromPSPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 65888, 66027);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1532_66794_66815(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 66794, 66815);
                    return return_v;
                }


                string
                f_1532_66794_66826(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 66794, 66826);
                    return return_v;
                }


                bool
                f_1532_66774_66827(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 66774, 66827);
                    return return_v;
                }


                string
                f_1532_66882_66912(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.FirstOrDefault<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 66882, 66912);
                    return return_v;
                }


                bool
                f_1532_66939_66967(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 66939, 66967);
                    return return_v;
                }


                bool
                f_1532_67111_67143(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 67111, 67143);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 64269, 67253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 64269, 67253);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void RemoveNestedModuleFunctions(PSModuleInfo module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 67440, 68329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 67634, 67666);

                List<FunctionInfo>
                input = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 67680, 67842) || true) && (f_1532_67684_67703(module) != null && (DynAbs.Tracing.TraceSender.Expression_True(1532, 67684, 67768) && f_1532_67732_67760(f_1532_67732_67751(module)) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 67680, 67842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 67787, 67842);

                    input = f_1532_67795_67841(f_1532_67795_67823(f_1532_67795_67814(module)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 67680, 67842);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 67856, 67923) || true) && ((input == null) || (DynAbs.Tracing.TraceSender.Expression_False(1532, 67860, 67897) || (f_1532_67880_67891(input) == 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 67856, 67923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 67914, 67921);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 67856, 67923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 67939, 68003);

                List<FunctionInfo>
                output = f_1532_67967_68002(f_1532_67990_68001(input))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 68017, 68251);
                    foreach (var fnInfo in f_1532_68040_68045_I(input))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 68017, 68251);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 68079, 68236) || true) && (f_1532_68083_68156(f_1532_68083_68094(module), f_1532_68102_68119(fnInfo), StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 68079, 68236);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 68198, 68217);

                            f_1532_68198_68216(output, fnInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 68079, 68236);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 68017, 68251);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 235);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 68267, 68281);

                f_1532_68267_68280(
                            input);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 68295, 68318);

                f_1532_68295_68317(input, output);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 67440, 68329);

                System.Management.Automation.SessionState
                f_1532_67684_67703(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 67684, 67703);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1532_67732_67751(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 67732, 67751);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_67732_67760(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 67732, 67760);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1532_67795_67814(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 67795, 67814);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1532_67795_67823(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 67795, 67823);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                f_1532_67795_67841(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExportedFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 67795, 67841);
                    return return_v;
                }


                int
                f_1532_67880_67891(System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 67880, 67891);
                    return return_v;
                }


                int
                f_1532_67990_68001(System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 67990, 68001);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                f_1532_67967_68002(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.FunctionInfo>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 67967, 68002);
                    return return_v;
                }


                string
                f_1532_68083_68094(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 68083, 68094);
                    return return_v;
                }


                string
                f_1532_68102_68119(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 68102, 68119);
                    return return_v;
                }


                bool
                f_1532_68083_68156(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 68083, 68156);
                    return return_v;
                }


                int
                f_1532_68198_68216(System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                this_param, System.Management.Automation.FunctionInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 68198, 68216);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                f_1532_68040_68045_I(System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 68040, 68045);
                    return return_v;
                }


                int
                f_1532_68267_68280(System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 68267, 68280);
                    return 0;
                }


                int
                f_1532_68295_68317(System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                this_param, System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.FunctionInfo>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 68295, 68317);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 67440, 68329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 67440, 68329);
            }
        }

        private static void SortAndRemoveDuplicates<T>(List<T> input, Func<T, string> keyGetter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 68341, 69421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 68454, 68523);

                f_1532_68454_68522(input != null, "Caller should verify that input != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 68539, 68823);

                f_1532_68539_68822(
                            input, delegate (T x, T y)
                                {
                                    string kx = keyGetter(x);
                                    string ky = keyGetter(y);
                                    return string.Compare(kx, ky, StringComparison.OrdinalIgnoreCase);
                                });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 68839, 68861);

                bool
                firstItem = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 68875, 68901);

                string
                previousKey = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 68915, 68957);

                List<T>
                output = f_1532_68932_68956(f_1532_68944_68955(input))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 68971, 69343);
                    foreach (T item in f_1532_68990_68995_I(input))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 68971, 69343);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 69029, 69065);

                        string
                        currentKey = f_1532_69049_69064(keyGetter, item)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 69083, 69247) || true) && ((firstItem) || (DynAbs.Tracing.TraceSender.Expression_False(1532, 69087, 69169) || !f_1532_69103_69169(currentKey, previousKey, StringComparison.OrdinalIgnoreCase)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 69083, 69247);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 69211, 69228);

                            f_1532_69211_69227(output, item);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 69083, 69247);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 69267, 69292);

                        previousKey = currentKey;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 69310, 69328);

                        firstItem = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 68971, 69343);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 373);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 69359, 69373);

                f_1532_69359_69372(
                            input);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 69387, 69410);

                f_1532_69387_69409(input, output);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 68341, 69421);

                int
                f_1532_68454_68522(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 68454, 68522);
                    return 0;
                }


                int
                f_1532_68539_68822(System.Collections.Generic.List<T>
                this_param, System.Comparison<T>
                comparison)
                {
                    this_param.Sort(comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 68539, 68822);
                    return 0;
                }


                int
                f_1532_68944_68955(System.Collections.Generic.List<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 68944, 68955);
                    return return_v;
                }


                System.Collections.Generic.List<T>
                f_1532_68932_68956(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<T>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 68932, 68956);
                    return return_v;
                }


                string
                f_1532_69049_69064(System.Func<T, string>
                this_param, T
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 69049, 69064);
                    return return_v;
                }


                bool
                f_1532_69103_69169(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 69103, 69169);
                    return return_v;
                }


                int
                f_1532_69211_69227(System.Collections.Generic.List<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 69211, 69227);
                    return 0;
                }


                System.Collections.Generic.List<T>
                f_1532_68990_68995_I(System.Collections.Generic.List<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 68990, 68995);
                    return return_v;
                }


                int
                f_1532_69359_69372(System.Collections.Generic.List<T>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 69359, 69372);
                    return 0;
                }


                int
                f_1532_69387_69409(System.Collections.Generic.List<T>
                this_param, System.Collections.Generic.List<T>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<T>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 69387, 69409);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 68341, 69421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 68341, 69421);
            }
        }

        internal static void ExportModuleMembers(
                    PSCmdlet cmdlet,
                    SessionStateInternal sessionState,
                    List<WildcardPattern> functionPatterns,
                    List<WildcardPattern> cmdletPatterns,
                    List<WildcardPattern> aliasPatterns,
                    List<WildcardPattern> variablePatterns,
                    List<string> doNotExportCmdlets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 70261, 78624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 70796, 70830);

                sessionState.UseExportList = true;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 70846, 72068) || true) && (functionPatterns != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 70846, 72068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 70908, 70946);

                    sessionState.FunctionsExported = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 70964, 71120) || true) && (f_1532_70968_71009(functionPatterns))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 70964, 71120);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 71051, 71101);

                        sessionState.FunctionsExportedWithWildcard = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 70964, 71120);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 71140, 71218);

                    IDictionary<string, FunctionInfo>
                    ft = f_1532_71179_71217(f_1532_71179_71203(sessionState))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 71238, 71929);
                        foreach (KeyValuePair<string, FunctionInfo> entry in f_1532_71291_71293_I(ft))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 71238, 71929);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 71383, 71524) || true) && ((f_1532_71388_71407(entry.Value) & ScopedItemOptions.AllScope) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 71383, 71524);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 71492, 71501);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 71383, 71524);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 71548, 71910) || true) && (f_1532_71552_71635(entry.Key, functionPatterns, false))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 71548, 71910);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 71685, 71733);

                                f_1532_71685_71732(f_1532_71685_71715(sessionState), entry.Value);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 71759, 71832);

                                string
                                message = f_1532_71776_71831(f_1532_71794_71819(), entry.Key)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 71858, 71887);

                                f_1532_71858_71886(cmdlet, message);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 71548, 71910);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 71238, 71929);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 692);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 692);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 71949, 72053);

                    f_1532_71949_72052(f_1532_71973_72003(sessionState), delegate (FunctionInfo ci)
                    { return ci.Name; });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 70846, 72068);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 72084, 75640) || true) && (cmdletPatterns != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 72084, 75640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 72144, 72224);

                    IDictionary<string, List<CmdletInfo>>
                    ft = f_1532_72187_72223(f_1532_72187_72211(sessionState))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 72442, 74028) || true) && (f_1532_72446_72487(f_1532_72446_72481(f_1532_72446_72465(sessionState))) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 72442, 74028);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 72533, 72599);

                        CmdletInfo[]
                        copy = f_1532_72553_72598(f_1532_72553_72588(f_1532_72553_72572(sessionState)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 72621, 72665);

                        f_1532_72621_72664(f_1532_72621_72656(f_1532_72621_72640(sessionState)));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 72689, 74009);
                            foreach (CmdletInfo element in f_1532_72720_72724_I(copy))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 72689, 74009);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 72774, 73986) || true) && (doNotExportCmdlets == null
                                || (DynAbs.Tracing.TraceSender.Expression_False(1532, 72778, 72958) || !f_1532_72838_72958(doNotExportCmdlets, cmdletName => string.Equals(element.FullName, cmdletName, StringComparison.OrdinalIgnoreCase))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 72774, 73986);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 73016, 73959) || true) && (f_1532_73020_73104(f_1532_73068_73080(element), cmdletPatterns, false))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 73016, 73959);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 73170, 73244);

                                        string
                                        message = f_1532_73187_73243(f_1532_73205_73228(), f_1532_73230_73242(element))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 73278, 73307);

                                        f_1532_73278_73306(cmdlet, message);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 73459, 73686);

                                        CmdletInfo
                                        exportedCmdlet = new CmdletInfo(f_1532_73502_73514(element), f_1532_73516_73540(element),
                                        f_1532_73579_73595(element), null, f_1532_73603_73618(element))
                                        { Module = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1532_73664_73683(sessionState), 1532, 73487, 73685) }
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 73720, 73838);

                                        f_1532_73720_73837(f_1532_73731_73750(sessionState) != null, "sessionState.Module should not be null by the time we're exporting cmdlets");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 73872, 73928);

                                        f_1532_73872_73927(f_1532_73872_73907(f_1532_73872_73891(sessionState)), exportedCmdlet);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 73016, 73959);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 72774, 73986);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 72689, 74009);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 1321);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 1321);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 72442, 74028);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 74128, 75498);
                        foreach (KeyValuePair<string, List<CmdletInfo>> entry in f_1532_74185_74187_I(ft))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 74128, 75498);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 74229, 74272);

                            CmdletInfo
                            cmdletToImport = f_1532_74257_74271(entry.Value, 0)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 74294, 75479) || true) && (doNotExportCmdlets == null
                            || (DynAbs.Tracing.TraceSender.Expression_False(1532, 74298, 74481) || !f_1532_74354_74481(doNotExportCmdlets, cmdletName => string.Equals(cmdletToImport.FullName, cmdletName, StringComparison.OrdinalIgnoreCase))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 74294, 75479);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 74531, 75456) || true) && (f_1532_74535_74616(entry.Key, cmdletPatterns, false))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 74531, 75456);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 74674, 74745);

                                    string
                                    message = f_1532_74691_74744(f_1532_74709_74732(), entry.Key)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 74775, 74804);

                                    f_1532_74775_74803(cmdlet, message);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 74948, 75195);

                                    CmdletInfo
                                    exportedCmdlet = new CmdletInfo(f_1532_74991_75010(cmdletToImport), f_1532_75012_75043(cmdletToImport),
                                    f_1532_75078_75101(cmdletToImport), null, f_1532_75109_75131(cmdletToImport))
                                    { Module = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1532_75173_75192(sessionState), 1532, 74976, 75194) }
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 75225, 75343);

                                    f_1532_75225_75342(f_1532_75236_75255(sessionState) != null, "sessionState.Module should not be null by the time we're exporting cmdlets");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 75373, 75429);

                                    f_1532_75373_75428(f_1532_75373_75408(f_1532_75373_75392(sessionState)), exportedCmdlet);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 74531, 75456);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 74294, 75479);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 74128, 75498);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 1371);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 1371);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 75518, 75625);

                    f_1532_75518_75624(f_1532_75542_75577(f_1532_75542_75561(sessionState)), delegate (CmdletInfo ci)
                    { return ci.Name; });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 72084, 75640);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 75656, 76712) || true) && (variablePatterns != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 75656, 76712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 75718, 75790);

                    IDictionary<string, PSVariable>
                    vt = f_1532_75755_75789(f_1532_75755_75779(sessionState))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 75810, 76577);
                        foreach (KeyValuePair<string, PSVariable> entry in f_1532_75861_75863_I(vt))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 75810, 76577);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 75998, 76172) || true) && (f_1532_76002_76024(entry.Value) || (DynAbs.Tracing.TraceSender.Expression_False(1532, 76002, 76090) || f_1532_76028_76084(PSModuleInfo._builtinVariables, entry.Key) != -1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 75998, 76172);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 76140, 76149);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 75998, 76172);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 76196, 76558) || true) && (f_1532_76200_76283(entry.Key, variablePatterns, false))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 76196, 76558);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 76333, 76406);

                                string
                                message = f_1532_76350_76405(f_1532_76368_76393(), entry.Key)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 76432, 76461);

                                f_1532_76432_76460(cmdlet, message);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 76487, 76535);

                                f_1532_76487_76534(f_1532_76487_76517(sessionState), entry.Value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 76196, 76558);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 75810, 76577);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 768);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 768);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 76597, 76697);

                    f_1532_76597_76696(f_1532_76621_76651(sessionState), delegate (PSVariable v)
                    { return v.Name; });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 75656, 76712);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 76728, 78613) || true) && (aliasPatterns != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 76728, 78613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 76787, 76852);

                    IEnumerable<AliasInfo>
                    mai = f_1532_76816_76851(f_1532_76816_76840(sessionState))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 77069, 77783) || true) && (f_1532_77073_77119(f_1532_77073_77113(f_1532_77073_77092(sessionState))) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 77069, 77783);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 77165, 77235);

                        AliasInfo[]
                        copy = f_1532_77184_77234(f_1532_77184_77224(f_1532_77184_77203(sessionState)))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 77259, 77764);
                            foreach (var element in f_1532_77283_77287_I(copy))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 77259, 77764);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 77337, 77741) || true) && (f_1532_77341_77424(f_1532_77389_77401(element), aliasPatterns, false))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 77337, 77741);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 77482, 77555);

                                    string
                                    message = f_1532_77499_77554(f_1532_77517_77539(), f_1532_77541_77553(element))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 77585, 77614);

                                    f_1532_77585_77613(cmdlet, message);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 77644, 77714);

                                    f_1532_77644_77713(f_1532_77644_77672(sessionState), f_1532_77677_77712(element, sessionState));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 77337, 77741);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 77259, 77764);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 506);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 506);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 77069, 77783);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 77803, 78479);
                        foreach (AliasInfo entry in f_1532_77831_77834_I(mai))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 77803, 78479);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 77923, 78058) || true) && ((f_1532_77928_77941(entry) & ScopedItemOptions.AllScope) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 77923, 78058);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 78026, 78035);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 77923, 78058);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 78082, 78460) || true) && (f_1532_78086_78167(f_1532_78134_78144(entry), aliasPatterns, false))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 78082, 78460);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 78217, 78288);

                                string
                                message = f_1532_78234_78287(f_1532_78252_78274(), f_1532_78276_78286(entry))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 78314, 78343);

                                f_1532_78314_78342(cmdlet, message);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 78369, 78437);

                                f_1532_78369_78436(f_1532_78369_78397(sessionState), f_1532_78402_78435(entry, sessionState));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 78082, 78460);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 77803, 78479);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 677);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 677);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 78499, 78598);

                    f_1532_78499_78597(f_1532_78523_78551(sessionState), delegate (AliasInfo ci)
                    { return ci.Name; });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 76728, 78613);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 70261, 78624);

                bool
                f_1532_70968_71009(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                list)
                {
                    var return_v = PatternContainsWildcard(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 70968, 71009);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1532_71179_71203(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ModuleScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 71179, 71203);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                f_1532_71179_71217(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.FunctionTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 71179, 71217);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1532_71388_71407(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 71388, 71407);
                    return return_v;
                }


                bool
                f_1532_71552_71635(string
                text, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 71552, 71635);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                f_1532_71685_71715(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExportedFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 71685, 71715);
                    return return_v;
                }


                int
                f_1532_71685_71732(System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                this_param, System.Management.Automation.FunctionInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 71685, 71732);
                    return 0;
                }


                string
                f_1532_71794_71819()
                {
                    var return_v = Modules.ExportingFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 71794, 71819);
                    return return_v;
                }


                string
                f_1532_71776_71831(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 71776, 71831);
                    return return_v;
                }


                int
                f_1532_71858_71886(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 71858, 71886);
                    return 0;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.FunctionInfo>
                f_1532_71291_71293_I(System.Collections.Generic.IDictionary<string, System.Management.Automation.FunctionInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 71291, 71293);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                f_1532_71973_72003(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExportedFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 71973, 72003);
                    return return_v;
                }


                int
                f_1532_71949_72052(System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                input, System.Func<System.Management.Automation.FunctionInfo, string>
                keyGetter)
                {
                    SortAndRemoveDuplicates(input, keyGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 71949, 72052);
                    return 0;
                }


                System.Management.Automation.SessionStateScope
                f_1532_72187_72211(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ModuleScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 72187, 72211);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
                f_1532_72187_72223(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.CmdletTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 72187, 72223);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_72446_72465(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 72446, 72465);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                f_1532_72446_72481(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.CompiledExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 72446, 72481);
                    return return_v;
                }


                int
                f_1532_72446_72487(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 72446, 72487);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_72553_72572(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 72553, 72572);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                f_1532_72553_72588(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.CompiledExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 72553, 72588);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo[]
                f_1532_72553_72598(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 72553, 72598);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_72621_72640(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 72621, 72640);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                f_1532_72621_72656(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.CompiledExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 72621, 72656);
                    return return_v;
                }


                int
                f_1532_72621_72664(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 72621, 72664);
                    return 0;
                }


                bool
                f_1532_72838_72958(System.Collections.Generic.List<string>
                this_param, System.Predicate<string>
                match)
                {
                    var return_v = this_param.Exists(match);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 72838, 72958);
                    return return_v;
                }


                string
                f_1532_73068_73080(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 73068, 73080);
                    return return_v;
                }


                bool
                f_1532_73020_73104(string
                text, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 73020, 73104);
                    return return_v;
                }


                string
                f_1532_73205_73228()
                {
                    var return_v = Modules.ExportingCmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 73205, 73228);
                    return return_v;
                }


                string
                f_1532_73230_73242(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 73230, 73242);
                    return return_v;
                }


                string
                f_1532_73187_73243(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 73187, 73243);
                    return return_v;
                }


                int
                f_1532_73278_73306(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 73278, 73306);
                    return 0;
                }


                string
                f_1532_73502_73514(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 73502, 73514);
                    return return_v;
                }


                System.Type
                f_1532_73516_73540(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 73516, 73540);
                    return return_v;
                }


                string
                f_1532_73579_73595(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.HelpFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 73579, 73595);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1532_73603_73618(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 73603, 73618);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_73664_73683(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 73664, 73683);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_73731_73750(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 73731, 73750);
                    return return_v;
                }


                int
                f_1532_73720_73837(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 73720, 73837);
                    return 0;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_73872_73891(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 73872, 73891);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                f_1532_73872_73907(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.CompiledExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 73872, 73907);
                    return return_v;
                }


                int
                f_1532_73872_73927(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                this_param, System.Management.Automation.CmdletInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 73872, 73927);
                    return 0;
                }


                System.Management.Automation.CmdletInfo[]
                f_1532_72720_72724_I(System.Management.Automation.CmdletInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 72720, 72724);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1532_74257_74271(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 74257, 74271);
                    return return_v;
                }


                bool
                f_1532_74354_74481(System.Collections.Generic.List<string>
                this_param, System.Predicate<string>
                match)
                {
                    var return_v = this_param.Exists(match);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 74354, 74481);
                    return return_v;
                }


                bool
                f_1532_74535_74616(string
                text, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 74535, 74616);
                    return return_v;
                }


                string
                f_1532_74709_74732()
                {
                    var return_v = Modules.ExportingCmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 74709, 74732);
                    return return_v;
                }


                string
                f_1532_74691_74744(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 74691, 74744);
                    return return_v;
                }


                int
                f_1532_74775_74803(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 74775, 74803);
                    return 0;
                }


                string
                f_1532_74991_75010(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 74991, 75010);
                    return return_v;
                }


                System.Type
                f_1532_75012_75043(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 75012, 75043);
                    return return_v;
                }


                string
                f_1532_75078_75101(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.HelpFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 75078, 75101);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1532_75109_75131(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 75109, 75131);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_75173_75192(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 75173, 75192);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_75236_75255(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 75236, 75255);
                    return return_v;
                }


                int
                f_1532_75225_75342(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 75225, 75342);
                    return 0;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_75373_75392(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 75373, 75392);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                f_1532_75373_75408(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.CompiledExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 75373, 75408);
                    return return_v;
                }


                int
                f_1532_75373_75428(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                this_param, System.Management.Automation.CmdletInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 75373, 75428);
                    return 0;
                }


                System.Collections.Generic.IDictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
                f_1532_74185_74187_I(System.Collections.Generic.IDictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 74185, 74187);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_75542_75561(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 75542, 75561);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                f_1532_75542_75577(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.CompiledExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 75542, 75577);
                    return return_v;
                }


                int
                f_1532_75518_75624(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                input, System.Func<System.Management.Automation.CmdletInfo, string>
                keyGetter)
                {
                    SortAndRemoveDuplicates(input, keyGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 75518, 75624);
                    return 0;
                }


                System.Management.Automation.SessionStateScope
                f_1532_75755_75779(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ModuleScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 75755, 75779);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.PSVariable>
                f_1532_75755_75789(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 75755, 75789);
                    return return_v;
                }


                bool
                f_1532_76002_76024(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.IsAllScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 76002, 76024);
                    return return_v;
                }


                int
                f_1532_76028_76084(string[]
                array, string
                value)
                {
                    var return_v = Array.IndexOf(array, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 76028, 76084);
                    return return_v;
                }


                bool
                f_1532_76200_76283(string
                text, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 76200, 76283);
                    return return_v;
                }


                string
                f_1532_76368_76393()
                {
                    var return_v = Modules.ExportingVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 76368, 76393);
                    return return_v;
                }


                string
                f_1532_76350_76405(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 76350, 76405);
                    return return_v;
                }


                int
                f_1532_76432_76460(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 76432, 76460);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSVariable>
                f_1532_76487_76517(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExportedVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 76487, 76517);
                    return return_v;
                }


                int
                f_1532_76487_76534(System.Collections.Generic.List<System.Management.Automation.PSVariable>
                this_param, System.Management.Automation.PSVariable
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 76487, 76534);
                    return 0;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.PSVariable>
                f_1532_75861_75863_I(System.Collections.Generic.IDictionary<string, System.Management.Automation.PSVariable>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 75861, 75863);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSVariable>
                f_1532_76621_76651(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExportedVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 76621, 76651);
                    return return_v;
                }


                int
                f_1532_76597_76696(System.Collections.Generic.List<System.Management.Automation.PSVariable>
                input, System.Func<System.Management.Automation.PSVariable, string>
                keyGetter)
                {
                    SortAndRemoveDuplicates(input, keyGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 76597, 76696);
                    return 0;
                }


                System.Management.Automation.SessionStateScope
                f_1532_76816_76840(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ModuleScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 76816, 76840);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.AliasInfo>
                f_1532_76816_76851(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.AliasTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 76816, 76851);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_77073_77092(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 77073, 77092);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                f_1532_77073_77113(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.CompiledAliasExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 77073, 77113);
                    return return_v;
                }


                int
                f_1532_77073_77119(System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 77073, 77119);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_77184_77203(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 77184, 77203);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                f_1532_77184_77224(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.CompiledAliasExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 77184, 77224);
                    return return_v;
                }


                System.Management.Automation.AliasInfo[]
                f_1532_77184_77234(System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 77184, 77234);
                    return return_v;
                }


                string
                f_1532_77389_77401(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 77389, 77401);
                    return return_v;
                }


                bool
                f_1532_77341_77424(string
                text, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 77341, 77424);
                    return return_v;
                }


                string
                f_1532_77517_77539()
                {
                    var return_v = Modules.ExportingAlias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 77517, 77539);
                    return return_v;
                }


                string
                f_1532_77541_77553(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 77541, 77553);
                    return return_v;
                }


                string
                f_1532_77499_77554(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 77499, 77554);
                    return return_v;
                }


                int
                f_1532_77585_77613(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 77585, 77613);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                f_1532_77644_77672(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExportedAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 77644, 77672);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1532_77677_77712(System.Management.Automation.AliasInfo
                alias, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = NewAliasInfo(alias, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 77677, 77712);
                    return return_v;
                }


                int
                f_1532_77644_77713(System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                this_param, System.Management.Automation.AliasInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 77644, 77713);
                    return 0;
                }


                System.Management.Automation.AliasInfo[]
                f_1532_77283_77287_I(System.Management.Automation.AliasInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 77283, 77287);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1532_77928_77941(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 77928, 77941);
                    return return_v;
                }


                string
                f_1532_78134_78144(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 78134, 78144);
                    return return_v;
                }


                bool
                f_1532_78086_78167(string
                text, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 78086, 78167);
                    return return_v;
                }


                string
                f_1532_78252_78274()
                {
                    var return_v = Modules.ExportingAlias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 78252, 78274);
                    return return_v;
                }


                string
                f_1532_78276_78286(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 78276, 78286);
                    return return_v;
                }


                string
                f_1532_78234_78287(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 78234, 78287);
                    return return_v;
                }


                int
                f_1532_78314_78342(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 78314, 78342);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                f_1532_78369_78397(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExportedAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 78369, 78397);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1532_78402_78435(System.Management.Automation.AliasInfo
                alias, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = NewAliasInfo(alias, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 78402, 78435);
                    return return_v;
                }


                int
                f_1532_78369_78436(System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                this_param, System.Management.Automation.AliasInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 78369, 78436);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.AliasInfo>
                f_1532_77831_77834_I(System.Collections.Generic.IEnumerable<System.Management.Automation.AliasInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 77831, 77834);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                f_1532_78523_78551(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExportedAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 78523, 78551);
                    return return_v;
                }


                int
                f_1532_78499_78597(System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                input, System.Func<System.Management.Automation.AliasInfo, string>
                keyGetter)
                {
                    SortAndRemoveDuplicates(input, keyGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 78499, 78597);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 70261, 78624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 70261, 78624);
            }
        }

        internal static bool PatternContainsWildcard(List<WildcardPattern> list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 78857, 79290);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 78954, 79250) || true) && (list != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 78954, 79250);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 79004, 79235);
                        foreach (var item in f_1532_79025_79029_I(list))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 79004, 79235);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 79071, 79216) || true) && (f_1532_79075_79131(f_1532_79118_79130(item)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1532, 79071, 79216);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 79181, 79193);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 79071, 79216);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 79004, 79235);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1532, 1, 232);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1532, 1, 232);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1532, 78954, 79250);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 79266, 79279);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 78857, 79290);

                string
                f_1532_79118_79130(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 79118, 79130);
                    return return_v;
                }


                bool
                f_1532_79075_79131(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 79075, 79131);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                f_1532_79025_79029_I(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 79025, 79029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 78857, 79290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 78857, 79290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static AliasInfo NewAliasInfo(AliasInfo alias, SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1532, 79302, 80005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 79416, 79470);

                f_1532_79416_79469(alias != null, "alias should not be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 79484, 79552);

                f_1532_79484_79551(sessionState != null, "sessionState should not be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 79566, 79684);

                f_1532_79566_79683(f_1532_79577_79596(sessionState) != null, "sessionState.Module should not be null by the time we're exporting aliases");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 79797, 79963);

                var
                aliasCopy = new AliasInfo(f_1532_79827_79837(alias), f_1532_79839_79855(alias), f_1532_79857_79870(alias), f_1532_79872_79885(alias))
                {
                    Module = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1532_79928_79947(sessionState), 1532, 79813, 79962)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 79977, 79994);

                return aliasCopy;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1532, 79302, 80005);

                int
                f_1532_79416_79469(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 79416, 79469);
                    return 0;
                }


                int
                f_1532_79484_79551(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 79484, 79551);
                    return 0;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_79577_79596(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 79577, 79596);
                    return return_v;
                }


                int
                f_1532_79566_79683(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 79566, 79683);
                    return 0;
                }


                string
                f_1532_79827_79837(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 79827, 79837);
                    return return_v;
                }


                string
                f_1532_79839_79855(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Definition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 79839, 79855);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1532_79857_79870(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 79857, 79870);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1532_79872_79885(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 79872, 79885);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1532_79928_79947(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 79928, 79947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1532, 79302, 80005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 79302, 80005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ModuleIntrinsics()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1532, 802, 80012);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 1031, 1105);
            Tracer = f_1532_1040_1105("Modules", "Module loading and analysis");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 1298, 1437);
            s_windowsPowerShellPSHomeModulePath = f_1532_1349_1437(f_1532_1362_1396(), "WindowsPowerShell", "v1.0", "Modules");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 1914, 1940);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 42178, 42785);
            PSModuleProcessableExtensions = new string[] {
                            StringLiterals.PowerShellDataFileExtension,
                            StringLiterals.PowerShellScriptFileExtension,
                            StringLiterals.PowerShellModuleFileExtension,
                            StringLiterals.PowerShellCmdletizationFileExtension,
                            StringLiterals.PowerShellNgenAssemblyExtension,
                            StringLiterals.PowerShellILAssemblyExtension,
                            StringLiterals.PowerShellILExecutableExtension,
                        };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 42982, 43503);
            PSModuleExtensions = new string[] {
                            StringLiterals.PowerShellDataFileExtension,
                            StringLiterals.PowerShellModuleFileExtension,
                            StringLiterals.PowerShellCmdletizationFileExtension,
                            StringLiterals.PowerShellNgenAssemblyExtension,
                            StringLiterals.PowerShellILAssemblyExtension,
                            StringLiterals.PowerShellILExecutableExtension,
                        };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1532, 47241, 47259);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1532, 802, 80012);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1532, 802, 80012);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1532, 802, 80012);

        static System.Management.Automation.PSTraceSource
        f_1532_1040_1105(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 1040, 1105);
            return return_v;
        }


        static string
        f_1532_1362_1396()
        {
            var return_v = System.Environment.SystemDirectory;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 1362, 1396);
            return return_v;
        }


        static string
        f_1532_1349_1437(string
        path1, string
        path2, string
        path3, string
        path4)
        {
            var return_v = Path.Combine(path1, path2, path3, path4);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 1349, 1437);
            return return_v;
        }


        static string
        f_1532_1611_1626()
        {
            var return_v = SetModulePath();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 1611, 1626);
            return return_v;
        }


        System.StringComparer
        f_1532_1850_1882()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1532, 1850, 1882);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
        f_1532_1813_1883(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1532, 1813, 1883);
            return return_v;
        }

    }

    /// <summary>
    /// Enumeration of reasons for a failure to match a module by constraints.
    /// </summary>
    internal enum ModuleMatchFailure
    {
        /// <summary>Match did not fail.</summary>
        None,

        /// <summary>Match failed because the module was null.</summary>
        NullModule,

        /// <summary>Module name did not match.</summary>
        Name,

        /// <summary>Module GUID did not match.</summary>
        Guid,

        /// <summary>Module version did not match the required version.</summary>
        RequiredVersion,

        /// <summary>Module version was lower than the minimum version.</summary>
        MinimumVersion,

        /// <summary>Module version was greater than the maximum version.</summary>
        MaximumVersion,

        /// <summary>The module specifcation passed in was null.</summary>
        NullModuleSpecification,
    }

    /// <summary>
    /// Used by Modules/Snapins to provide a hook to the engine for startup initialization
    /// w.r.t compiled assembly loading.
    /// </summary>
    public interface IModuleAssemblyInitializer
    {

        void OnImport();
    }

    /// <summary>
    /// Used by modules to provide a hook to the engine for cleanup on removal
    /// w.r.t. compiled assembly being removed.
    /// </summary>
    public interface IModuleAssemblyCleanup
    {

        void OnRemove(PSModuleInfo psModuleInfo);
    }
}
