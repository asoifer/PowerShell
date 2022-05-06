// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Management.Automation.Configuration;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Management.Automation.Host
{
    public abstract class PSHostUserInterface
    {
        public abstract System.Management.Automation.Host.PSHostRawUserInterface RawUI
        {
            get;
        }

        public virtual bool SupportsVirtualTerminal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 1907, 1928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 1913, 1926);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 1907, 1928);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 1861, 1930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 1861, 1930);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract string ReadLine();

        public abstract SecureString ReadLineAsSecureString();

        public abstract void Write(string value);

        public abstract void Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value);

        public virtual void WriteLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 7215, 7306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 7271, 7295);

                f_1472_7271_7294(this, string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 7215, 7306);

                int
                f_1472_7271_7294(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 7271, 7294);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 7215, 7306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 7215, 7306);
            }
        }

        public abstract void WriteLine(string value);

        public virtual void WriteLine(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 9127, 9639);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 9414, 9552) || true) && ((value != null) && (DynAbs.Tracing.TraceSender.Expression_True(1472, 9418, 9456) && (f_1472_9438_9450(value) != 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 9414, 9552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 9490, 9537);

                    f_1472_9490_9536(this, foregroundColor, backgroundColor, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 9414, 9552);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 9568, 9580);

                f_1472_9568_9579(this, "\n");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 9127, 9639);

                int
                f_1472_9438_9450(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 9438, 9450);
                    return return_v;
                }


                int
                f_1472_9490_9536(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.ConsoleColor
                foregroundColor, System.ConsoleColor
                backgroundColor, string
                value)
                {
                    this_param.Write(foregroundColor, backgroundColor, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 9490, 9536);
                    return 0;
                }


                int
                f_1472_9568_9579(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 9568, 9579);
                    return 0;
                }


                // #pragma warning restore 56506
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 9127, 9639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 9127, 9639);
            }
        }

        public abstract void WriteErrorLine(string value);

        public abstract void WriteDebugLine(string message);

        public abstract void WriteProgress(Int64 sourceId, ProgressRecord record);

        public abstract void WriteVerboseLine(string message);

        public abstract void WriteWarningLine(string message);

        public virtual void WriteInformation(InformationRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 13968, 14034);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 13968, 14034);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 13968, 14034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 13968, 14034);
            }
        }

        private TranscriptionData TranscriptionData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 14690, 15786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 14911, 14983);

                    LocalRunspace
                    localRunspace = f_1472_14941_14965() as LocalRunspace
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 15001, 15315) || true) && (localRunspace != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 15001, 15315);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 15068, 15129);

                        _volatileTranscriptionData = f_1472_15097_15128(localRunspace);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 15151, 15296) || true) && (_volatileTranscriptionData != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 15151, 15296);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 15239, 15273);

                            return _volatileTranscriptionData;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 15151, 15296);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 15001, 15315);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 15495, 15628) || true) && (_volatileTranscriptionData != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 15495, 15628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 15575, 15609);

                        return _volatileTranscriptionData;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 15495, 15628);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 15648, 15719);

                    TranscriptionData
                    temporaryTranscriptionData = f_1472_15695_15718()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 15737, 15771);

                    return temporaryTranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 14690, 15786);

                    System.Management.Automation.Runspaces.Runspace
                    f_1472_14941_14965()
                    {
                        var return_v = Runspace.DefaultRunspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 14941, 14965);
                        return return_v;
                    }


                    System.Management.Automation.Host.TranscriptionData
                    f_1472_15097_15128(System.Management.Automation.Runspaces.LocalRunspace
                    this_param)
                    {
                        var return_v = this_param.TranscriptionData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 15097, 15128);
                        return return_v;
                    }


                    System.Management.Automation.Host.TranscriptionData
                    f_1472_15695_15718()
                    {
                        var return_v = new System.Management.Automation.Host.TranscriptionData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 15695, 15718);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 14622, 15797);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 14622, 15797);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private TranscriptionData _volatileTranscriptionData;

        internal void TranscribeCommand(string commandText, InvocationInfo invocation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 16157, 18430);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 16260, 16364) || true) && (f_1472_16264_16308(this, commandText, invocation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 16260, 16364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 16342, 16349);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 16260, 16364);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 16380, 18419) || true) && (f_1472_16384_16398())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 16380, 18419);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 16909, 18404);
                        foreach (TranscriptionOption transcript in f_1472_16952_17046_I(f_1472_16952_17046(f_1472_16952_16981(f_1472_16952_16969()), f_1472_17011_17045(f_1472_17011_17028()))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 16909, 18404);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 17088, 18385) || true) && (transcript != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 17088, 18385);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 17166, 17188);
                                lock (f_1472_17166_17188(transcript))
                                {

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 17246, 18335) || true) && (f_1472_17250_17278(f_1472_17250_17272(transcript)) == 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 17246, 18335);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 17349, 18019) || true) && (f_1472_17353_17387(transcript))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 17349, 18019);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 17461, 17514);

                                            f_1472_17461_17513(f_1472_17461_17483(transcript), "**********************");
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 17552, 17893);

                                            f_1472_17552_17892(f_1472_17552_17574(transcript), f_1472_17621_17891(f_1472_17681_17723(), f_1472_17725_17774(), DateTime.Now.ToString("yyyyMMddHHmmss", f_1472_17861_17889())));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 17931, 17984);

                                            f_1472_17931_17983(f_1472_17931_17953(transcript), "**********************");
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 17349, 18019);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 18055, 18126);

                                        f_1472_18055_18125(f_1472_18055_18077(transcript), f_1472_18082_18110(f_1472_18082_18099()) + commandText);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 17246, 18335);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 17246, 18335);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 18256, 18304);

                                        f_1472_18256_18303(f_1472_18256_18278(transcript), ">> " + commandText);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 17246, 18335);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 17088, 18385);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 16909, 18404);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1472, 1, 1496);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1472, 1, 1496);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 16380, 18419);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 16157, 18430);

                bool
                f_1472_16264_16308(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                logElement, System.Management.Automation.InvocationInfo
                invocation)
                {
                    var return_v = this_param.ShouldIgnoreCommand(logElement, invocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 16264, 16308);
                    return return_v;
                }


                bool
                f_1472_16384_16398()
                {
                    var return_v = IsTranscribing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 16384, 16398);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_16952_16969()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 16952, 16969);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                f_1472_16952_16981(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.Transcripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 16952, 16981);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_17011_17028()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 17011, 17028);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_17011_17045(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.SystemTranscript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 17011, 17045);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Host.TranscriptionOption>
                f_1472_16952_17046(System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                collection, System.Management.Automation.Host.TranscriptionOption
                element)
                {
                    var return_v = collection.Prepend<System.Management.Automation.Host.TranscriptionOption>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 16952, 17046);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_17166_17188(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 17166, 17188);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_17250_17272(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 17250, 17272);
                    return return_v;
                }


                int
                f_1472_17250_17278(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 17250, 17278);
                    return return_v;
                }


                bool
                f_1472_17353_17387(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.IncludeInvocationHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 17353, 17387);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_17461_17483(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 17461, 17483);
                    return return_v;
                }


                int
                f_1472_17461_17513(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 17461, 17513);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1472_17552_17574(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 17552, 17574);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1472_17681_17723()
                {
                    var return_v = Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 17681, 17723);
                    return return_v;
                }


                string
                f_1472_17725_17774()
                {
                    var return_v = InternalHostUserInterfaceStrings.CommandStartTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 17725, 17774);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1472_17861_17889()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 17861, 17889);
                    return return_v;
                }


                string
                f_1472_17621_17891(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 17621, 17891);
                    return return_v;
                }


                int
                f_1472_17552_17892(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 17552, 17892);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1472_17931_17953(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 17931, 17953);
                    return return_v;
                }


                int
                f_1472_17931_17983(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 17931, 17983);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1472_18055_18077(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 18055, 18077);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_18082_18099()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 18082, 18099);
                    return return_v;
                }


                string
                f_1472_18082_18110(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.PromptText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 18082, 18110);
                    return return_v;
                }


                int
                f_1472_18055_18125(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 18055, 18125);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1472_18256_18278(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 18256, 18278);
                    return return_v;
                }


                int
                f_1472_18256_18303(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 18256, 18303);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Host.TranscriptionOption>
                f_1472_16952_17046_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Host.TranscriptionOption>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 16952, 17046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 16157, 18430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 16157, 18430);
            }
        }

        private bool ShouldIgnoreCommand(string logElement, InvocationInfo invocation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 18442, 20330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 18545, 18577);

                string
                commandName = logElement
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 18593, 19584) || true) && (invocation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 18593, 19584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 18649, 18689);

                    commandName = f_1472_18663_18688(invocation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 18759, 18824);

                    CmdletInfo
                    invocationCmdlet = f_1472_18789_18809(invocation) as CmdletInfo
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 18842, 19295) || true) && (invocationCmdlet != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 18842, 19295);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 18912, 19276) || true) && (f_1472_18916_18949(invocationCmdlet) == typeof(Microsoft.PowerShell.Commands.OutDefaultCommand))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 18912, 19276);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 19241, 19253);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 18912, 19276);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 18842, 19295);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 19382, 19569) || true) && (f_1472_19386_19410(invocation) == CommandOrigin.Internal)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 19382, 19569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 19478, 19516);

                        f_1472_19478_19515(this, logElement, invocation);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 19538, 19550);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 19382, 19569);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 18593, 19584);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 19660, 19757);

                string[]
                helperCommands = { "TabExpansion2", "prompt", "TabExpansion", "PSConsoleHostReadline" }
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 19771, 20290);
                    foreach (string helperCommand in f_1472_19804_19818_I(helperCommands))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 19771, 20290);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 19852, 20275) || true) && (f_1472_19856_19933(helperCommand, commandName, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 19852, 20275);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 19975, 20013);

                            f_1472_19975_20012(this, logElement, invocation);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 20181, 20222);

                            f_1472_20181_20198().IsHelperCommand = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 20244, 20256);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 19852, 20275);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 19771, 20290);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1472, 1, 520);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1472, 1, 520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 20306, 20319);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 18442, 20330);

                string
                f_1472_18663_18688(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.InvocationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 18663, 18688);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1472_18789_18809(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 18789, 18809);
                    return return_v;
                }


                System.Type
                f_1472_18916_18949(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 18916, 18949);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1472_19386_19410(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 19386, 19410);
                    return return_v;
                }


                int
                f_1472_19478_19515(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                commandText, System.Management.Automation.InvocationInfo
                invocation)
                {
                    this_param.IgnoreCommand(commandText, invocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 19478, 19515);
                    return 0;
                }


                bool
                f_1472_19856_19933(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 19856, 19933);
                    return return_v;
                }


                int
                f_1472_19975_20012(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                commandText, System.Management.Automation.InvocationInfo
                invocation)
                {
                    this_param.IgnoreCommand(commandText, invocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 19975, 20012);
                    return 0;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_20181_20198()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 20181, 20198);
                    return return_v;
                }


                string[]
                f_1472_19804_19818_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 19804, 19818);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 18442, 20330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 18442, 20330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void IgnoreCommand(string commandText, InvocationInfo invocation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 20661, 21234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 20760, 20792);

                f_1472_20760_20791(this, null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 20808, 21223) || true) && (f_1472_20812_20849(f_1472_20812_20829()) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 20808, 21223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 20891, 20943);

                    f_1472_20891_20908().CommandBeingIgnored = commandText;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 20961, 21003);

                    f_1472_20961_20978().IsHelperCommand = false;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 21023, 21208) || true) && ((invocation != null) && (DynAbs.Tracing.TraceSender.Expression_True(1472, 21027, 21081) && (f_1472_21052_21072(invocation) != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 21023, 21208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 21123, 21189);

                        f_1472_21123_21140().CommandBeingIgnored = f_1472_21163_21188(f_1472_21163_21183(invocation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 21023, 21208);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 20808, 21223);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 20661, 21234);

                int
                f_1472_20760_20791(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.InvocationInfo
                invocation)
                {
                    this_param.TranscribeCommandComplete(invocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 20760, 20791);
                    return 0;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_20812_20829()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 20812, 20829);
                    return return_v;
                }


                string
                f_1472_20812_20849(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.CommandBeingIgnored;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 20812, 20849);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_20891_20908()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 20891, 20908);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_20961_20978()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 20961, 20978);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1472_21052_21072(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 21052, 21072);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_21123_21140()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 21123, 21140);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1472_21163_21183(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 21163, 21183);
                    return return_v;
                }


                string
                f_1472_21163_21188(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 21163, 21188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 20661, 21234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 20661, 21234);
            }
        }

        internal bool TranscribeOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 21514, 21581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 21517, 21581);
                    return f_1472_21517_21576(ref _transcribeOnlyCount, 0, 0) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 21514, 21581);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 21514, 21581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 21514, 21581);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int _transcribeOnlyCount;

        internal IDisposable SetTranscribeOnly()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 21680, 21713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 21683, 21713);
                return f_1472_21683_21713(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 21680, 21713);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 21680, 21713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 21680, 21713);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Host.PSHostUserInterface.TranscribeOnlyCookie
            f_1472_21683_21713(System.Management.Automation.Host.PSHostUserInterface
            ui)
            {
                var return_v = new System.Management.Automation.Host.PSHostUserInterface.TranscribeOnlyCookie(ui);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 21683, 21713);
                return return_v;
            }

        }
        private sealed class TranscribeOnlyCookie : IDisposable
        {
            private PSHostUserInterface _ui;

            private bool _disposed;

            public TranscribeOnlyCookie(PSHostUserInterface ui)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1472, 21895, 22073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 21832, 21835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 21863, 21880);
                    this._disposed = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 21979, 21988);

                    _ui = ui;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 22006, 22058);

                    f_1472_22006_22057(ref _ui._transcribeOnlyCount);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1472, 21895, 22073);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 21895, 22073);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 21895, 22073);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 22089, 22372);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 22143, 22357) || true) && (!_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 22143, 22357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 22199, 22251);

                        f_1472_22199_22250(ref _ui._transcribeOnlyCount);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 22273, 22290);

                        _disposed = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 22312, 22338);

                        f_1472_22312_22337(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 22143, 22357);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 22089, 22372);

                    int
                    f_1472_22199_22250(ref int
                    location)
                    {
                        var return_v = Interlocked.Decrement(ref location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 22199, 22250);
                        return return_v;
                    }


                    int
                    f_1472_22312_22337(System.Management.Automation.Host.PSHostUserInterface.TranscribeOnlyCookie
                    obj)
                    {
                        GC.SuppressFinalize((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 22312, 22337);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 22089, 22372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 22089, 22372);
                }
            }

            ~TranscribeOnlyCookie() => f_1472_22415_22424(this);

            static TranscribeOnlyCookie()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1472, 21724, 22436);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1472, 21724, 22436);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 21724, 22436);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1472, 21724, 22436);

            int
            f_1472_22006_22057(ref int
            location)
            {
                var return_v = Interlocked.Increment(ref location);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 22006, 22057);
                return return_v;
            }


            int
            f_1472_22415_22424(System.Management.Automation.Host.PSHostUserInterface.TranscribeOnlyCookie
            this_param)
            {
                this_param.Dispose();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 22415, 22424);
                return 0;
            }

        }

        internal bool IsTranscribing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 22613, 22803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 22649, 22673);

                    f_1472_22649_22672(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 22691, 22788);

                    return (f_1472_22699_22734(f_1472_22699_22728(f_1472_22699_22716())) > 0) || (DynAbs.Tracing.TraceSender.Expression_False(1472, 22698, 22787) || (f_1472_22744_22778(f_1472_22744_22761()) != null));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 22613, 22803);

                    int
                    f_1472_22649_22672(System.Management.Automation.Host.PSHostUserInterface
                    this_param)
                    {
                        this_param.CheckSystemTranscript();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 22649, 22672);
                        return 0;
                    }


                    System.Management.Automation.Host.TranscriptionData
                    f_1472_22699_22716()
                    {
                        var return_v = TranscriptionData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 22699, 22716);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                    f_1472_22699_22728(System.Management.Automation.Host.TranscriptionData
                    this_param)
                    {
                        var return_v = this_param.Transcripts;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 22699, 22728);
                        return return_v;
                    }


                    int
                    f_1472_22699_22734(System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 22699, 22734);
                        return return_v;
                    }


                    System.Management.Automation.Host.TranscriptionData
                    f_1472_22744_22761()
                    {
                        var return_v = TranscriptionData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 22744, 22761);
                        return return_v;
                    }


                    System.Management.Automation.Host.TranscriptionOption
                    f_1472_22744_22778(System.Management.Automation.Host.TranscriptionData
                    this_param)
                    {
                        var return_v = this_param.SystemTranscript;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 22744, 22778);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 22560, 22814);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 22560, 22814);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void CheckSystemTranscript()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 22826, 23399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 22893, 22910);
                lock (f_1472_22893_22910())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 22944, 23373) || true) && (f_1472_22948_22982(f_1472_22948_22965()) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 22944, 23373);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 23032, 23151);

                        f_1472_23032_23049().SystemTranscript = f_1472_23069_23150(f_1472_23115_23149(f_1472_23115_23132()));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 23173, 23354) || true) && (f_1472_23177_23211(f_1472_23177_23194()) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 23173, 23354);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 23269, 23331);

                            f_1472_23269_23330(this, null, f_1472_23295_23329(f_1472_23295_23312()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 23173, 23354);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 22944, 23373);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 22826, 23399);

                System.Management.Automation.Host.TranscriptionData
                f_1472_22893_22910()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 22893, 22910);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_22948_22965()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 22948, 22965);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_22948_22982(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.SystemTranscript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 22948, 22982);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_23032_23049()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 23032, 23049);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_23115_23132()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 23115, 23132);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_23115_23149(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.SystemTranscript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 23115, 23149);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_23069_23150(System.Management.Automation.Host.TranscriptionOption
                currentTranscript)
                {
                    var return_v = PSHostUserInterface.GetSystemTranscriptOption(currentTranscript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 23069, 23150);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_23177_23194()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 23177, 23194);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_23177_23211(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.SystemTranscript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 23177, 23211);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_23295_23312()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 23295, 23312);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_23295_23329(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.SystemTranscript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 23295, 23329);
                    return return_v;
                }


                int
                f_1472_23269_23330(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.Remoting.PSSenderInfo
                senderInfo, System.Management.Automation.Host.TranscriptionOption
                transcript)
                {
                    this_param.LogTranscriptHeader(senderInfo, transcript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 23269, 23330);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 22826, 23399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 22826, 23399);
            }
        }

        internal void StartTranscribing(string path, System.Management.Automation.Remoting.PSSenderInfo senderInfo, bool includeInvocationHeader, bool useMinimalHeader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 23411, 23916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 23596, 23655);

                TranscriptionOption
                transcript = f_1472_23629_23654()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 23669, 23692);

                transcript.Path = path;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 23706, 23767);

                transcript.IncludeInvocationHeader = includeInvocationHeader;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 23781, 23827);

                f_1472_23781_23826(f_1472_23781_23810(f_1472_23781_23798()), transcript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 23843, 23905);

                f_1472_23843_23904(this, senderInfo, transcript, useMinimalHeader);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 23411, 23916);

                System.Management.Automation.Host.TranscriptionOption
                f_1472_23629_23654()
                {
                    var return_v = new System.Management.Automation.Host.TranscriptionOption();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 23629, 23654);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_23781_23798()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 23781, 23798);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                f_1472_23781_23810(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.Transcripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 23781, 23810);
                    return return_v;
                }


                int
                f_1472_23781_23826(System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                this_param, System.Management.Automation.Host.TranscriptionOption
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 23781, 23826);
                    return 0;
                }


                int
                f_1472_23843_23904(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.Remoting.PSSenderInfo
                senderInfo, System.Management.Automation.Host.TranscriptionOption
                transcript, bool
                useMinimalHeader)
                {
                    this_param.LogTranscriptHeader(senderInfo, transcript, useMinimalHeader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 23843, 23904);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 23411, 23916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 23411, 23916);
            }
        }

        private void LogTranscriptHeader(System.Management.Automation.Remoting.PSSenderInfo senderInfo, TranscriptionOption transcript, bool useMinimalHeader = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 23928, 26687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 24160, 24172);

                string
                line
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 24186, 26502) || true) && (useMinimalHeader)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 24186, 26502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 24240, 24476);

                    line =
                    f_1472_24268_24475(f_1472_24308_24350(), f_1472_24377_24435(), DateTime.Now);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 24186, 26502);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 24186, 26502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 24542, 24617);

                    string
                    username = f_1472_24560_24586() + "\\" + f_1472_24596_24616()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 24635, 24663);

                    string
                    runAsUser = username
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 24683, 24811) || true) && (senderInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 24683, 24811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 24747, 24792);

                        username = f_1472_24758_24791(f_1472_24758_24786(f_1472_24758_24777(senderInfo)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 24683, 24811);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 24880, 24934);

                    StringBuilder
                    versionInfoFooter = f_1472_24914_24933()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 24952, 25010);

                    Hashtable
                    versionInfo = f_1472_24976_25009()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 25028, 25528);
                        foreach (string versionKey in f_1472_25058_25074_I(f_1472_25058_25074(versionInfo)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 25028, 25528);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 25116, 25155);

                            object
                            value = f_1472_25131_25154(versionInfo, versionKey)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 25179, 25509) || true) && (value != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 25179, 25509);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 25246, 25281);

                                var
                                arrayValue = value as object[]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 25307, 25398);

                                string
                                valueString = (DynAbs.Tracing.TraceSender.Conditional_F1(1472, 25328, 25346) || ((arrayValue != null && DynAbs.Tracing.TraceSender.Conditional_F2(1472, 25349, 25378)) || DynAbs.Tracing.TraceSender.Conditional_F3(1472, 25381, 25397))) ? f_1472_25349_25378(", ", arrayValue) : f_1472_25381_25397(value)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 25424, 25486);

                                f_1472_25424_25485(versionInfoFooter, versionKey + ": " + valueString);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 25179, 25509);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 25028, 25528);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1472, 1, 501);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1472, 1, 501);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 25548, 25588);

                    string
                    configurationName = string.Empty
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 25606, 25793) || true) && (senderInfo != null && (DynAbs.Tracing.TraceSender.Expression_True(1472, 25610, 25683) && !f_1472_25633_25683(f_1472_25654_25682(senderInfo))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 25606, 25793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 25725, 25774);

                        configurationName = f_1472_25745_25773(senderInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 25606, 25793);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 25813, 26487);

                    line =
                    f_1472_25841_26486(f_1472_25881_25923(), f_1472_25950_26001(), DateTime.Now, username, runAsUser, configurationName, f_1472_26182_26205(), f_1472_26232_26267(f_1472_26232_26253()), f_1472_26294_26344(" ", f_1472_26311_26343()), f_1472_26371_26420(f_1472_26371_26417()), f_1472_26447_26485(f_1472_26447_26475(versionInfoFooter)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 24186, 26502);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 26524, 26546);

                lock (f_1472_26524_26546(transcript))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 26580, 26613);

                    f_1472_26580_26612(f_1472_26580_26602(transcript), line);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 26644, 26676);

                f_1472_26644_26675(this, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 23928, 26687);

                System.Globalization.CultureInfo
                f_1472_24308_24350()
                {
                    var return_v = Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 24308, 24350);
                    return return_v;
                }


                string
                f_1472_24377_24435()
                {
                    var return_v = InternalHostUserInterfaceStrings.MinimalTranscriptPrologue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 24377, 24435);
                    return return_v;
                }


                string
                f_1472_24268_24475(System.Globalization.CultureInfo
                provider, string
                format, System.DateTime
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 24268, 24475);
                    return return_v;
                }


                string
                f_1472_24560_24586()
                {
                    var return_v = Environment.UserDomainName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 24560, 24586);
                    return return_v;
                }


                string
                f_1472_24596_24616()
                {
                    var return_v = Environment.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 24596, 24616);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSPrincipal
                f_1472_24758_24777(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.UserInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 24758, 24777);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSIdentity
                f_1472_24758_24786(System.Management.Automation.Remoting.PSPrincipal
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 24758, 24786);
                    return return_v;
                }


                string
                f_1472_24758_24791(System.Management.Automation.Remoting.PSIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 24758, 24791);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1472_24914_24933()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 24914, 24933);
                    return return_v;
                }


                System.Management.Automation.PSVersionHashTable
                f_1472_24976_25009()
                {
                    var return_v = PSVersionInfo.GetPSVersionTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 24976, 25009);
                    return return_v;
                }


                System.Collections.ICollection
                f_1472_25058_25074(System.Collections.Hashtable
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 25058, 25074);
                    return return_v;
                }


                object
                f_1472_25131_25154(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 25131, 25154);
                    return return_v;
                }


                string
                f_1472_25349_25378(string
                separator, params object[]
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 25349, 25378);
                    return return_v;
                }


                string?
                f_1472_25381_25397(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 25381, 25397);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1472_25424_25485(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 25424, 25485);
                    return return_v;
                }


                System.Collections.ICollection
                f_1472_25058_25074_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 25058, 25074);
                    return return_v;
                }


                string
                f_1472_25654_25682(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.ConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 25654, 25682);
                    return return_v;
                }


                bool
                f_1472_25633_25683(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 25633, 25683);
                    return return_v;
                }


                string
                f_1472_25745_25773(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.ConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 25745, 25773);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1472_25881_25923()
                {
                    var return_v = Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 25881, 25923);
                    return return_v;
                }


                string
                f_1472_25950_26001()
                {
                    var return_v = InternalHostUserInterfaceStrings.TranscriptPrologue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 25950, 26001);
                    return return_v;
                }


                string
                f_1472_26182_26205()
                {
                    var return_v = Environment.MachineName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 26182, 26205);
                    return return_v;
                }


                System.OperatingSystem
                f_1472_26232_26253()
                {
                    var return_v = Environment.OSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 26232, 26253);
                    return return_v;
                }


                string
                f_1472_26232_26267(System.OperatingSystem
                this_param)
                {
                    var return_v = this_param.VersionString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 26232, 26267);
                    return return_v;
                }


                string[]
                f_1472_26311_26343()
                {
                    var return_v = Environment.GetCommandLineArgs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 26311, 26343);
                    return return_v;
                }


                string
                f_1472_26294_26344(string
                separator, params string[]
                value)
                {
                    var return_v = string.Join(separator, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 26294, 26344);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1472_26371_26417()
                {
                    var return_v = System.Diagnostics.Process.GetCurrentProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 26371, 26417);
                    return return_v;
                }


                int
                f_1472_26371_26420(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 26371, 26420);
                    return return_v;
                }


                string
                f_1472_26447_26475(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 26447, 26475);
                    return return_v;
                }


                string
                f_1472_26447_26485(string
                this_param)
                {
                    var return_v = this_param.TrimEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 26447, 26485);
                    return return_v;
                }


                string
                f_1472_25841_26486(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 25841, 26486);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_26524_26546(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 26524, 26546);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_26580_26602(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 26580, 26602);
                    return return_v;
                }


                int
                f_1472_26580_26612(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 26580, 26612);
                    return 0;
                }


                int
                f_1472_26644_26675(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.InvocationInfo
                invocation)
                {
                    this_param.TranscribeCommandComplete(invocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 26644, 26675);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 23928, 26687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 23928, 26687);
            }
        }

        internal string StopTranscribing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 26699, 27292);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 26758, 26943) || true) && (f_1472_26762_26797(f_1472_26762_26791(f_1472_26762_26779())) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 26758, 26943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 26836, 26928);

                    throw f_1472_26842_26927(f_1472_26874_26926());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 26758, 26943);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 26959, 27070);

                TranscriptionOption
                stoppedTranscript = f_1472_26999_27069(f_1472_26999_27028(f_1472_26999_27016()), f_1472_27029_27064(f_1472_27029_27058(f_1472_27029_27046())) - 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 27084, 27123);

                f_1472_27084_27122(this, stoppedTranscript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 27137, 27165);

                f_1472_27137_27164(stoppedTranscript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 27179, 27235);

                f_1472_27179_27234(f_1472_27179_27208(f_1472_27179_27196()), stoppedTranscript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 27251, 27281);

                return f_1472_27258_27280(stoppedTranscript);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 26699, 27292);

                System.Management.Automation.Host.TranscriptionData
                f_1472_26762_26779()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 26762, 26779);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                f_1472_26762_26791(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.Transcripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 26762, 26791);
                    return return_v;
                }


                int
                f_1472_26762_26797(System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 26762, 26797);
                    return return_v;
                }


                string
                f_1472_26874_26926()
                {
                    var return_v = InternalHostUserInterfaceStrings.HostNotTranscribing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 26874, 26926);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1472_26842_26927(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 26842, 26927);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_26999_27016()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 26999, 27016);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                f_1472_26999_27028(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.Transcripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 26999, 27028);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_27029_27046()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 27029, 27046);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                f_1472_27029_27058(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.Transcripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 27029, 27058);
                    return return_v;
                }


                int
                f_1472_27029_27064(System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 27029, 27064);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_26999_27069(System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 26999, 27069);
                    return return_v;
                }


                int
                f_1472_27084_27122(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.Host.TranscriptionOption
                stoppedTranscript)
                {
                    this_param.LogTranscriptFooter(stoppedTranscript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 27084, 27122);
                    return 0;
                }


                int
                f_1472_27137_27164(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 27137, 27164);
                    return 0;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_27179_27196()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 27179, 27196);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                f_1472_27179_27208(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.Transcripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 27179, 27208);
                    return return_v;
                }


                bool
                f_1472_27179_27234(System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                this_param, System.Management.Automation.Host.TranscriptionOption
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 27179, 27234);
                    return return_v;
                }


                string
                f_1472_27258_27280(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 27258, 27280);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 26699, 27292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 26699, 27292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LogTranscriptFooter(TranscriptionOption stoppedTranscript)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 27304, 28141);
                // Transcribe the transcript epilogue
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 27487, 27672);

                    string
                    message = f_1472_27504_27671(f_1472_27540_27582(), f_1472_27605_27656(), DateTime.Now)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 27698, 27727);

                    lock (f_1472_27698_27727(stoppedTranscript))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 27769, 27812);

                        f_1472_27769_27811(f_1472_27769_27798(stoppedTranscript), message);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 27851, 27883);

                    f_1472_27851_27882(this, null);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1472, 27912, 28130);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1472, 27912, 28130);
                    // Ignoring errors when stopping transcription (i.e.: file in use, access denied)
                    // since this is probably handling exactly that error.
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 27304, 28141);

                System.Globalization.CultureInfo
                f_1472_27540_27582()
                {
                    var return_v = Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 27540, 27582);
                    return return_v;
                }


                string
                f_1472_27605_27656()
                {
                    var return_v = InternalHostUserInterfaceStrings.TranscriptEpilogue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 27605, 27656);
                    return return_v;
                }


                string
                f_1472_27504_27671(System.Globalization.CultureInfo
                provider, string
                format, System.DateTime
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 27504, 27671);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_27698_27727(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 27698, 27727);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_27769_27798(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 27769, 27798);
                    return return_v;
                }


                int
                f_1472_27769_27811(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 27769, 27811);
                    return 0;
                }


                int
                f_1472_27851_27882(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.InvocationInfo
                invocation)
                {
                    this_param.TranscribeCommandComplete(invocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 27851, 27882);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 27304, 28141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 27304, 28141);
            }
        }

        internal void StopAllTranscribing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 28153, 28917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 28213, 28245);

                f_1472_28213_28244(this, null);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 28261, 28375) || true) && (f_1472_28268_28303(f_1472_28268_28297(f_1472_28268_28285())) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 28261, 28375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 28341, 28360);

                        f_1472_28341_28359(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 28261, 28375);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1472, 28261, 28375);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1472, 28261, 28375);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 28397, 28414);

                lock (f_1472_28397_28414())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 28448, 28891) || true) && (f_1472_28452_28486(f_1472_28452_28469()) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 28448, 28891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 28536, 28592);

                        f_1472_28536_28591(this, f_1472_28556_28590(f_1472_28556_28573()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 28614, 28659);

                        f_1472_28614_28658(f_1472_28614_28648(f_1472_28614_28631()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 28681, 28723);

                        f_1472_28681_28698().SystemTranscript = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 28753, 28775);

                        lock (s_systemTranscriptLock)
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 28825, 28849);

                            systemTranscript = null;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 28448, 28891);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 28153, 28917);

                int
                f_1472_28213_28244(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.InvocationInfo
                invocation)
                {
                    this_param.TranscribeCommandComplete(invocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 28213, 28244);
                    return 0;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_28268_28285()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 28268, 28285);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                f_1472_28268_28297(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.Transcripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 28268, 28297);
                    return return_v;
                }


                int
                f_1472_28268_28303(System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 28268, 28303);
                    return return_v;
                }


                string
                f_1472_28341_28359(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.StopTranscribing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 28341, 28359);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_28397_28414()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 28397, 28414);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_28452_28469()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 28452, 28469);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_28452_28486(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.SystemTranscript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 28452, 28486);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_28556_28573()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 28556, 28573);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_28556_28590(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.SystemTranscript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 28556, 28590);
                    return return_v;
                }


                int
                f_1472_28536_28591(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.Host.TranscriptionOption
                stoppedTranscript)
                {
                    this_param.LogTranscriptFooter(stoppedTranscript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 28536, 28591);
                    return 0;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_28614_28631()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 28614, 28631);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_28614_28648(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.SystemTranscript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 28614, 28648);
                    return return_v;
                }


                int
                f_1472_28614_28658(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 28614, 28658);
                    return 0;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_28681_28698()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 28681, 28698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 28153, 28917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 28153, 28917);
            }
        }

        internal void TranscribeResult(Runspace sourceRunspace, string resultText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 29266, 31357);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 29365, 31346) || true) && (f_1472_29369_29383())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 29365, 31346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 29651, 29691);

                    Runspace
                    originalDefaultRunspace = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 29709, 29911) || true) && (sourceRunspace != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 29709, 29911);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 29777, 29828);

                        originalDefaultRunspace = f_1472_29803_29827();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 29850, 29892);

                        Runspace.DefaultRunspace = sourceRunspace;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 29709, 29911);
                    }

                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 30047, 30507) || true) && (f_1472_30051_30088(f_1472_30051_30068()) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 30047, 30507);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 30220, 30449) || true) && (f_1472_30224_30322("prompt", f_1472_30248_30285(f_1472_30248_30265()), StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 30220, 30449);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 30380, 30422);

                                f_1472_30380_30397().PromptText = resultText;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 30220, 30449);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 30477, 30484);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 30047, 30507);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 30531, 30565);

                        resultText = f_1472_30544_30564(resultText);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 30587, 31068);
                            foreach (TranscriptionOption transcript in f_1472_30630_30724_I(f_1472_30630_30724(f_1472_30630_30659(f_1472_30630_30647()), f_1472_30689_30723(f_1472_30689_30706()))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 30587, 31068);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 30774, 31045) || true) && (transcript != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 30774, 31045);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 30860, 30882);
                                    lock (f_1472_30860_30882(transcript))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 30948, 30987);

                                        f_1472_30948_30986(f_1472_30948_30970(transcript), resultText);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 30774, 31045);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 30587, 31068);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1472, 1, 482);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1472, 1, 482);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1472, 31105, 31331);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 31153, 31312) || true) && (originalDefaultRunspace != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 31153, 31312);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 31238, 31289);

                            Runspace.DefaultRunspace = originalDefaultRunspace;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 31153, 31312);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1472, 31105, 31331);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 29365, 31346);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 29266, 31357);

                bool
                f_1472_29369_29383()
                {
                    var return_v = IsTranscribing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 29369, 29383);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1472_29803_29827()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 29803, 29827);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_30051_30068()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 30051, 30068);
                    return return_v;
                }


                string
                f_1472_30051_30088(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.CommandBeingIgnored;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 30051, 30088);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_30248_30265()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 30248, 30265);
                    return return_v;
                }


                string
                f_1472_30248_30285(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.CommandBeingIgnored;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 30248, 30285);
                    return return_v;
                }


                bool
                f_1472_30224_30322(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 30224, 30322);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_30380_30397()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 30380, 30397);
                    return return_v;
                }


                string
                f_1472_30544_30564(string
                this_param)
                {
                    var return_v = this_param.TrimEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 30544, 30564);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_30630_30647()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 30630, 30647);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                f_1472_30630_30659(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.Transcripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 30630, 30659);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_30689_30706()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 30689, 30706);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_30689_30723(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.SystemTranscript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 30689, 30723);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Host.TranscriptionOption>
                f_1472_30630_30724(System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                collection, System.Management.Automation.Host.TranscriptionOption
                element)
                {
                    var return_v = collection.Prepend<System.Management.Automation.Host.TranscriptionOption>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 30630, 30724);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_30860_30882(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 30860, 30882);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_30948_30970(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 30948, 30970);
                    return return_v;
                }


                int
                f_1472_30948_30986(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 30948, 30986);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Host.TranscriptionOption>
                f_1472_30630_30724_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Host.TranscriptionOption>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 30630, 30724);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 29266, 31357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 29266, 31357);
            }
        }

        internal void TranscribeResult(string resultText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 31569, 31689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 31643, 31678);

                f_1472_31643_31677(this, null, resultText);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 31569, 31689);

                int
                f_1472_31643_31677(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.Runspaces.Runspace
                sourceRunspace, string
                resultText)
                {
                    this_param.TranscribeResult(sourceRunspace, resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 31643, 31677);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 31569, 31689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 31569, 31689);
            }
        }

        internal void TranscribeCommandComplete(InvocationInfo invocation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 31859, 33074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 31950, 31971);

                f_1472_31950_31970(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 31987, 33063) || true) && (invocation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 31987, 33063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 32276, 32342);

                    string
                    commandNameToCheck = f_1472_32304_32341(f_1472_32304_32321())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 32360, 32493) || true) && (f_1472_32364_32397(f_1472_32364_32381()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 32360, 32493);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 32439, 32474);

                        commandNameToCheck = "Out-Default";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 32360, 32493);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 32627, 33048) || true) && ((f_1472_32632_32669(f_1472_32632_32649()) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1472, 32631, 32723) && (invocation != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1472, 32631, 32757) && (f_1472_32728_32748(invocation) != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1472, 32631, 32878) && f_1472_32782_32878(commandNameToCheck, f_1472_32816_32841(f_1472_32816_32836(invocation)), StringComparison.OrdinalIgnoreCase)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 32627, 33048);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 32920, 32965);

                        f_1472_32920_32937().CommandBeingIgnored = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 32987, 33029);

                        f_1472_32987_33004().IsHelperCommand = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 32627, 33048);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 31987, 33063);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 31859, 33074);

                int
                f_1472_31950_31970(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    this_param.FlushPendingOutput();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 31950, 31970);
                    return 0;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_32304_32321()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 32304, 32321);
                    return return_v;
                }


                string
                f_1472_32304_32341(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.CommandBeingIgnored;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 32304, 32341);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_32364_32381()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 32364, 32381);
                    return return_v;
                }


                bool
                f_1472_32364_32397(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.IsHelperCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 32364, 32397);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_32632_32649()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 32632, 32649);
                    return return_v;
                }


                string
                f_1472_32632_32669(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.CommandBeingIgnored;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 32632, 32669);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1472_32728_32748(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 32728, 32748);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1472_32816_32836(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 32816, 32836);
                    return return_v;
                }


                string
                f_1472_32816_32841(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 32816, 32841);
                    return return_v;
                }


                bool
                f_1472_32782_32878(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 32782, 32878);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_32920_32937()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 32920, 32937);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_32987_33004()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 32987, 33004);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 31859, 33074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 31859, 33074);
            }
        }

        internal void TranscribePipelineComplete()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 33086, 33302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 33153, 33174);

                f_1472_33153_33173(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 33190, 33235);

                f_1472_33190_33207().CommandBeingIgnored = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 33249, 33291);

                f_1472_33249_33266().IsHelperCommand = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 33086, 33302);

                int
                f_1472_33153_33173(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    this_param.FlushPendingOutput();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 33153, 33173);
                    return 0;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_33190_33207()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 33190, 33207);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_33249_33266()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 33249, 33266);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 33086, 33302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 33086, 33302);
            }
        }

        private void FlushPendingOutput()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 33314, 37479);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 33372, 37468);
                    foreach (TranscriptionOption transcript in f_1472_33415_33509_I(f_1472_33415_33509(f_1472_33415_33444(f_1472_33415_33432()), f_1472_33474_33508(f_1472_33474_33491()))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 33372, 37468);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 33543, 37453) || true) && (transcript != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 33543, 37453);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 33613, 33635);
                            lock (f_1472_33613_33635(transcript))
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 33685, 33816) || true) && (f_1472_33689_33717(f_1472_33689_33711(transcript)) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 33685, 33816);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 33780, 33789);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 33685, 33816);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 33850, 33878);

                                lock (f_1472_33850_33878(transcript))
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 33936, 33997);

                                    bool
                                    alreadyLogging = f_1472_33958_33992(f_1472_33958_33986(transcript)) > 0
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 34029, 34091);

                                    f_1472_34029_34090(f_1472_34029_34057(transcript), f_1472_34067_34089(transcript));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 34121, 34152);

                                    f_1472_34121_34151(f_1472_34121_34143(transcript));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 34359, 34483) || true) && (alreadyLogging)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 34359, 34483);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 34443, 34452);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 34359, 34483);
                                    }
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 34841, 34903);

                            string
                            baseDirectory = f_1472_34864_34902(f_1472_34886_34901(transcript))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 34925, 35467) || true) && (f_1472_34929_34962(f_1472_34946_34961(transcript)) || (DynAbs.Tracing.TraceSender.Expression_False(1472, 34929, 35076) || (f_1472_34967_35075(baseDirectory, f_1472_34996_35048(f_1472_34996_35011(transcript), Path.DirectorySeparatorChar), StringComparison.Ordinal))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 34925, 35467);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 35126, 35376);

                                string
                                errorMessage = f_1472_35148_35375(f_1472_35192_35239(), f_1472_35270_35328(), f_1472_35359_35374(transcript))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 35402, 35444);

                                throw f_1472_35408_35443(errorMessage);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 34925, 35467);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 35491, 35641) || true) && (!f_1472_35496_35527(baseDirectory))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 35491, 35641);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 35577, 35618);

                                f_1472_35577_35617(baseDirectory);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 35491, 35641);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 35665, 35810) || true) && (!f_1472_35670_35698(f_1472_35682_35697(transcript)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 35665, 35810);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 35748, 35787);

                                f_1472_35748_35786(f_1472_35748_35776(f_1472_35760_35775(transcript)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 35665, 35810);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 36199, 36237);

                            int
                            delay = f_1472_36211_36232(f_1472_36211_36223(), 10) + 1
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 36263, 36284);

                            bool
                            written = false
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 36312, 37407) || true) && (!written)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 36312, 37407);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 36453, 36485);

                                        f_1472_36453_36484(transcript);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 36519, 36534);

                                        written = true;
                                    }
                                    catch (IOException)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1472, 36595, 36747);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 36679, 36716);

                                        f_1472_36679_36715(delay);
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1472, 36595, 36747);
                                    }
                                    catch (UnauthorizedAccessException)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1472, 36777, 36945);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 36877, 36914);

                                        f_1472_36877_36913(delay);
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1472, 36777, 36945);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 37256, 37380) || true) && (delay < 1000)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 37256, 37380);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 37338, 37349);

                                        delay *= 2;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 37256, 37380);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 36312, 37407);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1472, 36312, 37407);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1472, 36312, 37407);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 33543, 37453);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 33372, 37468);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1472, 1, 4097);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1472, 1, 4097);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 33314, 37479);

                System.Management.Automation.Host.TranscriptionData
                f_1472_33415_33432()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 33415, 33432);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                f_1472_33415_33444(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.Transcripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 33415, 33444);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1472_33474_33491()
                {
                    var return_v = TranscriptionData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 33474, 33491);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_33474_33508(System.Management.Automation.Host.TranscriptionData
                this_param)
                {
                    var return_v = this_param.SystemTranscript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 33474, 33508);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Host.TranscriptionOption>
                f_1472_33415_33509(System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
                collection, System.Management.Automation.Host.TranscriptionOption
                element)
                {
                    var return_v = collection.Prepend<System.Management.Automation.Host.TranscriptionOption>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 33415, 33509);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_33613_33635(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 33613, 33635);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_33689_33711(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 33689, 33711);
                    return return_v;
                }


                int
                f_1472_33689_33717(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 33689, 33717);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_33850_33878(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputBeingLogged;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 33850, 33878);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_33958_33986(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputBeingLogged;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 33958, 33986);
                    return return_v;
                }


                int
                f_1472_33958_33992(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 33958, 33992);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_34029_34057(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputBeingLogged;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 34029, 34057);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_34067_34089(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 34067, 34089);
                    return return_v;
                }


                int
                f_1472_34029_34090(System.Collections.Generic.List<string>
                this_param, System.Collections.Generic.List<string>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 34029, 34090);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1472_34121_34143(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 34121, 34143);
                    return return_v;
                }


                int
                f_1472_34121_34151(System.Collections.Generic.List<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 34121, 34151);
                    return 0;
                }


                string
                f_1472_34886_34901(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 34886, 34901);
                    return return_v;
                }


                string?
                f_1472_34864_34902(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 34864, 34902);
                    return return_v;
                }


                string
                f_1472_34946_34961(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 34946, 34961);
                    return return_v;
                }


                bool
                f_1472_34929_34962(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 34929, 34962);
                    return return_v;
                }


                string
                f_1472_34996_35011(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 34996, 35011);
                    return return_v;
                }


                string
                f_1472_34996_35048(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 34996, 35048);
                    return return_v;
                }


                bool
                f_1472_34967_35075(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 34967, 35075);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1472_35192_35239()
                {
                    var return_v = System.Globalization.CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 35192, 35239);
                    return return_v;
                }


                string
                f_1472_35270_35328()
                {
                    var return_v = InternalHostUserInterfaceStrings.InvalidTranscriptFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 35270, 35328);
                    return return_v;
                }


                string
                f_1472_35359_35374(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 35359, 35374);
                    return return_v;
                }


                string
                f_1472_35148_35375(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 35148, 35375);
                    return return_v;
                }


                System.ArgumentException
                f_1472_35408_35443(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 35408, 35443);
                    return return_v;
                }


                bool
                f_1472_35496_35527(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 35496, 35527);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1472_35577_35617(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 35577, 35617);
                    return return_v;
                }


                string
                f_1472_35682_35697(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 35682, 35697);
                    return return_v;
                }


                bool
                f_1472_35670_35698(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 35670, 35698);
                    return return_v;
                }


                string
                f_1472_35760_35775(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 35760, 35775);
                    return return_v;
                }


                System.IO.FileStream
                f_1472_35748_35776(string
                path)
                {
                    var return_v = File.Create(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 35748, 35776);
                    return return_v;
                }


                int
                f_1472_35748_35786(System.IO.FileStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 35748, 35786);
                    return 0;
                }


                System.Random
                f_1472_36211_36223()
                {
                    var return_v = new System.Random();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 36211, 36223);
                    return return_v;
                }


                int
                f_1472_36211_36232(System.Random
                this_param, int
                maxValue)
                {
                    var return_v = this_param.Next(maxValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 36211, 36232);
                    return return_v;
                }


                int
                f_1472_36453_36484(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    this_param.FlushContentToDisk();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 36453, 36484);
                    return 0;
                }


                int
                f_1472_36679_36715(int
                millisecondsTimeout)
                {
                    System.Threading.Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 36679, 36715);
                    return 0;
                }


                int
                f_1472_36877_36913(int
                millisecondsTimeout)
                {
                    System.Threading.Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 36877, 36913);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Host.TranscriptionOption>
                f_1472_33415_33509_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Host.TranscriptionOption>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 33415, 33509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 33314, 37479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 33314, 37479);
            }
        }

        public abstract Dictionary<string, PSObject> Prompt(string caption, string message, Collection<FieldDescription> descriptions);

        public abstract PSCredential PromptForCredential(string caption, string message,
                    string userName, string targetName
                );

        public abstract PSCredential PromptForCredential(string caption, string message,
                    string userName, string targetName, PSCredentialTypes allowedCredentialTypes,
                    PSCredentialUIOptions options
                );

        public abstract int PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int defaultChoice);

        protected PSHostUserInterface()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1472, 45038, 45129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 15835, 15861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 21604, 21628);
                this._transcribeOnlyCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 45094, 45118);

                f_1472_45094_45117(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1472, 45038, 45129);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 45038, 45129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 45038, 45129);
            }
        }

        internal void TranscribeError(ExecutionContext context, InvocationInfo invocation, PSObject errorWrap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 45485, 45988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 45612, 45674);

                f_1472_45612_45673(f_1472_45612_45635(f_1472_45612_45632(context)), invocation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 45688, 45760);

                InitialSessionState
                minimalState = f_1472_45723_45759()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 45774, 45923);

                Collection<PSObject>
                results = f_1472_45805_45922(f_1472_45805_45861(f_1472_45805_45836(minimalState), "Out-String"), new List<PSObject>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => errorWrap, 1472, 45887, 45921) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 45937, 45977);

                f_1472_45937_45976(this, f_1472_45954_45975(f_1472_45954_45964(results, 0)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 45485, 45988);

                System.Management.Automation.Internal.Host.InternalHost
                f_1472_45612_45632(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 45612, 45632);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1472_45612_45635(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 45612, 45635);
                    return return_v;
                }


                int
                f_1472_45612_45673(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.InvocationInfo
                invocation)
                {
                    this_param.TranscribeCommandComplete(invocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 45612, 45673);
                    return 0;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1472_45723_45759()
                {
                    var return_v = InitialSessionState.CreateDefault2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 45723, 45759);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1472_45805_45836(System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = PowerShell.Create(initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 45805, 45836);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1472_45805_45861(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 45805, 45861);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1472_45805_45922(System.Management.Automation.PowerShell
                this_param, System.Collections.Generic.List<System.Management.Automation.PSObject>
                input)
                {
                    var return_v = this_param.Invoke((System.Collections.IEnumerable)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 45805, 45922);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1472_45954_45964(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 45954, 45964);
                    return return_v;
                }


                string
                f_1472_45954_45975(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 45954, 45975);
                    return return_v;
                }


                int
                f_1472_45937_45976(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                resultText)
                {
                    this_param.TranscribeResult(resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 45937, 45976);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 45485, 45988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 45485, 45988);
            }
        }

        internal static TranscriptionOption GetSystemTranscriptOption(TranscriptionOption currentTranscript)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1472, 46110, 47205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 46235, 46447);

                var
                transcription = (DynAbs.Tracing.TraceSender.Conditional_F1(1472, 46255, 46297) || ((InternalTestHooks.BypassGroupPolicyCaching
                && DynAbs.Tracing.TraceSender.Conditional_F2(1472, 46317, 46393)) || DynAbs.Tracing.TraceSender.Conditional_F3(1472, 46413, 46446))) ? f_1472_46317_46393(Utils.SystemWideThenCurrentUserConfig) : f_1472_46413_46446(s_transcriptionSettingCache)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 46463, 47154) || true) && (transcription != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 46463, 47154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 46850, 46872);
                    // If we have an existing system transcript for this process, use that.
                    // Otherwise, populate the static variable with the result of the group policy setting.
                    //
                    // This way, multiple runspaces opened by the same process will share the same transcript.
                    lock (s_systemTranscriptLock)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 46914, 47120) || true) && (systemTranscript == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 46914, 47120);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 46992, 47097);

                            systemTranscript = f_1472_47011_47096(transcription, currentTranscript);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 46914, 47120);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 46463, 47154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 47170, 47194);

                return systemTranscript;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1472, 46110, 47205);

                System.Management.Automation.Configuration.Transcription
                f_1472_46317_46393(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 46317, 46393);
                    return return_v;
                }


                System.Management.Automation.Configuration.Transcription
                f_1472_46413_46446(System.Lazy<System.Management.Automation.Configuration.Transcription>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 46413, 46446);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_47011_47096(System.Management.Automation.Configuration.Transcription
                transcriptConfig, System.Management.Automation.Host.TranscriptionOption
                currentTranscript)
                {
                    var return_v = PSHostUserInterface.GetTranscriptOptionFromSettings(transcriptConfig, currentTranscript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 47011, 47096);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 46110, 47205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 46110, 47205);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TranscriptionOption systemTranscript;

        private static object s_systemTranscriptLock;

        private static Lazy<Transcription> s_transcriptionSettingCache;

        private static TranscriptionOption GetTranscriptOptionFromSettings(Transcription transcriptConfig, TranscriptionOption currentTranscript)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1472, 47589, 48656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 47751, 47789);

                TranscriptionOption
                transcript = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 47805, 48611) || true) && (f_1472_47809_47845(transcriptConfig) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 47805, 48611);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 47887, 48002) || true) && (currentTranscript != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 47887, 48002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 47958, 47983);

                        return currentTranscript;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 47887, 48002);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 48022, 48061);

                    transcript = f_1472_48035_48060();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 48130, 48431) || true) && (f_1472_48134_48166(transcriptConfig) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 48130, 48431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 48216, 48292);

                        transcript.Path = f_1472_48234_48291(f_1472_48252_48284(transcriptConfig), true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 48130, 48431);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 48130, 48431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 48374, 48412);

                        transcript.Path = f_1472_48392_48411();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 48130, 48431);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 48511, 48596);

                    transcript.IncludeInvocationHeader = f_1472_48548_48587(transcriptConfig) == true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 47805, 48611);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 48627, 48645);

                return transcript;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1472, 47589, 48656);

                bool?
                f_1472_47809_47845(System.Management.Automation.Configuration.Transcription
                this_param)
                {
                    var return_v = this_param.EnableTranscripting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 47809, 47845);
                    return return_v;
                }


                System.Management.Automation.Host.TranscriptionOption
                f_1472_48035_48060()
                {
                    var return_v = new System.Management.Automation.Host.TranscriptionOption();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 48035, 48060);
                    return return_v;
                }


                string
                f_1472_48134_48166(System.Management.Automation.Configuration.Transcription
                this_param)
                {
                    var return_v = this_param.OutputDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 48134, 48166);
                    return return_v;
                }


                string
                f_1472_48252_48284(System.Management.Automation.Configuration.Transcription
                this_param)
                {
                    var return_v = this_param.OutputDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 48252, 48284);
                    return return_v;
                }


                string
                f_1472_48234_48291(string
                baseDirectory, bool
                includeDate)
                {
                    var return_v = GetTranscriptPath(baseDirectory, includeDate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 48234, 48291);
                    return return_v;
                }


                string
                f_1472_48392_48411()
                {
                    var return_v = GetTranscriptPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 48392, 48411);
                    return return_v;
                }


                bool?
                f_1472_48548_48587(System.Management.Automation.Configuration.Transcription
                this_param)
                {
                    var return_v = this_param.EnableInvocationHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 48548, 48587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 47589, 48656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 47589, 48656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetTranscriptPath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1472, 48668, 48892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 48735, 48820);

                string
                baseDirectory = f_1472_48758_48819(Environment.SpecialFolder.MyDocuments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 48834, 48881);

                return f_1472_48841_48880(baseDirectory, false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1472, 48668, 48892);

                string
                f_1472_48758_48819(System.Environment.SpecialFolder
                folder)
                {
                    var return_v = Platform.GetFolderPath(folder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 48758, 48819);
                    return return_v;
                }


                string
                f_1472_48841_48880(string
                baseDirectory, bool
                includeDate)
                {
                    var return_v = GetTranscriptPath(baseDirectory, includeDate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 48841, 48880);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 48668, 48892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 48668, 48892);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetTranscriptPath(string baseDirectory, bool includeDate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1472, 48904, 50882);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 49009, 49497) || true) && (f_1472_49013_49048(baseDirectory))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 49009, 49497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 49082, 49160);

                    baseDirectory = f_1472_49098_49159(Environment.SpecialFolder.MyDocuments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 49009, 49497);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 49009, 49497);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 49226, 49482) || true) && (!f_1472_49231_49263(baseDirectory))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 49226, 49482);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 49305, 49463);

                        baseDirectory = f_1472_49321_49462(f_1472_49360_49421(Environment.SpecialFolder.MyDocuments), baseDirectory);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 49226, 49482);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 49009, 49497);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 49513, 49686) || true) && (includeDate)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 49513, 49686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 49562, 49671);

                    baseDirectory = f_1472_49578_49670(baseDirectory, DateTime.Now.ToString("yyyyMMdd", f_1472_49640_49668()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 49513, 49686);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 50252, 50285);

                byte[]
                randomBytes = new byte[6]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 50299, 50381);

                f_1472_50299_50380(f_1472_50299_50358(), randomBytes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 50395, 50747);

                string
                filename = f_1472_50413_50746(f_1472_50453_50495(), "PowerShell_transcript.{0}.{1}.{2:yyyyMMddHHmmss}.txt", f_1472_50603_50626(), f_1472_50653_50706(f_1472_50653_50688(randomBytes), '/', '_'), DateTime.Now)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 50763, 50835);

                string
                transcriptPath = f_1472_50787_50834(baseDirectory, filename)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 50849, 50871);

                return transcriptPath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1472, 48904, 50882);

                bool
                f_1472_49013_49048(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 49013, 49048);
                    return return_v;
                }


                string
                f_1472_49098_49159(System.Environment.SpecialFolder
                folder)
                {
                    var return_v = Platform.GetFolderPath(folder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 49098, 49159);
                    return return_v;
                }


                bool
                f_1472_49231_49263(string
                path)
                {
                    var return_v = Path.IsPathRooted(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 49231, 49263);
                    return return_v;
                }


                string
                f_1472_49360_49421(System.Environment.SpecialFolder
                folder)
                {
                    var return_v = Platform.GetFolderPath(folder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 49360, 49421);
                    return return_v;
                }


                string
                f_1472_49321_49462(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 49321, 49462);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1472_49640_49668()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 49640, 49668);
                    return return_v;
                }


                string
                f_1472_49578_49670(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 49578, 49670);
                    return return_v;
                }


                System.Security.Cryptography.RandomNumberGenerator
                f_1472_50299_50358()
                {
                    var return_v = System.Security.Cryptography.RandomNumberGenerator.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 50299, 50358);
                    return return_v;
                }


                int
                f_1472_50299_50380(System.Security.Cryptography.RandomNumberGenerator
                this_param, byte[]
                data)
                {
                    this_param.GetBytes(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 50299, 50380);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1472_50453_50495()
                {
                    var return_v = Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 50453, 50495);
                    return return_v;
                }


                string
                f_1472_50603_50626()
                {
                    var return_v = Environment.MachineName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 50603, 50626);
                    return return_v;
                }


                string
                f_1472_50653_50688(byte[]
                inArray)
                {
                    var return_v = Convert.ToBase64String(inArray);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 50653, 50688);
                    return return_v;
                }


                string
                f_1472_50653_50706(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 50653, 50706);
                    return return_v;
                }


                string
                f_1472_50413_50746(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, System.DateTime
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 50413, 50746);
                    return return_v;
                }


                string
                f_1472_50787_50834(string
                path1, string
                path2)
                {
                    var return_v = System.IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 50787, 50834);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 48904, 50882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 48904, 50882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSHostUserInterface()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1472, 977, 50889);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 47253, 47276);
            systemTranscript = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 47309, 47346);
            s_systemTranscriptLock = f_1472_47334_47346();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 47392, 47576);
            s_transcriptionSettingCache = f_1472_47422_47576(() => Utils.GetPolicySetting<Transcription>(Utils.SystemWideThenCurrentUserConfig), isThreadSafe: true);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1472, 977, 50889);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 977, 50889);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1472, 977, 50889);

        int
        f_1472_21517_21576(ref int
        location1, int
        value, int
        comparand)
        {
            var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 21517, 21576);
            return return_v;
        }


        int
        f_1472_45094_45117(System.Management.Automation.Host.PSHostUserInterface
        this_param)
        {
            this_param.CheckSystemTranscript();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 45094, 45117);
            return 0;
        }


        static object
        f_1472_47334_47346()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 47334, 47346);
            return return_v;
        }


        static System.Lazy<System.Management.Automation.Configuration.Transcription>
        f_1472_47422_47576(System.Func<System.Management.Automation.Configuration.Transcription>
        valueFactory, bool
        isThreadSafe)
        {
            var return_v = new System.Lazy<System.Management.Automation.Configuration.Transcription>(valueFactory, isThreadSafe: isThreadSafe);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 47422, 47576);
            return return_v;
        }

    }
    internal class TranscriptionData
    {
        internal TranscriptionData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1472, 51033, 51293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 51305, 51417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 51429, 51488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 51498, 51547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 51557, 51600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 51610, 51650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 51086, 51132);

                Transcripts = f_1472_51100_51131();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 51146, 51170);

                SystemTranscript = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 51184, 51211);

                CommandBeingIgnored = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 51225, 51249);

                IsHelperCommand = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 51263, 51282);

                PromptText = "PS>";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1472, 51033, 51293);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 51033, 51293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 51033, 51293);
            }
        }

        internal List<TranscriptionOption> Transcripts
        {
            get;
            private set;
        }

        internal TranscriptionOption SystemTranscript { get; set; }

        internal string CommandBeingIgnored { get; set; }

        internal bool IsHelperCommand { get; set; }

        internal string PromptText { get; set; }

        static TranscriptionData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1472, 50984, 51657);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1472, 50984, 51657);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 50984, 51657);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1472, 50984, 51657);

        System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>
        f_1472_51100_51131()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Host.TranscriptionOption>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 51100, 51131);
            return return_v;
        }

    }
    internal class TranscriptionOption : IDisposable
    {
        internal TranscriptionOption()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1472, 51781, 51933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 52413, 52418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 52530, 52585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 52712, 52773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 52931, 52982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 53147, 53195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 55119, 55140);
                this._contentWriter = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 56115, 56132);
                this._disposed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 51836, 51869);

                OutputToLog = f_1472_51850_51868();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 51883, 51922);

                OutputBeingLogged = f_1472_51903_51921();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1472, 51781, 51933);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 51781, 51933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 51781, 51933);
            }
        }

        internal string Path
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 52100, 52164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 52136, 52149);

                    return _path;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 52100, 52164);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 52055, 52386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 52055, 52386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 52180, 52375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 52216, 52230);

                    _path = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 52324, 52360);

                    Encoding = f_1472_52335_52359(value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 52180, 52375);

                    System.Text.Encoding
                    f_1472_52335_52359(string
                    path)
                    {
                        var return_v = Utils.GetEncoding(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 52335, 52359);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 52055, 52386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 52055, 52386);
                }
            }
        }

        private string _path;

        internal List<string> OutputToLog { get; private set; }

        internal List<string> OutputBeingLogged { get; private set; }

        internal bool IncludeInvocationHeader { get; set; }

        internal Encoding Encoding { get; private set; }

        internal void FlushContentToDisk()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 53487, 55086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 53552, 53569);
                lock (f_1472_53552_53569())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 53603, 55014) || true) && (!_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 53603, 55014);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 53659, 54821) || true) && (_contentWriter == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 53659, 54821);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 53945, 54149);

                                _contentWriter = f_1472_53962_54148(f_1472_54013_54099(f_1472_54028_54037(this), FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read), f_1472_54134_54147(this));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 54179, 54229);

                                f_1472_54179_54228(f_1472_54179_54204(_contentWriter), 0, SeekOrigin.End);
                            }
                            catch (IOException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1472, 54282, 54738);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 54517, 54711);

                                _contentWriter = f_1472_54534_54710(f_1472_54585_54661(f_1472_54600_54609(this), FileMode.Append, FileAccess.Write, FileShare.Read), f_1472_54696_54709(this));
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1472, 54282, 54738);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 54766, 54798);

                            _contentWriter.AutoFlush = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 53659, 54821);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 54845, 54995);
                            foreach (string line in f_1472_54869_54891_I(f_1472_54869_54891(this)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 54845, 54995);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 54941, 54972);

                                f_1472_54941_54971(_contentWriter, line);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 54845, 54995);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1472, 1, 151);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1472, 1, 151);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 53603, 55014);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 55034, 55060);

                    f_1472_55034_55059(f_1472_55034_55051());
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 53487, 55086);

                System.Collections.Generic.List<string>
                f_1472_53552_53569()
                {
                    var return_v = OutputBeingLogged;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 53552, 53569);
                    return return_v;
                }


                string
                f_1472_54028_54037(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 54028, 54037);
                    return return_v;
                }


                System.IO.FileStream
                f_1472_54013_54099(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 54013, 54099);
                    return return_v;
                }


                System.Text.Encoding
                f_1472_54134_54147(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 54134, 54147);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1472_53962_54148(System.IO.FileStream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamWriter((System.IO.Stream)stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 53962, 54148);
                    return return_v;
                }


                System.IO.Stream
                f_1472_54179_54204(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 54179, 54204);
                    return return_v;
                }


                long
                f_1472_54179_54228(System.IO.Stream
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 54179, 54228);
                    return return_v;
                }


                string
                f_1472_54600_54609(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 54600, 54609);
                    return return_v;
                }


                System.IO.FileStream
                f_1472_54585_54661(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 54585, 54661);
                    return return_v;
                }


                System.Text.Encoding
                f_1472_54696_54709(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 54696, 54709);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1472_54534_54710(System.IO.FileStream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamWriter((System.IO.Stream)stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 54534, 54710);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_54869_54891(System.Management.Automation.Host.TranscriptionOption
                this_param)
                {
                    var return_v = this_param.OutputBeingLogged;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 54869, 54891);
                    return return_v;
                }


                int
                f_1472_54941_54971(System.IO.StreamWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 54941, 54971);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1472_54869_54891_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 54869, 54891);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_55034_55051()
                {
                    var return_v = OutputBeingLogged;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 55034, 55051);
                    return return_v;
                }


                int
                f_1472_55034_55059(System.Collections.Generic.List<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 55034, 55059);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 53487, 55086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 53487, 55086);
            }
        }

        private StreamWriter _contentWriter;

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1472, 55301, 56090);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 55347, 55373) || true) && (_disposed)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 55347, 55373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 55364, 55371);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 55347, 55373);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 55573, 55592);

                int
                outputWait = 0
                ;
                try
                {
                    while (
                    (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 55606, 55849) || true) && ((outputWait < 1000) && (DynAbs.Tracing.TraceSender.Expression_True(1472, 55631, 55729) && ((f_1472_55673_55690(f_1472_55673_55684()) > 0) || (DynAbs.Tracing.TraceSender.Expression_False(1472, 55672, 55728) || (f_1472_55700_55723(f_1472_55700_55717()) > 0)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 55606, 55849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 55763, 55798);

                        f_1472_55763_55797(100);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 55816, 55834);

                        outputWait += 100;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 55606, 55849);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1472, 55606, 55849);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1472, 55606, 55849);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 55865, 56046) || true) && (_contentWriter != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 55865, 56046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 55925, 55948);

                    f_1472_55925_55947(_contentWriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 55966, 55991);

                    f_1472_55966_55990(_contentWriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 56009, 56031);

                    _contentWriter = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 55865, 56046);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 56062, 56079);

                _disposed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1472, 55301, 56090);

                System.Collections.Generic.List<string>
                f_1472_55673_55684()
                {
                    var return_v = OutputToLog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 55673, 55684);
                    return return_v;
                }


                int
                f_1472_55673_55690(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 55673, 55690);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1472_55700_55717()
                {
                    var return_v = OutputBeingLogged;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 55700, 55717);
                    return return_v;
                }


                int
                f_1472_55700_55723(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 55700, 55723);
                    return return_v;
                }


                int
                f_1472_55763_55797(int
                millisecondsTimeout)
                {
                    System.Threading.Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 55763, 55797);
                    return 0;
                }


                int
                f_1472_55925_55947(System.IO.StreamWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 55925, 55947);
                    return 0;
                }


                int
                f_1472_55966_55990(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 55966, 55990);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 55301, 56090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 55301, 56090);
            }
        }

        private bool _disposed;

        static TranscriptionOption()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1472, 51716, 56140);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1472, 51716, 56140);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 51716, 56140);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1472, 51716, 56140);

        System.Collections.Generic.List<string>
        f_1472_51850_51868()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 51850, 51868);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1472_51903_51921()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 51903, 51921);
            return return_v;
        }

    }

    /// <summary>
    /// This interface needs to be implemented by PSHost objects that want to support PromptForChoice
    /// by giving the user ability to select more than one choice. The PromptForChoice method available
    /// in PSHostUserInterface class supports only one choice selection.
    /// </summary>
    public interface IHostUISupportsMultipleChoiceSelection
    {

        Collection<int> PromptForChoice(string caption, string message,
                    Collection<ChoiceDescription> choices, IEnumerable<int> defaultChoices);
    }
    internal static class HostUIHelperMethods
    {
        internal static void BuildHotkeysAndPlainLabels(Collection<ChoiceDescription> choices,
                    out string[,] hotkeysAndPlainLabels)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1472, 58433, 60236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 58644, 58697);

                hotkeysAndPlainLabels = new string[2, f_1472_58682_58695(choices)];
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 58722, 58727);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 58713, 60225) || true) && (i < f_1472_58733_58746(choices))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 58748, 58751)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 58713, 60225))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 58713, 60225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 58821, 58864);

                        hotkeysAndPlainLabels[0, i] = string.Empty;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 58882, 58925);

                        int
                        andPos = f_1472_58895_58924(f_1472_58895_58911(f_1472_58895_58905(choices, i)), '&')
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 58943, 59693) || true) && (andPos >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 58943, 59693);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 59000, 59119);

                            Text.StringBuilder
                            splitLabel = f_1472_59032_59118(f_1472_59055_59092(f_1472_59055_59071(f_1472_59055_59065(choices, i)), 0, andPos), f_1472_59094_59117(f_1472_59094_59110(f_1472_59094_59104(choices, i))))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 59141, 59462) || true) && (andPos + 1 < f_1472_59158_59181(f_1472_59158_59174(f_1472_59158_59168(choices, i))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 59141, 59462);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 59231, 59289);

                                f_1472_59231_59288(splitLabel, f_1472_59249_59287(f_1472_59249_59265(f_1472_59249_59259(choices, i)), andPos + 1));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 59315, 59439);

                                hotkeysAndPlainLabels[0, i] = f_1472_59345_59438(f_1472_59345_59380(f_1472_59345_59371()), f_1472_59389_59437(f_1472_59389_59430(f_1472_59389_59405(f_1472_59389_59399(choices, i)), andPos + 1, 1)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 59141, 59462);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 59486, 59545);

                            hotkeysAndPlainLabels[1, i] = f_1472_59516_59544(f_1472_59516_59537(splitLabel));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 58943, 59693);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 58943, 59693);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 59627, 59674);

                            hotkeysAndPlainLabels[1, i] = f_1472_59657_59673(f_1472_59657_59667(choices, i));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 58943, 59693);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 59793, 60210) || true) && (f_1472_59797_59871(hotkeysAndPlainLabels[0, i], "?", StringComparison.Ordinal) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 59793, 60210);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 59918, 60161);

                            Exception
                            e = f_1472_59932_60160(f_1472_59993_60075(f_1472_60007_60049(), "choices[{0}].Label", i), f_1472_60102_60159())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 60183, 60191);

                            throw e;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 59793, 60210);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1472, 1, 1513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1472, 1, 1513);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1472, 58433, 60236);

                int
                f_1472_58682_58695(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 58682, 58695);
                    return return_v;
                }


                int
                f_1472_58733_58746(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 58733, 58746);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1472_58895_58905(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 58895, 58905);
                    return return_v;
                }


                string
                f_1472_58895_58911(System.Management.Automation.Host.ChoiceDescription
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 58895, 58911);
                    return return_v;
                }


                int
                f_1472_58895_58924(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 58895, 58924);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1472_59055_59065(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59055, 59065);
                    return return_v;
                }


                string
                f_1472_59055_59071(System.Management.Automation.Host.ChoiceDescription
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59055, 59071);
                    return return_v;
                }


                string
                f_1472_59055_59092(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 59055, 59092);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1472_59094_59104(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59094, 59104);
                    return return_v;
                }


                string
                f_1472_59094_59110(System.Management.Automation.Host.ChoiceDescription
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59094, 59110);
                    return return_v;
                }


                int
                f_1472_59094_59117(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59094, 59117);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1472_59032_59118(string
                value, int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(value, capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 59032, 59118);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1472_59158_59168(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59158, 59168);
                    return return_v;
                }


                string
                f_1472_59158_59174(System.Management.Automation.Host.ChoiceDescription
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59158, 59174);
                    return return_v;
                }


                int
                f_1472_59158_59181(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59158, 59181);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1472_59249_59259(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59249, 59259);
                    return return_v;
                }


                string
                f_1472_59249_59265(System.Management.Automation.Host.ChoiceDescription
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59249, 59265);
                    return return_v;
                }


                string
                f_1472_59249_59287(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 59249, 59287);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1472_59231_59288(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 59231, 59288);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1472_59345_59371()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59345, 59371);
                    return return_v;
                }


                System.Globalization.TextInfo
                f_1472_59345_59380(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.TextInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59345, 59380);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1472_59389_59399(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59389, 59399);
                    return return_v;
                }


                string
                f_1472_59389_59405(System.Management.Automation.Host.ChoiceDescription
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59389, 59405);
                    return return_v;
                }


                string
                f_1472_59389_59430(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 59389, 59430);
                    return return_v;
                }


                string
                f_1472_59389_59437(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 59389, 59437);
                    return return_v;
                }


                string
                f_1472_59345_59438(System.Globalization.TextInfo
                this_param, string
                str)
                {
                    var return_v = this_param.ToUpper(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 59345, 59438);
                    return return_v;
                }


                string
                f_1472_59516_59537(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 59516, 59537);
                    return return_v;
                }


                string
                f_1472_59516_59544(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 59516, 59544);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1472_59657_59667(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59657, 59667);
                    return return_v;
                }


                string
                f_1472_59657_59673(System.Management.Automation.Host.ChoiceDescription
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 59657, 59673);
                    return return_v;
                }


                int
                f_1472_59797_59871(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 59797, 59871);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1472_60007_60049()
                {
                    var return_v = Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 60007, 60049);
                    return return_v;
                }


                string
                f_1472_59993_60075(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 59993, 60075);
                    return return_v;
                }


                string
                f_1472_60102_60159()
                {
                    var return_v = InternalHostUserInterfaceStrings.InvalidChoiceHotKeyError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 60102, 60159);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1472_59932_60160(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 59932, 60160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 58433, 60236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 58433, 60236);
            }
        }

        internal static int DetermineChoicePicked(string response, Collection<ChoiceDescription> choices, string[,] hotkeysAndPlainLabels)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1472, 60899, 62392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 61054, 61119);

                f_1472_61054_61118(choices != null, "choices: expected a value");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 61133, 61226);

                f_1472_61133_61225(hotkeysAndPlainLabels != null, "hotkeysAndPlainLabels: expected a value");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 61242, 61258);

                int
                result = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 61358, 61363);

                    // check the full label first, as this is the least ambiguous
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 61349, 61724) || true) && (i < f_1472_61369_61382(choices))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 61384, 61387)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 61349, 61724))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 61349, 61724);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 61504, 61709) || true) && (f_1472_61508_61604(response, hotkeysAndPlainLabels[1, i], StringComparison.CurrentCultureIgnoreCase) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 61504, 61709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 61651, 61662);

                            result = i;
                            DynAbs.Tracing.TraceSender.TraceBreak(1472, 61684, 61690);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 61504, 61709);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1472, 1, 376);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1472, 1, 376);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 61778, 62351) || true) && (result == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 61778, 62351);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 61837, 61842);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 61828, 62336) || true) && (i < f_1472_61848_61861(choices))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 61863, 61866)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 61828, 62336))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 61828, 62336);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 61965, 62317) || true) && (f_1472_61969_62003(hotkeysAndPlainLabels[0, i]) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 61965, 62317);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 62057, 62294) || true) && (f_1472_62061_62157(response, hotkeysAndPlainLabels[0, i], StringComparison.CurrentCultureIgnoreCase) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1472, 62057, 62294);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 62220, 62231);

                                    result = i;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1472, 62261, 62267);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 62057, 62294);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 61965, 62317);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1472, 1, 509);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1472, 1, 509);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1472, 61778, 62351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1472, 62367, 62381);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1472, 60899, 62392);

                int
                f_1472_61054_61118(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 61054, 61118);
                    return 0;
                }


                int
                f_1472_61133_61225(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 61133, 61225);
                    return 0;
                }


                int
                f_1472_61369_61382(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 61369, 61382);
                    return return_v;
                }


                int
                f_1472_61508_61604(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 61508, 61604);
                    return return_v;
                }


                int
                f_1472_61848_61861(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 61848, 61861);
                    return return_v;
                }


                int
                f_1472_61969_62003(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1472, 61969, 62003);
                    return return_v;
                }


                int
                f_1472_62061_62157(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1472, 62061, 62157);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1472, 60899, 62392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 60899, 62392);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static HostUIHelperMethods()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1472, 57981, 62399);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1472, 57981, 62399);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1472, 57981, 62399);
        }

    }
}

