// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Linq;
using System.Management.Automation.Host;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;

namespace System.Management.Automation
{
    internal class AutomationEngine
    {
        internal Language.Parser EngineParser;

        internal ExecutionContext Context { get; }

        internal CommandDiscovery CommandDiscovery { get; }

        internal AutomationEngine(PSHost hostInterface, InitialSessionState iss)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1237, 1287, 2752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 578, 590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 764, 806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 937, 988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 1459, 1519);

                var
                pathext = f_1237_1473_1518("PATHEXT")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 1535, 2355) || true) && (f_1237_1539_1568(pathext))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1237, 1535, 2355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 1602, 1656);

                    f_1237_1602_1655("PATHEXT", ".CPL");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1237, 1535, 2355);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1237, 1535, 2355);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 1690, 2355) || true) && (!(f_1237_1696_1757(pathext, ";.CPL", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1237, 1696, 1848) || f_1237_1785_1848(pathext, ".CPL;", StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1237, 1696, 1938) || f_1237_1876_1938(pathext, ";.CPL;", StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1237, 1696, 2024) || f_1237_1966_2024(pathext, ".CPL", StringComparison.OrdinalIgnoreCase))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1237, 1690, 2355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 2202, 2267);

                        pathext += (DynAbs.Tracing.TraceSender.Conditional_F1(1237, 2213, 2247) || ((f_1237_2213_2240(pathext, f_1237_2221_2235(pathext) - 1) == ';' && DynAbs.Tracing.TraceSender.Conditional_F2(1237, 2250, 2256)) || DynAbs.Tracing.TraceSender.Conditional_F3(1237, 2259, 2266))) ? ".CPL" : ";.CPL";
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 2285, 2340);

                        f_1237_2285_2339("PATHEXT", pathext);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1237, 1690, 2355);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1237, 1535, 2355);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 2379, 2436);

                Context = f_1237_2389_2435(this, hostInterface, iss);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 2452, 2489);

                EngineParser = f_1237_2467_2488();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 2503, 2552);

                CommandDiscovery = f_1237_2522_2551(f_1237_2543_2550());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 2639, 2741);

                f_1237_2639_2740(
                            // Load the iss, resetting everything to it's defaults...
                            iss, f_1237_2648_2655(), updateOnly: false, module: null, noClobber: false, local: false, setLocation: true);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1237, 1287, 2752);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1237, 1287, 2752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1237, 1287, 2752);
            }
        }

        internal string Expand(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1237, 2880, 3188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 2937, 2968);

                var
                ast = f_1237_2947_2967(s)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 3068, 3177);

                return f_1237_3075_3150(ast, true, f_1237_3114_3121(), f_1237_3123_3149(f_1237_3123_3130())) as string ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1237, 3075, 3176) ?? string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1237, 2880, 3188);

                System.Management.Automation.Language.ExpressionAst
                f_1237_2947_2967(string
                str)
                {
                    var return_v = Parser.ScanString(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 2947, 2967);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1237_3114_3121()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1237, 3114, 3121);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1237_3123_3130()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1237, 3123, 3130);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1237_3123_3149(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1237, 3123, 3149);
                    return return_v;
                }


                object
                f_1237_3075_3150(System.Management.Automation.Language.ExpressionAst
                expressionAst, bool
                isTrustedInput, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionStateInternal
                sessionStateInternal)
                {
                    var return_v = Compiler.GetExpressionValue(expressionAst, isTrustedInput, context, sessionStateInternal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 3075, 3150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1237, 2880, 3188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1237, 2880, 3188);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ScriptBlock ParseScriptBlock(string script, bool addToHistory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1237, 3551, 3710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 3647, 3699);

                return f_1237_3654_3698(this, script, null, addToHistory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1237, 3551, 3710);

                System.Management.Automation.ScriptBlock
                f_1237_3654_3698(System.Management.Automation.AutomationEngine
                this_param, string
                script, string
                fileName, bool
                addToHistory)
                {
                    var return_v = this_param.ParseScriptBlock(script, fileName, addToHistory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 3654, 3698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1237, 3551, 3710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1237, 3551, 3710);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ScriptBlock ParseScriptBlock(string script, string fileName, bool addToHistory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1237, 3722, 4451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 3835, 3855);

                ParseError[]
                errors
                = default(ParseError[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 3869, 3953);

                var
                ast = f_1237_3879_3952(EngineParser, fileName, script, null, out errors, ParseMode.Default)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 3969, 4082) || true) && (addToHistory)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1237, 3969, 4082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 4019, 4067);

                    f_1237_4019_4066(EngineParser, f_1237_4058_4065());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1237, 3969, 4082);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 4098, 4379) || true) && (f_1237_4102_4114(errors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1237, 4098, 4379);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 4148, 4311) || true) && (f_1237_4152_4177(errors[0]))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1237, 4148, 4311);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 4219, 4292);

                        throw f_1237_4225_4291(f_1237_4254_4271(errors[0]), f_1237_4273_4290(errors[0]));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1237, 4148, 4311);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 4331, 4364);

                    throw f_1237_4337_4363(errors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1237, 4098, 4379);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1237, 4395, 4440);

                return f_1237_4402_4439(ast, isFilter: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1237, 3722, 4451);

                System.Management.Automation.Language.ScriptBlockAst
                f_1237_3879_3952(System.Management.Automation.Language.Parser
                this_param, string
                fileName, string
                input, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                tokenList, out System.Management.Automation.Language.ParseError[]
                errors, System.Management.Automation.Language.ParseMode
                parseMode)
                {
                    var return_v = this_param.Parse(fileName, input, tokenList, out errors, parseMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 3879, 3952);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1237_4058_4065()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1237, 4058, 4065);
                    return return_v;
                }


                int
                f_1237_4019_4066(System.Management.Automation.Language.Parser
                this_param, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetPreviousFirstLastToken(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 4019, 4066);
                    return 0;
                }


                bool
                f_1237_4102_4114(System.Management.Automation.Language.ParseError[]
                source)
                {
                    var return_v = source.Any<System.Management.Automation.Language.ParseError>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 4102, 4114);
                    return return_v;
                }


                bool
                f_1237_4152_4177(System.Management.Automation.Language.ParseError
                this_param)
                {
                    var return_v = this_param.IncompleteInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1237, 4152, 4177);
                    return return_v;
                }


                string
                f_1237_4254_4271(System.Management.Automation.Language.ParseError
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1237, 4254, 4271);
                    return return_v;
                }


                string
                f_1237_4273_4290(System.Management.Automation.Language.ParseError
                this_param)
                {
                    var return_v = this_param.ErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1237, 4273, 4290);
                    return return_v;
                }


                System.Management.Automation.IncompleteParseException
                f_1237_4225_4291(string
                message, string
                errorId)
                {
                    var return_v = new System.Management.Automation.IncompleteParseException(message, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 4225, 4291);
                    return return_v;
                }


                System.Management.Automation.ParseException
                f_1237_4337_4363(System.Management.Automation.Language.ParseError[]
                errors)
                {
                    var return_v = new System.Management.Automation.ParseException(errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 4337, 4363);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1237_4402_4439(System.Management.Automation.Language.ScriptBlockAst
                ast, bool
                isFilter)
                {
                    var return_v = new System.Management.Automation.ScriptBlock((System.Management.Automation.Language.IParameterMetadataProvider)ast, isFilter: isFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 4402, 4439);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1237, 3722, 4451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1237, 3722, 4451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AutomationEngine()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1237, 434, 4458);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1237, 434, 4458);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1237, 434, 4458);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1237, 434, 4458);

        string?
        f_1237_1473_1518(string
        variable)
        {
            var return_v = Environment.GetEnvironmentVariable(variable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 1473, 1518);
            return return_v;
        }


        bool
        f_1237_1539_1568(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 1539, 1568);
            return return_v;
        }


        int
        f_1237_1602_1655(string
        variable, string
        value)
        {
            Environment.SetEnvironmentVariable(variable, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 1602, 1655);
            return 0;
        }


        bool
        f_1237_1696_1757(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.EndsWith(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 1696, 1757);
            return return_v;
        }


        bool
        f_1237_1785_1848(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.StartsWith(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 1785, 1848);
            return return_v;
        }


        bool
        f_1237_1876_1938(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.Contains(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 1876, 1938);
            return return_v;
        }


        bool
        f_1237_1966_2024(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.Equals(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 1966, 2024);
            return return_v;
        }


        int
        f_1237_2221_2235(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1237, 2221, 2235);
            return return_v;
        }


        char
        f_1237_2213_2240(string
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1237, 2213, 2240);
            return return_v;
        }


        int
        f_1237_2285_2339(string
        variable, string
        value)
        {
            Environment.SetEnvironmentVariable(variable, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 2285, 2339);
            return 0;
        }


        System.Management.Automation.ExecutionContext
        f_1237_2389_2435(System.Management.Automation.AutomationEngine
        engine, System.Management.Automation.Host.PSHost
        hostInterface, System.Management.Automation.Runspaces.InitialSessionState
        initialSessionState)
        {
            var return_v = new System.Management.Automation.ExecutionContext(engine, hostInterface, initialSessionState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 2389, 2435);
            return return_v;
        }


        System.Management.Automation.Language.Parser
        f_1237_2467_2488()
        {
            var return_v = new System.Management.Automation.Language.Parser();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 2467, 2488);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1237_2543_2550()
        {
            var return_v = Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1237, 2543, 2550);
            return return_v;
        }


        System.Management.Automation.CommandDiscovery
        f_1237_2522_2551(System.Management.Automation.ExecutionContext
        context)
        {
            var return_v = new System.Management.Automation.CommandDiscovery(context);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 2522, 2551);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1237_2648_2655()
        {
            var return_v = Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1237, 2648, 2655);
            return return_v;
        }


        int
        f_1237_2639_2740(System.Management.Automation.Runspaces.InitialSessionState
        this_param, System.Management.Automation.ExecutionContext
        context, bool
        updateOnly, System.Management.Automation.PSModuleInfo
        module, bool
        noClobber, bool
        local, bool
        setLocation)
        {
            this_param.Bind(context, updateOnly: updateOnly, module: module, noClobber: noClobber, local: local, setLocation: setLocation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1237, 2639, 2740);
            return 0;
        }

    }
}

