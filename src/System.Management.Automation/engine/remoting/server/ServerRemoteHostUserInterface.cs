// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation.Host;
using System.Security;

using Dbg = System.Management.Automation.Diagnostics;
using InternalHostUserInterface = System.Management.Automation.Internal.Host.InternalHostUserInterface;

namespace System.Management.Automation.Remoting
{
    internal class ServerRemoteHostUserInterface : PSHostUserInterface, IHostUISupportsMultipleChoiceSelection
    {
        private ServerMethodExecutor _serverMethodExecutor;

        internal ServerRemoteHostUserInterface(ServerRemoteHost remoteHost)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1651, 955, 1561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 814, 835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 1641, 1694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 1786, 1837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 1047, 1109);

                f_1651_1047_1108(remoteHost != null, "Expected remoteHost != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 1123, 1153);

                ServerRemoteHost = remoteHost;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 1167, 1259);

                f_1651_1167_1258(f_1651_1178_1211_M(!f_1651_1179_1198(remoteHost).IsHostUINull), "Expected !remoteHost.HostInfo.IsHostUINull");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 1275, 1331);

                _serverMethodExecutor = f_1651_1299_1330(remoteHost);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 1454, 1550);

                RawUI = (DynAbs.Tracing.TraceSender.Conditional_F1(1651, 1462, 1497) || ((f_1651_1462_1497(f_1651_1462_1481(remoteHost)) && DynAbs.Tracing.TraceSender.Conditional_F2(1651, 1500, 1504)) || DynAbs.Tracing.TraceSender.Conditional_F3(1651, 1507, 1549))) ? null : f_1651_1507_1549(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1651, 955, 1561);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 955, 1561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 955, 1561);
            }
        }

        public override PSHostRawUserInterface RawUI { get; }

        internal ServerRemoteHost ServerRemoteHost { get; }

        public override string ReadLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 1920, 2069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 1978, 2058);

                return f_1651_1985_2057(_serverMethodExecutor, RemoteHostMethodId.ReadLine);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 1920, 2069);

                string
                f_1651_1985_2057(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    var return_v = this_param.ExecuteMethod<string>(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 1985, 2057);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 1920, 2069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 1920, 2069);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int defaultChoice)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 2160, 2464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 2310, 2453);

                return f_1651_2317_2452(_serverMethodExecutor, RemoteHostMethodId.PromptForChoice, new object[] { caption, message, choices, defaultChoice });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 2160, 2464);

                int
                f_1651_2317_2452(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    var return_v = this_param.ExecuteMethod<int>(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 2317, 2452);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 2160, 2464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 2160, 2464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<int> PromptForChoice(string caption,
                    string message,
                    Collection<ChoiceDescription> choices,
                    IEnumerable<int> defaultChoices)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 2805, 3212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 3011, 3201);

                return f_1651_3018_3200(_serverMethodExecutor, RemoteHostMethodId.PromptForChoiceMultipleSelection, new object[] { caption, message, choices, defaultChoices });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 2805, 3212);

                System.Collections.ObjectModel.Collection<int>
                f_1651_3018_3200(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    var return_v = this_param.ExecuteMethod<System.Collections.ObjectModel.Collection<int>>(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 3018, 3200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 2805, 3212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 2805, 3212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Dictionary<string, PSObject> Prompt(string caption, string message, Collection<FieldDescription> descriptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 3292, 4951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 3495, 3694);

                Dictionary<string, PSObject>
                results = f_1651_3534_3693(_serverMethodExecutor, RemoteHostMethodId.Prompt, new object[] { caption, message, descriptions })
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 3840, 4909);
                    foreach (FieldDescription description in f_1651_3881_3893_I(descriptions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1651, 3840, 4909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 3927, 4000);

                        Type
                        requestedType = f_1651_3948_3999(description)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 4018, 4894) || true) && (requestedType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1651, 4018, 4894);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 4085, 4110);

                            PSObject
                            valueFromClient
                            = default(PSObject);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 4132, 4875) || true) && (f_1651_4136_4194(results, f_1651_4156_4172(description), out valueFromClient))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1651, 4132, 4875);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 4244, 4268);

                                object
                                conversionResult
                                = default(object);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 4294, 4852) || true) && (f_1651_4298_4413(valueFromClient, requestedType, f_1651_4362_4390(), out conversionResult))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1651, 4294, 4852);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 4471, 4825) || true) && (conversionResult != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1651, 4471, 4825);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 4565, 4631);

                                        results[f_1651_4573_4589(description)] = f_1651_4593_4630(conversionResult);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1651, 4471, 4825);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1651, 4471, 4825);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 4761, 4794);

                                        results[f_1651_4769_4785(description)] = null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1651, 4471, 4825);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1651, 4294, 4852);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1651, 4132, 4875);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1651, 4018, 4894);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1651, 3840, 4909);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1651, 1, 1070);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1651, 1, 1070);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 4925, 4940);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 3292, 4951);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSObject>
                f_1651_3534_3693(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    var return_v = this_param.ExecuteMethod<System.Collections.Generic.Dictionary<string, System.Management.Automation.PSObject>>(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 3534, 3693);
                    return return_v;
                }


                System.Type
                f_1651_3948_3999(System.Management.Automation.Host.FieldDescription
                field)
                {
                    var return_v = InternalHostUserInterface.GetFieldType(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 3948, 3999);
                    return return_v;
                }


                string
                f_1651_4156_4172(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1651, 4156, 4172);
                    return return_v;
                }


                bool
                f_1651_4136_4194(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSObject>
                this_param, string
                key, out System.Management.Automation.PSObject
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 4136, 4194);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1651_4362_4390()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1651, 4362, 4390);
                    return return_v;
                }


                bool
                f_1651_4298_4413(System.Management.Automation.PSObject
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider, out object
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 4298, 4413);
                    return return_v;
                }


                string
                f_1651_4573_4589(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1651, 4573, 4589);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1651_4593_4630(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 4593, 4630);
                    return return_v;
                }


                string
                f_1651_4769_4785(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1651, 4769, 4785);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
                f_1651_3881_3893_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 3881, 3893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 3292, 4951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 3292, 4951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Write(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 5030, 5201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 5097, 5190);

                f_1651_5097_5189(_serverMethodExecutor, RemoteHostMethodId.Write1, new object[] { message });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 5030, 5201);

                int
                f_1651_5097_5189(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 5097, 5189);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 5030, 5201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 5030, 5201);
            }
        }

        public override void Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 5280, 5545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 5407, 5534);

                f_1651_5407_5533(_serverMethodExecutor, RemoteHostMethodId.Write2, new object[] { foregroundColor, backgroundColor, message });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 5280, 5545);

                int
                f_1651_5407_5533(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 5407, 5533);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 5280, 5545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 5280, 5545);
            }
        }

        public override void WriteLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 5629, 5768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 5686, 5757);

                f_1651_5686_5756(_serverMethodExecutor, RemoteHostMethodId.WriteLine1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 5629, 5768);

                int
                f_1651_5686_5756(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    this_param.ExecuteVoidMethod(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 5686, 5756);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 5629, 5768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 5629, 5768);
            }
        }

        public override void WriteLine(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 5852, 6031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 5923, 6020);

                f_1651_5923_6019(_serverMethodExecutor, RemoteHostMethodId.WriteLine2, new object[] { message });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 5852, 6031);

                int
                f_1651_5923_6019(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 5923, 6019);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 5852, 6031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 5852, 6031);
            }
        }

        public override void WriteLine(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 6115, 6388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 6246, 6377);

                f_1651_6246_6376(_serverMethodExecutor, RemoteHostMethodId.WriteLine3, new object[] { foregroundColor, backgroundColor, message });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 6115, 6388);

                int
                f_1651_6246_6376(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 6246, 6376);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 6115, 6388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 6115, 6388);
            }
        }

        public override void WriteErrorLine(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 6478, 6666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 6554, 6655);

                f_1651_6554_6654(_serverMethodExecutor, RemoteHostMethodId.WriteErrorLine, new object[] { message });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 6478, 6666);

                int
                f_1651_6554_6654(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 6554, 6654);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 6478, 6666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 6478, 6666);
            }
        }

        public override void WriteDebugLine(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 6756, 6944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 6832, 6933);

                f_1651_6832_6932(_serverMethodExecutor, RemoteHostMethodId.WriteDebugLine, new object[] { message });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 6756, 6944);

                int
                f_1651_6832_6932(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 6832, 6932);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 6756, 6944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 6756, 6944);
            }
        }

        public override void WriteProgress(long sourceId, ProgressRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 7032, 7249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 7129, 7238);

                f_1651_7129_7237(_serverMethodExecutor, RemoteHostMethodId.WriteProgress, new object[] { sourceId, record });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 7032, 7249);

                int
                f_1651_7129_7237(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 7129, 7237);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 7032, 7249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 7032, 7249);
            }
        }

        public override void WriteVerboseLine(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 7341, 7533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 7419, 7522);

                f_1651_7419_7521(_serverMethodExecutor, RemoteHostMethodId.WriteVerboseLine, new object[] { message });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 7341, 7533);

                int
                f_1651_7419_7521(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 7419, 7521);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 7341, 7533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 7341, 7533);
            }
        }

        public override void WriteWarningLine(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 7625, 7817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 7703, 7806);

                f_1651_7703_7805(_serverMethodExecutor, RemoteHostMethodId.WriteWarningLine, new object[] { message });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 7625, 7817);

                int
                f_1651_7703_7805(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 7703, 7805);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 7625, 7817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 7625, 7817);
            }
        }

        public override SecureString ReadLineAsSecureString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 7917, 8106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 7995, 8095);

                return f_1651_8002_8094(_serverMethodExecutor, RemoteHostMethodId.ReadLineAsSecureString);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 7917, 8106);

                System.Security.SecureString
                f_1651_8002_8094(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    var return_v = this_param.ExecuteMethod<System.Security.SecureString>(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 8002, 8094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 7917, 8106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 7917, 8106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 8201, 8529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 8342, 8518);

                return f_1651_8349_8517(_serverMethodExecutor, RemoteHostMethodId.PromptForCredential1, new object[] { caption, message, userName, targetName });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 8201, 8529);

                System.Management.Automation.PSCredential
                f_1651_8349_8517(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    var return_v = this_param.ExecuteMethod<System.Management.Automation.PSCredential>(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 8349, 8517);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 8201, 8529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 8201, 8529);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName, PSCredentialTypes allowedCredentialTypes, PSCredentialUIOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1651, 8624, 9058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1651, 8838, 9047);

                return f_1651_8845_9046(_serverMethodExecutor, RemoteHostMethodId.PromptForCredential2, new object[] { caption, message, userName, targetName, allowedCredentialTypes, options });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1651, 8624, 9058);

                System.Management.Automation.PSCredential
                f_1651_8845_9046(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    var return_v = this_param.ExecuteMethod<System.Management.Automation.PSCredential>(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 8845, 9046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1651, 8624, 9058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 8624, 9058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ServerRemoteHostUserInterface()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1651, 578, 9065);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1651, 578, 9065);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1651, 578, 9065);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1651, 578, 9065);

        int
        f_1651_1047_1108(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 1047, 1108);
            return 0;
        }


        System.Management.Automation.Remoting.HostInfo
        f_1651_1179_1198(System.Management.Automation.Remoting.ServerRemoteHost
        this_param)
        {
            var return_v = this_param.HostInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1651, 1179, 1198);
            return return_v;
        }


        bool
        f_1651_1178_1211_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1651, 1178, 1211);
            return return_v;
        }


        int
        f_1651_1167_1258(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 1167, 1258);
            return 0;
        }


        System.Management.Automation.Remoting.ServerMethodExecutor
        f_1651_1299_1330(System.Management.Automation.Remoting.ServerRemoteHost
        this_param)
        {
            var return_v = this_param.ServerMethodExecutor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1651, 1299, 1330);
            return return_v;
        }


        System.Management.Automation.Remoting.HostInfo
        f_1651_1462_1481(System.Management.Automation.Remoting.ServerRemoteHost
        this_param)
        {
            var return_v = this_param.HostInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1651, 1462, 1481);
            return return_v;
        }


        bool
        f_1651_1462_1497(System.Management.Automation.Remoting.HostInfo
        this_param)
        {
            var return_v = this_param.IsHostRawUINull;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1651, 1462, 1497);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
        f_1651_1507_1549(System.Management.Automation.Remoting.ServerRemoteHostUserInterface
        remoteHostUserInterface)
        {
            var return_v = new System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface(remoteHostUserInterface);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1651, 1507, 1549);
            return return_v;
        }

    }
}
