// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691

using System.Diagnostics;
using System.IO;
using System.ComponentModel;
using System.Text;
using System.Collections;
using System.Threading;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Xml;
using System.Runtime.InteropServices;
using Dbg = System.Management.Automation.Diagnostics;
using System.Runtime.Serialization;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace System.Management.Automation
{
    /// <summary>
    /// Various types of input/output supported by native commands.
    /// </summary>
    /// <remarks>
    /// Most native commands only support text. Other formats
    /// are supported by minishell
    /// </remarks>
    internal enum NativeCommandIOFormat
    {
        Text,
        Xml
    };

    /// <summary>
    /// Different streams produced by minishell output.
    /// </summary>
    internal enum MinishellStream
    {
        Output,
        Error,
        Verbose,
        Warning,
        Debug,
        Progress,
        Information,
        Unknown
    }
    internal static class StringToMinishellStreamConverter
    {
        internal const string
        OutputStream = "output"
        ;

        internal const string
        ErrorStream = "error"
        ;

        internal const string
        DebugStream = "debug"
        ;

        internal const string
        VerboseStream = "verbose"
        ;

        internal const string
        WarningStream = "warning"
        ;

        internal const string
        ProgressStream = "progress"
        ;

        internal const string
        InformationStream = "information"
        ;

        internal static MinishellStream ToMinishellStream(string stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1301, 1951, 3355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 2040, 2107);

                f_1301_2040_2106(stream != null, "caller should validate the parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 2123, 2168);

                MinishellStream
                ms = MinishellStream.Unknown
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 2182, 3318) || true) && (f_1301_2186_2249(OutputStream, stream, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 2182, 3318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 2283, 2311);

                    ms = MinishellStream.Output;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 2182, 3318);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 2182, 3318);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 2345, 3318) || true) && (f_1301_2349_2411(ErrorStream, stream, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 2345, 3318);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 2445, 2472);

                        ms = MinishellStream.Error;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 2345, 3318);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 2345, 3318);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 2506, 3318) || true) && (f_1301_2510_2572(DebugStream, stream, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 2506, 3318);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 2606, 2633);

                            ms = MinishellStream.Debug;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 2506, 3318);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 2506, 3318);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 2667, 3318) || true) && (f_1301_2671_2735(VerboseStream, stream, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 2667, 3318);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 2769, 2798);

                                ms = MinishellStream.Verbose;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 2667, 3318);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 2667, 3318);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 2832, 3318) || true) && (f_1301_2836_2900(WarningStream, stream, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 2832, 3318);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 2934, 2963);

                                    ms = MinishellStream.Warning;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 2832, 3318);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 2832, 3318);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 2997, 3318) || true) && (f_1301_3001_3066(ProgressStream, stream, StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 2997, 3318);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 3100, 3130);

                                        ms = MinishellStream.Progress;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 2997, 3318);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 2997, 3318);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 3164, 3318) || true) && (f_1301_3168_3236(InformationStream, stream, StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 3164, 3318);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 3270, 3303);

                                            ms = MinishellStream.Information;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 3164, 3318);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 2997, 3318);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 2832, 3318);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 2667, 3318);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 2506, 3318);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 2345, 3318);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 2182, 3318);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 3334, 3344);

                return ms;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1301, 1951, 3355);

                int
                f_1301_2040_2106(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 2040, 2106);
                    return 0;
                }


                bool
                f_1301_2186_2249(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 2186, 2249);
                    return return_v;
                }


                bool
                f_1301_2349_2411(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 2349, 2411);
                    return return_v;
                }


                bool
                f_1301_2510_2572(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 2510, 2572);
                    return return_v;
                }


                bool
                f_1301_2671_2735(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 2671, 2735);
                    return return_v;
                }


                bool
                f_1301_2836_2900(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 2836, 2900);
                    return return_v;
                }


                bool
                f_1301_3001_3066(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 3001, 3066);
                    return return_v;
                }


                bool
                f_1301_3168_3236(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 3168, 3236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 1951, 3355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 1951, 3355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StringToMinishellStreamConverter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1301, 1472, 3362);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 1565, 1588);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 1621, 1642);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 1675, 1696);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 1729, 1754);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 1787, 1812);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 1845, 1872);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 1905, 1938);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1301, 1472, 3362);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 1472, 3362);
        }

    }
    internal class ProcessOutputObject
    {
        internal object Data { get; }

        internal MinishellStream Stream { get; }

        internal ProcessOutputObject(object data, MinishellStream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1301, 4098, 4241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 3699, 3728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 3830, 3870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 4188, 4200);

                Data = data;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 4214, 4230);

                Stream = stream;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1301, 4098, 4241);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 4098, 4241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 4098, 4241);
            }
        }

        static ProcessOutputObject()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1301, 3520, 4248);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1301, 3520, 4248);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 3520, 4248);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1301, 3520, 4248);
    }
    internal class NativeCommandProcessor : CommandProcessorBase
    {
        private ApplicationInfo _applicationInfo;

        internal NativeCommandProcessor(ApplicationInfo applicationInfo, ExecutionContext context)
        : base(f_1301_5335_5350_C(applicationInfo))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1301, 5224, 6458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 4671, 4687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 7803, 7828);
                this._isPreparedCalled = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 7997, 8029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 11316, 11330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 11477, 11496);
                this._inputWriter = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 11677, 11691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 12039, 12061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 12301, 12329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 12682, 12707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 12793, 12808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 13042, 13062);
                this._sync = f_1301_13050_13062();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 38139, 38155);
                this._stopped = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 58016, 58036);
                this._isMiniShell = false;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 5376, 5516) || true) && (applicationInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 5376, 5516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 5437, 5501);

                    throw f_1301_5443_5500("applicationInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 5376, 5516);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 5532, 5567);

                _applicationInfo = applicationInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 5581, 5605);

                this._context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 5621, 5656);

                this.Command = f_1301_5636_5655();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 5670, 5713);

                f_1301_5670_5682(this).CommandInfo = applicationInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 5727, 5758);

                f_1301_5727_5739(this).Context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 5772, 5886);

                f_1301_5772_5784(this).commandRuntime = this.commandRuntime = f_1301_5824_5885(context, applicationInfo, f_1301_5872_5884(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 5902, 5962);

                this.CommandScope = f_1301_5922_5961(f_1301_5922_5948(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 6168, 6219);

                ((NativeCommand)f_1301_6184_6191()).MyCommandProcessor = this;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 6307, 6354);

                _inputWriter = f_1301_6322_6353(f_1301_6345_6352());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 6370, 6447);

                _isTranscribing = f_1301_6388_6446(f_1301_6388_6431(f_1301_6388_6428(f_1301_6388_6408(f_1301_6388_6400(this)))));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1301, 5224, 6458);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 5224, 6458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 5224, 6458);
            }
        }

        private NativeCommand nativeCommand
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 6653, 6892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 6689, 6743);

                    NativeCommand
                    command = f_1301_6713_6725(this) as NativeCommand
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 6761, 6844);

                    f_1301_6761_6843(command != null, "this.Command is created in the constructor.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 6862, 6877);

                    return command;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 6653, 6892);

                    System.Management.Automation.Internal.InternalCommand
                    f_1301_6713_6725(System.Management.Automation.NativeCommandProcessor
                    this_param)
                    {
                        var return_v = this_param.Command;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 6713, 6725);
                        return return_v;
                    }


                    int
                    f_1301_6761_6843(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 6761, 6843);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 6593, 6903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 6593, 6903);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string NativeCommandName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 7077, 7194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 7113, 7149);

                    string
                    name = f_1301_7127_7148(_applicationInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 7167, 7179);

                    return name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 7077, 7194);

                    string
                    f_1301_7127_7148(System.Management.Automation.ApplicationInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 7127, 7148);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 7020, 7205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 7020, 7205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string Path
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 7362, 7479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 7398, 7434);

                    string
                    path = f_1301_7412_7433(_applicationInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 7452, 7464);

                    return path;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 7362, 7479);

                    string
                    f_1301_7412_7433(System.Management.Automation.ApplicationInfo
                    this_param)
                    {
                        var return_v = this_param.Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 7412, 7433);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 7318, 7490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 7318, 7490);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _isPreparedCalled;

        private NativeCommandParameterBinderController _nativeParameterBinderController;

        internal ParameterBinderController NewParameterBinderController(InternalCommand command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 8413, 9124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 8526, 8624);

                f_1301_8526_8623(_isPreparedCalled, "parameter binder should not be created before prepared is called");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 8640, 9057) || true) && (_isMiniShell)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 8640, 9057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 8690, 8831);

                    _nativeParameterBinderController =
                    f_1301_8746_8830(f_1301_8811_8829(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 8640, 9057);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 8640, 9057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 8897, 9042);

                    _nativeParameterBinderController =
                    f_1301_8953_9041(f_1301_9022_9040(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 8640, 9057);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 9073, 9113);

                return _nativeParameterBinderController;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 8413, 9124);

                int
                f_1301_8526_8623(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 8526, 8623);
                    return 0;
                }


                System.Management.Automation.NativeCommand
                f_1301_8811_8829(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.nativeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 8811, 8829);
                    return return_v;
                }


                System.Management.Automation.MinishellParameterBinderController
                f_1301_8746_8830(System.Management.Automation.NativeCommand
                command)
                {
                    var return_v = new System.Management.Automation.MinishellParameterBinderController(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 8746, 8830);
                    return return_v;
                }


                System.Management.Automation.NativeCommand
                f_1301_9022_9040(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.nativeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 9022, 9040);
                    return return_v;
                }


                System.Management.Automation.NativeCommandParameterBinderController
                f_1301_8953_9041(System.Management.Automation.NativeCommand
                command)
                {
                    var return_v = new System.Management.Automation.NativeCommandParameterBinderController(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 8953, 9041);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 8413, 9124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 8413, 9124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NativeCommandParameterBinderController NativeParameterBinderController
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 9240, 9499);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 9276, 9424) || true) && (_nativeParameterBinderController == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 9276, 9424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 9362, 9405);

                        f_1301_9362_9404(this, f_1301_9391_9403(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 9276, 9424);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 9444, 9484);

                    return _nativeParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 9240, 9499);

                    System.Management.Automation.Internal.InternalCommand
                    f_1301_9391_9403(System.Management.Automation.NativeCommandProcessor
                    this_param)
                    {
                        var return_v = this_param.Command;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 9391, 9403);
                        return return_v;
                    }


                    System.Management.Automation.ParameterBinderController
                    f_1301_9362_9404(System.Management.Automation.NativeCommandProcessor
                    this_param, System.Management.Automation.Internal.InternalCommand
                    command)
                    {
                        var return_v = this_param.NewParameterBinderController(command);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 9362, 9404);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 9136, 9510);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 9136, 9510);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void Prepare(IDictionary psDefaultParameterValues)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 9739, 10534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 9832, 9857);

                _isPreparedCalled = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 9927, 9956);

                _isMiniShell = f_1301_9942_9955(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 10142, 10271) || true) && (!_isMiniShell)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 10142, 10271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 10193, 10256);

                    f_1301_10193_10255(f_1301_10193_10229(this), arguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 10142, 10271);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 10323, 10343);

                    f_1301_10323_10342(this);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 10372, 10523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 10474, 10484);

                    f_1301_10474_10483(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 10502, 10508);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 10372, 10523);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 9739, 10534);

                bool
                f_1301_9942_9955(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.IsMiniShell();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 9942, 9955);
                    return return_v;
                }


                System.Management.Automation.NativeCommandParameterBinderController
                f_1301_10193_10229(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.NativeParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 10193, 10229);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1301_10193_10255(System.Management.Automation.NativeCommandParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                parameters)
                {
                    var return_v = this_param.BindParameters(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 10193, 10255);
                    return return_v;
                }


                int
                f_1301_10323_10342(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    this_param.InitNativeProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 10323, 10342);
                    return 0;
                }


                int
                f_1301_10474_10483(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    this_param.CleanUp();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 10474, 10483);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 9739, 10534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 9739, 10534);
            }
        }

        internal override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 10680, 11165);
                try
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 10779, 10901) || true) && (f_1301_10786_10792(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 10779, 10901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 10834, 10882);

                            f_1301_10834_10881(_inputWriter, f_1301_10851_10880(f_1301_10851_10858()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 10779, 10901);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1301, 10779, 10901);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1301, 10779, 10901);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 10921, 10974);

                    f_1301_10921_10973(this, blocking: false);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 11003, 11154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 11105, 11115);

                    f_1301_11105_11114(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 11133, 11139);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 11003, 11154);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 10680, 11165);

                bool
                f_1301_10786_10792(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Read();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 10786, 10792);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_10851_10858()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 10851, 10858);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1301_10851_10880(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.CurrentPipelineObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 10851, 10880);
                    return return_v;
                }


                int
                f_1301_10834_10881(System.Management.Automation.ProcessInputWriter
                this_param, System.Management.Automation.PSObject
                input)
                {
                    this_param.Add((object)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 10834, 10881);
                    return 0;
                }


                int
                f_1301_10921_10973(System.Management.Automation.NativeCommandProcessor
                this_param, bool
                blocking)
                {
                    this_param.ConsumeAvailableNativeProcessOutput(blocking: blocking);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 10921, 10973);
                    return 0;
                }


                int
                f_1301_11105_11114(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    this_param.CleanUp();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 11105, 11114);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 10680, 11165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 10680, 11165);
            }
        }

        private System.Diagnostics.Process _nativeProcess;

        private ProcessInputWriter _inputWriter;

        private bool _runStandAlone;

        private bool _isRunningInBackground;

        private bool _hasNotifiedBeginApplication;

        private BlockingCollection<ProcessOutputObject> _nativeProcessOutputQueue;

        private static bool? s_supportScreenScrape;

        private bool _isTranscribing;

        private Host.Coordinates _startPosition;

        private object _sync;

        private void InitNativeProcess()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 13459, 23115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 13860, 13880);

                bool
                redirectOutput
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 13894, 13913);

                bool
                redirectError
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 13927, 13946);

                bool
                redirectInput
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 13962, 14002);

                _startPosition = f_1301_13979_14001();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 14018, 14099);

                f_1301_14018_14098(this, out redirectOutput, out redirectError, out redirectInput);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 14182, 14247);

                bool
                soloCommand = f_1301_14201_14241(f_1301_14201_14226(f_1301_14201_14213(this))) == 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 14315, 14423);

                ProcessStartInfo
                startInfo = f_1301_14344_14422(this, redirectOutput, redirectError, redirectInput, soloCommand)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 14450, 14500);

                string
                commandPath = f_1301_14471_14499(f_1301_14471_14480(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 14514, 15049) || true) && (f_1301_14518_14556(commandPath, "powershell.exe") || (DynAbs.Tracing.TraceSender.Expression_False(1301, 14518, 14602) || f_1301_14560_14602(commandPath, "powershell_ise.exe")))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 14514, 15049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 14748, 14820);

                    string
                    psmodulepath = f_1301_14770_14819()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 14838, 14891);

                    f_1301_14838_14859(startInfo)["PSModulePath"] = psmodulepath;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 15000, 15034);

                    startInfo.UseShellExecute = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 14514, 15049);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 15073, 15207) || true) && (f_1301_15077_15121(f_1301_15077_15097(f_1301_15077_15089(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 15073, 15207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 15155, 15192);

                    throw f_1301_15161_15191();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 15073, 15207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 15223, 15259);

                Exception
                exceptionToRethrow = null
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 15533, 16162) || true) && (_runStandAlone)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 15533, 16162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 15593, 15659);

                        f_1301_15593_15658(f_1301_15593_15633(f_1301_15593_15613(f_1301_15593_15605(this))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 15681, 15717);

                        _hasNotifiedBeginApplication = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 15887, 16143) || true) && (_isTranscribing && (DynAbs.Tracing.TraceSender.Expression_True(1301, 15891, 15941) && (true == s_supportScreenScrape)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 15887, 16143);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 15991, 16073);

                            _startPosition = f_1301_16008_16072(f_1301_16008_16057(f_1301_16008_16051(f_1301_16008_16048(f_1301_16008_16028(f_1301_16008_16020(this))))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 16099, 16120);

                            _startPosition.X = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 15887, 16143);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 15533, 16162);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 16633, 16638);

                    // Start the process. If stop has been called, throw exception.
                    // Note: if StopProcessing is called which this method has the lock,
                    // Stop thread will wait for nativeProcess to start.
                    // If StopProcessing gets the lock first, then it will set the stopped
                    // flag and this method will throw PipelineStoppedException when it gets
                    // the lock.
                    lock (_sync)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 16680, 16802) || true) && (_stopped)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 16680, 16802);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 16742, 16779);

                            throw f_1301_16748_16778();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 16680, 16802);
                        }

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 16878, 16935);

                            _nativeProcess = new Process() { StartInfo = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => startInfo, 1301, 16895, 16934) };
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 16961, 16984);

                            f_1301_16961_16983(_nativeProcess);
                        }
                        catch (Win32Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 17029, 19897);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 17293, 17335) || true) && (f_1301_17297_17323_M(!Platform.IsWindowsDesktop))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 17293, 17335);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 17327, 17333);

                                throw;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 17293, 17335);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 17492, 17547);

                            string
                            executable = f_1301_17512_17546(f_1301_17527_17545(startInfo))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 17573, 17593);

                            bool
                            notDone = true
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 17619, 18880) || true) && (!f_1301_17624_17656(executable))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 17619, 18880);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 17714, 17983) || true) && (f_1301_17718_17750(executable))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 17714, 17983);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 17910, 17952);

                                    f_1301_17910_17951();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 17714, 17983);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 18015, 18057);

                                string
                                oldArguments = f_1301_18037_18056(startInfo)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 18087, 18127);

                                string
                                oldFileName = f_1301_18108_18126(startInfo)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 18157, 18235);

                                startInfo.Arguments = "\"" + f_1301_18186_18204(startInfo) + "\" " + f_1301_18215_18234(startInfo);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 18265, 18297);

                                startInfo.FileName = executable;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 18395, 18418);

                                    f_1301_18395_18417(_nativeProcess);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 18452, 18468);

                                    notDone = false;
                                }
                                catch (Win32Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 18529, 18853);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 18720, 18755);

                                    startInfo.Arguments = oldArguments;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 18789, 18822);

                                    startInfo.FileName = oldFileName;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 18529, 18853);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 17619, 18880);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 19179, 19874) || true) && (notDone)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 19179, 19874);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 19248, 19847) || true) && (soloCommand && (DynAbs.Tracing.TraceSender.Expression_True(1301, 19252, 19301) && f_1301_19267_19292(startInfo) == false))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 19248, 19847);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 19367, 19400);

                                    startInfo.UseShellExecute = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 19434, 19474);

                                    startInfo.RedirectStandardInput = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 19508, 19549);

                                    startInfo.RedirectStandardOutput = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 19583, 19623);

                                    startInfo.RedirectStandardError = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 19657, 19680);

                                    f_1301_19657_19679(_nativeProcess);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 19248, 19847);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 19248, 19847);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 19810, 19816);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 19248, 19847);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 19179, 19874);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 17029, 19897);
                        }
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 19936, 20688) || true) && (f_1301_19940_19982(f_1301_19940_19965(f_1301_19940_19952(this))) < f_1301_19985_20025(f_1301_19985_20010(f_1301_19985_19997(this))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 19936, 20688);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 20312, 20343);

                        _isRunningInBackground = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 19936, 20688);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 19936, 20688);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 20425, 20455);

                        _isRunningInBackground = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 20477, 20669) || true) && (f_1301_20481_20506(startInfo) == false)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 20477, 20669);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 20565, 20646);

                            _isRunningInBackground = f_1301_20590_20645(f_1301_20611_20644(f_1301_20611_20635(_nativeProcess)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 20477, 20669);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 19936, 20688);
                    }

                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 20824, 21500) || true) && (f_1301_20828_20859(startInfo))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 20824, 21500);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 20909, 20972);

                            NativeCommandIOFormat
                            inputFormat = NativeCommandIOFormat.Text
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 20998, 21195) || true) && (_isMiniShell)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 20998, 21195);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 21072, 21168);

                                inputFormat = f_1301_21086_21167(((MinishellParameterBinderController)f_1301_21123_21154()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 20998, 21195);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 21229, 21234);

                            lock (_sync)
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 21292, 21450) || true) && (!_stopped)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 21292, 21450);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 21371, 21419);

                                    f_1301_21371_21418(_inputWriter, _nativeProcess, inputFormat);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 21292, 21450);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 20824, 21500);
                        }
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 21537, 21659);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 21595, 21612);

                        f_1301_21595_21611(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 21634, 21640);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 21537, 21659);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 21679, 21793) || true) && (_isRunningInBackground == false)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 21679, 21793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 21756, 21774);

                        f_1301_21756_21773(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 21679, 21793);
                    }
                }
                catch (Win32Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 21822, 21917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 21879, 21902);

                    exceptionToRethrow = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 21822, 21917);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 21931, 22099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 22078, 22084);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 21931, 22099);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 22113, 22203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 22165, 22188);

                    exceptionToRethrow = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 22113, 22203);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 22342, 23104) || true) && (exceptionToRethrow != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 22342, 23104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 22490, 22700);

                    string
                    message = f_1301_22507_22699(f_1301_22525_22561(), f_1301_22584_22606(this), f_1301_22608_22634(exceptionToRethrow), f_1301_22657_22698(f_1301_22657_22682(f_1301_22657_22669(this))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 22718, 22826);

                    ApplicationFailedException
                    appFailedException = f_1301_22766_22825(message, exceptionToRethrow)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 23064, 23089);

                    throw appFailedException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 22342, 23104);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 13459, 23115);

                System.Management.Automation.Host.Coordinates
                f_1301_13979_14001()
                {
                    var return_v = new System.Management.Automation.Host.Coordinates();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 13979, 14001);
                    return return_v;
                }


                int
                f_1301_14018_14098(System.Management.Automation.NativeCommandProcessor
                this_param, out bool
                redirectOutput, out bool
                redirectError, out bool
                redirectInput)
                {
                    this_param.CalculateIORedirection(out redirectOutput, out redirectError, out redirectInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 14018, 14098);
                    return 0;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_14201_14213(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 14201, 14213);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1301_14201_14226(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 14201, 14226);
                    return return_v;
                }


                int
                f_1301_14201_14241(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 14201, 14241);
                    return return_v;
                }


                System.Diagnostics.ProcessStartInfo
                f_1301_14344_14422(System.Management.Automation.NativeCommandProcessor
                this_param, bool
                redirectOutput, bool
                redirectError, bool
                redirectInput, bool
                soloCommand)
                {
                    var return_v = this_param.GetProcessStartInfo(redirectOutput, redirectError, redirectInput, soloCommand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 14344, 14422);
                    return return_v;
                }


                string
                f_1301_14471_14480(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 14471, 14480);
                    return return_v;
                }


                string
                f_1301_14471_14499(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 14471, 14499);
                    return return_v;
                }


                bool
                f_1301_14518_14556(string
                this_param, string
                value)
                {
                    var return_v = this_param.EndsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 14518, 14556);
                    return return_v;
                }


                bool
                f_1301_14560_14602(string
                this_param, string
                value)
                {
                    var return_v = this_param.EndsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 14560, 14602);
                    return return_v;
                }


                string
                f_1301_14770_14819()
                {
                    var return_v = ModuleIntrinsics.GetWindowsPowerShellModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 14770, 14819);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, string>
                f_1301_14838_14859(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.Environment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 14838, 14859);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_15077_15089(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 15077, 15089);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_15077_15097(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 15077, 15097);
                    return return_v;
                }


                bool
                f_1301_15077_15121(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 15077, 15121);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1301_15161_15191()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 15161, 15191);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_15593_15605(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 15593, 15605);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_15593_15613(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 15593, 15613);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1301_15593_15633(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 15593, 15633);
                    return return_v;
                }


                int
                f_1301_15593_15658(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    this_param.NotifyBeginApplication();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 15593, 15658);
                    return 0;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_16008_16020(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 16008, 16020);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_16008_16028(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 16008, 16028);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1301_16008_16048(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 16008, 16048);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1301_16008_16051(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 16008, 16051);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostRawUserInterface
                f_1301_16008_16057(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.RawUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 16008, 16057);
                    return return_v;
                }


                System.Management.Automation.Host.Coordinates
                f_1301_16008_16072(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 16008, 16072);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1301_16748_16778()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 16748, 16778);
                    return return_v;
                }


                bool
                f_1301_16961_16983(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 16961, 16983);
                    return return_v;
                }


                bool
                f_1301_17297_17323_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 17297, 17323);
                    return return_v;
                }


                string
                f_1301_17527_17545(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 17527, 17545);
                    return return_v;
                }


                string
                f_1301_17512_17546(string
                filename)
                {
                    var return_v = FindExecutable(filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 17512, 17546);
                    return return_v;
                }


                bool
                f_1301_17624_17656(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 17624, 17656);
                    return return_v;
                }


                bool
                f_1301_17718_17750(string
                fileName)
                {
                    var return_v = IsConsoleApplication(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 17718, 17750);
                    return return_v;
                }


                bool
                f_1301_17910_17951()
                {
                    var return_v = ConsoleVisibility.AllocateHiddenConsole();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 17910, 17951);
                    return return_v;
                }


                string
                f_1301_18037_18056(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 18037, 18056);
                    return return_v;
                }


                string
                f_1301_18108_18126(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 18108, 18126);
                    return return_v;
                }


                string
                f_1301_18186_18204(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 18186, 18204);
                    return return_v;
                }


                string
                f_1301_18215_18234(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 18215, 18234);
                    return return_v;
                }


                bool
                f_1301_18395_18417(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 18395, 18417);
                    return return_v;
                }


                bool
                f_1301_19267_19292(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.UseShellExecute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 19267, 19292);
                    return return_v;
                }


                bool
                f_1301_19657_19679(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 19657, 19679);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_19940_19952(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 19940, 19952);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1301_19940_19965(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 19940, 19965);
                    return return_v;
                }


                int
                f_1301_19940_19982(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelinePosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 19940, 19982);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_19985_19997(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 19985, 19997);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1301_19985_20010(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 19985, 20010);
                    return return_v;
                }


                int
                f_1301_19985_20025(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 19985, 20025);
                    return return_v;
                }


                bool
                f_1301_20481_20506(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.UseShellExecute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 20481, 20506);
                    return return_v;
                }


                System.Diagnostics.ProcessStartInfo
                f_1301_20611_20635(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StartInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 20611, 20635);
                    return return_v;
                }


                string
                f_1301_20611_20644(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 20611, 20644);
                    return return_v;
                }


                bool
                f_1301_20590_20645(string
                fileName)
                {
                    var return_v = IsWindowsApplication(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 20590, 20645);
                    return return_v;
                }


                bool
                f_1301_20828_20859(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.RedirectStandardInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 20828, 20859);
                    return return_v;
                }


                System.Management.Automation.NativeCommandParameterBinderController
                f_1301_21123_21154()
                {
                    var return_v = NativeParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 21123, 21154);
                    return return_v;
                }


                System.Management.Automation.NativeCommandIOFormat
                f_1301_21086_21167(System.Management.Automation.MinishellParameterBinderController
                this_param)
                {
                    var return_v = this_param.InputFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 21086, 21167);
                    return return_v;
                }


                int
                f_1301_21371_21418(System.Management.Automation.ProcessInputWriter
                this_param, System.Diagnostics.Process
                process, System.Management.Automation.NativeCommandIOFormat
                inputFormat)
                {
                    this_param.Start(process, inputFormat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 21371, 21418);
                    return 0;
                }


                int
                f_1301_21595_21611(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    this_param.StopProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 21595, 21611);
                    return 0;
                }


                int
                f_1301_21756_21773(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    this_param.InitOutputQueue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 21756, 21773);
                    return 0;
                }


                string
                f_1301_22525_22561()
                {
                    var return_v = ParserStrings.ProgramFailedToExecute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 22525, 22561);
                    return return_v;
                }


                string
                f_1301_22584_22606(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.NativeCommandName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 22584, 22606);
                    return return_v;
                }


                string
                f_1301_22608_22634(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 22608, 22634);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_22657_22669(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 22657, 22669);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1301_22657_22682(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 22657, 22682);
                    return return_v;
                }


                string
                f_1301_22657_22698(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PositionMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 22657, 22698);
                    return return_v;
                }


                string
                f_1301_22507_22699(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 22507, 22699);
                    return return_v;
                }


                System.Management.Automation.ApplicationFailedException
                f_1301_22766_22825(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.ApplicationFailedException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 22766, 22825);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 13459, 23115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 13459, 23115);
            }
        }

        private void InitOutputQueue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 23127, 23867);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 23265, 23856) || true) && (f_1301_23269_23316(f_1301_23269_23293(_nativeProcess)) || (DynAbs.Tracing.TraceSender.Expression_False(1301, 23269, 23366) || f_1301_23320_23366(f_1301_23320_23344(_nativeProcess))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 23265, 23856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 23406, 23411);
                    lock (_sync)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 23453, 23822) || true) && (!_stopped)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 23453, 23822);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 23516, 23590);

                            _nativeProcessOutputQueue = f_1301_23544_23589();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 23731, 23799);

                            f_1301_23731_23798(_nativeProcess, _nativeProcessOutputQueue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 23453, 23822);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 23265, 23856);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 23127, 23867);

                System.Diagnostics.ProcessStartInfo
                f_1301_23269_23293(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StartInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 23269, 23293);
                    return return_v;
                }


                bool
                f_1301_23269_23316(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.RedirectStandardOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 23269, 23316);
                    return return_v;
                }


                System.Diagnostics.ProcessStartInfo
                f_1301_23320_23344(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StartInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 23320, 23344);
                    return return_v;
                }


                bool
                f_1301_23320_23366(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.RedirectStandardError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 23320, 23366);
                    return return_v;
                }


                System.Collections.Concurrent.BlockingCollection<System.Management.Automation.ProcessOutputObject>
                f_1301_23544_23589()
                {
                    var return_v = new System.Collections.Concurrent.BlockingCollection<System.Management.Automation.ProcessOutputObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 23544, 23589);
                    return return_v;
                }


                System.Management.Automation.ProcessOutputHandler
                f_1301_23731_23798(System.Diagnostics.Process
                process, System.Collections.Concurrent.BlockingCollection<System.Management.Automation.ProcessOutputObject>
                queue)
                {
                    var return_v = new System.Management.Automation.ProcessOutputHandler(process, queue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 23731, 23798);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 23127, 23867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 23127, 23867);
            }
        }

        private ProcessOutputObject DequeueProcessOutput(bool blocking)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 23879, 25287);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 23967, 25276) || true) && (blocking)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 23967, 25276);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 24188, 25033) || true) && (f_1301_24192_24230_M(!_nativeProcessOutputQueue.IsCompleted))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 24188, 25033);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 24483, 24523);

                            return f_1301_24490_24522(_nativeProcessOutputQueue);
                        }
                        catch (InvalidOperationException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 24568, 25014);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 24568, 25014);
                            // It's a normal situation: another thread can mark collection as CompleteAdding
                            // in a concurrent way and we will rise an exception in Take().
                            // Although it's a normal situation it's not the most common path
                            // and will be executed only on the race condtion case.
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 24188, 25033);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 25053, 25065);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 23967, 25276);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 23967, 25276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 25131, 25165);

                    ProcessOutputObject
                    record = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 25183, 25229);

                    f_1301_25183_25228(_nativeProcessOutputQueue, out record);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 25247, 25261);

                    return record;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 23967, 25276);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 23879, 25287);

                bool
                f_1301_24192_24230_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 24192, 24230);
                    return return_v;
                }


                System.Management.Automation.ProcessOutputObject
                f_1301_24490_24522(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.ProcessOutputObject>
                this_param)
                {
                    var return_v = this_param.Take();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 24490, 24522);
                    return return_v;
                }


                bool
                f_1301_25183_25228(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.ProcessOutputObject>
                this_param, out System.Management.Automation.ProcessOutputObject
                item)
                {
                    var return_v = this_param.TryTake(out item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 25183, 25228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 23879, 25287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 23879, 25287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ConsumeAvailableNativeProcessOutput(bool blocking)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 25426, 26197);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 25514, 26186) || true) && (_isRunningInBackground == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 25514, 26186);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 25583, 26171) || true) && (f_1301_25587_25634(f_1301_25587_25611(_nativeProcess)) || (DynAbs.Tracing.TraceSender.Expression_False(1301, 25587, 25684) || f_1301_25638_25684(f_1301_25638_25662(_nativeProcess))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 25583, 26171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 25726, 25753);

                        ProcessOutputObject
                        record
                        = default(ProcessOutputObject);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 25775, 26152) || true) && ((record = f_1301_25792_25822(this, blocking)) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 25775, 26152);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 25881, 26073) || true) && (f_1301_25885_25929(f_1301_25885_25905(f_1301_25885_25897(this))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 25881, 26073);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 25987, 26009);

                                    f_1301_25987_26008(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 26039, 26046);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 25881, 26073);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 26101, 26129);

                                f_1301_26101_26128(this, record);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 25775, 26152);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1301, 25775, 26152);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1301, 25775, 26152);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 25583, 26171);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 25514, 26186);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 25426, 26197);

                System.Diagnostics.ProcessStartInfo
                f_1301_25587_25611(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StartInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 25587, 25611);
                    return return_v;
                }


                bool
                f_1301_25587_25634(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.RedirectStandardOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 25587, 25634);
                    return return_v;
                }


                System.Diagnostics.ProcessStartInfo
                f_1301_25638_25662(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StartInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 25638, 25662);
                    return return_v;
                }


                bool
                f_1301_25638_25684(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.RedirectStandardError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 25638, 25684);
                    return return_v;
                }


                System.Management.Automation.ProcessOutputObject
                f_1301_25792_25822(System.Management.Automation.NativeCommandProcessor
                this_param, bool
                blocking)
                {
                    var return_v = this_param.DequeueProcessOutput(blocking);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 25792, 25822);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_25885_25897(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 25885, 25897);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_25885_25905(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 25885, 25905);
                    return return_v;
                }


                bool
                f_1301_25885_25929(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 25885, 25929);
                    return return_v;
                }


                int
                f_1301_25987_26008(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    this_param.StopProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 25987, 26008);
                    return 0;
                }


                int
                f_1301_26101_26128(System.Management.Automation.NativeCommandProcessor
                this_param, System.Management.Automation.ProcessOutputObject
                outputValue)
                {
                    this_param.ProcessOutputRecord(outputValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 26101, 26128);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 25426, 26197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 25426, 26197);
            }
        }

        internal override void Complete()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 26209, 30379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 26267, 26303);

                Exception
                exceptionToRethrow = null
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 26353, 28942) || true) && (_isRunningInBackground == false)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 26353, 28942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 26487, 26507);

                        f_1301_26487_26506(                    // Wait for input writer to finish.
                                            _inputWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 26605, 26657);

                        f_1301_26605_26656(this, blocking: true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 26679, 26708);

                        f_1301_26679_26707(_nativeProcess);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 26825, 28661) || true) && (_isTranscribing && (DynAbs.Tracing.TraceSender.Expression_True(1301, 26829, 26879) && (true == s_supportScreenScrape)) && (DynAbs.Tracing.TraceSender.Expression_True(1301, 26829, 26897) && _runStandAlone))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 26825, 28661);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 26947, 27043);

                            Host.Coordinates
                            endPosition = f_1301_26978_27042(f_1301_26978_27027(f_1301_26978_27021(f_1301_26978_27018(f_1301_26978_26998(f_1301_26978_26990(this))))))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 27069, 27156);

                            endPosition.X = f_1301_27085_27134(f_1301_27085_27128(f_1301_27085_27125(f_1301_27085_27105(f_1301_27085_27097(this))))).BufferSize.Width - 1;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 27294, 27436) || true) && (endPosition.Y < _startPosition.Y)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 27294, 27436);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 27388, 27409);

                                _startPosition.Y = 0;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 27294, 27436);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 27464, 27647);

                            Host.BufferCell[,]
                            bufferContents = f_1301_27500_27646(f_1301_27500_27549(f_1301_27500_27543(f_1301_27500_27540(f_1301_27500_27520(f_1301_27500_27512(this))))), f_1301_27598_27645(_startPosition, endPosition))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 27675, 27724);

                            StringBuilder
                            lineContents = f_1301_27704_27723()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 27750, 27797);

                            StringBuilder
                            bufferText = f_1301_27777_27796()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 27834, 27841);

                                for (int
        row = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 27825, 28533) || true) && (row < f_1301_27849_27876(bufferContents, 0))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 27878, 27883)
        , row++, DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 27825, 28533))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 27825, 28533);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 27941, 28088) || true) && (row > 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 27941, 28088);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 28018, 28057);

                                        f_1301_28018_28056(bufferText, f_1301_28036_28055());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 27941, 28088);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 28120, 28141);

                                    f_1301_28120_28140(
                                                                lineContents);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 28180, 28190);
                                        for (int
            column = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 28171, 28394) || true) && (column < f_1301_28201_28228(bufferContents, 1))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 28230, 28238)
            , column++, DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 28171, 28394))

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 28171, 28394);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 28304, 28363);

                                            f_1301_28304_28362(lineContents, bufferContents[row, column].Character);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1301, 1, 224);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1301, 1, 224);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 28426, 28506);

                                    f_1301_28426_28505(
                                                                bufferText, f_1301_28444_28504(f_1301_28444_28467(lineContents), Utils.Separators.SpaceOrTab));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1301, 1, 709);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1301, 1, 709);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 28561, 28638);

                            f_1301_28561_28637(f_1301_28561_28597(f_1301_28561_28594(f_1301_28561_28581(f_1301_28561_28573(this)))), f_1301_28615_28636(bufferText));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 26825, 28661);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 28685, 28781);

                        f_1301_28685_28780(f_1301_28685_28705(f_1301_28685_28697(this)), SpecialVariables.LastExitCodeVarPath, f_1301_28756_28779(_nativeProcess));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 28803, 28923) || true) && (f_1301_28807_28830(_nativeProcess) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 28803, 28923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 28862, 28923);

                            f_1301_28862_28899(this.commandRuntime).ExecutionFailed = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 28803, 28923);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 26353, 28942);
                    }
                }
                catch (Win32Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 28971, 29066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 29028, 29051);

                    exceptionToRethrow = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 28971, 29066);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 29080, 29248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 29227, 29233);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 29080, 29248);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 29262, 29352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 29314, 29337);

                    exceptionToRethrow = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 29262, 29352);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1301, 29366, 29467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 29442, 29452);

                    f_1301_29442_29451(this);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1301, 29366, 29467);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 29606, 30368) || true) && (exceptionToRethrow != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 29606, 30368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 29754, 29964);

                    string
                    message = f_1301_29771_29963(f_1301_29789_29825(), f_1301_29848_29870(this), f_1301_29872_29898(exceptionToRethrow), f_1301_29921_29962(f_1301_29921_29946(f_1301_29921_29933(this))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 29982, 30090);

                    ApplicationFailedException
                    appFailedException = f_1301_30030_30089(message, exceptionToRethrow)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 30328, 30353);

                    throw appFailedException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 29606, 30368);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 26209, 30379);

                int
                f_1301_26487_26506(System.Management.Automation.ProcessInputWriter
                this_param)
                {
                    this_param.Done();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 26487, 26506);
                    return 0;
                }


                int
                f_1301_26605_26656(System.Management.Automation.NativeCommandProcessor
                this_param, bool
                blocking)
                {
                    this_param.ConsumeAvailableNativeProcessOutput(blocking: blocking);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 26605, 26656);
                    return 0;
                }


                int
                f_1301_26679_26707(System.Diagnostics.Process
                this_param)
                {
                    this_param.WaitForExit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 26679, 26707);
                    return 0;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_26978_26990(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 26978, 26990);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_26978_26998(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 26978, 26998);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1301_26978_27018(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 26978, 27018);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1301_26978_27021(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 26978, 27021);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostRawUserInterface
                f_1301_26978_27027(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.RawUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 26978, 27027);
                    return return_v;
                }


                System.Management.Automation.Host.Coordinates
                f_1301_26978_27042(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 26978, 27042);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_27085_27097(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 27085, 27097);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_27085_27105(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 27085, 27105);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1301_27085_27125(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 27085, 27125);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1301_27085_27128(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 27085, 27128);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostRawUserInterface
                f_1301_27085_27134(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.RawUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 27085, 27134);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_27500_27512(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 27500, 27512);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_27500_27520(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 27500, 27520);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1301_27500_27540(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 27500, 27540);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1301_27500_27543(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 27500, 27543);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostRawUserInterface
                f_1301_27500_27549(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.RawUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 27500, 27549);
                    return return_v;
                }


                System.Management.Automation.Host.Rectangle
                f_1301_27598_27645(System.Management.Automation.Host.Coordinates
                upperLeft, System.Management.Automation.Host.Coordinates
                lowerRight)
                {
                    var return_v = new System.Management.Automation.Host.Rectangle(upperLeft, lowerRight);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 27598, 27645);
                    return return_v;
                }


                System.Management.Automation.Host.BufferCell[,]
                f_1301_27500_27646(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, System.Management.Automation.Host.Rectangle
                rectangle)
                {
                    var return_v = this_param.GetBufferContents(rectangle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 27500, 27646);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1301_27704_27723()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 27704, 27723);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1301_27777_27796()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 27777, 27796);
                    return return_v;
                }


                int
                f_1301_27849_27876(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLength(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 27849, 27876);
                    return return_v;
                }


                string
                f_1301_28036_28055()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 28036, 28055);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1301_28018_28056(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 28018, 28056);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1301_28120_28140(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 28120, 28140);
                    return return_v;
                }


                int
                f_1301_28201_28228(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLength(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 28201, 28228);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1301_28304_28362(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 28304, 28362);
                    return return_v;
                }


                string
                f_1301_28444_28467(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 28444, 28467);
                    return return_v;
                }


                string
                f_1301_28444_28504(string
                this_param, params char[]
                trimChars)
                {
                    var return_v = this_param.TrimEnd(trimChars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 28444, 28504);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1301_28426_28505(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 28426, 28505);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_28561_28573(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 28561, 28573);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_28561_28581(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 28561, 28581);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1301_28561_28594(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 28561, 28594);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1301_28561_28597(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 28561, 28597);
                    return return_v;
                }


                string
                f_1301_28615_28636(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 28615, 28636);
                    return return_v;
                }


                int
                f_1301_28561_28637(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                resultText)
                {
                    this_param.TranscribeResult(resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 28561, 28637);
                    return 0;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_28685_28697(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 28685, 28697);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_28685_28705(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 28685, 28705);
                    return return_v;
                }


                int
                f_1301_28756_28779(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.ExitCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 28756, 28779);
                    return return_v;
                }


                int
                f_1301_28685_28780(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, int
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 28685, 28780);
                    return 0;
                }


                int
                f_1301_28807_28830(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.ExitCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 28807, 28830);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1301_28862_28899(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 28862, 28899);
                    return return_v;
                }


                int
                f_1301_29442_29451(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    this_param.CleanUp();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 29442, 29451);
                    return 0;
                }


                string
                f_1301_29789_29825()
                {
                    var return_v = ParserStrings.ProgramFailedToExecute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 29789, 29825);
                    return return_v;
                }


                string
                f_1301_29848_29870(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.NativeCommandName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 29848, 29870);
                    return return_v;
                }


                string
                f_1301_29872_29898(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 29872, 29898);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_29921_29933(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 29921, 29933);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1301_29921_29946(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 29921, 29946);
                    return return_v;
                }


                string
                f_1301_29921_29962(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PositionMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 29921, 29962);
                    return return_v;
                }


                string
                f_1301_29771_29963(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 29771, 29963);
                    return return_v;
                }


                System.Management.Automation.ApplicationFailedException
                f_1301_30030_30089(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.ApplicationFailedException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 30030, 30089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 26209, 30379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 26209, 30379);
            }
        }

        private static void KillProcess(Process processToKill)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1301, 30905, 32149);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 30984, 31348) || true) && (f_1301_30988_31023())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 30984, 31348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 31057, 31114);

                    Process[]
                    currentlyRunningProcs = f_1301_31091_31113()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 31132, 31227);

                    ProcessWithParentId[]
                    procsWithParentId = ProcessWithParentId.Construct(currentlyRunningProcs)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 31245, 31308);

                    f_1301_31245_31307(processToKill, procsWithParentId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 31326, 31333);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 30984, 31348);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 31400, 31421);

                    f_1301_31400_31420(processToKill);
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 31450, 32077);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 31795, 31856);

                        Process
                        newHandle = f_1301_31815_31855(f_1301_31838_31854(processToKill))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 31953, 31970);

                        f_1301_31953_31969(                    // If the process was not found, we won't get here...
                                            newHandle);
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 32007, 32062);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 32007, 32062);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 31450, 32077);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 32091, 32138);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 32091, 32138);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1301, 30905, 32149);

                bool
                f_1301_30988_31023()
                {
                    var return_v = NativeCommandProcessor.IsServerSide;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 30988, 31023);
                    return return_v;
                }


                System.Diagnostics.Process[]
                f_1301_31091_31113()
                {
                    var return_v = Process.GetProcesses();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 31091, 31113);
                    return return_v;
                }


                int
                f_1301_31245_31307(System.Diagnostics.Process
                processToKill, System.Management.Automation.NativeCommandProcessor.ProcessWithParentId[]
                currentlyRunningProcs)
                {
                    KillProcessAndChildProcesses(processToKill, currentlyRunningProcs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 31245, 31307);
                    return 0;
                }


                int
                f_1301_31400_31420(System.Diagnostics.Process
                this_param)
                {
                    this_param.Kill();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 31400, 31420);
                    return 0;
                }


                int
                f_1301_31838_31854(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 31838, 31854);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1301_31815_31855(int
                processId)
                {
                    var return_v = Process.GetProcessById(processId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 31815, 31855);
                    return return_v;
                }


                int
                f_1301_31953_31969(System.Diagnostics.Process
                this_param)
                {
                    this_param.Kill();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 31953, 31969);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 30905, 32149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 30905, 32149);
            }
        }

        internal struct ProcessWithParentId
        {

            public Process OriginalProcessInstance;

            private int _parentId;

            public int ParentId
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 32646, 32927);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 32745, 32867) || true) && (int.MinValue == _parentId)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 32745, 32867);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 32824, 32844);

                            ConstructParentId();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 32745, 32867);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 32891, 32908);

                        return _parentId;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 32646, 32927);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 32594, 32942);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 32594, 32942);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ProcessWithParentId(Process originalProcess)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1301, 32958, 33142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 33042, 33084);

                    OriginalProcessInstance = originalProcess;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 33102, 33127);

                    _parentId = int.MinValue;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1301, 32958, 33142);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 32958, 33142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 32958, 33142);
                }
            }

            public static ProcessWithParentId[] Construct(Process[] originalProcCollection)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1301, 33158, 33621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 33270, 33356);

                    ProcessWithParentId[]
                    result = new ProcessWithParentId[f_1301_33325_33354(originalProcCollection)]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 33383, 33392);
                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 33374, 33572) || true) && (index < f_1301_33402_33431(originalProcCollection))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 33433, 33440)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 33374, 33572))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 33374, 33572);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 33482, 33553);

                            result[index] = f_1301_33498_33552(originalProcCollection[index]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1301, 1, 199);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1301, 1, 199);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 33592, 33606);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1301, 33158, 33621);

                    int
                    f_1301_33325_33354(System.Diagnostics.Process[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 33325, 33354);
                        return return_v;
                    }


                    int
                    f_1301_33402_33431(System.Diagnostics.Process[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 33402, 33431);
                        return return_v;
                    }


                    System.Management.Automation.NativeCommandProcessor.ProcessWithParentId
                    f_1301_33498_33552(System.Diagnostics.Process
                    originalProcess)
                    {
                        var return_v = new System.Management.Automation.NativeCommandProcessor.ProcessWithParentId(originalProcess);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 33498, 33552);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 33158, 33621);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 33158, 33621);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void ConstructParentId()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 33637, 34585);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 34010, 34025);

                        _parentId = -1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 34049, 34123);

                        Process
                        parentProcess = f_1301_34073_34122(OriginalProcessInstance)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 34145, 34272) || true) && (parentProcess != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 34145, 34272);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 34220, 34249);

                            _parentId = f_1301_34232_34248(parentProcess);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 34145, 34272);
                        }
                    }
                    catch (Win32Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 34309, 34369);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 34309, 34369);
                    }
                    catch (InvalidOperationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 34387, 34458);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 34387, 34458);
                    }
                    catch (Microsoft.Management.Infrastructure.CimException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 34476, 34570);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 34476, 34570);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 33637, 34585);

                    System.Diagnostics.Process
                    f_1301_34073_34122(System.Diagnostics.Process
                    current)
                    {
                        var return_v = PsUtils.GetParentProcess(current);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 34073, 34122);
                        return return_v;
                    }


                    int
                    f_1301_34232_34248(System.Diagnostics.Process
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 34232, 34248);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 33637, 34585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 33637, 34585);
                }
            }
            static ProcessWithParentId()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1301, 32445, 34596);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1301, 32445, 34596);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 32445, 34596);
            }
        }

        private static void KillProcessAndChildProcesses(Process processToKill,
                    ProcessWithParentId[] currentlyRunningProcs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1301, 34838, 36008);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 35070, 35103);

                    int
                    processId = f_1301_35086_35102(processToKill)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 35121, 35174);

                    f_1301_35121_35173(processId, currentlyRunningProcs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 35257, 35278);

                    f_1301_35257_35277(
                                    // kill the parent after children terminated.
                                    processToKill);
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 35307, 35936);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 35652, 35713);

                        Process
                        newHandle = f_1301_35672_35712(f_1301_35695_35711(processToKill))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 35812, 35829);

                        f_1301_35812_35828(
                                            // If the process was not found, we won't get here...
                                            newHandle);
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 35866, 35921);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 35866, 35921);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 35307, 35936);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 35950, 35997);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 35950, 35997);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1301, 34838, 36008);

                int
                f_1301_35086_35102(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 35086, 35102);
                    return return_v;
                }


                int
                f_1301_35121_35173(int
                parentId, System.Management.Automation.NativeCommandProcessor.ProcessWithParentId[]
                currentlyRunningProcs)
                {
                    KillChildProcesses(parentId, currentlyRunningProcs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 35121, 35173);
                    return 0;
                }


                int
                f_1301_35257_35277(System.Diagnostics.Process
                this_param)
                {
                    this_param.Kill();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 35257, 35277);
                    return 0;
                }


                int
                f_1301_35695_35711(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 35695, 35711);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1301_35672_35712(int
                processId)
                {
                    var return_v = Process.GetProcessById(processId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 35672, 35712);
                    return return_v;
                }


                int
                f_1301_35812_35828(System.Diagnostics.Process
                this_param)
                {
                    this_param.Kill();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 35812, 35828);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 34838, 36008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 34838, 36008);
            }
        }

        private static void KillChildProcesses(int parentId, ProcessWithParentId[] currentlyRunningProcs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1301, 36020, 36457);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 36142, 36446);
                    foreach (ProcessWithParentId proc in f_1301_36179_36200_I(currentlyRunningProcs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 36142, 36446);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 36234, 36431) || true) && ((proc.ParentId > 0) && (DynAbs.Tracing.TraceSender.Expression_True(1301, 36238, 36288) && (proc.ParentId == parentId)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 36234, 36431);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 36330, 36412);

                            f_1301_36330_36411(proc.OriginalProcessInstance, currentlyRunningProcs);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 36234, 36431);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 36142, 36446);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1301, 1, 305);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1301, 1, 305);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1301, 36020, 36457);

                int
                f_1301_36330_36411(System.Diagnostics.Process
                processToKill, System.Management.Automation.NativeCommandProcessor.ProcessWithParentId[]
                currentlyRunningProcs)
                {
                    KillProcessAndChildProcesses(processToKill, currentlyRunningProcs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 36330, 36411);
                    return 0;
                }


                System.Management.Automation.NativeCommandProcessor.ProcessWithParentId[]
                f_1301_36179_36200_I(System.Management.Automation.NativeCommandProcessor.ProcessWithParentId[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 36179, 36200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 36020, 36457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 36020, 36457);
            }
        }

        private static bool IsConsoleApplication(string fileName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1301, 36734, 36866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 36816, 36855);

                return !f_1301_36824_36854(fileName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1301, 36734, 36866);

                bool
                f_1301_36824_36854(string
                fileName)
                {
                    var return_v = IsWindowsApplication(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 36824, 36854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 36734, 36866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 36734, 36866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [ArchitectureSensitive]
        private static bool IsWindowsApplication(string fileName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1301, 37073, 37954);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 37188, 37237) || true) && (f_1301_37192_37218_M(!Platform.IsWindowsDesktop))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 37188, 37237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 37222, 37235);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 37188, 37237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 37253, 37290);

                SHFILEINFO
                shinfo = f_1301_37273_37289()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 37304, 37402);

                IntPtr
                type = f_1301_37318_37401(fileName, 0, ref shinfo, f_1301_37363_37385(shinfo), SHGFI_EXETYPE)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 37418, 37943);

                switch ((int)type)
                {

                    case 0x0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 37418, 37943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 37541, 37554);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 37418, 37943);

                    case 0x5a4d:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 37418, 37943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 37661, 37674);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 37418, 37943);

                    case 0x4550:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 37418, 37943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 37791, 37804);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 37418, 37943);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 37418, 37943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 37916, 37928);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 37418, 37943);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1301, 37073, 37954);

                bool
                f_1301_37192_37218_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 37192, 37218);
                    return return_v;
                }


                System.Management.Automation.NativeCommandProcessor.SHFILEINFO
                f_1301_37273_37289()
                {
                    var return_v = new System.Management.Automation.NativeCommandProcessor.SHFILEINFO();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 37273, 37289);
                    return return_v;
                }


                int
                f_1301_37363_37385(System.Management.Automation.NativeCommandProcessor.SHFILEINFO
                structure)
                {
                    var return_v = Marshal.SizeOf(structure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 37363, 37385);
                    return return_v;
                }


                System.IntPtr
                f_1301_37318_37401(string
                pszPath, int
                dwFileAttributes, ref System.Management.Automation.NativeCommandProcessor.SHFILEINFO
                psfi, int
                cbSizeFileInfo, uint
                uFlags)
                {
                    var return_v = SHGetFileInfo(pszPath, (uint)dwFileAttributes, ref psfi, (uint)cbSizeFileInfo, uFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 37318, 37401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 37073, 37954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 37073, 37954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool _stopped;

        internal void StopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 38279, 38745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 38340, 38345);
                lock (_sync)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 38379, 38400) || true) && (_stopped)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 38379, 38400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 38393, 38400);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 38379, 38400);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 38418, 38434);

                    _stopped = true;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 38465, 38734) || true) && (_nativeProcess != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 38465, 38734);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 38525, 38719) || true) && (!_runStandAlone)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 38525, 38719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 38628, 38648);

                        f_1301_38628_38647(                    // Stop input writer
                                            _inputWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 38672, 38700);

                        f_1301_38672_38699(_nativeProcess);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 38525, 38719);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 38465, 38734);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 38279, 38745);

                int
                f_1301_38628_38647(System.Management.Automation.ProcessInputWriter
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 38628, 38647);
                    return 0;
                }


                int
                f_1301_38672_38699(System.Diagnostics.Process
                processToKill)
                {
                    KillProcess(processToKill);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 38672, 38699);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 38279, 38745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 38279, 38745);
            }
        }

        private void CleanUp()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 38894, 39486);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 39026, 39171) || true) && (_hasNotifiedBeginApplication)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 39026, 39171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 39092, 39156);

                    f_1301_39092_39155(f_1301_39092_39132(f_1301_39092_39112(f_1301_39092_39104(this))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 39026, 39171);
                }

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 39287, 39399) || true) && (_nativeProcess != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 39287, 39399);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 39355, 39380);

                        f_1301_39355_39379(_nativeProcess);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 39287, 39399);
                    }
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 39428, 39475);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 39428, 39475);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 38894, 39486);

                System.Management.Automation.Internal.InternalCommand
                f_1301_39092_39104(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 39092, 39104);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_39092_39112(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 39092, 39112);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1301_39092_39132(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 39092, 39132);
                    return return_v;
                }


                int
                f_1301_39092_39155(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    this_param.NotifyEndApplication();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 39092, 39155);
                    return 0;
                }


                int
                f_1301_39355_39379(System.Diagnostics.Process
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 39355, 39379);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 38894, 39486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 38894, 39486);
            }
        }

        private void ProcessOutputRecord(ProcessOutputObject outputValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 39498, 42525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 39588, 39672);

                f_1301_39588_39671(outputValue != null, "only object of type ProcessOutputObject expected");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 39688, 42514) || true) && (f_1301_39692_39710(outputValue) == MinishellStream.Error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 39688, 42514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 39769, 39822);

                    ErrorRecord
                    record = f_1301_39790_39806(outputValue) as ErrorRecord
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 39840, 39923);

                    f_1301_39840_39922(record != null, "ProcessReader should ensure that data is ErrorRecord");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 39941, 39993);

                    f_1301_39941_39992(record, f_1301_39966_39991(f_1301_39966_39978(this)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 40011, 40086);

                    f_1301_40011_40085(this.commandRuntime, record, isNativeError: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 39688, 42514);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 39688, 42514);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 40120, 42514) || true) && (f_1301_40124_40142(outputValue) == MinishellStream.Output)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 40120, 42514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 40202, 40267);

                        f_1301_40202_40266(this.commandRuntime, f_1301_40249_40265(outputValue));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 40120, 42514);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 40120, 42514);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 40301, 42514) || true) && (f_1301_40305_40323(outputValue) == MinishellStream.Debug)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 40301, 42514);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 40382, 40423);

                            string
                            temp = f_1301_40396_40412(outputValue) as string
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 40441, 40517);

                            f_1301_40441_40516(temp != null, "ProcessReader should ensure that data is string");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 40535, 40587);

                            f_1301_40535_40586(f_1301_40535_40565(f_1301_40535_40562(f_1301_40535_40547(this))), temp);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 40301, 42514);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 40301, 42514);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 40621, 42514) || true) && (f_1301_40625_40643(outputValue) == MinishellStream.Verbose)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 40621, 42514);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 40704, 40745);

                                string
                                temp = f_1301_40718_40734(outputValue) as string
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 40763, 40839);

                                f_1301_40763_40838(temp != null, "ProcessReader should ensure that data is string");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 40857, 40911);

                                f_1301_40857_40910(f_1301_40857_40887(f_1301_40857_40884(f_1301_40857_40869(this))), temp);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 40621, 42514);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 40621, 42514);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 40945, 42514) || true) && (f_1301_40949_40967(outputValue) == MinishellStream.Warning)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 40945, 42514);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41028, 41069);

                                    string
                                    temp = f_1301_41042_41058(outputValue) as string
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41087, 41163);

                                    f_1301_41087_41162(temp != null, "ProcessReader should ensure that data is string");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41181, 41235);

                                    f_1301_41181_41234(f_1301_41181_41211(f_1301_41181_41208(f_1301_41181_41193(this))), temp);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 40945, 42514);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 40945, 42514);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41269, 42514) || true) && (f_1301_41273_41291(outputValue) == MinishellStream.Progress)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 41269, 42514);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41353, 41398);

                                        PSObject
                                        temp = f_1301_41369_41385(outputValue) as PSObject
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41416, 42143) || true) && (temp != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 41416, 42143);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41474, 41492);

                                            long
                                            sourceId = 0
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41514, 41562);

                                            PSMemberInfo
                                            info = f_1301_41534_41561(f_1301_41534_41549(temp), "SourceId")
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41584, 41701) || true) && (info != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 41584, 41701);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41650, 41678);

                                                sourceId = (long)f_1301_41667_41677(info);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 41584, 41701);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41725, 41758);

                                            info = f_1301_41732_41757(f_1301_41732_41747(temp), "Record");
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41780, 41806);

                                            ProgressRecord
                                            rec = null
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41828, 41952) || true) && (info != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 41828, 41952);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41894, 41929);

                                                rec = f_1301_41900_41910(info) as ProgressRecord;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 41828, 41952);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 41976, 42124) || true) && (rec != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 41976, 42124);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 42041, 42101);

                                                f_1301_42041_42100(f_1301_42041_42071(f_1301_42041_42068(f_1301_42041_42053(this))), sourceId, rec);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 41976, 42124);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 41416, 42143);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 41269, 42514);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 41269, 42514);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 42177, 42514) || true) && (f_1301_42181_42199(outputValue) == MinishellStream.Information)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 42177, 42514);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 42264, 42329);

                                            InformationRecord
                                            record = f_1301_42291_42307(outputValue) as InformationRecord
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 42347, 42436);

                                            f_1301_42347_42435(record != null, "ProcessReader should ensure that data is InformationRecord");
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 42454, 42499);

                                            f_1301_42454_42498(this.commandRuntime, record);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 42177, 42514);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 41269, 42514);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 40945, 42514);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 40621, 42514);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 40301, 42514);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 40120, 42514);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 39688, 42514);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 39498, 42525);

                int
                f_1301_39588_39671(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 39588, 39671);
                    return 0;
                }


                System.Management.Automation.MinishellStream
                f_1301_39692_39710(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 39692, 39710);
                    return return_v;
                }


                object
                f_1301_39790_39806(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 39790, 39806);
                    return return_v;
                }


                int
                f_1301_39840_39922(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 39840, 39922);
                    return 0;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_39966_39978(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 39966, 39978);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1301_39966_39991(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 39966, 39991);
                    return return_v;
                }


                int
                f_1301_39941_39992(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 39941, 39992);
                    return 0;
                }


                int
                f_1301_40011_40085(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ErrorRecord
                errorRecord, bool
                isNativeError)
                {
                    this_param._WriteErrorSkipAllowCheck(errorRecord, isNativeError: isNativeError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 40011, 40085);
                    return 0;
                }


                System.Management.Automation.MinishellStream
                f_1301_40124_40142(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 40124, 40142);
                    return return_v;
                }


                object
                f_1301_40249_40265(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 40249, 40265);
                    return return_v;
                }


                int
                f_1301_40202_40266(System.Management.Automation.MshCommandRuntime
                this_param, object
                sendToPipeline)
                {
                    this_param._WriteObjectSkipAllowCheck(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 40202, 40266);
                    return 0;
                }


                System.Management.Automation.MinishellStream
                f_1301_40305_40323(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 40305, 40323);
                    return return_v;
                }


                object
                f_1301_40396_40412(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 40396, 40412);
                    return return_v;
                }


                int
                f_1301_40441_40516(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 40441, 40516);
                    return 0;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_40535_40547(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 40535, 40547);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1301_40535_40562(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.PSHostInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 40535, 40562);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1301_40535_40565(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 40535, 40565);
                    return return_v;
                }


                int
                f_1301_40535_40586(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteDebugLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 40535, 40586);
                    return 0;
                }


                System.Management.Automation.MinishellStream
                f_1301_40625_40643(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 40625, 40643);
                    return return_v;
                }


                object
                f_1301_40718_40734(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 40718, 40734);
                    return return_v;
                }


                int
                f_1301_40763_40838(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 40763, 40838);
                    return 0;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_40857_40869(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 40857, 40869);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1301_40857_40884(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.PSHostInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 40857, 40884);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1301_40857_40887(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 40857, 40887);
                    return return_v;
                }


                int
                f_1301_40857_40910(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteVerboseLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 40857, 40910);
                    return 0;
                }


                System.Management.Automation.MinishellStream
                f_1301_40949_40967(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 40949, 40967);
                    return return_v;
                }


                object
                f_1301_41042_41058(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 41042, 41058);
                    return return_v;
                }


                int
                f_1301_41087_41162(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 41087, 41162);
                    return 0;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_41181_41193(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 41181, 41193);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1301_41181_41208(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.PSHostInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 41181, 41208);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1301_41181_41211(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 41181, 41211);
                    return return_v;
                }


                int
                f_1301_41181_41234(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteWarningLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 41181, 41234);
                    return 0;
                }


                System.Management.Automation.MinishellStream
                f_1301_41273_41291(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 41273, 41291);
                    return return_v;
                }


                object
                f_1301_41369_41385(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 41369, 41385);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1301_41534_41549(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 41534, 41549);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1301_41534_41561(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 41534, 41561);
                    return return_v;
                }


                object
                f_1301_41667_41677(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 41667, 41677);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1301_41732_41747(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 41732, 41747);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1301_41732_41757(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 41732, 41757);
                    return return_v;
                }


                object
                f_1301_41900_41910(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 41900, 41910);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_42041_42053(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 42041, 42053);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1301_42041_42068(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.PSHostInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 42041, 42068);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1301_42041_42071(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 42041, 42071);
                    return return_v;
                }


                int
                f_1301_42041_42100(System.Management.Automation.Host.PSHostUserInterface
                this_param, long
                sourceId, System.Management.Automation.ProgressRecord
                record)
                {
                    this_param.WriteProgress(sourceId, record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 42041, 42100);
                    return 0;
                }


                System.Management.Automation.MinishellStream
                f_1301_42181_42199(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 42181, 42199);
                    return return_v;
                }


                object
                f_1301_42291_42307(System.Management.Automation.ProcessOutputObject
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 42291, 42307);
                    return return_v;
                }


                int
                f_1301_42347_42435(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 42347, 42435);
                    return 0;
                }


                int
                f_1301_42454_42498(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.InformationRecord
                informationRecord)
                {
                    this_param.WriteInformation(informationRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 42454, 42498);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 39498, 42525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 39498, 42525);
            }
        }

        private ProcessStartInfo GetProcessStartInfo(bool redirectOutput, bool redirectError, bool redirectInput, bool soloCommand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 42862, 45925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 43010, 43062);

                ProcessStartInfo
                startInfo = f_1301_43039_43061()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 43076, 43107);

                startInfo.FileName = f_1301_43097_43106(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 43123, 44867) || true) && (f_1301_43127_43150(this, f_1301_43140_43149(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 43123, 44867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 43184, 43218);

                    startInfo.UseShellExecute = false;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 43236, 43353) || true) && (redirectInput)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 43236, 43353);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 43295, 43334);

                        startInfo.RedirectStandardInput = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 43236, 43353);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 43373, 43572) || true) && (redirectOutput)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 43373, 43572);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 43433, 43473);

                        startInfo.RedirectStandardOutput = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 43495, 43553);

                        startInfo.StandardOutputEncoding = f_1301_43530_43552();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 43373, 43572);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 43592, 43788) || true) && (redirectError)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 43592, 43788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 43651, 43690);

                        startInfo.RedirectStandardError = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 43712, 43769);

                        startInfo.StandardErrorEncoding = f_1301_43746_43768();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 43592, 43788);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 43123, 44867);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 43123, 44867);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 43854, 44390) || true) && (f_1301_43858_43879() || (DynAbs.Tracing.TraceSender.Expression_False(1301, 43858, 43897) || f_1301_43883_43897()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 43854, 44390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 44128, 44371);

                        throw f_1301_44134_44370(f_1301_44175_44184(this), typeof(RuntimeException), f_1301_44237_44266(f_1301_44237_44249(this)), "CantActivateDocumentInPowerShellCore", f_1301_44308_44358(), f_1301_44360_44369(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 43854, 44390);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 44491, 44799) || true) && (!soloCommand)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 44491, 44799);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 44549, 44780);

                        throw f_1301_44555_44779(f_1301_44596_44605(this), typeof(RuntimeException), f_1301_44658_44687(f_1301_44658_44670(this)), "CantActivateDocumentInPipeline", f_1301_44723_44767(), f_1301_44769_44778(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 44491, 44799);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 44819, 44852);

                    startInfo.UseShellExecute = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 43123, 44867);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 45073, 45422) || true) && (_isMiniShell)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 45073, 45422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 45123, 45232);

                    MinishellParameterBinderController
                    mpc = (MinishellParameterBinderController)f_1301_45200_45231()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 45250, 45343);

                    f_1301_45250_45342(mpc, arguments, redirectOutput, f_1301_45296_45341(f_1301_45296_45336(f_1301_45296_45316(f_1301_45296_45308(this)))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 45361, 45407);

                    startInfo.CreateNoWindow = f_1301_45388_45406(mpc);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 45073, 45422);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 45438, 45502);

                startInfo.Arguments = f_1301_45460_45501(f_1301_45460_45491());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 45518, 45566);

                ExecutionContext
                context = f_1301_45545_45565(f_1301_45545_45557(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 45648, 45806);

                string
                rawPath =
                f_1301_45682_45805(f_1301_45682_45792(f_1301_45682_45708(context), f_1301_45759_45791(f_1301_45759_45780(context))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 45820, 45883);

                startInfo.WorkingDirectory = f_1301_45849_45882(rawPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 45897, 45914);

                return startInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 42862, 45925);

                System.Diagnostics.ProcessStartInfo
                f_1301_43039_43061()
                {
                    var return_v = new System.Diagnostics.ProcessStartInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 43039, 43061);
                    return return_v;
                }


                string
                f_1301_43097_43106(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 43097, 43106);
                    return return_v;
                }


                string
                f_1301_43140_43149(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 43140, 43149);
                    return return_v;
                }


                bool
                f_1301_43127_43150(System.Management.Automation.NativeCommandProcessor
                this_param, string
                path)
                {
                    var return_v = this_param.IsExecutable(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 43127, 43150);
                    return return_v;
                }


                System.Text.Encoding
                f_1301_43530_43552()
                {
                    var return_v = Console.OutputEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 43530, 43552);
                    return return_v;
                }


                System.Text.Encoding
                f_1301_43746_43768()
                {
                    var return_v = Console.OutputEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 43746, 43768);
                    return return_v;
                }


                bool
                f_1301_43858_43879()
                {
                    var return_v = Platform.IsNanoServer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 43858, 43879);
                    return return_v;
                }


                bool
                f_1301_43883_43897()
                {
                    var return_v = Platform.IsIoT;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 43883, 43897);
                    return return_v;
                }


                string
                f_1301_44175_44184(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 44175, 44184);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_44237_44249(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 44237, 44249);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1301_44237_44266(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.InvocationExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 44237, 44266);
                    return return_v;
                }


                string
                f_1301_44308_44358()
                {
                    var return_v = ParserStrings.CantActivateDocumentInPowerShellCore;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 44308, 44358);
                    return return_v;
                }


                string
                f_1301_44360_44369(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 44360, 44369);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1301_44134_44370(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 44134, 44370);
                    return return_v;
                }


                string
                f_1301_44596_44605(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 44596, 44605);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_44658_44670(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 44658, 44670);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1301_44658_44687(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.InvocationExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 44658, 44687);
                    return return_v;
                }


                string
                f_1301_44723_44767()
                {
                    var return_v = ParserStrings.CantActivateDocumentInPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 44723, 44767);
                    return return_v;
                }


                string
                f_1301_44769_44778(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 44769, 44778);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1301_44555_44779(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 44555, 44779);
                    return return_v;
                }


                System.Management.Automation.NativeCommandParameterBinderController
                f_1301_45200_45231()
                {
                    var return_v = NativeParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45200, 45231);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_45296_45308(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45296, 45308);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_45296_45316(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45296, 45316);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1301_45296_45336(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45296, 45336);
                    return return_v;
                }


                string
                f_1301_45296_45341(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45296, 45341);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1301_45250_45342(System.Management.Automation.MinishellParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                parameters, bool
                outputRedirected, string
                hostName)
                {
                    var return_v = this_param.BindParameters(parameters, outputRedirected, hostName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 45250, 45342);
                    return return_v;
                }


                bool
                f_1301_45388_45406(System.Management.Automation.MinishellParameterBinderController
                this_param)
                {
                    var return_v = this_param.NonInteractive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45388, 45406);
                    return return_v;
                }


                System.Management.Automation.NativeCommandParameterBinderController
                f_1301_45460_45491()
                {
                    var return_v = NativeParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45460, 45491);
                    return return_v;
                }


                string
                f_1301_45460_45501(System.Management.Automation.NativeCommandParameterBinderController
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45460, 45501);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_45545_45557(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45545, 45557);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_45545_45565(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45545, 45565);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1301_45682_45708(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45682, 45708);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1301_45759_45780(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45759, 45780);
                    return return_v;
                }


                string
                f_1301_45759_45791(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45759, 45791);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1301_45682_45792(System.Management.Automation.SessionStateInternal
                this_param, string
                namespaceID)
                {
                    var return_v = this_param.GetNamespaceCurrentLocation(namespaceID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 45682, 45792);
                    return return_v;
                }


                string
                f_1301_45682_45805(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.ProviderPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 45682, 45805);
                    return return_v;
                }


                string
                f_1301_45849_45882(string
                pattern)
                {
                    var return_v = WildcardPattern.Unescape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 45849, 45882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 42862, 45925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 42862, 45925);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsDownstreamOutDefault(Pipe downstreamPipe)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 45937, 47148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 46018, 46119);

                f_1301_46018_46118(downstreamPipe != null, "Caller makes sure the passed-in parameter is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 46230, 46301);

                CommandProcessorBase
                outputProcessor = f_1301_46269_46300(downstreamPipe)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 46315, 47108) || true) && (outputProcessor != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 46315, 47108);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 46677, 47093) || true) && (f_1301_46681_46779(f_1301_46695_46727(f_1301_46695_46722(outputProcessor)), "Out-Default", StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 46677, 47093);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 46906, 47074) || true) && (!f_1301_46911_46989(f_1301_46911_46963(f_1301_46911_46947(f_1301_46911_46934(outputProcessor))), "Transcript"))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 46906, 47074);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 47039, 47051);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 46906, 47074);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 46677, 47093);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 46315, 47108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 47124, 47137);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 45937, 47148);

                int
                f_1301_46018_46118(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 46018, 46118);
                    return 0;
                }


                System.Management.Automation.CommandProcessorBase
                f_1301_46269_46300(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.DownstreamCmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 46269, 46300);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1301_46695_46722(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 46695, 46722);
                    return return_v;
                }


                string
                f_1301_46695_46727(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 46695, 46727);
                    return return_v;
                }


                bool
                f_1301_46681_46779(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 46681, 46779);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_46911_46934(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 46911, 46934);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1301_46911_46947(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 46911, 46947);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1301_46911_46963(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 46911, 46963);
                    return return_v;
                }


                bool
                f_1301_46911_46989(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 46911, 46989);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 45937, 47148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 45937, 47148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CalculateIORedirection(out bool redirectOutput, out bool redirectError, out bool redirectInput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 47445, 53127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 47578, 47635);

                redirectInput = f_1301_47594_47634(f_1301_47594_47619(f_1301_47594_47606(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 47649, 47671);

                redirectOutput = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 47685, 47706);

                redirectError = true;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 48355, 49158) || true) && (f_1301_48359_48401(f_1301_48359_48384(f_1301_48359_48371(this))) == f_1301_48405_48445(f_1301_48405_48430(f_1301_48405_48417(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 48355, 49158);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 49001, 49143) || true) && (f_1301_49005_49059(this, f_1301_49028_49058(this.commandRuntime)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 49001, 49143);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 49101, 49124);

                        redirectOutput = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 49001, 49143);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 48355, 49158);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 49342, 50142) || true) && (f_1301_49346_49373(f_1301_49346_49360()) != MshCommandRuntime.MergeDataStream.Output)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 49342, 50142);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 49981, 50127) || true) && (f_1301_49985_50044(this, f_1301_50008_50043(this.commandRuntime)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 49981, 50127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 50086, 50108);

                        redirectError = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 49981, 50127);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 49342, 50142);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 50275, 50413) || true) && (redirectError == false && (DynAbs.Tracing.TraceSender.Expression_True(1301, 50279, 50327) && redirectOutput == true) && (DynAbs.Tracing.TraceSender.Expression_True(1301, 50279, 50343) && _isMiniShell))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 50275, 50413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 50377, 50398);

                    redirectError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 50275, 50413);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 51134, 51862) || true) && (f_1301_51138_51173())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 51134, 51862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 51207, 51228);

                    redirectInput = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 51246, 51268);

                    redirectOutput = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 51286, 51307);

                    redirectError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 51134, 51862);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 51134, 51862);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 51341, 51862) || true) && (f_1301_51345_51370() && (DynAbs.Tracing.TraceSender.Expression_True(1301, 51345, 51405) && f_1301_51374_51405(f_1301_51395_51404(this))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 51341, 51862);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 51611, 51653);

                        f_1301_51611_51652();

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 51673, 51847) || true) && (f_1301_51677_51721())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 51673, 51847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 51763, 51785);

                            redirectOutput = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 51807, 51828);

                            redirectError = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 51673, 51847);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 51341, 51862);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 51134, 51862);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 51878, 51947);

                _runStandAlone = !redirectInput && (DynAbs.Tracing.TraceSender.Expression_True(1301, 51895, 51928) && !redirectOutput) && (DynAbs.Tracing.TraceSender.Expression_True(1301, 51895, 51946) && !redirectError);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 51963, 53116) || true) && (_runStandAlone)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 51963, 53116);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 52015, 52674) || true) && (s_supportScreenScrape == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 52015, 52674);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 52142, 52224);

                            _startPosition = f_1301_52159_52223(f_1301_52159_52208(f_1301_52159_52202(f_1301_52159_52199(f_1301_52159_52179(f_1301_52159_52171(this))))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 52250, 52436);

                            Host.BufferCell[,]
                            bufferContents = f_1301_52286_52435(f_1301_52286_52335(f_1301_52286_52329(f_1301_52286_52326(f_1301_52286_52306(f_1301_52286_52298(this))))), f_1301_52384_52434(_startPosition, _startPosition))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 52462, 52491);

                            s_supportScreenScrape = true;
                        }
                        catch (Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 52536, 52655);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 52602, 52632);

                            s_supportScreenScrape = false;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 52536, 52655);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 52015, 52674);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 52875, 53101) || true) && (_isTranscribing && (DynAbs.Tracing.TraceSender.Expression_True(1301, 52879, 52930) && (false == s_supportScreenScrape)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 52875, 53101);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 52972, 52994);

                        redirectOutput = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 53016, 53037);

                        redirectError = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 53059, 53082);

                        _runStandAlone = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 52875, 53101);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 51963, 53116);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 47445, 53127);

                System.Management.Automation.Internal.InternalCommand
                f_1301_47594_47606(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 47594, 47606);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1301_47594_47619(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 47594, 47619);
                    return return_v;
                }


                bool
                f_1301_47594_47634(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.ExpectingInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 47594, 47634);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_48359_48371(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 48359, 48371);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1301_48359_48384(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 48359, 48384);
                    return return_v;
                }


                int
                f_1301_48359_48401(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelinePosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 48359, 48401);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_48405_48417(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 48405, 48417);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1301_48405_48430(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 48405, 48430);
                    return return_v;
                }


                int
                f_1301_48405_48445(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 48405, 48445);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1301_49028_49058(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 49028, 49058);
                    return return_v;
                }


                bool
                f_1301_49005_49059(System.Management.Automation.NativeCommandProcessor
                this_param, System.Management.Automation.Internal.Pipe
                downstreamPipe)
                {
                    var return_v = this_param.IsDownstreamOutDefault(downstreamPipe);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 49005, 49059);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1301_49346_49360()
                {
                    var return_v = CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 49346, 49360);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime.MergeDataStream
                f_1301_49346_49373(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorMergeTo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 49346, 49373);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1301_50008_50043(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 50008, 50043);
                    return return_v;
                }


                bool
                f_1301_49985_50044(System.Management.Automation.NativeCommandProcessor
                this_param, System.Management.Automation.Internal.Pipe
                downstreamPipe)
                {
                    var return_v = this_param.IsDownstreamOutDefault(downstreamPipe);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 49985, 50044);
                    return return_v;
                }


                bool
                f_1301_51138_51173()
                {
                    var return_v = NativeCommandProcessor.IsServerSide;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 51138, 51173);
                    return return_v;
                }


                bool
                f_1301_51345_51370()
                {
                    var return_v = Platform.IsWindowsDesktop;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 51345, 51370);
                    return return_v;
                }


                string
                f_1301_51395_51404(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 51395, 51404);
                    return return_v;
                }


                bool
                f_1301_51374_51405(string
                fileName)
                {
                    var return_v = IsConsoleApplication(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 51374, 51405);
                    return return_v;
                }


                bool
                f_1301_51611_51652()
                {
                    var return_v = ConsoleVisibility.AllocateHiddenConsole();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 51611, 51652);
                    return return_v;
                }


                bool
                f_1301_51677_51721()
                {
                    var return_v = ConsoleVisibility.AlwaysCaptureApplicationIO;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 51677, 51721);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_52159_52171(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 52159, 52171);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_52159_52179(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 52159, 52179);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1301_52159_52199(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 52159, 52199);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1301_52159_52202(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 52159, 52202);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostRawUserInterface
                f_1301_52159_52208(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.RawUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 52159, 52208);
                    return return_v;
                }


                System.Management.Automation.Host.Coordinates
                f_1301_52159_52223(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 52159, 52223);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1301_52286_52298(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 52286, 52298);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1301_52286_52306(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 52286, 52306);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1301_52286_52326(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 52286, 52326);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1301_52286_52329(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 52286, 52329);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostRawUserInterface
                f_1301_52286_52335(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.RawUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 52286, 52335);
                    return return_v;
                }


                System.Management.Automation.Host.Rectangle
                f_1301_52384_52434(System.Management.Automation.Host.Coordinates
                upperLeft, System.Management.Automation.Host.Coordinates
                lowerRight)
                {
                    var return_v = new System.Management.Automation.Host.Rectangle(upperLeft, lowerRight);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 52384, 52434);
                    return return_v;
                }


                System.Management.Automation.Host.BufferCell[,]
                f_1301_52286_52435(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, System.Management.Automation.Host.Rectangle
                rectangle)
                {
                    var return_v = this_param.GetBufferContents(rectangle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 52286, 52435);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 47445, 53127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 47445, 53127);
            }
        }

        private bool IsExecutable(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 53310, 54213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 53456, 53511);

                string
                myExtension = f_1301_53477_53510(path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 53527, 53587);

                var
                pathext = f_1301_53541_53586("PATHEXT")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 53601, 53624);

                string[]
                extensionList
                = default(string[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 53638, 53908) || true) && (f_1301_53642_53671(pathext))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 53638, 53908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 53705, 53769);

                    extensionList = new string[] { ".exe", ".com", ".bat", ".cmd" };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 53638, 53908);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 53638, 53908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 53835, 53893);

                    extensionList = f_1301_53851_53892(pathext, Utils.Separators.Semicolon);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 53638, 53908);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 53924, 54165);
                    foreach (string extension in f_1301_53953_53966_I(extensionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 53924, 54165);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 54000, 54150) || true) && (f_1301_54004_54077(extension, myExtension, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 54000, 54150);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 54119, 54131);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 54000, 54150);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 53924, 54165);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1301, 1, 242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1301, 1, 242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 54181, 54194);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 53310, 54213);

                string?
                f_1301_53477_53510(string
                path)
                {
                    var return_v = System.IO.Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 53477, 53510);
                    return return_v;
                }


                string?
                f_1301_53541_53586(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 53541, 53586);
                    return return_v;
                }


                bool
                f_1301_53642_53671(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 53642, 53671);
                    return return_v;
                }


                string[]
                f_1301_53851_53892(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 53851, 53892);
                    return return_v;
                }


                bool
                f_1301_54004_54077(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 54004, 54077);
                    return return_v;
                }


                string[]
                f_1301_53953_53966_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 53953, 53966);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 53310, 54213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 53310, 54213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const int
        MaxExecutablePath = 1024
        ;

        [DllImport("shell32.dll", EntryPoint = "FindExecutable")]
        [SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "0")]
        [SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "1")]
        [SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "2")]
        private static extern IntPtr FindExecutableW(
                  string fileName, string directoryPath, StringBuilder pathFound);

        [ArchitectureSensitive]
        private static string FindExecutable(string filename)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1301, 55372, 56472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 55513, 55582);

                StringBuilder
                objResultBuffer = f_1301_55545_55581(MaxExecutablePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 55596, 55626);

                IntPtr
                resultCode = (IntPtr)0
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 55678, 55748);

                    resultCode = f_1301_55691_55747(filename, string.Empty, objResultBuffer);
                }
                catch (System.IndexOutOfRangeException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 55777, 56133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 56083, 56118);

                    f_1301_56083_56117(f_1301_56104_56113(e), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 55777, 56133);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 56324, 56433) || true) && ((long)resultCode >= 32)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 56324, 56433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 56384, 56418);

                    return f_1301_56391_56417(objResultBuffer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 56324, 56433);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 56449, 56461);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1301, 55372, 56472);

                System.Text.StringBuilder
                f_1301_55545_55581(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 55545, 55581);
                    return return_v;
                }


                System.IntPtr
                f_1301_55691_55747(string
                fileName, string
                directoryPath, System.Text.StringBuilder
                pathFound)
                {
                    var return_v = FindExecutableW(fileName, directoryPath, pathFound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 55691, 55747);
                    return return_v;
                }


                string
                f_1301_56104_56113(System.IndexOutOfRangeException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 56104, 56113);
                    return return_v;
                }


                int
                f_1301_56083_56117(string
                message, System.IndexOutOfRangeException
                exception)
                {
                    Environment.FailFast(message, (System.Exception)exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 56083, 56117);
                    return 0;
                }


                string
                f_1301_56391_56417(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 56391, 56417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 55372, 56472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 55372, 56472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const int
        SCS_32BIT_BINARY = 0
        ;

        private const int
        SCS_DOS_BINARY = 1
        ;

        private const int
        SCS_WOW_BINARY = 2
        ;

        private const int
        SCS_PIF_BINARY = 3
        ;

        private const int
        SCS_POSIX_BINARY = 4
        ;

        private const int
        SCS_OS216_BINARY = 5
        ;

        private const int
        SCS_64BIT_BINARY = 6
        ;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct SHFILEINFO
        {

            public IntPtr hIcon;

            public int iIcon;

            public uint dwAttributes;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
            static SHFILEINFO()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1301, 57169, 57609);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1301, 57169, 57609);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 57169, 57609);
            }
        };

        private const uint
        SHGFI_EXETYPE = 0x000002000
        ;

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes,
                    ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

        private bool _isMiniShell;

        private bool IsMiniShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 58367, 58822);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 58427, 58432);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 58418, 58782) || true) && (i < f_1301_58438_58453(arguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 58455, 58458)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 58418, 58782))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 58418, 58782);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 58492, 58536);

                        CommandParameterInternal
                        arg = f_1301_58523_58535(arguments, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 58554, 58767) || true) && (f_1301_58558_58585_M(!arg.ParameterNameSpecified))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 58554, 58767);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 58627, 58748) || true) && (f_1301_58631_58648(arg) is ScriptBlock)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 58627, 58748);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 58713, 58725);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 58627, 58748);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 58554, 58767);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1301, 1, 365);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1301, 1, 365);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 58798, 58811);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 58367, 58822);

                int
                f_1301_58438_58453(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 58438, 58453);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1301_58523_58535(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 58523, 58535);
                    return return_v;
                }


                bool
                f_1301_58558_58585_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 58558, 58585);
                    return return_v;
                }


                object
                f_1301_58631_58648(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 58631, 58648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 58367, 58822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 58367, 58822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsServerSide { get; set; }

        static NativeCommandProcessor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1301, 4356, 58928);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 12741, 12769);
            s_supportScreenScrape = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 54494, 54518);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 56569, 56589);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 56657, 56675);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 56738, 56756);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 56824, 56842);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 56930, 56950);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 57011, 57031);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 57096, 57116);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 57640, 57667);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 58874, 58921);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1301, 4356, 58928);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 4356, 58928);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1301, 4356, 58928);

        System.Management.Automation.PSArgumentNullException
        f_1301_5443_5500(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 5443, 5500);
            return return_v;
        }


        System.Management.Automation.NativeCommand
        f_1301_5636_5655()
        {
            var return_v = new System.Management.Automation.NativeCommand();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 5636, 5655);
            return return_v;
        }


        System.Management.Automation.Internal.InternalCommand
        f_1301_5670_5682(System.Management.Automation.NativeCommandProcessor
        this_param)
        {
            var return_v = this_param.Command;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 5670, 5682);
            return return_v;
        }


        System.Management.Automation.Internal.InternalCommand
        f_1301_5727_5739(System.Management.Automation.NativeCommandProcessor
        this_param)
        {
            var return_v = this_param.Command;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 5727, 5739);
            return return_v;
        }


        System.Management.Automation.Internal.InternalCommand
        f_1301_5772_5784(System.Management.Automation.NativeCommandProcessor
        this_param)
        {
            var return_v = this_param.Command;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 5772, 5784);
            return return_v;
        }


        System.Management.Automation.Internal.InternalCommand
        f_1301_5872_5884(System.Management.Automation.NativeCommandProcessor
        this_param)
        {
            var return_v = this_param.Command;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 5872, 5884);
            return return_v;
        }


        System.Management.Automation.MshCommandRuntime
        f_1301_5824_5885(System.Management.Automation.ExecutionContext
        context, System.Management.Automation.ApplicationInfo
        commandInfo, System.Management.Automation.Internal.InternalCommand
        thisCommand)
        {
            var return_v = new System.Management.Automation.MshCommandRuntime(context, (System.Management.Automation.CommandInfo)commandInfo, thisCommand);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 5824, 5885);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1301_5922_5948(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineSessionState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 5922, 5948);
            return return_v;
        }


        System.Management.Automation.SessionStateScope
        f_1301_5922_5961(System.Management.Automation.SessionStateInternal
        this_param)
        {
            var return_v = this_param.CurrentScope;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 5922, 5961);
            return return_v;
        }


        System.Management.Automation.Internal.InternalCommand
        f_1301_6184_6191()
        {
            var return_v = Command;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 6184, 6191);
            return return_v;
        }


        System.Management.Automation.Internal.InternalCommand
        f_1301_6345_6352()
        {
            var return_v = Command;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 6345, 6352);
            return return_v;
        }


        System.Management.Automation.ProcessInputWriter
        f_1301_6322_6353(System.Management.Automation.Internal.InternalCommand
        command)
        {
            var return_v = new System.Management.Automation.ProcessInputWriter(command);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 6322, 6353);
            return return_v;
        }


        System.Management.Automation.Internal.InternalCommand
        f_1301_6388_6400(System.Management.Automation.NativeCommandProcessor
        this_param)
        {
            var return_v = this_param.Command;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 6388, 6400);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1301_6388_6408(System.Management.Automation.Internal.InternalCommand
        this_param)
        {
            var return_v = this_param.Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 6388, 6408);
            return return_v;
        }


        System.Management.Automation.Internal.Host.InternalHost
        f_1301_6388_6428(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineHostInterface;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 6388, 6428);
            return return_v;
        }


        System.Management.Automation.Host.PSHostUserInterface
        f_1301_6388_6431(System.Management.Automation.Internal.Host.InternalHost
        this_param)
        {
            var return_v = this_param.UI;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 6388, 6431);
            return return_v;
        }


        bool
        f_1301_6388_6446(System.Management.Automation.Host.PSHostUserInterface
        this_param)
        {
            var return_v = this_param.IsTranscribing;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 6388, 6446);
            return return_v;
        }


        static System.Management.Automation.CommandInfo
        f_1301_5335_5350_C(System.Management.Automation.CommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1301, 5224, 6458);
            return return_v;
        }


        object
        f_1301_13050_13062()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 13050, 13062);
            return return_v;
        }

    }
    internal class ProcessOutputHandler
    {
        internal const string
        XmlCliTag = "#< CLIXML"
        ;

        private int _refCount;

        private BlockingCollection<ProcessOutputObject> _queue;

        private bool _isFirstOutput;

        private bool _isFirstError;

        private bool _isXmlCliOutput;

        private bool _isXmlCliError;

        private string _processFileName;

        public ProcessOutputHandler(Process process, BlockingCollection<ProcessOutputObject> queue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1301, 59339, 60719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59058, 59067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59126, 59132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59156, 59170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59194, 59207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59231, 59246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59270, 59284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59310, 59326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59455, 59599);

                f_1301_59455_59598(f_1301_59468_59508(f_1301_59468_59485(process)) || (DynAbs.Tracing.TraceSender.Expression_False(1301, 59468, 59551) || f_1301_59512_59551(f_1301_59512_59529(process))), "Caller should redirect at least one stream");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59613, 59627);

                _refCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59641, 59687);

                _processFileName = f_1301_59660_59686(f_1301_59660_59677(process));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59701, 59716);

                _queue = queue;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59885, 59947) || true) && (f_1301_59889_59929(f_1301_59889_59906(process)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 59885, 59947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59933, 59945);

                    _refCount++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 59885, 59947);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59963, 60024) || true) && (f_1301_59967_60006(f_1301_59967_59984(process)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 59963, 60024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60010, 60022);

                    _refCount++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 59963, 60024);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60104, 60401) || true) && (f_1301_60108_60148(f_1301_60108_60125(process)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 60104, 60401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60182, 60204);

                    _isFirstOutput = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60222, 60246);

                    _isXmlCliOutput = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60264, 60338);

                    process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60356, 60386);

                    f_1301_60356_60385(process);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 60104, 60401);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60417, 60708) || true) && (f_1301_60421_60460(f_1301_60421_60438(process)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 60417, 60708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60494, 60515);

                    _isFirstError = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60533, 60556);

                    _isXmlCliError = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60574, 60646);

                    process.ErrorDataReceived += new DataReceivedEventHandler(ErrorHandler);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60664, 60693);

                    f_1301_60664_60692(process);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 60417, 60708);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1301, 59339, 60719);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 59339, 60719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 59339, 60719);
            }
        }

        private void decrementRefCount()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 60731, 61033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60788, 60890);

                f_1301_60788_60889(_refCount > 0, "RefCount should always be positive, when we are trying to decrement it");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60904, 61022) || true) && (f_1301_60908_60944(ref _refCount) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 60904, 61022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 60983, 61007);

                    f_1301_60983_61006(_queue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 60904, 61022);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 60731, 61033);

                int
                f_1301_60788_60889(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 60788, 60889);
                    return 0;
                }


                int
                f_1301_60908_60944(ref int
                location)
                {
                    var return_v = Interlocked.Decrement(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 60908, 60944);
                    return return_v;
                }


                int
                f_1301_60983_61006(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.ProcessOutputObject>
                this_param)
                {
                    this_param.CompleteAdding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 60983, 61006);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 60731, 61033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 60731, 61033);
            }
        }

        private void OutputHandler(object sender, DataReceivedEventArgs outputReceived)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 61045, 62082);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 61149, 62071) || true) && (f_1301_61153_61172(outputReceived) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 61149, 62071);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 61214, 61542) || true) && (_isFirstOutput)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 61214, 61542);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 61274, 61297);

                        _isFirstOutput = false;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 61319, 61523) || true) && (f_1301_61323_61394(f_1301_61337_61356(outputReceived), XmlCliTag, StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 61319, 61523);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 61444, 61467);

                            _isXmlCliOutput = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 61493, 61500);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 61319, 61523);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 61214, 61542);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 61562, 61970) || true) && (_isXmlCliOutput)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 61562, 61970);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 61623, 61788);
                            foreach (var record in f_1301_61646_61696_I(f_1301_61646_61696(this, f_1301_61670_61689(outputReceived), true)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 61623, 61788);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 61746, 61765);

                                f_1301_61746_61764(_queue, record);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 61623, 61788);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1301, 1, 166);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1301, 1, 166);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 61562, 61970);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 61562, 61970);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 61870, 61951);

                        f_1301_61870_61950(_queue, f_1301_61881_61949(f_1301_61905_61924(outputReceived), MinishellStream.Output));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 61562, 61970);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 61149, 62071);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 61149, 62071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 62036, 62056);

                    f_1301_62036_62055(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 61149, 62071);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 61045, 62082);

                string
                f_1301_61153_61172(System.Diagnostics.DataReceivedEventArgs
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 61153, 61172);
                    return return_v;
                }


                string
                f_1301_61337_61356(System.Diagnostics.DataReceivedEventArgs
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 61337, 61356);
                    return return_v;
                }


                bool
                f_1301_61323_61394(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 61323, 61394);
                    return return_v;
                }


                string
                f_1301_61670_61689(System.Diagnostics.DataReceivedEventArgs
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 61670, 61689);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ProcessOutputObject>
                f_1301_61646_61696(System.Management.Automation.ProcessOutputHandler
                this_param, string
                xml, bool
                isOutput)
                {
                    var return_v = this_param.DeserializeCliXmlObject(xml, isOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 61646, 61696);
                    return return_v;
                }


                int
                f_1301_61746_61764(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.ProcessOutputObject>
                this_param, System.Management.Automation.ProcessOutputObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 61746, 61764);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ProcessOutputObject>
                f_1301_61646_61696_I(System.Collections.Generic.List<System.Management.Automation.ProcessOutputObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 61646, 61696);
                    return return_v;
                }


                string
                f_1301_61905_61924(System.Diagnostics.DataReceivedEventArgs
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 61905, 61924);
                    return return_v;
                }


                System.Management.Automation.ProcessOutputObject
                f_1301_61881_61949(string
                data, System.Management.Automation.MinishellStream
                stream)
                {
                    var return_v = new System.Management.Automation.ProcessOutputObject((object)data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 61881, 61949);
                    return return_v;
                }


                int
                f_1301_61870_61950(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.ProcessOutputObject>
                this_param, System.Management.Automation.ProcessOutputObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 61870, 61950);
                    return 0;
                }


                int
                f_1301_62036_62055(System.Management.Automation.ProcessOutputHandler
                this_param)
                {
                    this_param.decrementRefCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 62036, 62055);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 61045, 62082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 61045, 62082);
            }
        }

        private void ErrorHandler(object sender, DataReceivedEventArgs errorReceived)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 62094, 63767);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 62196, 63756) || true) && (f_1301_62200_62218(errorReceived) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 62196, 63756);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 62260, 62446) || true) && (f_1301_62264_62334(f_1301_62278_62296(errorReceived), XmlCliTag, StringComparison.Ordinal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 62260, 62446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 62376, 62398);

                        _isXmlCliError = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 62420, 62427);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 62260, 62446);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 62466, 63655) || true) && (_isXmlCliError)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 62466, 63655);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 62526, 62691);
                            foreach (var record in f_1301_62549_62599_I(f_1301_62549_62599(this, f_1301_62573_62591(errorReceived), false)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 62526, 62691);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 62649, 62668);

                                f_1301_62649_62667(_queue, record);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 62526, 62691);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1301, 1, 166);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1301, 1, 166);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 62466, 63655);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 62466, 63655);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 62773, 62797);

                        ErrorRecord
                        errorRecord
                        = default(ErrorRecord);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 62819, 63540) || true) && (_isFirstError)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 62819, 63540);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 62886, 62908);

                            _isFirstError = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 63026, 63167);

                            errorRecord = f_1301_63040_63166(f_1301_63056_63095(f_1301_63076_63094(errorReceived)), "NativeCommandError", ErrorCategory.NotSpecified, f_1301_63147_63165(errorReceived));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 62819, 63540);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 62819, 63540);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 63383, 63517);

                            errorRecord = f_1301_63397_63516(f_1301_63413_63452(f_1301_63433_63451(errorReceived)), "NativeCommandErrorMessage", ErrorCategory.NotSpecified, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 62819, 63540);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 63564, 63636);

                        f_1301_63564_63635(
                                            _queue, f_1301_63575_63634(errorRecord, MinishellStream.Error));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 62466, 63655);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 62196, 63756);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 62196, 63756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 63721, 63741);

                    f_1301_63721_63740(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 62196, 63756);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 62094, 63767);

                string
                f_1301_62200_62218(System.Diagnostics.DataReceivedEventArgs
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 62200, 62218);
                    return return_v;
                }


                string
                f_1301_62278_62296(System.Diagnostics.DataReceivedEventArgs
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 62278, 62296);
                    return return_v;
                }


                bool
                f_1301_62264_62334(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 62264, 62334);
                    return return_v;
                }


                string
                f_1301_62573_62591(System.Diagnostics.DataReceivedEventArgs
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 62573, 62591);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ProcessOutputObject>
                f_1301_62549_62599(System.Management.Automation.ProcessOutputHandler
                this_param, string
                xml, bool
                isOutput)
                {
                    var return_v = this_param.DeserializeCliXmlObject(xml, isOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 62549, 62599);
                    return return_v;
                }


                int
                f_1301_62649_62667(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.ProcessOutputObject>
                this_param, System.Management.Automation.ProcessOutputObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 62649, 62667);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ProcessOutputObject>
                f_1301_62549_62599_I(System.Collections.Generic.List<System.Management.Automation.ProcessOutputObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 62549, 62599);
                    return return_v;
                }


                string
                f_1301_63076_63094(System.Diagnostics.DataReceivedEventArgs
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 63076, 63094);
                    return return_v;
                }


                System.Management.Automation.RemoteException
                f_1301_63056_63095(string
                message)
                {
                    var return_v = new System.Management.Automation.RemoteException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 63056, 63095);
                    return return_v;
                }


                string
                f_1301_63147_63165(System.Diagnostics.DataReceivedEventArgs
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 63147, 63165);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1301_63040_63166(System.Management.Automation.RemoteException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 63040, 63166);
                    return return_v;
                }


                string
                f_1301_63433_63451(System.Diagnostics.DataReceivedEventArgs
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 63433, 63451);
                    return return_v;
                }


                System.Management.Automation.RemoteException
                f_1301_63413_63452(string
                message)
                {
                    var return_v = new System.Management.Automation.RemoteException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 63413, 63452);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1301_63397_63516(System.Management.Automation.RemoteException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 63397, 63516);
                    return return_v;
                }


                System.Management.Automation.ProcessOutputObject
                f_1301_63575_63634(System.Management.Automation.ErrorRecord
                data, System.Management.Automation.MinishellStream
                stream)
                {
                    var return_v = new System.Management.Automation.ProcessOutputObject((object)data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 63575, 63634);
                    return return_v;
                }


                int
                f_1301_63564_63635(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.ProcessOutputObject>
                this_param, System.Management.Automation.ProcessOutputObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 63564, 63635);
                    return 0;
                }


                int
                f_1301_63721_63740(System.Management.Automation.ProcessOutputHandler
                this_param)
                {
                    this_param.decrementRefCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 63721, 63740);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 62094, 63767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 62094, 63767);
            }
        }

        private List<ProcessOutputObject> DeserializeCliXmlObject(string xml, bool isOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 63779, 69129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 63888, 63933);

                var
                result = f_1301_63901_63932()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 63983, 68206);
                    using (var
                    streamReader = f_1301_64009_64054(f_1301_64026_64053(f_1301_64026_64039(), xml))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 64096, 64198);

                        XmlReader
                        xmlReader = f_1301_64118_64197(streamReader, f_1301_64149_64196())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 64220, 64267);

                        Deserializer
                        des = f_1301_64239_64266(xmlReader)
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 64289, 68187) || true) && (!f_1301_64297_64307(des))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 64289, 68187);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 64357, 64375);

                                string
                                streamName
                                = default(string);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 64401, 64446);

                                object
                                obj = f_1301_64414_64445(des, out streamName)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 64542, 64591);

                                MinishellStream
                                stream = MinishellStream.Unknown
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 64617, 64796) || true) && (streamName != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 64617, 64796);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 64697, 64769);

                                    stream = f_1301_64706_64768(streamName);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 64617, 64796);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 64824, 65013) || true) && (stream == MinishellStream.Unknown)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 64824, 65013);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 64919, 64986);

                                    stream = (DynAbs.Tracing.TraceSender.Conditional_F1(1301, 64928, 64936) || ((isOutput && DynAbs.Tracing.TraceSender.Conditional_F2(1301, 64939, 64961)) || DynAbs.Tracing.TraceSender.Conditional_F3(1301, 64964, 64985))) ? MinishellStream.Output : MinishellStream.Error;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 64824, 65013);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 65107, 65252) || true) && (stream != MinishellStream.Output && (DynAbs.Tracing.TraceSender.Expression_True(1301, 65111, 65158) && obj == null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 65107, 65252);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 65216, 65225);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 65107, 65252);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 65280, 68087) || true) && (stream == MinishellStream.Error)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 65280, 68087);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 65373, 66353) || true) && (obj is PSObject)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 65373, 66353);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 65458, 65526);

                                        obj = f_1301_65464_65525(f_1301_65500_65524(obj));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 65373, 66353);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 65373, 66353);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 65656, 65683);

                                        string
                                        errorMessage = null
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 65793, 65896);

                                            errorMessage = (string)f_1301_65816_65895(obj, typeof(string), f_1301_65866_65894());
                                        }
                                        catch (PSInvalidCastException)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 65965, 66112);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 66068, 66077);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 65965, 66112);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 66148, 66322);

                                        obj = f_1301_66154_66321(f_1301_66170_66203(errorMessage), "NativeCommandError", ErrorCategory.NotSpecified, errorMessage);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 65373, 66353);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 65280, 68087);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 65280, 68087);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 66411, 68087) || true) && (stream == MinishellStream.Information)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 66411, 68087);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 66510, 67367) || true) && (obj is PSObject)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 66510, 67367);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 66595, 66669);

                                            obj = f_1301_66601_66668(f_1301_66643_66667(obj));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 66510, 67367);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 66510, 67367);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 66799, 66825);

                                            string
                                            messageData = null
                                            ;
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 66935, 67037);

                                                messageData = (string)f_1301_66957_67036(obj, typeof(string), f_1301_67007_67035());
                                            }
                                            catch (PSInvalidCastException)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 67106, 67253);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 67209, 67218);

                                                continue;
                                                DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 67106, 67253);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 67289, 67336);

                                            obj = f_1301_67295_67335(messageData, null);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 66510, 67367);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 66411, 68087);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 66411, 68087);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 67425, 68087) || true) && (stream == MinishellStream.Debug || (DynAbs.Tracing.TraceSender.Expression_False(1301, 67429, 67531) || stream == MinishellStream.Verbose) || (DynAbs.Tracing.TraceSender.Expression_False(1301, 67429, 67602) || stream == MinishellStream.Warning))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 67425, 68087);
                                            // Convert to string
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 67778, 67864);

                                                obj = f_1301_67784_67863(obj, typeof(string), f_1301_67834_67862());
                                            }
                                            catch (PSInvalidCastException)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 67925, 68060);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 68020, 68029);

                                                continue;
                                                DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 67925, 68060);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 67425, 68087);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 66411, 68087);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 65280, 68087);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 68115, 68164);

                                f_1301_68115_68163(
                                                        result, f_1301_68126_68162(obj, stream));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 64289, 68187);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1301, 64289, 68187);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1301, 64289, 68187);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1301, 63983, 68206);
                    }
                }
                catch (XmlException originalException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 68235, 69088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 68306, 68345);

                    string
                    template = f_1301_68324_68344()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 68363, 68620);

                    string
                    message = f_1301_68380_68619(null, template, (DynAbs.Tracing.TraceSender.Conditional_F1(1301, 68474, 68482) || ((isOutput && DynAbs.Tracing.TraceSender.Conditional_F2(1301, 68485, 68507)) || DynAbs.Tracing.TraceSender.Conditional_F3(1301, 68510, 68531))) ? MinishellStream.Output : MinishellStream.Error, _processFileName, f_1301_68593_68618(originalException))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 68638, 68754);

                    XmlException
                    newException = f_1301_68666_68753(message, originalException)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 68774, 68989);

                    ErrorRecord
                    error = f_1301_68794_68988(newException, "ProcessStreamReader_CliXmlError", ErrorCategory.SyntaxError, _processFileName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 69007, 69073);

                    f_1301_69007_69072(result, f_1301_69018_69071(error, MinishellStream.Error));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 68235, 69088);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 69104, 69118);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 63779, 69129);

                System.Collections.Generic.List<System.Management.Automation.ProcessOutputObject>
                f_1301_63901_63932()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.ProcessOutputObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 63901, 63932);
                    return return_v;
                }


                System.Text.Encoding
                f_1301_64026_64039()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 64026, 64039);
                    return return_v;
                }


                byte[]
                f_1301_64026_64053(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 64026, 64053);
                    return return_v;
                }


                System.IO.MemoryStream
                f_1301_64009_64054(byte[]
                buffer)
                {
                    var return_v = new System.IO.MemoryStream(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 64009, 64054);
                    return return_v;
                }


                System.Xml.XmlReaderSettings
                f_1301_64149_64196()
                {
                    var return_v = InternalDeserializer.XmlReaderSettingsForCliXml;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 64149, 64196);
                    return return_v;
                }


                System.Xml.XmlReader
                f_1301_64118_64197(System.IO.MemoryStream
                input, System.Xml.XmlReaderSettings
                settings)
                {
                    var return_v = XmlReader.Create((System.IO.Stream)input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 64118, 64197);
                    return return_v;
                }


                System.Management.Automation.Deserializer
                f_1301_64239_64266(System.Xml.XmlReader
                reader)
                {
                    var return_v = new System.Management.Automation.Deserializer(reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 64239, 64266);
                    return return_v;
                }


                bool
                f_1301_64297_64307(System.Management.Automation.Deserializer
                this_param)
                {
                    var return_v = this_param.Done();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 64297, 64307);
                    return return_v;
                }


                object
                f_1301_64414_64445(System.Management.Automation.Deserializer
                this_param, out string
                streamName)
                {
                    var return_v = this_param.Deserialize(out streamName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 64414, 64445);
                    return return_v;
                }


                System.Management.Automation.MinishellStream
                f_1301_64706_64768(string
                stream)
                {
                    var return_v = StringToMinishellStreamConverter.ToMinishellStream(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 64706, 64768);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1301_65500_65524(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 65500, 65524);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1301_65464_65525(System.Management.Automation.PSObject
                serializedErrorRecord)
                {
                    var return_v = ErrorRecord.FromPSObjectForRemoting(serializedErrorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 65464, 65525);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1301_65866_65894()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 65866, 65894);
                    return return_v;
                }


                object
                f_1301_65816_65895(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 65816, 65895);
                    return return_v;
                }


                System.Management.Automation.RemoteException
                f_1301_66170_66203(string
                message)
                {
                    var return_v = new System.Management.Automation.RemoteException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 66170, 66203);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1301_66154_66321(System.Management.Automation.RemoteException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 66154, 66321);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1301_66643_66667(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 66643, 66667);
                    return return_v;
                }


                System.Management.Automation.InformationRecord
                f_1301_66601_66668(System.Management.Automation.PSObject
                inputObject)
                {
                    var return_v = InformationRecord.FromPSObjectForRemoting(inputObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 66601, 66668);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1301_67007_67035()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 67007, 67035);
                    return return_v;
                }


                object
                f_1301_66957_67036(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 66957, 67036);
                    return return_v;
                }


                System.Management.Automation.InformationRecord
                f_1301_67295_67335(string
                messageData, string
                source)
                {
                    var return_v = new System.Management.Automation.InformationRecord((object)messageData, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 67295, 67335);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1301_67834_67862()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 67834, 67862);
                    return return_v;
                }


                object
                f_1301_67784_67863(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 67784, 67863);
                    return return_v;
                }


                System.Management.Automation.ProcessOutputObject
                f_1301_68126_68162(object
                data, System.Management.Automation.MinishellStream
                stream)
                {
                    var return_v = new System.Management.Automation.ProcessOutputObject(data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 68126, 68162);
                    return return_v;
                }


                int
                f_1301_68115_68163(System.Collections.Generic.List<System.Management.Automation.ProcessOutputObject>
                this_param, System.Management.Automation.ProcessOutputObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 68115, 68163);
                    return 0;
                }


                string
                f_1301_68324_68344()
                {
                    var return_v = NativeCP.CliXmlError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 68324, 68344);
                    return return_v;
                }


                string
                f_1301_68593_68618(System.Xml.XmlException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 68593, 68618);
                    return return_v;
                }


                string
                f_1301_68380_68619(System.IFormatProvider?
                provider, string
                format, System.Management.Automation.MinishellStream
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format(provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 68380, 68619);
                    return return_v;
                }


                System.Xml.XmlException
                f_1301_68666_68753(string
                message, System.Xml.XmlException
                innerException)
                {
                    var return_v = new System.Xml.XmlException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 68666, 68753);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1301_68794_68988(System.Xml.XmlException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 68794, 68988);
                    return return_v;
                }


                System.Management.Automation.ProcessOutputObject
                f_1301_69018_69071(System.Management.Automation.ErrorRecord
                data, System.Management.Automation.MinishellStream
                stream)
                {
                    var return_v = new System.Management.Automation.ProcessOutputObject((object)data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 69018, 69071);
                    return return_v;
                }


                int
                f_1301_69007_69072(System.Collections.Generic.List<System.Management.Automation.ProcessOutputObject>
                this_param, System.Management.Automation.ProcessOutputObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 69007, 69072);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 63779, 69129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 63779, 69129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ProcessOutputHandler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1301, 58936, 69136);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 59010, 59033);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1301, 58936, 69136);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 58936, 69136);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1301, 58936, 69136);

        System.Diagnostics.ProcessStartInfo
        f_1301_59468_59485(System.Diagnostics.Process
        this_param)
        {
            var return_v = this_param.StartInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 59468, 59485);
            return return_v;
        }


        bool
        f_1301_59468_59508(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.RedirectStandardOutput;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 59468, 59508);
            return return_v;
        }


        System.Diagnostics.ProcessStartInfo
        f_1301_59512_59529(System.Diagnostics.Process
        this_param)
        {
            var return_v = this_param.StartInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 59512, 59529);
            return return_v;
        }


        bool
        f_1301_59512_59551(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.RedirectStandardError;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 59512, 59551);
            return return_v;
        }


        int
        f_1301_59455_59598(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 59455, 59598);
            return 0;
        }


        System.Diagnostics.ProcessStartInfo
        f_1301_59660_59677(System.Diagnostics.Process
        this_param)
        {
            var return_v = this_param.StartInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 59660, 59677);
            return return_v;
        }


        string
        f_1301_59660_59686(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.FileName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 59660, 59686);
            return return_v;
        }


        System.Diagnostics.ProcessStartInfo
        f_1301_59889_59906(System.Diagnostics.Process
        this_param)
        {
            var return_v = this_param.StartInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 59889, 59906);
            return return_v;
        }


        bool
        f_1301_59889_59929(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.RedirectStandardOutput;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 59889, 59929);
            return return_v;
        }


        System.Diagnostics.ProcessStartInfo
        f_1301_59967_59984(System.Diagnostics.Process
        this_param)
        {
            var return_v = this_param.StartInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 59967, 59984);
            return return_v;
        }


        bool
        f_1301_59967_60006(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.RedirectStandardError;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 59967, 60006);
            return return_v;
        }


        System.Diagnostics.ProcessStartInfo
        f_1301_60108_60125(System.Diagnostics.Process
        this_param)
        {
            var return_v = this_param.StartInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 60108, 60125);
            return return_v;
        }


        bool
        f_1301_60108_60148(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.RedirectStandardOutput;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 60108, 60148);
            return return_v;
        }


        int
        f_1301_60356_60385(System.Diagnostics.Process
        this_param)
        {
            this_param.BeginOutputReadLine();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 60356, 60385);
            return 0;
        }


        System.Diagnostics.ProcessStartInfo
        f_1301_60421_60438(System.Diagnostics.Process
        this_param)
        {
            var return_v = this_param.StartInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 60421, 60438);
            return return_v;
        }


        bool
        f_1301_60421_60460(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.RedirectStandardError;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 60421, 60460);
            return return_v;
        }


        int
        f_1301_60664_60692(System.Diagnostics.Process
        this_param)
        {
            this_param.BeginErrorReadLine();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 60664, 60692);
            return 0;
        }

    }
    internal class ProcessInputWriter
    {
        private InternalCommand _command;

        internal ProcessInputWriter(InternalCommand command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1301, 69470, 69659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 69348, 69356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 69731, 69740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 69770, 69784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 71974, 71987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 72107, 72119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 73616, 73633);
                this._stopping = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 69547, 69615);

                f_1301_69547_69614(command != null, "Caller should validate the parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 69629, 69648);

                _command = command;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1301, 69470, 69659);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 69470, 69659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 69470, 69659);
            }
        }

        private SteppablePipeline _pipeline;

        private Serializer _xmlSerializer;

        internal void Add(object input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 69934, 70462);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 69990, 70228) || true) && (_stopping || (DynAbs.Tracing.TraceSender.Expression_False(1301, 69994, 70028) || _streamWriter == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 69990, 70228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 70206, 70213);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 69990, 70228);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 70244, 70451) || true) && (_inputFormat == NativeCommandIOFormat.Text)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 70244, 70451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 70324, 70344);

                    f_1301_70324_70343(this, input);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 70244, 70451);
                }

                else // Xml

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 70244, 70451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 70417, 70436);

                    f_1301_70417_70435(this, input);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 70244, 70451);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 69934, 70462);

                int
                f_1301_70324_70343(System.Management.Automation.ProcessInputWriter
                this_param, object
                input)
                {
                    this_param.AddTextInput(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 70324, 70343);
                    return 0;
                }


                int
                f_1301_70417_70435(System.Management.Automation.ProcessInputWriter
                this_param, object
                input)
                {
                    this_param.AddXmlInput(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 70417, 70435);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 69934, 70462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 69934, 70462);
            }
        }

        private void AddTextInput(object input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 70474, 70606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 70538, 70595);

                f_1301_70538_70594(this, f_1301_70569_70593(_pipeline, input));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 70474, 70606);

                System.Array
                f_1301_70569_70593(System.Management.Automation.SteppablePipeline
                this_param, object
                input)
                {
                    var return_v = this_param.Process(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 70569, 70593);
                    return return_v;
                }


                int
                f_1301_70538_70594(System.Management.Automation.ProcessInputWriter
                this_param, System.Array
                formattedObjects)
                {
                    this_param.AddTextInputFromFormattedArray(formattedObjects);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 70538, 70594);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 70474, 70606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 70474, 70606);
            }
        }

        private void AddTextInputFromFormattedArray(Array formattedObjects)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 70618, 71448);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 70710, 71437);
                    foreach (var item in f_1301_70731_70747_I(formattedObjects))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 70710, 71437);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 70781, 70843);

                        string
                        line = f_1301_70795_70842(f_1301_70819_70835(_command), item)
                        ;
                        // if process is already finished and we are trying to write something to it,
                        // we will get IOException
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 71044, 71074);

                            f_1301_71044_71073(_streamWriter, line);
                        }
                        catch (IOException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 71111, 71422);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 71313, 71328);

                            f_1301_71313_71327(                    // we are assuming that process is already finished
                                                                   // we should just stop processing at this point
                                                this);
                            DynAbs.Tracing.TraceSender.TraceBreak(1301, 71397, 71403);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 71111, 71422);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 70710, 71437);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1301, 1, 728);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1301, 1, 728);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 70618, 71448);

                System.Management.Automation.ExecutionContext
                f_1301_70819_70835(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 70819, 70835);
                    return return_v;
                }


                string
                f_1301_70795_70842(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 70795, 70842);
                    return return_v;
                }


                int
                f_1301_71044_71073(System.IO.StreamWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 71044, 71073);
                    return 0;
                }


                int
                f_1301_71313_71327(System.Management.Automation.ProcessInputWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 71313, 71327);
                    return 0;
                }


                System.Array
                f_1301_70731_70747_I(System.Array
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 70731, 70747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 70618, 71448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 70618, 71448);
            }
        }

        private void AddXmlInput(object input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 71460, 71847);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 71559, 71591);

                    f_1301_71559_71590(_xmlSerializer, input);
                }
                catch (IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 71620, 71836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 71806, 71821);

                    f_1301_71806_71820(                // we are assuming that process is already finished
                                                       // we should just stop processing at this point
                                    this);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 71620, 71836);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 71460, 71847);

                int
                f_1301_71559_71590(System.Management.Automation.Serializer
                this_param, object
                source)
                {
                    this_param.Serialize(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 71559, 71590);
                    return 0;
                }


                int
                f_1301_71806_71820(System.Management.Automation.ProcessInputWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 71806, 71820);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 71460, 71847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 71460, 71847);
            }
        }

        private StreamWriter _streamWriter;

        private NativeCommandIOFormat _inputFormat;

        internal void Start(Process process, NativeCommandIOFormat inputFormat)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 72391, 73599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 72487, 72554);

                f_1301_72487_72553(process != null, "caller should validate the paramter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 72786, 72964);

                Encoding
                pipeEncoding = f_1301_72810_72883(f_1301_72810_72826(_command), SpecialVariables.OutputEncodingVarPath) as System.Text.Encoding ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Text.Encoding>(1301, 72810, 72963) ?? Utils.utf8NoBom)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 72980, 73061);

                _streamWriter = f_1301_72996_73060(f_1301_73013_73045(f_1301_73013_73034(process)), pipeEncoding);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 73075, 73106);

                _streamWriter.AutoFlush = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 73122, 73149);

                _inputFormat = inputFormat;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 73165, 73588) || true) && (_inputFormat == NativeCommandIOFormat.Xml)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 73165, 73588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 73244, 73300);

                    f_1301_73244_73299(_streamWriter, ProcessOutputHandler.XmlCliTag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 73318, 73383);

                    _xmlSerializer = f_1301_73335_73382(f_1301_73350_73381(_streamWriter));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 73165, 73588);
                }

                else // Text

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 73165, 73588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 73457, 73533);

                    _pipeline = f_1301_73469_73532(f_1301_73469_73509("Out-String -Stream"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 73551, 73573);

                    f_1301_73551_73572(_pipeline, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 73165, 73588);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 72391, 73599);

                int
                f_1301_72487_72553(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 72487, 72553);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1301_72810_72826(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 72810, 72826);
                    return return_v;
                }


                object
                f_1301_72810_72883(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path)
                {
                    var return_v = this_param.GetVariableValue(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 72810, 72883);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1301_73013_73034(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StandardInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 73013, 73034);
                    return return_v;
                }


                System.IO.Stream
                f_1301_73013_73045(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1301, 73013, 73045);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1301_72996_73060(System.IO.Stream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamWriter(stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 72996, 73060);
                    return return_v;
                }


                int
                f_1301_73244_73299(System.IO.StreamWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 73244, 73299);
                    return 0;
                }


                System.Xml.XmlWriter
                f_1301_73350_73381(System.IO.StreamWriter
                output)
                {
                    var return_v = XmlWriter.Create((System.IO.TextWriter)output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 73350, 73381);
                    return return_v;
                }


                System.Management.Automation.Serializer
                f_1301_73335_73382(System.Xml.XmlWriter
                writer)
                {
                    var return_v = new System.Management.Automation.Serializer(writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 73335, 73382);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1301_73469_73509(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 73469, 73509);
                    return return_v;
                }


                System.Management.Automation.SteppablePipeline
                f_1301_73469_73532(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.GetSteppablePipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 73469, 73532);
                    return return_v;
                }


                int
                f_1301_73551_73572(System.Management.Automation.SteppablePipeline
                this_param, bool
                expectInput)
                {
                    this_param.Begin(expectInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 73551, 73572);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 72391, 73599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 72391, 73599);
            }
        }

        bool _stopping;

        internal void Stop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 73737, 73810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 73782, 73799);

                _stopping = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 73737, 73810);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 73737, 73810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 73737, 73810);
            }
        }

        internal void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 73822, 75064);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 74254, 74379) || true) && (_pipeline != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 74254, 74379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 74309, 74329);

                    f_1301_74309_74328(_pipeline);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 74347, 74364);

                    _pipeline = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 74254, 74379);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 74395, 74492) || true) && (_xmlSerializer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 74395, 74492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 74455, 74477);

                    _xmlSerializer = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 74395, 74492);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 74580, 75053) || true) && (_streamWriter != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 74580, 75053);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 74683, 74707);

                        f_1301_74683_74706(_streamWriter);
                    }
                    catch (IOException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1301, 74744, 74997);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1301, 74744, 74997);
                        // on unix, if process is already finished attempt to dispose it will
                        // lead to "Broken pipe" exception.
                        // we are ignoring it here
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 75017, 75038);

                    _streamWriter = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 74580, 75053);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 73822, 75064);

                int
                f_1301_74309_74328(System.Management.Automation.SteppablePipeline
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 74309, 74328);
                    return 0;
                }


                int
                f_1301_74683_74706(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 74683, 74706);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 73822, 75064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 73822, 75064);
            }
        }

        internal void Done()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 75076, 75759);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 75121, 75722) || true) && (_inputFormat == NativeCommandIOFormat.Xml)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 75121, 75722);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 75200, 75309) || true) && (_xmlSerializer != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 75200, 75309);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 75268, 75290);

                        f_1301_75268_75289(_xmlSerializer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 75200, 75309);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 75121, 75722);
                }

                else // Text

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 75121, 75722);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 75523, 75707) || true) && (_pipeline != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 75523, 75707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 75586, 75621);

                        var
                        finalResults = f_1301_75605_75620(_pipeline)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 75643, 75688);

                        f_1301_75643_75687(this, finalResults);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 75523, 75707);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 75121, 75722);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 75738, 75748);

                f_1301_75738_75747(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 75076, 75759);

                int
                f_1301_75268_75289(System.Management.Automation.Serializer
                this_param)
                {
                    this_param.Done();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 75268, 75289);
                    return 0;
                }


                System.Array
                f_1301_75605_75620(System.Management.Automation.SteppablePipeline
                this_param)
                {
                    var return_v = this_param.End();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 75605, 75620);
                    return return_v;
                }


                int
                f_1301_75643_75687(System.Management.Automation.ProcessInputWriter
                this_param, System.Array
                formattedObjects)
                {
                    this_param.AddTextInputFromFormattedArray(formattedObjects);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 75643, 75687);
                    return 0;
                }


                int
                f_1301_75738_75747(System.Management.Automation.ProcessInputWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 75738, 75747);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 75076, 75759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 75076, 75759);
            }
        }

        static ProcessInputWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1301, 69243, 75766);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1301, 69243, 75766);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 69243, 75766);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1301, 69243, 75766);

        int
        f_1301_69547_69614(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 69547, 69614);
            return 0;
        }

    }
    internal static class ConsoleVisibility
    {
        public static bool AlwaysCaptureApplicationIO { get; set; }

        [DllImport("Kernel32.dll")]
        internal static extern IntPtr GetConsoleWindow();

        internal const int
        SW_HIDE = 0
        ;

        internal const int
        SW_SHOWNORMAL = 1
        ;

        internal const int
        SW_NORMAL = 1
        ;

        internal const int
        SW_SHOWMINIMIZED = 2
        ;

        internal const int
        SW_SHOWMAXIMIZED = 3
        ;

        internal const int
        SW_MAXIMIZE = 3
        ;

        internal const int
        SW_SHOWNOACTIVATE = 4
        ;

        internal const int
        SW_SHOW = 5
        ;

        internal const int
        SW_MINIMIZE = 6
        ;

        internal const int
        SW_SHOWMINNOACTIVE = 7
        ;

        internal const int
        SW_SHOWNA = 8
        ;

        internal const int
        SW_RESTORE = 9
        ;

        internal const int
        SW_SHOWDEFAULT = 10
        ;

        internal const int
        SW_FORCEMINIMIZE = 11
        ;

        internal const int
        SW_MAX = 11
        ;

        [DllImport("user32.dll")]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool AllocConsole();

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        internal static bool AllocateHiddenConsole()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1301, 78795, 80222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 78924, 78975);

                IntPtr
                hwnd = f_1301_78938_78974()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 78989, 79074) || true) && (hwnd != IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 78989, 79074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 79046, 79059);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 78989, 79074);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 79194, 79259);

                IntPtr
                savedForeground = f_1301_79219_79258()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 79513, 79546);

                f_1301_79513_79545();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 79560, 79604);

                hwnd = f_1301_79567_79603();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 79620, 79637);

                bool
                returnValue
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 79651, 79960) || true) && (hwnd == IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 79651, 79960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 79708, 79728);

                    returnValue = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 79651, 79960);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 79651, 79960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 79794, 79813);

                    returnValue = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 79831, 79893);

                    f_1301_79831_79892(hwnd, ConsoleVisibility.SW_HIDE);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 79911, 79945);

                    AlwaysCaptureApplicationIO = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 79651, 79960);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 79976, 80176) || true) && (savedForeground != IntPtr.Zero && (DynAbs.Tracing.TraceSender.Expression_True(1301, 79980, 80072) && f_1301_80014_80053() != savedForeground))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 79976, 80176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 80106, 80161);

                    f_1301_80106_80160(savedForeground);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 79976, 80176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 80192, 80211);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1301, 78795, 80222);

                System.IntPtr
                f_1301_78938_78974()
                {
                    var return_v = ConsoleVisibility.GetConsoleWindow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 78938, 78974);
                    return return_v;
                }


                System.IntPtr
                f_1301_79219_79258()
                {
                    var return_v = ConsoleVisibility.GetForegroundWindow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 79219, 79258);
                    return return_v;
                }


                bool
                f_1301_79513_79545()
                {
                    var return_v = ConsoleVisibility.AllocConsole();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 79513, 79545);
                    return return_v;
                }


                System.IntPtr
                f_1301_79567_79603()
                {
                    var return_v = ConsoleVisibility.GetConsoleWindow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 79567, 79603);
                    return return_v;
                }


                bool
                f_1301_79831_79892(System.IntPtr
                hWnd, int
                nCmdShow)
                {
                    var return_v = ConsoleVisibility.ShowWindow(hWnd, nCmdShow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 79831, 79892);
                    return return_v;
                }


                System.IntPtr
                f_1301_80014_80053()
                {
                    var return_v = ConsoleVisibility.GetForegroundWindow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 80014, 80053);
                    return return_v;
                }


                bool
                f_1301_80106_80160(System.IntPtr
                hWnd)
                {
                    var return_v = ConsoleVisibility.SetForegroundWindow(hWnd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 80106, 80160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 78795, 80222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 78795, 80222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void Show()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1301, 80414, 80790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 80464, 80497);

                IntPtr
                hwnd = f_1301_80478_80496()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 80511, 80779) || true) && (hwnd != IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 80511, 80779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 80568, 80594);

                    f_1301_80568_80593(hwnd, SW_SHOW);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 80612, 80647);

                    AlwaysCaptureApplicationIO = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 80511, 80779);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 80511, 80779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 80713, 80764);

                    throw f_1301_80719_80763();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 80511, 80779);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1301, 80414, 80790);

                System.IntPtr
                f_1301_80478_80496()
                {
                    var return_v = GetConsoleWindow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 80478, 80496);
                    return return_v;
                }


                bool
                f_1301_80568_80593(System.IntPtr
                hWnd, int
                nCmdShow)
                {
                    var return_v = ShowWindow(hWnd, nCmdShow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 80568, 80593);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1301_80719_80763()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 80719, 80763);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 80414, 80790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 80414, 80790);
            }
        }

        public static void Hide()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1301, 80970, 81345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 81020, 81053);

                IntPtr
                hwnd = f_1301_81034_81052()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 81067, 81334) || true) && (hwnd != IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 81067, 81334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 81124, 81150);

                    f_1301_81124_81149(hwnd, SW_HIDE);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 81168, 81202);

                    AlwaysCaptureApplicationIO = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 81067, 81334);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 81067, 81334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 81268, 81319);

                    throw f_1301_81274_81318();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 81067, 81334);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1301, 80970, 81345);

                System.IntPtr
                f_1301_81034_81052()
                {
                    var return_v = GetConsoleWindow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 81034, 81052);
                    return return_v;
                }


                bool
                f_1301_81124_81149(System.IntPtr
                hWnd, int
                nCmdShow)
                {
                    var return_v = ShowWindow(hWnd, nCmdShow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 81124, 81149);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1301_81274_81318()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1301, 81274, 81318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 80970, 81345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 80970, 81345);
            }
        }

        static ConsoleVisibility()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1301, 75926, 81352);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76112, 76171);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76300, 76311);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76341, 76358);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76388, 76401);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76431, 76451);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76481, 76501);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76531, 76546);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76576, 76597);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76627, 76638);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76668, 76683);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76713, 76735);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76765, 76778);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76808, 76822);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76852, 76871);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76901, 76922);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 76952, 76963);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1301, 75926, 81352);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 75926, 81352);
        }

    }
    [Serializable]
    [SuppressMessage("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly")]
    public class RemoteException : RuntimeException
    {
        public RemoteException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1301, 81898, 81966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 84708, 84734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 84787, 84818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 85662, 85680);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1301, 81898, 81966);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 81898, 81966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 81898, 81966);
            }
        }

        public RemoteException(string message)
        : base(f_1301_82284_82291_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1301, 82225, 82314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 84708, 84734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 84787, 84818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 85662, 85680);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1301, 82225, 82314);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 82225, 82314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 82225, 82314);
            }
        }

        public RemoteException(string message, Exception innerException)
        : base(f_1301_82905_82912_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1301, 82820, 82951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 84708, 84734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 84787, 84818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 85662, 85680);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1301, 82820, 82951);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 82820, 82951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 82820, 82951);
            }
        }

        internal RemoteException
                (
                    string message,
                    PSObject serializedRemoteException,
                    PSObject serializedRemoteInvocationInfo
                )
        : base(f_1301_83725_83732_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1301, 83527, 83903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 84708, 84734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 84787, 84818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 85662, 85680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 83758, 83813);

                _serializedRemoteException = serializedRemoteException;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 83827, 83892);

                _serializedRemoteInvocationInfo = serializedRemoteInvocationInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1301, 83527, 83903);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 83527, 83903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 83527, 83903);
            }
        }

        protected RemoteException(SerializationInfo info, StreamingContext context)
        : base(f_1301_84596_84600_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1301, 84500, 84632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 84708, 84734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 84787, 84818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 85662, 85680);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1301, 84500, 84632);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 84500, 84632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 84500, 84632);
            }
        }

        [NonSerialized]
        private PSObject _serializedRemoteException;

        [NonSerialized]
        private PSObject _serializedRemoteInvocationInfo;

        public PSObject SerializedRemoteException
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 85100, 85185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 85136, 85170);

                    return _serializedRemoteException;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 85100, 85185);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 85034, 85196);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 85034, 85196);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSObject SerializedRemoteInvocationInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 85529, 85619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 85565, 85604);

                    return _serializedRemoteInvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 85529, 85619);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 85458, 85630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 85458, 85630);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _remoteErrorRecord;

        internal void SetRemoteErrorRecord(ErrorRecord remoteError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 85860, 85988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 85944, 85977);

                _remoteErrorRecord = remoteError;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 85860, 85988);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 85860, 85988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 85860, 85988);
            }
        }

        public override ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1301, 86167, 86341);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 86203, 86282) || true) && (_remoteErrorRecord != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1301, 86203, 86282);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 86256, 86282);

                        return _remoteErrorRecord;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1301, 86203, 86282);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1301, 86302, 86326);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ErrorRecord, 1301, 86309, 86325);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1301, 86167, 86341);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1301, 86103, 86352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 86103, 86352);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static RemoteException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1301, 81623, 86359);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1301, 81623, 86359);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1301, 81623, 86359);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1301, 81623, 86359);

        static string
        f_1301_82284_82291_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1301, 82225, 82314);
            return return_v;
        }


        static string
        f_1301_82905_82912_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1301, 82820, 82951);
            return return_v;
        }


        static string
        f_1301_83725_83732_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1301, 83527, 83903);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1301_84596_84600_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1301, 84500, 84632);
            return return_v;
        }

    }
}
