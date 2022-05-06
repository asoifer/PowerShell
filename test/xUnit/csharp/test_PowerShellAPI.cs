// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using Xunit;

namespace PSTests.Sequential
{
    public static class PowerShellHostingScenario
    {
        [Fact]
        public static void TestStartJobThrowTerminatingException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(958, 267, 868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(958, 366, 857);
                using (var
                ps = f_958_382_401()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(958, 435, 517);

                    f_958_435_516(f_958_435_461(ps, "Start-Job"), "ScriptBlock", f_958_490_515("1+1"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(958, 535, 610);

                    var
                    ex = f_958_544_609(() => ps.Invoke())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(958, 628, 692);

                    f_958_628_691(f_958_673_690(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(958, 710, 842);

                    f_958_710_841("IPCPwshExecutableNotFound,Microsoft.PowerShell.Commands.StartJobCommand", f_958_804_840(f_958_804_818(ex)));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(958, 366, 857);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(958, 267, 868);

                System.Management.Automation.PowerShell
                f_958_382_401()
                {
                    var return_v = PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(958, 382, 401);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_958_435_461(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(958, 435, 461);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_958_490_515(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(958, 490, 515);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_958_435_516(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ScriptBlock
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(958, 435, 516);
                    return return_v;
                }


                System.Management.Automation.CmdletInvocationException
                f_958_544_609(System.Func<object>
                testCode)
                {
                    var return_v = CustomAssert.Throws<CmdletInvocationException>(testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(958, 544, 609);
                    return return_v;
                }


                System.Exception
                f_958_673_690(System.Management.Automation.CmdletInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(958, 673, 690);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_958_628_691(System.Exception
                @object)
                {
                    var return_v = CustomAssert.IsType<PSNotSupportedException>((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(958, 628, 691);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_958_804_818(System.Management.Automation.CmdletInvocationException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(958, 804, 818);
                    return return_v;
                }


                string
                f_958_804_840(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(958, 804, 840);
                    return return_v;
                }


                bool
                f_958_710_841(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(958, 710, 841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(958, 267, 868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(958, 267, 868);
            }
        }

        static PowerShellHostingScenario()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(958, 205, 875);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(958, 205, 875);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(958, 205, 875);
        }

    }
}
