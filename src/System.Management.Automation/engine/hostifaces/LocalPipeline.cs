// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Management.Automation.Internal;
using System.Management.Automation.Internal.Host;
using System.Management.Automation.Tracing;
using System.Security.Principal;
using System.Threading;
using Microsoft.PowerShell.Commands;
using Microsoft.Win32;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Runspaces
{
    internal sealed class LocalPipeline : PipelineBase
    {
        internal const int
        DefaultPipelineStackSize = 10_000_000
        ;

        internal LocalPipeline(LocalRunspace runspace, string command, bool addToHistory, bool isNested)
        : base(f_1469_1819_1837_C((Runspace)runspace), command, addToHistory, isNested)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1469, 1702, 1972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 33110, 33118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 43253, 43283);
                this._historyIdForThisPipeline = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46448, 46465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46501, 46524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46558, 46583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46631, 46653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46919, 46955);
                this._invokeHistoryIds = f_1469_46939_46955();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 47605, 47614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 1896, 1933);

                _stopper = f_1469_1907_1932(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 1947, 1961);

                f_1469_1947_1960(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1469, 1702, 1972);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 1702, 1972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 1702, 1972);
            }
        }

        internal LocalPipeline(LocalRunspace runspace,
                    CommandCollection command,
                    bool addToHistory,
                    bool isNested,
                    ObjectStreamBase inputStream,
                    ObjectStreamBase outputStream,
                    ObjectStreamBase errorStream,
                    PSInformationalBuffers infoBuffers)
        : base(f_1469_3515_3523_C(runspace), command, addToHistory, isNested, inputStream, outputStream, errorStream, infoBuffers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1469, 3169, 3711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 33110, 33118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 43253, 43283);
                this._historyIdForThisPipeline = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46448, 46465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46501, 46524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46558, 46583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46631, 46653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46919, 46955);
                this._invokeHistoryIds = f_1469_46939_46955();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 47605, 47614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 3635, 3672);

                _stopper = f_1469_3646_3671(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 3686, 3700);

                f_1469_3686_3699(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1469, 3169, 3711);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 3169, 3711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 3169, 3711);
            }
        }

        internal LocalPipeline(LocalPipeline pipeline)
        : base(f_1469_3952_3976_C((PipelineBase)(pipeline)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1469, 3885, 4078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 33110, 33118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 43253, 43283);
                this._historyIdForThisPipeline = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46448, 46465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46501, 46524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46558, 46583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46631, 46653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46919, 46955);
                this._invokeHistoryIds = f_1469_46939_46955();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 47605, 47614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 4002, 4039);

                _stopper = f_1469_4013_4038(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 4053, 4067);

                f_1469_4053_4066(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1469, 3885, 4078);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 3885, 4078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 3885, 4078);
            }
        }

        public override Pipeline Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 4390, 4705);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 4516, 4637) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 4516, 4637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 4563, 4622);

                    throw f_1469_4569_4621("pipeline");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 4516, 4637);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 4653, 4694);

                return (Pipeline)f_1469_4670_4693(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 4390, 4705);

                System.Management.Automation.PSObjectDisposedException
                f_1469_4569_4621(string
                objectName)
                {
                    var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 4569, 4621);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalPipeline
                f_1469_4670_4693(System.Management.Automation.Runspaces.LocalPipeline
                pipeline)
                {
                    var return_v = new System.Management.Automation.Runspaces.LocalPipeline(pipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 4670, 4693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 4390, 4705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 4390, 4705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void StartPipelineExecution()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 5027, 10667);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 5170, 5291) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 5170, 5291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 5217, 5276);

                    throw f_1469_5223_5275("pipeline");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 5170, 5291);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 5941, 6007);

                _useExternalInput = (f_1469_5962_5980(f_1469_5962_5973()) || (DynAbs.Tracing.TraceSender.Expression_False(1469, 5962, 6005) || f_1469_5984_6001(f_1469_5984_5995()) > 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 6023, 6139);

                PSThreadOptions
                memberOptions = (DynAbs.Tracing.TraceSender.Conditional_F1(1469, 6055, 6068) || ((f_1469_6055_6068(this) && DynAbs.Tracing.TraceSender.Conditional_F2(1469, 6071, 6103)) || DynAbs.Tracing.TraceSender.Conditional_F3(1469, 6106, 6138))) ? PSThreadOptions.UseCurrentThread : f_1469_6106_6138(f_1469_6106_6124(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 6253, 6320);

                ThreadStart
                invokeThreadProcDelegate = InvokeThreadProcImpersonate
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 6334, 6364);

                _identityToImpersonate = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 6488, 6683) || true) && ((f_1469_6493_6511() != null) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 6492, 6566) && f_1469_6524_6566(f_1469_6524_6542())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 6488, 6683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 6600, 6668);

                    f_1469_6600_6667(out _identityToImpersonate);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 6488, 6683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 6849, 10656);

                switch (memberOptions)
                {

                    case PSThreadOptions.Default:
                    case PSThreadOptions.UseNewThread:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 6849, 10656);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 7194, 7296);

                            Thread
                            invokeThread = f_1469_7216_7295(new ThreadStart(invokeThreadProcDelegate), DefaultPipelineStackSize)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 7322, 7360);

                            f_1469_7322_7359(this, invokeThread, true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 7388, 7418);

                            ApartmentState
                            apartmentState
                            = default(ApartmentState);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 7446, 7916) || true) && (f_1469_7450_7468() != null && (DynAbs.Tracing.TraceSender.Expression_True(1469, 7450, 7539) && f_1469_7480_7513(f_1469_7480_7498()) != ApartmentState.Unknown))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 7446, 7916);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 7597, 7648);

                                apartmentState = f_1469_7614_7647(f_1469_7614_7632());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 7446, 7916);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 7446, 7916);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 7802, 7853);

                                apartmentState = f_1469_7819_7852(f_1469_7819_7837(this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 7446, 7916);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 7955, 8176) || true) && (apartmentState != ApartmentState.Unknown && (DynAbs.Tracing.TraceSender.Expression_True(1469, 7959, 8025) && f_1469_8003_8025_M(!Platform.IsNanoServer)) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 7959, 8044) && f_1469_8029_8044_M(!Platform.IsIoT)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 7955, 8176);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 8102, 8149);

                                f_1469_8102_8148(invokeThread, apartmentState);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 7955, 8176);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 8212, 8233);

                            f_1469_8212_8232(
                                                    invokeThread);
                            DynAbs.Tracing.TraceSender.TraceBreak(1469, 8261, 8267);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 6849, 10656);

                    case PSThreadOptions.ReuseThread:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 6849, 10656);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 8392, 9360) || true) && (f_1469_8396_8409(this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 8392, 9360);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 8712, 8758);

                                f_1469_8712_8757(this, f_1469_8730_8750(), true);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 8788, 8807);

                                f_1469_8788_8806(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 8392, 9360);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 8392, 9360);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 9114, 9183);

                                PipelineThread
                                invokeThread = f_1469_9144_9182(f_1469_9144_9162(this))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 9213, 9258);

                                f_1469_9213_9257(this, f_1469_9231_9250(invokeThread), true);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 9288, 9333);

                                f_1469_9288_9332(invokeThread, invokeThreadProcDelegate);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 8392, 9360);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1469, 9388, 9394);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 6849, 10656);

                    case PSThreadOptions.UseCurrentThread:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 6849, 10656);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 9524, 9587);

                            Thread
                            oldNestedPipelineThread = f_1469_9557_9586()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 9615, 9674);

                            CultureInfo
                            oldCurrentCulture = f_1469_9647_9673()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 9700, 9763);

                            CultureInfo
                            oldCurrentUICulture = f_1469_9734_9762()
                            ;

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 10014, 10061);

                                f_1469_10014_10060(this, f_1469_10032_10052(), false);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 10091, 10110);

                                f_1469_10091_10109(this);
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinally(1469, 10163, 10486);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 10227, 10283);

                                NestedPipelineExecutionThread = oldNestedPipelineThread;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 10313, 10369);

                                f_1469_10313_10333().CurrentCulture = oldCurrentCulture;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 10399, 10459);

                                f_1469_10399_10419().CurrentUICulture = oldCurrentUICulture;
                                DynAbs.Tracing.TraceSender.TraceExitFinally(1469, 10163, 10486);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1469, 10514, 10520);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 6849, 10656);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 6849, 10656);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 10593, 10613);

                        f_1469_10593_10612(false);
                        DynAbs.Tracing.TraceSender.TraceBreak(1469, 10635, 10641);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 6849, 10656);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 5027, 10667);

                System.Management.Automation.PSObjectDisposedException
                f_1469_5223_5275(string
                objectName)
                {
                    var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 5223, 5275);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_5962_5973()
                {
                    var return_v = InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 5962, 5973);
                    return return_v;
                }


                bool
                f_1469_5962_5980(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.IsOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 5962, 5980);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_5984_5995()
                {
                    var return_v = InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 5984, 5995);
                    return return_v;
                }


                int
                f_1469_5984_6001(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 5984, 6001);
                    return return_v;
                }


                bool
                f_1469_6055_6068(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 6055, 6068);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_6106_6124(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 6106, 6124);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSThreadOptions
                f_1469_6106_6138(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ThreadOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 6106, 6138);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_6493_6511()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 6493, 6511);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_6524_6542()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 6524, 6542);
                    return return_v;
                }


                bool
                f_1469_6524_6566(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.FlowImpersonationPolicy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 6524, 6566);
                    return return_v;
                }


                bool
                f_1469_6600_6667(out System.Security.Principal.WindowsIdentity
                impersonatedIdentity)
                {
                    var return_v = Utils.TryGetWindowsImpersonatedIdentity(out impersonatedIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 6600, 6667);
                    return return_v;
                }


                System.Threading.Thread
                f_1469_7216_7295(System.Threading.ThreadStart
                start, int
                maxStackSize)
                {
                    var return_v = new System.Threading.Thread(start, maxStackSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 7216, 7295);
                    return return_v;
                }


                int
                f_1469_7322_7359(System.Management.Automation.Runspaces.LocalPipeline
                this_param, System.Threading.Thread
                invokeThread, bool
                changeName)
                {
                    this_param.SetupInvokeThread(invokeThread, changeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 7322, 7359);
                    return 0;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_7450_7468()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 7450, 7468);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_7480_7498()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 7480, 7498);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1469_7480_7513(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 7480, 7513);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_7614_7632()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 7614, 7632);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1469_7614_7647(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 7614, 7647);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_7819_7837(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 7819, 7837);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1469_7819_7852(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 7819, 7852);
                    return return_v;
                }


                bool
                f_1469_8003_8025_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 8003, 8025);
                    return return_v;
                }


                bool
                f_1469_8029_8044_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 8029, 8044);
                    return return_v;
                }


                int
                f_1469_8102_8148(System.Threading.Thread
                this_param, System.Threading.ApartmentState
                state)
                {
                    this_param.SetApartmentState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 8102, 8148);
                    return 0;
                }


                int
                f_1469_8212_8232(System.Threading.Thread
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 8212, 8232);
                    return 0;
                }


                bool
                f_1469_8396_8409(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 8396, 8409);
                    return return_v;
                }


                System.Threading.Thread
                f_1469_8730_8750()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 8730, 8750);
                    return return_v;
                }


                int
                f_1469_8712_8757(System.Management.Automation.Runspaces.LocalPipeline
                this_param, System.Threading.Thread
                invokeThread, bool
                changeName)
                {
                    this_param.SetupInvokeThread(invokeThread, changeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 8712, 8757);
                    return 0;
                }


                int
                f_1469_8788_8806(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    this_param.InvokeThreadProc();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 8788, 8806);
                    return 0;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_9144_9162(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 9144, 9162);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineThread
                f_1469_9144_9182(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.GetPipelineThread();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 9144, 9182);
                    return return_v;
                }


                System.Threading.Thread
                f_1469_9231_9250(System.Management.Automation.Runspaces.PipelineThread
                this_param)
                {
                    var return_v = this_param.Worker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 9231, 9250);
                    return return_v;
                }


                int
                f_1469_9213_9257(System.Management.Automation.Runspaces.LocalPipeline
                this_param, System.Threading.Thread
                invokeThread, bool
                changeName)
                {
                    this_param.SetupInvokeThread(invokeThread, changeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 9213, 9257);
                    return 0;
                }


                int
                f_1469_9288_9332(System.Management.Automation.Runspaces.PipelineThread
                this_param, System.Threading.ThreadStart
                workItem)
                {
                    this_param.Start(workItem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 9288, 9332);
                    return 0;
                }


                System.Threading.Thread
                f_1469_9557_9586()
                {
                    var return_v = NestedPipelineExecutionThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 9557, 9586);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1469_9647_9673()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 9647, 9673);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1469_9734_9762()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 9734, 9762);
                    return return_v;
                }


                System.Threading.Thread
                f_1469_10032_10052()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 10032, 10052);
                    return return_v;
                }


                int
                f_1469_10014_10060(System.Management.Automation.Runspaces.LocalPipeline
                this_param, System.Threading.Thread
                invokeThread, bool
                changeName)
                {
                    this_param.SetupInvokeThread(invokeThread, changeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 10014, 10060);
                    return 0;
                }


                int
                f_1469_10091_10109(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    this_param.InvokeThreadProc();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 10091, 10109);
                    return 0;
                }


                System.Threading.Thread
                f_1469_10313_10333()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 10313, 10333);
                    return return_v;
                }


                System.Threading.Thread
                f_1469_10399_10419()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 10399, 10419);
                    return return_v;
                }


                int
                f_1469_10593_10612(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 10593, 10612);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 5027, 10667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 5027, 10667);
            }
        }

        private void SetupInvokeThread(Thread invokeThread, bool changeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 10781, 11422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 10874, 10919);

                NestedPipelineExecutionThread = invokeThread;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 11232, 11411) || true) && ((f_1469_11237_11254(invokeThread) == null) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 11236, 11277) && changeName))
                ) // setup the invoke thread only once

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 11232, 11411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 11348, 11396);

                    invokeThread.Name = "Pipeline Execution Thread";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 11232, 11411);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 10781, 11422);

                string
                f_1469_11237_11254(System.Threading.Thread
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 11237, 11254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 10781, 11422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 10781, 11422);
            }
        }

        private FlowControlException InvokeHelper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 11652, 23893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 11720, 11769);

                FlowControlException
                flowControlException = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 11785, 11828);

                PipelineProcessor
                pipelineProcessor = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 12262, 12289);

                    f_1469_12262_12288(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 12358, 12384);

                    f_1469_12358_12383(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 12490, 14620) || true) && (f_1469_12494_12511(this) || (DynAbs.Tracing.TraceSender.Expression_False(1469, 12494, 12524) || f_1469_12515_12524_M(!IsNested)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 12490, 14620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 12566, 12598);

                        bool
                        needToAddOutDefault = true
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 12620, 12761);

                        CommandInfo
                        outDefaultCommandInfo = f_1469_12656_12760("Out-Default", typeof(Microsoft.PowerShell.Commands.OutDefaultCommand), null, null, null)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 12785, 13983);
                            foreach (Command command in f_1469_12813_12826_I(f_1469_12813_12826(this)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 12785, 13983);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 12876, 13198) || true) && (f_1469_12880_12896(command) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 12880, 12923) && (f_1469_12901_12922_M(!this.IsPulsePipeline))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 12876, 13198);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 13069, 13171);

                                    f_1469_13069_13170(f_1469_13069_13125(f_1469_13069_13122(f_1469_13069_13102(f_1469_13069_13082(this)))), f_1469_13144_13163(command), null);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 12876, 13198);
                                }

                                if (
                                (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 13414, 13960) || true) && (f_1469_13448_13546(f_1469_13462_13488(outDefaultCommandInfo), f_1469_13490_13509(command), StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1469, 13448, 13674) || f_1469_13579_13674("PSConsoleHostReadLine", f_1469_13618_13637(command), StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1469, 13448, 13794) || f_1469_13707_13794("TabExpansion2", f_1469_13738_13757(command), StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1469, 13448, 13847) || f_1469_13827_13847(this)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 13414, 13960);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 13905, 13933);

                                    needToAddOutDefault = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 13414, 13960);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 12785, 13983);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1469, 1, 1199);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1469, 1, 1199);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 14007, 14601) || true) && (f_1469_14011_14082(f_1469_14011_14067(f_1469_14011_14064(f_1469_14011_14044(f_1469_14011_14024(this))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 14007, 14601);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 14132, 14578) || true) && (needToAddOutDefault)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 14132, 14578);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 14213, 14276);

                                Command
                                outDefaultCommand = f_1469_14241_14275(outDefaultCommandInfo)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 14306, 14381);

                                f_1469_14306_14380(f_1469_14306_14334(outDefaultCommand), f_1469_14339_14379("Transcript", true));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 14411, 14487);

                                f_1469_14411_14486(f_1469_14411_14439(outDefaultCommand), f_1469_14444_14485("OutVariable", null));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 14519, 14551);

                                f_1469_14519_14550(f_1469_14519_14527(), outDefaultCommand);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 14132, 14578);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 14007, 14601);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 12490, 14620);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 14757, 14803);

                        pipelineProcessor = f_1469_14777_14802(this);
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 14840, 15148);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 14901, 15099) || true) && (f_1469_14905_14933(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 14901, 15099);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 14983, 15002);

                            f_1469_14983_15001(this, true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 15028, 15076);

                            f_1469_15028_15075(f_1469_15028_15053(f_1469_15028_15036()), ex);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 14901, 15099);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 15123, 15129);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 14840, 15148);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 15310, 15451) || true) && (_useExternalInput)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 15310, 15451);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 15373, 15432);

                        pipelineProcessor.ExternalInput = f_1469_15407_15431(f_1469_15407_15418());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 15310, 15451);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 15471, 15539);

                    pipelineProcessor.ExternalSuccessOutput = f_1469_15513_15538(f_1469_15513_15525());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 15557, 15622);

                    pipelineProcessor.ExternalErrorOutput = f_1469_15597_15621(f_1469_15597_15608());

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 15796, 15982) || true) && (f_1469_15800_15813_M(!this.IsChild))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 15796, 15982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 15855, 15963);

                        f_1469_15855_15962(f_1469_15855_15909(f_1469_15855_15898(f_1469_15855_15885(f_1469_15855_15868()))), f_1469_15941_15961());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 15796, 15982);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 16002, 16035);

                    bool
                    oldQuestionMarkValue = true
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 16053, 16137);

                    bool
                    savedIgnoreScriptDebug = f_1469_16083_16136(f_1469_16083_16118(f_1469_16083_16101(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 16221, 16322);

                    bool
                    oldTrapState = f_1469_16241_16321(f_1469_16241_16276(f_1469_16241_16259(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 16340, 16429);

                    f_1469_16340_16375(f_1469_16340_16358(this)).PropagateExceptionsToEnclosingStatementBlock = false;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 16546, 16579);

                        f_1469_16546_16578(                    // Add this pipeline to stopper
                                            _stopper, pipelineProcessor);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 16690, 17112) || true) && (f_1469_16694_16707_M(!AddToHistory))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 16690, 17112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 16757, 16842);

                            oldQuestionMarkValue = f_1469_16780_16841(f_1469_16780_16815(f_1469_16780_16798(this)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 16868, 16929);

                            f_1469_16868_16903(f_1469_16868_16886(this)).IgnoreScriptDebug = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 16690, 17112);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 16690, 17112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 17027, 17089);

                            f_1469_17027_17062(f_1469_17027_17045(this)).IgnoreScriptDebug = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 16690, 17112);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 17271, 17442) || true) && (f_1469_17275_17289_M(!this.IsNested) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 17275, 17314) && f_1469_17293_17314_M(!this.IsPulsePipeline)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 17271, 17442);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 17364, 17419);

                            f_1469_17364_17418(f_1469_17364_17399(f_1469_17364_17382(this)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 17271, 17442);
                        }

                        // Invoke the pipeline.
                        // Note:Since we are using pipes for output, return array is
                        // be empty.
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 17679, 17747);

                            f_1469_17679_17746(pipelineProcessor, f_1469_17725_17745());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 17773, 17821);

                            f_1469_17773_17820(this, f_1469_17786_17819(pipelineProcessor));
                        }
                        catch (ExitException ee)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 17866, 20173);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 18310, 18358);

                            f_1469_18310_18357(this, f_1469_18323_18356(pipelineProcessor));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 18384, 18401);

                            int
                            exitCode = 1
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 18427, 20150) || true) && (f_1469_18431_18439())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 18427, 20150);
                                // set the global LASTEXITCODE to the value passed by exit <code>
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 18660, 18688);

                                    exitCode = (int)f_1469_18676_18687(ee);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 18722, 18818);

                                    f_1469_18722_18817(f_1469_18722_18757(f_1469_18722_18740(this)), SpecialVariables.LastExitCodeVarPath, exitCode);
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1469, 18879, 19414);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 19027, 19102);

                                        f_1469_19027_19101(f_1469_19027_19082(f_1469_19027_19062(f_1469_19027_19045(this))));
                                    }
                                    catch (ExitNestedPromptException)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 19171, 19383);
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 19171, 19383);
                                        // Already at the top level so we just want to ignore this exception...
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitFinally(1469, 18879, 19414);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 18427, 20150);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 18427, 20150);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 19596, 19624);

                                    exitCode = (int)f_1469_19612_19623(ee);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 19660, 19879) || true) && ((f_1469_19665_19683() != null) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 19664, 19744) && (f_1469_19697_19743(f_1469_19697_19715()))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 19660, 19879);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 19818, 19844);

                                        flowControlException = ee;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 19660, 19879);
                                    }
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1469, 19940, 20123);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 20012, 20092);

                                    f_1469_20012_20091(f_1469_20012_20067(f_1469_20012_20047(f_1469_20012_20030(this))), exitCode);
                                    DynAbs.Tracing.TraceSender.TraceExitFinally(1469, 19940, 20123);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 18427, 20150);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 17866, 20173);
                        }
                        catch (ExitNestedPromptException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 20195, 20274);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 20195, 20274);
                        }
                        catch (FlowControlException e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 20296, 20931);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 20375, 20763) || true) && ((f_1469_20380_20398() != null) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 20379, 20459) && (f_1469_20412_20458(f_1469_20412_20430()))) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 20379, 20572) && ((e is BreakException) || (DynAbs.Tracing.TraceSender.Expression_False(1469, 20493, 20542) || (e is ContinueException)) || (DynAbs.Tracing.TraceSender.Expression_False(1469, 20493, 20571) || (e is TerminateException)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 20375, 20763);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 20711, 20736);

                                flowControlException = e;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 20375, 20763);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 20296, 20931);

                            // Otherwise discard this type of exception generated by the debugger or from an unhandled break, continue or return.
                        }
                        catch (Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 20953, 21169);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 21095, 21114);

                            f_1469_21095_21113(this, true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 21140, 21146);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 20953, 21169);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1469, 21206, 23317);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 21322, 22088) || true) && (pipelineProcessor != null && (DynAbs.Tracing.TraceSender.Expression_True(1469, 21326, 21389) && f_1469_21355_21381(pipelineProcessor) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 21322, 22088);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 21448, 21453);
                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 21439, 22065) || true) && (i < f_1469_21459_21491(f_1469_21459_21485(pipelineProcessor)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 21493, 21496)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 21439, 22065))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 21439, 22065);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 21554, 21624);

                                    CommandProcessorBase
                                    commandProcessor = f_1469_21594_21623(f_1469_21594_21620(pipelineProcessor), i)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 21656, 21719);

                                    f_1469_21656_21718(f_1469_21682_21717(commandProcessor));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 21816, 22038);

                                    f_1469_21816_22037(f_1469_21882_21906(commandProcessor), CommandState.Terminated, f_1469_21999_22036(f_1469_21999_22023(commandProcessor)));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1469, 1, 627);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1469, 1, 627);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 21322, 22088);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 22112, 22191);

                        PSLocalEventManager
                        eventManager = f_1469_22147_22167(f_1469_22147_22160()) as PSLocalEventManager
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 22213, 22347) || true) && (eventManager != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 22213, 22347);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 22287, 22324);

                            f_1469_22287_22323(eventManager);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 22213, 22347);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 22421, 22517);

                        f_1469_22421_22456(f_1469_22421_22439(this)).PropagateExceptionsToEnclosingStatementBlock = oldTrapState;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 22695, 22826) || true) && (f_1469_22699_22707_M(!IsChild))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 22695, 22826);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 22734, 22826);

                            f_1469_22734_22825(f_1469_22734_22788(f_1469_22734_22777(f_1469_22734_22764(f_1469_22734_22747()))), null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 22695, 22826);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 22915, 22935);

                        f_1469_22915_22934(
                                            // Pop the pipeline processor from stopper.
                                            _stopper, false);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 22959, 23134) || true) && (f_1469_22963_22976_M(!AddToHistory))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 22959, 23134);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 23026, 23111);

                            f_1469_23026_23061(f_1469_23026_23044(this)).QuestionMarkVariableValue = oldQuestionMarkValue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 22959, 23134);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 23219, 23298);

                        f_1469_23219_23254(f_1469_23219_23237(this)).IgnoreScriptDebug = savedIgnoreScriptDebug;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1469, 21206, 23317);
                    }
                }
                catch (FlowControlException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 23346, 23529);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 23346, 23529);
                    // Discard this type of exception generated by the debugger or from an unhandled break, continue or return.
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1469, 23543, 23838);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 23658, 23823) || true) && (pipelineProcessor != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 23658, 23823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 23729, 23757);

                        f_1469_23729_23756(pipelineProcessor);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 23779, 23804);

                        pipelineProcessor = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 23658, 23823);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1469, 23543, 23838);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 23854, 23882);

                return flowControlException;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 11652, 23893);

                int
                f_1469_12262_12288(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    this_param.RaisePipelineStateEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 12262, 12288);
                    return 0;
                }


                int
                f_1469_12358_12383(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    this_param.RecordPipelineStartTime();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 12358, 12383);
                    return 0;
                }


                bool
                f_1469_12494_12511(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.AddToHistory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 12494, 12511);
                    return return_v;
                }


                bool
                f_1469_12515_12524_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 12515, 12524);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1469_12656_12760(string
                name, System.Type
                implementingType, string
                helpFile, System.Management.Automation.PSSnapInInfo
                PSSnapin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType, helpFile, PSSnapin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 12656, 12760);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1469_12813_12826(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 12813, 12826);
                    return return_v;
                }


                bool
                f_1469_12880_12896(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.IsScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 12880, 12896);
                    return return_v;
                }


                bool
                f_1469_12901_12922_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 12901, 12922);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1469_13069_13082(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 13069, 13082);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_13069_13102(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 13069, 13102);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1469_13069_13122(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 13069, 13122);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1469_13069_13125(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 13069, 13125);
                    return return_v;
                }


                string
                f_1469_13144_13163(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 13144, 13163);
                    return return_v;
                }


                int
                f_1469_13069_13170(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                commandText, System.Management.Automation.InvocationInfo
                invocation)
                {
                    this_param.TranscribeCommand(commandText, invocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 13069, 13170);
                    return 0;
                }


                string
                f_1469_13462_13488(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 13462, 13488);
                    return return_v;
                }


                string
                f_1469_13490_13509(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 13490, 13509);
                    return return_v;
                }


                bool
                f_1469_13448_13546(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 13448, 13546);
                    return return_v;
                }


                string
                f_1469_13618_13637(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 13618, 13637);
                    return return_v;
                }


                bool
                f_1469_13579_13674(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 13579, 13674);
                    return return_v;
                }


                string
                f_1469_13738_13757(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 13738, 13757);
                    return return_v;
                }


                bool
                f_1469_13707_13794(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 13707, 13794);
                    return return_v;
                }


                bool
                f_1469_13827_13847(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.IsPulsePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 13827, 13847);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1469_12813_12826_I(System.Management.Automation.Runspaces.CommandCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 12813, 12826);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1469_14011_14024(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 14011, 14024);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_14011_14044(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 14011, 14044);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1469_14011_14064(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 14011, 14064);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1469_14011_14067(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 14011, 14067);
                    return return_v;
                }


                bool
                f_1469_14011_14082(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.IsTranscribing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 14011, 14082);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1469_14241_14275(System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 14241, 14275);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1469_14306_14334(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 14306, 14334);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1469_14339_14379(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.Runspaces.CommandParameter(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 14339, 14379);
                    return return_v;
                }


                int
                f_1469_14306_14380(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, System.Management.Automation.Runspaces.CommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 14306, 14380);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1469_14411_14439(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 14411, 14439);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1469_14444_14485(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.Runspaces.CommandParameter(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 14444, 14485);
                    return return_v;
                }


                int
                f_1469_14411_14486(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, System.Management.Automation.Runspaces.CommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 14411, 14486);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1469_14519_14527()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 14519, 14527);
                    return return_v;
                }


                int
                f_1469_14519_14550(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 14519, 14550);
                    return 0;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1469_14777_14802(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.CreatePipelineProcessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 14777, 14802);
                    return return_v;
                }


                bool
                f_1469_14905_14933(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.SetPipelineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 14905, 14933);
                    return return_v;
                }


                int
                f_1469_14983_15001(System.Management.Automation.Runspaces.LocalPipeline
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 14983, 15001);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1469_15028_15036()
                {
                    var return_v = Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15028, 15036);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_15028_15053(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15028, 15053);
                    return return_v;
                }


                int
                f_1469_15028_15075(System.Management.Automation.ExecutionContext
                this_param, System.Exception
                obj)
                {
                    this_param.AppendDollarError((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 15028, 15075);
                    return 0;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_15407_15418()
                {
                    var return_v = InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15407, 15418);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineReader<object>
                f_1469_15407_15431(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.ObjectReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15407, 15431);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_15513_15525()
                {
                    var return_v = OutputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15513, 15525);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineWriter
                f_1469_15513_15538(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.ObjectWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15513, 15538);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_15597_15608()
                {
                    var return_v = ErrorStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15597, 15608);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineWriter
                f_1469_15597_15621(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.ObjectWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15597, 15621);
                    return return_v;
                }


                bool
                f_1469_15800_15813_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15800, 15813);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_15855_15868()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15855, 15868);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_15855_15885(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15855, 15885);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1469_15855_15898(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15855, 15898);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1469_15855_15909(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15855, 15909);
                    return return_v;
                }


                System.Management.Automation.PSInformationalBuffers
                f_1469_15941_15961()
                {
                    var return_v = InformationalBuffers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 15941, 15961);
                    return return_v;
                }


                int
                f_1469_15855_15962(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.PSInformationalBuffers
                informationalBuffers)
                {
                    this_param.SetInformationalMessageBuffers(informationalBuffers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 15855, 15962);
                    return 0;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_16083_16101(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16083, 16101);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_16083_16118(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16083, 16118);
                    return return_v;
                }


                bool
                f_1469_16083_16136(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.IgnoreScriptDebug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16083, 16136);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_16241_16259(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16241, 16259);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_16241_16276(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16241, 16276);
                    return return_v;
                }


                bool
                f_1469_16241_16321(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.PropagateExceptionsToEnclosingStatementBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16241, 16321);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_16340_16358(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16340, 16358);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_16340_16375(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16340, 16375);
                    return return_v;
                }


                int
                f_1469_16546_16578(System.Management.Automation.Runspaces.PipelineStopper
                this_param, System.Management.Automation.Internal.PipelineProcessor
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 16546, 16578);
                    return 0;
                }


                bool
                f_1469_16694_16707_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16694, 16707);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_16780_16798(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16780, 16798);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_16780_16815(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16780, 16815);
                    return return_v;
                }


                bool
                f_1469_16780_16841(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.QuestionMarkVariableValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16780, 16841);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_16868_16886(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16868, 16886);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_16868_16903(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 16868, 16903);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_17027_17045(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 17027, 17045);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_17027_17062(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 17027, 17062);
                    return return_v;
                }


                bool
                f_1469_17275_17289_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 17275, 17289);
                    return return_v;
                }


                bool
                f_1469_17293_17314_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 17293, 17314);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_17364_17382(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 17364, 17382);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_17364_17399(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 17364, 17399);
                    return return_v;
                }


                int
                f_1469_17364_17418(System.Management.Automation.ExecutionContext
                this_param)
                {
                    this_param.ResetRedirection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 17364, 17418);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1469_17725_17745()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 17725, 17745);
                    return return_v;
                }


                System.Array
                f_1469_17679_17746(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.PSObject
                input)
                {
                    var return_v = this_param.SynchronousExecuteEnumerate((object)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 17679, 17746);
                    return return_v;
                }


                bool
                f_1469_17786_17819(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    var return_v = this_param.ExecutionFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 17786, 17819);
                    return return_v;
                }


                int
                f_1469_17773_17820(System.Management.Automation.Runspaces.LocalPipeline
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 17773, 17820);
                    return 0;
                }


                bool
                f_1469_18323_18356(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    var return_v = this_param.ExecutionFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 18323, 18356);
                    return return_v;
                }


                int
                f_1469_18310_18357(System.Management.Automation.Runspaces.LocalPipeline
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 18310, 18357);
                    return 0;
                }


                bool
                f_1469_18431_18439()
                {
                    var return_v = IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 18431, 18439);
                    return return_v;
                }


                object
                f_1469_18676_18687(System.Management.Automation.ExitException
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 18676, 18687);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_18722_18740(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 18722, 18740);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_18722_18757(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 18722, 18757);
                    return return_v;
                }


                int
                f_1469_18722_18817(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, int
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 18722, 18817);
                    return 0;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_19027_19045(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 19027, 19045);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_19027_19062(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 19027, 19062);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1469_19027_19082(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 19027, 19082);
                    return return_v;
                }


                int
                f_1469_19027_19101(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    this_param.ExitNestedPrompt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 19027, 19101);
                    return 0;
                }


                object
                f_1469_19612_19623(System.Management.Automation.ExitException
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 19612, 19623);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_19665_19683()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 19665, 19683);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_19697_19715()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 19697, 19715);
                    return return_v;
                }


                bool
                f_1469_19697_19743(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.ExposeFlowControlExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 19697, 19743);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_20012_20030(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 20012, 20030);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_20012_20047(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 20012, 20047);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1469_20012_20067(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 20012, 20067);
                    return return_v;
                }


                int
                f_1469_20012_20091(System.Management.Automation.Internal.Host.InternalHost
                this_param, int
                exitCode)
                {
                    this_param.SetShouldExit(exitCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 20012, 20091);
                    return 0;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_20380_20398()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 20380, 20398);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_20412_20430()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 20412, 20430);
                    return return_v;
                }


                bool
                f_1469_20412_20458(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.ExposeFlowControlExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 20412, 20458);
                    return return_v;
                }


                int
                f_1469_21095_21113(System.Management.Automation.Runspaces.LocalPipeline
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 21095, 21113);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
                f_1469_21355_21381(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 21355, 21381);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
                f_1469_21459_21485(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 21459, 21485);
                    return return_v;
                }


                int
                f_1469_21459_21491(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 21459, 21491);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
                f_1469_21594_21620(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 21594, 21620);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1469_21594_21623(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 21594, 21623);
                    return return_v;
                }


                System.Guid
                f_1469_21682_21717(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.PipelineActivityId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 21682, 21717);
                    return return_v;
                }


                bool
                f_1469_21656_21718(System.Guid
                activityId)
                {
                    var return_v = EtwActivity.SetActivityId(activityId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 21656, 21718);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_21882_21906(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 21882, 21906);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1469_21999_22023(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 21999, 22023);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1469_21999_22036(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 21999, 22036);
                    return return_v;
                }


                int
                f_1469_21816_22037(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.CommandState
                commandState, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    MshLog.LogCommandLifecycleEvent(executionContext, commandState, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 21816, 22037);
                    return 0;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_22147_22160()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 22147, 22160);
                    return return_v;
                }


                System.Management.Automation.PSEventManager
                f_1469_22147_22167(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 22147, 22167);
                    return return_v;
                }


                int
                f_1469_22287_22323(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.ProcessPendingActions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 22287, 22323);
                    return 0;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_22421_22439(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 22421, 22439);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_22421_22456(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 22421, 22456);
                    return return_v;
                }


                bool
                f_1469_22699_22707_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 22699, 22707);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_22734_22747()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 22734, 22747);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_22734_22764(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 22734, 22764);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1469_22734_22777(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 22734, 22777);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1469_22734_22788(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 22734, 22788);
                    return return_v;
                }


                int
                f_1469_22734_22825(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.PSInformationalBuffers
                informationalBuffers)
                {
                    this_param.SetInformationalMessageBuffers(informationalBuffers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 22734, 22825);
                    return 0;
                }


                int
                f_1469_22915_22934(System.Management.Automation.Runspaces.PipelineStopper
                this_param, bool
                fromSteppablePipeline)
                {
                    this_param.Pop(fromSteppablePipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 22915, 22934);
                    return 0;
                }


                bool
                f_1469_22963_22976_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 22963, 22976);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_23026_23044(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 23026, 23044);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_23026_23061(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 23026, 23061);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_23219_23237(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 23219, 23237);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_23219_23254(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 23219, 23254);
                    return return_v;
                }


                int
                f_1469_23729_23756(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 23729, 23756);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 11652, 23893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 11652, 23893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void InvokeThreadProcImpersonate()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 24092, 24452);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 24159, 24406) || true) && (_identityToImpersonate != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 24159, 24406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 24227, 24364);

                    f_1469_24227_24363(f_1469_24281_24315(_identityToImpersonate), () => InvokeThreadProc());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 24384, 24391);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 24159, 24406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 24422, 24441);

                f_1469_24422_24440(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 24092, 24452);

                Microsoft.Win32.SafeHandles.SafeAccessTokenHandle
                f_1469_24281_24315(System.Security.Principal.WindowsIdentity
                this_param)
                {
                    var return_v = this_param.AccessToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 24281, 24315);
                    return return_v;
                }


                int
                f_1469_24227_24363(Microsoft.Win32.SafeHandles.SafeAccessTokenHandle
                safeAccessTokenHandle, System.Action
                action)
                {
                    WindowsIdentity.RunImpersonated(safeAccessTokenHandle, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 24227, 24363);
                    return 0;
                }


                int
                f_1469_24422_24440(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    this_param.InvokeThreadProc();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 24422, 24440);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 24092, 24452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 24092, 24452);
            }
        }

        private void InvokeThreadProc()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 24589, 32312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 24645, 24683);

                bool
                incompleteParseException = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 24697, 24757);

                Runspace
                previousDefaultRunspace = f_1469_24732_24756()
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 24879, 25513) || true) && (f_1469_24883_24901() != null && (DynAbs.Tracing.TraceSender.Expression_True(1469, 24883, 24944) && f_1469_24913_24936(f_1469_24913_24931()) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 24879, 25513);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 24986, 25054);

                        InternalHost
                        internalHost = f_1469_25014_25037(f_1469_25014_25032()) as InternalHost
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 25078, 25494) || true) && (internalHost != null)
                        ) // if we are given an internal host, use the external host

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 25078, 25494);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 25211, 25293);

                            f_1469_25211_25292(f_1469_25211_25254(f_1469_25211_25241(f_1469_25211_25224())), f_1469_25266_25291(internalHost));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 25078, 25494);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 25078, 25494);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 25391, 25471);

                            f_1469_25391_25470(f_1469_25391_25434(f_1469_25391_25421(f_1469_25391_25404())), f_1469_25446_25469(f_1469_25446_25464()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 25078, 25494);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 24879, 25513);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 25533, 26317) || true) && (f_1469_25537_25625(f_1469_25537_25593(f_1469_25537_25580(f_1469_25537_25567(f_1469_25537_25550())))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 25533, 26317);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 26232, 26298);

                        f_1469_26232_26297(0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 25533, 26317);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 26386, 26432);

                    Runspace.DefaultRunspace = f_1469_26413_26431(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 26452, 26511);

                    FlowControlException
                    flowControlException = f_1469_26496_26510(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 26531, 26964) || true) && (flowControlException != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 26531, 26964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 26672, 26743);

                        f_1469_26672_26742(this, Runspaces.PipelineState.Failed, flowControlException);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 26531, 26964);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 26531, 26964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 26903, 26945);

                        f_1469_26903_26944(this, PipelineState.Completed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 26531, 26964);
                    }
                }
                catch (PipelineStoppedException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 26993, 27120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 27061, 27105);

                    f_1469_27061_27104(this, PipelineState.Stopped, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 26993, 27120);
                }
                catch (RuntimeException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 27134, 27365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 27194, 27252);

                    incompleteParseException = ex is IncompleteParseException;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 27270, 27313);

                    f_1469_27270_27312(this, PipelineState.Failed, ex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 27331, 27350);

                    f_1469_27331_27349(this, true);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 27134, 27365);
                }
                catch (ScriptCallDepthException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 27379, 27542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 27447, 27490);

                    f_1469_27447_27489(this, PipelineState.Failed, ex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 27508, 27527);

                    f_1469_27508_27526(this, true);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 27379, 27542);
                }
                catch (System.Security.SecurityException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 27556, 27728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 27633, 27676);

                    f_1469_27633_27675(this, PipelineState.Failed, ex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 27694, 27713);

                    f_1469_27694_27712(this, true);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 27556, 27728);
                }
                catch (HaltCommandException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 27742, 28030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 27973, 28015);

                    f_1469_27973_28014(this, PipelineState.Completed);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 27742, 28030);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1469, 28044, 32301);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 28354, 28625) || true) && ((f_1469_28359_28377() != null && (DynAbs.Tracing.TraceSender.Expression_True(1469, 28359, 28420) && f_1469_28389_28412(f_1469_28389_28407()) != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 28358, 28504) && (f_1469_28447_28503(f_1469_28447_28490(f_1469_28447_28477(f_1469_28447_28460()))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 28354, 28625);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 28546, 28606);

                        f_1469_28546_28605(f_1469_28546_28589(f_1469_28546_28576(f_1469_28546_28559())));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 28354, 28625);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 28699, 28750);

                    Runspace.DefaultRunspace = previousDefaultRunspace;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 28986, 30020) || true) && (!incompleteParseException)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 28986, 30020);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 29250, 29323);

                            bool
                            skipIfLocked = f_1469_29270_29322(f_1469_29270_29309(f_1469_29270_29300(f_1469_29270_29283())))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 29351, 29671) || true) && (_historyIdForThisPipeline == -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 29351, 29671);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 29444, 29474);

                                f_1469_29444_29473(this, skipIfLocked);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 29351, 29671);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 29351, 29671);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 29588, 29644);

                                f_1469_29588_29643(this, skipIfLocked);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 29351, 29671);
                            }
                        }
                        // Updating the history may trigger variable breakpoints; the debugger may throw a TerminateException to
                        // indicate that the user wants to interrupt the variable access.
                        catch (TerminateException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 29929, 30001);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 29929, 30001);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 28986, 30020);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 30282, 30573) || true) && (f_1469_30286_30305(f_1469_30286_30298()) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 30286, 30317) && f_1469_30309_30317_M(!IsChild)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 30282, 30573);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 30411, 30432);

                            f_1469_30411_30431(f_1469_30411_30423());
                        }
                        catch (ObjectDisposedException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 30477, 30554);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 30477, 30554);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 30282, 30573);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 30657, 30946) || true) && (f_1469_30661_30679(f_1469_30661_30672()) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 30661, 30691) && f_1469_30683_30691_M(!IsChild)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 30657, 30946);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 30785, 30805);

                            f_1469_30785_30804(f_1469_30785_30796());
                        }
                        catch (ObjectDisposedException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 30850, 30927);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 30850, 30927);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 30657, 30946);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 31030, 31319) || true) && (f_1469_31034_31052(f_1469_31034_31045()) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 31034, 31064) && f_1469_31056_31064_M(!IsChild)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 31030, 31319);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 31158, 31178);

                            f_1469_31158_31177(f_1469_31158_31169());
                        }
                        catch (ObjectDisposedException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 31223, 31300);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 31223, 31300);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 31030, 31319);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 31400, 31415);

                    f_1469_31400_31414(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 31643, 31693);

                    f_1469_31643_31692(f_1469_31643_31656(), this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 31866, 32286) || true) && (f_1469_31870_31885_M(!SyncInvokeCall))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 31866, 32286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 32240, 32267);

                        f_1469_32240_32266(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 31866, 32286);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1469, 28044, 32301);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 24589, 32312);

                System.Management.Automation.Runspaces.Runspace
                f_1469_24732_24756()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 24732, 24756);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_24883_24901()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 24883, 24901);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_24913_24931()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 24913, 24931);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1469_24913_24936(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 24913, 24936);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_25014_25032()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25014, 25032);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1469_25014_25037(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25014, 25037);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_25211_25224()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25211, 25224);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_25211_25241(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25211, 25241);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1469_25211_25254(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25211, 25254);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1469_25266_25291(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.ExternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25266, 25291);
                    return return_v;
                }


                int
                f_1469_25211_25292(System.Management.Automation.Internal.Host.InternalHost
                this_param, System.Management.Automation.Host.PSHost
                psHost)
                {
                    this_param.SetHostRef(psHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 25211, 25292);
                    return 0;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_25391_25404()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25391, 25404);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_25391_25421(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25391, 25421);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1469_25391_25434(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25391, 25434);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_25446_25464()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25446, 25464);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1469_25446_25469(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25446, 25469);
                    return return_v;
                }


                int
                f_1469_25391_25470(System.Management.Automation.Internal.Host.InternalHost
                this_param, System.Management.Automation.Host.PSHost
                psHost)
                {
                    this_param.SetHostRef(psHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 25391, 25470);
                    return 0;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_25537_25550()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25537, 25550);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_25537_25567(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25537, 25567);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1469_25537_25580(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25537, 25580);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1469_25537_25593(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.ExternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25537, 25593);
                    return return_v;
                }


                bool
                f_1469_25537_25625(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.ShouldSetThreadUILanguageToZero;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 25537, 25625);
                    return return_v;
                }


                int
                f_1469_26232_26297(int
                langId)
                {
                    Microsoft.PowerShell.NativeCultureResolver.SetThreadUILanguage((short)langId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 26232, 26297);
                    return 0;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_26413_26431(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 26413, 26431);
                    return return_v;
                }


                System.Management.Automation.FlowControlException
                f_1469_26496_26510(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.InvokeHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 26496, 26510);
                    return return_v;
                }


                int
                f_1469_26672_26742(System.Management.Automation.Runspaces.LocalPipeline
                this_param, System.Management.Automation.Runspaces.PipelineState
                state, System.Management.Automation.FlowControlException
                reason)
                {
                    this_param.SetPipelineState(state, (System.Exception)reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 26672, 26742);
                    return 0;
                }


                int
                f_1469_26903_26944(System.Management.Automation.Runspaces.LocalPipeline
                this_param, System.Management.Automation.Runspaces.PipelineState
                state)
                {
                    this_param.SetPipelineState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 26903, 26944);
                    return 0;
                }


                int
                f_1469_27061_27104(System.Management.Automation.Runspaces.LocalPipeline
                this_param, System.Management.Automation.Runspaces.PipelineState
                state, System.Management.Automation.PipelineStoppedException
                reason)
                {
                    this_param.SetPipelineState(state, (System.Exception)reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 27061, 27104);
                    return 0;
                }


                int
                f_1469_27270_27312(System.Management.Automation.Runspaces.LocalPipeline
                this_param, System.Management.Automation.Runspaces.PipelineState
                state, System.Management.Automation.RuntimeException
                reason)
                {
                    this_param.SetPipelineState(state, (System.Exception)reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 27270, 27312);
                    return 0;
                }


                int
                f_1469_27331_27349(System.Management.Automation.Runspaces.LocalPipeline
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 27331, 27349);
                    return 0;
                }


                int
                f_1469_27447_27489(System.Management.Automation.Runspaces.LocalPipeline
                this_param, System.Management.Automation.Runspaces.PipelineState
                state, System.Management.Automation.ScriptCallDepthException
                reason)
                {
                    this_param.SetPipelineState(state, (System.Exception)reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 27447, 27489);
                    return 0;
                }


                int
                f_1469_27508_27526(System.Management.Automation.Runspaces.LocalPipeline
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 27508, 27526);
                    return 0;
                }


                int
                f_1469_27633_27675(System.Management.Automation.Runspaces.LocalPipeline
                this_param, System.Management.Automation.Runspaces.PipelineState
                state, System.Security.SecurityException
                reason)
                {
                    this_param.SetPipelineState(state, (System.Exception)reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 27633, 27675);
                    return 0;
                }


                int
                f_1469_27694_27712(System.Management.Automation.Runspaces.LocalPipeline
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 27694, 27712);
                    return 0;
                }


                int
                f_1469_27973_28014(System.Management.Automation.Runspaces.LocalPipeline
                this_param, System.Management.Automation.Runspaces.PipelineState
                state)
                {
                    this_param.SetPipelineState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 27973, 28014);
                    return 0;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_28359_28377()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 28359, 28377);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1469_28389_28407()
                {
                    var return_v = InvocationSettings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 28389, 28407);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1469_28389_28412(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 28389, 28412);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_28447_28460()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 28447, 28460);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_28447_28477(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 28447, 28477);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1469_28447_28490(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 28447, 28490);
                    return return_v;
                }


                bool
                f_1469_28447_28503(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.IsHostRefSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 28447, 28503);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_28546_28559()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 28546, 28559);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_28546_28576(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 28546, 28576);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1469_28546_28589(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 28546, 28589);
                    return return_v;
                }


                int
                f_1469_28546_28605(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    this_param.RevertHostRef();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 28546, 28605);
                    return 0;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_29270_29283()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 29270, 29283);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_29270_29300(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 29270, 29300);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1469_29270_29309(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 29270, 29309);
                    return return_v;
                }


                bool
                f_1469_29270_29322(System.Management.Automation.ScriptDebugger
                this_param)
                {
                    var return_v = this_param.InBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 29270, 29322);
                    return return_v;
                }


                int
                f_1469_29444_29473(System.Management.Automation.Runspaces.LocalPipeline
                this_param, bool
                skipIfLocked)
                {
                    this_param.AddHistoryEntry(skipIfLocked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 29444, 29473);
                    return 0;
                }


                int
                f_1469_29588_29643(System.Management.Automation.Runspaces.LocalPipeline
                this_param, bool
                skipIfLocked)
                {
                    this_param.UpdateHistoryEntryAddedByAddHistoryCmdlet(skipIfLocked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 29588, 29643);
                    return 0;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_30286_30298()
                {
                    var return_v = OutputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 30286, 30298);
                    return return_v;
                }


                bool
                f_1469_30286_30305(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.IsOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 30286, 30305);
                    return return_v;
                }


                bool
                f_1469_30309_30317_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 30309, 30317);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_30411_30423()
                {
                    var return_v = OutputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 30411, 30423);
                    return return_v;
                }


                int
                f_1469_30411_30431(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 30411, 30431);
                    return 0;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_30661_30672()
                {
                    var return_v = ErrorStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 30661, 30672);
                    return return_v;
                }


                bool
                f_1469_30661_30679(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.IsOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 30661, 30679);
                    return return_v;
                }


                bool
                f_1469_30683_30691_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 30683, 30691);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_30785_30796()
                {
                    var return_v = ErrorStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 30785, 30796);
                    return return_v;
                }


                int
                f_1469_30785_30804(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 30785, 30804);
                    return 0;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_31034_31045()
                {
                    var return_v = InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 31034, 31045);
                    return return_v;
                }


                bool
                f_1469_31034_31052(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.IsOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 31034, 31052);
                    return return_v;
                }


                bool
                f_1469_31056_31064_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 31056, 31064);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_31158_31169()
                {
                    var return_v = InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 31158, 31169);
                    return return_v;
                }


                int
                f_1469_31158_31177(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 31158, 31177);
                    return 0;
                }


                int
                f_1469_31400_31414(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    this_param.ClearStreams();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 31400, 31414);
                    return 0;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_31643_31656()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 31643, 31656);
                    return return_v;
                }


                int
                f_1469_31643_31692(System.Management.Automation.Runspaces.LocalRunspace
                this_param, System.Management.Automation.Runspaces.LocalPipeline
                pipeline)
                {
                    this_param.RemoveFromRunningPipelineList((System.Management.Automation.Runspaces.PipelineBase)pipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 31643, 31692);
                    return 0;
                }


                bool
                f_1469_31870_31885_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 31870, 31885);
                    return return_v;
                }


                int
                f_1469_32240_32266(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    this_param.RaisePipelineStateEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 32240, 32266);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 24589, 32312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 24589, 32312);
            }
        }

        protected override void ImplementStop(bool syncCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 32554, 32888);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 32631, 32877) || true) && (syncCall)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 32631, 32877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 32677, 32690);

                    f_1469_32677_32689(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 32631, 32877);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 32631, 32877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 32756, 32825);

                    Thread
                    stopThread = f_1469_32776_32824(new ThreadStart(this.StopThreadProc))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 32843, 32862);

                    f_1469_32843_32861(stopThread);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 32631, 32877);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 32554, 32888);

                int
                f_1469_32677_32689(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    this_param.StopHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 32677, 32689);
                    return 0;
                }


                System.Threading.Thread
                f_1469_32776_32824(System.Threading.ThreadStart
                start)
                {
                    var return_v = new System.Threading.Thread(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 32776, 32824);
                    return return_v;
                }


                int
                f_1469_32843_32861(System.Threading.Thread
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 32843, 32861);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 32554, 32888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 32554, 32888);
            }
        }

        private void StopThreadProc()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 32996, 33074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 33050, 33063);

                f_1469_33050_33062(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 32996, 33074);

                int
                f_1469_33050_33062(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    this_param.StopHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 33050, 33062);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 32996, 33074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 32996, 33074);
            }
        }

        private PipelineStopper _stopper;

        internal PipelineStopper Stopper
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 33380, 33447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 33416, 33432);

                    return _stopper;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 33380, 33447);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 33323, 33458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 33323, 33458);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void StopHelper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 33566, 34384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 33680, 33712);

                f_1469_33680_33711(f_1469_33680_33693());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 33792, 33832);

                f_1469_33792_33831(f_1469_33792_33805(), this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 34010, 34251) || true) && (f_1469_34014_34032(f_1469_34014_34025()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 34010, 34251);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 34110, 34130);

                        f_1469_34110_34129(f_1469_34110_34121());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 34167, 34236);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 34167, 34236);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 34010, 34251);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 34267, 34283);

                f_1469_34267_34282(
                            _stopper);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 34341, 34373);

                f_1469_34341_34372(f_1469_34341_34362());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 33566, 34384);

                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_33680_33693()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 33680, 33693);
                    return return_v;
                }


                int
                f_1469_33680_33711(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.ReleaseDebugger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 33680, 33711);
                    return 0;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_33792_33805()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 33792, 33805);
                    return return_v;
                }


                int
                f_1469_33792_33831(System.Management.Automation.Runspaces.LocalRunspace
                this_param, System.Management.Automation.Runspaces.LocalPipeline
                pipeline)
                {
                    this_param.StopNestedPipelines((System.Management.Automation.Runspaces.Pipeline)pipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 33792, 33831);
                    return 0;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_34014_34025()
                {
                    var return_v = InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 34014, 34025);
                    return return_v;
                }


                bool
                f_1469_34014_34032(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.IsOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 34014, 34032);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_34110_34121()
                {
                    var return_v = InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 34110, 34121);
                    return return_v;
                }


                int
                f_1469_34110_34129(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 34110, 34129);
                    return 0;
                }


                int
                f_1469_34267_34282(System.Management.Automation.Runspaces.PipelineStopper
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 34267, 34282);
                    return 0;
                }


                System.Threading.ManualResetEvent
                f_1469_34341_34362()
                {
                    var return_v = PipelineFinishedEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 34341, 34362);
                    return return_v;
                }


                bool
                f_1469_34341_34372(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 34341, 34372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 33566, 34384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 33566, 34384);
            }
        }

        internal bool IsStopping
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 34572, 34650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 34608, 34635);

                    return f_1469_34615_34634(_stopper);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 34572, 34650);

                    bool
                    f_1469_34615_34634(System.Management.Automation.Runspaces.PipelineStopper
                    this_param)
                    {
                        var return_v = this_param.IsStopping;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 34615, 34634);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 34523, 34661);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 34523, 34661);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PipelineProcessor CreatePipelineProcessor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 34886, 39630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 34962, 35000);

                CommandCollection
                commands = f_1469_34991_34999()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 35016, 35194) || true) && (commands == null || (DynAbs.Tracing.TraceSender.Expression_False(1469, 35020, 35059) || f_1469_35040_35054(commands) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 35016, 35194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 35093, 35179);

                    throw f_1469_35099_35178(f_1469_35142_35177());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 35016, 35194);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 35210, 35272);

                PipelineProcessor
                pipelineProcessor = f_1469_35248_35271()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 35286, 35320);

                pipelineProcessor.TopLevel = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 35336, 35356);

                bool
                failed = false
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 35408, 38959);
                        foreach (Command command in f_1469_35436_35444_I(commands))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 35408, 38959);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 35486, 35528);

                            CommandProcessorBase
                            commandProcessorBase
                            = default(CommandProcessorBase);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 35656, 38764) || true) && (f_1469_35660_35679(command) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 35656, 38764);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 35797, 35849);

                                    CommandOrigin
                                    commandOrigin = f_1469_35827_35848(command)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 36146, 36473) || true) && (f_1469_36150_36158() && (DynAbs.Tracing.TraceSender.Expression_True(1469, 36150, 36224) && f_1469_36195_36224_M(!f_1469_36196_36209().InNestedPrompt)) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 36150, 36337) && !((f_1469_36264_36286(f_1469_36264_36277()) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 36263, 36336) && (f_1469_36300_36335(f_1469_36300_36322(f_1469_36300_36313())))))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 36146, 36473);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 36403, 36442);

                                        commandOrigin = CommandOrigin.Internal;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 36146, 36473);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 36505, 36853);

                                    commandProcessorBase =
                                    f_1469_36561_36852(command, f_1469_36672_36702(f_1469_36672_36685()), f_1469_36745_36757(), commandOrigin);
                                }
                                catch
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 36906, 37767);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 37151, 37702) || true) && (f_1469_37155_37226(f_1469_37155_37211(f_1469_37155_37208(f_1469_37155_37188(f_1469_37155_37168(this))))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 37151, 37702);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 37449, 37671) || true) && (f_1469_37453_37470_M(!command.IsScript))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 37449, 37671);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 37544, 37636);

                                            f_1469_37544_37635(f_1469_37544_37590(f_1469_37544_37587(f_1469_37544_37574(f_1469_37544_37557(this)))), f_1469_37609_37628(command), null);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 37449, 37671);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 37151, 37702);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 37734, 37740);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 36906, 37767);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 35656, 38764);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 35656, 38764);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 37865, 37922);

                                commandProcessorBase = f_1469_37888_37921(this, command);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 38054, 38130);

                                f_1469_38054_38082(commandProcessorBase).CommandOriginInternal = CommandOrigin.Internal;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 38156, 38240);

                                f_1469_38156_38197(f_1469_38156_38184(commandProcessorBase)).InvocationName = f_1469_38215_38239(f_1469_38215_38234(command));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 38266, 38741) || true) && (f_1469_38270_38288(command) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 38266, 38741);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 38354, 38714);
                                        foreach (CommandParameter publicParameter in f_1469_38399_38417_I(f_1469_38399_38417(command)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 38354, 38714);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 38483, 38596);

                                            CommandParameterInternal
                                            internalParameter = f_1469_38528_38595(publicParameter, false)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 38630, 38683);

                                            f_1469_38630_38682(commandProcessorBase, internalParameter);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 38354, 38714);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1469, 1, 361);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1469, 1, 361);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 38266, 38741);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 35656, 38764);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 38788, 38874);

                            commandProcessorBase.RedirectShellErrorOutputPipe = f_1469_38840_38873(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 38896, 38940);

                            f_1469_38896_38939(pipelineProcessor, commandProcessorBase);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 35408, 38959);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1469, 1, 3552);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1469, 1, 3552);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 38979, 39004);

                    return pipelineProcessor;
                }
                catch (RuntimeException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 39033, 39143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 39090, 39104);

                    failed = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 39122, 39128);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 39033, 39143);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1469, 39157, 39324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 39209, 39223);

                    failed = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 39241, 39309);

                    throw f_1469_39247_39308(f_1469_39268_39304(), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1469, 39157, 39324);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1469, 39338, 39619);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 39378, 39604) || true) && (failed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 39378, 39604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 39430, 39454);

                        f_1469_39430_39453(this, true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 39557, 39585);

                        f_1469_39557_39584(
                                            // 2004/02/26-JonN added IDisposable to PipelineProcessor
                                            pipelineProcessor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 39378, 39604);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1469, 39338, 39619);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 34886, 39630);

                System.Management.Automation.Runspaces.CommandCollection
                f_1469_34991_34999()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 34991, 34999);
                    return return_v;
                }


                int
                f_1469_35040_35054(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 35040, 35054);
                    return return_v;
                }


                string
                f_1469_35142_35177()
                {
                    var return_v = RunspaceStrings.NoCommandInPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 35142, 35177);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1469_35099_35178(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 35099, 35178);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1469_35248_35271()
                {
                    var return_v = new System.Management.Automation.Internal.PipelineProcessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 35248, 35271);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1469_35660_35679(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 35660, 35679);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1469_35827_35848(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 35827, 35848);
                    return return_v;
                }


                bool
                f_1469_36150_36158()
                {
                    var return_v = IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 36150, 36158);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_36196_36209()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 36196, 36209);
                    return return_v;
                }


                bool
                f_1469_36195_36224_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 36195, 36224);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_36264_36277()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 36264, 36277);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1469_36264_36286(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 36264, 36286);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_36300_36313()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 36300, 36313);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1469_36300_36322(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 36300, 36322);
                    return return_v;
                }


                bool
                f_1469_36300_36335(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.InBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 36300, 36335);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_36672_36685()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 36672, 36685);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_36672_36702(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 36672, 36702);
                    return return_v;
                }


                bool
                f_1469_36745_36757()
                {
                    var return_v = AddToHistory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 36745, 36757);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1469_36561_36852(System.Management.Automation.Runspaces.Command
                this_param, System.Management.Automation.ExecutionContext
                executionContext, bool
                addToHistory, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.CreateCommandProcessor(executionContext, addToHistory, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 36561, 36852);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1469_37155_37168(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 37155, 37168);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_37155_37188(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 37155, 37188);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1469_37155_37208(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 37155, 37208);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1469_37155_37211(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 37155, 37211);
                    return return_v;
                }


                bool
                f_1469_37155_37226(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.IsTranscribing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 37155, 37226);
                    return return_v;
                }


                bool
                f_1469_37453_37470_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 37453, 37470);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1469_37544_37557(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 37544, 37557);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_37544_37574(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 37544, 37574);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1469_37544_37587(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 37544, 37587);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1469_37544_37590(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 37544, 37590);
                    return return_v;
                }


                string
                f_1469_37609_37628(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 37609, 37628);
                    return return_v;
                }


                int
                f_1469_37544_37635(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                commandText, System.Management.Automation.InvocationInfo
                invocation)
                {
                    this_param.TranscribeCommand(commandText, invocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 37544, 37635);
                    return 0;
                }


                System.Management.Automation.CommandProcessorBase
                f_1469_37888_37921(System.Management.Automation.Runspaces.LocalPipeline
                this_param, System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = this_param.CreateCommandProcessBase(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 37888, 37921);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1469_38054_38082(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 38054, 38082);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1469_38156_38184(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 38156, 38184);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1469_38156_38197(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 38156, 38197);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1469_38215_38234(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 38215, 38234);
                    return return_v;
                }


                string
                f_1469_38215_38239(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 38215, 38239);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1469_38270_38288(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 38270, 38288);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1469_38399_38417(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 38399, 38417);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1469_38528_38595(System.Management.Automation.Runspaces.CommandParameter
                publicParameter, bool
                forNativeCommand)
                {
                    var return_v = CommandParameter.ToCommandParameterInternal(publicParameter, forNativeCommand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 38528, 38595);
                    return return_v;
                }


                int
                f_1469_38630_38682(System.Management.Automation.CommandProcessorBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter)
                {
                    this_param.AddParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 38630, 38682);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1469_38399_38417_I(System.Management.Automation.Runspaces.CommandParameterCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 38399, 38417);
                    return return_v;
                }


                bool
                f_1469_38840_38873(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.RedirectShellErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 38840, 38873);
                    return return_v;
                }


                int
                f_1469_38896_38939(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.CommandProcessorBase
                commandProcessor)
                {
                    var return_v = this_param.Add(commandProcessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 38896, 38939);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1469_35436_35444_I(System.Management.Automation.Runspaces.CommandCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 35436, 35444);
                    return return_v;
                }


                string
                f_1469_39268_39304()
                {
                    var return_v = PipelineStrings.CannotCreatePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 39268, 39304);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1469_39247_39308(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 39247, 39308);
                    return return_v;
                }


                int
                f_1469_39430_39453(System.Management.Automation.Runspaces.LocalPipeline
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 39430, 39453);
                    return 0;
                }


                int
                f_1469_39557_39584(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 39557, 39584);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 34886, 39630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 34886, 39630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandProcessorBase CreateCommandProcessBase(Command command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 39882, 41090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 39977, 40023);

                CommandInfo
                commandInfo = f_1469_40003_40022(command)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 40037, 40174) || true) && (commandInfo is AliasInfo)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 40037, 40174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 40102, 40159);

                        commandInfo = f_1469_40116_40158(((AliasInfo)commandInfo));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 40037, 40174);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1469, 40037, 40174);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1469, 40037, 40174);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 40190, 40240);

                CmdletInfo
                cmdletInfo = commandInfo as CmdletInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 40254, 40397) || true) && (cmdletInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 40254, 40397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 40310, 40382);

                    return f_1469_40317_40381(cmdletInfo, f_1469_40350_40380(f_1469_40350_40363()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 40254, 40397);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 40413, 40481);

                IScriptCommandInfo
                functionInfo = commandInfo as IScriptCommandInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 40495, 40773) || true) && (functionInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 40495, 40773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 40553, 40758);

                    return f_1469_40560_40757(functionInfo, f_1469_40595_40625(f_1469_40595_40608()), useLocalScope: false, fromScriptFile: false, sessionState: f_1469_40707_40756(f_1469_40707_40737(f_1469_40707_40720())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 40495, 40773);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 40789, 40854);

                ApplicationInfo
                applicationInfo = commandInfo as ApplicationInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 40868, 41027) || true) && (applicationInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 40868, 41027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 40929, 41012);

                    return f_1469_40936_41011(applicationInfo, f_1469_40980_41010(f_1469_40980_40993()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 40868, 41027);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 41043, 41079);

                throw f_1469_41049_41078();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 39882, 41090);

                System.Management.Automation.CommandInfo
                f_1469_40003_40022(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 40003, 40022);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1469_40116_40158(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.ReferencedCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 40116, 40158);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_40350_40363()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 40350, 40363);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_40350_40380(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 40350, 40380);
                    return return_v;
                }


                System.Management.Automation.CommandProcessor
                f_1469_40317_40381(System.Management.Automation.CmdletInfo
                cmdletInfo, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandProcessor(cmdletInfo, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 40317, 40381);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_40595_40608()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 40595, 40608);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_40595_40625(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 40595, 40625);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_40707_40720()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 40707, 40720);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_40707_40737(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 40707, 40737);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1469_40707_40756(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 40707, 40756);
                    return return_v;
                }


                System.Management.Automation.CommandProcessor
                f_1469_40560_40757(System.Management.Automation.IScriptCommandInfo
                scriptCommandInfo, System.Management.Automation.ExecutionContext
                context, bool
                useLocalScope, bool
                fromScriptFile, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.CommandProcessor(scriptCommandInfo, context, useLocalScope: useLocalScope, fromScriptFile: fromScriptFile, sessionState: sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 40560, 40757);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_40980_40993()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 40980, 40993);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_40980_41010(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 40980, 41010);
                    return return_v;
                }


                System.Management.Automation.NativeCommandProcessor
                f_1469_40936_41011(System.Management.Automation.ApplicationInfo
                applicationInfo, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.NativeCommandProcessor(applicationInfo, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 40936, 41011);
                    return return_v;
                }


                System.NotImplementedException
                f_1469_41049_41078()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 41049, 41078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 39882, 41090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 39882, 41090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void InitStreams()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 41289, 41813);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 41340, 41802) || true) && (f_1469_41344_41374(f_1469_41344_41357()) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 41340, 41802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 41416, 41493);

                    _oldExternalErrorOutput = f_1469_41442_41492(f_1469_41442_41472(f_1469_41442_41455()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 41511, 41592);

                    _oldExternalSuccessOutput = f_1469_41539_41591(f_1469_41539_41569(f_1469_41539_41552()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 41610, 41688);

                    f_1469_41610_41640(f_1469_41610_41623()).ExternalErrorOutput = f_1469_41663_41687(f_1469_41663_41674());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 41706, 41787);

                    f_1469_41706_41736(f_1469_41706_41719()).ExternalSuccessOutput = f_1469_41761_41786(f_1469_41761_41773());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 41340, 41802);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 41289, 41813);

                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_41344_41357()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41344, 41357);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_41344_41374(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41344, 41374);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_41442_41455()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41442, 41455);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_41442_41472(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41442, 41472);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineWriter
                f_1469_41442_41492(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExternalErrorOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41442, 41492);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_41539_41552()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41539, 41552);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_41539_41569(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41539, 41569);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineWriter
                f_1469_41539_41591(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExternalSuccessOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41539, 41591);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_41610_41623()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41610, 41623);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_41610_41640(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41610, 41640);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_41663_41674()
                {
                    var return_v = ErrorStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41663, 41674);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineWriter
                f_1469_41663_41687(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.ObjectWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41663, 41687);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_41706_41719()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41706, 41719);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_41706_41736(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41706, 41736);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1469_41761_41773()
                {
                    var return_v = OutputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41761, 41773);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineWriter
                f_1469_41761_41786(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.ObjectWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 41761, 41786);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 41289, 41813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 41289, 41813);
            }
        }

        private void ClearStreams()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 42050, 42380);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 42102, 42369) || true) && (f_1469_42106_42136(f_1469_42106_42119()) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 42102, 42369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 42178, 42255);

                    f_1469_42178_42208(f_1469_42178_42191()).ExternalErrorOutput = _oldExternalErrorOutput;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 42273, 42354);

                    f_1469_42273_42303(f_1469_42273_42286()).ExternalSuccessOutput = _oldExternalSuccessOutput;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 42102, 42369);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 42050, 42380);

                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_42106_42119()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 42106, 42119);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_42106_42136(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 42106, 42136);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_42178_42191()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 42178, 42191);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_42178_42208(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 42178, 42208);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_42273_42286()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 42273, 42286);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_42273_42303(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 42273, 42303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 42050, 42380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 42050, 42380);
            }
        }

        private DateTime _pipelineStartTime;

        private void RecordPipelineStartTime()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 42589, 42697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 42652, 42686);

                _pipelineStartTime = DateTime.Now;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 42589, 42697);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 42589, 42697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 42589, 42697);
            }
        }

        private void AddHistoryEntry(bool skipIfLocked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 42881, 43228);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 43031, 43217) || true) && (f_1469_43035_43047())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 43031, 43217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 43081, 43202);

                    f_1469_43081_43201(f_1469_43081_43102(f_1469_43081_43094()), f_1469_43112_43122(), f_1469_43124_43137(), f_1469_43139_43152(), _pipelineStartTime, DateTime.Now, skipIfLocked);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 43031, 43217);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 42881, 43228);

                bool
                f_1469_43035_43047()
                {
                    var return_v = AddToHistory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 43035, 43047);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_43081_43094()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 43081, 43094);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.History
                f_1469_43081_43102(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.History;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 43081, 43102);
                    return return_v;
                }


                long
                f_1469_43112_43122()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 43112, 43122);
                    return return_v;
                }


                string
                f_1469_43124_43137()
                {
                    var return_v = HistoryString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 43124, 43137);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1469_43139_43152()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 43139, 43152);
                    return return_v;
                }


                long
                f_1469_43081_43201(Microsoft.PowerShell.Commands.History
                this_param, long
                pipelineId, string
                cmdline, System.Management.Automation.Runspaces.PipelineState
                status, System.DateTime
                startTime, System.DateTime
                endTime, bool
                skipIfLocked)
                {
                    var return_v = this_param.AddEntry(pipelineId, cmdline, status, startTime, endTime, skipIfLocked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 43081, 43201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 42881, 43228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 42881, 43228);
            }
        }

        private long _historyIdForThisPipeline;

        internal
                void AddHistoryEntryFromAddHistoryCmdlet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 43753, 44411);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 44086, 44177) || true) && (_historyIdForThisPipeline != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 44086, 44177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 44155, 44162);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 44086, 44177);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 44193, 44400) || true) && (f_1469_44197_44209())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 44193, 44400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 44243, 44385);

                    _historyIdForThisPipeline = f_1469_44271_44384(f_1469_44271_44292(f_1469_44271_44284()), f_1469_44302_44312(), f_1469_44314_44327(), f_1469_44329_44342(), _pipelineStartTime, DateTime.Now, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 44193, 44400);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 43753, 44411);

                bool
                f_1469_44197_44209()
                {
                    var return_v = AddToHistory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 44197, 44209);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_44271_44284()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 44271, 44284);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.History
                f_1469_44271_44292(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.History;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 44271, 44292);
                    return return_v;
                }


                long
                f_1469_44302_44312()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 44302, 44312);
                    return return_v;
                }


                string
                f_1469_44314_44327()
                {
                    var return_v = HistoryString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 44314, 44327);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1469_44329_44342()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 44329, 44342);
                    return return_v;
                }


                long
                f_1469_44271_44384(Microsoft.PowerShell.Commands.History
                this_param, long
                pipelineId, string
                cmdline, System.Management.Automation.Runspaces.PipelineState
                status, System.DateTime
                startTime, System.DateTime
                endTime, bool
                skipIfLocked)
                {
                    var return_v = this_param.AddEntry(pipelineId, cmdline, status, startTime, endTime, skipIfLocked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 44271, 44384);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 43753, 44411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 43753, 44411);
            }
        }

        internal
                void UpdateHistoryEntryAddedByAddHistoryCmdlet(bool skipIfLocked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 44668, 44991);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 44776, 44980) || true) && (f_1469_44780_44792() && (DynAbs.Tracing.TraceSender.Expression_True(1469, 44780, 44827) && _historyIdForThisPipeline != -1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 44776, 44980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 44861, 44965);

                    f_1469_44861_44964(f_1469_44861_44882(f_1469_44861_44874()), _historyIdForThisPipeline, f_1469_44922_44935(), DateTime.Now, skipIfLocked);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 44776, 44980);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 44668, 44991);

                bool
                f_1469_44780_44792()
                {
                    var return_v = AddToHistory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 44780, 44792);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1469_44861_44874()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 44861, 44874);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.History
                f_1469_44861_44882(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.History;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 44861, 44882);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1469_44922_44935()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 44922, 44935);
                    return return_v;
                }


                int
                f_1469_44861_44964(Microsoft.PowerShell.Commands.History
                this_param, long
                id, System.Management.Automation.Runspaces.PipelineState
                status, System.DateTime
                endTime, bool
                skipIfLocked)
                {
                    this_param.UpdateEntry(id, status, endTime, skipIfLocked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 44861, 44964);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 44668, 44991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 44668, 44991);
            }
        }

        internal override void SetHistoryString(string historyString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 45184, 45311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 45270, 45300);

                HistoryString = historyString;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 45184, 45311);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 45184, 45311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 45184, 45311);
            }
        }

        internal static System.Management.Automation.ExecutionContext GetExecutionContextFromTLS()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1469, 45657, 46011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 45772, 45856);

                System.Management.Automation.Runspaces.Runspace
                runspace = f_1469_45831_45855()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 45870, 45951) || true) && (runspace == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 45870, 45951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 45924, 45936);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 45870, 45951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 45967, 46000);

                return f_1469_45974_45999(runspace);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1469, 45657, 46011);

                System.Management.Automation.Runspaces.Runspace
                f_1469_45831_45855()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 45831, 45855);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1469_45974_45999(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 45974, 45999);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 45657, 46011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 45657, 46011);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalRunspace LocalRunspace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 46330, 46412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 46366, 46397);

                    return (LocalRunspace)f_1469_46388_46396();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 46330, 46412);

                    System.Management.Automation.Runspaces.Runspace
                    f_1469_46388_46396()
                    {
                        var return_v = Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 46388, 46396);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 46270, 46423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 46270, 46423);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _useExternalInput;

        private PipelineWriter _oldExternalErrorOutput;

        private PipelineWriter _oldExternalSuccessOutput;

        private WindowsIdentity _identityToImpersonate;

        private List<long> _invokeHistoryIds;

        internal bool PresentInInvokeHistoryEntryList(HistoryInfo entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 46968, 47112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 47057, 47101);

                return f_1469_47064_47100(_invokeHistoryIds, f_1469_47091_47099(entry));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 46968, 47112);

                long
                f_1469_47091_47099(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 47091, 47099);
                    return return_v;
                }


                bool
                f_1469_47064_47100(System.Collections.Generic.List<long>
                this_param, long
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 47064, 47100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 46968, 47112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 46968, 47112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AddToInvokeHistoryEntryList(HistoryInfo entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 47124, 47252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 47209, 47241);

                f_1469_47209_47240(_invokeHistoryIds, f_1469_47231_47239(entry));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 47124, 47252);

                long
                f_1469_47231_47239(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 47231, 47239);
                    return return_v;
                }


                int
                f_1469_47209_47240(System.Collections.Generic.List<long>
                this_param, long
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 47209, 47240);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 47124, 47252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 47124, 47252);
            }
        }

        internal void RemoveFromInvokeHistoryEntryList(HistoryInfo entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 47264, 47400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 47354, 47389);

                f_1469_47354_47388(_invokeHistoryIds, f_1469_47379_47387(entry));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 47264, 47400);

                long
                f_1469_47379_47387(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 47379, 47387);
                    return return_v;
                }


                bool
                f_1469_47354_47388(System.Collections.Generic.List<long>
                this_param, long
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 47354, 47388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 47264, 47400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 47264, 47400);
            }
        }

        private bool _disposed;

        protected override
                void
                Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 47795, 48255);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 47921, 48136) || true) && (_disposed == false)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 47921, 48136);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 47985, 48002);

                        _disposed = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 48024, 48117) || true) && (disposing)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 48024, 48117);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 48087, 48094);

                            f_1469_48087_48093(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 48024, 48117);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 47921, 48136);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1469, 48165, 48244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 48205, 48229);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing), 1469, 48205, 48228);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1469, 48165, 48244);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 47795, 48255);

                int
                f_1469_48087_48093(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 48087, 48093);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 47795, 48255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 47795, 48255);
            }
        }

        static LocalPipeline()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1469, 682, 48304);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 1163, 1200);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1469, 682, 48304);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 682, 48304);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1469, 682, 48304);

        System.Management.Automation.Runspaces.PipelineStopper
        f_1469_1907_1932(System.Management.Automation.Runspaces.LocalPipeline
        localPipeline)
        {
            var return_v = new System.Management.Automation.Runspaces.PipelineStopper(localPipeline);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 1907, 1932);
            return return_v;
        }


        int
        f_1469_1947_1960(System.Management.Automation.Runspaces.LocalPipeline
        this_param)
        {
            this_param.InitStreams();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 1947, 1960);
            return 0;
        }


        static System.Management.Automation.Runspaces.Runspace
        f_1469_1819_1837_C(System.Management.Automation.Runspaces.Runspace
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1469, 1702, 1972);
            return return_v;
        }


        System.Management.Automation.Runspaces.PipelineStopper
        f_1469_3646_3671(System.Management.Automation.Runspaces.LocalPipeline
        localPipeline)
        {
            var return_v = new System.Management.Automation.Runspaces.PipelineStopper(localPipeline);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 3646, 3671);
            return return_v;
        }


        int
        f_1469_3686_3699(System.Management.Automation.Runspaces.LocalPipeline
        this_param)
        {
            this_param.InitStreams();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 3686, 3699);
            return 0;
        }


        static System.Management.Automation.Runspaces.Runspace
        f_1469_3515_3523_C(System.Management.Automation.Runspaces.Runspace
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1469, 3169, 3711);
            return return_v;
        }


        System.Management.Automation.Runspaces.PipelineStopper
        f_1469_4013_4038(System.Management.Automation.Runspaces.LocalPipeline
        localPipeline)
        {
            var return_v = new System.Management.Automation.Runspaces.PipelineStopper(localPipeline);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 4013, 4038);
            return return_v;
        }


        int
        f_1469_4053_4066(System.Management.Automation.Runspaces.LocalPipeline
        this_param)
        {
            this_param.InitStreams();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 4053, 4066);
            return 0;
        }


        static System.Management.Automation.Runspaces.PipelineBase
        f_1469_3952_3976_C(System.Management.Automation.Runspaces.PipelineBase
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1469, 3885, 4078);
            return return_v;
        }


        System.Collections.Generic.List<long>
        f_1469_46939_46955()
        {
            var return_v = new System.Collections.Generic.List<long>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 46939, 46955);
            return return_v;
        }

    }
    internal class PipelineThread : IDisposable
    {
        internal PipelineThread(ApartmentState apartmentState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1469, 48643, 49139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 51139, 51146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 51177, 51186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 51220, 51234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 51258, 51265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 48722, 48795);

                _worker = f_1469_48732_48794(WorkerProc, LocalPipeline.DefaultPipelineStackSize);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 48809, 48826);

                _workItem = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 48840, 48883);

                _workItemReady = f_1469_48857_48882(false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 48897, 48913);

                _closed = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 48940, 49120) || true) && (apartmentState != ApartmentState.Unknown && (DynAbs.Tracing.TraceSender.Expression_True(1469, 48944, 49010) && f_1469_48988_49010_M(!Platform.IsNanoServer)) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 48944, 49029) && f_1469_49014_49029_M(!Platform.IsIoT)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 48940, 49120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 49063, 49105);

                    f_1469_49063_49104(_worker, apartmentState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 48940, 49120);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1469, 48643, 49139);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 48643, 49139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 48643, 49139);
            }
        }

        internal Thread Worker
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 49285, 49351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 49321, 49336);

                    return _worker;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 49285, 49351);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 49238, 49362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 49238, 49362);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void Start(ThreadStart workItem)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 49498, 49860);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 49564, 49631) || true) && (_closed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 49564, 49631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 49609, 49616);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 49564, 49631);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 49647, 49668);

                _workItem = workItem;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 49682, 49703);

                f_1469_49682_49702(_workItemReady);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 49719, 49849) || true) && (f_1469_49723_49742(_worker) == System.Threading.ThreadState.Unstarted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 49719, 49849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 49818, 49834);

                    f_1469_49818_49833(_worker);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 49719, 49849);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 49498, 49860);

                bool
                f_1469_49682_49702(System.Threading.AutoResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 49682, 49702);
                    return return_v;
                }


                System.Threading.ThreadState
                f_1469_49723_49742(System.Threading.Thread
                this_param)
                {
                    var return_v = this_param.ThreadState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 49723, 49742);
                    return return_v;
                }


                int
                f_1469_49818_49833(System.Threading.Thread
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 49818, 49833);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 49498, 49860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 49498, 49860);
            }
        }

        internal void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 49954, 50021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 50000, 50010);

                f_1469_50000_50009(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 49954, 50021);

                int
                f_1469_50000_50009(System.Management.Automation.Runspaces.PipelineThread
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 50000, 50009);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 49954, 50021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 49954, 50021);
            }
        }

        private void WorkerProc()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 50130, 50385);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 50180, 50374) || true) && (!_closed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 50180, 50374);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 50229, 50254);

                        f_1469_50229_50253(_workItemReady);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 50274, 50359) || true) && (!_closed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 50274, 50359);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 50328, 50340);

                            f_1469_50328_50339(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 50274, 50359);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 50180, 50374);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1469, 50180, 50374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1469, 50180, 50374);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 50130, 50385);

                bool
                f_1469_50229_50253(System.Threading.AutoResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 50229, 50253);
                    return return_v;
                }


                int
                f_1469_50328_50339(System.Management.Automation.Runspaces.PipelineThread
                this_param)
                {
                    this_param._workItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 50328, 50339);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 50130, 50385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 50130, 50385);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 50485, 50940);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 50531, 50598) || true) && (_closed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 50531, 50598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 50576, 50583);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 50531, 50598);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 50614, 50629);

                _closed = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 50645, 50666);

                f_1469_50645_50665(
                            _workItemReady);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 50682, 50846) || true) && (f_1469_50686_50705(_worker) != System.Threading.ThreadState.Unstarted && (DynAbs.Tracing.TraceSender.Expression_True(1469, 50686, 50782) && f_1469_50751_50771() != _worker))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 50682, 50846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 50816, 50831);

                    f_1469_50816_50830(_worker);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 50682, 50846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 50862, 50887);

                f_1469_50862_50886(
                            _workItemReady);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 50903, 50929);

                f_1469_50903_50928(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 50485, 50940);

                bool
                f_1469_50645_50665(System.Threading.AutoResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 50645, 50665);
                    return return_v;
                }


                System.Threading.ThreadState
                f_1469_50686_50705(System.Threading.Thread
                this_param)
                {
                    var return_v = this_param.ThreadState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 50686, 50705);
                    return return_v;
                }


                System.Threading.Thread
                f_1469_50751_50771()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 50751, 50771);
                    return return_v;
                }


                int
                f_1469_50816_50830(System.Threading.Thread
                this_param)
                {
                    this_param.Join();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 50816, 50830);
                    return 0;
                }


                int
                f_1469_50862_50886(System.Threading.AutoResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 50862, 50886);
                    return 0;
                }


                int
                f_1469_50903_50928(System.Management.Automation.Runspaces.PipelineThread
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 50903, 50928);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 50485, 50940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 50485, 50940);
            }
        }

        /// <summary>
        /// Ensure we release the worker thread.
        /// </summary>
        ~PipelineThread()
        {
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 51091, 51101);

            f_1469_51091_51100(this);
        }

        private Thread _worker;

        private ThreadStart _workItem;

        private AutoResetEvent _workItemReady;

        private bool _closed;

        static PipelineThread()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1469, 48467, 51273);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1469, 48467, 51273);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 48467, 51273);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1469, 48467, 51273);

        System.Threading.Thread
        f_1469_48732_48794(System.Threading.ThreadStart
        start, int
        maxStackSize)
        {
            var return_v = new System.Threading.Thread(start, maxStackSize);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 48732, 48794);
            return return_v;
        }


        System.Threading.AutoResetEvent
        f_1469_48857_48882(bool
        initialState)
        {
            var return_v = new System.Threading.AutoResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 48857, 48882);
            return return_v;
        }


        bool
        f_1469_48988_49010_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 48988, 49010);
            return return_v;
        }


        bool
        f_1469_49014_49029_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 49014, 49029);
            return return_v;
        }


        int
        f_1469_49063_49104(System.Threading.Thread
        this_param, System.Threading.ApartmentState
        state)
        {
            this_param.SetApartmentState(state);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 49063, 49104);
            return 0;
        }


        int
        f_1469_51091_51100(System.Management.Automation.Runspaces.PipelineThread
        this_param)
        {
            this_param.Dispose();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 51091, 51100);
            return 0;
        }

    }
    internal class PipelineStopper
    {
        private Stack<PipelineProcessor> _stack;

        private object _syncRoot;

        private LocalPipeline _localPipeline;

        internal PipelineStopper(LocalPipeline localPipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1469, 52068, 52188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 51743, 51782);
                this._stack = f_1469_51752_51782();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 51903, 51927);
                this._syncRoot = f_1469_51915_51927();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 51960, 51974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 52311, 52320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 52146, 52177);

                _localPipeline = localPipeline;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1469, 52068, 52188);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 52068, 52188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 52068, 52188);
            }
        }

        private bool _stopping;

        internal bool IsStopping
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 52380, 52448);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 52416, 52433);

                    return _stopping;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 52380, 52448);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 52331, 52544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 52331, 52544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 52464, 52533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 52500, 52518);

                    _stopping = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 52464, 52533);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 52331, 52544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 52331, 52544);
                }
            }
        }

        internal void Push(PipelineProcessor item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 52698, 53228);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 52765, 52883) || true) && (item == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 52765, 52883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 52815, 52868);

                    throw f_1469_52821_52867("item");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 52765, 52883);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 52905, 52914);

                lock (_syncRoot)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 52948, 53112) || true) && (_stopping)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 52948, 53112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 53003, 53063);

                        PipelineStoppedException
                        e = f_1469_53032_53062()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 53085, 53093);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 52948, 53112);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 53132, 53150);

                    f_1469_53132_53149(
                                    _stack, item);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 53181, 53217);

                item.LocalPipeline = _localPipeline;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 52698, 53228);

                System.Management.Automation.PSArgumentNullException
                f_1469_52821_52867(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 52821, 52867);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1469_53032_53062()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 53032, 53062);
                    return return_v;
                }


                int
                f_1469_53132_53149(System.Collections.Generic.Stack<System.Management.Automation.Internal.PipelineProcessor>
                this_param, System.Management.Automation.Internal.PipelineProcessor
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 53132, 53149);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 52698, 53228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 52698, 53228);
            }
        }

        internal void Pop(bool fromSteppablePipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 53343, 54437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 53419, 53428);
                lock (_syncRoot)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 53675, 53756) || true) && (_stopping)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 53675, 53756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 53730, 53737);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 53675, 53756);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 53776, 54411) || true) && (f_1469_53780_53792(_stack) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 53776, 54411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 53838, 53879);

                        PipelineProcessor
                        oldPipe = f_1469_53866_53878(_stack)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 53901, 54083) || true) && (fromSteppablePipeline && (DynAbs.Tracing.TraceSender.Expression_True(1469, 53905, 53953) && f_1469_53930_53953(oldPipe)) && (DynAbs.Tracing.TraceSender.Expression_True(1469, 53905, 53973) && f_1469_53957_53969(_stack) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 53901, 54083);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 54023, 54060);

                            f_1469_54023_54036(_stack).ExecutionFailed = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 53901, 54083);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 54219, 54392) || true) && (f_1469_54223_54235(_stack) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1469, 54223, 54266) && _localPipeline != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 54219, 54392);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 54316, 54369);

                            f_1469_54316_54368(_localPipeline, f_1469_54344_54367(oldPipe));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 54219, 54392);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 53776, 54411);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 53343, 54437);

                int
                f_1469_53780_53792(System.Collections.Generic.Stack<System.Management.Automation.Internal.PipelineProcessor>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 53780, 53792);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1469_53866_53878(System.Collections.Generic.Stack<System.Management.Automation.Internal.PipelineProcessor>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 53866, 53878);
                    return return_v;
                }


                bool
                f_1469_53930_53953(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    var return_v = this_param.ExecutionFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 53930, 53953);
                    return return_v;
                }


                int
                f_1469_53957_53969(System.Collections.Generic.Stack<System.Management.Automation.Internal.PipelineProcessor>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 53957, 53969);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1469_54023_54036(System.Collections.Generic.Stack<System.Management.Automation.Internal.PipelineProcessor>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 54023, 54036);
                    return return_v;
                }


                int
                f_1469_54223_54235(System.Collections.Generic.Stack<System.Management.Automation.Internal.PipelineProcessor>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 54223, 54235);
                    return return_v;
                }


                bool
                f_1469_54344_54367(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    var return_v = this_param.ExecutionFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 54344, 54367);
                    return return_v;
                }


                int
                f_1469_54316_54368(System.Management.Automation.Runspaces.LocalPipeline
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 54316, 54368);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 53343, 54437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 53343, 54437);
            }
        }

        internal void Stop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1469, 54449, 55898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 54494, 54524);

                PipelineProcessor[]
                copyStack
                = default(PipelineProcessor[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 54544, 54553);
                lock (_syncRoot)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 54587, 54676) || true) && (_stopping == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 54587, 54676);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 54650, 54657);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 54587, 54676);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 54696, 54713);

                    _stopping = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 54733, 54762);

                    copyStack = f_1469_54745_54761(_stack);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 54893, 55206) || true) && (f_1469_54897_54913(copyStack) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 54893, 55206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 54951, 55012);

                    PipelineProcessor
                    topLevel = copyStack[f_1469_54990_55006(copyStack) - 1]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 55030, 55191) || true) && (topLevel != null && (DynAbs.Tracing.TraceSender.Expression_True(1469, 55034, 55076) && _localPipeline != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 55030, 55191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 55118, 55172);

                        f_1469_55118_55171(_localPipeline, f_1469_55146_55170(topLevel));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 55030, 55191);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 54893, 55206);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 55786, 55887);
                    foreach (PipelineProcessor pp in f_1469_55819_55828_I(copyStack))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1469, 55786, 55887);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1469, 55862, 55872);

                        f_1469_55862_55871(pp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1469, 55786, 55887);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1469, 1, 102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1469, 1, 102);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1469, 54449, 55898);

                System.Management.Automation.Internal.PipelineProcessor[]
                f_1469_54745_54761(System.Collections.Generic.Stack<System.Management.Automation.Internal.PipelineProcessor>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 54745, 54761);
                    return return_v;
                }


                int
                f_1469_54897_54913(System.Management.Automation.Internal.PipelineProcessor[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 54897, 54913);
                    return return_v;
                }


                int
                f_1469_54990_55006(System.Management.Automation.Internal.PipelineProcessor[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 54990, 55006);
                    return return_v;
                }


                bool
                f_1469_55146_55170(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    var return_v = this_param.ExecutionFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1469, 55146, 55170);
                    return return_v;
                }


                int
                f_1469_55118_55171(System.Management.Automation.Runspaces.LocalPipeline
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 55118, 55171);
                    return 0;
                }


                int
                f_1469_55862_55871(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 55862, 55871);
                    return 0;
                }


                System.Management.Automation.Internal.PipelineProcessor[]
                f_1469_55819_55828_I(System.Management.Automation.Internal.PipelineProcessor[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 55819, 55828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1469, 54449, 55898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 54449, 55898);
            }
        }

        static PipelineStopper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1469, 51556, 55905);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1469, 51556, 55905);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1469, 51556, 55905);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1469, 51556, 55905);

        System.Collections.Generic.Stack<System.Management.Automation.Internal.PipelineProcessor>
        f_1469_51752_51782()
        {
            var return_v = new System.Collections.Generic.Stack<System.Management.Automation.Internal.PipelineProcessor>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 51752, 51782);
            return return_v;
        }


        object
        f_1469_51915_51927()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1469, 51915, 51927);
            return return_v;
        }

    }
}

