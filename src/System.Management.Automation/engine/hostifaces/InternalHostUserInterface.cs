// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Host;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Security;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Internal.Host
{
    internal partial
        class InternalHostUserInterface : PSHostUserInterface, IHostUISupportsMultipleChoiceSelection
    {
        internal
                InternalHostUserInterface(PSHostUserInterface externalUI, InternalHost parentHost)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1465, 585, 1337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 36579, 36597);
                this._externalUI = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 36645, 36666);
                this._internalRawUI = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 36698, 36712);
                this._parent = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 36754, 36782);
                this._informationalBuffers = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 751, 776);

                _externalUI = externalUI;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 842, 899);

                f_1465_842_898(parentHost != null, "parent may not be null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 913, 1043) || true) && (parentHost == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 913, 1043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 969, 1028);

                    throw f_1465_975_1027("parentHost");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 913, 1043);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 1059, 1080);

                _parent = parentHost;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 1096, 1132);

                PSHostRawUserInterface
                rawui = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 1148, 1244) || true) && (externalUI != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 1148, 1244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 1204, 1229);

                    rawui = f_1465_1212_1228(externalUI);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 1148, 1244);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 1260, 1326);

                _internalRawUI = f_1465_1277_1325(rawui, _parent);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1465, 585, 1337);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 585, 1337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 585, 1337);
            }
        }

        private
                void
                ThrowNotInteractive()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 1349, 1474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 1426, 1463);

                f_1465_1426_1462(_internalRawUI);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 1349, 1474);

                int
                f_1465_1426_1462(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                this_param)
                {
                    this_param.ThrowNotInteractive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 1426, 1462);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 1349, 1474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 1349, 1474);
            }
        }

        private
                void
                ThrowPromptNotInteractive(string promptMessage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 1486, 1931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 1589, 1704);

                string
                message = f_1465_1606_1703(f_1465_1624_1687(), promptMessage)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 1718, 1898);

                HostException
                e = f_1465_1736_1897(message, null, "HostFunctionNotImplemented", ErrorCategory.NotImplemented)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 1912, 1920);

                throw e;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 1486, 1931);

                string
                f_1465_1624_1687()
                {
                    var return_v = HostInterfaceExceptionsStrings.HostFunctionPromptNotImplemented;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 1624, 1687);
                    return return_v;
                }


                string
                f_1465_1606_1703(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 1606, 1703);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_1465_1736_1897(string
                message, System.Exception
                innerException, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory)
                {
                    var return_v = new System.Management.Automation.Host.HostException(message, innerException, errorId, errorCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 1736, 1897);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 1486, 1931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 1486, 1931);
            }
        }

        public override
                System.Management.Automation.Host.PSHostRawUserInterface
                RawUI
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 2197, 2270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 2233, 2255);

                    return _internalRawUI;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 2197, 2270);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 2076, 2281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 2076, 2281);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool SupportsVirtualTerminal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 2362, 2445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 2368, 2443);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1465, 2375, 2396) || (((_externalUI != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1465, 2399, 2434)) || DynAbs.Tracing.TraceSender.Conditional_F3(1465, 2437, 2442))) ? f_1465_2399_2434(_externalUI) : false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 2362, 2445);

                    bool
                    f_1465_2399_2434(System.Management.Automation.Host.PSHostUserInterface
                    this_param)
                    {
                        var return_v = this_param.SupportsVirtualTerminal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 2399, 2434);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 2293, 2456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 2293, 2456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override
                string
                ReadLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 2776, 3586);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 2852, 2946) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 2852, 2946);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 2909, 2931);

                    f_1465_2909_2930(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 2852, 2946);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 2962, 2983);

                string
                result = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 3033, 3065);

                    result = f_1465_3042_3064(_externalUI);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1465, 3094, 3545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 3278, 3391);

                    LocalPipeline
                    lpl = (LocalPipeline)f_1465_3313_3390(((RunspaceBase)f_1465_3328_3359(f_1465_3328_3343(_parent))))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 3409, 3491) || true) && (lpl == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 3409, 3491);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 3466, 3472);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 3409, 3491);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 3511, 3530);

                    f_1465_3511_3529(f_1465_3511_3522(lpl));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1465, 3094, 3545);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 3561, 3575);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 2776, 3586);

                int
                f_1465_2909_2930(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param)
                {
                    this_param.ThrowNotInteractive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 2909, 2930);
                    return 0;
                }


                string
                f_1465_3042_3064(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.ReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 3042, 3064);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1465_3328_3343(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 3328, 3343);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1465_3328_3359(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 3328, 3359);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1465_3313_3390(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 3313, 3390);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStopper
                f_1465_3511_3522(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Stopper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 3511, 3522);
                    return return_v;
                }


                int
                f_1465_3511_3529(System.Management.Automation.Runspaces.PipelineStopper
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 3511, 3529);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 2776, 3586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 2776, 3586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                SecureString
                ReadLineAsSecureString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 3908, 4760);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 4004, 4098) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 4004, 4098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 4061, 4083);

                    f_1465_4061_4082(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 4004, 4098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 4114, 4141);

                SecureString
                result = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 4193, 4239);

                    result = f_1465_4202_4238(_externalUI);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1465, 4268, 4719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 4452, 4565);

                    LocalPipeline
                    lpl = (LocalPipeline)f_1465_4487_4564(((RunspaceBase)f_1465_4502_4533(f_1465_4502_4517(_parent))))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 4583, 4665) || true) && (lpl == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 4583, 4665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 4640, 4646);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 4583, 4665);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 4685, 4704);

                    f_1465_4685_4703(f_1465_4685_4696(lpl));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1465, 4268, 4719);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 4735, 4749);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 3908, 4760);

                int
                f_1465_4061_4082(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param)
                {
                    this_param.ThrowNotInteractive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 4061, 4082);
                    return 0;
                }


                System.Security.SecureString
                f_1465_4202_4238(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.ReadLineAsSecureString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 4202, 4238);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1465_4502_4517(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 4502, 4517);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1465_4502_4533(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 4502, 4533);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1465_4487_4564(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 4487, 4564);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStopper
                f_1465_4685_4696(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Stopper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 4685, 4696);
                    return return_v;
                }


                int
                f_1465_4685_4703(System.Management.Automation.Runspaces.PipelineStopper
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 4685, 4703);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 3908, 4760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 3908, 4760);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                void
                Write(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 5179, 5482);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 5262, 5335) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 5262, 5335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 5313, 5320);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 5262, 5335);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 5351, 5430) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 5351, 5430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 5408, 5415);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 5351, 5430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 5446, 5471);

                f_1465_5446_5470(
                            _externalUI, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 5179, 5482);

                int
                f_1465_5446_5470(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 5446, 5470);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 5179, 5482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 5179, 5482);
            }
        }

        public override
                void
                Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 6033, 6430);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 6176, 6249) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 6176, 6249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 6227, 6234);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 6176, 6249);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 6265, 6344) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 6265, 6344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 6322, 6329);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 6265, 6344);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 6360, 6419);

                f_1465_6360_6418(
                            _externalUI, foregroundColor, backgroundColor, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 6033, 6430);

                int
                f_1465_6360_6418(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.ConsoleColor
                foregroundColor, System.ConsoleColor
                backgroundColor, string
                value)
                {
                    this_param.Write(foregroundColor, backgroundColor, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 6360, 6418);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 6033, 6430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 6033, 6430);
            }
        }

        public override
                void
                WriteLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 6845, 7050);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 6920, 6999) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 6920, 6999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 6977, 6984);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 6920, 6999);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 7015, 7039);

                f_1465_7015_7038(
                            _externalUI);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 6845, 7050);

                int
                f_1465_7015_7038(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 7015, 7038);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 6845, 7050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 6845, 7050);
            }
        }

        public override
                void
                WriteLine(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 7469, 7780);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 7556, 7629) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 7556, 7629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 7607, 7614);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 7556, 7629);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 7645, 7724) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 7645, 7724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 7702, 7709);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 7645, 7724);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 7740, 7769);

                f_1465_7740_7768(
                            _externalUI, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 7469, 7780);

                int
                f_1465_7740_7768(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 7740, 7768);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 7469, 7780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 7469, 7780);
            }
        }

        public override
                void
                WriteErrorLine(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 7792, 8113);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 7884, 7957) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 7884, 7957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 7935, 7942);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 7884, 7957);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 7973, 8052) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 7973, 8052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 8030, 8037);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 7973, 8052);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 8068, 8102);

                f_1465_8068_8101(
                            _externalUI, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 7792, 8113);

                int
                f_1465_8068_8101(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteErrorLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 8068, 8101);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 7792, 8113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 7792, 8113);
            }
        }

        public override
                void
                WriteLine(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 8664, 9069);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 8811, 8884) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 8811, 8884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 8862, 8869);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 8811, 8884);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 8900, 8979) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 8900, 8979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 8957, 8964);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 8900, 8979);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 8995, 9058);

                f_1465_8995_9057(
                            _externalUI, foregroundColor, backgroundColor, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 8664, 9069);

                int
                f_1465_8995_9057(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.ConsoleColor
                foregroundColor, System.ConsoleColor
                backgroundColor, string
                value)
                {
                    this_param.WriteLine(foregroundColor, backgroundColor, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 8995, 9057);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 8664, 9069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 8664, 9069);
            }
        }

        public override
                void
                WriteDebugLine(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 9434, 9569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 9528, 9558);

                f_1465_9528_9557(this, message);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 9434, 9569);

                int
                f_1465_9528_9557(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteDebugLineHelper(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 9528, 9557);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 9434, 9569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 9434, 9569);
            }
        }

        internal void WriteDebugRecord(DebugRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 9628, 9898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 9703, 9733);

                f_1465_9703_9732(this, record);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 9749, 9828) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 9749, 9828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 9806, 9813);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 9749, 9828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 9844, 9887);

                f_1465_9844_9886(
                            _externalUI, f_1465_9871_9885(record));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 9628, 9898);

                int
                f_1465_9703_9732(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.DebugRecord
                record)
                {
                    this_param.WriteDebugInfoBuffers(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 9703, 9732);
                    return 0;
                }


                string
                f_1465_9871_9885(System.Management.Automation.DebugRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 9871, 9885);
                    return return_v;
                }


                int
                f_1465_9844_9886(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteDebugLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 9844, 9886);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 9628, 9898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 9628, 9898);
            }
        }

        internal void WriteDebugInfoBuffers(DebugRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 10074, 10286);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 10154, 10275) || true) && (_informationalBuffers != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 10154, 10275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 10221, 10260);

                    f_1465_10221_10259(_informationalBuffers, record);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 10154, 10275);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 10074, 10286);

                int
                f_1465_10221_10259(System.Management.Automation.PSInformationalBuffers
                this_param, System.Management.Automation.DebugRecord
                item)
                {
                    this_param.AddDebug(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 10221, 10259);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 10074, 10286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 10074, 10286);
            }
        }

        internal
                void
                WriteDebugLine(string message, ref ActionPreference preference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 10993, 13412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 11113, 11136);

                string
                errorMsg = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 11150, 11181);

                ErrorRecord
                errorRecord = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 11195, 13401);

                switch (preference)
                {

                    case ActionPreference.Continue:
                    case ActionPreference.Break:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 11195, 13401);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 11346, 11376);

                        f_1465_11346_11375(this, message);
                        DynAbs.Tracing.TraceSender.TraceBreak(1465, 11398, 11404);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 11195, 13401);

                    case ActionPreference.SilentlyContinue:
                    case ActionPreference.Ignore:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 11195, 13401);
                        DynAbs.Tracing.TraceSender.TraceBreak(1465, 11530, 11536);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 11195, 13401);

                    case ActionPreference.Inquire:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 11195, 13401);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 11606, 12427) || true) && (!f_1465_11611_11655(this, message, ref preference))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 11606, 12427);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 11768, 11839);

                            errorMsg = f_1465_11779_11838();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 11865, 12031);

                            errorRecord = f_1465_11879_12030(f_1465_11895_11943(errorMsg), "UserStopRequest", ErrorCategory.OperationStopped, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 12057, 12138);

                            ActionPreferenceStopException
                            e = f_1465_12091_12137(errorRecord)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 12268, 12276);

                            throw e;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 11606, 12427);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 11606, 12427);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 12374, 12404);

                            f_1465_12374_12403(this, message);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 11606, 12427);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1465, 12451, 12457);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 11195, 13401);

                    case ActionPreference.Stop:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 11195, 13401);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 12524, 12554);

                        f_1465_12524_12553(this, message);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 12578, 12649);

                        errorMsg = f_1465_12589_12648();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 12671, 12838);

                        errorRecord = f_1465_12685_12837(f_1465_12701_12749(errorMsg), "ActionPreferenceStop", ErrorCategory.OperationStopped, null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 12860, 12944);

                        ActionPreferenceStopException
                        ense = f_1465_12897_12943(errorRecord)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 13066, 13077);

                        throw ense;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 11195, 13401);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 11195, 13401);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 13125, 13180);

                        f_1465_13125_13179(false, "all preferences should be checked");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 13202, 13355);

                        throw f_1465_13208_13354("preference", f_1465_13282_13341(), preference);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 11195, 13401);
                        // break;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 10993, 13412);

                int
                f_1465_11346_11375(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteDebugLineHelper(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 11346, 11375);
                    return 0;
                }


                bool
                f_1465_11611_11655(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                message, ref System.Management.Automation.ActionPreference
                actionPreference)
                {
                    var return_v = this_param.DebugShouldContinue(message, ref actionPreference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 11611, 11655);
                    return return_v;
                }


                string
                f_1465_11779_11838()
                {
                    var return_v = InternalHostUserInterfaceStrings.WriteDebugLineStoppedError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 11779, 11838);
                    return return_v;
                }


                System.Management.Automation.ParentContainsErrorRecordException
                f_1465_11895_11943(string
                message)
                {
                    var return_v = new System.Management.Automation.ParentContainsErrorRecordException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 11895, 11943);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1465_11879_12030(System.Management.Automation.ParentContainsErrorRecordException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 11879, 12030);
                    return return_v;
                }


                System.Management.Automation.ActionPreferenceStopException
                f_1465_12091_12137(System.Management.Automation.ErrorRecord
                error)
                {
                    var return_v = new System.Management.Automation.ActionPreferenceStopException(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 12091, 12137);
                    return return_v;
                }


                int
                f_1465_12374_12403(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteDebugLineHelper(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 12374, 12403);
                    return 0;
                }


                int
                f_1465_12524_12553(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteDebugLineHelper(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 12524, 12553);
                    return 0;
                }


                string
                f_1465_12589_12648()
                {
                    var return_v = InternalHostUserInterfaceStrings.WriteDebugLineStoppedError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 12589, 12648);
                    return return_v;
                }


                System.Management.Automation.ParentContainsErrorRecordException
                f_1465_12701_12749(string
                message)
                {
                    var return_v = new System.Management.Automation.ParentContainsErrorRecordException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 12701, 12749);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1465_12685_12837(System.Management.Automation.ParentContainsErrorRecordException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 12685, 12837);
                    return return_v;
                }


                System.Management.Automation.ActionPreferenceStopException
                f_1465_12897_12943(System.Management.Automation.ErrorRecord
                error)
                {
                    var return_v = new System.Management.Automation.ActionPreferenceStopException(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 12897, 12943);
                    return return_v;
                }


                int
                f_1465_13125_13179(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 13125, 13179);
                    return 0;
                }


                string
                f_1465_13282_13341()
                {
                    var return_v = InternalHostUserInterfaceStrings.UnsupportedPreferenceError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 13282, 13341);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1465_13208_13354(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 13208, 13354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 10993, 13412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 10993, 13412);
            }
        }

        internal void SetInformationalMessageBuffers(PSInformationalBuffers informationalBuffers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 13962, 14132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 14076, 14121);

                _informationalBuffers = informationalBuffers;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 13962, 14132);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 13962, 14132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 13962, 14132);
            }
        }

        internal PSInformationalBuffers GetInformationalMessageBuffers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 14319, 14448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 14408, 14437);

                return _informationalBuffers;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 14319, 14448);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 14319, 14448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 14319, 14448);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private
                void
                WriteDebugLineHelper(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 14460, 14697);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 14552, 14627) || true) && (message == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 14552, 14627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 14605, 14612);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 14552, 14627);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 14643, 14686);

                f_1465_14643_14685(this, f_1465_14660_14684(message));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 14460, 14697);

                System.Management.Automation.DebugRecord
                f_1465_14660_14684(string
                message)
                {
                    var return_v = new System.Management.Automation.DebugRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 14660, 14684);
                    return return_v;
                }


                int
                f_1465_14643_14685(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.DebugRecord
                record)
                {
                    this_param.WriteDebugRecord(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 14643, 14685);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 14460, 14697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 14460, 14697);
            }
        }

        private
                bool
                DebugShouldContinue(string message, ref ActionPreference actionPreference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 15327, 18212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 15457, 15569);

                f_1465_15457_15568(actionPreference == ActionPreference.Inquire, "Why are you inquiring if your preference is not to?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 15585, 15613);

                bool
                shouldContinue = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 15629, 15705);

                Collection<ChoiceDescription>
                choices = f_1465_15669_15704()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 15721, 15869);

                f_1465_15721_15868(
                            choices, f_1465_15733_15867(f_1465_15755_15810(), f_1465_15812_15866()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 15883, 16041);

                f_1465_15883_16040(choices, f_1465_15895_16039(f_1465_15917_15977(), f_1465_15979_16038()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 16055, 16201);

                f_1465_16055_16200(choices, f_1465_16067_16199(f_1465_16089_16143(), f_1465_16145_16198()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 16215, 16371);

                f_1465_16215_16370(choices, f_1465_16227_16369(f_1465_16249_16308(), f_1465_16310_16368()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 16385, 16541);

                f_1465_16385_16540(choices, f_1465_16397_16539(f_1465_16419_16478(), f_1465_16480_16538()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 16557, 16577);

                bool
                endLoop = true
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 16591, 18163);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 16626, 16641);

                            endLoop = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 16661, 18123);

                            switch (
                            f_1465_16691_16890(this, f_1465_16733_16793(), message, choices, 0))
                            {

                                case 0:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 16661, 18123);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 16965, 16987);

                                    shouldContinue = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1465, 17013, 17019);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 16661, 18123);

                                case 1:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 16661, 18123);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 17076, 17121);

                                    actionPreference = ActionPreference.Continue;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 17147, 17169);

                                    shouldContinue = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1465, 17195, 17201);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 16661, 18123);

                                case 2:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 16661, 18123);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 17258, 17281);

                                    shouldContinue = false;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1465, 17307, 17313);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 16661, 18123);

                                case 3:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 16661, 18123);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 17736, 17777);

                                    actionPreference = ActionPreference.Stop;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 17803, 17826);

                                    shouldContinue = false;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1465, 17852, 17858);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 16661, 18123);

                                case 4:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 16661, 18123);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 18002, 18030);

                                    f_1465_18002_18029(                        // This call returns when the user exits the nested prompt.

                                                            _parent);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 18056, 18072);

                                    endLoop = false;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1465, 18098, 18104);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 16661, 18123);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 16591, 18163);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 16591, 18163) || true) && (endLoop != true)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1465, 16591, 18163);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1465, 16591, 18163);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 18179, 18201);

                return shouldContinue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 15327, 18212);

                int
                f_1465_15457_15568(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 15457, 15568);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                f_1465_15669_15704()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 15669, 15704);
                    return return_v;
                }


                string
                f_1465_15755_15810()
                {
                    var return_v = InternalHostUserInterfaceStrings.ShouldContinueYesLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 15755, 15810);
                    return return_v;
                }


                string
                f_1465_15812_15866()
                {
                    var return_v = InternalHostUserInterfaceStrings.ShouldContinueYesHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 15812, 15866);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1465_15733_15867(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 15733, 15867);
                    return return_v;
                }


                int
                f_1465_15721_15868(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 15721, 15868);
                    return 0;
                }


                string
                f_1465_15917_15977()
                {
                    var return_v = InternalHostUserInterfaceStrings.ShouldContinueYesToAllLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 15917, 15977);
                    return return_v;
                }


                string
                f_1465_15979_16038()
                {
                    var return_v = InternalHostUserInterfaceStrings.ShouldContinueYesToAllHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 15979, 16038);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1465_15895_16039(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 15895, 16039);
                    return return_v;
                }


                int
                f_1465_15883_16040(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 15883, 16040);
                    return 0;
                }


                string
                f_1465_16089_16143()
                {
                    var return_v = InternalHostUserInterfaceStrings.ShouldContinueNoLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 16089, 16143);
                    return return_v;
                }


                string
                f_1465_16145_16198()
                {
                    var return_v = InternalHostUserInterfaceStrings.ShouldContinueNoHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 16145, 16198);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1465_16067_16199(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 16067, 16199);
                    return return_v;
                }


                int
                f_1465_16055_16200(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 16055, 16200);
                    return 0;
                }


                string
                f_1465_16249_16308()
                {
                    var return_v = InternalHostUserInterfaceStrings.ShouldContinueNoToAllLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 16249, 16308);
                    return return_v;
                }


                string
                f_1465_16310_16368()
                {
                    var return_v = InternalHostUserInterfaceStrings.ShouldContinueNoToAllHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 16310, 16368);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1465_16227_16369(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 16227, 16369);
                    return return_v;
                }


                int
                f_1465_16215_16370(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 16215, 16370);
                    return 0;
                }


                string
                f_1465_16419_16478()
                {
                    var return_v = InternalHostUserInterfaceStrings.ShouldContinueSuspendLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 16419, 16478);
                    return return_v;
                }


                string
                f_1465_16480_16538()
                {
                    var return_v = InternalHostUserInterfaceStrings.ShouldContinueSuspendHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 16480, 16538);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1465_16397_16539(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 16397, 16539);
                    return return_v;
                }


                int
                f_1465_16385_16540(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 16385, 16540);
                    return 0;
                }


                string
                f_1465_16733_16793()
                {
                    var return_v = InternalHostUserInterfaceStrings.ShouldContinuePromptMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 16733, 16793);
                    return return_v;
                }


                int
                f_1465_16691_16890(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                caption, string
                message, System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                choices, int
                defaultChoice)
                {
                    var return_v = this_param.PromptForChoice(caption, message, choices, defaultChoice);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 16691, 16890);
                    return return_v;
                }


                int
                f_1465_18002_18029(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    this_param.EnterNestedPrompt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 18002, 18029);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 15327, 18212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 15327, 18212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                void
                WriteProgress(Int64 sourceId, ProgressRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 18576, 19165);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 18692, 18814) || true) && (record == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 18692, 18814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 18744, 18799);

                    throw f_1465_18750_18798("record");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 18692, 18814);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 18875, 18999) || true) && (_informationalBuffers != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 18875, 18999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 18942, 18984);

                    f_1465_18942_18983(_informationalBuffers, record);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 18875, 18999);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 19015, 19094) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 19015, 19094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 19072, 19079);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 19015, 19094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 19110, 19154);

                f_1465_19110_19153(
                            _externalUI, sourceId, record);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 18576, 19165);

                System.Management.Automation.PSArgumentNullException
                f_1465_18750_18798(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 18750, 18798);
                    return return_v;
                }


                int
                f_1465_18942_18983(System.Management.Automation.PSInformationalBuffers
                this_param, System.Management.Automation.ProgressRecord
                item)
                {
                    this_param.AddProgress(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 18942, 18983);
                    return 0;
                }


                int
                f_1465_19110_19153(System.Management.Automation.Host.PSHostUserInterface
                this_param, long
                sourceId, System.Management.Automation.ProgressRecord
                record)
                {
                    this_param.WriteProgress(sourceId, record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 19110, 19153);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 18576, 19165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 18576, 19165);
            }
        }

        public override
                void
                WriteVerboseLine(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 19530, 19775);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 19626, 19701) || true) && (message == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 19626, 19701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 19679, 19686);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 19626, 19701);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 19717, 19764);

                f_1465_19717_19763(this, f_1465_19736_19762(message));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 19530, 19775);

                System.Management.Automation.VerboseRecord
                f_1465_19736_19762(string
                message)
                {
                    var return_v = new System.Management.Automation.VerboseRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 19736, 19762);
                    return return_v;
                }


                int
                f_1465_19717_19763(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.VerboseRecord
                record)
                {
                    this_param.WriteVerboseRecord(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 19717, 19763);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 19530, 19775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 19530, 19775);
            }
        }

        internal void WriteVerboseRecord(VerboseRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 19834, 20112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 19913, 19945);

                f_1465_19913_19944(this, record);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 19961, 20040) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 19961, 20040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 20018, 20025);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 19961, 20040);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 20056, 20101);

                f_1465_20056_20100(
                            _externalUI, f_1465_20085_20099(record));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 19834, 20112);

                int
                f_1465_19913_19944(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.VerboseRecord
                record)
                {
                    this_param.WriteVerboseInfoBuffers(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 19913, 19944);
                    return 0;
                }


                string
                f_1465_20085_20099(System.Management.Automation.VerboseRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 20085, 20099);
                    return return_v;
                }


                int
                f_1465_20056_20100(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteVerboseLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 20056, 20100);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 19834, 20112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 19834, 20112);
            }
        }

        internal void WriteVerboseInfoBuffers(VerboseRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 20292, 20510);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 20376, 20499) || true) && (_informationalBuffers != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 20376, 20499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 20443, 20484);

                    f_1465_20443_20483(_informationalBuffers, record);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 20376, 20499);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 20292, 20510);

                int
                f_1465_20443_20483(System.Management.Automation.PSInformationalBuffers
                this_param, System.Management.Automation.VerboseRecord
                item)
                {
                    this_param.AddVerbose(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 20443, 20483);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 20292, 20510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 20292, 20510);
            }
        }

        public override void WriteWarningLine(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 20875, 21102);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 20953, 21028) || true) && (message == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 20953, 21028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 21006, 21013);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 20953, 21028);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 21044, 21091);

                f_1465_21044_21090(this, f_1465_21063_21089(message));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 20875, 21102);

                System.Management.Automation.WarningRecord
                f_1465_21063_21089(string
                message)
                {
                    var return_v = new System.Management.Automation.WarningRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 21063, 21089);
                    return return_v;
                }


                int
                f_1465_21044_21090(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.WarningRecord
                record)
                {
                    this_param.WriteWarningRecord(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 21044, 21090);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 20875, 21102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 20875, 21102);
            }
        }

        internal void WriteWarningRecord(WarningRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 21161, 21439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 21240, 21272);

                f_1465_21240_21271(this, record);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 21288, 21367) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 21288, 21367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 21345, 21352);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 21288, 21367);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 21383, 21428);

                f_1465_21383_21427(
                            _externalUI, f_1465_21412_21426(record));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 21161, 21439);

                int
                f_1465_21240_21271(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.WarningRecord
                record)
                {
                    this_param.WriteWarningInfoBuffers(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 21240, 21271);
                    return 0;
                }


                string
                f_1465_21412_21426(System.Management.Automation.WarningRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 21412, 21426);
                    return return_v;
                }


                int
                f_1465_21383_21427(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteWarningLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 21383, 21427);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 21161, 21439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 21161, 21439);
            }
        }

        internal void WriteWarningInfoBuffers(WarningRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 21619, 21837);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 21703, 21826) || true) && (_informationalBuffers != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 21703, 21826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 21770, 21811);

                    f_1465_21770_21810(_informationalBuffers, record);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 21703, 21826);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 21619, 21837);

                int
                f_1465_21770_21810(System.Management.Automation.PSInformationalBuffers
                this_param, System.Management.Automation.WarningRecord
                item)
                {
                    this_param.AddWarning(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 21770, 21810);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 21619, 21837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 21619, 21837);
            }
        }

        internal void WriteInformationRecord(InformationRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 21896, 22178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 21983, 22019);

                f_1465_21983_22018(this, record);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 22035, 22114) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 22035, 22114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 22092, 22099);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 22035, 22114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 22130, 22167);

                f_1465_22130_22166(
                            _externalUI, record);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 21896, 22178);

                int
                f_1465_21983_22018(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.InformationRecord
                record)
                {
                    this_param.WriteInformationInfoBuffers(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 21983, 22018);
                    return 0;
                }


                int
                f_1465_22130_22166(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.InformationRecord
                record)
                {
                    this_param.WriteInformation(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 22130, 22166);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 21896, 22178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 21896, 22178);
            }
        }

        internal void WriteInformationInfoBuffers(InformationRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 22362, 22592);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 22454, 22581) || true) && (_informationalBuffers != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 22454, 22581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 22521, 22566);

                    f_1465_22521_22565(_informationalBuffers, record);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 22454, 22581);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 22362, 22592);

                int
                f_1465_22521_22565(System.Management.Automation.PSInformationalBuffers
                this_param, System.Management.Automation.InformationRecord
                item)
                {
                    this_param.AddInformation(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 22521, 22565);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 22362, 22592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 22362, 22592);
            }
        }

        internal static Type GetFieldType(FieldDescription field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1465, 22604, 22979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 22686, 22698);

                Type
                result
                = default(Type);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 22712, 22940) || true) && (f_1465_22716_22788(f_1465_22744_22775(field), out result) || (DynAbs.Tracing.TraceSender.Expression_False(1465, 22716, 22877) || f_1465_22809_22877(f_1465_22837_22864(field), out result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 22712, 22940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 22911, 22925);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 22712, 22940);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 22956, 22968);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1465, 22604, 22979);

                string
                f_1465_22744_22775(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.ParameterAssemblyFullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 22744, 22775);
                    return return_v;
                }


                bool
                f_1465_22716_22788(string
                typeName, out System.Type
                type)
                {
                    var return_v = TypeResolver.TryResolveType(typeName, out type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 22716, 22788);
                    return return_v;
                }


                string
                f_1465_22837_22864(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.ParameterTypeFullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 22837, 22864);
                    return return_v;
                }


                bool
                f_1465_22809_22877(string
                typeName, out System.Type
                type)
                {
                    var return_v = TypeResolver.TryResolveType(typeName, out type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 22809, 22877);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 22604, 22979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 22604, 22979);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsSecuritySensitiveType(string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1465, 22991, 23419);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 23077, 23220) || true) && (f_1465_23081_23159(typeName, f_1465_23097_23122(typeof(PSCredential)), StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 23077, 23220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 23193, 23205);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 23077, 23220);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 23236, 23379) || true) && (f_1465_23240_23318(typeName, f_1465_23256_23281(typeof(SecureString)), StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 23236, 23379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 23352, 23364);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 23236, 23379);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 23395, 23408);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1465, 22991, 23419);

                string
                f_1465_23097_23122(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 23097, 23122);
                    return return_v;
                }


                bool
                f_1465_23081_23159(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 23081, 23159);
                    return return_v;
                }


                string
                f_1465_23256_23281(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 23256, 23281);
                    return return_v;
                }


                bool
                f_1465_23240_23318(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 23240, 23318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 22991, 23419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 22991, 23419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                Dictionary<string, PSObject>
                Prompt(string caption, string message, Collection<FieldDescription> descriptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 24203, 25548);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 24372, 24506) || true) && (descriptions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 24372, 24506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 24430, 24491);

                    throw f_1465_24436_24490("descriptions");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 24372, 24506);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 24522, 24733) || true) && (f_1465_24526_24544(descriptions) < 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 24522, 24733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 24582, 24718);

                    throw f_1465_24588_24717("descriptions", f_1465_24639_24700(), "descriptions");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 24522, 24733);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 24749, 24856) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 24749, 24856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 24806, 24841);

                    f_1465_24806_24840(this, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 24749, 24856);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 24872, 24915);

                Dictionary<string, PSObject>
                result = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 24967, 25027);

                    result = f_1465_24976_25026(_externalUI, caption, message, descriptions);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1465, 25056, 25507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 25240, 25353);

                    LocalPipeline
                    lpl = (LocalPipeline)f_1465_25275_25352(((RunspaceBase)f_1465_25290_25321(f_1465_25290_25305(_parent))))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 25371, 25453) || true) && (lpl == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 25371, 25453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 25428, 25434);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 25371, 25453);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 25473, 25492);

                    f_1465_25473_25491(f_1465_25473_25484(lpl));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1465, 25056, 25507);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 25523, 25537);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 24203, 25548);

                System.Management.Automation.PSArgumentNullException
                f_1465_24436_24490(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 24436, 24490);
                    return return_v;
                }


                int
                f_1465_24526_24544(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 24526, 24544);
                    return return_v;
                }


                string
                f_1465_24639_24700()
                {
                    var return_v = InternalHostUserInterfaceStrings.PromptEmptyDescriptionsError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 24639, 24700);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1465_24588_24717(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 24588, 24717);
                    return return_v;
                }


                int
                f_1465_24806_24840(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                promptMessage)
                {
                    this_param.ThrowPromptNotInteractive(promptMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 24806, 24840);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSObject>
                f_1465_24976_25026(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                caption, string
                message, System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
                descriptions)
                {
                    var return_v = this_param.Prompt(caption, message, descriptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 24976, 25026);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1465_25290_25305(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 25290, 25305);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1465_25290_25321(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 25290, 25321);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1465_25275_25352(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 25275, 25352);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStopper
                f_1465_25473_25484(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Stopper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 25473, 25484);
                    return return_v;
                }


                int
                f_1465_25473_25491(System.Management.Automation.Runspaces.PipelineStopper
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 25473, 25491);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 24203, 25548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 24203, 25548);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                int
                PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int defaultChoice)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 26066, 27023);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 26234, 26341) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 26234, 26341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 26291, 26326);

                    f_1465_26291_26325(this, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 26234, 26341);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 26357, 26373);

                int
                result = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 26423, 26502);

                    result = f_1465_26432_26501(_externalUI, caption, message, choices, defaultChoice);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1465, 26531, 26982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 26715, 26828);

                    LocalPipeline
                    lpl = (LocalPipeline)f_1465_26750_26827(((RunspaceBase)f_1465_26765_26796(f_1465_26765_26780(_parent))))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 26846, 26928) || true) && (lpl == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 26846, 26928);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 26903, 26909);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 26846, 26928);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 26948, 26967);

                    f_1465_26948_26966(f_1465_26948_26959(lpl));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1465, 26531, 26982);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 26998, 27012);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 26066, 27023);

                int
                f_1465_26291_26325(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                promptMessage)
                {
                    this_param.ThrowPromptNotInteractive(promptMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 26291, 26325);
                    return 0;
                }


                int
                f_1465_26432_26501(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                caption, string
                message, System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                choices, int
                defaultChoice)
                {
                    var return_v = this_param.PromptForChoice(caption, message, choices, defaultChoice);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 26432, 26501);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1465_26765_26780(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 26765, 26780);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1465_26765_26796(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 26765, 26796);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1465_26750_26827(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 26750, 26827);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStopper
                f_1465_26948_26959(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Stopper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 26948, 26959);
                    return return_v;
                }


                int
                f_1465_26948_26966(System.Management.Automation.Runspaces.PipelineStopper
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 26948, 26966);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 26066, 27023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 26066, 27023);
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
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 28034, 29739);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 28240, 28347) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 28240, 28347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 28297, 28332);

                    f_1465_28297_28331(this, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 28240, 28347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 28363, 28498);

                IHostUISupportsMultipleChoiceSelection
                hostForMultipleChoices =
                                _externalUI as IHostUISupportsMultipleChoiceSelection
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 28514, 28544);

                Collection<int>
                result = null
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 28594, 29218) || true) && (hostForMultipleChoices == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 28594, 29218);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 28943, 29026);

                        result = f_1465_28952_29025(this, caption, message, choices, defaultChoices);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 28594, 29218);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 28594, 29218);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 29108, 29199);

                        result = f_1465_29117_29198(hostForMultipleChoices, caption, message, choices, defaultChoices);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 28594, 29218);
                    }
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1465, 29247, 29698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 29431, 29544);

                    LocalPipeline
                    lpl = (LocalPipeline)f_1465_29466_29543(((RunspaceBase)f_1465_29481_29512(f_1465_29481_29496(_parent))))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 29562, 29644) || true) && (lpl == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 29562, 29644);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 29619, 29625);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 29562, 29644);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 29664, 29683);

                    f_1465_29664_29682(f_1465_29664_29675(lpl));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1465, 29247, 29698);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 29714, 29728);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 28034, 29739);

                int
                f_1465_28297_28331(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                promptMessage)
                {
                    this_param.ThrowPromptNotInteractive(promptMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 28297, 28331);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<int>
                f_1465_28952_29025(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                caption, string
                message, System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                choices, System.Collections.Generic.IEnumerable<int>
                defaultChoices)
                {
                    var return_v = this_param.EmulatePromptForMultipleChoice(caption, message, choices, defaultChoices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 28952, 29025);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<int>
                f_1465_29117_29198(System.Management.Automation.Host.IHostUISupportsMultipleChoiceSelection
                this_param, string
                caption, string
                message, System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                choices, System.Collections.Generic.IEnumerable<int>
                defaultChoices)
                {
                    var return_v = this_param.PromptForChoice(caption, message, choices, defaultChoices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 29117, 29198);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1465_29481_29496(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 29481, 29496);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1465_29481_29512(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 29481, 29512);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1465_29466_29543(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 29466, 29543);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStopper
                f_1465_29664_29675(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Stopper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 29664, 29675);
                    return return_v;
                }


                int
                f_1465_29664_29682(System.Management.Automation.Runspaces.PipelineStopper
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 29664, 29682);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 28034, 29739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 28034, 29739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Collection<int> EmulatePromptForMultipleChoice(string caption,
                    string message,
                    Collection<ChoiceDescription> choices,
                    IEnumerable<int> defaultChoices)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1465, 30383, 36539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 30605, 30667);

                f_1465_30605_30666(_externalUI != null, "externalUI cannot be null.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 30683, 30807) || true) && (choices == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 30683, 30807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 30736, 30792);

                    throw f_1465_30742_30791("choices");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 30683, 30807);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 30823, 31030) || true) && (f_1465_30827_30840(choices) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 30823, 31030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 30879, 31015);

                    throw f_1465_30885_31014("choices", f_1465_30952_31002(), "choices");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 30823, 31030);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 31046, 31116);

                Dictionary<int, bool>
                defaultChoiceKeys = f_1465_31088_31115()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 31130, 31948) || true) && (defaultChoices != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 31130, 31948);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 31190, 31933);
                        foreach (int defaultChoice in f_1465_31220_31234_I(defaultChoices))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 31190, 31933);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 31276, 31725) || true) && ((defaultChoice < 0) || (DynAbs.Tracing.TraceSender.Expression_False(1465, 31280, 31335) || (defaultChoice >= f_1465_31321_31334(choices))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 31276, 31725);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 31385, 31702);

                                throw f_1465_31391_31701("defaultChoice", defaultChoice, f_1465_31497_31570(), "defaultChoice", "choices", defaultChoice);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 31276, 31725);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 31749, 31914) || true) && (!f_1465_31754_31798(defaultChoiceKeys, defaultChoice))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 31749, 31914);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 31848, 31891);

                                f_1465_31848_31890(defaultChoiceKeys, defaultChoice, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 31749, 31914);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 31190, 31933);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1465, 1, 744);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1465, 1, 744);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 31130, 31948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32048, 32109);

                Text.StringBuilder
                choicesMessage = f_1465_32084_32108()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32123, 32143);

                char
                newLine = '\n'
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32157, 32320) || true) && (!f_1465_32162_32191(caption))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 32157, 32320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32225, 32256);

                    f_1465_32225_32255(choicesMessage, caption);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32274, 32305);

                    f_1465_32274_32304(choicesMessage, newLine);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 32157, 32320);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32336, 32499) || true) && (!f_1465_32341_32370(message))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 32336, 32499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32404, 32435);

                    f_1465_32404_32434(choicesMessage, message);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32453, 32484);

                    f_1465_32453_32483(choicesMessage, newLine);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 32336, 32499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32515, 32554);

                string[,]
                hotkeysAndPlainLabels = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32568, 32651);

                f_1465_32568_32650(choices, out hotkeysAndPlainLabels);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32667, 32705);

                string
                choiceTemplate = "[{0}] {1}  "
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32728, 32733);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32719, 33194) || true) && (i < f_1465_32739_32773(hotkeysAndPlainLabels, 1))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32775, 32778)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 32719, 33194))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 32719, 33194);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 32812, 33082);

                        string
                        choice =
                        f_1465_32849_33081(f_1465_32889_32931(), choiceTemplate, hotkeysAndPlainLabels[0, i], hotkeysAndPlainLabels[1, i])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 33100, 33130);

                        f_1465_33100_33129(choicesMessage, choice);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 33148, 33179);

                        f_1465_33148_33178(choicesMessage, newLine);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1465, 1, 476);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1465, 1, 476);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 33242, 33278);

                string
                defaultPrompt = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 33292, 34613) || true) && (f_1465_33296_33319(defaultChoiceKeys) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 33292, 34613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 33357, 33387);

                    string
                    prepend = string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 33405, 33473);

                    Text.StringBuilder
                    defaultChoicesBuilder = f_1465_33448_33472()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 33491, 34052);
                        foreach (int defaultChoice in f_1465_33521_33543_I(f_1465_33521_33543(defaultChoiceKeys)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 33491, 34052);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 33585, 33645);

                            string
                            defaultStr = hotkeysAndPlainLabels[0, defaultChoice]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 33667, 33829) || true) && (f_1465_33671_33703(defaultStr))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 33667, 33829);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 33753, 33806);

                                defaultStr = hotkeysAndPlainLabels[1, defaultChoice];
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 33667, 33829);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 33853, 33997);

                            f_1465_33853_33996(
                                                defaultChoicesBuilder, f_1465_33882_33995(f_1465_33896_33938(), "{0}{1}", prepend, defaultStr));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 34019, 34033);

                            prepend = ",";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 33491, 34052);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1465, 1, 562);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1465, 1, 562);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 34072, 34132);

                    string
                    defaultChoicesStr = f_1465_34099_34131(defaultChoicesBuilder)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 34152, 34598) || true) && (f_1465_34156_34179(defaultChoiceKeys) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 34152, 34598);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 34226, 34352);

                        defaultPrompt = f_1465_34242_34351(f_1465_34260_34306(), defaultChoicesStr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 34152, 34598);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 34152, 34598);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 34434, 34579);

                        defaultPrompt = f_1465_34450_34578(f_1465_34468_34533(), defaultChoicesStr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 34152, 34598);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 33292, 34613);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 34629, 34711);

                string
                messageToBeDisplayed = f_1465_34659_34684(choicesMessage) + defaultPrompt + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (newLine).ToString(), 1465, 34703, 34710)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 34768, 34815);

                Collection<int>
                result = f_1465_34793_34814()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 34829, 34853);

                int
                choicesSelected = 0
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 34867, 36498);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 34902, 35004);

                            string
                            choiceMsg = f_1465_34921_35003(f_1465_34939_34985(), choicesSelected)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 35022, 35056);

                            messageToBeDisplayed += choiceMsg;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 35074, 35118);

                            f_1465_35074_35117(_externalUI, messageToBeDisplayed);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 35136, 35177);

                            string
                            response = f_1465_35154_35176(_externalUI)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 35237, 36071) || true) && (f_1465_35241_35256(response) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 35237, 36071);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 35606, 35969) || true) && ((f_1465_35611_35623(result) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1465, 35610, 35668) && (f_1465_35634_35662(f_1465_35634_35656(defaultChoiceKeys)) >= 0)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 35606, 35969);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 35783, 35946);
                                        foreach (int defaultChoice in f_1465_35813_35835_I(f_1465_35813_35835(defaultChoiceKeys)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 35783, 35946);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 35893, 35919);

                                            f_1465_35893_35918(result, defaultChoice);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 35783, 35946);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1465, 1, 164);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1465, 1, 164);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 35606, 35969);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1465, 36046, 36052);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 35237, 36071);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 36091, 36201);

                            int
                            choicePicked = f_1465_36110_36200(f_1465_36152_36167(response), choices, hotkeysAndPlainLabels)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 36221, 36368) || true) && (choicePicked >= 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1465, 36221, 36368);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 36284, 36309);

                                f_1465_36284_36308(result, choicePicked);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 36331, 36349);

                                choicesSelected++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 36221, 36368);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 36433, 36469);

                            messageToBeDisplayed = string.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1465, 34867, 36498);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 34867, 36498) || true) && (true)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1465, 34867, 36498);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1465, 34867, 36498);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1465, 36514, 36528);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1465, 30383, 36539);

                int
                f_1465_30605_30666(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 30605, 30666);
                    return 0;
                }


                System.Management.Automation.PSArgumentNullException
                f_1465_30742_30791(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 30742, 30791);
                    return return_v;
                }


                int
                f_1465_30827_30840(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 30827, 30840);
                    return return_v;
                }


                string
                f_1465_30952_31002()
                {
                    var return_v = InternalHostUserInterfaceStrings.EmptyChoicesError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 30952, 31002);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1465_30885_31014(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 30885, 31014);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<int, bool>
                f_1465_31088_31115()
                {
                    var return_v = new System.Collections.Generic.Dictionary<int, bool>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 31088, 31115);
                    return return_v;
                }


                int
                f_1465_31321_31334(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 31321, 31334);
                    return return_v;
                }


                string
                f_1465_31497_31570()
                {
                    var return_v = InternalHostUserInterfaceStrings.InvalidDefaultChoiceForMultipleSelection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 31497, 31570);
                    return return_v;
                }


                System.Management.Automation.PSArgumentOutOfRangeException
                f_1465_31391_31701(string
                paramName, int
                actualValue, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 31391, 31701);
                    return return_v;
                }


                bool
                f_1465_31754_31798(System.Collections.Generic.Dictionary<int, bool>
                this_param, int
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 31754, 31798);
                    return return_v;
                }


                int
                f_1465_31848_31890(System.Collections.Generic.Dictionary<int, bool>
                this_param, int
                key, bool
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 31848, 31890);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<int>
                f_1465_31220_31234_I(System.Collections.Generic.IEnumerable<int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 31220, 31234);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1465_32084_32108()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 32084, 32108);
                    return return_v;
                }


                bool
                f_1465_32162_32191(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 32162, 32191);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1465_32225_32255(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 32225, 32255);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1465_32274_32304(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 32274, 32304);
                    return return_v;
                }


                bool
                f_1465_32341_32370(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 32341, 32370);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1465_32404_32434(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 32404, 32434);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1465_32453_32483(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 32453, 32483);
                    return return_v;
                }


                int
                f_1465_32568_32650(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                choices, out string[,]
                hotkeysAndPlainLabels)
                {
                    HostUIHelperMethods.BuildHotkeysAndPlainLabels(choices, out hotkeysAndPlainLabels);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 32568, 32650);
                    return 0;
                }


                int
                f_1465_32739_32773(string[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLength(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 32739, 32773);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1465_32889_32931()
                {
                    var return_v = Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 32889, 32931);
                    return return_v;
                }


                string
                f_1465_32849_33081(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 32849, 33081);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1465_33100_33129(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 33100, 33129);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1465_33148_33178(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 33148, 33178);
                    return return_v;
                }


                int
                f_1465_33296_33319(System.Collections.Generic.Dictionary<int, bool>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 33296, 33319);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1465_33448_33472()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 33448, 33472);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<int, bool>.KeyCollection
                f_1465_33521_33543(System.Collections.Generic.Dictionary<int, bool>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 33521, 33543);
                    return return_v;
                }


                bool
                f_1465_33671_33703(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 33671, 33703);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1465_33896_33938()
                {
                    var return_v = Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 33896, 33938);
                    return return_v;
                }


                string
                f_1465_33882_33995(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 33882, 33995);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1465_33853_33996(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 33853, 33996);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<int, bool>.KeyCollection
                f_1465_33521_33543_I(System.Collections.Generic.Dictionary<int, bool>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 33521, 33543);
                    return return_v;
                }


                string
                f_1465_34099_34131(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 34099, 34131);
                    return return_v;
                }


                int
                f_1465_34156_34179(System.Collections.Generic.Dictionary<int, bool>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 34156, 34179);
                    return return_v;
                }


                string
                f_1465_34260_34306()
                {
                    var return_v = InternalHostUserInterfaceStrings.DefaultChoice;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 34260, 34306);
                    return return_v;
                }


                string
                f_1465_34242_34351(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 34242, 34351);
                    return return_v;
                }


                string
                f_1465_34468_34533()
                {
                    var return_v = InternalHostUserInterfaceStrings.DefaultChoicesForMultipleChoices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 34468, 34533);
                    return return_v;
                }


                string
                f_1465_34450_34578(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 34450, 34578);
                    return return_v;
                }


                string
                f_1465_34659_34684(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 34659, 34684);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<int>
                f_1465_34793_34814()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 34793, 34814);
                    return return_v;
                }


                string
                f_1465_34939_34985()
                {
                    var return_v = InternalHostUserInterfaceStrings.ChoiceMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 34939, 34985);
                    return return_v;
                }


                string
                f_1465_34921_35003(string
                formatSpec, int
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 34921, 35003);
                    return return_v;
                }


                int
                f_1465_35074_35117(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 35074, 35117);
                    return 0;
                }


                string
                f_1465_35154_35176(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.ReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 35154, 35176);
                    return return_v;
                }


                int
                f_1465_35241_35256(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 35241, 35256);
                    return return_v;
                }


                int
                f_1465_35611_35623(System.Collections.ObjectModel.Collection<int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 35611, 35623);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<int, bool>.KeyCollection
                f_1465_35634_35656(System.Collections.Generic.Dictionary<int, bool>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 35634, 35656);
                    return return_v;
                }


                int
                f_1465_35634_35662(System.Collections.Generic.Dictionary<int, bool>.KeyCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 35634, 35662);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<int, bool>.KeyCollection
                f_1465_35813_35835(System.Collections.Generic.Dictionary<int, bool>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 35813, 35835);
                    return return_v;
                }


                int
                f_1465_35893_35918(System.Collections.ObjectModel.Collection<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 35893, 35918);
                    return 0;
                }


                System.Collections.Generic.Dictionary<int, bool>.KeyCollection
                f_1465_35813_35835_I(System.Collections.Generic.Dictionary<int, bool>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 35813, 35835);
                    return return_v;
                }


                string
                f_1465_36152_36167(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 36152, 36167);
                    return return_v;
                }


                int
                f_1465_36110_36200(string
                response, System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                choices, string[,]
                hotkeysAndPlainLabels)
                {
                    var return_v = HostUIHelperMethods.DetermineChoicePicked(response, choices, hotkeysAndPlainLabels);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 36110, 36200);
                    return return_v;
                }


                int
                f_1465_36284_36308(System.Collections.ObjectModel.Collection<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 36284, 36308);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1465, 30383, 36539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 30383, 36539);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSHostUserInterface _externalUI;

        private InternalHostRawUserInterface _internalRawUI;

        private InternalHost _parent;

        private PSInformationalBuffers _informationalBuffers;

        static InternalHostUserInterface()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1465, 453, 36790);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1465, 453, 36790);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1465, 453, 36790);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1465, 453, 36790);

        int
        f_1465_842_898(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 842, 898);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1465_975_1027(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 975, 1027);
            return return_v;
        }


        System.Management.Automation.Host.PSHostRawUserInterface
        f_1465_1212_1228(System.Management.Automation.Host.PSHostUserInterface
        this_param)
        {
            var return_v = this_param.RawUI;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1465, 1212, 1228);
            return return_v;
        }


        System.Management.Automation.Internal.Host.InternalHostRawUserInterface
        f_1465_1277_1325(System.Management.Automation.Host.PSHostRawUserInterface
        externalRawUI, System.Management.Automation.Internal.Host.InternalHost
        parentHost)
        {
            var return_v = new System.Management.Automation.Internal.Host.InternalHostRawUserInterface(externalRawUI, parentHost);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1465, 1277, 1325);
            return return_v;
        }

    }
}

