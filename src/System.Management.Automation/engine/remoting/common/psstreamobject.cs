// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting.Internal
{
    /// <summary>
    /// PSStreamObjectType is for internal (PowerShell) consumption and should not be treated as a public API.
    /// </summary>
    public enum PSStreamObjectType
    {
        /// <summary>
        /// </summary>
        Output = 1,

        /// <summary>
        /// </summary>
        Error = 2,

        /// <summary>
        /// </summary>
        MethodExecutor = 3,

        /// <summary>
        /// </summary>
        Warning = 4,

        /// <summary>
        /// </summary>
        BlockingError = 5,

        /// <summary>
        /// </summary>
        ShouldMethod = 6,

        /// <summary>
        /// </summary>
        WarningRecord = 7,

        /// <summary>
        /// </summary>
        Debug = 8,

        /// <summary>
        /// </summary>
        Progress = 9,

        /// <summary>
        /// </summary>
        Verbose = 10,

        /// <summary>
        /// </summary>
        Information = 11,

        /// <summary>
        /// </summary>
        Exception = 12,
    }
    public class PSStreamObject
    {
        public PSStreamObjectType ObjectType { get; set; }

        internal object Value { get; set; }

        internal Guid Id { get; set; }

        internal PSStreamObject(PSStreamObjectType objectType, object value, Guid id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1624, 1931, 2118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 1784, 1834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 1844, 1879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 2033, 2057);

                ObjectType = objectType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 2071, 2085);

                Value = value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 2099, 2107);

                Id = id;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1624, 1931, 2118);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1624, 1931, 2118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1624, 1931, 2118);
            }
        }

        public PSStreamObject(PSStreamObjectType objectType, object value) : this(f_1624_2353_2363_C(objectType), value, Guid.Empty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1624, 2266, 2405);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1624, 2266, 2405);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1624, 2266, 2405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1624, 2266, 2405);
            }
        }

        public void WriteStreamObject(Cmdlet cmdlet, bool overrideInquire = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1624, 2752, 8751);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 2851, 8740) || true) && (cmdlet != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2851, 8740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 2903, 8554);

                    switch (f_1624_2911_2926(this))
                    {

                        case PSStreamObjectType.Output:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2903, 8554);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 3056, 3087);

                                f_1624_3056_3086(cmdlet, f_1624_3075_3085(this));
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1624, 3142, 3148);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2903, 8554);

                        case PSStreamObjectType.Error:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2903, 8554);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 3259, 3309);

                                ErrorRecord
                                errorRecord = (ErrorRecord)f_1624_3298_3308(this)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 3339, 3385);

                                errorRecord.PreserveInvocationInfoOnce = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 3415, 3496);

                                MshCommandRuntime
                                mshCommandRuntime = f_1624_3453_3474(cmdlet) as MshCommandRuntime
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 3526, 3711) || true) && (mshCommandRuntime != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 3526, 3711);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 3621, 3680);

                                    f_1624_3621_3679(mshCommandRuntime, errorRecord, overrideInquire);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 3526, 3711);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1624, 3766, 3772);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2903, 8554);

                        case PSStreamObjectType.Debug:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2903, 8554);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 3883, 3912);

                                string
                                debug = (string)f_1624_3906_3911()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 3942, 3991);

                                DebugRecord
                                debugRecord = f_1624_3968_3990(debug)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 4021, 4102);

                                MshCommandRuntime
                                mshCommandRuntime = f_1624_4059_4080(cmdlet) as MshCommandRuntime
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 4132, 4317) || true) && (mshCommandRuntime != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 4132, 4317);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 4227, 4286);

                                    f_1624_4227_4285(mshCommandRuntime, debugRecord, overrideInquire);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 4132, 4317);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1624, 4372, 4378);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2903, 8554);

                        case PSStreamObjectType.Warning:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2903, 8554);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 4491, 4522);

                                string
                                warning = (string)f_1624_4516_4521()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 4552, 4609);

                                WarningRecord
                                warningRecord = f_1624_4582_4608(warning)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 4639, 4720);

                                MshCommandRuntime
                                mshCommandRuntime = f_1624_4677_4698(cmdlet) as MshCommandRuntime
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 4750, 4939) || true) && (mshCommandRuntime != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 4750, 4939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 4845, 4908);

                                    f_1624_4845_4907(mshCommandRuntime, warningRecord, overrideInquire);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 4750, 4939);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1624, 4994, 5000);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2903, 8554);

                        case PSStreamObjectType.Verbose:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2903, 8554);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 5113, 5144);

                                string
                                verbose = (string)f_1624_5138_5143()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 5174, 5231);

                                VerboseRecord
                                verboseRecord = f_1624_5204_5230(verbose)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 5261, 5342);

                                MshCommandRuntime
                                mshCommandRuntime = f_1624_5299_5320(cmdlet) as MshCommandRuntime
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 5372, 5561) || true) && (mshCommandRuntime != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 5372, 5561);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 5467, 5530);

                                    f_1624_5467_5529(mshCommandRuntime, verboseRecord, overrideInquire);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 5372, 5561);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1624, 5616, 5622);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2903, 8554);

                        case PSStreamObjectType.Progress:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2903, 8554);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 5736, 5817);

                                MshCommandRuntime
                                mshCommandRuntime = f_1624_5774_5795(cmdlet) as MshCommandRuntime
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 5847, 6045) || true) && (mshCommandRuntime != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 5847, 6045);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 5942, 6014);

                                    f_1624_5942_6013(mshCommandRuntime, f_1624_5990_5995(), overrideInquire);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 5847, 6045);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1624, 6100, 6106);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2903, 8554);

                        case PSStreamObjectType.Information:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2903, 8554);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 6223, 6304);

                                MshCommandRuntime
                                mshCommandRuntime = f_1624_6261_6282(cmdlet) as MshCommandRuntime
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 6334, 6538) || true) && (mshCommandRuntime != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 6334, 6538);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 6429, 6507);

                                    f_1624_6429_6506(mshCommandRuntime, f_1624_6483_6488(), overrideInquire);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 6334, 6538);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1624, 6593, 6599);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2903, 8554);

                        case PSStreamObjectType.WarningRecord:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2903, 8554);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 6718, 6769);

                                WarningRecord
                                warningRecord = (WarningRecord)f_1624_6763_6768()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 6799, 6880);

                                MshCommandRuntime
                                mshCommandRuntime = f_1624_6837_6858(cmdlet) as MshCommandRuntime
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 6910, 7090) || true) && (mshCommandRuntime != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 6910, 7090);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 7005, 7059);

                                    f_1624_7005_7058(mshCommandRuntime, warningRecord);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 6910, 7090);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1624, 7145, 7151);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2903, 8554);

                        case PSStreamObjectType.MethodExecutor:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2903, 8554);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 7271, 7415);

                                f_1624_7271_7414(f_1624_7282_7292(this) is ClientMethodExecutor, "Expected psstreamObject.value is ClientMethodExecutor");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 7445, 7511);

                                ClientMethodExecutor
                                methodExecutor = (ClientMethodExecutor)f_1624_7505_7510()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 7541, 7572);

                                f_1624_7541_7571(methodExecutor, cmdlet);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1624, 7627, 7633);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2903, 8554);

                        case PSStreamObjectType.BlockingError:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2903, 8554);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 7752, 7831);

                                CmdletMethodInvoker<object>
                                methodInvoker = (CmdletMethodInvoker<object>)f_1624_7825_7830()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 7861, 7920);

                                f_1624_7861_7919(methodInvoker, cmdlet);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1624, 7975, 7981);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2903, 8554);

                        case PSStreamObjectType.ShouldMethod:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2903, 8554);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 8099, 8174);

                                CmdletMethodInvoker<bool>
                                methodInvoker = (CmdletMethodInvoker<bool>)f_1624_8168_8173()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 8204, 8263);

                                f_1624_8204_8262(methodInvoker, cmdlet);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1624, 8318, 8324);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2903, 8554);

                        case PSStreamObjectType.Exception:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2903, 8554);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 8439, 8470);

                                Exception
                                e = (Exception)f_1624_8464_8469()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 8500, 8508);

                                throw e;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2903, 8554);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2851, 8740);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 2851, 8740);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 8588, 8740) || true) && (f_1624_8592_8602() == PSStreamObjectType.Exception)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 8588, 8740);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 8668, 8699);

                        Exception
                        e = (Exception)f_1624_8693_8698()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 8717, 8725);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 8588, 8740);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 2851, 8740);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1624, 2752, 8751);

                System.Management.Automation.Remoting.Internal.PSStreamObjectType
                f_1624_2911_2926(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param)
                {
                    var return_v = this_param.ObjectType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 2911, 2926);
                    return return_v;
                }


                object
                f_1624_3075_3085(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 3075, 3085);
                    return return_v;
                }


                int
                f_1624_3056_3086(System.Management.Automation.Cmdlet
                this_param, object
                sendToPipeline)
                {
                    this_param.WriteObject(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 3056, 3086);
                    return 0;
                }


                object
                f_1624_3298_3308(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 3298, 3308);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1624_3453_3474(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 3453, 3474);
                    return return_v;
                }


                int
                f_1624_3621_3679(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ErrorRecord
                errorRecord, bool
                overrideInquire)
                {
                    this_param.WriteError(errorRecord, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 3621, 3679);
                    return 0;
                }


                object
                f_1624_3906_3911()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 3906, 3911);
                    return return_v;
                }


                System.Management.Automation.DebugRecord
                f_1624_3968_3990(string
                message)
                {
                    var return_v = new System.Management.Automation.DebugRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 3968, 3990);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1624_4059_4080(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 4059, 4080);
                    return return_v;
                }


                int
                f_1624_4227_4285(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.DebugRecord
                record, bool
                overrideInquire)
                {
                    this_param.WriteDebug(record, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 4227, 4285);
                    return 0;
                }


                object
                f_1624_4516_4521()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 4516, 4521);
                    return return_v;
                }


                System.Management.Automation.WarningRecord
                f_1624_4582_4608(string
                message)
                {
                    var return_v = new System.Management.Automation.WarningRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 4582, 4608);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1624_4677_4698(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 4677, 4698);
                    return return_v;
                }


                int
                f_1624_4845_4907(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.WarningRecord
                record, bool
                overrideInquire)
                {
                    this_param.WriteWarning(record, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 4845, 4907);
                    return 0;
                }


                object
                f_1624_5138_5143()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 5138, 5143);
                    return return_v;
                }


                System.Management.Automation.VerboseRecord
                f_1624_5204_5230(string
                message)
                {
                    var return_v = new System.Management.Automation.VerboseRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 5204, 5230);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1624_5299_5320(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 5299, 5320);
                    return return_v;
                }


                int
                f_1624_5467_5529(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.VerboseRecord
                record, bool
                overrideInquire)
                {
                    this_param.WriteVerbose(record, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 5467, 5529);
                    return 0;
                }


                System.Management.Automation.ICommandRuntime
                f_1624_5774_5795(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 5774, 5795);
                    return return_v;
                }


                object
                f_1624_5990_5995()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 5990, 5995);
                    return return_v;
                }


                int
                f_1624_5942_6013(System.Management.Automation.MshCommandRuntime
                this_param, object
                progressRecord, bool
                overrideInquire)
                {
                    this_param.WriteProgress((System.Management.Automation.ProgressRecord)progressRecord, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 5942, 6013);
                    return 0;
                }


                System.Management.Automation.ICommandRuntime
                f_1624_6261_6282(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 6261, 6282);
                    return return_v;
                }


                object
                f_1624_6483_6488()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 6483, 6488);
                    return return_v;
                }


                int
                f_1624_6429_6506(System.Management.Automation.MshCommandRuntime
                this_param, object
                record, bool
                overrideInquire)
                {
                    this_param.WriteInformation((System.Management.Automation.InformationRecord)record, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 6429, 6506);
                    return 0;
                }


                object
                f_1624_6763_6768()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 6763, 6768);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1624_6837_6858(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 6837, 6858);
                    return return_v;
                }


                int
                f_1624_7005_7058(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.WarningRecord
                obj)
                {
                    this_param.AppendWarningVarList((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 7005, 7058);
                    return 0;
                }


                object
                f_1624_7282_7292(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 7282, 7292);
                    return return_v;
                }


                int
                f_1624_7271_7414(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 7271, 7414);
                    return 0;
                }


                object
                f_1624_7505_7510()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 7505, 7510);
                    return return_v;
                }


                int
                f_1624_7541_7571(System.Management.Automation.Remoting.ClientMethodExecutor
                this_param, System.Management.Automation.Cmdlet
                cmdlet)
                {
                    this_param.Execute(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 7541, 7571);
                    return 0;
                }


                object
                f_1624_7825_7830()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 7825, 7830);
                    return return_v;
                }


                int
                f_1624_7861_7919(System.Management.Automation.Remoting.CmdletMethodInvoker<object>
                cmdletMethodInvoker, System.Management.Automation.Cmdlet
                cmdlet)
                {
                    InvokeCmdletMethodAndWaitForResults(cmdletMethodInvoker, cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 7861, 7919);
                    return 0;
                }


                object
                f_1624_8168_8173()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 8168, 8173);
                    return return_v;
                }


                int
                f_1624_8204_8262(System.Management.Automation.Remoting.CmdletMethodInvoker<bool>
                cmdletMethodInvoker, System.Management.Automation.Cmdlet
                cmdlet)
                {
                    InvokeCmdletMethodAndWaitForResults(cmdletMethodInvoker, cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 8204, 8262);
                    return 0;
                }


                object
                f_1624_8464_8469()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 8464, 8469);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObjectType
                f_1624_8592_8602()
                {
                    var return_v = ObjectType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 8592, 8602);
                    return return_v;
                }


                object
                f_1624_8693_8698()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 8693, 8698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1624, 2752, 8751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1624, 2752, 8751);
            }
        }

        private static void GetIdentifierInfo(string message, out Guid jobInstanceId, out string computerName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1624, 8763, 9281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 8890, 8917);

                jobInstanceId = Guid.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 8931, 8959);

                computerName = string.Empty;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 8975, 9003) || true) && (message == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 8975, 9003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 8996, 9003);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 8975, 9003);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 9017, 9075);

                string[]
                parts = f_1624_9034_9074(message, Utils.Separators.Colon, 3)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 9091, 9121) || true) && (f_1624_9095_9107(parts) != 3)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 9091, 9121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 9114, 9121);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 9091, 9121);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 9137, 9230) || true) && (!Guid.TryParse(parts[0], out jobInstanceId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 9137, 9230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 9203, 9230);

                    jobInstanceId = Guid.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 9137, 9230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 9246, 9270);

                computerName = parts[1];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1624, 8763, 9281);

                string[]
                f_1624_9034_9074(string
                this_param, char[]
                separator, int
                count)
                {
                    var return_v = this_param.Split(separator, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 9034, 9074);
                    return return_v;
                }


                int
                f_1624_9095_9107(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 9095, 9107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1624, 8763, 9281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1624, 8763, 9281);
            }
        }

        internal void WriteStreamObject(Cmdlet cmdlet, Guid instanceId, bool overrideInquire = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1624, 9714, 17519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 9832, 17508);

                switch (f_1624_9840_9850())
                {

                    case PSStreamObjectType.Output:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 9832, 17508);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 9964, 10226) || true) && (instanceId != Guid.Empty)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 9964, 10226);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 10050, 10081);

                                PSObject
                                o = f_1624_10063_10068() as PSObject
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 10111, 10199) || true) && (o != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 10111, 10199);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 10159, 10199);

                                    f_1624_10159_10198(o, instanceId);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 10111, 10199);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 9964, 10226);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 10254, 10280);

                            f_1624_10254_10279(
                                                    cmdlet, f_1624_10273_10278());
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1624, 10327, 10333);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 9832, 17508);

                    case PSStreamObjectType.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 9832, 17508);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 10432, 10482);

                            ErrorRecord
                            errorRecord = (ErrorRecord)f_1624_10471_10481(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 10508, 10583);

                            RemotingErrorRecord
                            remoteErrorRecord = errorRecord as RemotingErrorRecord
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 10611, 11802) || true) && (remoteErrorRecord == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 10611, 11802);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 10869, 11629) || true) && (f_1624_10873_10897(errorRecord) != null && (DynAbs.Tracing.TraceSender.Expression_True(1624, 10873, 10974) && !f_1624_10910_10974(f_1624_10931_10973(f_1624_10931_10955(errorRecord)))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 10869, 11629);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 11040, 11060);

                                    string
                                    computerName
                                    = default(string);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 11094, 11113);

                                    Guid
                                    jobInstanceId
                                    = default(Guid);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 11147, 11297);

                                    f_1624_11147_11296(f_1624_11165_11207(f_1624_11165_11189(errorRecord)), out jobInstanceId, out computerName);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 11333, 11598);

                                    errorRecord = f_1624_11347_11597(errorRecord, f_1624_11455_11596(computerName, Guid.Empty, jobInstanceId));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 10869, 11629);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 10611, 11802);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 10611, 11802);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 11743, 11775);

                                errorRecord = remoteErrorRecord;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 10611, 11802);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 11830, 11876);

                            errorRecord.PreserveInvocationInfoOnce = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 11902, 11983);

                            MshCommandRuntime
                            mshCommandRuntime = f_1624_11940_11961(cmdlet) as MshCommandRuntime
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 12009, 12182) || true) && (mshCommandRuntime != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 12009, 12182);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 12096, 12155);

                                f_1624_12096_12154(mshCommandRuntime, errorRecord, overrideInquire);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 12009, 12182);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1624, 12229, 12235);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 9832, 17508);

                    case PSStreamObjectType.Warning:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 9832, 17508);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 12336, 12367);

                            string
                            warning = (string)f_1624_12361_12366()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 12393, 12450);

                            WarningRecord
                            warningRecord = f_1624_12423_12449(warning)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 12476, 12557);

                            MshCommandRuntime
                            mshCommandRuntime = f_1624_12514_12535(cmdlet) as MshCommandRuntime
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 12583, 12760) || true) && (mshCommandRuntime != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 12583, 12760);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 12670, 12733);

                                f_1624_12670_12732(mshCommandRuntime, warningRecord, overrideInquire);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 12583, 12760);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1624, 12807, 12813);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 9832, 17508);

                    case PSStreamObjectType.Verbose:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 9832, 17508);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 12914, 12945);

                            string
                            verbose = (string)f_1624_12939_12944()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 12971, 13028);

                            VerboseRecord
                            verboseRecord = f_1624_13001_13027(verbose)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 13054, 13135);

                            MshCommandRuntime
                            mshCommandRuntime = f_1624_13092_13113(cmdlet) as MshCommandRuntime
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 13161, 13338) || true) && (mshCommandRuntime != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 13161, 13338);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 13248, 13311);

                                f_1624_13248_13310(mshCommandRuntime, verboseRecord, overrideInquire);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 13161, 13338);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1624, 13385, 13391);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 9832, 17508);

                    case PSStreamObjectType.Progress:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 9832, 17508);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 13493, 13547);

                            ProgressRecord
                            progressRecord = (ProgressRecord)f_1624_13541_13546()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 13575, 13664);

                            RemotingProgressRecord
                            remotingProgressRecord = progressRecord as RemotingProgressRecord
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 13690, 14397) || true) && (remotingProgressRecord == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 13690, 14397);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 13782, 13801);

                                Guid
                                jobInstanceId
                                = default(Guid);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 13831, 13851);

                                string
                                computerName
                                = default(string);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 13881, 14016);

                                f_1624_13881_14015(f_1624_13899_13930(progressRecord), out jobInstanceId, out computerName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 14046, 14120);

                                OriginInfo
                                info = f_1624_14064_14119(computerName, Guid.Empty, jobInstanceId)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 14150, 14216);

                                progressRecord = f_1624_14167_14215(progressRecord, info);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 13690, 14397);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 13690, 14397);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 14330, 14370);

                                progressRecord = remotingProgressRecord;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 13690, 14397);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 14425, 14506);

                            MshCommandRuntime
                            mshCommandRuntime = f_1624_14463_14484(cmdlet) as MshCommandRuntime
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 14532, 14711) || true) && (mshCommandRuntime != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 14532, 14711);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 14619, 14684);

                                f_1624_14619_14683(mshCommandRuntime, progressRecord, overrideInquire);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 14532, 14711);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1624, 14758, 14764);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 9832, 17508);

                    case PSStreamObjectType.Debug:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 9832, 17508);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 14863, 14892);

                            string
                            debug = (string)f_1624_14886_14891()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 14918, 14967);

                            DebugRecord
                            debugRecord = f_1624_14944_14966(debug)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 14993, 15074);

                            MshCommandRuntime
                            mshCommandRuntime = f_1624_15031_15052(cmdlet) as MshCommandRuntime
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 15100, 15273) || true) && (mshCommandRuntime != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 15100, 15273);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 15187, 15246);

                                f_1624_15187_15245(mshCommandRuntime, debugRecord, overrideInquire);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 15100, 15273);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1624, 15320, 15326);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 9832, 17508);

                    case PSStreamObjectType.Information:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 9832, 17508);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 15431, 15499);

                            InformationRecord
                            informationRecord = (InformationRecord)f_1624_15488_15498(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 15525, 15624);

                            RemotingInformationRecord
                            remoteInformationRecord = informationRecord as RemotingInformationRecord
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 15652, 16749) || true) && (remoteInformationRecord == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 15652, 16749);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 15911, 16564) || true) && (!f_1624_15916_15962(f_1624_15937_15961(informationRecord)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 15911, 16564);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 16028, 16048);

                                    string
                                    computerName
                                    = default(string);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 16082, 16101);

                                    Guid
                                    jobInstanceId
                                    = default(Guid);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 16135, 16216);

                                    f_1624_16135_16215(f_1624_16153_16177(informationRecord), out jobInstanceId, out computerName);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 16250, 16533);

                                    informationRecord = f_1624_16270_16532(informationRecord, f_1624_16390_16531(computerName, Guid.Empty, jobInstanceId));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 15911, 16564);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 15652, 16749);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 15652, 16749);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 16678, 16722);

                                informationRecord = remoteInformationRecord;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 15652, 16749);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 16777, 16858);

                            MshCommandRuntime
                            mshCommandRuntime = f_1624_16815_16836(cmdlet) as MshCommandRuntime
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 16884, 17069) || true) && (mshCommandRuntime != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 16884, 17069);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 16971, 17042);

                                f_1624_16971_17041(mshCommandRuntime, informationRecord, overrideInquire);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 16884, 17069);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1624, 17116, 17122);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 9832, 17508);

                    case PSStreamObjectType.WarningRecord:
                    case PSStreamObjectType.MethodExecutor:
                    case PSStreamObjectType.BlockingError:
                    case PSStreamObjectType.ShouldMethod:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 9832, 17508);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 17397, 17440);

                            f_1624_17397_17439(this, cmdlet, overrideInquire);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1624, 17487, 17493);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 9832, 17508);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1624, 9714, 17519);

                System.Management.Automation.Remoting.Internal.PSStreamObjectType
                f_1624_9840_9850()
                {
                    var return_v = ObjectType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 9840, 9850);
                    return return_v;
                }


                object
                f_1624_10063_10068()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 10063, 10068);
                    return return_v;
                }


                int
                f_1624_10159_10198(System.Management.Automation.PSObject
                psObj, System.Guid
                instanceId)
                {
                    AddSourceJobNoteProperty(psObj, instanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 10159, 10198);
                    return 0;
                }


                object
                f_1624_10273_10278()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 10273, 10278);
                    return return_v;
                }


                int
                f_1624_10254_10279(System.Management.Automation.Cmdlet
                this_param, object
                sendToPipeline)
                {
                    this_param.WriteObject(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 10254, 10279);
                    return 0;
                }


                object
                f_1624_10471_10481(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 10471, 10481);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1624_10873_10897(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 10873, 10897);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1624_10931_10955(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 10931, 10955);
                    return return_v;
                }


                string
                f_1624_10931_10973(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.RecommendedAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 10931, 10973);
                    return return_v;
                }


                bool
                f_1624_10910_10974(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 10910, 10974);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1624_11165_11189(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 11165, 11189);
                    return return_v;
                }


                string
                f_1624_11165_11207(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.RecommendedAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 11165, 11207);
                    return return_v;
                }


                int
                f_1624_11147_11296(string
                message, out System.Guid
                jobInstanceId, out string
                computerName)
                {
                    GetIdentifierInfo(message, out jobInstanceId, out computerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 11147, 11296);
                    return 0;
                }


                System.Management.Automation.Remoting.OriginInfo
                f_1624_11455_11596(string
                computerName, System.Guid
                runspaceID, System.Guid
                instanceID)
                {
                    var return_v = new System.Management.Automation.Remoting.OriginInfo(computerName, runspaceID, instanceID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 11455, 11596);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RemotingErrorRecord
                f_1624_11347_11597(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.Remoting.OriginInfo
                originInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.RemotingErrorRecord(errorRecord, originInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 11347, 11597);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1624_11940_11961(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 11940, 11961);
                    return return_v;
                }


                int
                f_1624_12096_12154(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ErrorRecord
                errorRecord, bool
                overrideInquire)
                {
                    this_param.WriteError(errorRecord, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 12096, 12154);
                    return 0;
                }


                object
                f_1624_12361_12366()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 12361, 12366);
                    return return_v;
                }


                System.Management.Automation.WarningRecord
                f_1624_12423_12449(string
                message)
                {
                    var return_v = new System.Management.Automation.WarningRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 12423, 12449);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1624_12514_12535(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 12514, 12535);
                    return return_v;
                }


                int
                f_1624_12670_12732(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.WarningRecord
                record, bool
                overrideInquire)
                {
                    this_param.WriteWarning(record, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 12670, 12732);
                    return 0;
                }


                object
                f_1624_12939_12944()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 12939, 12944);
                    return return_v;
                }


                System.Management.Automation.VerboseRecord
                f_1624_13001_13027(string
                message)
                {
                    var return_v = new System.Management.Automation.VerboseRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 13001, 13027);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1624_13092_13113(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 13092, 13113);
                    return return_v;
                }


                int
                f_1624_13248_13310(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.VerboseRecord
                record, bool
                overrideInquire)
                {
                    this_param.WriteVerbose(record, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 13248, 13310);
                    return 0;
                }


                object
                f_1624_13541_13546()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 13541, 13546);
                    return return_v;
                }


                string
                f_1624_13899_13930(System.Management.Automation.ProgressRecord
                this_param)
                {
                    var return_v = this_param.CurrentOperation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 13899, 13930);
                    return return_v;
                }


                int
                f_1624_13881_14015(string
                message, out System.Guid
                jobInstanceId, out string
                computerName)
                {
                    GetIdentifierInfo(message, out jobInstanceId, out computerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 13881, 14015);
                    return 0;
                }


                System.Management.Automation.Remoting.OriginInfo
                f_1624_14064_14119(string
                computerName, System.Guid
                runspaceID, System.Guid
                instanceID)
                {
                    var return_v = new System.Management.Automation.Remoting.OriginInfo(computerName, runspaceID, instanceID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 14064, 14119);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RemotingProgressRecord
                f_1624_14167_14215(System.Management.Automation.ProgressRecord
                progressRecord, System.Management.Automation.Remoting.OriginInfo
                originInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.RemotingProgressRecord(progressRecord, originInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 14167, 14215);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1624_14463_14484(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 14463, 14484);
                    return return_v;
                }


                int
                f_1624_14619_14683(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ProgressRecord
                progressRecord, bool
                overrideInquire)
                {
                    this_param.WriteProgress(progressRecord, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 14619, 14683);
                    return 0;
                }


                object
                f_1624_14886_14891()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 14886, 14891);
                    return return_v;
                }


                System.Management.Automation.DebugRecord
                f_1624_14944_14966(string
                message)
                {
                    var return_v = new System.Management.Automation.DebugRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 14944, 14966);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1624_15031_15052(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 15031, 15052);
                    return return_v;
                }


                int
                f_1624_15187_15245(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.DebugRecord
                record, bool
                overrideInquire)
                {
                    this_param.WriteDebug(record, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 15187, 15245);
                    return 0;
                }


                object
                f_1624_15488_15498(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 15488, 15498);
                    return return_v;
                }


                string
                f_1624_15937_15961(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 15937, 15961);
                    return return_v;
                }


                bool
                f_1624_15916_15962(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 15916, 15962);
                    return return_v;
                }


                string
                f_1624_16153_16177(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 16153, 16177);
                    return return_v;
                }


                int
                f_1624_16135_16215(string
                message, out System.Guid
                jobInstanceId, out string
                computerName)
                {
                    GetIdentifierInfo(message, out jobInstanceId, out computerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 16135, 16215);
                    return 0;
                }


                System.Management.Automation.Remoting.OriginInfo
                f_1624_16390_16531(string
                computerName, System.Guid
                runspaceID, System.Guid
                instanceID)
                {
                    var return_v = new System.Management.Automation.Remoting.OriginInfo(computerName, runspaceID, instanceID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 16390, 16531);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RemotingInformationRecord
                f_1624_16270_16532(System.Management.Automation.InformationRecord
                record, System.Management.Automation.Remoting.OriginInfo
                originInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.RemotingInformationRecord(record, originInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 16270, 16532);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1624_16815_16836(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 16815, 16836);
                    return return_v;
                }


                int
                f_1624_16971_17041(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.InformationRecord
                record, bool
                overrideInquire)
                {
                    this_param.WriteInformation(record, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 16971, 17041);
                    return 0;
                }


                int
                f_1624_17397_17439(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param, System.Management.Automation.Cmdlet
                cmdlet, bool
                overrideInquire)
                {
                    this_param.WriteStreamObject(cmdlet, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 17397, 17439);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1624, 9714, 17519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1624, 9714, 17519);
            }
        }

        internal void WriteStreamObject(Cmdlet cmdlet, bool writeSourceIdentifier, bool overrideInquire)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1624, 17947, 18249);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 18068, 18238) || true) && (writeSourceIdentifier)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 18068, 18238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 18112, 18159);

                    f_1624_18112_18158(this, cmdlet, f_1624_18138_18140(), overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 18068, 18238);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 18068, 18238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 18195, 18238);

                    f_1624_18195_18237(this, cmdlet, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 18068, 18238);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1624, 17947, 18249);

                System.Guid
                f_1624_18138_18140()
                {
                    var return_v = Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 18138, 18140);
                    return return_v;
                }


                int
                f_1624_18112_18158(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param, System.Management.Automation.Cmdlet
                cmdlet, System.Guid
                instanceId, bool
                overrideInquire)
                {
                    this_param.WriteStreamObject(cmdlet, instanceId, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 18112, 18158);
                    return 0;
                }


                int
                f_1624_18195_18237(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param, System.Management.Automation.Cmdlet
                cmdlet, bool
                overrideInquire)
                {
                    this_param.WriteStreamObject(cmdlet, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 18195, 18237);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1624, 17947, 18249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1624, 17947, 18249);
            }
        }

        private static void InvokeCmdletMethodAndWaitForResults<T>(CmdletMethodInvoker<T> cmdletMethodInvoker, Cmdlet cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1624, 18261, 19317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 18403, 18495);

                f_1624_18403_18494(cmdletMethodInvoker != null, "Caller should verify cmdletMethodInvoker != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 18511, 18557);

                cmdletMethodInvoker.MethodResult = default(T);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 18607, 18662);

                    T
                    tmpMethodResult = f_1624_18627_18661(cmdletMethodInvoker, cmdlet)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 18686, 18716);
                    lock (f_1624_18686_18716(cmdletMethodInvoker))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 18758, 18809);

                        cmdletMethodInvoker.MethodResult = tmpMethodResult;
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1624, 18857, 19101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 18915, 18945);
                    lock (f_1624_18915_18945(cmdletMethodInvoker))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 18987, 19041);

                        cmdletMethodInvoker.ExceptionThrownOnCmdletThread = e;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 19080, 19086);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1624, 18857, 19101);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1624, 19115, 19306);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 19155, 19291) || true) && (f_1624_19159_19187(cmdletMethodInvoker) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 19155, 19291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 19237, 19272);

                        f_1624_19237_19271(f_1624_19237_19265(cmdletMethodInvoker));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 19155, 19291);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1624, 19115, 19306);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1624, 18261, 19317);

                int
                f_1624_18403_18494(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 18403, 18494);
                    return 0;
                }


                T
                f_1624_18627_18661(System.Management.Automation.Remoting.CmdletMethodInvoker<T>
                this_param, System.Management.Automation.Cmdlet
                arg)
                {
                    var return_v = this_param.Action(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 18627, 18661);
                    return return_v;
                }


                object
                f_1624_18686_18716(System.Management.Automation.Remoting.CmdletMethodInvoker<T>
                this_param)
                {
                    var return_v = this_param.SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 18686, 18716);
                    return return_v;
                }


                object
                f_1624_18915_18945(System.Management.Automation.Remoting.CmdletMethodInvoker<T>
                this_param)
                {
                    var return_v = this_param.SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 18915, 18945);
                    return return_v;
                }


                System.Threading.ManualResetEventSlim
                f_1624_19159_19187(System.Management.Automation.Remoting.CmdletMethodInvoker<T>
                this_param)
                {
                    var return_v = this_param.Finished;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 19159, 19187);
                    return return_v;
                }


                System.Threading.ManualResetEventSlim
                f_1624_19237_19265(System.Management.Automation.Remoting.CmdletMethodInvoker<T>
                this_param)
                {
                    var return_v = this_param.Finished;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 19237, 19265);
                    return return_v;
                }


                int
                f_1624_19237_19271(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 19237, 19271);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1624, 18261, 19317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1624, 18261, 19317);
            }
        }

        internal static void AddSourceJobNoteProperty(PSObject psObj, Guid instanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1624, 19329, 19818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 19432, 19506);

                f_1624_19432_19505(psObj != null, "psObj is null trying to add a note property.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 19520, 19699) || true) && (f_1624_19524_19579(f_1624_19524_19540(psObj), RemotingConstants.SourceJobInstanceId) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 19520, 19699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 19621, 19684);

                    f_1624_19621_19683(f_1624_19621_19637(psObj), RemotingConstants.SourceJobInstanceId);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 19520, 19699);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 19715, 19807);

                f_1624_19715_19806(f_1624_19715_19731(psObj), f_1624_19736_19805(RemotingConstants.SourceJobInstanceId, instanceId));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1624, 19329, 19818);

                int
                f_1624_19432_19505(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 19432, 19505);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1624_19524_19540(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 19524, 19540);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1624_19524_19579(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 19524, 19579);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1624_19621_19637(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 19621, 19637);
                    return return_v;
                }


                int
                f_1624_19621_19683(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                name)
                {
                    this_param.Remove(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 19621, 19683);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1624_19715_19731(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 19715, 19731);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1624_19736_19805(string
                name, System.Guid
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 19736, 19805);
                    return return_v;
                }


                int
                f_1624_19715_19806(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 19715, 19806);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1624, 19329, 19818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1624, 19329, 19818);
            }
        }

        internal static string CreateInformationalMessage(Guid instanceId, string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1624, 19830, 20127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 19937, 19995);

                var
                newMessage = f_1624_19954_19994(instanceId.ToString())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 20009, 20032);

                f_1624_20009_20031(newMessage, ":");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 20046, 20073);

                f_1624_20046_20072(newMessage, message);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 20087, 20116);

                return f_1624_20094_20115(newMessage);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1624, 19830, 20127);

                System.Text.StringBuilder
                f_1624_19954_19994(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 19954, 19994);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1624_20009_20031(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 20009, 20031);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1624_20046_20072(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 20046, 20072);
                    return return_v;
                }


                string
                f_1624_20094_20115(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 20094, 20115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1624, 19830, 20127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1624, 19830, 20127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ErrorRecord AddSourceTagToError(ErrorRecord errorRecord, Guid sourceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1624, 20139, 20582);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 20251, 20288) || true) && (errorRecord == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 20251, 20288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 20276, 20288);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 20251, 20288);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 20302, 20398) || true) && (f_1624_20306_20330(errorRecord) == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1624, 20302, 20398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 20340, 20398);

                    errorRecord.ErrorDetails = f_1624_20367_20397(string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1624, 20302, 20398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 20412, 20538);

                f_1624_20412_20436(errorRecord).RecommendedAction = f_1624_20457_20537(sourceId, f_1624_20494_20536(f_1624_20494_20518(errorRecord)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 20552, 20571);

                return errorRecord;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1624, 20139, 20582);

                System.Management.Automation.ErrorDetails
                f_1624_20306_20330(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 20306, 20330);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1624_20367_20397(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 20367, 20397);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1624_20412_20436(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 20412, 20436);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1624_20494_20518(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 20494, 20518);
                    return return_v;
                }


                string
                f_1624_20494_20536(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.RecommendedAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1624, 20494, 20536);
                    return return_v;
                }


                string
                f_1624_20457_20537(System.Guid
                instanceId, string
                message)
                {
                    var return_v = CreateInformationalMessage(instanceId, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1624, 20457, 20537);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1624, 20139, 20582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1624, 20139, 20582);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSStreamObject()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1624, 1693, 20589);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1624, 1693, 20589);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1624, 1693, 20589);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1624, 1693, 20589);

        static System.Management.Automation.Remoting.Internal.PSStreamObjectType
        f_1624_2353_2363_C(System.Management.Automation.Remoting.Internal.PSStreamObjectType
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1624, 2266, 2405);
            return return_v;
        }

    }
}

namespace System.Management.Automation.Remoting
{
    public class CmdletMethodInvoker<T>
    {
        public Func<Cmdlet, T> Action { get; set; }

        public Exception ExceptionThrownOnCmdletThread { get; set; }

        public ManualResetEventSlim Finished { get; set; }

        public object SyncObject { get; set; }

        public T MethodResult { get; set; }

        public CmdletMethodInvoker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1624, 20691, 21259);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 20790, 20833);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 20892, 20952);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 21011, 21061);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 21120, 21158);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1624, 21217, 21252);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1624, 20691, 21259);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1624, 20691, 21259);
        }


        static CmdletMethodInvoker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1624, 20691, 21259);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1624, 20691, 21259);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1624, 20691, 21259);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1624, 20691, 21259);
    }
}
