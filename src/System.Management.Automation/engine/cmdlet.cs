// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691

using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Management.Automation.Internal;
using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    public abstract partial class Cmdlet : InternalCommand
    {
        public static HashSet<string> CommonParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1240, 1949, 2032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 1985, 2017);

                    return f_1240_1992_2016(s_commonParameters);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1240, 1949, 2032);

                    System.Collections.Generic.HashSet<string>
                    f_1240_1992_2016(System.Lazy<System.Collections.Generic.HashSet<string>>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 1992, 2016);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 1878, 2043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 1878, 2043);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static Lazy<HashSet<string>> s_commonParameters;

        public static HashSet<string> OptionalCommonParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1240, 2849, 2940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 2885, 2925);

                    return f_1240_2892_2924(s_optionalCommonParameters);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1240, 2849, 2940);

                    System.Collections.Generic.HashSet<string>
                    f_1240_2892_2924(System.Lazy<System.Collections.Generic.HashSet<string>>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 2892, 2924);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 2770, 2951);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 2770, 2951);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static Lazy<HashSet<string>> s_optionalCommonParameters;

        public bool Stopping
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 4044, 4233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 4080, 4218);
                    using (f_1240_4087_4134())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 4176, 4199);

                        return f_1240_4183_4198(this);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 4080, 4218);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 4044, 4233);

                    System.IDisposable
                    f_1240_4087_4134()
                    {
                        var return_v = PSTransactionManager.GetEngineProtectionScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 4087, 4134);
                        return return_v;
                    }


                    bool
                    f_1240_4183_4198(System.Management.Automation.Cmdlet
                    this_param)
                    {
                        var return_v = this_param.IsStopping;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 4183, 4198);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 3999, 4244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 3999, 4244);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string _ParameterSetName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 4466, 4499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 4472, 4497);

                    return _parameterSetName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 4466, 4499);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 4408, 4510);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 4408, 4510);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void SetParameterSetName(string parameterSetName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 4723, 4854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 4806, 4843);

                _parameterSetName = parameterSetName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 4723, 4854);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 4723, 4854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 4723, 4854);
            }
        }

        private string _parameterSetName;

        internal override void DoBeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 5392, 6393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 5459, 5531);

                MshCommandRuntime
                mshRuntime = f_1240_5490_5509(this) as MshCommandRuntime
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 5547, 6343) || true) && (mshRuntime != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 5547, 6343);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 5603, 6328) || true) && (f_1240_5607_5632(mshRuntime) && (DynAbs.Tracing.TraceSender.Expression_True(1240, 5607, 5705) && (f_1240_5657_5704_M(!f_1240_5658_5689(f_1240_5658_5670(this)).HasTransaction))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 5603, 6328);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 5747, 5802);

                        string
                        error = f_1240_5762_5801()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 5826, 6242) || true) && (f_1240_5830_5888(f_1240_5830_5861(f_1240_5830_5842(this))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 5826, 6242);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 5938, 5996);

                            error = f_1240_5946_5995();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 5826, 6242);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 5826, 6242);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 6046, 6242) || true) && (f_1240_6050_6109(f_1240_6050_6081(f_1240_6050_6062(this))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 6046, 6242);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 6159, 6219);

                                error = f_1240_6167_6218();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 6046, 6242);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 5826, 6242);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 6266, 6309);

                        throw f_1240_6272_6308(error);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 5603, 6328);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 5547, 6343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 6359, 6382);

                f_1240_6359_6381(
                            this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 5392, 6393);

                System.Management.Automation.ICommandRuntime
                f_1240_5490_5509(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 5490, 5509);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1240_5607_5632(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.UseTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 5607, 5632);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1240_5658_5670(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 5658, 5670);
                    return return_v;
                }


                System.Management.Automation.Internal.PSTransactionManager
                f_1240_5658_5689(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TransactionManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 5658, 5689);
                    return return_v;
                }


                bool
                f_1240_5657_5704_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 5657, 5704);
                    return return_v;
                }


                string
                f_1240_5762_5801()
                {
                    var return_v = TransactionStrings.NoTransactionStarted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 5762, 5801);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1240_5830_5842(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 5830, 5842);
                    return return_v;
                }


                System.Management.Automation.Internal.PSTransactionManager
                f_1240_5830_5861(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TransactionManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 5830, 5861);
                    return return_v;
                }


                bool
                f_1240_5830_5888(System.Management.Automation.Internal.PSTransactionManager
                this_param)
                {
                    var return_v = this_param.IsLastTransactionCommitted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 5830, 5888);
                    return return_v;
                }


                string
                f_1240_5946_5995()
                {
                    var return_v = TransactionStrings.NoTransactionStartedFromCommit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 5946, 5995);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1240_6050_6062(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 6050, 6062);
                    return return_v;
                }


                System.Management.Automation.Internal.PSTransactionManager
                f_1240_6050_6081(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TransactionManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 6050, 6081);
                    return return_v;
                }


                bool
                f_1240_6050_6109(System.Management.Automation.Internal.PSTransactionManager
                this_param)
                {
                    var return_v = this_param.IsLastTransactionRolledBack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 6050, 6109);
                    return return_v;
                }


                string
                f_1240_6167_6218()
                {
                    var return_v = TransactionStrings.NoTransactionStartedFromRollback;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 6167, 6218);
                    return return_v;
                }


                System.InvalidOperationException
                f_1240_6272_6308(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 6272, 6308);
                    return return_v;
                }


                int
                f_1240_6359_6381(System.Management.Automation.Cmdlet
                this_param)
                {
                    this_param.BeginProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 6359, 6381);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 5392, 6393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 5392, 6393);
            }
        }

        internal override void DoProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 6755, 6852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 6820, 6841);

                f_1240_6820_6840(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 6755, 6852);

                int
                f_1240_6820_6840(System.Management.Automation.Cmdlet
                this_param)
                {
                    this_param.ProcessRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 6820, 6840);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 6755, 6852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 6755, 6852);
            }
        }

        internal override void DoEndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 7294, 7391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 7359, 7380);

                f_1240_7359_7379(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 7294, 7391);

                int
                f_1240_7359_7379(System.Management.Automation.Cmdlet
                this_param)
                {
                    this_param.EndProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 7359, 7379);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 7294, 7391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 7294, 7391);
            }
        }

        internal override void DoStopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 7924, 8023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 7990, 8012);

                f_1240_7990_8011(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 7924, 8023);

                int
                f_1240_7990_8011(System.Management.Automation.Cmdlet
                this_param)
                {
                    this_param.StopProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 7990, 8011);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 7924, 8023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 7924, 8023);
            }
        }

        protected Cmdlet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1240, 8402, 8442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 4881, 4913);
                this._parameterSetName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1240, 8402, 8442);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 8402, 8442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 8402, 8442);
            }
        }

        public virtual string GetResourceString(string baseName, string resourceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 9813, 11050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 9913, 11039);
                using (f_1240_9920_9967())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 10001, 10115) || true) && (f_1240_10005_10035(baseName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 10001, 10115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 10058, 10115);

                        throw f_1240_10064_10114("baseName");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 10001, 10115);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 10135, 10253) || true) && (f_1240_10139_10171(resourceId))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 10135, 10253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 10194, 10253);

                        throw f_1240_10200_10252("resourceId");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 10135, 10253);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 10273, 10374);

                    ResourceManager
                    manager = f_1240_10299_10373(f_1240_10339_10362(f_1240_10339_10353(this)), baseName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 10392, 10415);

                    string
                    retValue = null
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 10479, 10550);

                        retValue = f_1240_10490_10549(manager, resourceId, f_1240_10520_10548());
                    }
                    catch (MissingManifestResourceException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1240, 10587, 10788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 10668, 10769);

                        throw f_1240_10674_10768("baseName", f_1240_10721_10757(), baseName);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1240, 10587, 10788);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 10808, 10988) || true) && (retValue == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 10808, 10988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 10870, 10969);

                        throw f_1240_10876_10968("resourceId", f_1240_10925_10955(), resourceId);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 10808, 10988);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 11008, 11024);

                    return retValue;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 9913, 11039);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 9813, 11050);

                System.IDisposable
                f_1240_9920_9967()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 9920, 9967);
                    return return_v;
                }


                bool
                f_1240_10005_10035(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 10005, 10035);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1240_10064_10114(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 10064, 10114);
                    return return_v;
                }


                bool
                f_1240_10139_10171(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 10139, 10171);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1240_10200_10252(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 10200, 10252);
                    return return_v;
                }


                System.Type
                f_1240_10339_10353(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 10339, 10353);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1240_10339_10362(System.Type
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 10339, 10362);
                    return return_v;
                }


                System.Resources.ResourceManager
                f_1240_10299_10373(System.Reflection.Assembly
                assembly, string
                baseName)
                {
                    var return_v = ResourceManagerCache.GetResourceManager(assembly, baseName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 10299, 10373);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1240_10520_10548()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 10520, 10548);
                    return return_v;
                }


                string?
                f_1240_10490_10549(System.Resources.ResourceManager
                this_param, string
                name, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.GetString(name, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 10490, 10549);
                    return return_v;
                }


                string
                f_1240_10721_10757()
                {
                    var return_v = GetErrorText.ResourceBaseNameFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 10721, 10757);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1240_10674_10768(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 10674, 10768);
                    return return_v;
                }


                string
                f_1240_10925_10955()
                {
                    var return_v = GetErrorText.ResourceIdFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 10925, 10955);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1240_10876_10968(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 10876, 10968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 9813, 11050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 9813, 11050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ICommandRuntime CommandRuntime
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 11378, 11566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 11414, 11551);
                    using (f_1240_11421_11468())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 11510, 11532);

                        return commandRuntime;
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 11414, 11551);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 11378, 11566);

                    System.IDisposable
                    f_1240_11421_11468()
                    {
                        var return_v = PSTransactionManager.GetEngineProtectionScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 11421, 11468);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 11316, 11782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 11316, 11782);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 11582, 11771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 11618, 11756);
                    using (f_1240_11625_11672())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 11714, 11737);

                        commandRuntime = value;
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 11618, 11756);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 11582, 11771);

                    System.IDisposable
                    f_1240_11625_11672()
                    {
                        var return_v = PSTransactionManager.GetEngineProtectionScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 11625, 11672);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 11316, 11782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 11316, 11782);
                }
            }
        }

        public void WriteError(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 13625, 13998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 13697, 13987);
                using (f_1240_13704_13751())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 13785, 13972) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 13785, 13972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 13834, 13873);

                        f_1240_13834_13872(commandRuntime, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 13785, 13972);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 13785, 13972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 13917, 13972);

                        throw f_1240_13923_13971("WriteError");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 13785, 13972);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 13697, 13987);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 13625, 13998);

                System.IDisposable
                f_1240_13704_13751()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 13704, 13751);
                    return return_v;
                }


                int
                f_1240_13834_13872(System.Management.Automation.ICommandRuntime
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 13834, 13872);
                    return 0;
                }


                System.NotImplementedException
                f_1240_13923_13971(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 13923, 13971);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 13625, 13998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 13625, 13998);
            }
        }

        public void WriteObject(object sendToPipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 15231, 15608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 15302, 15597);
                using (f_1240_15309_15356())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 15390, 15582) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 15390, 15582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 15439, 15482);

                        f_1240_15439_15481(commandRuntime, sendToPipeline);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 15390, 15582);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 15390, 15582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 15526, 15582);

                        throw f_1240_15532_15581("WriteObject");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 15390, 15582);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 15302, 15597);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 15231, 15608);

                System.IDisposable
                f_1240_15309_15356()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 15309, 15356);
                    return return_v;
                }


                int
                f_1240_15439_15481(System.Management.Automation.ICommandRuntime
                this_param, object
                sendToPipeline)
                {
                    this_param.WriteObject(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 15439, 15481);
                    return 0;
                }


                System.NotImplementedException
                f_1240_15532_15581(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 15532, 15581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 15231, 15608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 15231, 15608);
            }
        }

        public void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 17074, 17498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 17171, 17487);
                using (f_1240_17178_17225())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 17259, 17472) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 17259, 17472);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 17308, 17372);

                        f_1240_17308_17371(commandRuntime, sendToPipeline, enumerateCollection);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 17259, 17472);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 17259, 17472);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 17416, 17472);

                        throw f_1240_17422_17471("WriteObject");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 17259, 17472);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 17171, 17487);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 17074, 17498);

                System.IDisposable
                f_1240_17178_17225()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 17178, 17225);
                    return return_v;
                }


                int
                f_1240_17308_17371(System.Management.Automation.ICommandRuntime
                this_param, object
                sendToPipeline, bool
                enumerateCollection)
                {
                    this_param.WriteObject(sendToPipeline, enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 17308, 17371);
                    return 0;
                }


                System.NotImplementedException
                f_1240_17422_17471(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 17422, 17471);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 17074, 17498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 17074, 17498);
            }
        }

        public void WriteVerbose(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 19027, 19387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 19089, 19376);
                using (f_1240_19096_19143())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 19177, 19361) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 19177, 19361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 19226, 19260);

                        f_1240_19226_19259(commandRuntime, text);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 19177, 19361);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 19177, 19361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 19304, 19361);

                        throw f_1240_19310_19360("WriteVerbose");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 19177, 19361);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 19089, 19376);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 19027, 19387);

                System.IDisposable
                f_1240_19096_19143()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 19096, 19143);
                    return return_v;
                }


                int
                f_1240_19226_19259(System.Management.Automation.ICommandRuntime
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 19226, 19259);
                    return 0;
                }


                System.NotImplementedException
                f_1240_19310_19360(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 19310, 19360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 19027, 19387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 19027, 19387);
            }
        }

        public void WriteWarning(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 20894, 21254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 20956, 21243);
                using (f_1240_20963_21010())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 21044, 21228) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 21044, 21228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 21093, 21127);

                        f_1240_21093_21126(commandRuntime, text);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 21044, 21228);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 21044, 21228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 21171, 21228);

                        throw f_1240_21177_21227("WriteWarning");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 21044, 21228);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 20956, 21243);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 20894, 21254);

                System.IDisposable
                f_1240_20963_21010()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 20963, 21010);
                    return return_v;
                }


                int
                f_1240_21093_21126(System.Management.Automation.ICommandRuntime
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 21093, 21126);
                    return 0;
                }


                System.NotImplementedException
                f_1240_21177_21227(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 21177, 21227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 20894, 21254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 20894, 21254);
            }
        }

        public void WriteCommandDetail(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 22782, 23160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 22850, 23149);
                using (f_1240_22857_22904())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 22938, 23134) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 22938, 23134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 22987, 23027);

                        f_1240_22987_23026(commandRuntime, text);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 22938, 23134);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 22938, 23134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 23071, 23134);

                        throw f_1240_23077_23133("WriteCommandDetail");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 22938, 23134);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 22850, 23149);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 22782, 23160);

                System.IDisposable
                f_1240_22857_22904()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 22857, 22904);
                    return return_v;
                }


                int
                f_1240_22987_23026(System.Management.Automation.ICommandRuntime
                this_param, string
                text)
                {
                    this_param.WriteCommandDetail(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 22987, 23026);
                    return 0;
                }


                System.NotImplementedException
                f_1240_23077_23133(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 23077, 23133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 22782, 23160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 22782, 23160);
            }
        }

        public void WriteProgress(ProgressRecord progressRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 24738, 25129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 24819, 25118);
                using (f_1240_24826_24873())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 24907, 25103) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 24907, 25103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 24956, 25001);

                        f_1240_24956_25000(commandRuntime, progressRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 24907, 25103);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 24907, 25103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 25045, 25103);

                        throw f_1240_25051_25102("WriteProgress");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 24907, 25103);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 24819, 25118);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 24738, 25129);

                System.IDisposable
                f_1240_24826_24873()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 24826, 24873);
                    return return_v;
                }


                int
                f_1240_24956_25000(System.Management.Automation.ICommandRuntime
                this_param, System.Management.Automation.ProgressRecord
                progressRecord)
                {
                    this_param.WriteProgress(progressRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 24956, 25000);
                    return 0;
                }


                System.NotImplementedException
                f_1240_25051_25102(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 25051, 25102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 24738, 25129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 24738, 25129);
            }
        }

        internal void WriteProgress(
                    Int64 sourceId,
                    ProgressRecord progressRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 26253, 26584);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 26379, 26573) || true) && (commandRuntime != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 26379, 26573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 26424, 26479);

                    f_1240_26424_26478(commandRuntime, sourceId, progressRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 26379, 26573);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 26379, 26573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 26515, 26573);

                    throw f_1240_26521_26572("WriteProgress");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 26379, 26573);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 26253, 26584);

                int
                f_1240_26424_26478(System.Management.Automation.ICommandRuntime
                this_param, long
                sourceId, System.Management.Automation.ProgressRecord
                progressRecord)
                {
                    this_param.WriteProgress(sourceId, progressRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 26424, 26478);
                    return 0;
                }


                System.NotImplementedException
                f_1240_26521_26572(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 26521, 26572);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 26253, 26584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 26253, 26584);
            }
        }

        public void WriteDebug(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 28479, 28833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 28539, 28822);
                using (f_1240_28546_28593())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 28627, 28807) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 28627, 28807);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 28676, 28708);

                        f_1240_28676_28707(commandRuntime, text);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 28627, 28807);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 28627, 28807);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 28752, 28807);

                        throw f_1240_28758_28806("WriteDebug");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 28627, 28807);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 28539, 28822);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 28479, 28833);

                System.IDisposable
                f_1240_28546_28593()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 28546, 28593);
                    return return_v;
                }


                int
                f_1240_28676_28707(System.Management.Automation.ICommandRuntime
                this_param, string
                text)
                {
                    this_param.WriteDebug(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 28676, 28707);
                    return 0;
                }


                System.NotImplementedException
                f_1240_28758_28806(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 28758, 28806);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 28479, 28833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 28479, 28833);
            }
        }

        public void WriteInformation(object messageData, string[] tags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 30776, 31846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 30864, 31835);
                using (f_1240_30871_30918())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 30952, 31022);

                    ICommandRuntime2
                    commandRuntime2 = commandRuntime as ICommandRuntime2
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 31040, 31820) || true) && (commandRuntime2 != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 31040, 31820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 31109, 31157);

                        string
                        source = f_1240_31125_31156(f_1240_31125_31142(this))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 31179, 31326) || true) && (f_1240_31183_31211(source))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 31179, 31326);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 31261, 31303);

                            source = f_1240_31270_31302(f_1240_31270_31297(f_1240_31270_31287(this)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 31179, 31326);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 31350, 31431);

                        InformationRecord
                        informationRecord = f_1240_31388_31430(messageData, source)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 31455, 31582) || true) && (tags != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 31455, 31582);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 31521, 31559);

                            f_1240_31521_31558(f_1240_31521_31543(informationRecord), tags);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 31455, 31582);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 31606, 31658);

                        f_1240_31606_31657(
                                            commandRuntime2, informationRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 31040, 31820);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 31040, 31820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 31740, 31801);

                        throw f_1240_31746_31800("WriteInformation");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 31040, 31820);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 30864, 31835);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 30776, 31846);

                System.IDisposable
                f_1240_30871_30918()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 30871, 30918);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1240_31125_31142(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 31125, 31142);
                    return return_v;
                }


                string
                f_1240_31125_31156(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PSCommandPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 31125, 31156);
                    return return_v;
                }


                bool
                f_1240_31183_31211(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 31183, 31211);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1240_31270_31287(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 31270, 31287);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1240_31270_31297(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 31270, 31297);
                    return return_v;
                }


                string
                f_1240_31270_31302(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 31270, 31302);
                    return return_v;
                }


                System.Management.Automation.InformationRecord
                f_1240_31388_31430(object
                messageData, string
                source)
                {
                    var return_v = new System.Management.Automation.InformationRecord(messageData, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 31388, 31430);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1240_31521_31543(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.Tags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 31521, 31543);
                    return return_v;
                }


                int
                f_1240_31521_31558(System.Collections.Generic.List<string>
                this_param, string[]
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 31521, 31558);
                    return 0;
                }


                int
                f_1240_31606_31657(System.Management.Automation.ICommandRuntime2
                this_param, System.Management.Automation.InformationRecord
                informationRecord)
                {
                    this_param.WriteInformation(informationRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 31606, 31657);
                    return 0;
                }


                System.NotImplementedException
                f_1240_31746_31800(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 31746, 31800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 30776, 31846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 30776, 31846);
            }
        }

        public void WriteInformation(InformationRecord informationRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 33554, 34129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 33644, 34118);
                using (f_1240_33651_33698())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 33732, 33802);

                    ICommandRuntime2
                    commandRuntime2 = commandRuntime as ICommandRuntime2
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 33820, 34103) || true) && (commandRuntime2 != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 33820, 34103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 33889, 33941);

                        f_1240_33889_33940(commandRuntime2, informationRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 33820, 34103);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 33820, 34103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 34023, 34084);

                        throw f_1240_34029_34083("WriteInformation");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 33820, 34103);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 33644, 34118);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 33554, 34129);

                System.IDisposable
                f_1240_33651_33698()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 33651, 33698);
                    return return_v;
                }


                int
                f_1240_33889_33940(System.Management.Automation.ICommandRuntime2
                this_param, System.Management.Automation.InformationRecord
                informationRecord)
                {
                    this_param.WriteInformation(informationRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 33889, 33940);
                    return 0;
                }


                System.NotImplementedException
                f_1240_34029_34083(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 34029, 34083);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 33554, 34129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 33554, 34129);
            }
        }

        public bool ShouldProcess(string target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 38461, 38789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 38526, 38778);
                using (f_1240_38533_38580())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 38614, 38763) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 38614, 38763);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 38663, 38707);

                        return f_1240_38670_38706(commandRuntime, target);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 38614, 38763);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 38614, 38763);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 38751, 38763);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 38614, 38763);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 38526, 38778);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 38461, 38789);

                System.IDisposable
                f_1240_38533_38580()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 38533, 38580);
                    return return_v;
                }


                bool
                f_1240_38670_38706(System.Management.Automation.ICommandRuntime
                this_param, string
                target)
                {
                    var return_v = this_param.ShouldProcess(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 38670, 38706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 38461, 38789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 38461, 38789);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldProcess(string target, string action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 43311, 43662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 43391, 43651);
                using (f_1240_43398_43445())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 43479, 43636) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 43479, 43636);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 43528, 43580);

                        return f_1240_43535_43579(commandRuntime, target, action);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 43479, 43636);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 43479, 43636);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 43624, 43636);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 43479, 43636);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 43391, 43651);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 43311, 43662);

                System.IDisposable
                f_1240_43398_43445()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 43398, 43445);
                    return return_v;
                }


                bool
                f_1240_43535_43579(System.Management.Automation.ICommandRuntime
                this_param, string
                target, string
                action)
                {
                    var return_v = this_param.ShouldProcess(target, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 43535, 43579);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 43311, 43662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 43311, 43662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldProcess(
                    string verboseDescription,
                    string verboseWarning,
                    string caption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 48844, 49300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 49000, 49289);
                using (f_1240_49007_49054())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 49088, 49274) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 49088, 49274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 49137, 49218);

                        return f_1240_49144_49217(commandRuntime, verboseDescription, verboseWarning, caption);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 49088, 49274);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 49088, 49274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 49262, 49274);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 49088, 49274);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 49000, 49289);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 48844, 49300);

                System.IDisposable
                f_1240_49007_49054()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 49007, 49054);
                    return return_v;
                }


                bool
                f_1240_49144_49217(System.Management.Automation.ICommandRuntime
                this_param, string
                verboseDescription, string
                verboseWarning, string
                caption)
                {
                    var return_v = this_param.ShouldProcess(verboseDescription, verboseWarning, caption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 49144, 49217);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 48844, 49300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 48844, 49300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldProcess(
                    string verboseDescription,
                    string verboseWarning,
                    string caption,
                    out ShouldProcessReason shouldProcessReason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 54893, 55539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 55107, 55528);
                using (f_1240_55114_55161())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 55195, 55513) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 55195, 55513);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 55244, 55350);

                        return f_1240_55251_55349(commandRuntime, verboseDescription, verboseWarning, caption, out shouldProcessReason);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 55195, 55513);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 55195, 55513);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 55413, 55460);

                        shouldProcessReason = ShouldProcessReason.None;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 55482, 55494);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 55195, 55513);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 55107, 55528);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 54893, 55539);

                System.IDisposable
                f_1240_55114_55161()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 55114, 55161);
                    return return_v;
                }


                bool
                f_1240_55251_55349(System.Management.Automation.ICommandRuntime
                this_param, string
                verboseDescription, string
                verboseWarning, string
                caption, out System.Management.Automation.ShouldProcessReason
                shouldProcessReason)
                {
                    var return_v = this_param.ShouldProcess(verboseDescription, verboseWarning, caption, out shouldProcessReason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 55251, 55349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 54893, 55539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 54893, 55539);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldContinue(string query, string caption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 61610, 61963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 61691, 61952);
                using (f_1240_61698_61745())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 61779, 61937) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 61779, 61937);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 61828, 61881);

                        return f_1240_61835_61880(commandRuntime, query, caption);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 61779, 61937);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 61779, 61937);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 61925, 61937);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 61779, 61937);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 61691, 61952);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 61610, 61963);

                System.IDisposable
                f_1240_61698_61745()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 61698, 61745);
                    return return_v;
                }


                bool
                f_1240_61835_61880(System.Management.Automation.ICommandRuntime
                this_param, string
                query, string
                caption)
                {
                    var return_v = this_param.ShouldContinue(query, caption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 61835, 61880);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 61610, 61963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 61610, 61963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference")]
        public bool ShouldContinue(
                    string query, string caption, ref bool yesToAll, ref bool noToAll)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 68579, 69093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 68794, 69082);
                using (f_1240_68801_68848())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 68882, 69067) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 68882, 69067);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 68931, 69011);

                        return f_1240_68938_69010(commandRuntime, query, caption, ref yesToAll, ref noToAll);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 68882, 69067);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 68882, 69067);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 69055, 69067);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 68882, 69067);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 68794, 69082);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 68579, 69093);

                System.IDisposable
                f_1240_68801_68848()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 68801, 68848);
                    return return_v;
                }


                bool
                f_1240_68938_69010(System.Management.Automation.ICommandRuntime
                this_param, string
                query, string
                caption, ref bool
                yesToAll, ref bool
                noToAll)
                {
                    var return_v = this_param.ShouldContinue(query, caption, ref yesToAll, ref noToAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 68938, 69010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 68579, 69093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 68579, 69093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference")]
        public bool ShouldContinue(
                    string query, string caption, bool hasSecurityImpact, ref bool yesToAll, ref bool noToAll)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 75937, 76882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 76176, 76871);
                using (f_1240_76183_76230())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 76264, 76856) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 76264, 76856);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 76332, 76395);

                        ICommandRuntime2
                        runtime2 = commandRuntime as ICommandRuntime2
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 76417, 76781) || true) && (runtime2 != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 76417, 76781);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 76487, 76580);

                            return f_1240_76494_76579(runtime2, query, caption, hasSecurityImpact, ref yesToAll, ref noToAll);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 76417, 76781);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 76417, 76781);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 76678, 76758);

                            return f_1240_76685_76757(commandRuntime, query, caption, ref yesToAll, ref noToAll);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 76417, 76781);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 76264, 76856);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 76264, 76856);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 76844, 76856);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 76264, 76856);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 76176, 76871);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 75937, 76882);

                System.IDisposable
                f_1240_76183_76230()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 76183, 76230);
                    return return_v;
                }


                bool
                f_1240_76494_76579(System.Management.Automation.ICommandRuntime2
                this_param, string
                query, string
                caption, bool
                hasSecurityImpact, ref bool
                yesToAll, ref bool
                noToAll)
                {
                    var return_v = this_param.ShouldContinue(query, caption, hasSecurityImpact, ref yesToAll, ref noToAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 76494, 76579);
                    return return_v;
                }


                bool
                f_1240_76685_76757(System.Management.Automation.ICommandRuntime
                this_param, string
                query, string
                caption, ref bool
                yesToAll, ref bool
                noToAll)
                {
                    var return_v = this_param.ShouldContinue(query, caption, ref yesToAll, ref noToAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 76685, 76757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 75937, 76882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 75937, 76882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<object> GetResults()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 77190, 77868);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 77321, 77520) || true) && (this is PSCmdlet)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 77321, 77520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 77375, 77437);

                    string
                    msg = f_1240_77388_77436()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 77457, 77505);

                    throw f_1240_77463_77504(msg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 77321, 77520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 77536, 77568);

                var
                result = f_1240_77549_77567()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 77582, 77718) || true) && (this.commandRuntime == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 77582, 77718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 77647, 77703);

                    this.CommandRuntime = f_1240_77669_77702(result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 77582, 77718);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 77734, 77757);

                f_1240_77734_77756(
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 77771, 77792);

                f_1240_77771_77791(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 77806, 77827);

                f_1240_77806_77826(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 77843, 77857);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 77190, 77868);

                string
                f_1240_77388_77436()
                {
                    var return_v = CommandBaseStrings.CannotInvokePSCmdletsDirectly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 77388, 77436);
                    return return_v;
                }


                System.InvalidOperationException
                f_1240_77463_77504(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 77463, 77504);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1240_77549_77567()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 77549, 77567);
                    return return_v;
                }


                System.Management.Automation.DefaultCommandRuntime
                f_1240_77669_77702(System.Collections.Generic.List<object>
                outputList)
                {
                    var return_v = new System.Management.Automation.DefaultCommandRuntime(outputList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 77669, 77702);
                    return return_v;
                }


                int
                f_1240_77734_77756(System.Management.Automation.Cmdlet
                this_param)
                {
                    this_param.BeginProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 77734, 77756);
                    return 0;
                }


                int
                f_1240_77771_77791(System.Management.Automation.Cmdlet
                this_param)
                {
                    this_param.ProcessRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 77771, 77791);
                    return 0;
                }


                int
                f_1240_77806_77826(System.Management.Automation.Cmdlet
                this_param)
                {
                    this_param.EndProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 77806, 77826);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 77190, 77868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 77190, 77868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable Invoke()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 78077, 78378);

                var listYield = new List<object>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 78129, 78367);
                using (f_1240_78136_78183())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 78217, 78255);

                    List<object>
                    data = f_1240_78237_78254(this)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 78282, 78287);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 78273, 78352) || true) && (i < f_1240_78293_78303(data))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 78305, 78308)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 78273, 78352))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 78273, 78352);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 78331, 78352);

                            listYield.Add(f_1240_78344_78351(data, i));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1240, 1, 80);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1240, 1, 80);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 78129, 78367);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 78077, 78378);

                return listYield;

                System.IDisposable
                f_1240_78136_78183()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 78136, 78183);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1240_78237_78254(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.GetResults();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 78237, 78254);
                    return return_v;
                }


                int
                f_1240_78293_78303(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 78293, 78303);
                    return return_v;
                }


                object
                f_1240_78344_78351(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 78344, 78351);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 78077, 78378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 78077, 78378);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<T> Invoke<T>()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 78824, 79134);

                var listYield = new List<T>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 78882, 79123);
                using (f_1240_78889_78936())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 78970, 79008);

                    List<object>
                    data = f_1240_78990_79007(this)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 79035, 79040);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 79026, 79108) || true) && (i < f_1240_79046_79056(data))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 79058, 79061)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 79026, 79108))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 79026, 79108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 79084, 79108);

                            listYield.Add((T)f_1240_79100_79107(data, i));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1240, 1, 83);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1240, 1, 83);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 78882, 79123);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 78824, 79134);

                return listYield;

                System.IDisposable
                f_1240_78889_78936()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 78889, 78936);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1240_78990_79007(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.GetResults();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 78990, 79007);
                    return return_v;
                }


                int
                f_1240_79046_79056(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 79046, 79056);
                    return return_v;
                }


                object
                f_1240_79100_79107(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 79100, 79107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 78824, 79134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 78824, 79134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TransactionAvailable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 79337, 79745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 79396, 79734);
                using (f_1240_79403_79450())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 79484, 79719) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 79484, 79719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 79533, 79578);

                        return f_1240_79540_79577(commandRuntime);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 79484, 79719);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 79484, 79719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 79654, 79719);

                        throw f_1240_79660_79718("TransactionAvailable");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 79484, 79719);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 79396, 79734);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 79337, 79745);

                System.IDisposable
                f_1240_79403_79450()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 79403, 79450);
                    return return_v;
                }


                bool
                f_1240_79540_79577(System.Management.Automation.ICommandRuntime
                this_param)
                {
                    var return_v = this_param.TransactionAvailable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 79540, 79577);
                    return return_v;
                }


                System.NotImplementedException
                f_1240_79660_79718(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 79660, 79718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 79337, 79745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 79337, 79745);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations")]
        public PSTransactionContext CurrentPSTransaction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 80139, 80562);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 80175, 80547) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 80175, 80547);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 80224, 80267);

                        return f_1240_80231_80266(commandRuntime);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 80175, 80547);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 80175, 80547);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 80482, 80547);

                        throw f_1240_80488_80546("CurrentPSTransaction");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 80175, 80547);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 80139, 80562);

                    System.Management.Automation.PSTransactionContext
                    f_1240_80231_80266(System.Management.Automation.ICommandRuntime
                    this_param)
                    {
                        var return_v = this_param.CurrentPSTransaction;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 80231, 80266);
                        return return_v;
                    }


                    System.NotImplementedException
                    f_1240_80488_80546(string
                    message)
                    {
                        var return_v = new System.NotImplementedException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 80488, 80546);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 79967, 80573);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 79967, 80573);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void ThrowTerminatingError(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 82667, 83408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 82750, 83397);
                using (f_1240_82757_82804())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 82838, 82931) || true) && (errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 82838, 82931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 82884, 82931);

                        throw f_1240_82890_82930("errorRecord");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 82838, 82931);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 82951, 83382) || true) && (commandRuntime != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 82951, 83382);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 83019, 83069);

                        f_1240_83019_83068(commandRuntime, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 82951, 83382);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 82951, 83382);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 83111, 83382) || true) && (f_1240_83115_83136(errorRecord) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 83111, 83382);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 83186, 83214);

                            throw f_1240_83192_83213(errorRecord);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 83111, 83382);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1240, 83111, 83382);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 83296, 83363);

                            throw f_1240_83302_83362(f_1240_83339_83361(errorRecord));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 83111, 83382);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1240, 82951, 83382);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 82750, 83397);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 82667, 83408);

                System.IDisposable
                f_1240_82757_82804()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 82757, 82804);
                    return return_v;
                }


                System.ArgumentNullException
                f_1240_82890_82930(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 82890, 82930);
                    return return_v;
                }


                int
                f_1240_83019_83068(System.Management.Automation.ICommandRuntime
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 83019, 83068);
                    return 0;
                }


                System.Exception
                f_1240_83115_83136(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 83115, 83136);
                    return return_v;
                }


                System.Exception
                f_1240_83192_83213(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1240, 83192, 83213);
                    return return_v;
                }


                string
                f_1240_83339_83361(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 83339, 83361);
                    return return_v;
                }


                System.InvalidOperationException
                f_1240_83302_83362(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 83302, 83362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 82667, 83408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 82667, 83408);
            }
        }

        protected virtual void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 83931, 84092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 83996, 84081);
                using (f_1240_84003_84050())
                {
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 83996, 84081);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 83931, 84092);

                System.IDisposable
                f_1240_84003_84050()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 84003, 84050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 83931, 84092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 83931, 84092);
            }
        }

        protected virtual void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 84454, 84613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 84517, 84602);
                using (f_1240_84524_84571())
                {
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 84517, 84602);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 84454, 84613);

                System.IDisposable
                f_1240_84524_84571()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 84524, 84571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 84454, 84613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 84454, 84613);
            }
        }

        protected virtual void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 85055, 85214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 85118, 85203);
                using (f_1240_85125_85172())
                {
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 85118, 85203);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 85055, 85214);

                System.IDisposable
                f_1240_85125_85172()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 85125, 85172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 85055, 85214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 85055, 85214);
            }
        }

        protected virtual void StopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1240, 85747, 85907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 85811, 85896);
                using (f_1240_85818_85865())
                {
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1240, 85811, 85896);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1240, 85747, 85907);

                System.IDisposable
                f_1240_85818_85865()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 85818, 85865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1240, 85747, 85907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 85747, 85907);
            }
        }

        static Cmdlet()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1240, 1587, 85994);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 2092, 2524);
            s_commonParameters = f_1240_2113_2524(() =>
                        {
                            return new HashSet<string>(StringComparer.OrdinalIgnoreCase) {
                    "Verbose", "Debug", "ErrorAction", "WarningAction", "InformationAction",
                    "ErrorVariable", "WarningVariable", "OutVariable",
                    "OutBuffer", "PipelineVariable", "InformationVariable" };
                        });
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1240, 3000, 3257);
            s_optionalCommonParameters = f_1240_3029_3257(() =>
                        {
                            return new HashSet<string>(StringComparer.OrdinalIgnoreCase) {
                    "WhatIf", "Confirm", "UseTransaction" };
                        });
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1240, 1587, 85994);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1240, 1587, 85994);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1240, 1587, 85994);

        static System.Lazy<System.Collections.Generic.HashSet<string>>
        f_1240_2113_2524(System.Func<System.Collections.Generic.HashSet<string>>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Collections.Generic.HashSet<string>>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 2113, 2524);
            return return_v;
        }


        static System.Lazy<System.Collections.Generic.HashSet<string>>
        f_1240_3029_3257(System.Func<System.Collections.Generic.HashSet<string>>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Collections.Generic.HashSet<string>>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1240, 3029, 3257);
            return return_v;
        }

    }

    /// <summary>
    /// This describes the reason why ShouldProcess returned what it returned.
    /// Not all possible reasons are covered.
    /// </summary>
    /// <seealso cref="System.Management.Automation.Cmdlet.ShouldProcess(string,string,string,out ShouldProcessReason)"/>
    [Flags]
    public enum ShouldProcessReason
    {
        /// <summary> none of the reasons below </summary>
        None = 0x0,

        /// <summary>
        /// WhatIf behavior was requested.
        /// </summary>
        /// <remarks>
        /// In the MSH host, WhatIf behavior can be requested explicitly
        /// for one cmdlet instance using the -WhatIf commandline parameter,
        /// or implicitly for all SupportsShouldProcess cmdlets with $WhatIfPreference.
        /// Other hosts may have other ways to request WhatIf behavior.
        /// </remarks>
        WhatIf = 0x1,
    }
}

