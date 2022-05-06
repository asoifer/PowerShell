// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
#pragma warning disable 1634, 1691

using System.Collections;
using System.Collections.Generic;
using System.Management.Automation.Host;

namespace System.Management.Automation
{
    internal class DefaultCommandRuntime : ICommandRuntime2
    {
        private List<object> _output;

        public DefaultCommandRuntime(List<object> outputList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1263, 711, 931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 504, 511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 1052, 1084);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 789, 883) || true) && (outputList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1263, 789, 883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 830, 883);

                    throw f_1263_836_882("outputList");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1263, 789, 883);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 899, 920);

                _output = outputList;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1263, 711, 931);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 711, 931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 711, 931);
            }
        }

        public PSHost Host { set; get; }

        public void WriteDebug(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 1290, 1330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 1327, 1328);
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 1290, 1330);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 1290, 1330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 1290, 1330);
            }
        }

        public void WriteError(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 1700, 1959);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 1772, 1948) || true) && (f_1263_1776_1797(errorRecord) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1263, 1772, 1948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 1824, 1852);

                    throw f_1263_1830_1851(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1263, 1772, 1948);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1263, 1772, 1948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 1888, 1948);

                    throw f_1263_1894_1947(f_1263_1924_1946(errorRecord));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1263, 1772, 1948);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 1700, 1959);

                System.Exception
                f_1263_1776_1797(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1263, 1776, 1797);
                    return return_v;
                }


                System.Exception
                f_1263_1830_1851(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1263, 1830, 1851);
                    return return_v;
                }


                string
                f_1263_1924_1946(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1263, 1924, 1946);
                    return return_v;
                }


                System.InvalidOperationException
                f_1263_1894_1947(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1263, 1894, 1947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 1700, 1959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 1700, 1959);
            }
        }

        public void WriteObject(object sendToPipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 2214, 2324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 2285, 2313);

                f_1263_2285_2312(_output, sendToPipeline);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 2214, 2324);

                int
                f_1263_2285_2312(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1263, 2285, 2312);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 2214, 2324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 2214, 2324);
            }
        }

        public void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 2774, 3430);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 2871, 3419) || true) && (enumerateCollection)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1263, 2871, 3419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 2928, 2993);

                    IEnumerator
                    e = f_1263_2944_2992(sendToPipeline)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 3011, 3310) || true) && (e == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1263, 3011, 3310);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 3066, 3094);

                        f_1263_3066_3093(_output, sendToPipeline);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1263, 3011, 3310);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1263, 3011, 3310);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 3176, 3291) || true) && (f_1263_3183_3195(e))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1263, 3176, 3291);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 3245, 3268);

                                f_1263_3245_3267(_output, f_1263_3257_3266(e));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1263, 3176, 3291);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1263, 3176, 3291);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1263, 3176, 3291);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1263, 3011, 3310);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1263, 2871, 3419);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1263, 2871, 3419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 3376, 3404);

                    f_1263_3376_3403(_output, sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1263, 2871, 3419);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 2774, 3430);

                System.Collections.IEnumerator
                f_1263_2944_2992(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1263, 2944, 2992);
                    return return_v;
                }


                int
                f_1263_3066_3093(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1263, 3066, 3093);
                    return 0;
                }


                bool
                f_1263_3183_3195(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1263, 3183, 3195);
                    return return_v;
                }


                object
                f_1263_3257_3266(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1263, 3257, 3266);
                    return return_v;
                }


                int
                f_1263_3245_3267(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1263, 3245, 3267);
                    return 0;
                }


                int
                f_1263_3376_3403(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1263, 3376, 3403);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 2774, 3430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 2774, 3430);
            }
        }

        public void WriteProgress(ProgressRecord progressRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 3633, 3694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 3691, 3692);
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 3633, 3694);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 3633, 3694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 3633, 3694);
            }
        }

        public void WriteProgress(Int64 sourceId, ProgressRecord progressRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 3956, 4033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 4030, 4031);
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 3956, 4033);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 3956, 4033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 3956, 4033);
            }
        }

        public void WriteVerbose(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 4215, 4257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 4254, 4255);
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 4215, 4257);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 4215, 4257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 4215, 4257);
            }
        }

        public void WriteWarning(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 4439, 4481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 4478, 4479);
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 4439, 4481);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 4439, 4481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 4439, 4481);
            }
        }

        public void WriteCommandDetail(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 4663, 4711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 4708, 4709);
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 4663, 4711);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 4663, 4711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 4663, 4711);
            }
        }

        public void WriteInformation(InformationRecord informationRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 4908, 4978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 4975, 4976);
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 4908, 4978);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 4908, 4978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 4908, 4978);
            }
        }

        public bool ShouldProcess(string target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 5237, 5294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 5280, 5292);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 5237, 5294);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 5237, 5294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 5237, 5294);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldProcess(string target, string action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 5552, 5624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 5610, 5622);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 5552, 5624);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 5552, 5624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 5552, 5624);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldProcess(string verboseDescription, string verboseWarning, string caption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 5954, 6062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 6048, 6060);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 5954, 6062);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 5954, 6062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 5954, 6062);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldProcess(string verboseDescription, string verboseWarning, string caption, out ShouldProcessReason shouldProcessReason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 6456, 6657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 6595, 6642);

                shouldProcessReason = ShouldProcessReason.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 6643, 6655);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 6456, 6657);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 6456, 6657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 6456, 6657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldContinue(string query, string caption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 6915, 6988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 6974, 6986);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 6915, 6988);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 6915, 6988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 6915, 6988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldContinue(string query, string caption, ref bool yesToAll, ref bool noToAll)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 7351, 7461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 7447, 7459);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 7351, 7461);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 7351, 7461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 7351, 7461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldContinue(string query, string caption, bool hasSecurityImpact, ref bool yesToAll, ref bool noToAll)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 7886, 8020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 8006, 8018);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 7886, 8020);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 7886, 8020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 7886, 8020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TransactionAvailable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 8213, 8265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 8250, 8263);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 8213, 8265);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 8213, 8265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 8213, 8265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSTransactionContext CurrentPSTransaction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 8560, 8923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 8596, 8650);

                    string
                    error = f_1263_8611_8649()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 8865, 8908);

                    throw f_1263_8871_8907(error);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 8560, 8923);

                    string
                    f_1263_8611_8649()
                    {
                        var return_v = TransactionStrings.CmdletRequiresUseTx;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1263, 8611, 8649);
                        return return_v;
                    }


                    System.InvalidOperationException
                    f_1263_8871_8907(string
                    message)
                    {
                        var return_v = new System.InvalidOperationException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1263, 8871, 8907);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 8487, 8934);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 8487, 8934);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void ThrowTerminatingError(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1263, 9372, 9709);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 9455, 9698) || true) && (f_1263_9459_9480(errorRecord) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1263, 9455, 9698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 9522, 9550);

                    throw f_1263_9528_9549(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1263, 9455, 9698);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1263, 9455, 9698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1263, 9616, 9683);

                    throw f_1263_9622_9682(f_1263_9659_9681(errorRecord));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1263, 9455, 9698);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1263, 9372, 9709);

                System.Exception
                f_1263_9459_9480(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1263, 9459, 9480);
                    return return_v;
                }


                System.Exception
                f_1263_9528_9549(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1263, 9528, 9549);
                    return return_v;
                }


                string
                f_1263_9659_9681(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1263, 9659, 9681);
                    return return_v;
                }


                System.InvalidOperationException
                f_1263_9622_9682(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1263, 9622, 9682);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1263, 9372, 9709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 9372, 9709);
            }
        }

        static DefaultCommandRuntime()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1263, 411, 9736);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1263, 411, 9736);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1263, 411, 9736);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1263, 411, 9736);

        System.ArgumentNullException
        f_1263_836_882(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1263, 836, 882);
            return return_v;
        }

    }
}
