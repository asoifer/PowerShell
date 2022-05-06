// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    internal sealed partial class SessionStateInternal
    {
        internal void AddSessionStateEntry(SessionStateAliasEntry entry, string scopeID)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 897, 1419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 1002, 1269);

                AliasInfo
                alias = new AliasInfo(f_1341_1034_1044(entry), f_1341_1046_1062(entry), f_1341_1064_1085(this), f_1341_1087_1100(entry))
                {
                    Visibility = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1341_1147_1163(entry), 1341, 1020, 1268),
                    Module = f_1341_1191_1203(entry),
                    Description = f_1341_1236_1253(entry)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 1337, 1408);

                f_1341_1337_1407(
                            // Create alias in the global scope...
                            this, alias, scopeID, true, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 897, 1419);

                string
                f_1341_1034_1044(System.Management.Automation.Runspaces.SessionStateAliasEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 1034, 1044);
                    return return_v;
                }


                string
                f_1341_1046_1062(System.Management.Automation.Runspaces.SessionStateAliasEntry
                this_param)
                {
                    var return_v = this_param.Definition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 1046, 1062);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1341_1064_1085(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 1064, 1085);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1341_1087_1100(System.Management.Automation.Runspaces.SessionStateAliasEntry
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 1087, 1100);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1341_1147_1163(System.Management.Automation.Runspaces.SessionStateAliasEntry
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 1147, 1163);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1341_1191_1203(System.Management.Automation.Runspaces.SessionStateAliasEntry
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 1191, 1203);
                    return return_v;
                }


                string
                f_1341_1236_1253(System.Management.Automation.Runspaces.SessionStateAliasEntry
                this_param)
                {
                    var return_v = this_param.Description
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 1236, 1253);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1341_1337_1407(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.AliasInfo
                alias, string
                scopeID, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetAliasItemAtScope(alias, scopeID, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 1337, 1407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 897, 1419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 897, 1419);
            }
        }

        internal IDictionary<string, AliasInfo> GetAliasTable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 1532, 2629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 1612, 1736);

                Dictionary<string, AliasInfo>
                result =
                f_1341_1668_1735(f_1341_1702_1734())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 1752, 1862);

                SessionStateScopeEnumerator
                scopeEnumerator =
                f_1341_1815_1861(_currentScope)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 1878, 2588);
                    foreach (SessionStateScope scope in f_1341_1914_1929_I(scopeEnumerator))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 1878, 2588);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 1963, 2573);
                            foreach (AliasInfo entry in f_1341_1991_2007_I(f_1341_1991_2007(scope)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 1963, 2573);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 2049, 2554) || true) && (!f_1341_2054_2084(result, f_1341_2073_2083(entry)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 2049, 2554);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 2309, 2531) || true) && ((f_1341_2314_2327(entry) & ScopedItemOptions.Private) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(1341, 2313, 2416) || scope == _currentScope))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 2309, 2531);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 2474, 2504);

                                        f_1341_2474_2503(result, f_1341_2485_2495(entry), entry);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 2309, 2531);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 2049, 2554);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 1963, 2573);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1341, 1, 611);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1341, 1, 611);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 1878, 2588);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1341, 1, 711);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1341, 1, 711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 2604, 2618);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 1532, 2629);

                System.StringComparer
                f_1341_1702_1734()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 1702, 1734);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
                f_1341_1668_1735(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 1668, 1735);
                    return return_v;
                }


                System.Management.Automation.SessionStateScopeEnumerator
                f_1341_1815_1861(System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = new System.Management.Automation.SessionStateScopeEnumerator(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 1815, 1861);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.AliasInfo>
                f_1341_1991_2007(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.AliasTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 1991, 2007);
                    return return_v;
                }


                string
                f_1341_2073_2083(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 2073, 2083);
                    return return_v;
                }


                bool
                f_1341_2054_2084(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 2054, 2084);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1341_2314_2327(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 2314, 2327);
                    return return_v;
                }


                string
                f_1341_2485_2495(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 2485, 2495);
                    return return_v;
                }


                int
                f_1341_2474_2503(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
                this_param, string
                key, System.Management.Automation.AliasInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 2474, 2503);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.AliasInfo>
                f_1341_1991_2007_I(System.Collections.Generic.IEnumerable<System.Management.Automation.AliasInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 1991, 2007);
                    return return_v;
                }


                System.Management.Automation.SessionStateScopeEnumerator
                f_1341_1914_1929_I(System.Management.Automation.SessionStateScopeEnumerator
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 1914, 1929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 1532, 2629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 1532, 2629);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IDictionary<string, AliasInfo> GetAliasTableAtScope(string scopeID)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 3456, 4244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 3557, 3681);

                Dictionary<string, AliasInfo>
                result =
                f_1341_3613_3680(f_1341_3647_3679())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 3697, 3745);

                SessionStateScope
                scope = f_1341_3723_3744(this, scopeID)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 3761, 4203);
                    foreach (AliasInfo entry in f_1341_3789_3805_I(f_1341_3789_3805(scope)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 3761, 4203);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 3998, 4188) || true) && ((f_1341_4003_4016(entry) & ScopedItemOptions.Private) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(1341, 4002, 4097) || scope == _currentScope))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 3998, 4188);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 4139, 4169);

                            f_1341_4139_4168(result, f_1341_4150_4160(entry), entry);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 3998, 4188);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 3761, 4203);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1341, 1, 443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1341, 1, 443);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 4219, 4233);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 3456, 4244);

                System.StringComparer
                f_1341_3647_3679()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 3647, 3679);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
                f_1341_3613_3680(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 3613, 3680);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1341_3723_3744(System.Management.Automation.SessionStateInternal
                this_param, string
                scopeID)
                {
                    var return_v = this_param.GetScopeByID(scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 3723, 3744);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.AliasInfo>
                f_1341_3789_3805(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.AliasTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 3789, 3805);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1341_4003_4016(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 4003, 4016);
                    return return_v;
                }


                string
                f_1341_4150_4160(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 4150, 4160);
                    return return_v;
                }


                int
                f_1341_4139_4168(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
                this_param, string
                key, System.Management.Automation.AliasInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 4139, 4168);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.AliasInfo>
                f_1341_3789_3805_I(System.Collections.Generic.IEnumerable<System.Management.Automation.AliasInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 3789, 3805);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 3456, 4244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 3456, 4244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<AliasInfo> ExportedAliases { get; }

        internal AliasInfo GetAlias(string aliasName, CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 4908, 6265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 5000, 5024);

                AliasInfo
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 5038, 5134) || true) && (f_1341_5042_5073(aliasName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 5038, 5134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 5107, 5119);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 5038, 5134);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 5263, 5373);

                SessionStateScopeEnumerator
                scopeEnumerator =
                f_1341_5326_5372(_currentScope)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 5389, 6224);
                    foreach (SessionStateScope scope in f_1341_5425_5440_I(scopeEnumerator))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 5389, 6224);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 5474, 5509);

                        result = f_1341_5483_5508(scope, aliasName);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 5529, 6209) || true) && (result != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 5529, 6209);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 5657, 5704);

                            f_1341_5657_5703(origin, result);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 5895, 6190) || true) && ((f_1341_5900_5914(result) & ScopedItemOptions.Private) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1341, 5899, 5999) && scope != _currentScope))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 5895, 6190);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 6049, 6063);

                                result = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 5895, 6190);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 5895, 6190);
                                DynAbs.Tracing.TraceSender.TraceBreak(1341, 6161, 6167);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 5895, 6190);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 5529, 6209);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 5389, 6224);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1341, 1, 836);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1341, 1, 836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 6240, 6254);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 4908, 6265);

                bool
                f_1341_5042_5073(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 5042, 5073);
                    return return_v;
                }


                System.Management.Automation.SessionStateScopeEnumerator
                f_1341_5326_5372(System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = new System.Management.Automation.SessionStateScopeEnumerator(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 5326, 5372);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1341_5483_5508(System.Management.Automation.SessionStateScope
                this_param, string
                name)
                {
                    var return_v = this_param.GetAlias(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 5483, 5508);
                    return return_v;
                }


                int
                f_1341_5657_5703(System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.AliasInfo
                valueToCheck)
                {
                    SessionState.ThrowIfNotVisible(origin, (object)valueToCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 5657, 5703);
                    return 0;
                }


                System.Management.Automation.ScopedItemOptions
                f_1341_5900_5914(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 5900, 5914);
                    return return_v;
                }


                System.Management.Automation.SessionStateScopeEnumerator
                f_1341_5425_5440_I(System.Management.Automation.SessionStateScopeEnumerator
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 5425, 5440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 4908, 6265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 4908, 6265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AliasInfo GetAlias(string aliasName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 6609, 6741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 6679, 6730);

                return f_1341_6686_6729(this, aliasName, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 6609, 6741);

                System.Management.Automation.AliasInfo
                f_1341_6686_6729(System.Management.Automation.SessionStateInternal
                this_param, string
                aliasName, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.GetAlias(aliasName, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 6686, 6729);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 6609, 6741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 6609, 6741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AliasInfo GetAliasAtScope(string aliasName, string scopeID)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 7781, 8524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 7874, 7898);

                AliasInfo
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 7912, 8008) || true) && (f_1341_7916_7947(aliasName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 7912, 8008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 7981, 7993);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 7912, 8008);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 8024, 8072);

                SessionStateScope
                scope = f_1341_8050_8071(this, scopeID)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 8086, 8121);

                result = f_1341_8095_8120(scope, aliasName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 8288, 8483) || true) && (result != null && (DynAbs.Tracing.TraceSender.Expression_True(1341, 8292, 8376) && (f_1341_8328_8342(result) & ScopedItemOptions.Private) != 0) && (DynAbs.Tracing.TraceSender.Expression_True(1341, 8292, 8420) && scope != _currentScope))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 8288, 8483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 8454, 8468);

                    result = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 8288, 8483);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 8499, 8513);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 7781, 8524);

                bool
                f_1341_7916_7947(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 7916, 7947);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1341_8050_8071(System.Management.Automation.SessionStateInternal
                this_param, string
                scopeID)
                {
                    var return_v = this_param.GetScopeByID(scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 8050, 8071);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1341_8095_8120(System.Management.Automation.SessionStateScope
                this_param, string
                name)
                {
                    var return_v = this_param.GetAlias(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 8095, 8120);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1341_8328_8342(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 8328, 8342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 7781, 8524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 7781, 8524);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AliasInfo SetAliasValue(string aliasName, string value, bool force, CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 9546, 10109);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 9669, 9807) || true) && (f_1341_9673_9704(aliasName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 9669, 9807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 9738, 9792);

                    throw f_1341_9744_9791("aliasName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 9669, 9807);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 9823, 9953) || true) && (f_1341_9827_9854(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 9823, 9953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 9888, 9938);

                    throw f_1341_9894_9937("value");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 9823, 9953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 9969, 10070);

                AliasInfo
                info = f_1341_9986_10069(_currentScope, aliasName, value, f_1341_10032_10053(this), force, origin)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 10086, 10098);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 9546, 10109);

                bool
                f_1341_9673_9704(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 9673, 9704);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1341_9744_9791(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 9744, 9791);
                    return return_v;
                }


                bool
                f_1341_9827_9854(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 9827, 9854);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1341_9894_9937(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 9894, 9937);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1341_10032_10053(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 10032, 10053);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1341_9986_10069(System.Management.Automation.SessionStateScope
                this_param, string
                name, string
                value, System.Management.Automation.ExecutionContext
                context, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetAliasValue(name, value, context, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 9986, 10069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 9546, 10109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 9546, 10109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AliasInfo SetAliasValue(string aliasName, string value, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 11158, 11340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 11259, 11329);

                return f_1341_11266_11328(this, aliasName, value, force, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 11158, 11340);

                System.Management.Automation.AliasInfo
                f_1341_11266_11328(System.Management.Automation.SessionStateInternal
                this_param, string
                aliasName, string
                value, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetAliasValue(aliasName, value, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 11266, 11328);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 11158, 11340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 11158, 11340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AliasInfo SetAliasValue(
                    string aliasName,
                    string value,
                    ScopedItemOptions options,
                    bool force,
                    CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 12466, 13131);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 12682, 12820) || true) && (f_1341_12686_12717(aliasName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 12682, 12820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 12751, 12805);

                    throw f_1341_12757_12804("aliasName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 12682, 12820);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 12836, 12966) || true) && (f_1341_12840_12867(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 12836, 12966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 12901, 12951);

                    throw f_1341_12907_12950("value");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 12836, 12966);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 12982, 13092);

                AliasInfo
                info = f_1341_12999_13091(_currentScope, aliasName, value, options, f_1341_13054_13075(this), force, origin)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 13108, 13120);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 12466, 13131);

                bool
                f_1341_12686_12717(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 12686, 12717);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1341_12757_12804(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 12757, 12804);
                    return return_v;
                }


                bool
                f_1341_12840_12867(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 12840, 12867);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1341_12907_12950(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 12907, 12950);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1341_13054_13075(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 13054, 13075);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1341_12999_13091(System.Management.Automation.SessionStateScope
                this_param, string
                name, string
                value, System.Management.Automation.ScopedItemOptions
                options, System.Management.Automation.ExecutionContext
                context, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetAliasValue(name, value, options, context, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 12999, 13091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 12466, 13131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 12466, 13131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AliasInfo SetAliasValue(
                    string aliasName,
                    string value,
                    ScopedItemOptions options,
                    bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 14260, 14531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 14441, 14520);

                return f_1341_14448_14519(this, aliasName, value, options, force, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 14260, 14531);

                System.Management.Automation.AliasInfo
                f_1341_14448_14519(System.Management.Automation.SessionStateInternal
                this_param, string
                aliasName, string
                value, System.Management.Automation.ScopedItemOptions
                options, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetAliasValue(aliasName, value, options, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 14448, 14519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 14260, 14531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 14260, 14531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AliasInfo SetAliasItem(AliasInfo alias, bool force, CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 15465, 15813);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 15572, 15692) || true) && (alias == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 15572, 15692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 15623, 15677);

                    throw f_1341_15629_15676("alias");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 15572, 15692);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 15708, 15774);

                AliasInfo
                info = f_1341_15725_15773(_currentScope, alias, force, origin)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 15790, 15802);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 15465, 15813);

                System.Management.Automation.PSArgumentNullException
                f_1341_15629_15676(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 15629, 15676);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1341_15725_15773(System.Management.Automation.SessionStateScope
                this_param, System.Management.Automation.AliasInfo
                aliasToSet, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetAliasItem(aliasToSet, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 15725, 15773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 15465, 15813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 15465, 15813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AliasInfo SetAliasItemAtScope(AliasInfo alias, string scopeID, bool force, CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 17441, 18181);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 17571, 17691) || true) && (alias == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 17571, 17691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 17622, 17676);

                    throw f_1341_17628_17675("alias");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 17571, 17691);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 17826, 18004) || true) && (f_1341_17830_17912(scopeID, StringLiterals.Private, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 17826, 18004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 17946, 17989);

                    alias.Options |= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => ScopedItemOptions.Private, 1341, 17946, 17959);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 17826, 18004);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 18020, 18068);

                SessionStateScope
                scope = f_1341_18046_18067(this, scopeID)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 18084, 18142);

                AliasInfo
                info = f_1341_18101_18141(scope, alias, force, origin)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 18158, 18170);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 17441, 18181);

                System.Management.Automation.PSArgumentNullException
                f_1341_17628_17675(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 17628, 17675);
                    return return_v;
                }


                bool
                f_1341_17830_17912(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 17830, 17912);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1341_18046_18067(System.Management.Automation.SessionStateInternal
                this_param, string
                scopeID)
                {
                    var return_v = this_param.GetScopeByID(scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 18046, 18067);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1341_18101_18141(System.Management.Automation.SessionStateScope
                this_param, System.Management.Automation.AliasInfo
                aliasToSet, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetAliasItem(aliasToSet, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 18101, 18141);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 17441, 18181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 17441, 18181);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AliasInfo SetAliasItemAtScope(AliasInfo alias, string scopeID, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 19686, 19879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 19794, 19868);

                return f_1341_19801_19867(this, alias, scopeID, force, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 19686, 19879);

                System.Management.Automation.AliasInfo
                f_1341_19801_19867(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.AliasInfo
                alias, string
                scopeID, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetAliasItemAtScope(alias, scopeID, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 19801, 19867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 19686, 19879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 19686, 19879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void RemoveAlias(string aliasName, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 20487, 21717);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 20567, 20705) || true) && (f_1341_20571_20602(aliasName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 20567, 20705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 20636, 20690);

                    throw f_1341_20642_20689("aliasName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 20567, 20705);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 20793, 20903);

                SessionStateScopeEnumerator
                scopeEnumerator =
                f_1341_20856_20902(_currentScope)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 20919, 21706);
                    foreach (SessionStateScope scope in f_1341_20955_20970_I(scopeEnumerator))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 20919, 21706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 21004, 21069);

                        AliasInfo
                        alias =
                        f_1341_21043_21068(scope, aliasName)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 21089, 21691) || true) && (alias != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 21089, 21691);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 21315, 21672) || true) && ((f_1341_21320_21333(alias) & ScopedItemOptions.Private) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1341, 21319, 21418) && scope != _currentScope))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 21315, 21672);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 21468, 21481);

                                alias = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 21315, 21672);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 21315, 21672);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 21579, 21615);

                                f_1341_21579_21614(scope, aliasName, force);
                                DynAbs.Tracing.TraceSender.TraceBreak(1341, 21643, 21649);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 21315, 21672);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 21089, 21691);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 20919, 21706);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1341, 1, 788);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1341, 1, 788);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 20487, 21717);

                bool
                f_1341_20571_20602(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 20571, 20602);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1341_20642_20689(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 20642, 20689);
                    return return_v;
                }


                System.Management.Automation.SessionStateScopeEnumerator
                f_1341_20856_20902(System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = new System.Management.Automation.SessionStateScopeEnumerator(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 20856, 20902);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1341_21043_21068(System.Management.Automation.SessionStateScope
                this_param, string
                name)
                {
                    var return_v = this_param.GetAlias(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 21043, 21068);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1341_21320_21333(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1341, 21320, 21333);
                    return return_v;
                }


                int
                f_1341_21579_21614(System.Management.Automation.SessionStateScope
                this_param, string
                name, bool
                force)
                {
                    this_param.RemoveAlias(name, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 21579, 21614);
                    return 0;
                }


                System.Management.Automation.SessionStateScopeEnumerator
                f_1341_20955_20970_I(System.Management.Automation.SessionStateScopeEnumerator
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 20955, 20970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 20487, 21717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 20487, 21717);
            }
        }

        internal IEnumerable<string> GetAliasesByCommandName(string command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1341, 21930, 22431);

                var listYield = new List<String>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 22023, 22133);

                SessionStateScopeEnumerator
                scopeEnumerator =
                f_1341_22086_22132(_currentScope)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 22149, 22392);
                    foreach (SessionStateScope scope in f_1341_22185_22200_I(scopeEnumerator))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 22149, 22392);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 22234, 22377);
                            foreach (string alias in f_1341_22259_22297_I(f_1341_22259_22297(scope, command)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1341, 22234, 22377);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 22339, 22358);

                                listYield.Add(alias);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 22234, 22377);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1341, 1, 144);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1341, 1, 144);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1341, 22149, 22392);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1341, 1, 244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1341, 1, 244);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 22408, 22420);

                return listYield;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1341, 21930, 22431);

                return listYield;

                System.Management.Automation.SessionStateScopeEnumerator
                f_1341_22086_22132(System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = new System.Management.Automation.SessionStateScopeEnumerator(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 22086, 22132);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1341_22259_22297(System.Management.Automation.SessionStateScope
                this_param, string
                command)
                {
                    var return_v = this_param.GetAliasesByCommandName(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 22259, 22297);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1341_22259_22297_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 22259, 22297);
                    return return_v;
                }


                System.Management.Automation.SessionStateScopeEnumerator
                f_1341_22185_22200_I(System.Management.Automation.SessionStateScopeEnumerator
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 22185, 22200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1341, 21930, 22431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1341, 21930, 22431);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}

