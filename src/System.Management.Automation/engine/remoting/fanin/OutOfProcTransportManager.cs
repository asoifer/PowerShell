// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

/*
 * Common file that contains implementation for both server and client transport
 * managers for Out-Of-Process and Named Pipe (on the local machine) remoting implementation.
 * These interfaces are used by *-Job cmdlets to support background jobs and
 * attach-to-process feature without depending on WinRM (WinRM has complex requirements like
 * elevation to support local machine remoting).
 */

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Tracing;
using System.Net;
using System.Threading;
using System.Xml;

using PSRemotingCryptoHelper = System.Management.Automation.Internal.PSRemotingCryptoHelper;
using PSRemotingCryptoHelperServer = System.Management.Automation.Internal.PSRemotingCryptoHelperServer;
using RunspaceConnectionInfo = System.Management.Automation.Runspaces.RunspaceConnectionInfo;
using ClientRemotePowerShell = System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell;
using NewProcessConnectionInfo = System.Management.Automation.Runspaces.NewProcessConnectionInfo;
using PSTask = System.Management.Automation.Internal.PSTask;
using PSOpcode = System.Management.Automation.Internal.PSOpcode;
using PSEventId = System.Management.Automation.Internal.PSEventId;
using TypeTable = System.Management.Automation.Runspaces.TypeTable;
using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal static class OutOfProcessUtils
    {
        internal const string
        PS_OUT_OF_PROC_DATA_TAG = "Data"
        ;

        internal const string
        PS_OUT_OF_PROC_DATA_ACK_TAG = "DataAck"
        ;

        internal const string
        PS_OUT_OF_PROC_STREAM_ATTRIBUTE = "Stream"
        ;

        internal const string
        PS_OUT_OF_PROC_PSGUID_ATTRIBUTE = "PSGuid"
        ;

        internal const string
        PS_OUT_OF_PROC_CLOSE_TAG = "Close"
        ;

        internal const string
        PS_OUT_OF_PROC_CLOSE_ACK_TAG = "CloseAck"
        ;

        internal const string
        PS_OUT_OF_PROC_COMMAND_TAG = "Command"
        ;

        internal const string
        PS_OUT_OF_PROC_COMMAND_ACK_TAG = "CommandAck"
        ;

        internal const string
        PS_OUT_OF_PROC_SIGNAL_TAG = "Signal"
        ;

        internal const string
        PS_OUT_OF_PROC_SIGNAL_ACK_TAG = "SignalAck"
        ;

        internal const int
        EXITCODE_UNHANDLED_EXCEPTION = 0x0FA0
        ;

        internal static XmlReaderSettings XmlReaderSettings;

        static OutOfProcessUtils()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 2740, 3363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 1847, 1879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 1912, 1951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 1984, 2026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 2059, 2101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 2134, 2168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 2201, 2242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 2275, 2313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 2346, 2391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 2424, 2460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 2493, 2536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 2566, 2603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 2650, 2667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 3002, 3046);

                XmlReaderSettings = f_1635_3022_3045();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 3060, 3102);

                XmlReaderSettings.CheckCharacters = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 3116, 3156);

                XmlReaderSettings.IgnoreComments = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 3170, 3224);

                XmlReaderSettings.IgnoreProcessingInstructions = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 3238, 3275);

                XmlReaderSettings.XmlResolver = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 3289, 3352);

                XmlReaderSettings.ConformanceLevel = ConformanceLevel.Fragment;
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 2740, 3363);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 2740, 3363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 2740, 3363);
            }
        }

        internal static string CreateDataPacket(byte[] data, DataPriorityType streamType, Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1635, 3447, 3987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 3566, 3946);

                string
                result = f_1635_3582_3945(f_1635_3596_3624(), "<{0} {1}='{2}' {3}='{4}'>{5}</{0}>", PS_OUT_OF_PROC_DATA_TAG, PS_OUT_OF_PROC_STREAM_ATTRIBUTE, f_1635_3790_3811(streamType), PS_OUT_OF_PROC_PSGUID_ATTRIBUTE, psGuid.ToString(), f_1635_3916_3944(data))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 3962, 3976);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1635, 3447, 3987);

                System.Globalization.CultureInfo
                f_1635_3596_3624()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 3596, 3624);
                    return return_v;
                }


                string
                f_1635_3790_3811(System.Management.Automation.Remoting.DataPriorityType
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 3790, 3811);
                    return return_v;
                }


                string
                f_1635_3916_3944(byte[]
                inArray)
                {
                    var return_v = Convert.ToBase64String(inArray);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 3916, 3944);
                    return return_v;
                }


                string
                f_1635_3582_3945(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 3582, 3945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 3447, 3987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 3447, 3987);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string CreateDataAckPacket(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1635, 3999, 4153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 4079, 4142);

                return f_1635_4086_4141(PS_OUT_OF_PROC_DATA_ACK_TAG, psGuid);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1635, 3999, 4153);

                string
                f_1635_4086_4141(string
                element, System.Guid
                psGuid)
                {
                    var return_v = CreatePSGuidPacket(element, psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 4086, 4141);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 3999, 4153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 3999, 4153);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string CreateCommandPacket(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1635, 4165, 4318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 4245, 4307);

                return f_1635_4252_4306(PS_OUT_OF_PROC_COMMAND_TAG, psGuid);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1635, 4165, 4318);

                string
                f_1635_4252_4306(string
                element, System.Guid
                psGuid)
                {
                    var return_v = CreatePSGuidPacket(element, psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 4252, 4306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 4165, 4318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 4165, 4318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string CreateCommandAckPacket(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1635, 4330, 4490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 4413, 4479);

                return f_1635_4420_4478(PS_OUT_OF_PROC_COMMAND_ACK_TAG, psGuid);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1635, 4330, 4490);

                string
                f_1635_4420_4478(string
                element, System.Guid
                psGuid)
                {
                    var return_v = CreatePSGuidPacket(element, psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 4420, 4478);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 4330, 4490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 4330, 4490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string CreateClosePacket(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1635, 4502, 4651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 4580, 4640);

                return f_1635_4587_4639(PS_OUT_OF_PROC_CLOSE_TAG, psGuid);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1635, 4502, 4651);

                string
                f_1635_4587_4639(string
                element, System.Guid
                psGuid)
                {
                    var return_v = CreatePSGuidPacket(element, psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 4587, 4639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 4502, 4651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 4502, 4651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string CreateCloseAckPacket(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1635, 4663, 4819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 4744, 4808);

                return f_1635_4751_4807(PS_OUT_OF_PROC_CLOSE_ACK_TAG, psGuid);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1635, 4663, 4819);

                string
                f_1635_4751_4807(string
                element, System.Guid
                psGuid)
                {
                    var return_v = CreatePSGuidPacket(element, psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 4751, 4807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 4663, 4819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 4663, 4819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string CreateSignalPacket(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1635, 4831, 4982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 4910, 4971);

                return f_1635_4917_4970(PS_OUT_OF_PROC_SIGNAL_TAG, psGuid);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1635, 4831, 4982);

                string
                f_1635_4917_4970(string
                element, System.Guid
                psGuid)
                {
                    var return_v = CreatePSGuidPacket(element, psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 4917, 4970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 4831, 4982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 4831, 4982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string CreateSignalAckPacket(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1635, 4994, 5152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 5076, 5141);

                return f_1635_5083_5140(PS_OUT_OF_PROC_SIGNAL_ACK_TAG, psGuid);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1635, 4994, 5152);

                string
                f_1635_5083_5140(string
                element, System.Guid
                psGuid)
                {
                    var return_v = CreatePSGuidPacket(element, psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 5083, 5140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 4994, 5152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 4994, 5152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string CreatePSGuidPacket(string element, Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1635, 5447, 5792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 5541, 5751);

                string
                result = f_1635_5557_5750(f_1635_5571_5599(), "<{0} {1}='{2}' />", element, PS_OUT_OF_PROC_PSGUID_ATTRIBUTE, psGuid.ToString())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 5767, 5781);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1635, 5447, 5792);

                System.Globalization.CultureInfo
                f_1635_5571_5599()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 5571, 5599);
                    return return_v;
                }


                string
                f_1635_5557_5750(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 5557, 5750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 5447, 5792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 5447, 5792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }


        internal delegate void DataPacketReceived(byte[] rawData, string stream, Guid psGuid);
        internal delegate void DataAckPacketReceived(Guid psGuid);
        internal delegate void CommandCreationPacketReceived(Guid psGuid);
        internal delegate void CommandCreationAckReceived(Guid psGuid);
        internal delegate void ClosePacketReceived(Guid psGuid);
        internal delegate void CloseAckPacketReceived(Guid psGuid);
        internal delegate void SignalPacketReceived(Guid psGuid);
        internal delegate void SignalAckPacketReceived(Guid psGuid);

        internal struct DataProcessingDelegates
        {

            internal DataPacketReceived DataPacketReceived;

            internal DataAckPacketReceived DataAckPacketReceived;

            internal CommandCreationPacketReceived CommandCreationPacketReceived;

            internal CommandCreationAckReceived CommandCreationAckReceived;

            internal SignalPacketReceived SignalPacketReceived;

            internal SignalAckPacketReceived SignalAckPacketReceived;

            internal ClosePacketReceived ClosePacketReceived;

            internal CloseAckPacketReceived CloseAckPacketReceived;
            static DataProcessingDelegates()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 6475, 7092);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 6475, 7092);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 6475, 7092);
            }
        }

        internal static void ProcessData(string data, DataProcessingDelegates callbacks)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1635, 7634, 8770);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 7739, 7825) || true) && (f_1635_7743_7769(data))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 7739, 7825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 7803, 7810);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 7739, 7825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 7841, 7920);

                XmlReader
                reader = f_1635_7860_7919(f_1635_7877_7899(data), XmlReaderSettings)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 7934, 8759) || true) && (f_1635_7941_7954(reader))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 7934, 8759);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 7988, 8744);

                        switch (f_1635_7996_8011(reader))
                        {

                            case XmlNodeType.Element:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 7988, 8744);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 8104, 8138);

                                f_1635_8104_8137(reader, callbacks);
                                DynAbs.Tracing.TraceSender.TraceBreak(1635, 8164, 8170);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 7988, 8744);

                            case XmlNodeType.EndElement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 7988, 8744);
                                DynAbs.Tracing.TraceSender.TraceBreak(1635, 8246, 8252);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 7988, 8744);

                            case XmlNodeType.Text:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 7988, 8744);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 8322, 8367);

                                throw f_1635_8328_8366(data);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 7988, 8744);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 7988, 8744);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 8423, 8725);

                                throw f_1635_8429_8724(PSRemotingErrorId.IPCUnknownNodeType, f_1635_8500_8541(), f_1635_8572_8598(f_1635_8572_8587(reader)), f_1635_8629_8659(XmlNodeType.Element), f_1635_8690_8723(XmlNodeType.EndElement));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 7988, 8744);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 7934, 8759);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1635, 7934, 8759);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1635, 7934, 8759);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1635, 7634, 8770);

                bool
                f_1635_7743_7769(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 7743, 7769);
                    return return_v;
                }


                System.IO.StringReader
                f_1635_7877_7899(string
                s)
                {
                    var return_v = new System.IO.StringReader(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 7877, 7899);
                    return return_v;
                }


                System.Xml.XmlReader
                f_1635_7860_7919(System.IO.StringReader
                input, System.Xml.XmlReaderSettings
                settings)
                {
                    var return_v = XmlReader.Create((System.IO.TextReader)input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 7860, 7919);
                    return return_v;
                }


                bool
                f_1635_7941_7954(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.Read();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 7941, 7954);
                    return return_v;
                }


                System.Xml.XmlNodeType
                f_1635_7996_8011(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 7996, 8011);
                    return return_v;
                }


                int
                f_1635_8104_8137(System.Xml.XmlReader
                xmlReader, System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates
                callbacks)
                {
                    ProcessElement(xmlReader, callbacks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 8104, 8137);
                    return 0;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_8328_8366(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 8328, 8366);
                    return return_v;
                }


                string
                f_1635_8500_8541()
                {
                    var return_v = RemotingErrorIdStrings.IPCUnknownNodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 8500, 8541);
                    return return_v;
                }


                System.Xml.XmlNodeType
                f_1635_8572_8587(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 8572, 8587);
                    return return_v;
                }


                string
                f_1635_8572_8598(System.Xml.XmlNodeType
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 8572, 8598);
                    return return_v;
                }


                string
                f_1635_8629_8659(System.Xml.XmlNodeType
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 8629, 8659);
                    return return_v;
                }


                string
                f_1635_8690_8723(System.Xml.XmlNodeType
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 8690, 8723);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_8429_8724(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 8429, 8724);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 7634, 8770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 7634, 8770);
            }
        }

        private static void ProcessElement(XmlReader xmlReader, DataProcessingDelegates callbacks)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1635, 9371, 19708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 9486, 9545);

                f_1635_9486_9544(xmlReader != null, "xmlReader cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 9559, 9663);

                f_1635_9559_9662(f_1635_9570_9588(xmlReader) == XmlNodeType.Element, "xmlReader's NodeType should be of type Element");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 9679, 9756);

                PowerShellTraceSource
                tracer = f_1635_9710_9755()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 9772, 19697);

                switch (f_1635_9780_9799(xmlReader))
                {

                    case OutOfProcessUtils.PS_OUT_OF_PROC_DATA_TAG:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 9772, 19697);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 10013, 10564) || true) && (f_1635_10017_10041(xmlReader) != 2)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 10013, 10564);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 10104, 10537);

                                throw f_1635_10110_10536(PSRemotingErrorId.IPCWrongAttributeCountForDataElement, f_1635_10232_10291(), OutOfProcessUtils.PS_OUT_OF_PROC_STREAM_ATTRIBUTE, OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE, OutOfProcessUtils.PS_OUT_OF_PROC_DATA_TAG);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 10013, 10564);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 10592, 10682);

                            string
                            stream = f_1635_10608_10681(xmlReader, OutOfProcessUtils.PS_OUT_OF_PROC_STREAM_ATTRIBUTE)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 10708, 10804);

                            string
                            psGuidString = f_1635_10730_10803(xmlReader, OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 10830, 10867);

                            Guid
                            psGuid = f_1635_10844_10866(psGuidString)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 10963, 11320) || true) && (!f_1635_10968_10984(xmlReader))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 10963, 11320);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 11042, 11293);

                                throw f_1635_11048_11292(PSRemotingErrorId.IPCInsufficientDataforElement, f_1635_11163_11215(), OutOfProcessUtils.PS_OUT_OF_PROC_DATA_TAG);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 10963, 11320);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 11348, 11770) || true) && (f_1635_11352_11370(xmlReader) != XmlNodeType.Text)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 11348, 11770);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 11448, 11743);

                                throw f_1635_11454_11742(PSRemotingErrorId.IPCOnlyTextExpectedInDataElement, f_1635_11572_11627(), f_1635_11662_11680(xmlReader), OutOfProcessUtils.PS_OUT_OF_PROC_DATA_TAG, XmlNodeType.Text);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 11348, 11770);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 11798, 11828);

                            string
                            data = f_1635_11812_11827(xmlReader)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 11854, 11972);

                            f_1635_11854_11971(tracer, "OutOfProcessUtils.ProcessElement : PS_OUT_OF_PROC_DATA received, psGuid : " + psGuid.ToString());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 11998, 12046);

                            byte[]
                            rawData = f_1635_12015_12045(data)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 12072, 12126);

                            f_1635_12072_12125(ref callbacks, rawData, stream, psGuid);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1635, 12173, 12179);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 9772, 19697);

                    case OutOfProcessUtils.PS_OUT_OF_PROC_DATA_ACK_TAG:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 9772, 19697);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 12297, 12760) || true) && (f_1635_12301_12325(xmlReader) != 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 12297, 12760);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 12388, 12733);

                                throw f_1635_12394_12732(PSRemotingErrorId.IPCWrongAttributeCountForElement, f_1635_12512_12567(), OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE, OutOfProcessUtils.PS_OUT_OF_PROC_DATA_ACK_TAG);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 12297, 12760);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 12788, 12884);

                            string
                            psGuidString = f_1635_12810_12883(xmlReader, OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 12910, 12947);

                            Guid
                            psGuid = f_1635_12924_12946(psGuidString)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 12975, 13097);

                            f_1635_12975_13096(
                                                    tracer, "OutOfProcessUtils.ProcessElement : PS_OUT_OF_PROC_DATA_ACK received, psGuid : " + psGuid.ToString());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 13123, 13163);

                            f_1635_13123_13162(ref callbacks, psGuid);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1635, 13210, 13216);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 9772, 19697);

                    case OutOfProcessUtils.PS_OUT_OF_PROC_COMMAND_TAG:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 9772, 19697);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 13333, 13795) || true) && (f_1635_13337_13361(xmlReader) != 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 13333, 13795);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 13424, 13768);

                                throw f_1635_13430_13767(PSRemotingErrorId.IPCWrongAttributeCountForElement, f_1635_13548_13603(), OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE, OutOfProcessUtils.PS_OUT_OF_PROC_COMMAND_TAG);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 13333, 13795);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 13823, 13919);

                            string
                            psGuidString = f_1635_13845_13918(xmlReader, OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 13945, 13982);

                            Guid
                            psGuid = f_1635_13959_13981(psGuidString)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 14010, 14131);

                            f_1635_14010_14130(
                                                    tracer, "OutOfProcessUtils.ProcessElement : PS_OUT_OF_PROC_COMMAND received, psGuid : " + psGuid.ToString());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 14157, 14205);

                            f_1635_14157_14204(ref callbacks, psGuid);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1635, 14252, 14258);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 9772, 19697);

                    case OutOfProcessUtils.PS_OUT_OF_PROC_COMMAND_ACK_TAG:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 9772, 19697);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 14379, 14845) || true) && (f_1635_14383_14407(xmlReader) != 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 14379, 14845);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 14470, 14818);

                                throw f_1635_14476_14817(PSRemotingErrorId.IPCWrongAttributeCountForElement, f_1635_14594_14649(), OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE, OutOfProcessUtils.PS_OUT_OF_PROC_COMMAND_ACK_TAG);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 14379, 14845);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 14873, 14969);

                            string
                            psGuidString = f_1635_14895_14968(xmlReader, OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 14995, 15032);

                            Guid
                            psGuid = f_1635_15009_15031(psGuidString)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 15058, 15183);

                            f_1635_15058_15182(tracer, "OutOfProcessUtils.ProcessElement : PS_OUT_OF_PROC_COMMAND_ACK received, psGuid : " + psGuid.ToString());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 15209, 15254);

                            f_1635_15209_15253(ref callbacks, psGuid);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1635, 15301, 15307);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 9772, 19697);

                    case OutOfProcessUtils.PS_OUT_OF_PROC_CLOSE_TAG:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 9772, 19697);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 15422, 15882) || true) && (f_1635_15426_15450(xmlReader) != 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 15422, 15882);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 15513, 15855);

                                throw f_1635_15519_15854(PSRemotingErrorId.IPCWrongAttributeCountForElement, f_1635_15637_15692(), OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE, OutOfProcessUtils.PS_OUT_OF_PROC_CLOSE_TAG);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 15422, 15882);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 15910, 16006);

                            string
                            psGuidString = f_1635_15932_16005(xmlReader, OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 16032, 16069);

                            Guid
                            psGuid = f_1635_16046_16068(psGuidString)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 16097, 16216);

                            f_1635_16097_16215(
                                                    tracer, "OutOfProcessUtils.ProcessElement : PS_OUT_OF_PROC_CLOSE received, psGuid : " + psGuid.ToString());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 16242, 16280);

                            f_1635_16242_16279(ref callbacks, psGuid);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1635, 16327, 16333);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 9772, 19697);

                    case OutOfProcessUtils.PS_OUT_OF_PROC_CLOSE_ACK_TAG:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 9772, 19697);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 16452, 16912) || true) && (f_1635_16456_16480(xmlReader) != 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 16452, 16912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 16543, 16885);

                                throw f_1635_16549_16884(PSRemotingErrorId.IPCWrongAttributeCountForElement, f_1635_16663_16718(), OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE, OutOfProcessUtils.PS_OUT_OF_PROC_CLOSE_ACK_TAG);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 16452, 16912);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 16940, 17036);

                            string
                            psGuidString = f_1635_16962_17035(xmlReader, OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 17062, 17099);

                            Guid
                            psGuid = f_1635_17076_17098(psGuidString)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 17125, 17248);

                            f_1635_17125_17247(tracer, "OutOfProcessUtils.ProcessElement : PS_OUT_OF_PROC_CLOSE_ACK received, psGuid : " + psGuid.ToString());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 17274, 17315);

                            f_1635_17274_17314(ref callbacks, psGuid);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1635, 17362, 17368);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 9772, 19697);

                    case OutOfProcessUtils.PS_OUT_OF_PROC_SIGNAL_TAG:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 9772, 19697);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 17484, 17941) || true) && (f_1635_17488_17512(xmlReader) != 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 17484, 17941);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 17575, 17914);

                                throw f_1635_17581_17913(PSRemotingErrorId.IPCWrongAttributeCountForElement, f_1635_17695_17750(), OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE, OutOfProcessUtils.PS_OUT_OF_PROC_SIGNAL_TAG);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 17484, 17941);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 17969, 18065);

                            string
                            psGuidString = f_1635_17991_18064(xmlReader, OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 18091, 18128);

                            Guid
                            psGuid = f_1635_18105_18127(psGuidString)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 18156, 18276);

                            f_1635_18156_18275(
                                                    tracer, "OutOfProcessUtils.ProcessElement : PS_OUT_OF_PROC_SIGNAL received, psGuid : " + psGuid.ToString());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 18302, 18341);

                            f_1635_18302_18340(ref callbacks, psGuid);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1635, 18388, 18394);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 9772, 19697);

                    case OutOfProcessUtils.PS_OUT_OF_PROC_SIGNAL_ACK_TAG:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 9772, 19697);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 18514, 18975) || true) && (f_1635_18518_18542(xmlReader) != 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 18514, 18975);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 18605, 18948);

                                throw f_1635_18611_18947(PSRemotingErrorId.IPCWrongAttributeCountForElement, f_1635_18725_18780(), OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE, OutOfProcessUtils.PS_OUT_OF_PROC_SIGNAL_ACK_TAG);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 18514, 18975);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 19003, 19099);

                            string
                            psGuidString = f_1635_19025_19098(xmlReader, OutOfProcessUtils.PS_OUT_OF_PROC_PSGUID_ATTRIBUTE)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 19125, 19162);

                            Guid
                            psGuid = f_1635_19139_19161(psGuidString)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 19188, 19312);

                            f_1635_19188_19311(tracer, "OutOfProcessUtils.ProcessElement : PS_OUT_OF_PROC_SIGNAL_ACK received, psGuid : " + psGuid.ToString());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 19338, 19380);

                            f_1635_19338_19379(ref callbacks, psGuid);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1635, 19427, 19433);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 9772, 19697);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 9772, 19697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 19481, 19682);

                        throw f_1635_19487_19681(PSRemotingErrorId.IPCUnknownElementReceived, f_1635_19586_19634(), f_1635_19661_19680(xmlReader));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 9772, 19697);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1635, 9371, 19708);

                int
                f_1635_9486_9544(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 9486, 9544);
                    return 0;
                }


                System.Xml.XmlNodeType
                f_1635_9570_9588(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 9570, 9588);
                    return return_v;
                }


                int
                f_1635_9559_9662(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 9559, 9662);
                    return 0;
                }


                System.Management.Automation.Tracing.PowerShellTraceSource
                f_1635_9710_9755()
                {
                    var return_v = PowerShellTraceSourceFactory.GetTraceSource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 9710, 9755);
                    return return_v;
                }


                string
                f_1635_9780_9799(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.LocalName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 9780, 9799);
                    return return_v;
                }


                int
                f_1635_10017_10041(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.AttributeCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 10017, 10041);
                    return return_v;
                }


                string
                f_1635_10232_10291()
                {
                    var return_v = RemotingErrorIdStrings.IPCWrongAttributeCountForDataElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 10232, 10291);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_10110_10536(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 10110, 10536);
                    return return_v;
                }


                string
                f_1635_10608_10681(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 10608, 10681);
                    return return_v;
                }


                string
                f_1635_10730_10803(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 10730, 10803);
                    return return_v;
                }


                System.Guid
                f_1635_10844_10866(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 10844, 10866);
                    return return_v;
                }


                bool
                f_1635_10968_10984(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.Read();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 10968, 10984);
                    return return_v;
                }


                string
                f_1635_11163_11215()
                {
                    var return_v = RemotingErrorIdStrings.IPCInsufficientDataforElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 11163, 11215);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_11048_11292(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 11048, 11292);
                    return return_v;
                }


                System.Xml.XmlNodeType
                f_1635_11352_11370(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 11352, 11370);
                    return return_v;
                }


                string
                f_1635_11572_11627()
                {
                    var return_v = RemotingErrorIdStrings.IPCOnlyTextExpectedInDataElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 11572, 11627);
                    return return_v;
                }


                System.Xml.XmlNodeType
                f_1635_11662_11680(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 11662, 11680);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_11454_11742(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 11454, 11742);
                    return return_v;
                }


                string
                f_1635_11812_11827(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 11812, 11827);
                    return return_v;
                }


                bool
                f_1635_11854_11971(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 11854, 11971);
                    return return_v;
                }


                byte[]
                f_1635_12015_12045(string
                s)
                {
                    var return_v = Convert.FromBase64String(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 12015, 12045);
                    return return_v;
                }


                int
                f_1635_12072_12125(ref System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates
                this_param, byte[]
                rawData, string
                stream, System.Guid
                psGuid)
                {
                    this_param.DataPacketReceived(rawData, stream, psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 12072, 12125);
                    return 0;
                }


                int
                f_1635_12301_12325(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.AttributeCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 12301, 12325);
                    return return_v;
                }


                string
                f_1635_12512_12567()
                {
                    var return_v = RemotingErrorIdStrings.IPCWrongAttributeCountForElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 12512, 12567);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_12394_12732(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 12394, 12732);
                    return return_v;
                }


                string
                f_1635_12810_12883(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 12810, 12883);
                    return return_v;
                }


                System.Guid
                f_1635_12924_12946(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 12924, 12946);
                    return return_v;
                }


                bool
                f_1635_12975_13096(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 12975, 13096);
                    return return_v;
                }


                int
                f_1635_13123_13162(ref System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates
                this_param, System.Guid
                psGuid)
                {
                    this_param.DataAckPacketReceived(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 13123, 13162);
                    return 0;
                }


                int
                f_1635_13337_13361(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.AttributeCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 13337, 13361);
                    return return_v;
                }


                string
                f_1635_13548_13603()
                {
                    var return_v = RemotingErrorIdStrings.IPCWrongAttributeCountForElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 13548, 13603);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_13430_13767(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 13430, 13767);
                    return return_v;
                }


                string
                f_1635_13845_13918(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 13845, 13918);
                    return return_v;
                }


                System.Guid
                f_1635_13959_13981(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 13959, 13981);
                    return return_v;
                }


                bool
                f_1635_14010_14130(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 14010, 14130);
                    return return_v;
                }


                int
                f_1635_14157_14204(ref System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates
                this_param, System.Guid
                psGuid)
                {
                    this_param.CommandCreationPacketReceived(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 14157, 14204);
                    return 0;
                }


                int
                f_1635_14383_14407(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.AttributeCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 14383, 14407);
                    return return_v;
                }


                string
                f_1635_14594_14649()
                {
                    var return_v = RemotingErrorIdStrings.IPCWrongAttributeCountForElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 14594, 14649);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_14476_14817(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 14476, 14817);
                    return return_v;
                }


                string
                f_1635_14895_14968(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 14895, 14968);
                    return return_v;
                }


                System.Guid
                f_1635_15009_15031(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 15009, 15031);
                    return return_v;
                }


                bool
                f_1635_15058_15182(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 15058, 15182);
                    return return_v;
                }


                int
                f_1635_15209_15253(ref System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates
                this_param, System.Guid
                psGuid)
                {
                    this_param.CommandCreationAckReceived(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 15209, 15253);
                    return 0;
                }


                int
                f_1635_15426_15450(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.AttributeCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 15426, 15450);
                    return return_v;
                }


                string
                f_1635_15637_15692()
                {
                    var return_v = RemotingErrorIdStrings.IPCWrongAttributeCountForElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 15637, 15692);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_15519_15854(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 15519, 15854);
                    return return_v;
                }


                string
                f_1635_15932_16005(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 15932, 16005);
                    return return_v;
                }


                System.Guid
                f_1635_16046_16068(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 16046, 16068);
                    return return_v;
                }


                bool
                f_1635_16097_16215(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 16097, 16215);
                    return return_v;
                }


                int
                f_1635_16242_16279(ref System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates
                this_param, System.Guid
                psGuid)
                {
                    this_param.ClosePacketReceived(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 16242, 16279);
                    return 0;
                }


                int
                f_1635_16456_16480(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.AttributeCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 16456, 16480);
                    return return_v;
                }


                string
                f_1635_16663_16718()
                {
                    var return_v = RemotingErrorIdStrings.IPCWrongAttributeCountForElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 16663, 16718);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_16549_16884(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 16549, 16884);
                    return return_v;
                }


                string
                f_1635_16962_17035(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 16962, 17035);
                    return return_v;
                }


                System.Guid
                f_1635_17076_17098(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 17076, 17098);
                    return return_v;
                }


                bool
                f_1635_17125_17247(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 17125, 17247);
                    return return_v;
                }


                int
                f_1635_17274_17314(ref System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates
                this_param, System.Guid
                psGuid)
                {
                    this_param.CloseAckPacketReceived(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 17274, 17314);
                    return 0;
                }


                int
                f_1635_17488_17512(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.AttributeCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 17488, 17512);
                    return return_v;
                }


                string
                f_1635_17695_17750()
                {
                    var return_v = RemotingErrorIdStrings.IPCWrongAttributeCountForElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 17695, 17750);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_17581_17913(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 17581, 17913);
                    return return_v;
                }


                string
                f_1635_17991_18064(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 17991, 18064);
                    return return_v;
                }


                System.Guid
                f_1635_18105_18127(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 18105, 18127);
                    return return_v;
                }


                bool
                f_1635_18156_18275(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 18156, 18275);
                    return return_v;
                }


                int
                f_1635_18302_18340(ref System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates
                this_param, System.Guid
                psGuid)
                {
                    this_param.SignalPacketReceived(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 18302, 18340);
                    return 0;
                }


                int
                f_1635_18518_18542(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.AttributeCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 18518, 18542);
                    return return_v;
                }


                string
                f_1635_18725_18780()
                {
                    var return_v = RemotingErrorIdStrings.IPCWrongAttributeCountForElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 18725, 18780);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_18611_18947(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 18611, 18947);
                    return return_v;
                }


                string
                f_1635_19025_19098(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 19025, 19098);
                    return return_v;
                }


                System.Guid
                f_1635_19139_19161(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 19139, 19161);
                    return return_v;
                }


                bool
                f_1635_19188_19311(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 19188, 19311);
                    return return_v;
                }


                int
                f_1635_19338_19379(ref System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates
                this_param, System.Guid
                psGuid)
                {
                    this_param.SignalAckPacketReceived(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 19338, 19379);
                    return 0;
                }


                string
                f_1635_19586_19634()
                {
                    var return_v = RemotingErrorIdStrings.IPCUnknownElementReceived;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 19586, 19634);
                    return return_v;
                }


                string
                f_1635_19661_19680(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.LocalName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 19661, 19680);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_19487_19681(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 19487, 19681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 9371, 19708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 9371, 19708);
            }
        }

        static System.Xml.XmlReaderSettings
        f_1635_3022_3045()
        {
            var return_v = new System.Xml.XmlReaderSettings();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 3022, 3045);
            return return_v;
        }

    }
    internal class OutOfProcessTextWriter
    {
        private TextWriter _writer;

        private bool _isStopped;

        private object _syncObject;

        internal OutOfProcessTextWriter(TextWriter writerToWrap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1635, 20412, 20604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 20119, 20126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 20150, 20160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 20186, 20212);
                this._syncObject = f_1635_20200_20212();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 20493, 20556);

                f_1635_20493_20555(writerToWrap != null, "Cannot wrap a null writer.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 20570, 20593);

                _writer = writerToWrap;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1635, 20412, 20604);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 20412, 20604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 20412, 20604);
            }
        }

        internal virtual void WriteLine(string data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 20802, 21092);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 20871, 20941) || true) && (_isStopped)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 20871, 20941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 20919, 20926);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 20871, 20941);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 20963, 20974);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 21008, 21032);

                    f_1635_21008_21031(_writer, data);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 21050, 21066);

                    f_1635_21050_21065(_writer);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 20802, 21092);

                int
                f_1635_21008_21031(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 21008, 21031);
                    return 0;
                }


                int
                f_1635_21050_21065(System.IO.TextWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 21050, 21065);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 20802, 21092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 20802, 21092);
            }
        }

        internal void StopWriting()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 21498, 21579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 21550, 21568);

                _isStopped = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 21498, 21579);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 21498, 21579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 21498, 21579);
            }
        }

        static OutOfProcessTextWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 20014, 21608);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 20014, 21608);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 20014, 21608);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1635, 20014, 21608);

        object
        f_1635_20200_20212()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 20200, 20212);
            return return_v;
        }


        int
        f_1635_20493_20555(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 20493, 20555);
            return 0;
        }

    }
}

namespace System.Management.Automation.Remoting.Client
{
    internal abstract class OutOfProcessClientSessionTransportManagerBase : BaseClientSessionTransportManager
    {
        private readonly BlockingCollection<string> _sessionMessageQueue;

        private readonly BlockingCollection<string> _commandMessageQueue;

        private PrioritySendDataCollection.OnDataAvailableCallback _onDataAvailableToSendCallback;

        private OutOfProcessUtils.DataProcessingDelegates _dataProcessingCallbacks;

        private Dictionary<Guid, OutOfProcessClientCommandTransportManager> _cmdTransportManagers;

        private Timer _closeTimeOutTimer;

        protected OutOfProcessTextWriter stdInWriter;

        protected PowerShellTraceSource _tracer;

        internal OutOfProcessClientSessionTransportManagerBase(
                    Guid runspaceId,
                    PSRemotingCryptoHelper cryptoHelper)
        : base(f_1635_22620_22630_C(runspaceId), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1635, 22464, 25799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 21868, 21888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 21943, 21963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 22033, 22063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 22227, 22248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 22273, 22291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 22337, 22348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 22391, 22398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 22670, 22800);

                _onDataAvailableToSendCallback =
                                new PrioritySendDataCollection.OnDataAvailableCallback(OnDataAvailableCallback);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 22816, 22906);

                _cmdTransportManagers = f_1635_22840_22905();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 22922, 22997);

                _dataProcessingCallbacks = f_1635_22949_22996();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 23011, 23121);

                _dataProcessingCallbacks.DataPacketReceived += new OutOfProcessUtils.DataPacketReceived(OnDataPacketReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 23135, 23254);

                _dataProcessingCallbacks.DataAckPacketReceived += new OutOfProcessUtils.DataAckPacketReceived(OnDataAckPacketReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 23268, 23411);

                _dataProcessingCallbacks.CommandCreationPacketReceived += new OutOfProcessUtils.CommandCreationPacketReceived(OnCommandCreationPacketReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 23425, 23559);

                _dataProcessingCallbacks.CommandCreationAckReceived += new OutOfProcessUtils.CommandCreationAckReceived(OnCommandCreationAckReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 23573, 23689);

                _dataProcessingCallbacks.SignalPacketReceived += new OutOfProcessUtils.SignalPacketReceived(OnSignalPacketReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 23703, 23828);

                _dataProcessingCallbacks.SignalAckPacketReceived += new OutOfProcessUtils.SignalAckPacketReceived(OnSignalAckPacketReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 23842, 23955);

                _dataProcessingCallbacks.ClosePacketReceived += new OutOfProcessUtils.ClosePacketReceived(OnClosePacketReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 23969, 24085);

                _dataProcessingCallbacks.CloseAckPacketReceived += new OutOfProcessUtils.CloseAckPacketReceived(OnCloseAckReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 24101, 24143);

                dataToBeSent.Fragmentor = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Fragmentor, 1635, 24127, 24142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 24705, 24759);

                f_1635_24705_24727().MaximumReceivedDataSize = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 24773, 24871);

                f_1635_24773_24795().MaximumReceivedObjectSize = BaseTransportManager.MaximumReceivedObjectSize;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 24923, 25024);

                _closeTimeOutTimer = f_1635_24944_25023(OnCloseTimeOutTimerElapsed, null, Timeout.Infinite, Timeout.Infinite);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 25083, 25139);

                _sessionMessageQueue = f_1635_25106_25138();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 25153, 25204);

                var
                sessionThread = f_1635_25173_25203(ProcessMessageProc)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 25218, 25266);

                sessionThread.Name = "SessionMessageProcessing";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 25280, 25314);

                sessionThread.IsBackground = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 25328, 25370);

                f_1635_25328_25369(sessionThread, _sessionMessageQueue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 25429, 25485);

                _commandMessageQueue = f_1635_25452_25484();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 25499, 25550);

                var
                commandThread = f_1635_25519_25549(ProcessMessageProc)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 25564, 25612);

                commandThread.Name = "CommandMessageProcessing";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 25626, 25660);

                commandThread.IsBackground = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 25674, 25716);

                f_1635_25674_25715(commandThread, _commandMessageQueue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 25732, 25788);

                _tracer = f_1635_25742_25787();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1635, 22464, 25799);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 22464, 25799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 22464, 25799);
            }
        }

        internal override void ConnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 25862, 26018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 25924, 26007);

                throw f_1635_25930_26006(f_1635_25958_26005());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 25862, 26018);

                string
                f_1635_25958_26005()
                {
                    var return_v = RemotingErrorIdStrings.IPCTransportConnectError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 25958, 26005);
                    return return_v;
                }


                System.NotImplementedException
                f_1635_25930_26006(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 25930, 26006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 25862, 26018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 25862, 26018);
            }
        }

        internal override void CloseAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 26117, 28246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 26177, 26216);

                bool
                shouldRaiseCloseCompleted = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 26236, 26246);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 26280, 26368) || true) && (isClosed == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 26280, 26368);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 26342, 26349);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 26280, 26368);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 26500, 26516);

                    isClosed = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 26536, 26850) || true) && (stdInWriter == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 26536, 26850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 26798, 26831);

                        shouldRaiseCloseCompleted = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 26536, 26850);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 26881, 26899);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CloseAsync(), 1635, 26881, 26898);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 26915, 27040) || true) && (shouldRaiseCloseCompleted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 26915, 27040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 26978, 27000);

                    f_1635_26978_26999(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 27018, 27025);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 26915, 27040);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 27056, 27271);

                f_1635_27056_27270(PSEventId.WSManCloseShell, PSOpcode.Disconnect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_27236_27258().ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 27287, 27544);

                f_1635_27287_27543(
                            _tracer, "OutOfProcessClientSessionTransportManager.CloseAsync, when sending close session packet, progress command count should be zero, current cmd count: " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1635_27460_27487(_cmdTransportManagers)).ToString(), 1635, 27460, 27487) + ", RunSpacePool Id : " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1635_27515_27542(this)).ToString(), 1635, 27515, 27542));

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 27675, 27746);

                    f_1635_27675_27745(                // send Close signal to the server and let it die gracefully.
                                    stdInWriter, f_1635_27697_27744(Guid.Empty));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 27840, 27895);

                    f_1635_27840_27894(
                                    // start the timer..so client can fail deterministically
                                    _closeTimeOutTimer, 60 * 1000, Timeout.Infinite);
                }
                catch (IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 27924, 28119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 28071, 28104);

                    shouldRaiseCloseCompleted = true;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 27924, 28119);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 28135, 28235) || true) && (shouldRaiseCloseCompleted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 28135, 28235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 28198, 28220);

                    f_1635_28198_28219(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 28135, 28235);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 26117, 28246);

                int
                f_1635_26978_26999(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param)
                {
                    this_param.RaiseCloseCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 26978, 26999);
                    return 0;
                }


                System.Guid
                f_1635_27236_27258()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 27236, 27258);
                    return return_v;
                }


                int
                f_1635_27056_27270(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 27056, 27270);
                    return 0;
                }


                int
                f_1635_27460_27487(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 27460, 27487);
                    return return_v;
                }


                System.Guid
                f_1635_27515_27542(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param)
                {
                    var return_v = this_param.RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 27515, 27542);
                    return return_v;
                }


                bool
                f_1635_27287_27543(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 27287, 27543);
                    return return_v;
                }


                string
                f_1635_27697_27744(System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateClosePacket(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 27697, 27744);
                    return return_v;
                }


                int
                f_1635_27675_27745(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 27675, 27745);
                    return 0;
                }


                bool
                f_1635_27840_27894(System.Threading.Timer
                this_param, int
                dueTime, int
                period)
                {
                    var return_v = this_param.Change(dueTime, period);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 27840, 27894);
                    return return_v;
                }


                int
                f_1635_28198_28219(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param)
                {
                    this_param.RaiseCloseCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 28198, 28219);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 26117, 28246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 26117, 28246);
            }
        }

        internal override BaseClientCommandTransportManager CreateClientCommandTransportManager(
                    RunspaceConnectionInfo connectionInfo,
                    ClientRemotePowerShell cmd,
                    bool noInput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 28526, 29074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 28759, 28805);

                f_1635_28759_28804(cmd != null, "Cmd cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 28821, 28968);

                OutOfProcessClientCommandTransportManager
                result = f_1635_28872_28967(cmd, noInput, this, stdInWriter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 28982, 29033);

                f_1635_28982_29032(this, f_1635_29009_29023(cmd), result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 29049, 29063);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 28526, 29074);

                int
                f_1635_28759_28804(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 28759, 28804);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                f_1635_28872_28967(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                cmd, bool
                noInput, System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                sessnTM, System.Management.Automation.Remoting.OutOfProcessTextWriter
                stdInWriter)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager(cmd, noInput, sessnTM, stdInWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 28872, 28967);
                    return return_v;
                }


                System.Guid
                f_1635_29009_29023(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 29009, 29023);
                    return return_v;
                }


                int
                f_1635_28982_29032(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param, System.Guid
                key, System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                cmdTM)
                {
                    this_param.AddCommandTransportManager(key, cmdTM);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 28982, 29032);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 28526, 29074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 28526, 29074);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 29254, 30239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 29327, 29353);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(isDisposing), 1635, 29327, 29352);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 29367, 30228) || true) && (isDisposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 29367, 30228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 29416, 29446);

                    f_1635_29416_29445(_cmdTransportManagers);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 29464, 29493);

                    f_1635_29464_29492(_closeTimeOutTimer);

                    // Stop session processing thread.
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 29609, 29647);

                        f_1635_29609_29646(_sessionMessageQueue);
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 29684, 29802);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 29684, 29802);
                        // Object already disposed.
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 29822, 29853);

                    f_1635_29822_29852(
                                    _sessionMessageQueue);

                    // Stop command processing thread.
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 29969, 30007);

                        f_1635_29969_30006(_commandMessageQueue);
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 30044, 30162);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 30044, 30162);
                        // Object already disposed.
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 30182, 30213);

                    f_1635_30182_30212(
                                    _commandMessageQueue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 29367, 30228);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 29254, 30239);

                int
                f_1635_29416_29445(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 29416, 29445);
                    return 0;
                }


                int
                f_1635_29464_29492(System.Threading.Timer
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 29464, 29492);
                    return 0;
                }


                int
                f_1635_29609_29646(System.Collections.Concurrent.BlockingCollection<string>
                this_param)
                {
                    this_param.CompleteAdding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 29609, 29646);
                    return 0;
                }


                int
                f_1635_29822_29852(System.Collections.Concurrent.BlockingCollection<string>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 29822, 29852);
                    return 0;
                }


                int
                f_1635_29969_30006(System.Collections.Concurrent.BlockingCollection<string>
                this_param)
                {
                    this_param.CompleteAdding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 29969, 30006);
                    return 0;
                }


                int
                f_1635_30182_30212(System.Collections.Concurrent.BlockingCollection<string>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 30182, 30212);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 29254, 30239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 29254, 30239);
            }
        }

        private void AddCommandTransportManager(Guid key, OutOfProcessClientCommandTransportManager cmdTM)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 30307, 31143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 30436, 30446);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 30480, 30967) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 30480, 30967);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 30732, 30919);

                        f_1635_30732_30918(                    // It is possible for this add command to occur after/during session close via
                                                               // asynchronous stop pipeline or Stop-Job.  In this case ignore the command.
                                            _tracer, "OutOfProcessClientSessionTransportManager.AddCommandTransportManager, Adding command transport on closed session, RunSpacePool Id : " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1635_30890_30917(this)).ToString(), 1635, 30890, 30917));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 30941, 30948);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 30480, 30967);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 30987, 31061);

                    f_1635_30987_31060(!f_1635_30999_31037(_cmdTransportManagers, key), "key already exists");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 31079, 31117);

                    f_1635_31079_31116(_cmdTransportManagers, key, cmdTM);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 30307, 31143);

                System.Guid
                f_1635_30890_30917(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param)
                {
                    var return_v = this_param.RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 30890, 30917);
                    return return_v;
                }


                bool
                f_1635_30732_30918(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 30732, 30918);
                    return return_v;
                }


                bool
                f_1635_30999_31037(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager>
                this_param, System.Guid
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 30999, 31037);
                    return return_v;
                }


                int
                f_1635_30987_31060(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 30987, 31060);
                    return 0;
                }


                int
                f_1635_31079_31116(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager>
                this_param, System.Guid
                key, System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 31079, 31116);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 30307, 31143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 30307, 31143);
            }
        }

        internal override void RemoveCommandTransportManager(Guid key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 31155, 31740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 31248, 31258);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 31536, 31714) || true) && (!f_1635_31541_31574(_cmdTransportManagers, key))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 31536, 31714);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 31616, 31695);

                        f_1635_31616_31694(_tracer, "key does not exist to remove from cmdTransportManagers");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 31536, 31714);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 31155, 31740);

                bool
                f_1635_31541_31574(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager>
                this_param, System.Guid
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 31541, 31574);
                    return return_v;
                }


                bool
                f_1635_31616_31694(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 31616, 31694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 31155, 31740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 31155, 31740);
            }
        }

        private OutOfProcessClientCommandTransportManager GetCommandTransportManager(Guid key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 31752, 32096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 31869, 31879);
                lock (syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 31913, 31969);

                    OutOfProcessClientCommandTransportManager
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 31987, 32038);

                    f_1635_31987_32037(_cmdTransportManagers, key, out result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 32056, 32070);

                    return result;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 31752, 32096);

                bool
                f_1635_31987_32037(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager>
                this_param, System.Guid
                key, out System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 31987, 32037);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 31752, 32096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 31752, 32096);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void OnCloseSessionCompleted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 32108, 32343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 32198, 32260);

                f_1635_32198_32259(            // stop timer
                            _closeTimeOutTimer, Timeout.Infinite, Timeout.Infinite);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 32276, 32298);

                f_1635_32276_32297(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 32312, 32332);

                f_1635_32312_32331(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 32108, 32343);

                bool
                f_1635_32198_32259(System.Threading.Timer
                this_param, int
                dueTime, int
                period)
                {
                    var return_v = this_param.Change(dueTime, period);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 32198, 32259);
                    return return_v;
                }


                int
                f_1635_32276_32297(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param)
                {
                    this_param.RaiseCloseCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 32276, 32297);
                    return 0;
                }


                int
                f_1635_32312_32331(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param)
                {
                    this_param.CleanupConnection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 32312, 32331);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 32108, 32343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 32108, 32343);
            }
        }

        protected abstract void CleanupConnection();

        private void ProcessMessageProc(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 32411, 33588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 32481, 32536);

                var
                messageQueue = state as BlockingCollection<string>
                ;

                try
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 32588, 33419) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 32588, 33419);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 32641, 32672);

                            var
                            data = f_1635_32652_32671(messageQueue)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 32746, 32808);

                                f_1635_32746_32807(data, _dataProcessingCallbacks);
                            }
                            catch (Exception exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 32853, 33400);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 32929, 33248);

                                PSRemotingTransportException
                                psrte =
                                f_1635_32995_33247(PSRemotingErrorId.IPCErrorProcessingServerData, f_1635_33143_33194(), f_1635_33229_33246(exception))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 33274, 33377);

                                f_1635_33274_33376(this, f_1635_33292_33375(psrte, TransportMethodEnum.ReceiveShellOutputEx));
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 32853, 33400);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 32588, 33419);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1635, 32588, 33419);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1635, 32588, 33419);
                    }
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 33448, 33577);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 33448, 33577);
                    // Normal session message processing thread end.
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 32411, 33588);

                string
                f_1635_32652_32671(System.Collections.Concurrent.BlockingCollection<string>
                this_param)
                {
                    var return_v = this_param.Take();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 32652, 32671);
                    return return_v;
                }


                int
                f_1635_32746_32807(string
                data, System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates
                callbacks)
                {
                    OutOfProcessUtils.ProcessData(data, callbacks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 32746, 32807);
                    return 0;
                }


                string
                f_1635_33143_33194()
                {
                    var return_v = RemotingErrorIdStrings.IPCErrorProcessingServerData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 33143, 33194);
                    return return_v;
                }


                string
                f_1635_33229_33246(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 33229, 33246);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_32995_33247(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 32995, 33247);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1635_33292_33375(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 33292, 33375);
                    return return_v;
                }


                int
                f_1635_33274_33376(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 33274, 33376);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 32411, 33588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 32411, 33588);
            }
        }

        private const string
        SESSIONDMESSAGETAG = "PSGuid='00000000-0000-0000-0000-000000000000'"
        ;

        protected void HandleOutputDataReceived(string data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 33758, 34920);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 33835, 34160) || true) && (f_1635_33839_33865(data))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 33835, 34160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 34138, 34145);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 33835, 34160);
                }

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 34308, 34670) || true) && (f_1635_34312_34380(data, SESSIONDMESSAGETAG, StringComparison.OrdinalIgnoreCase) > -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 34308, 34670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 34467, 34498);

                        f_1635_34467_34497(                    // Session message
                                            _sessionMessageQueue, data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 34308, 34670);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 34308, 34670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 34620, 34651);

                        f_1635_34620_34650(                    // Command message
                                            _commandMessageQueue, data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 34308, 34670);
                    }
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 34699, 34909);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 34699, 34909);
                    // This exception will be thrown by the BlockingCollection message queue objects
                    // after they have been closed.
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 33758, 34920);

                bool
                f_1635_33839_33865(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 33839, 33865);
                    return return_v;
                }


                int
                f_1635_34312_34380(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 34312, 34380);
                    return return_v;
                }


                int
                f_1635_34467_34497(System.Collections.Concurrent.BlockingCollection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 34467, 34497);
                    return 0;
                }


                int
                f_1635_34620_34650(System.Collections.Concurrent.BlockingCollection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 34620, 34650);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 33758, 34920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 33758, 34920);
            }
        }

        protected void HandleErrorDataReceived(string data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 34932, 35497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 35014, 35024);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 35058, 35138) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 35058, 35138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 35112, 35119);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 35058, 35138);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 35169, 35382);

                PSRemotingTransportException
                psrte = f_1635_35206_35381(PSRemotingErrorId.IPCServerProcessReportedError, f_1635_35305_35357(), data)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 35396, 35486);

                f_1635_35396_35485(this, f_1635_35414_35484(psrte, TransportMethodEnum.Unknown));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 34932, 35497);

                string
                f_1635_35305_35357()
                {
                    var return_v = RemotingErrorIdStrings.IPCServerProcessReportedError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 35305, 35357);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_35206_35381(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 35206, 35381);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1635_35414_35484(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 35414, 35484);
                    return return_v;
                }


                int
                f_1635_35396_35485(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 35396, 35485);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 34932, 35497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 34932, 35497);
            }
        }

        protected void OnExited(object sender, EventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 35509, 37658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 35585, 35651);

                TransportMethodEnum
                transportMethod = TransportMethodEnum.Unknown
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 35671, 35681);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 36006, 36139) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 36006, 36139);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 36060, 36120);

                        transportMethod = TransportMethodEnum.CloseShellOperationEx;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 36006, 36139);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 36385, 36411);

                    f_1635_36385_36410(
                                    // dont let the writer write new data as the process is exited.
                                    // Not assigning null to stdInWriter to fix the race condition between OnExited() and CloseAsync() methods.
                                    //
                                    stdInWriter);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 36579, 36611);

                string
                processDiagnosticMessage
                = default(string);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 36661, 36694);

                    var
                    jobProcess = (Process)sender
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 36712, 36980);

                    processDiagnosticMessage = f_1635_36739_36979(f_1635_36779_36817(), f_1635_36840_36859(jobProcess), f_1635_36882_36919(f_1635_36882_36907(jobProcess)), f_1635_36942_36978(f_1635_36942_36966(jobProcess)));
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 37009, 37241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 37069, 37226);

                    processDiagnosticMessage = f_1635_37096_37225(f_1635_37136_37184(), f_1635_37207_37224(exception));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 37009, 37241);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 37257, 37405);

                string
                exitErrorMsg = f_1635_37279_37404(f_1635_37315_37360(), processDiagnosticMessage)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 37419, 37555);

                var
                psrte = f_1635_37431_37554(PSRemotingErrorId.IPCServerProcessExited, exitErrorMsg)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 37569, 37647);

                f_1635_37569_37646(this, f_1635_37587_37645(psrte, transportMethod));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 35509, 37658);

                int
                f_1635_36385_36410(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param)
                {
                    this_param.StopWriting();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 36385, 36410);
                    return 0;
                }


                string
                f_1635_36779_36817()
                {
                    var return_v = RemotingErrorIdStrings.ProcessExitInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 36779, 36817);
                    return return_v;
                }


                int
                f_1635_36840_36859(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.ExitCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 36840, 36859);
                    return return_v;
                }


                System.IO.StreamReader
                f_1635_36882_36907(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StandardOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 36882, 36907);
                    return return_v;
                }


                string
                f_1635_36882_36919(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadToEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 36882, 36919);
                    return return_v;
                }


                System.IO.StreamReader
                f_1635_36942_36966(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StandardError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 36942, 36966);
                    return return_v;
                }


                string
                f_1635_36942_36978(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadToEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 36942, 36978);
                    return return_v;
                }


                string
                f_1635_36739_36979(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 36739, 36979);
                    return return_v;
                }


                string
                f_1635_37136_37184()
                {
                    var return_v = RemotingErrorIdStrings.ProcessInfoNotRecoverable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 37136, 37184);
                    return return_v;
                }


                string
                f_1635_37207_37224(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 37207, 37224);
                    return return_v;
                }


                string
                f_1635_37096_37225(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 37096, 37225);
                    return return_v;
                }


                string
                f_1635_37315_37360()
                {
                    var return_v = RemotingErrorIdStrings.IPCServerProcessExited;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 37315, 37360);
                    return return_v;
                }


                string
                f_1635_37279_37404(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 37279, 37404);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_37431_37554(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 37431, 37554);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1635_37587_37645(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 37587, 37645);
                    return return_v;
                }


                int
                f_1635_37569_37646(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 37569, 37646);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 35509, 37658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 35509, 37658);
            }
        }

        protected void SendOneItem()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 37740, 38160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 37793, 37823);

                DataPriorityType
                priorityType
                = default(DataPriorityType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 37924, 38041);

                byte[]
                data = f_1635_37938_38040(dataToBeSent, _onDataAvailableToSendCallback, out priorityType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 38055, 38149) || true) && (data != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 38055, 38149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 38105, 38134);

                    f_1635_38105_38133(this, data, priorityType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 38055, 38149);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 37740, 38160);

                byte[]
                f_1635_37938_38040(System.Management.Automation.Remoting.PrioritySendDataCollection
                this_param, System.Management.Automation.Remoting.PrioritySendDataCollection.OnDataAvailableCallback
                callback, out System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    var return_v = this_param.ReadOrRegisterCallback(callback, out priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 37938, 38040);
                    return return_v;
                }


                int
                f_1635_38105_38133(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param, byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    this_param.SendData(data, priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 38105, 38133);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 37740, 38160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 37740, 38160);
            }
        }

        private void OnDataAvailableCallback(byte[] data, DataPriorityType priorityType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 38172, 38490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 38277, 38356);

                f_1635_38277_38355(data != null, "data cannot be null in the data available callback");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 38372, 38436);

                f_1635_38372_38435(
                            tracer, "Received data to be sent from the callback.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 38450, 38479);

                f_1635_38450_38478(this, data, priorityType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 38172, 38490);

                int
                f_1635_38277_38355(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 38277, 38355);
                    return 0;
                }


                int
                f_1635_38372_38435(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 38372, 38435);
                    return 0;
                }


                int
                f_1635_38450_38478(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param, byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    this_param.SendData(data, priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 38450, 38478);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 38172, 38490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 38172, 38490);
            }
        }

        private void SendData(byte[] data, DataPriorityType priorityType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 38502, 39293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 38592, 38969);

                f_1635_38592_38968(PSEventId.WSManSendShellInputEx, PSOpcode.Send, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_38811_38833().ToString(), Guid.Empty.ToString(), f_1635_38917_38967(f_1635_38917_38928(data), f_1635_38938_38966()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 38991, 39001);

                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 39035, 39115) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 39035, 39115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 39089, 39096);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 39035, 39115);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 39135, 39267);

                    f_1635_39135_39266(
                                    stdInWriter, f_1635_39157_39265(data, priorityType, Guid.Empty));
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 38502, 39293);

                System.Guid
                f_1635_38811_38833()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 38811, 38833);
                    return return_v;
                }


                int
                f_1635_38917_38928(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 38917, 38928);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1635_38938_38966()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 38938, 38966);
                    return return_v;
                }


                string
                f_1635_38917_38967(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 38917, 38967);
                    return return_v;
                }


                int
                f_1635_38592_38968(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 38592, 38968);
                    return 0;
                }


                string
                f_1635_39157_39265(byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                streamType, System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateDataPacket(data, streamType, psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 39157, 39265);
                    return return_v;
                }


                int
                f_1635_39135_39266(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 39135, 39266);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 38502, 39293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 38502, 39293);
            }
        }

        private void OnRemoteSessionSendCompleted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 39305, 39671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 39373, 39630);

                f_1635_39373_39629(PSEventId.WSManSendShellInputExCallbackReceived, PSOpcode.Connect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_39572_39594().ToString(), Guid.Empty.ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 39646, 39660);

                f_1635_39646_39659(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 39305, 39671);

                System.Guid
                f_1635_39572_39594()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 39572, 39594);
                    return return_v;
                }


                int
                f_1635_39373_39629(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 39373, 39629);
                    return 0;
                }


                int
                f_1635_39646_39659(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 39646, 39659);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 39305, 39671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 39305, 39671);
            }
        }

        private void OnDataPacketReceived(byte[] rawData, string stream, Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 39749, 41445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 39851, 39954);

                string
                streamTemp = System.Management.Automation.Remoting.Client.WSManNativeApi.WSMAN_STREAM_ID_STDOUT
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 39968, 40218) || true) && (f_1635_39972_40065(stream, f_1635_39986_40028(DataPriorityType.PromptResponse), StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 39968, 40218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 40099, 40203);

                    streamTemp = System.Management.Automation.Remoting.Client.WSManNativeApi.WSMAN_STREAM_ID_PROMPTRESPONSE;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 39968, 40218);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 40234, 41434) || true) && (psGuid == Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 40234, 41434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 40292, 40680);

                    f_1635_40292_40679(PSEventId.WSManReceiveShellOutputExCallbackReceived, PSOpcode.Receive, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_40525_40547().ToString(), Guid.Empty.ToString(), f_1635_40625_40678(f_1635_40625_40639(rawData), f_1635_40649_40677()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 40752, 40793);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ProcessRawData(rawData, streamTemp), 1635, 40752, 40792);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 40234, 41434);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 40234, 41434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 40901, 40986);

                    OutOfProcessClientCommandTransportManager
                    cmdTM = f_1635_40951_40985(this, psGuid)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 41004, 41419) || true) && (cmdTM != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 41004, 41419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 41349, 41400);

                        f_1635_41349_41399(                    // not throwing the exception in null case as the command might have already
                                                               // closed. The RS data structure handler does not wait for the close ack before
                                                               // it clears the command transport manager..so this might happen.
                                            cmdTM, rawData, streamTemp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 41004, 41419);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 40234, 41434);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 39749, 41445);

                string
                f_1635_39986_40028(System.Management.Automation.Remoting.DataPriorityType
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 39986, 40028);
                    return return_v;
                }


                bool
                f_1635_39972_40065(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 39972, 40065);
                    return return_v;
                }


                System.Guid
                f_1635_40525_40547()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 40525, 40547);
                    return return_v;
                }


                int
                f_1635_40625_40639(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 40625, 40639);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1635_40649_40677()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 40649, 40677);
                    return return_v;
                }


                string
                f_1635_40625_40678(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 40625, 40678);
                    return return_v;
                }


                int
                f_1635_40292_40679(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 40292, 40679);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                f_1635_40951_40985(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param, System.Guid
                key)
                {
                    var return_v = this_param.GetCommandTransportManager(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 40951, 40985);
                    return return_v;
                }


                int
                f_1635_41349_41399(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param, byte[]
                rawData, string
                stream)
                {
                    this_param.OnRemoteCmdDataReceived(rawData, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 41349, 41399);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 39749, 41445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 39749, 41445);
            }
        }

        private void OnDataAckPacketReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 41457, 42306);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 41531, 42295) || true) && (psGuid == Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 41531, 42295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 41641, 41672);

                    f_1635_41641_41671(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 41531, 42295);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 41531, 42295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 41780, 41865);

                    OutOfProcessClientCommandTransportManager
                    cmdTM = f_1635_41830_41864(this, psGuid)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 41883, 42280) || true) && (cmdTM != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 41883, 42280);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 42228, 42261);

                        f_1635_42228_42260(                    // not throwing the exception in null case as the command might have already
                                                               // closed. The RS data structure handler does not wait for the close ack before
                                                               // it clears the command transport manager..so this might happen.
                                            cmdTM);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 41883, 42280);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 41531, 42295);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 41457, 42306);

                int
                f_1635_41641_41671(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param)
                {
                    this_param.OnRemoteSessionSendCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 41641, 41671);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                f_1635_41830_41864(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param, System.Guid
                key)
                {
                    var return_v = this_param.GetCommandTransportManager(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 41830, 41864);
                    return return_v;
                }


                int
                f_1635_42228_42260(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param)
                {
                    this_param.OnRemoteCmdSendCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 42228, 42260);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 41457, 42306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 41457, 42306);
            }
        }

        private void OnCommandCreationPacketReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 42318, 42628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 42400, 42617);

                throw f_1635_42406_42616(PSRemotingErrorId.IPCUnknownElementReceived, f_1635_42501_42549(), OutOfProcessUtils.PS_OUT_OF_PROC_COMMAND_TAG);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 42318, 42628);

                string
                f_1635_42501_42549()
                {
                    var return_v = RemotingErrorIdStrings.IPCUnknownElementReceived;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 42501, 42549);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_42406_42616(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 42406, 42616);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 42318, 42628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 42318, 42628);
            }
        }

        private void OnCommandCreationAckReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 42640, 43407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 42719, 42804);

                OutOfProcessClientCommandTransportManager
                cmdTM = f_1635_42769_42803(this, psGuid)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 42818, 43121) || true) && (cmdTM == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 42818, 43121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 42869, 43106);

                    throw f_1635_42875_43105(PSRemotingErrorId.IPCUnknownCommandGuid, f_1635_42970_43014(), psGuid.ToString(), OutOfProcessUtils.PS_OUT_OF_PROC_COMMAND_ACK_TAG);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 42818, 43121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 43137, 43166);

                f_1635_43137_43165(
                            cmdTM);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 43182, 43396);

                f_1635_43182_43395(
                            _tracer, "OutOfProcessClientSessionTransportManager.OnCommandCreationAckReceived, in progress command count after cmd creation ACK : " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1635_43331_43358(_cmdTransportManagers)).ToString(), 1635, 43331, 43358) + ", psGuid : " + psGuid.ToString());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 42640, 43407);

                System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                f_1635_42769_42803(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param, System.Guid
                key)
                {
                    var return_v = this_param.GetCommandTransportManager(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 42769, 42803);
                    return return_v;
                }


                string
                f_1635_42970_43014()
                {
                    var return_v = RemotingErrorIdStrings.IPCUnknownCommandGuid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 42970, 43014);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_42875_43105(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 42875, 43105);
                    return return_v;
                }


                int
                f_1635_43137_43165(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param)
                {
                    this_param.OnCreateCmdCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 43137, 43165);
                    return 0;
                }


                int
                f_1635_43331_43358(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 43331, 43358);
                    return return_v;
                }


                bool
                f_1635_43182_43395(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 43182, 43395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 42640, 43407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 42640, 43407);
            }
        }

        private void OnSignalPacketReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 43419, 43719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 43492, 43708);

                throw f_1635_43498_43707(PSRemotingErrorId.IPCUnknownElementReceived, f_1635_43593_43641(), OutOfProcessUtils.PS_OUT_OF_PROC_SIGNAL_TAG);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 43419, 43719);

                string
                f_1635_43593_43641()
                {
                    var return_v = RemotingErrorIdStrings.IPCUnknownElementReceived;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 43593, 43641);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_43498_43707(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 43498, 43707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 43419, 43719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 43419, 43719);
            }
        }

        private void OnSignalAckPacketReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 43731, 44390);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 43807, 44379) || true) && (psGuid == Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 43807, 44379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 43865, 44082);

                    throw f_1635_43871_44081(PSRemotingErrorId.IPCNoSignalForSession, f_1635_43966_44010(), OutOfProcessUtils.PS_OUT_OF_PROC_SIGNAL_ACK_TAG);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 43807, 44379);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 43807, 44379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 44148, 44233);

                    OutOfProcessClientCommandTransportManager
                    cmdTM = f_1635_44198_44232(this, psGuid)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 44251, 44364) || true) && (cmdTM != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 44251, 44364);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 44310, 44345);

                        f_1635_44310_44344(cmdTM);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 44251, 44364);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 43807, 44379);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 43731, 44390);

                string
                f_1635_43966_44010()
                {
                    var return_v = RemotingErrorIdStrings.IPCNoSignalForSession;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 43966, 44010);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_43871_44081(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 43871, 44081);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                f_1635_44198_44232(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param, System.Guid
                key)
                {
                    var return_v = this_param.GetCommandTransportManager(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 44198, 44232);
                    return return_v;
                }


                int
                f_1635_44310_44344(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param)
                {
                    this_param.OnRemoteCmdSignalCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 44310, 44344);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 43731, 44390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 43731, 44390);
            }
        }

        private void OnClosePacketReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 44402, 44700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 44474, 44689);

                throw f_1635_44480_44688(PSRemotingErrorId.IPCUnknownElementReceived, f_1635_44575_44623(), OutOfProcessUtils.PS_OUT_OF_PROC_CLOSE_TAG);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 44402, 44700);

                string
                f_1635_44575_44623()
                {
                    var return_v = RemotingErrorIdStrings.IPCUnknownElementReceived;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 44575, 44623);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_44480_44688(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 44480, 44688);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 44402, 44700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 44402, 44700);
            }
        }

        private void OnCloseAckReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 44712, 45950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 44781, 44798);

                int
                commandCount
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 44818, 44828);
                lock (syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 44862, 44905);

                    commandCount = f_1635_44877_44904(_cmdTransportManagers);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 44936, 45939) || true) && (psGuid == Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 44936, 45939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 44994, 45187);

                    f_1635_44994_45186(_tracer, "OutOfProcessClientSessionTransportManager.OnCloseAckReceived, progress command count after CLOSE ACK should be zero = " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (commandCount).ToString(), 1635, 45138, 45150) + " psGuid : " + psGuid.ToString());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 45207, 45238);

                    f_1635_45207_45237(
                                    this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 44936, 45939);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 44936, 45939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 45304, 45552);

                    f_1635_45304_45551(_tracer, "OutOfProcessClientSessionTransportManager.OnCloseAckReceived, in progress command count should be greater than zero: " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (commandCount).ToString(), 1635, 45447, 45459) + ", RunSpacePool Id : " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1635_45487_45514(this)).ToString(), 1635, 45487, 45514) + ", psGuid : " + psGuid.ToString());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 45572, 45657);

                    OutOfProcessClientCommandTransportManager
                    cmdTM = f_1635_45622_45656(this, psGuid)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 45675, 45924) || true) && (cmdTM != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 45675, 45924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 45877, 45905);

                        f_1635_45877_45904(                    // this might legitimately happen if cmd is already closed before we get an
                                                               // ACK back from server.
                                            cmdTM);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 45675, 45924);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 44936, 45939);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 44712, 45950);

                int
                f_1635_44877_44904(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 44877, 44904);
                    return return_v;
                }


                bool
                f_1635_44994_45186(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 44994, 45186);
                    return return_v;
                }


                int
                f_1635_45207_45237(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param)
                {
                    this_param.OnCloseSessionCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 45207, 45237);
                    return 0;
                }


                System.Guid
                f_1635_45487_45514(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param)
                {
                    var return_v = this_param.RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 45487, 45514);
                    return return_v;
                }


                bool
                f_1635_45304_45551(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 45304, 45551);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                f_1635_45622_45656(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param, System.Guid
                key)
                {
                    var return_v = this_param.GetCommandTransportManager(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 45622, 45656);
                    return return_v;
                }


                int
                f_1635_45877_45904(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param)
                {
                    this_param.OnCloseCmdCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 45877, 45904);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 44712, 45950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 44712, 45950);
            }
        }

        internal void OnCloseTimeOutTimerElapsed(object source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 46028, 46384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 46108, 46255);

                PSRemotingTransportException
                psrte = f_1635_46145_46254(PSRemotingErrorId.IPCCloseTimedOut, f_1635_46214_46253())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 46269, 46373);

                f_1635_46269_46372(this, f_1635_46287_46371(psrte, TransportMethodEnum.CloseShellOperationEx));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 46028, 46384);

                string
                f_1635_46214_46253()
                {
                    var return_v = RemotingErrorIdStrings.IPCCloseTimedOut;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 46214, 46253);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_46145_46254(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 46145, 46254);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1635_46287_46371(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 46287, 46371);
                    return return_v;
                }


                int
                f_1635_46269_46372(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 46269, 46372);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 46028, 46384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 46028, 46384);
            }
        }

        static OutOfProcessClientSessionTransportManagerBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 21678, 46413);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 33677, 33745);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 21678, 46413);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 21678, 46413);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1635, 21678, 46413);

        System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager>
        f_1635_22840_22905()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 22840, 22905);
            return return_v;
        }


        System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates
        f_1635_22949_22996()
        {
            var return_v = new System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 22949, 22996);
            return return_v;
        }


        System.Management.Automation.Remoting.PriorityReceiveDataCollection
        f_1635_24705_24727()
        {
            var return_v = ReceivedDataCollection;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 24705, 24727);
            return return_v;
        }


        System.Management.Automation.Remoting.PriorityReceiveDataCollection
        f_1635_24773_24795()
        {
            var return_v = ReceivedDataCollection;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 24773, 24795);
            return return_v;
        }


        System.Threading.Timer
        f_1635_24944_25023(System.Threading.TimerCallback
        callback, object?
        state, int
        dueTime, int
        period)
        {
            var return_v = new System.Threading.Timer(callback, state, dueTime, period);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 24944, 25023);
            return return_v;
        }


        System.Collections.Concurrent.BlockingCollection<string>
        f_1635_25106_25138()
        {
            var return_v = new System.Collections.Concurrent.BlockingCollection<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 25106, 25138);
            return return_v;
        }


        System.Threading.Thread
        f_1635_25173_25203(System.Threading.ParameterizedThreadStart
        start)
        {
            var return_v = new System.Threading.Thread(start);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 25173, 25203);
            return return_v;
        }


        int
        f_1635_25328_25369(System.Threading.Thread
        this_param, System.Collections.Concurrent.BlockingCollection<string>
        parameter)
        {
            this_param.Start((object)parameter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 25328, 25369);
            return 0;
        }


        System.Collections.Concurrent.BlockingCollection<string>
        f_1635_25452_25484()
        {
            var return_v = new System.Collections.Concurrent.BlockingCollection<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 25452, 25484);
            return return_v;
        }


        System.Threading.Thread
        f_1635_25519_25549(System.Threading.ParameterizedThreadStart
        start)
        {
            var return_v = new System.Threading.Thread(start);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 25519, 25549);
            return return_v;
        }


        int
        f_1635_25674_25715(System.Threading.Thread
        this_param, System.Collections.Concurrent.BlockingCollection<string>
        parameter)
        {
            this_param.Start((object)parameter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 25674, 25715);
            return 0;
        }


        System.Management.Automation.Tracing.PowerShellTraceSource
        f_1635_25742_25787()
        {
            var return_v = PowerShellTraceSourceFactory.GetTraceSource();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 25742, 25787);
            return return_v;
        }


        static System.Guid
        f_1635_22620_22630_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1635, 22464, 25799);
            return return_v;
        }

    }
    internal class OutOfProcessClientSessionTransportManager : OutOfProcessClientSessionTransportManagerBase
    {
        private Process _serverProcess;

        private NewProcessConnectionInfo _connectionInfo;

        private bool _processCreated;

        private PowerShellProcessInstance _processInstance;

        internal OutOfProcessClientSessionTransportManager(Guid runspaceId,
                    NewProcessConnectionInfo connectionInfo,
                    PSRemotingCryptoHelper cryptoHelper)
        : base(f_1635_47028_47038_C(runspaceId), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1635, 46836, 47122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 46590, 46604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 46648, 46663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 46687, 46709);
                this._processCreated = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 46754, 46770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 47078, 47111);

                _connectionInfo = connectionInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1635, 46836, 47122);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 46836, 47122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 46836, 47122);
            }
        }

        internal override void CreateAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 47742, 51768);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 47803, 48659) || true) && (_connectionInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 47803, 48659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 47864, 48460);

                    _processInstance = f_1635_47883_47906(_connectionInfo) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Runspaces.PowerShellProcessInstance>(1635, 47883, 48459) ?? f_1635_47910_48459(f_1635_47940_47965(_connectionInfo), f_1635_48059_48085(_connectionInfo), f_1635_48179_48215(_connectionInfo), f_1635_48309_48332(_connectionInfo), f_1635_48426_48458(_connectionInfo)));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 48478, 48598) || true) && (f_1635_48482_48505(_connectionInfo) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 48478, 48598);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 48555, 48579);

                        _processCreated = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 48478, 48598);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 47803, 48659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 48675, 48922);

                f_1635_48675_48921(PSEventId.WSManCreateShell, PSOpcode.Connect, PSTask.CreateRunspace, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_48887_48909().ToString());

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 48980, 48990);
                    lock (syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 49032, 49124) || true) && (isClosed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 49032, 49124);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 49094, 49101);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 49032, 49124);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 49210, 49252);

                        _serverProcess = f_1635_49227_49251(_processInstance);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 49276, 49494) || true) && (f_1635_49280_49309(_processInstance) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 49276, 49494);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 49367, 49405);

                            f_1635_49367_49404(f_1635_49367_49396(_processInstance));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 49431, 49471);

                            f_1635_49431_49470(f_1635_49431_49460(_processInstance));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 49276, 49494);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 49518, 49561);

                        stdInWriter = f_1635_49532_49560(_processInstance);
                        // if (stdInWriter == null)
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 49659, 49747);

                            _serverProcess.OutputDataReceived += new DataReceivedEventHandler(OnOutputDataReceived);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 49773, 49859);

                            _serverProcess.ErrorDataReceived += new DataReceivedEventHandler(OnErrorDataReceived);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 49906, 49958);

                        _serverProcess.Exited += new EventHandler(OnExited);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 50029, 50054);

                        f_1635_50029_50053(
                                            // serverProcess.Start();
                                            _processInstance);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 50078, 50267) || true) && (stdInWriter != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 50078, 50267);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 50151, 50184);

                            f_1635_50151_50183(_serverProcess);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 50210, 50244);

                            f_1635_50210_50243(_serverProcess);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 50078, 50267);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 50359, 50396);

                        f_1635_50359_50395(
                                            // Start asynchronous reading of output/errors
                                            _serverProcess);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 50418, 50454);

                        f_1635_50418_50453(_serverProcess);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 50478, 50549);

                        stdInWriter = f_1635_50492_50548(f_1635_50519_50547(_serverProcess));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 50571, 50614);

                        _processInstance.StdInWriter = stdInWriter;
                    }
                }
                catch (System.ComponentModel.Win32Exception w32e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 50662, 51182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 50744, 50908);

                    PSRemotingTransportException
                    psrte = f_1635_50781_50907(w32e, f_1635_50820_50871(), f_1635_50894_50906(w32e))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 50926, 50957);

                    psrte.ErrorCode = f_1635_50944_50956(w32e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 50975, 51095);

                    TransportErrorOccuredEventArgs
                    eventargs = f_1635_51018_51094(psrte, TransportMethodEnum.CreateShellEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 51113, 51142);

                    f_1635_51113_51141(this, eventargs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 51160, 51167);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 50662, 51182);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 51196, 51693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 51248, 51468);

                    PSRemotingTransportException
                    psrte = f_1635_51285_51467(PSRemotingErrorId.IPCExceptionLaunchingProcess, f_1635_51383_51434(), f_1635_51457_51466(e))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 51486, 51606);

                    TransportErrorOccuredEventArgs
                    eventargs = f_1635_51529_51605(psrte, TransportMethodEnum.CreateShellEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 51624, 51653);

                    f_1635_51624_51652(this, eventargs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 51671, 51678);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 51196, 51693);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 51743, 51757);

                f_1635_51743_51756(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 47742, 51768);

                System.Management.Automation.Runspaces.PowerShellProcessInstance
                f_1635_47883_47906(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.Process;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 47883, 47906);
                    return return_v;
                }


                System.Version
                f_1635_47940_47965(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.PSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 47940, 47965);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1635_48059_48085(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.Credential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 48059, 48085);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1635_48179_48215(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.InitializationScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 48179, 48215);
                    return return_v;
                }


                bool
                f_1635_48309_48332(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.RunAs32;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 48309, 48332);
                    return return_v;
                }


                string
                f_1635_48426_48458(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.WorkingDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 48426, 48458);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PowerShellProcessInstance
                f_1635_47910_48459(System.Version
                powerShellVersion, System.Management.Automation.PSCredential
                credential, System.Management.Automation.ScriptBlock
                initializationScript, bool
                useWow64, string
                workingDirectory)
                {
                    var return_v = new System.Management.Automation.Runspaces.PowerShellProcessInstance(powerShellVersion, credential, initializationScript, useWow64, workingDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 47910, 48459);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PowerShellProcessInstance
                f_1635_48482_48505(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.Process;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 48482, 48505);
                    return return_v;
                }


                System.Guid
                f_1635_48887_48909()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 48887, 48909);
                    return return_v;
                }


                int
                f_1635_48675_48921(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 48675, 48921);
                    return 0;
                }


                System.Diagnostics.Process
                f_1635_49227_49251(System.Management.Automation.Runspaces.PowerShellProcessInstance
                this_param)
                {
                    var return_v = this_param.Process;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 49227, 49251);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1635_49280_49309(System.Management.Automation.Runspaces.PowerShellProcessInstance
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 49280, 49309);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1635_49367_49396(System.Management.Automation.Runspaces.PowerShellProcessInstance
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 49367, 49396);
                    return return_v;
                }


                int
                f_1635_49367_49404(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 49367, 49404);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1635_49431_49460(System.Management.Automation.Runspaces.PowerShellProcessInstance
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 49431, 49460);
                    return return_v;
                }


                int
                f_1635_49431_49470(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 49431, 49470);
                    return 0;
                }


                System.Management.Automation.Remoting.OutOfProcessTextWriter
                f_1635_49532_49560(System.Management.Automation.Runspaces.PowerShellProcessInstance
                this_param)
                {
                    var return_v = this_param.StdInWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 49532, 49560);
                    return return_v;
                }


                int
                f_1635_50029_50053(System.Management.Automation.Runspaces.PowerShellProcessInstance
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 50029, 50053);
                    return 0;
                }


                int
                f_1635_50151_50183(System.Diagnostics.Process
                this_param)
                {
                    this_param.CancelErrorRead();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 50151, 50183);
                    return 0;
                }


                int
                f_1635_50210_50243(System.Diagnostics.Process
                this_param)
                {
                    this_param.CancelOutputRead();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 50210, 50243);
                    return 0;
                }


                int
                f_1635_50359_50395(System.Diagnostics.Process
                this_param)
                {
                    this_param.BeginOutputReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 50359, 50395);
                    return 0;
                }


                int
                f_1635_50418_50453(System.Diagnostics.Process
                this_param)
                {
                    this_param.BeginErrorReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 50418, 50453);
                    return 0;
                }


                System.IO.StreamWriter
                f_1635_50519_50547(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StandardInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 50519, 50547);
                    return return_v;
                }


                System.Management.Automation.Remoting.OutOfProcessTextWriter
                f_1635_50492_50548(System.IO.StreamWriter
                writerToWrap)
                {
                    var return_v = new System.Management.Automation.Remoting.OutOfProcessTextWriter((System.IO.TextWriter)writerToWrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 50492, 50548);
                    return return_v;
                }


                string
                f_1635_50820_50871()
                {
                    var return_v = RemotingErrorIdStrings.IPCExceptionLaunchingProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 50820, 50871);
                    return return_v;
                }


                string
                f_1635_50894_50906(System.ComponentModel.Win32Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 50894, 50906);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_50781_50907(System.ComponentModel.Win32Exception
                innerException, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException((System.Exception)innerException, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 50781, 50907);
                    return return_v;
                }


                int
                f_1635_50944_50956(System.ComponentModel.Win32Exception
                this_param)
                {
                    var return_v = this_param.HResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 50944, 50956);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1635_51018_51094(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 51018, 51094);
                    return return_v;
                }


                int
                f_1635_51113_51141(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 51113, 51141);
                    return 0;
                }


                string
                f_1635_51383_51434()
                {
                    var return_v = RemotingErrorIdStrings.IPCExceptionLaunchingProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 51383, 51434);
                    return return_v;
                }


                string
                f_1635_51457_51466(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 51457, 51466);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_51285_51467(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 51285, 51467);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1635_51529_51605(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 51529, 51605);
                    return return_v;
                }


                int
                f_1635_51624_51652(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 51624, 51652);
                    return 0;
                }


                int
                f_1635_51743_51756(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManager
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 51743, 51756);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 47742, 51768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 47742, 51768);
            }
        }

        internal override void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 51943, 52383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 52016, 52042);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(isDisposing), 1635, 52016, 52041);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 52056, 52372) || true) && (isDisposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 52056, 52372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 52105, 52125);

                    f_1635_52105_52124(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 52143, 52357) || true) && (_serverProcess != null && (DynAbs.Tracing.TraceSender.Expression_True(1635, 52147, 52188) && _processCreated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 52143, 52357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 52313, 52338);

                        f_1635_52313_52337(                    // null can happen if Dispose is called before ConnectAsync()
                                            _serverProcess);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 52143, 52357);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 52056, 52372);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 51943, 52383);

                int
                f_1635_52105_52124(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManager
                this_param)
                {
                    this_param.KillServerProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 52105, 52124);
                    return 0;
                }


                int
                f_1635_52313_52337(System.Diagnostics.Process
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 52313, 52337);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 51943, 52383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 51943, 52383);
            }
        }

        protected override void CleanupConnection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 52395, 52537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 52506, 52526);

                f_1635_52506_52525(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 52395, 52537);

                int
                f_1635_52506_52525(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManager
                this_param)
                {
                    this_param.KillServerProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 52506, 52525);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 52395, 52537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 52395, 52537);
            }
        }

        private void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 52605, 52747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 52703, 52736);

                f_1635_52703_52735(this, f_1635_52728_52734(e));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 52605, 52747);

                string
                f_1635_52728_52734(System.Diagnostics.DataReceivedEventArgs
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 52728, 52734);
                    return return_v;
                }


                int
                f_1635_52703_52735(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManager
                this_param, string
                data)
                {
                    this_param.HandleOutputDataReceived(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 52703, 52735);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 52605, 52747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 52605, 52747);
            }
        }

        private void OnErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 52759, 52899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 52856, 52888);

                f_1635_52856_52887(this, f_1635_52880_52886(e));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 52759, 52899);

                string
                f_1635_52880_52886(System.Diagnostics.DataReceivedEventArgs
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 52880, 52886);
                    return return_v;
                }


                int
                f_1635_52856_52887(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManager
                this_param, string
                data)
                {
                    this_param.HandleErrorDataReceived(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 52856, 52887);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 52759, 52899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 52759, 52899);
            }
        }

        private void KillServerProcess()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 52967, 54588);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 53024, 53185) || true) && (_serverProcess == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 53024, 53185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 53163, 53170);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 53024, 53185);
                }

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 53237, 53838) || true) && (f_1635_53241_53266_M(!_serverProcess.HasExited))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 53237, 53838);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 53308, 53342);

                        _serverProcess.Exited -= OnExited;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 53366, 53599) || true) && (_processCreated)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 53366, 53599);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 53435, 53469);

                            f_1635_53435_53468(_serverProcess);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 53495, 53528);

                            f_1635_53495_53527(_serverProcess);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 53554, 53576);

                            f_1635_53554_53575(_serverProcess);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 53366, 53599);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 53623, 53711);

                        _serverProcess.OutputDataReceived -= new DataReceivedEventHandler(OnOutputDataReceived);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 53733, 53819);

                        _serverProcess.ErrorDataReceived -= new DataReceivedEventHandler(OnErrorDataReceived);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 53237, 53838);
                    }
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 53867, 54516);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 54212, 54274);

                        Process
                        newHandle = f_1635_54232_54273(f_1635_54255_54272(_serverProcess))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 54371, 54409) || true) && (_processCreated)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 54371, 54409);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 54392, 54409);

                            f_1635_54392_54408(newHandle);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 54371, 54409);
                        }
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 54446, 54501);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 54446, 54501);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 53867, 54516);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 54530, 54577);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 54530, 54577);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 52967, 54588);

                bool
                f_1635_53241_53266_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 53241, 53266);
                    return return_v;
                }


                int
                f_1635_53435_53468(System.Diagnostics.Process
                this_param)
                {
                    this_param.CancelOutputRead();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 53435, 53468);
                    return 0;
                }


                int
                f_1635_53495_53527(System.Diagnostics.Process
                this_param)
                {
                    this_param.CancelErrorRead();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 53495, 53527);
                    return 0;
                }


                int
                f_1635_53554_53575(System.Diagnostics.Process
                this_param)
                {
                    this_param.Kill();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 53554, 53575);
                    return 0;
                }


                int
                f_1635_54255_54272(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 54255, 54272);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1635_54232_54273(int
                processId)
                {
                    var return_v = Process.GetProcessById(processId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 54232, 54273);
                    return return_v;
                }


                int
                f_1635_54392_54408(System.Diagnostics.Process
                this_param)
                {
                    this_param.Kill();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 54392, 54408);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 52967, 54588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 52967, 54588);
            }
        }

        static OutOfProcessClientSessionTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 46421, 54617);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 46421, 54617);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 46421, 54617);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1635, 46421, 54617);

        static System.Guid
        f_1635_47028_47038_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1635, 46836, 47122);
            return return_v;
        }

    }
    internal abstract class HyperVSocketClientSessionTransportManagerBase : OutOfProcessClientSessionTransportManagerBase
    {
        protected RemoteSessionHyperVSocketClient _client;

        private const string
        _threadName = "HyperVSocketTransport Reader Thread"
        ;

        internal HyperVSocketClientSessionTransportManagerBase(
                    Guid runspaceId,
                    PSRemotingCryptoHelper cryptoHelper)
        : base(f_1635_55138_55148_C(runspaceId), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1635, 54982, 55176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 54825, 54832);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1635, 54982, 55176);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 54982, 55176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 54982, 55176);
            }
        }

        internal override void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 55239, 55527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 55312, 55338);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(isDisposing), 1635, 55312, 55337);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 55354, 55516) || true) && (isDisposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 55354, 55516);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 55403, 55501) || true) && (_client != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 55403, 55501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 55464, 55482);

                        f_1635_55464_55481(_client);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 55403, 55501);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 55354, 55516);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 55239, 55527);

                int
                f_1635_55464_55481(System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 55464, 55481);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 55239, 55527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 55239, 55527);
            }
        }

        protected override void CleanupConnection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 55539, 55634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 55607, 55623);

                f_1635_55607_55622(_client);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 55539, 55634);

                int
                f_1635_55607_55622(System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 55607, 55622);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 55539, 55634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 55539, 55634);
            }
        }

        protected void StartReaderThread(
                    StreamReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 55705, 55996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 55797, 55851);

                Thread
                readerThread = f_1635_55819_55850(ProcessReaderThread)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 55865, 55897);

                readerThread.Name = _threadName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 55911, 55944);

                readerThread.IsBackground = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 55958, 55985);

                f_1635_55958_55984(readerThread, reader);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 55705, 55996);

                System.Threading.Thread
                f_1635_55819_55850(System.Threading.ParameterizedThreadStart
                start)
                {
                    var return_v = new System.Threading.Thread(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 55819, 55850);
                    return return_v;
                }


                int
                f_1635_55958_55984(System.Threading.Thread
                this_param, System.IO.StreamReader
                parameter)
                {
                    this_param.Start((object)parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 55958, 55984);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 55705, 55996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 55705, 55996);
            }
        }

        protected void ProcessReaderThread(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 56008, 59040);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 56117, 56161);

                    StreamReader
                    reader = state as StreamReader
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 56179, 56232);

                    f_1635_56179_56231(reader != null, "Reader cannot be null.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 56291, 56305);

                    f_1635_56291_56304(this);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 56364, 57900) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 56364, 57900);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 56417, 56449);

                            string
                            data = f_1635_56431_56448(reader)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 56471, 57217) || true) && (data == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 56471, 57217);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 56714, 57033);

                                PSRemotingTransportException
                                psrte = f_1635_56751_57032(PSRemotingErrorId.IPCServerProcessReportedError, f_1635_56892_56944(), f_1635_56975_57031())
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 57059, 57162);

                                f_1635_57059_57161(this, f_1635_57077_57160(psrte, TransportMethodEnum.ReceiveShellOutputEx));
                                DynAbs.Tracing.TraceSender.TraceBreak(1635, 57188, 57194);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 56471, 57217);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 57241, 57881) || true) && (f_1635_57245_57383(data, f_1635_57261_57346(), StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 57241, 57881);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 57492, 57620);

                                string
                                errorData = f_1635_57511_57619(data, f_1635_57526_57618(f_1635_57526_57611()))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 57646, 57681);

                                f_1635_57646_57680(this, errorData);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 57241, 57881);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 57241, 57881);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 57827, 57858);

                                f_1635_57827_57857(this, data);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 57241, 57881);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 56364, 57900);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1635, 56364, 57900);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1635, 56364, 57900);
                    }
                }
                catch (ObjectDisposedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 57929, 58036);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 57929, 58036);
                    // Normal reader thread end.
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 58050, 59029);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 58102, 58288) || true) && (e is ArgumentOutOfRangeException)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 58102, 58288);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 58180, 58269);

                        f_1635_58180_58268(false, "Need to adjust transport fragmentor to accomodate read buffer size.");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 58102, 58288);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 58308, 58373);

                    string
                    errorMsg = (DynAbs.Tracing.TraceSender.Conditional_F1(1635, 58326, 58345) || (((f_1635_58327_58336(e) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1635, 58348, 58357)) || DynAbs.Tracing.TraceSender.Conditional_F3(1635, 58360, 58372))) ? f_1635_58348_58357(e) : string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 58391, 58578);

                    f_1635_58391_58577(_tracer, "HyperVSocketClientSessionTransportManager", "StartReaderThread", Guid.Empty, "Transport manager reader thread ended with error: {0}", errorMsg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 58598, 58893);

                    PSRemotingTransportException
                    psrte = f_1635_58635_58892(PSRemotingErrorId.IPCServerProcessReportedError, f_1635_58760_58812(), f_1635_58835_58891())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 58911, 59014);

                    f_1635_58911_59013(this, f_1635_58929_59012(psrte, TransportMethodEnum.ReceiveShellOutputEx));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 58050, 59029);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 56008, 59040);

                int
                f_1635_56179_56231(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 56179, 56231);
                    return 0;
                }


                int
                f_1635_56291_56304(System.Management.Automation.Remoting.Client.HyperVSocketClientSessionTransportManagerBase
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 56291, 56304);
                    return 0;
                }


                string?
                f_1635_56431_56448(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 56431, 56448);
                    return return_v;
                }


                string
                f_1635_56892_56944()
                {
                    var return_v = RemotingErrorIdStrings.IPCServerProcessReportedError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 56892, 56944);
                    return return_v;
                }


                string
                f_1635_56975_57031()
                {
                    var return_v = RemotingErrorIdStrings.HyperVSocketTransportProcessEnded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 56975, 57031);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_56751_57032(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 56751, 57032);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1635_57077_57160(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 57077, 57160);
                    return return_v;
                }


                int
                f_1635_57059_57161(System.Management.Automation.Remoting.Client.HyperVSocketClientSessionTransportManagerBase
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 57059, 57161);
                    return 0;
                }


                string
                f_1635_57261_57346()
                {
                    var return_v = System.Management.Automation.Remoting.Server.HyperVSocketErrorTextWriter.ErrorPrepend;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 57261, 57346);
                    return return_v;
                }


                bool
                f_1635_57245_57383(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 57245, 57383);
                    return return_v;
                }


                string
                f_1635_57526_57611()
                {
                    var return_v = System.Management.Automation.Remoting.Server.HyperVSocketErrorTextWriter.ErrorPrepend;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 57526, 57611);
                    return return_v;
                }


                int
                f_1635_57526_57618(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 57526, 57618);
                    return return_v;
                }


                string
                f_1635_57511_57619(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 57511, 57619);
                    return return_v;
                }


                int
                f_1635_57646_57680(System.Management.Automation.Remoting.Client.HyperVSocketClientSessionTransportManagerBase
                this_param, string
                data)
                {
                    this_param.HandleErrorDataReceived(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 57646, 57680);
                    return 0;
                }


                int
                f_1635_57827_57857(System.Management.Automation.Remoting.Client.HyperVSocketClientSessionTransportManagerBase
                this_param, string
                data)
                {
                    this_param.HandleOutputDataReceived(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 57827, 57857);
                    return 0;
                }


                int
                f_1635_58180_58268(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 58180, 58268);
                    return 0;
                }


                string
                f_1635_58327_58336(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 58327, 58336);
                    return return_v;
                }


                string
                f_1635_58348_58357(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 58348, 58357);
                    return return_v;
                }


                int
                f_1635_58391_58577(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 58391, 58577);
                    return 0;
                }


                string
                f_1635_58760_58812()
                {
                    var return_v = RemotingErrorIdStrings.IPCServerProcessReportedError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 58760, 58812);
                    return return_v;
                }


                string
                f_1635_58835_58891()
                {
                    var return_v = RemotingErrorIdStrings.HyperVSocketTransportProcessEnded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 58835, 58891);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_58635_58892(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 58635, 58892);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1635_58929_59012(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 58929, 59012);
                    return return_v;
                }


                int
                f_1635_58911_59013(System.Management.Automation.Remoting.Client.HyperVSocketClientSessionTransportManagerBase
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 58911, 59013);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 56008, 59040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 56008, 59040);
            }
        }

        static HyperVSocketClientSessionTransportManagerBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 54625, 59069);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 54864, 54915);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 54625, 59069);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 54625, 59069);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1635, 54625, 59069);

        static System.Guid
        f_1635_55138_55148_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1635, 54982, 55176);
            return return_v;
        }

    }
    internal sealed class VMHyperVSocketClientSessionTransportManager : HyperVSocketClientSessionTransportManagerBase
    {
        private Guid _vmGuid;

        private string _configurationName;

        private VMConnectionInfo _connectionInfo;

        private NetworkCredential _networkCredential;

        internal VMHyperVSocketClientSessionTransportManager(
                    VMConnectionInfo connectionInfo,
                    Guid runspaceId,
                    PSRemotingCryptoHelper cryptoHelper,
                    Guid vmGuid,
                    string configurationName)
        : base(f_1635_59741_59751_C(runspaceId), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1635, 59476, 60363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 59285, 59303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 59339, 59354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 59391, 59409);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 59791, 59918) || true) && (connectionInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 59791, 59918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 59851, 59903);

                    throw f_1635_59857_59902("connectionInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 59791, 59918);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 59934, 59967);

                _connectionInfo = connectionInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 59981, 59998);

                _vmGuid = vmGuid;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 60012, 60051);

                _configurationName = configurationName;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 60067, 60352) || true) && (f_1635_60071_60096(connectionInfo) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 60067, 60352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 60138, 60201);

                    _networkCredential = f_1635_60159_60200();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 60067, 60352);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 60067, 60352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 60267, 60337);

                    _networkCredential = f_1635_60288_60336(f_1635_60288_60313(connectionInfo));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 60067, 60352);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1635, 59476, 60363);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 59476, 60363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 59476, 60363);
            }
        }

        internal override void CreateAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 60592, 62183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 60653, 60714);

                _client = f_1635_60663_60713(_vmGuid, true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 60728, 61215) || true) && (!f_1635_60733_60794(_client, _networkCredential, _configurationName, true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 60728, 61215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 60828, 60846);

                    f_1635_60828_60845(_client);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 60864, 61200);

                    throw f_1635_60870_61199(f_1635_60924_61017(f_1635_60971_61016()), null, f_1635_61067_61118(PSRemotingErrorId.VMSessionConnectFailed), ErrorCategory.InvalidOperation, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 60728, 61215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 61338, 61356);

                f_1635_61338_61355(
                            // TODO: remove below 3 lines when Hyper-V socket duplication is supported in .NET framework.
                            _client);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 61370, 61432);

                _client = f_1635_61380_61431(_vmGuid, false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 61446, 61934) || true) && (!f_1635_61451_61513(_client, _networkCredential, _configurationName, false))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 61446, 61934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 61547, 61565);

                    f_1635_61547_61564(_client);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 61583, 61919);

                    throw f_1635_61589_61918(f_1635_61643_61736(f_1635_61690_61735()), null, f_1635_61786_61837(PSRemotingErrorId.VMSessionConnectFailed), ErrorCategory.InvalidOperation, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 61446, 61934);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 62000, 62061);

                stdInWriter = f_1635_62014_62060(f_1635_62041_62059(_client));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 62134, 62172);

                f_1635_62134_62171(this, f_1635_62152_62170(_client));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 60592, 62183);

                System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                f_1635_60663_60713(System.Guid
                vmId, bool
                isFirstConnection)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient(vmId, isFirstConnection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 60663, 60713);
                    return return_v;
                }


                bool
                f_1635_60733_60794(System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                this_param, System.Net.NetworkCredential
                networkCredential, string
                configurationName, bool
                isFirstConnection)
                {
                    var return_v = this_param.Connect(networkCredential, configurationName, isFirstConnection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 60733, 60794);
                    return return_v;
                }


                int
                f_1635_60828_60845(System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 60828, 60845);
                    return 0;
                }


                string
                f_1635_60971_61016()
                {
                    var return_v = RemotingErrorIdStrings.VMSessionConnectFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 60971, 61016);
                    return return_v;
                }


                string
                f_1635_60924_61017(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 60924, 61017);
                    return return_v;
                }


                string
                f_1635_61067_61118(System.Management.Automation.Remoting.PSRemotingErrorId
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 61067, 61118);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1635_60870_61199(string
                message, System.Exception
                innerException, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                target)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message, innerException, errorId, errorCategory, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 60870, 61199);
                    return return_v;
                }


                int
                f_1635_61338_61355(System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 61338, 61355);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                f_1635_61380_61431(System.Guid
                vmId, bool
                isFirstConnection)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient(vmId, isFirstConnection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 61380, 61431);
                    return return_v;
                }


                bool
                f_1635_61451_61513(System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                this_param, System.Net.NetworkCredential
                networkCredential, string
                configurationName, bool
                isFirstConnection)
                {
                    var return_v = this_param.Connect(networkCredential, configurationName, isFirstConnection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 61451, 61513);
                    return return_v;
                }


                int
                f_1635_61547_61564(System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 61547, 61564);
                    return 0;
                }


                string
                f_1635_61690_61735()
                {
                    var return_v = RemotingErrorIdStrings.VMSessionConnectFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 61690, 61735);
                    return return_v;
                }


                string
                f_1635_61643_61736(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 61643, 61736);
                    return return_v;
                }


                string
                f_1635_61786_61837(System.Management.Automation.Remoting.PSRemotingErrorId
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 61786, 61837);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1635_61589_61918(string
                message, System.Exception
                innerException, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                target)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message, innerException, errorId, errorCategory, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 61589, 61918);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1635_62041_62059(System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                this_param)
                {
                    var return_v = this_param.TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 62041, 62059);
                    return return_v;
                }


                System.Management.Automation.Remoting.OutOfProcessTextWriter
                f_1635_62014_62060(System.IO.StreamWriter
                writerToWrap)
                {
                    var return_v = new System.Management.Automation.Remoting.OutOfProcessTextWriter((System.IO.TextWriter)writerToWrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 62014, 62060);
                    return return_v;
                }


                System.IO.StreamReader
                f_1635_62152_62170(System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                this_param)
                {
                    var return_v = this_param.TextReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 62152, 62170);
                    return return_v;
                }


                int
                f_1635_62134_62171(System.Management.Automation.Remoting.Client.VMHyperVSocketClientSessionTransportManager
                this_param, System.IO.StreamReader
                reader)
                {
                    this_param.StartReaderThread(reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 62134, 62171);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 60592, 62183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 60592, 62183);
            }
        }

        static VMHyperVSocketClientSessionTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 59077, 62212);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 59077, 62212);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 59077, 62212);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1635, 59077, 62212);

        System.Management.Automation.PSArgumentNullException
        f_1635_59857_59902(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 59857, 59902);
            return return_v;
        }


        System.Management.Automation.PSCredential
        f_1635_60071_60096(System.Management.Automation.Runspaces.VMConnectionInfo
        this_param)
        {
            var return_v = this_param.Credential;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 60071, 60096);
            return return_v;
        }


        System.Net.NetworkCredential
        f_1635_60159_60200()
        {
            var return_v = CredentialCache.DefaultNetworkCredentials;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 60159, 60200);
            return return_v;
        }


        System.Management.Automation.PSCredential
        f_1635_60288_60313(System.Management.Automation.Runspaces.VMConnectionInfo
        this_param)
        {
            var return_v = this_param.Credential;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 60288, 60313);
            return return_v;
        }


        System.Net.NetworkCredential
        f_1635_60288_60336(System.Management.Automation.PSCredential
        this_param)
        {
            var return_v = this_param.GetNetworkCredential();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 60288, 60336);
            return return_v;
        }


        static System.Guid
        f_1635_59741_59751_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1635, 59476, 60363);
            return return_v;
        }

    }
    internal sealed class ContainerHyperVSocketClientSessionTransportManager : HyperVSocketClientSessionTransportManagerBase
    {
        private Guid _targetGuid;

        private ContainerConnectionInfo _connectionInfo;

        internal ContainerHyperVSocketClientSessionTransportManager(
                    ContainerConnectionInfo connectionInfo,
                    Guid runspaceId,
                    PSRemotingCryptoHelper cryptoHelper,
                    Guid targetGuid)
        : base(f_1635_62852_62862_C(runspaceId), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1635, 62608, 63128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 62526, 62541);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 62902, 63029) || true) && (connectionInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 62902, 63029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 62962, 63014);

                    throw f_1635_62968_63013("connectionInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 62902, 63029);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 63045, 63078);

                _connectionInfo = connectionInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 63092, 63117);

                _targetGuid = targetGuid;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1635, 62608, 63128);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 62608, 63128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 62608, 63128);
            }
        }

        internal override void CreateAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 63357, 64235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 63418, 63490);

                _client = f_1635_63428_63489(_targetGuid, false, true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 63504, 63986) || true) && (!f_1635_63509_63551(_client, null, string.Empty, false))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 63504, 63986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 63585, 63603);

                    f_1635_63585_63602(_client);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 63621, 63971);

                    throw f_1635_63627_63970(f_1635_63681_63781(f_1635_63728_63780()), null, f_1635_63831_63889(PSRemotingErrorId.ContainerSessionConnectFailed), ErrorCategory.InvalidOperation, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 63504, 63986);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 64052, 64113);

                stdInWriter = f_1635_64066_64112(f_1635_64093_64111(_client));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 64186, 64224);

                f_1635_64186_64223(this, f_1635_64204_64222(_client));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 63357, 64235);

                System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                f_1635_63428_63489(System.Guid
                vmId, bool
                isFirstConnection, bool
                isContainer)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient(vmId, isFirstConnection, isContainer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 63428, 63489);
                    return return_v;
                }


                bool
                f_1635_63509_63551(System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                this_param, System.Net.NetworkCredential
                networkCredential, string
                configurationName, bool
                isFirstConnection)
                {
                    var return_v = this_param.Connect(networkCredential, configurationName, isFirstConnection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 63509, 63551);
                    return return_v;
                }


                int
                f_1635_63585_63602(System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 63585, 63602);
                    return 0;
                }


                string
                f_1635_63728_63780()
                {
                    var return_v = RemotingErrorIdStrings.ContainerSessionConnectFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 63728, 63780);
                    return return_v;
                }


                string
                f_1635_63681_63781(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 63681, 63781);
                    return return_v;
                }


                string
                f_1635_63831_63889(System.Management.Automation.Remoting.PSRemotingErrorId
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 63831, 63889);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1635_63627_63970(string
                message, System.Exception
                innerException, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                target)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message, innerException, errorId, errorCategory, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 63627, 63970);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1635_64093_64111(System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                this_param)
                {
                    var return_v = this_param.TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 64093, 64111);
                    return return_v;
                }


                System.Management.Automation.Remoting.OutOfProcessTextWriter
                f_1635_64066_64112(System.IO.StreamWriter
                writerToWrap)
                {
                    var return_v = new System.Management.Automation.Remoting.OutOfProcessTextWriter((System.IO.TextWriter)writerToWrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 64066, 64112);
                    return return_v;
                }


                System.IO.StreamReader
                f_1635_64204_64222(System.Management.Automation.Remoting.RemoteSessionHyperVSocketClient
                this_param)
                {
                    var return_v = this_param.TextReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 64204, 64222);
                    return return_v;
                }


                int
                f_1635_64186_64223(System.Management.Automation.Remoting.Client.ContainerHyperVSocketClientSessionTransportManager
                this_param, System.IO.StreamReader
                reader)
                {
                    this_param.StartReaderThread(reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 64186, 64223);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 63357, 64235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 63357, 64235);
            }
        }

        static ContainerHyperVSocketClientSessionTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 62220, 64264);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 62220, 64264);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 62220, 64264);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1635, 62220, 64264);

        System.Management.Automation.PSArgumentNullException
        f_1635_62968_63013(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 62968, 63013);
            return return_v;
        }


        static System.Guid
        f_1635_62852_62862_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1635, 62608, 63128);
            return return_v;
        }

    }
    internal sealed class SSHClientSessionTransportManager : OutOfProcessClientSessionTransportManagerBase
    {
        private SSHConnectionInfo _connectionInfo;

        private int _sshProcessId;

        private StreamWriter _stdInWriter;

        private StreamReader _stdOutReader;

        private StreamReader _stdErrReader;

        private bool _connectionEstablished;

        private const string
        _threadName = "SSHTransport Reader Thread"
        ;

        internal SSHClientSessionTransportManager(
                    SSHConnectionInfo connectionInfo,
                    Guid runspaceId,
                    PSRemotingCryptoHelper cryptoHelper)
        : base(f_1635_65003_65013_C(runspaceId), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1635, 64813, 65193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 64441, 64456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 64479, 64492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 64524, 64536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 64568, 64581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 64613, 64626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 64650, 64672);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 65053, 65133) || true) && (connectionInfo == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 65053, 65133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 65083, 65131);

                    throw f_1635_65089_65130("connectionInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 65053, 65133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 65149, 65182);

                _connectionInfo = connectionInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1635, 64813, 65193);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 64813, 65193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 64813, 65193);
            }
        }

        internal override void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 65256, 65464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 65329, 65355);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(isDisposing), 1635, 65329, 65354);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 65371, 65453) || true) && (isDisposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 65371, 65453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 65420, 65438);

                    f_1635_65420_65437(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 65371, 65453);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 65256, 65464);

                int
                f_1635_65420_65437(System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager
                this_param)
                {
                    this_param.CloseConnection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 65420, 65437);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 65256, 65464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 65256, 65464);
            }
        }

        protected override void CleanupConnection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 65476, 65573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 65544, 65562);

                f_1635_65544_65561(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 65476, 65573);

                int
                f_1635_65544_65561(System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager
                this_param)
                {
                    this_param.CloseConnection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 65544, 65561);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 65476, 65573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 65476, 65573);
            }
        }

        internal override void CreateAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 65738, 66367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 65877, 66033);

                _sshProcessId = f_1635_65893_66032(_connectionInfo, out _stdInWriter, out _stdOutReader, out _stdErrReader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 66092, 66124);

                f_1635_66092_66123(this, _stdErrReader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 66186, 66241);

                stdInWriter = f_1635_66200_66240(_stdInWriter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 66323, 66356);

                f_1635_66323_66355(this, _stdOutReader);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 65738, 66367);

                int
                f_1635_65893_66032(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param, out System.IO.StreamWriter
                stdInWriterVar, out System.IO.StreamReader
                stdOutReaderVar, out System.IO.StreamReader
                stdErrReaderVar)
                {
                    var return_v = this_param.StartSSHProcess(out stdInWriterVar, out stdOutReaderVar, out stdErrReaderVar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 65893, 66032);
                    return return_v;
                }


                int
                f_1635_66092_66123(System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager
                this_param, System.IO.StreamReader
                stdErrReader)
                {
                    this_param.StartErrorThread(stdErrReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 66092, 66123);
                    return 0;
                }


                System.Management.Automation.Remoting.OutOfProcessTextWriter
                f_1635_66200_66240(System.IO.StreamWriter
                writerToWrap)
                {
                    var return_v = new System.Management.Automation.Remoting.OutOfProcessTextWriter((System.IO.TextWriter)writerToWrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 66200, 66240);
                    return return_v;
                }


                int
                f_1635_66323_66355(System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager
                this_param, System.IO.StreamReader
                reader)
                {
                    this_param.StartReaderThread(reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 66323, 66355);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 65738, 66367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 65738, 66367);
            }
        }

        internal override void CloseAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 66379, 66683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 66439, 66457);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CloseAsync(), 1635, 66439, 66456);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 66473, 66672) || true) && (!_connectionEstablished)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 66473, 66672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 66639, 66657);

                    f_1635_66639_66656(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 66473, 66672);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 66379, 66683);

                int
                f_1635_66639_66656(System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager
                this_param)
                {
                    this_param.CloseConnection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 66639, 66656);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 66379, 66683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 66379, 66683);
            }
        }

        private void CloseConnection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 66752, 68207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 66807, 66870);

                var
                stdInWriter = f_1635_66825_66869(ref _stdInWriter, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 66884, 66935) || true) && (stdInWriter != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 66884, 66935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 66911, 66933);

                    f_1635_66911_66932(stdInWriter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 66884, 66935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 66951, 67016);

                var
                stdOutReader = f_1635_66970_67015(ref _stdOutReader, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 67030, 67083) || true) && (stdOutReader != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 67030, 67083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 67058, 67081);

                    f_1635_67058_67080(stdOutReader);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 67030, 67083);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 67099, 67164);

                var
                stdErrReader = f_1635_67118_67163(ref _stdErrReader, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 67178, 67231) || true) && (stdErrReader != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 67178, 67231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 67206, 67229);

                    f_1635_67206_67228(stdErrReader);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 67178, 67231);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 67495, 67557);

                var
                sshProcessId = f_1635_67514_67556(ref _sshProcessId, 0)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 67571, 68196) || true) && (sshProcessId != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 67571, 68196);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 67670, 67743);

                        var
                        sshProcess = f_1635_67687_67742(sshProcessId)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 67765, 67943) || true) && ((sshProcess != null) && (DynAbs.Tracing.TraceSender.Expression_True(1635, 67769, 67827) && (f_1635_67794_67811(sshProcess) != IntPtr.Zero)) && (DynAbs.Tracing.TraceSender.Expression_True(1635, 67769, 67852) && f_1635_67831_67852_M(!sshProcess.HasExited)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 67765, 67943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 67902, 67920);

                            f_1635_67902_67919(sshProcess);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 67765, 67943);
                        }
                    }
                    catch (ArgumentException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 67980, 68009);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 67980, 68009);
                    }
                    catch (InvalidOperationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 68027, 68064);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 68027, 68064);
                    }
                    catch (NotSupportedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 68082, 68115);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 68082, 68115);
                    }
                    catch (System.ComponentModel.Win32Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 68133, 68181);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 68133, 68181);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 67571, 68196);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 66752, 68207);

                System.IO.StreamWriter
                f_1635_66825_66869(ref System.IO.StreamWriter
                location1, System.IO.StreamWriter
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 66825, 66869);
                    return return_v;
                }


                int
                f_1635_66911_66932(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 66911, 66932);
                    return 0;
                }


                System.IO.StreamReader
                f_1635_66970_67015(ref System.IO.StreamReader
                location1, System.IO.StreamReader
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 66970, 67015);
                    return return_v;
                }


                int
                f_1635_67058_67080(System.IO.StreamReader
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 67058, 67080);
                    return 0;
                }


                System.IO.StreamReader
                f_1635_67118_67163(ref System.IO.StreamReader
                location1, System.IO.StreamReader
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 67118, 67163);
                    return return_v;
                }


                int
                f_1635_67206_67228(System.IO.StreamReader
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 67206, 67228);
                    return 0;
                }


                int
                f_1635_67514_67556(ref int
                location1, int
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 67514, 67556);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1635_67687_67742(int
                processId)
                {
                    var return_v = System.Diagnostics.Process.GetProcessById(processId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 67687, 67742);
                    return return_v;
                }


                System.IntPtr
                f_1635_67794_67811(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 67794, 67811);
                    return return_v;
                }


                bool
                f_1635_67831_67852_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 67831, 67852);
                    return return_v;
                }


                int
                f_1635_67902_67919(System.Diagnostics.Process
                this_param)
                {
                    this_param.Kill();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 67902, 67919);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 66752, 68207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 66752, 68207);
            }
        }

        private void StartErrorThread(
                    StreamReader stdErrReader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 68219, 68531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 68314, 68366);

                Thread
                errorThread = f_1635_68335_68365(ProcessErrorThread)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 68380, 68428);

                errorThread.Name = "SSH Transport Error Thread";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 68442, 68474);

                errorThread.IsBackground = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 68488, 68520);

                f_1635_68488_68519(errorThread, stdErrReader);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 68219, 68531);

                System.Threading.Thread
                f_1635_68335_68365(System.Threading.ParameterizedThreadStart
                start)
                {
                    var return_v = new System.Threading.Thread(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 68335, 68365);
                    return return_v;
                }


                int
                f_1635_68488_68519(System.Threading.Thread
                this_param, System.IO.StreamReader
                parameter)
                {
                    this_param.Start((object)parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 68488, 68519);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 68219, 68531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 68219, 68531);
            }
        }

        private void ProcessErrorThread(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 68543, 70268);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 68649, 68693);

                    StreamReader
                    reader = state as StreamReader
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 68711, 68764);

                    f_1635_68711_68763(reader != null, "Reader cannot be null.");
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 68784, 69521) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 68784, 69521);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 68837, 68870);

                            string
                            error = f_1635_68852_68869(reader)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 68894, 69032) || true) && (f_1635_68898_68910(error) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 68894, 69032);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 69000, 69009);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 68894, 69032);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 69130, 69458);

                            PSRemotingTransportException
                            psrte = f_1635_69167_69457(PSRemotingErrorId.IPCServerProcessReportedError, f_1635_69300_69352(), f_1635_69379_69456(f_1635_69397_69448(), error))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 69480, 69502);

                            f_1635_69480_69501(this, psrte);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 68784, 69521);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1635, 68784, 69521);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1635, 68784, 69521);
                    }
                }
                catch (ObjectDisposedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 69550, 69657);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 69550, 69657);
                    // Normal reader thread end.
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 69671, 70257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 69723, 69788);

                    string
                    errorMsg = (DynAbs.Tracing.TraceSender.Conditional_F1(1635, 69741, 69760) || (((f_1635_69742_69751(e) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1635, 69763, 69772)) || DynAbs.Tracing.TraceSender.Conditional_F3(1635, 69775, 69787))) ? f_1635_69763_69772(e) : string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 69806, 69984);

                    f_1635_69806_69983(_tracer, "SSHClientSessionTransportManager", "ProcessErrorThread", Guid.Empty, "Transport manager error thread ended with error: {0}", errorMsg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 70004, 70202);

                    PSRemotingTransportException
                    psrte = f_1635_70041_70201(f_1635_70096_70176(f_1635_70114_70165(), errorMsg), e)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 70220, 70242);

                    f_1635_70220_70241(this, psrte);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 69671, 70257);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 68543, 70268);

                int
                f_1635_68711_68763(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 68711, 68763);
                    return 0;
                }


                string
                f_1635_68852_68869(System.IO.StreamReader
                reader)
                {
                    var return_v = ReadError(reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 68852, 68869);
                    return return_v;
                }


                int
                f_1635_68898_68910(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 68898, 68910);
                    return return_v;
                }


                string
                f_1635_69300_69352()
                {
                    var return_v = RemotingErrorIdStrings.IPCServerProcessReportedError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 69300, 69352);
                    return return_v;
                }


                string
                f_1635_69397_69448()
                {
                    var return_v = RemotingErrorIdStrings.SSHClientEndWithErrorMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 69397, 69448);
                    return return_v;
                }


                string
                f_1635_69379_69456(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 69379, 69456);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_69167_69457(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 69167, 69457);
                    return return_v;
                }


                int
                f_1635_69480_69501(System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.PSRemotingTransportException
                psrte)
                {
                    this_param.HandleSSHError(psrte);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 69480, 69501);
                    return 0;
                }


                string
                f_1635_69742_69751(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 69742, 69751);
                    return return_v;
                }


                string
                f_1635_69763_69772(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 69763, 69772);
                    return return_v;
                }


                int
                f_1635_69806_69983(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 69806, 69983);
                    return 0;
                }


                string
                f_1635_70114_70165()
                {
                    var return_v = RemotingErrorIdStrings.SSHClientEndWithErrorMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 70114, 70165);
                    return return_v;
                }


                string
                f_1635_70096_70176(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 70096, 70176);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_70041_70201(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 70041, 70201);
                    return return_v;
                }


                int
                f_1635_70220_70241(System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.PSRemotingTransportException
                psrte)
                {
                    this_param.HandleSSHError(psrte);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 70220, 70241);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 68543, 70268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 68543, 70268);
            }
        }

        private void HandleSSHError(PSRemotingTransportException psrte)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 70280, 70515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 70368, 70472);

                f_1635_70368_70471(this, f_1635_70386_70470(psrte, TransportMethodEnum.CloseShellOperationEx));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 70486, 70504);

                f_1635_70486_70503(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 70280, 70515);

                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1635_70386_70470(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 70386, 70470);
                    return return_v;
                }


                int
                f_1635_70368_70471(System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 70368, 70471);
                    return 0;
                }


                int
                f_1635_70486_70503(System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager
                this_param)
                {
                    this_param.CloseConnection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 70486, 70503);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 70280, 70515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 70280, 70515);
            }
        }

        private static string ReadError(StreamReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1635, 70527, 72338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 70655, 70688);

                string
                error = f_1635_70670_70687(reader)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 70704, 70905) || true) && (error == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 70704, 70905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 70806, 70890);

                    throw f_1635_70812_70889(f_1635_70844_70888());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 70704, 70905);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 70921, 71201) || true) && ((f_1635_70926_70938(error) == 0) || (DynAbs.Tracing.TraceSender.Expression_False(1635, 70925, 71031) || f_1635_70965_71026(error, "WARNING:", StringComparison.OrdinalIgnoreCase) > -1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 70921, 71201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 71123, 71148);

                    f_1635_71123_71147(error);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 71166, 71186);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 70921, 71201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 71578, 71639);

                System.Text.StringBuilder
                sb = f_1635_71609_71638(error)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 71653, 71672);

                var
                running = true
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 71686, 72290) || true) && (running)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 71686, 72290);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 71778, 71812);

                            var
                            task = f_1635_71789_71811(reader)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 71834, 72145) || true) && (f_1635_71838_71853(task, 1000) && (DynAbs.Tracing.TraceSender.Expression_True(1635, 71838, 71878) && (f_1635_71858_71869(task) != null)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 71834, 72145);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 71928, 71959);

                                f_1635_71928_71958(sb, f_1635_71938_71957());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 71985, 72008);

                                f_1635_71985_72007(sb, f_1635_71995_72006(task));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 71834, 72145);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 71834, 72145);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 72106, 72122);

                                running = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 71834, 72145);
                            }
                        }
                        catch (Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 72182, 72275);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 72240, 72256);

                            running = false;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 72182, 72275);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 71686, 72290);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1635, 71686, 72290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1635, 71686, 72290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 72306, 72327);

                return f_1635_72313_72326(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1635, 70527, 72338);

                string?
                f_1635_70670_70687(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 70670, 70687);
                    return return_v;
                }


                string
                f_1635_70844_70888()
                {
                    var return_v = RemotingErrorIdStrings.SSHAbruptlyTerminated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 70844, 70888);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1635_70812_70889(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 70812, 70889);
                    return return_v;
                }


                int
                f_1635_70926_70938(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 70926, 70938);
                    return return_v;
                }


                int
                f_1635_70965_71026(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 70965, 71026);
                    return return_v;
                }


                int
                f_1635_71123_71147(string
                value)
                {
                    Console.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 71123, 71147);
                    return 0;
                }


                System.Text.StringBuilder
                f_1635_71609_71638(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 71609, 71638);
                    return return_v;
                }


                System.Threading.Tasks.Task<string?>
                f_1635_71789_71811(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadLineAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 71789, 71811);
                    return return_v;
                }


                bool
                f_1635_71838_71853(System.Threading.Tasks.Task<string?>
                this_param, int
                millisecondsTimeout)
                {
                    var return_v = this_param.Wait(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 71838, 71853);
                    return return_v;
                }


                string
                f_1635_71858_71869(System.Threading.Tasks.Task<string?>
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 71858, 71869);
                    return return_v;
                }


                string
                f_1635_71938_71957()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 71938, 71957);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1635_71928_71958(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 71928, 71958);
                    return return_v;
                }


                string
                f_1635_71995_72006(System.Threading.Tasks.Task<string?>
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 71995, 72006);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1635_71985_72007(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 71985, 72007);
                    return return_v;
                }


                string
                f_1635_72313_72326(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 72313, 72326);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 70527, 72338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 70527, 72338);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void StartReaderThread(
                    StreamReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 72350, 72639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 72440, 72494);

                Thread
                readerThread = f_1635_72462_72493(ProcessReaderThread)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 72508, 72540);

                readerThread.Name = _threadName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 72554, 72587);

                readerThread.IsBackground = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 72601, 72628);

                f_1635_72601_72627(readerThread, reader);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 72350, 72639);

                System.Threading.Thread
                f_1635_72462_72493(System.Threading.ParameterizedThreadStart
                start)
                {
                    var return_v = new System.Threading.Thread(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 72462, 72493);
                    return return_v;
                }


                int
                f_1635_72601_72627(System.Threading.Thread
                this_param, System.IO.StreamReader
                parameter)
                {
                    this_param.Start((object)parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 72601, 72627);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 72350, 72639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 72350, 72639);
            }
        }

        private void ProcessReaderThread(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 72651, 75065);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 72758, 72802);

                    StreamReader
                    reader = state as StreamReader
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 72820, 72873);

                    f_1635_72820_72872(reader != null, "Reader cannot be null.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 72932, 72946);

                    f_1635_72932_72945(this);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 73005, 74368) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 73005, 74368);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 73058, 73090);

                            string
                            data = f_1635_73072_73089(reader)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 73112, 73453) || true) && (data == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 73112, 73453);
                                DynAbs.Tracing.TraceSender.TraceBreak(1635, 73424, 73430);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 73112, 73453);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 73477, 74349) || true) && (f_1635_73481_73616(data, f_1635_73497_73579(), StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 73477, 74349);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 73725, 73850);

                                string
                                errorData = f_1635_73744_73849(data, f_1635_73759_73848(f_1635_73759_73841()))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 73876, 73911);

                                f_1635_73876_73910(this, errorData);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 73477, 74349);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 73477, 74349);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 74156, 74219) || true) && (!_connectionEstablished)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 74156, 74219);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 74187, 74217);

                                    _connectionEstablished = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 74156, 74219);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 74295, 74326);

                                f_1635_74295_74325(this, data);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 73477, 74349);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 73005, 74368);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1635, 73005, 74368);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1635, 73005, 74368);
                    }
                }
                catch (ObjectDisposedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 74397, 74504);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 74397, 74504);
                    // Normal reader thread end.
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 74518, 75054);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 74570, 74756) || true) && (e is ArgumentOutOfRangeException)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 74570, 74756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 74648, 74737);

                        f_1635_74648_74736(false, "Need to adjust transport fragmentor to accomodate read buffer size.");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 74570, 74756);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 74776, 74841);

                    string
                    errorMsg = (DynAbs.Tracing.TraceSender.Conditional_F1(1635, 74794, 74813) || (((f_1635_74795_74804(e) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1635, 74816, 74825)) || DynAbs.Tracing.TraceSender.Conditional_F3(1635, 74828, 74840))) ? f_1635_74816_74825(e) : string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 74859, 75039);

                    f_1635_74859_75038(_tracer, "SSHClientSessionTransportManager", "ProcessReaderThread", Guid.Empty, "Transport manager reader thread ended with error: {0}", errorMsg);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 74518, 75054);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 72651, 75065);

                int
                f_1635_72820_72872(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 72820, 72872);
                    return 0;
                }


                int
                f_1635_72932_72945(System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 72932, 72945);
                    return 0;
                }


                string?
                f_1635_73072_73089(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 73072, 73089);
                    return return_v;
                }


                string
                f_1635_73497_73579()
                {
                    var return_v = System.Management.Automation.Remoting.Server.NamedPipeErrorTextWriter.ErrorPrepend;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 73497, 73579);
                    return return_v;
                }


                bool
                f_1635_73481_73616(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 73481, 73616);
                    return return_v;
                }


                string
                f_1635_73759_73841()
                {
                    var return_v = System.Management.Automation.Remoting.Server.NamedPipeErrorTextWriter.ErrorPrepend;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 73759, 73841);
                    return return_v;
                }


                int
                f_1635_73759_73848(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 73759, 73848);
                    return return_v;
                }


                string
                f_1635_73744_73849(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 73744, 73849);
                    return return_v;
                }


                int
                f_1635_73876_73910(System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager
                this_param, string
                data)
                {
                    this_param.HandleErrorDataReceived(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 73876, 73910);
                    return 0;
                }


                int
                f_1635_74295_74325(System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager
                this_param, string
                data)
                {
                    this_param.HandleOutputDataReceived(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 74295, 74325);
                    return 0;
                }


                int
                f_1635_74648_74736(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 74648, 74736);
                    return 0;
                }


                string
                f_1635_74795_74804(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 74795, 74804);
                    return return_v;
                }


                string
                f_1635_74816_74825(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 74816, 74825);
                    return return_v;
                }


                int
                f_1635_74859_75038(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 74859, 75038);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 72651, 75065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 72651, 75065);
            }
        }

        static SSHClientSessionTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 64272, 75094);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 64704, 64746);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 64272, 75094);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 64272, 75094);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1635, 64272, 75094);

        System.Management.Automation.PSArgumentException
        f_1635_65089_65130(string
        message)
        {
            var return_v = new System.Management.Automation.PSArgumentException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 65089, 65130);
            return return_v;
        }


        static System.Guid
        f_1635_65003_65013_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1635, 64813, 65193);
            return return_v;
        }

    }
    internal abstract class NamedPipeClientSessionTransportManagerBase : OutOfProcessClientSessionTransportManagerBase
    {
        private RunspaceConnectionInfo _connectionInfo;

        protected NamedPipeClientBase _clientPipe;

        private string _threadName;

        internal NamedPipeClientSessionTransportManagerBase(
                    RunspaceConnectionInfo connectionInfo,
                    Guid runspaceId,
                    PSRemotingCryptoHelper cryptoHelper,
                    string threadName)
        : base(f_1635_75724_75734_C(runspaceId), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1635, 75487, 76100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 75288, 75303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 75344, 75383);
                this._clientPipe = f_1635_75358_75383();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 75409, 75420);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 75774, 75901) || true) && (connectionInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 75774, 75901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 75834, 75886);

                    throw f_1635_75840_75885("connectionInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 75774, 75901);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 75917, 75950);

                _connectionInfo = connectionInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 75964, 75989);

                _threadName = threadName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 76003, 76089);

                f_1635_76003_76013().FragmentSize = f_1635_76029_76088();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1635, 75487, 76100);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 75487, 76100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 75487, 76100);
            }
        }

        internal override void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 76163, 76459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 76236, 76262);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(isDisposing), 1635, 76236, 76261);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 76278, 76448) || true) && (isDisposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 76278, 76448);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 76327, 76433) || true) && (_clientPipe != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 76327, 76433);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 76392, 76414);

                        f_1635_76392_76413(_clientPipe);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 76327, 76433);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 76278, 76448);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 76163, 76459);

                int
                f_1635_76392_76413(System.Management.Automation.Remoting.NamedPipeClientBase
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 76392, 76413);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 76163, 76459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 76163, 76459);
            }
        }

        protected override void CleanupConnection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 76471, 76570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 76539, 76559);

                f_1635_76539_76558(_clientPipe);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 76471, 76570);

                int
                f_1635_76539_76558(System.Management.Automation.Remoting.NamedPipeClientBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 76539, 76558);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 76471, 76570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 76471, 76570);
            }
        }

        protected void StartReaderThread(
                    StreamReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 76641, 76932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 76733, 76787);

                Thread
                readerThread = f_1635_76755_76786(ProcessReaderThread)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 76801, 76833);

                readerThread.Name = _threadName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 76847, 76880);

                readerThread.IsBackground = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 76894, 76921);

                f_1635_76894_76920(readerThread, reader);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 76641, 76932);

                System.Threading.Thread
                f_1635_76755_76786(System.Threading.ParameterizedThreadStart
                start)
                {
                    var return_v = new System.Threading.Thread(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 76755, 76786);
                    return return_v;
                }


                int
                f_1635_76894_76920(System.Threading.Thread
                this_param, System.IO.StreamReader
                parameter)
                {
                    this_param.Start((object)parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 76894, 76920);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 76641, 76932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 76641, 76932);
            }
        }

        private void ProcessReaderThread(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 77001, 79584);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 77108, 77152);

                    StreamReader
                    reader = state as StreamReader
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 77170, 77223);

                    f_1635_77170_77222(reader != null, "Reader cannot be null.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 77282, 77296);

                    f_1635_77282_77295(this);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 77355, 78882) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 77355, 78882);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 77408, 77440);

                            string
                            data = f_1635_77422_77439(reader)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 77462, 78205) || true) && (data == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 77462, 78205);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 77705, 78021);

                                PSRemotingTransportException
                                psrte = f_1635_77742_78020(PSRemotingErrorId.IPCServerProcessReportedError, f_1635_77883_77935(), f_1635_77966_78019())
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 78047, 78150);

                                f_1635_78047_78149(this, f_1635_78065_78148(psrte, TransportMethodEnum.ReceiveShellOutputEx));
                                DynAbs.Tracing.TraceSender.TraceBreak(1635, 78176, 78182);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 77462, 78205);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 78229, 78863) || true) && (f_1635_78233_78368(data, f_1635_78249_78331(), StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 78229, 78863);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 78477, 78602);

                                string
                                errorData = f_1635_78496_78601(data, f_1635_78511_78600(f_1635_78511_78593()))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 78628, 78663);

                                f_1635_78628_78662(this, errorData);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 78229, 78863);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 78229, 78863);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 78809, 78840);

                                f_1635_78809_78839(this, data);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 78229, 78863);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 77355, 78882);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1635, 77355, 78882);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1635, 77355, 78882);
                    }
                }
                catch (ObjectDisposedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 78911, 79018);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 78911, 79018);
                    // Normal reader thread end.
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 79032, 79573);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 79084, 79271) || true) && (e is ArgumentOutOfRangeException)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 79084, 79271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 79162, 79252);

                        f_1635_79162_79251(false, "Need to adjust transport fragmentor to accommodate read buffer size.");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 79084, 79271);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 79291, 79356);

                    string
                    errorMsg = (DynAbs.Tracing.TraceSender.Conditional_F1(1635, 79309, 79328) || (((f_1635_79310_79319(e) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1635, 79331, 79340)) || DynAbs.Tracing.TraceSender.Conditional_F3(1635, 79343, 79355))) ? f_1635_79331_79340(e) : string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 79374, 79558);

                    f_1635_79374_79557(_tracer, "NamedPipeClientSessionTransportManager", "StartReaderThread", Guid.Empty, "Transport manager reader thread ended with error: {0}", errorMsg);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 79032, 79573);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 77001, 79584);

                int
                f_1635_77170_77222(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 77170, 77222);
                    return 0;
                }


                int
                f_1635_77282_77295(System.Management.Automation.Remoting.Client.NamedPipeClientSessionTransportManagerBase
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 77282, 77295);
                    return 0;
                }


                string?
                f_1635_77422_77439(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 77422, 77439);
                    return return_v;
                }


                string
                f_1635_77883_77935()
                {
                    var return_v = RemotingErrorIdStrings.IPCServerProcessReportedError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 77883, 77935);
                    return return_v;
                }


                string
                f_1635_77966_78019()
                {
                    var return_v = RemotingErrorIdStrings.NamedPipeTransportProcessEnded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 77966, 78019);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_77742_78020(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 77742, 78020);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1635_78065_78148(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 78065, 78148);
                    return return_v;
                }


                int
                f_1635_78047_78149(System.Management.Automation.Remoting.Client.NamedPipeClientSessionTransportManagerBase
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 78047, 78149);
                    return 0;
                }


                string
                f_1635_78249_78331()
                {
                    var return_v = System.Management.Automation.Remoting.Server.NamedPipeErrorTextWriter.ErrorPrepend;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 78249, 78331);
                    return return_v;
                }


                bool
                f_1635_78233_78368(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 78233, 78368);
                    return return_v;
                }


                string
                f_1635_78511_78593()
                {
                    var return_v = System.Management.Automation.Remoting.Server.NamedPipeErrorTextWriter.ErrorPrepend;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 78511, 78593);
                    return return_v;
                }


                int
                f_1635_78511_78600(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 78511, 78600);
                    return return_v;
                }


                string
                f_1635_78496_78601(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 78496, 78601);
                    return return_v;
                }


                int
                f_1635_78628_78662(System.Management.Automation.Remoting.Client.NamedPipeClientSessionTransportManagerBase
                this_param, string
                data)
                {
                    this_param.HandleErrorDataReceived(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 78628, 78662);
                    return 0;
                }


                int
                f_1635_78809_78839(System.Management.Automation.Remoting.Client.NamedPipeClientSessionTransportManagerBase
                this_param, string
                data)
                {
                    this_param.HandleOutputDataReceived(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 78809, 78839);
                    return 0;
                }


                int
                f_1635_79162_79251(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 79162, 79251);
                    return 0;
                }


                string
                f_1635_79310_79319(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 79310, 79319);
                    return return_v;
                }


                string
                f_1635_79331_79340(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 79331, 79340);
                    return return_v;
                }


                int
                f_1635_79374_79557(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 79374, 79557);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 77001, 79584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 77001, 79584);
            }
        }

        static NamedPipeClientSessionTransportManagerBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 75102, 79613);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 75102, 79613);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 75102, 79613);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1635, 75102, 79613);

        System.Management.Automation.Remoting.NamedPipeClientBase
        f_1635_75358_75383()
        {
            var return_v = new System.Management.Automation.Remoting.NamedPipeClientBase();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 75358, 75383);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1635_75840_75885(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 75840, 75885);
            return return_v;
        }


        System.Management.Automation.Remoting.Fragmentor
        f_1635_76003_76013()
        {
            var return_v = Fragmentor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 76003, 76013);
            return return_v;
        }


        int
        f_1635_76029_76088()
        {
            var return_v = RemoteSessionNamedPipeServer.NamedPipeBufferSizeForRemoting;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 76029, 76088);
            return return_v;
        }


        static System.Guid
        f_1635_75724_75734_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1635, 75487, 76100);
            return return_v;
        }

    }
    internal sealed class NamedPipeClientSessionTransportManager : NamedPipeClientSessionTransportManagerBase
    {
        private NamedPipeConnectionInfo _connectionInfo;

        private const string
        _threadName = "NamedPipeTransport Reader Thread"
        ;

        internal NamedPipeClientSessionTransportManager(
                    NamedPipeConnectionInfo connectionInfo,
                    Guid runspaceId,
                    PSRemotingCryptoHelper cryptoHelper)
        : base(f_1635_80171_80185_C(connectionInfo), runspaceId, cryptoHelper, _threadName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1635, 79969, 80437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 79807, 79822);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 80250, 80377) || true) && (connectionInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 80250, 80377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 80310, 80362);

                    throw f_1635_80316_80361("connectionInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 80250, 80377);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 80393, 80426);

                _connectionInfo = connectionInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1635, 79969, 80437);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 79969, 80437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 79969, 80437);
            }
        }

        internal override void CreateAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 80662, 81346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 80723, 80984);

                _clientPipe = (DynAbs.Tracing.TraceSender.Conditional_F1(1635, 80737, 80789) || ((f_1635_80737_80789(f_1635_80758_80788(_connectionInfo)) && DynAbs.Tracing.TraceSender.Conditional_F2(1635, 80809, 80899)) || DynAbs.Tracing.TraceSender.Conditional_F3(1635, 80919, 80983))) ? f_1635_80809_80899(f_1635_80842_80867(_connectionInfo), f_1635_80869_80898(_connectionInfo)) : f_1635_80919_80983(f_1635_80952_80982(_connectionInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 81048, 81097);

                f_1635_81048_81096(
                            // Wait for named pipe to connect.
                            _clientPipe, f_1635_81068_81095(_connectionInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 81159, 81224);

                stdInWriter = f_1635_81173_81223(f_1635_81200_81222(_clientPipe));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 81293, 81335);

                f_1635_81293_81334(this, f_1635_81311_81333(_clientPipe));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 80662, 81346);

                string
                f_1635_80758_80788(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
                this_param)
                {
                    var return_v = this_param.CustomPipeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 80758, 80788);
                    return return_v;
                }


                bool
                f_1635_80737_80789(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 80737, 80789);
                    return return_v;
                }


                int
                f_1635_80842_80867(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
                this_param)
                {
                    var return_v = this_param.ProcessId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 80842, 80867);
                    return return_v;
                }


                string
                f_1635_80869_80898(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
                this_param)
                {
                    var return_v = this_param.AppDomainName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 80869, 80898);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionNamedPipeClient
                f_1635_80809_80899(int
                procId, string
                appDomainName)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteSessionNamedPipeClient(procId, appDomainName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 80809, 80899);
                    return return_v;
                }


                string
                f_1635_80952_80982(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
                this_param)
                {
                    var return_v = this_param.CustomPipeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 80952, 80982);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionNamedPipeClient
                f_1635_80919_80983(string
                pipeName)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteSessionNamedPipeClient(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 80919, 80983);
                    return return_v;
                }


                int
                f_1635_81068_81095(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
                this_param)
                {
                    var return_v = this_param.OpenTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 81068, 81095);
                    return return_v;
                }


                int
                f_1635_81048_81096(System.Management.Automation.Remoting.NamedPipeClientBase
                this_param, int
                timeout)
                {
                    this_param.Connect(timeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 81048, 81096);
                    return 0;
                }


                System.IO.StreamWriter
                f_1635_81200_81222(System.Management.Automation.Remoting.NamedPipeClientBase
                this_param)
                {
                    var return_v = this_param.TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 81200, 81222);
                    return return_v;
                }


                System.Management.Automation.Remoting.OutOfProcessTextWriter
                f_1635_81173_81223(System.IO.StreamWriter
                writerToWrap)
                {
                    var return_v = new System.Management.Automation.Remoting.OutOfProcessTextWriter((System.IO.TextWriter)writerToWrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 81173, 81223);
                    return return_v;
                }


                System.IO.StreamReader
                f_1635_81311_81333(System.Management.Automation.Remoting.NamedPipeClientBase
                this_param)
                {
                    var return_v = this_param.TextReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 81311, 81333);
                    return return_v;
                }


                int
                f_1635_81293_81334(System.Management.Automation.Remoting.Client.NamedPipeClientSessionTransportManager
                this_param, System.IO.StreamReader
                reader)
                {
                    this_param.StartReaderThread(reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 81293, 81334);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 80662, 81346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 80662, 81346);
            }
        }

        public void AbortConnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 81513, 81674);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 81564, 81663) || true) && (_clientPipe != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 81564, 81663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 81621, 81648);

                    f_1635_81621_81647(_clientPipe);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 81564, 81663);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 81513, 81674);

                int
                f_1635_81621_81647(System.Management.Automation.Remoting.NamedPipeClientBase
                this_param)
                {
                    this_param.AbortConnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 81621, 81647);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 81513, 81674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 81513, 81674);
            }
        }

        static NamedPipeClientSessionTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 79621, 81703);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 79854, 79902);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 79621, 81703);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 79621, 81703);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1635, 79621, 81703);

        System.Management.Automation.PSArgumentNullException
        f_1635_80316_80361(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 80316, 80361);
            return return_v;
        }


        static System.Management.Automation.Runspaces.RunspaceConnectionInfo
        f_1635_80171_80185_C(System.Management.Automation.Runspaces.RunspaceConnectionInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1635, 79969, 80437);
            return return_v;
        }

    }
    internal sealed class ContainerNamedPipeClientSessionTransportManager : NamedPipeClientSessionTransportManagerBase
    {
        private ContainerConnectionInfo _connectionInfo;

        private const string
        _threadName = "ContainerNamedPipeTransport Reader Thread"
        ;

        internal ContainerNamedPipeClientSessionTransportManager(
                    ContainerConnectionInfo connectionInfo,
                    Guid runspaceId,
                    PSRemotingCryptoHelper cryptoHelper)
        : base(f_1635_82288_82302_C(connectionInfo), runspaceId, cryptoHelper, _threadName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1635, 82077, 82554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 81906, 81921);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 82367, 82494) || true) && (connectionInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 82367, 82494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 82427, 82479);

                    throw f_1635_82433_82478("connectionInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 82367, 82494);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 82510, 82543);

                _connectionInfo = connectionInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1635, 82077, 82554);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 82077, 82554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 82077, 82554);
            }
        }

        internal override void CreateAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 82799, 83443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 82860, 83081);

                _clientPipe = f_1635_82874_83080(f_1635_82928_82967(f_1635_82928_82957(_connectionInfo)), string.Empty, f_1635_83034_83079(f_1635_83034_83063(_connectionInfo)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 83145, 83194);

                f_1635_83145_83193(
                            // Wait for named pipe to connect.
                            _clientPipe, f_1635_83165_83192(_connectionInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 83256, 83321);

                stdInWriter = f_1635_83270_83320(f_1635_83297_83319(_clientPipe));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 83390, 83432);

                f_1635_83390_83431(this, f_1635_83408_83430(_clientPipe));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 82799, 83443);

                System.Management.Automation.Runspaces.ContainerProcess
                f_1635_82928_82957(System.Management.Automation.Runspaces.ContainerConnectionInfo
                this_param)
                {
                    var return_v = this_param.ContainerProc;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 82928, 82957);
                    return return_v;
                }


                int
                f_1635_82928_82967(System.Management.Automation.Runspaces.ContainerProcess
                this_param)
                {
                    var return_v = this_param.ProcessId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 82928, 82967);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ContainerProcess
                f_1635_83034_83063(System.Management.Automation.Runspaces.ContainerConnectionInfo
                this_param)
                {
                    var return_v = this_param.ContainerProc;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 83034, 83063);
                    return return_v;
                }


                string
                f_1635_83034_83079(System.Management.Automation.Runspaces.ContainerProcess
                this_param)
                {
                    var return_v = this_param.ContainerObRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 83034, 83079);
                    return return_v;
                }


                System.Management.Automation.Remoting.ContainerSessionNamedPipeClient
                f_1635_82874_83080(int
                procId, string
                appDomainName, string
                containerObRoot)
                {
                    var return_v = new System.Management.Automation.Remoting.ContainerSessionNamedPipeClient(procId, appDomainName, containerObRoot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 82874, 83080);
                    return return_v;
                }


                int
                f_1635_83165_83192(System.Management.Automation.Runspaces.ContainerConnectionInfo
                this_param)
                {
                    var return_v = this_param.OpenTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 83165, 83192);
                    return return_v;
                }


                int
                f_1635_83145_83193(System.Management.Automation.Remoting.NamedPipeClientBase
                this_param, int
                timeout)
                {
                    this_param.Connect(timeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 83145, 83193);
                    return 0;
                }


                System.IO.StreamWriter
                f_1635_83297_83319(System.Management.Automation.Remoting.NamedPipeClientBase
                this_param)
                {
                    var return_v = this_param.TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 83297, 83319);
                    return return_v;
                }


                System.Management.Automation.Remoting.OutOfProcessTextWriter
                f_1635_83270_83320(System.IO.StreamWriter
                writerToWrap)
                {
                    var return_v = new System.Management.Automation.Remoting.OutOfProcessTextWriter((System.IO.TextWriter)writerToWrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 83270, 83320);
                    return return_v;
                }


                System.IO.StreamReader
                f_1635_83408_83430(System.Management.Automation.Remoting.NamedPipeClientBase
                this_param)
                {
                    var return_v = this_param.TextReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 83408, 83430);
                    return return_v;
                }


                int
                f_1635_83390_83431(System.Management.Automation.Remoting.Client.ContainerNamedPipeClientSessionTransportManager
                this_param, System.IO.StreamReader
                reader)
                {
                    this_param.StartReaderThread(reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 83390, 83431);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 82799, 83443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 82799, 83443);
            }
        }

        protected override void CleanupConnection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 83455, 84015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 83523, 83543);

                f_1635_83523_83542(_clientPipe);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 83722, 84004) || true) && (!f_1635_83727_83770(_connectionInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 83722, 84004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 83804, 83989);

                    f_1635_83804_83988(_tracer, "ContainerNamedPipeClientSessionTransportManager", "CleanupConnection", Guid.Empty, "Failed to terminate PowerShell process inside container");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 83722, 84004);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 83455, 84015);

                int
                f_1635_83523_83542(System.Management.Automation.Remoting.NamedPipeClientBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 83523, 83542);
                    return 0;
                }


                bool
                f_1635_83727_83770(System.Management.Automation.Runspaces.ContainerConnectionInfo
                this_param)
                {
                    var return_v = this_param.TerminateContainerProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 83727, 83770);
                    return return_v;
                }


                int
                f_1635_83804_83988(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 83804, 83988);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 83455, 84015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 83455, 84015);
            }
        }

        static ContainerNamedPipeClientSessionTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 81711, 84044);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 81953, 82010);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 81711, 84044);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 81711, 84044);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1635, 81711, 84044);

        System.Management.Automation.PSArgumentNullException
        f_1635_82433_82478(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 82433, 82478);
            return return_v;
        }


        static System.Management.Automation.Runspaces.RunspaceConnectionInfo
        f_1635_82288_82302_C(System.Management.Automation.Runspaces.RunspaceConnectionInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1635, 82077, 82554);
            return return_v;
        }

    }
    internal class OutOfProcessClientCommandTransportManager : BaseClientCommandTransportManager
    {
        private OutOfProcessTextWriter _stdInWriter;

        private PrioritySendDataCollection.OnDataAvailableCallback _onDataAvailableToSendCallback;

        private Timer _signalTimeOutTimer;

        internal OutOfProcessClientCommandTransportManager(
                    ClientRemotePowerShell cmd,
                    bool noInput,
                    OutOfProcessClientSessionTransportManagerBase sessnTM,
                    OutOfProcessTextWriter stdInWriter) : base(f_1635_84691_84694_C(cmd), f_1635_84696_84716(sessnTM), sessnTM)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1635, 84447, 85050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 84224, 84236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 84306, 84336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 84361, 84380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 84751, 84778);

                _stdInWriter = stdInWriter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 84792, 84922);

                _onDataAvailableToSendCallback =
                                new PrioritySendDataCollection.OnDataAvailableCallback(OnDataAvailableCallback);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 84936, 85039);

                _signalTimeOutTimer = f_1635_84958_85038(OnSignalTimeOutTimerElapsed, null, Timeout.Infinite, Timeout.Infinite);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1635, 84447, 85050);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 84447, 85050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 84447, 85050);
            }
        }

        internal override void ConnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 85113, 85269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 85175, 85258);

                throw f_1635_85181_85257(f_1635_85209_85256());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 85113, 85269);

                string
                f_1635_85209_85256()
                {
                    var return_v = RemotingErrorIdStrings.IPCTransportConnectError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 85209, 85256);
                    return return_v;
                }


                System.NotImplementedException
                f_1635_85181_85257(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 85181, 85257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 85113, 85269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 85113, 85269);
            }
        }

        internal override void CreateAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 85281, 85776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 85342, 85665);

                f_1635_85342_85664(PSEventId.WSManCreateCommand, PSOpcode.Connect, PSTask.CreateRunspace, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_85597_85619().ToString(), powershellInstanceId.ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 85681, 85765);

                f_1635_85681_85764(
                            _stdInWriter, f_1635_85704_85763(powershellInstanceId));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 85281, 85776);

                System.Guid
                f_1635_85597_85619()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 85597, 85619);
                    return return_v;
                }


                int
                f_1635_85342_85664(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 85342, 85664);
                    return 0;
                }


                string
                f_1635_85704_85763(System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateCommandPacket(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 85704, 85763);
                    return return_v;
                }


                int
                f_1635_85681_85764(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 85681, 85764);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 85281, 85776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 85281, 85776);
            }
        }

        internal override void CloseAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 85788, 87108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 85854, 85864);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 85898, 85986) || true) && (isClosed == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 85898, 85986);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 85960, 85967);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 85898, 85986);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 86118, 86134);

                    isClosed = true;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 86165, 86183);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CloseAsync(), 1635, 86165, 86182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 86199, 86466);

                f_1635_86199_86465(PSEventId.WSManCloseCommand, PSOpcode.Disconnect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_86398_86420().ToString(), powershellInstanceId.ToString());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 86535, 87097) || true) && (_stdInWriter != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 86535, 87097);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 86637, 86719);

                        f_1635_86637_86718(_stdInWriter, f_1635_86660_86717(powershellInstanceId));
                    }
                    catch (IOException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1635, 86756, 87082);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 86818, 87063);

                        f_1635_86818_87062(this, f_1635_86862_87061(f_1635_86927_87017(f_1635_86960_87013(), e), TransportMethodEnum.CloseShellOperationEx));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1635, 86756, 87082);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 86535, 87097);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 85788, 87108);

                System.Guid
                f_1635_86398_86420()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 86398, 86420);
                    return return_v;
                }


                int
                f_1635_86199_86465(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 86199, 86465);
                    return 0;
                }


                string
                f_1635_86660_86717(System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateClosePacket(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 86660, 86717);
                    return return_v;
                }


                int
                f_1635_86637_86718(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 86637, 86718);
                    return 0;
                }


                string
                f_1635_86960_87013()
                {
                    var return_v = RemotingErrorIdStrings.NamedPipeTransportProcessEnded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 86960, 87013);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_86927_87017(string
                message, System.IO.IOException
                innerException)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 86927, 87017);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1635_86862_87061(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 86862, 87061);
                    return return_v;
                }


                int
                f_1635_86818_87062(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 86818, 87062);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 85788, 87108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 85788, 87108);
            }
        }

        internal override void SendStopSignal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 87120, 87923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 87184, 87459);

                f_1635_87184_87458(PSEventId.WSManSignal, PSOpcode.Disconnect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_87377_87399().ToString(), powershellInstanceId.ToString(), "stopsignal");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 87543, 87561);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CloseAsync(), 1635, 87543, 87560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 87639, 87722);

                f_1635_87639_87721(
                            // Stop is equivalent to closing on the server..
                            _stdInWriter, f_1635_87662_87720(powershellInstanceId));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 87856, 87912);

                f_1635_87856_87911(
                            // start the timer..so client can fail deterministically
                            // set the interval to 60 seconds.
                            _signalTimeOutTimer, 60 * 1000, Timeout.Infinite);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 87120, 87923);

                System.Guid
                f_1635_87377_87399()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 87377, 87399);
                    return return_v;
                }


                int
                f_1635_87184_87458(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 87184, 87458);
                    return 0;
                }


                string
                f_1635_87662_87720(System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateSignalPacket(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 87662, 87720);
                    return return_v;
                }


                int
                f_1635_87639_87721(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 87639, 87721);
                    return 0;
                }


                bool
                f_1635_87856_87911(System.Threading.Timer
                this_param, int
                dueTime, int
                period)
                {
                    var return_v = this_param.Change(dueTime, period);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 87856, 87911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 87120, 87923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 87120, 87923);
            }
        }

        internal override void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 87935, 88211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 88008, 88034);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(isDisposing), 1635, 88008, 88033);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 88048, 88200) || true) && (isDisposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 88048, 88200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 88097, 88137);

                    f_1635_88097_88136(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 88155, 88185);

                    f_1635_88155_88184(_signalTimeOutTimer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 88048, 88200);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 87935, 88211);

                int
                f_1635_88097_88136(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param)
                {
                    this_param.StopSignalTimerAndDecrementOperations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 88097, 88136);
                    return 0;
                }


                int
                f_1635_88155_88184(System.Threading.Timer
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 88155, 88184);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 87935, 88211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 87935, 88211);
            }
        }

        internal void OnCreateCmdCompleted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 88279, 89078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 88340, 88621);

                f_1635_88340_88620(PSEventId.WSManCreateCommandCallbackReceived, PSOpcode.Connect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_88553_88575().ToString(), powershellInstanceId.ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 88643, 88653);

                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 88750, 88933) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 88750, 88933);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 88804, 88885);

                        f_1635_88804_88884(tracer, "Client Session TM: Transport manager is closed. So returning");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 88907, 88914);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 88750, 88933);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 89038, 89052);

                    f_1635_89038_89051(this);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 88279, 89078);

                System.Guid
                f_1635_88553_88575()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 88553, 88575);
                    return return_v;
                }


                int
                f_1635_88340_88620(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 88340, 88620);
                    return 0;
                }


                int
                f_1635_88804_88884(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 88804, 88884);
                    return 0;
                }


                int
                f_1635_89038_89051(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 89038, 89051);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 88279, 89078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 88279, 89078);
            }
        }

        internal void OnRemoteCmdSendCompleted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 89090, 89827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 89155, 89439);

                f_1635_89155_89438(PSEventId.WSManSendShellInputExCallbackReceived, PSOpcode.Connect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_89371_89393().ToString(), powershellInstanceId.ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 89461, 89471);

                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 89588, 89771) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 89588, 89771);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 89642, 89723);

                        f_1635_89642_89722(tracer, "Client Command TM: Transport manager is closed. So returning");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 89745, 89752);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 89588, 89771);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 89802, 89816);

                f_1635_89802_89815(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 89090, 89827);

                System.Guid
                f_1635_89371_89393()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 89371, 89393);
                    return return_v;
                }


                int
                f_1635_89155_89438(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 89155, 89438);
                    return 0;
                }


                int
                f_1635_89642_89722(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 89642, 89722);
                    return 0;
                }


                int
                f_1635_89802_89815(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 89802, 89815);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 89090, 89827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 89090, 89827);
            }
        }

        internal void OnRemoteCmdDataReceived(byte[] rawData, string stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 89839, 90651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 89932, 90330);

                f_1635_89932_90329(PSEventId.WSManReceiveShellOutputExCallbackReceived, PSOpcode.Receive, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_90165_90187().ToString(), powershellInstanceId.ToString(), f_1635_90275_90328(f_1635_90275_90289(rawData), f_1635_90299_90327()));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 90425, 90592) || true) && (isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 90425, 90592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 90471, 90552);

                    f_1635_90471_90551(tracer, "Client Command TM: Transport manager is closed. So returning");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 90570, 90577);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 90425, 90592);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 90608, 90640);

                f_1635_90608_90639(this, rawData, stream);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 89839, 90651);

                System.Guid
                f_1635_90165_90187()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 90165, 90187);
                    return return_v;
                }


                int
                f_1635_90275_90289(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 90275, 90289);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1635_90299_90327()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 90299, 90327);
                    return return_v;
                }


                string
                f_1635_90275_90328(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 90275, 90328);
                    return return_v;
                }


                int
                f_1635_89932_90329(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 89932, 90329);
                    return 0;
                }


                int
                f_1635_90471_90551(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 90471, 90551);
                    return 0;
                }


                int
                f_1635_90608_90639(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param, byte[]
                data, string
                stream)
                {
                    this_param.ProcessRawData(data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 90608, 90639);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 89839, 90651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 89839, 90651);
            }
        }

        internal void OnRemoteCmdSignalCompleted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 90663, 91333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 90779, 91056);

                f_1635_90779_91055(PSEventId.WSManSignalCallbackReceived, PSOpcode.Disconnect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_90988_91010().ToString(), powershellInstanceId.ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 91072, 91112);

                f_1635_91072_91111(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 91128, 91196) || true) && (isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 91128, 91196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 91174, 91181);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 91128, 91196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 91272, 91322);

                f_1635_91272_91321(this, null, null, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 90663, 91333);

                System.Guid
                f_1635_90988_91010()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 90988, 91010);
                    return return_v;
                }


                int
                f_1635_90779_91055(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 90779, 91055);
                    return 0;
                }


                int
                f_1635_91072_91111(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param)
                {
                    this_param.StopSignalTimerAndDecrementOperations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 91072, 91111);
                    return 0;
                }


                int
                f_1635_91272_91321(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                remoteObject, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                transportErrorArgs, bool
                privateData)
                {
                    this_param.EnqueueAndStartProcessingThread(remoteObject, transportErrorArgs, (object)privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 91272, 91321);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 90663, 91333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 90663, 91333);
            }
        }

        internal void OnSignalTimeOutTimerElapsed(object source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 91345, 91804);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 91480, 91548) || true) && (isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 91480, 91548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 91526, 91533);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 91480, 91548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 91564, 91676);

                PSRemotingTransportException
                psrte = f_1635_91601_91675(f_1635_91634_91674())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 91690, 91793);

                f_1635_91690_91792(this, f_1635_91708_91791(psrte, TransportMethodEnum.ReceiveShellOutputEx));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 91345, 91804);

                string
                f_1635_91634_91674()
                {
                    var return_v = RemotingErrorIdStrings.IPCSignalTimedOut;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 91634, 91674);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_91601_91675(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 91601, 91675);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1635_91708_91791(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 91708, 91791);
                    return return_v;
                }


                int
                f_1635_91690_91792(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 91690, 91792);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 91345, 91804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 91345, 91804);
            }
        }

        private void StopSignalTimerAndDecrementOperations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 91816, 92032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 91899, 91909);
                lock (syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 91943, 92006);

                    f_1635_91943_92005(_signalTimeOutTimer, Timeout.Infinite, Timeout.Infinite);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 91816, 92032);

                bool
                f_1635_91943_92005(System.Threading.Timer
                this_param, int
                dueTime, int
                period)
                {
                    var return_v = this_param.Change(dueTime, period);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 91943, 92005);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 91816, 92032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 91816, 92032);
            }
        }

        internal override void ProcessPrivateData(object privateData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 92433, 92861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 92519, 92582);

                f_1635_92519_92581(privateData != null, "privateData cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 92677, 92729);

                bool
                shouldRaiseSignalCompleted = (bool)privateData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 92743, 92850) || true) && (shouldRaiseSignalCompleted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 92743, 92850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 92807, 92835);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.RaiseSignalCompleted(), 1635, 92807, 92834);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 92743, 92850);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 92433, 92861);

                int
                f_1635_92519_92581(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 92519, 92581);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 92433, 92861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 92433, 92861);
            }
        }

        internal void OnCloseCmdCompleted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 92873, 93421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 92933, 93216);

                f_1635_92933_93215(PSEventId.WSManCloseCommandCallbackReceived, PSOpcode.Disconnect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_93148_93170().ToString(), powershellInstanceId.ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 93388, 93410);

                f_1635_93388_93409(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 92873, 93421);

                System.Guid
                f_1635_93148_93170()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 93148, 93170);
                    return return_v;
                }


                int
                f_1635_92933_93215(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 92933, 93215);
                    return 0;
                }


                int
                f_1635_93388_93409(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseCloseCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 93388, 93409);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 92873, 93421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 92873, 93421);
            }
        }

        private void SendOneItem()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 93433, 94311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 93484, 93503);

                byte[]
                data = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 93517, 93574);

                DataPriorityType
                priorityType = DataPriorityType.Default
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 93803, 94190) || true) && (f_1635_93807_93832(serializedPipeline) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 93803, 94190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 93870, 93925);

                    data = f_1635_93877_93924(serializedPipeline, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 93803, 94190);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 93803, 94190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 94082, 94175);

                    data = f_1635_94089_94174(dataToBeSent, _onDataAvailableToSendCallback, out priorityType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 93803, 94190);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 94206, 94300) || true) && (data != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 94206, 94300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 94256, 94285);

                    f_1635_94256_94284(this, data, priorityType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 94206, 94300);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 93433, 94311);

                long
                f_1635_93807_93832(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 93807, 93832);
                    return return_v;
                }


                byte[]
                f_1635_93877_93924(System.Management.Automation.Remoting.SerializedDataStream
                this_param, System.Management.Automation.Remoting.SerializedDataStream.OnDataAvailableCallback
                callback)
                {
                    var return_v = this_param.ReadOrRegisterCallback(callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 93877, 93924);
                    return return_v;
                }


                byte[]
                f_1635_94089_94174(System.Management.Automation.Remoting.PrioritySendDataCollection
                this_param, System.Management.Automation.Remoting.PrioritySendDataCollection.OnDataAvailableCallback
                callback, out System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    var return_v = this_param.ReadOrRegisterCallback(callback, out priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 94089, 94174);
                    return return_v;
                }


                int
                f_1635_94256_94284(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param, byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    this_param.SendData(data, priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 94256, 94284);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 93433, 94311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 93433, 94311);
            }
        }

        private void SendData(byte[] data, DataPriorityType priorityType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 94323, 95120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 94413, 94785);

                f_1635_94413_94784(PSEventId.WSManSendShellInputEx, PSOpcode.Send, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1635_94623_94645().ToString(), powershellInstanceId.ToString(), f_1635_94733_94783(f_1635_94733_94744(data), f_1635_94754_94782()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 94807, 94817);

                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 94851, 94931) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 94851, 94931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 94905, 94912);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 94851, 94931);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 94951, 95094);

                    f_1635_94951_95093(
                                    _stdInWriter, f_1635_94974_95092(data, priorityType, powershellInstanceId));
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 94323, 95120);

                System.Guid
                f_1635_94623_94645()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 94623, 94645);
                    return return_v;
                }


                int
                f_1635_94733_94744(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 94733, 94744);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1635_94754_94782()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 94754, 94782);
                    return return_v;
                }


                string
                f_1635_94733_94783(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 94733, 94783);
                    return return_v;
                }


                int
                f_1635_94413_94784(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 94413, 94784);
                    return 0;
                }


                string
                f_1635_94974_95092(byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                streamType, System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateDataPacket(data, streamType, psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 94974, 95092);
                    return return_v;
                }


                int
                f_1635_94951_95093(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 94951, 95093);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 94323, 95120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 94323, 95120);
            }
        }

        private void OnDataAvailableCallback(byte[] data, DataPriorityType priorityType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 95132, 95445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 95237, 95316);

                f_1635_95237_95315(data != null, "data cannot be null in the data available callback");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 95332, 95391);

                f_1635_95332_95390(
                            tracer, "Received data from dataToBeSent store.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 95405, 95434);

                f_1635_95405_95433(this, data, priorityType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 95132, 95445);

                int
                f_1635_95237_95315(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 95237, 95315);
                    return 0;
                }


                int
                f_1635_95332_95390(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 95332, 95390);
                    return 0;
                }


                int
                f_1635_95405_95433(System.Management.Automation.Remoting.Client.OutOfProcessClientCommandTransportManager
                this_param, byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    this_param.SendData(data, priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 95405, 95433);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 95132, 95445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 95132, 95445);
            }
        }

        static OutOfProcessClientCommandTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 84052, 95474);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 84052, 95474);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 84052, 95474);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1635, 84052, 95474);

        static System.Management.Automation.Internal.PSRemotingCryptoHelper
        f_1635_84696_84716(System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManagerBase
        this_param)
        {
            var return_v = this_param.CryptoHelper;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 84696, 84716);
            return return_v;
        }


        System.Threading.Timer
        f_1635_84958_85038(System.Threading.TimerCallback
        callback, object?
        state, int
        dueTime, int
        period)
        {
            var return_v = new System.Threading.Timer(callback, state, dueTime, period);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 84958, 85038);
            return return_v;
        }


        static System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
        f_1635_84691_84694_C(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1635, 84447, 85050);
            return return_v;
        }

    }
}

namespace System.Management.Automation.Remoting.Server
{
    internal class OutOfProcessServerSessionTransportManager : AbstractServerSessionTransportManager
    {
        private OutOfProcessTextWriter _stdOutWriter;

        private OutOfProcessTextWriter _stdErrWriter;

        private Dictionary<Guid, OutOfProcessServerTransportManager> _cmdTransportManagers;

        private object _syncObject;

        internal OutOfProcessServerSessionTransportManager(OutOfProcessTextWriter outWriter, OutOfProcessTextWriter errWriter, PSRemotingCryptoHelperServer cryptoHelper)
        : base(f_1635_96182_96222_C(BaseTransportManager.DefaultFragmentSize), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1635, 96000, 96582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 95720, 95733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 95775, 95788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 95860, 95881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 95907, 95933);
                this._syncObject = f_1635_95921_95933();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 96262, 96321);

                f_1635_96262_96320(outWriter != null, "outWriter cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 96335, 96394);

                f_1635_96335_96393(errWriter != null, "errWriter cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 96408, 96434);

                _stdOutWriter = outWriter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 96448, 96474);

                _stdErrWriter = errWriter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 96488, 96571);

                _cmdTransportManagers = f_1635_96512_96570();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1635, 96000, 96582);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 96000, 96582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 96000, 96582);
            }
        }

        internal override void ProcessRawData(byte[] data, string stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 96645, 96942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 96735, 96769);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ProcessRawData(data, stream), 1635, 96735, 96768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 96856, 96931);

                f_1635_96856_96930(
                            // Send ACK back to the client as we have processed data.
                            _stdOutWriter, f_1635_96880_96929(Guid.Empty));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 96645, 96942);

                string
                f_1635_96880_96929(System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateDataAckPacket(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 96880, 96929);
                    return return_v;
                }


                int
                f_1635_96856_96930(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 96856, 96930);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 96645, 96942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 96645, 96942);
            }
        }

        internal override void Prepare()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 96954, 97056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 97011, 97045);

                throw f_1635_97017_97044();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 96954, 97056);

                System.NotSupportedException
                f_1635_97017_97044()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 97017, 97044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 96954, 97056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 96954, 97056);
            }
        }

        protected override void SendDataToClient(byte[] data, bool flush, bool reportAsPending, bool reportAsDataBoundary)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 97068, 97339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 97207, 97328);

                f_1635_97207_97327(_stdOutWriter, f_1635_97231_97326(data, DataPriorityType.Default, Guid.Empty));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 97068, 97339);

                string
                f_1635_97231_97326(byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                streamType, System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateDataPacket(data, streamType, psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 97231, 97326);
                    return return_v;
                }


                int
                f_1635_97207_97327(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 97207, 97327);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 97068, 97339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 97068, 97339);
            }
        }

        internal override void ReportExecutionStatusAsRunning()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 97351, 97468);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 97351, 97468);
                // No-OP for outofProc TMs
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 97351, 97468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 97351, 97468);
            }
        }

        internal void CreateCommandTransportManager(Guid powerShellCmdId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 97480, 98603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 97570, 97781);

                OutOfProcessServerTransportManager
                cmdTM = f_1635_97613_97780(_stdOutWriter, _stdErrWriter, powerShellCmdId, f_1635_97716_97730(this), f_1635_97732_97760(f_1635_97732_97747(this)), f_1635_97762_97779(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 97980, 98022);

                f_1635_97980_98021(            // this will make the Session's DataReady event handler handle
                                               // the commands data as well. This is because the state machine
                                               // is per session.
                            cmdTM, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 98044, 98055);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 98252, 98338);

                    f_1635_98252_98337(!f_1635_98264_98314(_cmdTransportManagers, powerShellCmdId), "key already exists");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 98356, 98406);

                    f_1635_98356_98405(_cmdTransportManagers, powerShellCmdId, cmdTM);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 98509, 98592);

                f_1635_98509_98591(
                            // send command ack..so that client can start sending data
                            _stdOutWriter, f_1635_98533_98590(powerShellCmdId));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 97480, 98603);

                System.Management.Automation.Runspaces.TypeTable
                f_1635_97716_97730(System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                this_param)
                {
                    var return_v = this_param.TypeTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 97716, 97730);
                    return return_v;
                }


                System.Management.Automation.Remoting.Fragmentor
                f_1635_97732_97747(System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                this_param)
                {
                    var return_v = this_param.Fragmentor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 97732, 97747);
                    return return_v;
                }


                int
                f_1635_97732_97760(System.Management.Automation.Remoting.Fragmentor
                this_param)
                {
                    var return_v = this_param.FragmentSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 97732, 97760);
                    return return_v;
                }


                System.Management.Automation.Internal.PSRemotingCryptoHelper
                f_1635_97762_97779(System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                this_param)
                {
                    var return_v = this_param.CryptoHelper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 97762, 97779);
                    return return_v;
                }


                System.Management.Automation.Remoting.Server.OutOfProcessServerTransportManager
                f_1635_97613_97780(System.Management.Automation.Remoting.OutOfProcessTextWriter
                stdOutWriter, System.Management.Automation.Remoting.OutOfProcessTextWriter
                stdErrWriter, System.Guid
                powershellInstanceId, System.Management.Automation.Runspaces.TypeTable
                typeTableToUse, int
                fragmentSize, System.Management.Automation.Internal.PSRemotingCryptoHelper
                cryptoHelper)
                {
                    var return_v = new System.Management.Automation.Remoting.Server.OutOfProcessServerTransportManager(stdOutWriter, stdErrWriter, powershellInstanceId, typeTableToUse, fragmentSize, cryptoHelper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 97613, 97780);
                    return return_v;
                }


                int
                f_1635_97980_98021(System.Management.Automation.Remoting.Server.OutOfProcessServerTransportManager
                this_param, System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                transportManager)
                {
                    this_param.MigrateDataReadyEventHandlers((System.Management.Automation.Remoting.BaseTransportManager)transportManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 97980, 98021);
                    return 0;
                }


                bool
                f_1635_98264_98314(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Server.OutOfProcessServerTransportManager>
                this_param, System.Guid
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 98264, 98314);
                    return return_v;
                }


                int
                f_1635_98252_98337(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 98252, 98337);
                    return 0;
                }


                int
                f_1635_98356_98405(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Server.OutOfProcessServerTransportManager>
                this_param, System.Guid
                key, System.Management.Automation.Remoting.Server.OutOfProcessServerTransportManager
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 98356, 98405);
                    return 0;
                }


                string
                f_1635_98533_98590(System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateCommandAckPacket(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 98533, 98590);
                    return return_v;
                }


                int
                f_1635_98509_98591(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 98509, 98591);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 97480, 98603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 97480, 98603);
            }
        }

        internal override AbstractServerTransportManager GetCommandTransportManager(Guid powerShellCmdId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 98615, 98976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 98743, 98754);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 98788, 98837);

                    OutOfProcessServerTransportManager
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 98855, 98918);

                    f_1635_98855_98917(_cmdTransportManagers, powerShellCmdId, out result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 98936, 98950);

                    return result;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 98615, 98976);

                bool
                f_1635_98855_98917(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Server.OutOfProcessServerTransportManager>
                this_param, System.Guid
                key, out System.Management.Automation.Remoting.Server.OutOfProcessServerTransportManager
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 98855, 98917);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 98615, 98976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 98615, 98976);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void RemoveCommandTransportManager(Guid powerShellCmdId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 98988, 99210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 99093, 99104);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 99138, 99184);

                    f_1635_99138_99183(_cmdTransportManagers, powerShellCmdId);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 98988, 99210);

                bool
                f_1635_99138_99183(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Server.OutOfProcessServerTransportManager>
                this_param, System.Guid
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 99138, 99183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 98988, 99210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 98988, 99210);
            }
        }

        internal override void Close(Exception reasonForClose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 99222, 99332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 99301, 99321);

                f_1635_99301_99320(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 99222, 99332);

                int
                f_1635_99301_99320(System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                this_param)
                {
                    this_param.RaiseClosingEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 99301, 99320);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 99222, 99332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 99222, 99332);
            }
        }

        static OutOfProcessServerSessionTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 95544, 99361);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 95544, 99361);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 95544, 99361);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1635, 95544, 99361);

        object
        f_1635_95921_95933()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 95921, 95933);
            return return_v;
        }


        int
        f_1635_96262_96320(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 96262, 96320);
            return 0;
        }


        int
        f_1635_96335_96393(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 96335, 96393);
            return 0;
        }


        System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Server.OutOfProcessServerTransportManager>
        f_1635_96512_96570()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.Server.OutOfProcessServerTransportManager>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 96512, 96570);
            return return_v;
        }


        static int
        f_1635_96182_96222_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1635, 96000, 96582);
            return return_v;
        }

    }
    internal class OutOfProcessServerTransportManager : AbstractServerTransportManager
    {
        private OutOfProcessTextWriter _stdOutWriter;

        private OutOfProcessTextWriter _stdErrWriter;

        private Guid _powershellInstanceId;

        private bool _isDataAckSendPending;

        internal OutOfProcessServerTransportManager(OutOfProcessTextWriter stdOutWriter, OutOfProcessTextWriter stdErrWriter,
                    Guid powershellInstanceId,
                    TypeTable typeTableToUse,
                    int fragmentSize,
                    PSRemotingCryptoHelper cryptoHelper)
        : base(f_1635_100054_100066_C(fragmentSize), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1635, 99756, 100371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 99531, 99544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 99586, 99599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 99668, 99689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 100106, 100135);

                _stdOutWriter = stdOutWriter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 100149, 100178);

                _stdErrWriter = stdErrWriter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 100192, 100237);

                _powershellInstanceId = powershellInstanceId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 100251, 100283);

                this.TypeTable = typeTableToUse;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 100299, 100360);

                this.WSManTransportErrorOccured += HandleWSManTransportError;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1635, 99756, 100371);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 99756, 100371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 99756, 100371);
            }
        }

        private void HandleWSManTransportError(object sender, TransportErrorOccuredEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 100440, 100681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 100552, 100670);

                f_1635_100552_100669(_stdErrWriter, f_1635_100576_100668(f_1635_100594_100637(), f_1635_100639_100667(f_1635_100639_100650(e))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 100440, 100681);

                string
                f_1635_100594_100637()
                {
                    var return_v = RemotingErrorIdStrings.RemoteTransportError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 100594, 100637);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1635_100639_100650(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 100639, 100650);
                    return return_v;
                }


                string
                f_1635_100639_100667(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.TransportMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1635, 100639, 100667);
                    return return_v;
                }


                string
                f_1635_100576_100668(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 100576, 100668);
                    return return_v;
                }


                int
                f_1635_100552_100669(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 100552, 100669);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 100440, 100681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 100440, 100681);
            }
        }

        internal override void ProcessRawData(byte[] data, string stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 100744, 101221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 100834, 100863);

                _isDataAckSendPending = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 100877, 100911);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ProcessRawData(data, stream), 1635, 100877, 100910);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 100927, 101210) || true) && (_isDataAckSendPending)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 100927, 101210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 100986, 101016);

                    _isDataAckSendPending = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 101109, 101195);

                    f_1635_101109_101194(                // Send ACK back to the client as we have processed data.
                                    _stdOutWriter, f_1635_101133_101193(_powershellInstanceId));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 100927, 101210);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 100744, 101221);

                string
                f_1635_101133_101193(System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateDataAckPacket(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 101133, 101193);
                    return return_v;
                }


                int
                f_1635_101109_101194(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 101109, 101194);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 100744, 101221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 100744, 101221);
            }
        }

        internal override void ReportExecutionStatusAsRunning()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 101233, 101350);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 101233, 101350);
                // No-OP for outofProc TMs
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 101233, 101350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 101233, 101350);
            }
        }

        protected override void SendDataToClient(byte[] data, bool flush, bool reportAsPending, bool reportAsDataBoundary)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 101362, 101644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 101501, 101633);

                f_1635_101501_101632(_stdOutWriter, f_1635_101525_101631(data, DataPriorityType.Default, _powershellInstanceId));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 101362, 101644);

                string
                f_1635_101525_101631(byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                streamType, System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateDataPacket(data, streamType, psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 101525, 101631);
                    return return_v;
                }


                int
                f_1635_101501_101632(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 101501, 101632);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 101362, 101644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 101362, 101644);
            }
        }

        internal override void Prepare()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 101656, 102095);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 101713, 102084) || true) && (_isDataAckSendPending)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1635, 101713, 102084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 101772, 101802);

                    _isDataAckSendPending = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 101875, 101890);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Prepare(), 1635, 101875, 101889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 101983, 102069);

                    f_1635_101983_102068(                // Send ACK back to the client as we have processed data.
                                    _stdOutWriter, f_1635_102007_102067(_powershellInstanceId));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1635, 101713, 102084);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 101656, 102095);

                string
                f_1635_102007_102067(System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateDataAckPacket(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 102007, 102067);
                    return return_v;
                }


                int
                f_1635_101983_102068(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 101983, 102068);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 101656, 102095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 101656, 102095);
            }
        }

        internal override void Close(Exception reasonForClose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1635, 102107, 102217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1635, 102186, 102206);

                f_1635_102186_102205(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1635, 102107, 102217);

                int
                f_1635_102186_102205(System.Management.Automation.Remoting.Server.OutOfProcessServerTransportManager
                this_param)
                {
                    this_param.RaiseClosingEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1635, 102186, 102205);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1635, 102107, 102217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 102107, 102217);
            }
        }

        static OutOfProcessServerTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1635, 99369, 102246);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1635, 99369, 102246);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1635, 99369, 102246);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1635, 99369, 102246);

        static int
        f_1635_100054_100066_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1635, 99756, 100371);
            return return_v;
        }

    }
}

