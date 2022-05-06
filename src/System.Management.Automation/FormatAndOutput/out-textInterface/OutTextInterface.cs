// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using System.Management.Automation.Internal;

using Microsoft.PowerShell.Commands.Internal.Format;

namespace Microsoft.PowerShell.Commands
{
    [Cmdlet(VerbsData.Out, "LineOutput")]
    public class OutLineOutputCommand : FrontEndCommandBase
    {
        [Parameter(Mandatory = true, Position = 0)]
        public object LineOutput
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1116, 879, 906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 885, 904);

                    return _lineOutput;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1116, 879, 906);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1116, 777, 961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1116, 777, 961);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1116, 922, 950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 928, 948);

                    _lineOutput = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1116, 922, 950);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1116, 777, 961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1116, 777, 961);
                }
            }
        }

        private object _lineOutput;

        public OutLineOutputCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1116, 1098, 1207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 988, 1006);
                this._lineOutput = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 1152, 1196);

                this.implementation = f_1116_1174_1195();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1116, 1098, 1207);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1116, 1098, 1207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1116, 1098, 1207);
            }
        }

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1116, 1266, 1724);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 1332, 1428) || true) && (_lineOutput == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1116, 1332, 1428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 1389, 1413);

                    f_1116_1389_1412(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1116, 1332, 1428);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 1444, 1486);

                LineOutput
                lo = _lineOutput as LineOutput
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 1500, 1603) || true) && (lo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1116, 1500, 1603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 1548, 1588);

                    f_1116_1548_1587(this, _lineOutput);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1116, 1500, 1603);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 1619, 1674);

                ((OutCommandInner)this.implementation).LineOutput = lo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 1690, 1713);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(), 1116, 1690, 1712);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1116, 1266, 1724);

                int
                f_1116_1389_1412(Microsoft.PowerShell.Commands.OutLineOutputCommand
                this_param)
                {
                    this_param.ProcessNullLineOutput();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 1389, 1412);
                    return 0;
                }


                int
                f_1116_1548_1587(Microsoft.PowerShell.Commands.OutLineOutputCommand
                this_param, object
                obj)
                {
                    this_param.ProcessWrongTypeLineOutput(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 1548, 1587);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1116, 1266, 1724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1116, 1266, 1724);
            }
        }

        private void ProcessNullLineOutput()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1116, 1736, 2276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 1797, 1888);

                string
                msg = f_1116_1810_1887(f_1116_1828_1886())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 1904, 2146);

                ErrorRecord
                errorRecord = f_1116_1930_2145(f_1116_1964_2016("LineOutput"), "OutLineOutputNullLineOutputParameter", ErrorCategory.InvalidArgument, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 2162, 2211);

                errorRecord.ErrorDetails = f_1116_2189_2210(msg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 2225, 2265);

                f_1116_2225_2264(this, errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1116, 1736, 2276);

                string
                f_1116_1828_1886()
                {
                    var return_v = FormatAndOut_out_xxx.OutLineOutput_NullLineOutputParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1116, 1828, 1886);
                    return return_v;
                }


                string
                f_1116_1810_1887(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 1810, 1887);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1116_1964_2016(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 1964, 2016);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1116_1930_2145(System.Management.Automation.PSArgumentNullException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 1930, 2145);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1116_2189_2210(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 2189, 2210);
                    return return_v;
                }


                int
                f_1116_2225_2264(Microsoft.PowerShell.Commands.OutLineOutputCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 2225, 2264);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1116, 1736, 2276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1116, 1736, 2276);
            }
        }

        private void ProcessWrongTypeLineOutput(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1116, 2288, 2918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 2364, 2549);

                string
                msg = f_1116_2377_2548(f_1116_2395_2460(), f_1116_2479_2501(f_1116_2479_2492(obj)), f_1116_2520_2547(typeof(LineOutput)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 2565, 2788);

                ErrorRecord
                errorRecord = f_1116_2591_2787(f_1116_2625_2651(), "OutLineOutputInvalidLineOutputParameterType", ErrorCategory.InvalidArgument, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 2804, 2853);

                errorRecord.ErrorDetails = f_1116_2831_2852(msg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1116, 2867, 2907);

                f_1116_2867_2906(this, errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1116, 2288, 2918);

                string
                f_1116_2395_2460()
                {
                    var return_v = FormatAndOut_out_xxx.OutLineOutput_InvalidLineOutputParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1116, 2395, 2460);
                    return return_v;
                }


                System.Type
                f_1116_2479_2492(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 2479, 2492);
                    return return_v;
                }


                string
                f_1116_2479_2501(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1116, 2479, 2501);
                    return return_v;
                }


                string
                f_1116_2520_2547(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1116, 2520, 2547);
                    return return_v;
                }


                string
                f_1116_2377_2548(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 2377, 2548);
                    return return_v;
                }


                System.InvalidCastException
                f_1116_2625_2651()
                {
                    var return_v = new System.InvalidCastException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 2625, 2651);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1116_2591_2787(System.InvalidCastException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 2591, 2787);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1116_2831_2852(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 2831, 2852);
                    return return_v;
                }


                int
                f_1116_2867_2906(Microsoft.PowerShell.Commands.OutLineOutputCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 2867, 2906);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1116, 2288, 2918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1116, 2288, 2918);
            }
        }

        static OutLineOutputCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1116, 514, 2925);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1116, 514, 2925);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1116, 514, 2925);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1116, 514, 2925);

        Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
        f_1116_1174_1195()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1116, 1174, 1195);
            return return_v;
        }

    }
}

