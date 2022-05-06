// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Management.Automation.Language;

namespace System.Management.Automation
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class ArgumentCompleterAttribute : Attribute
    {
        [SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
        public Type Type { get; private set; }

        public ScriptBlock ScriptBlock { get; private set; }

        public ArgumentCompleterAttribute(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1445, 1199, 1489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 837, 970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 1006, 1058);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 1268, 1450) || true) && (type == null || (DynAbs.Tracing.TraceSender.Expression_False(1445, 1272, 1352) || (f_1445_1289_1351(f_1445_1289_1309(type), t => t != typeof(IArgumentCompleter)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1445, 1268, 1450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 1386, 1435);

                    throw f_1445_1392_1434("type");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1445, 1268, 1450);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 1466, 1478);

                Type = type;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1445, 1199, 1489);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1445, 1199, 1489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1445, 1199, 1489);
            }
        }

        public ArgumentCompleterAttribute(ScriptBlock scriptBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1445, 1668, 1936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 837, 970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 1006, 1058);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 1751, 1883) || true) && (scriptBlock == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1445, 1751, 1883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 1808, 1868);

                    throw f_1445_1814_1867("scriptBlock");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1445, 1751, 1883);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 1899, 1925);

                ScriptBlock = scriptBlock;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1445, 1668, 1936);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1445, 1668, 1936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1445, 1668, 1936);
            }
        }

        static ArgumentCompleterAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1445, 671, 1943);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1445, 671, 1943);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1445, 671, 1943);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1445, 671, 1943);

        System.Type[]
        f_1445_1289_1309(System.Type
        this_param)
        {
            var return_v = this_param.GetInterfaces();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 1289, 1309);
            return return_v;
        }


        bool
        f_1445_1289_1351(System.Type[]
        source, System.Func<System.Type, bool>
        predicate)
        {
            var return_v = source.All<System.Type>(predicate);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 1289, 1351);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1445_1392_1434(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 1392, 1434);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1445_1814_1867(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 1814, 1867);
            return return_v;
        }

    }

    /// <summary>
    /// A type specified by the <see cref="ArgumentCompleterAttribute"/> must implement this interface.
    /// </summary>
    public interface IArgumentCompleter
    {

        IEnumerable<CompletionResult> CompleteArgument(
                    string commandName,
                    string parameterName,
                    string wordToComplete,
                    CommandAst commandAst,
                    IDictionary fakeBoundParameters);
    }
    [Cmdlet(VerbsLifecycle.Register, "ArgumentCompleter", HelpUri = "https://go.microsoft.com/fwlink/?LinkId=528576")]
    public class RegisterArgumentCompleterCommand : PSCmdlet
    {
        [Parameter(ParameterSetName = "NativeSet", Mandatory = true)]
        [Parameter(ParameterSetName = "PowerShellSet")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] CommandName { get; set; }

        [Parameter(ParameterSetName = "PowerShellSet", Mandatory = true)]
        public string ParameterName { get; set; }

        [Parameter(Mandatory = true)]
        [AllowNull()]
        public ScriptBlock ScriptBlock { get; set; }

        [Parameter(ParameterSetName = "NativeSet")]
        public SwitchParameter Native { get; set; }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1445, 4554, 5959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 4618, 4670);

                Dictionary<string, ScriptBlock>
                completerDictionary
                = default(Dictionary<string, ScriptBlock>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 4684, 5232) || true) && (f_1445_4688_4701() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1445, 4684, 5232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 4743, 4947);

                    completerDictionary = f_1445_4765_4797(f_1445_4765_4772()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>>(1445, 4765, 4946) ?? (f_1445_4841_4848().CustomArgumentCompleters = f_1445_4876_4945(f_1445_4912_4944())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1445, 4684, 5232);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1445, 4684, 5232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 5013, 5217);

                    completerDictionary = f_1445_5035_5067(f_1445_5035_5042()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>>(1445, 5035, 5216) ?? (f_1445_5111_5118().NativeArgumentCompleters = f_1445_5146_5215(f_1445_5182_5214())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1445, 4684, 5232);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 5248, 5374) || true) && (f_1445_5252_5263() == null || (DynAbs.Tracing.TraceSender.Expression_False(1445, 5252, 5298) || f_1445_5275_5293(f_1445_5275_5286()) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1445, 5248, 5374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 5332, 5359);

                    CommandName = new[] { "" };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1445, 5248, 5374);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 5399, 5404);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 5390, 5948) || true) && (i < f_1445_5410_5428(f_1445_5410_5421()))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 5430, 5433)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1445, 5390, 5948))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1445, 5390, 5948);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 5467, 5492);

                        var
                        key = f_1445_5477_5488()[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 5510, 5874) || true) && (!f_1445_5515_5555(f_1445_5541_5554()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1445, 5510, 5874);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 5597, 5855) || true) && (!f_1445_5602_5632(key))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1445, 5597, 5855);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 5682, 5714);

                                key = key + ":" + f_1445_5700_5713();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1445, 5597, 5855);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1445, 5597, 5855);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 5812, 5832);

                                key = f_1445_5818_5831();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1445, 5597, 5855);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1445, 5510, 5874);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 5894, 5933);

                        completerDictionary[key] = f_1445_5921_5932();
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1445, 1, 559);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1445, 1, 559);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1445, 4554, 5959);

                string
                f_1445_4688_4701()
                {
                    var return_v = ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 4688, 4701);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1445_4765_4772()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 4765, 4772);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                f_1445_4765_4797(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CustomArgumentCompleters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 4765, 4797);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1445_4841_4848()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 4841, 4848);
                    return return_v;
                }


                System.StringComparer
                f_1445_4912_4944()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 4912, 4944);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                f_1445_4876_4945(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 4876, 4945);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1445_5035_5042()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5035, 5042);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                f_1445_5035_5067(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.NativeArgumentCompleters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5035, 5067);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1445_5111_5118()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5111, 5118);
                    return return_v;
                }


                System.StringComparer
                f_1445_5182_5214()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5182, 5214);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                f_1445_5146_5215(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 5146, 5215);
                    return return_v;
                }


                string[]
                f_1445_5252_5263()
                {
                    var return_v = CommandName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5252, 5263);
                    return return_v;
                }


                string[]
                f_1445_5275_5286()
                {
                    var return_v = CommandName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5275, 5286);
                    return return_v;
                }


                int
                f_1445_5275_5293(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5275, 5293);
                    return return_v;
                }


                string[]
                f_1445_5410_5421()
                {
                    var return_v = CommandName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5410, 5421);
                    return return_v;
                }


                int
                f_1445_5410_5428(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5410, 5428);
                    return return_v;
                }


                string[]
                f_1445_5477_5488()
                {
                    var return_v = CommandName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5477, 5488);
                    return return_v;
                }


                string
                f_1445_5541_5554()
                {
                    var return_v = ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5541, 5554);
                    return return_v;
                }


                bool
                f_1445_5515_5555(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 5515, 5555);
                    return return_v;
                }


                bool
                f_1445_5602_5632(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 5602, 5632);
                    return return_v;
                }


                string
                f_1445_5700_5713()
                {
                    var return_v = ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5700, 5713);
                    return return_v;
                }


                string
                f_1445_5818_5831()
                {
                    var return_v = ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5818, 5831);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1445_5921_5932()
                {
                    var return_v = ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 5921, 5932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1445, 4554, 5959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1445, 4554, 5959);
            }
        }

        public RegisterArgumentCompleterCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1445, 3497, 5966);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 3737, 4000);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 4059, 4175);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 4234, 4340);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1445, 3497, 5966);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1445, 3497, 5966);
        }


        static RegisterArgumentCompleterCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1445, 3497, 5966);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1445, 3497, 5966);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1445, 3497, 5966);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1445, 3497, 5966);
    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class ArgumentCompletionsAttribute : Attribute
    {
        private string[] _completions;

        public ArgumentCompletionsAttribute(params string[] completions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1445, 6897, 7343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 6491, 6503);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 6986, 7118) || true) && (completions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1445, 6986, 7118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 7043, 7103);

                    throw f_1445_7049_7102("completions");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1445, 6986, 7118);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 7134, 7289) || true) && (f_1445_7138_7156(completions) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1445, 7134, 7289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 7195, 7274);

                    throw f_1445_7201_7273("completions", completions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1445, 7134, 7289);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 7305, 7332);

                _completions = completions;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1445, 6897, 7343);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1445, 6897, 7343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1445, 6897, 7343);
            }
        }

        public IEnumerable<CompletionResult> CompleteArgument(string commandName, string parameterName, string wordToComplete, CommandAst commandAst, IDictionary fakeBoundParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1445, 7463, 8103);

                var listYield = new List<CompletionResult>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 7662, 7810);

                var
                wordToCompletePattern = f_1445_7690_7809((DynAbs.Tracing.TraceSender.Conditional_F1(1445, 7710, 7751) || ((f_1445_7710_7751(wordToComplete) && DynAbs.Tracing.TraceSender.Conditional_F2(1445, 7754, 7757)) || DynAbs.Tracing.TraceSender.Conditional_F3(1445, 7760, 7780))) ? "*" : wordToComplete + "*", WildcardOptions.IgnoreCase)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 7826, 8092);
                    foreach (var str in f_1445_7846_7858_I(_completions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1445, 7826, 8092);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 7892, 8077) || true) && (f_1445_7896_7930(wordToCompletePattern, str))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1445, 7892, 8077);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1445, 7972, 8058);

                            listYield.Add(f_1445_7985_8057(str, str, CompletionResultType.ParameterValue, str));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1445, 7892, 8077);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1445, 7826, 8092);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1445, 1, 267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1445, 1, 267);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1445, 7463, 8103);

                return listYield;

                bool
                f_1445_7710_7751(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 7710, 7751);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1445_7690_7809(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 7690, 7809);
                    return return_v;
                }


                bool
                f_1445_7896_7930(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 7896, 7930);
                    return return_v;
                }


                System.Management.Automation.CompletionResult
                f_1445_7985_8057(string
                completionText, string
                listItemText, System.Management.Automation.CompletionResultType
                resultType, string
                toolTip)
                {
                    var return_v = new System.Management.Automation.CompletionResult(completionText, listItemText, resultType, toolTip);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 7985, 8057);
                    return return_v;
                }


                string[]
                f_1445_7846_7858_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 7846, 7858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1445, 7463, 8103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1445, 7463, 8103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ArgumentCompletionsAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1445, 6330, 8110);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1445, 6330, 8110);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1445, 6330, 8110);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1445, 6330, 8110);

        System.Management.Automation.PSArgumentNullException
        f_1445_7049_7102(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 7049, 7102);
            return return_v;
        }


        int
        f_1445_7138_7156(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1445, 7138, 7156);
            return return_v;
        }


        System.Management.Automation.PSArgumentOutOfRangeException
        f_1445_7201_7273(string
        paramName, string[]
        actualValue)
        {
            var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1445, 7201, 7273);
            return return_v;
        }

    }
}
