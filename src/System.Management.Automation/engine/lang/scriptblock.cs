// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;

namespace System.Management.Automation
{
    public partial class ScriptBlock
    {
        internal static ScriptBlock Create(ExecutionContext context, string script)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1526, 2891, 3294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 2991, 3058);

                ScriptBlock
                sb = f_1526_3008_3057(f_1526_3015_3029(context).EngineParser, null, script)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 3072, 3257) || true) && (f_1526_3076_3102(context) != null && (DynAbs.Tracing.TraceSender.Expression_True(1526, 3076, 3155) && f_1526_3114_3147(f_1526_3114_3140(context)) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 3072, 3257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 3189, 3242);

                    sb.SessionStateInternal = f_1526_3215_3241(context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 3072, 3257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 3273, 3283);

                return sb;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1526, 2891, 3294);

                System.Management.Automation.AutomationEngine
                f_1526_3015_3029(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Engine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 3015, 3029);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1526_3008_3057(System.Management.Automation.Language.Parser
                parser, string
                fileName, string
                fileContents)
                {
                    var return_v = Create(parser, fileName, fileContents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 3008, 3057);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1526_3076_3102(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 3076, 3102);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1526_3114_3140(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 3114, 3140);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1526_3114_3147(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 3114, 3147);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1526_3215_3241(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 3215, 3241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 2891, 3294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 2891, 3294);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ScriptBlock Create(string script)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 3581, 3699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 3584, 3699);
                return f_1526_3584_3699(parser: f_1526_3613_3634(), fileName: null, fileContents: script);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 3581, 3699);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 3581, 3699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 3581, 3699);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Language.Parser
            f_1526_3613_3634()
            {
                var return_v = new System.Management.Automation.Language.Parser();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 3613, 3634);
                return return_v;
            }


            System.Management.Automation.ScriptBlock
            f_1526_3584_3699(System.Management.Automation.Language.Parser
            parser, string
            fileName, string
            fileContents)
            {
                var return_v = Create(parser: parser, fileName: fileName, fileContents: fileContents);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 3584, 3699);
                return return_v;
            }

        }

        internal static ScriptBlock CreateDelayParsedScriptBlock(string script, bool isProductCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 3817, 3913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 3820, 3913);
                return new ScriptBlock(f_1526_3836_3886(script, isProductCode)) { DebuggerHidden = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1526, 3820, 3913) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 3817, 3913);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 3817, 3913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 3817, 3913);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.CompiledScriptBlockData
            f_1526_3836_3886(string
            scriptText, bool
            isProductCode)
            {
                var return_v = new System.Management.Automation.CompiledScriptBlockData(scriptText, isProductCode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 3836, 3886);
                return return_v;
            }

        }

        public ScriptBlock GetNewClosure()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 4152, 4343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 4211, 4251);

                PSModuleInfo
                m = f_1526_4228_4250(true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 4265, 4283);

                f_1526_4265_4282(m);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 4297, 4332);

                return f_1526_4304_4331(m, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 4152, 4343);

                System.Management.Automation.PSModuleInfo
                f_1526_4228_4250(bool
                linkToGlobal)
                {
                    var return_v = new System.Management.Automation.PSModuleInfo(linkToGlobal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 4228, 4250);
                    return return_v;
                }


                int
                f_1526_4265_4282(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    this_param.CaptureLocals();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 4265, 4282);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1526_4304_4331(System.Management.Automation.PSModuleInfo
                this_param, System.Management.Automation.ScriptBlock
                scriptBlockToBind)
                {
                    var return_v = this_param.NewBoundScriptBlock(scriptBlockToBind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 4304, 4331);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 4152, 4343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 4152, 4343);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShell GetPowerShell(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 6854, 7108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 6857, 7108);
                return f_1526_6857_7108(this, context: f_1526_6898_6940(), variables: null, isTrustedInput: false, filterNonUsingVariables: false, createLocalScope: null, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 6854, 7108);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 6854, 7108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 6854, 7108);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.ExecutionContext
            f_1526_6898_6940()
            {
                var return_v = LocalPipeline.GetExecutionContextFromTLS();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 6898, 6940);
                return return_v;
            }


            System.Management.Automation.PowerShell
            f_1526_6857_7108(System.Management.Automation.ScriptBlock
            this_param, System.Management.Automation.ExecutionContext
            context, System.Collections.Generic.Dictionary<string, object>
            variables, bool
            isTrustedInput, bool
            filterNonUsingVariables, bool?
            createLocalScope, params object[]
            args)
            {
                var return_v = this_param.GetPowerShellImpl(context: context, variables: variables, isTrustedInput: isTrustedInput, filterNonUsingVariables: filterNonUsingVariables, createLocalScope: createLocalScope, args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 6857, 7108);
                return return_v;
            }

        }

        public PowerShell GetPowerShell(bool isTrustedInput, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 8079, 8350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 8082, 8350);
                return f_1526_8082_8350(this, context: f_1526_8127_8169(), variables: null, isTrustedInput, filterNonUsingVariables: false, createLocalScope: null, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 8079, 8350);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 8079, 8350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 8079, 8350);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.ExecutionContext
            f_1526_8127_8169()
            {
                var return_v = LocalPipeline.GetExecutionContextFromTLS();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 8127, 8169);
                return return_v;
            }


            System.Management.Automation.PowerShell
            f_1526_8082_8350(System.Management.Automation.ScriptBlock
            this_param, System.Management.Automation.ExecutionContext
            context, System.Collections.Generic.Dictionary<string, object>
            variables, bool
            isTrustedInput, bool
            filterNonUsingVariables, bool?
            createLocalScope, params object[]
            args)
            {
                var return_v = this_param.GetPowerShellImpl(context: context, variables: variables, isTrustedInput, filterNonUsingVariables: filterNonUsingVariables, createLocalScope: createLocalScope, args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 8082, 8350);
                return return_v;
            }

        }

        public PowerShell GetPowerShell(Dictionary<string, object> variables, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 10101, 10674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 10217, 10287);

                ExecutionContext
                context = f_1526_10244_10286()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 10301, 10353);

                Dictionary<string, object>
                suppliedVariables = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 10369, 10568) || true) && (variables != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 10369, 10568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 10424, 10520);

                    suppliedVariables = f_1526_10444_10519(variables, f_1526_10486_10518());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 10538, 10553);

                    context = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 10369, 10568);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 10584, 10663);

                return f_1526_10591_10662(this, context, suppliedVariables, false, false, null, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 10101, 10674);

                System.Management.Automation.ExecutionContext
                f_1526_10244_10286()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 10244, 10286);
                    return return_v;
                }


                System.StringComparer
                f_1526_10486_10518()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 10486, 10518);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1526_10444_10519(System.Collections.Generic.Dictionary<string, object>
                dictionary, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, object>((System.Collections.Generic.IDictionary<string, object>)dictionary, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 10444, 10519);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1526_10591_10662(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.Dictionary<string, object>
                variables, bool
                isTrustedInput, bool
                filterNonUsingVariables, bool?
                createLocalScope, params object[]
                args)
                {
                    var return_v = this_param.GetPowerShellImpl(context, variables, isTrustedInput, filterNonUsingVariables, createLocalScope, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 10591, 10662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 10101, 10674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 10101, 10674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShell GetPowerShell(
                    Dictionary<string, object> variables,
                    out Dictionary<string, object> usingVariables,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 12798, 12874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 12801, 12874);
                return f_1526_12801_12874(this, variables, out usingVariables, isTrustedInput: false, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 12798, 12874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 12798, 12874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 12798, 12874);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.PowerShell
            f_1526_12801_12874(System.Management.Automation.ScriptBlock
            this_param, System.Collections.Generic.Dictionary<string, object>
            variables, out System.Collections.Generic.Dictionary<string, object>
            usingVariables, bool
            isTrustedInput, params object[]
            args)
            {
                var return_v = this_param.GetPowerShell(variables, out usingVariables, isTrustedInput: isTrustedInput, args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 12801, 12874);
                return return_v;
            }

        }

        public PowerShell GetPowerShell(
                    Dictionary<string, object> variables,
                    out Dictionary<string, object> usingVariables,
                    bool isTrustedInput,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 14999, 15801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 15236, 15306);

                ExecutionContext
                context = f_1526_15263_15305()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 15320, 15372);

                Dictionary<string, object>
                suppliedVariables = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 15388, 15587) || true) && (variables != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 15388, 15587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 15443, 15539);

                    suppliedVariables = f_1526_15463_15538(variables, f_1526_15505_15537());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 15557, 15572);

                    context = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 15388, 15587);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 15603, 15707);

                PowerShell
                powershell = f_1526_15627_15706(this, context, suppliedVariables, isTrustedInput, true, null, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 15721, 15756);

                usingVariables = suppliedVariables;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 15772, 15790);

                return powershell;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 14999, 15801);

                System.Management.Automation.ExecutionContext
                f_1526_15263_15305()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 15263, 15305);
                    return return_v;
                }


                System.StringComparer
                f_1526_15505_15537()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 15505, 15537);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1526_15463_15538(System.Collections.Generic.Dictionary<string, object>
                dictionary, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, object>((System.Collections.Generic.IDictionary<string, object>)dictionary, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 15463, 15538);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1526_15627_15706(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.Dictionary<string, object>
                variables, bool
                isTrustedInput, bool
                filterNonUsingVariables, bool?
                createLocalScope, params object[]
                args)
                {
                    var return_v = this_param.GetPowerShellImpl(context, variables, isTrustedInput, filterNonUsingVariables, createLocalScope, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 15627, 15706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 14999, 15801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 14999, 15801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PowerShell GetPowerShell(
                    ExecutionContext context,
                    bool isTrustedInput,
                    bool? useLocalScope,
                    object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 15996, 16214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 15999, 16214);
                return f_1526_15999_16214(this, context, variables: null, isTrustedInput, filterNonUsingVariables: false, useLocalScope, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 15996, 16214);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 15996, 16214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 15996, 16214);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.PowerShell
            f_1526_15999_16214(System.Management.Automation.ScriptBlock
            this_param, System.Management.Automation.ExecutionContext
            context, System.Collections.Generic.Dictionary<string, object>
            variables, bool
            isTrustedInput, bool
            filterNonUsingVariables, bool?
            createLocalScope, params object[]
            args)
            {
                var return_v = this_param.GetPowerShellImpl(context, variables: variables, isTrustedInput, filterNonUsingVariables: filterNonUsingVariables, createLocalScope, args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 15999, 16214);
                return return_v;
            }

        }

        [SuppressMessage(
                    "Microsoft.Naming",
                    "CA1704:IdentifiersShouldBeSpelledCorrectly",
                    MessageId = "Steppable",
                    Justification = "Review this during API naming")]
        public SteppablePipeline GetSteppablePipeline()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 16662, 16740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 16665, 16740);
                return f_1526_16665_16740(this, commandOrigin: CommandOrigin.Internal, args: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 16662, 16740);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 16662, 16740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 16662, 16740);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.SteppablePipeline
            f_1526_16665_16740(System.Management.Automation.ScriptBlock
            this_param, System.Management.Automation.CommandOrigin
            commandOrigin, object[]
            args)
            {
                var return_v = this_param.GetSteppablePipelineImpl(commandOrigin: commandOrigin, args: args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 16665, 16740);
                return return_v;
            }

        }

        [SuppressMessage(
                    "Microsoft.Naming",
                    "CA1704:IdentifiersShouldBeSpelledCorrectly",
                    MessageId = "Steppable",
                    Justification = "Review this during API naming")]
        public SteppablePipeline GetSteppablePipeline(CommandOrigin commandOrigin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 17217, 17271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 17220, 17271);
                return f_1526_17220_17271(this, commandOrigin, args: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 17217, 17271);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 17217, 17271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 17217, 17271);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.SteppablePipeline
            f_1526_17220_17271(System.Management.Automation.ScriptBlock
            this_param, System.Management.Automation.CommandOrigin
            commandOrigin, object[]
            args)
            {
                var return_v = this_param.GetSteppablePipelineImpl(commandOrigin, args: args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 17220, 17271);
                return return_v;
            }

        }

        [SuppressMessage(
                    "Microsoft.Naming",
                    "CA1704:IdentifiersShouldBeSpelledCorrectly",
                    MessageId = "Steppable",
                    Justification = "Review this during API naming")]
        public SteppablePipeline GetSteppablePipeline(CommandOrigin commandOrigin, object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 17761, 17809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 17764, 17809);
                return f_1526_17764_17809(this, commandOrigin, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 17761, 17809);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 17761, 17809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 17761, 17809);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.SteppablePipeline
            f_1526_17764_17809(System.Management.Automation.ScriptBlock
            this_param, System.Management.Automation.CommandOrigin
            commandOrigin, object[]
            args)
            {
                var return_v = this_param.GetSteppablePipelineImpl(commandOrigin, args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 17764, 17809);
                return return_v;
            }

        }

        public Collection<PSObject> Invoke(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 18544, 18638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 18560, 18638);
                return f_1526_18560_18638(this, dollarUnder: f_1526_18582_18602(), input: f_1526_18611_18631(), args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 18544, 18638);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 18544, 18638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 18544, 18638);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.PSObject
            f_1526_18582_18602()
            {
                var return_v = AutomationNull.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 18582, 18602);
                return return_v;
            }


            System.Management.Automation.PSObject
            f_1526_18611_18631()
            {
                var return_v = AutomationNull.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 18611, 18631);
                return return_v;
            }


            System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
            f_1526_18560_18638(System.Management.Automation.ScriptBlock
            this_param, System.Management.Automation.PSObject
            dollarUnder, System.Management.Automation.PSObject
            input, object[]
            args)
            {
                var return_v = this_param.DoInvoke(dollarUnder: (object)dollarUnder, input: (object)input, args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 18560, 18638);
                return return_v;
            }

        }

        public Collection<PSObject> InvokeWithContext(
                    IDictionary functionsToDefine,
                    List<PSVariable> variablesToDefine,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 19469, 20894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 19668, 19735);

                Dictionary<string, ScriptBlock>
                functionsToDefineDictionary = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 19749, 20736) || true) && (functionsToDefine != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 19749, 20736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 19812, 19880);

                    functionsToDefineDictionary = f_1526_19842_19879();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 19898, 20721);
                        foreach (DictionaryEntry pair in f_1526_19931_19948_I(functionsToDefine))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 19898, 20721);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 19990, 20031);

                            string
                            functionName = pair.Key as string
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 20053, 20463) || true) && (f_1526_20057_20096(functionName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 20053, 20463);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 20146, 20314);

                                PSInvalidOperationException
                                e = f_1526_20178_20313(f_1526_20251_20312())
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 20342, 20406);

                                f_1526_20342_20405(
                                                        e, "EmptyFunctionNameInFunctionDefinitionDictionary");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 20432, 20440);

                                throw e;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 20053, 20463);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 20487, 20540);

                            ScriptBlock
                            functionBody = pair.Value as ScriptBlock
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 20642, 20702);

                            f_1526_20642_20701(                    // null check for functionBody is done at the lower layer.
                                                functionsToDefineDictionary, functionName, functionBody);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 19898, 20721);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1526, 1, 824);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1526, 1, 824);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 19749, 20736);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 20752, 20883);

                return f_1526_20759_20882(this, functionsToDefineDictionary, variablesToDefine, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 19469, 20894);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                f_1526_19842_19879()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 19842, 19879);
                    return return_v;
                }


                bool
                f_1526_20057_20096(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 20057, 20096);
                    return return_v;
                }


                string
                f_1526_20251_20312()
                {
                    var return_v = ParserStrings.EmptyFunctionNameInFunctionDefinitionDictionary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 20251, 20312);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1526_20178_20313(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 20178, 20313);
                    return return_v;
                }


                int
                f_1526_20342_20405(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 20342, 20405);
                    return 0;
                }


                int
                f_1526_20642_20701(System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                this_param, string
                key, System.Management.Automation.ScriptBlock
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 20642, 20701);
                    return 0;
                }


                System.Collections.IDictionary
                f_1526_19931_19948_I(System.Collections.IDictionary
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 19931, 19948);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1526_20759_20882(System.Management.Automation.ScriptBlock
                this_param, System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                functionsToDefine, System.Collections.Generic.List<System.Management.Automation.PSVariable>
                variablesToDefine, params object[]
                args)
                {
                    var return_v = this_param.InvokeWithContext(functionsToDefine, variablesToDefine, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 20759, 20882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 19469, 20894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 19469, 20894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> InvokeWithContext(
                    Dictionary<string, ScriptBlock> functionsToDefine,
                    List<PSVariable> variablesToDefine,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 21527, 23704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 21746, 21782);

                object
                input = f_1526_21761_21781()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 21796, 21838);

                object
                dollarUnder = f_1526_21817_21837()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 21852, 21893);

                object
                scriptThis = f_1526_21872_21892()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 21909, 23050) || true) && (variablesToDefine != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 21909, 23050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 22046, 22194);

                    PSVariable
                    located = f_1526_22067_22193(variablesToDefine, v => string.Equals(v.Name, "this", StringComparison.OrdinalIgnoreCase))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 22212, 22375) || true) && (located != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 22212, 22375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 22273, 22300);

                        scriptThis = f_1526_22286_22299(located);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 22322, 22356);

                        f_1526_22322_22355(variablesToDefine, located);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 22212, 22375);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 22395, 22519);

                    located = f_1526_22405_22518(variablesToDefine, v => string.Equals(v.Name, "_", StringComparison.Ordinal));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 22537, 22701) || true) && (located != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 22537, 22701);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 22598, 22626);

                        dollarUnder = f_1526_22612_22625(located);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 22648, 22682);

                        f_1526_22648_22681(variablesToDefine, located);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 22537, 22701);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 22721, 22859);

                    located = f_1526_22731_22858(variablesToDefine, v => string.Equals(v.Name, "input", StringComparison.OrdinalIgnoreCase));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 22877, 23035) || true) && (located != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 22877, 23035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 22938, 22960);

                        input = f_1526_22946_22959(located);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 22982, 23016);

                        f_1526_22982_23015(variablesToDefine, located);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 22877, 23035);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 21909, 23050);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 23066, 23107);

                List<object>
                result = f_1526_23088_23106()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 23121, 23156);

                Pipe
                outputPipe = f_1526_23139_23155(result)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 23172, 23647);

                f_1526_23172_23646(this, useLocalScope: true, functionsToDefine: functionsToDefine, variablesToDefine: variablesToDefine, errorHandlingBehavior: ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: dollarUnder, input: input, scriptThis: scriptThis, outputPipe: outputPipe, invocationInfo: null, args: args);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 23661, 23693);

                return f_1526_23668_23692(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 21527, 23704);

                System.Management.Automation.PSObject
                f_1526_21761_21781()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 21761, 21781);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_21817_21837()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 21817, 21837);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_21872_21892()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 21872, 21892);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1526_22067_22193(System.Collections.Generic.List<System.Management.Automation.PSVariable>
                source, System.Func<System.Management.Automation.PSVariable, bool>
                predicate)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.PSVariable>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 22067, 22193);
                    return return_v;
                }


                object
                f_1526_22286_22299(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 22286, 22299);
                    return return_v;
                }


                bool
                f_1526_22322_22355(System.Collections.Generic.List<System.Management.Automation.PSVariable>
                this_param, System.Management.Automation.PSVariable
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 22322, 22355);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1526_22405_22518(System.Collections.Generic.List<System.Management.Automation.PSVariable>
                source, System.Func<System.Management.Automation.PSVariable, bool>
                predicate)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.PSVariable>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 22405, 22518);
                    return return_v;
                }


                object
                f_1526_22612_22625(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 22612, 22625);
                    return return_v;
                }


                bool
                f_1526_22648_22681(System.Collections.Generic.List<System.Management.Automation.PSVariable>
                this_param, System.Management.Automation.PSVariable
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 22648, 22681);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1526_22731_22858(System.Collections.Generic.List<System.Management.Automation.PSVariable>
                source, System.Func<System.Management.Automation.PSVariable, bool>
                predicate)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.PSVariable>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 22731, 22858);
                    return return_v;
                }


                object
                f_1526_22946_22959(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 22946, 22959);
                    return return_v;
                }


                bool
                f_1526_22982_23015(System.Collections.Generic.List<System.Management.Automation.PSVariable>
                this_param, System.Management.Automation.PSVariable
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 22982, 23015);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1526_23088_23106()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 23088, 23106);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1526_23139_23155(System.Collections.Generic.List<object>
                resultList)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(resultList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 23139, 23155);
                    return return_v;
                }


                int
                f_1526_23172_23646(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                functionsToDefine, System.Collections.Generic.List<System.Management.Automation.PSVariable>
                variablesToDefine, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, object
                dollarUnder, object
                input, object
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, object[]
                args)
                {
                    this_param.InvokeWithPipe(useLocalScope: useLocalScope, functionsToDefine: functionsToDefine, variablesToDefine: variablesToDefine, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: dollarUnder, input: input, scriptThis: scriptThis, outputPipe: outputPipe, invocationInfo: invocationInfo, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 23172, 23646);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1526_23668_23692(System.Collections.Generic.List<object>
                result)
                {
                    var return_v = GetWrappedResult(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 23668, 23692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 21527, 23704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 21527, 23704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object InvokeReturnAsIs(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 24555, 24881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 24558, 24881);
                return f_1526_24558_24881(this, useLocalScope: true, errorHandlingBehavior: ErrorHandlingBehavior.WriteToExternalErrorPipe, dollarUnder: f_1526_24734_24754(), input: f_1526_24780_24800(), scriptThis: f_1526_24831_24851(), args: args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 24555, 24881);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 24555, 24881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 24555, 24881);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.PSObject
            f_1526_24734_24754()
            {
                var return_v = AutomationNull.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 24734, 24754);
                return return_v;
            }


            System.Management.Automation.PSObject
            f_1526_24780_24800()
            {
                var return_v = AutomationNull.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 24780, 24800);
                return return_v;
            }


            System.Management.Automation.PSObject
            f_1526_24831_24851()
            {
                var return_v = AutomationNull.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 24831, 24851);
                return return_v;
            }


            object
            f_1526_24558_24881(System.Management.Automation.ScriptBlock
            this_param, bool
            useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
            errorHandlingBehavior, System.Management.Automation.PSObject
            dollarUnder, System.Management.Automation.PSObject
            input, System.Management.Automation.PSObject
            scriptThis, object[]
            args)
            {
                var return_v = this_param.DoInvokeReturnAsIs(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 24558, 24881);
                return return_v;
            }

        }

        internal T InvokeAsMemberFunctionT<T>(object instance, object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 24894, 26105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 24988, 25029);

                List<object>
                result = f_1526_25010_25028()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 25043, 25072);

                Pipe
                pipe = f_1526_25055_25071(result)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 25088, 25546);

                f_1526_25088_25545(this, useLocalScope: true, errorHandlingBehavior: ErrorHandlingBehavior.WriteToExternalErrorPipe, dollarUnder: f_1526_25260_25280(), input: f_1526_25306_25326(), scriptThis: instance ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(1526, 25357, 25389) ?? f_1526_25369_25389()), outputPipe: pipe, invocationInfo: null, propagateAllExceptionsToTop: true, args: args);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 25970, 26058) || true) && (f_1526_25974_25986(result) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 25970, 26058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 26025, 26043);

                    return default(T);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 25970, 26058);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 26074, 26094);

                return (T)f_1526_26084_26093(result, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 24894, 26105);

                System.Collections.Generic.List<object>
                f_1526_25010_25028()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 25010, 25028);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1526_25055_25071(System.Collections.Generic.List<object>
                resultList)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(resultList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 25055, 25071);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_25260_25280()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 25260, 25280);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_25306_25326()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 25306, 25326);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_25369_25389()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 25369, 25389);
                    return return_v;
                }


                int
                f_1526_25088_25545(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, System.Management.Automation.PSObject
                input, object
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, bool
                propagateAllExceptionsToTop, object[]
                args)
                {
                    this_param.InvokeWithPipe(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: scriptThis, outputPipe: outputPipe, invocationInfo: invocationInfo, propagateAllExceptionsToTop: propagateAllExceptionsToTop, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 25088, 25545);
                    return 0;
                }


                int
                f_1526_25974_25986(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 25974, 25986);
                    return return_v;
                }


                object
                f_1526_26084_26093(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 26084, 26093);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 24894, 26105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 24894, 26105);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void InvokeAsMemberFunction(object instance, object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 26117, 26884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 26210, 26251);

                List<object>
                result = f_1526_26232_26250()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 26265, 26294);

                Pipe
                pipe = f_1526_26277_26293(result)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 26310, 26767);

                f_1526_26310_26766(this, useLocalScope: true, errorHandlingBehavior: ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1526_26481_26501(), input: f_1526_26527_26547(), scriptThis: instance ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(1526, 26578, 26610) ?? f_1526_26590_26610()), outputPipe: pipe, invocationInfo: null, propagateAllExceptionsToTop: true, args: args);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 26781, 26873);

                f_1526_26781_26872(f_1526_26800_26812(result) == 0, "Code generation ensures we return the correct type");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 26117, 26884);

                System.Collections.Generic.List<object>
                f_1526_26232_26250()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 26232, 26250);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1526_26277_26293(System.Collections.Generic.List<object>
                resultList)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(resultList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 26277, 26293);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_26481_26501()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 26481, 26501);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_26527_26547()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 26527, 26547);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_26590_26610()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 26590, 26610);
                    return return_v;
                }


                int
                f_1526_26310_26766(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, System.Management.Automation.PSObject
                input, object
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, bool
                propagateAllExceptionsToTop, object[]
                args)
                {
                    this_param.InvokeWithPipe(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: scriptThis, outputPipe: outputPipe, invocationInfo: invocationInfo, propagateAllExceptionsToTop: propagateAllExceptionsToTop, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 26310, 26766);
                    return 0;
                }


                int
                f_1526_26800_26812(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 26800, 26812);
                    return return_v;
                }


                int
                f_1526_26781_26872(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 26781, 26872);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 26117, 26884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 26117, 26884);
            }
        }

        public List<Attribute> Attributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 27037, 27055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 27040, 27055);
                    return f_1526_27040_27055(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 27037, 27055);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 26997, 27058);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 26997, 27058);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string File
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 27203, 27219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 27206, 27219);
                    return f_1526_27206_27219(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 27203, 27219);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 27178, 27222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 27178, 27222);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsFilter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 27367, 27395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 27370, 27395);
                    return f_1526_27370_27395(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 27367, 27395);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 27340, 27398);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 27340, 27398);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsConfiguration
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 27557, 27597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 27560, 27597);
                    return f_1526_27560_27597(_scriptBlockData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 27557, 27597);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 27523, 27600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 27523, 27600);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSModuleInfo Module
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 27792, 27860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 27795, 27860);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1526, 27795, 27823) || ((f_1526_27795_27815() != null && DynAbs.Tracing.TraceSender.Conditional_F2(1526, 27826, 27853)) || DynAbs.Tracing.TraceSender.Conditional_F3(1526, 27856, 27860))) ? f_1526_27826_27853(f_1526_27826_27846()) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 27792, 27860);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 27759, 27863);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 27759, 27863);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSToken StartPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 28028, 28049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 28031, 28049);
                    return f_1526_28031_28049(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 28028, 28049);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 27993, 28052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 27993, 28052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PSLanguageMode? LanguageMode { get; set; }

        internal enum ErrorHandlingBehavior
        {
            WriteToCurrentErrorPipe = 1,
            WriteToExternalErrorPipe = 2,
            SwallowErrors = 3,
        }

        internal ReadOnlyCollection<PSTypeName> OutputType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 29181, 29688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 29217, 29266);

                    List<PSTypeName>
                    result = f_1526_29243_29265()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 29284, 29603);
                        foreach (Attribute attribute in f_1526_29316_29326_I(f_1526_29316_29326()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 29284, 29603);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 29368, 29434);

                            OutputTypeAttribute
                            outputType = attribute as OutputTypeAttribute
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 29456, 29584) || true) && (outputType != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 29456, 29584);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 29528, 29561);

                                f_1526_29528_29560(result, f_1526_29544_29559(outputType));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 29456, 29584);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 29284, 29603);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1526, 1, 320);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1526, 1, 320);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 29623, 29673);

                    return f_1526_29630_29672(result);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 29181, 29688);

                    System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    f_1526_29243_29265()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 29243, 29265);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Attribute>
                    f_1526_29316_29326()
                    {
                        var return_v = Attributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 29316, 29326);
                        return return_v;
                    }


                    System.Management.Automation.PSTypeName[]
                    f_1526_29544_29559(System.Management.Automation.OutputTypeAttribute
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 29544, 29559);
                        return return_v;
                    }


                    int
                    f_1526_29528_29560(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    this_param, System.Management.Automation.PSTypeName[]
                    collection)
                    {
                        this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>)collection);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 29528, 29560);
                        return 0;
                    }


                    System.Collections.Generic.List<System.Attribute>
                    f_1526_29316_29326_I(System.Collections.Generic.List<System.Attribute>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 29316, 29326);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                    f_1526_29630_29672(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    list)
                    {
                        var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>((System.Collections.Generic.IList<System.Management.Automation.PSTypeName>)list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 29630, 29672);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 29106, 29699);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 29106, 29699);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static object GetRawResult(List<object> result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1526, 29963, 30391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 30044, 30380);

                switch (f_1526_30052_30064(result))
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 30044, 30380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 30127, 30155);

                        return f_1526_30134_30154();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 30044, 30380);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 30044, 30380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 30202, 30256);

                        return f_1526_30209_30255(f_1526_30245_30254(result, 0));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 30044, 30380);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 30044, 30380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 30304, 30365);

                        return f_1526_30311_30364(f_1526_30347_30363(result));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 30044, 30380);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1526, 29963, 30391);

                int
                f_1526_30052_30064(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 30052, 30064);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_30134_30154()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 30134, 30154);
                    return return_v;
                }


                object
                f_1526_30245_30254(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 30245, 30254);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_30209_30255(object
                obj)
                {
                    var return_v = LanguagePrimitives.AsPSObjectOrNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 30209, 30255);
                    return return_v;
                }


                object[]
                f_1526_30347_30363(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 30347, 30363);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_30311_30364(object[]
                obj)
                {
                    var return_v = LanguagePrimitives.AsPSObjectOrNull((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 30311, 30364);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 29963, 30391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 29963, 30391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void InvokeUsingCmdlet(
                    Cmdlet contextCmdlet,
                    bool useLocalScope,
                    ErrorHandlingBehavior errorHandlingBehavior,
                    object dollarUnder,
                    object input,
                    object scriptThis,
                    object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 30403, 31503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 30706, 30792);

                f_1526_30706_30791(contextCmdlet != null, "caller to verify contextCmdlet parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 30808, 30887);

                Pipe
                outputPipe = f_1526_30826_30886(((MshCommandRuntime)f_1526_30846_30874(contextCmdlet)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 30901, 30948);

                ExecutionContext
                context = f_1526_30928_30947(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 30962, 31072);

                var
                myInv = f_1526_30974_31071(f_1526_30974_31013(f_1526_30974_31000(context)), AutomaticVariable.MyInvocation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 31086, 31171);

                InvocationInfo
                inInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(1526, 31110, 31139) || ((myInv == f_1526_31119_31139() && DynAbs.Tracing.TraceSender.Conditional_F2(1526, 31142, 31146)) || DynAbs.Tracing.TraceSender.Conditional_F3(1526, 31149, 31170))) ? null : (InvocationInfo)myInv
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 31185, 31492);

                f_1526_31185_31491(this, useLocalScope, errorHandlingBehavior, dollarUnder, input, scriptThis, outputPipe, inInfo, propagateAllExceptionsToTop: false, args: args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 30403, 31503);

                int
                f_1526_30706_30791(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 30706, 30791);
                    return 0;
                }


                System.Management.Automation.ICommandRuntime
                f_1526_30846_30874(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 30846, 30874);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1526_30826_30886(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 30826, 30886);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1526_30928_30947(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.GetContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 30928, 30947);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1526_30974_31000(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 30974, 31000);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1526_30974_31013(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 30974, 31013);
                    return return_v;
                }


                object
                f_1526_30974_31071(System.Management.Automation.SessionStateScope
                this_param, System.Management.Automation.AutomaticVariable
                variable)
                {
                    var return_v = this_param.GetAutomaticVariableValue(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 30974, 31071);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_31119_31139()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 31119, 31139);
                    return return_v;
                }


                int
                f_1526_31185_31491(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, object
                dollarUnder, object
                input, object
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, bool
                propagateAllExceptionsToTop, object[]
                args)
                {
                    this_param.InvokeWithPipe(useLocalScope, errorHandlingBehavior, dollarUnder, input, scriptThis, outputPipe, invocationInfo, propagateAllExceptionsToTop: propagateAllExceptionsToTop, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 31185, 31491);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 30403, 31503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 30403, 31503);
            }
        }

        internal SessionStateInternal SessionStateInternal { get; set; }

        internal SessionState SessionState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 31932, 32443);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 31968, 32323) || true) && (f_1526_31972_31992() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 31968, 32323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 32042, 32112);

                        ExecutionContext
                        context = f_1526_32069_32111()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 32134, 32304) || true) && (context != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 32134, 32304);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 32203, 32281);

                            SessionStateInternal = f_1526_32226_32280(f_1526_32226_32271(f_1526_32226_32252(context)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 32134, 32304);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 31968, 32323);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 32343, 32428);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1526, 32350, 32378) || ((f_1526_32350_32370() != null && DynAbs.Tracing.TraceSender.Conditional_F2(1526, 32381, 32420)) || DynAbs.Tracing.TraceSender.Conditional_F3(1526, 32423, 32427))) ? f_1526_32381_32420(f_1526_32381_32401()) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 31932, 32443);

                    System.Management.Automation.SessionStateInternal
                    f_1526_31972_31992()
                    {
                        var return_v = SessionStateInternal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 31972, 31992);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1526_32069_32111()
                    {
                        var return_v = LocalPipeline.GetExecutionContextFromTLS();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 32069, 32111);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1526_32226_32252(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 32226, 32252);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1526_32226_32271(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.PublicSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 32226, 32271);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1526_32226_32280(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Internal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 32226, 32280);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1526_32350_32370()
                    {
                        var return_v = SessionStateInternal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 32350, 32370);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1526_32381_32401()
                    {
                        var return_v = SessionStateInternal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 32381, 32401);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1526_32381_32420(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.PublicSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 32381, 32420);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 31873, 32717);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 31873, 32717);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 32459, 32706);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 32495, 32633) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 32495, 32633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 32554, 32614);

                        throw f_1526_32560_32613(nameof(value));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 32495, 32633);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 32653, 32691);

                    SessionStateInternal = f_1526_32676_32690(value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 32459, 32706);

                    System.Management.Automation.PSArgumentNullException
                    f_1526_32560_32613(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 32560, 32613);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1526_32676_32690(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Internal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 32676, 32690);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 31873, 32717);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 31873, 32717);
                }
            }
        }

        private static readonly ConditionalWeakTable<ScriptBlock, ConcurrentDictionary<Type, Delegate>> s_delegateTable;

        internal Delegate GetDelegate(Type delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 33037, 33117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 33040, 33117);
                return f_1526_33040_33117(f_1526_33040_33078(s_delegateTable, this), delegateType, CreateDelegate);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 33037, 33117);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 33037, 33117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 33037, 33117);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Delegate>
            f_1526_33040_33078(System.Runtime.CompilerServices.ConditionalWeakTable<System.Management.Automation.ScriptBlock, System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Delegate>>
            this_param, System.Management.Automation.ScriptBlock
            key)
            {
                var return_v = this_param.GetOrCreateValue(key);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 33040, 33078);
                return return_v;
            }


            System.Delegate
            f_1526_33040_33117(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Delegate>
            this_param, System.Type
            key, System.Func<System.Type, System.Delegate>
            valueFactory)
            {
                var return_v = this_param.GetOrAdd(key, valueFactory);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 33040, 33117);
                return return_v;
            }

        }

        internal Delegate CreateDelegate(Type delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 33230, 35750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 33306, 33365);

                MethodInfo
                invokeMethod = f_1526_33332_33364(delegateType, "Invoke")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 33379, 33437);

                ParameterInfo[]
                parameters = f_1526_33408_33436(invokeMethod)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 33451, 33833) || true) && (f_1526_33455_33493(invokeMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 33451, 33833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 33527, 33818);

                    throw f_1526_33533_33817("CantConvertScriptBlockToOpenGenericType", null, "AutomationExceptions", "CantConvertScriptBlockToOpenGenericType", delegateType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 33451, 33833);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 33849, 33902);

                var
                parameterExprs = f_1526_33870_33901()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 33916, 34067);
                    foreach (var parameter in f_1526_33942_33952_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 33916, 34067);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 33986, 34052);

                        f_1526_33986_34051(parameterExprs, f_1526_34005_34050(f_1526_34026_34049(parameter)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 33916, 34067);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1526, 1, 152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1526, 1, 152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 34083, 34153);

                bool
                returnsSomething = !f_1526_34108_34152(f_1526_34108_34131(invokeMethod), typeof(void))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 34169, 34196);

                Expression
                dollarUnderExpr
                = default(Expression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 34210, 34236);

                Expression
                dollarThisExpr
                = default(Expression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 34250, 35049) || true) && (f_1526_34254_34271(parameters) == 2 && (DynAbs.Tracing.TraceSender.Expression_True(1526, 34254, 34297) && !returnsSomething))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 34250, 35049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 34706, 34763);

                    dollarUnderExpr = f_1526_34724_34762(f_1526_34724_34741(parameterExprs, 1), typeof(object));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 34781, 34837);

                    dollarThisExpr = f_1526_34798_34836(f_1526_34798_34815(parameterExprs, 0), typeof(object));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 34250, 35049);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 34250, 35049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 34903, 34960);

                    dollarUnderExpr = ExpressionCache.AutomationNullConstant;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 34978, 35034);

                    dollarThisExpr = ExpressionCache.AutomationNullConstant;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 34250, 35049);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 35065, 35395);

                Expression
                call = f_1526_35083_35394(f_1526_35117_35142(this), CachedReflectionInfo.ScriptBlock_InvokeAsDelegateHelper, dollarUnderExpr, dollarThisExpr, f_1526_35302_35393(typeof(object), f_1526_35342_35392(parameterExprs, p => p.Cast(typeof(object)))))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 35409, 35652) || true) && (returnsSomething)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 35409, 35652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 35463, 35637);

                    call = f_1526_35470_35636(f_1526_35518_35562(f_1526_35538_35561(invokeMethod)), f_1526_35585_35608(invokeMethod), call);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 35409, 35652);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 35668, 35739);

                return f_1526_35675_35738(f_1526_35675_35728(delegateType, call, parameterExprs));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 33230, 35750);

                System.Reflection.MethodInfo?
                f_1526_33332_33364(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 33332, 33364);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_1526_33408_33436(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 33408, 33436);
                    return return_v;
                }


                bool
                f_1526_33455_33493(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ContainsGenericParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 33455, 33493);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                f_1526_33533_33817(string
                errorId, System.Exception
                innerException, string
                message, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ScriptBlockToPowerShellNotSupportedException(errorId, innerException, message, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 33533, 33817);
                    return return_v;
                }


                System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                f_1526_33870_33901()
                {
                    var return_v = new System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 33870, 33901);
                    return return_v;
                }


                System.Type
                f_1526_34026_34049(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 34026, 34049);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1526_34005_34050(System.Type
                type)
                {
                    var return_v = Expression.Parameter(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 34005, 34050);
                    return return_v;
                }


                int
                f_1526_33986_34051(System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                this_param, System.Linq.Expressions.ParameterExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 33986, 34051);
                    return 0;
                }


                System.Reflection.ParameterInfo[]
                f_1526_33942_33952_I(System.Reflection.ParameterInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 33942, 33952);
                    return return_v;
                }


                System.Type
                f_1526_34108_34131(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 34108, 34131);
                    return return_v;
                }


                bool
                f_1526_34108_34152(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 34108, 34152);
                    return return_v;
                }


                int
                f_1526_34254_34271(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 34254, 34271);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1526_34724_34741(System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 34724, 34741);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1526_34724_34762(System.Linq.Expressions.ParameterExpression
                expr, System.Type
                type)
                {
                    var return_v = expr.Cast(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 34724, 34762);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1526_34798_34815(System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 34798, 34815);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1526_34798_34836(System.Linq.Expressions.ParameterExpression
                expr, System.Type
                type)
                {
                    var return_v = expr.Cast(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 34798, 34836);
                    return return_v;
                }


                System.Linq.Expressions.ConstantExpression
                f_1526_35117_35142(System.Management.Automation.ScriptBlock
                value)
                {
                    var return_v = Expression.Constant((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 35117, 35142);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression>
                f_1526_35342_35392(System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                source, System.Func<System.Linq.Expressions.ParameterExpression, System.Linq.Expressions.Expression>
                selector)
                {
                    var return_v = source.Select<System.Linq.Expressions.ParameterExpression, System.Linq.Expressions.Expression>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 35342, 35392);
                    return return_v;
                }


                System.Linq.Expressions.NewArrayExpression
                f_1526_35302_35393(System.Type
                type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression>
                initializers)
                {
                    var return_v = Expression.NewArrayInit(type, initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 35302, 35393);
                    return return_v;
                }


                System.Linq.Expressions.MethodCallExpression
                f_1526_35083_35394(System.Linq.Expressions.ConstantExpression
                instance, System.Reflection.MethodInfo
                method, System.Linq.Expressions.Expression
                arg0, System.Linq.Expressions.Expression
                arg1, System.Linq.Expressions.NewArrayExpression
                arg2)
                {
                    var return_v = Expression.Call((System.Linq.Expressions.Expression)instance, method, arg0, arg1, (System.Linq.Expressions.Expression)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 35083, 35394);
                    return return_v;
                }


                System.Type
                f_1526_35538_35561(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 35538, 35561);
                    return return_v;
                }


                System.Management.Automation.Language.PSConvertBinder
                f_1526_35518_35562(System.Type
                type)
                {
                    var return_v = PSConvertBinder.Get(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 35518, 35562);
                    return return_v;
                }


                System.Type
                f_1526_35585_35608(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 35585, 35608);
                    return return_v;
                }


                System.Linq.Expressions.DynamicExpression
                f_1526_35470_35636(System.Management.Automation.Language.PSConvertBinder
                binder, System.Type
                returnType, System.Linq.Expressions.Expression
                arg0)
                {
                    var return_v = DynamicExpression.Dynamic((System.Runtime.CompilerServices.CallSiteBinder)binder, returnType, arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 35470, 35636);
                    return return_v;
                }


                System.Linq.Expressions.LambdaExpression
                f_1526_35675_35728(System.Type
                delegateType, System.Linq.Expressions.Expression
                body, System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                parameters)
                {
                    var return_v = Expression.Lambda(delegateType, body, (System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression>)parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 35675, 35728);
                    return return_v;
                }


                System.Delegate
                f_1526_35675_35738(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.Compile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 35675, 35738);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 33230, 35750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 33230, 35750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object InvokeAsDelegateHelper(object dollarUnder, object dollarThis, object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 35762, 36670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 36001, 36048);

                ExecutionContext
                context = f_1526_36028_36047(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 36062, 36124);

                RunspaceBase
                runspace = (RunspaceBase)f_1526_36100_36123(context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 36140, 36184);

                List<object>
                rawResult = f_1526_36165_36183()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 36198, 36236);

                Pipe
                outputPipe = f_1526_36216_36235(rawResult)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 36250, 36614);

                f_1526_36250_36613(this, useLocalScope: true, errorHandlingBehavior: ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: dollarUnder, input: null, scriptThis: dollarThis, outputPipe: outputPipe, invocationInfo: null, args: args);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 36628, 36659);

                return f_1526_36635_36658(rawResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 35762, 36670);

                System.Management.Automation.ExecutionContext
                f_1526_36028_36047(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.GetContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 36028, 36047);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1526_36100_36123(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 36100, 36123);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1526_36165_36183()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 36165, 36183);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1526_36216_36235(System.Collections.Generic.List<object>
                resultList)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(resultList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 36216, 36235);
                    return return_v;
                }


                int
                f_1526_36250_36613(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, object
                dollarUnder, object
                input, object
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, object[]
                args)
                {
                    this_param.InvokeWithPipe(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: dollarUnder, input: input, scriptThis: scriptThis, outputPipe: outputPipe, invocationInfo: invocationInfo, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 36250, 36613);
                    return 0;
                }


                object
                f_1526_36635_36658(System.Collections.Generic.List<object>
                result)
                {
                    var return_v = GetRawResult(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 36635, 36658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 35762, 36670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 35762, 36670);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ExecutionContext GetContextFromTLS()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 37010, 37824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 37080, 37150);

                ExecutionContext
                context = f_1526_37107_37149()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 37264, 37782) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 37264, 37782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 37317, 37353);

                    string
                    scriptText = f_1526_37337_37352(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 37373, 37456);

                    scriptText = f_1526_37386_37455(f_1526_37414_37442(), scriptText);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 37476, 37663);

                    PSInvalidOperationException
                    e = f_1526_37508_37662(f_1526_37573_37628(), scriptText)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 37683, 37741);

                    f_1526_37683_37740(
                                    e, "ScriptBlockDelegateInvokedFromWrongThread");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 37759, 37767);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 37264, 37782);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 37798, 37813);

                return context;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 37010, 37824);

                System.Management.Automation.ExecutionContext
                f_1526_37107_37149()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 37107, 37149);
                    return return_v;
                }


                string
                f_1526_37337_37352(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 37337, 37352);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1526_37414_37442()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 37414, 37442);
                    return return_v;
                }


                string
                f_1526_37386_37455(System.Globalization.CultureInfo
                uiCultureInfo, string
                original)
                {
                    var return_v = ErrorCategoryInfo.Ellipsize(uiCultureInfo, original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 37386, 37455);
                    return return_v;
                }


                string
                f_1526_37573_37628()
                {
                    var return_v = ParserStrings.ScriptBlockDelegateInvokedFromWrongThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 37573, 37628);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1526_37508_37662(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 37508, 37662);
                    return return_v;
                }


                int
                f_1526_37683_37740(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 37683, 37740);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 37010, 37824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 37010, 37824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<PSObject> DoInvoke(object dollarUnder, object input, object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 38852, 39501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 38964, 39005);

                List<object>
                result = f_1526_38986_39004()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 39019, 39054);

                Pipe
                outputPipe = f_1526_39037_39053(result)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 39068, 39444);

                f_1526_39068_39443(this, useLocalScope: true, errorHandlingBehavior: ErrorHandlingBehavior.WriteToExternalErrorPipe, dollarUnder: dollarUnder, input: input, scriptThis: f_1526_39313_39333(), outputPipe: outputPipe, invocationInfo: null, args: args);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 39458, 39490);

                return f_1526_39465_39489(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 38852, 39501);

                System.Collections.Generic.List<object>
                f_1526_38986_39004()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 38986, 39004);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1526_39037_39053(System.Collections.Generic.List<object>
                resultList)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(resultList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 39037, 39053);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_39313_39333()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 39313, 39333);
                    return return_v;
                }


                int
                f_1526_39068_39443(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, object
                dollarUnder, object
                input, System.Management.Automation.PSObject
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, object[]
                args)
                {
                    this_param.InvokeWithPipe(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: dollarUnder, input: input, scriptThis: (object)scriptThis, outputPipe: outputPipe, invocationInfo: invocationInfo, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 39068, 39443);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1526_39465_39489(System.Collections.Generic.List<object>
                result)
                {
                    var return_v = GetWrappedResult(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 39465, 39489);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 38852, 39501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 38852, 39501);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Collection<PSObject> GetWrappedResult(List<object> result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1526, 39735, 40249);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 39833, 39955) || true) && (result == null || (DynAbs.Tracing.TraceSender.Expression_False(1526, 39837, 39872) || f_1526_39855_39867(result) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 39833, 39955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 39906, 39940);

                    return f_1526_39913_39939();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 39833, 39955);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 39971, 40035);

                Collection<PSObject>
                wrappedResult = f_1526_40008_40034()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 40058, 40063);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 40049, 40201) || true) && (i < f_1526_40069_40081(result))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 40083, 40086)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 40049, 40201))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 40049, 40201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 40120, 40186);

                        f_1526_40120_40185(wrappedResult, f_1526_40138_40184(f_1526_40174_40183(result, i)));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1526, 1, 153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1526, 1, 153);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 40217, 40238);

                return wrappedResult;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1526, 39735, 40249);

                int
                f_1526_39855_39867(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 39855, 39867);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1526_39913_39939()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 39913, 39939);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1526_40008_40034()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 40008, 40034);
                    return return_v;
                }


                int
                f_1526_40069_40081(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 40069, 40081);
                    return return_v;
                }


                object
                f_1526_40174_40183(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 40174, 40183);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_40138_40184(object
                obj)
                {
                    var return_v = LanguagePrimitives.AsPSObjectOrNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 40138, 40184);
                    return return_v;
                }


                int
                f_1526_40120_40185(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 40120, 40185);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 39735, 40249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 39735, 40249);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object DoInvokeReturnAsIs(
                    bool useLocalScope,
                    ErrorHandlingBehavior errorHandlingBehavior,
                    object dollarUnder,
                    object input,
                    object scriptThis,
                    object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 41440, 42218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 41711, 41752);

                List<object>
                result = f_1526_41733_41751()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 41766, 41801);

                Pipe
                outputPipe = f_1526_41784_41800(result)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 41815, 42165);

                f_1526_41815_42164(this, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: dollarUnder, input: input, scriptThis: scriptThis, outputPipe: outputPipe, invocationInfo: null, args: args);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 42179, 42207);

                return f_1526_42186_42206(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 41440, 42218);

                System.Collections.Generic.List<object>
                f_1526_41733_41751()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 41733, 41751);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1526_41784_41800(System.Collections.Generic.List<object>
                resultList)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(resultList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 41784, 41800);
                    return return_v;
                }


                int
                f_1526_41815_42164(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, object
                dollarUnder, object
                input, object
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, object[]
                args)
                {
                    this_param.InvokeWithPipe(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: dollarUnder, input: input, scriptThis: scriptThis, outputPipe: outputPipe, invocationInfo: invocationInfo, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 41815, 42164);
                    return 0;
                }


                object
                f_1526_42186_42206(System.Collections.Generic.List<object>
                result)
                {
                    var return_v = GetRawResult(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 42186, 42206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 41440, 42218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 41440, 42218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void InvokeWithPipe(
                    bool useLocalScope,
                    ErrorHandlingBehavior errorHandlingBehavior,
                    object dollarUnder,
                    object input,
                    object scriptThis,
                    Pipe outputPipe,
                    InvocationInfo invocationInfo,
                    bool propagateAllExceptionsToTop = false,
                    List<PSVariable> variablesToDefine = null,
                    Dictionary<string, ScriptBlock> functionsToDefine = null,
                    object[] args = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 42230, 46355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 42758, 42791);

                bool
                shouldGenerateEvent = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 42805, 42841);

                bool
                oldPropagateExceptions = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 42855, 42925);

                ExecutionContext
                context = f_1526_42882_42924()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 42941, 44748) || true) && (f_1526_42945_42965() != null && (DynAbs.Tracing.TraceSender.Expression_True(1526, 42945, 43025) && f_1526_42977_43014(f_1526_42977_42997()) != context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 42941, 44748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 43059, 43107);

                    context = f_1526_43069_43106(f_1526_43069_43089());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 43125, 43152);

                    shouldGenerateEvent = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 42941, 44748);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 42941, 44748);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 43186, 44748) || true) && (context == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 43186, 44748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 43276, 43296);

                        f_1526_43276_43295(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 43186, 44748);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 43186, 44748);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 43362, 43614) || true) && (propagateAllExceptionsToTop)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 43362, 43614);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 43435, 43513);

                            oldPropagateExceptions = f_1526_43460_43512(context);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 43535, 43595);

                            context.PropagateExceptionsToEnclosingStatementBlock = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 43362, 43614);
                        }

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 43678, 43731);

                            var
                            runspace = (RunspaceBase)f_1526_43707_43730(context)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 43753, 44447) || true) && (f_1526_43757_43797(runspace))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 43753, 44447);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 43847, 44299);

                                f_1526_43847_44298(this, useLocalScope, functionsToDefine, variablesToDefine, errorHandlingBehavior, dollarUnder, input, scriptThis, outputPipe, invocationInfo, args);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 43753, 44447);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 43753, 44447);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 44397, 44424);

                                shouldGenerateEvent = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 43753, 44447);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1526, 44484, 44733);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 44532, 44714) || true) && (propagateAllExceptionsToTop)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 44532, 44714);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 44613, 44691);

                                context.PropagateExceptionsToEnclosingStatementBlock = oldPropagateExceptions;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 44532, 44714);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1526, 44484, 44733);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 43186, 44748);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 42941, 44748);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 44764, 46344) || true) && (shouldGenerateEvent)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 44764, 46344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 44821, 45356);

                    f_1526_44821_45355(f_1526_44821_44835(context), source: null, eventName: PSEngineEvent.OnScriptBlockInvoke, sourceIdentifier: PSEngineEvent.OnScriptBlockInvoke, data: null, handlerDelegate: new PSEventReceivedEventHandler(OnScriptBlockInvokeEventHandler), supportEvent: true, forwardEvent: false, shouldQueueAndProcessInExecutionThread: true, maxTriggerCount: 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 45376, 45761);

                    var
                    scriptBlockInvocationEventArgs = f_1526_45413_45760(scriptBlock: this, useLocalScope, errorHandlingBehavior, dollarUnder, input, scriptThis, outputPipe, invocationInfo, args)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 45781, 46147);

                    f_1526_45781_46146(f_1526_45781_45795(context), sourceIdentifier: PSEngineEvent.OnScriptBlockInvoke, sender: null, args: new object[1] { scriptBlockInvocationEventArgs }, extraData: null, processInCurrentThread: true, waitForCompletionInCurrentThread: true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 46167, 46329) || true) && (f_1526_46171_46211(scriptBlockInvocationEventArgs) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 46167, 46329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 46261, 46310);

                        f_1526_46261_46309(f_1526_46261_46301(scriptBlockInvocationEventArgs));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 46167, 46329);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 44764, 46344);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 42230, 46355);

                System.Management.Automation.ExecutionContext
                f_1526_42882_42924()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 42882, 42924);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1526_42945_42965()
                {
                    var return_v = SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 42945, 42965);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1526_42977_42997()
                {
                    var return_v = SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 42977, 42997);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1526_42977_43014(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 42977, 43014);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1526_43069_43089()
                {
                    var return_v = SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 43069, 43089);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1526_43069_43106(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 43069, 43106);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1526_43276_43295(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.GetContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 43276, 43295);
                    return return_v;
                }


                bool
                f_1526_43460_43512(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.PropagateExceptionsToEnclosingStatementBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 43460, 43512);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1526_43707_43730(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 43707, 43730);
                    return return_v;
                }


                bool
                f_1526_43757_43797(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.CanRunActionInCurrentPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 43757, 43797);
                    return return_v;
                }


                int
                f_1526_43847_44298(System.Management.Automation.ScriptBlock
                this_param, bool
                createLocalScope, System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                functionsToDefine, System.Collections.Generic.List<System.Management.Automation.PSVariable>
                variablesToDefine, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, object
                dollarUnder, object
                input, object
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, params object[]
                args)
                {
                    this_param.InvokeWithPipeImpl(createLocalScope, functionsToDefine, variablesToDefine, errorHandlingBehavior, dollarUnder, input, scriptThis, outputPipe, invocationInfo, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 43847, 44298);
                    return 0;
                }


                System.Management.Automation.PSLocalEventManager
                f_1526_44821_44835(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 44821, 44835);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber
                f_1526_44821_45355(System.Management.Automation.PSLocalEventManager
                this_param, object
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSObject
                data, System.Management.Automation.PSEventReceivedEventHandler
                handlerDelegate, bool
                supportEvent, bool
                forwardEvent, bool
                shouldQueueAndProcessInExecutionThread, int
                maxTriggerCount)
                {
                    var return_v = this_param.SubscribeEvent(source: source, eventName: eventName, sourceIdentifier: sourceIdentifier, data: data, handlerDelegate: handlerDelegate, supportEvent: supportEvent, forwardEvent: forwardEvent, shouldQueueAndProcessInExecutionThread: shouldQueueAndProcessInExecutionThread, maxTriggerCount: maxTriggerCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 44821, 45355);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockInvocationEventArgs
                f_1526_45413_45760(System.Management.Automation.ScriptBlock
                scriptBlock, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, object
                dollarUnder, object
                input, object
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, object[]
                args)
                {
                    var return_v = new System.Management.Automation.ScriptBlockInvocationEventArgs(scriptBlock: scriptBlock, useLocalScope, errorHandlingBehavior, dollarUnder, input, scriptThis, outputPipe, invocationInfo, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 45413, 45760);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1526_45781_45795(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 45781, 45795);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1526_45781_46146(System.Management.Automation.PSLocalEventManager
                this_param, string
                sourceIdentifier, object
                sender, object[]
                args, System.Management.Automation.PSObject
                extraData, bool
                processInCurrentThread, bool
                waitForCompletionInCurrentThread)
                {
                    var return_v = this_param.GenerateEvent(sourceIdentifier: sourceIdentifier, sender: sender, args: args, extraData: extraData, processInCurrentThread: processInCurrentThread, waitForCompletionInCurrentThread: waitForCompletionInCurrentThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 45781, 46146);
                    return return_v;
                }


                System.Runtime.ExceptionServices.ExceptionDispatchInfo
                f_1526_46171_46211(System.Management.Automation.ScriptBlockInvocationEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 46171, 46211);
                    return return_v;
                }


                System.Runtime.ExceptionServices.ExceptionDispatchInfo
                f_1526_46261_46301(System.Management.Automation.ScriptBlockInvocationEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 46261, 46301);
                    return return_v;
                }


                int
                f_1526_46261_46309(System.Runtime.ExceptionServices.ExceptionDispatchInfo
                this_param)
                {
                    this_param.Throw();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 46261, 46309);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 42230, 46355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 42230, 46355);
            }
        }

        private static void OnScriptBlockInvokeEventHandler(object sender, PSEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1526, 46499, 47567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 46608, 46687);

                var
                eventArgs = (object)f_1526_46632_46652(args) as ScriptBlockInvocationEventArgs
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 46701, 46829);

                f_1526_46701_46828(eventArgs != null, "Event Arguments to OnScriptBlockInvokeEventHandler should not be null");

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 46881, 46920);

                    ScriptBlock
                    sb = f_1526_46898_46919(eventArgs)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 46938, 47405);

                    f_1526_46938_47404(sb, f_1526_46982_47005(eventArgs), functionsToDefine: null, variablesToDefine: null, f_1526_47120_47151(eventArgs), f_1526_47174_47195(eventArgs), f_1526_47218_47233(eventArgs), f_1526_47256_47276(eventArgs), f_1526_47299_47319(eventArgs), f_1526_47342_47366(eventArgs), f_1526_47389_47403(eventArgs));
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1526, 47434, 47556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 47486, 47541);

                    eventArgs.Exception = f_1526_47508_47540(e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1526, 47434, 47556);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1526, 46499, 47567);

                System.EventArgs
                f_1526_46632_46652(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.SourceEventArgs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 46632, 46652);
                    return return_v;
                }


                int
                f_1526_46701_46828(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 46701, 46828);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1526_46898_46919(System.Management.Automation.ScriptBlockInvocationEventArgs
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 46898, 46919);
                    return return_v;
                }


                bool
                f_1526_46982_47005(System.Management.Automation.ScriptBlockInvocationEventArgs
                this_param)
                {
                    var return_v = this_param.UseLocalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 46982, 47005);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                f_1526_47120_47151(System.Management.Automation.ScriptBlockInvocationEventArgs
                this_param)
                {
                    var return_v = this_param.ErrorHandlingBehavior;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 47120, 47151);
                    return return_v;
                }


                object
                f_1526_47174_47195(System.Management.Automation.ScriptBlockInvocationEventArgs
                this_param)
                {
                    var return_v = this_param.DollarUnder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 47174, 47195);
                    return return_v;
                }


                object
                f_1526_47218_47233(System.Management.Automation.ScriptBlockInvocationEventArgs
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 47218, 47233);
                    return return_v;
                }


                object
                f_1526_47256_47276(System.Management.Automation.ScriptBlockInvocationEventArgs
                this_param)
                {
                    var return_v = this_param.ScriptThis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 47256, 47276);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1526_47299_47319(System.Management.Automation.ScriptBlockInvocationEventArgs
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 47299, 47319);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1526_47342_47366(System.Management.Automation.ScriptBlockInvocationEventArgs
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 47342, 47366);
                    return return_v;
                }


                object[]
                f_1526_47389_47403(System.Management.Automation.ScriptBlockInvocationEventArgs
                this_param)
                {
                    var return_v = this_param.Args;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 47389, 47403);
                    return return_v;
                }


                int
                f_1526_46938_47404(System.Management.Automation.ScriptBlock
                this_param, bool
                createLocalScope, System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                functionsToDefine, System.Collections.Generic.List<System.Management.Automation.PSVariable>
                variablesToDefine, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, object
                dollarUnder, object
                input, object
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, params object[]
                args)
                {
                    this_param.InvokeWithPipeImpl(createLocalScope, functionsToDefine: functionsToDefine, variablesToDefine: variablesToDefine, errorHandlingBehavior, dollarUnder, input, scriptThis, outputPipe, invocationInfo, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 46938, 47404);
                    return 0;
                }


                System.Runtime.ExceptionServices.ExceptionDispatchInfo
                f_1526_47508_47540(System.Exception
                source)
                {
                    var return_v = ExceptionDispatchInfo.Capture(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 47508, 47540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 46499, 47567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 46499, 47567);
            }
        }

        internal void SetPSScriptRootAndPSCommandPath(MutableTuple locals, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 47579, 48160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 47696, 47728);

                var
                psScriptRoot = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 47742, 47775);

                var
                psCommandPath = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 47789, 47951) || true) && (!f_1526_47794_47820(f_1526_47815_47819()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 47789, 47951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 47854, 47897);

                    psScriptRoot = f_1526_47869_47896(f_1526_47891_47895());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 47915, 47936);

                    psCommandPath = f_1526_47931_47935();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 47789, 47951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 47967, 48050);

                f_1526_47967_48049(
                            locals, AutomaticVariable.PSScriptRoot, psScriptRoot, context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 48064, 48149);

                f_1526_48064_48148(locals, AutomaticVariable.PSCommandPath, psCommandPath, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 47579, 48160);

                string
                f_1526_47815_47819()
                {
                    var return_v = File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 47815, 47819);
                    return return_v;
                }


                bool
                f_1526_47794_47820(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 47794, 47820);
                    return return_v;
                }


                string
                f_1526_47891_47895()
                {
                    var return_v = File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 47891, 47895);
                    return return_v;
                }


                string?
                f_1526_47869_47896(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 47869, 47896);
                    return return_v;
                }


                string
                f_1526_47931_47935()
                {
                    var return_v = File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 47931, 47935);
                    return return_v;
                }


                int
                f_1526_47967_48049(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, string
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, (object)value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 47967, 48049);
                    return 0;
                }


                int
                f_1526_48064_48148(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, string
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, (object)value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 48064, 48148);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 47579, 48160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 47579, 48160);
            }
        }

        static ScriptBlock()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1526, 2556, 48167);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 32854, 32962);
            s_delegateTable = f_1526_32885_32962();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 20249, 20342);
            s_cachedScripts = f_1562_20280_20342();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 22938, 23045);
            EmptyScriptBlock = f_1562_22970_23045(string.Empty, isProductCode: true);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 70866, 70893);
            s_syncObject = f_1562_70881_70893();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 70926, 70962);
            s_lastSeenCertificate = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 70993, 71026);
            s_hasProcessedCertificate = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 71074, 71103);
            s_encryptionRecipients = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1562, 71154, 71344);
            s_sbLoggingSettingCache = f_1562_71180_71344(() => Utils.GetPolicySetting<Configuration.ScriptBlockLogging>(Utils.SystemWideThenCurrentUserConfig), isThreadSafe: true);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1526, 2556, 48167);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 2556, 48167);
        }

        // CUSTOM ADDS
        static ConcurrentDictionary<Tuple<string, string>, ScriptBlock> f_1562_20280_20342()
        {
            var temp = new ConcurrentDictionary<Tuple<string, string>, ScriptBlock>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 20280, 20342);
            return temp;
        }

        static ScriptBlock f_1562_22970_23045(string s, bool isProductCode)
        {
            var temp = ScriptBlock.CreateDelayParsedScriptBlock(s, isProductCode: true);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 22970, 23045);
            return temp;
        }

        static object f_1562_70881_70893()
        {
            var temp = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 70881, 70893);
            return temp;
        }

        static Lazy<Configuration.ScriptBlockLogging> f_1562_71180_71344(Func<Configuration.ScriptBlockLogging> f, bool isThreadSafe)
        {
            var temp = new Lazy<Configuration.ScriptBlockLogging>(f, isThreadSafe);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1562, 71180, 71344);
            return temp;
        }


        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1526, 2556, 48167);

        System.Collections.Generic.List<System.Attribute>
        f_1526_27040_27055(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.GetAttributes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 27040, 27055);
            return return_v;
        }


        string
        f_1526_27206_27219(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.GetFileName();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 27206, 27219);
            return return_v;
        }


        bool
        f_1526_27370_27395(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.IsFilter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 27370, 27395);
            return return_v;
        }


        bool
        f_1526_27560_27597(System.Management.Automation.CompiledScriptBlockData
        this_param)
        {
            var return_v = this_param.GetIsConfiguration();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 27560, 27597);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1526_27795_27815()
        {
            var return_v = SessionStateInternal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 27795, 27815);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1526_27826_27846()
        {
            var return_v = SessionStateInternal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 27826, 27846);
            return return_v;
        }


        System.Management.Automation.PSModuleInfo
        f_1526_27826_27853(System.Management.Automation.SessionStateInternal
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 27826, 27853);
            return return_v;
        }


        System.Management.Automation.PSToken
        f_1526_28031_28049(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.GetStartPosition();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 28031, 28049);
            return return_v;
        }


        static System.Runtime.CompilerServices.ConditionalWeakTable<System.Management.Automation.ScriptBlock, System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Delegate>>
        f_1526_32885_32962()
        {
            var return_v = new System.Runtime.CompilerServices.ConditionalWeakTable<System.Management.Automation.ScriptBlock, System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Delegate>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 32885, 32962);
            return return_v;
        }

    }
    [SuppressMessage(
            "Microsoft.Naming",
            "CA1704:IdentifiersShouldBeSpelledCorrectly",
            MessageId = "Steppable",
            Justification = "Consider Name change during API review")]
    public sealed class SteppablePipeline : IDisposable
    {
        internal SteppablePipeline(ExecutionContext context, PipelineProcessor pipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1526, 48539, 48977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 49015, 49024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 49060, 49068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 49092, 49104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 55602, 55611);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 48644, 48763) || true) && (pipeline == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 48644, 48763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 48698, 48748);

                    throw f_1526_48704_48747(nameof(pipeline));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 48644, 48763);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 48779, 48896) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 48779, 48896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 48832, 48881);

                    throw f_1526_48838_48880(nameof(context));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 48779, 48896);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 48912, 48933);

                _pipeline = pipeline;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 48947, 48966);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1526, 48539, 48977);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 48539, 48977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 48539, 48977);
            }
        }

        private PipelineProcessor _pipeline;

        private ExecutionContext _context;

        private bool _expectInput;

        public void Begin(bool expectInput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 49434, 49494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 49437, 49494);
                f_1526_49437_49494(this, expectInput, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 49434, 49494);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 49434, 49494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 49434, 49494);
            }

            int
            f_1526_49437_49494(System.Management.Automation.SteppablePipeline
            this_param, bool
            expectInput, System.Management.Automation.ICommandRuntime
            commandRuntime)
            {
                this_param.Begin(expectInput, commandRuntime: commandRuntime);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 49437, 49494);
                return 0;
            }

        }

        public void Begin(bool expectInput, EngineIntrinsics contextToRedirectTo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 49976, 50572);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 50074, 50215) || true) && (contextToRedirectTo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 50074, 50215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 50139, 50200);

                    throw f_1526_50145_50199(nameof(contextToRedirectTo));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 50074, 50215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 50231, 50326);

                ExecutionContext
                executionContext = f_1526_50267_50325(f_1526_50267_50308(f_1526_50267_50299(contextToRedirectTo)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 50340, 50421);

                CommandProcessorBase
                commandProcessor = f_1526_50380_50420(executionContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 50435, 50523);

                ICommandRuntime
                crt = (DynAbs.Tracing.TraceSender.Conditional_F1(1526, 50457, 50481) || ((commandProcessor == null && DynAbs.Tracing.TraceSender.Conditional_F2(1526, 50484, 50488)) || DynAbs.Tracing.TraceSender.Conditional_F3(1526, 50491, 50522))) ? null : f_1526_50491_50522(commandProcessor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 50537, 50561);

                f_1526_50537_50560(this, expectInput, crt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 49976, 50572);

                System.ArgumentNullException
                f_1526_50145_50199(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 50145, 50199);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1526_50267_50299(System.Management.Automation.EngineIntrinsics
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 50267, 50299);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1526_50267_50308(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 50267, 50308);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1526_50267_50325(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 50267, 50325);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1526_50380_50420(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 50380, 50420);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1526_50491_50522(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 50491, 50522);
                    return return_v;
                }


                int
                f_1526_50537_50560(System.Management.Automation.SteppablePipeline
                this_param, bool
                expectInput, System.Management.Automation.ICommandRuntime
                commandRuntime)
                {
                    this_param.Begin(expectInput, commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 50537, 50560);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 49976, 50572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 49976, 50572);
            }
        }

        public void Begin(InternalCommand command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 50977, 51287);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 51044, 51193) || true) && (command == null || (DynAbs.Tracing.TraceSender.Expression_False(1526, 51048, 51095) || f_1526_51067_51087(command) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 51044, 51193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 51129, 51178);

                    throw f_1526_51135_51177(nameof(command));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 51044, 51193);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 51209, 51276);

                f_1526_51209_51275(this, f_1526_51215_51250(f_1526_51215_51235(command)), command.commandRuntime);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 50977, 51287);

                System.Management.Automation.InvocationInfo
                f_1526_51067_51087(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 51067, 51087);
                    return return_v;
                }


                System.ArgumentNullException
                f_1526_51135_51177(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 51135, 51177);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1526_51215_51235(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 51215, 51235);
                    return return_v;
                }


                bool
                f_1526_51215_51250(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.ExpectingInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 51215, 51250);
                    return return_v;
                }


                int
                f_1526_51209_51275(System.Management.Automation.SteppablePipeline
                this_param, bool
                expectInput, System.Management.Automation.ICommandRuntime
                commandRuntime)
                {
                    this_param.Begin(expectInput, commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 51209, 51275);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 50977, 51287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 50977, 51287);
            }
        }

        private void Begin(bool expectInput, ICommandRuntime commandRuntime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 51299, 52555);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 51428, 51496);

                    _pipeline.ExecutionScope = f_1526_51455_51495(f_1526_51455_51482(_context));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 51514, 51556);

                    f_1526_51514_51555(_context, _pipeline);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 51574, 51601);

                    _expectInput = expectInput;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 51832, 51892);

                    MshCommandRuntime
                    crt = commandRuntime as MshCommandRuntime
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 51910, 52320) || true) && (crt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 51910, 52320);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 51967, 52118) || true) && (f_1526_51971_51985(crt) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 51967, 52118);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 52043, 52095);

                            f_1526_52043_52094(_pipeline, f_1526_52079_52093(crt));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 51967, 52118);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 52142, 52301) || true) && (f_1526_52146_52165(crt) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 52142, 52301);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 52223, 52278);

                            f_1526_52223_52277(_pipeline, f_1526_52257_52276(crt));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 52142, 52301);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 51910, 52320);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 52340, 52378);

                    f_1526_52340_52377(
                                    _pipeline, _expectInput);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1526, 52407, 52544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 52493, 52529);

                    f_1526_52493_52528(                // then pop this pipeline...
                                    _context, true);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1526, 52407, 52544);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 51299, 52555);

                System.Management.Automation.SessionStateInternal
                f_1526_51455_51482(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 51455, 51482);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1526_51455_51495(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 51455, 51495);
                    return return_v;
                }


                int
                f_1526_51514_51555(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.Internal.PipelineProcessor
                pp)
                {
                    this_param.PushPipelineProcessor(pp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 51514, 51555);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1526_51971_51985(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 51971, 51985);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1526_52079_52093(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 52079, 52093);
                    return return_v;
                }


                int
                f_1526_52043_52094(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.Internal.Pipe
                pipeToUse)
                {
                    this_param.LinkPipelineSuccessOutput(pipeToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 52043, 52094);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1526_52146_52165(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 52146, 52165);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1526_52257_52276(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 52257, 52276);
                    return return_v;
                }


                int
                f_1526_52223_52277(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.Internal.Pipe
                pipeToUse)
                {
                    this_param.LinkPipelineErrorOutput(pipeToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 52223, 52277);
                    return 0;
                }


                int
                f_1526_52340_52377(System.Management.Automation.Internal.PipelineProcessor
                this_param, bool
                expectInput)
                {
                    this_param.StartStepping(expectInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 52340, 52377);
                    return 0;
                }


                int
                f_1526_52493_52528(System.Management.Automation.ExecutionContext
                this_param, bool
                fromSteppablePipeline)
                {
                    this_param.PopPipelineProcessor(fromSteppablePipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 52493, 52528);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 51299, 52555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 51299, 52555);
            }
        }

        public Array Process(object input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 52796, 53360);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 52891, 52933);

                    f_1526_52891_52932(_context, _pipeline);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 52951, 53183) || true) && (_expectInput)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 52951, 53183);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 53009, 53038);

                        return f_1526_53016_53037(_pipeline, input);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 52951, 53183);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 52951, 53183);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 53120, 53164);

                        return f_1526_53127_53163(_pipeline, f_1526_53142_53162());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 52951, 53183);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1526, 53212, 53349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 53298, 53334);

                    f_1526_53298_53333(                // then pop this pipeline...
                                    _context, true);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1526, 53212, 53349);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 52796, 53360);

                int
                f_1526_52891_52932(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.Internal.PipelineProcessor
                pp)
                {
                    this_param.PushPipelineProcessor(pp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 52891, 52932);
                    return 0;
                }


                System.Array
                f_1526_53016_53037(System.Management.Automation.Internal.PipelineProcessor
                this_param, object
                input)
                {
                    var return_v = this_param.Step(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 53016, 53037);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_53142_53162()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 53142, 53162);
                    return return_v;
                }


                System.Array
                f_1526_53127_53163(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.PSObject
                input)
                {
                    var return_v = this_param.Step((object)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 53127, 53163);
                    return return_v;
                }


                int
                f_1526_53298_53333(System.Management.Automation.ExecutionContext
                this_param, bool
                fromSteppablePipeline)
                {
                    this_param.PopPipelineProcessor(fromSteppablePipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 53298, 53333);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 52796, 53360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 52796, 53360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Array Process(PSObject input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 53743, 54309);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 53840, 53882);

                    f_1526_53840_53881(_context, _pipeline);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 53900, 54132) || true) && (_expectInput)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 53900, 54132);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 53958, 53987);

                        return f_1526_53965_53986(_pipeline, input);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 53900, 54132);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 53900, 54132);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 54069, 54113);

                        return f_1526_54076_54112(_pipeline, f_1526_54091_54111());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 53900, 54132);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1526, 54161, 54298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 54247, 54283);

                    f_1526_54247_54282(                // then pop this pipeline...
                                    _context, true);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1526, 54161, 54298);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 53743, 54309);

                int
                f_1526_53840_53881(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.Internal.PipelineProcessor
                pp)
                {
                    this_param.PushPipelineProcessor(pp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 53840, 53881);
                    return 0;
                }


                System.Array
                f_1526_53965_53986(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.PSObject
                input)
                {
                    var return_v = this_param.Step((object)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 53965, 53986);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1526_54091_54111()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 54091, 54111);
                    return return_v;
                }


                System.Array
                f_1526_54076_54112(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.PSObject
                input)
                {
                    var return_v = this_param.Step((object)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 54076, 54112);
                    return return_v;
                }


                int
                f_1526_54247_54282(System.Management.Automation.ExecutionContext
                this_param, bool
                fromSteppablePipeline)
                {
                    this_param.PopPipelineProcessor(fromSteppablePipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 54247, 54282);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 53743, 54309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 53743, 54309);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Array Process()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 54597, 54961);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 54680, 54722);

                    f_1526_54680_54721(_context, _pipeline);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 54740, 54784);

                    return f_1526_54747_54783(_pipeline, f_1526_54762_54782());
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1526, 54813, 54950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 54899, 54935);

                    f_1526_54899_54934(                // then pop this pipeline...
                                    _context, true);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1526, 54813, 54950);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 54597, 54961);

                int
                f_1526_54680_54721(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.Internal.PipelineProcessor
                pp)
                {
                    this_param.PushPipelineProcessor(pp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 54680, 54721);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1526_54762_54782()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 54762, 54782);
                    return return_v;
                }


                System.Array
                f_1526_54747_54783(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.PSObject
                input)
                {
                    var return_v = this_param.Step((object)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 54747, 54783);
                    return return_v;
                }


                int
                f_1526_54899_54934(System.Management.Automation.ExecutionContext
                this_param, bool
                fromSteppablePipeline)
                {
                    this_param.PopPipelineProcessor(fromSteppablePipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 54899, 54934);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 54597, 54961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 54597, 54961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Array End()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 55150, 55549);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 55229, 55271);

                    f_1526_55229_55270(_context, _pipeline);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 55289, 55319);

                    return f_1526_55296_55318(_pipeline);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1526, 55348, 55538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 55449, 55485);

                    f_1526_55449_55484(                // then pop this pipeline and dispose it...
                                    _context, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 55503, 55523);

                    f_1526_55503_55522(_pipeline);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1526, 55348, 55538);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 55150, 55549);

                int
                f_1526_55229_55270(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.Internal.PipelineProcessor
                pp)
                {
                    this_param.PushPipelineProcessor(pp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 55229, 55270);
                    return 0;
                }


                System.Array
                f_1526_55296_55318(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    var return_v = this_param.DoComplete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 55296, 55318);
                    return return_v;
                }


                int
                f_1526_55449_55484(System.Management.Automation.ExecutionContext
                this_param, bool
                fromSteppablePipeline)
                {
                    this_param.PopPipelineProcessor(fromSteppablePipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 55449, 55484);
                    return 0;
                }


                int
                f_1526_55503_55522(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 55503, 55522);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 55150, 55549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 55150, 55549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool _disposed;

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 55802, 55913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 55848, 55862);

                f_1526_55848_55861(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 55876, 55902);

                f_1526_55876_55901(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 55802, 55913);

                int
                f_1526_55848_55861(System.Management.Automation.SteppablePipeline
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 55848, 55861);
                    return 0;
                }


                int
                f_1526_55876_55901(System.Management.Automation.SteppablePipeline
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 55876, 55901);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 55802, 55913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 55802, 55913);
            }
        }

        private void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1526, 55925, 56197);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 55986, 56055) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 55986, 56055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 56033, 56040);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 55986, 56055);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 56071, 56153) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 56071, 56153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 56118, 56138);

                    f_1526_56118_56137(_pipeline);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 56071, 56153);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 56169, 56186);

                _disposed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1526, 55925, 56197);

                int
                f_1526_56118_56137(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 56118, 56137);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 55925, 56197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 55925, 56197);
            }
        }

        /// <summary>
        /// Finalizer for class SteppablePipeline.
        /// </summary>
        ~SteppablePipeline()
        {
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 56353, 56368);

            f_1526_56353_56367(this, false);
        }

        static SteppablePipeline()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1526, 48262, 56417);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1526, 48262, 56417);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 48262, 56417);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1526, 48262, 56417);

        System.ArgumentNullException
        f_1526_48704_48747(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 48704, 48747);
            return return_v;
        }


        System.ArgumentNullException
        f_1526_48838_48880(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 48838, 48880);
            return return_v;
        }


        int
        f_1526_56353_56367(System.Management.Automation.SteppablePipeline
        this_param, bool
        disposing)
        {
            this_param.Dispose(disposing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 56353, 56367);
            return 0;
        }

    }
    [Serializable]
    public class ScriptBlockToPowerShellNotSupportedException : RuntimeException
    {
        public ScriptBlockToPowerShellNotSupportedException()
        : base(f_1526_57098_57159_C(f_1526_57098_57159(typeof(ScriptBlockToPowerShellNotSupportedException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1526, 57024, 57182);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1526, 57024, 57182);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 57024, 57182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 57024, 57182);
            }
        }

        public ScriptBlockToPowerShellNotSupportedException(string message)
        : base(f_1526_57506_57513_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1526, 57418, 57536);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1526, 57418, 57536);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 57418, 57536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 57418, 57536);
            }
        }

        public ScriptBlockToPowerShellNotSupportedException(string message, Exception innerException)
        : base(f_1526_57989_57996_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1526, 57875, 58035);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1526, 57875, 58035);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 57875, 58035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 57875, 58035);
            }
        }

        internal ScriptBlockToPowerShellNotSupportedException(
                    string errorId,
                    Exception innerException,
                    string message,
                    params object[] arguments)
        : base(f_1526_58668_58729_C(string.Format(CultureInfo.CurrentCulture, message, arguments)), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1526, 58456, 58788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 58763, 58787);
                f_1526_58763_58787(this, errorId);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1526, 58456, 58788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 58456, 58788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 58456, 58788);
            }
        }

        protected ScriptBlockToPowerShellNotSupportedException(SerializationInfo info, StreamingContext context)
        : base(f_1526_59251_59255_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1526, 59126, 59287);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1526, 59126, 59287);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 59126, 59287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 59126, 59287);
            }
        }

        static ScriptBlockToPowerShellNotSupportedException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1526, 56652, 59357);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1526, 56652, 59357);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 56652, 59357);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1526, 56652, 59357);

        static string
        f_1526_57098_57159(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1526, 57098, 57159);
            return return_v;
        }


        static string
        f_1526_57098_57159_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1526, 57024, 57182);
            return return_v;
        }


        static string
        f_1526_57506_57513_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1526, 57418, 57536);
            return return_v;
        }


        static string
        f_1526_57989_57996_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1526, 57875, 58035);
            return return_v;
        }


        static string
        f_1526_58668_58729(System.Globalization.CultureInfo
        provider, string
        format, params object[]
        args)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 58668, 58729);
            return return_v;
        }


        int
        f_1526_58763_58787(System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 58763, 58787);
            return 0;
        }


        static string
        f_1526_58668_58729_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1526, 58456, 58788);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1526_59251_59255_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1526, 59126, 59287);
            return return_v;
        }

    }
    internal sealed class ScriptBlockInvocationEventArgs : EventArgs
    {
        internal ScriptBlockInvocationEventArgs(
                    ScriptBlock scriptBlock,
                    bool useLocalScope,
                    ScriptBlock.ErrorHandlingBehavior errorHandlingBehavior,
                    object dollarUnder,
                    object input,
                    object scriptThis,
                    Pipe outputPipe,
                    InvocationInfo invocationInfo,
                    object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1526, 60704, 61615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61627, 61673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61683, 61724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61734, 61812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61822, 61863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61873, 61908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61918, 61958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61968, 62006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 62016, 62068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 62078, 62114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 62244, 62298);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61104, 61242) || true) && (scriptBlock == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1526, 61104, 61242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61161, 61227);

                    throw f_1526_61167_61226(nameof(scriptBlock));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1526, 61104, 61242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61258, 61284);

                ScriptBlock = scriptBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61298, 61322);

                OutputPipe = outputPipe;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61336, 61366);

                UseLocalScope = useLocalScope;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61380, 61426);

                ErrorHandlingBehavior = errorHandlingBehavior;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61440, 61466);

                DollarUnder = dollarUnder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61480, 61494);

                Input = input;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61508, 61532);

                ScriptThis = scriptThis;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61546, 61578);

                InvocationInfo = invocationInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1526, 61592, 61604);

                Args = args;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1526, 60704, 61615);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1526, 60704, 61615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 60704, 61615);
            }
        }

        internal ScriptBlock ScriptBlock { get; set; }

        internal bool UseLocalScope { get; set; }

        internal ScriptBlock.ErrorHandlingBehavior ErrorHandlingBehavior { get; set; }

        internal object DollarUnder { get; set; }

        internal object Input { get; set; }

        internal object ScriptThis { get; set; }

        internal Pipe OutputPipe { get; set; }

        internal InvocationInfo InvocationInfo { get; set; }

        internal object[] Args { get; set; }

        internal ExceptionDispatchInfo Exception { get; set; }

        static ScriptBlockInvocationEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1526, 59484, 62305);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1526, 59484, 62305);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1526, 59484, 62305);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1526, 59484, 62305);

        System.Management.Automation.PSArgumentNullException
        f_1526_61167_61226(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1526, 61167, 61226);
            return return_v;
        }

    }
}
