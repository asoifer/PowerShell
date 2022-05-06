// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Management.Automation.Language;
using System.Runtime.Serialization;

namespace System.Management.Automation
{
    [Serializable]
    public class ParseException : RuntimeException
    {
        private const string
        errorIdString = "Parse"
        ;

        private ParseError[] _errors;

        public ParseError[] Errors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1030, 744, 767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 750, 765);

                    return _errors;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1030, 744, 767);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 693, 778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 693, 778);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected ParseException(SerializationInfo info,
                                   StreamingContext context)
        : base(f_1030_1405_1409_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1030, 1278, 1525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 586, 593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 1444, 1514);

                _errors = (ParseError[])f_1030_1468_1513(info, "Errors", typeof(ParseError[]));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1030, 1278, 1525);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 1278, 1525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 1278, 1525);
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1030, 1633, 1957);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 1742, 1849) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1030, 1742, 1849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 1792, 1834);

                    throw f_1030_1798_1833("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1030, 1742, 1849);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 1865, 1899);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1030, 1865, 1898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 1913, 1946);

                f_1030_1913_1945(info, "Errors", _errors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1030, 1633, 1957);

                System.Management.Automation.PSArgumentNullException
                f_1030_1798_1833(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1030, 1798, 1833);
                    return return_v;
                }


                int
                f_1030_1913_1945(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, System.Management.Automation.Language.ParseError[]
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1030, 1913, 1945);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 1633, 1957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 1633, 1957);
            }
        }

        public ParseException() : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1030, 2197, 2359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 586, 593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 2254, 2285);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(errorIdString), 1030, 2254, 2284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 2299, 2348);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorCategory(ErrorCategory.ParserError), 1030, 2299, 2347);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1030, 2197, 2359);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 2197, 2359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 2197, 2359);
            }
        }

        public ParseException(string message) : base(f_1030_2713_2720_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1030, 2668, 2851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 586, 593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 2746, 2777);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(errorIdString), 1030, 2746, 2776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 2791, 2840);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorCategory(ErrorCategory.ParserError), 1030, 2791, 2839);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1030, 2668, 2851);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 2668, 2851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 2668, 2851);
            }
        }

        internal ParseException(string message, string errorId) : base(f_1030_3341_3348_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1030, 3278, 3473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 586, 593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 3374, 3399);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(errorId), 1030, 3374, 3398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 3413, 3462);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorCategory(ErrorCategory.ParserError), 1030, 3413, 3461);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1030, 3278, 3473);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 3278, 3473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 3278, 3473);
            }
        }

        internal ParseException(string message, string errorId, Exception innerException)
        : base(f_1030_4128_4135_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1030, 4026, 4276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 586, 593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 4177, 4202);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(errorId), 1030, 4177, 4201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 4216, 4265);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorCategory(ErrorCategory.ParserError), 1030, 4216, 4264);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1030, 4026, 4276);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 4026, 4276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 4026, 4276);
            }
        }

        public ParseException(string message,
                                Exception innerException)
        : base(f_1030_4839_4846_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1030, 4726, 4993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 586, 593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 4888, 4919);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(errorIdString), 1030, 4888, 4918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 4933, 4982);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorCategory(ErrorCategory.ParserError), 1030, 4933, 4981);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1030, 4726, 4993);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 4726, 4993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 4726, 4993);
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
                    Justification = "ErrorRecord is not overridden in classes deriving from ParseException")]
        public ParseException(Language.ParseError[] errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1030, 5233, 6019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 586, 593);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 5509, 5644) || true) && ((errors == null) || (DynAbs.Tracing.TraceSender.Expression_False(1030, 5513, 5553) || (f_1030_5534_5547(errors) == 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1030, 5509, 5644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 5587, 5629);

                    throw f_1030_5593_5628("errors");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1030, 5509, 5644);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 5660, 5677);

                _errors = errors;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 5767, 5803);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(f_1030_5783_5801(_errors[0])), 1030, 5767, 5802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 5817, 5866);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorCategory(ErrorCategory.ParserError), 1030, 5817, 5865);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 5882, 6008) || true) && (f_1030_5886_5902(errors[0]) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1030, 5882, 6008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 5929, 6008);

                    f_1030_5929_6007(f_1030_5929_5945(this), f_1030_5964_6006(null, f_1030_5989_6005(errors[0])));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1030, 5882, 6008);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1030, 5233, 6019);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 5233, 6019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 5233, 6019);
            }
        }

        public override string Message
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1030, 6203, 6729);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 6239, 6339) || true) && (_errors == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1030, 6239, 6339);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 6300, 6320);

                        return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Message, 1030, 6307, 6319);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1030, 6239, 6339);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 6414, 6616);

                    var
                    errorsToReport = (DynAbs.Tracing.TraceSender.Conditional_F1(1030, 6435, 6456) || (((f_1030_6436_6450(_errors) > 10)
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1030, 6480, 6558)) || DynAbs.Tracing.TraceSender.Conditional_F3(1030, 6582, 6615))) ? f_1030_6480_6558(f_1030_6480_6522(f_1030_6480_6496(_errors, 10), e => e.ToString()), f_1030_6530_6557()) : f_1030_6582_6615(_errors, e => e.ToString())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 6636, 6714);

                    return f_1030_6643_6713(f_1030_6655_6674() + f_1030_6677_6696(), errorsToReport);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1030, 6203, 6729);

                    int
                    f_1030_6436_6450(System.Management.Automation.Language.ParseError[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1030, 6436, 6450);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ParseError>
                    f_1030_6480_6496(System.Management.Automation.Language.ParseError[]
                    source, int
                    count)
                    {
                        var return_v = source.Take<System.Management.Automation.Language.ParseError>(count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1030, 6480, 6496);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_1030_6480_6522(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ParseError>
                    source, System.Func<System.Management.Automation.Language.ParseError, string>
                    selector)
                    {
                        var return_v = source.Select<System.Management.Automation.Language.ParseError, string>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1030, 6480, 6522);
                        return return_v;
                    }


                    string
                    f_1030_6530_6557()
                    {
                        var return_v = ParserStrings.TooManyErrors;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1030, 6530, 6557);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_1030_6480_6558(System.Collections.Generic.IEnumerable<string>
                    source, string
                    element)
                    {
                        var return_v = source.Append<string>(element);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1030, 6480, 6558);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_1030_6582_6615(System.Management.Automation.Language.ParseError[]
                    source, System.Func<System.Management.Automation.Language.ParseError, string>
                    selector)
                    {
                        var return_v = source.Select<System.Management.Automation.Language.ParseError, string>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1030, 6582, 6615);
                        return return_v;
                    }


                    string
                    f_1030_6655_6674()
                    {
                        var return_v = Environment.NewLine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1030, 6655, 6674);
                        return return_v;
                    }


                    string
                    f_1030_6677_6696()
                    {
                        var return_v = Environment.NewLine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1030, 6677, 6696);
                        return return_v;
                    }


                    string
                    f_1030_6643_6713(string
                    separator, System.Collections.Generic.IEnumerable<string>
                    values)
                    {
                        var return_v = string.Join(separator, values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1030, 6643, 6713);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 6148, 6740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 6148, 6740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ParseException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1030, 427, 6747);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 531, 554);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1030, 427, 6747);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 427, 6747);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1030, 427, 6747);

        object?
        f_1030_1468_1513(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name, System.Type
        type)
        {
            var return_v = this_param.GetValue(name, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1030, 1468, 1513);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1030_1405_1409_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1030, 1278, 1525);
            return return_v;
        }


        static string
        f_1030_2713_2720_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1030, 2668, 2851);
            return return_v;
        }


        static string
        f_1030_3341_3348_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1030, 3278, 3473);
            return return_v;
        }


        static string
        f_1030_4128_4135_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1030, 4026, 4276);
            return return_v;
        }


        static string
        f_1030_4839_4846_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1030, 4726, 4993);
            return return_v;
        }


        int
        f_1030_5534_5547(System.Management.Automation.Language.ParseError[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1030, 5534, 5547);
            return return_v;
        }


        System.ArgumentNullException
        f_1030_5593_5628(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1030, 5593, 5628);
            return return_v;
        }


        string
        f_1030_5783_5801(System.Management.Automation.Language.ParseError
        this_param)
        {
            var return_v = this_param.ErrorId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1030, 5783, 5801);
            return return_v;
        }


        System.Management.Automation.Language.IScriptExtent
        f_1030_5886_5902(System.Management.Automation.Language.ParseError
        this_param)
        {
            var return_v = this_param.Extent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1030, 5886, 5902);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1030_5929_5945(System.Management.Automation.ParseException
        this_param)
        {
            var return_v = this_param.ErrorRecord;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1030, 5929, 5945);
            return return_v;
        }


        System.Management.Automation.Language.IScriptExtent
        f_1030_5989_6005(System.Management.Automation.Language.ParseError
        this_param)
        {
            var return_v = this_param.Extent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1030, 5989, 6005);
            return return_v;
        }


        System.Management.Automation.InvocationInfo
        f_1030_5964_6006(System.Management.Automation.CommandInfo
        commandInfo, System.Management.Automation.Language.IScriptExtent
        scriptPosition)
        {
            var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1030, 5964, 6006);
            return return_v;
        }


        int
        f_1030_5929_6007(System.Management.Automation.ErrorRecord
        this_param, System.Management.Automation.InvocationInfo
        invocationInfo)
        {
            this_param.SetInvocationInfo(invocationInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1030, 5929, 6007);
            return 0;
        }

    }
    [Serializable]
    public class IncompleteParseException
                : ParseException
    {
        private const string
        errorIdString = "IncompleteParse"
        ;

        protected IncompleteParseException(SerializationInfo info,
                                   StreamingContext context)
        : base(f_1030_8050_8054_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1030, 7913, 8086);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1030, 7913, 8086);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 7913, 8086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 7913, 8086);
            }
        }

        public IncompleteParseException() : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1030, 8310, 8477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 8435, 8466);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(errorIdString), 1030, 8435, 8465);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1030, 8310, 8477);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 8310, 8477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 8310, 8477);
            }
        }

        public IncompleteParseException(string message) : base(f_1030_8851_8858_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1030, 8796, 8984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 8942, 8973);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(errorIdString), 1030, 8942, 8972);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1030, 8796, 8984);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 8796, 8984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 8796, 8984);
            }
        }

        internal IncompleteParseException(string message, string errorId) : base(f_1030_9494_9501_C(message), errorId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1030, 9421, 9591);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1030, 9421, 9591);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 9421, 9591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 9421, 9591);
            }
        }

        internal IncompleteParseException(string message, string errorId, Exception innerException)
        : base(f_1030_10266_10273_C(message), errorId, innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1030, 10154, 10379);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1030, 10154, 10379);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 10154, 10379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 10154, 10379);
            }
        }

        public IncompleteParseException(string message,
                                Exception innerException)
        : base(f_1030_10962_10969_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1030, 10839, 11111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 11069, 11100);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(errorIdString), 1030, 11069, 11099);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1030, 10839, 11111);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1030, 10839, 11111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 10839, 11111);
            }
        }

        static IncompleteParseException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1030, 7175, 11143);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1030, 7325, 7358);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1030, 7175, 11143);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1030, 7175, 11143);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1030, 7175, 11143);

        static System.Runtime.Serialization.SerializationInfo
        f_1030_8050_8054_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1030, 7913, 8086);
            return return_v;
        }


        static string
        f_1030_8851_8858_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1030, 8796, 8984);
            return return_v;
        }


        static string
        f_1030_9494_9501_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1030, 9421, 9591);
            return return_v;
        }


        static string
        f_1030_10266_10273_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1030, 10154, 10379);
            return return_v;
        }


        static string
        f_1030_10962_10969_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1030, 10839, 11111);
            return return_v;
        }

    }
}
