// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

using Microsoft.PowerShell.Commands;
using Microsoft.PowerShell.DesiredStateConfiguration.Internal;

namespace System.Management.Automation.Language
{
    /// <summary>
    /// Defines the name modes for a dynamic keyword. A name expression may be required, optional or not permitted.
    /// </summary>
    public enum DynamicKeywordNameMode
    {
        /// <summary>
        /// This keyword does not take a name value.
        /// </summary>
        NoName = 0,
        /// <summary>
        /// Name must be present and simple non-empty bare word.
        /// </summary>
        SimpleNameRequired = 1,
        /// <summary>
        /// Name must be present but can also be an expression.
        /// </summary>
        NameRequired = 2,
        /// <summary>
        /// Name may be optionally present, but if it is present, it must be a non-empty bare word.
        /// </summary>
        SimpleOptionalName = 3,
        /// <summary>
        /// Name may be optionally present, expression or bare word.
        /// </summary>
        OptionalName = 4,
    };

    /// <summary>
    /// Defines the body mode for a dynamic keyword. It can be a scriptblock, hashtable or command which means no body.
    /// </summary>
    public enum DynamicKeywordBodyMode
    {
        /// <summary>
        /// The keyword act like a command.
        /// </summary>
        Command = 0,
        /// <summary>
        /// The keyword has a scriptblock body.
        /// </summary>
        ScriptBlock = 1,
        /// <summary>
        /// The keyword has hashtable body.
        /// </summary>
        Hashtable = 2,
    }
    public class DynamicKeyword
    {
        private static Dictionary<string, DynamicKeyword> DynamicKeywords
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 2475, 2673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 2511, 2658);

                    return t_dynamicKeywords ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>>(1558, 2518, 2657) ?? (t_dynamicKeywords = f_1558_2584_2656(f_1558_2623_2655())));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 2475, 2673);

                    System.StringComparer
                    f_1558_2623_2655()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 2623, 2655);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                    f_1558_2584_2656(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 2584, 2656);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 2385, 2684);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 2385, 2684);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [ThreadStatic]
        private static Dictionary<string, DynamicKeyword> t_dynamicKeywords;

        private static Stack<Dictionary<string, DynamicKeyword>> DynamicKeywordsStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 2994, 3177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 3030, 3162);

                    return t_dynamicKeywordsStack ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Stack<System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>>>(1558, 3037, 3161) ?? (t_dynamicKeywordsStack = f_1558_3113_3160()));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 2994, 3177);

                    System.Collections.Generic.Stack<System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>>
                    f_1558_3113_3160()
                    {
                        var return_v = new System.Collections.Generic.Stack<System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 3113, 3160);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 2892, 3188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 2892, 3188);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [ThreadStatic]
        private static Stack<Dictionary<string, DynamicKeyword>> t_dynamicKeywordsStack;

        public static void Reset()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 3427, 3582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 3478, 3571);

                t_dynamicKeywords = f_1558_3498_3570(f_1558_3537_3569());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 3427, 3582);

                System.StringComparer
                f_1558_3537_3569()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 3537, 3569);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                f_1558_3498_3570(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 3498, 3570);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 3427, 3582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 3427, 3582);
            }
        }

        public static void Push()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 3701, 3829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 3751, 3796);

                f_1558_3751_3795(f_1558_3751_3771(), t_dynamicKeywords);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 3810, 3818);

                f_1558_3810_3817();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 3701, 3829);

                System.Collections.Generic.Stack<System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>>
                f_1558_3751_3771()
                {
                    var return_v = DynamicKeywordsStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 3751, 3771);
                    return return_v;
                }


                int
                f_1558_3751_3795(System.Collections.Generic.Stack<System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>>
                this_param, System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 3751, 3795);
                    return 0;
                }


                int
                f_1558_3810_3817()
                {
                    Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 3810, 3817);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 3701, 3829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 3701, 3829);
            }
        }

        public static void Pop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 3940, 4047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 3989, 4036);

                t_dynamicKeywords = f_1558_4009_4035(f_1558_4009_4029());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 3940, 4047);

                System.Collections.Generic.Stack<System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>>
                f_1558_4009_4029()
                {
                    var return_v = DynamicKeywordsStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 4009, 4029);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                f_1558_4009_4035(System.Collections.Generic.Stack<System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 4009, 4035);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 3940, 4047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 3940, 4047);
            }
        }

        public static DynamicKeyword GetKeyword(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 4180, 4420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 4257, 4288);

                DynamicKeyword
                keywordToReturn
                = default(DynamicKeyword);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 4302, 4372);

                f_1558_4302_4371(f_1558_4302_4332(), name, out keywordToReturn);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 4386, 4409);

                return keywordToReturn;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 4180, 4420);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                f_1558_4302_4332()
                {
                    var return_v = DynamicKeyword.DynamicKeywords;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 4302, 4332);
                    return return_v;
                }


                bool
                f_1558_4302_4371(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                this_param, string
                key, out System.Management.Automation.Language.DynamicKeyword
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 4302, 4371);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 4180, 4420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 4180, 4420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static List<DynamicKeyword> GetKeyword()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 4599, 4753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 4671, 4742);

                return f_1558_4678_4741(f_1558_4703_4740(f_1558_4703_4733()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 4599, 4753);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                f_1558_4703_4733()
                {
                    var return_v = DynamicKeyword.DynamicKeywords;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 4703, 4733);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>.ValueCollection
                f_1558_4703_4740(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 4703, 4740);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.DynamicKeyword>
                f_1558_4678_4741(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>.ValueCollection
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.DynamicKeyword>((System.Collections.Generic.IEnumerable<System.Management.Automation.Language.DynamicKeyword>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 4678, 4741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 4599, 4753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 4599, 4753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool ContainsKeyword(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 4886, 5221);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 4958, 5138) || true) && (f_1558_4962_4988(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 4958, 5138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 5022, 5097);

                    PSArgumentNullException
                    e = f_1558_5050_5096("name")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 5115, 5123);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 4958, 5138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 5154, 5210);

                return f_1558_5161_5209(f_1558_5161_5191(), name);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 4886, 5221);

                bool
                f_1558_4962_4988(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 4962, 4988);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1558_5050_5096(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 5050, 5096);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                f_1558_5161_5191()
                {
                    var return_v = DynamicKeyword.DynamicKeywords;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 5161, 5191);
                    return return_v;
                }


                bool
                f_1558_5161_5209(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 5161, 5209);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 4886, 5221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 4886, 5221);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void AddKeyword(DynamicKeyword keywordToAdd)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 5329, 6005);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 5412, 5594) || true) && (keywordToAdd == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 5412, 5594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 5470, 5553);

                    PSArgumentNullException
                    e = f_1558_5498_5552("keywordToAdd")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 5571, 5579);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 5412, 5594);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 5668, 5703);

                string
                name = f_1558_5682_5702(keywordToAdd)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 5717, 5865) || true) && (f_1558_5721_5747(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 5717, 5865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 5781, 5850);

                    throw f_1558_5787_5849("keywordToAdd.Keyword");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 5717, 5865);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 5881, 5925);

                f_1558_5881_5924(f_1558_5881_5911(), name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 5939, 5994);

                f_1558_5939_5993(f_1558_5939_5969(), name, keywordToAdd);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 5329, 6005);

                System.Management.Automation.PSArgumentNullException
                f_1558_5498_5552(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 5498, 5552);
                    return return_v;
                }


                string
                f_1558_5682_5702(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.Keyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 5682, 5702);
                    return return_v;
                }


                bool
                f_1558_5721_5747(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 5721, 5747);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1558_5787_5849(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 5787, 5849);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                f_1558_5881_5911()
                {
                    var return_v =
                                DynamicKeyword.DynamicKeywords;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 5881, 5911);
                    return return_v;
                }


                bool
                f_1558_5881_5924(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 5881, 5924);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                f_1558_5939_5969()
                {
                    var return_v = DynamicKeyword.DynamicKeywords;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 5939, 5969);
                    return return_v;
                }


                int
                f_1558_5939_5993(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                this_param, string
                key, System.Management.Automation.Language.DynamicKeyword
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 5939, 5993);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 5329, 6005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 5329, 6005);
            }
        }

        public static void RemoveKeyword(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 6223, 6544);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 6293, 6473) || true) && (f_1558_6297_6323(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 6293, 6473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 6357, 6432);

                    PSArgumentNullException
                    e = f_1558_6385_6431("name")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 6450, 6458);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 6293, 6473);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 6489, 6533);

                f_1558_6489_6532(f_1558_6489_6519(), name);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 6223, 6544);

                bool
                f_1558_6297_6323(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 6297, 6323);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1558_6385_6431(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 6385, 6431);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                f_1558_6489_6519()
                {
                    var return_v =
                                DynamicKeyword.DynamicKeywords;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 6489, 6519);
                    return return_v;
                }


                bool
                f_1558_6489_6532(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeyword>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 6489, 6532);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 6223, 6544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 6223, 6544);
            }
        }

        internal static bool IsHiddenKeyword(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 6723, 7050);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 6797, 6977) || true) && (f_1558_6801_6827(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 6797, 6977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 6861, 6936);

                    PSArgumentNullException
                    e = f_1558_6889_6935("name")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 6954, 6962);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 6797, 6977);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 6993, 7039);

                return f_1558_7000_7038(s_hiddenDynamicKeywords, name);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 6723, 7050);

                bool
                f_1558_6801_6827(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 6801, 6827);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1558_6889_6935(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 6889, 6935);
                    return return_v;
                }


                bool
                f_1558_7000_7038(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 7000, 7038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 6723, 7050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 6723, 7050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly HashSet<string> s_hiddenDynamicKeywords;

        public DynamicKeyword Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 7588, 8826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 7641, 8405);

                DynamicKeyword
                keyword = new DynamicKeyword()
                {
                    ImplementingModule = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1558_7740_7763(this), 1558, 7666, 8404),
                    ImplementingModuleVersion = f_1558_7810_7840(this),
                    Keyword = f_1558_7869_7881(this),
                    ResourceName = f_1558_7915_7932(this),
                    BodyMode = f_1558_7962_7975(this),
                    DirectCall = f_1558_8007_8022(this),
                    NameMode = f_1558_8052_8065(this),
                    MetaStatement = f_1558_8100_8118(this),
                    IsReservedKeyword = f_1558_8157_8179(this),
                    HasReservedProperties = f_1558_8222_8248(this),
                    PreParse = f_1558_8278_8291(this),
                    PostParse = f_1558_8322_8336(this),
                    SemanticCheck = f_1558_8371_8389(this)
                }
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 8419, 8593);
                    foreach (KeyValuePair<string, DynamicKeywordProperty> entry in f_1558_8482_8497_I(f_1558_8482_8497(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 8419, 8593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 8531, 8578);

                        f_1558_8531_8577(f_1558_8531_8549(keyword), entry.Key, entry.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 8419, 8593);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 175);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 8609, 8784);
                    foreach (KeyValuePair<string, DynamicKeywordParameter> entry in f_1558_8673_8688_I(f_1558_8673_8688(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 8609, 8784);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 8722, 8769);

                        f_1558_8722_8768(f_1558_8722_8740(keyword), entry.Key, entry.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 8609, 8784);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 176);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 8800, 8815);

                return keyword;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 7588, 8826);

                string
                f_1558_7740_7763(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.ImplementingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 7740, 7763);
                    return return_v;
                }


                System.Version
                f_1558_7810_7840(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.ImplementingModuleVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 7810, 7840);
                    return return_v;
                }


                string
                f_1558_7869_7881(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.Keyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 7869, 7881);
                    return return_v;
                }


                string
                f_1558_7915_7932(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.ResourceName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 7915, 7932);
                    return return_v;
                }


                System.Management.Automation.Language.DynamicKeywordBodyMode
                f_1558_7962_7975(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.BodyMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 7962, 7975);
                    return return_v;
                }


                bool
                f_1558_8007_8022(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.DirectCall;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 8007, 8022);
                    return return_v;
                }


                System.Management.Automation.Language.DynamicKeywordNameMode
                f_1558_8052_8065(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.NameMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 8052, 8065);
                    return return_v;
                }


                bool
                f_1558_8100_8118(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.MetaStatement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 8100, 8118);
                    return return_v;
                }


                bool
                f_1558_8157_8179(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.IsReservedKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 8157, 8179);
                    return return_v;
                }


                bool
                f_1558_8222_8248(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.HasReservedProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 8222, 8248);
                    return return_v;
                }


                System.Func<System.Management.Automation.Language.DynamicKeyword, System.Management.Automation.Language.ParseError[]>
                f_1558_8278_8291(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.PreParse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 8278, 8291);
                    return return_v;
                }


                System.Func<System.Management.Automation.Language.DynamicKeywordStatementAst, System.Management.Automation.Language.ParseError[]>
                f_1558_8322_8336(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.PostParse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 8322, 8336);
                    return return_v;
                }


                System.Func<System.Management.Automation.Language.DynamicKeywordStatementAst, System.Management.Automation.Language.ParseError[]>
                f_1558_8371_8389(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.SemanticCheck
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 8371, 8389);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>
                f_1558_8482_8497(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 8482, 8497);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>
                f_1558_8531_8549(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 8531, 8549);
                    return return_v;
                }


                int
                f_1558_8531_8577(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>
                this_param, string
                key, System.Management.Automation.Language.DynamicKeywordProperty
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 8531, 8577);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>
                f_1558_8482_8497_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 8482, 8497);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordParameter>
                f_1558_8673_8688(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 8673, 8688);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordParameter>
                f_1558_8722_8740(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 8722, 8740);
                    return return_v;
                }


                int
                f_1558_8722_8768(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordParameter>
                this_param, string
                key, System.Management.Automation.Language.DynamicKeywordParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 8722, 8768);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordParameter>
                f_1558_8673_8688_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 8673, 8688);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 7588, 8826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 7588, 8826);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ImplementingModule { get; set; }

        public Version ImplementingModuleVersion { get; set; }

        public string Keyword { get; set; }

        public string ResourceName { get; set; }

        public DynamicKeywordBodyMode BodyMode { get; set; }

        public bool DirectCall { get; set; }

        public DynamicKeywordNameMode NameMode { get; set; }

        public bool MetaStatement { get; set; }

        public bool IsReservedKeyword { get; set; }

        public bool HasReservedProperties { get; set; }

        public Dictionary<string, DynamicKeywordProperty> Properties
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 11128, 11322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 11164, 11307);

                    return _properties ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>>(1558, 11171, 11306) ?? (_properties = f_1558_11225_11305(f_1558_11272_11304())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 11128, 11322);

                    System.StringComparer
                    f_1558_11272_11304()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 11272, 11304);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>
                    f_1558_11225_11305(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 11225, 11305);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 11043, 11333);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 11043, 11333);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Dictionary<string, DynamicKeywordProperty> _properties;

        public Dictionary<string, DynamicKeywordParameter> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 11620, 11815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 11656, 11800);

                    return _parameters ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordParameter>>(1558, 11663, 11799) ?? (_parameters = f_1558_11717_11798(f_1558_11765_11797())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 11620, 11815);

                    System.StringComparer
                    f_1558_11765_11797()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 11765, 11797);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordParameter>
                    f_1558_11717_11798(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordParameter>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 11717, 11798);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 11534, 11826);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 11534, 11826);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Dictionary<string, DynamicKeywordParameter> _parameters;

        public Func<DynamicKeyword, ParseError[]> PreParse { get; set; }

        public Func<DynamicKeywordStatementAst, ParseError[]> PostParse { get; set; }

        public Func<DynamicKeywordStatementAst, ParseError[]> SemanticCheck { get; set; }

        public DynamicKeyword()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1558, 2160, 12680);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 8981, 9027);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 9185, 9239);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 9383, 9418);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 9524, 9564);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 9714, 9766);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 10089, 10125);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 10294, 10346);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 10510, 10549);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 10689, 10732);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 10870, 10917);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 11396, 11407);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 11890, 11901);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 12124, 12188);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 12349, 12426);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 12592, 12673);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1558, 2160, 12680);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 2160, 12680);
        }


        static DynamicKeyword()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1558, 2160, 12680);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 2770, 2787);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 3281, 3303);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 7286, 7400);
            s_hiddenDynamicKeywords = new HashSet<string>(f_1558_7345_7377()) { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "MSFT_Credential", 1558, 7325, 7400) };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1558, 2160, 12680);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 2160, 12680);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1558, 2160, 12680);

        static System.StringComparer
        f_1558_7345_7377()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 7345, 7377);
            return return_v;
        }

    }
    internal static class DynamicKeywordExtension
    {
        internal static bool IsMetaDSCResource(this DynamicKeyword keyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 12750, 13159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 12842, 12897);

                string
                implementingModule = f_1558_12870_12896(keyword)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 12911, 13119) || true) && (implementingModule != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 12911, 13119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 12975, 13104);

                    return f_1558_12982_13103(implementingModule, f_1558_13008_13066(DscClassCache.DefaultModuleInfoForMetaConfigResource), StringComparison.OrdinalIgnoreCase);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 12911, 13119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 13135, 13148);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 12750, 13159);

                string
                f_1558_12870_12896(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.ImplementingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 12870, 12896);
                    return return_v;
                }


                string
                f_1558_13008_13066(System.Tuple<string, System.Version>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 13008, 13066);
                    return return_v;
                }


                bool
                f_1558_12982_13103(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 12982, 13103);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 12750, 13159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 12750, 13159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsCompatibleWithConfigurationType(this DynamicKeyword keyword, ConfigurationType ConfigurationType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 13171, 13515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 13316, 13504);

                return ((ConfigurationType == ConfigurationType.Meta && (DynAbs.Tracing.TraceSender.Expression_True(1558, 13325, 13399) && f_1558_13372_13399(keyword))) || (DynAbs.Tracing.TraceSender.Expression_False(1558, 13324, 13502) || (ConfigurationType != ConfigurationType.Meta && (DynAbs.Tracing.TraceSender.Expression_True(1558, 13426, 13501) && !f_1558_13474_13501(keyword)))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 13171, 13515);

                bool
                f_1558_13372_13399(System.Management.Automation.Language.DynamicKeyword
                keyword)
                {
                    var return_v = keyword.IsMetaDSCResource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 13372, 13399);
                    return return_v;
                }


                bool
                f_1558_13474_13501(System.Management.Automation.Language.DynamicKeyword
                keyword)
                {
                    var return_v = keyword.IsMetaDSCResource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 13474, 13501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 13171, 13515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 13171, 13515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Dictionary<string, List<string>> s_excludeKeywords;

        internal static IEnumerable<DynamicKeyword> GetAllowedKeywords(this DynamicKeyword keyword, IEnumerable<DynamicKeyword> allowedKeywords)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 14054, 14749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 14215, 14252);

                string
                keywordName = f_1558_14236_14251(keyword)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 14266, 14710) || true) && (f_1558_14270_14342(keywordName, @"Node", StringComparison.OrdinalIgnoreCase) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 14266, 14710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 14381, 14410);

                    List<string>
                    excludeKeywords
                    = default(List<string>);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 14428, 14695) || true) && (f_1558_14432_14495(s_excludeKeywords, keywordName, out excludeKeywords))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 14428, 14695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 14537, 14609);

                        return f_1558_14544_14608(allowedKeywords, k => !excludeKeywords.Contains(k.Keyword));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 14428, 14695);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 14428, 14695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 14672, 14695);

                        return allowedKeywords;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 14428, 14695);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 14266, 14710);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 14726, 14738);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 14054, 14749);

                string
                f_1558_14236_14251(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.Keyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 14236, 14251);
                    return return_v;
                }


                int
                f_1558_14270_14342(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 14270, 14342);
                    return return_v;
                }


                bool
                f_1558_14432_14495(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>
                this_param, string
                key, out System.Collections.Generic.List<string>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 14432, 14495);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.DynamicKeyword>
                f_1558_14544_14608(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.DynamicKeyword>
                source, System.Func<System.Management.Automation.Language.DynamicKeyword, bool>
                predicate)
                {
                    var return_v = source.Where<System.Management.Automation.Language.DynamicKeyword>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 14544, 14608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 14054, 14749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 14054, 14749);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DynamicKeywordExtension()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1558, 12688, 14756);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 13575, 13739);
            s_excludeKeywords = new Dictionary<string, List<string>>(f_1558_13632_13664())
        {
            {DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => @"Node",1558,13595,13739),new List<string> {DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => @"Node",1558,13700,13726)}}        };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1558, 12688, 14756);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 12688, 14756);
        }


        static System.StringComparer
        f_1558_13632_13664()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 13632, 13664);
            return return_v;
        }

    }
    public class DynamicKeywordProperty
    {
        public string Name { get; set; }

        public string TypeConstraint { get; set; }

        public List<string> Attributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 15352, 15417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 15358, 15415);

                    return _attributes ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<string>>(1558, 15365, 15414) ?? (_attributes = f_1558_15395_15413()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 15352, 15417);

                    System.Collections.Generic.List<string>
                    f_1558_15395_15413()
                    {
                        var return_v = new System.Collections.Generic.List<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 15395, 15413);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 15297, 15428);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 15297, 15428);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private List<string> _attributes;

        public List<string> Values
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 15658, 15715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 15664, 15713);

                    return _values ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<string>>(1558, 15671, 15712) ?? (_values = f_1558_15693_15711()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 15658, 15715);

                    System.Collections.Generic.List<string>
                    f_1558_15693_15711()
                    {
                        var return_v = new System.Collections.Generic.List<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 15693, 15711);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 15607, 15726);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 15607, 15726);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private List<string> _values;

        public Dictionary<string, string> ValueMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 15959, 16066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 15965, 16064);

                    return _valueMap ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<string, string>>(1558, 15972, 16063) ?? (_valueMap = f_1558_15998_16062(f_1558_16029_16061())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 15959, 16066);

                    System.StringComparer
                    f_1558_16029_16061()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 16029, 16061);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, string>
                    f_1558_15998_16062(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 15998, 16062);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 15892, 16077);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 15892, 16077);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Dictionary<string, string> _valueMap;

        public bool Mandatory { get; set; }

        public bool IsKey { get; set; }

        public Tuple<int, int> Range { get; set; }

        public DynamicKeywordProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1558, 14868, 16619);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 15006, 15038);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 15145, 15187);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 15461, 15472);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 15759, 15766);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 16124, 16133);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 16269, 16304);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 16415, 16446);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 16570, 16612);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1558, 14868, 16619);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 14868, 16619);
        }


        static DynamicKeywordProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1558, 14868, 16619);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1558, 14868, 16619);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 14868, 16619);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1558, 14868, 16619);
    }
    public class DynamicKeywordParameter : DynamicKeywordProperty
    {
        public bool Switch { get; set; }

        public DynamicKeywordParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1558, 16862, 17097);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 17058, 17090);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1558, 16862, 17097);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 16862, 17097);
        }


        static DynamicKeywordParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1558, 16862, 17097);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1558, 16862, 17097);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 16862, 17097);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1558, 16862, 17097);
    }

    internal enum TokenizerMode
    {
        Command,
        Expression,
        TypeName,
        Signature, // i.e. class or method declaration
    }

    /// <summary>
    /// Indicates which suffix character(s) are present in the numeric literal being parsed by TryGetNumberValue.
    /// </summary>
    [Flags]
    internal enum NumberSuffixFlags
    {
        /// <summary>
        /// Indicates no suffix, a raw numeric literal. May be parsed as Int32, Int64, or Double.
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Indicates 'u' suffix for unsigned integers. May be parsed as UInt32 or UInt64, depending on the value.
        /// </summary>
        Unsigned = 0x1,

        /// <summary>
        /// Indicates 'y' suffix for signed byte (sbyte) values.
        /// </summary>
        SignedByte = 0x2,

        /// <summary>
        /// Indicates 'uy' suffix for unsigned byte values.
        /// This is a compound value, representing both SignedByte and Unsigned flags being set.
        /// </summary>
        UnsignedByte = 0x3,

        /// <summary>
        /// Indicates 's' suffix for short (Int16) integers.
        /// </summary>
        Short = 0x4,

        /// <summary>
        /// Indicates 'us' suffix for ushort (UInt16) integers.
        /// This is a compound flag value, representing both Unsigned and Short flags being set.
        /// </summary>
        UnsignedShort = 0x5,

        /// <summary>
        /// Indicates 'l' suffix for long (Int64) integers.
        /// </summary>
        Long = 0x8,

        /// <summary>
        /// Indicates 'ul' suffix for ulong (UInt64) integers.
        /// This is a compound flag value, representing both Unsigned and Long flags being set.
        /// </summary>
        UnsignedLong = 0x9,

        /// <summary>
        /// Indicates 'd' suffix for decimal (128-bit) real numbers.
        /// </summary>
        Decimal = 0x10,

        /// <summary>
        /// Indicates 'I' suffix for BigInteger (arbitrarily large integer) numerals.
        /// </summary>
        BigInteger = 0x20
    }

    /// <summary>
    /// Indicates the format of a numeric literal.
    /// </summary>
    internal enum NumberFormat
    {
        /// <summary>
        /// Indicates standard decimal literal, no necessary prefix.
        /// </summary>
        Decimal = 0x0,

        /// <summary>
        /// Indicates hexadecimal literal, with '0x' prefix.
        /// </summary>
        Hex = 0x1,

        /// <summary>
        /// Indicates binary literal, with '0b' prefix.
        /// </summary>
        Binary = 0x2
    }
    internal class TokenizerState
    {
        internal int NestedTokensAdjustment;

        internal string Script;

        internal int TokenStart;

        internal int CurrentIndex;

        internal Token FirstToken;

        internal Token LastToken;

        internal BitArray SkippedCharOffsets;

        internal List<Token> TokenList;

        public TokenizerState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1558, 19964, 20315);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20023, 20045);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20072, 20078);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20102, 20112);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20136, 20148);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20174, 20184);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20210, 20219);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20248, 20266);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20298, 20307);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1558, 19964, 20315);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 19964, 20315);
        }


        static TokenizerState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1558, 19964, 20315);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1558, 19964, 20315);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 19964, 20315);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1558, 19964, 20315);
    }
    [DebuggerDisplay("Mode = {Mode}; Script = {_script}")]
    internal class Tokenizer
    {
        private static readonly Dictionary<string, TokenKind> s_keywordTable
        ;

        private static readonly Dictionary<string, TokenKind> s_operatorTable
        ;

        private static readonly char s_invalidChar;

        private static readonly int s_maxNumberOfUnicodeHexDigits;

        private readonly Parser _parser;

        private PositionHelper _positionHelper;

        private int _nestedTokensAdjustment;

        private BitArray _skippedCharOffsets;

        private string _script;

        private int _tokenStart;

        private int _currentIndex;

        private InternalScriptExtent _beginSignatureExtent;

        private static readonly string[] s_keywordText;

        private static readonly TokenKind[] s_keywordTokenKind;

        internal static readonly string[] _operatorText;

        private static readonly TokenKind[] s_operatorTokenKind;

        static Tokenizer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1558, 29356, 30753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20478, 20575);
                s_keywordTable = f_1558_20508_20575(f_1558_20542_20574());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20640, 20738);
                s_operatorTable = f_1558_20671_20738(f_1558_20705_20737());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20780, 20809);
                s_invalidChar = char.MaxValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20848, 20881);
                s_maxNumberOfUnicodeHexDigits = 6;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 21937, 23551);
                s_keywordText = new string[] {
        /*1*/    "elseif",                  "if",               "else",             "switch",                     /*1*/
        /*2*/    "foreach",                 "from",             "in",               "for",                        /*2*/
        /*3*/    "while",                   "until",            "do",               "try",                        /*3*/
        /*4*/    "catch",                   "finally",          "trap",             "data",                       /*4*/
        /*5*/    "return",                  "continue",         "break",            "exit",                       /*5*/
        /*6*/    "throw",                   "begin",            "process",          "end",                        /*6*/
        /*7*/    "dynamicparam",            "function",         "filter",           "param",                      /*7*/
        /*8*/    "class",                   "define",           "var",              "using",                      /*8*/
        /*9*/    "workflow",                "parallel",         "sequence",         "inlinescript",               /*9*/
        /*A*/    "configuration",           "public",           "private",          "static",                     /*A*/
        /*B*/    "interface",               "enum",             "namespace",        "module",                     /*B*/
        /*C*/    "type",                    "assembly",         "command",          "hidden",                     /*C*/
        /*D*/    "base",                                                                                          /*D*/
        };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 23600, 25222);
                s_keywordTokenKind = new TokenKind[] {
        /*1*/    TokenKind.ElseIf,          TokenKind.If,       TokenKind.Else,     TokenKind.Switch,             /*1*/
        /*2*/    TokenKind.Foreach,         TokenKind.From,     TokenKind.In,       TokenKind.For,                /*2*/
        /*3*/    TokenKind.While,           TokenKind.Until,    TokenKind.Do,       TokenKind.Try,                /*3*/
        /*4*/    TokenKind.Catch,           TokenKind.Finally,  TokenKind.Trap,     TokenKind.Data,               /*4*/
        /*5*/    TokenKind.Return,          TokenKind.Continue, TokenKind.Break,    TokenKind.Exit,               /*5*/
        /*6*/    TokenKind.Throw,           TokenKind.Begin,    TokenKind.Process,  TokenKind.End,                /*6*/
        /*7*/    TokenKind.Dynamicparam,    TokenKind.Function, TokenKind.Filter,   TokenKind.Param,              /*7*/
        /*8*/    TokenKind.Class,           TokenKind.Define,   TokenKind.Var,      TokenKind.Using,              /*8*/
        /*9*/    TokenKind.Workflow,        TokenKind.Parallel, TokenKind.Sequence, TokenKind.InlineScript,       /*9*/
        /*A*/    TokenKind.Configuration,   TokenKind.Public,   TokenKind.Private,  TokenKind.Static,             /*A*/
        /*B*/    TokenKind.Interface,       TokenKind.Enum,     TokenKind.Namespace,TokenKind.Module,             /*B*/
        /*C*/    TokenKind.Type,            TokenKind.Assembly, TokenKind.Command,  TokenKind.Hidden,             /*C*/
        /*D*/    TokenKind.Base,                                                                                  /*D*/
        };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 25269, 27253);
                _operatorText = new string[] {
        /*1*/   "bnot",                 "not",                  "eq",                   "ieq",                    /*1*/
        /*2*/   "ceq",                  "ne",                   "ine",                  "cne",                    /*2*/
        /*3*/   "ge",                   "ige",                  "cge",                  "gt",                     /*3*/
        /*4*/   "igt",                  "cgt",                  "lt",                   "ilt",                    /*4*/
        /*5*/   "clt",                  "le",                   "ile",                  "cle",                    /*5*/
        /*6*/   "like",                 "ilike",                "clike",                "notlike",                /*6*/
        /*7*/   "inotlike",             "cnotlike",             "match",                "imatch",                 /*7*/
        /*8*/   "cmatch",               "notmatch",             "inotmatch",            "cnotmatch",              /*8*/
        /*9*/   "replace",              "ireplace",             "creplace",             "contains",               /*9*/
        /*10*/  "icontains",            "ccontains",            "notcontains",          "inotcontains",           /*10*/
        /*11*/  "cnotcontains",         "in",                   "iin",                  "cin",                    /*11*/
        /*12*/  "notin",                "inotin",               "cnotin",               "split",                  /*12*/
        /*13*/  "isplit",               "csplit",               "isnot",                "is",                     /*13*/
        /*14*/  "as",                   "f",                    "and",                  "band",                   /*14*/
        /*15*/  "or",                   "bor",                  "xor",                  "bxor",                   /*15*/
        /*16*/  "join",                 "shl",                  "shr",                                            /*16*/
        };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 27302, 29295);
                s_operatorTokenKind = new TokenKind[] {
        /*1*/   TokenKind.Bnot,         TokenKind.Not,          TokenKind.Ieq,          TokenKind.Ieq,            /*1*/
        /*2*/   TokenKind.Ceq,          TokenKind.Ine,          TokenKind.Ine,          TokenKind.Cne,            /*2*/
        /*3*/   TokenKind.Ige,          TokenKind.Ige,          TokenKind.Cge,          TokenKind.Igt,            /*3*/
        /*4*/   TokenKind.Igt,          TokenKind.Cgt,          TokenKind.Ilt,          TokenKind.Ilt,            /*4*/
        /*5*/   TokenKind.Clt,          TokenKind.Ile,          TokenKind.Ile,          TokenKind.Cle,            /*5*/
        /*6*/   TokenKind.Ilike,        TokenKind.Ilike,        TokenKind.Clike,        TokenKind.Inotlike,       /*6*/
        /*7*/   TokenKind.Inotlike,     TokenKind.Cnotlike,     TokenKind.Imatch,       TokenKind.Imatch,         /*7*/
        /*8*/   TokenKind.Cmatch,       TokenKind.Inotmatch,    TokenKind.Inotmatch,    TokenKind.Cnotmatch,      /*8*/
        /*9*/   TokenKind.Ireplace,     TokenKind.Ireplace,     TokenKind.Creplace,     TokenKind.Icontains,      /*9*/
        /*10*/  TokenKind.Icontains,    TokenKind.Ccontains,    TokenKind.Inotcontains, TokenKind.Inotcontains,   /*10*/
        /*11*/  TokenKind.Cnotcontains, TokenKind.Iin,          TokenKind.Iin,          TokenKind.Cin,            /*11*/
        /*12*/  TokenKind.Inotin,       TokenKind.Inotin,       TokenKind.Cnotin,       TokenKind.Isplit,         /*12*/
        /*13*/  TokenKind.Isplit,       TokenKind.Csplit,       TokenKind.IsNot,        TokenKind.Is,             /*13*/
        /*14*/  TokenKind.As,           TokenKind.Format,       TokenKind.And,          TokenKind.Band,           /*14*/
        /*15*/  TokenKind.Or,           TokenKind.Bor,          TokenKind.Xor,          TokenKind.Bxor,           /*15*/
        /*16*/  TokenKind.Join,         TokenKind.Shl,          TokenKind.Shr,                                    /*16*/
        };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 78923, 78947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 78979, 79005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 79037, 79061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 79093, 79119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 79151, 79177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 79209, 79233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 79265, 79302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 29399, 29503);

                f_1558_29399_29502(f_1558_29418_29438(s_keywordText) == f_1558_29442_29467(s_keywordTokenKind), "Keyword table sizes must match");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 29517, 29623);

                f_1558_29517_29622(f_1558_29536_29556(_operatorText) == f_1558_29560_29586(s_operatorTokenKind), "Operator table sizes must match");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 29648, 29653);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 29639, 29793) || true) && (i < f_1558_29659_29679(s_keywordText))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 29681, 29684)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 29639, 29793))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 29639, 29793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 29718, 29778);

                        f_1558_29718_29777(s_keywordTable, s_keywordText[i], s_keywordTokenKind[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 155);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 29818, 29823);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 29809, 29965) || true) && (i < f_1558_29829_29849(_operatorText))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 29851, 29854)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 29809, 29965))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 29809, 29965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 29888, 29950);

                        f_1558_29888_29949(s_operatorTable, _operatorText[i], s_operatorTokenKind[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 157);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 30329, 30379);

                const string
                beginSig = "sig#beginsignatureblock"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 30393, 30444);

                f_1558_30393_30443(beginSig, 0, (current, t) => current + t);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 30528, 30628);

                f_1558_30528_30627(f_1558_30547_30570(s_keywordTable, "using") == TokenKind.Using, "Keyword table out of sync w/ enum");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 30642, 30742);

                f_1558_30642_30741(f_1558_30661_30684(s_operatorTable, "join") == TokenKind.Join, "Operator table out of sync w/ enum");
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1558, 29356, 30753);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 29356, 30753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 29356, 30753);
            }
        }

        internal Tokenizer(Parser parser)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1558, 30765, 30851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20918, 20925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20959, 20974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 20997, 21020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 21661, 21680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 21708, 21715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 21738, 21749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 21772, 21785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 21825, 21846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 30863, 30904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 30914, 30960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 31075, 31106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 31318, 31360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 31370, 31415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 31425, 31469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 31479, 31526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 31538, 31584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 31596, 31644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 68625, 68653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 68704, 68748);
                this._stringBuilders = f_1558_68722_68748();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 30823, 30840);

                _parser = parser;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1558, 30765, 30851);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 30765, 30851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 30765, 30851);
            }
        }

        internal TokenizerMode Mode { get; set; }

        internal bool AllowSignedNumbers { get; set; }

        private bool _forceEndNumberOnTernaryOpChars;

        internal bool ForceEndNumberOnTernaryOpChars
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 31186, 31233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 31192, 31231);

                    return _forceEndNumberOnTernaryOpChars;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 31186, 31233);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 31117, 31306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 31117, 31306);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 31247, 31295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 31253, 31293);

                    _forceEndNumberOnTernaryOpChars = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 31247, 31295);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 31117, 31306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 31117, 31306);
                }
            }
        }

        internal bool WantSimpleName { get; set; }

        internal bool InWorkflowContext { get; set; }

        internal List<Token> TokenList { get; set; }

        internal Token FirstToken { get; private set; }

        internal Token LastToken { get; private set; }

        private List<Token> RequiresTokens { get; set; }

        private bool InCommandMode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 31656, 31726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 31687, 31724);

                return f_1558_31694_31698() == TokenizerMode.Command;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 31656, 31726);

                System.Management.Automation.Language.TokenizerMode
                f_1558_31694_31698()
                {
                    var return_v = Mode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 31694, 31698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 31656, 31726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 31656, 31726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool InExpressionMode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 31738, 31814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 31772, 31812);

                return f_1558_31779_31783() == TokenizerMode.Expression;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 31738, 31814);

                System.Management.Automation.Language.TokenizerMode
                f_1558_31779_31783()
                {
                    var return_v = Mode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 31779, 31783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 31738, 31814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 31738, 31814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool InTypeNameMode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 31826, 31898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 31858, 31896);

                return f_1558_31865_31869() == TokenizerMode.TypeName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 31826, 31898);

                System.Management.Automation.Language.TokenizerMode
                f_1558_31865_31869()
                {
                    var return_v = Mode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 31865, 31869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 31826, 31898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 31826, 31898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool InSignatureMode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 31910, 31984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 31943, 31982);

                return f_1558_31950_31954() == TokenizerMode.Signature;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 31910, 31984);

                System.Management.Automation.Language.TokenizerMode
                f_1558_31950_31954()
                {
                    var return_v = Mode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 31950, 31954);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 31910, 31984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 31910, 31984);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Initialize(string fileName, string input, List<Token> tokenList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 31996, 33113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32099, 32153);

                _positionHelper = f_1558_32117_32152(fileName, input);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32167, 32183);

                _script = input;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32197, 32224);

                this.TokenList = tokenList;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32238, 32261);

                this.FirstToken = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32275, 32297);

                this.LastToken = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32311, 32338);

                this.RequiresTokens = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32352, 32381);

                _beginSignatureExtent = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32397, 32447);

                List<int>
                lineStartMap = new List<int>(100) { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => 0, 1558, 32422, 32446) }
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32470, 32475);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32461, 32955) || true) && (i < f_1558_32481_32493(input))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32495, 32498)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 32461, 32955))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 32461, 32955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32532, 32550);

                        char
                        c = f_1558_32541_32549(input, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32570, 32822) || true) && (c == '\r')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 32570, 32822);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32625, 32755) || true) && ((i + 1) < f_1558_32639_32651(input) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 32629, 32675) && f_1558_32655_32667(input, i + 1) == '\n'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 32625, 32755);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32725, 32732);

                                i += 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 32625, 32755);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32779, 32803);

                            f_1558_32779_32802(
                                                lineStartMap, i + 1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 32570, 32822);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32842, 32940) || true) && (c == '\n')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 32842, 32940);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32897, 32921);

                            f_1558_32897_32920(lineStartMap, i + 1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 32842, 32940);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 495);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 495);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 32971, 32989);

                _currentIndex = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 33003, 33032);

                Mode = TokenizerMode.Command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 33048, 33102);

                _positionHelper.LineStartMap = f_1558_33079_33101(lineStartMap);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 31996, 33113);

                System.Management.Automation.Language.PositionHelper
                f_1558_32117_32152(string
                filename, string
                scriptText)
                {
                    var return_v = new System.Management.Automation.Language.PositionHelper(filename, scriptText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 32117, 32152);
                    return return_v;
                }


                int
                f_1558_32481_32493(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 32481, 32493);
                    return return_v;
                }


                char
                f_1558_32541_32549(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 32541, 32549);
                    return return_v;
                }


                int
                f_1558_32639_32651(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 32639, 32651);
                    return return_v;
                }


                char
                f_1558_32655_32667(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 32655, 32667);
                    return return_v;
                }


                int
                f_1558_32779_32802(System.Collections.Generic.List<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 32779, 32802);
                    return 0;
                }


                int
                f_1558_32897_32920(System.Collections.Generic.List<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 32897, 32920);
                    return 0;
                }


                int[]
                f_1558_33079_33101(System.Collections.Generic.List<int>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 33079, 33101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 31996, 33113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 31996, 33113);
            }
        }

        internal TokenizerState StartNestedScan(UnscannedSubExprToken nestedText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 33125, 34040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 33223, 33665);

                TokenizerState
                ts = new TokenizerState
                {
                    CurrentIndex = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => _currentIndex, 1558, 33243, 33664),
                    NestedTokensAdjustment = _nestedTokensAdjustment,
                    Script = _script,
                    TokenStart = _tokenStart,
                    FirstToken = f_1558_33499_33509(),
                    LastToken = f_1558_33540_33549(),
                    SkippedCharOffsets = _skippedCharOffsets,
                    TokenList = f_1558_33639_33648()
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 33681, 33699);

                _currentIndex = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 33713, 33793);

                _nestedTokensAdjustment = f_1558_33739_33792(((InternalScriptExtent)f_1558_33762_33779(nestedText)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 33807, 33834);

                _script = f_1558_33817_33833(nestedText);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 33848, 33864);

                _tokenStart = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 33878, 33930);

                _skippedCharOffsets = f_1558_33900_33929(nestedText);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 33944, 34003);

                TokenList = (DynAbs.Tracing.TraceSender.Conditional_F1(1558, 33956, 33975) || (((f_1558_33957_33966() != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1558, 33978, 33995)) || DynAbs.Tracing.TraceSender.Conditional_F3(1558, 33998, 34002))) ? f_1558_33978_33995() : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 34019, 34029);

                return ts;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 33125, 34040);

                System.Management.Automation.Language.Token
                f_1558_33499_33509()
                {
                    var return_v = FirstToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 33499, 33509);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_33540_33549()
                {
                    var return_v = LastToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 33540, 33549);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_33639_33648()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 33639, 33648);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_33762_33779(System.Management.Automation.Language.UnscannedSubExprToken
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 33762, 33779);
                    return return_v;
                }


                int
                f_1558_33739_33792(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 33739, 33792);
                    return return_v;
                }


                string
                f_1558_33817_33833(System.Management.Automation.Language.UnscannedSubExprToken
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 33817, 33833);
                    return return_v;
                }


                System.Collections.BitArray
                f_1558_33900_33929(System.Management.Automation.Language.UnscannedSubExprToken
                this_param)
                {
                    var return_v = this_param.SkippedCharOffsets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 33900, 33929);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_33957_33966()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 33957, 33966);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_33978_33995()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.Token>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 33978, 33995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 33125, 34040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 33125, 34040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void FinishNestedScan(TokenizerState ts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 34052, 34488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 34126, 34158);

                _currentIndex = ts.CurrentIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 34172, 34224);

                _nestedTokensAdjustment = ts.NestedTokensAdjustment;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 34238, 34258);

                _script = ts.Script;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 34272, 34300);

                _tokenStart = ts.TokenStart;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 34314, 34341);

                FirstToken = ts.FirstToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 34355, 34380);

                LastToken = ts.LastToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 34394, 34438);

                _skippedCharOffsets = ts.SkippedCharOffsets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 34452, 34477);

                TokenList = ts.TokenList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 34052, 34488);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 34052, 34488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 34052, 34488);
            }
        }

        private char GetChar()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 34529, 35084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 34576, 34657);

                f_1558_34576_34656(0 <= _currentIndex, "GetChar reading before start of input.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 34671, 34766);

                f_1558_34671_34765(_currentIndex <= f_1558_34707_34721(_script) + 1, "GetChar reading after end of input.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 34899, 34929);

                int
                current = _currentIndex++
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 34943, 35033) || true) && (current >= f_1558_34958_34972(_script))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 34943, 35033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 35006, 35018);

                    return '\0';
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 34943, 35033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 35049, 35073);

                return f_1558_35056_35072(_script, current);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 34529, 35084);

                int
                f_1558_34576_34656(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 34576, 34656);
                    return 0;
                }


                int
                f_1558_34707_34721(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 34707, 34721);
                    return return_v;
                }


                int
                f_1558_34671_34765(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 34671, 34765);
                    return 0;
                }


                int
                f_1558_34958_34972(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 34958, 34972);
                    return return_v;
                }


                char
                f_1558_35056_35072(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 35056, 35072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 34529, 35084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 34529, 35084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void UngetChar()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 35096, 35275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 35145, 35229);

                f_1558_35145_35228(_currentIndex > 0, "UngetChar ungetting before start of input.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 35245, 35264);

                _currentIndex -= 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 35096, 35275);

                int
                f_1558_35145_35228(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 35145, 35228);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 35096, 35275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 35096, 35275);
            }
        }

        private char PeekChar()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 35287, 35604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 35335, 35435);

                f_1558_35335_35434(0 <= _currentIndex && (DynAbs.Tracing.TraceSender.Expression_True(1558, 35354, 35407) && _currentIndex <= f_1558_35393_35407(_script)), "PeekChar out of range.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 35451, 35547) || true) && (_currentIndex == f_1558_35472_35486(_script))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 35451, 35547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 35520, 35532);

                    return '\0';
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 35451, 35547);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 35563, 35593);

                return f_1558_35570_35592(_script, _currentIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 35287, 35604);

                int
                f_1558_35393_35407(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 35393, 35407);
                    return return_v;
                }


                int
                f_1558_35335_35434(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 35335, 35434);
                    return 0;
                }


                int
                f_1558_35472_35486(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 35472, 35486);
                    return return_v;
                }


                char
                f_1558_35570_35592(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 35570, 35592);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 35287, 35604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 35287, 35604);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SkipChar()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 35616, 35800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 35664, 35754);

                f_1558_35664_35753((_currentIndex + 1) <= f_1558_35706_35720(_script), "SkipChar can't skip past EOF");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 35770, 35789);

                _currentIndex += 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 35616, 35800);

                int
                f_1558_35706_35720(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 35706, 35720);
                    return return_v;
                }


                int
                f_1558_35664_35753(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 35664, 35753);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 35616, 35800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 35616, 35800);
            }
        }

        private bool AtEof()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 35812, 35906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 35857, 35895);

                return _currentIndex > f_1558_35880_35894(_script);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 35812, 35906);

                int
                f_1558_35880_35894(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 35880, 35894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 35812, 35906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 35812, 35906);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsKeyword(string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 35918, 36277);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 35985, 36081) || true) && (f_1558_35989_36020(s_keywordTable, str))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 35985, 36081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 36054, 36066);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 35985, 36081);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 36097, 36237) || true) && (f_1558_36101_36136(str) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 36101, 36176) && !f_1558_36141_36176(str)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 36097, 36237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 36210, 36222);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 36097, 36237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 36253, 36266);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 35918, 36277);

                bool
                f_1558_35989_36020(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TokenKind>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 35989, 36020);
                    return return_v;
                }


                bool
                f_1558_36101_36136(string
                name)
                {
                    var return_v = DynamicKeyword.ContainsKeyword(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 36101, 36136);
                    return return_v;
                }


                bool
                f_1558_36141_36176(string
                name)
                {
                    var return_v = DynamicKeyword.IsHiddenKeyword(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 36141, 36176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 35918, 36277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 35918, 36277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SkipNewlines(bool skipSemis)
        {
        // We normally don't create any tokens in a Skip method, but the
        // V2 tokenizer api returns newline, semi-colon, and line
        // continuation tokens so we create them as they are encountered.
        again:
            char c = GetChar();
            switch (c)
            {
                case ' ':
                case '\t':
                case '\f':
                case '\v':
                case SpecialChars.NoBreakSpace:
                case SpecialChars.NextLine:
                    SkipWhiteSpace();
                    goto again;

                case '\r':
                case '\n':
                    ScanNewline(c);
                    goto again;

                case ';':
                    if (skipSemis)
                    {
                        ScanSemicolon();
                        goto again;
                    }

                    break;

                case '#':
                    _tokenStart = _currentIndex - 1;
                    ScanLineComment();
                    goto again;

                case '<':
                    if (PeekChar() == '#')
                    {
                        _tokenStart = _currentIndex - 1;
                        SkipChar();
                        ScanBlockComment();
                        goto again;
                    }

                    break;

                case '`':
                    char c1 = GetChar();
                    if (c1 == '\n' || c1 == '\r')
                    {
                        ScanLineContinuation(c1);
                        goto again;
                    }

                    if (char.IsWhiteSpace(c1))
                    {
                        SkipWhiteSpace();
                        goto again;
                    }

                    UngetChar();
                    break;

                default:
                    if (c.IsWhitespace())
                    {
                        SkipWhiteSpace();
                        goto again;
                    }

                    break;
            }

            UngetChar();
        }

        private void SkipWhiteSpace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 38554, 38836);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 38608, 38825) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 38608, 38825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 38653, 38673);

                        char
                        c = f_1558_38662_38672(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 38691, 38779) || true) && (!f_1558_38696_38712(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 38691, 38779);
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 38754, 38760);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 38691, 38779);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 38799, 38810);

                        f_1558_38799_38809(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 38608, 38825);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 38608, 38825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 38608, 38825);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 38554, 38836);

                char
                f_1558_38662_38672(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 38662, 38672);
                    return return_v;
                }


                bool
                f_1558_38696_38712(char
                c)
                {
                    var return_v = c.IsWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 38696, 38712);
                    return return_v;
                }


                int
                f_1558_38799_38809(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 38799, 38809);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 38554, 38836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 38554, 38836);
            }
        }

        private void ScanNewline(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 38848, 39173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 38905, 38937);

                _tokenStart = _currentIndex - 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 38951, 38968);

                f_1558_38951_38967(this, c);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 39064, 39162) || true) && (f_1558_39068_39077() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 39064, 39162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 39119, 39147);

                    f_1558_39119_39146(this, TokenKind.NewLine);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 39064, 39162);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 38848, 39173);

                int
                f_1558_38951_38967(System.Management.Automation.Language.Tokenizer
                this_param, char
                c)
                {
                    this_param.NormalizeCRLF(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 38951, 38967);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_39068_39077()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 39068, 39077);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_39119_39146(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 39119, 39146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 38848, 39173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 38848, 39173);
            }
        }

        private void ScanSemicolon()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 39185, 39472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 39238, 39270);

                _tokenStart = _currentIndex - 1;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 39366, 39461) || true) && (f_1558_39370_39379() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 39366, 39461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 39421, 39446);

                    f_1558_39421_39445(this, TokenKind.Semi);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 39366, 39461);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 39185, 39472);

                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_39370_39379()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 39370, 39379);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_39421_39445(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 39421, 39445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 39185, 39472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 39185, 39472);
            }
        }

        private void ScanLineContinuation(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 39484, 39827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 39550, 39582);

                _tokenStart = _currentIndex - 2;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 39596, 39613);

                f_1558_39596_39612(this, c);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 39709, 39816) || true) && (f_1558_39713_39722() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 39709, 39816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 39764, 39801);

                    f_1558_39764_39800(this, TokenKind.LineContinuation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 39709, 39816);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 39484, 39827);

                int
                f_1558_39596_39612(System.Management.Automation.Language.Tokenizer
                this_param, char
                c)
                {
                    this_param.NormalizeCRLF(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 39596, 39612);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_39713_39722()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 39713, 39722);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_39764_39800(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 39764, 39800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 39484, 39827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 39484, 39827);
            }
        }

        internal int GetRestorePoint()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 39839, 39982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 39894, 39922);

                _tokenStart = _currentIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 39936, 39971);

                return f_1558_39943_39970(f_1558_39943_39958(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 39839, 39982);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_39943_39958(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 39943, 39958);
                    return return_v;
                }


                int
                f_1558_39943_39970(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 39943, 39970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 39839, 39982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 39839, 39982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Resync(Token token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 39994, 40278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 40210, 40267);

                f_1558_40210_40266(this, f_1558_40217_40265(((InternalScriptExtent)f_1558_40240_40252(token))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 39994, 40278);

                System.Management.Automation.Language.IScriptExtent
                f_1558_40240_40252(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 40240, 40252);
                    return return_v;
                }


                int
                f_1558_40217_40265(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 40217, 40265);
                    return return_v;
                }


                int
                f_1558_40210_40266(System.Management.Automation.Language.Tokenizer
                this_param, int
                start)
                {
                    this_param.Resync(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 40210, 40266);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 39994, 40278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 39994, 40278);
            }
        }

        internal void Resync(int start)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 40290, 41673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 40346, 40387);

                int
                adjustment = _nestedTokensAdjustment
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 40401, 40747) || true) && (_skippedCharOffsets != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 40401, 40747);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 40475, 40502);
                        for (int
        i = _nestedTokensAdjustment
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 40466, 40732) || true) && (i < start - 1 && (DynAbs.Tracing.TraceSender.Expression_True(1558, 40504, 40551) && i < f_1558_40525_40551(_skippedCharOffsets)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 40553, 40556)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 40466, 40732))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 40466, 40732);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 40598, 40713) || true) && (f_1558_40602_40624(_skippedCharOffsets, i))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 40598, 40713);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 40674, 40690);

                                adjustment += 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 40598, 40713);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 267);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 267);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 40401, 40747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 40763, 40798);

                _currentIndex = start - adjustment;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 40812, 41041) || true) && (_currentIndex > f_1558_40832_40846(_script) + 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 40812, 41041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 40884, 40919);

                    _currentIndex = f_1558_40900_40914(_script) + 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 40812, 41041);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 40812, 41041);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 40953, 41041) || true) && (0 > _currentIndex)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 40953, 41041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 41008, 41026);

                        _currentIndex = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 40953, 41041);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 40812, 41041);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 41057, 41220) || true) && (f_1558_41061_41071() != null && (DynAbs.Tracing.TraceSender.Expression_True(1558, 41061, 41153) && _currentIndex <= f_1558_41100_41153(((InternalScriptExtent)f_1558_41123_41140(f_1558_41123_41133())))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 41057, 41220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 41187, 41205);

                    FirstToken = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 41057, 41220);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 41236, 41487) || true) && (f_1558_41240_41249() != null && (DynAbs.Tracing.TraceSender.Expression_True(1558, 41240, 41280) && f_1558_41261_41276(f_1558_41261_41270()) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 41236, 41487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 41421, 41472);

                    f_1558_41421_41471(this, f_1558_41454_41463(), start);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 41236, 41487);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 41503, 41662) || true) && (f_1558_41507_41521() != null && (DynAbs.Tracing.TraceSender.Expression_True(1558, 41507, 41557) && f_1558_41533_41553(f_1558_41533_41547()) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 41503, 41662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 41591, 41647);

                    f_1558_41591_41646(this, f_1558_41624_41638(), start);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 41503, 41662);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 40290, 41673);

                int
                f_1558_40525_40551(System.Collections.BitArray
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 40525, 40551);
                    return return_v;
                }


                bool
                f_1558_40602_40624(System.Collections.BitArray
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 40602, 40624);
                    return return_v;
                }


                int
                f_1558_40832_40846(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 40832, 40846);
                    return return_v;
                }


                int
                f_1558_40900_40914(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 40900, 40914);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_41061_41071()
                {
                    var return_v = FirstToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41061, 41071);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_41123_41133()
                {
                    var return_v = FirstToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41123, 41133);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_41123_41140(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41123, 41140);
                    return return_v;
                }


                int
                f_1558_41100_41153(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41100, 41153);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_41240_41249()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41240, 41249);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_41261_41270()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41261, 41270);
                    return return_v;
                }


                int
                f_1558_41261_41276(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41261, 41276);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_41454_41463()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41454, 41463);
                    return return_v;
                }


                int
                f_1558_41421_41471(System.Management.Automation.Language.Tokenizer
                this_param, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                tokenList, int
                start)
                {
                    this_param.RemoveTokensFromListDuringResync(tokenList, start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 41421, 41471);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_41507_41521()
                {
                    var return_v = RequiresTokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41507, 41521);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_41533_41547()
                {
                    var return_v = RequiresTokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41533, 41547);
                    return return_v;
                }


                int
                f_1558_41533_41553(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41533, 41553);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_41624_41638()
                {
                    var return_v = RequiresTokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41624, 41638);
                    return return_v;
                }


                int
                f_1558_41591_41646(System.Management.Automation.Language.Tokenizer
                this_param, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                tokenList, int
                start)
                {
                    this_param.RemoveTokensFromListDuringResync(tokenList, start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 41591, 41646);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 40290, 41673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 40290, 41673);
            }
        }

        internal void RemoveTokensFromListDuringResync(List<Token> tokenList, int start)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 41685, 42427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 41790, 41809);

                int
                removeFrom = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 41926, 41954);

                int
                i = f_1558_41934_41949(tokenList) - 1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 41968, 42079) || true) && (i >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(1558, 41972, 42023) && f_1558_41982_41999(f_1558_41982_41994(tokenList, i)) == TokenKind.EndOfInput))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 41968, 42079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42057, 42064);

                    i -= 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 41968, 42079);
                }
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42095, 42336) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42110, 42113)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 42095, 42336))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 42095, 42336);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42147, 42321) || true) && (f_1558_42151_42204(((InternalScriptExtent)f_1558_42174_42193(f_1558_42174_42186(tokenList, i)))) <= start)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 42147, 42321);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42255, 42274);

                            removeFrom = i + 1;
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 42296, 42302);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 42147, 42321);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42352, 42416);

                f_1558_42352_42415(
                            tokenList, removeFrom, f_1558_42386_42401(tokenList) - removeFrom);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 41685, 42427);

                int
                f_1558_41934_41949(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41934, 41949);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_41982_41994(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41982, 41994);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1558_41982_41999(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 41982, 41999);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_42174_42186(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42174, 42186);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_42174_42193(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42174, 42193);
                    return return_v;
                }


                int
                f_1558_42151_42204(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42151, 42204);
                    return return_v;
                }


                int
                f_1558_42386_42401(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42386, 42401);
                    return return_v;
                }


                int
                f_1558_42352_42415(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param, int
                index, int
                count)
                {
                    this_param.RemoveRange(index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 42352, 42415);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 41685, 42427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 41685, 42427);
            }
        }

        internal void ReplaceSavedTokens(Token firstOldToken, Token lastOldToken, Token newToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 42439, 43346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42553, 42628);

                int
                startOffset = f_1558_42571_42627(((InternalScriptExtent)f_1558_42594_42614(firstOldToken)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42642, 42712);

                int
                endOffset = f_1558_42658_42711(((InternalScriptExtent)f_1558_42681_42700(lastOldToken)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42726, 42754);

                int
                lastTokenToReplace = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42777, 42800);
                    for (int
        i = f_1558_42781_42796(f_1558_42781_42790()) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42768, 43335) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42810, 42813)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 42768, 43335))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 42768, 43335);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42847, 43032) || true) && (f_1558_42851_42904(((InternalScriptExtent)f_1558_42874_42893(f_1558_42874_42886(f_1558_42874_42883(), i)))) == endOffset)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 42847, 43032);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 42959, 42982);

                            lastTokenToReplace = i;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 43004, 43013);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 42847, 43032);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 43052, 43320) || true) && (f_1558_43056_43111(((InternalScriptExtent)f_1558_43079_43098(f_1558_43079_43091(f_1558_43079_43088(), i)))) == startOffset)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 43052, 43320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 43168, 43221);

                            f_1558_43168_43220(f_1558_43168_43177(), i, lastTokenToReplace - i + 1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 43243, 43273);

                            f_1558_43243_43272(f_1558_43243_43252(), i, newToken);
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 43295, 43301);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 43052, 43320);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 568);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 568);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 42439, 43346);

                System.Management.Automation.Language.IScriptExtent
                f_1558_42594_42614(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42594, 42614);
                    return return_v;
                }


                int
                f_1558_42571_42627(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42571, 42627);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_42681_42700(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42681, 42700);
                    return return_v;
                }


                int
                f_1558_42658_42711(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42658, 42711);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_42781_42790()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42781, 42790);
                    return return_v;
                }


                int
                f_1558_42781_42796(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42781, 42796);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_42874_42883()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42874, 42883);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_42874_42886(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42874, 42886);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_42874_42893(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42874, 42893);
                    return return_v;
                }


                int
                f_1558_42851_42904(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 42851, 42904);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_43079_43088()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 43079, 43088);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_43079_43091(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 43079, 43091);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_43079_43098(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 43079, 43098);
                    return return_v;
                }


                int
                f_1558_43056_43111(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 43056, 43111);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_43168_43177()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 43168, 43177);
                    return return_v;
                }


                int
                f_1558_43168_43220(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param, int
                index, int
                count)
                {
                    this_param.RemoveRange(index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 43168, 43220);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_43243_43252()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 43243, 43252);
                    return return_v;
                }


                int
                f_1558_43243_43272(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param, int
                index, System.Management.Automation.Language.Token
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 43243, 43272);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 42439, 43346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 42439, 43346);
            }
        }

        private void NormalizeCRLF(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 43358, 43579);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 43473, 43568) || true) && (c == '\r' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 43477, 43508) && f_1558_43490_43500(this) == '\n'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 43473, 43568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 43542, 43553);

                    f_1558_43542_43552(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 43473, 43568);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 43358, 43579);

                char
                f_1558_43490_43500(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 43490, 43500);
                    return return_v;
                }


                int
                f_1558_43542_43552(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 43542, 43552);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 43358, 43579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 43358, 43579);
            }
        }

        internal void CheckAstIsBeforeSignature(Ast ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 43591, 44027);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 43664, 43723) || true) && (_beginSignatureExtent == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 43664, 43723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 43716, 43723);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 43664, 43723);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 43739, 44016) || true) && (f_1558_43743_43776(_beginSignatureExtent) < f_1558_43779_43801(f_1558_43779_43789(ast)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 43739, 44016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 43835, 44001);

                    f_1558_43835_44000(this, f_1558_43847_43857(ast), nameof(ParserStrings.TokenAfterEndOfValidScriptText), f_1558_43955_43999());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 43739, 44016);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 43591, 44027);

                int
                f_1558_43743_43776(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 43743, 43776);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_43779_43789(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 43779, 43789);
                    return return_v;
                }


                int
                f_1558_43779_43801(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 43779, 43801);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_43847_43857(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 43847, 43857);
                    return return_v;
                }


                string
                f_1558_43955_43999()
                {
                    var return_v = ParserStrings.TokenAfterEndOfValidScriptText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 43955, 43999);
                    return return_v;
                }


                int
                f_1558_43835_44000(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportError(extent, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 43835, 44000);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 43591, 44027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 43591, 44027);
            }
        }

        private void ReportError(int errorOffset, string errorId, string errorMsg, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 44039, 44263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 44160, 44252);

                f_1558_44160_44251(_parser, f_1558_44180_44225(this, errorOffset, errorOffset + 1), errorId, errorMsg, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 44039, 44263);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_44180_44225(System.Management.Automation.Language.Tokenizer
                this_param, int
                start, int
                end)
                {
                    var return_v = this_param.NewScriptExtent(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 44180, 44225);
                    return return_v;
                }


                int
                f_1558_44160_44251(System.Management.Automation.Language.Parser
                this_param, System.Management.Automation.Language.InternalScriptExtent
                extent, string
                errorId, string
                errorMsg, params object[]
                args)
                {
                    this_param.ReportError((System.Management.Automation.Language.IScriptExtent)extent, errorId, errorMsg, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 44160, 44251);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 44039, 44263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 44039, 44263);
            }
        }

        private void ReportError(IScriptExtent extent, string errorId, string errorMsg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 44275, 44437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 44379, 44426);

                f_1558_44379_44425(_parser, extent, errorId, errorMsg);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 44275, 44437);

                int
                f_1558_44379_44425(System.Management.Automation.Language.Parser
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportError(extent, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 44379, 44425);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 44275, 44437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 44275, 44437);
            }
        }

        private void ReportError(IScriptExtent extent, string errorId, string errorMsg, object arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 44449, 44628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 44565, 44617);

                f_1558_44565_44616(_parser, extent, errorId, errorMsg, arg);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 44449, 44628);

                int
                f_1558_44565_44616(System.Management.Automation.Language.Parser
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, object
                arg)
                {
                    this_param.ReportError(extent, errorId, errorMsg, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 44565, 44616);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 44449, 44628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 44449, 44628);
            }
        }

        private void ReportError(IScriptExtent extent, string errorId, string errorMsg, object arg1, object arg2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 44640, 44840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 44770, 44829);

                f_1558_44770_44828(_parser, extent, errorId, errorMsg, arg1, arg2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 44640, 44840);

                int
                f_1558_44770_44828(System.Management.Automation.Language.Parser
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, object
                arg1, object
                arg2)
                {
                    this_param.ReportError(extent, errorId, errorMsg, arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 44770, 44828);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 44640, 44840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 44640, 44840);
            }
        }

        private void ReportIncompleteInput(int errorOffset, string errorId, string errorMsg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 44852, 45066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 44961, 45055);

                f_1558_44961_45054(_parser, f_1558_44991_45034(this, errorOffset, _currentIndex), errorId, errorMsg);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 44852, 45066);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_44991_45034(System.Management.Automation.Language.Tokenizer
                this_param, int
                start, int
                end)
                {
                    var return_v = this_param.NewScriptExtent(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 44991, 45034);
                    return return_v;
                }


                bool
                f_1558_44961_45054(System.Management.Automation.Language.Parser
                this_param, System.Management.Automation.Language.InternalScriptExtent
                extent, string
                errorId, string
                errorMsg)
                {
                    var return_v = this_param.ReportIncompleteInput((System.Management.Automation.Language.IScriptExtent)extent, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 44961, 45054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 44852, 45066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 44852, 45066);
            }
        }

        private void ReportIncompleteInput(int errorOffset, string errorId, string errorMsg, object arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 45078, 45309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 45199, 45298);

                f_1558_45199_45297(_parser, f_1558_45229_45272(this, errorOffset, _currentIndex), errorId, errorMsg, arg);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 45078, 45309);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_45229_45272(System.Management.Automation.Language.Tokenizer
                this_param, int
                start, int
                end)
                {
                    var return_v = this_param.NewScriptExtent(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 45229, 45272);
                    return return_v;
                }


                bool
                f_1558_45199_45297(System.Management.Automation.Language.Parser
                this_param, System.Management.Automation.Language.InternalScriptExtent
                extent, string
                errorId, string
                errorMsg, object
                arg)
                {
                    var return_v = this_param.ReportIncompleteInput((System.Management.Automation.Language.IScriptExtent)extent, errorId, errorMsg, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 45199, 45297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 45078, 45309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 45078, 45309);
            }
        }

        private InternalScriptExtent NewScriptExtent(int start, int end)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 45321, 45534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 45410, 45523);

                return f_1558_45417_45522(_positionHelper, start + _nestedTokensAdjustment, end + _nestedTokensAdjustment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 45321, 45534);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_45417_45522(System.Management.Automation.Language.PositionHelper
                _positionHelper, int
                startOffset, int
                endOffset)
                {
                    var return_v = new System.Management.Automation.Language.InternalScriptExtent(_positionHelper, startOffset, endOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 45417, 45522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 45321, 45534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 45321, 45534);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal InternalScriptExtent CurrentExtent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 45546, 46465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 45616, 45666);

                int
                start = _tokenStart + _nestedTokensAdjustment
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 45680, 45730);

                int
                end = _currentIndex + _nestedTokensAdjustment
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 45744, 46377) || true) && (_skippedCharOffsets != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 45744, 46377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 45809, 45841);

                    int
                    i = _nestedTokensAdjustment
                    ;
                    try
                    {
                        for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 45859, 46120) || true) && (i < start && (DynAbs.Tracing.TraceSender.Expression_True(1558, 45866, 45909) && i < f_1558_45883_45909(_skippedCharOffsets)))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 45911, 45914)
   , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 45859, 46120))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 45859, 46120);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 45956, 46101) || true) && (f_1558_45960_45982(_skippedCharOffsets, i))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 45956, 46101);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 46032, 46043);

                                start += 1;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 46069, 46078);

                                end += 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 45956, 46101);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 262);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 262);
                    }
                    try
                    {
                        for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 46140, 46362) || true) && (i < end && (DynAbs.Tracing.TraceSender.Expression_True(1558, 46147, 46188) && i < f_1558_46162_46188(_skippedCharOffsets)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 46190, 46193)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 46140, 46362))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 46140, 46362);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 46235, 46343) || true) && (f_1558_46239_46261(_skippedCharOffsets, i))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 46235, 46343);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 46311, 46320);

                                end += 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 46235, 46343);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 223);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 223);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 45744, 46377);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 46393, 46454);

                return f_1558_46400_46453(_positionHelper, start, end);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 45546, 46465);

                int
                f_1558_45883_45909(System.Collections.BitArray
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 45883, 45909);
                    return return_v;
                }


                bool
                f_1558_45960_45982(System.Collections.BitArray
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 45960, 45982);
                    return return_v;
                }


                int
                f_1558_46162_46188(System.Collections.BitArray
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 46162, 46188);
                    return return_v;
                }


                bool
                f_1558_46239_46261(System.Collections.BitArray
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 46239, 46261);
                    return return_v;
                }


                System.Management.Automation.Language.InternalScriptExtent
                f_1558_46400_46453(System.Management.Automation.Language.PositionHelper
                _positionHelper, int
                startOffset, int
                endOffset)
                {
                    var return_v = new System.Management.Automation.Language.InternalScriptExtent(_positionHelper, startOffset, endOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 46400, 46453);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 45546, 46465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 45546, 46465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IScriptExtent GetScriptExtent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 46477, 46595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 46542, 46584);

                return f_1558_46549_46583(this, 0, f_1558_46568_46582(_script));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 46477, 46595);

                int
                f_1558_46568_46582(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 46568, 46582);
                    return return_v;
                }


                System.Management.Automation.Language.InternalScriptExtent
                f_1558_46549_46583(System.Management.Automation.Language.Tokenizer
                this_param, int
                start, int
                end)
                {
                    var return_v = this_param.NewScriptExtent(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 46549, 46583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 46477, 46595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 46477, 46595);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token NewCommentToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 46607, 46755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 46663, 46744);

                return f_1558_46670_46743(this, f_1558_46680_46742(f_1558_46690_46705(this), TokenKind.Comment, TokenFlags.None));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 46607, 46755);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_46690_46705(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 46690, 46705);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_46680_46742(System.Management.Automation.Language.InternalScriptExtent
                scriptExtent, System.Management.Automation.Language.TokenKind
                kind, System.Management.Automation.Language.TokenFlags
                tokenFlags)
                {
                    var return_v = new System.Management.Automation.Language.Token(scriptExtent, kind, tokenFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 46680, 46742);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_46670_46743(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.Token
                token)
                {
                    var return_v = this_param.SaveToken<System.Management.Automation.Language.Token>(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 46670, 46743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 46607, 46755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 46607, 46755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private T SaveToken<T>(T token) where T : Token
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 46767, 47697);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 46839, 46930) || true) && (f_1558_46843_46852() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 46839, 46930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 46894, 46915);

                    f_1558_46894_46914(f_1558_46894_46903(), token);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 46839, 46930);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 47086, 47657);

                switch (f_1558_47094_47104(token))
                {

                    case TokenKind.NewLine:
                    case TokenKind.LineContinuation:
                    case TokenKind.Comment:
                    case TokenKind.EndOfInput:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 47086, 47657);
                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 47404, 47410);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 47086, 47657);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 47086, 47657);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 47458, 47572) || true) && (f_1558_47462_47472() == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 47458, 47572);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 47530, 47549);

                            FirstToken = token;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 47458, 47572);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 47596, 47614);

                        LastToken = token;
                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 47636, 47642);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 47086, 47657);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 47673, 47686);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 46767, 47697);

                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_46843_46852()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 46843, 46852);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_46894_46903()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 46894, 46903);
                    return return_v;
                }


                int
                f_1558_46894_46914(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param, T
                item)
                {
                    this_param.Add((System.Management.Automation.Language.Token)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 46894, 46914);
                    return 0;
                }


                System.Management.Automation.Language.TokenKind
                f_1558_47094_47104(T
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 47094, 47104);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_47462_47472()
                {
                    var return_v = FirstToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 47462, 47472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 46767, 47697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 46767, 47697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token NewToken(TokenKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 47709, 47851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 47772, 47840);

                return f_1558_47779_47839(this, f_1558_47789_47838(f_1558_47799_47814(this), kind, TokenFlags.None));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 47709, 47851);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_47799_47814(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 47799, 47814);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_47789_47838(System.Management.Automation.Language.InternalScriptExtent
                scriptExtent, System.Management.Automation.Language.TokenKind
                kind, System.Management.Automation.Language.TokenFlags
                tokenFlags)
                {
                    var return_v = new System.Management.Automation.Language.Token(scriptExtent, kind, tokenFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 47789, 47838);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_47779_47839(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.Token
                token)
                {
                    var return_v = this_param.SaveToken<System.Management.Automation.Language.Token>(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 47779, 47839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 47709, 47851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 47709, 47851);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token NewNumberToken(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 47863, 48016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 47930, 48005);

                return f_1558_47937_48004(this, f_1558_47947_48003(f_1558_47963_47978(this), value, TokenFlags.None));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 47863, 48016);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_47963_47978(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 47963, 47978);
                    return return_v;
                }


                System.Management.Automation.Language.NumberToken
                f_1558_47947_48003(System.Management.Automation.Language.InternalScriptExtent
                scriptExtent, object
                value, System.Management.Automation.Language.TokenFlags
                tokenFlags)
                {
                    var return_v = new System.Management.Automation.Language.NumberToken(scriptExtent, value, tokenFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 47947, 48003);
                    return return_v;
                }


                System.Management.Automation.Language.NumberToken
                f_1558_47937_48004(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.NumberToken
                token)
                {
                    var return_v = this_param.SaveToken<System.Management.Automation.Language.NumberToken>(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 47937, 48004);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 47863, 48016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 47863, 48016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token NewParameterToken(string name, bool sawColon)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 48028, 48193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 48112, 48182);

                return f_1558_48119_48181(this, f_1558_48129_48180(f_1558_48148_48163(this), name, sawColon));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 48028, 48193);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_48148_48163(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 48148, 48163);
                    return return_v;
                }


                System.Management.Automation.Language.ParameterToken
                f_1558_48129_48180(System.Management.Automation.Language.InternalScriptExtent
                scriptExtent, string
                parameterName, bool
                usedColon)
                {
                    var return_v = new System.Management.Automation.Language.ParameterToken(scriptExtent, parameterName, usedColon);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 48129, 48180);
                    return return_v;
                }


                System.Management.Automation.Language.ParameterToken
                f_1558_48119_48181(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.ParameterToken
                token)
                {
                    var return_v = this_param.SaveToken<System.Management.Automation.Language.ParameterToken>(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 48119, 48181);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 48028, 48193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 48028, 48193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private VariableToken NewVariableToken(VariablePath path, bool splatted)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 48205, 48399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 48302, 48388);

                return f_1558_48309_48387(this, f_1558_48319_48386(f_1558_48337_48352(this), path, TokenFlags.None, splatted));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 48205, 48399);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_48337_48352(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 48337, 48352);
                    return return_v;
                }


                System.Management.Automation.Language.VariableToken
                f_1558_48319_48386(System.Management.Automation.Language.InternalScriptExtent
                scriptExtent, System.Management.Automation.VariablePath
                path, System.Management.Automation.Language.TokenFlags
                tokenFlags, bool
                splatted)
                {
                    var return_v = new System.Management.Automation.Language.VariableToken(scriptExtent, path, tokenFlags, splatted);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 48319, 48386);
                    return return_v;
                }


                System.Management.Automation.Language.VariableToken
                f_1558_48309_48387(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.VariableToken
                token)
                {
                    var return_v = this_param.SaveToken<System.Management.Automation.Language.VariableToken>(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 48309, 48387);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 48205, 48399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 48205, 48399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private StringToken NewStringLiteralToken(string value, TokenKind tokenKind, TokenFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 48411, 48624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 48530, 48613);

                return f_1558_48537_48612(this, f_1558_48547_48611(f_1558_48570_48585(this), flags, tokenKind, value));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 48411, 48624);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_48570_48585(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 48570, 48585);
                    return return_v;
                }


                System.Management.Automation.Language.StringLiteralToken
                f_1558_48547_48611(System.Management.Automation.Language.InternalScriptExtent
                scriptExtent, System.Management.Automation.Language.TokenFlags
                flags, System.Management.Automation.Language.TokenKind
                tokenKind, string
                value)
                {
                    var return_v = new System.Management.Automation.Language.StringLiteralToken(scriptExtent, flags, tokenKind, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 48547, 48611);
                    return return_v;
                }


                System.Management.Automation.Language.StringLiteralToken
                f_1558_48537_48612(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.StringLiteralToken
                token)
                {
                    var return_v = this_param.SaveToken<System.Management.Automation.Language.StringLiteralToken>(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 48537, 48612);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 48411, 48624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 48411, 48624);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private StringToken NewStringExpandableToken(string value, string formatString, TokenKind tokenKind, List<Token> nestedTokens, TokenFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 48636, 49311);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 48805, 49170) || true) && (nestedTokens != null && (DynAbs.Tracing.TraceSender.Expression_True(1558, 48809, 48856) && f_1558_48833_48851(nestedTokens) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 48805, 49170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 48890, 48910);

                    nestedTokens = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 48805, 49170);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 48805, 49170);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 48944, 49170) || true) && ((flags & TokenFlags.TokenInError) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 48944, 49170);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 49020, 49155) || true) && (f_1558_49024_49061(nestedTokens, tok => tok.HasError))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 49020, 49155);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 49103, 49136);

                            flags |= TokenFlags.TokenInError;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 49020, 49155);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 48944, 49170);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 48805, 49170);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 49186, 49300);

                return f_1558_49193_49299(this, f_1558_49203_49298(f_1558_49229_49244(this), tokenKind, value, formatString, nestedTokens, flags));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 48636, 49311);

                int
                f_1558_48833_48851(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 48833, 48851);
                    return return_v;
                }


                bool
                f_1558_49024_49061(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                source, System.Func<System.Management.Automation.Language.Token, bool>
                predicate)
                {
                    var return_v = source.Any<System.Management.Automation.Language.Token>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 49024, 49061);
                    return return_v;
                }


                System.Management.Automation.Language.InternalScriptExtent
                f_1558_49229_49244(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 49229, 49244);
                    return return_v;
                }


                System.Management.Automation.Language.StringExpandableToken
                f_1558_49203_49298(System.Management.Automation.Language.InternalScriptExtent
                scriptExtent, System.Management.Automation.Language.TokenKind
                tokenKind, string
                value, string
                formatString, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                nestedTokens, System.Management.Automation.Language.TokenFlags
                flags)
                {
                    var return_v = new System.Management.Automation.Language.StringExpandableToken(scriptExtent, tokenKind, value, formatString, nestedTokens, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 49203, 49298);
                    return return_v;
                }


                System.Management.Automation.Language.StringExpandableToken
                f_1558_49193_49299(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.StringExpandableToken
                token)
                {
                    var return_v = this_param.SaveToken<System.Management.Automation.Language.StringExpandableToken>(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 49193, 49299);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 48636, 49311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 48636, 49311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token NewGenericExpandableToken(string value, string formatString, List<Token> nestedTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 49323, 49562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 49448, 49551);

                return f_1558_49455_49550(this, value, formatString, TokenKind.Generic, nestedTokens, TokenFlags.None);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 49323, 49562);

                System.Management.Automation.Language.StringToken
                f_1558_49455_49550(System.Management.Automation.Language.Tokenizer
                this_param, string
                value, string
                formatString, System.Management.Automation.Language.TokenKind
                tokenKind, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                nestedTokens, System.Management.Automation.Language.TokenFlags
                flags)
                {
                    var return_v = this_param.NewStringExpandableToken(value, formatString, tokenKind, nestedTokens, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 49455, 49550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 49323, 49562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 49323, 49562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token NewGenericToken(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 49574, 49725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 49642, 49714);

                return f_1558_49649_49713(this, value, TokenKind.Generic, TokenFlags.None);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 49574, 49725);

                System.Management.Automation.Language.StringToken
                f_1558_49649_49713(System.Management.Automation.Language.Tokenizer
                this_param, string
                value, System.Management.Automation.Language.TokenKind
                tokenKind, System.Management.Automation.Language.TokenFlags
                flags)
                {
                    var return_v = this_param.NewStringLiteralToken(value, tokenKind, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 49649, 49713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 49574, 49725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 49574, 49725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token NewInputRedirectionToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 49737, 49874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 49802, 49863);

                return f_1558_49809_49862(this, f_1558_49819_49861(f_1558_49845_49860(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 49737, 49874);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_49845_49860(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 49845, 49860);
                    return return_v;
                }


                System.Management.Automation.Language.InputRedirectionToken
                f_1558_49819_49861(System.Management.Automation.Language.InternalScriptExtent
                scriptExtent)
                {
                    var return_v = new System.Management.Automation.Language.InputRedirectionToken(scriptExtent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 49819, 49861);
                    return return_v;
                }


                System.Management.Automation.Language.InputRedirectionToken
                f_1558_49809_49862(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.InputRedirectionToken
                token)
                {
                    var return_v = this_param.SaveToken<System.Management.Automation.Language.InputRedirectionToken>(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 49809, 49862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 49737, 49874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 49737, 49874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token NewFileRedirectionToken(int from, bool append, bool fromSpecifiedExplicitly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 49886, 50380);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 50001, 50260) || true) && (fromSpecifiedExplicitly && (DynAbs.Tracing.TraceSender.Expression_True(1558, 50005, 50050) && f_1558_50032_50050(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 50001, 50260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 50084, 50096);

                    f_1558_50084_50095(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 50114, 50197) || true) && (append)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 50114, 50197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 50166, 50178);

                        f_1558_50166_50177(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 50114, 50197);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 50217, 50245);

                    return f_1558_50224_50244(this, from);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 50001, 50260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 50276, 50369);

                return f_1558_50283_50368(this, f_1558_50293_50367(f_1558_50318_50333(this), from, append));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 49886, 50380);

                bool
                f_1558_50032_50050(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InExpressionMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 50032, 50050);
                    return return_v;
                }


                int
                f_1558_50084_50095(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 50084, 50095);
                    return 0;
                }


                int
                f_1558_50166_50177(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 50166, 50177);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_50224_50244(System.Management.Automation.Language.Tokenizer
                this_param, int
                value)
                {
                    var return_v = this_param.NewNumberToken((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 50224, 50244);
                    return return_v;
                }


                System.Management.Automation.Language.InternalScriptExtent
                f_1558_50318_50333(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 50318, 50333);
                    return return_v;
                }


                System.Management.Automation.Language.FileRedirectionToken
                f_1558_50293_50367(System.Management.Automation.Language.InternalScriptExtent
                scriptExtent, int
                from, bool
                append)
                {
                    var return_v = new System.Management.Automation.Language.FileRedirectionToken(scriptExtent, (System.Management.Automation.Language.RedirectionStream)from, append);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 50293, 50367);
                    return return_v;
                }


                System.Management.Automation.Language.FileRedirectionToken
                f_1558_50283_50368(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.FileRedirectionToken
                token)
                {
                    var return_v = this_param.SaveToken<System.Management.Automation.Language.FileRedirectionToken>(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 50283, 50368);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 49886, 50380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 49886, 50380);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token NewMergingRedirectionToken(int from, int to)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 50392, 50597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 50475, 50586);

                return f_1558_50482_50585(this, f_1558_50492_50584(f_1558_50520_50535(this), from, to));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 50392, 50597);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_50520_50535(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 50520, 50535);
                    return return_v;
                }


                System.Management.Automation.Language.MergingRedirectionToken
                f_1558_50492_50584(System.Management.Automation.Language.InternalScriptExtent
                scriptExtent, int
                from, int
                to)
                {
                    var return_v = new System.Management.Automation.Language.MergingRedirectionToken(scriptExtent, (System.Management.Automation.Language.RedirectionStream)from, (System.Management.Automation.Language.RedirectionStream)to);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 50492, 50584);
                    return return_v;
                }


                System.Management.Automation.Language.MergingRedirectionToken
                f_1558_50482_50585(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.MergingRedirectionToken
                token)
                {
                    var return_v = this_param.SaveToken<System.Management.Automation.Language.MergingRedirectionToken>(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 50482, 50585);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 50392, 50597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 50392, 50597);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LabelToken NewLabelToken(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 50609, 50765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 50680, 50754);

                return f_1558_50687_50753(this, f_1558_50697_50752(f_1558_50712_50727(this), TokenFlags.None, value));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 50609, 50765);

                System.Management.Automation.Language.InternalScriptExtent
                f_1558_50712_50727(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 50712, 50727);
                    return return_v;
                }


                System.Management.Automation.Language.LabelToken
                f_1558_50697_50752(System.Management.Automation.Language.InternalScriptExtent
                scriptExtent, System.Management.Automation.Language.TokenFlags
                tokenFlags, string
                labelText)
                {
                    var return_v = new System.Management.Automation.Language.LabelToken(scriptExtent, tokenFlags, labelText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 50697, 50752);
                    return return_v;
                }


                System.Management.Automation.Language.LabelToken
                f_1558_50687_50753(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.LabelToken
                token)
                {
                    var return_v = this_param.SaveToken<System.Management.Automation.Language.LabelToken>(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 50687, 50753);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 50609, 50765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 50609, 50765);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsAtEndOfScript(IScriptExtent extent, bool checkCommentsAndWhitespace = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 50777, 51117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 50894, 50942);

                var
                scriptExtent = (InternalScriptExtent)extent
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 50956, 51106);

                return f_1558_50963_50985(scriptExtent) >= f_1558_50989_51003(_script) || (DynAbs.Tracing.TraceSender.Expression_False(1558, 50963, 51105) || (checkCommentsAndWhitespace && (DynAbs.Tracing.TraceSender.Expression_True(1558, 51025, 51104) && f_1558_51055_51104(this, scriptExtent))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 50777, 51117);

                int
                f_1558_50963_50985(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 50963, 50985);
                    return return_v;
                }


                int
                f_1558_50989_51003(string
                this_param)
                {
                    var return_v = this_param.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 50989, 51003);
                    return return_v;
                }


                bool
                f_1558_51055_51104(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.InternalScriptExtent
                extent)
                {
                    var return_v = this_param.OnlyWhitespaceOrCommentsAfterExtent(extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 51055, 51104);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 50777, 51117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 50777, 51117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool OnlyWhitespaceOrCommentsAfterExtent(InternalScriptExtent extent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 51129, 52025);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 51240, 51260);
                    for (int
        i = f_1558_51244_51260(extent)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 51231, 51986) || true) && (i < f_1558_51266_51280(_script))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 51282, 51285)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 51231, 51986))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 51231, 51986);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 51319, 51629) || true) && (f_1558_51323_51333(_script, i) == '#')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 51319, 51629);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 51548, 51579);

                            i = f_1558_51552_51574(this, i + 1) - 1;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 51601, 51610);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 51319, 51629);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 51649, 51847) || true) && (f_1558_51653_51663(_script, i) == '<' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 51653, 51698) && (i + 1) < f_1558_51684_51698(_script)) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 51653, 51723) && f_1558_51702_51716(_script, i + 1) == '#'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 51649, 51847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 51765, 51797);

                            i = f_1558_51769_51792(this, i + 2) - 1;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 51819, 51828);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 51649, 51847);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 51867, 51971) || true) && (!f_1558_51872_51897(f_1558_51872_51882(_script, i)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 51867, 51971);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 51939, 51952);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 51867, 51971);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 756);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 52002, 52014);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 51129, 52025);

                int
                f_1558_51244_51260(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 51244, 51260);
                    return return_v;
                }


                int
                f_1558_51266_51280(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 51266, 51280);
                    return return_v;
                }


                char
                f_1558_51323_51333(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 51323, 51333);
                    return return_v;
                }


                int
                f_1558_51552_51574(System.Management.Automation.Language.Tokenizer
                this_param, int
                i)
                {
                    var return_v = this_param.SkipLineComment(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 51552, 51574);
                    return return_v;
                }


                char
                f_1558_51653_51663(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 51653, 51663);
                    return return_v;
                }


                int
                f_1558_51684_51698(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 51684, 51698);
                    return return_v;
                }


                char
                f_1558_51702_51716(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 51702, 51716);
                    return return_v;
                }


                int
                f_1558_51769_51792(System.Management.Automation.Language.Tokenizer
                this_param, int
                i)
                {
                    var return_v = this_param.SkipBlockComment(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 51769, 51792);
                    return return_v;
                }


                char
                f_1558_51872_51882(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 51872, 51882);
                    return return_v;
                }


                bool
                f_1558_51872_51897(char
                c)
                {
                    var return_v = c.IsWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 51872, 51897);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 51129, 52025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 51129, 52025);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsPipeContinuation(IScriptExtent extent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 52037, 52387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 52277, 52376);

                return f_1558_52284_52300(extent) < f_1558_52303_52317(_script) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 52284, 52375) && f_1558_52321_52375(this, extent, continuationChar: '|'));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 52037, 52387);

                int
                f_1558_52284_52300(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 52284, 52300);
                    return return_v;
                }


                int
                f_1558_52303_52317(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 52303, 52317);
                    return return_v;
                }


                bool
                f_1558_52321_52375(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, char
                continuationChar)
                {
                    var return_v = this_param.ContinuationAfterExtent(extent, continuationChar: continuationChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 52321, 52375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 52037, 52387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 52037, 52387);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ContinuationAfterExtent(IScriptExtent extent, char continuationChar)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 52399, 54766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 52505, 52544);

                bool
                lastNonWhitespaceIsNewline = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 52558, 52583);

                int
                i = f_1558_52566_52582(extent)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 52955, 54684) || true) && (i < f_1558_52966_52980(_script) - 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 52955, 54684);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53018, 53038);

                        char
                        c = f_1558_53027_53037(_script, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53058, 53174) || true) && (f_1558_53062_53078(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 53058, 53174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53120, 53124);

                            i++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53146, 53155);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 53058, 53174);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53194, 54071) || true) && (c == '\n')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 53194, 54071);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53249, 53471) || true) && (lastNonWhitespaceIsNewline)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 53249, 53471);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53435, 53448);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 53249, 53471);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53495, 53529);

                            lastNonWhitespaceIsNewline = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53551, 53555);

                            i++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53577, 53586);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 53194, 54071);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 53194, 54071);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53628, 54071) || true) && (c == '\r')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 53628, 54071);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53683, 53905) || true) && (lastNonWhitespaceIsNewline)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 53683, 53905);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53869, 53882);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 53683, 53905);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53929, 53963);

                                lastNonWhitespaceIsNewline = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 53985, 54021);

                                i += (DynAbs.Tracing.TraceSender.Conditional_F1(1558, 53990, 54012) || ((f_1558_53990_54004(_script, i + 1) == '\n' && DynAbs.Tracing.TraceSender.Conditional_F2(1558, 54015, 54016)) || DynAbs.Tracing.TraceSender.Conditional_F3(1558, 54019, 54020))) ? 2 : 1;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54043, 54052);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 53628, 54071);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 53194, 54071);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54091, 54126);

                        lastNonWhitespaceIsNewline = false;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54146, 54443) || true) && (c == '#')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 54146, 54443);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54366, 54393);

                            i = f_1558_54370_54392(this, i + 1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54415, 54424);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 54146, 54443);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54463, 54620) || true) && (c == '<' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 54467, 54500) && f_1558_54479_54493(_script, i + 1) == '#'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 54463, 54620);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54542, 54570);

                            i = f_1558_54546_54569(this, i + 2);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54592, 54601);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 54463, 54620);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54640, 54669);

                        return c == continuationChar;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 52955, 54684);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 52955, 54684);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 52955, 54684);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54700, 54755);

                return f_1558_54707_54734(_script, f_1558_54715_54729(_script) - 1) == continuationChar;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 52399, 54766);

                int
                f_1558_52566_52582(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 52566, 52582);
                    return return_v;
                }


                int
                f_1558_52966_52980(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 52966, 52980);
                    return return_v;
                }


                char
                f_1558_53027_53037(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 53027, 53037);
                    return return_v;
                }


                bool
                f_1558_53062_53078(char
                c)
                {
                    var return_v = c.IsWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 53062, 53078);
                    return return_v;
                }


                char
                f_1558_53990_54004(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 53990, 54004);
                    return return_v;
                }


                int
                f_1558_54370_54392(System.Management.Automation.Language.Tokenizer
                this_param, int
                i)
                {
                    var return_v = this_param.SkipLineComment(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 54370, 54392);
                    return return_v;
                }


                char
                f_1558_54479_54493(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 54479, 54493);
                    return return_v;
                }


                int
                f_1558_54546_54569(System.Management.Automation.Language.Tokenizer
                this_param, int
                i)
                {
                    var return_v = this_param.SkipBlockComment(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 54546, 54569);
                    return return_v;
                }


                int
                f_1558_54715_54729(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 54715, 54729);
                    return return_v;
                }


                char
                f_1558_54707_54734(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 54707, 54734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 52399, 54766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 52399, 54766);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int SkipLineComment(int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 54778, 55085);
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54837, 55049) || true) && (i < f_1558_54848_54862(_script))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54864, 54867)
   , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 54837, 55049))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 54837, 55049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54901, 54921);

                        char
                        c = f_1558_54910_54920(_script, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 54941, 55034) || true) && (c == '\r' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 54945, 54967) || c == '\n'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 54941, 55034);
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 55009, 55015);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 54941, 55034);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 213);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55065, 55074);

                return i;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 54778, 55085);

                int
                f_1558_54848_54862(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 54848, 54862);
                    return return_v;
                }


                char
                f_1558_54910_54920(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 54910, 54920);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 54778, 55085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 54778, 55085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int SkipBlockComment(int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 55097, 55451);
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55157, 55415) || true) && (i < f_1558_55168_55182(_script))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55184, 55187)
   , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 55157, 55415))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 55157, 55415);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55221, 55241);

                        char
                        c = f_1558_55230_55240(_script, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55261, 55400) || true) && (c == '#' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 55265, 55301) && (i + 1) < f_1558_55287_55301(_script)) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 55265, 55326) && f_1558_55305_55319(_script, i + 1) == '>'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 55261, 55400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55368, 55381);

                            return i + 2;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 55261, 55400);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 259);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 259);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55431, 55440);

                return i;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 55097, 55451);

                int
                f_1558_55168_55182(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 55168, 55182);
                    return return_v;
                }


                char
                f_1558_55230_55240(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 55230, 55240);
                    return return_v;
                }


                int
                f_1558_55287_55301(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 55287, 55301);
                    return return_v;
                }


                char
                f_1558_55305_55319(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 55305, 55319);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 55097, 55451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 55097, 55451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private char Backtick(char c, out char surrogateCharacter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 55463, 56125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55546, 55581);

                surrogateCharacter = s_invalidChar;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55597, 56114);

                switch (c)
                {

                    case '0':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 55597, 56114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55650, 55662);

                        return '\0';
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 55597, 56114);

                    case 'a':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 55597, 56114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55690, 55702);

                        return '\a';
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 55597, 56114);

                    case 'b':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 55597, 56114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55730, 55742);

                        return '\b';
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 55597, 56114);

                    case 'e':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 55597, 56114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55770, 55786);

                        return '\u001b';
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 55597, 56114);

                    case 'f':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 55597, 56114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55814, 55826);

                        return '\f';
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 55597, 56114);

                    case 'n':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 55597, 56114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55854, 55866);

                        return '\n';
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 55597, 56114);

                    case 'r':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 55597, 56114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55894, 55906);

                        return '\r';
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 55597, 56114);

                    case 't':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 55597, 56114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55934, 55946);

                        return '\t';
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 55597, 56114);

                    case 'u':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 55597, 56114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 55974, 56023);

                        return f_1558_55981_56022(this, out surrogateCharacter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 55597, 56114);

                    case 'v':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 55597, 56114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56051, 56063);

                        return '\v';
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 55597, 56114);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 55597, 56114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56090, 56099);

                        return c;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 55597, 56114);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 55463, 56125);

                char
                f_1558_55981_56022(System.Management.Automation.Language.Tokenizer
                this_param, out char
                surrogateCharacter)
                {
                    var return_v = this_param.ScanUnicodeEscape(out surrogateCharacter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 55981, 56022);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 55463, 56125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 55463, 56125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private char ScanUnicodeEscape(out char surrogateCharacter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 56137, 59964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56221, 56262);

                int
                escSeqStartIndex = _currentIndex - 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56276, 56311);

                surrogateCharacter = s_invalidChar;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56327, 56346);

                char
                c = f_1558_56336_56345(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56360, 56750) || true) && (c != '{')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 56360, 56750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56406, 56418);

                    f_1558_56406_56417(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56438, 56515);

                    IScriptExtent
                    errorExtent = f_1558_56466_56514(this, escSeqStartIndex, _currentIndex)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56533, 56696);

                    f_1558_56533_56695(this, errorExtent, nameof(ParserStrings.InvalidUnicodeEscapeSequence), f_1558_56652_56694());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56714, 56735);

                    return s_invalidChar;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 56360, 56750);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56884, 56912);

                var
                sb = f_1558_56893_56911(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56926, 56932);

                int
                i
                = default(int);
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56951, 56956)
   , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56946, 59021) || true) && (i < s_maxNumberOfUnicodeHexDigits + 1)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 56997, 57000)
   , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 56946, 59021))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 56946, 59021);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 57034, 57048);

                        c = f_1558_57038_57047(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 57118, 58973) || true) && (c == '}')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 57118, 58973);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 57172, 57692) || true) && (i == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 57172, 57692);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 57302, 57314);

                                f_1558_57302_57313(this, sb);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 57340, 57417);

                                IScriptExtent
                                errorExtent = f_1558_57368_57416(this, escSeqStartIndex, _currentIndex)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 57443, 57622);

                                f_1558_57443_57621(this, errorExtent, nameof(ParserStrings.InvalidUnicodeEscapeSequence), f_1558_57578_57620());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 57648, 57669);

                                return s_invalidChar;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 57172, 57692);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 57716, 57722);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 57118, 58973);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 57118, 58973);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 57764, 58973) || true) && (!f_1558_57769_57783(c))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 57764, 58973);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 57825, 57837);

                                f_1558_57825_57836(this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 57861, 57873);

                                f_1558_57861_57872(this, sb);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 57895, 58485) || true) && (i < s_maxNumberOfUnicodeHexDigits)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 57895, 58485);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 57982, 58163);

                                    f_1558_57982_58162(this, _currentIndex, nameof(ParserStrings.InvalidUnicodeEscapeSequence), f_1558_58119_58161());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 57895, 58485);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 57895, 58485);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 58261, 58462);

                                    f_1558_58261_58461(this, _currentIndex, nameof(ParserStrings.MissingUnicodeEscapeSequenceTerminator), f_1558_58408_58460());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 57895, 58485);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 58509, 58530);

                                return s_invalidChar;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 57764, 58973);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 57764, 58973);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 58572, 58973) || true) && (i == s_maxNumberOfUnicodeHexDigits)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 58572, 58973);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 58652, 58664);

                                    f_1558_58652_58663(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 58688, 58700);

                                    f_1558_58688_58699(this, sb);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 58722, 58911);

                                    f_1558_58722_58910(this, _currentIndex, nameof(ParserStrings.TooManyDigitsInUnicodeEscapeSequence), f_1558_58859_58909());
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 58933, 58954);

                                    return s_invalidChar;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 58572, 58973);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 57764, 58973);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 57118, 58973);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 58993, 59006);

                        f_1558_58993_59005(
                                        sb, c);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 2076);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 2076);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 59037, 59077);

                string
                hexStr = f_1558_59053_59076(this, sb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 59093, 59196);

                uint
                unicodeValue = f_1558_59113_59195(hexStr, NumberStyles.AllowHexSpecifier, f_1558_59164_59194())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 59210, 59953) || true) && (unicodeValue <= char.MaxValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 59210, 59953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 59277, 59305);

                    return ((char)unicodeValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 59210, 59953);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 59210, 59953);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 59339, 59953) || true) && (unicodeValue <= 0x10FFFF)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 59339, 59953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 59401, 59464);

                        return f_1558_59408_59463(unicodeValue, out surrogateCharacter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 59339, 59953);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 59339, 59953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 59623, 59708);

                        IScriptExtent
                        errorExtent = f_1558_59651_59707(this, escSeqStartIndex + 3, _currentIndex - 1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 59726, 59899);

                        f_1558_59726_59898(this, errorExtent, nameof(ParserStrings.InvalidUnicodeEscapeSequenceValue), f_1558_59850_59897());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 59917, 59938);

                        return s_invalidChar;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 59339, 59953);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 59210, 59953);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 56137, 59964);

                char
                f_1558_56336_56345(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 56336, 56345);
                    return return_v;
                }


                int
                f_1558_56406_56417(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 56406, 56417);
                    return 0;
                }


                System.Management.Automation.Language.InternalScriptExtent
                f_1558_56466_56514(System.Management.Automation.Language.Tokenizer
                this_param, int
                start, int
                end)
                {
                    var return_v = this_param.NewScriptExtent(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 56466, 56514);
                    return return_v;
                }


                string
                f_1558_56652_56694()
                {
                    var return_v = ParserStrings.InvalidUnicodeEscapeSequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 56652, 56694);
                    return return_v;
                }


                int
                f_1558_56533_56695(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportError(extent, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 56533, 56695);
                    return 0;
                }


                System.Text.StringBuilder
                f_1558_56893_56911(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 56893, 56911);
                    return return_v;
                }


                char
                f_1558_57038_57047(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 57038, 57047);
                    return return_v;
                }


                int
                f_1558_57302_57313(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    this_param.Release(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 57302, 57313);
                    return 0;
                }


                System.Management.Automation.Language.InternalScriptExtent
                f_1558_57368_57416(System.Management.Automation.Language.Tokenizer
                this_param, int
                start, int
                end)
                {
                    var return_v = this_param.NewScriptExtent(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 57368, 57416);
                    return return_v;
                }


                string
                f_1558_57578_57620()
                {
                    var return_v = ParserStrings.InvalidUnicodeEscapeSequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 57578, 57620);
                    return return_v;
                }


                int
                f_1558_57443_57621(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportError(extent, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 57443, 57621);
                    return 0;
                }


                bool
                f_1558_57769_57783(char
                c)
                {
                    var return_v = c.IsHexDigit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 57769, 57783);
                    return return_v;
                }


                int
                f_1558_57825_57836(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 57825, 57836);
                    return 0;
                }


                int
                f_1558_57861_57872(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    this_param.Release(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 57861, 57872);
                    return 0;
                }


                string
                f_1558_58119_58161()
                {
                    var return_v = ParserStrings.InvalidUnicodeEscapeSequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 58119, 58161);
                    return return_v;
                }


                int
                f_1558_57982_58162(System.Management.Automation.Language.Tokenizer
                this_param, int
                errorOffset, string
                errorId, string
                errorMsg, params object[]
                args)
                {
                    this_param.ReportError(errorOffset, errorId, errorMsg, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 57982, 58162);
                    return 0;
                }


                string
                f_1558_58408_58460()
                {
                    var return_v = ParserStrings.MissingUnicodeEscapeSequenceTerminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 58408, 58460);
                    return return_v;
                }


                int
                f_1558_58261_58461(System.Management.Automation.Language.Tokenizer
                this_param, int
                errorOffset, string
                errorId, string
                errorMsg, params object[]
                args)
                {
                    this_param.ReportError(errorOffset, errorId, errorMsg, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 58261, 58461);
                    return 0;
                }


                int
                f_1558_58652_58663(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 58652, 58663);
                    return 0;
                }


                int
                f_1558_58688_58699(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    this_param.Release(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 58688, 58699);
                    return 0;
                }


                string
                f_1558_58859_58909()
                {
                    var return_v = ParserStrings.TooManyDigitsInUnicodeEscapeSequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 58859, 58909);
                    return return_v;
                }


                int
                f_1558_58722_58910(System.Management.Automation.Language.Tokenizer
                this_param, int
                errorOffset, string
                errorId, string
                errorMsg, params object[]
                args)
                {
                    this_param.ReportError(errorOffset, errorId, errorMsg, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 58722, 58910);
                    return 0;
                }


                System.Text.StringBuilder
                f_1558_58993_59005(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 58993, 59005);
                    return return_v;
                }


                string
                f_1558_59053_59076(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 59053, 59076);
                    return return_v;
                }


                System.Globalization.NumberFormatInfo
                f_1558_59164_59194()
                {
                    var return_v = NumberFormatInfo.InvariantInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 59164, 59194);
                    return return_v;
                }


                uint
                f_1558_59113_59195(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.NumberFormatInfo
                provider)
                {
                    var return_v = uint.Parse(s, style, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 59113, 59195);
                    return return_v;
                }


                char
                f_1558_59408_59463(uint
                codepoint, out char
                lowSurrogate)
                {
                    var return_v = GetCharsFromUtf32(codepoint, out lowSurrogate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 59408, 59463);
                    return return_v;
                }


                System.Management.Automation.Language.InternalScriptExtent
                f_1558_59651_59707(System.Management.Automation.Language.Tokenizer
                this_param, int
                start, int
                end)
                {
                    var return_v = this_param.NewScriptExtent(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 59651, 59707);
                    return return_v;
                }


                string
                f_1558_59850_59897()
                {
                    var return_v = ParserStrings.InvalidUnicodeEscapeSequenceValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 59850, 59897);
                    return return_v;
                }


                int
                f_1558_59726_59898(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportError(extent, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 59726, 59898);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 56137, 59964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 56137, 59964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static char GetCharsFromUtf32(uint codepoint, out char lowSurrogate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 59976, 60589);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 60077, 60578) || true) && (codepoint < (uint)0x00010000)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 60077, 60578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 60143, 60172);

                    lowSurrogate = s_invalidChar;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 60190, 60213);

                    return (char)codepoint;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 60077, 60578);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 60077, 60578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 60279, 60403);

                    f_1558_60279_60402((codepoint > 0x0000FFFF) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 60298, 60351) && (codepoint <= 0x0010FFFF)), "Codepoint is out of range for a surrogate pair");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 60421, 60487);

                    lowSurrogate = (char)((codepoint - 0x00010000) % 0x0400 + 0xDC00);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 60505, 60563);

                    return (char)((codepoint - 0x00010000) / 0x0400 + 0xD800);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 60077, 60578);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 59976, 60589);

                int
                f_1558_60279_60402(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 60279, 60402);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 59976, 60589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 59976, 60589);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ScanToEndOfCommentLine(out bool sawBeginSig, out bool matchedRequires)
        {
            // When we get here, we are scanning a line comment.  To avoid rescanning,
            // we look for a script signature while we scan to the end of the line.
            //
            // We want to find both real signatures and fake signatures, with the goal of disallowing any
            // code after anything that looks like a signature because people often stop reading a script
            // once they see a signature - making it relatively easy to "hide" trojan like code in a script
            // after a fake signature.
            //
            // To "match" a signature, we compare its similarity (using Levenshtein Distance) to find
            // comments that look confusingly similar to the actual signature block (mapping to lowercase,
            // and ignoring spaces).
            //
            // At the same time, we also want to match #requires.  We do this with a simple state machine,
            // incrementing the state as we continue to match, or set requiresMatchState to -1 if we failed to match.

            var commentLine = GetStringBuilder();

            int requiresMatchState = 0;
            matchedRequires = false;
            while (true)
            {
                char c = GetChar();

                if (!c.IsWhitespace())
                {
                    commentLine.Append(c);
                }

                switch (c)
                {
                    case 'e':
                    case 'E':
                        if (requiresMatchState == 1 || requiresMatchState == 6)
                            requiresMatchState += 1;
                        else
                            requiresMatchState = -1;
                        break;
                    case 'i':
                    case 'I':
                        if (requiresMatchState == 4)
                            requiresMatchState += 1;
                        else
                            requiresMatchState = -1;
                        break;
                    case 'q':
                    case 'Q':
                        if (requiresMatchState == 2)
                            requiresMatchState += 1;
                        else
                            requiresMatchState = -1;
                        break;
                    case 'r':
                    case 'R':
                        if (requiresMatchState == 0 || requiresMatchState == 5)
                            requiresMatchState += 1;
                        else
                            requiresMatchState = -1;
                        break;
                    case 's':
                    case 'S':
                        if (requiresMatchState == 7)
                            matchedRequires = true;
                        else
                            requiresMatchState = -1;
                        break;
                    case 'u':
                    case 'U':
                        if (requiresMatchState == 3)
                            requiresMatchState += 1;
                        else
                            requiresMatchState = -1;
                        break;
                    case '\0':
                        if (AtEof())
                        {
                            goto case '\n';
                        }

                        goto default;
                    case '\r':
                    case '\n':
                        UngetChar();

                        // Detect a line comment that disguises itself to look like the beginning of a signature block.
                        // This could be used to hide code at the bottom of a script, since people might assume there is nothing else after the signature.
                        //
                        // The token similarity threshold was chosen by instrumenting the tokenizer and
                        // analyzing every comment from PoshCode, Technet Script Center, and Windows.
                        //
                        // The closest comments above "10" had a score of 11, which are marginal and
                        // appropriately close to being tricky.
                        //
                        // # END BEGIN SCRIPT BLOCK
                        // # SET TEXT SIGNATURE
                        //
                        // Below 11 were only actual signature blocks:
                        //
                        // # SIG # END SIGNATURE BLOCK
                        // # SIG # BEGIN SIGNATURE BLOCK
                        //
                        // There were only 279 (out of 269,387) comments with a similarity of 11,12,13,14, or 15.
                        // At a similarity of 16-77, there were thousands of comments per similarity bucket.

                        const string beginSignatureTextNoSpace = "sig#beginsignatureblock\n";
                        const int beginTokenSimilarityThreshold = 10;

                        const int beginTokenSimilarityUpperBound = 34; // beginSignatureTextNoSpace.Length + beginTokenSimilarityThreshold
                        const int beginTokenSimilarityLowerBound = 14; // beginSignatureTextNoSpace.Length - beginTokenSimilarityThreshold

                        // Quick exit - the comment line is more than 'threshold' longer, or is less than 'threshold' shorter. Therefore,
                        // its similarity will be over the threshold.
                        if (commentLine.Length > beginTokenSimilarityUpperBound || commentLine.Length < beginTokenSimilarityLowerBound)
                        {
                            sawBeginSig = false;
                        }
                        else
                        {
                            // Perf note - the GetStringSimilarity function is able to evaluate approximately 50kb of pure comments
                            // (1000 lines, each of length between 10 and 80 characters) in about 40ms, compared to 6ms it took to
                            // doing the error-prone hashing approach we had implemented before.
                            //
                            // The average script is 14% comments and parses in about 5.05 ms with this algorithm,
                            // about 4.45 ms with the more simplistic algorithm.

                            string commentLineComparison = commentLine.ToString().ToLowerInvariant();
                            if (_beginTokenSimilarity2dArray == null)
                            {
                                // Create the 2 dimensional array for edit distance calculation if it hasn't been created yet.
                                _beginTokenSimilarity2dArray = new int[beginTokenSimilarityUpperBound + 1, beginSignatureTextNoSpace.Length + 1];
                            }
                            else
                            {
                                // Zero out the 2 dimensional array before using it.
                                Array.Clear(_beginTokenSimilarity2dArray, 0, _beginTokenSimilarity2dArray.Length);
                            }

                            int sawBeginTokenSimilarity = GetStringSimilarity(commentLineComparison, beginSignatureTextNoSpace, _beginTokenSimilarity2dArray);
                            sawBeginSig = sawBeginTokenSimilarity < beginTokenSimilarityThreshold;
                        }

                        Release(commentLine);
                        return;
                    default:
                        requiresMatchState = -1;
                        break;
                }
            }
        }

        private int[,] _beginTokenSimilarity2dArray;

        private readonly Queue<StringBuilder> _stringBuilders;

        private StringBuilder GetStringBuilder()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 68761, 68921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 68826, 68910);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1558, 68833, 68859) || ((f_1558_68833_68854(_stringBuilders) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1558, 68862, 68881)) || DynAbs.Tracing.TraceSender.Conditional_F3(1558, 68884, 68909))) ? f_1558_68862_68881() : f_1558_68884_68909(_stringBuilders);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 68761, 68921);

                int
                f_1558_68833_68854(System.Collections.Generic.Queue<System.Text.StringBuilder>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 68833, 68854);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_68862_68881()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 68862, 68881);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_68884_68909(System.Collections.Generic.Queue<System.Text.StringBuilder>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 68884, 68909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 68761, 68921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 68761, 68921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Release(StringBuilder sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 68933, 69296);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 69127, 69285) || true) && (f_1558_69131_69152(_stringBuilders) < 10 && (DynAbs.Tracing.TraceSender.Expression_True(1558, 69131, 69179) && f_1558_69161_69172(sb) < 1024))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 69127, 69285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 69213, 69224);

                    f_1558_69213_69223(sb);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 69242, 69270);

                    f_1558_69242_69269(_stringBuilders, sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 69127, 69285);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 68933, 69296);

                int
                f_1558_69131_69152(System.Collections.Generic.Queue<System.Text.StringBuilder>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 69131, 69152);
                    return return_v;
                }


                int
                f_1558_69161_69172(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Capacity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 69161, 69172);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_69213_69223(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 69213, 69223);
                    return return_v;
                }


                int
                f_1558_69242_69269(System.Collections.Generic.Queue<System.Text.StringBuilder>
                this_param, System.Text.StringBuilder
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 69242, 69269);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 68933, 69296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 68933, 69296);
            }
        }

        private string GetStringAndRelease(StringBuilder sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 69308, 69477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 69385, 69412);

                var
                result = f_1558_69398_69411(sb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 69426, 69438);

                f_1558_69426_69437(this, sb);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 69452, 69466);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 69308, 69477);

                string
                f_1558_69398_69411(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 69398, 69411);
                    return return_v;
                }


                int
                f_1558_69426_69437(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    this_param.Release(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 69426, 69437);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 69308, 69477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 69308, 69477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ScanLineComment()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 69552, 70154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 69607, 69624);

                bool
                sawBeginSig
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 69638, 69659);

                bool
                matchedRequires
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 69673, 69734);

                f_1558_69673_69733(this, out sawBeginSig, out matchedRequires);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 69748, 69778);

                var
                token = f_1558_69760_69777(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 69792, 70143) || true) && (sawBeginSig)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 69792, 70143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 69841, 69881);

                    _beginSignatureExtent = f_1558_69865_69880(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 69792, 70143);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 69792, 70143);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 69915, 70143) || true) && (matchedRequires && (DynAbs.Tracing.TraceSender.Expression_True(1558, 69919, 69966) && _nestedTokensAdjustment == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 69915, 70143);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70000, 70084) || true) && (f_1558_70004_70018() == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 70000, 70084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70049, 70084);

                            RequiresTokens = f_1558_70066_70083();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 70000, 70084);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70102, 70128);

                        f_1558_70102_70127(f_1558_70102_70116(), token);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 69915, 70143);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 69792, 70143);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 69552, 70154);

                int
                f_1558_69673_69733(System.Management.Automation.Language.Tokenizer
                this_param, out bool
                sawBeginSig, out bool
                matchedRequires)
                {
                    this_param.ScanToEndOfCommentLine(out sawBeginSig, out matchedRequires);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 69673, 69733);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_69760_69777(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.NewCommentToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 69760, 69777);
                    return return_v;
                }


                System.Management.Automation.Language.InternalScriptExtent
                f_1558_69865_69880(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 69865, 69880);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_70004_70018()
                {
                    var return_v = RequiresTokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 70004, 70018);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_70066_70083()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.Token>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 70066, 70083);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_70102_70116()
                {
                    var return_v = RequiresTokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 70102, 70116);
                    return return_v;
                }


                int
                f_1558_70102_70127(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param, System.Management.Automation.Language.Token
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 70102, 70127);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 69552, 70154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 69552, 70154);
            }
        }

        private void ScanBlockComment()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 70166, 71019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70222, 70257);

                int
                errorIndex = _currentIndex - 2
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70271, 70974) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 70271, 70974);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70316, 70335);

                        char
                        c = f_1558_70325_70334(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70355, 70488) || true) && (c == '#' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 70359, 70388) && f_1558_70371_70381(this) == '>'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 70355, 70488);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70430, 70441);

                            f_1558_70430_70440(this);
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 70463, 70469);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 70355, 70488);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70508, 70959) || true) && (c == '\r')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 70508, 70959);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70563, 70580);

                            f_1558_70563_70579(this, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 70508, 70959);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 70508, 70959);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70622, 70959) || true) && (c == '\0' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 70626, 70646) && f_1558_70639_70646(this)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 70622, 70959);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70688, 70700);

                                f_1558_70688_70699(this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70722, 70912);

                                f_1558_70722_70911(this, errorIndex, nameof(ParserStrings.MissingTerminatorMultiLineComment), f_1558_70863_70910());
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 70934, 70940);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 70622, 70959);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 70508, 70959);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 70271, 70974);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 70271, 70974);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 70271, 70974);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 70990, 71008);

                f_1558_70990_71007(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 70166, 71019);

                char
                f_1558_70325_70334(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 70325, 70334);
                    return return_v;
                }


                char
                f_1558_70371_70381(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 70371, 70381);
                    return return_v;
                }


                int
                f_1558_70430_70440(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 70430, 70440);
                    return 0;
                }


                int
                f_1558_70563_70579(System.Management.Automation.Language.Tokenizer
                this_param, char
                c)
                {
                    this_param.NormalizeCRLF(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 70563, 70579);
                    return 0;
                }


                bool
                f_1558_70639_70646(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.AtEof();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 70639, 70646);
                    return return_v;
                }


                int
                f_1558_70688_70699(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 70688, 70699);
                    return 0;
                }


                string
                f_1558_70863_70910()
                {
                    var return_v = ParserStrings.MissingTerminatorMultiLineComment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 70863, 70910);
                    return return_v;
                }


                int
                f_1558_70722_70911(System.Management.Automation.Language.Tokenizer
                this_param, int
                errorOffset, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportIncompleteInput(errorOffset, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 70722, 70911);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_70990_71007(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.NewCommentToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 70990, 71007);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 70166, 71019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 70166, 71019);
            }
        }

        private static int GetStringSimilarity(string first, string second, int[,] distanceMap = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 71159, 73526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 71278, 71404);

                f_1558_71278_71403(!f_1558_71298_71325(first) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 71297, 71358) && !f_1558_71330_71358(second)), "Caller never calls us with empty strings");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 71612, 71673);

                distanceMap ??= new int[f_1558_71636_71648(first) + 1, f_1558_71654_71667(second) + 1];
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 71903, 71910);

                    // Initialize the first row and column of the matrix - the number
                    // of edits required when one of the strings is empty is just
                    // the length of the non-empty string
                    for (int
        row = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 71894, 72013) || true) && (row <= f_1558_71919_71931(first))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 71933, 71938)
        , row++, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 71894, 72013))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 71894, 72013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 71972, 71998);

                        distanceMap[row, 0] = row;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 120);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 72038, 72048);

                    for (int
        column = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 72029, 72164) || true) && (column <= f_1558_72060_72073(second))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 72075, 72083)
        , column++, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 72029, 72164))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 72029, 72164);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 72117, 72149);

                        distanceMap[0, column] = column;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 136);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 72264, 72271);

                    // Visit all prefixes and determine the minimum edit distance
                    for (int
        row = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 72255, 73451) || true) && (row <= f_1558_72280_72292(first))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 72294, 72299)
        , row++, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 72255, 73451))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 72255, 73451);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 72342, 72352);
                            for (int
            column = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 72333, 73436) || true) && (column <= f_1558_72364_72377(second))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 72379, 72387)
            , column++, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 72333, 73436))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 72333, 73436);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 72639, 73417) || true) && (f_1558_72643_72657(first, row - 1) == f_1558_72661_72679(second, column - 1))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 72639, 73417);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 72729, 72789);

                                    distanceMap[row, column] = distanceMap[row - 1, column - 1];
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 72639, 73417);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 72639, 73417);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 73112, 73394);

                                    distanceMap[row, column] = f_1558_73139_73393(f_1558_73178_73321(distanceMap[row - 1, column] + 1, distanceMap[row, column - 1] + 1), distanceMap[row - 1, column - 1] + 1);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 72639, 73417);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 1104);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 1104);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 1197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 1197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 73467, 73515);

                return distanceMap[f_1558_73486_73498(first), f_1558_73500_73513(second)];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 71159, 73526);

                bool
                f_1558_71298_71325(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 71298, 71325);
                    return return_v;
                }


                bool
                f_1558_71330_71358(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 71330, 71358);
                    return return_v;
                }


                int
                f_1558_71278_71403(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 71278, 71403);
                    return 0;
                }


                int
                f_1558_71636_71648(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 71636, 71648);
                    return return_v;
                }


                int
                f_1558_71654_71667(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 71654, 71667);
                    return return_v;
                }


                int
                f_1558_71919_71931(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 71919, 71931);
                    return return_v;
                }


                int
                f_1558_72060_72073(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 72060, 72073);
                    return return_v;
                }


                int
                f_1558_72280_72292(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 72280, 72292);
                    return return_v;
                }


                int
                f_1558_72364_72377(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 72364, 72377);
                    return return_v;
                }


                char
                f_1558_72643_72657(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 72643, 72657);
                    return return_v;
                }


                char
                f_1558_72661_72679(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 72661, 72679);
                    return return_v;
                }


                int
                f_1558_73178_73321(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 73178, 73321);
                    return return_v;
                }


                int
                f_1558_73139_73393(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 73139, 73393);
                    return return_v;
                }


                int
                f_1558_73486_73498(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 73486, 73498);
                    return return_v;
                }


                int
                f_1558_73500_73513(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 73500, 73513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 71159, 73526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 71159, 73526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ScriptRequirements GetScriptRequirements()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 73566, 78890);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 73642, 73699) || true) && (f_1558_73646_73660() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 73642, 73699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 73687, 73699);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 73642, 73699);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 73812, 73858);

                var
                requiresTokens = f_1558_73833_73857(f_1558_73833_73847())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 73872, 73894);

                RequiresTokens = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 73910, 73940);

                string
                requiredShellId = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 73954, 73985);

                Version
                requiredVersion = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 73999, 74036);

                List<string>
                requiredEditions = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74050, 74099);

                List<ModuleSpecification>
                requiredModules = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74113, 74164);

                List<PSSnapInSpecification>
                requiredSnapins = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74178, 74217);

                List<string>
                requiredAssemblies = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74231, 74262);

                bool
                requiresElevation = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74278, 77553);
                    foreach (var token in f_1558_74300_74314_I(requiresTokens))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 74278, 77553);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74348, 74465);

                        var
                        requiresExtent = f_1558_74369_74464(_positionHelper, f_1558_74411_74435(f_1558_74411_74423(token)) + 1, f_1558_74441_74463(f_1558_74441_74453(token)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74483, 74598);

                        var
                        state = f_1558_74495_74597(this, f_1558_74511_74596(requiresExtent, TokenFlags.None, f_1558_74570_74589(requiresExtent), null))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74616, 74693);

                        var
                        commandAst = f_1558_74633_74678(_parser, forDynamicKeyword: false) as CommandAst
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74711, 74738);

                        _parser._ungotToken = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74756, 74780);

                        f_1558_74756_74779(this, state);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74800, 74825);

                        string
                        snapinName = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74843, 74872);

                        Version
                        snapinVersion = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74892, 77538) || true) && (commandAst != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 74892, 77538);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 74956, 75002);

                            var
                            commandName = f_1558_74974_75001(commandAst)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 75024, 75371) || true) && (!f_1558_75029_75103(commandName, "requires", StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 75024, 75371);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 75153, 75348);

                                f_1558_75153_75347(this, f_1558_75165_75182(commandAst), nameof(DiscoveryExceptions.ScriptRequiresInvalidFormat), f_1558_75299_75346());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 75024, 75371);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 75395, 75423);

                            var
                            snapinSpecified = false
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 75454, 75459);
                                for (int
            i = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 75445, 76163) || true) && (i < f_1558_75465_75497(f_1558_75465_75491(commandAst)))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 75499, 75502)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 75445, 76163))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 75445, 76163);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 75552, 75621);

                                    var
                                    parameter = f_1558_75568_75597(f_1558_75568_75594(commandAst), i) as CommandParameterAst
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 75649, 76140) || true) && (parameter != null && (DynAbs.Tracing.TraceSender.Expression_True(1558, 75653, 75788) && f_1558_75703_75788(PSSnapinToken, f_1558_75728_75751(parameter), StringComparison.OrdinalIgnoreCase)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 75649, 76140);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 75846, 75869);

                                        snapinSpecified = true;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 75899, 76075) || true) && (requiredSnapins == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 75899, 76075);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 75992, 76044);

                                            requiredSnapins = f_1558_76010_76043();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 75899, 76075);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 76107, 76113);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 75649, 76140);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 719);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 719);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 76196, 76201);

                                for (int
            i = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 76187, 77174) || true) && (i < f_1558_76207_76239(f_1558_76207_76233(commandAst)))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 76241, 76244)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 76187, 77174))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 76187, 77174);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 76294, 76363);

                                    var
                                    parameter = f_1558_76310_76339(f_1558_76310_76336(commandAst), i) as CommandParameterAst
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 76389, 77151) || true) && (parameter != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 76389, 77151);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 76468, 76788);

                                        f_1558_76468_76787(this, parameter, f_1558_76503_76529(commandAst), snapinSpecified, ref i, ref snapinName, ref snapinVersion, ref requiredShellId, ref requiredVersion, ref requiredEditions, ref requiredModules, ref requiredAssemblies, ref requiresElevation);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 76389, 77151);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 76389, 77151);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 76902, 77124);

                                        f_1558_76902_77123(this, f_1558_76914_76950(f_1558_76914_76943(f_1558_76914_76940(commandAst), i)), nameof(DiscoveryExceptions.ScriptRequiresInvalidFormat), f_1558_77075_77122());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 76389, 77151);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 988);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 988);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 77198, 77519) || true) && (snapinName != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 77198, 77519);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 77270, 77383);

                                f_1558_77270_77382(f_1558_77289_77331(snapinName), "we shouldn't set snapinName if it wasn't valid");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 77409, 77496);

                                f_1558_77409_77495(requiredSnapins, new PSSnapInSpecification(snapinName) { Version = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => snapinVersion, 1558, 77429, 77494) });
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 77198, 77519);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 74892, 77538);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 74278, 77553);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 3276);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 3276);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 77569, 78879);

                return new ScriptRequirements
                {
                    RequiredApplicationId = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => requiredShellId, 1558, 77576, 78878),
                    RequiredPSVersion = requiredVersion,
                    RequiredPSEditions = (DynAbs.Tracing.TraceSender.Conditional_F1(1558, 77764, 77788) || ((requiredEditions != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(1558, 77844, 77892)) || DynAbs.Tracing.TraceSender.Conditional_F3(1558, 77948, 77989))) ? f_1558_77844_77892(requiredEditions) : ScriptRequirements.EmptyEditionCollection,
                    RequiresPSSnapIns = (DynAbs.Tracing.TraceSender.Conditional_F1(1558, 78028, 78051) || ((requiredSnapins != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(1558, 78106, 78168)) || DynAbs.Tracing.TraceSender.Conditional_F3(1558, 78223, 78263))) ? f_1558_78106_78168(requiredSnapins) : ScriptRequirements.EmptySnapinCollection,
                    RequiredAssemblies = (DynAbs.Tracing.TraceSender.Conditional_F1(1558, 78303, 78329) || ((requiredAssemblies != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(1558, 78385, 78435)) || DynAbs.Tracing.TraceSender.Conditional_F3(1558, 78491, 78533))) ? f_1558_78385_78435(requiredAssemblies) : ScriptRequirements.EmptyAssemblyCollection,
                    RequiredModules = (DynAbs.Tracing.TraceSender.Conditional_F1(1558, 78570, 78593) || ((requiredModules != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(1558, 78649, 78709)) || DynAbs.Tracing.TraceSender.Conditional_F3(1558, 78765, 78805))) ? f_1558_78649_78709(requiredModules) : ScriptRequirements.EmptyModuleCollection,
                    IsElevationRequired = requiresElevation
                };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 73566, 78890);

                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_73646_73660()
                {
                    var return_v = RequiresTokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 73646, 73660);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_73833_73847()
                {
                    var return_v = RequiresTokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 73833, 73847);
                    return return_v;
                }


                System.Management.Automation.Language.Token[]
                f_1558_73833_73857(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 73833, 73857);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_74411_74423(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 74411, 74423);
                    return return_v;
                }


                int
                f_1558_74411_74435(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 74411, 74435);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_74441_74453(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 74441, 74453);
                    return return_v;
                }


                int
                f_1558_74441_74463(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 74441, 74463);
                    return return_v;
                }


                System.Management.Automation.Language.InternalScriptExtent
                f_1558_74369_74464(System.Management.Automation.Language.PositionHelper
                _positionHelper, int
                startOffset, int
                endOffset)
                {
                    var return_v = new System.Management.Automation.Language.InternalScriptExtent(_positionHelper, startOffset, endOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 74369, 74464);
                    return return_v;
                }


                string
                f_1558_74570_74589(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 74570, 74589);
                    return return_v;
                }


                System.Management.Automation.Language.UnscannedSubExprToken
                f_1558_74511_74596(System.Management.Automation.Language.InternalScriptExtent
                scriptExtent, System.Management.Automation.Language.TokenFlags
                tokenFlags, string
                value, System.Collections.BitArray
                skippedCharOffsets)
                {
                    var return_v = new System.Management.Automation.Language.UnscannedSubExprToken(scriptExtent, tokenFlags, value, skippedCharOffsets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 74511, 74596);
                    return return_v;
                }


                System.Management.Automation.Language.TokenizerState
                f_1558_74495_74597(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.UnscannedSubExprToken
                nestedText)
                {
                    var return_v = this_param.StartNestedScan(nestedText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 74495, 74597);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1558_74633_74678(System.Management.Automation.Language.Parser
                this_param, bool
                forDynamicKeyword)
                {
                    var return_v = this_param.CommandRule(forDynamicKeyword: forDynamicKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 74633, 74678);
                    return return_v;
                }


                int
                f_1558_74756_74779(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenizerState
                ts)
                {
                    this_param.FinishNestedScan(ts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 74756, 74779);
                    return 0;
                }


                string
                f_1558_74974_75001(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.GetCommandName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 74974, 75001);
                    return return_v;
                }


                bool
                f_1558_75029_75103(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 75029, 75103);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_75165_75182(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 75165, 75182);
                    return return_v;
                }


                string
                f_1558_75299_75346()
                {
                    var return_v = DiscoveryExceptions.ScriptRequiresInvalidFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 75299, 75346);
                    return return_v;
                }


                int
                f_1558_75153_75347(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportError(extent, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 75153, 75347);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1558_75465_75491(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 75465, 75491);
                    return return_v;
                }


                int
                f_1558_75465_75497(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 75465, 75497);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1558_75568_75594(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 75568, 75594);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1558_75568_75597(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 75568, 75597);
                    return return_v;
                }


                string
                f_1558_75728_75751(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 75728, 75751);
                    return return_v;
                }


                bool
                f_1558_75703_75788(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 75703, 75788);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSSnapInSpecification>
                f_1558_76010_76043()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSSnapInSpecification>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 76010, 76043);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1558_76207_76233(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 76207, 76233);
                    return return_v;
                }


                int
                f_1558_76207_76239(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 76207, 76239);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1558_76310_76336(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 76310, 76336);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1558_76310_76339(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 76310, 76339);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1558_76503_76529(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 76503, 76529);
                    return return_v;
                }


                int
                f_1558_76468_76787(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.CommandParameterAst
                parameter, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                commandElements, bool
                snapinSpecified, ref int
                index, ref string
                snapinName, ref System.Version
                snapinVersion, ref string
                requiredShellId, ref System.Version
                requiredVersion, ref System.Collections.Generic.List<string>
                requiredEditions, ref System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                requiredModules, ref System.Collections.Generic.List<string>
                requiredAssemblies, ref bool
                requiresElevation)
                {
                    this_param.HandleRequiresParameter(parameter, commandElements, snapinSpecified, ref index, ref snapinName, ref snapinVersion, ref requiredShellId, ref requiredVersion, ref requiredEditions, ref requiredModules, ref requiredAssemblies, ref requiresElevation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 76468, 76787);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1558_76914_76940(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 76914, 76940);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1558_76914_76943(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 76914, 76943);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_76914_76950(System.Management.Automation.Language.CommandElementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 76914, 76950);
                    return return_v;
                }


                string
                f_1558_77075_77122()
                {
                    var return_v = DiscoveryExceptions.ScriptRequiresInvalidFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 77075, 77122);
                    return return_v;
                }


                int
                f_1558_76902_77123(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportError(extent, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 76902, 77123);
                    return 0;
                }


                bool
                f_1558_77289_77331(string
                psSnapinId)
                {
                    var return_v = PSSnapInInfo.IsPSSnapinIdValid(psSnapinId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 77289, 77331);
                    return return_v;
                }


                int
                f_1558_77270_77382(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 77270, 77382);
                    return 0;
                }


                int
                f_1558_77409_77495(System.Collections.Generic.List<System.Management.Automation.PSSnapInSpecification>
                this_param, System.Management.Automation.PSSnapInSpecification
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 77409, 77495);
                    return 0;
                }


                System.Management.Automation.Language.Token[]
                f_1558_74300_74314_I(System.Management.Automation.Language.Token[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 74300, 74314);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<string>
                f_1558_77844_77892(System.Collections.Generic.List<string>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>((System.Collections.Generic.IList<string>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 77844, 77892);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSSnapInSpecification>
                f_1558_78106_78168(System.Collections.Generic.List<System.Management.Automation.PSSnapInSpecification>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSSnapInSpecification>((System.Collections.Generic.IList<System.Management.Automation.PSSnapInSpecification>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 78106, 78168);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<string>
                f_1558_78385_78435(System.Collections.Generic.List<string>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>((System.Collections.Generic.IList<string>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 78385, 78435);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1558_78649_78709(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.ModuleSpecification>((System.Collections.Generic.IList<Microsoft.PowerShell.Commands.ModuleSpecification>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 78649, 78709);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 73566, 78890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 73566, 78890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const string
        shellIDToken = "shellid"
        ;

        private const string
        PSSnapinToken = "pssnapin"
        ;

        private const string
        versionToken = "version"
        ;

        private const string
        editionToken = "psedition"
        ;

        private const string
        assemblyToken = "assembly"
        ;

        private const string
        modulesToken = "modules"
        ;

        private const string
        elevationToken = "runasadministrator"
        ;

        private void HandleRequiresParameter(CommandParameterAst parameter,
                                                     ReadOnlyCollection<CommandElementAst> commandElements,
                                                     bool snapinSpecified,
                                                     ref int index,
                                                     ref string snapinName,
                                                     ref Version snapinVersion,
                                                     ref string requiredShellId,
                                                     ref Version requiredVersion,
                                                     ref List<string> requiredEditions,
                                                     ref List<ModuleSpecification> requiredModules,
                                                     ref List<string> requiredAssemblies,
                                                     ref bool requiresElevation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 79315, 88995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 80259, 80369);

                Ast
                argumentAst = f_1558_80277_80295(parameter) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.ExpressionAst>(1558, 80277, 80368) ?? ((DynAbs.Tracing.TraceSender.Conditional_F1(1558, 80300, 80333) || ((index + 1 < f_1558_80312_80333(commandElements) && DynAbs.Tracing.TraceSender.Conditional_F2(1558, 80336, 80360)) || DynAbs.Tracing.TraceSender.Conditional_F3(1558, 80363, 80367))) ? f_1558_80336_80360(commandElements, ++index) : null))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 80385, 80902) || true) && (f_1558_80389_80475(elevationToken, f_1558_80415_80438(parameter), StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 80385, 80902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 80509, 80534);

                    requiresElevation = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 80552, 80860) || true) && (argumentAst != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 80552, 80860);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 80617, 80841);

                        f_1558_80617_80840(this, f_1558_80629_80645(parameter), nameof(ParserStrings.ParameterCannotHaveArgument), f_1558_80748_80789(), f_1558_80816_80839(parameter));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 80552, 80860);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 80880, 80887);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 80385, 80902);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 80918, 81223) || true) && (argumentAst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 80918, 81223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 80975, 81183);

                    f_1558_80975_81182(this, f_1558_80987_81003(parameter), nameof(ParserStrings.ParameterRequiresArgument), f_1558_81096_81135(), f_1558_81158_81181(parameter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 81201, 81208);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 80918, 81223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 81239, 81260);

                object
                argumentValue
                = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 81274, 81611) || true) && (!f_1558_81279_81363(argumentAst, out argumentValue, forRequires: true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 81274, 81611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 81397, 81571);

                    f_1558_81397_81570(this, f_1558_81409_81427(argumentAst), nameof(ParserStrings.RequiresArgumentMustBeConstant), f_1558_81525_81569());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 81589, 81596);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 81274, 81611);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 81627, 88984) || true) && (f_1558_81631_81715(shellIDToken, f_1558_81655_81678(parameter), StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 81627, 88984);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 81749, 82116) || true) && (requiredShellId != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 81749, 82116);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 81818, 82068);

                        f_1558_81818_82067(this, f_1558_81830_81846(parameter), nameof(ParameterBinderStrings.ParameterAlreadyBound), f_1558_81952_81996(), null, shellIDToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 82090, 82097);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 81749, 82116);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 82136, 82475) || true) && (!(argumentValue is string))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 82136, 82475);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 82208, 82427);

                        f_1558_82208_82426(this, f_1558_82220_82238(argumentAst), nameof(ParserStrings.RequiresInvalidStringArgument), f_1558_82343_82386(), shellIDToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 82449, 82456);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 82136, 82475);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 82495, 82535);

                    requiredShellId = (string)argumentValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 81627, 88984);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 81627, 88984);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 82569, 88984) || true) && (f_1558_82573_82658(PSSnapinToken, f_1558_82598_82621(parameter), StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 82569, 88984);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 82692, 83032) || true) && (!(argumentValue is string))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 82692, 83032);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 82764, 82984);

                            f_1558_82764_82983(this, f_1558_82776_82794(argumentAst), nameof(ParserStrings.RequiresInvalidStringArgument), f_1558_82899_82942(), PSSnapinToken);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 83006, 83013);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 82692, 83032);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 83052, 83415) || true) && (snapinName != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 83052, 83415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 83116, 83367);

                            f_1558_83116_83366(this, f_1558_83128_83144(parameter), nameof(ParameterBinderStrings.ParameterAlreadyBound), f_1558_83250_83294(), null, PSSnapinToken);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 83389, 83396);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 83052, 83415);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 83435, 83765) || true) && (!f_1558_83440_83493(argumentValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 83435, 83765);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 83535, 83717);

                            f_1558_83535_83716(this, f_1558_83547_83565(argumentAst), nameof(MshSnapInCmdletResources.InvalidPSSnapInName), f_1558_83671_83715());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 83739, 83746);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 83435, 83765);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 83785, 83820);

                        snapinName = (string)argumentValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 82569, 88984);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 82569, 88984);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 83854, 88984) || true) && (f_1558_83858_83942(editionToken, f_1558_83882_83905(parameter), StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 83854, 88984);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 83976, 84344) || true) && (requiredEditions != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 83976, 84344);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 84046, 84296);

                                f_1558_84046_84295(this, f_1558_84058_84074(parameter), nameof(ParameterBinderStrings.ParameterAlreadyBound), f_1558_84180_84224(), null, editionToken);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 84318, 84325);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 83976, 84344);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 84364, 84880) || true) && (argumentValue is string || (DynAbs.Tracing.TraceSender.Expression_False(1558, 84368, 84426) || !(argumentValue is IEnumerable)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 84364, 84880);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 84468, 84569);

                                requiredEditions = f_1558_84487_84568(this, argumentAst, argumentValue, ref requiredEditions);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 84364, 84880);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 84364, 84880);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 84651, 84861);
                                    foreach (var arg in f_1558_84671_84697_I((IEnumerable)argumentValue))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 84651, 84861);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 84747, 84838);

                                        requiredEditions = f_1558_84766_84837(this, argumentAst, arg, ref requiredEditions);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 84651, 84861);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 211);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 211);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 84364, 84880);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 83854, 88984);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 83854, 88984);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 84914, 88984) || true) && (f_1558_84918_85002(versionToken, f_1558_84942_84965(parameter), StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 84914, 88984);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 85036, 85106);

                                var
                                argumentText = argumentValue as string ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1558, 85055, 85105) ?? f_1558_85082_85105(f_1558_85082_85100(argumentAst)))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 85124, 85174);

                                var
                                version = f_1558_85138_85173(argumentText)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 85192, 85467) || true) && (version == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 85192, 85467);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 85253, 85419);

                                    f_1558_85253_85418(this, f_1558_85265_85283(argumentAst), nameof(ParserStrings.RequiresVersionInvalid), f_1558_85381_85417());
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 85441, 85448);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 85192, 85467);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 85487, 86579) || true) && (snapinSpecified)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 85487, 86579);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 85548, 85945) || true) && (snapinVersion != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 85548, 85945);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 85623, 85889);

                                        f_1558_85623_85888(this, f_1558_85635_85651(parameter), nameof(ParameterBinderStrings.ParameterAlreadyBound), f_1558_85765_85809(), null, versionToken);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 85915, 85922);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 85548, 85945);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 85969, 85993);

                                    snapinVersion = version;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 85487, 86579);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 85487, 86579);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 86075, 86510) || true) && (requiredVersion != null && (DynAbs.Tracing.TraceSender.Expression_True(1558, 86079, 86138) && !f_1558_86107_86138(requiredVersion, version)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 86075, 86510);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 86188, 86454);

                                        f_1558_86188_86453(this, f_1558_86200_86216(parameter), nameof(ParameterBinderStrings.ParameterAlreadyBound), f_1558_86330_86374(), null, versionToken);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 86480, 86487);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 86075, 86510);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 86534, 86560);

                                    requiredVersion = version;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 85487, 86579);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 84914, 88984);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 84914, 88984);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 86613, 88984) || true) && (f_1558_86617_86702(assemblyToken, f_1558_86642_86665(parameter), StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 86613, 88984);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 86736, 87250) || true) && (argumentValue is string || (DynAbs.Tracing.TraceSender.Expression_False(1558, 86740, 86798) || !(argumentValue is IEnumerable)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 86736, 87250);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 86840, 86940);

                                        requiredAssemblies = f_1558_86861_86939(this, argumentAst, argumentValue, requiredAssemblies);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 86736, 87250);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 86736, 87250);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 87022, 87231);
                                            foreach (var arg in f_1558_87042_87068_I((IEnumerable)argumentValue))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 87022, 87231);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 87118, 87208);

                                                requiredAssemblies = f_1558_87139_87207(this, argumentAst, arg, requiredAssemblies);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 87022, 87231);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 210);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 210);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 86736, 87250);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 86613, 88984);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 86613, 88984);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 87284, 88984) || true) && (f_1558_87288_87372(modulesToken, f_1558_87312_87335(parameter), StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 87284, 88984);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 87406, 87476);

                                        var
                                        enumerable = argumentValue as object[] ?? (DynAbs.Tracing.TraceSender.Expression_Null<object[]>(1558, 87423, 87475) ?? new[] { argumentValue })
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 87494, 88725);
                                            foreach (var arg in f_1558_87514_87524_I(enumerable))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 87494, 88725);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 87566, 87606);

                                                ModuleSpecification
                                                moduleSpecification
                                                = default(ModuleSpecification);
                                                try
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 87680, 87757);

                                                    moduleSpecification = f_1558_87702_87756(arg);
                                                }
                                                catch (InvalidCastException e)
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1558, 87802, 88149);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 87881, 88093);

                                                    f_1558_87881_88092(this, f_1558_87893_87911(argumentAst), nameof(ParserStrings.RequiresModuleInvalid), f_1558_88016_88051(), f_1558_88082_88091(e));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 88119, 88126);

                                                    return;
                                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1558, 87802, 88149);
                                                }
                                                catch (ArgumentException e)
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1558, 88171, 88515);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 88247, 88459);

                                                    f_1558_88247_88458(this, f_1558_88259_88277(argumentAst), nameof(ParserStrings.RequiresModuleInvalid), f_1558_88382_88417(), f_1558_88448_88457(e));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 88485, 88492);

                                                    return;
                                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1558, 88171, 88515);
                                                }

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 88539, 88643) || true) && (requiredModules == null)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 88539, 88643);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 88593, 88643);

                                                    requiredModules = f_1558_88611_88642();
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 88539, 88643);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 88665, 88706);

                                                f_1558_88665_88705(requiredModules, moduleSpecification);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 87494, 88725);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 1232);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 1232);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 87284, 88984);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 87284, 88984);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 88791, 88969);

                                        f_1558_88791_88968(this, f_1558_88803_88819(parameter), nameof(DiscoveryExceptions.ScriptRequiresInvalidFormat), f_1558_88920_88967());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 87284, 88984);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 86613, 88984);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 84914, 88984);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 83854, 88984);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 82569, 88984);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 81627, 88984);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 79315, 88995);

                System.Management.Automation.Language.ExpressionAst
                f_1558_80277_80295(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 80277, 80295);
                    return return_v;
                }


                int
                f_1558_80312_80333(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 80312, 80333);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1558_80336_80360(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 80336, 80360);
                    return return_v;
                }


                string
                f_1558_80415_80438(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 80415, 80438);
                    return return_v;
                }


                bool
                f_1558_80389_80475(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 80389, 80475);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_80629_80645(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 80629, 80645);
                    return return_v;
                }


                string
                f_1558_80748_80789()
                {
                    var return_v = ParserStrings.ParameterCannotHaveArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 80748, 80789);
                    return return_v;
                }


                string
                f_1558_80816_80839(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 80816, 80839);
                    return return_v;
                }


                int
                f_1558_80617_80840(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 80617, 80840);
                    return 0;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_80987_81003(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 80987, 81003);
                    return return_v;
                }


                string
                f_1558_81096_81135()
                {
                    var return_v = ParserStrings.ParameterRequiresArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 81096, 81135);
                    return return_v;
                }


                string
                f_1558_81158_81181(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 81158, 81181);
                    return return_v;
                }


                int
                f_1558_80975_81182(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 80975, 81182);
                    return 0;
                }


                bool
                f_1558_81279_81363(System.Management.Automation.Language.Ast
                ast, out object
                constantValue, bool
                forRequires)
                {
                    var return_v = IsConstantValueVisitor.IsConstant(ast, out constantValue, forRequires: forRequires);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 81279, 81363);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_81409_81427(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 81409, 81427);
                    return return_v;
                }


                string
                f_1558_81525_81569()
                {
                    var return_v = ParserStrings.RequiresArgumentMustBeConstant;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 81525, 81569);
                    return return_v;
                }


                int
                f_1558_81397_81570(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportError(extent, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 81397, 81570);
                    return 0;
                }


                string
                f_1558_81655_81678(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 81655, 81678);
                    return return_v;
                }


                bool
                f_1558_81631_81715(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 81631, 81715);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_81830_81846(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 81830, 81846);
                    return return_v;
                }


                string
                f_1558_81952_81996()
                {
                    var return_v = ParameterBinderStrings.ParameterAlreadyBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 81952, 81996);
                    return return_v;
                }


                int
                f_1558_81818_82067(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, object
                arg1, string
                arg2)
                {
                    this_param.ReportError(extent, errorId, errorMsg, arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 81818, 82067);
                    return 0;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_82220_82238(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 82220, 82238);
                    return return_v;
                }


                string
                f_1558_82343_82386()
                {
                    var return_v = ParserStrings.RequiresInvalidStringArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 82343, 82386);
                    return return_v;
                }


                int
                f_1558_82208_82426(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 82208, 82426);
                    return 0;
                }


                string
                f_1558_82598_82621(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 82598, 82621);
                    return return_v;
                }


                bool
                f_1558_82573_82658(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 82573, 82658);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_82776_82794(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 82776, 82794);
                    return return_v;
                }


                string
                f_1558_82899_82942()
                {
                    var return_v = ParserStrings.RequiresInvalidStringArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 82899, 82942);
                    return return_v;
                }


                int
                f_1558_82764_82983(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 82764, 82983);
                    return 0;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_83128_83144(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 83128, 83144);
                    return return_v;
                }


                string
                f_1558_83250_83294()
                {
                    var return_v = ParameterBinderStrings.ParameterAlreadyBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 83250, 83294);
                    return return_v;
                }


                int
                f_1558_83116_83366(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, object
                arg1, string
                arg2)
                {
                    this_param.ReportError(extent, errorId, errorMsg, arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 83116, 83366);
                    return 0;
                }


                bool
                f_1558_83440_83493(object
                psSnapinId)
                {
                    var return_v = PSSnapInInfo.IsPSSnapinIdValid((string)psSnapinId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 83440, 83493);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_83547_83565(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 83547, 83565);
                    return return_v;
                }


                string
                f_1558_83671_83715()
                {
                    var return_v = MshSnapInCmdletResources.InvalidPSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 83671, 83715);
                    return return_v;
                }


                int
                f_1558_83535_83716(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportError(extent, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 83535, 83716);
                    return 0;
                }


                string
                f_1558_83882_83905(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 83882, 83905);
                    return return_v;
                }


                bool
                f_1558_83858_83942(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 83858, 83942);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_84058_84074(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 84058, 84074);
                    return return_v;
                }


                string
                f_1558_84180_84224()
                {
                    var return_v = ParameterBinderStrings.ParameterAlreadyBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 84180, 84224);
                    return return_v;
                }


                int
                f_1558_84046_84295(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, object
                arg1, string
                arg2)
                {
                    this_param.ReportError(extent, errorId, errorMsg, arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 84046, 84295);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1558_84487_84568(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.Ast
                argumentAst, object
                arg, ref System.Collections.Generic.List<string>
                requiredEditions)
                {
                    var return_v = this_param.HandleRequiresPSEditionArgument(argumentAst, arg, ref requiredEditions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 84487, 84568);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1558_84766_84837(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.Ast
                argumentAst, object
                arg, ref System.Collections.Generic.List<string>
                requiredEditions)
                {
                    var return_v = this_param.HandleRequiresPSEditionArgument(argumentAst, arg, ref requiredEditions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 84766, 84837);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1558_84671_84697_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 84671, 84697);
                    return return_v;
                }


                string
                f_1558_84942_84965(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 84942, 84965);
                    return return_v;
                }


                bool
                f_1558_84918_85002(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 84918, 85002);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_85082_85100(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 85082, 85100);
                    return return_v;
                }


                string
                f_1558_85082_85105(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 85082, 85105);
                    return return_v;
                }


                System.Version
                f_1558_85138_85173(string
                versionString)
                {
                    var return_v = Utils.StringToVersion(versionString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 85138, 85173);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_85265_85283(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 85265, 85283);
                    return return_v;
                }


                string
                f_1558_85381_85417()
                {
                    var return_v = ParserStrings.RequiresVersionInvalid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 85381, 85417);
                    return return_v;
                }


                int
                f_1558_85253_85418(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportError(extent, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 85253, 85418);
                    return 0;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_85635_85651(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 85635, 85651);
                    return return_v;
                }


                string
                f_1558_85765_85809()
                {
                    var return_v = ParameterBinderStrings.ParameterAlreadyBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 85765, 85809);
                    return return_v;
                }


                int
                f_1558_85623_85888(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, object
                arg1, string
                arg2)
                {
                    this_param.ReportError(extent, errorId, errorMsg, arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 85623, 85888);
                    return 0;
                }


                bool
                f_1558_86107_86138(System.Version
                this_param, System.Version
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 86107, 86138);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_86200_86216(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 86200, 86216);
                    return return_v;
                }


                string
                f_1558_86330_86374()
                {
                    var return_v = ParameterBinderStrings.ParameterAlreadyBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 86330, 86374);
                    return return_v;
                }


                int
                f_1558_86188_86453(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, object
                arg1, string
                arg2)
                {
                    this_param.ReportError(extent, errorId, errorMsg, arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 86188, 86453);
                    return 0;
                }


                string
                f_1558_86642_86665(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 86642, 86665);
                    return return_v;
                }


                bool
                f_1558_86617_86702(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 86617, 86702);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1558_86861_86939(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.Ast
                argumentAst, object
                arg, System.Collections.Generic.List<string>
                requiredAssemblies)
                {
                    var return_v = this_param.HandleRequiresAssemblyArgument(argumentAst, arg, requiredAssemblies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 86861, 86939);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1558_87139_87207(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.Ast
                argumentAst, object
                arg, System.Collections.Generic.List<string>
                requiredAssemblies)
                {
                    var return_v = this_param.HandleRequiresAssemblyArgument(argumentAst, arg, requiredAssemblies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 87139, 87207);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1558_87042_87068_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 87042, 87068);
                    return return_v;
                }


                string
                f_1558_87312_87335(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 87312, 87335);
                    return return_v;
                }


                bool
                f_1558_87288_87372(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 87288, 87372);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification
                f_1558_87702_87756(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<ModuleSpecification>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 87702, 87756);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_87893_87911(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 87893, 87911);
                    return return_v;
                }


                string
                f_1558_88016_88051()
                {
                    var return_v = ParserStrings.RequiresModuleInvalid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 88016, 88051);
                    return return_v;
                }


                string
                f_1558_88082_88091(System.InvalidCastException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 88082, 88091);
                    return return_v;
                }


                int
                f_1558_87881_88092(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 87881, 88092);
                    return 0;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_88259_88277(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 88259, 88277);
                    return return_v;
                }


                string
                f_1558_88382_88417()
                {
                    var return_v = ParserStrings.RequiresModuleInvalid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 88382, 88417);
                    return return_v;
                }


                string
                f_1558_88448_88457(System.ArgumentException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 88448, 88457);
                    return return_v;
                }


                int
                f_1558_88247_88458(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 88247, 88458);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1558_88611_88642()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 88611, 88642);
                    return return_v;
                }


                int
                f_1558_88665_88705(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                this_param, Microsoft.PowerShell.Commands.ModuleSpecification
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 88665, 88705);
                    return 0;
                }


                object[]
                f_1558_87514_87524_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 87514, 87524);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_88803_88819(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 88803, 88819);
                    return return_v;
                }


                string
                f_1558_88920_88967()
                {
                    var return_v = DiscoveryExceptions.ScriptRequiresInvalidFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 88920, 88967);
                    return return_v;
                }


                int
                f_1558_88791_88968(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportError(extent, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 88791, 88968);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 79315, 88995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 79315, 88995);
            }
        }

        private List<string> HandleRequiresAssemblyArgument(Ast argumentAst, object arg, List<string> requiredAssemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 89007, 89796);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 89145, 89743) || true) && (!(arg is string))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 89145, 89743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 89199, 89407);

                    f_1558_89199_89406(this, f_1558_89211_89229(argumentAst), nameof(ParserStrings.RequiresInvalidStringArgument), f_1558_89326_89369(), assemblyToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 89145, 89743);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 89145, 89743);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 89473, 89566) || true) && (requiredAssemblies == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 89473, 89566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 89526, 89566);

                        requiredAssemblies = f_1558_89547_89565();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 89473, 89566);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 89586, 89728) || true) && (!f_1558_89591_89631(requiredAssemblies, arg))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 89586, 89728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 89673, 89709);

                        f_1558_89673_89708(requiredAssemblies, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 89586, 89728);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 89145, 89743);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 89759, 89785);

                return requiredAssemblies;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 89007, 89796);

                System.Management.Automation.Language.IScriptExtent
                f_1558_89211_89229(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 89211, 89229);
                    return return_v;
                }


                string
                f_1558_89326_89369()
                {
                    var return_v = ParserStrings.RequiresInvalidStringArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 89326, 89369);
                    return return_v;
                }


                int
                f_1558_89199_89406(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 89199, 89406);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1558_89547_89565()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 89547, 89565);
                    return return_v;
                }


                bool
                f_1558_89591_89631(System.Collections.Generic.List<string>
                this_param, object
                item)
                {
                    var return_v = this_param.Contains((string)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 89591, 89631);
                    return return_v;
                }


                int
                f_1558_89673_89708(System.Collections.Generic.List<string>
                this_param, object
                item)
                {
                    this_param.Add((string)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 89673, 89708);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 89007, 89796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 89007, 89796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<string> HandleRequiresPSEditionArgument(Ast argumentAst, object arg, ref List<string> requiredEditions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 89808, 91313);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 89949, 91262) || true) && (!(arg is string))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 89949, 91262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 90003, 90210);

                    f_1558_90003_90209(this, f_1558_90015_90033(argumentAst), nameof(ParserStrings.RequiresInvalidStringArgument), f_1558_90130_90173(), editionToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 89949, 91262);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 89949, 91262);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 90276, 90365) || true) && (requiredEditions == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 90276, 90365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 90327, 90365);

                        requiredEditions = f_1558_90346_90364();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 90276, 90365);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 90385, 90411);

                    var
                    edition = (string)arg
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 90429, 90740) || true) && (!f_1558_90434_90470(edition))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 90429, 90740);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 90512, 90721);

                        f_1558_90512_90720(this, f_1558_90524_90542(argumentAst), nameof(ParserStrings.RequiresPSEditionInvalid), f_1558_90642_90680(), editionToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 90429, 90740);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 90760, 91247) || true) && (!f_1558_90765_90833(requiredEditions, edition, f_1558_90800_90832()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 90760, 91247);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 90875, 90905);

                        f_1558_90875_90904(requiredEditions, edition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 90760, 91247);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 90760, 91247);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 90987, 91228);

                        f_1558_90987_91227(this, f_1558_90999_91017(argumentAst), nameof(ParserStrings.RequiresPSEditionValueIsAlreadySpecified), f_1558_91133_91187(), editionToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 90760, 91247);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 89949, 91262);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 91278, 91302);

                return requiredEditions;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 89808, 91313);

                System.Management.Automation.Language.IScriptExtent
                f_1558_90015_90033(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 90015, 90033);
                    return return_v;
                }


                string
                f_1558_90130_90173()
                {
                    var return_v = ParserStrings.RequiresInvalidStringArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 90130, 90173);
                    return return_v;
                }


                int
                f_1558_90003_90209(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 90003, 90209);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1558_90346_90364()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 90346, 90364);
                    return return_v;
                }


                bool
                f_1558_90434_90470(string
                editionValue)
                {
                    var return_v = Utils.IsValidPSEditionValue(editionValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 90434, 90470);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_90524_90542(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 90524, 90542);
                    return return_v;
                }


                string
                f_1558_90642_90680()
                {
                    var return_v = ParserStrings.RequiresPSEditionInvalid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 90642, 90680);
                    return return_v;
                }


                int
                f_1558_90512_90720(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 90512, 90720);
                    return 0;
                }


                System.StringComparer
                f_1558_90800_90832()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 90800, 90832);
                    return return_v;
                }


                bool
                f_1558_90765_90833(System.Collections.Generic.List<string>
                source, string
                value, System.StringComparer
                comparer)
                {
                    var return_v = source.Contains<string>(value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 90765, 90833);
                    return return_v;
                }


                int
                f_1558_90875_90904(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 90875, 90904);
                    return 0;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1558_90999_91017(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 90999, 91017);
                    return return_v;
                }


                string
                f_1558_91133_91187()
                {
                    var return_v = ParserStrings.RequiresPSEditionValueIsAlreadySpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 91133, 91187);
                    return return_v;
                }


                int
                f_1558_90987_91227(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 90987, 91227);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 89808, 91313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 89808, 91313);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal StringToken GetVerbatimCommandArgument()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 91554, 92564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 91628, 91645);

                f_1558_91628_91644(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 91659, 91687);

                _tokenStart = _currentIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 91703, 91725);

                bool
                inQuotes = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 91739, 92340) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 91739, 92340);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 91784, 91803);

                        char
                        c = f_1558_91793_91802(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 91823, 91976) || true) && (c == '\r' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 91827, 91849) || c == '\n') || (DynAbs.Tracing.TraceSender.Expression_False(1558, 91827, 91875) || (c == '\0' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 91854, 91874) && f_1558_91867_91874(this)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 91823, 91976);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 91917, 91929);

                            f_1558_91917_91928(this);
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 91951, 91957);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 91823, 91976);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 91996, 92130) || true) && (f_1558_92000_92017(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 91996, 92130);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 92059, 92080);

                            inQuotes = !inQuotes;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 92102, 92111);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 91996, 92130);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 92150, 92325) || true) && (!inQuotes && (DynAbs.Tracing.TraceSender.Expression_True(1558, 92154, 92224) && (c == '|' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 92168, 92223) || (c == '&' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 92181, 92201) && !f_1558_92194_92201(this)) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 92181, 92222) && f_1558_92205_92215(this) == '&'))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 92150, 92325);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 92266, 92278);

                            f_1558_92266_92277(this);
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 92300, 92306);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 92150, 92325);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 91739, 92340);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 91739, 92340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 91739, 92340);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 92356, 92409);

                InternalScriptExtent
                currentExtent = f_1558_92393_92408(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 92423, 92462);

                string
                tokenValue = f_1558_92443_92461(currentExtent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 92476, 92553);

                return f_1558_92483_92552(this, tokenValue, TokenKind.Generic, TokenFlags.None);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 91554, 92564);

                int
                f_1558_91628_91644(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipWhiteSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 91628, 91644);
                    return 0;
                }


                char
                f_1558_91793_91802(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 91793, 91802);
                    return return_v;
                }


                bool
                f_1558_91867_91874(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.AtEof();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 91867, 91874);
                    return return_v;
                }


                int
                f_1558_91917_91928(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 91917, 91928);
                    return 0;
                }


                bool
                f_1558_92000_92017(char
                c)
                {
                    var return_v = c.IsDoubleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 92000, 92017);
                    return return_v;
                }


                bool
                f_1558_92194_92201(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.AtEof();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 92194, 92201);
                    return return_v;
                }


                char
                f_1558_92205_92215(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 92205, 92215);
                    return return_v;
                }


                int
                f_1558_92266_92277(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 92266, 92277);
                    return 0;
                }


                System.Management.Automation.Language.InternalScriptExtent
                f_1558_92393_92408(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.CurrentExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 92393, 92408);
                    return return_v;
                }


                string
                f_1558_92443_92461(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 92443, 92461);
                    return return_v;
                }


                System.Management.Automation.Language.StringToken
                f_1558_92483_92552(System.Management.Automation.Language.Tokenizer
                this_param, string
                value, System.Management.Automation.Language.TokenKind
                tokenKind, System.Management.Automation.Language.TokenFlags
                flags)
                {
                    var return_v = this_param.NewStringLiteralToken(value, tokenKind, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 92483, 92552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 91554, 92564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 91554, 92564);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TokenFlags ScanStringLiteral(StringBuilder sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 92576, 93812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 92655, 92690);

                int
                errorIndex = _currentIndex - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 92704, 92739);

                TokenFlags
                flags = TokenFlags.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 92755, 92774);

                char
                c = f_1558_92764_92773(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 92788, 93335) || true) && (c != '\0' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 92795, 92816) || !f_1558_92809_92816(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 92788, 93335);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 92850, 93255) || true) && (f_1558_92854_92871(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 92850, 93255);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 93088, 93198) || true) && (!f_1558_93093_93119(f_1558_93093_93103(this)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 93088, 93198);
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 93169, 93175);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 93088, 93198);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 93222, 93236);

                            c = f_1558_93226_93235(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 92850, 93255);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 93275, 93288);

                        f_1558_93275_93287(
                                        sb, c);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 93306, 93320);

                        c = f_1558_93310_93319(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 92788, 93335);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 92788, 93335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 92788, 93335);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 93351, 93772) || true) && (c == '\0')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 93351, 93772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 93473, 93485);

                    f_1558_93473_93484(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 93503, 93707);

                    f_1558_93503_93706(this, errorIndex, nameof(ParserStrings.TerminatorExpectedAtEndOfString), f_1558_93634_93679(), "'");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 93725, 93757);

                    flags = TokenFlags.TokenInError;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 93351, 93772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 93788, 93801);

                return flags;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 92576, 93812);

                char
                f_1558_92764_92773(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 92764, 92773);
                    return return_v;
                }


                bool
                f_1558_92809_92816(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.AtEof();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 92809, 92816);
                    return return_v;
                }


                bool
                f_1558_92854_92871(char
                c)
                {
                    var return_v = c.IsSingleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 92854, 92871);
                    return return_v;
                }


                char
                f_1558_93093_93103(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 93093, 93103);
                    return return_v;
                }


                bool
                f_1558_93093_93119(char
                c)
                {
                    var return_v = c.IsSingleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 93093, 93119);
                    return return_v;
                }


                char
                f_1558_93226_93235(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 93226, 93235);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_93275_93287(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 93275, 93287);
                    return return_v;
                }


                char
                f_1558_93310_93319(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 93310, 93319);
                    return return_v;
                }


                int
                f_1558_93473_93484(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 93473, 93484);
                    return 0;
                }


                string
                f_1558_93634_93679()
                {
                    var return_v = ParserStrings.TerminatorExpectedAtEndOfString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 93634, 93679);
                    return return_v;
                }


                int
                f_1558_93503_93706(System.Management.Automation.Language.Tokenizer
                this_param, int
                errorOffset, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportIncompleteInput(errorOffset, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 93503, 93706);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 92576, 93812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 92576, 93812);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token ScanStringLiteral()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 93824, 94069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 93882, 93910);

                var
                sb = f_1558_93891_93909(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 93924, 93958);

                var
                flags = f_1558_93936_93957(this, sb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 93972, 94058);

                return f_1558_93979_94057(this, f_1558_94001_94024(this, sb), TokenKind.StringLiteral, flags);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 93824, 94069);

                System.Text.StringBuilder
                f_1558_93891_93909(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 93891, 93909);
                    return return_v;
                }


                System.Management.Automation.Language.TokenFlags
                f_1558_93936_93957(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanStringLiteral(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 93936, 93957);
                    return return_v;
                }


                string
                f_1558_94001_94024(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 94001, 94024);
                    return return_v;
                }


                System.Management.Automation.Language.StringToken
                f_1558_93979_94057(System.Management.Automation.Language.Tokenizer
                this_param, string
                value, System.Management.Automation.Language.TokenKind
                tokenKind, System.Management.Automation.Language.TokenFlags
                flags)
                {
                    var return_v = this_param.NewStringLiteralToken(value, tokenKind, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 93979, 94057);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 93824, 94069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 93824, 94069);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token ScanSubExpression(bool hereString)
        {
            RuntimeHelpers.EnsureSufficientExecutionStack();
            _tokenStart = _currentIndex - 2;
            var sb = GetStringBuilder();
            sb.Append("$(");
            int parenCount = 1;
            TokenFlags flags = TokenFlags.None;
            bool scanning = true;
            List<int> skippedCharOffsets = new List<int>();
            while (scanning)
            {
                char c = GetChar();
                switch (c)
                {
                    case '(':
                        sb.Append(c);
                        ++parenCount;
                        break;

                    case ')':
                        sb.Append(c);
                        if (--parenCount == 0)
                        {
                            scanning = false;
                        }

                        break;

                    case '`':
                    case '"':
                    case SpecialChars.QuoteDoubleLeft:
                    case SpecialChars.QuoteDoubleRight:
                    case SpecialChars.QuoteLowDoubleLeft:
                        char c1 = PeekChar();
                        if (!hereString && c1.IsDoubleQuote())
                        {
                            SkipChar();
                            sb.Append(c1);
                            skippedCharOffsets.Add(_currentIndex - 2 + _nestedTokensAdjustment);
                        }
                        else
                        {
                            sb.Append(c);
                        }

                        break;

                    case '\0':
                        if (!AtEof())
                            goto default;

                        UngetChar();
                        ReportIncompleteInput(_tokenStart,
                            nameof(ParserStrings.IncompleteDollarSubexpressionReference),
                            ParserStrings.IncompleteDollarSubexpressionReference);
                        flags = TokenFlags.TokenInError;
                        scanning = false;
                        break;

                    default:
                        sb.Append(c);
                        break;
                }
            }

            BitArray skippedCharBitArray;
            if (skippedCharOffsets.Count > 0)
            {
                skippedCharBitArray = new BitArray(skippedCharOffsets.Last() + 1);
                foreach (int i in skippedCharOffsets)
                {
                    skippedCharBitArray.Set(i, true);
                }
            }
            else
            {
                skippedCharBitArray = _skippedCharOffsets;
            }

            var extent = CurrentExtent();
            Diagnostics.Assert(
                (extent.Text[0] == '$' && extent.Text[1] == '(' && extent.Text[extent.Text.Length - 1] == ')') || (flags & TokenFlags.TokenInError) != 0,
                "Extent computed incorrectly.");
            return new UnscannedSubExprToken(extent, flags, GetStringAndRelease(sb), skippedCharBitArray);
        }

        private TokenFlags ScanStringExpandable(StringBuilder sb, StringBuilder formatSb, List<Token> nestedTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 97305, 99868);
                char surrogateCharacter = default(char);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 97437, 97472);

                TokenFlags
                flags = TokenFlags.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 97486, 97521);

                int
                errorIndex = _currentIndex - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 97537, 97556);

                char
                c = f_1558_97546_97555(this)
                ;
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 97570, 99465) || true) && (c != '\0' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 97577, 97598) || !f_1558_97591_97598(this)))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 97600, 97613)
   , c = f_1558_97604_97613(this), DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 97570, 99465))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 97570, 99465);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 97647, 99007) || true) && (f_1558_97651_97668(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 97647, 99007);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 97885, 97995) || true) && (!f_1558_97890_97916(f_1558_97890_97900(this)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 97885, 97995);
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 97966, 97972);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 97885, 97995);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 98019, 98033);

                            c = f_1558_98023_98032(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 97647, 99007);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 97647, 99007);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 98075, 99007) || true) && (c == '$')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 98075, 99007);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 98129, 98278) || true) && (f_1558_98133_98196(this, sb, formatSb, false, nestedTokens))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 98129, 98278);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 98246, 98255);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 98129, 98278);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 98075, 99007);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 98075, 99007);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 98320, 99007) || true) && (c == '`')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 98320, 99007);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 98473, 98494);

                                    char
                                    c1 = f_1558_98483_98493(this)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 98516, 98988) || true) && (c1 != 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 98516, 98988);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 98577, 98588);

                                        f_1558_98577_98587(this);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 98614, 98660);

                                        c = f_1558_98618_98659(this, c1, out surrogateCharacter);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 98686, 98965) || true) && (surrogateCharacter != s_invalidChar)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 98686, 98965);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 98783, 98823);

                                            f_1558_98783_98822(f_1558_98783_98795(sb, c), surrogateCharacter);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 98853, 98899);

                                            f_1558_98853_98898(f_1558_98853_98871(formatSb, c), surrogateCharacter);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 98929, 98938);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 98686, 98965);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 98516, 98988);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 98320, 99007);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 98075, 99007);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 97647, 99007);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 99027, 99380) || true) && (c == '{' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 99031, 99051) || c == '}'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 99027, 99380);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 99342, 99361);

                            f_1558_99342_99360(                    // In the format string, we need to double up the curlies because we're
                                                                   // replacing variable references and sub-expressions with the appropriate
                                                                   // format expression for string.Format.
                                                formatSb, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 99027, 99380);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 99400, 99413);

                        f_1558_99400_99412(
                                        sb, c);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 99431, 99450);

                        f_1558_99431_99449(formatSb, c);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 1896);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 1896);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 99481, 99828) || true) && (c == '\0')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 99481, 99828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 99528, 99540);

                    f_1558_99528_99539(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 99558, 99763);

                    f_1558_99558_99762(this, errorIndex, nameof(ParserStrings.TerminatorExpectedAtEndOfString), f_1558_99689_99734(), "\"");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 99781, 99813);

                    flags = TokenFlags.TokenInError;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 99481, 99828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 99844, 99857);

                return flags;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 97305, 99868);

                char
                f_1558_97546_97555(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 97546, 97555);
                    return return_v;
                }


                bool
                f_1558_97591_97598(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.AtEof();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 97591, 97598);
                    return return_v;
                }


                char
                f_1558_97604_97613(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 97604, 97613);
                    return return_v;
                }


                bool
                f_1558_97651_97668(char
                c)
                {
                    var return_v = c.IsDoubleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 97651, 97668);
                    return return_v;
                }


                char
                f_1558_97890_97900(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 97890, 97900);
                    return return_v;
                }


                bool
                f_1558_97890_97916(char
                c)
                {
                    var return_v = c.IsDoubleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 97890, 97916);
                    return return_v;
                }


                char
                f_1558_98023_98032(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 98023, 98032);
                    return return_v;
                }


                bool
                f_1558_98133_98196(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb, System.Text.StringBuilder
                formatSb, bool
                hereString, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                nestedTokens)
                {
                    var return_v = this_param.ScanDollarInStringExpandable(sb, formatSb, hereString, nestedTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 98133, 98196);
                    return return_v;
                }


                char
                f_1558_98483_98493(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 98483, 98493);
                    return return_v;
                }


                int
                f_1558_98577_98587(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 98577, 98587);
                    return 0;
                }


                char
                f_1558_98618_98659(System.Management.Automation.Language.Tokenizer
                this_param, char
                c, out char
                surrogateCharacter)
                {
                    var return_v = this_param.Backtick(c, out surrogateCharacter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 98618, 98659);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_98783_98795(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 98783, 98795);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_98783_98822(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 98783, 98822);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_98853_98871(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 98853, 98871);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_98853_98898(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 98853, 98898);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_99342_99360(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 99342, 99360);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_99400_99412(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 99400, 99412);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_99431_99449(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 99431, 99449);
                    return return_v;
                }


                int
                f_1558_99528_99539(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 99528, 99539);
                    return 0;
                }


                string
                f_1558_99689_99734()
                {
                    var return_v = ParserStrings.TerminatorExpectedAtEndOfString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 99689, 99734);
                    return return_v;
                }


                int
                f_1558_99558_99762(System.Management.Automation.Language.Tokenizer
                this_param, int
                errorOffset, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportIncompleteInput(errorOffset, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 99558, 99762);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 97305, 99868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 97305, 99868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanDollarInStringExpandable(StringBuilder sb, StringBuilder formatSb, bool hereString, List<Token> nestedTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 99979, 101783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100130, 100166);

                int
                dollarIndex = _currentIndex - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100180, 100201);

                char
                c1 = f_1558_100190_100200(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100215, 100248);

                int
                saveTokenStart = _tokenStart
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100262, 100290);

                var
                oldTokenizerMode = f_1558_100285_100289()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100304, 100333);

                var
                oldTokenList = f_1558_100323_100332()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100347, 100372);

                Token
                nestedToken = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100481, 100498);

                    TokenList = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100516, 100548);

                    Mode = TokenizerMode.Expression;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100568, 100934) || true) && (c1 == '(')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 100568, 100934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100623, 100634);

                        f_1558_100623_100633(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100656, 100700);

                        nestedToken = f_1558_100670_100699(this, hereString);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 100568, 100934);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 100568, 100934);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100742, 100934) || true) && (f_1558_100746_100766(c1) || (DynAbs.Tracing.TraceSender.Expression_False(1558, 100746, 100779) || c1 == '{'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 100742, 100934);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100821, 100853);

                            _tokenStart = _currentIndex - 1;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 100875, 100915);

                            nestedToken = f_1558_100889_100914(this, false, true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 100742, 100934);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 100568, 100934);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1558, 100963, 101132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101003, 101028);

                    TokenList = oldTokenList;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101046, 101075);

                    _tokenStart = saveTokenStart;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101093, 101117);

                    Mode = oldTokenizerMode;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1558, 100963, 101132);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101148, 101491) || true) && (nestedToken != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 101148, 101491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101205, 101266);

                    f_1558_101205_101265(sb, _script, dollarIndex, _currentIndex - dollarIndex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101284, 101305);

                    f_1558_101284_101304(formatSb, '{');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101323, 101359);

                    f_1558_101323_101358(formatSb, f_1558_101339_101357(nestedTokens));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101377, 101398);

                    f_1558_101377_101397(formatSb, '}');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101416, 101446);

                    f_1558_101416_101445(nestedTokens, nestedToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101464, 101476);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 101148, 101491);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101649, 101743);

                f_1558_101649_101742(f_1558_101668_101678(this) == c1, "We accidently consumed a character we shouldn't have.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101759, 101772);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 99979, 101783);

                char
                f_1558_100190_100200(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 100190, 100200);
                    return return_v;
                }


                System.Management.Automation.Language.TokenizerMode
                f_1558_100285_100289()
                {
                    var return_v = Mode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 100285, 100289);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_100323_100332()
                {
                    var return_v = TokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 100323, 100332);
                    return return_v;
                }


                int
                f_1558_100623_100633(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 100623, 100633);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_100670_100699(System.Management.Automation.Language.Tokenizer
                this_param, bool
                hereString)
                {
                    var return_v = this_param.ScanSubExpression(hereString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 100670, 100699);
                    return return_v;
                }


                bool
                f_1558_100746_100766(char
                c)
                {
                    var return_v = c.IsVariableStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 100746, 100766);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_100889_100914(System.Management.Automation.Language.Tokenizer
                this_param, bool
                splatted, bool
                inStringExpandable)
                {
                    var return_v = this_param.ScanVariable(splatted, inStringExpandable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 100889, 100914);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_101205_101265(System.Text.StringBuilder
                this_param, string
                value, int
                startIndex, int
                count)
                {
                    var return_v = this_param.Append(value, startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 101205, 101265);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_101284_101304(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 101284, 101304);
                    return return_v;
                }


                int
                f_1558_101339_101357(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 101339, 101357);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_101323_101358(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 101323, 101358);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_101377_101397(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 101377, 101397);
                    return return_v;
                }


                int
                f_1558_101416_101445(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param, System.Management.Automation.Language.Token
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 101416, 101445);
                    return 0;
                }


                char
                f_1558_101668_101678(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 101668, 101678);
                    return return_v;
                }


                int
                f_1558_101649_101742(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 101649, 101742);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 99979, 101783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 99979, 101783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token ScanStringExpandable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 101795, 102237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101856, 101884);

                var
                sb = f_1558_101865_101883(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101898, 101932);

                var
                formatSb = f_1558_101913_101931(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 101946, 101991);

                List<Token>
                nestedTokens = f_1558_101973_101990()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 102007, 102075);

                TokenFlags
                flags = f_1558_102026_102074(this, sb, formatSb, nestedTokens)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 102089, 102226);

                return f_1558_102096_102225(this, f_1558_102121_102144(this, sb), f_1558_102146_102175(this, formatSb), TokenKind.StringExpandable, nestedTokens, flags);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 101795, 102237);

                System.Text.StringBuilder
                f_1558_101865_101883(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 101865, 101883);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_101913_101931(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 101913, 101931);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_101973_101990()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.Token>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 101973, 101990);
                    return return_v;
                }


                System.Management.Automation.Language.TokenFlags
                f_1558_102026_102074(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb, System.Text.StringBuilder
                formatSb, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                nestedTokens)
                {
                    var return_v = this_param.ScanStringExpandable(sb, formatSb, nestedTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 102026, 102074);
                    return return_v;
                }


                string
                f_1558_102121_102144(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 102121, 102144);
                    return return_v;
                }


                string
                f_1558_102146_102175(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 102146, 102175);
                    return return_v;
                }


                System.Management.Automation.Language.StringToken
                f_1558_102096_102225(System.Management.Automation.Language.Tokenizer
                this_param, string
                value, string
                formatString, System.Management.Automation.Language.TokenKind
                tokenKind, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                nestedTokens, System.Management.Automation.Language.TokenFlags
                flags)
                {
                    var return_v = this_param.NewStringExpandableToken(value, formatString, tokenKind, nestedTokens, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 102096, 102225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 101795, 102237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 101795, 102237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanAfterHereStringHeader(string header)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 102249, 104266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 102450, 102487);

                int
                headerOffset = _currentIndex - 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 102503, 102510);

                char
                c
                = default(char);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 102524, 102614);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 102559, 102573);

                            c = f_1558_102563_102572(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 102524, 102614);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 102524, 102614) || true) && (f_1558_102596_102612(c))
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 102524, 102614);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 102524, 102614);
                    }
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 102630, 104227) || true) && (c == '\r')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 102630, 104227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 102677, 102694);

                    f_1558_102677_102693(this, c);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 102630, 104227);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 102630, 104227);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 102728, 104227) || true) && (c != '\n')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 102728, 104227);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 102775, 103173) || true) && (c == '\0' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 102779, 102799) && f_1558_102792_102799(this)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 102775, 103173);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 102841, 102853);

                            f_1558_102841_102852(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 102875, 103119);

                            f_1558_102875_103118(this, headerOffset, nameof(ParserStrings.TerminatorExpectedAtEndOfString), f_1558_103016_103061(), f_1558_103088_103117(f_1558_103102_103111(header, 1), '@'));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 103141, 103154);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 102775, 103173);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 103193, 103205);

                        f_1558_103193_103204(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 103506, 103697);

                        f_1558_103506_103696(this, _currentIndex, nameof(ParserStrings.UnexpectedCharactersAfterHereStringHeader), f_1558_103640_103695());
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 103717, 104179);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 103760, 103774);

                                    c = f_1558_103764_103773(this);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 103796, 103953) || true) && (c == f_1558_103805_103814(header, 1) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 103800, 103837) && (f_1558_103819_103829(this) == '@')))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 103796, 103953);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 103887, 103898);

                                        f_1558_103887_103897(this);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 103924, 103930);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 103796, 103953);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 103977, 104146) || true) && (c == '\r' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 103981, 104003) || c == '\n') || (DynAbs.Tracing.TraceSender.Expression_False(1558, 103981, 104029) || (c == '\0' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 104008, 104028) && f_1558_104021_104028(this)))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 103977, 104146);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 104079, 104091);

                                        f_1558_104079_104090(this);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 104117, 104123);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 103977, 104146);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 103717, 104179);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 103717, 104179) || true) && (true)
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 103717, 104179);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 103717, 104179);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 104199, 104212);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 102728, 104227);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 102630, 104227);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 104243, 104255);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 102249, 104266);

                char
                f_1558_102563_102572(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 102563, 102572);
                    return return_v;
                }


                bool
                f_1558_102596_102612(char
                c)
                {
                    var return_v = c.IsWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 102596, 102612);
                    return return_v;
                }


                int
                f_1558_102677_102693(System.Management.Automation.Language.Tokenizer
                this_param, char
                c)
                {
                    this_param.NormalizeCRLF(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 102677, 102693);
                    return 0;
                }


                bool
                f_1558_102792_102799(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.AtEof();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 102792, 102799);
                    return return_v;
                }


                int
                f_1558_102841_102852(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 102841, 102852);
                    return 0;
                }


                string
                f_1558_103016_103061()
                {
                    var return_v = ParserStrings.TerminatorExpectedAtEndOfString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 103016, 103061);
                    return return_v;
                }


                char
                f_1558_103102_103111(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 103102, 103111);
                    return return_v;
                }


                string
                f_1558_103088_103117(char
                arg0, char
                arg1)
                {
                    var return_v = string.Concat((object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 103088, 103117);
                    return return_v;
                }


                int
                f_1558_102875_103118(System.Management.Automation.Language.Tokenizer
                this_param, int
                errorOffset, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportIncompleteInput(errorOffset, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 102875, 103118);
                    return 0;
                }


                int
                f_1558_103193_103204(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 103193, 103204);
                    return 0;
                }


                string
                f_1558_103640_103695()
                {
                    var return_v = ParserStrings.UnexpectedCharactersAfterHereStringHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 103640, 103695);
                    return return_v;
                }


                int
                f_1558_103506_103696(System.Management.Automation.Language.Tokenizer
                this_param, int
                errorOffset, string
                errorId, string
                errorMsg, params object[]
                args)
                {
                    this_param.ReportError(errorOffset, errorId, errorMsg, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 103506, 103696);
                    return 0;
                }


                char
                f_1558_103764_103773(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 103764, 103773);
                    return return_v;
                }


                char
                f_1558_103805_103814(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 103805, 103814);
                    return return_v;
                }


                char
                f_1558_103819_103829(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 103819, 103829);
                    return return_v;
                }


                int
                f_1558_103887_103897(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 103887, 103897);
                    return 0;
                }


                bool
                f_1558_104021_104028(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.AtEof();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 104021, 104028);
                    return return_v;
                }


                int
                f_1558_104079_104090(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 104079, 104090);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 102249, 104266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 102249, 104266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanPossibleHereStringFooter(Func<char, bool> test, Action<char> appendChar, ref int falseFooterOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 104278, 105808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 104419, 104438);

                char
                c = f_1558_104428_104437(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 104516, 104638) || true) && (f_1558_104520_104527(test, c) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 104520, 104548) && f_1558_104531_104541(this) == '@'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 104516, 104638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 104582, 104593);

                    f_1558_104582_104592(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 104611, 104623);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 104516, 104638);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 104793, 104911) || true) && (f_1558_104800_104816(c))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 104793, 104911);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 104850, 104864);

                        f_1558_104850_104863(appendChar, c);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 104882, 104896);

                        c = f_1558_104886_104895(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 104793, 104911);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 104793, 104911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 104793, 104911);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 104927, 105071) || true) && (c == '\r' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 104931, 104953) || c == '\n') || (DynAbs.Tracing.TraceSender.Expression_False(1558, 104931, 104979) || (c == '\0' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 104958, 104978) && f_1558_104971_104978(this)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 104927, 105071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 105013, 105025);

                    f_1558_105013_105024(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 105043, 105056);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 104927, 105071);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 105087, 105768) || true) && (f_1558_105091_105098(test, c) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 105091, 105119) && f_1558_105102_105112(this) == '@'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 105087, 105768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 105153, 105167);

                    f_1558_105153_105166(appendChar, c);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 105185, 105448) || true) && (falseFooterOffset == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 105185, 105448);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 105391, 105429);

                        falseFooterOffset = _currentIndex - 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 105185, 105448);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 105468, 105490);

                    f_1558_105468_105489(appendChar, f_1558_105479_105488(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 105087, 105768);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 105087, 105768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 105741, 105753);

                    f_1558_105741_105752(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 105087, 105768);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 105784, 105797);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 104278, 105808);

                char
                f_1558_104428_104437(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 104428, 104437);
                    return return_v;
                }


                bool
                f_1558_104520_104527(System.Func<char, bool>
                this_param, char
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 104520, 104527);
                    return return_v;
                }


                char
                f_1558_104531_104541(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 104531, 104541);
                    return return_v;
                }


                int
                f_1558_104582_104592(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 104582, 104592);
                    return 0;
                }


                bool
                f_1558_104800_104816(char
                c)
                {
                    var return_v = c.IsWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 104800, 104816);
                    return return_v;
                }


                int
                f_1558_104850_104863(System.Action<char>
                this_param, char
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 104850, 104863);
                    return 0;
                }


                char
                f_1558_104886_104895(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 104886, 104895);
                    return return_v;
                }


                bool
                f_1558_104971_104978(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.AtEof();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 104971, 104978);
                    return return_v;
                }


                int
                f_1558_105013_105024(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 105013, 105024);
                    return 0;
                }


                bool
                f_1558_105091_105098(System.Func<char, bool>
                this_param, char
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 105091, 105098);
                    return return_v;
                }


                char
                f_1558_105102_105112(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 105102, 105112);
                    return return_v;
                }


                int
                f_1558_105153_105166(System.Action<char>
                this_param, char
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 105153, 105166);
                    return 0;
                }


                char
                f_1558_105479_105488(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 105479, 105488);
                    return return_v;
                }


                int
                f_1558_105468_105489(System.Action<char>
                this_param, char
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 105468, 105489);
                    return 0;
                }


                int
                f_1558_105741_105752(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 105741, 105752);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 104278, 105808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 104278, 105808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token ScanHereStringLiteral()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 105820, 108716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106047, 106084);

                int
                headerOffset = _currentIndex - 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106098, 106125);

                int
                falseFooterOffset = -1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106141, 106323) || true) && (!f_1558_106146_106177(this, "@'"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 106141, 106323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106211, 106308);

                    return f_1558_106218_106307(this, string.Empty, TokenKind.HereStringLiteral, TokenFlags.TokenInError);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 106141, 106323);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106339, 106374);

                TokenFlags
                flags = TokenFlags.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106388, 106416);

                var
                sb = f_1558_106397_106415(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106430, 106474);

                Action<char>
                appendChar = c => sb.Append(c)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106488, 108599) || true) && (!f_1558_106493_106586(this, CharExtensions.IsSingleQuote, appendChar, ref falseFooterOffset))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 106488, 108599);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106620, 108584) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 106620, 108584);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106673, 106692);

                            char
                            c = f_1558_106682_106691(this)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106716, 108565) || true) && (c == '\r' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 106720, 106742) || c == '\n'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 106716, 108565);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106898, 106921);

                                int
                                length = f_1558_106911_106920(sb)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106949, 106962);

                                f_1558_106949_106961(
                                                        sb, c);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 106988, 107165) || true) && (c == '\r' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 106992, 107023) && f_1558_107005_107015(this) == '\n'))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 106988, 107165);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 107081, 107092);

                                    f_1558_107081_107091(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 107122, 107138);

                                    f_1558_107122_107137(sb, '\n');
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 106988, 107165);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 107193, 107496) || true) && (f_1558_107197_107290(this, CharExtensions.IsSingleQuote, appendChar, ref falseFooterOffset))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 107193, 107496);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 107414, 107433);

                                    sb.Length = length;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1558, 107463, 107469);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 107193, 107496);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 106716, 108565);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 106716, 108565);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 107546, 108565) || true) && (c != '\0' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 107550, 107571) || !f_1558_107564_107571(this)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 107546, 108565);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 107621, 107634);

                                    f_1558_107621_107633(sb, c);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 107546, 108565);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 107546, 108565);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 107732, 107744);

                                    f_1558_107732_107743(this);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 107770, 108450) || true) && (falseFooterOffset != -1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 107770, 108450);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 107855, 108066);

                                        f_1558_107855_108065(this, falseFooterOffset, nameof(ParserStrings.WhitespaceBeforeHereStringFooter), f_1558_108018_108064());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 107770, 108450);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 107770, 108450);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 108180, 108423);

                                        f_1558_108180_108422(this, headerOffset, nameof(ParserStrings.TerminatorExpectedAtEndOfString), f_1558_108337_108382(), "'@");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 107770, 108450);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 108478, 108510);

                                    flags = TokenFlags.TokenInError;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1558, 108536, 108542);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 107546, 108565);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 106716, 108565);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 106620, 108584);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 106620, 108584);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 106620, 108584);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 106488, 108599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 108615, 108705);

                return f_1558_108622_108704(this, f_1558_108644_108667(this, sb), TokenKind.HereStringLiteral, flags);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 105820, 108716);

                bool
                f_1558_106146_106177(System.Management.Automation.Language.Tokenizer
                this_param, string
                header)
                {
                    var return_v = this_param.ScanAfterHereStringHeader(header);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 106146, 106177);
                    return return_v;
                }


                System.Management.Automation.Language.StringToken
                f_1558_106218_106307(System.Management.Automation.Language.Tokenizer
                this_param, string
                value, System.Management.Automation.Language.TokenKind
                tokenKind, System.Management.Automation.Language.TokenFlags
                flags)
                {
                    var return_v = this_param.NewStringLiteralToken(value, tokenKind, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 106218, 106307);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_106397_106415(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 106397, 106415);
                    return return_v;
                }


                bool
                f_1558_106493_106586(System.Management.Automation.Language.Tokenizer
                this_param, System.Func<char, bool>
                test, System.Action<char>
                appendChar, ref int
                falseFooterOffset)
                {
                    var return_v = this_param.ScanPossibleHereStringFooter(test, appendChar, ref falseFooterOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 106493, 106586);
                    return return_v;
                }


                char
                f_1558_106682_106691(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 106682, 106691);
                    return return_v;
                }


                int
                f_1558_106911_106920(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 106911, 106920);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_106949_106961(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 106949, 106961);
                    return return_v;
                }


                char
                f_1558_107005_107015(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 107005, 107015);
                    return return_v;
                }


                int
                f_1558_107081_107091(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 107081, 107091);
                    return 0;
                }


                System.Text.StringBuilder
                f_1558_107122_107137(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 107122, 107137);
                    return return_v;
                }


                bool
                f_1558_107197_107290(System.Management.Automation.Language.Tokenizer
                this_param, System.Func<char, bool>
                test, System.Action<char>
                appendChar, ref int
                falseFooterOffset)
                {
                    var return_v = this_param.ScanPossibleHereStringFooter(test, appendChar, ref falseFooterOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 107197, 107290);
                    return return_v;
                }


                bool
                f_1558_107564_107571(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.AtEof();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 107564, 107571);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_107621_107633(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 107621, 107633);
                    return return_v;
                }


                int
                f_1558_107732_107743(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 107732, 107743);
                    return 0;
                }


                string
                f_1558_108018_108064()
                {
                    var return_v = ParserStrings.WhitespaceBeforeHereStringFooter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 108018, 108064);
                    return return_v;
                }


                int
                f_1558_107855_108065(System.Management.Automation.Language.Tokenizer
                this_param, int
                errorOffset, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportIncompleteInput(errorOffset, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 107855, 108065);
                    return 0;
                }


                string
                f_1558_108337_108382()
                {
                    var return_v = ParserStrings.TerminatorExpectedAtEndOfString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 108337, 108382);
                    return return_v;
                }


                int
                f_1558_108180_108422(System.Management.Automation.Language.Tokenizer
                this_param, int
                errorOffset, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportIncompleteInput(errorOffset, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 108180, 108422);
                    return 0;
                }


                string
                f_1558_108644_108667(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 108644, 108667);
                    return return_v;
                }


                System.Management.Automation.Language.StringToken
                f_1558_108622_108704(System.Management.Automation.Language.Tokenizer
                this_param, string
                value, System.Management.Automation.Language.TokenKind
                tokenKind, System.Management.Automation.Language.TokenFlags
                flags)
                {
                    var return_v = this_param.NewStringLiteralToken(value, tokenKind, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 108622, 108704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 105820, 108716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 105820, 108716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token ScanHereStringExpandable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 108728, 113580);
                char surrogateCharacter = default(char);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 108958, 108995);

                int
                headerOffset = _currentIndex - 2
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 109011, 109220) || true) && (!f_1558_109016_109048(this, "@\""))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 109011, 109220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 109082, 109205);

                    return f_1558_109089_109204(this, string.Empty, string.Empty, TokenKind.HereStringExpandable, null, TokenFlags.TokenInError);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 109011, 109220);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 109236, 109271);

                TokenFlags
                flags = TokenFlags.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 109285, 109330);

                List<Token>
                nestedTokens = f_1558_109312_109329()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 109344, 109371);

                int
                falseFooterOffset = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 109385, 109413);

                var
                sb = f_1558_109394_109412(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 109427, 109461);

                var
                formatSb = f_1558_109442_109460(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 109475, 109544);

                Action<char>
                appendChar = c => { sb.Append(c); formatSb.Append(c); }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 109558, 113412) || true) && (!f_1558_109563_109656(this, CharExtensions.IsDoubleQuote, appendChar, ref falseFooterOffset))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 109558, 113412);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 109690, 113397) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 109690, 113397);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 109743, 109762);

                            char
                            c = f_1558_109752_109761(this)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 109786, 110845) || true) && (c == '\r' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 109790, 109812) || c == '\n'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 109786, 110845);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 109968, 109991);

                                int
                                length = f_1558_109981_109990(sb)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 110017, 110052);

                                int
                                formatLength = f_1558_110036_110051(formatSb)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 110080, 110093);

                                f_1558_110080_110092(
                                                        sb, c);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 110119, 110138);

                                f_1558_110119_110137(formatSb, c);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 110164, 110393) || true) && (c == '\r' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 110168, 110199) && f_1558_110181_110191(this) == '\n'))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 110164, 110393);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 110257, 110268);

                                    f_1558_110257_110267(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 110298, 110314);

                                    f_1558_110298_110313(sb, '\n');
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 110344, 110366);

                                    f_1558_110344_110365(formatSb, '\n');
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 110164, 110393);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 110421, 110785) || true) && (f_1558_110425_110518(this, CharExtensions.IsDoubleQuote, appendChar, ref falseFooterOffset))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 110421, 110785);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 110642, 110661);

                                    sb.Length = length;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 110691, 110722);

                                    formatSb.Length = formatLength;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1558, 110752, 110758);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 110421, 110785);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 110813, 110822);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 109786, 110845);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 110869, 111888) || true) && (c == '$')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 110869, 111888);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 110931, 111091) || true) && (f_1558_110935_110997(this, sb, formatSb, true, nestedTokens))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 110931, 111091);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 111055, 111064);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 110931, 111091);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 110869, 111888);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 110869, 111888);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 111141, 111888) || true) && (c == '`')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 111141, 111888);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 111306, 111327);

                                    char
                                    c1 = f_1558_111316_111326(this)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 111353, 111865) || true) && (c1 != 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 111353, 111865);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 111422, 111433);

                                        f_1558_111422_111432(this);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 111463, 111509);

                                        c = f_1558_111467_111508(this, c1, out surrogateCharacter);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 111539, 111838) || true) && (surrogateCharacter != s_invalidChar)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 111539, 111838);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 111644, 111684);

                                            f_1558_111644_111683(f_1558_111644_111656(sb, c), surrogateCharacter);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 111718, 111764);

                                            f_1558_111718_111763(f_1558_111718_111736(formatSb, c), surrogateCharacter);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 111798, 111807);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 111539, 111838);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 111353, 111865);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 111141, 111888);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 110869, 111888);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 111912, 112289) || true) && (c == '{' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 111916, 111936) || c == '}'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 111912, 112289);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 112247, 112266);

                                f_1558_112247_112265(                        // In the format string, we need to double up the curlies because we're
                                                                             // replacing variable references and sub-expressions with the appropriate
                                                                             // format expression for string.Format.
                                                        formatSb, c);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 111912, 112289);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 112313, 113378) || true) && (c != '\0' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 112317, 112338) || !f_1558_112331_112338(this)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 112313, 113378);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 112388, 112401);

                                f_1558_112388_112400(sb, c);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 112427, 112446);

                                f_1558_112427_112445(formatSb, c);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 112313, 113378);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 112313, 113378);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 112544, 112556);

                                f_1558_112544_112555(this);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 112582, 113263) || true) && (falseFooterOffset != -1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 112582, 113263);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 112667, 112878);

                                    f_1558_112667_112877(this, falseFooterOffset, nameof(ParserStrings.WhitespaceBeforeHereStringFooter), f_1558_112830_112876());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 112582, 113263);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 112582, 113263);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 112992, 113236);

                                    f_1558_112992_113235(this, headerOffset, nameof(ParserStrings.TerminatorExpectedAtEndOfString), f_1558_113149_113194(), "\"@");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 112582, 113263);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 113291, 113323);

                                flags = TokenFlags.TokenInError;
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 113349, 113355);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 112313, 113378);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 109690, 113397);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 109690, 113397);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 109690, 113397);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 109558, 113412);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 113428, 113569);

                return f_1558_113435_113568(this, f_1558_113460_113483(this, sb), f_1558_113485_113514(this, formatSb), TokenKind.HereStringExpandable, nestedTokens, flags);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 108728, 113580);

                bool
                f_1558_109016_109048(System.Management.Automation.Language.Tokenizer
                this_param, string
                header)
                {
                    var return_v = this_param.ScanAfterHereStringHeader(header);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 109016, 109048);
                    return return_v;
                }


                System.Management.Automation.Language.StringToken
                f_1558_109089_109204(System.Management.Automation.Language.Tokenizer
                this_param, string
                value, string
                formatString, System.Management.Automation.Language.TokenKind
                tokenKind, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                nestedTokens, System.Management.Automation.Language.TokenFlags
                flags)
                {
                    var return_v = this_param.NewStringExpandableToken(value, formatString, tokenKind, nestedTokens, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 109089, 109204);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_109312_109329()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.Token>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 109312, 109329);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_109394_109412(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 109394, 109412);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_109442_109460(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 109442, 109460);
                    return return_v;
                }


                bool
                f_1558_109563_109656(System.Management.Automation.Language.Tokenizer
                this_param, System.Func<char, bool>
                test, System.Action<char>
                appendChar, ref int
                falseFooterOffset)
                {
                    var return_v = this_param.ScanPossibleHereStringFooter(test, appendChar, ref falseFooterOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 109563, 109656);
                    return return_v;
                }


                char
                f_1558_109752_109761(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 109752, 109761);
                    return return_v;
                }


                int
                f_1558_109981_109990(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 109981, 109990);
                    return return_v;
                }


                int
                f_1558_110036_110051(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 110036, 110051);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_110080_110092(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 110080, 110092);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_110119_110137(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 110119, 110137);
                    return return_v;
                }


                char
                f_1558_110181_110191(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 110181, 110191);
                    return return_v;
                }


                int
                f_1558_110257_110267(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 110257, 110267);
                    return 0;
                }


                System.Text.StringBuilder
                f_1558_110298_110313(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 110298, 110313);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_110344_110365(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 110344, 110365);
                    return return_v;
                }


                bool
                f_1558_110425_110518(System.Management.Automation.Language.Tokenizer
                this_param, System.Func<char, bool>
                test, System.Action<char>
                appendChar, ref int
                falseFooterOffset)
                {
                    var return_v = this_param.ScanPossibleHereStringFooter(test, appendChar, ref falseFooterOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 110425, 110518);
                    return return_v;
                }


                bool
                f_1558_110935_110997(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb, System.Text.StringBuilder
                formatSb, bool
                hereString, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                nestedTokens)
                {
                    var return_v = this_param.ScanDollarInStringExpandable(sb, formatSb, hereString, nestedTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 110935, 110997);
                    return return_v;
                }


                char
                f_1558_111316_111326(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 111316, 111326);
                    return return_v;
                }


                int
                f_1558_111422_111432(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 111422, 111432);
                    return 0;
                }


                char
                f_1558_111467_111508(System.Management.Automation.Language.Tokenizer
                this_param, char
                c, out char
                surrogateCharacter)
                {
                    var return_v = this_param.Backtick(c, out surrogateCharacter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 111467, 111508);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_111644_111656(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 111644, 111656);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_111644_111683(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 111644, 111683);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_111718_111736(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 111718, 111736);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_111718_111763(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 111718, 111763);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_112247_112265(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 112247, 112265);
                    return return_v;
                }


                bool
                f_1558_112331_112338(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.AtEof();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 112331, 112338);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_112388_112400(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 112388, 112400);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_112427_112445(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 112427, 112445);
                    return return_v;
                }


                int
                f_1558_112544_112555(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 112544, 112555);
                    return 0;
                }


                string
                f_1558_112830_112876()
                {
                    var return_v = ParserStrings.WhitespaceBeforeHereStringFooter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 112830, 112876);
                    return return_v;
                }


                int
                f_1558_112667_112877(System.Management.Automation.Language.Tokenizer
                this_param, int
                errorOffset, string
                errorId, string
                errorMsg)
                {
                    this_param.ReportIncompleteInput(errorOffset, errorId, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 112667, 112877);
                    return 0;
                }


                string
                f_1558_113149_113194()
                {
                    var return_v = ParserStrings.TerminatorExpectedAtEndOfString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 113149, 113194);
                    return return_v;
                }


                int
                f_1558_112992_113235(System.Management.Automation.Language.Tokenizer
                this_param, int
                errorOffset, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportIncompleteInput(errorOffset, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 112992, 113235);
                    return 0;
                }


                string
                f_1558_113460_113483(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 113460, 113483);
                    return return_v;
                }


                string
                f_1558_113485_113514(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 113485, 113514);
                    return return_v;
                }


                System.Management.Automation.Language.StringToken
                f_1558_113435_113568(System.Management.Automation.Language.Tokenizer
                this_param, string
                value, string
                formatString, System.Management.Automation.Language.TokenKind
                tokenKind, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                nestedTokens, System.Management.Automation.Language.TokenFlags
                flags)
                {
                    var return_v = this_param.NewStringExpandableToken(value, formatString, tokenKind, nestedTokens, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 113435, 113568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 108728, 113580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 108728, 113580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        // Scan a variable - the first character ($ or @) has been consumed already.
        private Token ScanVariable(bool splatted, bool inStringExpandable)
        {
            int errorStartPosition = _currentIndex;

            var sb = GetStringBuilder();
            char c = GetChar();

            VariablePath path;
            if (c == '{')
            {
                // Braced variable
                Diagnostics.Assert(!splatted, "Splatting is not supported with braced variables.");

                while (true)
                {
                    c = GetChar();

                    switch (c)
                    {
                        case '}':
                            goto end_braced_variable_scan;
                        case '`':
                            {
                                char c1 = GetChar();
                                if (c1 == '\0' && AtEof())
                                {
                                    UngetChar();
                                    goto end_braced_variable_scan;
                                }

                                c = Backtick(c1, out char surrogateCharacter);
                                if (surrogateCharacter != s_invalidChar)
                                {
                                    sb.Append(c).Append(surrogateCharacter);
                                    continue;
                                }

                                break;
                            }
                        case '"':
                        case SpecialChars.QuoteDoubleLeft:
                        case SpecialChars.QuoteDoubleRight:
                        case SpecialChars.QuoteLowDoubleLeft:
                            if (inStringExpandable)
                            {
                                char c1 = GetChar();
                                if (c1 == '\0' && AtEof())
                                {
                                    UngetChar();
                                    goto end_braced_variable_scan;
                                }

                                if (c1.IsDoubleQuote())
                                {
                                    c = c1;
                                }
                                else
                                {
                                    UngetChar();
                                }
                            }

                            break;
                        case '{':
                            ReportError(_currentIndex,
                                nameof(ParserStrings.OpenBraceNeedsToBeBackTickedInVariableName),
                                ParserStrings.OpenBraceNeedsToBeBackTickedInVariableName);
                            break;
                        case '\0':
                            if (AtEof())
                            {
                                UngetChar();
                                goto end_braced_variable_scan;
                            }

                            break;
                    }

                    sb.Append(c);
                }

            end_braced_variable_scan:

                string name = GetStringAndRelease(sb);
                if (c != '}')
                {
                    ReportIncompleteInput(errorStartPosition,
                        nameof(ParserStrings.IncompleteDollarVariableReference),
                        ParserStrings.IncompleteDollarVariableReference);
                }

                if (name.Length == 0)
                {
                    if (c == '}')
                    {
                        ReportError(_currentIndex - 1,
                            nameof(ParserStrings.EmptyVariableReference),
                            ParserStrings.EmptyVariableReference);
                    }

                    name = ":Error:";
                }

                if (InCommandMode())
                {
                    char c1 = PeekChar();

                    // A '.' or '[' after the variable name in command mode is an operator, not part of the current token.
                    if (!c1.ForceStartNewToken() && c1 != '.' && c1 != '[')
                    {
                        // The simple way to get this variable included in the nested tokens is to just start
                        // scanning all over again, but from the context of scanning a generic token.
                        _currentIndex = _tokenStart;
                        return ScanGenericToken(GetStringBuilder());
                    }
                }

                path = new VariablePath(name);
                if (string.IsNullOrEmpty(path.UnqualifiedPath))
                {
                    // Enable if we decide we still need to support
                    //     "${}"  or "$var:"
                    // if (inStringExpandable)
                    // {
                    //    return NewToken(TokenKind.Unknown);
                    // }

                    ReportError(NewScriptExtent(_tokenStart, _currentIndex),
                        nameof(ParserStrings.InvalidBracedVariableReference),
                        ParserStrings.InvalidBracedVariableReference);
                }

                return NewVariableToken(path, false);
            }

            if (!c.IsVariableStart())
            {
                UngetChar();
                sb.Append('$');
                return ScanGenericToken(sb);
            }

            // Normal variable, not braced.
            sb.Append(c);

            // $$, $?, and $^ can only be single character variables.  Otherwise keep scanning.
            if (!(c == '$' || c == '?' || c == '^'))
            {
                bool scanning = true;
                while (scanning)
                {
                    c = GetChar();
                    switch (c)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                        case 'd':
                        case 'e':
                        case 'f':
                        case 'g':
                        case 'h':
                        case 'i':
                        case 'j':
                        case 'k':
                        case 'l':
                        case 'm':
                        case 'n':
                        case 'o':
                        case 'p':
                        case 'q':
                        case 'r':
                        case 's':
                        case 't':
                        case 'u':
                        case 'v':
                        case 'w':
                        case 'x':
                        case 'y':
                        case 'z':
                        case 'A':
                        case 'B':
                        case 'C':
                        case 'D':
                        case 'E':
                        case 'F':
                        case 'G':
                        case 'H':
                        case 'I':
                        case 'J':
                        case 'K':
                        case 'L':
                        case 'M':
                        case 'N':
                        case 'O':
                        case 'P':
                        case 'Q':
                        case 'R':
                        case 'S':
                        case 'T':
                        case 'U':
                        case 'V':
                        case 'W':
                        case 'X':
                        case 'Y':
                        case 'Z':
                        case '0':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                        case '_':
                        case '?':
                            sb.Append(c);
                            break;

                        case ':':
                            if (PeekChar() == ':')
                            {
                                // Something like $a::b is static member access
                                UngetChar();
                                scanning = false;
                            }
                            else
                            {
                                sb.Append(c);
                            }

                            break;

                        case '\0':
                        case '\t':
                        case '\r':
                        case '\n':
                        case ' ':
                        case '&':
                        case '(':
                        case ')':
                        case ',':
                        case ';':
                        case '{':
                        case '}':
                        case '|':
                        // The above cases would also be handled correctly below in the default case,
                        // but we can avoid extra checks on some of these characters which commonly
                        // occur after a variable.
                        case '.':
                        case '[':
                        // Something like $a.b or $a[1].
                        case '=':
                            // Something like $a=
                            UngetChar();
                            scanning = false;
                            break;

                        default:
                            if (char.IsLetterOrDigit(c))
                            {
                                sb.Append(c);
                            }
                            else if (InCommandMode() && !c.ForceStartNewToken())
                            {
                                _currentIndex = _tokenStart;
                                sb.Clear();
                                return ScanGenericToken(sb);
                            }
                            else
                            {
                                UngetChar();
                                scanning = false;
                            }

                            break;
                    }
                }
            }
            else if (InCommandMode() && !PeekChar().ForceStartNewToken())
            {
                _currentIndex = _tokenStart;
                sb.Clear();
                return ScanGenericToken(sb);
            }

            path = new VariablePath(GetStringAndRelease(sb));
            if (string.IsNullOrEmpty(path.UnqualifiedPath))
            {
                string errorId;
                string errorMsg;
                if (path.IsDriveQualified)
                {
                    errorId = nameof(ParserStrings.InvalidVariableReferenceWithDrive);
                    errorMsg = ParserStrings.InvalidVariableReferenceWithDrive;
                }
                else
                {
                    errorId = nameof(ParserStrings.InvalidVariableReference);
                    errorMsg = ParserStrings.InvalidVariableReference;
                }

                ReportError(NewScriptExtent(_tokenStart, _currentIndex), errorId, errorMsg);
            }

            return NewVariableToken(path, splatted);
        }

        private Token ScanParameter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 125615, 130457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 125669, 125697);

                var
                sb = f_1558_125678_125696(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 125713, 125734);

                bool
                scanning = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 125748, 125775);

                bool
                sawColonAtEnd = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 125789, 129945) || true) && (scanning)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 125789, 129945);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 125838, 125857);

                        char
                        c = f_1558_125847_125856(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 125877, 125998) || true) && (f_1558_125881_125897(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 125877, 125998);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 125939, 125951);

                            f_1558_125939_125950(this);
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 125973, 125979);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 125877, 125998);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 126018, 129930);

                        switch (c)
                        {

                            case '{':
                            case '}':
                            case '(':
                            case ')':
                            case ';':
                            case ',':
                            case '|':
                            case '&':
                            case '.':
                            case '[':
                            case '\r':
                            case '\n':
                            case '\0':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 126018, 129930);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 126479, 126491);

                                f_1558_126479_126490(this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 126517, 126534);

                                scanning = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 126560, 126566);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 126018, 129930);

                            case ':':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 126018, 129930);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 126625, 126642);

                                scanning = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 126668, 126689);

                                sawColonAtEnd = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 126715, 126832) || true) && (!f_1558_126720_126735(this))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 126715, 126832);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 126793, 126805);

                                    f_1558_126793_126804(this);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 126715, 126832);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 126860, 126866);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 126018, 129930);

                            case 'a':
                            case 'b':
                            case 'c':
                            case 'd':
                            case 'e':
                            case 'f':
                            case 'g':
                            case 'h':
                            case 'i':
                            case 'j':
                            case 'k':
                            case 'l':
                            case 'm':
                            case 'n':
                            case 'o':
                            case 'p':
                            case 'q':
                            case 'r':
                            case 's':
                            case 't':
                            case 'u':
                            case 'v':
                            case 'w':
                            case 'x':
                            case 'y':
                            case 'z':
                            case 'A':
                            case 'B':
                            case 'C':
                            case 'D':
                            case 'E':
                            case 'F':
                            case 'G':
                            case 'H':
                            case 'I':
                            case 'J':
                            case 'K':
                            case 'L':
                            case 'M':
                            case 'N':
                            case 'O':
                            case 'P':
                            case 'Q':
                            case 'R':
                            case 'S':
                            case 'T':
                            case 'U':
                            case 'V':
                            case 'W':
                            case 'X':
                            case 'Y':
                            case 'Z':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 126018, 129930);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 128506, 128519);

                                f_1558_128506_128518(sb, c);
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 128545, 128551);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 126018, 129930);

                            case '\'':
                            case SpecialChars.QuoteSingleLeft:
                            case SpecialChars.QuoteSingleRight:
                            case SpecialChars.QuoteSingleBase:
                            case SpecialChars.QuoteReversed:
                            case '"':
                            case SpecialChars.QuoteDoubleLeft:
                            case SpecialChars.QuoteDoubleRight:
                            case SpecialChars.QuoteLowDoubleLeft:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 126018, 129930);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 129037, 129414) || true) && (f_1558_129041_129056(this))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 129037, 129414);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 129217, 129229);

                                    f_1558_129217_129228(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 129259, 129294);

                                    f_1558_129259_129293(sb, 0, f_1558_129272_129292(_script, _tokenStart));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 129359, 129387);

                                    return f_1558_129366_129386(this, sb);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 129037, 129414);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 129442, 129454);

                                f_1558_129442_129453(this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 129480, 129497);

                                scanning = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 129523, 129529);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 126018, 129930);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 126018, 129930);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 129587, 129877) || true) && (f_1558_129591_129606(this))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 129587, 129877);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 129664, 129677);

                                    f_1558_129664_129676(sb, c);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 129587, 129877);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 129587, 129877);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 129791, 129803);

                                    f_1558_129791_129802(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 129833, 129850);

                                    scanning = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 129587, 129877);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 129905, 129911);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 126018, 129930);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 125789, 129945);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 125789, 129945);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 125789, 129945);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 129961, 129995);

                var
                str = f_1558_129971_129994(this, sb)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 130011, 130268) || true) && (f_1558_130015_130033(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 130011, 130268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 130067, 130090);

                    TokenKind
                    operatorKind
                    = default(TokenKind);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 130108, 130253) || true) && (f_1558_130112_130162(s_operatorTable, str, out operatorKind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 130108, 130253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 130204, 130234);

                        return f_1558_130211_130233(this, operatorKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 130108, 130253);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 130011, 130268);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 130284, 130385) || true) && (f_1558_130288_130298(str) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 130284, 130385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 130337, 130370);

                    return f_1558_130344_130369(this, TokenKind.Minus);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 130284, 130385);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 130401, 130446);

                return f_1558_130408_130445(this, str, sawColonAtEnd);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 125615, 130457);

                System.Text.StringBuilder
                f_1558_125678_125696(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 125678, 125696);
                    return return_v;
                }


                char
                f_1558_125847_125856(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 125847, 125856);
                    return return_v;
                }


                bool
                f_1558_125881_125897(char
                c)
                {
                    var return_v = c.IsWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 125881, 125897);
                    return return_v;
                }


                int
                f_1558_125939_125950(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 125939, 125950);
                    return 0;
                }


                int
                f_1558_126479_126490(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 126479, 126490);
                    return 0;
                }


                bool
                f_1558_126720_126735(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InCommandMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 126720, 126735);
                    return return_v;
                }


                int
                f_1558_126793_126804(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 126793, 126804);
                    return 0;
                }


                System.Text.StringBuilder
                f_1558_128506_128518(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 128506, 128518);
                    return return_v;
                }


                bool
                f_1558_129041_129056(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InCommandMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 129041, 129056);
                    return return_v;
                }


                int
                f_1558_129217_129228(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 129217, 129228);
                    return 0;
                }


                char
                f_1558_129272_129292(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 129272, 129292);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_129259_129293(System.Text.StringBuilder
                this_param, int
                index, char
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 129259, 129293);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_129366_129386(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanGenericToken(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 129366, 129386);
                    return return_v;
                }


                int
                f_1558_129442_129453(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 129442, 129453);
                    return 0;
                }


                bool
                f_1558_129591_129606(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InCommandMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 129591, 129606);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_129664_129676(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 129664, 129676);
                    return return_v;
                }


                int
                f_1558_129791_129802(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 129791, 129802);
                    return 0;
                }


                string
                f_1558_129971_129994(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 129971, 129994);
                    return return_v;
                }


                bool
                f_1558_130015_130033(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InExpressionMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130015, 130033);
                    return return_v;
                }


                bool
                f_1558_130112_130162(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TokenKind>
                this_param, string
                key, out System.Management.Automation.Language.TokenKind
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130112, 130162);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_130211_130233(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130211, 130233);
                    return return_v;
                }


                int
                f_1558_130288_130298(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 130288, 130298);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_130344_130369(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130344, 130369);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_130408_130445(System.Management.Automation.Language.Tokenizer
                this_param, string
                name, bool
                sawColon)
                {
                    var return_v = this_param.NewParameterToken(name, sawColon);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130408, 130445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 125615, 130457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 125615, 130457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token CheckOperatorInCommandMode(char c, TokenKind tokenKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 130469, 130748);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 130563, 130694) || true) && (f_1558_130567_130582(this) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 130567, 130618) && !f_1558_130587_130618(f_1558_130587_130597(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 130563, 130694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 130652, 130679);

                    return f_1558_130659_130678(this, c);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 130563, 130694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 130710, 130737);

                return f_1558_130717_130736(this, tokenKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 130469, 130748);

                bool
                f_1558_130567_130582(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InCommandMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130567, 130582);
                    return return_v;
                }


                char
                f_1558_130587_130597(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130587, 130597);
                    return return_v;
                }


                bool
                f_1558_130587_130618(char
                c)
                {
                    var return_v = c.ForceStartNewToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130587, 130618);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_130659_130678(System.Management.Automation.Language.Tokenizer
                this_param, char
                firstChar)
                {
                    var return_v = this_param.ScanGenericToken(firstChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130659, 130678);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_130717_130736(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130717, 130736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 130469, 130748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 130469, 130748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token CheckOperatorInCommandMode(char c1, char c2, TokenKind tokenKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 130760, 131160);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 130864, 131106) || true) && (f_1558_130868_130883(this) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 130868, 130919) && !f_1558_130888_130919(f_1558_130888_130898(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 130864, 131106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 130953, 130981);

                    var
                    sb = f_1558_130962_130980(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 130999, 131013);

                    f_1558_130999_131012(sb, c1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 131031, 131045);

                    f_1558_131031_131044(sb, c2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 131063, 131091);

                    return f_1558_131070_131090(this, sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 130864, 131106);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 131122, 131149);

                return f_1558_131129_131148(this, tokenKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 130760, 131160);

                bool
                f_1558_130868_130883(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InCommandMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130868, 130883);
                    return return_v;
                }


                char
                f_1558_130888_130898(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130888, 130898);
                    return return_v;
                }


                bool
                f_1558_130888_130919(char
                c)
                {
                    var return_v = c.ForceStartNewToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130888, 130919);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_130962_130980(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130962, 130980);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_130999_131012(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 130999, 131012);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_131031_131044(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 131031, 131044);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_131070_131090(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanGenericToken(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 131070, 131090);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_131129_131148(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 131129, 131148);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 130760, 131160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 130760, 131160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token ScanGenericToken(char firstChar)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 131172, 131359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 131243, 131271);

                var
                sb = f_1558_131252_131270(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 131285, 131306);

                f_1558_131285_131305(sb, firstChar);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 131320, 131348);

                return f_1558_131327_131347(this, sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 131172, 131359);

                System.Text.StringBuilder
                f_1558_131252_131270(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 131252, 131270);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_131285_131305(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 131285, 131305);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_131327_131347(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanGenericToken(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 131327, 131347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 131172, 131359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 131172, 131359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token ScanGenericToken(char firstChar, char surrogateCharacter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 131371, 131717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 131467, 131495);

                var
                sb = f_1558_131476_131494(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 131509, 131530);

                f_1558_131509_131529(sb, firstChar);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 131544, 131662) || true) && (surrogateCharacter != s_invalidChar)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 131544, 131662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 131617, 131647);

                    f_1558_131617_131646(sb, surrogateCharacter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 131544, 131662);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 131678, 131706);

                return f_1558_131685_131705(this, sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 131371, 131717);

                System.Text.StringBuilder
                f_1558_131476_131494(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 131476, 131494);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_131509_131529(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 131509, 131529);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_131617_131646(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 131617, 131646);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_131685_131705(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanGenericToken(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 131685, 131705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 131371, 131717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 131371, 131717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token ScanGenericToken(StringBuilder sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 131729, 135806);
                char surrogateCharacter = default(char);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 133345, 133390);

                List<Token>
                nestedTokens = f_1558_133372_133389()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 133404, 133438);

                var
                formatSb = f_1558_133419_133437(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 133452, 133472);

                f_1558_133452_133471(formatSb, sb);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 133488, 133507);

                char
                c = f_1558_133497_133506(this)
                ;
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 133521, 135281) || true) && (!f_1558_133529_133551(c))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 133553, 133566)
   , c = f_1558_133557_133566(this), DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 133521, 135281))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 133521, 135281);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 133600, 135074) || true) && (c == '`')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 133600, 135074);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 133754, 133775);

                            char
                            c1 = f_1558_133764_133774(this)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 133797, 134269) || true) && (c1 != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 133797, 134269);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 133858, 133869);

                                f_1558_133858_133868(this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 133895, 133941);

                                c = f_1558_133899_133940(this, c1, out surrogateCharacter);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 133967, 134246) || true) && (surrogateCharacter != s_invalidChar)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 133967, 134246);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134064, 134104);

                                    f_1558_134064_134103(f_1558_134064_134076(sb, c), surrogateCharacter);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134134, 134180);

                                    f_1558_134134_134179(f_1558_134134_134152(formatSb, c), surrogateCharacter);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134210, 134219);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 133967, 134246);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 133797, 134269);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 133600, 135074);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 133600, 135074);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134311, 135074) || true) && (f_1558_134315_134332(c))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 134311, 135074);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134374, 134394);

                                int
                                len = f_1558_134384_134393(sb)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134416, 134438);

                                f_1558_134416_134437(this, sb);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134469, 134476);
                                    for (int
                i = len
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134460, 134592) || true) && (i < f_1558_134482_134491(sb))
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134493, 134496)
                , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 134460, 134592))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 134460, 134592);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134546, 134569);

                                        f_1558_134546_134568(formatSb, f_1558_134562_134567(sb, i));
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 133);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 133);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134616, 134625);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 134311, 135074);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 134311, 135074);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134667, 135074) || true) && (f_1558_134671_134688(c))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 134667, 135074);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134730, 134779);

                                    f_1558_134730_134778(this, sb, formatSb, nestedTokens);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134801, 134810);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 134667, 135074);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 134667, 135074);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134852, 135074) || true) && (c == '$')
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 134852, 135074);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 134906, 135055) || true) && (f_1558_134910_134973(this, sb, formatSb, false, nestedTokens))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 134906, 135055);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135023, 135032);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 134906, 135055);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 134852, 135074);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 134667, 135074);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 134311, 135074);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 133600, 135074);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135094, 135107);

                        f_1558_135094_135106(
                                        sb, c);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135125, 135144);

                        f_1558_135125_135143(formatSb, c);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135162, 135266) || true) && (c == '{' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 135166, 135186) || c == '}'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 135162, 135266);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135228, 135247);

                            f_1558_135228_135246(formatSb, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 135162, 135266);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 1, 1761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 1, 1761);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135297, 135309);

                f_1558_135297_135308(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135325, 135359);

                var
                str = f_1558_135335_135358(this, sb)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135373, 135531) || true) && (f_1558_135377_135395(nestedTokens) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 135373, 135531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135433, 135516);

                    return f_1558_135440_135515(this, str, f_1558_135471_135500(this, formatSb), nestedTokens);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 135373, 135531);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135547, 135565);

                f_1558_135547_135564(this, formatSb);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135581, 135751) || true) && (f_1558_135585_135620(str) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 135585, 135660) && !f_1558_135625_135660(str)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 135581, 135751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135694, 135736);

                    return f_1558_135701_135735(this, TokenKind.DynamicKeyword);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 135581, 135751);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135767, 135795);

                return f_1558_135774_135794(this, str);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 131729, 135806);

                System.Collections.Generic.List<System.Management.Automation.Language.Token>
                f_1558_133372_133389()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.Token>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 133372, 133389);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_133419_133437(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 133419, 133437);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_133452_133471(System.Text.StringBuilder
                this_param, System.Text.StringBuilder
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 133452, 133471);
                    return return_v;
                }


                char
                f_1558_133497_133506(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 133497, 133506);
                    return return_v;
                }


                bool
                f_1558_133529_133551(char
                c)
                {
                    var return_v = c.ForceStartNewToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 133529, 133551);
                    return return_v;
                }


                char
                f_1558_133557_133566(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 133557, 133566);
                    return return_v;
                }


                char
                f_1558_133764_133774(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 133764, 133774);
                    return return_v;
                }


                int
                f_1558_133858_133868(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 133858, 133868);
                    return 0;
                }


                char
                f_1558_133899_133940(System.Management.Automation.Language.Tokenizer
                this_param, char
                c, out char
                surrogateCharacter)
                {
                    var return_v = this_param.Backtick(c, out surrogateCharacter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 133899, 133940);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_134064_134076(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 134064, 134076);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_134064_134103(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 134064, 134103);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_134134_134152(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 134134, 134152);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_134134_134179(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 134134, 134179);
                    return return_v;
                }


                bool
                f_1558_134315_134332(char
                c)
                {
                    var return_v = c.IsSingleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 134315, 134332);
                    return return_v;
                }


                int
                f_1558_134384_134393(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 134384, 134393);
                    return return_v;
                }


                System.Management.Automation.Language.TokenFlags
                f_1558_134416_134437(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanStringLiteral(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 134416, 134437);
                    return return_v;
                }


                int
                f_1558_134482_134491(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 134482, 134491);
                    return return_v;
                }


                char
                f_1558_134562_134567(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 134562, 134567);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_134546_134568(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 134546, 134568);
                    return return_v;
                }


                bool
                f_1558_134671_134688(char
                c)
                {
                    var return_v = c.IsDoubleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 134671, 134688);
                    return return_v;
                }


                System.Management.Automation.Language.TokenFlags
                f_1558_134730_134778(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb, System.Text.StringBuilder
                formatSb, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                nestedTokens)
                {
                    var return_v = this_param.ScanStringExpandable(sb, formatSb, nestedTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 134730, 134778);
                    return return_v;
                }


                bool
                f_1558_134910_134973(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb, System.Text.StringBuilder
                formatSb, bool
                hereString, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                nestedTokens)
                {
                    var return_v = this_param.ScanDollarInStringExpandable(sb, formatSb, hereString, nestedTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 134910, 134973);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_135094_135106(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135094, 135106);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_135125_135143(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135125, 135143);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_135228_135246(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135228, 135246);
                    return return_v;
                }


                int
                f_1558_135297_135308(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135297, 135308);
                    return 0;
                }


                string
                f_1558_135335_135358(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135335, 135358);
                    return return_v;
                }


                int
                f_1558_135377_135395(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 135377, 135395);
                    return return_v;
                }


                string
                f_1558_135471_135500(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135471, 135500);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_135440_135515(System.Management.Automation.Language.Tokenizer
                this_param, string
                value, string
                formatString, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                nestedTokens)
                {
                    var return_v = this_param.NewGenericExpandableToken(value, formatString, nestedTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135440, 135515);
                    return return_v;
                }


                int
                f_1558_135547_135564(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    this_param.Release(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135547, 135564);
                    return 0;
                }


                bool
                f_1558_135585_135620(string
                name)
                {
                    var return_v = DynamicKeyword.ContainsKeyword(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135585, 135620);
                    return return_v;
                }


                bool
                f_1558_135625_135660(string
                name)
                {
                    var return_v = DynamicKeyword.IsHiddenKeyword(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135625, 135660);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_135701_135735(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135701, 135735);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_135774_135794(System.Management.Automation.Language.Tokenizer
                this_param, string
                value)
                {
                    var return_v = this_param.NewGenericToken(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135774, 135794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 131729, 135806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 131729, 135806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ScanHexDigits(StringBuilder sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 135845, 136104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135914, 135934);

                char
                c = f_1558_135923_135933(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 135948, 136093) || true) && (f_1558_135955_135969(c))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 135948, 136093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136003, 136014);

                        f_1558_136003_136013(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136032, 136045);

                        f_1558_136032_136044(sb, c);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136063, 136078);

                        c = f_1558_136067_136077(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 135948, 136093);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 135948, 136093);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 135948, 136093);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 135845, 136104);

                char
                f_1558_135923_135933(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135923, 135933);
                    return return_v;
                }


                bool
                f_1558_135955_135969(char
                c)
                {
                    var return_v = c.IsHexDigit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 135955, 135969);
                    return return_v;
                }


                int
                f_1558_136003_136013(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136003, 136013);
                    return 0;
                }


                System.Text.StringBuilder
                f_1558_136032_136044(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136032, 136044);
                    return return_v;
                }


                char
                f_1558_136067_136077(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136067, 136077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 135845, 136104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 135845, 136104);
            }
        }

        private int ScanDecimalDigits(StringBuilder sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 136116, 136486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136188, 136208);

                int
                countDigits = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136222, 136242);

                char
                c = f_1558_136231_136241(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136256, 136440) || true) && (f_1558_136263_136281(c))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 136256, 136440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136315, 136332);

                        countDigits += 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136350, 136361);

                        f_1558_136350_136360(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136379, 136392);

                        f_1558_136379_136391(sb, c);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136410, 136425);

                        c = f_1558_136414_136424(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 136256, 136440);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 136256, 136440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 136256, 136440);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136456, 136475);

                return countDigits;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 136116, 136486);

                char
                f_1558_136231_136241(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136231, 136241);
                    return return_v;
                }


                bool
                f_1558_136263_136281(char
                c)
                {
                    var return_v = c.IsDecimalDigit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136263, 136281);
                    return return_v;
                }


                int
                f_1558_136350_136360(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136350, 136360);
                    return 0;
                }


                System.Text.StringBuilder
                f_1558_136379_136391(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136379, 136391);
                    return return_v;
                }


                char
                f_1558_136414_136424(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136414, 136424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 136116, 136486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 136116, 136486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ScanBinaryDigits(StringBuilder sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 136498, 136763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136570, 136590);

                char
                c = f_1558_136579_136589(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136604, 136752) || true) && (f_1558_136611_136628(c))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 136604, 136752);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136662, 136673);

                        f_1558_136662_136672(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136691, 136704);

                        f_1558_136691_136703(sb, c);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136722, 136737);

                        c = f_1558_136726_136736(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 136604, 136752);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 136604, 136752);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 136604, 136752);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 136498, 136763);

                char
                f_1558_136579_136589(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136579, 136589);
                    return return_v;
                }


                bool
                f_1558_136611_136628(char
                c)
                {
                    var return_v = c.IsBinaryDigit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136611, 136628);
                    return return_v;
                }


                int
                f_1558_136662_136672(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136662, 136672);
                    return 0;
                }


                System.Text.StringBuilder
                f_1558_136691_136703(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136691, 136703);
                    return return_v;
                }


                char
                f_1558_136726_136736(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136726, 136736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 136498, 136763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 136498, 136763);
            }
        }

        private void ScanExponent(StringBuilder sb, ref int signIndex, ref bool notNumber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 136775, 137464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136882, 136902);

                char
                c = f_1558_136891_136901(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136916, 137341) || true) && (c == '+' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 136920, 136942) || f_1558_136932_136942(c)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 136916, 137341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 136976, 136987);

                    f_1558_136976_136986(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 137273, 137295);

                    signIndex = f_1558_137285_137294(sb);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 137313, 137326);

                    f_1558_137313_137325(sb, c);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 136916, 137341);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 137357, 137453) || true) && (f_1558_137361_137382(this, sb) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 137357, 137453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 137421, 137438);

                    notNumber = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 137357, 137453);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 136775, 137464);

                char
                f_1558_136891_136901(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136891, 136901);
                    return return_v;
                }


                bool
                f_1558_136932_136942(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136932, 136942);
                    return return_v;
                }


                int
                f_1558_136976_136986(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 136976, 136986);
                    return 0;
                }


                int
                f_1558_137285_137294(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 137285, 137294);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_137313_137325(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 137313, 137325);
                    return return_v;
                }


                int
                f_1558_137361_137382(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanDecimalDigits(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 137361, 137382);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 136775, 137464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 136775, 137464);
            }
        }

        private void ScanNumberAfterDot(StringBuilder sb, ref int signIndex, ref bool notNumber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 137476, 138021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 137589, 137611);

                f_1558_137589_137610(this, sb);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 137796, 137816);

                char
                c = f_1558_137805_137815(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 137830, 138010) || true) && (c == 'e' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 137834, 137854) || c == 'E'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 137830, 138010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 137888, 137899);

                    f_1558_137888_137898(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 137917, 137930);

                    f_1558_137917_137929(sb, c);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 137948, 137995);

                    f_1558_137948_137994(this, sb, ref signIndex, ref notNumber);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 137830, 138010);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 137476, 138021);

                int
                f_1558_137589_137610(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanDecimalDigits(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 137589, 137610);
                    return return_v;
                }


                char
                f_1558_137805_137815(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 137805, 137815);
                    return return_v;
                }


                int
                f_1558_137888_137898(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 137888, 137898);
                    return 0;
                }


                System.Text.StringBuilder
                f_1558_137917_137929(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 137917, 137929);
                    return return_v;
                }


                int
                f_1558_137948_137994(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb, ref int
                signIndex, ref bool
                notNumber)
                {
                    this_param.ScanExponent(sb, ref signIndex, ref notNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 137948, 137994);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 137476, 138021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 137476, 138021);
            }
        }

        private static bool TryGetNumberValue(
                    ReadOnlySpan<char> strNum,
                    NumberFormat format,
                    NumberSuffixFlags suffix,
                    bool real,
                    long multiplier,
                    out object result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1558, 138033, 151994);
                decimal d = default(decimal);
                double doubleValue = default(double);
                sbyte sb = default(sbyte);
                byte b = default(byte);
                short s = default(short);
                long l = default(long);
                ushort us = default(ushort);
                uint u = default(uint);
                ulong ul = default(ulong);
                ulong ulValue = default(ulong);
                decimal dm = default(decimal);
                int i = default(int);
                long lValue = default(long);
                decimal dmValue = default(decimal);
                checked
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 138379, 138534);

                        NumberStyles
                        style = NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint |
                                                                 NumberStyles.AllowExponent
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 138558, 143765) || true) && (real)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 138558, 143765);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 138837, 139299) || true) && (suffix == NumberSuffixFlags.Decimal)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 138837, 139299);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 138934, 139183) || true) && (f_1558_138938_139016(strNum, style, f_1558_138970_139000(), out d))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 138934, 139183);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 139082, 139106);

                                    result = d * multiplier;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 139140, 139152);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 138934, 139183);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 139215, 139229);

                                result = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 139259, 139272);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 138837, 139299);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 139327, 143592) || true) && (f_1558_139331_139417(strNum, style, f_1558_139362_139392(), out doubleValue))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 139327, 143592);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 139591, 139749) || true) && (doubleValue == 0.0 && (DynAbs.Tracing.TraceSender.Expression_True(1558, 139595, 139633) && strNum[0] == '-'))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 139591, 139749);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 139699, 139718);

                                    doubleValue = -0.0;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 139591, 139749);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 139781, 139807);

                                doubleValue *= multiplier;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 139837, 143368);

                                switch (suffix)
                                {

                                    case NumberSuffixFlags.None:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 139837, 143368);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 139983, 140004);

                                        result = doubleValue;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 140042, 140054);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 139837, 143368);

                                    case NumberSuffixFlags.SignedByte:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 139837, 143368);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 140160, 140402) || true) && (f_1558_140164_140215(f_1558_140178_140200(doubleValue), out sb))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 140160, 140402);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 140297, 140309);

                                            result = sb;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 140351, 140363);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 140160, 140402);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 140442, 140448);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 139837, 143368);

                                    case NumberSuffixFlags.UnsignedByte:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 139837, 143368);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 140556, 140795) || true) && (f_1558_140560_140609(f_1558_140574_140596(doubleValue), out b))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 140556, 140795);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 140691, 140702);

                                            result = b;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 140744, 140756);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 140556, 140795);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 140835, 140841);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 139837, 143368);

                                    case NumberSuffixFlags.Short:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 139837, 143368);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 140942, 141182) || true) && (f_1558_140946_140996(f_1558_140960_140982(doubleValue), out s))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 140942, 141182);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 141078, 141089);

                                            result = s;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 141131, 141143);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 140942, 141182);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 141222, 141228);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 139837, 143368);

                                    case NumberSuffixFlags.Long:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 139837, 143368);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 141328, 141567) || true) && (f_1558_141332_141381(f_1558_141346_141368(doubleValue), out l))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 141328, 141567);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 141463, 141474);

                                            result = l;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 141516, 141528);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 141328, 141567);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 141607, 141613);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 139837, 143368);

                                    case NumberSuffixFlags.UnsignedShort:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 139837, 143368);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 141722, 141965) || true) && (f_1558_141726_141778(f_1558_141740_141762(doubleValue), out us))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 141722, 141965);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 141860, 141872);

                                            result = us;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 141914, 141926);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 141722, 141965);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 142005, 142011);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 139837, 143368);

                                    case NumberSuffixFlags.Unsigned:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 139837, 143368);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 142115, 142161);

                                        BigInteger
                                        testValue = f_1558_142138_142160(doubleValue)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 142199, 142697) || true) && (f_1558_142203_142239(testValue, out u))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 142199, 142697);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 142321, 142332);

                                            result = u;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 142374, 142386);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 142199, 142697);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 142199, 142697);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 142468, 142697) || true) && (f_1558_142472_142510(testValue, out ul))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 142468, 142697);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 142592, 142604);

                                                result = ul;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 142646, 142658);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 142468, 142697);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 142199, 142697);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 142737, 142743);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 139837, 143368);

                                    case NumberSuffixFlags.UnsignedLong:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 139837, 143368);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 142851, 143103) || true) && (f_1558_142855_142911(f_1558_142869_142891(doubleValue), out ulValue))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 142851, 143103);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 142993, 143010);

                                            result = ulValue;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 143052, 143064);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 142851, 143103);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 143143, 143149);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 139837, 143368);

                                    case NumberSuffixFlags.BigInteger:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 139837, 143368);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 143255, 143287);

                                        result = f_1558_143264_143286(doubleValue);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 143325, 143337);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 139837, 143368);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 143508, 143522);

                                result = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 143552, 143565);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 139327, 143592);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 143689, 143703);

                            result = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 143729, 143742);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 138558, 143765);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 143789, 143809);

                        BigInteger
                        bigValue
                        = default(BigInteger);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 143833, 146916);

                        switch (format)
                        {

                            case NumberFormat.Hex:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 143833, 146916);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 143949, 144363) || true) && (!f_1558_143954_143976(strNum[0]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 143949, 144363);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 144042, 144196) || true) && (strNum[0] == '-')
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 144042, 144196);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 144136, 144161);

                                        multiplier = -multiplier;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 144042, 144196);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 144307, 144332);

                                    strNum = strNum.Slice(1);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 143949, 144363);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 144505, 144708) || true) && (!f_1558_144510_144552(suffix, NumberSuffixFlags.Unsigned) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 144509, 144586) && ((strNum.Length - 1) & 7) == 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 144505, 144708);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 144652, 144677);

                                    strNum = strNum.Slice(1);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 144505, 144708);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 144740, 144779);

                                style = NumberStyles.AllowHexSpecifier;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 144809, 145052) || true) && (!BigInteger.TryParse(strNum, style, f_1558_144849_144879(), out bigValue))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 144809, 145052);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 144960, 144974);

                                    result = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 145008, 145021);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 144809, 145052);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 145203, 145434) || true) && (strNum.Length == 16 && (DynAbs.Tracing.TraceSender.Expression_True(1558, 145207, 145304) && (suffix == NumberSuffixFlags.None || (DynAbs.Tracing.TraceSender.Expression_False(1558, 145231, 145303) || suffix == NumberSuffixFlags.Unsigned))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 145203, 145434);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 145370, 145403);

                                    suffix |= NumberSuffixFlags.Long;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 145203, 145434);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 145466, 145472);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 143833, 146916);

                            case NumberFormat.Binary:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 143833, 146916);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 145553, 145970) || true) && (!f_1558_145558_145583(strNum[0]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 145553, 145970);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 145649, 145803) || true) && (strNum[0] == '-')
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 145649, 145803);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 145743, 145768);

                                        multiplier = -multiplier;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 145649, 145803);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 145914, 145939);

                                    strNum = strNum.Slice(1);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 145553, 145970);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 146002, 146083);

                                bigValue = f_1558_146013_146082(strNum, f_1558_146039_146081(suffix, NumberSuffixFlags.Unsigned));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 146211, 146442) || true) && (strNum.Length == 64 && (DynAbs.Tracing.TraceSender.Expression_True(1558, 146215, 146312) && (suffix == NumberSuffixFlags.None || (DynAbs.Tracing.TraceSender.Expression_False(1558, 146239, 146311) || suffix == NumberSuffixFlags.Unsigned))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 146211, 146442);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 146378, 146411);

                                    suffix |= NumberSuffixFlags.Long;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 146211, 146442);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 146474, 146480);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 143833, 146916);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 143833, 146916);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 146544, 146582);

                                style = NumberStyles.AllowLeadingSign;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 146612, 146855) || true) && (!BigInteger.TryParse(strNum, style, f_1558_146652_146682(), out bigValue))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 146612, 146855);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 146763, 146777);

                                    result = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 146811, 146824);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 146612, 146855);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 146887, 146893);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 143833, 146916);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 147027, 147050);

                        bigValue *= multiplier;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 147074, 151642);

                        switch (suffix)
                        {

                            case NumberSuffixFlags.SignedByte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 147074, 151642);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 147202, 147398) || true) && (f_1558_147206_147243(bigValue, out sb))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 147202, 147398);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 147309, 147321);

                                    result = sb;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 147355, 147367);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 147202, 147398);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 147430, 147436);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 147074, 151642);

                            case NumberSuffixFlags.UnsignedByte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 147074, 151642);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 147528, 147721) || true) && (f_1558_147532_147567(bigValue, out b))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 147528, 147721);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 147633, 147644);

                                    result = b;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 147678, 147690);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 147528, 147721);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 147753, 147759);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 147074, 151642);

                            case NumberSuffixFlags.Short:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 147074, 151642);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 147844, 148038) || true) && (f_1558_147848_147884(bigValue, out s))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 147844, 148038);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 147950, 147961);

                                    result = s;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 147995, 148007);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 147844, 148038);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 148070, 148076);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 147074, 151642);

                            case NumberSuffixFlags.Long:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 147074, 151642);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 148160, 148353) || true) && (f_1558_148164_148199(bigValue, out l))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 148160, 148353);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 148265, 148276);

                                    result = l;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 148310, 148322);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 148160, 148353);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 148385, 148391);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 147074, 151642);

                            case NumberSuffixFlags.UnsignedShort:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 147074, 151642);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 148484, 148681) || true) && (f_1558_148488_148526(bigValue, out us))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 148484, 148681);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 148592, 148604);

                                    result = us;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 148638, 148650);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 148484, 148681);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 148713, 148719);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 147074, 151642);

                            case NumberSuffixFlags.Unsigned:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 147074, 151642);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 148807, 149231) || true) && (f_1558_148811_148846(bigValue, out u))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 148807, 149231);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 148912, 148923);

                                    result = u;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 148957, 148969);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 148807, 149231);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 148807, 149231);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 149035, 149231) || true) && (f_1558_149039_149076(bigValue, out ul))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 149035, 149231);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 149142, 149154);

                                        result = ul;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 149188, 149200);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 149035, 149231);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 148807, 149231);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 149263, 149269);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 147074, 151642);

                            case NumberSuffixFlags.UnsignedLong:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 147074, 151642);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 149361, 149567) || true) && (f_1558_149365_149407(bigValue, out ulValue))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 149361, 149567);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 149473, 149490);

                                    result = ulValue;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 149524, 149536);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 149361, 149567);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 149599, 149605);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 147074, 151642);

                            case NumberSuffixFlags.Decimal:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 147074, 151642);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 149692, 149890) || true) && (f_1558_149696_149735(bigValue, out dm))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 149692, 149890);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 149801, 149813);

                                    result = dm;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 149847, 149859);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 149692, 149890);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 149922, 149928);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 147074, 151642);

                            case NumberSuffixFlags.BigInteger:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 147074, 151642);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 150018, 150036);

                                result = bigValue;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 150066, 150078);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 147074, 151642);

                            case NumberSuffixFlags.None:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 147074, 151642);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 150276, 150468) || true) && (f_1558_150280_150314(bigValue, out i))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 150276, 150468);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 150380, 150391);

                                    result = i;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 150425, 150437);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 150276, 150468);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 150500, 150703) || true) && (f_1558_150504_150544(bigValue, out lValue))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 150500, 150703);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 150610, 150626);

                                    result = lValue;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 150660, 150672);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 150500, 150703);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 150834, 151436) || true) && (format == NumberFormat.Decimal)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 150834, 151436);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 150934, 151158) || true) && (f_1558_150938_150982(bigValue, out dmValue))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 150934, 151158);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 151056, 151073);

                                        result = dmValue;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 151111, 151123);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 150934, 151158);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 151194, 151405) || true) && (f_1558_151198_151235(bigValue, out d))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 151194, 151405);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 151309, 151320);

                                        result = d;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 151358, 151370);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 151194, 151405);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 150834, 151436);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 151562, 151576);

                                result = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 151606, 151619);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 147074, 151642);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 151770, 151784);

                        result = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 151806, 151819);

                        return false;
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1558, 151856, 151911);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1558, 151856, 151911);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 151942, 151956);

                result = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 151970, 151983);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1558, 138033, 151994);

                System.Globalization.NumberFormatInfo
                f_1558_138970_139000()
                {
                    var return_v = NumberFormatInfo.InvariantInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 138970, 139000);
                    return return_v;
                }


                bool
                f_1558_138938_139016(System.ReadOnlySpan<char>
                s, System.Globalization.NumberStyles
                style, System.Globalization.NumberFormatInfo
                provider, out decimal
                result)
                {
                    var return_v = decimal.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 138938, 139016);
                    return return_v;
                }


                System.Globalization.NumberFormatInfo
                f_1558_139362_139392()
                {
                    var return_v = NumberFormatInfo.InvariantInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 139362, 139392);
                    return return_v;
                }


                bool
                f_1558_139331_139417(System.ReadOnlySpan<char>
                s, System.Globalization.NumberStyles
                style, System.Globalization.NumberFormatInfo
                provider, out double
                result)
                {
                    var return_v = double.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 139331, 139417);
                    return return_v;
                }


                System.Numerics.BigInteger
                f_1558_140178_140200(double
                d)
                {
                    var return_v = d.AsBigInt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 140178, 140200);
                    return return_v;
                }


                bool
                f_1558_140164_140215(System.Numerics.BigInteger
                value, out sbyte
                sb)
                {
                    var return_v = Utils.TryCast(value, out sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 140164, 140215);
                    return return_v;
                }


                System.Numerics.BigInteger
                f_1558_140574_140596(double
                d)
                {
                    var return_v = d.AsBigInt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 140574, 140596);
                    return return_v;
                }


                bool
                f_1558_140560_140609(System.Numerics.BigInteger
                value, out byte
                b)
                {
                    var return_v = Utils.TryCast(value, out b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 140560, 140609);
                    return return_v;
                }


                System.Numerics.BigInteger
                f_1558_140960_140982(double
                d)
                {
                    var return_v = d.AsBigInt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 140960, 140982);
                    return return_v;
                }


                bool
                f_1558_140946_140996(System.Numerics.BigInteger
                value, out short
                s)
                {
                    var return_v = Utils.TryCast(value, out s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 140946, 140996);
                    return return_v;
                }


                System.Numerics.BigInteger
                f_1558_141346_141368(double
                d)
                {
                    var return_v = d.AsBigInt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 141346, 141368);
                    return return_v;
                }


                bool
                f_1558_141332_141381(System.Numerics.BigInteger
                value, out long
                l)
                {
                    var return_v = Utils.TryCast(value, out l);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 141332, 141381);
                    return return_v;
                }


                System.Numerics.BigInteger
                f_1558_141740_141762(double
                d)
                {
                    var return_v = d.AsBigInt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 141740, 141762);
                    return return_v;
                }


                bool
                f_1558_141726_141778(System.Numerics.BigInteger
                value, out ushort
                us)
                {
                    var return_v = Utils.TryCast(value, out us);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 141726, 141778);
                    return return_v;
                }


                System.Numerics.BigInteger
                f_1558_142138_142160(double
                d)
                {
                    var return_v = d.AsBigInt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 142138, 142160);
                    return return_v;
                }


                bool
                f_1558_142203_142239(System.Numerics.BigInteger
                value, out uint
                u)
                {
                    var return_v = Utils.TryCast(value, out u);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 142203, 142239);
                    return return_v;
                }


                bool
                f_1558_142472_142510(System.Numerics.BigInteger
                value, out ulong
                ul)
                {
                    var return_v = Utils.TryCast(value, out ul);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 142472, 142510);
                    return return_v;
                }


                System.Numerics.BigInteger
                f_1558_142869_142891(double
                d)
                {
                    var return_v = d.AsBigInt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 142869, 142891);
                    return return_v;
                }


                bool
                f_1558_142855_142911(System.Numerics.BigInteger
                value, out ulong
                ul)
                {
                    var return_v = Utils.TryCast(value, out ul);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 142855, 142911);
                    return return_v;
                }


                System.Numerics.BigInteger
                f_1558_143264_143286(double
                d)
                {
                    var return_v = d.AsBigInt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 143264, 143286);
                    return return_v;
                }


                bool
                f_1558_143954_143976(char
                c)
                {
                    var return_v = c.IsHexDigit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 143954, 143976);
                    return return_v;
                }


                bool
                f_1558_144510_144552(System.Management.Automation.Language.NumberSuffixFlags
                this_param, System.Management.Automation.Language.NumberSuffixFlags
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 144510, 144552);
                    return return_v;
                }


                System.Globalization.NumberFormatInfo
                f_1558_144849_144879()
                {
                    var return_v = NumberFormatInfo.InvariantInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 144849, 144879);
                    return return_v;
                }


                bool
                f_1558_145558_145583(char
                c)
                {
                    var return_v = c.IsBinaryDigit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 145558, 145583);
                    return return_v;
                }


                bool
                f_1558_146039_146081(System.Management.Automation.Language.NumberSuffixFlags
                this_param, System.Management.Automation.Language.NumberSuffixFlags
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 146039, 146081);
                    return return_v;
                }


                System.Numerics.BigInteger
                f_1558_146013_146082(System.ReadOnlySpan<char>
                digits, bool
                unsigned)
                {
                    var return_v = Utils.ParseBinary(digits, unsigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 146013, 146082);
                    return return_v;
                }


                System.Globalization.NumberFormatInfo
                f_1558_146652_146682()
                {
                    var return_v = NumberFormatInfo.InvariantInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 146652, 146682);
                    return return_v;
                }


                bool
                f_1558_147206_147243(System.Numerics.BigInteger
                value, out sbyte
                sb)
                {
                    var return_v = Utils.TryCast(value, out sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 147206, 147243);
                    return return_v;
                }


                bool
                f_1558_147532_147567(System.Numerics.BigInteger
                value, out byte
                b)
                {
                    var return_v = Utils.TryCast(value, out b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 147532, 147567);
                    return return_v;
                }


                bool
                f_1558_147848_147884(System.Numerics.BigInteger
                value, out short
                s)
                {
                    var return_v = Utils.TryCast(value, out s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 147848, 147884);
                    return return_v;
                }


                bool
                f_1558_148164_148199(System.Numerics.BigInteger
                value, out long
                l)
                {
                    var return_v = Utils.TryCast(value, out l);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 148164, 148199);
                    return return_v;
                }


                bool
                f_1558_148488_148526(System.Numerics.BigInteger
                value, out ushort
                us)
                {
                    var return_v = Utils.TryCast(value, out us);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 148488, 148526);
                    return return_v;
                }


                bool
                f_1558_148811_148846(System.Numerics.BigInteger
                value, out uint
                u)
                {
                    var return_v = Utils.TryCast(value, out u);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 148811, 148846);
                    return return_v;
                }


                bool
                f_1558_149039_149076(System.Numerics.BigInteger
                value, out ulong
                ul)
                {
                    var return_v = Utils.TryCast(value, out ul);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 149039, 149076);
                    return return_v;
                }


                bool
                f_1558_149365_149407(System.Numerics.BigInteger
                value, out ulong
                ul)
                {
                    var return_v = Utils.TryCast(value, out ul);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 149365, 149407);
                    return return_v;
                }


                bool
                f_1558_149696_149735(System.Numerics.BigInteger
                value, out decimal
                dm)
                {
                    var return_v = Utils.TryCast(value, out dm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 149696, 149735);
                    return return_v;
                }


                bool
                f_1558_150280_150314(System.Numerics.BigInteger
                value, out int
                i)
                {
                    var return_v = Utils.TryCast(value, out i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 150280, 150314);
                    return return_v;
                }


                bool
                f_1558_150504_150544(System.Numerics.BigInteger
                value, out long
                l)
                {
                    var return_v = Utils.TryCast(value, out l);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 150504, 150544);
                    return return_v;
                }


                bool
                f_1558_150938_150982(System.Numerics.BigInteger
                value, out decimal
                dm)
                {
                    var return_v = Utils.TryCast(value, out dm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 150938, 150982);
                    return return_v;
                }


                bool
                f_1558_151198_151235(System.Numerics.BigInteger
                value, out decimal
                db)
                {
                    var return_v = Utils.TryCast(value, out db);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 151198, 151235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 138033, 151994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 138033, 151994);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token ScanNumber(char firstChar)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 152006, 153563);
                System.Management.Automation.Language.NumberFormat format = default(System.Management.Automation.Language.NumberFormat);
                System.Management.Automation.Language.NumberSuffixFlags suffix = default(System.Management.Automation.Language.NumberSuffixFlags);
                bool real = default(bool);
                long multiplier = default(long);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 152071, 152299);

                f_1558_152071_152298(firstChar == '.' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 152108, 152166) || (firstChar >= '0' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 152129, 152165) && firstChar <= '9'))
                ) || (DynAbs.Tracing.TraceSender.Expression_False(1558, 152108, 152251) || (f_1558_152188_152206() && (DynAbs.Tracing.TraceSender.Expression_True(1558, 152188, 152250) && (firstChar == '+' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 152211, 152249) || f_1558_152231_152249(firstChar)))))), "Number must start with '.', '-', or digit.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 152315, 152450);

                string
                strNum = f_1558_152331_152449(this, firstChar, out format, out suffix, out real, out multiplier)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 152522, 152799) || true) && (strNum == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 152522, 152799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 152694, 152722);

                    _currentIndex = _tokenStart;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 152740, 152784);

                    return f_1558_152747_152783(this, f_1558_152764_152782(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 152522, 152799);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 152815, 152828);

                object
                value
                = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 152842, 153507) || true) && (!f_1558_152847_152917(strNum, format, suffix, real, multiplier, out value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 152842, 153507);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 152951, 153245) || true) && (!f_1558_152956_152974(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 152951, 153245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 153132, 153160);

                        _currentIndex = _tokenStart;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 153182, 153226);

                        return f_1558_153189_153225(this, f_1558_153206_153224(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 152951, 153245);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 153265, 153492);

                    f_1558_153265_153491(this, _currentIndex, nameof(ParserStrings.BadNumericConstant), f_1558_153376_153408(), f_1558_153431_153490(_script, _tokenStart, _currentIndex - _tokenStart));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 152842, 153507);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 153523, 153552);

                return f_1558_153530_153551(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 152006, 153563);

                bool
                f_1558_152188_152206()
                {
                    var return_v = AllowSignedNumbers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 152188, 152206);
                    return return_v;
                }


                bool
                f_1558_152231_152249(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 152231, 152249);
                    return return_v;
                }


                int
                f_1558_152071_152298(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 152071, 152298);
                    return 0;
                }


                string
                f_1558_152331_152449(System.Management.Automation.Language.Tokenizer
                this_param, char
                firstChar, out System.Management.Automation.Language.NumberFormat
                format, out System.Management.Automation.Language.NumberSuffixFlags
                suffix, out bool
                real, out long
                multiplier)
                {
                    var return_v = this_param.ScanNumberHelper(firstChar, out format, out suffix, out real, out multiplier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 152331, 152449);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_152764_152782(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 152764, 152782);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_152747_152783(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanGenericToken(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 152747, 152783);
                    return return_v;
                }


                bool
                f_1558_152847_152917(string
                strNum, System.Management.Automation.Language.NumberFormat
                format, System.Management.Automation.Language.NumberSuffixFlags
                suffix, bool
                real, long
                multiplier, out object
                result)
                {
                    var return_v = TryGetNumberValue((System.ReadOnlySpan<char>)strNum, format, suffix, real, multiplier, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 152847, 152917);
                    return return_v;
                }


                bool
                f_1558_152956_152974(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InExpressionMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 152956, 152974);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_153206_153224(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 153206, 153224);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_153189_153225(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanGenericToken(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 153189, 153225);
                    return return_v;
                }


                string
                f_1558_153376_153408()
                {
                    var return_v = ParserStrings.BadNumericConstant;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 153376, 153408);
                    return return_v;
                }


                string
                f_1558_153431_153490(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 153431, 153490);
                    return return_v;
                }


                int
                f_1558_153265_153491(System.Management.Automation.Language.Tokenizer
                this_param, int
                errorOffset, string
                errorId, string
                errorMsg, params object[]
                args)
                {
                    this_param.ReportError(errorOffset, errorId, errorMsg, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 153265, 153491);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_153530_153551(System.Management.Automation.Language.Tokenizer
                this_param, object
                value)
                {
                    var return_v = this_param.NewNumberToken(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 153530, 153551);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 152006, 153563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 152006, 153563);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string ScanNumberHelper(char firstChar, out NumberFormat format, out NumberSuffixFlags suffix, out bool real, out long multiplier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 154258, 162159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154421, 154451);

                format = NumberFormat.Decimal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154465, 154497);

                suffix = NumberSuffixFlags.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154511, 154524);

                real = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154538, 154553);

                multiplier = 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154569, 154592);

                bool
                notNumber = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154606, 154625);

                int
                signIndex = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154639, 154646);

                char
                c
                = default(char);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154660, 154688);

                var
                sb = f_1558_154669_154687(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154704, 154856) || true) && (f_1558_154708_154726(firstChar) || (DynAbs.Tracing.TraceSender.Expression_False(1558, 154708, 154746) || firstChar == '+'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 154704, 154856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154780, 154801);

                    f_1558_154780_154800(sb, firstChar);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154819, 154841);

                    firstChar = f_1558_154831_154840(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 154704, 154856);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154872, 157584) || true) && (firstChar == '.')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 154872, 157584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154926, 154941);

                    f_1558_154926_154940(sb, '.');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 154959, 155012);

                    f_1558_154959_155011(this, sb, ref signIndex, ref notNumber);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 155030, 155042);

                    real = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 154872, 157584);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 154872, 157584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 155108, 155123);

                    c = f_1558_155112_155122(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 155141, 155229);

                    bool
                    isHexOrBinary = firstChar == '0' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 155162, 155228) && (c == 'x' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 155183, 155203) || c == 'X') || (DynAbs.Tracing.TraceSender.Expression_False(1558, 155183, 155215) || c == 'b') || (DynAbs.Tracing.TraceSender.Expression_False(1558, 155183, 155227) || c == 'B')))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 155249, 157569) || true) && (isHexOrBinary)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 155249, 157569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 155308, 155319);

                        f_1558_155308_155318(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 155343, 156263);

                        switch (c)
                        {

                            case 'x':
                            case 'X':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 155343, 156263);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 155476, 155491);

                                f_1558_155476_155490(sb, '0');
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 155586, 155604);

                                f_1558_155586_155603(this, sb);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 155634, 155766) || true) && (f_1558_155638_155647(sb) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 155634, 155766);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 155718, 155735);

                                    notNumber = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 155634, 155766);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 155798, 155824);

                                format = NumberFormat.Hex;
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 155854, 155860);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 155343, 156263);

                            case 'b':
                            case 'B':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 155343, 156263);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 155960, 155981);

                                f_1558_155960_155980(this, sb);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 156011, 156143) || true) && (f_1558_156015_156024(sb) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 156011, 156143);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 156095, 156112);

                                    notNumber = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 156011, 156143);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 156175, 156204);

                                format = NumberFormat.Binary;
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 156234, 156240);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 155343, 156263);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 155249, 157569);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 155249, 157569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 156345, 156366);

                        f_1558_156345_156365(sb, firstChar);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 156388, 156410);

                        f_1558_156388_156409(this, sb);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 156432, 156447);

                        c = f_1558_156436_156446(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 156469, 157550);

                        switch (c)
                        {

                            case '.':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 156469, 157550);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 156567, 156578);

                                f_1558_156567_156577(this);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 156608, 157180) || true) && (f_1558_156612_156622(this) == '.')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 156608, 157180);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 156861, 156873);

                                    f_1558_156861_156872(this);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 156608, 157180);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 156608, 157180);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 157003, 157016);

                                    f_1558_157003_157015(sb, c);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 157050, 157062);

                                    real = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 157096, 157149);

                                    f_1558_157096_157148(this, sb, ref signIndex, ref notNumber);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 156608, 157180);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 157212, 157218);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 156469, 157550);

                            case 'E':
                            case 'e':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 156469, 157550);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 157318, 157329);

                                f_1558_157318_157328(this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 157359, 157372);

                                f_1558_157359_157371(sb, c);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 157402, 157414);

                                real = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 157444, 157491);

                                f_1558_157444_157490(this, sb, ref signIndex, ref notNumber);
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 157521, 157527);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 156469, 157550);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 155249, 157569);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 154872, 157584);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 157600, 157615);

                c = f_1558_157604_157614(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 157629, 160153) || true) && (f_1558_157633_157649(c))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 157629, 160153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 157683, 157694);

                    f_1558_157683_157693(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 157712, 158803);

                    switch (c)
                    {

                        case 'u':
                        case 'U':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 157712, 158803);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 157829, 157866);

                            suffix |= NumberSuffixFlags.Unsigned;
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 157892, 157898);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 157712, 158803);

                        case 's':
                        case 'S':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 157712, 158803);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 157986, 158020);

                            suffix |= NumberSuffixFlags.Short;
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 158046, 158052);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 157712, 158803);

                        case 'l':
                        case 'L':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 157712, 158803);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 158140, 158173);

                            suffix |= NumberSuffixFlags.Long;
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 158199, 158205);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 157712, 158803);

                        case 'd':
                        case 'D':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 157712, 158803);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 158293, 158329);

                            suffix |= NumberSuffixFlags.Decimal;
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 158355, 158361);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 157712, 158803);

                        case 'y':
                        case 'Y':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 157712, 158803);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 158449, 158488);

                            suffix |= NumberSuffixFlags.SignedByte;
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 158514, 158520);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 157712, 158803);

                        case 'n':
                        case 'N':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 157712, 158803);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 158608, 158647);

                            suffix |= NumberSuffixFlags.BigInteger;
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 158673, 158679);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 157712, 158803);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 157712, 158803);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 158735, 158752);

                            notNumber = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 158778, 158784);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 157712, 158803);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 158823, 158838);

                    c = f_1558_158827_158837(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 158858, 160138) || true) && (f_1558_158862_158878(c))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 158858, 160138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 158920, 158931);

                        f_1558_158920_158930(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 158953, 160080);

                        switch (suffix)
                        {

                            case NumberSuffixFlags.Unsigned:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 158953, 160080);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 159079, 159902);

                                switch (c)
                                {

                                    case 'l':
                                    case 'L':
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 159079, 159902);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 159244, 159277);

                                        suffix |= NumberSuffixFlags.Long;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 159315, 159321);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 159079, 159902);

                                    case 's':
                                    case 'S':
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 159079, 159902);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 159445, 159479);

                                        suffix |= NumberSuffixFlags.Short;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 159517, 159523);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 159079, 159902);

                                    case 'y':
                                    case 'Y':
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 159079, 159902);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 159647, 159686);

                                        suffix |= NumberSuffixFlags.SignedByte;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 159724, 159730);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 159079, 159902);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 159079, 159902);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 159810, 159827);

                                        notNumber = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 159865, 159871);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 159079, 159902);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 159934, 159940);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 158953, 160080);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 158953, 160080);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 160004, 160021);

                                notNumber = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 160051, 160057);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 158953, 160080);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 160104, 160119);

                        c = f_1558_160108_160118(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 158858, 160138);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 157629, 160153);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 160169, 161377) || true) && (f_1558_160173_160194(c))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 160169, 161377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 160228, 160239);

                    f_1558_160228_160238(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 160259, 161069);

                    switch (c)
                    {

                        case 'k':
                        case 'K':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 160259, 161069);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 160376, 160394);

                            multiplier = 1024;
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 160420, 160426);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 160259, 161069);

                        case 'm':
                        case 'M':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 160259, 161069);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 160514, 160539);

                            multiplier = 1024 * 1024;
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 160565, 160571);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 160259, 161069);

                        case 'g':
                        case 'G':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 160259, 161069);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 160659, 160691);

                            multiplier = 1024 * 1024 * 1024;
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 160717, 160723);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 160259, 161069);

                        case 't':
                        case 'T':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 160259, 161069);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 160811, 160851);

                            multiplier = 1024L * 1024 * 1024 * 1024;
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 160877, 160883);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 160259, 161069);

                        case 'p':
                        case 'P':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 160259, 161069);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 160971, 161018);

                            multiplier = 1024L * 1024 * 1024 * 1024 * 1024;
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 161044, 161050);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 160259, 161069);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 161089, 161110);

                    char
                    c1 = f_1558_161099_161109(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 161128, 161362) || true) && (c1 == 'b' || (DynAbs.Tracing.TraceSender.Expression_False(1558, 161132, 161154) || c1 == 'B'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 161128, 161362);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 161196, 161207);

                        f_1558_161196_161206(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 161229, 161244);

                        c = f_1558_161233_161243(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 161128, 161362);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 161128, 161362);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 161326, 161343);

                        notNumber = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 161128, 161362);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 160169, 161377);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 161393, 161638) || true) && (!f_1558_161398_161420(c))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 161393, 161638);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 161454, 161623) || true) && (!f_1558_161459_161477(this) || (DynAbs.Tracing.TraceSender.Expression_False(1558, 161458, 161545) || !f_1558_161482_161545(c, f_1558_161514_161544())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 161454, 161623);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 161587, 161604);

                        notNumber = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 161454, 161623);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 161393, 161638);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 161654, 161758) || true) && (notNumber)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 161654, 161758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 161701, 161713);

                    f_1558_161701_161712(this, sb);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 161731, 161743);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 161654, 161758);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 161852, 161990) || true) && (signIndex != -1 && (DynAbs.Tracing.TraceSender.Expression_True(1558, 161856, 161895) && f_1558_161875_161888(sb, signIndex) != '-') && (DynAbs.Tracing.TraceSender.Expression_True(1558, 161856, 161921) && f_1558_161899_161921(f_1558_161899_161912(sb, signIndex))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 161852, 161990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 161955, 161975);

                    sb[signIndex] = '-';
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 161852, 161990);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162006, 162101) || true) && (f_1558_162010_162015(sb, 0) != '-' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 162010, 162040) && f_1558_162026_162040(f_1558_162026_162031(sb, 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 162006, 162101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162074, 162086);

                    sb[0] = '-';
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 162006, 162101);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162117, 162148);

                return f_1558_162124_162147(this, sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 154258, 162159);

                System.Text.StringBuilder
                f_1558_154669_154687(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 154669, 154687);
                    return return_v;
                }


                bool
                f_1558_154708_154726(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 154708, 154726);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_154780_154800(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 154780, 154800);
                    return return_v;
                }


                char
                f_1558_154831_154840(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 154831, 154840);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_154926_154940(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 154926, 154940);
                    return return_v;
                }


                int
                f_1558_154959_155011(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb, ref int
                signIndex, ref bool
                notNumber)
                {
                    this_param.ScanNumberAfterDot(sb, ref signIndex, ref notNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 154959, 155011);
                    return 0;
                }


                char
                f_1558_155112_155122(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 155112, 155122);
                    return return_v;
                }


                int
                f_1558_155308_155318(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 155308, 155318);
                    return 0;
                }


                System.Text.StringBuilder
                f_1558_155476_155490(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 155476, 155490);
                    return return_v;
                }


                int
                f_1558_155586_155603(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    this_param.ScanHexDigits(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 155586, 155603);
                    return 0;
                }


                int
                f_1558_155638_155647(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 155638, 155647);
                    return return_v;
                }


                int
                f_1558_155960_155980(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    this_param.ScanBinaryDigits(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 155960, 155980);
                    return 0;
                }


                int
                f_1558_156015_156024(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 156015, 156024);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_156345_156365(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 156345, 156365);
                    return return_v;
                }


                int
                f_1558_156388_156409(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanDecimalDigits(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 156388, 156409);
                    return return_v;
                }


                char
                f_1558_156436_156446(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 156436, 156446);
                    return return_v;
                }


                int
                f_1558_156567_156577(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 156567, 156577);
                    return 0;
                }


                char
                f_1558_156612_156622(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 156612, 156622);
                    return return_v;
                }


                int
                f_1558_156861_156872(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 156861, 156872);
                    return 0;
                }


                System.Text.StringBuilder
                f_1558_157003_157015(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 157003, 157015);
                    return return_v;
                }


                int
                f_1558_157096_157148(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb, ref int
                signIndex, ref bool
                notNumber)
                {
                    this_param.ScanNumberAfterDot(sb, ref signIndex, ref notNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 157096, 157148);
                    return 0;
                }


                int
                f_1558_157318_157328(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 157318, 157328);
                    return 0;
                }


                System.Text.StringBuilder
                f_1558_157359_157371(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 157359, 157371);
                    return return_v;
                }


                int
                f_1558_157444_157490(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb, ref int
                signIndex, ref bool
                notNumber)
                {
                    this_param.ScanExponent(sb, ref signIndex, ref notNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 157444, 157490);
                    return 0;
                }


                char
                f_1558_157604_157614(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 157604, 157614);
                    return return_v;
                }


                bool
                f_1558_157633_157649(char
                c)
                {
                    var return_v = c.IsTypeSuffix();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 157633, 157649);
                    return return_v;
                }


                int
                f_1558_157683_157693(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 157683, 157693);
                    return 0;
                }


                char
                f_1558_158827_158837(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 158827, 158837);
                    return return_v;
                }


                bool
                f_1558_158862_158878(char
                c)
                {
                    var return_v = c.IsTypeSuffix();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 158862, 158878);
                    return return_v;
                }


                int
                f_1558_158920_158930(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 158920, 158930);
                    return 0;
                }


                char
                f_1558_160108_160118(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 160108, 160118);
                    return return_v;
                }


                bool
                f_1558_160173_160194(char
                c)
                {
                    var return_v = c.IsMultiplierStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 160173, 160194);
                    return return_v;
                }


                int
                f_1558_160228_160238(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 160228, 160238);
                    return 0;
                }


                char
                f_1558_161099_161109(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 161099, 161109);
                    return return_v;
                }


                int
                f_1558_161196_161206(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 161196, 161206);
                    return 0;
                }


                char
                f_1558_161233_161243(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 161233, 161243);
                    return return_v;
                }


                bool
                f_1558_161398_161420(char
                c)
                {
                    var return_v = c.ForceStartNewToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 161398, 161420);
                    return return_v;
                }


                bool
                f_1558_161459_161477(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InExpressionMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 161459, 161477);
                    return return_v;
                }


                bool
                f_1558_161514_161544()
                {
                    var return_v = ForceEndNumberOnTernaryOpChars;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 161514, 161544);
                    return return_v;
                }


                bool
                f_1558_161482_161545(char
                c, bool
                forceEndNumberOnTernaryOperatorChars)
                {
                    var return_v = c.ForceStartNewTokenAfterNumber(forceEndNumberOnTernaryOperatorChars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 161482, 161545);
                    return return_v;
                }


                int
                f_1558_161701_161712(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    this_param.Release(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 161701, 161712);
                    return 0;
                }


                char
                f_1558_161875_161888(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 161875, 161888);
                    return return_v;
                }


                char
                f_1558_161899_161912(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 161899, 161912);
                    return return_v;
                }


                bool
                f_1558_161899_161921(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 161899, 161921);
                    return return_v;
                }


                char
                f_1558_162010_162015(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 162010, 162015);
                    return return_v;
                }


                char
                f_1558_162026_162031(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 162026, 162031);
                    return return_v;
                }


                bool
                f_1558_162026_162040(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 162026, 162040);
                    return return_v;
                }


                string
                f_1558_162124_162147(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 162124, 162147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 154258, 162159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 154258, 162159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Token GetMemberAccessOperator(bool allowLBracket)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 162201, 165135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162499, 162519);

                char
                c = f_1558_162508_162518(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162535, 162973) || true) && (c == '<')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 162535, 162973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162584, 162612);

                        _tokenStart = _currentIndex;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162630, 162641);

                        f_1558_162630_162640(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162659, 162958) || true) && (f_1558_162663_162673(this) == '#')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 162659, 162958);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162722, 162733);

                            f_1558_162722_162732(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162755, 162774);

                            f_1558_162755_162773(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162796, 162811);

                            c = f_1558_162800_162810(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 162659, 162958);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 162659, 162958);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162893, 162905);

                            f_1558_162893_162904(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162927, 162939);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 162659, 162958);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 162535, 162973);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 162535, 162973);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 162535, 162973);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 162989, 163551) || true) && (c == '.')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 162989, 163551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163035, 163063);

                    _tokenStart = _currentIndex;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163081, 163092);

                    f_1558_163081_163091(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163110, 163125);

                    c = f_1558_163114_163124(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163143, 163474) || true) && (c != '.')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 163143, 163474);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163197, 163400) || true) && (f_1558_163201_163216(this) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 163201, 163277) && (f_1558_163221_163237(c) || (DynAbs.Tracing.TraceSender.Expression_False(1558, 163221, 163250) || c == '\0') || (DynAbs.Tracing.TraceSender.Expression_False(1558, 163221, 163263) || c == '\r') || (DynAbs.Tracing.TraceSender.Expression_False(1558, 163221, 163276) || c == '\n'))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 163197, 163400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163327, 163339);

                            f_1558_163327_163338(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163365, 163377);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 163197, 163400);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163424, 163455);

                        return f_1558_163431_163454(this, TokenKind.Dot);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 163143, 163474);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163494, 163506);

                    f_1558_163494_163505(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163524, 163536);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 162989, 163551);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163567, 164244) || true) && (c == ':')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 163567, 164244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163613, 163641);

                    _tokenStart = _currentIndex;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163659, 163670);

                    f_1558_163659_163669(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163688, 163703);

                    c = f_1558_163692_163702(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163721, 164167) || true) && (c == ':')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 163721, 164167);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163775, 163786);

                        f_1558_163775_163785(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163808, 163823);

                        c = f_1558_163812_163822(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163845, 164086) || true) && (f_1558_163849_163864(this) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 163849, 163925) && (f_1558_163869_163885(c) || (DynAbs.Tracing.TraceSender.Expression_False(1558, 163869, 163898) || c == '\0') || (DynAbs.Tracing.TraceSender.Expression_False(1558, 163869, 163911) || c == '\r') || (DynAbs.Tracing.TraceSender.Expression_False(1558, 163869, 163924) || c == '\n'))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 163845, 164086);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 163975, 163987);

                            f_1558_163975_163986(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164013, 164025);

                            f_1558_164013_164024(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164051, 164063);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 163845, 164086);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164110, 164148);

                        return f_1558_164117_164147(this, TokenKind.ColonColon);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 163721, 164167);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164187, 164199);

                    f_1558_164187_164198(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164217, 164229);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 163567, 164244);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164260, 164449) || true) && (c == '[' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 164264, 164289) && allowLBracket))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 164260, 164449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164323, 164351);

                    _tokenStart = _currentIndex;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164369, 164380);

                    f_1558_164369_164379(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164398, 164434);

                    return f_1558_164405_164433(this, TokenKind.LBracket);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 164260, 164449);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164467, 165096) || true) && (f_1558_164471_164530("PSNullConditionalOperators") && (DynAbs.Tracing.TraceSender.Expression_True(1558, 164471, 164542) && c == '?'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 164467, 165096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164576, 164604);

                    _tokenStart = _currentIndex;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164622, 164633);

                    f_1558_164622_164632(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164651, 164666);

                    c = f_1558_164655_164665(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164684, 165019) || true) && (c == '.')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 164684, 165019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164738, 164749);

                        f_1558_164738_164748(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164771, 164810);

                        return f_1558_164778_164809(this, TokenKind.QuestionDot);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 164684, 165019);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 164684, 165019);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164852, 165019) || true) && (c == '[' && (DynAbs.Tracing.TraceSender.Expression_True(1558, 164856, 164881) && allowLBracket))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 164852, 165019);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164923, 164934);

                            f_1558_164923_164933(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 164956, 165000);

                            return f_1558_164963_164999(this, TokenKind.QuestionLBracket);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 164852, 165019);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 164684, 165019);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 165039, 165051);

                    f_1558_165039_165050(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 165069, 165081);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 164467, 165096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 165112, 165124);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 162201, 165135);

                char
                f_1558_162508_162518(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 162508, 162518);
                    return return_v;
                }


                int
                f_1558_162630_162640(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 162630, 162640);
                    return 0;
                }


                char
                f_1558_162663_162673(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 162663, 162673);
                    return return_v;
                }


                int
                f_1558_162722_162732(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 162722, 162732);
                    return 0;
                }


                int
                f_1558_162755_162773(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.ScanBlockComment();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 162755, 162773);
                    return 0;
                }


                char
                f_1558_162800_162810(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 162800, 162810);
                    return return_v;
                }


                int
                f_1558_162893_162904(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 162893, 162904);
                    return 0;
                }


                int
                f_1558_163081_163091(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163081, 163091);
                    return 0;
                }


                char
                f_1558_163114_163124(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163114, 163124);
                    return return_v;
                }


                bool
                f_1558_163201_163216(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InCommandMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163201, 163216);
                    return return_v;
                }


                bool
                f_1558_163221_163237(char
                c)
                {
                    var return_v = c.IsWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163221, 163237);
                    return return_v;
                }


                int
                f_1558_163327_163338(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163327, 163338);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_163431_163454(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163431, 163454);
                    return return_v;
                }


                int
                f_1558_163494_163505(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163494, 163505);
                    return 0;
                }


                int
                f_1558_163659_163669(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163659, 163669);
                    return 0;
                }


                char
                f_1558_163692_163702(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163692, 163702);
                    return return_v;
                }


                int
                f_1558_163775_163785(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163775, 163785);
                    return 0;
                }


                char
                f_1558_163812_163822(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163812, 163822);
                    return return_v;
                }


                bool
                f_1558_163849_163864(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InCommandMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163849, 163864);
                    return return_v;
                }


                bool
                f_1558_163869_163885(char
                c)
                {
                    var return_v = c.IsWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163869, 163885);
                    return return_v;
                }


                int
                f_1558_163975_163986(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 163975, 163986);
                    return 0;
                }


                int
                f_1558_164013_164024(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 164013, 164024);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_164117_164147(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 164117, 164147);
                    return return_v;
                }


                int
                f_1558_164187_164198(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 164187, 164198);
                    return 0;
                }


                int
                f_1558_164369_164379(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 164369, 164379);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_164405_164433(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 164405, 164433);
                    return return_v;
                }


                bool
                f_1558_164471_164530(string
                featureName)
                {
                    var return_v = ExperimentalFeature.IsEnabled(featureName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 164471, 164530);
                    return return_v;
                }


                int
                f_1558_164622_164632(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 164622, 164632);
                    return 0;
                }


                char
                f_1558_164655_164665(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 164655, 164665);
                    return return_v;
                }


                int
                f_1558_164738_164748(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 164738, 164748);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_164778_164809(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 164778, 164809);
                    return return_v;
                }


                int
                f_1558_164923_164933(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 164923, 164933);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_164963_164999(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 164963, 164999);
                    return return_v;
                }


                int
                f_1558_165039_165050(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 165039, 165050);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 162201, 165135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 162201, 165135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Token GetInvokeMemberOpenParen()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 165147, 165760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 165332, 165351);

                var
                c = f_1558_165340_165350(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 165365, 165535) || true) && (c == '(')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 165365, 165535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 165411, 165439);

                    _tokenStart = _currentIndex;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 165457, 165468);

                    f_1558_165457_165467(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 165486, 165520);

                    return f_1558_165493_165519(this, TokenKind.LParen);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 165365, 165535);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 165551, 165721) || true) && (c == '{')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 165551, 165721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 165597, 165625);

                    _tokenStart = _currentIndex;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 165643, 165654);

                    f_1558_165643_165653(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 165672, 165706);

                    return f_1558_165679_165705(this, TokenKind.LCurly);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 165551, 165721);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 165737, 165749);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 165147, 165760);

                char
                f_1558_165340_165350(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 165340, 165350);
                    return return_v;
                }


                int
                f_1558_165457_165467(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 165457, 165467);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_165493_165519(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 165493, 165519);
                    return return_v;
                }


                int
                f_1558_165643_165653(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 165643, 165653);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_165679_165705(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 165679, 165705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 165147, 165760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 165147, 165760);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Token GetLBracket()
        {
            // We know we want a '[' token or no token.  We are in a context where we expect an attribute/type constraint
            // and allow any whitespace/comments before the '[', but nothing else (the caller has already skipped newlines
            // if appropriate.)  This is handled specially because in command mode, a generic token may begin with '[', but
            // we don't want anything more than the '['.

            // Remember where we started.  In some rare cases, we may need to sync back to make things a little
            // simpler in the parser.

            int resyncPoint = _currentIndex;
            bool resyncIfMemberAccess = false;
        again:
            _tokenStart = _currentIndex;
            char c = GetChar();
            switch (c)
            {
                case ' ':
                case '\t':
                case '\f':
                case '\v':
                case SpecialChars.NoBreakSpace:
                case SpecialChars.NextLine:
                    resyncIfMemberAccess = true;
                    SkipWhiteSpace();
                    goto again;

                case '#':
                    resyncIfMemberAccess = true;
                    ScanLineComment();
                    goto again;

                case '<':
                    if (PeekChar() == '#')
                    {
                        // We resync if we find any whitespace, but only if the whitespace occurs after a
                        // multi-line comment (rationale: backwards compatibility.)
                        resyncIfMemberAccess = false;
                        SkipChar();
                        ScanBlockComment();
                        goto again;
                    }

                    UngetChar();
                    break;

                case '[':
                    return NewToken(TokenKind.LBracket);

                case '.':
                case ':':
                    // We don't call resync here unless we might have a member access token, in which case
                    // we want to rescan the comments to ensure there is no whitespace between the expression
                    // and the member access token.  The resync here should rarely do much other than move
                    // the _currentIndex because there will rarely be any comment tokens after the closing ']'
                    // in an attribute and the member access token.
                    if (resyncIfMemberAccess)
                    {
                        Resync(resyncPoint);
                    }
                    else
                    {
                        UngetChar();
                    }

                    break;

                default:
                    if (c.IsWhitespace())
                    {
                        resyncIfMemberAccess = true;
                        SkipWhiteSpace();
                        goto again;
                    }

                    UngetChar();
                    break;
            }

            return null;
        }

        private Token ScanDot()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 168960, 169998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 169008, 169028);

                char
                c = f_1558_169017_169027(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 169042, 169448) || true) && (c == '.')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 169042, 169448);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 169088, 169099);

                    f_1558_169088_169098(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 169117, 169132);

                    c = f_1558_169121_169131(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 169150, 169379) || true) && (f_1558_169154_169169(this) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 169154, 169196) && !f_1558_169174_169196(c)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 169150, 169379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 169238, 169250);

                        f_1558_169238_169249(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 169331, 169360);

                        return f_1558_169338_169359(this, '.');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 169150, 169379);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 169399, 169433);

                    return f_1558_169406_169432(this, TokenKind.DotDot);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 169042, 169448);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 169464, 169558) || true) && (f_1558_169468_169486(c))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 169464, 169558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 169520, 169543);

                    return f_1558_169527_169542(this, '.');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 169464, 169558);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 169779, 169940) || true) && (f_1558_169783_169798(this) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 169783, 169825) && !f_1558_169803_169825(c)) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 169783, 169837) && c != '$') && (DynAbs.Tracing.TraceSender.Expression_True(1558, 169783, 169849) && c != '"') && (DynAbs.Tracing.TraceSender.Expression_True(1558, 169783, 169862) && c != '\''))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 169779, 169940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 169896, 169925);

                    return f_1558_169903_169924(this, '.');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 169779, 169940);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 169956, 169987);

                return f_1558_169963_169986(this, TokenKind.Dot);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 168960, 169998);

                char
                f_1558_169017_169027(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169017, 169027);
                    return return_v;
                }


                int
                f_1558_169088_169098(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169088, 169098);
                    return 0;
                }


                char
                f_1558_169121_169131(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169121, 169131);
                    return return_v;
                }


                bool
                f_1558_169154_169169(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InCommandMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169154, 169169);
                    return return_v;
                }


                bool
                f_1558_169174_169196(char
                c)
                {
                    var return_v = c.ForceStartNewToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169174, 169196);
                    return return_v;
                }


                int
                f_1558_169238_169249(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169238, 169249);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_169338_169359(System.Management.Automation.Language.Tokenizer
                this_param, char
                firstChar)
                {
                    var return_v = this_param.ScanGenericToken(firstChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169338, 169359);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_169406_169432(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169406, 169432);
                    return return_v;
                }


                bool
                f_1558_169468_169486(char
                c)
                {
                    var return_v = c.IsDecimalDigit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169468, 169486);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_169527_169542(System.Management.Automation.Language.Tokenizer
                this_param, char
                firstChar)
                {
                    var return_v = this_param.ScanNumber(firstChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169527, 169542);
                    return return_v;
                }


                bool
                f_1558_169783_169798(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InCommandMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169783, 169798);
                    return return_v;
                }


                bool
                f_1558_169803_169825(char
                c)
                {
                    var return_v = c.ForceStartNewToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169803, 169825);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_169903_169924(System.Management.Automation.Language.Tokenizer
                this_param, char
                firstChar)
                {
                    var return_v = this_param.ScanGenericToken(firstChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169903, 169924);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_169963_169986(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 169963, 169986);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 168960, 169998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 168960, 169998);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token ScanIdentifier(char firstChar)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 170165, 172015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 170234, 170262);

                var
                sb = f_1558_170243_170261(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 170276, 170283);

                char
                c
                = default(char);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 170297, 170318);

                f_1558_170297_170317(sb, firstChar);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 170334, 170650) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 170334, 170650);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 170379, 170393);

                        c = f_1558_170383_170392(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 170413, 170635) || true) && (f_1558_170417_170439(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 170413, 170635);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 170481, 170494);

                            f_1558_170481_170493(sb, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 170413, 170635);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 170413, 170635);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 170576, 170588);

                            f_1558_170576_170587(this);
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 170610, 170616);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 170413, 170635);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 170334, 170650);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 170334, 170650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 170334, 170650);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 170726, 170847) || true) && (f_1558_170730_170746(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 170726, 170847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 170780, 170792);

                    f_1558_170780_170791(this, sb);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 170810, 170832);

                    return f_1558_170817_170831(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 170726, 170847);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171070, 171212) || true) && (f_1558_171074_171089_M(!WantSimpleName) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 171074, 171108) && f_1558_171093_171108(this)) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 171074, 171135) && !f_1558_171113_171135(c)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 171070, 171212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171169, 171197);

                    return f_1558_171176_171196(this, sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 171070, 171212);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171228, 171891) || true) && (f_1558_171232_171247_M(!WantSimpleName) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 171232, 171289) && (f_1558_171252_171267(this) || (DynAbs.Tracing.TraceSender.Expression_False(1558, 171252, 171288) || f_1558_171271_171288(this)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 171228, 171891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171323, 171343);

                    TokenKind
                    tokenKind
                    = default(TokenKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171361, 171397);

                    var
                    ident = f_1558_171373_171396(this, sb)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171415, 171425);

                    sb = null;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171443, 171670) || true) && (f_1558_171447_171495(s_keywordTable, ident, out tokenKind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 171443, 171670);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171537, 171651) || true) && (tokenKind != TokenKind.InlineScript || (DynAbs.Tracing.TraceSender.Expression_False(1558, 171541, 171597) || f_1558_171580_171597()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 171537, 171651);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171624, 171651);

                            return f_1558_171631_171650(this, tokenKind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 171537, 171651);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 171443, 171670);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171690, 171876) || true) && (f_1558_171694_171731(ident) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 171694, 171773) && !f_1558_171736_171773(ident)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 171690, 171876);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171815, 171857);

                        return f_1558_171822_171856(this, TokenKind.DynamicKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 171690, 171876);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 171228, 171891);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171907, 171952) || true) && (sb != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 171907, 171952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171940, 171952);

                    f_1558_171940_171951(this, sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 171907, 171952);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 171966, 172004);

                return f_1558_171973_172003(this, TokenKind.Identifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 170165, 172015);

                System.Text.StringBuilder
                f_1558_170243_170261(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 170243, 170261);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_170297_170317(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 170297, 170317);
                    return return_v;
                }


                char
                f_1558_170383_170392(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 170383, 170392);
                    return return_v;
                }


                bool
                f_1558_170417_170439(char
                c)
                {
                    var return_v = c.IsIdentifierFollow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 170417, 170439);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_170481_170493(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 170481, 170493);
                    return return_v;
                }


                int
                f_1558_170576_170587(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 170576, 170587);
                    return 0;
                }


                bool
                f_1558_170730_170746(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InTypeNameMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 170730, 170746);
                    return return_v;
                }


                int
                f_1558_170780_170791(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    this_param.Release(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 170780, 170791);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_170817_170831(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.ScanTypeName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 170817, 170831);
                    return return_v;
                }


                bool
                f_1558_171074_171089_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 171074, 171089);
                    return return_v;
                }


                bool
                f_1558_171093_171108(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InCommandMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 171093, 171108);
                    return return_v;
                }


                bool
                f_1558_171113_171135(char
                c)
                {
                    var return_v = c.ForceStartNewToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 171113, 171135);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_171176_171196(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanGenericToken(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 171176, 171196);
                    return return_v;
                }


                bool
                f_1558_171232_171247_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 171232, 171247);
                    return return_v;
                }


                bool
                f_1558_171252_171267(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InCommandMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 171252, 171267);
                    return return_v;
                }


                bool
                f_1558_171271_171288(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InSignatureMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 171271, 171288);
                    return return_v;
                }


                string
                f_1558_171373_171396(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 171373, 171396);
                    return return_v;
                }


                bool
                f_1558_171447_171495(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TokenKind>
                this_param, string
                key, out System.Management.Automation.Language.TokenKind
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 171447, 171495);
                    return return_v;
                }


                bool
                f_1558_171580_171597()
                {
                    var return_v = InWorkflowContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 171580, 171597);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_171631_171650(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 171631, 171650);
                    return return_v;
                }


                bool
                f_1558_171694_171731(string
                name)
                {
                    var return_v = DynamicKeyword.ContainsKeyword(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 171694, 171731);
                    return return_v;
                }


                bool
                f_1558_171736_171773(string
                name)
                {
                    var return_v = DynamicKeyword.IsHiddenKeyword(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 171736, 171773);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_171822_171856(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 171822, 171856);
                    return return_v;
                }


                int
                f_1558_171940_171951(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    this_param.Release(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 171940, 171951);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_171973_172003(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 171973, 172003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 170165, 172015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 170165, 172015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token ScanTypeName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 172057, 172900);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 172110, 172746) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 172110, 172746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 172155, 172174);

                        char
                        c = f_1558_172164_172173(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 172194, 172675);

                        switch (c)
                        {

                            case '.':
                            case '`':
                            case '_':
                            case '+':
                            case '#':
                            case '\\':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 172194, 172675);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 172436, 172445);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 172194, 172675);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 172194, 172675);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 172501, 172622) || true) && (f_1558_172505_172528(c))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 172501, 172622);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 172586, 172595);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 172501, 172622);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1558, 172650, 172656);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 172194, 172675);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 172695, 172707);

                        f_1558_172695_172706(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1558, 172725, 172731);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 172110, 172746);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 172110, 172746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 172110, 172746);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 172762, 172806);

                var
                result = f_1558_172775_172805(this, TokenKind.Identifier)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 172820, 172861);

                result.TokenFlags |= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => TokenFlags.TypeName, 1558, 172820, 172837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 172875, 172889);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 172057, 172900);

                char
                f_1558_172164_172173(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 172164, 172173);
                    return return_v;
                }


                bool
                f_1558_172505_172528(char
                c)
                {
                    var return_v = char.IsLetterOrDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 172505, 172528);
                    return return_v;
                }


                int
                f_1558_172695_172706(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 172695, 172706);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_172775_172805(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 172775, 172805);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 172057, 172900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 172057, 172900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ScanAssemblyNameSpecToken(StringBuilder sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 172912, 173575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 173070, 173087);

                f_1558_173070_173086(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 173103, 173131);

                _tokenStart = _currentIndex;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 173145, 173420) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 173145, 173420);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 173190, 173209);

                        char
                        c = f_1558_173199_173208(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 173227, 173372) || true) && (f_1558_173231_173271(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 173227, 173372);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 173313, 173325);

                            f_1558_173313_173324(this);
                            DynAbs.Tracing.TraceSender.TraceBreak(1558, 173347, 173353);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 173227, 173372);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 173392, 173405);

                        f_1558_173392_173404(
                                        sb, c);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 173145, 173420);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 173145, 173420);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 173145, 173420);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 173436, 173479);

                var
                token = f_1558_173448_173478(this, TokenKind.Identifier)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 173493, 173533);

                token.TokenFlags |= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => TokenFlags.TypeName, 1558, 173493, 173509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 173547, 173564);

                f_1558_173547_173563(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 172912, 173575);

                int
                f_1558_173070_173086(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipWhiteSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 173070, 173086);
                    return 0;
                }


                char
                f_1558_173199_173208(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 173199, 173208);
                    return return_v;
                }


                bool
                f_1558_173231_173271(char
                c)
                {
                    var return_v = c.ForceStartNewTokenInAssemblyNameSpec();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 173231, 173271);
                    return return_v;
                }


                int
                f_1558_173313_173324(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 173313, 173324);
                    return 0;
                }


                System.Text.StringBuilder
                f_1558_173392_173404(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 173392, 173404);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_173448_173478(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 173448, 173478);
                    return return_v;
                }


                int
                f_1558_173547_173563(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipWhiteSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 173547, 173563);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 172912, 173575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 172912, 173575);
            }
        }

        internal string GetAssemblyNameSpec()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 173587, 175573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 174766, 174794);

                var
                sb = f_1558_174775_174793(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 174880, 174910);

                f_1558_174880_174909(this, sb);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 174926, 175515) || true) && (f_1558_174933_174943(this) == ',')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 174926, 175515);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 174984, 175012);

                        _tokenStart = _currentIndex;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175030, 175046);

                        f_1558_175030_175045(sb, ", ");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175064, 175075);

                        f_1558_175064_175074(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175093, 175119);

                        f_1558_175093_175118(this, TokenKind.Comma);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175139, 175169);

                        f_1558_175139_175168(this, sb);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175187, 175468) || true) && (f_1558_175191_175201(this) == '=')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 175187, 175468);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175250, 175278);

                            _tokenStart = _currentIndex;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175300, 175315);

                            f_1558_175300_175314(sb, "=");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175337, 175348);

                            f_1558_175337_175347(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175370, 175397);

                            f_1558_175370_175396(this, TokenKind.Equals);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175419, 175449);

                            f_1558_175419_175448(this, sb);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 175187, 175468);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 174926, 175515);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 174926, 175515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 174926, 175515);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175531, 175562);

                return f_1558_175538_175561(this, sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 173587, 175573);

                System.Text.StringBuilder
                f_1558_174775_174793(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 174775, 174793);
                    return return_v;
                }


                int
                f_1558_174880_174909(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    this_param.ScanAssemblyNameSpecToken(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 174880, 174909);
                    return 0;
                }


                char
                f_1558_174933_174943(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 174933, 174943);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_175030_175045(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175030, 175045);
                    return return_v;
                }


                int
                f_1558_175064_175074(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175064, 175074);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_175093_175118(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175093, 175118);
                    return return_v;
                }


                int
                f_1558_175139_175168(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    this_param.ScanAssemblyNameSpecToken(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175139, 175168);
                    return 0;
                }


                char
                f_1558_175191_175201(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175191, 175201);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_175300_175314(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175300, 175314);
                    return return_v;
                }


                int
                f_1558_175337_175347(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.SkipChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175337, 175347);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_175370_175396(System.Management.Automation.Language.Tokenizer
                this_param, System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = this_param.NewToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175370, 175396);
                    return return_v;
                }


                int
                f_1558_175419_175448(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    this_param.ScanAssemblyNameSpecToken(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175419, 175448);
                    return 0;
                }


                string
                f_1558_175538_175561(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175538, 175561);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 173587, 175573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 173587, 175573);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Token ScanLabel()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1558, 175618, 176700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175668, 175696);

                var
                sb = f_1558_175677_175695(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175712, 175731);

                char
                c = f_1558_175721_175730(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175745, 176136) || true) && (!f_1558_175750_175771(c))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 175745, 176136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175854, 175869);

                    f_1558_175854_175868(                // Must be a generic token then
                                    sb, ':');

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175887, 176043) || true) && (c == '\0')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 175887, 176043);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175942, 175954);

                        f_1558_175942_175953(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 175976, 176024);

                        return f_1558_175983_176023(this, f_1558_175999_176022(this, sb));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 175887, 176043);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 176063, 176075);

                    f_1558_176063_176074(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 176093, 176121);

                    return f_1558_176100_176120(this, sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 175745, 176136);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 176152, 176275) || true) && (f_1558_176159_176181(c))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 176152, 176275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 176215, 176228);

                        f_1558_176215_176227(sb, c);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 176246, 176260);

                        c = f_1558_176250_176259(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 176152, 176275);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1558, 176152, 176275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1558, 176152, 176275);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 176411, 176601) || true) && (f_1558_176415_176430(this) && (DynAbs.Tracing.TraceSender.Expression_True(1558, 176415, 176457) && !f_1558_176435_176457(c)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1558, 176411, 176601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 176491, 176509);

                    f_1558_176491_176508(sb, 0, ':');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 176527, 176540);

                    f_1558_176527_176539(sb, c);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 176558, 176586);

                    return f_1558_176565_176585(this, sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1558, 176411, 176601);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 176617, 176629);

                f_1558_176617_176628(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1558, 176643, 176689);

                return f_1558_176650_176688(this, f_1558_176664_176687(this, sb));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1558, 175618, 176700);

                System.Text.StringBuilder
                f_1558_175677_175695(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetStringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175677, 175695);
                    return return_v;
                }


                char
                f_1558_175721_175730(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175721, 175730);
                    return return_v;
                }


                bool
                f_1558_175750_175771(char
                c)
                {
                    var return_v = c.IsIdentifierStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175750, 175771);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_175854_175868(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175854, 175868);
                    return return_v;
                }


                int
                f_1558_175942_175953(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175942, 175953);
                    return 0;
                }


                string
                f_1558_175999_176022(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175999, 176022);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_175983_176023(System.Management.Automation.Language.Tokenizer
                this_param, string
                value)
                {
                    var return_v = this_param.NewGenericToken(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 175983, 176023);
                    return return_v;
                }


                int
                f_1558_176063_176074(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 176063, 176074);
                    return 0;
                }


                System.Management.Automation.Language.Token
                f_1558_176100_176120(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanGenericToken(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 176100, 176120);
                    return return_v;
                }


                bool
                f_1558_176159_176181(char
                c)
                {
                    var return_v = c.IsIdentifierFollow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 176159, 176181);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_176215_176227(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 176215, 176227);
                    return return_v;
                }


                char
                f_1558_176250_176259(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.GetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 176250, 176259);
                    return return_v;
                }


                bool
                f_1558_176415_176430(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    var return_v = this_param.InCommandMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 176415, 176430);
                    return return_v;
                }


                bool
                f_1558_176435_176457(char
                c)
                {
                    var return_v = c.ForceStartNewToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 176435, 176457);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_176491_176508(System.Text.StringBuilder
                this_param, int
                index, char
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 176491, 176508);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1558_176527_176539(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 176527, 176539);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1558_176565_176585(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.ScanGenericToken(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 176565, 176585);
                    return return_v;
                }


                int
                f_1558_176617_176628(System.Management.Automation.Language.Tokenizer
                this_param)
                {
                    this_param.UngetChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 176617, 176628);
                    return 0;
                }


                string
                f_1558_176664_176687(System.Management.Automation.Language.Tokenizer
                this_param, System.Text.StringBuilder
                sb)
                {
                    var return_v = this_param.GetStringAndRelease(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 176664, 176687);
                    return return_v;
                }


                System.Management.Automation.Language.LabelToken
                f_1558_176650_176688(System.Management.Automation.Language.Tokenizer
                this_param, string
                value)
                {
                    var return_v = this_param.NewLabelToken(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 176650, 176688);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1558, 175618, 176700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1558, 175618, 176700);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Token NextToken()
        {
            char c1;

        again:
            _tokenStart = _currentIndex;
            char c = GetChar();
            switch (c)
            {
                case ' ':
                case '\t':
                case '\f':
                case '\v':
                case SpecialChars.NoBreakSpace:
                case SpecialChars.NextLine:
                    SkipWhiteSpace();
                    goto again;

                case '\'':
                case SpecialChars.QuoteSingleLeft:
                case SpecialChars.QuoteSingleRight:
                case SpecialChars.QuoteSingleBase:
                case SpecialChars.QuoteReversed:
                    return ScanStringLiteral();

                case '"':
                case SpecialChars.QuoteDoubleLeft:
                case SpecialChars.QuoteDoubleRight:
                case SpecialChars.QuoteLowDoubleLeft:
                    return ScanStringExpandable();

                case '@':
                    // Could be start of hash literal, array operator, multi-line string, splatted variable
                    c1 = GetChar();
                    if (c1 == '{')
                    {
                        return NewToken(TokenKind.AtCurly);
                    }

                    if (c1 == '(')
                    {
                        return NewToken(TokenKind.AtParen);
                    }

                    if (c1.IsSingleQuote())
                    {
                        return ScanHereStringLiteral();
                    }

                    if (c1.IsDoubleQuote())
                    {
                        return ScanHereStringExpandable();
                    }

                    UngetChar();
                    if (c1.IsVariableStart())
                    {
                        return ScanVariable(true, false);
                    }

                    ReportError(_currentIndex - 1,
                        nameof(ParserStrings.UnrecognizedToken),
                        ParserStrings.UnrecognizedToken);
                    return NewToken(TokenKind.Unknown);

                case '#':
                    ScanLineComment();
                    goto again;

                case '\n':
                    return NewToken(TokenKind.NewLine);

                case '\r':
                    NormalizeCRLF(c);
                    goto case '\n';

                case '`':
                    c1 = GetChar();
                    if (c1 == '\r')
                    {
                        NormalizeCRLF(c1);
                    }

                    if (c1 == '\n' || c1 == '\r')
                    {
                        NewToken(TokenKind.LineContinuation);
                        goto again;
                    }

                    if (char.IsWhiteSpace(c1))
                    {
                        SkipWhiteSpace();
                        goto again;
                    }

                    if (c1 == '\0' && AtEof())
                    {
                        ReportIncompleteInput(_currentIndex,
                            nameof(ParserStrings.IncompleteString),
                            ParserStrings.IncompleteString);

                        // Unget the EOF so we can return an EOF token.
                        UngetChar();
                        goto again;
                    }

                    c = Backtick(c1, out char surrogateCharacter);
                    return ScanGenericToken(c, surrogateCharacter);

                case '=':
                    return CheckOperatorInCommandMode(c, TokenKind.Equals);

                case '+':
                    c1 = PeekChar();
                    if (c1 == '+')
                    {
                        SkipChar();
                        return CheckOperatorInCommandMode(c, c1, TokenKind.PlusPlus);
                    }

                    if (c1 == '=')
                    {
                        SkipChar();
                        return CheckOperatorInCommandMode(c, c1, TokenKind.PlusEquals);
                    }

                    if (AllowSignedNumbers && (char.IsDigit(c1) || c1 == '.'))
                    {
                        return ScanNumber(c);
                    }

                    return CheckOperatorInCommandMode(c, TokenKind.Plus);

                case '-':
                case SpecialChars.EmDash:
                case SpecialChars.EnDash:
                case SpecialChars.HorizontalBar:
                    c1 = PeekChar();
                    if (c1.IsDash())
                    {
                        SkipChar();
                        return CheckOperatorInCommandMode(c, c1, TokenKind.MinusMinus);
                    }

                    if (c1 == '=')
                    {
                        SkipChar();
                        return CheckOperatorInCommandMode(c, c1, TokenKind.MinusEquals);
                    }

                    if (char.IsLetter(c1) || c1 == '_' || c1 == '?')
                    {
                        return ScanParameter();
                    }

                    if (AllowSignedNumbers && (char.IsDigit(c1) || c1 == '.'))
                    {
                        return ScanNumber(c);
                    }

                    return CheckOperatorInCommandMode(c, TokenKind.Minus);

                case '*':
                    c1 = PeekChar();
                    if (c1 == '=')
                    {
                        SkipChar();
                        return CheckOperatorInCommandMode(c, c1, TokenKind.MultiplyEquals);
                    }

                    if (c1 == '>')
                    {
                        SkipChar();
                        c1 = PeekChar();
                        if (c1 == '>')
                        {
                            SkipChar();
                            return NewFileRedirectionToken(0, append: true, fromSpecifiedExplicitly: false);
                        }

                        if (c1 == '&')
                        {
                            SkipChar();
                            c1 = PeekChar();
                            if (c1 == '1')
                            {
                                SkipChar();
                                return NewMergingRedirectionToken(0, 1);
                            }

                            UngetChar();
                        }

                        return NewFileRedirectionToken(0, append: false, fromSpecifiedExplicitly: false);
                    }

                    return CheckOperatorInCommandMode(c, TokenKind.Multiply);

                case '/':
                    c1 = PeekChar();
                    if (c1 == '=')
                    {
                        SkipChar();
                        return CheckOperatorInCommandMode(c, c1, TokenKind.DivideEquals);
                    }

                    return CheckOperatorInCommandMode(c, TokenKind.Divide);

                case '%':
                    c1 = PeekChar();
                    if (c1 == '=')
                    {
                        SkipChar();
                        return CheckOperatorInCommandMode(c, c1, TokenKind.RemainderEquals);
                    }

                    return CheckOperatorInCommandMode(c, TokenKind.Rem);

                case '$':
                    if (PeekChar() == '(')
                    {
                        SkipChar();
                        return NewToken(TokenKind.DollarParen);
                    }

                    return ScanVariable(false, false);

                case '<':
                    if (PeekChar() == '#')
                    {
                        SkipChar();
                        ScanBlockComment();
                        goto again;
                    }

                    return NewInputRedirectionToken();

                case '>':
                    if (PeekChar() == '>')
                    {
                        SkipChar();
                        return NewFileRedirectionToken(1, append: true, fromSpecifiedExplicitly: false);
                    }

                    return NewFileRedirectionToken(1, append: false, fromSpecifiedExplicitly: false);

                case 'a':
                case 'b':
                case 'c':
                case 'd':
                case 'e':
                case 'f':
                case 'g':
                case 'h':
                case 'i':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'o':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'u':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                case 'G':
                case 'H':
                case 'I':
                case 'J':
                case 'K':
                case 'L':
                case 'M':
                case 'N':
                case 'O':
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                case 'T':
                case 'U':
                case 'V':
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                case '_':
                    return ScanIdentifier(c);

                case '(':
                    return NewToken(TokenKind.LParen);
                case ')':
                    return NewToken(TokenKind.RParen);
                case '[':
                    if (InCommandMode() && !PeekChar().ForceStartNewToken())
                    {
                        return ScanGenericToken('[');
                    }

                    return NewToken(TokenKind.LBracket);
                case ']':
                    return NewToken(TokenKind.RBracket);
                case '{':
                    return NewToken(TokenKind.LCurly);
                case '}':
                    return NewToken(TokenKind.RCurly);
                case '.':
                    return ScanDot();
                case ';':
                    return NewToken(TokenKind.Semi);
                case ',':
                    return NewToken(TokenKind.Comma);

                case '0':
                case '7':
                case '8':
                case '9':
                    return ScanNumber(c);

                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                    if (PeekChar() == '>')
                    {
                        SkipChar();
                        c1 = PeekChar();
                        if (c1 == '>')
                        {
                            SkipChar();
                            return NewFileRedirectionToken(c - '0', append: true, fromSpecifiedExplicitly: true);
                        }

                        if (c1 == '&')
                        {
                            SkipChar();
                            c1 = PeekChar();
                            if (c1 == '1' || c1 == '2')
                            {
                                SkipChar();
                                return NewMergingRedirectionToken(c - '0', c1 - '0');
                            }

                            UngetChar();
                        }

                        return NewFileRedirectionToken(c - '0', append: false, fromSpecifiedExplicitly: true);
                    }

                    return ScanNumber(c);

                case '&':
                    if (PeekChar() == '&')
                    {
                        SkipChar();
                        return NewToken(TokenKind.AndAnd);
                    }

                    return NewToken(TokenKind.Ampersand);

                case '|':
                    if (PeekChar() == '|')
                    {
                        SkipChar();
                        return NewToken(TokenKind.OrOr);
                    }

                    return NewToken(TokenKind.Pipe);

                case '!':
                    c1 = PeekChar();
                    if ((InCommandMode() && !c1.ForceStartNewToken()) ||
                        (InExpressionMode() && c1.IsIdentifierStart()))
                    {
                        return ScanGenericToken(c);
                    }

                    if (InExpressionMode() && (char.IsDigit(c1) || c1 == '.'))
                    {
                        // check if the next token is actually a number
                        string strNum = ScanNumberHelper(c, out _, out _, out _, out _);
                        // rescan characters after the check
                        _currentIndex = _tokenStart;
                        c = GetChar();

                        if (strNum == null)
                        { return ScanGenericToken(c); }
                    }

                    return NewToken(TokenKind.Exclaim);

                case ':':
                    if (PeekChar() == ':')
                    {
                        SkipChar();
                        if (InCommandMode() && !WantSimpleName && !PeekChar().ForceStartNewToken())
                        {
                            var sb = GetStringBuilder();
                            sb.Append("::");
                            return ScanGenericToken(sb);
                        }

                        return NewToken(TokenKind.ColonColon);
                    }

                    if (InCommandMode())
                    {
                        return ScanLabel();
                    }

                    return this.NewToken(TokenKind.Colon);

                case '?' when InExpressionMode():
                    c1 = PeekChar();

                    if (c1 == '?')
                    {
                        SkipChar();
                        c1 = PeekChar();

                        if (c1 == '=')
                        {
                            SkipChar();
                            return this.NewToken(TokenKind.QuestionQuestionEquals);
                        }

                        return this.NewToken(TokenKind.QuestionQuestion);
                    }

                    return this.NewToken(TokenKind.QuestionMark);

                case '\0':
                    if (AtEof())
                    {
                        return SaveToken(new Token(NewScriptExtent(_tokenStart + 1, _tokenStart + 1), TokenKind.EndOfInput, TokenFlags.None));
                    }

                    return ScanGenericToken(c);

                default:
                    if (c.IsWhitespace())
                    {
                        SkipWhiteSpace();
                        goto again;
                    }

                    if (char.IsLetter(c))
                    {
                        return ScanIdentifier(c);
                    }

                    return ScanGenericToken(c);
            }
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1558, 20323, 192504);

        static System.StringComparer
        f_1558_20542_20574()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 20542, 20574);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TokenKind>
        f_1558_20508_20575(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TokenKind>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 20508, 20575);
            return return_v;
        }


        static System.StringComparer
        f_1558_20705_20737()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 20705, 20737);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TokenKind>
        f_1558_20671_20738(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TokenKind>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 20671, 20738);
            return return_v;
        }


        static int
        f_1558_29418_29438(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 29418, 29438);
            return return_v;
        }


        static int
        f_1558_29442_29467(System.Management.Automation.Language.TokenKind[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 29442, 29467);
            return return_v;
        }


        static int
        f_1558_29399_29502(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 29399, 29502);
            return 0;
        }


        static int
        f_1558_29536_29556(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 29536, 29556);
            return return_v;
        }


        static int
        f_1558_29560_29586(System.Management.Automation.Language.TokenKind[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 29560, 29586);
            return return_v;
        }


        static int
        f_1558_29517_29622(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 29517, 29622);
            return 0;
        }


        static int
        f_1558_29659_29679(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 29659, 29679);
            return return_v;
        }


        static int
        f_1558_29718_29777(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TokenKind>
        this_param, string
        key, System.Management.Automation.Language.TokenKind
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 29718, 29777);
            return 0;
        }


        static int
        f_1558_29829_29849(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 29829, 29849);
            return return_v;
        }


        static int
        f_1558_29888_29949(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TokenKind>
        this_param, string
        key, System.Management.Automation.Language.TokenKind
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 29888, 29949);
            return 0;
        }


        static int
        f_1558_30393_30443(string
        source, int
        seed, System.Func<int, char, int>
        func)
        {
            var return_v = source.Aggregate<char, int>(seed, func);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 30393, 30443);
            return return_v;
        }


        static System.Management.Automation.Language.TokenKind
        f_1558_30547_30570(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TokenKind>
        this_param, string
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 30547, 30570);
            return return_v;
        }


        static int
        f_1558_30528_30627(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 30528, 30627);
            return 0;
        }


        static System.Management.Automation.Language.TokenKind
        f_1558_30661_30684(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TokenKind>
        this_param, string
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1558, 30661, 30684);
            return return_v;
        }


        static int
        f_1558_30642_30741(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 30642, 30741);
            return 0;
        }


        System.Collections.Generic.Queue<System.Text.StringBuilder>
        f_1558_68722_68748()
        {
            var return_v = new System.Collections.Generic.Queue<System.Text.StringBuilder>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1558, 68722, 68748);
            return return_v;
        }

    }
}
