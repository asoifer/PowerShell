// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Internal;
using System.Management.Automation.Provider;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings
#pragma warning disable 56500

namespace System.Management.Automation
{
    internal sealed partial class SessionStateInternal
    {
        internal void AddSessionStateEntry(SessionStateVariableEntry entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 932, 1290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 1024, 1152);

                PSVariable
                v = f_1360_1039_1151(f_1360_1054_1064(entry), f_1360_1066_1077(entry), f_1360_1100_1113(entry), f_1360_1115_1131(entry), f_1360_1133_1150(entry))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 1166, 1198);

                v.Visibility = f_1360_1181_1197(entry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 1212, 1279);

                f_1360_1212_1278(this, v, "global", true, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 932, 1290);

                string
                f_1360_1054_1064(System.Management.Automation.Runspaces.SessionStateVariableEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 1054, 1064);
                    return return_v;
                }


                object
                f_1360_1066_1077(System.Management.Automation.Runspaces.SessionStateVariableEntry
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 1066, 1077);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1360_1100_1113(System.Management.Automation.Runspaces.SessionStateVariableEntry
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 1100, 1113);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1360_1115_1131(System.Management.Automation.Runspaces.SessionStateVariableEntry
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 1115, 1131);
                    return return_v;
                }


                string
                f_1360_1133_1150(System.Management.Automation.Runspaces.SessionStateVariableEntry
                this_param)
                {
                    var return_v = this_param.Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 1133, 1150);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1360_1039_1151(string
                name, object
                value, System.Management.Automation.ScopedItemOptions
                options, System.Collections.ObjectModel.Collection<System.Attribute>
                attributes, string
                description)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, value, options, attributes, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 1039, 1151);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1360_1181_1197(System.Management.Automation.Runspaces.SessionStateVariableEntry
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 1181, 1197);
                    return return_v;
                }


                object
                f_1360_1212_1278(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.PSVariable
                variable, string
                scopeID, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariableAtScope(variable, scopeID, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 1212, 1278);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 932, 1290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 932, 1290);
            }
        }

        internal PSVariable GetVariable(string name, CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 1900, 2415);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 1991, 2109) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 1991, 2109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 2041, 2094);

                    throw f_1360_2047_2093("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 1991, 2109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 2125, 2236);

                VariablePath
                variablePath = f_1360_2153_2235(name, VariablePathFlags.Variable | VariablePathFlags.Unqualified)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 2250, 2281);

                SessionStateScope
                scope = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 2297, 2370);

                PSVariable
                resultItem = f_1360_2321_2369(this, variablePath, out scope, origin)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 2386, 2404);

                return resultItem;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 1900, 2415);

                System.Management.Automation.PSArgumentNullException
                f_1360_2047_2093(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 2047, 2093);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1360_2153_2235(string
                path, System.Management.Automation.VariablePathFlags
                knownFlags)
                {
                    var return_v = new System.Management.Automation.VariablePath(path, knownFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 2153, 2235);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1360_2321_2369(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.SessionStateScope
                scope, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.GetVariableItem(variablePath, out scope, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 2321, 2369);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 1900, 2415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 1900, 2415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSVariable GetVariable(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 2912, 3041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 2981, 3030);

                return f_1360_2988_3029(this, name, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 2912, 3041);

                System.Management.Automation.PSVariable
                f_1360_2988_3029(System.Management.Automation.SessionStateInternal
                this_param, string
                name, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.GetVariable(name, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 2988, 3029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 2912, 3041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 2912, 3041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetVariableValue(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 4281, 4768);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 4351, 4469) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 4351, 4469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 4401, 4454);

                    throw f_1360_4407_4453("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 4351, 4469);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 4485, 4536);

                VariablePath
                variablePath = f_1360_4513_4535(name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 4550, 4587);

                CmdletProviderContext
                context = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 4601, 4632);

                SessionStateScope
                scope = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 4648, 4723);

                object
                resultItem = f_1360_4668_4722(this, variablePath, out context, out scope)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 4739, 4757);

                return resultItem;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 4281, 4768);

                System.Management.Automation.PSArgumentNullException
                f_1360_4407_4453(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 4407, 4453);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1360_4513_4535(string
                path)
                {
                    var return_v = new System.Management.Automation.VariablePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 4513, 4535);
                    return return_v;
                }


                object
                f_1360_4668_4722(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = this_param.GetVariableValue(variablePath, out context, out scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 4668, 4722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 4281, 4768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 4281, 4768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetVariableValue(string name, object defaultValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 6143, 6340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 6234, 6295);

                object
                returnObject = f_1360_6256_6278(this, name) ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(1360, 6256, 6294) ?? defaultValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 6309, 6329);

                return returnObject;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 6143, 6340);

                object
                f_1360_6256_6278(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariableValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 6256, 6278);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 6143, 6340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 6143, 6340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetVariableValue(
                    VariablePath variablePath,
                    out CmdletProviderContext context,
                    out SessionStateScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 8540, 9293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 8728, 8743);

                context = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 8757, 8770);

                scope = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 8786, 8807);

                object
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 8821, 9252) || true) && (f_1360_8825_8848(variablePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 8821, 9252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 8882, 8945);

                    PSVariable
                    variable = f_1360_8904_8944(this, variablePath, out scope)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 8963, 9068) || true) && (variable != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 8963, 9068);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 9025, 9049);

                        result = f_1360_9034_9048(variable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 8963, 9068);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 8821, 9252);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 8821, 9252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 9134, 9237);

                    result = f_1360_9143_9236(this, variablePath, out context, out scope, f_1360_9210_9235(_currentScope));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 8821, 9252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 9268, 9282);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 8540, 9293);

                bool
                f_1360_8825_8848(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 8825, 8848);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1360_8904_8944(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = this_param.GetVariableItem(variablePath, out scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 8904, 8944);
                    return return_v;
                }


                object
                f_1360_9034_9048(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 9034, 9048);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1360_9210_9235(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScopeOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 9210, 9235);
                    return return_v;
                }


                object
                f_1360_9143_9236(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.SessionStateScope
                scope, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.GetVariableValueFromProvider(variablePath, out context, out scope, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 9143, 9236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 8540, 9293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 8540, 9293);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetVariableValueFromProvider(
                    VariablePath variablePath,
                    out CmdletProviderContext context,
                    out SessionStateScope scope,
                    CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 11630, 19911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 11865, 11878);

                scope = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 11894, 12028) || true) && (variablePath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 11894, 12028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 11952, 12013);

                    throw f_1360_11958_12012("variablePath");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 11894, 12028);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 12044, 12189);

                f_1360_12044_12188(f_1360_12085_12109_M(!variablePath.IsVariable), "This method can only be used to retrieve provider content");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 12205, 12220);

                context = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 12236, 12377);

                DriveScopeItemSearcher
                searcher =
                f_1360_12287_12376(this, variablePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 12393, 12414);

                object
                result = null
                ;
                {
                    try
                    {
                        do // false loop

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 12430, 19870);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 12479, 12570) || true) && (!f_1360_12484_12503(searcher))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 12479, 12570);
                                DynAbs.Tracing.TraceSender.TraceBreak(1360, 12545, 12551);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 12479, 12570);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 12590, 12655);

                            PSDriveInfo
                            drive = f_1360_12610_12654(((IEnumerator<PSDriveInfo>)searcher))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 12675, 12759) || true) && (drive == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 12675, 12759);
                                DynAbs.Tracing.TraceSender.TraceBreak(1360, 12734, 12740);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 12675, 12759);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 12859, 12926);

                            context = f_1360_12869_12925(f_1360_12895_12916(this), origin);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 12946, 12968);

                            context.Drive = drive;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 13081, 13123);

                            Collection<IContentReader>
                            readers = null
                            ;

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 13187, 13293);

                                readers =
                                f_1360_13222_13292(this, new string[] { f_1360_13254_13280(variablePath) }, context);
                            }
                            // If the item is not found we just return null like the normal
                            // variable semantics.
                            catch (ItemNotFoundException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 13451, 13546);
                                DynAbs.Tracing.TraceSender.TraceBreak(1360, 13521, 13527);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 13451, 13546);
                            }
                            catch (DriveNotFoundException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 13564, 13660);
                                DynAbs.Tracing.TraceSender.TraceBreak(1360, 13635, 13641);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 13564, 13660);
                            }
                            catch (ProviderNotFoundException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 13678, 13777);
                                DynAbs.Tracing.TraceSender.TraceBreak(1360, 13752, 13758);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 13678, 13777);
                            }
                            catch (NotImplementedException notImplemented)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 13795, 14498);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 13945, 13978);

                                ProviderInfo
                                providerInfo = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 14000, 14116);

                                string
                                unused =
                                f_1360_14041_14115(f_1360_14041_14053(this), f_1360_14070_14096(variablePath), out providerInfo)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 14140, 14479);

                                throw f_1360_14146_14478(this, "ProviderCannotBeUsedAsVariable", f_1360_14262_14312(), providerInfo, f_1360_14378_14404(variablePath), notImplemented, false);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 13795, 14498);
                            }
                            catch (NotSupportedException notSupported)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 14516, 15213);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 14662, 14695);

                                ProviderInfo
                                providerInfo = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 14717, 14833);

                                string
                                unused =
                                f_1360_14758_14832(f_1360_14758_14770(this), f_1360_14787_14813(variablePath), out providerInfo)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 14857, 15194);

                                throw f_1360_14863_15193(this, "ProviderCannotBeUsedAsVariable", f_1360_14979_15029(), providerInfo, f_1360_15095_15121(variablePath), notSupported, false);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 14516, 15213);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 15233, 15586) || true) && (readers == null || (DynAbs.Tracing.TraceSender.Expression_False(1360, 15237, 15274) || f_1360_15256_15269(readers) == 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 15233, 15586);
                                DynAbs.Tracing.TraceSender.TraceBreak(1360, 15561, 15567);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 15233, 15586);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 15606, 16867) || true) && (f_1360_15610_15623(readers) > 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 15606, 16867);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 15849, 15968);
                                    foreach (IContentReader r in f_1360_15878_15885_I(readers))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 15849, 15968);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 15935, 15945);

                                        f_1360_15935_15944(r);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 15849, 15968);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1360, 1, 120);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1360, 1, 120);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 15992, 16263);

                                PSArgumentException
                                argException =
                                f_1360_16052_16262("path", f_1360_16154_16204(), f_1360_16235_16261(variablePath))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 16350, 16383);

                                ProviderInfo
                                providerInfo = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 16405, 16521);

                                string
                                unused =
                                f_1360_16446_16520(f_1360_16446_16458(this), f_1360_16475_16501(variablePath), out providerInfo)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 16545, 16848);

                                throw f_1360_16551_16847(this, "ProviderVariableSyntaxInvalid", f_1360_16666_16715(), providerInfo, f_1360_16781_16807(variablePath), argException);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 15606, 16867);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 16887, 16922);

                            IContentReader
                            reader = f_1360_16911_16921(readers, 0)
                            ;

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 17031, 17066);

                                IList
                                resultList = f_1360_17050_17065(reader, -1)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 17090, 17607) || true) && (resultList != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 17090, 17607);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 17162, 17584) || true) && (f_1360_17166_17182(resultList) == 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 17162, 17584);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 17245, 17259);

                                        result = null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 17162, 17584);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 17162, 17584);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 17317, 17584) || true) && (f_1360_17321_17337(resultList) == 1)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 17317, 17584);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 17400, 17423);

                                            result = f_1360_17409_17422(resultList, 0);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 17317, 17584);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 17317, 17584);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 17537, 17557);

                                            result = resultList;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 17317, 17584);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 17162, 17584);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 17090, 17607);
                                }
                            }
                            catch (Exception e) // Third-party callout, catch-all OK
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 17644, 18434);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 17802, 17835);

                                ProviderInfo
                                providerInfo = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 17857, 17973);

                                string
                                unused =
                                f_1360_17898_17972(f_1360_17898_17910(this), f_1360_17927_17953(variablePath), out providerInfo)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 17997, 18367);

                                ProviderInvocationException
                                providerException =
                                f_1360_18070_18366("ProviderContentReadError", f_1360_18189_18233(), providerInfo, f_1360_18307_18333(variablePath), e)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 18391, 18415);

                                throw providerException;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 17644, 18434);
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinally(1360, 18452, 18534);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 18500, 18515);

                                f_1360_18500_18514(reader);
                                DynAbs.Tracing.TraceSender.TraceExitFinally(1360, 18452, 18534);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1360, 19834, 19840);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 12430, 19870);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 12430, 19870) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1360, 12430, 19870);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1360, 12430, 19870);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 19886, 19900);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 11630, 19911);

                System.Management.Automation.PSArgumentNullException
                f_1360_11958_12012(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 11958, 12012);
                    return return_v;
                }


                bool
                f_1360_12085_12109_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 12085, 12109);
                    return return_v;
                }


                int
                f_1360_12044_12188(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 12044, 12188);
                    return 0;
                }


                System.Management.Automation.DriveScopeItemSearcher
                f_1360_12287_12376(System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.VariablePath
                lookupPath)
                {
                    var return_v = new System.Management.Automation.DriveScopeItemSearcher(sessionState, lookupPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 12287, 12376);
                    return return_v;
                }


                bool
                f_1360_12484_12503(System.Management.Automation.DriveScopeItemSearcher
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 12484, 12503);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1360_12610_12654(System.Collections.Generic.IEnumerator<System.Management.Automation.PSDriveInfo>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 12610, 12654);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1360_12895_12916(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 12895, 12916);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1360_12869_12925(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 12869, 12925);
                    return return_v;
                }


                string
                f_1360_13254_13280(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 13254, 13280);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                f_1360_13222_13292(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetContentReader(paths, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 13222, 13292);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1360_14041_14053(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 14041, 14053);
                    return return_v;
                }


                string
                f_1360_14070_14096(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 14070, 14096);
                    return return_v;
                }


                string
                f_1360_14041_14115(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 14041, 14115);
                    return return_v;
                }


                string
                f_1360_14262_14312()
                {
                    var return_v = SessionStateStrings.ProviderCannotBeUsedAsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 14262, 14312);
                    return return_v;
                }


                string
                f_1360_14378_14404(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 14378, 14404);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1360_14146_14478(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.NotImplementedException
                e, bool
                useInnerExceptionErrorMessage)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, (System.Exception)e, useInnerExceptionErrorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 14146, 14478);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1360_14758_14770(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 14758, 14770);
                    return return_v;
                }


                string
                f_1360_14787_14813(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 14787, 14813);
                    return return_v;
                }


                string
                f_1360_14758_14832(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 14758, 14832);
                    return return_v;
                }


                string
                f_1360_14979_15029()
                {
                    var return_v = SessionStateStrings.ProviderCannotBeUsedAsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 14979, 15029);
                    return return_v;
                }


                string
                f_1360_15095_15121(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 15095, 15121);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1360_14863_15193(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.NotSupportedException
                e, bool
                useInnerExceptionErrorMessage)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, (System.Exception)e, useInnerExceptionErrorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 14863, 15193);
                    return return_v;
                }


                int
                f_1360_15256_15269(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 15256, 15269);
                    return return_v;
                }


                int
                f_1360_15610_15623(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 15610, 15623);
                    return return_v;
                }


                int
                f_1360_15935_15944(System.Management.Automation.Provider.IContentReader
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 15935, 15944);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                f_1360_15878_15885_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 15878, 15885);
                    return return_v;
                }


                string
                f_1360_16154_16204()
                {
                    var return_v = SessionStateStrings.VariablePathResolvedToMultiple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 16154, 16204);
                    return return_v;
                }


                string
                f_1360_16235_16261(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 16235, 16261);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1360_16052_16262(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 16052, 16262);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1360_16446_16458(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 16446, 16458);
                    return return_v;
                }


                string
                f_1360_16475_16501(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 16475, 16501);
                    return return_v;
                }


                string
                f_1360_16446_16520(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 16446, 16520);
                    return return_v;
                }


                string
                f_1360_16666_16715()
                {
                    var return_v = SessionStateStrings.ProviderVariableSyntaxInvalid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 16666, 16715);
                    return return_v;
                }


                string
                f_1360_16781_16807(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 16781, 16807);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1360_16551_16847(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Management.Automation.PSArgumentException
                e)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 16551, 16847);
                    return return_v;
                }


                System.Management.Automation.Provider.IContentReader
                f_1360_16911_16921(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 16911, 16921);
                    return return_v;
                }


                System.Collections.IList
                f_1360_17050_17065(System.Management.Automation.Provider.IContentReader
                this_param, int
                readCount)
                {
                    var return_v = this_param.Read((long)readCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 17050, 17065);
                    return return_v;
                }


                int
                f_1360_17166_17182(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 17166, 17182);
                    return return_v;
                }


                int
                f_1360_17321_17337(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 17321, 17337);
                    return return_v;
                }


                object
                f_1360_17409_17422(System.Collections.IList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 17409, 17422);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1360_17898_17910(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 17898, 17910);
                    return return_v;
                }


                string
                f_1360_17927_17953(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 17927, 17953);
                    return return_v;
                }


                string
                f_1360_17898_17972(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 17898, 17972);
                    return return_v;
                }


                string
                f_1360_18189_18233()
                {
                    var return_v = SessionStateStrings.ProviderContentReadError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 18189, 18233);
                    return return_v;
                }


                string
                f_1360_18307_18333(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 18307, 18333);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1360_18070_18366(string
                errorId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.ProviderInvocationException(errorId, resourceStr, provider, path, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 18070, 18366);
                    return return_v;
                }


                int
                f_1360_18500_18514(System.Management.Automation.Provider.IContentReader
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 18500, 18514);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 11630, 19911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 11630, 19911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSVariable GetVariableItem(
                    VariablePath variablePath,
                    out SessionStateScope scope,
                    CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 21216, 22069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 21394, 21407);

                scope = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 21423, 21557) || true) && (variablePath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 21423, 21557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 21481, 21542);

                    throw f_1360_21487_21541("variablePath");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 21423, 21557);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 21573, 21664);

                f_1360_21573_21663(f_1360_21596_21619(variablePath), "Can't get variable w/ non-variable path");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 21680, 21792);

                VariableScopeItemSearcher
                searcher =
                f_1360_21734_21791(this, variablePath, origin)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 21808, 21833);

                PSVariable
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 21849, 22028) || true) && (f_1360_21853_21872(searcher))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 21849, 22028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 21906, 21959);

                    result = f_1360_21915_21958(((IEnumerator<PSVariable>)searcher));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 21977, 22013);

                    scope = f_1360_21985_22012(searcher);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 21849, 22028);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 22044, 22058);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 21216, 22069);

                System.Management.Automation.PSArgumentNullException
                f_1360_21487_21541(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 21487, 21541);
                    return return_v;
                }


                bool
                f_1360_21596_21619(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 21596, 21619);
                    return return_v;
                }


                int
                f_1360_21573_21663(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 21573, 21663);
                    return 0;
                }


                System.Management.Automation.VariableScopeItemSearcher
                f_1360_21734_21791(System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.VariablePath
                lookupPath, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = new System.Management.Automation.VariableScopeItemSearcher(sessionState, lookupPath, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 21734, 21791);
                    return return_v;
                }


                bool
                f_1360_21853_21872(System.Management.Automation.VariableScopeItemSearcher
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 21853, 21872);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1360_21915_21958(System.Collections.Generic.IEnumerator<System.Management.Automation.PSVariable>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 21915, 21958);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1360_21985_22012(System.Management.Automation.VariableScopeItemSearcher
                this_param)
                {
                    var return_v = this_param.CurrentLookupScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 21985, 22012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 21216, 22069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 21216, 22069);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSVariable GetVariableItem(
                    VariablePath variablePath,
                    out SessionStateScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 23227, 23453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 23370, 23442);

                return f_1360_23377_23441(this, variablePath, out scope, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 23227, 23453);

                System.Management.Automation.PSVariable
                f_1360_23377_23441(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.SessionStateScope
                scope, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.GetVariableItem(variablePath, out scope, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 23377, 23441);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 23227, 23453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 23227, 23453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSVariable GetVariableAtScope(string name, string scopeID)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 24568, 25304);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 24660, 24778) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 24660, 24778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 24710, 24763);

                    throw f_1360_24716_24762("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 24660, 24778);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 24794, 24845);

                VariablePath
                variablePath = f_1360_24822_24844(name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 24861, 24898);

                SessionStateScope
                lookupScope = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 25021, 25057);

                lookupScope = f_1360_25035_25056(this, scopeID);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 25073, 25102);

                PSVariable
                resultItem = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 25118, 25259) || true) && (f_1360_25122_25145(variablePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 25118, 25259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 25179, 25244);

                    resultItem = f_1360_25192_25243(lookupScope, f_1360_25216_25242(variablePath));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 25118, 25259);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 25275, 25293);

                return resultItem;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 24568, 25304);

                System.Management.Automation.PSArgumentNullException
                f_1360_24716_24762(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 24716, 24762);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1360_24822_24844(string
                path)
                {
                    var return_v = new System.Management.Automation.VariablePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 24822, 24844);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1360_25035_25056(System.Management.Automation.SessionStateInternal
                this_param, string
                scopeID)
                {
                    var return_v = this_param.GetScopeByID(scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 25035, 25056);
                    return return_v;
                }


                bool
                f_1360_25122_25145(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 25122, 25145);
                    return return_v;
                }


                string
                f_1360_25216_25242(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 25216, 25242);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1360_25192_25243(System.Management.Automation.SessionStateScope
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 25192, 25243);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 24568, 25304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 24568, 25304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetVariableValueAtScope(string name, string scopeID)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 27094, 35875);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 27187, 27305) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 27187, 27305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 27237, 27290);

                    throw f_1360_27243_27289("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 27187, 27305);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 27321, 27372);

                VariablePath
                variablePath = f_1360_27349_27371(name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 27388, 27425);

                SessionStateScope
                lookupScope = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 27548, 27584);

                lookupScope = f_1360_27562_27583(this, scopeID);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 27600, 27625);

                object
                resultItem = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 27641, 35062) || true) && (f_1360_27645_27668(variablePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 27641, 35062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 27702, 27767);

                    resultItem = f_1360_27715_27766(lookupScope, f_1360_27739_27765(variablePath));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 27641, 35062);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 27641, 35062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 27833, 27898);

                    PSDriveInfo
                    drive = f_1360_27853_27897(lookupScope, f_1360_27874_27896(variablePath))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 27918, 35047) || true) && (drive != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 27918, 35047);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 27977, 28058);

                        CmdletProviderContext
                        context = f_1360_28009_28057(f_1360_28035_28056(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 28080, 28102);

                        context.Drive = drive;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 28223, 28265);

                        Collection<IContentReader>
                        readers = null
                        ;

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 28341, 28451);

                            readers =
                            f_1360_28380_28450(this, new string[] { f_1360_28412_28438(variablePath) }, context);
                        }
                        // If the item is not found we just return null like the normal
                        // variable semantics.
                        catch (ItemNotFoundException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 28625, 28738);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 28703, 28715);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 28625, 28738);
                        }
                        catch (DriveNotFoundException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 28760, 28874);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 28839, 28851);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 28760, 28874);
                        }
                        catch (ProviderNotFoundException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 28896, 29013);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 28978, 28990);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 28896, 29013);
                        }
                        catch (NotImplementedException notImplemented)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 29035, 29790);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 29197, 29230);

                            ProviderInfo
                            providerInfo = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 29256, 29376);

                            string
                            unused =
                            f_1360_29301_29375(f_1360_29301_29313(this), f_1360_29330_29356(variablePath), out providerInfo)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 29404, 29767);

                            throw f_1360_29410_29766(this, "ProviderCannotBeUsedAsVariable", f_1360_29534_29584(), providerInfo, f_1360_29658_29684(variablePath), notImplemented, false);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 29035, 29790);
                        }
                        catch (NotSupportedException notSupported)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 29812, 30561);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 29970, 30003);

                            ProviderInfo
                            providerInfo = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 30029, 30149);

                            string
                            unused =
                            f_1360_30074_30148(f_1360_30074_30086(this), f_1360_30103_30129(variablePath), out providerInfo)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 30177, 30538);

                            throw f_1360_30183_30537(this, "ProviderCannotBeUsedAsVariable", f_1360_30307_30357(), providerInfo, f_1360_30431_30457(variablePath), notSupported, false);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 29812, 30561);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 30585, 31055) || true) && (readers == null || (DynAbs.Tracing.TraceSender.Expression_False(1360, 30589, 30626) || f_1360_30608_30621(readers) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 30585, 31055);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 31020, 31032);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 30585, 31055);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 31079, 32329) || true) && (f_1360_31083_31096(readers) > 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 31079, 32329);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 31150, 31301);
                                foreach (IContentReader closeReader in f_1360_31189_31196_I(readers))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 31150, 31301);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 31254, 31274);

                                    f_1360_31254_31273(closeReader);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 31150, 31301);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1360, 1, 152);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1360, 1, 152);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 31416, 31681);

                            PSArgumentException
                            argException =
                            f_1360_31480_31680("path", f_1360_31590_31640(), name)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 31776, 31809);

                            ProviderInfo
                            providerInfo = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 31835, 31955);

                            string
                            unused =
                            f_1360_31880_31954(f_1360_31880_31892(this), f_1360_31909_31935(variablePath), out providerInfo)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 31983, 32306);

                            throw f_1360_31989_32305(this, "ProviderVariableSyntaxInvalid", f_1360_32112_32161(), providerInfo, f_1360_32235_32261(variablePath), argException);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 31079, 32329);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 32353, 32388);

                        IContentReader
                        reader = f_1360_32377_32387(readers, 0)
                        ;

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 32513, 32548);

                            IList
                            resultList = f_1360_32532_32547(reader, -1)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 32576, 33161) || true) && (resultList != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 32576, 33161);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 32656, 33134) || true) && (f_1360_32660_32676(resultList) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 32656, 33134);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 32747, 32765);

                                    resultItem = null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 32656, 33134);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 32656, 33134);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 32831, 33134) || true) && (f_1360_32835_32851(resultList) == 1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 32831, 33134);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 32922, 32949);

                                        resultItem = f_1360_32935_32948(resultList, 0);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 32831, 33134);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 32831, 33134);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 33079, 33103);

                                        resultItem = resultList;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 32831, 33134);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 32656, 33134);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 32576, 33161);
                            }
                        }
                        catch (Exception e) // Third-party callout, catch-all OK
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 33206, 34054);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 33378, 33411);

                            ProviderInfo
                            providerInfo = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 33437, 33557);

                            string
                            unused =
                            f_1360_33482_33556(f_1360_33482_33494(this), f_1360_33511_33537(variablePath), out providerInfo)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 33585, 33979);

                            ProviderInvocationException
                            providerException =
                            f_1360_33662_33978("ProviderContentReadError", f_1360_33789_33833(), providerInfo, f_1360_33915_33941(variablePath), e)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 34007, 34031);

                            throw providerException;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 33206, 34054);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1360, 34076, 34170);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 34132, 34147);

                            f_1360_34132_34146(reader);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1360, 34076, 34170);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 27918, 35047);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 27641, 35062);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 35227, 35830) || true) && (resultItem != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 35227, 35830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 35283, 35330);

                    PSVariable
                    variable = resultItem as PSVariable
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 35350, 35815) || true) && (variable != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 35350, 35815);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 35412, 35440);

                        resultItem = f_1360_35425_35439(variable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 35350, 35815);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 35350, 35815);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 35574, 35626);

                            DictionaryEntry
                            entry = (DictionaryEntry)resultItem
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 35652, 35677);

                            resultItem = entry.Value;
                        }
                        catch (InvalidCastException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 35722, 35796);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 35722, 35796);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 35350, 35815);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 35227, 35830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 35846, 35864);

                return resultItem;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 27094, 35875);

                System.Management.Automation.PSArgumentNullException
                f_1360_27243_27289(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 27243, 27289);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1360_27349_27371(string
                path)
                {
                    var return_v = new System.Management.Automation.VariablePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 27349, 27371);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1360_27562_27583(System.Management.Automation.SessionStateInternal
                this_param, string
                scopeID)
                {
                    var return_v = this_param.GetScopeByID(scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 27562, 27583);
                    return return_v;
                }


                bool
                f_1360_27645_27668(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 27645, 27668);
                    return return_v;
                }


                string
                f_1360_27739_27765(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 27739, 27765);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1360_27715_27766(System.Management.Automation.SessionStateScope
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 27715, 27766);
                    return return_v;
                }


                string
                f_1360_27874_27896(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.DriveName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 27874, 27896);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1360_27853_27897(System.Management.Automation.SessionStateScope
                this_param, string
                name)
                {
                    var return_v = this_param.GetDrive(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 27853, 27897);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1360_28035_28056(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 28035, 28056);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1360_28009_28057(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 28009, 28057);
                    return return_v;
                }


                string
                f_1360_28412_28438(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 28412, 28438);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                f_1360_28380_28450(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetContentReader(paths, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 28380, 28450);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1360_29301_29313(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 29301, 29313);
                    return return_v;
                }


                string
                f_1360_29330_29356(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 29330, 29356);
                    return return_v;
                }


                string
                f_1360_29301_29375(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 29301, 29375);
                    return return_v;
                }


                string
                f_1360_29534_29584()
                {
                    var return_v = SessionStateStrings.ProviderCannotBeUsedAsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 29534, 29584);
                    return return_v;
                }


                string
                f_1360_29658_29684(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 29658, 29684);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1360_29410_29766(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.NotImplementedException
                e, bool
                useInnerExceptionErrorMessage)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, (System.Exception)e, useInnerExceptionErrorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 29410, 29766);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1360_30074_30086(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 30074, 30086);
                    return return_v;
                }


                string
                f_1360_30103_30129(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 30103, 30129);
                    return return_v;
                }


                string
                f_1360_30074_30148(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 30074, 30148);
                    return return_v;
                }


                string
                f_1360_30307_30357()
                {
                    var return_v = SessionStateStrings.ProviderCannotBeUsedAsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 30307, 30357);
                    return return_v;
                }


                string
                f_1360_30431_30457(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 30431, 30457);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1360_30183_30537(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.NotSupportedException
                e, bool
                useInnerExceptionErrorMessage)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, (System.Exception)e, useInnerExceptionErrorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 30183, 30537);
                    return return_v;
                }


                int
                f_1360_30608_30621(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 30608, 30621);
                    return return_v;
                }


                int
                f_1360_31083_31096(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 31083, 31096);
                    return return_v;
                }


                int
                f_1360_31254_31273(System.Management.Automation.Provider.IContentReader
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 31254, 31273);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                f_1360_31189_31196_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 31189, 31196);
                    return return_v;
                }


                string
                f_1360_31590_31640()
                {
                    var return_v = SessionStateStrings.VariablePathResolvedToMultiple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 31590, 31640);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1360_31480_31680(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 31480, 31680);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1360_31880_31892(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 31880, 31892);
                    return return_v;
                }


                string
                f_1360_31909_31935(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 31909, 31935);
                    return return_v;
                }


                string
                f_1360_31880_31954(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 31880, 31954);
                    return return_v;
                }


                string
                f_1360_32112_32161()
                {
                    var return_v = SessionStateStrings.ProviderVariableSyntaxInvalid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 32112, 32161);
                    return return_v;
                }


                string
                f_1360_32235_32261(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 32235, 32261);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1360_31989_32305(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Management.Automation.PSArgumentException
                e)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 31989, 32305);
                    return return_v;
                }


                System.Management.Automation.Provider.IContentReader
                f_1360_32377_32387(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 32377, 32387);
                    return return_v;
                }


                System.Collections.IList
                f_1360_32532_32547(System.Management.Automation.Provider.IContentReader
                this_param, int
                readCount)
                {
                    var return_v = this_param.Read((long)readCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 32532, 32547);
                    return return_v;
                }


                int
                f_1360_32660_32676(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 32660, 32676);
                    return return_v;
                }


                int
                f_1360_32835_32851(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 32835, 32851);
                    return return_v;
                }


                object
                f_1360_32935_32948(System.Collections.IList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 32935, 32948);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1360_33482_33494(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 33482, 33494);
                    return return_v;
                }


                string
                f_1360_33511_33537(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 33511, 33537);
                    return return_v;
                }


                string
                f_1360_33482_33556(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 33482, 33556);
                    return return_v;
                }


                string
                f_1360_33789_33833()
                {
                    var return_v = SessionStateStrings.ProviderContentReadError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 33789, 33833);
                    return return_v;
                }


                string
                f_1360_33915_33941(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 33915, 33941);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1360_33662_33978(string
                errorId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.ProviderInvocationException(errorId, resourceStr, provider, path, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 33662, 33978);
                    return return_v;
                }


                int
                f_1360_34132_34146(System.Management.Automation.Provider.IContentReader
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 34132, 34146);
                    return 0;
                }


                object
                f_1360_35425_35439(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 35425, 35439);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 27094, 35875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 27094, 35875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetAutomaticVariableValue(AutomaticVariable variable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 35887, 36411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 35981, 36049);

                var
                scopeEnumerator = f_1360_36003_36048(f_1360_36035_36047())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 36063, 36100);

                object
                result = f_1360_36079_36099()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 36114, 36370);
                    foreach (var scope in f_1360_36136_36151_I(scopeEnumerator))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 36114, 36370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 36185, 36236);

                        result = f_1360_36194_36235(scope, variable);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 36254, 36355) || true) && (result != f_1360_36268_36288())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 36254, 36355);
                            DynAbs.Tracing.TraceSender.TraceBreak(1360, 36330, 36336);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 36254, 36355);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 36114, 36370);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1360, 1, 257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1360, 1, 257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 36386, 36400);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 35887, 36411);

                System.Management.Automation.SessionStateScope
                f_1360_36035_36047()
                {
                    var return_v = CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 36035, 36047);
                    return return_v;
                }


                System.Management.Automation.SessionStateScopeEnumerator
                f_1360_36003_36048(System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = new System.Management.Automation.SessionStateScopeEnumerator(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 36003, 36048);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1360_36079_36099()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 36079, 36099);
                    return return_v;
                }


                object
                f_1360_36194_36235(System.Management.Automation.SessionStateScope
                this_param, System.Management.Automation.AutomaticVariable
                variable)
                {
                    var return_v = this_param.GetAutomaticVariableValue(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 36194, 36235);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1360_36268_36288()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 36268, 36288);
                    return return_v;
                }


                System.Management.Automation.SessionStateScopeEnumerator
                f_1360_36136_36151_I(System.Management.Automation.SessionStateScopeEnumerator
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 36136, 36151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 35887, 36411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 35887, 36411);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetVariableValue(string name, object newValue, CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 37945, 38314);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 38052, 38170) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 38052, 38170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 38102, 38155);

                    throw f_1360_38108_38154("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 38052, 38170);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 38186, 38237);

                VariablePath
                variablePath = f_1360_38214_38236(name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 38253, 38303);

                f_1360_38253_38302(this, variablePath, newValue, true, origin);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 37945, 38314);

                System.Management.Automation.PSArgumentNullException
                f_1360_38108_38154(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 38108, 38154);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1360_38214_38236(string
                path)
                {
                    var return_v = new System.Management.Automation.VariablePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 38214, 38236);
                    return return_v;
                }


                object
                f_1360_38253_38302(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, object
                newValue, bool
                asValue, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(variablePath, newValue, asValue, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 38253, 38302);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 37945, 38314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 37945, 38314);
            }
        }

        internal void SetVariableValue(string name, object newValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 39943, 40096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 40028, 40085);

                f_1360_40028_40084(this, name, newValue, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 39943, 40096);

                int
                f_1360_40028_40084(System.Management.Automation.SessionStateInternal
                this_param, string
                name, object
                newValue, System.Management.Automation.CommandOrigin
                origin)
                {
                    this_param.SetVariableValue(name, newValue, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 40028, 40084);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 39943, 40096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 39943, 40096);
            }
        }

        internal object SetVariable(PSVariable variable, bool force, CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 41121, 41617);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 41228, 41389) || true) && (variable == null || (DynAbs.Tracing.TraceSender.Expression_False(1360, 41232, 41287) || f_1360_41252_41287(f_1360_41273_41286(variable))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 41228, 41389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 41321, 41374);

                    throw f_1360_41327_41373("variable");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 41228, 41389);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 41405, 41525);

                VariablePath
                variablePath = f_1360_41433_41524(f_1360_41450_41463(variable), VariablePathFlags.Variable | VariablePathFlags.Unqualified)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 41541, 41606);

                return f_1360_41548_41605(this, variablePath, variable, false, force, origin);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 41121, 41617);

                string
                f_1360_41273_41286(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 41273, 41286);
                    return return_v;
                }


                bool
                f_1360_41252_41287(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 41252, 41287);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1360_41327_41373(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 41327, 41373);
                    return return_v;
                }


                string
                f_1360_41450_41463(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 41450, 41463);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1360_41433_41524(string
                path, System.Management.Automation.VariablePathFlags
                knownFlags)
                {
                    var return_v = new System.Management.Automation.VariablePath(path, knownFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 41433, 41524);
                    return return_v;
                }


                object
                f_1360_41548_41605(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, System.Management.Automation.PSVariable
                newValue, bool
                asValue, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(variablePath, (object)newValue, asValue, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 41548, 41605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 41121, 41617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 41121, 41617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object SetVariable(
                    VariablePath variablePath,
                    object newValue,
                    bool asValue,
                    CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 43527, 43790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 43712, 43779);

                return f_1360_43719_43778(this, variablePath, newValue, asValue, false, origin);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 43527, 43790);

                object
                f_1360_43719_43778(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, object
                newValue, bool
                asValue, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(variablePath, newValue, asValue, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 43719, 43778);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 43527, 43790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 43527, 43790);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object SetVariable(
                    VariablePath variablePath,
                    object newValue,
                    bool asValue,
                    bool force,
                    CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 45822, 54897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46032, 46053);

                object
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46067, 46201) || true) && (variablePath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 46067, 46201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46125, 46186);

                    throw f_1360_46131_46185("variablePath");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 46067, 46201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46217, 46254);

                CmdletProviderContext
                context = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46268, 46299);

                SessionStateScope
                scope = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46315, 54856) || true) && (f_1360_46319_46342(variablePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 46315, 54856);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46453, 46999) || true) && (f_1360_46457_46477(variablePath) || (DynAbs.Tracing.TraceSender.Expression_False(1360, 46457, 46512) || f_1360_46481_46512(variablePath)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 46453, 46999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46554, 46576);

                        scope = _currentScope;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 46453, 46999);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 46453, 46999);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46618, 46999) || true) && (f_1360_46622_46643(variablePath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 46618, 46999);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46685, 46719);

                            scope = f_1360_46693_46718(_currentScope);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 46618, 46999);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 46618, 46999);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46761, 46999) || true) && (f_1360_46765_46786(variablePath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 46761, 46999);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46828, 46848);

                                scope = f_1360_46836_46847();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 46761, 46999);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 46761, 46999);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46890, 46999) || true) && (f_1360_46894_46916(variablePath))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 46890, 46999);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 46958, 46980);

                                    scope = _currentScope;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 46890, 46999);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 46761, 46999);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 46618, 46999);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 46453, 46999);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 47019, 47300);

                    PSVariable
                    varResult =
                    f_1360_47063_47299(scope, f_1360_47107_47133(variablePath), newValue, asValue, force, this, origin)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 47435, 47609) || true) && (f_1360_47439_47461(variablePath) && (DynAbs.Tracing.TraceSender.Expression_True(1360, 47439, 47482) && varResult != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 47435, 47609);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 47524, 47590);

                        varResult.Options = f_1360_47544_47561(varResult) | ScopedItemOptions.Private;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 47435, 47609);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 47629, 47648);

                    result = varResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 46315, 54856);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 46315, 54856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 47944, 47999);

                    f_1360_47944_47998(this, variablePath, out context, out scope);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 48110, 48152);

                    Collection<IContentWriter>
                    writers = null
                    ;

                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 48216, 49879) || true) && (context != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 48216, 49879);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 48345, 48424);

                                CmdletProviderContext
                                clearContentContext = f_1360_48389_48423(context)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 48532, 48611);

                                f_1360_48532_48610(this, new string[] { f_1360_48560_48586(variablePath) }, clearContentContext);
                            }
                            catch (NotSupportedException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 48664, 48747);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 48664, 48747);
                            }
                            catch (ItemNotFoundException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 48773, 48856);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 48773, 48856);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 48884, 49061);

                            writers =
                            f_1360_48923_49060(this, new string[] { f_1360_48989_49015(variablePath) }, context);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 49087, 49128);

                            f_1360_49087_49127(context, true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 48216, 49879);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 48216, 49879);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 49362, 49434);

                                f_1360_49362_49433(this, new string[] { f_1360_49390_49416(variablePath) }, false, false);
                            }
                            catch (NotSupportedException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 49487, 49570);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 49487, 49570);
                            }
                            catch (ItemNotFoundException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 49596, 49679);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 49596, 49679);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 49707, 49856);

                            writers =
                            f_1360_49746_49855(this, new string[] { f_1360_49812_49838(variablePath) }, false, false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 48216, 49879);
                        }
                    }
                    catch (NotImplementedException notImplemented)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 49916, 50619);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 50066, 50099);

                        ProviderInfo
                        providerInfo = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 50121, 50237);

                        string
                        unused =
                        f_1360_50162_50236(f_1360_50162_50174(this), f_1360_50191_50217(variablePath), out providerInfo)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 50261, 50600);

                        throw f_1360_50267_50599(this, "ProviderCannotBeUsedAsVariable", f_1360_50383_50433(), providerInfo, f_1360_50499_50525(variablePath), notImplemented, false);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 49916, 50619);
                    }
                    catch (NotSupportedException notSupported)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 50637, 51334);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 50783, 50816);

                        ProviderInfo
                        providerInfo = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 50838, 50954);

                        string
                        unused =
                        f_1360_50879_50953(f_1360_50879_50891(this), f_1360_50908_50934(variablePath), out providerInfo)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 50978, 51315);

                        throw f_1360_50984_51314(this, "ProviderCannotBeUsedAsVariable", f_1360_51100_51150(), providerInfo, f_1360_51216_51242(variablePath), notSupported, false);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 50637, 51334);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 51354, 51753) || true) && (writers == null || (DynAbs.Tracing.TraceSender.Expression_False(1360, 51358, 51395) || f_1360_51377_51390(writers) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 51354, 51753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 51437, 51691);

                        ItemNotFoundException
                        itemNotFound =
                        f_1360_51499_51690(f_1360_51555_51581(variablePath), "PathNotFound", f_1360_51657_51689())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 51715, 51734);

                        throw itemNotFound;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 51354, 51753);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 51773, 52935) || true) && (f_1360_51777_51790(writers) > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 51773, 52935);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 51917, 52036);
                            foreach (IContentWriter w in f_1360_51946_51953_I(writers))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 51917, 52036);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 52003, 52013);

                                f_1360_52003_52012(w);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 51917, 52036);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1360, 1, 120);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1360, 1, 120);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 52060, 52331);

                        PSArgumentException
                        argException =
                        f_1360_52120_52330("path", f_1360_52222_52272(), f_1360_52303_52329(variablePath))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 52418, 52451);

                        ProviderInfo
                        providerInfo = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 52473, 52589);

                        string
                        unused =
                        f_1360_52514_52588(f_1360_52514_52526(this), f_1360_52543_52569(variablePath), out providerInfo)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 52613, 52916);

                        throw f_1360_52619_52915(this, "ProviderVariableSyntaxInvalid", f_1360_52734_52783(), providerInfo, f_1360_52849_52875(variablePath), argException);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 51773, 52935);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 52955, 52990);

                    IContentWriter
                    writer = f_1360_52979_52989(writers, 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 53010, 53073);

                    IList
                    content = newValue as IList ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.IList>(1360, 53026, 53072) ?? new object[] { newValue })
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 53137, 53159);

                        f_1360_53137_53158(writer, content);
                    }
                    catch (Exception e) // Third-party callout, catch-all OK
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1360, 53196, 53990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 53356, 53389);

                        ProviderInfo
                        providerInfo = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 53411, 53527);

                        string
                        unused =
                        f_1360_53452_53526(f_1360_53452_53464(this), f_1360_53481_53507(variablePath), out providerInfo)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 53551, 53923);

                        ProviderInvocationException
                        providerException =
                        f_1360_53624_53922("ProviderContentWriteError", f_1360_53744_53789(), providerInfo, f_1360_53863_53889(variablePath), e)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 53947, 53971);

                        throw providerException;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1360, 53196, 53990);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1360, 54008, 54090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 54056, 54071);

                        f_1360_54056_54070(writer);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1360, 54008, 54090);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 46315, 54856);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 54872, 54886);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 45822, 54897);

                System.Management.Automation.PSArgumentNullException
                f_1360_46131_46185(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 46131, 46185);
                    return return_v;
                }


                bool
                f_1360_46319_46342(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 46319, 46342);
                    return return_v;
                }


                bool
                f_1360_46457_46477(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsLocal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 46457, 46477);
                    return return_v;
                }


                bool
                f_1360_46481_46512(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsUnscopedVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 46481, 46512);
                    return return_v;
                }


                bool
                f_1360_46622_46643(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 46622, 46643);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1360_46693_46718(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScriptScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 46693, 46718);
                    return return_v;
                }


                bool
                f_1360_46765_46786(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsGlobal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 46765, 46786);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1360_46836_46847()
                {
                    var return_v = GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 46836, 46847);
                    return return_v;
                }


                bool
                f_1360_46894_46916(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsPrivate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 46894, 46916);
                    return return_v;
                }


                string
                f_1360_47107_47133(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 47107, 47133);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1360_47063_47299(System.Management.Automation.SessionStateScope
                this_param, string
                name, object
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(name, value, asValue, force, sessionState, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 47063, 47299);
                    return return_v;
                }


                bool
                f_1360_47439_47461(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsPrivate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 47439, 47461);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1360_47544_47561(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 47544, 47561);
                    return return_v;
                }


                object
                f_1360_47944_47998(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = this_param.GetVariableValue(variablePath, out context, out scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 47944, 47998);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1360_48389_48423(System.Management.Automation.CmdletProviderContext
                contextToCopyFrom)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(contextToCopyFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 48389, 48423);
                    return return_v;
                }


                string
                f_1360_48560_48586(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 48560, 48586);
                    return return_v;
                }


                int
                f_1360_48532_48610(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.ClearContent(paths, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 48532, 48610);
                    return 0;
                }


                string
                f_1360_48989_49015(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 48989, 49015);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>
                f_1360_48923_49060(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetContentWriter(paths, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 48923, 49060);
                    return return_v;
                }


                int
                f_1360_49087_49127(System.Management.Automation.CmdletProviderContext
                this_param, bool
                wrapExceptionInProviderException)
                {
                    this_param.ThrowFirstErrorOrDoNothing(wrapExceptionInProviderException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 49087, 49127);
                    return 0;
                }


                string
                f_1360_49390_49416(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 49390, 49416);
                    return return_v;
                }


                int
                f_1360_49362_49433(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                force, bool
                literalPath)
                {
                    this_param.ClearContent(paths, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 49362, 49433);
                    return 0;
                }


                string
                f_1360_49812_49838(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 49812, 49838);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>
                f_1360_49746_49855(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.GetContentWriter(paths, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 49746, 49855);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1360_50162_50174(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 50162, 50174);
                    return return_v;
                }


                string
                f_1360_50191_50217(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 50191, 50217);
                    return return_v;
                }


                string
                f_1360_50162_50236(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 50162, 50236);
                    return return_v;
                }


                string
                f_1360_50383_50433()
                {
                    var return_v = SessionStateStrings.ProviderCannotBeUsedAsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 50383, 50433);
                    return return_v;
                }


                string
                f_1360_50499_50525(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 50499, 50525);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1360_50267_50599(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.NotImplementedException
                e, bool
                useInnerExceptionErrorMessage)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, (System.Exception)e, useInnerExceptionErrorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 50267, 50599);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1360_50879_50891(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 50879, 50891);
                    return return_v;
                }


                string
                f_1360_50908_50934(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 50908, 50934);
                    return return_v;
                }


                string
                f_1360_50879_50953(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 50879, 50953);
                    return return_v;
                }


                string
                f_1360_51100_51150()
                {
                    var return_v = SessionStateStrings.ProviderCannotBeUsedAsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 51100, 51150);
                    return return_v;
                }


                string
                f_1360_51216_51242(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 51216, 51242);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1360_50984_51314(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.NotSupportedException
                e, bool
                useInnerExceptionErrorMessage)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, (System.Exception)e, useInnerExceptionErrorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 50984, 51314);
                    return return_v;
                }


                int
                f_1360_51377_51390(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 51377, 51390);
                    return return_v;
                }


                string
                f_1360_51555_51581(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 51555, 51581);
                    return return_v;
                }


                string
                f_1360_51657_51689()
                {
                    var return_v = SessionStateStrings.PathNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 51657, 51689);
                    return return_v;
                }


                System.Management.Automation.ItemNotFoundException
                f_1360_51499_51690(string
                path, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.ItemNotFoundException(path, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 51499, 51690);
                    return return_v;
                }


                int
                f_1360_51777_51790(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 51777, 51790);
                    return return_v;
                }


                int
                f_1360_52003_52012(System.Management.Automation.Provider.IContentWriter
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 52003, 52012);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>
                f_1360_51946_51953_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 51946, 51953);
                    return return_v;
                }


                string
                f_1360_52222_52272()
                {
                    var return_v = SessionStateStrings.VariablePathResolvedToMultiple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 52222, 52272);
                    return return_v;
                }


                string
                f_1360_52303_52329(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 52303, 52329);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1360_52120_52330(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 52120, 52330);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1360_52514_52526(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 52514, 52526);
                    return return_v;
                }


                string
                f_1360_52543_52569(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 52543, 52569);
                    return return_v;
                }


                string
                f_1360_52514_52588(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 52514, 52588);
                    return return_v;
                }


                string
                f_1360_52734_52783()
                {
                    var return_v = SessionStateStrings.ProviderVariableSyntaxInvalid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 52734, 52783);
                    return return_v;
                }


                string
                f_1360_52849_52875(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 52849, 52875);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1360_52619_52915(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Management.Automation.PSArgumentException
                e)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 52619, 52915);
                    return return_v;
                }


                System.Management.Automation.Provider.IContentWriter
                f_1360_52979_52989(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 52979, 52989);
                    return return_v;
                }


                System.Collections.IList
                f_1360_53137_53158(System.Management.Automation.Provider.IContentWriter
                this_param, System.Collections.IList
                content)
                {
                    var return_v = this_param.Write(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 53137, 53158);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1360_53452_53464(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 53452, 53464);
                    return return_v;
                }


                string
                f_1360_53481_53507(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 53481, 53507);
                    return return_v;
                }


                string
                f_1360_53452_53526(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 53452, 53526);
                    return return_v;
                }


                string
                f_1360_53744_53789()
                {
                    var return_v = SessionStateStrings.ProviderContentWriteError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 53744, 53789);
                    return return_v;
                }


                string
                f_1360_53863_53889(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 53863, 53889);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1360_53624_53922(string
                errorId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.ProviderInvocationException(errorId, resourceStr, provider, path, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 53624, 53922);
                    return return_v;
                }


                int
                f_1360_54056_54070(System.Management.Automation.Provider.IContentWriter
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 54056, 54070);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 45822, 54897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 45822, 54897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object SetVariableAtScope(PSVariable variable, string scopeID, bool force, CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 56518, 57134);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 56648, 56809) || true) && (variable == null || (DynAbs.Tracing.TraceSender.Expression_False(1360, 56652, 56707) || f_1360_56672_56707(f_1360_56693_56706(variable))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 56648, 56809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 56741, 56794);

                    throw f_1360_56747_56793("variable");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 56648, 56809);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 56825, 56879);

                SessionStateScope
                lookupScope = f_1360_56857_56878(this, scopeID)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 56895, 57123);

                return
                f_1360_56919_57122(lookupScope, f_1360_56965_56978(variable), variable, false, force, this, origin);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 56518, 57134);

                string
                f_1360_56693_56706(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 56693, 56706);
                    return return_v;
                }


                bool
                f_1360_56672_56707(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 56672, 56707);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1360_56747_56793(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 56747, 56793);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1360_56857_56878(System.Management.Automation.SessionStateInternal
                this_param, string
                scopeID)
                {
                    var return_v = this_param.GetScopeByID(scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 56857, 56878);
                    return return_v;
                }


                string
                f_1360_56965_56978(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 56965, 56978);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1360_56919_57122(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.PSVariable
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(name, (object)value, asValue, force, sessionState, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 56919, 57122);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 56518, 57134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 56518, 57134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object NewVariable(PSVariable variable, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 57752, 58166);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 57837, 57998) || true) && (variable == null || (DynAbs.Tracing.TraceSender.Expression_False(1360, 57841, 57896) || f_1360_57861_57896(f_1360_57882_57895(variable))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 57837, 57998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 57930, 57983);

                    throw f_1360_57936_57982("variable");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 57837, 57998);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 58014, 58155);

                return
                f_1360_58038_58154(f_1360_58038_58055(this), variable, force, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 57752, 58166);

                string
                f_1360_57882_57895(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 57882, 57895);
                    return return_v;
                }


                bool
                f_1360_57861_57896(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 57861, 57896);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1360_57936_57982(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 57936, 57982);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1360_58038_58055(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 58038, 58055);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1360_58038_58154(System.Management.Automation.SessionStateScope
                this_param, System.Management.Automation.PSVariable
                newVariable, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = this_param.NewVariable(newVariable, force, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 58038, 58154);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 57752, 58166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 57752, 58166);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object NewVariableAtScope(PSVariable variable, string scopeID, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 59610, 60218);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 59718, 59879) || true) && (variable == null || (DynAbs.Tracing.TraceSender.Expression_False(1360, 59722, 59777) || f_1360_59742_59777(f_1360_59763_59776(variable))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 59718, 59879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 59811, 59864);

                    throw f_1360_59817_59863("variable");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 59718, 59879);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 60002, 60056);

                SessionStateScope
                lookupScope = f_1360_60034_60055(this, scopeID)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 60072, 60207);

                return
                f_1360_60096_60206(lookupScope, variable, force, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 59610, 60218);

                string
                f_1360_59763_59776(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 59763, 59776);
                    return return_v;
                }


                bool
                f_1360_59742_59777(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 59742, 59777);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1360_59817_59863(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 59817, 59863);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1360_60034_60055(System.Management.Automation.SessionStateInternal
                this_param, string
                scopeID)
                {
                    var return_v = this_param.GetScopeByID(scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 60034, 60055);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1360_60096_60206(System.Management.Automation.SessionStateScope
                this_param, System.Management.Automation.PSVariable
                newVariable, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = this_param.NewVariable(newVariable, force, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 60096, 60206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 59610, 60218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 59610, 60218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void RemoveVariable(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 61416, 61521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 61482, 61510);

                f_1360_61482_61509(this, name, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 61416, 61521);

                int
                f_1360_61482_61509(System.Management.Automation.SessionStateInternal
                this_param, string
                name, bool
                force)
                {
                    this_param.RemoveVariable(name, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 61482, 61509);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 61416, 61521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 61416, 61521);
            }
        }

        internal void RemoveVariable(string name, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 62814, 63728);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 62892, 63010) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 62892, 63010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 62942, 62995);

                    throw f_1360_62948_62994("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 62892, 63010);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 63026, 63077);

                VariablePath
                variablePath = f_1360_63054_63076(name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 63091, 63122);

                SessionStateScope
                scope = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 63138, 63717) || true) && (f_1360_63142_63165(variablePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 63138, 63717);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 63199, 63368) || true) && (f_1360_63203_63243(this, variablePath, out scope) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 63199, 63368);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 63293, 63349);

                        f_1360_63293_63348(scope, f_1360_63314_63340(variablePath), force);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 63199, 63368);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 63138, 63717);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 63138, 63717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 63434, 63515);

                    CmdletProviderContext
                    context = f_1360_63466_63514(f_1360_63492_63513(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 63533, 63555);

                    context.Force = force;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 63575, 63647);

                    f_1360_63575_63646(this, new string[] { f_1360_63601_63627(variablePath) }, false, context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 63665, 63702);

                    f_1360_63665_63701(context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 63138, 63717);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 62814, 63728);

                System.Management.Automation.PSArgumentNullException
                f_1360_62948_62994(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 62948, 62994);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1360_63054_63076(string
                path)
                {
                    var return_v = new System.Management.Automation.VariablePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 63054, 63076);
                    return return_v;
                }


                bool
                f_1360_63142_63165(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 63142, 63165);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1360_63203_63243(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = this_param.GetVariableItem(variablePath, out scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 63203, 63243);
                    return return_v;
                }


                string
                f_1360_63314_63340(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 63314, 63340);
                    return return_v;
                }


                int
                f_1360_63293_63348(System.Management.Automation.SessionStateScope
                this_param, string
                name, bool
                force)
                {
                    this_param.RemoveVariable(name, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 63293, 63348);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1360_63492_63513(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 63492, 63513);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1360_63466_63514(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 63466, 63514);
                    return return_v;
                }


                string
                f_1360_63601_63627(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 63601, 63627);
                    return return_v;
                }


                int
                f_1360_63575_63646(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                recurse, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.RemoveItem(paths, recurse, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 63575, 63646);
                    return 0;
                }


                int
                f_1360_63665_63701(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.ThrowFirstErrorOrDoNothing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 63665, 63701);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 62814, 63728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 62814, 63728);
            }
        }

        internal void RemoveVariable(PSVariable variable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 64213, 64330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 64287, 64319);

                f_1360_64287_64318(this, variable, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 64213, 64330);

                int
                f_1360_64287_64318(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.PSVariable
                variable, bool
                force)
                {
                    this_param.RemoveVariable(variable, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 64287, 64318);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 64213, 64330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 64213, 64330);
            }
        }

        internal void RemoveVariable(PSVariable variable, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 64944, 65463);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 65030, 65156) || true) && (variable == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 65030, 65156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 65084, 65141);

                    throw f_1360_65090_65140("variable");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 65030, 65156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 65172, 65232);

                VariablePath
                variablePath = f_1360_65200_65231(f_1360_65217_65230(variable))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 65248, 65279);

                SessionStateScope
                scope = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 65295, 65452) || true) && (f_1360_65299_65339(this, variablePath, out scope) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 65295, 65452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 65381, 65437);

                    f_1360_65381_65436(scope, f_1360_65402_65428(variablePath), force);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 65295, 65452);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 64944, 65463);

                System.Management.Automation.PSArgumentNullException
                f_1360_65090_65140(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 65090, 65140);
                    return return_v;
                }


                string
                f_1360_65217_65230(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 65217, 65230);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1360_65200_65231(string
                path)
                {
                    var return_v = new System.Management.Automation.VariablePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 65200, 65231);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1360_65299_65339(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = this_param.GetVariableItem(variablePath, out scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 65299, 65339);
                    return return_v;
                }


                string
                f_1360_65402_65428(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 65402, 65428);
                    return return_v;
                }


                int
                f_1360_65381_65436(System.Management.Automation.SessionStateScope
                this_param, string
                name, bool
                force)
                {
                    this_param.RemoveVariable(name, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 65381, 65436);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 64944, 65463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 64944, 65463);
            }
        }

        internal void RemoveVariableAtScope(string name, string scopeID)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 66620, 66764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 66709, 66753);

                f_1360_66709_66752(this, name, scopeID, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 66620, 66764);

                int
                f_1360_66709_66752(System.Management.Automation.SessionStateInternal
                this_param, string
                name, string
                scopeID, bool
                force)
                {
                    this_param.RemoveVariableAtScope(name, scopeID, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 66709, 66752);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 66620, 66764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 66620, 66764);
            }
        }

        internal void RemoveVariableAtScope(string name, string scopeID, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 68055, 69281);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 68156, 68284) || true) && (f_1360_68160_68186(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 68156, 68284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 68220, 68269);

                    throw f_1360_68226_68268("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 68156, 68284);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 68300, 68351);

                VariablePath
                variablePath = f_1360_68328_68350(name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 68367, 68404);

                SessionStateScope
                lookupScope = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 68527, 68563);

                lookupScope = f_1360_68541_68562(this, scopeID);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 68579, 69270) || true) && (f_1360_68583_68606(variablePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 68579, 69270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 68640, 68702);

                    f_1360_68640_68701(lookupScope, f_1360_68667_68693(variablePath), force);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 68579, 69270);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 68579, 69270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 68768, 68833);

                    PSDriveInfo
                    drive = f_1360_68788_68832(lookupScope, f_1360_68809_68831(variablePath))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 68853, 69255) || true) && (drive != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 68853, 69255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 68912, 68993);

                        CmdletProviderContext
                        context = f_1360_68944_68992(f_1360_68970_68991(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 69015, 69037);

                        context.Drive = drive;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 69059, 69081);

                        context.Force = force;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 69105, 69177);

                        f_1360_69105_69176(this, new string[] { f_1360_69131_69157(variablePath) }, false, context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 69199, 69236);

                        f_1360_69199_69235(context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 68853, 69255);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 68579, 69270);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 68055, 69281);

                bool
                f_1360_68160_68186(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 68160, 68186);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1360_68226_68268(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 68226, 68268);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1360_68328_68350(string
                path)
                {
                    var return_v = new System.Management.Automation.VariablePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 68328, 68350);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1360_68541_68562(System.Management.Automation.SessionStateInternal
                this_param, string
                scopeID)
                {
                    var return_v = this_param.GetScopeByID(scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 68541, 68562);
                    return return_v;
                }


                bool
                f_1360_68583_68606(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 68583, 68606);
                    return return_v;
                }


                string
                f_1360_68667_68693(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 68667, 68693);
                    return return_v;
                }


                int
                f_1360_68640_68701(System.Management.Automation.SessionStateScope
                this_param, string
                name, bool
                force)
                {
                    this_param.RemoveVariable(name, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 68640, 68701);
                    return 0;
                }


                string
                f_1360_68809_68831(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.DriveName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 68809, 68831);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1360_68788_68832(System.Management.Automation.SessionStateScope
                this_param, string
                name)
                {
                    var return_v = this_param.GetDrive(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 68788, 68832);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1360_68970_68991(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 68970, 68991);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1360_68944_68992(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 68944, 68992);
                    return return_v;
                }


                string
                f_1360_69131_69157(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 69131, 69157);
                    return return_v;
                }


                int
                f_1360_69105_69176(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                recurse, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.RemoveItem(paths, recurse, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 69105, 69176);
                    return 0;
                }


                int
                f_1360_69199_69235(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.ThrowFirstErrorOrDoNothing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 69199, 69235);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 68055, 69281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 68055, 69281);
            }
        }

        internal void RemoveVariableAtScope(PSVariable variable, string scopeID)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 70092, 70248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 70189, 70237);

                f_1360_70189_70236(this, variable, scopeID, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 70092, 70248);

                int
                f_1360_70189_70236(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.PSVariable
                variable, string
                scopeID, bool
                force)
                {
                    this_param.RemoveVariableAtScope(variable, scopeID, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 70189, 70236);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 70092, 70248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 70092, 70248);
            }
        }

        internal void RemoveVariableAtScope(PSVariable variable, string scopeID, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 71188, 71713);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 71297, 71423) || true) && (variable == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 71297, 71423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 71351, 71408);

                    throw f_1360_71357_71407("variable");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 71297, 71423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 71439, 71499);

                VariablePath
                variablePath = f_1360_71467_71498(f_1360_71484_71497(variable))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 71570, 71624);

                SessionStateScope
                lookupScope = f_1360_71602_71623(this, scopeID)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 71640, 71702);

                f_1360_71640_71701(
                            lookupScope, f_1360_71667_71693(variablePath), force);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 71188, 71713);

                System.Management.Automation.PSArgumentNullException
                f_1360_71357_71407(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 71357, 71407);
                    return return_v;
                }


                string
                f_1360_71484_71497(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 71484, 71497);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1360_71467_71498(string
                path)
                {
                    var return_v = new System.Management.Automation.VariablePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 71467, 71498);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1360_71602_71623(System.Management.Automation.SessionStateInternal
                this_param, string
                scopeID)
                {
                    var return_v = this_param.GetScopeByID(scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 71602, 71623);
                    return return_v;
                }


                string
                f_1360_71667_71693(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.QualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 71667, 71693);
                    return return_v;
                }


                int
                f_1360_71640_71701(System.Management.Automation.SessionStateScope
                this_param, string
                name, bool
                force)
                {
                    this_param.RemoveVariable(name, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 71640, 71701);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 71188, 71713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 71188, 71713);
            }
        }

        internal IDictionary<string, PSVariable> GetVariableTable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 72093, 72663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 72177, 72287);

                SessionStateScopeEnumerator
                scopeEnumerator =
                f_1360_72240_72286(_currentScope)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 72303, 72429);

                Dictionary<string, PSVariable>
                result =
                f_1360_72360_72428(f_1360_72395_72427())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 72445, 72622);
                    foreach (SessionStateScope scope in f_1360_72481_72496_I(scopeEnumerator))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 72445, 72622);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 72530, 72607);

                        f_1360_72530_72606(this, scope, result, includePrivate: scope == _currentScope);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 72445, 72622);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1360, 1, 178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1360, 1, 178);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 72638, 72652);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 72093, 72663);

                System.Management.Automation.SessionStateScopeEnumerator
                f_1360_72240_72286(System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = new System.Management.Automation.SessionStateScopeEnumerator(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 72240, 72286);
                    return return_v;
                }


                System.StringComparer
                f_1360_72395_72427()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 72395, 72427);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                f_1360_72360_72428(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 72360, 72428);
                    return return_v;
                }


                int
                f_1360_72530_72606(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.SessionStateScope
                scope, System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                result, bool
                includePrivate)
                {
                    this_param.GetScopeVariableTable(scope, result, includePrivate: includePrivate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 72530, 72606);
                    return 0;
                }


                System.Management.Automation.SessionStateScopeEnumerator
                f_1360_72481_72496_I(System.Management.Automation.SessionStateScopeEnumerator
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 72481, 72496);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 72093, 72663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 72093, 72663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetScopeVariableTable(SessionStateScope scope, Dictionary<string, PSVariable> result, bool includePrivate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 72675, 73674);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 72819, 73346);
                    foreach (KeyValuePair<string, PSVariable> entry in f_1360_72870_72885_I(f_1360_72870_72885(scope)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 72819, 73346);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 72919, 73331) || true) && (!f_1360_72924_72953(result, entry.Key))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 72919, 73331);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 73123, 73152);

                            PSVariable
                            var = entry.Value
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 73176, 73312) || true) && (f_1360_73180_73194_M(!var.IsPrivate) || (DynAbs.Tracing.TraceSender.Expression_False(1360, 73180, 73212) || includePrivate))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 73176, 73312);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 73262, 73289);

                                f_1360_73262_73288(result, entry.Key, var);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 73176, 73312);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 72919, 73331);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 72819, 73346);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1360, 1, 528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1360, 1, 528);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 73362, 73510);
                    foreach (var dottedScope in f_1360_73390_73408_I(f_1360_73390_73408(scope)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 73362, 73510);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 73442, 73495);

                        f_1360_73442_73494(dottedScope, result, includePrivate);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 73362, 73510);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1360, 1, 149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1360, 1, 149);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 73526, 73663) || true) && (f_1360_73530_73547(scope) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1360, 73526, 73663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 73589, 73648);

                    f_1360_73589_73647(f_1360_73589_73606(scope), result, includePrivate);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1360, 73526, 73663);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 72675, 73674);

                System.Collections.Generic.IDictionary<string, System.Management.Automation.PSVariable>
                f_1360_72870_72885(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 72870, 72885);
                    return return_v;
                }


                bool
                f_1360_72924_72953(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 72924, 72953);
                    return return_v;
                }


                bool
                f_1360_73180_73194_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 73180, 73194);
                    return return_v;
                }


                int
                f_1360_73262_73288(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                this_param, string
                key, System.Management.Automation.PSVariable
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 73262, 73288);
                    return 0;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.PSVariable>
                f_1360_72870_72885_I(System.Collections.Generic.IDictionary<string, System.Management.Automation.PSVariable>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 72870, 72885);
                    return return_v;
                }


                System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                f_1360_73390_73408(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.DottedScopes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 73390, 73408);
                    return return_v;
                }


                int
                f_1360_73442_73494(System.Management.Automation.MutableTuple
                this_param, System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                result, bool
                includePrivate)
                {
                    this_param.GetVariableTable(result, includePrivate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 73442, 73494);
                    return 0;
                }


                System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                f_1360_73390_73408_I(System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 73390, 73408);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1360_73530_73547(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.LocalsTuple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 73530, 73547);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1360_73589_73606(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.LocalsTuple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 73589, 73606);
                    return return_v;
                }


                int
                f_1360_73589_73647(System.Management.Automation.MutableTuple
                this_param, System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                result, bool
                includePrivate)
                {
                    this_param.GetVariableTable(result, includePrivate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 73589, 73647);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 72675, 73674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 72675, 73674);
            }
        }

        internal IDictionary<string, PSVariable> GetVariableTableAtScope(string scopeID)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1360, 74486, 74801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 74591, 74673);

                var
                result = f_1360_74604_74672(f_1360_74639_74671())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 74687, 74762);

                f_1360_74687_74761(this, f_1360_74709_74730(this, scopeID), result, includePrivate: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 74776, 74790);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1360, 74486, 74801);

                System.StringComparer
                f_1360_74639_74671()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1360, 74639, 74671);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                f_1360_74604_74672(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 74604, 74672);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1360_74709_74730(System.Management.Automation.SessionStateInternal
                this_param, string
                scopeID)
                {
                    var return_v = this_param.GetScopeByID(scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 74709, 74730);
                    return return_v;
                }


                int
                f_1360_74687_74761(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.SessionStateScope
                scope, System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                result, bool
                includePrivate)
                {
                    this_param.GetScopeVariableTable(scope, result, includePrivate: includePrivate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 74687, 74761);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1360, 74486, 74801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1360, 74486, 74801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<PSVariable> ExportedVariables { get; }
    }
}

#pragma warning restore 56500
