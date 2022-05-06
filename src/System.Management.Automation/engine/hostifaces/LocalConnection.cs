// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis; // for fxcop
using System.IO;
using System.Linq;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Runtime.Serialization;
using System.Threading;

using Microsoft.PowerShell.Commands;

using Dbg = System.Management.Automation.Diagnostics;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings

namespace System.Management.Automation.Runspaces
{
    internal sealed partial class LocalRunspace : RunspaceBase
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
        internal LocalRunspace(PSHost host, InitialSessionState initialSessionState, bool suppressClone)
        : base(f_1468_1759_1763_C(host), initialSessionState, suppressClone)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1468, 1552, 1822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 3932, 3955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 6330, 6376);
                this._createThreadOptions = PSThreadOptions.Default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 10368, 10462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 11151, 11176);
                this._transcriptionData = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 11211, 11225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 11503, 11514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 11828, 11847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 31342, 31364);
                this._pipelineThread = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 46077, 46086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 48784, 48791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 49061, 49069);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1468, 1552, 1822);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 1552, 1822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 1552, 1822);
            }
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
        internal LocalRunspace(PSHost host, InitialSessionState initialSessionState)
        : base(f_1468_2403_2407_C(host), initialSessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1468, 2216, 2451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 3932, 3955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 6330, 6376);
                this._createThreadOptions = PSThreadOptions.Default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 10368, 10462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 11151, 11176);
                this._transcriptionData = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 11211, 11225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 11503, 11514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 11828, 11847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 31342, 31364);
                this._pipelineThread = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 46077, 46086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 48784, 48791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 49061, 49069);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1468, 2216, 2451);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 2216, 2451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 2216, 2451);
            }
        }

        public override PSPrimitiveDictionary GetApplicationPrivateData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 2894, 3489);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 3105, 3431) || true) && (_applicationPrivateData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 3105, 3431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 3180, 3193);
                    lock (f_1468_3180_3193(this))
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 3235, 3397) || true) && (_applicationPrivateData == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 3235, 3397);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 3320, 3374);

                            _applicationPrivateData = f_1468_3346_3373();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 3235, 3397);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 3105, 3431);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 3447, 3478);

                return _applicationPrivateData;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 2894, 3489);

                object
                f_1468_3180_3193(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 3180, 3193);
                    return return_v;
                }


                System.Management.Automation.PSPrimitiveDictionary
                f_1468_3346_3373()
                {
                    var return_v = new System.Management.Automation.PSPrimitiveDictionary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 3346, 3373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 2894, 3489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 2894, 3489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void SetApplicationPrivateData(PSPrimitiveDictionary applicationPrivateData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 3711, 3890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 3830, 3879);

                _applicationPrivateData = applicationPrivateData;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 3711, 3890);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 3711, 3890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 3711, 3890);
            }
        }

        private PSPrimitiveDictionary _applicationPrivateData;

        public override PSEventManager Events
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 4114, 4400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 4150, 4231);

                    System.Management.Automation.ExecutionContext
                    context = f_1468_4206_4230(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 4251, 4343) || true) && (context == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 4251, 4343);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 4312, 4324);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 4251, 4343);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 4363, 4385);

                    return f_1468_4370_4384(context);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 4114, 4400);

                    System.Management.Automation.ExecutionContext
                    f_1468_4206_4230(System.Management.Automation.Runspaces.LocalRunspace
                    this_param)
                    {
                        var return_v = this_param.GetExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 4206, 4230);
                        return return_v;
                    }


                    System.Management.Automation.PSLocalEventManager
                    f_1468_4370_4384(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.Events;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 4370, 4384);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 4052, 4411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 4052, 4411);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override PSThreadOptions ThreadOptions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 5104, 5183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 5140, 5168);

                    return _createThreadOptions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 5104, 5183);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 5034, 5893);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 5034, 5893);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 5199, 5882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 5241, 5254);
                    lock (f_1468_5241_5254(this))
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 5296, 5409) || true) && (value == _createThreadOptions)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 5296, 5409);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 5379, 5386);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 5296, 5409);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 5433, 5795) || true) && (f_1468_5437_5465(f_1468_5437_5459(this)) != RunspaceState.BeforeOpen)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 5433, 5795);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 5543, 5772) || true) && (!f_1468_5548_5588(this, value))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 5543, 5772);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 5646, 5745);

                                throw f_1468_5652_5744(f_1468_5682_5743(f_1468_5700_5742()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 5543, 5772);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 5433, 5795);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 5819, 5848);

                        _createThreadOptions = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 5199, 5882);

                    object
                    f_1468_5241_5254(System.Management.Automation.Runspaces.LocalRunspace
                    this_param)
                    {
                        var return_v = this_param.SyncRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 5241, 5254);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspaceStateInfo
                    f_1468_5437_5459(System.Management.Automation.Runspaces.LocalRunspace
                    this_param)
                    {
                        var return_v = this_param.RunspaceStateInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 5437, 5459);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspaceState
                    f_1468_5437_5465(System.Management.Automation.Runspaces.RunspaceStateInfo
                    this_param)
                    {
                        var return_v = this_param.State;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 5437, 5465);
                        return return_v;
                    }


                    bool
                    f_1468_5548_5588(System.Management.Automation.Runspaces.LocalRunspace
                    this_param, System.Management.Automation.Runspaces.PSThreadOptions
                    options)
                    {
                        var return_v = this_param.IsValidThreadOptionsConfiguration(options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 5548, 5588);
                        return return_v;
                    }


                    string
                    f_1468_5700_5742()
                    {
                        var return_v = RunspaceStrings.InvalidThreadOptionsChange;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 5700, 5742);
                        return return_v;
                    }


                    string
                    f_1468_5682_5743(string
                    formatSpec, params object[]
                    o)
                    {
                        var return_v = StringUtil.Format(formatSpec, o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 5682, 5743);
                        return return_v;
                    }


                    System.InvalidOperationException
                    f_1468_5652_5744(string
                    message)
                    {
                        var return_v = new System.InvalidOperationException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 5652, 5744);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 5034, 5893);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 5034, 5893);
                }
            }
        }

        private bool IsValidThreadOptionsConfiguration(PSThreadOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 5905, 6294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 6192, 6283);

                return options == PSThreadOptions.ReuseThread && (DynAbs.Tracing.TraceSender.Expression_True(1468, 6199, 6282) && f_1468_6241_6260(this) != ApartmentState.STA);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 5905, 6294);

                System.Threading.ApartmentState
                f_1468_6241_6260(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 6241, 6260);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 5905, 6294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 5905, 6294);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSThreadOptions _createThreadOptions;

        public override void ResetRunspaceState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 6673, 8013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 6739, 6791);

                PSInvalidOperationException
                invalidOperation = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 6807, 7503) || true) && (f_1468_6811_6835(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 6807, 7503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 6877, 6941);

                    invalidOperation = f_1468_6896_6940();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 6807, 7503);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 6807, 7503);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 6975, 7503) || true) && (f_1468_6979_6997(this) != Runspaces.RunspaceState.Opened)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 6975, 7503);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 7065, 7215);

                        invalidOperation = f_1468_7084_7214(f_1468_7153_7193(), f_1468_7195_7213(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 6975, 7503);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 6975, 7503);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 7249, 7503) || true) && (f_1468_7253_7278(this) != Runspaces.RunspaceAvailability.Available)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 7249, 7503);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 7356, 7488);

                            invalidOperation = f_1468_7375_7487(f_1468_7444_7486());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 7249, 7503);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 6975, 7503);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 6807, 7503);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 7519, 7684) || true) && (invalidOperation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 7519, 7684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 7581, 7628);

                    invalidOperation.Source = "ResetRunspaceState";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 7646, 7669);

                    throw invalidOperation;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 7519, 7684);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 7700, 7767);

                f_1468_7700_7766(f_1468_7700_7724(this), f_1468_7744_7765(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 7956, 8002);

                _history = f_1468_7967_8001(f_1468_7979_8000(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 6673, 8013);

                System.Management.Automation.Runspaces.InitialSessionState
                f_1468_6811_6835(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.InitialSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 6811, 6835);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1468_6896_6940()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 6896, 6940);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1468_6979_6997(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 6979, 6997);
                    return return_v;
                }


                string
                f_1468_7153_7193()
                {
                    var return_v = RunspaceStrings.RunspaceNotInOpenedState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 7153, 7193);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1468_7195_7213(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 7195, 7213);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1468_7084_7214(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 7084, 7214);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1468_7253_7278(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 7253, 7278);
                    return return_v;
                }


                string
                f_1468_7444_7486()
                {
                    var return_v = RunspaceStrings.ConcurrentInvokeNotAllowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 7444, 7486);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1468_7375_7487(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 7375, 7487);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1468_7700_7724(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.InitialSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 7700, 7724);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1468_7744_7765(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 7744, 7765);
                    return return_v;
                }


                int
                f_1468_7700_7766(System.Management.Automation.Runspaces.InitialSessionState
                this_param, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.ResetRunspaceState(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 7700, 7766);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1468_7979_8000(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 7979, 8000);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.History
                f_1468_7967_8001(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new Microsoft.PowerShell.Commands.History(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 7967, 8001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 6673, 8013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 6673, 8013);
            }
        }

        protected override Pipeline CoreCreatePipeline(string command, bool addToHistory, bool isNested)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 8522, 8935);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 8713, 8834) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 8713, 8834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 8760, 8819);

                    throw f_1468_8766_8818("runspace");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 8713, 8834);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 8850, 8924);

                return (Pipeline)f_1468_8867_8923(this, command, addToHistory, isNested);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 8522, 8935);

                System.Management.Automation.PSObjectDisposedException
                f_1468_8766_8818(string
                objectName)
                {
                    var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 8766, 8818);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalPipeline
                f_1468_8867_8923(System.Management.Automation.Runspaces.LocalRunspace
                runspace, string
                command, bool
                addToHistory, bool
                isNested)
                {
                    var return_v = new System.Management.Automation.Runspaces.LocalPipeline(runspace, command, addToHistory, isNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 8867, 8923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 8522, 8935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 8522, 8935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override System.Management.Automation.ExecutionContext GetExecutionContext
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 9223, 9395);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 9259, 9380) || true) && (_engine == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 9259, 9380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 9301, 9313);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 9259, 9380);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 9259, 9380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 9357, 9380);

                        return f_1468_9364_9379(_engine);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 9259, 9380);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 9223, 9395);

                    System.Management.Automation.ExecutionContext
                    f_1468_9364_9379(System.Management.Automation.AutomationEngine
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 9364, 9379);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 9115, 9406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 9115, 9406);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool InNestedPrompt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 9597, 9937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 9633, 9714);

                    System.Management.Automation.ExecutionContext
                    context = f_1468_9689_9713(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 9734, 9827) || true) && (context == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 9734, 9827);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 9795, 9808);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 9734, 9827);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 9847, 9922);

                    return f_1468_9854_9895(f_1468_9854_9874(context)) || (DynAbs.Tracing.TraceSender.Expression_False(1468, 9854, 9921) || f_1468_9899_9921());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 9597, 9937);

                    System.Management.Automation.ExecutionContext
                    f_1468_9689_9713(System.Management.Automation.Runspaces.LocalRunspace
                    this_param)
                    {
                        var return_v = this_param.GetExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 9689, 9713);
                        return return_v;
                    }


                    System.Management.Automation.Internal.Host.InternalHost
                    f_1468_9854_9874(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.InternalHost;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 9854, 9874);
                        return return_v;
                    }


                    bool
                    f_1468_9854_9895(System.Management.Automation.Internal.Host.InternalHost
                    this_param)
                    {
                        var return_v = this_param.HostInNestedPrompt();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 9854, 9895);
                        return return_v;
                    }


                    bool
                    f_1468_9899_9921()
                    {
                        var return_v = InInternalNestedPrompt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 9899, 9921);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 9535, 9948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 9535, 9948);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool InInternalNestedPrompt
        {
            get;
            set;
        }

        internal History History
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 10734, 10801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 10770, 10786);

                    return _history;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 10734, 10801);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 10685, 10812);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 10685, 10812);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TranscriptionData TranscriptionData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 11025, 11102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 11061, 11087);

                    return _transcriptionData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 11025, 11102);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 10956, 11113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 10956, 11113);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private TranscriptionData _transcriptionData;

        private JobRepository _jobRepository;

        internal JobRepository JobRepository
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 11388, 11461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 11424, 11446);

                    return _jobRepository;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 11388, 11461);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 11327, 11472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 11327, 11472);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private JobManager _jobManager;

        public override JobManager JobManager
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 11708, 11778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 11744, 11763);

                    return _jobManager;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 11708, 11778);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 11646, 11789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 11646, 11789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private RunspaceRepository _runspaceRepository;

        internal RunspaceRepository RunspaceRepository
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 12034, 12112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 12070, 12097);

                    return _runspaceRepository;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 12034, 12112);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 11963, 12123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 11963, 12123);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Debugger Debugger
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 12333, 12425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 12369, 12410);

                    return f_1468_12376_12392() ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Debugger>(1468, 12376, 12409) ?? DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Debugger, 1468, 12396, 12409));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 12333, 12425);

                    System.Management.Automation.Debugger
                    f_1468_12376_12392()
                    {
                        var return_v = InternalDebugger;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 12376, 12392);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 12275, 12436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 12275, 12436);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static string s_debugPreferenceCachePath;

        private static object s_debugPreferenceLockObject;
        public class DebugPreference
        {
            public string[] AppDomainNames;

            public DebugPreference()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1468, 12895, 12990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 12964, 12978);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1468, 12895, 12990);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 12895, 12990);
            }


            static DebugPreference()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1468, 12895, 12990);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1468, 12895, 12990);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 12895, 12990);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1468, 12895, 12990);
        }

        private static DebugPreference CreateDebugPreference(string[] AppDomainNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1468, 13249, 13517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 13351, 13407);

                DebugPreference
                DebugPreference = f_1468_13385_13406()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 13421, 13469);

                DebugPreference.AppDomainNames = AppDomainNames;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 13483, 13506);

                return DebugPreference;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1468, 13249, 13517);

                System.Management.Automation.Runspaces.LocalRunspace.DebugPreference
                f_1468_13385_13406()
                {
                    var return_v = new System.Management.Automation.Runspaces.LocalRunspace.DebugPreference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 13385, 13406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 13249, 13517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 13249, 13517);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void SetDebugPreference(string processName, List<string> appDomainName, bool enable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1468, 13906, 21941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 14037, 14064);
                lock (s_debugPreferenceLockObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 14098, 14126);

                    bool
                    iscacheUpdated = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 14144, 14182);

                    Hashtable
                    debugPreferenceCache = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 14202, 14233);

                    string[]
                    appDomainNames = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 14251, 14378) || true) && (appDomainName != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 14251, 14378);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 14318, 14359);

                        appDomainNames = f_1468_14335_14358(appDomainName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 14251, 14378);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 14398, 21519) || true) && (!f_1468_14403_14456(LocalRunspace.s_debugPreferenceCachePath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 14398, 21519);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 14498, 14847) || true) && (enable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 14498, 14847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 14558, 14630);

                            DebugPreference
                            DebugPreference = f_1468_14592_14629(appDomainNames)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 14656, 14695);

                            debugPreferenceCache = f_1468_14679_14694();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 14721, 14776);

                            f_1468_14721_14775(debugPreferenceCache, processName, DebugPreference);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 14802, 14824);

                            iscacheUpdated = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 14498, 14847);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 14398, 21519);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 14398, 21519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 14929, 14982);

                        debugPreferenceCache = f_1468_14952_14981(null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 15004, 21500) || true) && (debugPreferenceCache != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 15004, 21500);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 15086, 20903) || true) && (enable)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 15086, 20903);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 15332, 17998) || true) && (!f_1468_15337_15382(debugPreferenceCache, processName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 15332, 17998);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 15448, 15520);

                                    DebugPreference
                                    DebugPreference = f_1468_15482_15519(appDomainNames)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 15554, 15609);

                                    f_1468_15554_15608(debugPreferenceCache, processName, DebugPreference);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 15643, 15665);

                                    iscacheUpdated = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 15332, 17998);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 15332, 17998);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 16006, 16116);

                                    DebugPreference
                                    processDebugPreference = f_1468_16047_16115(f_1468_16081_16114(debugPreferenceCache, processName))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 16499, 17967) || true) && (processDebugPreference != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 16499, 17967);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 16607, 16648);

                                        List<string>
                                        cachedAppDomainNames = null
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 16686, 17571) || true) && (processDebugPreference.AppDomainNames != null && (DynAbs.Tracing.TraceSender.Expression_True(1468, 16690, 16787) && f_1468_16739_16783(processDebugPreference.AppDomainNames) > 0))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 16686, 17571);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 16869, 16948);

                                            cachedAppDomainNames = f_1468_16892_16947(processDebugPreference.AppDomainNames);
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 16992, 17532);
                                                foreach (string currentAppDomainName in f_1468_17032_17045_I(appDomainName))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 16992, 17532);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 17135, 17489) || true) && (!f_1468_17140_17225(cachedAppDomainNames, currentAppDomainName, f_1468_17192_17224()))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 17135, 17489);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 17323, 17370);

                                                        f_1468_17323_17369(cachedAppDomainNames, currentAppDomainName);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 17420, 17442);

                                                        iscacheUpdated = true;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 17135, 17489);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 16992, 17532);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1468, 1, 541);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(1468, 1, 541);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 16686, 17571);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 17611, 17932) || true) && (iscacheUpdated)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 17611, 17932);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 17711, 17799);

                                            DebugPreference
                                            DebugPreference = f_1468_17745_17798(f_1468_17767_17797(cachedAppDomainNames))
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 17841, 17893);

                                            debugPreferenceCache[processName] = DebugPreference;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 17611, 17932);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 16499, 17967);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 15332, 17998);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 15086, 20903);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 15086, 20903);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 18180, 20876) || true) && (f_1468_18184_18229(debugPreferenceCache, processName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 18180, 20876);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 18295, 20845) || true) && (appDomainName == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 18295, 20845);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 18394, 18435);

                                        f_1468_18394_18434(debugPreferenceCache, processName);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 18473, 18495);

                                        iscacheUpdated = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 18295, 20845);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 18295, 20845);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 18641, 18751);

                                        DebugPreference
                                        processDebugPreference = f_1468_18682_18750(f_1468_18716_18749(debugPreferenceCache, processName))
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 19150, 20810) || true) && (processDebugPreference != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 19150, 20810);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 19266, 19307);

                                            List<string>
                                            cachedAppDomainNames = null
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 19349, 20390) || true) && (processDebugPreference.AppDomainNames != null && (DynAbs.Tracing.TraceSender.Expression_True(1468, 19353, 19450) && f_1468_19402_19446(processDebugPreference.AppDomainNames) > 0))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 19349, 20390);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 19540, 19619);

                                                cachedAppDomainNames = f_1468_19563_19618(processDebugPreference.AppDomainNames);
                                                try
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 19667, 20347);
                                                    foreach (string currentAppDomainName in f_1468_19707_19720_I(appDomainName))
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 19667, 20347);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 19818, 20300) || true) && (f_1468_19822_19907(cachedAppDomainNames, currentAppDomainName, f_1468_19874_19906()))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 19818, 20300);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 20123, 20173);

                                                            f_1468_20123_20172(                                                    // remove requested appdomains debug preference details.
                                                                                                                cachedAppDomainNames, currentAppDomainName);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 20227, 20249);

                                                            iscacheUpdated = true;
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 19818, 20300);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 19667, 20347);
                                                    }
                                                }
                                                catch (System.Exception)
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1468, 1, 681);
                                                    throw;
                                                }
                                                finally
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1468, 1, 681);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 19349, 20390);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 20434, 20771) || true) && (iscacheUpdated)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 20434, 20771);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 20542, 20630);

                                                DebugPreference
                                                DebugPreference = f_1468_20576_20629(f_1468_20598_20628(cachedAppDomainNames))
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 20676, 20728);

                                                debugPreferenceCache[processName] = DebugPreference;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 20434, 20771);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 19150, 20810);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 18295, 20845);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 18180, 20876);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 15086, 20903);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 15004, 21500);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 15004, 21500);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 21104, 21477) || true) && (enable)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 21104, 21477);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 21172, 21211);

                                debugPreferenceCache = f_1468_21195_21210();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 21241, 21313);

                                DebugPreference
                                DebugPreference = f_1468_21275_21312(appDomainNames)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 21343, 21398);

                                f_1468_21343_21397(debugPreferenceCache, processName, DebugPreference);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 21428, 21450);

                                iscacheUpdated = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 21104, 21477);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 15004, 21500);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 14398, 21519);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 21539, 21915) || true) && (iscacheUpdated)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 21539, 21915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 21599, 21896);
                        using (PowerShell
                        ps = f_1468_21622_21641()
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 21691, 21835);

                            f_1468_21691_21834(f_1468_21691_21784(f_1468_21691_21721(ps, "Export-Clixml"), "Path", LocalRunspace.s_debugPreferenceCachePath), "InputObject", debugPreferenceCache);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 21861, 21873);

                            f_1468_21861_21872(ps);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1468, 21599, 21896);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 21539, 21915);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1468, 13906, 21941);

                string[]
                f_1468_14335_14358(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 14335, 14358);
                    return return_v;
                }


                bool
                f_1468_14403_14456(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 14403, 14456);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace.DebugPreference
                f_1468_14592_14629(string[]
                AppDomainNames)
                {
                    var return_v = CreateDebugPreference(AppDomainNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 14592, 14629);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1468_14679_14694()
                {
                    var return_v = new System.Collections.Hashtable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 14679, 14694);
                    return return_v;
                }


                int
                f_1468_14721_14775(System.Collections.Hashtable
                this_param, string
                key, System.Management.Automation.Runspaces.LocalRunspace.DebugPreference
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 14721, 14775);
                    return 0;
                }


                System.Collections.Hashtable
                f_1468_14952_14981(System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    var return_v = GetDebugPreferenceCache(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 14952, 14981);
                    return return_v;
                }


                bool
                f_1468_15337_15382(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 15337, 15382);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace.DebugPreference
                f_1468_15482_15519(string[]
                AppDomainNames)
                {
                    var return_v = CreateDebugPreference(AppDomainNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 15482, 15519);
                    return return_v;
                }


                int
                f_1468_15554_15608(System.Collections.Hashtable
                this_param, string
                key, System.Management.Automation.Runspaces.LocalRunspace.DebugPreference
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 15554, 15608);
                    return 0;
                }


                object
                f_1468_16081_16114(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 16081, 16114);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace.DebugPreference
                f_1468_16047_16115(object
                debugPreference)
                {
                    var return_v = GetProcessSpecificDebugPreference(debugPreference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 16047, 16115);
                    return return_v;
                }


                int
                f_1468_16739_16783(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 16739, 16783);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1468_16892_16947(string[]
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 16892, 16947);
                    return return_v;
                }


                System.StringComparer
                f_1468_17192_17224()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 17192, 17224);
                    return return_v;
                }


                bool
                f_1468_17140_17225(System.Collections.Generic.List<string>
                source, string
                value, System.StringComparer
                comparer)
                {
                    var return_v = source.Contains<string>(value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 17140, 17225);
                    return return_v;
                }


                int
                f_1468_17323_17369(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 17323, 17369);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1468_17032_17045_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 17032, 17045);
                    return return_v;
                }


                string[]
                f_1468_17767_17797(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 17767, 17797);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace.DebugPreference
                f_1468_17745_17798(string[]
                AppDomainNames)
                {
                    var return_v = CreateDebugPreference(AppDomainNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 17745, 17798);
                    return return_v;
                }


                bool
                f_1468_18184_18229(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 18184, 18229);
                    return return_v;
                }


                int
                f_1468_18394_18434(System.Collections.Hashtable
                this_param, string
                key)
                {
                    this_param.Remove((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 18394, 18434);
                    return 0;
                }


                object
                f_1468_18716_18749(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 18716, 18749);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace.DebugPreference
                f_1468_18682_18750(object
                debugPreference)
                {
                    var return_v = GetProcessSpecificDebugPreference(debugPreference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 18682, 18750);
                    return return_v;
                }


                int
                f_1468_19402_19446(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 19402, 19446);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1468_19563_19618(string[]
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 19563, 19618);
                    return return_v;
                }


                System.StringComparer
                f_1468_19874_19906()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 19874, 19906);
                    return return_v;
                }


                bool
                f_1468_19822_19907(System.Collections.Generic.List<string>
                source, string
                value, System.StringComparer
                comparer)
                {
                    var return_v = source.Contains<string>(value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 19822, 19907);
                    return return_v;
                }


                bool
                f_1468_20123_20172(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 20123, 20172);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1468_19707_19720_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 19707, 19720);
                    return return_v;
                }


                string[]
                f_1468_20598_20628(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 20598, 20628);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace.DebugPreference
                f_1468_20576_20629(string[]
                AppDomainNames)
                {
                    var return_v = CreateDebugPreference(AppDomainNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 20576, 20629);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1468_21195_21210()
                {
                    var return_v = new System.Collections.Hashtable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 21195, 21210);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace.DebugPreference
                f_1468_21275_21312(string[]
                AppDomainNames)
                {
                    var return_v = CreateDebugPreference(AppDomainNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 21275, 21312);
                    return return_v;
                }


                int
                f_1468_21343_21397(System.Collections.Hashtable
                this_param, string
                key, System.Management.Automation.Runspaces.LocalRunspace.DebugPreference
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 21343, 21397);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1468_21622_21641()
                {
                    var return_v = PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 21622, 21641);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1468_21691_21721(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 21691, 21721);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1468_21691_21784(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 21691, 21784);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1468_21691_21834(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Collections.Hashtable
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 21691, 21834);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1468_21861_21872(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 21861, 21872);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 13906, 21941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 13906, 21941);
            }
        }

        private static Hashtable GetDebugPreferenceCache(Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1468, 22358, 23115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 22450, 22488);

                Hashtable
                debugPreferenceCache = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 22502, 23060);
                using (PowerShell
                ps = f_1468_22525_22544()
                )
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 22578, 22682) || true) && (runspace != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 22578, 22682);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 22640, 22663);

                        ps.Runspace = runspace;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 22578, 22682);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 22702, 22796);

                    f_1468_22702_22795(f_1468_22702_22732(
                                    ps, "Import-Clixml"), "Path", LocalRunspace.s_debugPreferenceCachePath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 22814, 22859);

                    Collection<PSObject>
                    psObjects = f_1468_22847_22858(ps)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 22879, 23045) || true) && (psObjects != null && (DynAbs.Tracing.TraceSender.Expression_True(1468, 22883, 22924) && f_1468_22904_22919(psObjects) == 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 22879, 23045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 22966, 23026);

                        debugPreferenceCache = f_1468_22989_23012(f_1468_22989_23001(psObjects, 0)) as Hashtable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 22879, 23045);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1468, 22502, 23060);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 23076, 23104);

                return debugPreferenceCache;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1468, 22358, 23115);

                System.Management.Automation.PowerShell
                f_1468_22525_22544()
                {
                    var return_v = PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 22525, 22544);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1468_22702_22732(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 22702, 22732);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1468_22702_22795(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 22702, 22795);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1468_22847_22858(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 22847, 22858);
                    return return_v;
                }


                int
                f_1468_22904_22919(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 22904, 22919);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1468_22989_23001(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 22989, 23001);
                    return return_v;
                }


                object
                f_1468_22989_23012(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 22989, 23012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 22358, 23115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 22358, 23115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static DebugPreference GetProcessSpecificDebugPreference(object debugPreference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1468, 23384, 23963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 23497, 23543);

                DebugPreference
                processDebugPreference = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 23557, 23906) || true) && (debugPreference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 23557, 23906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 23618, 23681);

                    PSObject
                    debugPreferencePsObject = debugPreference as PSObject
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 23699, 23891) || true) && (debugPreferencePsObject != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 23699, 23891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 23776, 23872);

                        processDebugPreference = f_1468_23801_23871(debugPreferencePsObject);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 23699, 23891);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 23557, 23906);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 23922, 23952);

                return processDebugPreference;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1468, 23384, 23963);

                System.Management.Automation.Runspaces.LocalRunspace.DebugPreference
                f_1468_23801_23871(System.Management.Automation.PSObject
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<DebugPreference>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 23801, 23871);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 23384, 23963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 23384, 23963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void OpenHelper(bool syncCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 24220, 24657);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 24294, 24646) || true) && (syncCall)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 24294, 24646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 24388, 24403);

                    f_1468_24388_24402(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 24294, 24646);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 24294, 24646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 24521, 24591);

                    Thread
                    asyncThread = f_1468_24542_24590(new ThreadStart(this.OpenThreadProc))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 24611, 24631);

                    f_1468_24611_24630(
                                    asyncThread);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 24294, 24646);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 24220, 24657);

                int
                f_1468_24388_24402(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.DoOpenHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 24388, 24402);
                    return 0;
                }


                System.Threading.Thread
                f_1468_24542_24590(System.Threading.ThreadStart
                start)
                {
                    var return_v = new System.Threading.Thread(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 24542, 24590);
                    return return_v;
                }


                int
                f_1468_24611_24630(System.Threading.Thread
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 24611, 24630);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 24220, 24657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 24220, 24657);
            }
        }

        private void OpenThreadProc()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 24765, 25125);
#pragma warning disable 56500
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 24886, 24901);

                    f_1468_24886_24900(this);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1468, 24930, 25083);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1468, 24930, 25083);
                    // This exception is reported by raising RunspaceState
                    // change event.
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 24765, 25125);

                int
                f_1468_24886_24900(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.DoOpenHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 24886, 24900);
                    return 0;
                }

#pragma warning restore 56500
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 24765, 25125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 24765, 25125);
            }
        }

        private void DoOpenHelper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 25242, 29314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 25294, 25376);

                f_1468_25294_25375(f_1468_25305_25324() != null, "InitialSessionState should not be null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 25460, 25581) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 25460, 25581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 25507, 25566);

                    throw f_1468_25513_25565("runspace");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 25460, 25581);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 25597, 25637);

                bool
                startLifeCycleEventWritten = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 25651, 25705);

                f_1468_25651_25704(s_runspaceInitTracer, "begin open runspace");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 25755, 25800);

                    _transcriptionData = f_1468_25776_25799();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 26085, 26143);

                    _engine = f_1468_26095_26142(f_1468_26116_26120(), f_1468_26122_26141());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 26161, 26200);

                    f_1468_26161_26176(_engine).CurrentRunspace = this;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 26276, 26347);

                    f_1468_26276_26346(f_1468_26307_26322(_engine), EngineState.Available);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 26365, 26399);

                    startLifeCycleEventWritten = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 26419, 26459);

                    _history = f_1468_26430_26458(f_1468_26442_26457(_engine));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 26477, 26514);

                    _jobRepository = f_1468_26494_26513();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 26532, 26563);

                    _jobManager = f_1468_26546_26562();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 26581, 26628);

                    _runspaceRepository = f_1468_26603_26627();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 26648, 26737);

                    f_1468_26648_26736(
                                    s_runspaceInitTracer, "initializing built-in aliases and variable information");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 26755, 26776);

                    f_1468_26755_26775(this);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1468, 26805, 27840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 26865, 26920);

                    f_1468_26865_26919(s_runspaceInitTracer, "Runspace open failed");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 26984, 27016);

                    f_1468_26984_27015(this, exception);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 27090, 27383) || true) && (startLifeCycleEventWritten)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 27090, 27383);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 27162, 27273);

                        f_1468_27162_27272(f_1468_27173_27188(_engine) != null, "if startLifeCycleEventWritten is true, ExecutionContext must be present");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 27295, 27364);

                        f_1468_27295_27363(f_1468_27326_27341(_engine), EngineState.Stopped);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 27090, 27383);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 27469, 27519);

                    f_1468_27469_27518(this, RunspaceState.Broken, exception);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 27575, 27602);

                    f_1468_27575_27601(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 27819, 27825);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1468, 26805, 27840);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 27856, 27895);

                f_1468_27856_27894(this, RunspaceState.Opened);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 27909, 27931);

                f_1468_27909_27930(RunspaceOpening);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 27979, 28006);

                f_1468_27979_28005(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 28020, 28083);

                f_1468_28020_28082(s_runspaceInitTracer, "runspace opened successfully");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 28183, 28266);

                Exception
                initError = f_1468_28205_28265(f_1468_28205_28224(), this, s_runspaceInitTracer)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 28280, 29179) || true) && (initError != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 28280, 29179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 28379, 28411);

                    f_1468_28379_28410(this, initError);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 28485, 28627);

                    f_1468_28485_28626(f_1468_28498_28513(_engine) != null, "if startLifeCycleEventWritten is true, ExecutionContext must be present");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 28645, 28714);

                    f_1468_28645_28713(f_1468_28676_28691(_engine), EngineState.Stopped);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 28800, 28850);

                    f_1468_28800_28849(this, RunspaceState.Broken, initError);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 28906, 28933);

                    f_1468_28906_28932(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 29148, 29164);

                    throw initError;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 28280, 29179);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 25242, 29314);

                System.Management.Automation.Runspaces.InitialSessionState
                f_1468_25305_25324()
                {
                    var return_v = InitialSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 25305, 25324);
                    return return_v;
                }


                int
                f_1468_25294_25375(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 25294, 25375);
                    return 0;
                }


                System.Management.Automation.PSObjectDisposedException
                f_1468_25513_25565(string
                objectName)
                {
                    var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 25513, 25565);
                    return return_v;
                }


                int
                f_1468_25651_25704(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 25651, 25704);
                    return 0;
                }


                System.Management.Automation.Host.TranscriptionData
                f_1468_25776_25799()
                {
                    var return_v = new System.Management.Automation.Host.TranscriptionData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 25776, 25799);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1468_26116_26120()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 26116, 26120);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1468_26122_26141()
                {
                    var return_v = InitialSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 26122, 26141);
                    return return_v;
                }


                System.Management.Automation.AutomationEngine
                f_1468_26095_26142(System.Management.Automation.Host.PSHost
                hostInterface, System.Management.Automation.Runspaces.InitialSessionState
                iss)
                {
                    var return_v = new System.Management.Automation.AutomationEngine(hostInterface, iss);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 26095, 26142);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1468_26161_26176(System.Management.Automation.AutomationEngine
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 26161, 26176);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1468_26307_26322(System.Management.Automation.AutomationEngine
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 26307, 26322);
                    return return_v;
                }


                int
                f_1468_26276_26346(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.EngineState
                engineState)
                {
                    MshLog.LogEngineLifecycleEvent(executionContext, engineState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 26276, 26346);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1468_26442_26457(System.Management.Automation.AutomationEngine
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 26442, 26457);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.History
                f_1468_26430_26458(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new Microsoft.PowerShell.Commands.History(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 26430, 26458);
                    return return_v;
                }


                System.Management.Automation.JobRepository
                f_1468_26494_26513()
                {
                    var return_v = new System.Management.Automation.JobRepository();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 26494, 26513);
                    return return_v;
                }


                System.Management.Automation.JobManager
                f_1468_26546_26562()
                {
                    var return_v = new System.Management.Automation.JobManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 26546, 26562);
                    return return_v;
                }


                System.Management.Automation.RunspaceRepository
                f_1468_26603_26627()
                {
                    var return_v = new System.Management.Automation.RunspaceRepository();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 26603, 26627);
                    return return_v;
                }


                int
                f_1468_26648_26736(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 26648, 26736);
                    return 0;
                }


                int
                f_1468_26755_26775(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.InitializeDefaults();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 26755, 26775);
                    return 0;
                }


                int
                f_1468_26865_26919(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 26865, 26919);
                    return 0;
                }


                int
                f_1468_26984_27015(System.Management.Automation.Runspaces.LocalRunspace
                this_param, System.Exception
                exception)
                {
                    this_param.LogEngineHealthEvent(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 26984, 27015);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1468_27173_27188(System.Management.Automation.AutomationEngine
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 27173, 27188);
                    return return_v;
                }


                int
                f_1468_27162_27272(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 27162, 27272);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1468_27326_27341(System.Management.Automation.AutomationEngine
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 27326, 27341);
                    return return_v;
                }


                int
                f_1468_27295_27363(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.EngineState
                engineState)
                {
                    MshLog.LogEngineLifecycleEvent(executionContext, engineState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 27295, 27363);
                    return 0;
                }


                int
                f_1468_27469_27518(System.Management.Automation.Runspaces.LocalRunspace
                this_param, System.Management.Automation.Runspaces.RunspaceState
                state, System.Exception
                reason)
                {
                    this_param.SetRunspaceState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 27469, 27518);
                    return 0;
                }


                int
                f_1468_27575_27601(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.RaiseRunspaceStateEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 27575, 27601);
                    return 0;
                }


                int
                f_1468_27856_27894(System.Management.Automation.Runspaces.LocalRunspace
                this_param, System.Management.Automation.Runspaces.RunspaceState
                state)
                {
                    this_param.SetRunspaceState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 27856, 27894);
                    return 0;
                }


                int
                f_1468_27909_27930(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 27909, 27930);
                    return 0;
                }


                int
                f_1468_27979_28005(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.RaiseRunspaceStateEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 27979, 28005);
                    return 0;
                }


                int
                f_1468_28020_28082(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 28020, 28082);
                    return 0;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1468_28205_28224()
                {
                    var return_v = InitialSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 28205, 28224);
                    return return_v;
                }


                System.Exception
                f_1468_28205_28265(System.Management.Automation.Runspaces.InitialSessionState
                this_param, System.Management.Automation.Runspaces.LocalRunspace
                initializedRunspace, System.Management.Automation.PSTraceSource
                runspaceInitTracer)
                {
                    var return_v = this_param.BindRunspace((System.Management.Automation.Runspaces.Runspace)initializedRunspace, runspaceInitTracer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 28205, 28265);
                    return return_v;
                }


                int
                f_1468_28379_28410(System.Management.Automation.Runspaces.LocalRunspace
                this_param, System.Exception
                exception)
                {
                    this_param.LogEngineHealthEvent(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 28379, 28410);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1468_28498_28513(System.Management.Automation.AutomationEngine
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 28498, 28513);
                    return return_v;
                }


                int
                f_1468_28485_28626(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 28485, 28626);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1468_28676_28691(System.Management.Automation.AutomationEngine
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 28676, 28691);
                    return return_v;
                }


                int
                f_1468_28645_28713(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.EngineState
                engineState)
                {
                    MshLog.LogEngineLifecycleEvent(executionContext, engineState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 28645, 28713);
                    return 0;
                }


                int
                f_1468_28800_28849(System.Management.Automation.Runspaces.LocalRunspace
                this_param, System.Management.Automation.Runspaces.RunspaceState
                state, System.Exception
                reason)
                {
                    this_param.SetRunspaceState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 28800, 28849);
                    return 0;
                }


                int
                f_1468_28906_28932(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.RaiseRunspaceStateEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 28906, 28932);
                    return 0;
                }


            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 25242, 29314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 25242, 29314);
            }
        }

        internal void LogEngineHealthEvent(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 29412, 29665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 29492, 29654);

                f_1468_29492_29653(this, exception, Severity.Error, MshLog.EVENT_ID_CONFIGURATION_FAILURE, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 29412, 29665);

                int
                f_1468_29492_29653(System.Management.Automation.Runspaces.LocalRunspace
                this_param, System.Exception
                exception, System.Management.Automation.Severity
                severity, int
                id, System.Collections.Generic.Dictionary<string, string>
                additionalInfo)
                {
                    this_param.LogEngineHealthEvent(exception, severity, id, additionalInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 29492, 29653);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 29412, 29665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 29412, 29665);
            }
        }

        internal void LogEngineHealthEvent(Exception exception,
                                     Severity severity,
                                     int id,
                                     Dictionary<string, string> additionalInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 29763, 30707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 30003, 30073);

                f_1468_30003_30072(exception != null, "Caller should validate the parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 30089, 30130);

                LogContext
                logContext = f_1468_30113_30129()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 30144, 30190);

                logContext.EngineVersion = f_1468_30171_30189(f_1468_30171_30178());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 30204, 30251);

                logContext.HostId = f_1468_30224_30228().InstanceId.ToString();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 30265, 30297);

                logContext.HostName = f_1468_30287_30296(f_1468_30287_30291());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 30311, 30360);

                logContext.HostVersion = f_1468_30336_30359(f_1468_30336_30348(f_1468_30336_30340()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 30374, 30420);

                logContext.RunspaceId = f_1468_30398_30408().ToString();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 30434, 30476);

                logContext.Severity = f_1468_30456_30475(severity);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 30490, 30542);

                logContext.ShellId = Utils.DefaultPowerShellShellID;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 30556, 30696);

                f_1468_30556_30695(logContext, id, exception, additionalInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 29763, 30707);

                int
                f_1468_30003_30072(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 30003, 30072);
                    return 0;
                }


                System.Management.Automation.LogContext
                f_1468_30113_30129()
                {
                    var return_v = new System.Management.Automation.LogContext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 30113, 30129);
                    return return_v;
                }


                System.Version
                f_1468_30171_30178()
                {
                    var return_v = Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 30171, 30178);
                    return return_v;
                }


                string
                f_1468_30171_30189(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 30171, 30189);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1468_30224_30228()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 30224, 30228);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1468_30287_30291()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 30287, 30291);
                    return return_v;
                }


                string
                f_1468_30287_30296(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 30287, 30296);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1468_30336_30340()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 30336, 30340);
                    return return_v;
                }


                System.Version
                f_1468_30336_30348(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 30336, 30348);
                    return return_v;
                }


                string
                f_1468_30336_30359(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 30336, 30359);
                    return return_v;
                }


                System.Guid
                f_1468_30398_30408()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 30398, 30408);
                    return return_v;
                }


                string
                f_1468_30456_30475(System.Management.Automation.Severity
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 30456, 30475);
                    return return_v;
                }


                int
                f_1468_30556_30695(System.Management.Automation.LogContext
                logContext, int
                eventId, System.Exception
                exception, System.Collections.Generic.Dictionary<string, string>
                additionalInfo)
                {
                    MshLog.LogEngineHealthEvent(logContext, eventId, exception, additionalInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 30556, 30695);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 29763, 30707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 29763, 30707);
            }
        }

        internal PipelineThread GetPipelineThread()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 31055, 31307);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 31123, 31257) || true) && (_pipelineThread == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 31123, 31257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 31184, 31242);

                    _pipelineThread = f_1468_31202_31241(f_1468_31221_31240(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 31123, 31257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 31273, 31296);

                return _pipelineThread;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 31055, 31307);

                System.Threading.ApartmentState
                f_1468_31221_31240(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 31221, 31240);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineThread
                f_1468_31202_31241(System.Threading.ApartmentState
                apartmentState)
                {
                    var return_v = new System.Management.Automation.Runspaces.PipelineThread(apartmentState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 31202, 31241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 31055, 31307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 31055, 31307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PipelineThread _pipelineThread;

        protected override void CloseHelper(bool syncCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 31377, 31804);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 31452, 31793) || true) && (syncCall)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 31452, 31793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 31541, 31557);

                    f_1468_31541_31556(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 31452, 31793);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 31452, 31793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 31667, 31738);

                    Thread
                    asyncThread = f_1468_31688_31737(new ThreadStart(this.CloseThreadProc))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 31758, 31778);

                    f_1468_31758_31777(
                                    asyncThread);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 31452, 31793);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 31377, 31804);

                int
                f_1468_31541_31556(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.DoCloseHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 31541, 31556);
                    return 0;
                }


                System.Threading.Thread
                f_1468_31688_31737(System.Threading.ThreadStart
                start)
                {
                    var return_v = new System.Threading.Thread(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 31688, 31737);
                    return return_v;
                }


                int
                f_1468_31758_31777(System.Threading.Thread
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 31758, 31777);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 31377, 31804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 31377, 31804);
            }
        }

        private void CloseThreadProc()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 31913, 32169);
#pragma warning disable 56500
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 32035, 32051);

                    f_1468_32035_32050(this);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1468, 32080, 32127);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1468, 32080, 32127);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 31913, 32169);

                int
                f_1468_32035_32050(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.DoCloseHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 32035, 32050);
                    return 0;
                }

#pragma warning restore 56500
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 31913, 32169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 31913, 32169);
            }
        }

        private void DoCloseHelper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 32404, 37122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 32457, 32516);

                var
                isPrimaryRunspace = (f_1468_32482_32506() == this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 32530, 32560);

                var
                haveOpenRunspaces = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 32574, 32839);
                    foreach (Runspace runspace in f_1468_32604_32616_I(f_1468_32604_32616()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 32574, 32839);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 32650, 32824) || true) && (f_1468_32654_32686(f_1468_32654_32680(runspace)) == RunspaceState.Opened)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 32650, 32824);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 32752, 32777);

                            haveOpenRunspaces = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1468, 32799, 32805);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 32650, 32824);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 32574, 32839);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1468, 1, 266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1468, 1, 266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 32951, 33018);

                var
                closeAllOpenRunspaces = isPrimaryRunspace && (DynAbs.Tracing.TraceSender.Expression_True(1468, 32979, 33017) && haveOpenRunspaces)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 33172, 33667) || true) && (!haveOpenRunspaces)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 33172, 33667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 33228, 33289);

                    ExecutionContext
                    executionContext = f_1468_33264_33288(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 33307, 33607) || true) && (executionContext != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 33307, 33607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 33377, 33446);

                        PSHostUserInterface
                        hostUI = f_1468_33406_33445(f_1468_33406_33442(executionContext))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 33468, 33588) || true) && (hostUI != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 33468, 33588);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 33536, 33565);

                            f_1468_33536_33564(hostUI);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 33468, 33588);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 33307, 33607);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 33627, 33652);

                    f_1468_33627_33651();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 33172, 33667);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 33727, 33851) || true) && (f_1468_33731_33737() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 33727, 33851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 33764, 33851);

                    f_1468_33764_33850(f_1468_33764_33770(), PSEngineEvent.Exiting, null, new object[] { }, null, true, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 33727, 33851);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 34697, 34713);

                f_1468_34697_34712(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 34803, 34829);

                f_1468_34803_34828(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 34960, 35376);

                f_1468_34960_35375(this, () =>
                                {
                                    List<RemoteRunspace> runspaces = new List<RemoteRunspace>();
                                    foreach (PSSession psSession in this.RunspaceRepository.Runspaces)
                                    {
                                        runspaces.Add(psSession.Runspace as RemoteRunspace);
                                    }

                                    return runspaces;
                                });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 35464, 35510);

                f_1468_35464_35509(f_1468_35464_35479(_engine));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 35570, 35639);

                f_1468_35570_35638(f_1468_35601_35616(_engine), EngineState.Stopped);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 35725, 35740);

                _engine = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 35756, 35795);

                f_1468_35756_35794(this, RunspaceState.Closed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 35839, 35866);

                f_1468_35839_35865(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 35882, 36211) || true) && (closeAllOpenRunspaces)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 35882, 36211);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 35941, 36196);
                        foreach (Runspace runspace in f_1468_35971_35983_I(f_1468_35971_35983()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 35941, 36196);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 36025, 36177) || true) && (f_1468_36029_36061(f_1468_36029_36055(runspace)) == RunspaceState.Opened)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 36025, 36177);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 36135, 36154);

                                f_1468_36135_36153(runspace);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 36025, 36177);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 35941, 36196);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1468, 1, 256);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1468, 1, 256);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 35882, 36211);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 32404, 37122);

                System.Management.Automation.Runspaces.Runspace
                f_1468_32482_32506()
                {
                    var return_v = Runspace.PrimaryRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 32482, 32506);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<System.Management.Automation.Runspaces.Runspace>
                f_1468_32604_32616()
                {
                    var return_v = RunspaceList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 32604, 32616);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1468_32654_32680(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 32654, 32680);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1468_32654_32686(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 32654, 32686);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<System.Management.Automation.Runspaces.Runspace>
                f_1468_32604_32616_I(System.Collections.Generic.IReadOnlyList<System.Management.Automation.Runspaces.Runspace>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 32604, 32616);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1468_33264_33288(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.GetExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 33264, 33288);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1468_33406_33442(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 33406, 33442);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1468_33406_33445(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 33406, 33445);
                    return return_v;
                }


                int
                f_1468_33536_33564(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    this_param.StopAllTranscribing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 33536, 33564);
                    return 0;
                }


                int
                f_1468_33627_33651()
                {
                    AmsiUtils.Uninitialize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 33627, 33651);
                    return 0;
                }


                System.Management.Automation.PSEventManager
                f_1468_33731_33737()
                {
                    var return_v = Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 33731, 33737);
                    return return_v;
                }


                System.Management.Automation.PSEventManager
                f_1468_33764_33770()
                {
                    var return_v = Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 33764, 33770);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1468_33764_33850(System.Management.Automation.PSEventManager
                this_param, string
                sourceIdentifier, object
                sender, object[]
                args, System.Management.Automation.PSObject
                extraData, bool
                processInCurrentThread, bool
                waitForCompletionInCurrentThread)
                {
                    var return_v = this_param.GenerateEvent(sourceIdentifier, sender, args, extraData, processInCurrentThread, waitForCompletionInCurrentThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 33764, 33850);
                    return return_v;
                }


                int
                f_1468_34697_34712(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.StopPipelines();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 34697, 34712);
                    return 0;
                }


                int
                f_1468_34803_34828(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.StopOrDisconnectAllJobs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 34803, 34828);
                    return 0;
                }


                int
                f_1468_34960_35375(System.Management.Automation.Runspaces.LocalRunspace
                this_param, System.Func<System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>>
                getRunspaces)
                {
                    this_param.CloseOrDisconnectAllRemoteRunspaces(getRunspaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 34960, 35375);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1468_35464_35479(System.Management.Automation.AutomationEngine
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 35464, 35479);
                    return return_v;
                }


                int
                f_1468_35464_35509(System.Management.Automation.ExecutionContext
                this_param)
                {
                    this_param.RunspaceClosingNotification();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 35464, 35509);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1468_35601_35616(System.Management.Automation.AutomationEngine
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 35601, 35616);
                    return return_v;
                }


                int
                f_1468_35570_35638(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.EngineState
                engineState)
                {
                    MshLog.LogEngineLifecycleEvent(executionContext, engineState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 35570, 35638);
                    return 0;
                }


                int
                f_1468_35756_35794(System.Management.Automation.Runspaces.LocalRunspace
                this_param, System.Management.Automation.Runspaces.RunspaceState
                state)
                {
                    this_param.SetRunspaceState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 35756, 35794);
                    return 0;
                }


                int
                f_1468_35839_35865(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.RaiseRunspaceStateEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 35839, 35865);
                    return 0;
                }


                System.Collections.Generic.IReadOnlyList<System.Management.Automation.Runspaces.Runspace>
                f_1468_35971_35983()
                {
                    var return_v = RunspaceList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 35971, 35983);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1468_36029_36055(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 36029, 36055);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1468_36029_36061(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 36029, 36061);
                    return return_v;
                }


                int
                f_1468_36135_36153(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 36135, 36153);
                    return 0;
                }


                System.Collections.Generic.IReadOnlyList<System.Management.Automation.Runspaces.Runspace>
                f_1468_35971_35983_I(System.Collections.Generic.IReadOnlyList<System.Management.Automation.Runspaces.Runspace>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 35971, 35983);
                    return return_v;
                }


                // Report telemetry if we have no more open runspaces.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 32404, 37122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 32404, 37122);
            }
        }

        private void CloseOrDisconnectAllRemoteRunspaces(Func<List<RemoteRunspace>> getRunspaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 37397, 38481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 37511, 37559);

                List<RemoteRunspace>
                runspaces = f_1468_37544_37558(getRunspaces)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 37573, 37610) || true) && (f_1468_37577_37592(runspaces) == 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 37573, 37610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 37601, 37608);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 37573, 37610);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 37693, 38470);
                using (ManualResetEvent
                remoteRunspaceCloseCompleted = f_1468_37748_37775(false)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 37809, 37865);

                    ThrottleManager
                    throttleManager = f_1468_37843_37864()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 37883, 38052);

                    throttleManager.ThrottleComplete += delegate (object sender, EventArgs e)
                                    {
                                        remoteRunspaceCloseCompleted.Set();
                                    };
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 38072, 38338);
                        foreach (RemoteRunspace remoteRunspace in f_1468_38114_38123_I(runspaces))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 38072, 38338);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 38165, 38257);

                            IThrottleOperation
                            operation = f_1468_38196_38256(remoteRunspace)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 38279, 38319);

                            f_1468_38279_38318(throttleManager, operation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 38072, 38338);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1468, 1, 267);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1468, 1, 267);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 38358, 38396);

                    f_1468_38358_38395(
                                    throttleManager);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 38416, 38455);

                    f_1468_38416_38454(
                                    remoteRunspaceCloseCompleted);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1468, 37693, 38470);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 37397, 38481);

                System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
                f_1468_37544_37558(System.Func<System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 37544, 37558);
                    return return_v;
                }


                int
                f_1468_37577_37592(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 37577, 37592);
                    return return_v;
                }


                System.Threading.ManualResetEvent
                f_1468_37748_37775(bool
                initialState)
                {
                    var return_v = new System.Threading.ManualResetEvent(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 37748, 37775);
                    return return_v;
                }


                System.Management.Automation.Remoting.ThrottleManager
                f_1468_37843_37864()
                {
                    var return_v = new System.Management.Automation.Remoting.ThrottleManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 37843, 37864);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CloseOrDisconnectRunspaceOperationHelper
                f_1468_38196_38256(System.Management.Automation.RemoteRunspace
                remoteRunspace)
                {
                    var return_v = new System.Management.Automation.Runspaces.CloseOrDisconnectRunspaceOperationHelper(remoteRunspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 38196, 38256);
                    return return_v;
                }


                int
                f_1468_38279_38318(System.Management.Automation.Remoting.ThrottleManager
                this_param, System.Management.Automation.Remoting.IThrottleOperation
                operation)
                {
                    this_param.AddOperation(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 38279, 38318);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
                f_1468_38114_38123_I(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 38114, 38123);
                    return return_v;
                }


                int
                f_1468_38358_38395(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.EndSubmitOperations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 38358, 38395);
                    return 0;
                }


                bool
                f_1468_38416_38454(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 38416, 38454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 37397, 38481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 37397, 38481);
            }
        }

        private void StopOrDisconnectAllJobs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 38618, 40668);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 38681, 38727) || true) && (f_1468_38685_38709(f_1468_38685_38703(f_1468_38685_38698())) == 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 38681, 38727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 38718, 38725);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 38681, 38727);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 38743, 38813);

                List<RemoteRunspace>
                disconnectRunspaces = f_1468_38786_38812()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 38829, 40444);
                using (ManualResetEvent
                jobsStopCompleted = f_1468_38873_38900(false)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 38934, 38990);

                    ThrottleManager
                    throttleManager = f_1468_38968_38989()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 39008, 39166);

                    throttleManager.ThrottleComplete += delegate (object sender, EventArgs e)
                                    {
                                        jobsStopCompleted.Set();
                                    };
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 39186, 40294);
                        foreach (Job job in f_1468_39206_39229_I(f_1468_39206_39229(f_1468_39206_39224(this))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 39186, 40294);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 39336, 39451) || true) && (job is PSRemotingJob == false)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 39336, 39451);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 39419, 39428);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 39336, 39451);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 39475, 40275) || true) && (f_1468_39479_39497_M(!job.CanDisconnect))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 39475, 40275);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 39667, 39729);

                                f_1468_39667_39728(                        // If the job cannot be disconnected then add it to
                                                                           // the stop list.
                                                        throttleManager, f_1468_39696_39727(job));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 39475, 40275);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 39475, 40275);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 39779, 40275) || true) && (f_1468_39783_39805(f_1468_39783_39799(job)) == JobState.Running)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 39779, 40275);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 40012, 40074);

                                    IEnumerable<RemoteRunspace>
                                    jobRunspaces = f_1468_40055_40073(job)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 40100, 40252) || true) && (jobRunspaces != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 40100, 40252);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 40182, 40225);

                                        f_1468_40182_40224(disconnectRunspaces, jobRunspaces);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 40100, 40252);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 39779, 40275);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 39475, 40275);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 39186, 40294);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1468, 1, 1109);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1468, 1, 1109);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 40345, 40383);

                    f_1468_40345_40382(
                                    // Stop jobs.
                                    throttleManager);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 40401, 40429);

                    f_1468_40401_40428(jobsStopCompleted);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1468, 38829, 40444);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 40527, 40657);

                f_1468_40527_40656(this, () =>
                                {
                                    return disconnectRunspaces;
                                });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 38618, 40668);

                System.Management.Automation.JobRepository
                f_1468_38685_38698()
                {
                    var return_v = JobRepository;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 38685, 38698);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1468_38685_38703(System.Management.Automation.JobRepository
                this_param)
                {
                    var return_v = this_param.Jobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 38685, 38703);
                    return return_v;
                }


                int
                f_1468_38685_38709(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 38685, 38709);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
                f_1468_38786_38812()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 38786, 38812);
                    return return_v;
                }


                System.Threading.ManualResetEvent
                f_1468_38873_38900(bool
                initialState)
                {
                    var return_v = new System.Threading.ManualResetEvent(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 38873, 38900);
                    return return_v;
                }


                System.Management.Automation.Remoting.ThrottleManager
                f_1468_38968_38989()
                {
                    var return_v = new System.Management.Automation.Remoting.ThrottleManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 38968, 38989);
                    return return_v;
                }


                System.Management.Automation.JobRepository
                f_1468_39206_39224(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.JobRepository;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 39206, 39224);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1468_39206_39229(System.Management.Automation.JobRepository
                this_param)
                {
                    var return_v = this_param.Jobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 39206, 39229);
                    return return_v;
                }


                bool
                f_1468_39479_39497_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 39479, 39497);
                    return return_v;
                }


                System.Management.Automation.Runspaces.StopJobOperationHelper
                f_1468_39696_39727(System.Management.Automation.Job
                job)
                {
                    var return_v = new System.Management.Automation.Runspaces.StopJobOperationHelper(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 39696, 39727);
                    return return_v;
                }


                int
                f_1468_39667_39728(System.Management.Automation.Remoting.ThrottleManager
                this_param, System.Management.Automation.Runspaces.StopJobOperationHelper
                operation)
                {
                    this_param.AddOperation((System.Management.Automation.Remoting.IThrottleOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 39667, 39728);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1468_39783_39799(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 39783, 39799);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1468_39783_39805(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 39783, 39805);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteRunspace>
                f_1468_40055_40073(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.GetRunspaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 40055, 40073);
                    return return_v;
                }


                int
                f_1468_40182_40224(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteRunspace>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 40182, 40224);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1468_39206_39229_I(System.Collections.Generic.List<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 39206, 39229);
                    return return_v;
                }


                int
                f_1468_40345_40382(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.EndSubmitOperations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 40345, 40382);
                    return 0;
                }


                bool
                f_1468_40401_40428(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 40401, 40428);
                    return return_v;
                }


                int
                f_1468_40527_40656(System.Management.Automation.Runspaces.LocalRunspace
                this_param, System.Func<System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>>
                getRunspaces)
                {
                    this_param.CloseOrDisconnectAllRemoteRunspaces(getRunspaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 40527, 40656);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 38618, 40668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 38618, 40668);
            }
        }

        internal void ReleaseDebugger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 40680, 41283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 40736, 40765);

                Debugger
                debugger = f_1468_40756_40764()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 40779, 41272) || true) && (debugger != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 40779, 41272);
                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 40877, 41183) || true) && (f_1468_40881_40913(debugger) == UnhandledBreakpointProcessingMode.Wait)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 40877, 41183);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 41084, 41160);

                            debugger.UnhandledBreakpointMode = UnhandledBreakpointProcessingMode.Ignore;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 40877, 41183);
                        }
                    }
                    catch (PSNotImplementedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1468, 41220, 41257);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1468, 41220, 41257);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 40779, 41272);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 40680, 41283);

                System.Management.Automation.Debugger
                f_1468_40756_40764()
                {
                    var return_v = Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 40756, 40764);
                    return return_v;
                }


                System.Management.Automation.UnhandledBreakpointProcessingMode
                f_1468_40881_40913(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.UnhandledBreakpointMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 40881, 40913);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 40680, 41283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 40680, 41283);
            }
        }

        protected override void DoSetVariable(string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 41332, 41728);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 41491, 41612) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 41491, 41612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 41538, 41597);

                    throw f_1468_41544_41596("runspace");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 41491, 41612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 41628, 41717);

                f_1468_41628_41716(f_1468_41628_41662(f_1468_41628_41643(_engine)), name, value, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 41332, 41728);

                System.Management.Automation.PSObjectDisposedException
                f_1468_41544_41596(string
                objectName)
                {
                    var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 41544, 41596);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1468_41628_41643(System.Management.Automation.AutomationEngine
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 41628, 41643);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1468_41628_41662(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 41628, 41662);
                    return return_v;
                }


                int
                f_1468_41628_41716(System.Management.Automation.SessionStateInternal
                this_param, string
                name, object
                newValue, System.Management.Automation.CommandOrigin
                origin)
                {
                    this_param.SetVariableValue(name, newValue, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 41628, 41716);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 41332, 41728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 41332, 41728);
            }
        }

        protected override object DoGetVariable(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 41740, 42100);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 41887, 42008) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 41887, 42008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 41934, 41993);

                    throw f_1468_41940_41992("runspace");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 41887, 42008);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 42024, 42089);

                return f_1468_42031_42088(f_1468_42031_42065(f_1468_42031_42046(_engine)), name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 41740, 42100);

                System.Management.Automation.PSObjectDisposedException
                f_1468_41940_41992(string
                objectName)
                {
                    var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 41940, 41992);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1468_42031_42046(System.Management.Automation.AutomationEngine
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 42031, 42046);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1468_42031_42065(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 42031, 42065);
                    return return_v;
                }


                object
                f_1468_42031_42088(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariableValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 42031, 42088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 41740, 42100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 41740, 42100);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override List<string> DoApplications
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 42183, 42442);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 42219, 42352) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 42219, 42352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 42274, 42333);

                        throw f_1468_42280_42332("runspace");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 42219, 42352);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 42372, 42427);

                    return f_1468_42379_42426(f_1468_42379_42413(f_1468_42379_42394(_engine)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 42183, 42442);

                    System.Management.Automation.PSObjectDisposedException
                    f_1468_42280_42332(string
                    objectName)
                    {
                        var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 42280, 42332);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1468_42379_42394(System.Management.Automation.AutomationEngine
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 42379, 42394);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1468_42379_42413(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 42379, 42413);
                        return return_v;
                    }


                    System.Collections.Generic.List<string>
                    f_1468_42379_42426(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.Applications;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 42379, 42426);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 42112, 42453);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 42112, 42453);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override List<string> DoScripts
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 42531, 42785);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 42567, 42700) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 42567, 42700);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 42622, 42681);

                        throw f_1468_42628_42680("runspace");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 42567, 42700);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 42720, 42770);

                    return f_1468_42727_42769(f_1468_42727_42761(f_1468_42727_42742(_engine)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 42531, 42785);

                    System.Management.Automation.PSObjectDisposedException
                    f_1468_42628_42680(string
                    objectName)
                    {
                        var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 42628, 42680);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1468_42727_42742(System.Management.Automation.AutomationEngine
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 42727, 42742);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1468_42727_42761(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 42727, 42761);
                        return return_v;
                    }


                    System.Collections.Generic.List<string>
                    f_1468_42727_42769(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.Scripts;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 42727, 42769);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 42465, 42796);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 42465, 42796);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override DriveManagementIntrinsics DoDrive
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 42885, 43131);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 42921, 43054) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 42921, 43054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 42976, 43035);

                        throw f_1468_42982_43034("runspace");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 42921, 43054);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 43074, 43116);

                    return f_1468_43081_43115(f_1468_43081_43109(f_1468_43081_43096(_engine)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 42885, 43131);

                    System.Management.Automation.PSObjectDisposedException
                    f_1468_42982_43034(string
                    objectName)
                    {
                        var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 42982, 43034);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1468_43081_43096(System.Management.Automation.AutomationEngine
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 43081, 43096);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1468_43081_43109(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 43081, 43109);
                        return return_v;
                    }


                    System.Management.Automation.DriveManagementIntrinsics
                    f_1468_43081_43115(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Drive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 43081, 43115);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 42808, 43142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 42808, 43142);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override PSLanguageMode DoLanguageMode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 43227, 43480);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 43263, 43396) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 43263, 43396);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 43318, 43377);

                        throw f_1468_43324_43376("runspace");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 43263, 43396);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 43416, 43465);

                    return f_1468_43423_43464(f_1468_43423_43451(f_1468_43423_43438(_engine)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 43227, 43480);

                    System.Management.Automation.PSObjectDisposedException
                    f_1468_43324_43376(string
                    objectName)
                    {
                        var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 43324, 43376);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1468_43423_43438(System.Management.Automation.AutomationEngine
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 43423, 43438);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1468_43423_43451(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 43423, 43451);
                        return return_v;
                    }


                    System.Management.Automation.PSLanguageMode
                    f_1468_43423_43464(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.LanguageMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 43423, 43464);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 43154, 43761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 43154, 43761);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 43496, 43750);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 43532, 43665) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 43532, 43665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 43587, 43646);

                        throw f_1468_43593_43645("runspace");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 43532, 43665);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 43685, 43735);

                    f_1468_43685_43713(f_1468_43685_43700(_engine)).LanguageMode = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 43496, 43750);

                    System.Management.Automation.PSObjectDisposedException
                    f_1468_43593_43645(string
                    objectName)
                    {
                        var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 43593, 43645);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1468_43685_43700(System.Management.Automation.AutomationEngine
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 43685, 43700);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1468_43685_43713(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 43685, 43713);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 43154, 43761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 43154, 43761);
                }
            }
        }

        protected override PSModuleInfo DoModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 43838, 44091);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 43874, 44007) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 43874, 44007);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 43929, 43988);

                        throw f_1468_43935_43987("runspace");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 43874, 44007);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 44027, 44076);

                    return f_1468_44034_44075(f_1468_44034_44068(f_1468_44034_44049(_engine)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 43838, 44091);

                    System.Management.Automation.PSObjectDisposedException
                    f_1468_43935_43987(string
                    objectName)
                    {
                        var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 43935, 43987);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1468_44034_44049(System.Management.Automation.AutomationEngine
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 44034, 44049);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1468_44034_44068(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 44034, 44068);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1468_44034_44075(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 44034, 44075);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 43773, 44102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 43773, 44102);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override PathIntrinsics DoPath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 44179, 44424);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 44215, 44348) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 44215, 44348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 44270, 44329);

                        throw f_1468_44276_44328("runspace");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 44215, 44348);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 44368, 44409);

                    return f_1468_44375_44408(f_1468_44375_44403(f_1468_44375_44390(_engine)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 44179, 44424);

                    System.Management.Automation.PSObjectDisposedException
                    f_1468_44276_44328(string
                    objectName)
                    {
                        var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 44276, 44328);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1468_44375_44390(System.Management.Automation.AutomationEngine
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 44375, 44390);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1468_44375_44403(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 44375, 44403);
                        return return_v;
                    }


                    System.Management.Automation.PathIntrinsics
                    f_1468_44375_44408(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 44375, 44408);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 44114, 44435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 44114, 44435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override CmdletProviderManagementIntrinsics DoProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 44536, 44785);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 44572, 44705) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 44572, 44705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 44627, 44686);

                        throw f_1468_44633_44685("runspace");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 44572, 44705);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 44725, 44770);

                    return f_1468_44732_44769(f_1468_44732_44760(f_1468_44732_44747(_engine)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 44536, 44785);

                    System.Management.Automation.PSObjectDisposedException
                    f_1468_44633_44685(string
                    objectName)
                    {
                        var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 44633, 44685);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1468_44732_44747(System.Management.Automation.AutomationEngine
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 44732, 44747);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1468_44732_44760(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 44732, 44760);
                        return return_v;
                    }


                    System.Management.Automation.CmdletProviderManagementIntrinsics
                    f_1468_44732_44769(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Provider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 44732, 44769);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 44447, 44796);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 44447, 44796);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override PSVariableIntrinsics DoPSVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 44885, 45136);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 44921, 45054) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 44921, 45054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 44976, 45035);

                        throw f_1468_44982_45034("runspace");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 44921, 45054);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 45074, 45121);

                    return f_1468_45081_45120(f_1468_45081_45109(f_1468_45081_45096(_engine)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 44885, 45136);

                    System.Management.Automation.PSObjectDisposedException
                    f_1468_44982_45034(string
                    objectName)
                    {
                        var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 44982, 45034);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1468_45081_45096(System.Management.Automation.AutomationEngine
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 45081, 45096);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1468_45081_45109(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 45081, 45109);
                        return return_v;
                    }


                    System.Management.Automation.PSVariableIntrinsics
                    f_1468_45081_45120(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.PSVariable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 45081, 45120);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 44808, 45147);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 44808, 45147);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override CommandInvocationIntrinsics DoInvokeCommand
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 45246, 45504);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 45282, 45415) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 45282, 45415);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 45337, 45396);

                        throw f_1468_45343_45395("runspace");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 45282, 45415);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 45435, 45489);

                    return f_1468_45442_45488(f_1468_45442_45474(f_1468_45442_45457(_engine)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 45246, 45504);

                    System.Management.Automation.PSObjectDisposedException
                    f_1468_45343_45395(string
                    objectName)
                    {
                        var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 45343, 45395);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1468_45442_45457(System.Management.Automation.AutomationEngine
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 45442, 45457);
                        return return_v;
                    }


                    System.Management.Automation.EngineIntrinsics
                    f_1468_45442_45474(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineIntrinsics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 45442, 45474);
                        return return_v;
                    }


                    System.Management.Automation.CommandInvocationIntrinsics
                    f_1468_45442_45488(System.Management.Automation.EngineIntrinsics
                    this_param)
                    {
                        var return_v = this_param.InvokeCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 45442, 45488);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 45159, 45515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 45159, 45515);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ProviderIntrinsics DoInvokeProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 45606, 45865);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 45642, 45775) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 45642, 45775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 45697, 45756);

                        throw f_1468_45703_45755("runspace");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 45642, 45775);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 45795, 45850);

                    return f_1468_45802_45849(f_1468_45802_45834(f_1468_45802_45817(_engine)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 45606, 45865);

                    System.Management.Automation.PSObjectDisposedException
                    f_1468_45703_45755(string
                    objectName)
                    {
                        var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 45703, 45755);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1468_45802_45817(System.Management.Automation.AutomationEngine
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 45802, 45817);
                        return return_v;
                    }


                    System.Management.Automation.EngineIntrinsics
                    f_1468_45802_45834(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineIntrinsics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 45802, 45834);
                        return return_v;
                    }


                    System.Management.Automation.ProviderIntrinsics
                    f_1468_45802_45849(System.Management.Automation.EngineIntrinsics
                    this_param)
                    {
                        var return_v = this_param.InvokeProvider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 45802, 45849);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 45527, 45876);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 45527, 45876);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _disposed;

        [SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "pipelineThread", Justification = "pipelineThread is disposed in Close()")]
        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 46267, 48053);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 46551, 46632) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 46551, 46632);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 46606, 46613);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 46551, 46632);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 46658, 46666);

                    lock (f_1468_46658_46666())
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 46708, 46801) || true) && (_disposed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 46708, 46801);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 46771, 46778);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 46708, 46801);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 46825, 46842);

                        _disposed = true;
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 46881, 47934) || true) && (disposing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 46881, 47934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 46936, 46944);

                        f_1468_46936_46943(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 46966, 46981);

                        _engine = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 47003, 47019);

                        _history = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 47041, 47067);

                        _transcriptionData = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 47089, 47108);

                        _jobManager = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 47130, 47152);

                        _jobRepository = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 47174, 47201);

                        _runspaceRepository = null;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 47223, 47398) || true) && (RunspaceOpening != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 47223, 47398);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 47300, 47326);

                            f_1468_47300_47325(RunspaceOpening);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 47352, 47375);

                            RunspaceOpening = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 47223, 47398);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 47422, 47458);

                        f_1468_47422_47457();

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 47532, 47915) || true) && (f_1468_47536_47557(this) != null && (DynAbs.Tracing.TraceSender.Expression_True(1468, 47536, 47605) && f_1468_47569_47597(f_1468_47569_47590(this)) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 47532, 47915);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 47715, 47754);

                                f_1468_47715_47753(f_1468_47715_47743(f_1468_47715_47736(this)));
                            }
                            catch (ObjectDisposedException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1468, 47807, 47892);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1468, 47807, 47892);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 47532, 47915);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 46881, 47934);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1468, 47963, 48042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 48003, 48027);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing), 1468, 48003, 48026);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1468, 47963, 48042);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 46267, 48053);

                object
                f_1468_46658_46666()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 46658, 46666);
                    return return_v;
                }


                int
                f_1468_46936_46943(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 46936, 46943);
                    return 0;
                }


                int
                f_1468_47300_47325(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 47300, 47325);
                    return 0;
                }


                int
                f_1468_47422_47457()
                {
                    Platform.RemoveTemporaryDirectory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 47422, 47457);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1468_47536_47557(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 47536, 47557);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1468_47569_47590(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 47569, 47590);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1468_47569_47597(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 47569, 47597);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1468_47715_47736(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 47715, 47736);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1468_47715_47743(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 47715, 47743);
                    return return_v;
                }


                int
                f_1468_47715_47753(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 47715, 47753);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 46267, 48053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 46267, 48053);
            }
        }

        public override void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 48145, 48566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 48370, 48383);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Close(), 1468, 48370, 48382);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 48455, 48555) || true) && (_pipelineThread != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 48455, 48555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 48516, 48540);

                    f_1468_48516_48539(_pipelineThread);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 48455, 48555);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 48145, 48566);

                int
                f_1468_48516_48539(System.Management.Automation.Runspaces.PipelineThread
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 48516, 48539);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 48145, 48566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 48145, 48566);
            }
        }

        private AutomationEngine _engine;

        internal AutomationEngine Engine
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 48861, 48927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 48897, 48912);

                    return _engine;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 48861, 48927);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 48804, 48938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 48804, 48938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private History _history;

        [TraceSource("RunspaceInit", "Initialization code for Runspace")]
        private static
                PSTraceSource s_runspaceInitTracer;

        private static RemoteSessionNamedPipeServer s_IPCNamedPipeServer;

        static LocalRunspace()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1468, 923, 49596);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 12470, 12636);
            s_debugPreferenceCachePath = f_1468_12499_12636(f_1468_12512_12609(f_1468_12525_12587(Environment.SpecialFolder.ProgramFiles), "WindowsPowerShell"), "DebugPreference.clixml");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 12669, 12711);
            s_debugPreferenceLockObject = f_1468_12699_12711();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 49195, 49313);
            s_runspaceInitTracer = f_1468_49231_49313("RunspaceInit", "Initialization code for Runspace", false);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 49481, 49551);
            s_IPCNamedPipeServer = RemoteSessionNamedPipeServer.IPCNamedPipeServer;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1468, 923, 49596);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 923, 49596);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1468, 923, 49596);

        static System.Management.Automation.Host.PSHost
        f_1468_1759_1763_C(System.Management.Automation.Host.PSHost
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1468, 1552, 1822);
            return return_v;
        }


        static System.Management.Automation.Host.PSHost
        f_1468_2403_2407_C(System.Management.Automation.Host.PSHost
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1468, 2216, 2451);
            return return_v;
        }


        static string
        f_1468_12525_12587(System.Environment.SpecialFolder
        folder)
        {
            var return_v = Platform.GetFolderPath(folder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 12525, 12587);
            return return_v;
        }


        static string
        f_1468_12512_12609(string
        path1, string
        path2)
        {
            var return_v = Path.Combine(path1, path2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 12512, 12609);
            return return_v;
        }


        static string
        f_1468_12499_12636(string
        path1, string
        path2)
        {
            var return_v = Path.Combine(path1, path2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 12499, 12636);
            return return_v;
        }


        static object
        f_1468_12699_12711()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 12699, 12711);
            return return_v;
        }


        static System.Management.Automation.PSTraceSource
        f_1468_49231_49313(string
        name, string
        description, bool
        traceHeaders)
        {
            var return_v = PSTraceSource.GetTracer(name, description, traceHeaders);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 49231, 49313);
            return return_v;
        }

    }
    internal sealed class StopJobOperationHelper : IThrottleOperation
    {
        private Job _job;

        internal StopJobOperationHelper(Job job)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1468, 49968, 50149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 49810, 49814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 50033, 50044);

                _job = job;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 50058, 50138);

                _job.StateChanged += new EventHandler<JobStateEventArgs>(HandleJobStateChanged);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1468, 49968, 50149);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 49968, 50149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 49968, 50149);
            }
        }

        private void HandleJobStateChanged(object sender, JobStateEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 50411, 50724);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 50514, 50713) || true) && (f_1468_50518_50563(_job, f_1468_50539_50562(f_1468_50539_50556(_job))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 50514, 50713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 50668, 50698);

                    f_1468_50668_50697(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 50514, 50713);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 50411, 50724);

                System.Management.Automation.JobStateInfo
                f_1468_50539_50556(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 50539, 50556);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1468_50539_50562(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 50539, 50562);
                    return return_v;
                }


                bool
                f_1468_50518_50563(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 50518, 50563);
                    return return_v;
                }


                int
                f_1468_50668_50697(System.Management.Automation.Runspaces.StopJobOperationHelper
                this_param)
                {
                    this_param.RaiseOperationCompleteEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 50668, 50697);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 50411, 50724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 50411, 50724);
            }
        }

        internal override void StartOperation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 50836, 51251);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 50900, 51240) || true) && (f_1468_50904_50949(_job, f_1468_50925_50948(f_1468_50925_50942(_job))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 50900, 51240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 51070, 51100);

                    f_1468_51070_51099(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 50900, 51240);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 50900, 51240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 51210, 51225);

                    f_1468_51210_51224(                // Otherwise stop the job.
                                    _job);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 50900, 51240);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 50836, 51251);

                System.Management.Automation.JobStateInfo
                f_1468_50925_50942(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 50925, 50942);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1468_50925_50948(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 50925, 50948);
                    return return_v;
                }


                bool
                f_1468_50904_50949(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 50904, 50949);
                    return return_v;
                }


                int
                f_1468_51070_51099(System.Management.Automation.Runspaces.StopJobOperationHelper
                this_param)
                {
                    this_param.RaiseOperationCompleteEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 51070, 51099);
                    return 0;
                }


                int
                f_1468_51210_51224(System.Management.Automation.Job
                this_param)
                {
                    this_param.StopJob();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 51210, 51224);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 50836, 51251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 50836, 51251);
            }
        }

        internal override void StopOperation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 51425, 51485);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 51425, 51485);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 51425, 51485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 51425, 51485);
            }
        }

        /// <summary>
        /// Event to signal ThrottleManager when the operation is complete.
        /// </summary>
        internal override event EventHandler<OperationStateEventArgs>
OperationComplete
;

        private void RaiseOperationCompleteEvent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 51808, 52268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 51875, 51955);

                _job.StateChanged -= new EventHandler<JobStateEventArgs>(HandleJobStateChanged);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 51971, 52046);

                OperationStateEventArgs
                operationStateArgs = f_1468_52016_52045()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 52060, 52125);

                operationStateArgs.OperationState = OperationState.StartComplete;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 52139, 52186);

                operationStateArgs.BaseEvent = EventArgs.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 52202, 52257);

                f_1468_52202_52256(
                            OperationComplete, this, operationStateArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 51808, 52268);

                System.Management.Automation.Remoting.OperationStateEventArgs
                f_1468_52016_52045()
                {
                    var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 52016, 52045);
                    return return_v;
                }


                int
                f_1468_52202_52256(System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
                eventHandler, System.Management.Automation.Runspaces.StopJobOperationHelper
                sender, System.Management.Automation.Remoting.OperationStateEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.Remoting.OperationStateEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 52202, 52256);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 51808, 52268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 51808, 52268);
            }
        }

        static StopJobOperationHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1468, 49716, 52275);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1468, 49716, 52275);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 49716, 52275);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1468, 49716, 52275);
    }
    internal sealed class CloseOrDisconnectRunspaceOperationHelper : IThrottleOperation
    {
        private RemoteRunspace _remoteRunspace;

        internal CloseOrDisconnectRunspaceOperationHelper(RemoteRunspace remoteRunspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1468, 52741, 53005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 52580, 52595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 52846, 52879);

                _remoteRunspace = remoteRunspace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 52893, 52994);

                _remoteRunspace.StateChanged += new EventHandler<RunspaceStateEventArgs>(HandleRunspaceStateChanged);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1468, 52741, 53005);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 52741, 53005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 52741, 53005);
            }
        }

        private void HandleRunspaceStateChanged(object sender, RunspaceStateEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 53262, 53847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 53375, 53709);

                switch (f_1468_53383_53416(f_1468_53383_53410(eventArgs)))
                {

                    case RunspaceState.BeforeOpen:
                    case RunspaceState.Closing:
                    case RunspaceState.Opened:
                    case RunspaceState.Opening:
                    case RunspaceState.Disconnecting:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 53375, 53709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 53687, 53694);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 53375, 53709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 53806, 53836);

                f_1468_53806_53835(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 53262, 53847);

                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1468_53383_53410(System.Management.Automation.Runspaces.RunspaceStateEventArgs
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 53383, 53410);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1468_53383_53416(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 53383, 53416);
                    return return_v;
                }


                int
                f_1468_53806_53835(System.Management.Automation.Runspaces.CloseOrDisconnectRunspaceOperationHelper
                this_param)
                {
                    this_param.RaiseOperationCompleteEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 53806, 53835);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 53262, 53847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 53262, 53847);
            }
        }

        internal override void StartOperation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 53964, 55351);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 54028, 55340) || true) && (f_1468_54032_54071(f_1468_54032_54065(_remoteRunspace)) == RunspaceState.Closed || (DynAbs.Tracing.TraceSender.Expression_False(1468, 54032, 54179) || f_1468_54116_54155(f_1468_54116_54149(_remoteRunspace)) == RunspaceState.Broken) || (DynAbs.Tracing.TraceSender.Expression_False(1468, 54032, 54269) || f_1468_54200_54239(f_1468_54200_54233(_remoteRunspace)) == RunspaceState.Disconnected))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 54028, 55340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 54757, 54787);

                    f_1468_54757_54786(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 54028, 55340);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 54028, 55340);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 55008, 55325) || true) && (f_1468_55012_55041(_remoteRunspace) && (DynAbs.Tracing.TraceSender.Expression_True(1468, 55012, 55119) && f_1468_55066_55111(_remoteRunspace) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 55008, 55325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 55161, 55195);

                        f_1468_55161_55194(_remoteRunspace);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 55008, 55325);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 55008, 55325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 55277, 55306);

                        f_1468_55277_55305(_remoteRunspace);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 55008, 55325);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 54028, 55340);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 53964, 55351);

                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1468_54032_54065(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 54032, 54065);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1468_54032_54071(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 54032, 54071);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1468_54116_54149(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 54116, 54149);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1468_54116_54155(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 54116, 54155);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1468_54200_54233(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 54200, 54233);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1468_54200_54239(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 54200, 54239);
                    return return_v;
                }


                int
                f_1468_54757_54786(System.Management.Automation.Runspaces.CloseOrDisconnectRunspaceOperationHelper
                this_param)
                {
                    this_param.RaiseOperationCompleteEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 54757, 54786);
                    return 0;
                }


                bool
                f_1468_55012_55041(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.CanDisconnect;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 55012, 55041);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1468_55066_55111(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 55066, 55111);
                    return return_v;
                }


                int
                f_1468_55161_55194(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    this_param.DisconnectAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 55161, 55194);
                    return 0;
                }


                int
                f_1468_55277_55305(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    this_param.CloseAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 55277, 55305);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 53964, 55351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 53964, 55351);
            }
        }

        internal override void StopOperation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 55539, 55599);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 55539, 55599);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 55539, 55599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 55539, 55599);
            }
        }

        /// <summary>
        /// Event raised when the required operation is complete.
        /// </summary>
        internal override event EventHandler<OperationStateEventArgs>
OperationComplete
;

        private void RaiseOperationCompleteEvent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 55914, 56457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 55981, 56082);

                _remoteRunspace.StateChanged -= new EventHandler<RunspaceStateEventArgs>(HandleRunspaceStateChanged);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 56098, 56199);

                OperationStateEventArgs
                operationStateEventArgs =
                f_1468_56169_56198()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 56213, 56304);

                operationStateEventArgs.OperationState =
                                    OperationState.StartComplete;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 56318, 56370);

                operationStateEventArgs.BaseEvent = EventArgs.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 56386, 56446);

                f_1468_56386_56445(
                            OperationComplete, this, operationStateEventArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 55914, 56457);

                System.Management.Automation.Remoting.OperationStateEventArgs
                f_1468_56169_56198()
                {
                    var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 56169, 56198);
                    return return_v;
                }


                int
                f_1468_56386_56445(System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
                eventHandler, System.Management.Automation.Runspaces.CloseOrDisconnectRunspaceOperationHelper
                sender, System.Management.Automation.Remoting.OperationStateEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.Remoting.OperationStateEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 56386, 56445);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 55914, 56457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 55914, 56457);
            }
        }

        static CloseOrDisconnectRunspaceOperationHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1468, 52457, 56464);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1468, 52457, 56464);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 52457, 56464);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1468, 52457, 56464);
    }
    [Serializable]
    public class RunspaceOpenModuleLoadException : RuntimeException
    {
        public RunspaceOpenModuleLoadException()
        : base(f_1468_57105_57166_C(f_1468_57105_57166(typeof(ScriptBlockToPowerShellNotSupportedException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1468, 57044, 57189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 59178, 59185);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1468, 57044, 57189);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 57044, 57189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 57044, 57189);
            }
        }

        public RunspaceOpenModuleLoadException(string message)
        : base(f_1468_57500_57507_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1468, 57425, 57530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 59178, 59185);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1468, 57425, 57530);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 57425, 57530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 57425, 57530);
            }
        }

        public RunspaceOpenModuleLoadException(string message, Exception innerException)
        : base(f_1468_57970_57977_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1468, 57869, 58016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 59178, 59185);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1468, 57869, 58016);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 57869, 58016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 57869, 58016);
            }
        }

        internal RunspaceOpenModuleLoadException(
                    string moduleName,
                    PSDataCollection<ErrorRecord> errors)
        : base(f_1468_58470_58664_C(f_1468_58470_58664(f_1468_58488_58537(), moduleName, (DynAbs.Tracing.TraceSender.Conditional_F1(1468, 58568, 58625) || (((errors != null && (DynAbs.Tracing.TraceSender.Expression_True(1468, 58569, 58603) && f_1468_58587_58599(errors) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(1468, 58569, 58624) && f_1468_58607_58616(errors, 0) != null)) && DynAbs.Tracing.TraceSender.Conditional_F2(1468, 58628, 58648)) || DynAbs.Tracing.TraceSender.Conditional_F3(1468, 58651, 58663))) ? f_1468_58628_58648(f_1468_58628_58637(errors, 0)) : string.Empty)), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1468, 58325, 58852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 59178, 59185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 58696, 58713);

                _errors = errors;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 58727, 58780);

                f_1468_58727_58779(this, "ErrorLoadingModulesOnRunspaceOpen");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 58794, 58841);

                f_1468_58794_58840(this, ErrorCategory.OpenError);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1468, 58325, 58852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 58325, 58852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 58325, 58852);
            }
        }

        public PSDataCollection<ErrorRecord> ErrorRecords
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 59094, 59117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 59100, 59115);

                    return _errors;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 59094, 59117);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 59020, 59128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 59020, 59128);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSDataCollection<ErrorRecord> _errors;

        protected RunspaceOpenModuleLoadException(SerializationInfo info, StreamingContext context)
        : base(f_1468_59623_59627_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1468, 59511, 59659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 59178, 59185);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1468, 59511, 59659);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 59511, 59659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 59511, 59659);
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1468, 60048, 60325);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 60157, 60264) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1468, 60157, 60264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 60207, 60249);

                    throw f_1468_60213_60248("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1468, 60157, 60264);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1468, 60280, 60314);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1468, 60280, 60313);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1468, 60048, 60325);

                System.Management.Automation.PSArgumentNullException
                f_1468_60213_60248(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 60213, 60248);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1468, 60048, 60325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 60048, 60325);
            }
        }

        static RunspaceOpenModuleLoadException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1468, 56685, 60368);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1468, 56685, 60368);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1468, 56685, 60368);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1468, 56685, 60368);

        static string
        f_1468_57105_57166(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 57105, 57166);
            return return_v;
        }


        static string
        f_1468_57105_57166_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1468, 57044, 57189);
            return return_v;
        }


        static string
        f_1468_57500_57507_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1468, 57425, 57530);
            return return_v;
        }


        static string
        f_1468_57970_57977_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1468, 57869, 58016);
            return return_v;
        }


        static string
        f_1468_58488_58537()
        {
            var return_v = RunspaceStrings.ErrorLoadingModulesOnRunspaceOpen;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 58488, 58537);
            return return_v;
        }


        static int
        f_1468_58587_58599(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 58587, 58599);
            return return_v;
        }


        static System.Management.Automation.ErrorRecord
        f_1468_58607_58616(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 58607, 58616);
            return return_v;
        }


        static System.Management.Automation.ErrorRecord
        f_1468_58628_58637(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1468, 58628, 58637);
            return return_v;
        }


        static string
        f_1468_58628_58648(System.Management.Automation.ErrorRecord
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 58628, 58648);
            return return_v;
        }


        static string
        f_1468_58470_58664(string
        formatSpec, string
        o1, string
        o2)
        {
            var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 58470, 58664);
            return return_v;
        }


        int
        f_1468_58727_58779(System.Management.Automation.Runspaces.RunspaceOpenModuleLoadException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 58727, 58779);
            return 0;
        }


        int
        f_1468_58794_58840(System.Management.Automation.Runspaces.RunspaceOpenModuleLoadException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1468, 58794, 58840);
            return 0;
        }


        static string
        f_1468_58470_58664_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1468, 58325, 58852);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1468_59623_59627_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1468, 59511, 59659);
            return return_v;
        }

    }

}

