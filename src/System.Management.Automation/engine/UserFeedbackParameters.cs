// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Globalization;
using System.Management.Automation.Language;

namespace System.Management.Automation
{
    public sealed class PagingParameters
    {
        internal PagingParameters(MshCommandRuntime commandRuntime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1371, 523, 811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 1342, 1395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 1655, 1728);
                this.First = UInt64.MaxValue;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 607, 745) || true) && (commandRuntime == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1371, 607, 745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 667, 730);

                    throw f_1371_673_729("commandRuntime");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1371, 607, 745);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 761, 800);

                commandRuntime.PagingParameters = this;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1371, 523, 811);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1371, 523, 811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1371, 523, 811);
            }
        }

        [Parameter]
        public SwitchParameter IncludeTotalCount { get; set; }

        [Parameter]
        public UInt64 Skip { get; set; }

        [Parameter]
        public UInt64 First { get; set; }

        public PSObject NewTotalCount(UInt64 totalCount, double accuracy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1371, 2669, 4070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 2759, 2802);

                PSObject
                result = f_1371_2777_2801(totalCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 2818, 3661);

                string
                toStringMethodBody = f_1371_2846_3660(f_1371_2878_2904(), @"
                    $totalCount = $this.PSObject.BaseObject
                    switch ($this.Accuracy) {{
                        {{ $_ -ge 1.0 }} {{ '{0}' -f $totalCount }}
                        {{ $_ -le 0.0 }} {{ '{1}' -f $totalCount }}
                        default          {{ '{2}' -f $totalCount }}
                    }}
                ", f_1371_3303_3409(f_1371_3350_3408()), f_1371_3428_3533(f_1371_3475_3532()), f_1371_3552_3659(f_1371_3599_3658()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 3675, 3778);

                PSScriptMethod
                toStringMethod = f_1371_3707_3777("ToString", f_1371_3738_3776(toStringMethodBody))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 3792, 3827);

                f_1371_3792_3826(f_1371_3792_3806(result), toStringMethod);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 3843, 3893);

                accuracy = f_1371_3854_3892(0.0, f_1371_3868_3891(1.0, accuracy));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 3907, 3980);

                PSNoteProperty
                statusProperty = f_1371_3939_3979("Accuracy", accuracy)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 3994, 4029);

                f_1371_3994_4028(f_1371_3994_4008(result), statusProperty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 4045, 4059);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1371, 2669, 4070);

                System.Management.Automation.PSObject
                f_1371_2777_2801(ulong
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 2777, 2801);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1371_2878_2904()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1371, 2878, 2904);
                    return return_v;
                }


                string
                f_1371_3350_3408()
                {
                    var return_v = CommandBaseStrings.PagingSupportAccurateTotalCountTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1371, 3350, 3408);
                    return return_v;
                }


                string
                f_1371_3303_3409(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 3303, 3409);
                    return return_v;
                }


                string
                f_1371_3475_3532()
                {
                    var return_v = CommandBaseStrings.PagingSupportUnknownTotalCountTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1371, 3475, 3532);
                    return return_v;
                }


                string
                f_1371_3428_3533(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 3428, 3533);
                    return return_v;
                }


                string
                f_1371_3599_3658()
                {
                    var return_v = CommandBaseStrings.PagingSupportEstimatedTotalCountTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1371, 3599, 3658);
                    return return_v;
                }


                string
                f_1371_3552_3659(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 3552, 3659);
                    return return_v;
                }


                string
                f_1371_2846_3660(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 2846, 3660);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1371_3738_3776(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 3738, 3776);
                    return return_v;
                }


                System.Management.Automation.PSScriptMethod
                f_1371_3707_3777(string
                name, System.Management.Automation.ScriptBlock
                script)
                {
                    var return_v = new System.Management.Automation.PSScriptMethod(name, script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 3707, 3777);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1371_3792_3806(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1371, 3792, 3806);
                    return return_v;
                }


                int
                f_1371_3792_3826(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSScriptMethod
                member)
                {
                    this_param.Add((System.Management.Automation.PSMemberInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 3792, 3826);
                    return 0;
                }


                double
                f_1371_3868_3891(double
                val1, double
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 3868, 3891);
                    return return_v;
                }


                double
                f_1371_3854_3892(double
                val1, double
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 3854, 3892);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1371_3939_3979(string
                name, double
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 3939, 3979);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1371_3994_4008(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1371, 3994, 4008);
                    return return_v;
                }


                int
                f_1371_3994_4028(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSMemberInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 3994, 4028);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1371, 2669, 4070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1371, 2669, 4070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PagingParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1371, 446, 4120);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1371, 446, 4120);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1371, 446, 4120);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1371, 446, 4120);

        System.Management.Automation.PSArgumentNullException
        f_1371_673_729(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 673, 729);
            return return_v;
        }

    }
}

namespace System.Management.Automation.Internal
{
    public sealed class ShouldProcessParameters
    {
        internal ShouldProcessParameters(MshCommandRuntime commandRuntime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1371, 4735, 5024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 6002, 6017);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 4826, 4964) || true) && (commandRuntime == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1371, 4826, 4964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 4886, 4949);

                    throw f_1371_4892_4948("commandRuntime");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1371, 4826, 4964);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 4980, 5013);

                _commandRuntime = commandRuntime;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1371, 4735, 5024);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1371, 4735, 5024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1371, 4735, 5024);
            }
        }

        [Parameter]
        [Alias("wi")]
        public SwitchParameter WhatIf
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1371, 5314, 5395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 5350, 5380);

                    return f_1371_5357_5379(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1371, 5314, 5395);

                    System.Management.Automation.SwitchParameter
                    f_1371_5357_5379(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.WhatIf;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1371, 5357, 5379);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1371, 5216, 5504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1371, 5216, 5504);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1371, 5411, 5493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 5447, 5478);

                    _commandRuntime.WhatIf = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1371, 5411, 5493);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1371, 5216, 5504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1371, 5216, 5504);
                }
            }
        }

        [Parameter]
        [Alias("cf")]
        public SwitchParameter Confirm
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1371, 5741, 5823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 5777, 5808);

                    return f_1371_5784_5807(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1371, 5741, 5823);

                    System.Management.Automation.SwitchParameter
                    f_1371_5784_5807(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.Confirm;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1371, 5784, 5807);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1371, 5642, 5933);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1371, 5642, 5933);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1371, 5839, 5922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 5875, 5907);

                    _commandRuntime.Confirm = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1371, 5839, 5922);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1371, 5642, 5933);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1371, 5642, 5933);
                }
            }
        }

        private MshCommandRuntime _commandRuntime;

        static ShouldProcessParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1371, 4318, 6025);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1371, 4318, 6025);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1371, 4318, 6025);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1371, 4318, 6025);

        System.Management.Automation.PSArgumentNullException
        f_1371_4892_4948(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1371, 4892, 4948);
            return return_v;
        }

    }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.MSInternal", "CA903:InternalNamespaceShouldNotContainPublicTypes", Justification = "These are only exposed by way of the PowerShell cmdlets that surface them.")]
    public sealed class TransactionParameters
    {
        internal TransactionParameters(MshCommandRuntime commandRuntime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1371, 6827, 6960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 7546, 7561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 6916, 6949);

                _commandRuntime = commandRuntime;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1371, 6827, 6960);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1371, 6827, 6960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1371, 6827, 6960);
            }
        }

        [Parameter]
        [Alias("usetx")]
        public SwitchParameter UseTransaction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1371, 7269, 7358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 7305, 7343);

                    return f_1371_7312_7342(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1371, 7269, 7358);

                    System.Management.Automation.SwitchParameter
                    f_1371_7312_7342(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.UseTransaction;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1371, 7312, 7342);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1371, 7160, 7475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1371, 7160, 7475);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1371, 7374, 7464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1371, 7410, 7449);

                    _commandRuntime.UseTransaction = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1371, 7374, 7464);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1371, 7160, 7475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1371, 7160, 7475);
                }
            }
        }

        private MshCommandRuntime _commandRuntime;

        static TransactionParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1371, 6185, 7569);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1371, 6185, 7569);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1371, 6185, 7569);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1371, 6185, 7569);
    }
}

