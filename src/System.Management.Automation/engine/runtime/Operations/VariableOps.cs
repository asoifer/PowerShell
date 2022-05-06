// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Linq;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;

// ReSharper disable UnusedMember.Local

namespace System.Management.Automation
{
    using Dbg = Diagnostics;
    using System.Collections.ObjectModel;
    internal static class VariableOps
    {
        internal static object SetVariableValue(VariablePath variablePath, object value, ExecutionContext executionContext, AttributeBaseAst[] attributeAsts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1667, 429, 4991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 603, 675);

                SessionStateInternal
                sessionState = f_1667_639_674(executionContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 689, 750);

                CommandOrigin
                origin = f_1667_712_749(f_1667_712_737(sessionState))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 766, 934) || true) && (f_1667_770_794_M(!variablePath.IsVariable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 766, 934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 828, 888);

                    f_1667_828_887(sessionState, variablePath, value, true, origin);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 906, 919);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 766, 934);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 1032, 1203) || true) && (f_1667_1036_1070(executionContext) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 1032, 1203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 1108, 1188);

                    f_1667_1108_1187(f_1667_1108_1133(executionContext), f_1667_1151_1179(variablePath), value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 1032, 1203);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 1219, 1350) || true) && (f_1667_1223_1254(variablePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 1219, 1350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 1288, 1335);

                    variablePath = f_1667_1303_1334(variablePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 1219, 1350);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 1366, 1390);

                SessionStateScope
                scope
                = default(SessionStateScope);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 1404, 1483);

                PSVariable
                var = f_1667_1421_1482(sessionState, variablePath, out scope, origin)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 1499, 4951) || true) && (var == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 1499, 4951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 1548, 1733);

                    var
                    attributes = (DynAbs.Tracing.TraceSender.Conditional_F1(1667, 1565, 1586) || ((attributeAsts == null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1667, 1627, 1654)) || DynAbs.Tracing.TraceSender.Conditional_F3(1667, 1695, 1732))) ? f_1667_1627_1654() : f_1667_1695_1732(attributeAsts)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 1751, 1845);

                    var = f_1667_1757_1844(f_1667_1772_1800(variablePath), value, ScopedItemOptions.None, attributes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 2018, 2077);

                    f_1667_2018_2076(
                                    // Marking untrusted values for assignments in 'ConstrainedLanguage' mode is done in
                                    // SessionStateScope.SetVariable.
                                    sessionState, variablePath, var, false, origin);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 2097, 2272) || true) && (executionContext._debuggingMode > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 2097, 2272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 2178, 2253);

                        f_1667_2178_2252(f_1667_2178_2203(executionContext), f_1667_2223_2251(variablePath));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 2097, 2272);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 1499, 4951);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 1499, 4951);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 2338, 4526) || true) && (attributeAsts != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 2338, 4526);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 2612, 3193) || true) && ((f_1667_2617_2628(var) & (ScopedItemOptions.ReadOnly | ScopedItemOptions.Constant)) != ScopedItemOptions.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 2612, 3193);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 2765, 3136);

                            SessionStateUnauthorizedAccessException
                            e =
                            f_1667_2838_3135(f_1667_2920_2928(var), SessionStateCategory.Variable, "VariableNotWritable", f_1667_3095_3134())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 3162, 3170);

                            throw e;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 2612, 3193);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 3217, 3272);

                        var
                        attributes = f_1667_3234_3271(attributeAsts)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 3294, 3347);

                        value = f_1667_3302_3346(attributes, value);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 3369, 3851) || true) && (!f_1667_3374_3416(attributes, value))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 3369, 3851);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 3466, 3792);

                            ValidationMetadataException
                            e = f_1667_3498_3791("ValidateSetFailure", null, f_1667_3646_3674(), f_1667_3705_3713(var), ((DynAbs.Tracing.TraceSender.Conditional_F1(1667, 3745, 3760) || (((value != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1667, 3763, 3779)) || DynAbs.Tracing.TraceSender.Conditional_F3(1667, 3782, 3789))) ? f_1667_3763_3779(value) : "$null"))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 3820, 3828);

                            throw e;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 3369, 3851);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 3875, 3904);

                        f_1667_3875_3903(
                                            var, value, true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 4027, 4050);

                        f_1667_4027_4049(f_1667_4027_4041(var));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 4072, 4119);

                        f_1667_4072_4118(var, attributes);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 4143, 4330) || true) && (executionContext._debuggingMode > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 4143, 4330);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 4232, 4307);

                            f_1667_4232_4306(f_1667_4232_4257(executionContext), f_1667_4277_4305(variablePath));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 4143, 4330);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 2338, 4526);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 2338, 4526);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 4489, 4507);

                        var.Value = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 2338, 4526);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 4546, 4936) || true) && (f_1667_4550_4579(executionContext) == PSLanguageMode.ConstrainedLanguage)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 4546, 4936);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 4831, 4917);

                        f_1667_4831_4916(var, scope, sessionState);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 4546, 4936);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 1499, 4951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 4967, 4980);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1667, 429, 4991);

                System.Management.Automation.SessionStateInternal
                f_1667_639_674(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 639, 674);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1667_712_737(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 712, 737);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1667_712_749(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScopeOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 712, 749);
                    return return_v;
                }


                bool
                f_1667_770_794_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 770, 794);
                    return return_v;
                }


                object
                f_1667_828_887(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, object
                newValue, bool
                asValue, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(variablePath, newValue, asValue, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 828, 887);
                    return return_v;
                }


                int
                f_1667_1036_1070(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.PSDebugTraceLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 1036, 1070);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1667_1108_1133(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 1108, 1133);
                    return return_v;
                }


                string
                f_1667_1151_1179(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 1151, 1179);
                    return return_v;
                }


                int
                f_1667_1108_1187(System.Management.Automation.ScriptDebugger
                this_param, string
                varName, object
                value)
                {
                    this_param.TraceVariableSet(varName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 1108, 1187);
                    return 0;
                }


                bool
                f_1667_1223_1254(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsUnscopedVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 1223, 1254);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1667_1303_1334(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.CloneAndSetLocal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 1303, 1334);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1667_1421_1482(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.SessionStateScope
                scope, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.GetVariableItem(variablePath, out scope, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 1421, 1482);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1667_1627_1654()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 1627, 1654);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1667_1695_1732(System.Management.Automation.Language.AttributeBaseAst[]
                attributeAsts)
                {
                    var return_v = GetAttributeCollection(attributeAsts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 1695, 1732);
                    return return_v;
                }


                string
                f_1667_1772_1800(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 1772, 1800);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1667_1757_1844(string
                name, object
                value, System.Management.Automation.ScopedItemOptions
                options, System.Collections.ObjectModel.Collection<System.Attribute>
                attributes)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, value, options, attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 1757, 1844);
                    return return_v;
                }


                object
                f_1667_2018_2076(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, System.Management.Automation.PSVariable
                newValue, bool
                asValue, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(variablePath, (object)newValue, asValue, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 2018, 2076);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1667_2178_2203(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 2178, 2203);
                    return return_v;
                }


                string
                f_1667_2223_2251(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 2223, 2251);
                    return return_v;
                }


                int
                f_1667_2178_2252(System.Management.Automation.ScriptDebugger
                this_param, string
                variableName)
                {
                    this_param.CheckVariableWrite(variableName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 2178, 2252);
                    return 0;
                }


                System.Management.Automation.ScopedItemOptions
                f_1667_2617_2628(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 2617, 2628);
                    return return_v;
                }


                string
                f_1667_2920_2928(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 2920, 2928);
                    return return_v;
                }


                string
                f_1667_3095_3134()
                {
                    var return_v = SessionStateStrings.VariableNotWritable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 3095, 3134);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1667_2838_3135(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 2838, 3135);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1667_3234_3271(System.Management.Automation.Language.AttributeBaseAst[]
                attributeAsts)
                {
                    var return_v = GetAttributeCollection(attributeAsts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 3234, 3271);
                    return return_v;
                }


                object
                f_1667_3302_3346(System.Collections.ObjectModel.Collection<System.Attribute>
                attributes, object
                value)
                {
                    var return_v = PSVariable.TransformValue((System.Collections.Generic.IEnumerable<System.Attribute>)attributes, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 3302, 3346);
                    return return_v;
                }


                bool
                f_1667_3374_3416(System.Collections.ObjectModel.Collection<System.Attribute>
                attributes, object
                value)
                {
                    var return_v = PSVariable.IsValidValue((System.Collections.Generic.IEnumerable<System.Attribute>)attributes, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 3374, 3416);
                    return return_v;
                }


                string
                f_1667_3646_3674()
                {
                    var return_v = Metadata.InvalidValueFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 3646, 3674);
                    return return_v;
                }


                string
                f_1667_3705_3713(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 3705, 3713);
                    return return_v;
                }


                string?
                f_1667_3763_3779(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 3763, 3779);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1667_3498_3791(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 3498, 3791);
                    return return_v;
                }


                int
                f_1667_3875_3903(System.Management.Automation.PSVariable
                this_param, object
                newValue, bool
                preserveValueTypeSemantics)
                {
                    this_param.SetValueRaw(newValue, preserveValueTypeSemantics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 3875, 3903);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1667_4027_4041(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 4027, 4041);
                    return return_v;
                }


                int
                f_1667_4027_4049(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 4027, 4049);
                    return 0;
                }


                int
                f_1667_4072_4118(System.Management.Automation.PSVariable
                this_param, System.Collections.ObjectModel.Collection<System.Attribute>
                attributes)
                {
                    this_param.AddParameterAttributesNoChecks(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 4072, 4118);
                    return 0;
                }


                System.Management.Automation.ScriptDebugger
                f_1667_4232_4257(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 4232, 4257);
                    return return_v;
                }


                string
                f_1667_4277_4305(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 4277, 4305);
                    return return_v;
                }


                int
                f_1667_4232_4306(System.Management.Automation.ScriptDebugger
                this_param, string
                variableName)
                {
                    this_param.CheckVariableWrite(variableName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 4232, 4306);
                    return 0;
                }


                System.Management.Automation.PSLanguageMode
                f_1667_4550_4579(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 4550, 4579);
                    return return_v;
                }


                int
                f_1667_4831_4916(System.Management.Automation.PSVariable
                variable, System.Management.Automation.SessionStateScope
                scope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    ExecutionContext.MarkObjectAsUntrustedForVariableAssignment(variable, scope, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 4831, 4916);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1667, 429, 4991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1667, 429, 4991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ThrowStrictModeUndefinedVariable(ExecutionContext executionContext, VariableExpressionAst varAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1667, 5003, 6030);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 5355, 5435) || true) && (varAst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 5355, 5435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 5407, 5420);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 5355, 5435);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 5451, 5551) || true) && (f_1667_5455_5490(executionContext, 2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 5451, 5551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 5524, 5536);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 5451, 5551);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 5567, 5990) || true) && (f_1667_5571_5606(executionContext, 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 5567, 5990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 5640, 5667);

                    var
                    parent = f_1667_5653_5666(varAst)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 5685, 5943) || true) && (parent != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 5685, 5943);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 5748, 5877) || true) && (parent is ExpandableStringExpressionAst)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 5748, 5877);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 5841, 5854);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 5748, 5877);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 5901, 5924);

                            parent = f_1667_5910_5923(parent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 5685, 5943);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1667, 5685, 5943);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1667, 5685, 5943);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 5963, 5975);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 5567, 5990);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 6006, 6019);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1667, 5003, 6030);

                bool
                f_1667_5455_5490(System.Management.Automation.ExecutionContext
                this_param, int
                majorVersion)
                {
                    var return_v = this_param.IsStrictVersion(majorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 5455, 5490);
                    return return_v;
                }


                bool
                f_1667_5571_5606(System.Management.Automation.ExecutionContext
                this_param, int
                majorVersion)
                {
                    var return_v = this_param.IsStrictVersion(majorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 5571, 5606);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1667_5653_5666(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 5653, 5666);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1667_5910_5923(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 5910, 5923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1667, 5003, 6030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1667, 5003, 6030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object GetAutomaticVariableValue(int tupleIndex, ExecutionContext executionContext, VariableExpressionAst varAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1667, 6042, 7212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 6196, 6324);

                f_1667_6196_6323(tupleIndex < f_1667_6228_6274(SpecialVariables.AutomaticVariableTypes), "caller to verify a valid tuple index is used");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 6340, 6521) || true) && (executionContext._debuggingMode > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 6340, 6521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 6413, 6506);

                    f_1667_6413_6505(f_1667_6413_6438(executionContext), SpecialVariables.AutomaticVariables[tupleIndex]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 6340, 6521);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 6537, 6646);

                object
                result = f_1667_6553_6645(f_1667_6553_6588(executionContext), tupleIndex)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 6662, 7171) || true) && (result == f_1667_6676_6696())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 6662, 7171);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 6730, 7122) || true) && (f_1667_6734_6792(executionContext, varAst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 6730, 7122);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 6834, 7103);

                        throw f_1667_6840_7102(SpecialVariables.AutomaticVariables[tupleIndex], typeof(RuntimeException), f_1667_6981_6994(varAst), "VariableIsUndefined", f_1667_7019_7052(), SpecialVariables.AutomaticVariables[tupleIndex]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 6730, 7122);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 7142, 7156);

                    result = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 6662, 7171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 7187, 7201);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1667, 6042, 7212);

                int
                f_1667_6228_6274(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 6228, 6274);
                    return return_v;
                }


                int
                f_1667_6196_6323(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 6196, 6323);
                    return 0;
                }


                System.Management.Automation.ScriptDebugger
                f_1667_6413_6438(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 6413, 6438);
                    return return_v;
                }


                int
                f_1667_6413_6505(System.Management.Automation.ScriptDebugger
                this_param, string
                variableName)
                {
                    this_param.CheckVariableRead(variableName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 6413, 6505);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1667_6553_6588(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 6553, 6588);
                    return return_v;
                }


                object
                f_1667_6553_6645(System.Management.Automation.SessionStateInternal
                this_param, int
                variable)
                {
                    var return_v = this_param.GetAutomaticVariableValue((System.Management.Automation.AutomaticVariable)variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 6553, 6645);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1667_6676_6696()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 6676, 6696);
                    return return_v;
                }


                bool
                f_1667_6734_6792(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.Language.VariableExpressionAst
                varAst)
                {
                    var return_v = ThrowStrictModeUndefinedVariable(executionContext, varAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 6734, 6792);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1667_6981_6994(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 6981, 6994);
                    return return_v;
                }


                string
                f_1667_7019_7052()
                {
                    var return_v = ParserStrings.VariableIsUndefined;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 7019, 7052);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1667_6840_7102(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 6840, 7102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1667, 6042, 7212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1667, 6042, 7212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object GetVariableValue(VariablePath variablePath, ExecutionContext executionContext, VariableExpressionAst varAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1667, 7224, 8721);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 7380, 7745) || true) && (f_1667_7384_7408_M(!variablePath.IsVariable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 7380, 7745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 7442, 7475);

                    CmdletProviderContext
                    contextOut
                    = default(CmdletProviderContext);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 7493, 7520);

                    SessionStateScope
                    scopeOut
                    = default(SessionStateScope);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 7538, 7600);

                    SessionStateInternal
                    ss = f_1667_7564_7599(executionContext)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 7618, 7730);

                    return f_1667_7625_7729(ss, variablePath, out contextOut, out scopeOut, f_1667_7701_7728(f_1667_7701_7716(ss)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 7380, 7745);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 7761, 7833);

                SessionStateInternal
                sessionState = f_1667_7797_7832(executionContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 7847, 7908);

                CommandOrigin
                origin = f_1667_7870_7907(f_1667_7870_7895(sessionState))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 7924, 7948);

                SessionStateScope
                scope
                = default(SessionStateScope);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 7962, 8041);

                PSVariable
                var = f_1667_7979_8040(sessionState, variablePath, out scope, origin)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 8057, 8138) || true) && (var != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 8057, 8138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 8106, 8123);

                    return f_1667_8113_8122(var);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 8057, 8138);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 8154, 8342) || true) && (f_1667_8158_8187(sessionState)._debuggingMode > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 8154, 8342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 8240, 8327);

                    f_1667_8240_8326(f_1667_8240_8278(f_1667_8240_8269(sessionState)), f_1667_8297_8325(variablePath));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 8154, 8342);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 8358, 8682) || true) && (f_1667_8362_8420(executionContext, varAst))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 8358, 8682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 8454, 8667);

                    throw f_1667_8460_8666(f_1667_8501_8522(variablePath), typeof(RuntimeException), f_1667_8571_8584(varAst), "VariableIsUndefined", f_1667_8609_8642(), f_1667_8644_8665(variablePath));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 8358, 8682);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 8698, 8710);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1667, 7224, 8721);

                bool
                f_1667_7384_7408_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 7384, 7408);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1667_7564_7599(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 7564, 7599);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1667_7701_7716(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 7701, 7716);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1667_7701_7728(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScopeOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 7701, 7728);
                    return return_v;
                }


                object
                f_1667_7625_7729(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.SessionStateScope
                scope, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.GetVariableValueFromProvider(variablePath, out context, out scope, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 7625, 7729);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1667_7797_7832(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 7797, 7832);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1667_7870_7895(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 7870, 7895);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1667_7870_7907(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScopeOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 7870, 7907);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1667_7979_8040(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.SessionStateScope
                scope, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.GetVariableItem(variablePath, out scope, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 7979, 8040);
                    return return_v;
                }


                object
                f_1667_8113_8122(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 8113, 8122);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1667_8158_8187(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 8158, 8187);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1667_8240_8269(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 8240, 8269);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1667_8240_8278(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 8240, 8278);
                    return return_v;
                }


                string
                f_1667_8297_8325(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 8297, 8325);
                    return return_v;
                }


                int
                f_1667_8240_8326(System.Management.Automation.ScriptDebugger
                this_param, string
                variableName)
                {
                    this_param.CheckVariableRead(variableName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 8240, 8326);
                    return 0;
                }


                bool
                f_1667_8362_8420(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.Language.VariableExpressionAst
                varAst)
                {
                    var return_v = ThrowStrictModeUndefinedVariable(executionContext, varAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 8362, 8420);
                    return return_v;
                }


                string
                f_1667_8501_8522(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 8501, 8522);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1667_8571_8584(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 8571, 8584);
                    return return_v;
                }


                string
                f_1667_8609_8642()
                {
                    var return_v = ParserStrings.VariableIsUndefined;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 8609, 8642);
                    return return_v;
                }


                string
                f_1667_8644_8665(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 8644, 8665);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1667_8460_8666(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 8460, 8666);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1667, 7224, 8721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1667, 7224, 8721);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSReference GetVariableAsRef(VariablePath variablePath, ExecutionContext executionContext, Type staticType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1667, 8733, 10308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 8881, 8969);

                f_1667_8881_8968(f_1667_8900_8923(variablePath), "calller to verify varpath is a variable.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 8985, 9057);

                SessionStateInternal
                sessionState = f_1667_9021_9056(executionContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 9071, 9132);

                CommandOrigin
                origin = f_1667_9094_9131(f_1667_9094_9119(sessionState))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 9148, 9172);

                SessionStateScope
                scope
                = default(SessionStateScope);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 9186, 9265);

                PSVariable
                var = f_1667_9203_9264(sessionState, variablePath, out scope, origin)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 9281, 9642) || true) && (var == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 9281, 9642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 9330, 9627);

                    throw f_1667_9336_9626(variablePath, typeof(RuntimeException), null, "NonExistingVariableReference", f_1667_9583_9625());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 9281, 9642);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 9658, 9683);

                object
                value = f_1667_9673_9682(var)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 9697, 9939) || true) && (staticType == null && (DynAbs.Tracing.TraceSender.Expression_True(1667, 9701, 9736) && value != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 9697, 9939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 9770, 9799);

                    value = f_1667_9778_9798(value);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 9817, 9924) || true) && (value != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 9817, 9924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 9876, 9905);

                        staticType = f_1667_9889_9904(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 9817, 9924);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 9697, 9939);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 9955, 10230) || true) && (staticType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 9955, 10230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 10011, 10103);

                    var
                    declaredType = f_1667_10030_10102(f_1667_10030_10085(f_1667_10030_10044(var)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 10121, 10215);

                    staticType = (DynAbs.Tracing.TraceSender.Conditional_F1(1667, 10134, 10154) || ((declaredType != null && DynAbs.Tracing.TraceSender.Conditional_F2(1667, 10157, 10180)) || DynAbs.Tracing.TraceSender.Conditional_F3(1667, 10183, 10214))) ? f_1667_10157_10180(declaredType) : typeof(LanguagePrimitives.Null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 9955, 10230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 10246, 10297);

                return f_1667_10253_10296(var, staticType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1667, 8733, 10308);

                bool
                f_1667_8900_8923(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 8900, 8923);
                    return return_v;
                }


                int
                f_1667_8881_8968(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 8881, 8968);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1667_9021_9056(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 9021, 9056);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1667_9094_9119(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 9094, 9119);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1667_9094_9131(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScopeOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 9094, 9131);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1667_9203_9264(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.SessionStateScope
                scope, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.GetVariableItem(variablePath, out scope, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 9203, 9264);
                    return return_v;
                }


                string
                f_1667_9583_9625()
                {
                    var return_v = ParserStrings.NonExistingVariableReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 9583, 9625);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1667_9336_9626(System.Management.Automation.VariablePath
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 9336, 9626);
                    return return_v;
                }


                object
                f_1667_9673_9682(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 9673, 9682);
                    return return_v;
                }


                object
                f_1667_9778_9798(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 9778, 9798);
                    return return_v;
                }


                System.Type
                f_1667_9889_9904(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 9889, 9904);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1667_10030_10044(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 10030, 10044);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ArgumentTypeConverterAttribute>
                f_1667_10030_10085(System.Collections.ObjectModel.Collection<System.Attribute>
                source)
                {
                    var return_v = source.OfType<System.Management.Automation.ArgumentTypeConverterAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 10030, 10085);
                    return return_v;
                }


                System.Management.Automation.ArgumentTypeConverterAttribute
                f_1667_10030_10102(System.Collections.Generic.IEnumerable<System.Management.Automation.ArgumentTypeConverterAttribute>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.ArgumentTypeConverterAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 10030, 10102);
                    return return_v;
                }


                System.Type
                f_1667_10157_10180(System.Management.Automation.ArgumentTypeConverterAttribute
                this_param)
                {
                    var return_v = this_param.TargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 10157, 10180);
                    return return_v;
                }


                System.Management.Automation.PSReference
                f_1667_10253_10296(System.Management.Automation.PSVariable
                value, System.Type
                typeOfValue)
                {
                    var return_v = PSReference.CreateInstance((object)value, typeOfValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 10253, 10296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1667, 8733, 10308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1667, 8733, 10308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Collection<Attribute> GetAttributeCollection(AttributeBaseAst[] attributeAsts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1667, 10320, 10665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 10438, 10479);

                var
                result = f_1667_10451_10478()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 10493, 10624);
                    foreach (var attributeAst in f_1667_10522_10535_I(attributeAsts))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 10493, 10624);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 10569, 10609);

                        f_1667_10569_10608(result, f_1667_10580_10607(attributeAst));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 10493, 10624);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1667, 1, 132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1667, 1, 132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 10640, 10654);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1667, 10320, 10665);

                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1667_10451_10478()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 10451, 10478);
                    return return_v;
                }


                System.Attribute
                f_1667_10580_10607(System.Management.Automation.Language.AttributeBaseAst
                this_param)
                {
                    var return_v = this_param.GetAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 10580, 10607);
                    return return_v;
                }


                int
                f_1667_10569_10608(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Attribute
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 10569, 10608);
                    return 0;
                }


                System.Management.Automation.Language.AttributeBaseAst[]
                f_1667_10522_10535_I(System.Management.Automation.Language.AttributeBaseAst[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 10522, 10535);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1667, 10320, 10665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1667, 10320, 10665);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static UsingResult GetUsingValueFromTuple(MutableTuple tuple, string usingExpressionKey, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1667, 10677, 11778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 10809, 10943);

                var
                boundParameters =
                f_1667_10848_10911(tuple, AutomaticVariable.PSBoundParameters) as PSBoundParametersDictionary
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 10957, 11739) || true) && (boundParameters != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 10957, 11739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 11018, 11088);

                    var
                    implicitUsingParameters = f_1667_11048_11087(boundParameters)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 11106, 11724) || true) && (implicitUsingParameters != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 11106, 11724);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 11183, 11705) || true) && (f_1667_11187_11239(implicitUsingParameters, usingExpressionKey))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 11183, 11705);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 11289, 11368);

                            return new UsingResult { Value = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1667_11322_11365(implicitUsingParameters, usingExpressionKey), 1667, 11296, 11367) };
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 11183, 11705);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 11183, 11705);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 11418, 11705) || true) && (f_1667_11422_11461(implicitUsingParameters, index))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 11418, 11705);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 11616, 11682);

                                return new UsingResult { Value = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1667_11649_11679(implicitUsingParameters, index), 1667, 11623, 11681) };
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 11418, 11705);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 11183, 11705);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 11106, 11724);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 10957, 11739);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 11755, 11767);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1667, 10677, 11778);

                object
                f_1667_10848_10911(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto)
                {
                    var return_v = this_param.GetAutomaticVariable(auto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 10848, 10911);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1667_11048_11087(System.Management.Automation.PSBoundParametersDictionary
                this_param)
                {
                    var return_v = this_param.ImplicitUsingParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 11048, 11087);
                    return return_v;
                }


                bool
                f_1667_11187_11239(System.Collections.IDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.Contains((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 11187, 11239);
                    return return_v;
                }


                object
                f_1667_11322_11365(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 11322, 11365);
                    return return_v;
                }


                bool
                f_1667_11422_11461(System.Collections.IDictionary
                this_param, int
                key)
                {
                    var return_v = this_param.Contains((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 11422, 11461);
                    return return_v;
                }


                object
                f_1667_11649_11679(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 11649, 11679);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1667, 10677, 11778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1667, 10677, 11778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class UsingResult
        {
            public object Value { get; set; }

            public UsingResult()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1667, 11790, 11884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 11840, 11873);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1667, 11790, 11884);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1667, 11790, 11884);
            }


            static UsingResult()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1667, 11790, 11884);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1667, 11790, 11884);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1667, 11790, 11884);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1667, 11790, 11884);
        }

        internal static object GetUsingValue(MutableTuple tuple, string usingExpressionKey, int index, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1667, 11896, 13322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 12041, 12119);

                UsingResult
                result = f_1667_12062_12118(tuple, usingExpressionKey, index)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 12133, 12220) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 12133, 12220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 12185, 12205);

                    return f_1667_12192_12204(result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 12133, 12220);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 12236, 12288);

                var
                scope = f_1667_12248_12287(f_1667_12248_12274(context))
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 12302, 12939) || true) && (scope != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 12302, 12939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 12356, 12434);

                        result = f_1667_12365_12433(f_1667_12388_12405(scope), usingExpressionKey, index);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 12452, 12551) || true) && (result != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 12452, 12551);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 12512, 12532);

                            return f_1667_12519_12531(result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 12452, 12551);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 12571, 12883);
                            foreach (var dottedScope in f_1667_12599_12617_I(f_1667_12599_12617(scope)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 12571, 12883);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 12659, 12731);

                                result = f_1667_12668_12730(dottedScope, usingExpressionKey, index);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 12753, 12864) || true) && (result != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1667, 12753, 12864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 12821, 12841);

                                    return f_1667_12828_12840(result);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 12753, 12864);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 12571, 12883);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1667, 1, 313);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1667, 1, 313);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 12903, 12924);

                        scope = f_1667_12911_12923(scope);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1667, 12302, 12939);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1667, 12302, 12939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1667, 12302, 12939);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1667, 13139, 13311);

                throw f_1667_13145_13310(null, typeof(RuntimeException), null, "UsingWithoutInvokeCommand", f_1667_13270_13309());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1667, 11896, 13322);

                System.Management.Automation.VariableOps.UsingResult
                f_1667_12062_12118(System.Management.Automation.MutableTuple
                tuple, string
                usingExpressionKey, int
                index)
                {
                    var return_v = GetUsingValueFromTuple(tuple, usingExpressionKey, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 12062, 12118);
                    return return_v;
                }


                object
                f_1667_12192_12204(System.Management.Automation.VariableOps.UsingResult
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 12192, 12204);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1667_12248_12274(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 12248, 12274);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1667_12248_12287(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 12248, 12287);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1667_12388_12405(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.LocalsTuple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 12388, 12405);
                    return return_v;
                }


                System.Management.Automation.VariableOps.UsingResult
                f_1667_12365_12433(System.Management.Automation.MutableTuple
                tuple, string
                usingExpressionKey, int
                index)
                {
                    var return_v = GetUsingValueFromTuple(tuple, usingExpressionKey, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 12365, 12433);
                    return return_v;
                }


                object
                f_1667_12519_12531(System.Management.Automation.VariableOps.UsingResult
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 12519, 12531);
                    return return_v;
                }


                System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                f_1667_12599_12617(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.DottedScopes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 12599, 12617);
                    return return_v;
                }


                System.Management.Automation.VariableOps.UsingResult
                f_1667_12668_12730(System.Management.Automation.MutableTuple
                tuple, string
                usingExpressionKey, int
                index)
                {
                    var return_v = GetUsingValueFromTuple(tuple, usingExpressionKey, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 12668, 12730);
                    return return_v;
                }


                object
                f_1667_12828_12840(System.Management.Automation.VariableOps.UsingResult
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 12828, 12840);
                    return return_v;
                }


                System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                f_1667_12599_12617_I(System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 12599, 12617);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1667_12911_12923(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 12911, 12923);
                    return return_v;
                }


                string
                f_1667_13270_13309()
                {
                    var return_v = ParserStrings.UsingWithoutInvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1667, 13270, 13309);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1667_13145_13310(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1667, 13145, 13310);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1667, 11896, 13322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1667, 11896, 13322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static VariableOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1667, 379, 13329);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1667, 379, 13329);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1667, 379, 13329);
        }

    }
}
