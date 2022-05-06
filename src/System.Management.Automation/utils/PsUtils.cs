// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation.Language;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace System.Management.Automation
{
    internal static class PsUtils
    {
        internal static ProcessModule GetMainModule(Process targetProcess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 2270, 3138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 2361, 2381);

                int
                caughtCount = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 2397, 3127) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 2397, 3127);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 2486, 2518);

                            return f_1038_2493_2517(targetProcess);
                        }
                        catch (System.ComponentModel.Win32Exception e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1038, 2555, 3112);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 2796, 2855) || true) && (f_1038_2800_2817(e) == 5)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 2796, 2855);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 2849, 2855);

                                throw;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 2796, 2855);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 2947, 2961);

                            caughtCount++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 2983, 3018);

                            f_1038_2983_3017(100);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 3040, 3093) || true) && (caughtCount == 5)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 3040, 3093);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 3087, 3093);

                                throw;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 3040, 3093);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1038, 2555, 3112);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 2397, 3127);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1038, 2397, 3127);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1038, 2397, 3127);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 2270, 3138);

                System.Diagnostics.ProcessModule
                f_1038_2493_2517(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.MainModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 2493, 2517);
                    return return_v;
                }


                int
                f_1038_2800_2817(System.ComponentModel.Win32Exception
                this_param)
                {
                    var return_v = this_param.NativeErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 2800, 2817);
                    return return_v;
                }


                int
                f_1038_2983_3017(int
                millisecondsTimeout)
                {
                    System.Threading.Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 2983, 3017);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 2270, 3138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 2270, 3138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int? s_currentParentProcessId;

        private static readonly int s_currentProcessId;

        internal static Process GetParentProcess(Process current)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 3860, 5444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 3942, 3969);

                var
                processId = f_1038_3958_3968(current)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 4106, 4330);

                var
                parentProcessId = (DynAbs.Tracing.TraceSender.Conditional_F1(1038, 4128, 4196) || ((processId == s_currentProcessId && (DynAbs.Tracing.TraceSender.Expression_True(1038, 4128, 4196) && f_1038_4163_4196(s_currentParentProcessId)) && DynAbs.Tracing.TraceSender.Conditional_F2(1038, 4217, 4247)) || DynAbs.Tracing.TraceSender.Conditional_F3(1038, 4268, 4329))) ? f_1038_4217_4247(s_currentParentProcessId) : f_1038_4268_4329(current)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 4426, 4591) || true) && (processId == s_currentProcessId && (DynAbs.Tracing.TraceSender.Expression_True(1038, 4430, 4499) && f_1038_4465_4499_M(!s_currentParentProcessId.HasValue)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 4426, 4591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 4533, 4576);

                    s_currentParentProcessId = parentProcessId;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 4426, 4591);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 4607, 4662) || true) && (parentProcessId == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 4607, 4662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 4650, 4662);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 4607, 4662);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 4714, 4778);

                    Process
                    returnProcess = f_1038_4738_4777(parentProcessId)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 4966, 5114) || true) && (f_1038_4970_4993(returnProcess) <= f_1038_4997_5014(current))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 4966, 5114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 5037, 5058);

                        return returnProcess;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 4966, 5114);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 4966, 5114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 5102, 5114);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 4966, 5114);
                    }
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1038, 5143, 5433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 5406, 5418);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1038, 5143, 5433);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 3860, 5444);

                int
                f_1038_3958_3968(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 3958, 3968);
                    return return_v;
                }


                bool
                f_1038_4163_4196(int?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 4163, 4196);
                    return return_v;
                }


                int
                f_1038_4217_4247(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 4217, 4247);
                    return return_v;
                }


                int
                f_1038_4268_4329(System.Diagnostics.Process
                process)
                {
                    var return_v = Microsoft.PowerShell.ProcessCodeMethods.GetParentPid(process);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 4268, 4329);
                    return return_v;
                }


                bool
                f_1038_4465_4499_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 4465, 4499);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1038_4738_4777(int
                processId)
                {
                    var return_v = Process.GetProcessById(processId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 4738, 4777);
                    return return_v;
                }


                System.DateTime
                f_1038_4970_4993(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StartTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 4970, 4993);
                    return return_v;
                }


                System.DateTime
                f_1038_4997_5014(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StartTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 4997, 5014);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 3860, 5444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 3860, 5444);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsRunningOnProcessorArchitectureARM()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 5622, 5846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 5705, 5759);

                Architecture
                arch = f_1038_5725_5758()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 5773, 5835);

                return arch == Architecture.Arm || (DynAbs.Tracing.TraceSender.Expression_False(1038, 5780, 5834) || arch == Architecture.Arm64);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 5622, 5846);

                System.Runtime.InteropServices.Architecture
                f_1038_5725_5758()
                {
                    var return_v = RuntimeInformation.OSArchitecture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 5725, 5758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 5622, 5846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 5622, 5846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetTemporaryDirectory()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 5991, 6627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 6062, 6092);

                string
                tempDir = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 6106, 6143);

                string
                tempPath = f_1038_6124_6142()
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 6157, 6322);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 6192, 6259);

                            tempDir = f_1038_6202_6258(tempPath, System.Guid.NewGuid().ToString());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 6157, 6322);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 6157, 6322) || true) && (f_1038_6295_6320(tempDir))
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1038, 6157, 6322);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1038, 6157, 6322);
                    }
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 6374, 6409);

                    f_1038_6374_6408(tempDir);
                }
                catch (UnauthorizedAccessException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1038, 6438, 6585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 6506, 6529);

                    tempDir = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1038, 6438, 6585);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 6601, 6616);

                return tempDir;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 5991, 6627);

                string
                f_1038_6124_6142()
                {
                    var return_v = Path.GetTempPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 6124, 6142);
                    return return_v;
                }


                string
                f_1038_6202_6258(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 6202, 6258);
                    return return_v;
                }


                bool
                f_1038_6295_6320(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 6295, 6320);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1038_6374_6408(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 6374, 6408);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 5991, 6627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 5991, 6627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetHostName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 6639, 7278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 6700, 6777);

                IPGlobalProperties
                ipProperties = f_1038_6734_6776()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 6793, 6833);

                string
                hostname = f_1038_6811_6832(ipProperties)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 6847, 6891);

                string
                domainName = f_1038_6867_6890(ipProperties)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 7052, 7235) || true) && (!f_1038_7057_7089(domainName) && (DynAbs.Tracing.TraceSender.Expression_True(1038, 7056, 7147) && !f_1038_7094_7147(domainName, "(none)", StringComparison.Ordinal)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 7052, 7235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 7181, 7220);

                    hostname = hostname + "." + domainName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 7052, 7235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 7251, 7267);

                return hostname;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 6639, 7278);

                System.Net.NetworkInformation.IPGlobalProperties
                f_1038_6734_6776()
                {
                    var return_v = IPGlobalProperties.GetIPGlobalProperties();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 6734, 6776);
                    return return_v;
                }


                string
                f_1038_6811_6832(System.Net.NetworkInformation.IPGlobalProperties
                this_param)
                {
                    var return_v = this_param.HostName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 6811, 6832);
                    return return_v;
                }


                string
                f_1038_6867_6890(System.Net.NetworkInformation.IPGlobalProperties
                this_param)
                {
                    var return_v = this_param.DomainName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 6867, 6890);
                    return return_v;
                }


                bool
                f_1038_7057_7089(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 7057, 7089);
                    return return_v;
                }


                bool
                f_1038_7094_7147(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 7094, 7147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 6639, 7278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 6639, 7278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static uint GetNativeThreadId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 7290, 7487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 7426, 7468);

                return f_1038_7433_7467();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 7290, 7487);

                uint
                f_1038_7433_7467()
                {
                    var return_v = NativeMethods.GetCurrentThreadId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 7433, 7467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 7290, 7487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 7290, 7487);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private static class NativeMethods
        {
            [DllImport(PinvokeDllNames.GetCurrentThreadIdDllName)]
            internal static extern uint GetCurrentThreadId();

            static NativeMethods()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1038, 7499, 7686);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1038, 7499, 7686);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 7499, 7686);
            }

        }

        internal static string GetUsingExpressionKey(Language.UsingExpressionAst usingAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 8479, 9757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 8586, 8670);

                f_1038_8586_8669(usingAst != null, "Caller makes sure the parameter is not null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 9452, 9494);

                string
                usingAstText = f_1038_9474_9493(usingAst)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 9508, 9664) || true) && (f_1038_9512_9534(usingAst) is Language.VariableExpressionAst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 9508, 9664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 9602, 9649);

                    usingAstText = f_1038_9617_9648(usingAstText);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 9508, 9664);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 9680, 9746);

                return f_1038_9687_9745(usingAstText);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 8479, 9757);

                int
                f_1038_8586_8669(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 8586, 8669);
                    return 0;
                }


                string
                f_1038_9474_9493(System.Management.Automation.Language.UsingExpressionAst
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 9474, 9493);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1038_9512_9534(System.Management.Automation.Language.UsingExpressionAst
                this_param)
                {
                    var return_v = this_param.SubExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 9512, 9534);
                    return return_v;
                }


                string
                f_1038_9617_9648(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 9617, 9648);
                    return return_v;
                }


                string
                f_1038_9687_9745(string
                input)
                {
                    var return_v = StringToBase64Converter.StringToBase64String(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 9687, 9745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 8479, 9757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 8479, 9757);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Hashtable EvaluatePowerShellDataFileAsModuleManifest(
                                             string parameterName,
                                             string psDataFilePath,
                                             ExecutionContext context,
                                             bool skipPathValidation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 10201, 11070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 10659, 11059);

                return f_1038_10666_11058(parameterName, psDataFilePath, context, Microsoft.PowerShell.Commands.ModuleCmdletBase.PermittedCmdlets, new[] { "PSScriptRoot" }, allowEnvironmentVariables: true, skipPathValidation: skipPathValidation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 10201, 11070);

                System.Collections.Hashtable
                f_1038_10666_11058(string
                parameterName, string
                psDataFilePath, System.Management.Automation.ExecutionContext
                context, string[]
                allowedCommands, string[]
                allowedVariables, bool
                allowEnvironmentVariables, bool
                skipPathValidation)
                {
                    var return_v = EvaluatePowerShellDataFile(parameterName, psDataFilePath, context, (System.Collections.Generic.IEnumerable<string>)allowedCommands, (System.Collections.Generic.IEnumerable<string>)allowedVariables, allowEnvironmentVariables: allowEnvironmentVariables, skipPathValidation: skipPathValidation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 10666, 11058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 10201, 11070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 10201, 11070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Hashtable EvaluatePowerShellDataFile(
                                             string parameterName,
                                             string psDataFilePath,
                                             ExecutionContext context,
                                             IEnumerable<string> allowedCommands,
                                             IEnumerable<string> allowedVariables,
                                             bool allowEnvironmentVariables,
                                             bool skipPathValidation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 12152, 16831);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 12699, 12829) || true) && (!skipPathValidation && (DynAbs.Tracing.TraceSender.Expression_True(1038, 12703, 12761) && f_1038_12726_12761(parameterName)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 12699, 12829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 12765, 12827);

                    throw f_1038_12771_12826("parameterName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 12699, 12829);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 12845, 12954) || true) && (f_1038_12849_12885(psDataFilePath))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 12845, 12954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 12889, 12952);

                    throw f_1038_12895_12951("psDataFilePath");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 12845, 12954);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 12970, 13051) || true) && (context == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 12970, 13051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 12993, 13049);

                    throw f_1038_12999_13048("context");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 12970, 13051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 13067, 13087);

                string
                resolvedPath
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 13101, 14838) || true) && (skipPathValidation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 13101, 14838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 13157, 13187);

                    resolvedPath = psDataFilePath;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 13101, 14838);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 13101, 14838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 13313, 13337);

                    bool
                    isPathValid = true
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 13410, 13461);

                    string
                    pathExt = f_1038_13427_13460(psDataFilePath)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 13479, 13713) || true) && (f_1038_13483_13512(pathExt) || (DynAbs.Tracing.TraceSender.Expression_False(1038, 13483, 13632) || !f_1038_13538_13632(StringLiterals.PowerShellDataFileExtension, pathExt, StringComparison.OrdinalIgnoreCase)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 13479, 13713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 13674, 13694);

                        isPathValid = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 13479, 13713);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 13733, 13755);

                    ProviderInfo
                    provider
                    = default(ProviderInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 13773, 13883);

                    var
                    resolvedPaths = f_1038_13793_13882(f_1038_13793_13818(f_1038_13793_13813(context)), psDataFilePath, out provider)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 13976, 14201) || true) && (provider == null || (DynAbs.Tracing.TraceSender.Expression_False(1038, 13980, 14120) || !f_1038_14001_14120(Microsoft.PowerShell.Commands.FileSystemProvider.ProviderName, f_1038_14070_14083(provider), StringComparison.OrdinalIgnoreCase)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 13976, 14201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 14162, 14182);

                        isPathValid = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 13976, 14201);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 14288, 14397) || true) && (f_1038_14292_14311(resolvedPaths) != 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 14288, 14397);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 14358, 14378);

                        isPathValid = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 14288, 14397);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 14417, 14708) || true) && (!isPathValid)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 14417, 14708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 14475, 14689);

                        throw f_1038_14481_14688(parameterName, f_1038_14592_14641(), psDataFilePath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 14417, 14708);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 14728, 14760);

                    resolvedPath = f_1038_14743_14759(resolvedPaths, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 13101, 14838);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 14913, 14937);

                object
                evaluationResult
                = default(object);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 15048, 15101);

                    string
                    dataFileName = f_1038_15070_15100(resolvedPath)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 15119, 15204);

                    var
                    dataFileScriptInfo = f_1038_15144_15203(dataFileName, resolvedPath, context)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 15222, 15279);

                    ScriptBlock
                    scriptBlock = f_1038_15248_15278(dataFileScriptInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 15344, 15442);

                    f_1038_15344_15441(
                                    // Validate the scriptblock
                                    scriptBlock, allowedCommands, allowedVariables, allowEnvironmentVariables);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 15507, 15595);

                    object
                    oldPsScriptRoot = f_1038_15532_15594(context, SpecialVariables.PSScriptRootVarPath)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 15725, 15820);

                        f_1038_15725_15819(                    // Set the $PSScriptRoot before the evaluation
                                            context, SpecialVariables.PSScriptRootVarPath, f_1038_15783_15818(resolvedPath));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 15842, 15907);

                        evaluationResult = f_1038_15861_15906(f_1038_15875_15905(scriptBlock));
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1038, 15944, 16086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 15992, 16067);

                        f_1038_15992_16066(context, SpecialVariables.PSScriptRootVarPath, oldPsScriptRoot);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1038, 15944, 16086);
                    }
                }
                catch (RuntimeException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1038, 16115, 16420);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 16175, 16405);

                    throw f_1038_16181_16404(ex, f_1038_16281_16323(), psDataFilePath, f_1038_16393_16403(ex));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1038, 16115, 16420);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 16436, 16482);

                var
                retResult = evaluationResult as Hashtable
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 16496, 16725) || true) && (retResult == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 16496, 16725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 16551, 16710);

                    throw f_1038_16557_16709(f_1038_16627_16666(), psDataFilePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 16496, 16725);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 16803, 16820);

                return retResult;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 12152, 16831);

                bool
                f_1038_12726_12761(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 12726, 12761);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1038_12771_12826(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 12771, 12826);
                    return return_v;
                }


                bool
                f_1038_12849_12885(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 12849, 12885);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1038_12895_12951(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 12895, 12951);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1038_12999_13048(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 12999, 13048);
                    return return_v;
                }


                string?
                f_1038_13427_13460(string
                path)
                {
                    var return_v = Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 13427, 13460);
                    return return_v;
                }


                bool
                f_1038_13483_13512(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 13483, 13512);
                    return return_v;
                }


                bool
                f_1038_13538_13632(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 13538, 13632);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1038_13793_13813(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 13793, 13813);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1038_13793_13818(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 13793, 13818);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1038_13793_13882(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetResolvedProviderPathFromPSPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 13793, 13882);
                    return return_v;
                }


                string
                f_1038_14070_14083(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 14070, 14083);
                    return return_v;
                }


                bool
                f_1038_14001_14120(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 14001, 14120);
                    return return_v;
                }


                int
                f_1038_14292_14311(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 14292, 14311);
                    return return_v;
                }


                string
                f_1038_14592_14641()
                {
                    var return_v = ParserStrings.CannotResolvePowerShellDataFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 14592, 14641);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1038_14481_14688(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 14481, 14688);
                    return return_v;
                }


                string
                f_1038_14743_14759(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 14743, 14759);
                    return return_v;
                }


                string?
                f_1038_15070_15100(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 15070, 15100);
                    return return_v;
                }


                System.Management.Automation.ExternalScriptInfo
                f_1038_15144_15203(string
                name, string
                path, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.ExternalScriptInfo(name, path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 15144, 15203);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1038_15248_15278(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 15248, 15278);
                    return return_v;
                }


                int
                f_1038_15344_15441(System.Management.Automation.ScriptBlock
                this_param, System.Collections.Generic.IEnumerable<string>
                allowedCommands, System.Collections.Generic.IEnumerable<string>
                allowedVariables, bool
                allowEnvironmentVariables)
                {
                    this_param.CheckRestrictedLanguage(allowedCommands, allowedVariables, allowEnvironmentVariables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 15344, 15441);
                    return 0;
                }


                object
                f_1038_15532_15594(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path)
                {
                    var return_v = this_param.GetVariableValue(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 15532, 15594);
                    return return_v;
                }


                string?
                f_1038_15783_15818(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 15783, 15818);
                    return return_v;
                }


                int
                f_1038_15725_15819(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, string
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 15725, 15819);
                    return 0;
                }


                object
                f_1038_15875_15905(System.Management.Automation.ScriptBlock
                this_param, params object[]
                args)
                {
                    var return_v = this_param.InvokeReturnAsIs(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 15875, 15905);
                    return return_v;
                }


                object
                f_1038_15861_15906(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 15861, 15906);
                    return return_v;
                }


                int
                f_1038_15992_16066(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, object
                newValue)
                {
                    this_param.SetVariable(path, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 15992, 16066);
                    return 0;
                }


                string
                f_1038_16281_16323()
                {
                    var return_v = ParserStrings.CannotLoadPowerShellDataFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 16281, 16323);
                    return return_v;
                }


                string
                f_1038_16393_16403(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 16393, 16403);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1038_16181_16404(System.Management.Automation.RuntimeException
                innerException, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException((System.Exception)innerException, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 16181, 16404);
                    return return_v;
                }


                string
                f_1038_16627_16666()
                {
                    var return_v = ParserStrings.InvalidPowerShellDataFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 16627, 16666);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1038_16557_16709(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 16557, 16709);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 12152, 16831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 12152, 16831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static readonly string[] ManifestModuleVersionPropertyName;

        internal static readonly string[] ManifestGuidPropertyName;

        internal static readonly string[] ManifestPrivateDataPropertyName;

        internal static readonly string[] FastModuleManifestAnalysisPropertyNames;

        internal static Hashtable GetModuleManifestProperties(string psDataFilePath, string[] keys)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 17557, 19834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 17673, 17741);

                string
                dataFileContents = f_1038_17699_17740(psDataFilePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 17755, 17780);

                ParseError[]
                parseErrors
                = default(ParseError[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 17794, 17908);

                var
                ast = f_1038_17804_17907((f_1038_17805_17817()), psDataFilePath, dataFileContents, null, out parseErrors, ParseMode.ModuleAnalysis)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 17922, 18266) || true) && (f_1038_17926_17944(parseErrors) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 17922, 18266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 17982, 18023);

                    var
                    pe = f_1038_17991_18022(parseErrors)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 18041, 18251);

                    throw f_1038_18047_18250(pe, f_1038_18137_18179(), psDataFilePath, f_1038_18239_18249(pe));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 17922, 18266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 18282, 18297);

                string
                unused1
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 18311, 18326);

                string
                unused2
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 18340, 18410);

                var
                pipeline = f_1038_18355_18409(ast, false, out unused1, out unused2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 18424, 19656) || true) && (pipeline != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 18424, 19656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 18478, 18542);

                    var
                    hashtableAst = f_1038_18497_18525(pipeline) as HashtableAst
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 18560, 19641) || true) && (hashtableAst != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 18560, 19641);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 18626, 18687);

                        var
                        result = f_1038_18639_18686(f_1038_18653_18685())
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 18709, 19584);
                            foreach (var pair in f_1038_18730_18756_I(f_1038_18730_18756(hashtableAst)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 18709, 19584);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 18806, 18858);

                                var
                                key = f_1038_18816_18826(pair) as StringConstantExpressionAst
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 18884, 19561) || true) && (key != null && (DynAbs.Tracing.TraceSender.Expression_True(1038, 18888, 18961) && f_1038_18903_18961(keys, f_1038_18917_18926(key), f_1038_18928_18960())))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 18884, 19561);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 19087, 19123);

                                        var
                                        val = f_1038_19097_19122(f_1038_19097_19107(pair))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 19157, 19181);

                                        result[f_1038_19164_19173(key)] = val;
                                    }
                                    catch
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1038, 19242, 19534);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 19312, 19503);

                                        throw f_1038_19318_19502(f_1038_19404_19443(), psDataFilePath);
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1038, 19242, 19534);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 18884, 19561);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 18709, 19584);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1038, 1, 876);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1038, 1, 876);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 19608, 19622);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 18560, 19641);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 18424, 19656);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 19672, 19823);

                throw f_1038_19678_19822(f_1038_19744_19783(), psDataFilePath);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 17557, 19834);

                string
                f_1038_17699_17740(string
                path)
                {
                    var return_v = ScriptAnalysis.ReadScript(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 17699, 17740);
                    return return_v;
                }


                System.Management.Automation.Language.Parser
                f_1038_17805_17817()
                {
                    var return_v = new System.Management.Automation.Language.Parser();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 17805, 17817);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1038_17804_17907(System.Management.Automation.Language.Parser
                this_param, string
                fileName, string
                input, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                tokenList, out System.Management.Automation.Language.ParseError[]
                errors, System.Management.Automation.Language.ParseMode
                parseMode)
                {
                    var return_v = this_param.Parse(fileName, input, tokenList, out errors, parseMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 17804, 17907);
                    return return_v;
                }


                int
                f_1038_17926_17944(System.Management.Automation.Language.ParseError[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 17926, 17944);
                    return return_v;
                }


                System.Management.Automation.ParseException
                f_1038_17991_18022(System.Management.Automation.Language.ParseError[]
                errors)
                {
                    var return_v = new System.Management.Automation.ParseException(errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 17991, 18022);
                    return return_v;
                }


                string
                f_1038_18137_18179()
                {
                    var return_v = ParserStrings.CannotLoadPowerShellDataFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 18137, 18179);
                    return return_v;
                }


                string
                f_1038_18239_18249(System.Management.Automation.ParseException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 18239, 18249);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1038_18047_18250(System.Management.Automation.ParseException
                innerException, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException((System.Exception)innerException, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 18047, 18250);
                    return return_v;
                }


                System.Management.Automation.Language.PipelineAst
                f_1038_18355_18409(System.Management.Automation.Language.ScriptBlockAst
                this_param, bool
                allowMultiplePipelines, out string
                errorId, out string
                errorMsg)
                {
                    var return_v = this_param.GetSimplePipeline(allowMultiplePipelines, out errorId, out errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 18355, 18409);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1038_18497_18525(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.GetPureExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 18497, 18525);
                    return return_v;
                }


                System.StringComparer
                f_1038_18653_18685()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 18653, 18685);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1038_18639_18686(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 18639, 18686);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                f_1038_18730_18756(System.Management.Automation.Language.HashtableAst
                this_param)
                {
                    var return_v = this_param.KeyValuePairs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 18730, 18756);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1038_18816_18826(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 18816, 18826);
                    return return_v;
                }


                string
                f_1038_18917_18926(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 18917, 18926);
                    return return_v;
                }


                System.StringComparer
                f_1038_18928_18960()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 18928, 18960);
                    return return_v;
                }


                bool
                f_1038_18903_18961(string[]
                source, string
                value, System.StringComparer
                comparer)
                {
                    var return_v = source.Contains<string>(value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 18903, 18961);
                    return return_v;
                }


                System.Management.Automation.Language.StatementAst
                f_1038_19097_19107(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 19097, 19107);
                    return return_v;
                }


                object
                f_1038_19097_19122(System.Management.Automation.Language.StatementAst
                this_param)
                {
                    var return_v = this_param.SafeGetValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 19097, 19122);
                    return return_v;
                }


                string
                f_1038_19164_19173(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 19164, 19173);
                    return return_v;
                }


                string
                f_1038_19404_19443()
                {
                    var return_v = ParserStrings.InvalidPowerShellDataFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 19404, 19443);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1038_19318_19502(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 19318, 19502);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                f_1038_18730_18756_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 18730, 18756);
                    return return_v;
                }


                string
                f_1038_19744_19783()
                {
                    var return_v = ParserStrings.InvalidPowerShellDataFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 19744, 19783);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1038_19678_19822(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 19678, 19822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 17557, 19834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 17557, 19834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PsUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1038, 587, 19841);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 3221, 3245);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 3284, 3335);
            s_currentProcessId = f_1038_3305_3335(f_1038_3305_3332());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 16926, 16987);
            ManifestModuleVersionPropertyName = new[] { "ModuleVersion" };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 17032, 17075);
            ManifestGuidPropertyName = new[] { "GUID" };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 17120, 17177);
            ManifestPrivateDataPropertyName = new[] { "PrivateData" };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 17222, 17544);
            FastModuleManifestAnalysisPropertyNames = new[]
                    {
            "AliasesToExport",
            "CmdletsToExport",
            "CompatiblePSEditions",
            "FunctionsToExport",
            "NestedModules",
            "RootModule",
            "ModuleToProcess",
            "ModuleVersion"
        };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1038, 587, 19841);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 587, 19841);
        }


        static System.Diagnostics.Process
        f_1038_3305_3332()
        {
            var return_v = Process.GetCurrentProcess();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 3305, 3332);
            return return_v;
        }


        static int
        f_1038_3305_3335(System.Diagnostics.Process
        this_param)
        {
            var return_v = this_param.Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 3305, 3335);
            return return_v;
        }

    }
    internal static class StringToBase64Converter
    {
        internal static string StringToBase64String(string input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 20270, 20867);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 20511, 20631) || true) && (input == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 20511, 20631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 20562, 20616);

                    throw f_1038_20568_20615("input");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 20511, 20631);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 20647, 20828);

                string
                base64 = f_1038_20663_20827(f_1038_20750_20796(f_1038_20750_20766(), f_1038_20776_20795(input)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 20842, 20856);

                return base64;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 20270, 20867);

                System.Management.Automation.PSArgumentNullException
                f_1038_20568_20615(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 20568, 20615);
                    return return_v;
                }


                System.Text.Encoding
                f_1038_20750_20766()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 20750, 20766);
                    return return_v;
                }


                char[]
                f_1038_20776_20795(string
                this_param)
                {
                    var return_v = this_param.ToCharArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 20776, 20795);
                    return return_v;
                }


                byte[]
                f_1038_20750_20796(System.Text.Encoding
                this_param, char[]
                chars)
                {
                    var return_v = this_param.GetBytes(chars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 20750, 20796);
                    return return_v;
                }


                string
                f_1038_20663_20827(byte[]
                inArray)
                {
                    var return_v = Convert.ToBase64String(inArray);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 20663, 20827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 20270, 20867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 20270, 20867);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string Base64ToString(string base64)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 21085, 21441);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 21162, 21298) || true) && (f_1038_21166_21194(base64))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 21162, 21298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 21228, 21283);

                    throw f_1038_21234_21282("base64");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 21162, 21298);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 21314, 21402);

                string
                output = f_1038_21330_21401(f_1038_21341_21400(f_1038_21341_21357(), f_1038_21367_21399(base64)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 21416, 21430);

                return output;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 21085, 21441);

                bool
                f_1038_21166_21194(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 21166, 21194);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1038_21234_21282(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 21234, 21282);
                    return return_v;
                }


                System.Text.Encoding
                f_1038_21341_21357()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 21341, 21357);
                    return return_v;
                }


                byte[]
                f_1038_21367_21399(string
                s)
                {
                    var return_v = Convert.FromBase64String(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 21367, 21399);
                    return return_v;
                }


                char[]
                f_1038_21341_21400(System.Text.Encoding
                this_param, byte[]
                bytes)
                {
                    var return_v = this_param.GetChars(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 21341, 21400);
                    return return_v;
                }


                string
                f_1038_21330_21401(char[]
                value)
                {
                    var return_v = new string(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 21330, 21401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 21085, 21441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 21085, 21441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object[] Base64ToArgsConverter(string base64)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 21637, 23405);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 21723, 21859) || true) && (f_1038_21727_21755(base64))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 21723, 21859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 21789, 21844);

                    throw f_1038_21795_21843("base64");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 21723, 21859);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 21875, 21964);

                string
                decoded = f_1038_21892_21963(f_1038_21903_21962(f_1038_21903_21919(), f_1038_21929_21961(base64)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 22015, 22127);

                XmlReader
                reader = f_1038_22034_22126(f_1038_22051_22076(decoded), f_1038_22078_22125())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 22141, 22152);

                object
                dso
                = default(object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 22166, 22219);

                Deserializer
                deserializer = f_1038_22194_22218(reader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 22233, 22266);

                dso = f_1038_22239_22265(deserializer);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 22280, 22588) || true) && (f_1038_22284_22303(deserializer) == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 22280, 22588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 22482, 22573);

                    throw f_1038_22488_22572(MinishellParameterBinderController.ArgsParameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 22280, 22588);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 22604, 22634);

                PSObject
                mo = dso as PSObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 22648, 22961) || true) && (mo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 22648, 22961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 22855, 22946);

                    throw f_1038_22861_22945(MinishellParameterBinderController.ArgsParameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 22648, 22961);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 22977, 23019);

                var
                argsList = f_1038_22992_23005(mo) as ArrayList
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 23033, 23352) || true) && (argsList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 23033, 23352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 23246, 23337);

                    throw f_1038_23252_23336(MinishellParameterBinderController.ArgsParameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 23033, 23352);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 23368, 23394);

                return f_1038_23375_23393(argsList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 21637, 23405);

                bool
                f_1038_21727_21755(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 21727, 21755);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1038_21795_21843(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 21795, 21843);
                    return return_v;
                }


                System.Text.Encoding
                f_1038_21903_21919()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 21903, 21919);
                    return return_v;
                }


                byte[]
                f_1038_21929_21961(string
                s)
                {
                    var return_v = Convert.FromBase64String(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 21929, 21961);
                    return return_v;
                }


                char[]
                f_1038_21903_21962(System.Text.Encoding
                this_param, byte[]
                bytes)
                {
                    var return_v = this_param.GetChars(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 21903, 21962);
                    return return_v;
                }


                string
                f_1038_21892_21963(char[]
                value)
                {
                    var return_v = new string(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 21892, 21963);
                    return return_v;
                }


                System.IO.StringReader
                f_1038_22051_22076(string
                s)
                {
                    var return_v = new System.IO.StringReader(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 22051, 22076);
                    return return_v;
                }


                System.Xml.XmlReaderSettings
                f_1038_22078_22125()
                {
                    var return_v = InternalDeserializer.XmlReaderSettingsForCliXml;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 22078, 22125);
                    return return_v;
                }


                System.Xml.XmlReader
                f_1038_22034_22126(System.IO.StringReader
                input, System.Xml.XmlReaderSettings
                settings)
                {
                    var return_v = XmlReader.Create((System.IO.TextReader)input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 22034, 22126);
                    return return_v;
                }


                System.Management.Automation.Deserializer
                f_1038_22194_22218(System.Xml.XmlReader
                reader)
                {
                    var return_v = new System.Management.Automation.Deserializer(reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 22194, 22218);
                    return return_v;
                }


                object
                f_1038_22239_22265(System.Management.Automation.Deserializer
                this_param)
                {
                    var return_v = this_param.Deserialize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 22239, 22265);
                    return return_v;
                }


                bool
                f_1038_22284_22303(System.Management.Automation.Deserializer
                this_param)
                {
                    var return_v = this_param.Done();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 22284, 22303);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1038_22488_22572(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 22488, 22572);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1038_22861_22945(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 22861, 22945);
                    return return_v;
                }


                object
                f_1038_22992_23005(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 22992, 23005);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1038_23252_23336(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 23252, 23336);
                    return return_v;
                }


                object?[]
                f_1038_23375_23393(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 23375, 23393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 21637, 23405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 21637, 23405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StringToBase64Converter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1038, 19992, 23412);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1038, 19992, 23412);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 19992, 23412);
        }

    }
    internal class CRC32Hash
    {
        private const uint
        polynomial = 0x1EDC6F41
        ;

        private static uint[] table;

        static CRC32Hash()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1038, 23773, 24368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 23699, 23722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 23755, 23760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 23816, 23830);

                uint
                temp = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 23844, 23866);

                table = new uint[256];
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 23891, 23896);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 23882, 24357) || true) && (i < f_1038_23902_23914(table))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 23916, 23919)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 23882, 24357))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 23882, 24357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 23953, 23968);

                        temp = (uint)i;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 23995, 24000);
                            for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 23986, 24306) || true) && (j < 8)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24009, 24012)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 23986, 24306))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 23986, 24306);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24054, 24287) || true) && ((temp & 1) == 1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 24054, 24287);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24123, 24155);

                                    temp = (temp >> 1) ^ polynomial;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 24054, 24287);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 24054, 24287);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24253, 24264);

                                    temp >>= 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 24054, 24287);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1038, 1, 321);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1038, 1, 321);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24326, 24342);

                        table[i] = temp;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1038, 1, 476);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1038, 1, 476);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1038, 23773, 24368);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 23773, 24368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 23773, 24368);
            }
        }

        private static uint Compute(byte[] buffer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 24380, 24702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24447, 24469);

                uint
                crc = 0xFFFFFFFF
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24492, 24497);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24483, 24663) || true) && (i < f_1038_24503_24516(buffer))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24518, 24521)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1038, 24483, 24663))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1038, 24483, 24663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24555, 24598);

                        var
                        index = (byte)(crc ^ buffer[i] & 0xff)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24616, 24648);

                        crc = (crc >> 8) ^ table[index];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1038, 1, 181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1038, 1, 181);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24679, 24691);

                return ~crc;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 24380, 24702);

                int
                f_1038_24503_24516(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 24503, 24516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 24380, 24702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 24380, 24702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static byte[] ComputeHash(byte[] buffer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 24714, 24886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24788, 24821);

                uint
                crcResult = f_1038_24805_24820(buffer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24835, 24875);

                return f_1038_24842_24874(crcResult);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 24714, 24886);

                uint
                f_1038_24805_24820(byte[]
                buffer)
                {
                    var return_v = Compute(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 24805, 24820);
                    return return_v;
                }


                byte[]
                f_1038_24842_24874(uint
                value)
                {
                    var return_v = BitConverter.GetBytes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 24842, 24874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 24714, 24886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 24714, 24886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ComputeHash(string input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1038, 24898, 25125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 24971, 25033);

                byte[]
                hashBytes = f_1038_24990_25032(f_1038_25002_25031(f_1038_25002_25015(), input))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 25047, 25114);

                return f_1038_25054_25113(f_1038_25054_25086(hashBytes), "-", string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1038, 24898, 25125);

                System.Text.Encoding
                f_1038_25002_25015()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 25002, 25015);
                    return return_v;
                }


                byte[]
                f_1038_25002_25031(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 25002, 25031);
                    return return_v;
                }


                byte[]
                f_1038_24990_25032(byte[]
                buffer)
                {
                    var return_v = ComputeHash(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 24990, 25032);
                    return return_v;
                }


                string
                f_1038_25054_25086(byte[]
                value)
                {
                    var return_v = BitConverter.ToString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 25054, 25086);
                    return return_v;
                }


                string
                f_1038_25054_25113(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 25054, 25113);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 24898, 25125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 24898, 25125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CRC32Hash()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1038, 23592, 25132);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1038, 23592, 25132);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 23592, 25132);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1038, 23592, 25132);

        static int
        f_1038_23902_23914(uint[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1038, 23902, 23914);
            return return_v;
        }

    }
    internal class ReferenceEqualityComparer : IEqualityComparer
    {
        bool IEqualityComparer.Equals(object x, object y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1038, 25350, 25471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 25424, 25460);

                return f_1038_25431_25459(x, y);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1038, 25350, 25471);

                bool
                f_1038_25431_25459(object
                objA, object
                objB)
                {
                    var return_v = Object.ReferenceEquals(objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 25431, 25459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 25350, 25471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 25350, 25471);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int IEqualityComparer.GetHashCode(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1038, 25483, 26262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1038, 26212, 26251);

                return f_1038_26219_26250(obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1038, 25483, 26262);

                int
                f_1038_26219_26250(object
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1038, 26219, 26250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1038, 25483, 26262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 25483, 26262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ReferenceEqualityComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1038, 25273, 26269);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1038, 25273, 26269);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 25273, 26269);
        }


        static ReferenceEqualityComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1038, 25273, 26269);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1038, 25273, 26269);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1038, 25273, 26269);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1038, 25273, 26269);
    }

}

