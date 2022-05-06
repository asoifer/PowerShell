// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Language;

using Microsoft.Management.Infrastructure;

namespace System.Management.Automation.Runspaces
{
    using System;
    using System.Collections.ObjectModel;
    using Debug = System.Management.Automation.Diagnostics;
    public sealed class CommandParameter
    {
        public CommandParameter(string name)
        : this(f_1474_1021_1025_C(name), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1474, 964, 1186);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 1057, 1175) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 1057, 1175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 1107, 1160);

                    throw f_1474_1113_1159("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 1057, 1175);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1474, 964, 1186);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1474, 964, 1186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1474, 964, 1186);
            }
        }

        public CommandParameter(string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1474, 1555, 1991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 2167, 2194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 2299, 2327);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 1630, 1950) || true) && (name != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 1630, 1950);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 1680, 1825) || true) && (f_1474_1684_1715(name))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 1680, 1825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 1757, 1806);

                        throw f_1474_1763_1805("name");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 1680, 1825);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 1845, 1857);

                    Name = name;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 1630, 1950);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 1630, 1950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 1923, 1935);

                    Name = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 1630, 1950);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 1966, 1980);

                Value = value;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1474, 1555, 1991);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1474, 1555, 1991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1474, 1555, 1991);
            }
        }

        public string Name { get; }

        public object Value { get; }

        internal static CommandParameter FromCommandParameterInternal(CommandParameterInternal internalParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1474, 2517, 4091);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 2647, 2791) || true) && (internalParameter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 2647, 2791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 2710, 2776);

                    throw f_1474_2716_2775("internalParameter");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 2647, 2791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 2907, 2926);

                string
                name = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 2940, 3554) || true) && (f_1474_2944_2984(internalParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 2940, 3554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 3018, 3057);

                    name = f_1474_3025_3056(internalParameter);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 3075, 3195) || true) && (f_1474_3079_3116(internalParameter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 3075, 3195);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 3158, 3176);

                        name = name + " ";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 3075, 3195);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 3215, 3303);

                    f_1474_3215_3302(name != null, "'name' variable should be initialized at this point");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 3321, 3410);

                    f_1474_3321_3409(f_1474_3340_3356(f_1474_3340_3347(name, 0)), "first character in parameter name must be a dash");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 3428, 3539);

                    f_1474_3428_3538(f_1474_3447_3465(f_1474_3447_3458(name)) != 1, "Parameter name has to have some non-whitespace characters in it");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 2940, 3554);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 3570, 3737) || true) && (f_1474_3574_3621(internalParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 3570, 3737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 3655, 3722);

                    return f_1474_3662_3721(name, f_1474_3689_3720(internalParameter));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 3570, 3737);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 3753, 3917) || true) && (name != null)
                ) // either a switch parameter or first part of parameter+argument

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 3753, 3917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 3868, 3902);

                    return f_1474_3875_3901(name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 3753, 3917);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 4013, 4080);

                return f_1474_4020_4079(null, f_1474_4047_4078(internalParameter));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1474, 2517, 4091);

                System.Management.Automation.PSArgumentNullException
                f_1474_2716_2775(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 2716, 2775);
                    return return_v;
                }


                bool
                f_1474_2944_2984(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterNameSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 2944, 2984);
                    return return_v;
                }


                string
                f_1474_3025_3056(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 3025, 3056);
                    return return_v;
                }


                bool
                f_1474_3079_3116(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.SpaceAfterParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 3079, 3116);
                    return return_v;
                }


                int
                f_1474_3215_3302(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 3215, 3302);
                    return 0;
                }


                char
                f_1474_3340_3347(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 3340, 3347);
                    return return_v;
                }


                bool
                f_1474_3340_3356(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 3340, 3356);
                    return return_v;
                }


                int
                f_1474_3321_3409(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 3321, 3409);
                    return 0;
                }


                string
                f_1474_3447_3458(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 3447, 3458);
                    return return_v;
                }


                int
                f_1474_3447_3465(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 3447, 3465);
                    return return_v;
                }


                int
                f_1474_3428_3538(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 3428, 3538);
                    return 0;
                }


                bool
                f_1474_3574_3621(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterAndArgumentSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 3574, 3621);
                    return return_v;
                }


                object
                f_1474_3689_3720(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 3689, 3720);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1474_3662_3721(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.Runspaces.CommandParameter(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 3662, 3721);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1474_3875_3901(string
                name)
                {
                    var return_v = new System.Management.Automation.Runspaces.CommandParameter(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 3875, 3901);
                    return return_v;
                }


                object
                f_1474_4047_4078(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 4047, 4078);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1474_4020_4079(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.Runspaces.CommandParameter(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 4020, 4079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1474, 2517, 4091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1474, 2517, 4091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CommandParameterInternal ToCommandParameterInternal(CommandParameter publicParameter, bool forNativeCommand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1474, 4103, 7376);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 4252, 4392) || true) && (publicParameter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 4252, 4392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 4313, 4377);

                    throw f_1474_4319_4376("publicParameter");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 4252, 4392);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 4408, 4443);

                string
                name = f_1474_4422_4442(publicParameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 4457, 4494);

                object
                value = f_1474_4472_4493(publicParameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 4510, 4643);

                f_1474_4510_4642((name == null) || (DynAbs.Tracing.TraceSender.Expression_False(1474, 4523, 4566) || (f_1474_4542_4560(f_1474_4542_4553(name)) != 0)), "Parameter name has to null or have some non-whitespace characters in it");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 4659, 4778) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 4659, 4778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 4709, 4763);

                    return f_1474_4716_4762(value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 4659, 4778);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 4794, 4815);

                string
                parameterText
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 4829, 5171) || true) && (!f_1474_4834_4850(f_1474_4834_4841(name, 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 4829, 5171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 4884, 4937);

                    parameterText = (DynAbs.Tracing.TraceSender.Conditional_F1(1474, 4900, 4916) || ((forNativeCommand && DynAbs.Tracing.TraceSender.Conditional_F2(1474, 4919, 4923)) || DynAbs.Tracing.TraceSender.Conditional_F3(1474, 4926, 4936))) ? name : "-" + name;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 4955, 5156);

                    return f_1474_4962_5155(null, name, parameterText, null, value, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 4829, 5171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 5414, 5447);

                bool
                spaceAfterParameter = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 5461, 5491);

                int
                endPosition = f_1474_5479_5490(name)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 5505, 5681) || true) && ((endPosition > 0) && (DynAbs.Tracing.TraceSender.Expression_True(1474, 5512, 5573) && f_1474_5533_5573(f_1474_5551_5572(name, endPosition - 1))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 5505, 5681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 5607, 5634);

                        spaceAfterParameter = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 5652, 5666);

                        endPosition--;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 5505, 5681);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1474, 5505, 5681);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1474, 5505, 5681);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 5697, 5794);

                f_1474_5697_5793(endPosition > 0, "parameter name should have some non-whitespace characters in it");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 5895, 5942);

                parameterText = f_1474_5911_5941(name, 0, endPosition);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 6073, 6120);

                bool
                hasColon = (f_1474_6090_6111(name, endPosition - 1) == ':')
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 6134, 6224);

                var
                parameterName = f_1474_6154_6223(parameterText, 1, f_1474_6181_6201(parameterText) - ((DynAbs.Tracing.TraceSender.Conditional_F1(1474, 6205, 6213) || ((hasColon && DynAbs.Tracing.TraceSender.Conditional_F2(1474, 6216, 6217)) || DynAbs.Tracing.TraceSender.Conditional_F3(1474, 6220, 6221))) ? 2 : 1))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 6915, 7104) || true) && (!hasColon && (DynAbs.Tracing.TraceSender.Expression_True(1474, 6919, 6945) && value == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 6915, 7104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 7011, 7089);

                    return f_1474_7018_7088(parameterName, parameterText);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 6915, 7104);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 7152, 7365);

                return f_1474_7159_7364(null, parameterName, parameterText, null, value, spaceAfterParameter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1474, 4103, 7376);

                System.Management.Automation.PSArgumentNullException
                f_1474_4319_4376(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 4319, 4376);
                    return return_v;
                }


                string
                f_1474_4422_4442(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 4422, 4442);
                    return return_v;
                }


                object
                f_1474_4472_4493(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 4472, 4493);
                    return return_v;
                }


                string
                f_1474_4542_4553(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 4542, 4553);
                    return return_v;
                }


                int
                f_1474_4542_4560(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 4542, 4560);
                    return return_v;
                }


                int
                f_1474_4510_4642(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Debug.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 4510, 4642);
                    return 0;
                }


                System.Management.Automation.CommandParameterInternal
                f_1474_4716_4762(object
                value)
                {
                    var return_v = CommandParameterInternal.CreateArgument(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 4716, 4762);
                    return return_v;
                }


                char
                f_1474_4834_4841(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 4834, 4841);
                    return return_v;
                }


                bool
                f_1474_4834_4850(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 4834, 4850);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1474_4962_5155(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 4962, 5155);
                    return return_v;
                }


                int
                f_1474_5479_5490(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 5479, 5490);
                    return return_v;
                }


                char
                f_1474_5551_5572(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 5551, 5572);
                    return return_v;
                }


                bool
                f_1474_5533_5573(char
                c)
                {
                    var return_v = char.IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 5533, 5573);
                    return return_v;
                }


                int
                f_1474_5697_5793(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Debug.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 5697, 5793);
                    return 0;
                }


                string
                f_1474_5911_5941(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 5911, 5941);
                    return return_v;
                }


                char
                f_1474_6090_6111(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 6090, 6111);
                    return return_v;
                }


                int
                f_1474_6181_6201(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 6181, 6201);
                    return return_v;
                }


                string
                f_1474_6154_6223(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 6154, 6223);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1474_7018_7088(string
                parameterName, string
                parameterText)
                {
                    var return_v = CommandParameterInternal.CreateParameter(parameterName, parameterText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 7018, 7088);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1474_7159_7364(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 7159, 7364);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1474, 4103, 7376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1474, 4103, 7376);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CommandParameter FromPSObjectForRemoting(PSObject parameterAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1474, 8203, 8786);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 8314, 8462) || true) && (parameterAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1474, 8314, 8462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 8379, 8447);

                    throw f_1474_8385_8446("parameterAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1474, 8314, 8462);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 8478, 8591);

                string
                name = f_1474_8492_8590(parameterAsPSObject, RemoteDataNameStrings.ParameterName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 8605, 8720);

                object
                value = f_1474_8620_8719(parameterAsPSObject, RemoteDataNameStrings.ParameterValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 8734, 8775);

                return f_1474_8741_8774(name, value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1474, 8203, 8786);

                System.Management.Automation.PSArgumentNullException
                f_1474_8385_8446(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 8385, 8446);
                    return return_v;
                }


                string
                f_1474_8492_8590(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 8492, 8590);
                    return return_v;
                }


                object
                f_1474_8620_8719(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<object>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 8620, 8719);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1474_8741_8774(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.Runspaces.CommandParameter(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 8741, 8774);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1474, 8203, 8786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1474, 8203, 8786);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSObject ToPSObjectForRemoting()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1474, 9043, 9466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 9109, 9178);

                PSObject
                parameterAsPSObject = f_1474_9140_9177()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 9192, 9295);

                f_1474_9192_9294(f_1474_9192_9222(parameterAsPSObject), f_1474_9227_9293(RemoteDataNameStrings.ParameterName, f_1474_9283_9292(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 9309, 9414);

                f_1474_9309_9413(f_1474_9309_9339(parameterAsPSObject), f_1474_9344_9412(RemoteDataNameStrings.ParameterValue, f_1474_9401_9411(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 9428, 9455);

                return parameterAsPSObject;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1474, 9043, 9466);

                System.Management.Automation.PSObject
                f_1474_9140_9177()
                {
                    var return_v = RemotingEncoder.CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 9140, 9177);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1474_9192_9222(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 9192, 9222);
                    return return_v;
                }


                string
                f_1474_9283_9292(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 9283, 9292);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1474_9227_9293(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 9227, 9293);
                    return return_v;
                }


                int
                f_1474_9192_9294(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 9192, 9294);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1474_9309_9339(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 9309, 9339);
                    return return_v;
                }


                object
                f_1474_9401_9411(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1474, 9401, 9411);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1474_9344_9412(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 9344, 9412);
                    return return_v;
                }


                int
                f_1474_9309_9413(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 9309, 9413);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1474, 9043, 9466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1474, 9043, 9466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommandParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1474, 469, 10831);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1474, 469, 10831);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1474, 469, 10831);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1474, 469, 10831);

        System.Management.Automation.PSArgumentNullException
        f_1474_1113_1159(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 1113, 1159);
            return return_v;
        }


        static string
        f_1474_1021_1025_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1474, 964, 1186);
            return return_v;
        }


        bool
        f_1474_1684_1715(string
        value)
        {
            var return_v = string.IsNullOrWhiteSpace(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 1684, 1715);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1474_1763_1805(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 1763, 1805);
            return return_v;
        }

    }
    public sealed class CommandParameterCollection : Collection<CommandParameter>
    {
        public CommandParameterCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1474, 11203, 11260);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1474, 11203, 11260);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1474, 11203, 11260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1474, 11203, 11260);
            }
        }

        public void Add(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1474, 11694, 11790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 11747, 11779);

                f_1474_11747_11778(this, f_1474_11751_11777(name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1474, 11694, 11790);

                System.Management.Automation.Runspaces.CommandParameter
                f_1474_11751_11777(string
                name)
                {
                    var return_v = new System.Management.Automation.Runspaces.CommandParameter(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 11751, 11777);
                    return return_v;
                }


                int
                f_1474_11747_11778(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, System.Management.Automation.Runspaces.CommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 11747, 11778);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1474, 11694, 11790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1474, 11694, 11790);
            }
        }

        public void Add(string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1474, 12344, 12461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1474, 12411, 12450);

                f_1474_12411_12449(this, f_1474_12415_12448(name, value));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1474, 12344, 12461);

                System.Management.Automation.Runspaces.CommandParameter
                f_1474_12415_12448(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.Runspaces.CommandParameter(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 12415, 12448);
                    return return_v;
                }


                int
                f_1474_12411_12449(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, System.Management.Automation.Runspaces.CommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1474, 12411, 12449);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1474, 12344, 12461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1474, 12344, 12461);
            }
        }

        static CommandParameterCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1474, 10923, 12468);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1474, 10923, 12468);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1474, 10923, 12468);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1474, 10923, 12468);
    }
}

