// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Internal.Host
{
    internal
        class InternalHostRawUserInterface : PSHostRawUserInterface
    {
        internal
                InternalHostRawUserInterface(PSHostRawUserInterface externalRawUI, InternalHost parentHost)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1464, 399, 656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 17960, 17974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 18006, 18017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 575, 606);

                _externalRawUI = externalRawUI;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 620, 645);

                _parentHost = parentHost;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1464, 399, 656);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 399, 656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 399, 656);
            }
        }

        internal
                void
                ThrowNotInteractive()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 668, 1255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 953, 1028);

                string
                message = f_1464_970_1027()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 1042, 1222);

                HostException
                e = f_1464_1060_1221(message, null, "HostFunctionNotImplemented", ErrorCategory.NotImplemented)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 1236, 1244);

                throw e;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 668, 1255);

                string
                f_1464_970_1027()
                {
                    var return_v = HostInterfaceExceptionsStrings.HostFunctionNotImplemented;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 970, 1027);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_1464_1060_1221(string
                message, System.Exception
                innerException, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory)
                {
                    var return_v = new System.Management.Automation.Host.HostException(message, innerException, errorId, errorCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 1060, 1221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 668, 1255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 668, 1255);
            }
        }

        public override
                ConsoleColor
                ForegroundColor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 1694, 1961);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 1730, 1839) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 1730, 1839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 1798, 1820);

                        f_1464_1798_1819(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 1730, 1839);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 1859, 1912);

                    ConsoleColor
                    result = f_1464_1881_1911(_externalRawUI)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 1932, 1946);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 1694, 1961);

                    int
                    f_1464_1798_1819(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 1798, 1819);
                        return 0;
                    }


                    System.ConsoleColor
                    f_1464_1881_1911(System.Management.Automation.Host.PSHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.ForegroundColor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 1881, 1911);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 1607, 2207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 1607, 2207);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 1977, 2196);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 2013, 2122) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 2013, 2122);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 2081, 2103);

                        f_1464_2081_2102(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 2013, 2122);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 2142, 2181);

                    _externalRawUI.ForegroundColor = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 1977, 2196);

                    int
                    f_1464_2081_2102(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 2081, 2102);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 1607, 2207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 1607, 2207);
                }
            }
        }

        public override
                ConsoleColor
                BackgroundColor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 2648, 2915);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 2684, 2793) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 2684, 2793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 2752, 2774);

                        f_1464_2752_2773(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 2684, 2793);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 2813, 2866);

                    ConsoleColor
                    result = f_1464_2835_2865(_externalRawUI)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 2886, 2900);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 2648, 2915);

                    int
                    f_1464_2752_2773(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 2752, 2773);
                        return 0;
                    }


                    System.ConsoleColor
                    f_1464_2835_2865(System.Management.Automation.Host.PSHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.BackgroundColor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 2835, 2865);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 2561, 3161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 2561, 3161);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 2931, 3150);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 2967, 3076) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 2967, 3076);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 3035, 3057);

                        f_1464_3035_3056(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 2967, 3076);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 3096, 3135);

                    _externalRawUI.BackgroundColor = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 2931, 3150);

                    int
                    f_1464_3035_3056(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 3035, 3056);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 2561, 3161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 2561, 3161);
                }
            }
        }

        public override
                Coordinates
                CursorPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 3600, 3865);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 3636, 3745) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 3636, 3745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 3704, 3726);

                        f_1464_3704_3725(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 3636, 3745);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 3765, 3816);

                    Coordinates
                    result = f_1464_3786_3815(_externalRawUI)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 3836, 3850);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 3600, 3865);

                    int
                    f_1464_3704_3725(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 3704, 3725);
                        return 0;
                    }


                    System.Management.Automation.Host.Coordinates
                    f_1464_3786_3815(System.Management.Automation.Host.PSHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.CursorPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 3786, 3815);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 3515, 4110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 3515, 4110);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 3881, 4099);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 3917, 4026) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 3917, 4026);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 3985, 4007);

                        f_1464_3985_4006(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 3917, 4026);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 4046, 4084);

                    _externalRawUI.CursorPosition = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 3881, 4099);

                    int
                    f_1464_3985_4006(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 3985, 4006);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 3515, 4110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 3515, 4110);
                }
            }
        }

        public override
                Coordinates
                WindowPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 4549, 4814);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 4585, 4694) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 4585, 4694);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 4653, 4675);

                        f_1464_4653_4674(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 4585, 4694);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 4714, 4765);

                    Coordinates
                    result = f_1464_4735_4764(_externalRawUI)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 4785, 4799);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 4549, 4814);

                    int
                    f_1464_4653_4674(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 4653, 4674);
                        return 0;
                    }


                    System.Management.Automation.Host.Coordinates
                    f_1464_4735_4764(System.Management.Automation.Host.PSHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.WindowPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 4735, 4764);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 4464, 5059);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 4464, 5059);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 4830, 5048);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 4866, 4975) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 4866, 4975);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 4934, 4956);

                        f_1464_4934_4955(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 4866, 4975);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 4995, 5033);

                    _externalRawUI.WindowPosition = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 4830, 5048);

                    int
                    f_1464_4934_4955(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 4934, 4955);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 4464, 5059);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 4464, 5059);
                }
            }
        }

        public override
                int
                CursorSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 5486, 5739);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 5522, 5631) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 5522, 5631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 5590, 5612);

                        f_1464_5590_5611(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 5522, 5631);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 5651, 5690);

                    int
                    result = f_1464_5664_5689(_externalRawUI)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 5710, 5724);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 5486, 5739);

                    int
                    f_1464_5590_5611(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 5590, 5611);
                        return 0;
                    }


                    int
                    f_1464_5664_5689(System.Management.Automation.Host.PSHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.CursorSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 5664, 5689);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 5413, 5980);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 5413, 5980);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 5755, 5969);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 5791, 5900) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 5791, 5900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 5859, 5881);

                        f_1464_5859_5880(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 5791, 5900);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 5920, 5954);

                    _externalRawUI.CursorSize = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 5755, 5969);

                    int
                    f_1464_5859_5880(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 5859, 5880);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 5413, 5980);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 5413, 5980);
                }
            }
        }

        public override
                Size
                BufferSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 6408, 6662);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 6444, 6553) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 6444, 6553);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 6512, 6534);

                        f_1464_6512_6533(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 6444, 6553);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 6573, 6613);

                    Size
                    result = f_1464_6587_6612(_externalRawUI)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 6633, 6647);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 6408, 6662);

                    int
                    f_1464_6512_6533(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 6512, 6533);
                        return 0;
                    }


                    System.Management.Automation.Host.Size
                    f_1464_6587_6612(System.Management.Automation.Host.PSHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.BufferSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 6587, 6612);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 6334, 6903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 6334, 6903);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 6678, 6892);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 6714, 6823) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 6714, 6823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 6782, 6804);

                        f_1464_6782_6803(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 6714, 6823);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 6843, 6877);

                    _externalRawUI.BufferSize = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 6678, 6892);

                    int
                    f_1464_6782_6803(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 6782, 6803);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 6334, 6903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 6334, 6903);
                }
            }
        }

        public override
                Size
                WindowSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 7331, 7585);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 7367, 7476) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 7367, 7476);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 7435, 7457);

                        f_1464_7435_7456(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 7367, 7476);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 7496, 7536);

                    Size
                    result = f_1464_7510_7535(_externalRawUI)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 7556, 7570);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 7331, 7585);

                    int
                    f_1464_7435_7456(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 7435, 7456);
                        return 0;
                    }


                    System.Management.Automation.Host.Size
                    f_1464_7510_7535(System.Management.Automation.Host.PSHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.WindowSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 7510, 7535);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 7257, 7826);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 7257, 7826);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 7601, 7815);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 7637, 7746) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 7637, 7746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 7705, 7727);

                        f_1464_7705_7726(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 7637, 7746);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 7766, 7800);

                    _externalRawUI.WindowSize = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 7601, 7815);

                    int
                    f_1464_7705_7726(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 7705, 7726);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 7257, 7826);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 7257, 7826);
                }
            }
        }

        public override
                Size
                MaxWindowSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 8257, 8514);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 8293, 8402) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 8293, 8402);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 8361, 8383);

                        f_1464_8361_8382(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 8293, 8402);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 8422, 8465);

                    Size
                    result = f_1464_8436_8464(_externalRawUI)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 8485, 8499);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 8257, 8514);

                    int
                    f_1464_8361_8382(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 8361, 8382);
                        return 0;
                    }


                    System.Management.Automation.Host.Size
                    f_1464_8436_8464(System.Management.Automation.Host.PSHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.MaxWindowSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 8436, 8464);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 8180, 8525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 8180, 8525);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override
                Size
                MaxPhysicalWindowSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 8964, 9229);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 9000, 9109) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 9000, 9109);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 9068, 9090);

                        f_1464_9068_9089(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 9000, 9109);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 9129, 9180);

                    Size
                    result = f_1464_9143_9179(_externalRawUI)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 9200, 9214);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 8964, 9229);

                    int
                    f_1464_9068_9089(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 9068, 9089);
                        return 0;
                    }


                    System.Management.Automation.Host.Size
                    f_1464_9143_9179(System.Management.Automation.Host.PSHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.MaxPhysicalWindowSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 9143, 9179);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 8879, 9240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 8879, 9240);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override
                KeyInfo
                ReadKey(ReadKeyOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 9656, 10514);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 9754, 9851) || true) && (_externalRawUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 9754, 9851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 9814, 9836);

                    f_1464_9814_9835(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 9754, 9851);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 9867, 9898);

                KeyInfo
                result = f_1464_9884_9897()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 9948, 9989);

                    result = f_1464_9957_9988(_externalRawUI, options);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1464, 10018, 10473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 10202, 10319);

                    LocalPipeline
                    lpl = (LocalPipeline)f_1464_10237_10318(((RunspaceBase)f_1464_10252_10287(f_1464_10252_10271(_parentHost))))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 10337, 10419) || true) && (lpl == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 10337, 10419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 10394, 10400);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 10337, 10419);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 10439, 10458);

                    f_1464_10439_10457(f_1464_10439_10450(lpl));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1464, 10018, 10473);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 10489, 10503);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 9656, 10514);

                int
                f_1464_9814_9835(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                this_param)
                {
                    this_param.ThrowNotInteractive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 9814, 9835);
                    return 0;
                }


                System.Management.Automation.Host.KeyInfo
                f_1464_9884_9897()
                {
                    var return_v = new System.Management.Automation.Host.KeyInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 9884, 9897);
                    return return_v;
                }


                System.Management.Automation.Host.KeyInfo
                f_1464_9957_9988(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, System.Management.Automation.Host.ReadKeyOptions
                options)
                {
                    var return_v = this_param.ReadKey(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 9957, 9988);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1464_10252_10271(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 10252, 10271);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1464_10252_10287(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 10252, 10287);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1464_10237_10318(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 10237, 10318);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStopper
                f_1464_10439_10450(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Stopper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 10439, 10450);
                    return return_v;
                }


                int
                f_1464_10439_10457(System.Management.Automation.Runspaces.PipelineStopper
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 10439, 10457);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 9656, 10514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 9656, 10514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                void
                FlushInputBuffer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 10839, 11079);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 10921, 11018) || true) && (_externalRawUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 10921, 11018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 10981, 11003);

                    f_1464_10981_11002(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 10921, 11018);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 11034, 11068);

                f_1464_11034_11067(
                            _externalRawUI);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 10839, 11079);

                int
                f_1464_10981_11002(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                this_param)
                {
                    this_param.ThrowNotInteractive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 10981, 11002);
                    return 0;
                }


                int
                f_1464_11034_11067(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    this_param.FlushInputBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 11034, 11067);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 10839, 11079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 10839, 11079);
            }
        }

        public override
                bool
                KeyAvailable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 11513, 11769);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 11549, 11658) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 11549, 11658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 11617, 11639);

                        f_1464_11617_11638(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 11549, 11658);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 11678, 11720);

                    bool
                    result = f_1464_11692_11719(_externalRawUI)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 11740, 11754);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 11513, 11769);

                    int
                    f_1464_11617_11638(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 11617, 11638);
                        return 0;
                    }


                    bool
                    f_1464_11692_11719(System.Management.Automation.Host.PSHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.KeyAvailable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 11692, 11719);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 11437, 11780);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 11437, 11780);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override
                string
                WindowTitle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 12211, 12468);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 12247, 12356) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 12247, 12356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 12315, 12337);

                        f_1464_12315_12336(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 12247, 12356);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 12376, 12419);

                    string
                    result = f_1464_12392_12418(_externalRawUI)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 12439, 12453);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 12211, 12468);

                    int
                    f_1464_12315_12336(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 12315, 12336);
                        return 0;
                    }


                    string
                    f_1464_12392_12418(System.Management.Automation.Host.PSHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.WindowTitle;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 12392, 12418);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 12134, 12710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 12134, 12710);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 12484, 12699);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 12520, 12629) || true) && (_externalRawUI == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 12520, 12629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 12588, 12610);

                        f_1464_12588_12609(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 12520, 12629);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 12649, 12684);

                    _externalRawUI.WindowTitle = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 12484, 12699);

                    int
                    f_1464_12588_12609(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                    this_param)
                    {
                        this_param.ThrowNotInteractive();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 12588, 12609);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 12134, 12710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 12134, 12710);
                }
            }
        }

        public override
                void
                SetBufferContents(Coordinates origin, BufferCell[,] contents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 13121, 13421);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 13246, 13343) || true) && (_externalRawUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 13246, 13343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 13306, 13328);

                    f_1464_13306_13327(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 13246, 13343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 13359, 13410);

                f_1464_13359_13409(
                            _externalRawUI, origin, contents);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 13121, 13421);

                int
                f_1464_13306_13327(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                this_param)
                {
                    this_param.ThrowNotInteractive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 13306, 13327);
                    return 0;
                }


                int
                f_1464_13359_13409(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.BufferCell[,]
                contents)
                {
                    this_param.SetBufferContents(origin, contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 13359, 13409);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 13121, 13421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 13121, 13421);
            }
        }

        public override
                void
                SetBufferContents(Rectangle r, BufferCell fill)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 13900, 14177);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 14011, 14108) || true) && (_externalRawUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 14011, 14108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 14071, 14093);

                    f_1464_14071_14092(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 14011, 14108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 14124, 14166);

                f_1464_14124_14165(
                            _externalRawUI, r, fill);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 13900, 14177);

                int
                f_1464_14071_14092(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                this_param)
                {
                    this_param.ThrowNotInteractive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 14071, 14092);
                    return 0;
                }


                int
                f_1464_14124_14165(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, System.Management.Automation.Host.Rectangle
                rectangle, System.Management.Automation.Host.BufferCell
                fill)
                {
                    this_param.SetBufferContents(rectangle, fill);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 14124, 14165);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 13900, 14177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 13900, 14177);
            }
        }

        public override
                BufferCell[,]
                GetBufferContents(Rectangle r)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 14573, 14843);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 14676, 14773) || true) && (_externalRawUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 14676, 14773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 14736, 14758);

                    f_1464_14736_14757(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 14676, 14773);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 14789, 14832);

                return f_1464_14796_14831(_externalRawUI, r);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 14573, 14843);

                int
                f_1464_14736_14757(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                this_param)
                {
                    this_param.ThrowNotInteractive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 14736, 14757);
                    return 0;
                }


                System.Management.Automation.Host.BufferCell[,]
                f_1464_14796_14831(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, System.Management.Automation.Host.Rectangle
                rectangle)
                {
                    var return_v = this_param.GetBufferContents(rectangle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 14796, 14831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 14573, 14843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 14573, 14843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                void
                ScrollBufferContents
                (
                    Rectangle source,
                    Coordinates destination,
                    Rectangle clip,
                    BufferCell fill
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 15397, 15823);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 15630, 15727) || true) && (_externalRawUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 15630, 15727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 15690, 15712);

                    f_1464_15690_15711(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 15630, 15727);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 15743, 15812);

                f_1464_15743_15811(
                            _externalRawUI, source, destination, clip, fill);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 15397, 15823);

                int
                f_1464_15690_15711(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                this_param)
                {
                    this_param.ThrowNotInteractive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 15690, 15711);
                    return 0;
                }


                int
                f_1464_15743_15811(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, System.Management.Automation.Host.Rectangle
                source, System.Management.Automation.Host.Coordinates
                destination, System.Management.Automation.Host.Rectangle
                clip, System.Management.Automation.Host.BufferCell
                fill)
                {
                    this_param.ScrollBufferContents(source, destination, clip, fill);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 15743, 15811);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 15397, 15823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 15397, 15823);
            }
        }

        public override int LengthInBufferCells(string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 16190, 16437);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 16266, 16363) || true) && (_externalRawUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 16266, 16363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 16326, 16348);

                    f_1464_16326_16347(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 16266, 16363);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 16379, 16426);

                return f_1464_16386_16425(_externalRawUI, str);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 16190, 16437);

                int
                f_1464_16326_16347(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                this_param)
                {
                    this_param.ThrowNotInteractive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 16326, 16347);
                    return 0;
                }


                int
                f_1464_16386_16425(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, string
                source)
                {
                    var return_v = this_param.LengthInBufferCells(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 16386, 16425);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 16190, 16437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 16190, 16437);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int LengthInBufferCells(string str, int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 16847, 17269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 16935, 16974);

                f_1464_16935_16973(offset >= 0, "offset >= 0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 16988, 17074);

                f_1464_16988_17073(f_1464_16999_17024(str) || (DynAbs.Tracing.TraceSender.Expression_False(1464, 16999, 17049) || (offset < f_1464_17038_17048(str))), "offset < str.Length");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 17090, 17187) || true) && (_externalRawUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 17090, 17187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 17150, 17172);

                    f_1464_17150_17171(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 17090, 17187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 17203, 17258);

                return f_1464_17210_17257(_externalRawUI, str, offset);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 16847, 17269);

                int
                f_1464_16935_16973(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 16935, 16973);
                    return 0;
                }


                bool
                f_1464_16999_17024(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 16999, 17024);
                    return return_v;
                }


                int
                f_1464_17038_17048(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1464, 17038, 17048);
                    return return_v;
                }


                int
                f_1464_16988_17073(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 16988, 17073);
                    return 0;
                }


                int
                f_1464_17150_17171(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                this_param)
                {
                    this_param.ThrowNotInteractive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 17150, 17171);
                    return 0;
                }


                int
                f_1464_17210_17257(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, string
                source, int
                offset)
                {
                    var return_v = this_param.LengthInBufferCells(source, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 17210, 17257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 16847, 17269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 16847, 17269);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                int
                LengthInBufferCells(char character)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1464, 17642, 17917);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 17740, 17837) || true) && (_externalRawUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1464, 17740, 17837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 17800, 17822);

                    f_1464_17800_17821(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1464, 17740, 17837);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1464, 17853, 17906);

                return f_1464_17860_17905(_externalRawUI, character);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1464, 17642, 17917);

                int
                f_1464_17800_17821(System.Management.Automation.Internal.Host.InternalHostRawUserInterface
                this_param)
                {
                    this_param.ThrowNotInteractive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 17800, 17821);
                    return 0;
                }


                int
                f_1464_17860_17905(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, char
                source)
                {
                    var return_v = this_param.LengthInBufferCells(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1464, 17860, 17905);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1464, 17642, 17917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 17642, 17917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSHostRawUserInterface _externalRawUI;

        private InternalHost _parentHost;

        static InternalHostRawUserInterface()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1464, 309, 18025);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1464, 309, 18025);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1464, 309, 18025);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1464, 309, 18025);
    }
}
