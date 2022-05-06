// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#define TRACE

using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace System.Management.Automation
{
    /// <summary>
    /// These flags enable tracing based on the types of
    /// a tracing supplied. Each type of tracing will allow
    /// for one or more methods in the StructuredTraceSource class to become
    /// "enabled".
    /// </summary>
    [Flags]
    public enum PSTraceSourceOptions
    {
        /// <summary>
        /// All tracing off.
        /// </summary>
        /// <!--
        /// No tracing is enabled
        /// -->
        None = 0x00000000,

        /// <summary>
        /// Constructors will be traced.
        /// </summary>
        /// <!--
        /// The TraceConstructor methods are enabled
        /// -->
        Constructor = 0x00000001,

        /// <summary>
        /// Dispose will be traced.
        /// </summary>
        /// <!--
        /// The TraceDispose methods are enabled
        /// -->
        Dispose = 0x00000002,

        /// <summary>
        /// Finalize will be traced.
        /// </summary>
        /// <!--
        /// The TraceFinalizer methods are enabled
        /// -->
        Finalizer = 0x00000004,

        /// <summary>
        /// Methods will be traced.
        /// </summary>
        /// <!--
        /// The TraceMethod methods are enabled
        /// -->
        Method = 0x00000008,

        /// <summary>
        /// Properties will be traced.
        /// </summary>
        /// <!--
        /// The TraceProperty methods are enabled
        /// -->
        Property = 0x00000010,

        /// <summary>
        /// Delegates will be traced.
        /// </summary>
        /// <!--
        /// The TraceDelegate and TraceDelegateHandler methods are enabled
        /// -->
        Delegates = 0x00000020,

        /// <summary>
        /// Events will be traced.
        /// </summary>
        /// <!--
        /// The TraceRaiseEvent and TraceEventHandler methods are enabled
        /// -->
        Events = 0x00000040,

        /// <summary>
        /// Exceptions will be traced.
        /// </summary>
        /// <!--
        /// The TraceException method is enabled
        /// -->
        Exception = 0x00000080,

        /// <summary>
        /// Locks will be traced.
        /// </summary>
        /// <!--
        /// The TraceLock methods are enabled
        /// -->
        Lock = 0x00000100,

        /// <summary>
        /// Errors will be traced.
        /// </summary>
        /// <!--
        /// The TraceError methods are enabled
        /// -->
        Error = 0x00000200,

        /// <summary>
        /// Warnings will be traced.
        /// </summary>
        /// <!--
        /// The TraceWarning methods are enabled
        /// -->
        Warning = 0x00000400,

        /// <summary>
        /// Verbose messages will be traced.
        /// </summary>
        Verbose = 0x00000800,

        /// <summary>
        /// WriteLines will be traced.
        /// </summary>
        /// <!--
        /// The WriteLine methods are enabled
        /// -->
        WriteLine = 0x00001000,

        /// <summary>
        /// TraceScope calls will be traced.
        /// </summary>
        Scope = 0x00002000,

        /// <summary>
        /// Assertions will be traced.
        /// </summary>
        Assert = 0x00004000,

        /// <summary>
        /// A combination of flags that trace the execution flow will
        /// be traced.
        /// </summary>
        /// <remarks>
        /// The methods associated with the flags; Constructor, Dispose,
        /// Finalizer, Method, Delegates, and Events will be enabled
        /// </remarks>
        ExecutionFlow =
            Constructor |
            Dispose |
            Finalizer |
            Method |
            Delegates |
            Events |
            Scope,

        /// <summary>
        /// A combination of flags that trace the data will be traced
        /// be traced.
        /// </summary>
        /// <remarks>
        /// The methods associated with the flags; Constructor, Dispose,
        /// Finalizer, Property, and WriteLine will be enabled
        /// </remarks>
        Data =
            Constructor |
            Dispose |
            Finalizer |
            Property |
            Verbose |
            WriteLine,

        /// <summary>
        /// A combination of flags that trace the errors.
        /// </summary>
        /// <remarks>
        /// The methods associated with the flags; Error,
        /// and Exception will be enabled
        /// </remarks>
        Errors =
            Error |
            Exception,

        /// <summary>
        /// All combination of trace flags will be set
        /// be traced.
        /// </summary>
        /// <remarks>
        /// All methods for tracing will be enabled.
        /// </remarks>
        All =
            Constructor |
            Dispose |
            Finalizer |
            Method |
            Property |
            Delegates |
            Events |
            Exception |
            Error |
            Warning |
            Verbose |
            Lock |
            WriteLine |
            Scope |
            Assert
    }
    public partial class PSTraceSource
    {
        internal PSTraceSource(string fullName, string name, string description, bool traceHeaders)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1043, 8347, 10209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 44204, 44227);
                this._alreadyTracing = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 47914, 47948);
                this._flags = PSTraceSourceOptions.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 48074, 48129);
                this.Description = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 48289, 48336);
                this.ShowHeaders = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 48457, 48506);
                this.FullName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 48533, 48538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 48837, 48849);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 8463, 8783) || true) && (f_1043_8467_8497(fullName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 8463, 8783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 8724, 8768);

                    throw f_1043_8730_8767("fullName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 8463, 8783);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 8835, 8855);

                    FullName = fullName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 8873, 8886);

                    _name = name;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 8988, 9064);

                    string
                    tracingEnvVar = f_1043_9011_9063("MshEnableTrace")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 9084, 9554) || true) && (f_1043_9088_9236(tracingEnvVar, "True", StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 9084, 9554);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 9278, 9334);

                        string
                        options = f_1043_9295_9333(f_1043_9295_9322(f_1043_9295_9311(this)), "Options")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 9356, 9535) || true) && (options != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 9356, 9535);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 9425, 9512);

                            _flags = (PSTraceSourceOptions)f_1043_9456_9511(typeof(PSTraceSourceOptions), options, true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 9356, 9535);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 9084, 9554);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 9574, 9601);

                    ShowHeaders = traceHeaders;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 9619, 9645);

                    Description = description;
                }
                catch (System.Xml.XmlException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1043, 9674, 9908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 9858, 9893);

                    _flags = PSTraceSourceOptions.None;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1043, 9674, 9908);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1043, 8347, 10209);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 8347, 10209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 8347, 10209);
            }
        }

        private static bool globalTraceInitialized;

        internal void TraceGlobalAppDomainHeader()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 10440, 11592);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 10603, 10685) || true) && (globalTraceInitialized)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 10603, 10685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 10663, 10670);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 10603, 10685);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 10729, 10899);

                f_1043_10729_10898(this, PSTraceSourceOptions.All, "Initializing tracing for AppDomain: {0}", f_1043_10861_10897(f_1043_10861_10884()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 10946, 11083);

                f_1043_10946_11082(this, PSTraceSourceOptions.All, "\tCurrent time: {0}", DateTime.Now.ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 11126, 11268);

                f_1043_11126_11267(this, PSTraceSourceOptions.All, "\tOS Build: {0}", f_1043_11234_11266(f_1043_11234_11255()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 11325, 11474);

                f_1043_11325_11473(this, PSTraceSourceOptions.All, "\tFramework Build: {0}\n", f_1043_11442_11472(f_1043_11442_11461()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 11551, 11581);

                globalTraceInitialized = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 10440, 11592);

                System.AppDomain
                f_1043_10861_10884()
                {
                    var return_v = AppDomain.CurrentDomain;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 10861, 10884);
                    return return_v;
                }


                string
                f_1043_10861_10897(System.AppDomain
                this_param)
                {
                    var return_v = this_param.FriendlyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 10861, 10897);
                    return return_v;
                }


                int
                f_1043_10729_10898(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format, string
                arg)
                {
                    this_param.OutputLine(flag, format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 10729, 10898);
                    return 0;
                }


                int
                f_1043_10946_11082(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format, string
                arg)
                {
                    this_param.OutputLine(flag, format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 10946, 11082);
                    return 0;
                }


                System.OperatingSystem
                f_1043_11234_11255()
                {
                    var return_v = Environment.OSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 11234, 11255);
                    return return_v;
                }


                string
                f_1043_11234_11266(System.OperatingSystem
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 11234, 11266);
                    return return_v;
                }


                int
                f_1043_11126_11267(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format, string
                arg)
                {
                    this_param.OutputLine(flag, format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 11126, 11267);
                    return 0;
                }


                System.Version
                f_1043_11442_11461()
                {
                    var return_v = Environment.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 11442, 11461);
                    return return_v;
                }


                string
                f_1043_11442_11472(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 11442, 11472);
                    return return_v;
                }


                int
                f_1043_11325_11473(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format, string
                arg)
                {
                    this_param.OutputLine(flag, format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 11325, 11473);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 10440, 11592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 10440, 11592);
            }
        }

        internal void TracerObjectHeader(
                    Assembly callingAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 12152, 13961);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 12249, 12344) || true) && (_flags == PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 12249, 12344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 12322, 12329);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 12249, 12344);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 12420, 12477);

                f_1043_12420_12476(this, PSTraceSourceOptions.All, "Creating tracer:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 12520, 12639);

                f_1043_12520_12638(this, PSTraceSourceOptions.All, "\tCategory: {0}", f_1043_12628_12637(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 12685, 12809);

                f_1043_12685_12808(this, PSTraceSourceOptions.All, "\tDescription: {0}", f_1043_12796_12807());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 12825, 13649) || true) && (callingAssembly != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 12825, 13649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 12922, 13068);

                    f_1043_12922_13067(this, PSTraceSourceOptions.All, "\tAssembly: {0}", f_1043_13042_13066(callingAssembly));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 13128, 13283);

                    f_1043_13128_13282(this, PSTraceSourceOptions.All, "\tAssembly Location: {0}", f_1043_13257_13281(callingAssembly));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 13349, 13437);

                    FileInfo
                    assemblyFileInfo =
                    f_1043_13398_13436(f_1043_13411_13435(callingAssembly))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 13457, 13634);

                    f_1043_13457_13633(this, PSTraceSourceOptions.All, "\tAssembly File Timestamp: {0}", assemblyFileInfo.CreationTime.ToString());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 12825, 13649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 13665, 13713);

                StringBuilder
                flagBuilder = f_1043_13693_13712()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 13751, 13783);

                f_1043_13751_13782(            // Label

                            flagBuilder, "\tFlags: ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 13797, 13835);

                f_1043_13797_13834(flagBuilder, f_1043_13816_13833(_flags));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 13889, 13950);

                f_1043_13889_13949(this, PSTraceSourceOptions.All, f_1043_13926_13948(flagBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 12152, 13961);

                int
                f_1043_12420_12476(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format)
                {
                    this_param.OutputLine(flag, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 12420, 12476);
                    return 0;
                }


                string
                f_1043_12628_12637(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 12628, 12637);
                    return return_v;
                }


                int
                f_1043_12520_12638(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format, string
                arg)
                {
                    this_param.OutputLine(flag, format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 12520, 12638);
                    return 0;
                }


                string
                f_1043_12796_12807()
                {
                    var return_v = Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 12796, 12807);
                    return return_v;
                }


                int
                f_1043_12685_12808(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format, string
                arg)
                {
                    this_param.OutputLine(flag, format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 12685, 12808);
                    return 0;
                }


                string
                f_1043_13042_13066(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 13042, 13066);
                    return return_v;
                }


                int
                f_1043_12922_13067(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format, string
                arg)
                {
                    this_param.OutputLine(flag, format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 12922, 13067);
                    return 0;
                }


                string
                f_1043_13257_13281(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 13257, 13281);
                    return return_v;
                }


                int
                f_1043_13128_13282(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format, string
                arg)
                {
                    this_param.OutputLine(flag, format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 13128, 13282);
                    return 0;
                }


                string
                f_1043_13411_13435(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 13411, 13435);
                    return return_v;
                }


                System.IO.FileInfo
                f_1043_13398_13436(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 13398, 13436);
                    return return_v;
                }


                int
                f_1043_13457_13633(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format, string
                arg)
                {
                    this_param.OutputLine(flag, format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 13457, 13633);
                    return 0;
                }


                System.Text.StringBuilder
                f_1043_13693_13712()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 13693, 13712);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_13751_13782(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 13751, 13782);
                    return return_v;
                }


                string
                f_1043_13816_13833(System.Management.Automation.PSTraceSourceOptions
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 13816, 13833);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_13797_13834(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 13797, 13834);
                    return return_v;
                }


                string
                f_1043_13926_13948(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 13926, 13948);
                    return return_v;
                }


                int
                f_1043_13889_13949(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format)
                {
                    this_param.OutputLine(flag, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 13889, 13949);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 12152, 13961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 12152, 13961);
            }
        }

        internal IDisposable TraceScope(string msg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 14081, 14485);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 14149, 14446) || true) && ((_flags & PSTraceSourceOptions.Scope) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 14149, 14446);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 14297, 14385);

                        return f_1043_14304_14384(this, PSTraceSourceOptions.Scope, null, null, string.Empty, msg);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1043, 14422, 14431);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1043, 14422, 14431);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 14149, 14446);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 14462, 14474);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 14081, 14485);

                System.Management.Automation.ScopeTracer
                f_1043_14304_14384(System.Management.Automation.PSTraceSource
                tracer, System.Management.Automation.PSTraceSourceOptions
                flag, string
                scopeOutputFormatter, string
                leavingScopeFormatter, string
                scopeName, string
                format, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ScopeTracer(tracer, flag, scopeOutputFormatter, leavingScopeFormatter, scopeName, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 14304, 14384);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 14081, 14485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 14081, 14485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IDisposable TraceScope(string format, object arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 14497, 14926);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 14581, 14887) || true) && ((_flags & PSTraceSourceOptions.Scope) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 14581, 14887);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 14729, 14826);

                        return f_1043_14736_14825(this, PSTraceSourceOptions.Scope, null, null, string.Empty, format, arg1);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1043, 14863, 14872);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1043, 14863, 14872);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 14581, 14887);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 14903, 14915);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 14497, 14926);

                System.Management.Automation.ScopeTracer
                f_1043_14736_14825(System.Management.Automation.PSTraceSource
                tracer, System.Management.Automation.PSTraceSourceOptions
                flag, string
                scopeOutputFormatter, string
                leavingScopeFormatter, string
                scopeName, string
                format, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ScopeTracer(tracer, flag, scopeOutputFormatter, leavingScopeFormatter, scopeName, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 14736, 14825);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 14497, 14926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 14497, 14926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IDisposable TraceScope(string format, object arg1, object arg2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 14938, 15386);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 15035, 15347) || true) && ((_flags & PSTraceSourceOptions.Scope) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 15035, 15347);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 15183, 15286);

                        return f_1043_15190_15285(this, PSTraceSourceOptions.Scope, null, null, string.Empty, format, arg1, arg2);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1043, 15323, 15332);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1043, 15323, 15332);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 15035, 15347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 15363, 15375);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 14938, 15386);

                System.Management.Automation.ScopeTracer
                f_1043_15190_15285(System.Management.Automation.PSTraceSource
                tracer, System.Management.Automation.PSTraceSourceOptions
                flag, string
                scopeOutputFormatter, string
                leavingScopeFormatter, string
                scopeName, string
                format, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ScopeTracer(tracer, flag, scopeOutputFormatter, leavingScopeFormatter, scopeName, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 15190, 15285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 14938, 15386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 14938, 15386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IDisposable TraceMethod(
                    string format,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 16723, 18137);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 16844, 18098) || true) && ((_flags & PSTraceSourceOptions.Method) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 16844, 18098);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 17209, 17266);

                        string
                        methodName = f_1043_17229_17265(1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 17346, 17777);

                        return
                                                (IDisposable)
                        f_1043_17421_17776(this, PSTraceSourceOptions.Method, methodOutputFormatter, methodLeavingFormatter, methodName, format, args);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1043, 17814, 18083);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1043, 17814, 18083);
                        // Eat all exceptions

                        // Do not assert here because exceptions can be
                        // raised while a thread is shutting down during
                        // normal operation.
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 16844, 18098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 18114, 18126);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 16723, 18137);

                string
                f_1043_17229_17265(int
                skipFrames)
                {
                    var return_v = GetCallingMethodNameAndParameters(skipFrames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 17229, 17265);
                    return return_v;
                }


                System.Management.Automation.ScopeTracer
                f_1043_17421_17776(System.Management.Automation.PSTraceSource
                tracer, System.Management.Automation.PSTraceSourceOptions
                flag, string
                scopeOutputFormatter, string
                leavingScopeFormatter, string
                scopeName, string
                format, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ScopeTracer(tracer, flag, scopeOutputFormatter, leavingScopeFormatter, scopeName, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 17421, 17776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 16723, 18137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 16723, 18137);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IDisposable TraceEventHandlers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 18578, 19915);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 18644, 19876) || true) && ((_flags & PSTraceSourceOptions.Events) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 18644, 19876);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 19009, 19066);

                        string
                        methodName = f_1043_19029_19065(1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 19145, 19555);

                        return
                                                (IDisposable)
                        f_1043_19220_19554(this, PSTraceSourceOptions.Events, eventHandlerOutputFormatter, eventHandlerLeavingFormatter, methodName, string.Empty);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1043, 19592, 19861);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1043, 19592, 19861);
                        // Eat all exceptions

                        // Do not assert here because exceptions can be
                        // raised while a thread is shutting down during
                        // normal operation.
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 18644, 19876);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 19892, 19904);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 18578, 19915);

                string
                f_1043_19029_19065(int
                skipFrames)
                {
                    var return_v = GetCallingMethodNameAndParameters(skipFrames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 19029, 19065);
                    return return_v;
                }


                System.Management.Automation.ScopeTracer
                f_1043_19220_19554(System.Management.Automation.PSTraceSource
                tracer, System.Management.Automation.PSTraceSourceOptions
                flag, string
                scopeOutputFormatter, string
                leavingScopeFormatter, string
                scopeName, string
                format, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ScopeTracer(tracer, flag, scopeOutputFormatter, leavingScopeFormatter, scopeName, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 19220, 19554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 18578, 19915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 18578, 19915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IDisposable TraceEventHandlers(
                    string format,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 20473, 21905);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 20601, 21866) || true) && ((_flags & PSTraceSourceOptions.Events) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 20601, 21866);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 20966, 21023);

                        string
                        methodName = f_1043_20986_21022(1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 21102, 21545);

                        return
                                                (IDisposable)
                        f_1043_21177_21544(this, PSTraceSourceOptions.Events, eventHandlerOutputFormatter, eventHandlerLeavingFormatter, methodName, format, args);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1043, 21582, 21851);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1043, 21582, 21851);
                        // Eat all exceptions

                        // Do not assert here because exceptions can be
                        // raised while a thread is shutting down during
                        // normal operation.
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 20601, 21866);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 21882, 21894);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 20473, 21905);

                string
                f_1043_20986_21022(int
                skipFrames)
                {
                    var return_v = GetCallingMethodNameAndParameters(skipFrames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 20986, 21022);
                    return return_v;
                }


                System.Management.Automation.ScopeTracer
                f_1043_21177_21544(System.Management.Automation.PSTraceSource
                tracer, System.Management.Automation.PSTraceSourceOptions
                flag, string
                scopeOutputFormatter, string
                leavingScopeFormatter, string
                scopeName, string
                format, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ScopeTracer(tracer, flag, scopeOutputFormatter, leavingScopeFormatter, scopeName, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 21177, 21544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 20473, 21905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 20473, 21905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IDisposable TraceLock(string lockName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 23040, 23961);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 23112, 23922) || true) && ((_flags & PSTraceSourceOptions.Lock) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 23112, 23922);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 23259, 23601);

                        return
                                                (IDisposable)
                        f_1043_23334_23600(this, PSTraceSourceOptions.Lock, lockEnterFormatter, lockLeavingFormatter, lockName);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1043, 23638, 23907);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1043, 23638, 23907);
                        // Eat all exceptions

                        // Do not assert here because exceptions can be
                        // raised while a thread is shutting down during
                        // normal operation.
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 23112, 23922);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 23938, 23950);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 23040, 23961);

                System.Management.Automation.ScopeTracer
                f_1043_23334_23600(System.Management.Automation.PSTraceSource
                tracer, System.Management.Automation.PSTraceSourceOptions
                flag, string
                scopeOutputFormatter, string
                leavingScopeFormatter, string
                scopeName)
                {
                    var return_v = new System.Management.Automation.ScopeTracer(tracer, flag, scopeOutputFormatter, leavingScopeFormatter, scopeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 23334, 23600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 23040, 23961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 23040, 23961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void TraceLockAcquiring(string lockName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 24176, 24472);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 24250, 24461) || true) && ((_flags & PSTraceSourceOptions.Lock) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 24250, 24461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 24353, 24446);

                    f_1043_24353_24445(this, lockAcquiringFormatter, lockName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 24250, 24461);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 24176, 24472);

                int
                f_1043_24353_24445(System.Management.Automation.PSTraceSource
                this_param, string
                formatter, string
                lockName)
                {
                    this_param.TraceLockHelper(formatter, lockName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 24353, 24445);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 24176, 24472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 24176, 24472);
            }
        }

        internal void TraceLockAcquired(string lockName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 24945, 25236);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 25018, 25225) || true) && ((_flags & PSTraceSourceOptions.Lock) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 25018, 25225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 25121, 25210);

                    f_1043_25121_25209(this, lockEnterFormatter, lockName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 25018, 25225);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 24945, 25236);

                int
                f_1043_25121_25209(System.Management.Automation.PSTraceSource
                this_param, string
                formatter, string
                lockName)
                {
                    this_param.TraceLockHelper(formatter, lockName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 25121, 25209);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 24945, 25236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 24945, 25236);
            }
        }

        internal void TraceLockReleased(string lockName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 25547, 25840);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 25620, 25829) || true) && ((_flags & PSTraceSourceOptions.Lock) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 25620, 25829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 25723, 25814);

                    f_1043_25723_25813(this, lockLeavingFormatter, lockName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 25620, 25829);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 25547, 25840);

                int
                f_1043_25723_25813(System.Management.Automation.PSTraceSource
                this_param, string
                formatter, string
                lockName)
                {
                    this_param.TraceLockHelper(formatter, lockName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 25723, 25813);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 25547, 25840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 25547, 25840);
            }
        }

        private void TraceLockHelper(
                    string formatter,
                    string lockName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 26168, 26727);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 26319, 26442);

                    f_1043_26319_26441(this, PSTraceSourceOptions.Lock, formatter, lockName);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1043, 26471, 26716);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1043, 26471, 26716);
                    // Eat all exceptions

                    // Do not assert here because exceptions can be
                    // raised while a thread is shutting down during
                    // normal operation.
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 26168, 26727);

                int
                f_1043_26319_26441(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format, string
                arg)
                {
                    this_param.OutputLine(flag, format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 26319, 26441);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 26168, 26727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 26168, 26727);
            }
        }

        internal void TraceError(
                    string errorMessageFormat,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 27264, 27691);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 27389, 27680) || true) && ((_flags & PSTraceSourceOptions.Error) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 27389, 27680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 27493, 27665);

                    f_1043_27493_27664(this, PSTraceSourceOptions.Error, errorFormatter, errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 27389, 27680);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 27264, 27691);

                int
                f_1043_27493_27664(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                classFormatter, string
                format, params object[]
                args)
                {
                    this_param.FormatOutputLine(flag, classFormatter, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 27493, 27664);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 27264, 27691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 27264, 27691);
            }
        }

        internal void TraceWarning(
                    string warningMessageFormat,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 28095, 28534);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 28224, 28523) || true) && ((_flags & PSTraceSourceOptions.Warning) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 28224, 28523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 28330, 28508);

                    f_1043_28330_28507(this, PSTraceSourceOptions.Warning, warningFormatter, warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 28224, 28523);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 28095, 28534);

                int
                f_1043_28330_28507(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                classFormatter, string
                format, params object[]
                args)
                {
                    this_param.FormatOutputLine(flag, classFormatter, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 28330, 28507);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 28095, 28534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 28095, 28534);
            }
        }

        internal void TraceVerbose(
                    string verboseMessageFormat,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 28938, 29377);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 29067, 29366) || true) && ((_flags & PSTraceSourceOptions.Verbose) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 29067, 29366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 29173, 29351);

                    f_1043_29173_29350(this, PSTraceSourceOptions.Verbose, verboseFormatter, verboseMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 29067, 29366);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 28938, 29377);

                int
                f_1043_29173_29350(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                classFormatter, string
                format, params object[]
                args)
                {
                    this_param.FormatOutputLine(flag, classFormatter, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 29173, 29350);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 28938, 29377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 28938, 29377);
            }
        }

        internal void WriteLine(string format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 29613, 29995);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 29676, 29984) || true) && ((_flags & PSTraceSourceOptions.WriteLine) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 29676, 29984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 29784, 29969);

                    f_1043_29784_29968(this, PSTraceSourceOptions.WriteLine, writeLineFormatter, format, f_1043_29946_29967());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 29676, 29984);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 29613, 29995);

                object[]
                f_1043_29946_29967()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 29946, 29967);
                    return return_v;
                }


                int
                f_1043_29784_29968(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                classFormatter, string
                format, params object[]
                args)
                {
                    this_param.FormatOutputLine(flag, classFormatter, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 29784, 29968);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 29613, 29995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 29613, 29995);
            }
        }

        internal void WriteLine(string format, object arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 30245, 30640);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 30321, 30629) || true) && ((_flags & PSTraceSourceOptions.WriteLine) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 30321, 30629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 30429, 30614);

                    f_1043_30429_30613(this, PSTraceSourceOptions.WriteLine, writeLineFormatter, format, new object[] { arg1 });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 30321, 30629);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 30245, 30640);

                int
                f_1043_30429_30613(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                classFormatter, string
                format, params object[]
                args)
                {
                    this_param.FormatOutputLine(flag, classFormatter, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 30429, 30613);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 30245, 30640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 30245, 30640);
            }
        }

        internal void WriteLine(string format, bool arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 30652, 30780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 30726, 30769);

                f_1043_30726_30768(this, format, f_1043_30752_30767(arg1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 30652, 30780);

                string
                f_1043_30752_30767(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 30752, 30767);
                    return return_v;
                }


                int
                f_1043_30726_30768(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 30726, 30768);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 30652, 30780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 30652, 30780);
            }
        }

        internal void WriteLine(string format, byte arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 30792, 30920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 30866, 30909);

                f_1043_30866_30908(this, format, f_1043_30892_30907(arg1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 30792, 30920);

                string
                f_1043_30892_30907(byte
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 30892, 30907);
                    return return_v;
                }


                int
                f_1043_30866_30908(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 30866, 30908);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 30792, 30920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 30792, 30920);
            }
        }

        internal void WriteLine(string format, char arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 30932, 31060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 31006, 31049);

                f_1043_31006_31048(this, format, f_1043_31032_31047(arg1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 30932, 31060);

                string
                f_1043_31032_31047(char
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31032, 31047);
                    return return_v;
                }


                int
                f_1043_31006_31048(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31006, 31048);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 30932, 31060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 30932, 31060);
            }
        }

        internal void WriteLine(string format, decimal arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 31072, 31203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 31149, 31192);

                f_1043_31149_31191(this, format, f_1043_31175_31190(arg1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 31072, 31203);

                string
                f_1043_31175_31190(decimal
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31175, 31190);
                    return return_v;
                }


                int
                f_1043_31149_31191(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31149, 31191);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 31072, 31203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 31072, 31203);
            }
        }

        internal void WriteLine(string format, double arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 31215, 31345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 31291, 31334);

                f_1043_31291_31333(this, format, f_1043_31317_31332(arg1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 31215, 31345);

                string
                f_1043_31317_31332(double
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31317, 31332);
                    return return_v;
                }


                int
                f_1043_31291_31333(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31291, 31333);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 31215, 31345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 31215, 31345);
            }
        }

        internal void WriteLine(string format, float arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 31357, 31486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 31432, 31475);

                f_1043_31432_31474(this, format, f_1043_31458_31473(arg1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 31357, 31486);

                string
                f_1043_31458_31473(float
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31458, 31473);
                    return return_v;
                }


                int
                f_1043_31432_31474(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31432, 31474);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 31357, 31486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 31357, 31486);
            }
        }

        internal void WriteLine(string format, int arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 31498, 31625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 31571, 31614);

                f_1043_31571_31613(this, format, f_1043_31597_31612(arg1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 31498, 31625);

                string
                f_1043_31597_31612(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31597, 31612);
                    return return_v;
                }


                int
                f_1043_31571_31613(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31571, 31613);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 31498, 31625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 31498, 31625);
            }
        }

        internal void WriteLine(string format, long arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 31637, 31765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 31711, 31754);

                f_1043_31711_31753(this, format, f_1043_31737_31752(arg1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 31637, 31765);

                string
                f_1043_31737_31752(long
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31737, 31752);
                    return return_v;
                }


                int
                f_1043_31711_31753(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31711, 31753);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 31637, 31765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 31637, 31765);
            }
        }

        internal void WriteLine(string format, uint arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 31777, 31905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 31851, 31894);

                f_1043_31851_31893(this, format, f_1043_31877_31892(arg1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 31777, 31905);

                string
                f_1043_31877_31892(uint
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31877, 31892);
                    return return_v;
                }


                int
                f_1043_31851_31893(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31851, 31893);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 31777, 31905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 31777, 31905);
            }
        }

        internal void WriteLine(string format, ulong arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 31917, 32046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 31992, 32035);

                f_1043_31992_32034(this, format, f_1043_32018_32033(arg1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 31917, 32046);

                string
                f_1043_32018_32033(ulong
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 32018, 32033);
                    return return_v;
                }


                int
                f_1043_31992_32034(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 31992, 32034);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 31917, 32046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 31917, 32046);
            }
        }

        internal void WriteLine(string format, object arg1, object arg2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 32337, 32751);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 32426, 32740) || true) && ((_flags & PSTraceSourceOptions.WriteLine) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 32426, 32740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 32534, 32725);

                    f_1043_32534_32724(this, PSTraceSourceOptions.WriteLine, writeLineFormatter, format, new object[] { arg1, arg2 });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 32426, 32740);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 32337, 32751);

                int
                f_1043_32534_32724(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                classFormatter, string
                format, params object[]
                args)
                {
                    this_param.FormatOutputLine(flag, classFormatter, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 32534, 32724);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 32337, 32751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 32337, 32751);
            }
        }

        internal void WriteLine(string format, object arg1, object arg2, object arg3)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 33083, 33516);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 33185, 33505) || true) && ((_flags & PSTraceSourceOptions.WriteLine) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 33185, 33505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 33293, 33490);

                    f_1043_33293_33489(this, PSTraceSourceOptions.WriteLine, writeLineFormatter, format, new object[] { arg1, arg2, arg3 });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 33185, 33505);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 33083, 33516);

                int
                f_1043_33293_33489(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                classFormatter, string
                format, params object[]
                args)
                {
                    this_param.FormatOutputLine(flag, classFormatter, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 33293, 33489);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 33083, 33516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 33083, 33516);
            }
        }

        internal void WriteLine(string format, object arg1, object arg2, object arg3, object arg4)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 33889, 34341);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 34004, 34330) || true) && ((_flags & PSTraceSourceOptions.WriteLine) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 34004, 34330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 34112, 34315);

                    f_1043_34112_34314(this, PSTraceSourceOptions.WriteLine, writeLineFormatter, format, new object[] { arg1, arg2, arg3, arg4 });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 34004, 34330);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 33889, 34341);

                int
                f_1043_34112_34314(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                classFormatter, string
                format, params object[]
                args)
                {
                    this_param.FormatOutputLine(flag, classFormatter, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 34112, 34314);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 33889, 34341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 33889, 34341);
            }
        }

        internal void WriteLine(string format, object arg1, object arg2, object arg3, object arg4, object arg5)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 34755, 35226);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 34883, 35215) || true) && ((_flags & PSTraceSourceOptions.WriteLine) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 34883, 35215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 34991, 35200);

                    f_1043_34991_35199(this, PSTraceSourceOptions.WriteLine, writeLineFormatter, format, new object[] { arg1, arg2, arg3, arg4, arg5 });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 34883, 35215);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 34755, 35226);

                int
                f_1043_34991_35199(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                classFormatter, string
                format, params object[]
                args)
                {
                    this_param.FormatOutputLine(flag, classFormatter, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 34991, 35199);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 34755, 35226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 34755, 35226);
            }
        }

        internal void WriteLine(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 35681, 36171);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 35822, 36160) || true) && ((_flags & PSTraceSourceOptions.WriteLine) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 35822, 36160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 35930, 36145);

                    f_1043_35930_36144(this, PSTraceSourceOptions.WriteLine, writeLineFormatter, format, new object[] { arg1, arg2, arg3, arg4, arg5, arg6 });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 35822, 36160);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 35681, 36171);

                int
                f_1043_35930_36144(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                classFormatter, string
                format, params object[]
                args)
                {
                    this_param.FormatOutputLine(flag, classFormatter, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 35930, 36144);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 35681, 36171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 35681, 36171);
            }
        }

        internal void WriteLine(object arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 36410, 36660);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 36470, 36649) || true) && ((_flags & PSTraceSourceOptions.WriteLine) != PSTraceSourceOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 36470, 36649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 36578, 36634);

                    f_1043_36578_36633(this, "{0}", (DynAbs.Tracing.TraceSender.Conditional_F1(1043, 36595, 36606) || ((arg == null && DynAbs.Tracing.TraceSender.Conditional_F2(1043, 36609, 36615)) || DynAbs.Tracing.TraceSender.Conditional_F3(1043, 36618, 36632))) ? "null" : f_1043_36618_36632(arg));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 36470, 36649);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 36410, 36660);

                string?
                f_1043_36618_36632(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 36618, 36632);
                    return return_v;
                }


                int
                f_1043_36578_36633(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 36578, 36633);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 36410, 36660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 36410, 36660);
            }
        }

        private void FormatOutputLine(
                    PSTraceSourceOptions flag,
                    string classFormatter,
                    string format,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 37297, 38470);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 37649, 37692);

                    StringBuilder
                    output = f_1043_37672_37691()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 37712, 37829) || true) && (classFormatter != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 37712, 37829);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 37780, 37810);

                        f_1043_37780_37809(output, classFormatter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 37712, 37829);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 37849, 38066) || true) && (format != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 37849, 38066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 37909, 38047);

                        f_1043_37909_38046(output, f_1043_37955_37981(), format, args);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 37849, 38066);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 38131, 38167);

                    f_1043_38131_38166(this, flag, f_1043_38148_38165(output));
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1043, 38196, 38459);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1043, 38196, 38459);
                    // Eat all exceptions
                    //
                    // Do not assert here because exceptions can be
                    // raised while a thread is shutting down during
                    // normal operation.
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 37297, 38470);

                System.Text.StringBuilder
                f_1043_37672_37691()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 37672, 37691);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_37780_37809(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 37780, 37809);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1043_37955_37981()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 37955, 37981);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_37909_38046(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, params object[]
                args)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 37909, 38046);
                    return return_v;
                }


                string
                f_1043_38148_38165(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 38148, 38165);
                    return return_v;
                }


                int
                f_1043_38131_38166(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format)
                {
                    this_param.OutputLine(flag, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 38131, 38166);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 37297, 38470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 37297, 38470);
            }
        }

        private static string GetCallingMethodNameAndParameters(int skipFrames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1043, 39208, 40629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 39304, 39345);

                StringBuilder
                methodAndParameters = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 39515, 39568);

                    StackFrame
                    stackFrame = f_1043_39539_39567(++skipFrames)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 39586, 39636);

                    MethodBase
                    callingMethod = f_1043_39613_39635(stackFrame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 39656, 39705);

                    Type
                    declaringType = f_1043_39677_39704(callingMethod)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 39794, 39836);

                    methodAndParameters = f_1043_39816_39835();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 40040, 40238);

                    f_1043_40040_40237(
                                    // Note: don't use the FullName for the declaringType
                                    // as it is usually way too long and makes the trace
                                    // output hard to read.

                                    methodAndParameters, f_1043_40095_40121(), "{0}.{1}(", f_1043_40177_40195(declaringType), f_1043_40218_40236(callingMethod));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 40258, 40290);

                    f_1043_40258_40289(
                                    methodAndParameters, ")");
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1043, 40319, 40564);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1043, 40319, 40564);
                    // Eat all exceptions

                    // Do not assert here because exceptions can be
                    // raised while a thread is shutting down during
                    // normal operation.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 40580, 40618);

                return f_1043_40587_40617(methodAndParameters);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1043, 39208, 40629);

                System.Diagnostics.StackFrame
                f_1043_39539_39567(int
                skipFrames)
                {
                    var return_v = new System.Diagnostics.StackFrame(skipFrames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 39539, 39567);
                    return return_v;
                }


                System.Reflection.MethodBase?
                f_1043_39613_39635(System.Diagnostics.StackFrame
                this_param)
                {
                    var return_v = this_param.GetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 39613, 39635);
                    return return_v;
                }


                System.Type
                f_1043_39677_39704(System.Reflection.MethodBase
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 39677, 39704);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_39816_39835()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 39816, 39835);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1043_40095_40121()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 40095, 40121);
                    return return_v;
                }


                string
                f_1043_40177_40195(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 40177, 40195);
                    return return_v;
                }


                string
                f_1043_40218_40236(System.Reflection.MethodBase
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 40218, 40236);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_40040_40237(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 40040, 40237);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_40258_40289(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 40258, 40289);
                    return return_v;
                }


                string
                f_1043_40587_40617(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 40587, 40617);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 39208, 40629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 39208, 40629);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const string
        errorFormatter =
                    "ERROR: "
        ;

        private const string
        warningFormatter =
                    "Warning: "
        ;

        private const string
        verboseFormatter =
                    "Verbose: "
        ;

        private const string
        writeLineFormatter =
                    ""
        ;

        private const string
        constructorOutputFormatter =
                    "Enter Ctor {0}"
        ;

        private const string
        constructorLeavingFormatter =
                    "Leave Ctor {0}"
        ;

        private const string
        disposeOutputFormatter =
                    "Enter Disposer {0}"
        ;

        private const string
        disposeLeavingFormatter =
                    "Leave Disposer {0}"
        ;

        private const string
        methodOutputFormatter =
                    "Enter {0}:"
        ;

        private const string
        methodLeavingFormatter =
                    "Leave {0}"
        ;

        private const string
        propertyOutputFormatter =
                    "Enter property {0}:"
        ;

        private const string
        propertyLeavingFormatter =
                    "Leave property {0}"
        ;

        private const string
        delegateHandlerOutputFormatter =
                    "Enter delegate handler: {0}:"
        ;

        private const string
        delegateHandlerLeavingFormatter =
                    "Leave delegate handler: {0}"
        ;

        private const string
        eventHandlerOutputFormatter =
                    "Enter event handler: {0}:"
        ;

        private const string
        eventHandlerLeavingFormatter =
                    "Leave event handler: {0}"
        ;

        private const string
        exceptionOutputFormatter =
                    "{0}: {1}\n{2}"
        ;

        private const string
        innermostExceptionOutputFormatter =
                    "Inner-most {0}: {1}\n{2}"
        ;

        private const string
        lockEnterFormatter =
                    "Enter Lock: {0}"
        ;

        private const string
        lockLeavingFormatter =
                    "Leave Lock: {0}"
        ;

        private const string
        lockAcquiringFormatter =
                    "Acquiring Lock: {0}"
        ;

        private static StringBuilder GetLinePrefix(PSTraceSourceOptions flag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1043, 43195, 43637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 43289, 43339);

                StringBuilder
                prefixBuilder = f_1043_43319_43338()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 43421, 43591);

                f_1043_43421_43590(
                            // Add the flag that caused this line to be traced

                            prefixBuilder, f_1043_43466_43492(), " {0,-11} ", f_1043_43541_43589(typeof(PSTraceSourceOptions), flag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 43605, 43626);

                return prefixBuilder;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1043, 43195, 43637);

                System.Text.StringBuilder
                f_1043_43319_43338()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 43319, 43338);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1043_43466_43492()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 43466, 43492);
                    return return_v;
                }


                string?
                f_1043_43541_43589(System.Type
                enumType, System.Management.Automation.PSTraceSourceOptions
                value)
                {
                    var return_v = Enum.GetName(enumType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 43541, 43589);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_43421_43590(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 43421, 43590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 43195, 43637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 43195, 43637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddTab(StringBuilder lineBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1043, 43649, 44116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 43890, 43924);

                int
                indentSize = f_1043_43907_43923()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 43938, 43980);

                int
                threadIndentLevel = f_1043_43962_43979()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 43996, 44105);

                f_1043_43996_44104(
                            lineBuilder, f_1043_44015_44103(indentSize * threadIndentLevel));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1043, 43649, 44116);

                int
                f_1043_43907_43923()
                {
                    var return_v = Trace.IndentSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 43907, 43923);
                    return return_v;
                }


                int
                f_1043_43962_43979()
                {
                    var return_v = ThreadIndentLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 43962, 43979);
                    return return_v;
                }


                string
                f_1043_44015_44103(int
                countOfSpaces)
                {
                    var return_v = System.Management.Automation.Internal.StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 44015, 44103);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_43996_44104(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 43996, 44104);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 43649, 44116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 43649, 44116);
            }
        }

        private bool _alreadyTracing;

        internal void OutputLine(
                    PSTraceSourceOptions flag,
                    string format,
                    string arg = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 44993, 46675);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 45297, 45372) || true) && (_alreadyTracing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 45297, 45372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 45350, 45357);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 45297, 45372);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 45388, 45411);

                _alreadyTracing = true;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 45461, 45579);

                    f_1043_45461_45578(format != null, "The format string should not be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 45599, 45647);

                    StringBuilder
                    lineBuilder = f_1043_45627_45646()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 45667, 45923) || true) && (f_1043_45671_45682())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 45667, 45923);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 45864, 45904);

                        f_1043_45864_45903(                    // Get the line prefix string which includes things
                                                               // like App name, clock tick, thread ID, etc.
                                            lineBuilder, f_1043_45883_45902(flag));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 45667, 45923);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 45993, 46013);

                    f_1043_45993_46012(lineBuilder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 46033, 46360) || true) && (arg != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 46033, 46360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 46090, 46232);

                        f_1043_46090_46231(lineBuilder, f_1043_46141_46167(), format, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 46033, 46360);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 46033, 46360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 46314, 46341);

                        f_1043_46314_46340(lineBuilder, format);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 46033, 46360);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 46380, 46438);

                    f_1043_46380_46437(f_1043_46380_46396(this), f_1043_46414_46436(lineBuilder));
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1043, 46467, 46664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 46625, 46649);

                    _alreadyTracing = false;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1043, 46467, 46664);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 44993, 46675);

                int
                f_1043_45461_45578(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 45461, 45578);
                    return 0;
                }


                System.Text.StringBuilder
                f_1043_45627_45646()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 45627, 45646);
                    return return_v;
                }


                bool
                f_1043_45671_45682()
                {
                    var return_v = ShowHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 45671, 45682);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_45883_45902(System.Management.Automation.PSTraceSourceOptions
                flag)
                {
                    var return_v = GetLinePrefix(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 45883, 45902);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_45864_45903(System.Text.StringBuilder
                this_param, System.Text.StringBuilder
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 45864, 45903);
                    return return_v;
                }


                int
                f_1043_45993_46012(System.Text.StringBuilder
                lineBuilder)
                {
                    AddTab(lineBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 45993, 46012);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1043_46141_46167()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 46141, 46167);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_46090_46231(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 46090, 46231);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_46314_46340(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 46314, 46340);
                    return return_v;
                }


                System.Diagnostics.TraceSource
                f_1043_46380_46396(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 46380, 46396);
                    return return_v;
                }


                string
                f_1043_46414_46436(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 46414, 46436);
                    return return_v;
                }


                int
                f_1043_46380_46437(System.Diagnostics.TraceSource
                this_param, string
                message)
                {
                    this_param.TraceInformation(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 46380, 46437);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 44993, 46675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 44993, 46675);
            }
        }

        internal static int ThreadIndentLevel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1043, 46870, 47132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 47085, 47117);

                    return f_1043_47092_47116(s_localIndentLevel);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1043, 46870, 47132);

                    int
                    f_1043_47092_47116(System.Threading.ThreadLocal<int>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 47092, 47116);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 46808, 47552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 46808, 47552);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1043, 47148, 47541);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 47184, 47526) || true) && (value >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 47184, 47526);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 47313, 47346);

                        s_localIndentLevel.Value = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 47184, 47526);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 47184, 47526);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 47428, 47507);

                        f_1043_47428_47506(value >= 0, "The indention value cannot be less than zero");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 47184, 47526);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1043, 47148, 47541);

                    int
                    f_1043_47428_47506(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 47428, 47506);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 46808, 47552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 46808, 47552);
                }
            }
        }

        private static readonly ThreadLocal<int> s_localIndentLevel;

        private PSTraceSourceOptions _flags;

        public string Description { get; set; }

        internal bool ShowHeaders { get; set; }

        internal string FullName { get; }

        private string _name;

        internal TraceSource TraceSource
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 48718, 48794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 48724, 48792);

                    return _traceSource ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Diagnostics.TraceSource>(1043, 48731, 48791) ?? (_traceSource = f_1043_48763_48790(_name)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 48718, 48794);

                    System.Management.Automation.MonadTraceSource
                    f_1043_48763_48790(string
                    name)
                    {
                        var return_v = new System.Management.Automation.MonadTraceSource(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 48763, 48790);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 48661, 48805);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 48661, 48805);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private TraceSource _traceSource;

        public PSTraceSourceOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 49124, 49146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 49130, 49144);

                    return _flags;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 49124, 49146);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 49064, 49310);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 49064, 49310);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 49162, 49299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 49198, 49213);

                    _flags = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 49231, 49284);

                    f_1043_49231_49254(f_1043_49231_49247(this)).Level = (SourceLevels)_flags;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 49162, 49299);

                    System.Diagnostics.TraceSource
                    f_1043_49231_49247(System.Management.Automation.PSTraceSource
                    this_param)
                    {
                        var return_v = this_param.TraceSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 49231, 49247);
                        return return_v;
                    }


                    System.Diagnostics.SourceSwitch
                    f_1043_49231_49254(System.Diagnostics.TraceSource
                    this_param)
                    {
                        var return_v = this_param.Switch;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 49231, 49254);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 49064, 49310);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 49064, 49310);
                }
            }
        }

        internal bool IsEnabled
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 49370, 49421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 49376, 49419);

                    return _flags != PSTraceSourceOptions.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 49370, 49421);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 49322, 49432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 49322, 49432);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public StringDictionary Attributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 49603, 49684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 49639, 49669);

                    return f_1043_49646_49668(f_1043_49646_49657());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 49603, 49684);

                    System.Diagnostics.TraceSource
                    f_1043_49646_49657()
                    {
                        var return_v = TraceSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 49646, 49657);
                        return return_v;
                    }


                    System.Collections.Specialized.StringDictionary
                    f_1043_49646_49668(System.Diagnostics.TraceSource
                    this_param)
                    {
                        var return_v = this_param.Attributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 49646, 49668);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 49544, 49695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 49544, 49695);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TraceListenerCollection Listeners
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 49872, 49952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 49908, 49937);

                    return f_1043_49915_49936(f_1043_49915_49926());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 49872, 49952);

                    System.Diagnostics.TraceSource
                    f_1043_49915_49926()
                    {
                        var return_v = TraceSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 49915, 49926);
                        return return_v;
                    }


                    System.Diagnostics.TraceListenerCollection
                    f_1043_49915_49936(System.Diagnostics.TraceSource
                    this_param)
                    {
                        var return_v = this_param.Listeners;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 49915, 49936);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 49807, 49963);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 49807, 49963);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 50294, 50358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 50330, 50343);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 50294, 50358);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 50251, 50369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 50251, 50369);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SourceSwitch Switch
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 50531, 50608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 50567, 50593);

                    return f_1043_50574_50592(f_1043_50574_50585());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 50531, 50608);

                    System.Diagnostics.TraceSource
                    f_1043_50574_50585()
                    {
                        var return_v = TraceSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 50574, 50585);
                        return return_v;
                    }


                    System.Diagnostics.SourceSwitch
                    f_1043_50574_50592(System.Diagnostics.TraceSource
                    this_param)
                    {
                        var return_v = this_param.Switch;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 50574, 50592);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 50480, 50713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 50480, 50713);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 50624, 50702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 50660, 50687);

                    f_1043_50660_50671().Switch = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 50624, 50702);

                    System.Diagnostics.TraceSource
                    f_1043_50660_50671()
                    {
                        var return_v = TraceSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 50660, 50671);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 50480, 50713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 50480, 50713);
                }
            }
        }

        internal static Dictionary<string, PSTraceSource> TraceCatalog { get; }

        internal static Dictionary<string, PSTraceSource> PreConfiguredTraceSource { get; }

        bool
        f_1043_8467_8497(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 8467, 8497);
            return return_v;
        }


        System.ArgumentNullException
        f_1043_8730_8767(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 8730, 8767);
            return return_v;
        }


        string?
        f_1043_9011_9063(string
        variable)
        {
            var return_v = Environment.GetEnvironmentVariable(variable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 9011, 9063);
            return return_v;
        }


        bool
        f_1043_9088_9236(string
        a, string
        b, System.StringComparison
        comparisonType)
        {
            var return_v = string.Equals(a, b, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 9088, 9236);
            return return_v;
        }


        System.Diagnostics.TraceSource
        f_1043_9295_9311(System.Management.Automation.PSTraceSource
        this_param)
        {
            var return_v = this_param.TraceSource;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 9295, 9311);
            return return_v;
        }


        System.Collections.Specialized.StringDictionary
        f_1043_9295_9322(System.Diagnostics.TraceSource
        this_param)
        {
            var return_v = this_param.Attributes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 9295, 9322);
            return return_v;
        }


        string
        f_1043_9295_9333(System.Collections.Specialized.StringDictionary
        this_param, string
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 9295, 9333);
            return return_v;
        }


        object
        f_1043_9456_9511(System.Type
        enumType, string
        value, bool
        ignoreCase)
        {
            var return_v = Enum.Parse(enumType, value, ignoreCase);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 9456, 9511);
            return return_v;
        }

    }
    internal class ScopeTracer : IDisposable
    {
        internal ScopeTracer(
                    PSTraceSource tracer,
                    PSTraceSourceOptions flag,
                    string scopeOutputFormatter,
                    string leavingScopeFormatter,
                    string scopeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1043, 53429, 53924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 59609, 59616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 59773, 59778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 59923, 59933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 60111, 60133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 53666, 53683);

                _tracer = tracer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 53733, 53913);

                f_1043_53733_53912(this, flag, scopeOutputFormatter, leavingScopeFormatter, scopeName, string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1043, 53429, 53924);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 53429, 53924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 53429, 53924);
            }
        }

        internal ScopeTracer(
                    PSTraceSource tracer,
                    PSTraceSourceOptions flag,
                    string scopeOutputFormatter,
                    string leavingScopeFormatter,
                    string scopeName,
                    string format,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1043, 55380, 56312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 59609, 59616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 59773, 59778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 59923, 59933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 60111, 60133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 55680, 55697);

                _tracer = tracer;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 55747, 56301) || true) && (format != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 55747, 56301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 55799, 56020);

                    f_1043_55799_56019(this, flag, scopeOutputFormatter, leavingScopeFormatter, scopeName, format, args);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 55747, 56301);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 55747, 56301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 56086, 56286);

                    f_1043_56086_56285(this, flag, scopeOutputFormatter, leavingScopeFormatter, scopeName, string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 55747, 56301);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1043, 55380, 56312);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 55380, 56312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 55380, 56312);
            }
        }

        internal void ScopeTracerHelper(
                    PSTraceSourceOptions flag,
                    string scopeOutputFormatter,
                    string leavingScopeFormatter,
                    string scopeName,
                    string format,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 57547, 58879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 57960, 57973);

                _flag = flag;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 57987, 58010);

                _scopeName = scopeName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 58024, 58071);

                _leavingScopeFormatter = leavingScopeFormatter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 58134, 58177);

                StringBuilder
                output = f_1043_58157_58176()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 58193, 58435) || true) && (!f_1043_58198_58240(scopeOutputFormatter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 58193, 58435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 58274, 58420);

                    f_1043_58274_58419(output, f_1043_58316_58342(), scopeOutputFormatter, _scopeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 58193, 58435);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 58451, 58659) || true) && (!f_1043_58456_58484(format))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 58451, 58659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 58518, 58644);

                    f_1043_58518_58643(output, f_1043_58560_58586(), format, args);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 58451, 58659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 58713, 58758);

                f_1043_58713_58757(
                            // Now write the trace

                            _tracer, _flag, f_1043_58739_58756(output));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 58834, 58868);

                f_1043_58834_58867_M(PSTraceSource.ThreadIndentLevel++);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 57547, 58879);

                System.Text.StringBuilder
                f_1043_58157_58176()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 58157, 58176);
                    return return_v;
                }


                bool
                f_1043_58198_58240(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 58198, 58240);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1043_58316_58342()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 58316, 58342);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_58274_58419(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 58274, 58419);
                    return return_v;
                }


                bool
                f_1043_58456_58484(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 58456, 58484);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1043_58560_58586()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 58560, 58586);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1043_58518_58643(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, params object[]
                args)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 58518, 58643);
                    return return_v;
                }


                string
                f_1043_58739_58756(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 58739, 58756);
                    return return_v;
                }


                int
                f_1043_58713_58757(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format)
                {
                    this_param.OutputLine(flag, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 58713, 58757);
                    return 0;
                }


                int
                f_1043_58834_58867_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 58834, 58867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 57547, 58879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 57547, 58879);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 59048, 59469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 59163, 59197);

                f_1043_59163_59196_M(PSTraceSource.ThreadIndentLevel--);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 59256, 59416) || true) && (!f_1043_59261_59305(_leavingScopeFormatter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1043, 59256, 59416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 59339, 59401);

                    f_1043_59339_59400(_tracer, _flag, _leavingScopeFormatter, _scopeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1043, 59256, 59416);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 59432, 59458);

                f_1043_59432_59457(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 59048, 59469);

                int
                f_1043_59163_59196_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1043, 59163, 59196);
                    return return_v;
                }


                bool
                f_1043_59261_59305(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 59261, 59305);
                    return return_v;
                }


                int
                f_1043_59339_59400(System.Management.Automation.PSTraceSource
                this_param, System.Management.Automation.PSTraceSourceOptions
                flag, string
                format, string
                arg)
                {
                    this_param.OutputLine(flag, format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 59339, 59400);
                    return 0;
                }


                int
                f_1043_59432_59457(System.Management.Automation.ScopeTracer
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 59432, 59457);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 59048, 59469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 59048, 59469);
            }
        }

        private PSTraceSource _tracer;

        private PSTraceSourceOptions _flag;

        private string _scopeName;

        private string _leavingScopeFormatter;

        static ScopeTracer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1043, 52201, 60141);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1043, 52201, 60141);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 52201, 60141);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1043, 52201, 60141);

        int
        f_1043_53733_53912(System.Management.Automation.ScopeTracer
        this_param, System.Management.Automation.PSTraceSourceOptions
        flag, string
        scopeOutputFormatter, string
        leavingScopeFormatter, string
        scopeName, string
        format, params object[]
        args)
        {
            this_param.ScopeTracerHelper(flag, scopeOutputFormatter, leavingScopeFormatter, scopeName, format, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 53733, 53912);
            return 0;
        }


        int
        f_1043_55799_56019(System.Management.Automation.ScopeTracer
        this_param, System.Management.Automation.PSTraceSourceOptions
        flag, string
        scopeOutputFormatter, string
        leavingScopeFormatter, string
        scopeName, string
        format, params object[]
        args)
        {
            this_param.ScopeTracerHelper(flag, scopeOutputFormatter, leavingScopeFormatter, scopeName, format, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 55799, 56019);
            return 0;
        }


        int
        f_1043_56086_56285(System.Management.Automation.ScopeTracer
        this_param, System.Management.Automation.PSTraceSourceOptions
        flag, string
        scopeOutputFormatter, string
        leavingScopeFormatter, string
        scopeName, string
        format, params object[]
        args)
        {
            this_param.ScopeTracerHelper(flag, scopeOutputFormatter, leavingScopeFormatter, scopeName, format, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 56086, 56285);
            return 0;
        }

    }
    [AttributeUsage(
             AttributeTargets.Field,
             AllowMultiple = false)]
    internal class TraceSourceAttribute : Attribute
    {
        internal TraceSourceAttribute(
                    string category,
                    string description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1043, 61827, 62016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 62133, 62166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 62303, 62344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 61945, 61965);

                Category = category;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 61979, 62005);

                Description = description;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1043, 61827, 62016);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 61827, 62016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 61827, 62016);
            }
        }

        internal string Category { get; }

        internal string Description { get; set; }

        static TraceSourceAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1043, 61299, 62351);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1043, 61299, 62351);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 61299, 62351);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1043, 61299, 62351);
    }
    internal class MonadTraceSource : TraceSource
    {
        internal MonadTraceSource(string name)
        : base(f_1043_62794_62798_C(name))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1043, 62735, 62821);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1043, 62735, 62821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 62735, 62821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 62735, 62821);
            }
        }

        protected override string[] GetSupportedAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1043, 63142, 63264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 63219, 63253);

                return new string[] { "Options" };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1043, 63142, 63264);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1043, 63142, 63264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 63142, 63264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MonadTraceSource()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1043, 62673, 63271);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1043, 62673, 63271);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1043, 62673, 63271);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1043, 62673, 63271);

        static string
        f_1043_62794_62798_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1043, 62735, 62821);
            return return_v;
        }

    }
}

