// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Internal.Host
{
    internal partial
        class InternalHostUserInterface : PSHostUserInterface
    {
        public override
                PSCredential
                PromptForCredential
                (
                    string caption,
                    string message,
                    string userName,
                    string targetName
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1466, 479, 973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1466, 711, 962);

                return f_1466_718_961(this, caption, message, userName, targetName, PSCredentialTypes.Default, PSCredentialUIOptions.Default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1466, 479, 973);

                System.Management.Automation.PSCredential
                f_1466_718_961(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                caption, string
                message, string
                userName, string
                targetName, System.Management.Automation.PSCredentialTypes
                allowedCredentialTypes, System.Management.Automation.PSCredentialUIOptions
                options)
                {
                    var return_v = this_param.PromptForCredential(caption, message, userName, targetName, allowedCredentialTypes, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1466, 718, 961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1466, 479, 973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1466, 479, 973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                PSCredential
                PromptForCredential
                (
                    string caption,
                    string message,
                    string userName,
                    string targetName,
                    PSCredentialTypes allowedCredentialTypes,
                    PSCredentialUIOptions options
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1466, 1063, 2229);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1466, 1394, 1501) || true) && (_externalUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1466, 1394, 1501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1466, 1451, 1486);

                    f_1466_1451_1485(this, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1466, 1394, 1501);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1466, 1517, 1544);

                PSCredential
                result = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1466, 1594, 1708);

                    result = f_1466_1603_1707(_externalUI, caption, message, userName, targetName, allowedCredentialTypes, options);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1466, 1737, 2188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1466, 1921, 2034);

                    LocalPipeline
                    lpl = (LocalPipeline)f_1466_1956_2033(((RunspaceBase)f_1466_1971_2002(f_1466_1971_1986(_parent))))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1466, 2052, 2134) || true) && (lpl == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1466, 2052, 2134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1466, 2109, 2115);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1466, 2052, 2134);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1466, 2154, 2173);

                    f_1466_2154_2172(f_1466_2154_2165(lpl));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1466, 1737, 2188);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1466, 2204, 2218);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1466, 1063, 2229);

                int
                f_1466_1451_1485(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                promptMessage)
                {
                    this_param.ThrowPromptNotInteractive(promptMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1466, 1451, 1485);
                    return 0;
                }


                System.Management.Automation.PSCredential
                f_1466_1603_1707(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                caption, string
                message, string
                userName, string
                targetName, System.Management.Automation.PSCredentialTypes
                allowedCredentialTypes, System.Management.Automation.PSCredentialUIOptions
                options)
                {
                    var return_v = this_param.PromptForCredential(caption, message, userName, targetName, allowedCredentialTypes, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1466, 1603, 1707);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1466_1971_1986(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1466, 1971, 1986);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1466_1971_2002(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1466, 1971, 2002);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1466_1956_2033(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1466, 1956, 2033);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStopper
                f_1466_2154_2165(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Stopper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1466, 2154, 2165);
                    return return_v;
                }


                int
                f_1466_2154_2172(System.Management.Automation.Runspaces.PipelineStopper
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1466, 2154, 2172);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1466, 1063, 2229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1466, 1063, 2229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}

