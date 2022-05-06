// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace System.Management.Automation
{
    /// <summary>
    /// Possible types of CompletionResults.
    /// </summary>
    public enum CompletionResultType
    {
        /// <summary> An unknown result type, kept as text only.</summary>
        Text = 0,

        /// <summary>A history result type like the items out of get-history.</summary>
        History = 1,

        /// <summary>A command result type like the items out of get-command.</summary>
        Command = 2,

        /// <summary>A provider item.</summary>
        ProviderItem = 3,

        /// <summary>A provider container.</summary>
        ProviderContainer = 4,

        /// <summary>A property result type like the property items out of get-member.</summary>
        Property = 5,

        /// <summary>A method result type like the method items out of get-member.</summary>
        Method = 6,

        /// <summary>A parameter name result type like the Parameters property out of get-command items.</summary>
        ParameterName = 7,

        /// <summary>A parameter value result type.</summary>
        ParameterValue = 8,

        /// <summary>A variable result type like the items out of get-childitem variable.</summary>
        Variable = 9,

        /// <summary>A namespace.</summary>
        Namespace = 10,

        /// <summary>A type name.</summary>
        Type = 11,

        /// <summary>A keyword.</summary>
        Keyword = 12,

        /// <summary>A dynamic keyword.</summary>
        DynamicKeyword = 13,

        // If a new enum is added, there is a range test that uses DynamicKeyword for parameter validation
        // that needs to be updated to use the new enum.
        // We can't use a "MaxValue" enum because it's value would preclude ever adding a new enum.
    }
    public class CompletionResult
    {
        private string _completionText;

        private string _listItemText;

        private string _toolTip;

        private CompletionResultType _resultType;

        private static readonly CompletionResult s_nullInstance;

        public string CompletionText
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1444, 3057, 3330);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 3093, 3272) || true) && (this == s_nullInstance)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1444, 3093, 3272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 3161, 3253);

                        throw f_1444_3167_3252(f_1444_3210_3251());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1444, 3093, 3272);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 3292, 3315);

                    return _completionText;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1444, 3057, 3330);

                    string
                    f_1444_3210_3251()
                    {
                        var return_v = TabCompletionStrings.NoAccessToProperties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1444, 3210, 3251);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1444_3167_3252(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1444, 3167, 3252);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1444, 3004, 3341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1444, 3004, 3341);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string ListItemText
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1444, 3505, 3776);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 3541, 3720) || true) && (this == s_nullInstance)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1444, 3541, 3720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 3609, 3701);

                        throw f_1444_3615_3700(f_1444_3658_3699());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1444, 3541, 3720);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 3740, 3761);

                    return _listItemText;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1444, 3505, 3776);

                    string
                    f_1444_3658_3699()
                    {
                        var return_v = TabCompletionStrings.NoAccessToProperties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1444, 3658, 3699);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1444_3615_3700(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1444, 3615, 3700);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1444, 3454, 3787);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1444, 3454, 3787);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CompletionResultType ResultType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1444, 3958, 4227);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 3994, 4173) || true) && (this == s_nullInstance)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1444, 3994, 4173);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 4062, 4154);

                        throw f_1444_4068_4153(f_1444_4111_4152());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1444, 3994, 4173);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 4193, 4212);

                    return _resultType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1444, 3958, 4227);

                    string
                    f_1444_4111_4152()
                    {
                        var return_v = TabCompletionStrings.NoAccessToProperties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1444, 4111, 4152);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1444_4068_4153(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1444, 4068, 4153);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1444, 3895, 4238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1444, 3895, 4238);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string ToolTip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1444, 4433, 4699);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 4469, 4648) || true) && (this == s_nullInstance)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1444, 4469, 4648);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 4537, 4629);

                        throw f_1444_4543_4628(f_1444_4586_4627());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1444, 4469, 4648);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 4668, 4684);

                    return _toolTip;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1444, 4433, 4699);

                    string
                    f_1444_4586_4627()
                    {
                        var return_v = TabCompletionStrings.NoAccessToProperties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1444, 4586, 4627);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1444_4543_4628(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1444, 4543, 4628);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1444, 4387, 4710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1444, 4387, 4710);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static CompletionResult Null
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1444, 4893, 4923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 4899, 4921);

                    return s_nullInstance;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1444, 4893, 4923);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1444, 4831, 4934);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1444, 4831, 4934);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CompletionResult(string completionText, string listItemText, CompletionResultType resultType, string toolTip)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1444, 5441, 6463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 2232, 2247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 2367, 2380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 2540, 2548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 2677, 2688);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 5582, 5734) || true) && (f_1444_5586_5622(completionText))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1444, 5582, 5734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 5656, 5719);

                    throw f_1444_5662_5718("completionText");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1444, 5582, 5734);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 5750, 5898) || true) && (f_1444_5754_5788(listItemText))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1444, 5750, 5898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 5822, 5883);

                    throw f_1444_5828_5882("listItemText");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1444, 5750, 5898);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 5914, 6134) || true) && (resultType < CompletionResultType.Text || (DynAbs.Tracing.TraceSender.Expression_False(1444, 5918, 6008) || resultType > CompletionResultType.DynamicKeyword))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1444, 5914, 6134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 6042, 6119);

                    throw f_1444_6048_6118("resultType", resultType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1444, 5914, 6134);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 6150, 6288) || true) && (f_1444_6154_6183(toolTip))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1444, 6150, 6288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 6217, 6273);

                    throw f_1444_6223_6272("toolTip");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1444, 6150, 6288);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 6304, 6337);

                _completionText = completionText;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 6351, 6380);

                _listItemText = listItemText;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 6394, 6413);

                _toolTip = toolTip;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 6427, 6452);

                _resultType = resultType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1444, 5441, 6463);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1444, 5441, 6463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1444, 5441, 6463);
            }
        }

        public CompletionResult(string completionText)
        : this(f_1444_6768_6782_C(completionText), completionText, CompletionResultType.Text, completionText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1444, 6701, 6864);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1444, 6701, 6864);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1444, 6701, 6864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1444, 6701, 6864);
            }
        }

        private CompletionResult()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1444, 7193, 7223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 2232, 2247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 2367, 2380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 2540, 2548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 2677, 2688);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1444, 7193, 7223);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1444, 7193, 7223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1444, 7193, 7223);
            }
        }

        static CompletionResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1444, 2064, 7230);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1444, 2836, 2875);
            s_nullInstance = f_1444_2853_2875();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1444, 2064, 7230);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1444, 2064, 7230);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1444, 2064, 7230);

        static System.Management.Automation.CompletionResult
        f_1444_2853_2875()
        {
            var return_v = new System.Management.Automation.CompletionResult();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1444, 2853, 2875);
            return return_v;
        }


        bool
        f_1444_5586_5622(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1444, 5586, 5622);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1444_5662_5718(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1444, 5662, 5718);
            return return_v;
        }


        bool
        f_1444_5754_5788(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1444, 5754, 5788);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1444_5828_5882(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1444, 5828, 5882);
            return return_v;
        }


        System.Management.Automation.PSArgumentOutOfRangeException
        f_1444_6048_6118(string
        paramName, System.Management.Automation.CompletionResultType
        actualValue)
        {
            var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1444, 6048, 6118);
            return return_v;
        }


        bool
        f_1444_6154_6183(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1444, 6154, 6183);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1444_6223_6272(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1444, 6223, 6272);
            return return_v;
        }


        static string
        f_1444_6768_6782_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1444, 6701, 6864);
            return return_v;
        }

    }
}
