// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal sealed partial class SessionStateInternal
    {
        internal void AddSessionStateEntry(SessionStateFunctionEntry entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 737, 1239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 829, 872);

                ScriptBlock
                sb = f_1347_846_871(f_1347_846_863(entry))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 888, 1036);

                FunctionInfo
                fn = f_1347_906_1035(this, f_1347_923_933(entry), sb, null, f_1347_945_958(entry), false, CommandOrigin.Internal, f_1347_991_1012(this), f_1347_1014_1028(entry), true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 1050, 1083);

                fn.Visibility = f_1347_1066_1082(entry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 1097, 1122);

                fn.Module = f_1347_1109_1121(entry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 1136, 1228);

                f_1347_1136_1150(fn).LanguageMode = f_1347_1166_1196(f_1347_1166_1183(entry)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PSLanguageMode?>(1347, 1166, 1227) ?? PSLanguageMode.FullLanguage);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 737, 1239);

                System.Management.Automation.ScriptBlock
                f_1347_846_863(System.Management.Automation.Runspaces.SessionStateFunctionEntry
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 846, 863);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1347_846_871(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 846, 871);
                    return return_v;
                }


                string
                f_1347_923_933(System.Management.Automation.Runspaces.SessionStateFunctionEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 923, 933);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1347_945_958(System.Management.Automation.Runspaces.SessionStateFunctionEntry
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 945, 958);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1347_991_1012(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 991, 1012);
                    return return_v;
                }


                string
                f_1347_1014_1028(System.Management.Automation.Runspaces.SessionStateFunctionEntry
                this_param)
                {
                    var return_v = this_param.HelpFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 1014, 1028);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1347_906_1035(System.Management.Automation.SessionStateInternal
                this_param, string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.FunctionInfo
                originalFunction, System.Management.Automation.ScopedItemOptions
                options, bool
                force, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.ExecutionContext
                context, string
                helpFile, bool
                isPreValidated)
                {
                    var return_v = this_param.SetFunction(name, function, originalFunction, options, force, origin, context, helpFile, isPreValidated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 906, 1035);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1347_1066_1082(System.Management.Automation.Runspaces.SessionStateFunctionEntry
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 1066, 1082);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1347_1109_1121(System.Management.Automation.Runspaces.SessionStateFunctionEntry
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 1109, 1121);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1347_1136_1150(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 1136, 1150);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1347_1166_1183(System.Management.Automation.Runspaces.SessionStateFunctionEntry
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 1166, 1183);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1347_1166_1196(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 1166, 1196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 737, 1239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 737, 1239);
            }
        }

        internal IDictionary GetFunctionTable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 1619, 2352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 1683, 1793);

                SessionStateScopeEnumerator
                scopeEnumerator =
                f_1347_1746_1792(_currentScope)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 1809, 1939);

                Dictionary<string, FunctionInfo>
                result =
                f_1347_1868_1938(f_1347_1905_1937())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 1955, 2311);
                    foreach (SessionStateScope scope in f_1347_1991_2006_I(scopeEnumerator))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 1955, 2311);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 2040, 2296);
                            foreach (FunctionInfo entry in f_1347_2071_2097_I(f_1347_2071_2097(f_1347_2071_2090(scope))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 2040, 2296);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 2139, 2277) || true) && (!f_1347_2144_2174(result, f_1347_2163_2173(entry)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 2139, 2277);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 2224, 2254);

                                    f_1347_2224_2253(result, f_1347_2235_2245(entry), entry);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 2139, 2277);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 2040, 2296);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1347, 1, 257);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1347, 1, 257);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 1955, 2311);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1347, 1, 357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1347, 1, 357);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 2327, 2341);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 1619, 2352);

                System.Management.Automation.SessionStateScopeEnumerator
                f_1347_1746_1792(System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = new System.Management.Automation.SessionStateScopeEnumerator(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 1746, 1792);
                    return return_v;
                }


                System.StringComparer
                f_1347_1905_1937()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 1905, 1937);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                f_1347_1868_1938(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 1868, 1938);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                f_1347_2071_2090(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.FunctionTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 2071, 2090);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>.ValueCollection
                f_1347_2071_2097(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 2071, 2097);
                    return return_v;
                }


                string
                f_1347_2163_2173(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 2163, 2173);
                    return return_v;
                }


                bool
                f_1347_2144_2174(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 2144, 2174);
                    return return_v;
                }


                string
                f_1347_2235_2245(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 2235, 2245);
                    return return_v;
                }


                int
                f_1347_2224_2253(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                this_param, string
                key, System.Management.Automation.FunctionInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 2224, 2253);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>.ValueCollection
                f_1347_2071_2097_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 2071, 2097);
                    return return_v;
                }


                System.Management.Automation.SessionStateScopeEnumerator
                f_1347_1991_2006_I(System.Management.Automation.SessionStateScopeEnumerator
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 1991, 2006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 1619, 2352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 1619, 2352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IDictionary<string, FunctionInfo> GetFunctionTableAtScope(string scopeID)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 3182, 4005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 3289, 3419);

                Dictionary<string, FunctionInfo>
                result =
                f_1347_3348_3418(f_1347_3385_3417())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 3435, 3483);

                SessionStateScope
                scope = f_1347_3461_3482(this, scopeID)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 3499, 3964);
                    foreach (FunctionInfo entry in f_1347_3530_3556_I(f_1347_3530_3556(f_1347_3530_3549(scope))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 3499, 3964);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 3759, 3949) || true) && ((f_1347_3764_3777(entry) & ScopedItemOptions.Private) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(1347, 3763, 3858) || scope == _currentScope))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 3759, 3949);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 3900, 3930);

                            f_1347_3900_3929(result, f_1347_3911_3921(entry), entry);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 3759, 3949);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 3499, 3964);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1347, 1, 466);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1347, 1, 466);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 3980, 3994);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 3182, 4005);

                System.StringComparer
                f_1347_3385_3417()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 3385, 3417);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                f_1347_3348_3418(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 3348, 3418);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1347_3461_3482(System.Management.Automation.SessionStateInternal
                this_param, string
                scopeID)
                {
                    var return_v = this_param.GetScopeByID(scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 3461, 3482);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                f_1347_3530_3549(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.FunctionTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 3530, 3549);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>.ValueCollection
                f_1347_3530_3556(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 3530, 3556);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1347_3764_3777(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 3764, 3777);
                    return return_v;
                }


                string
                f_1347_3911_3921(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 3911, 3921);
                    return return_v;
                }


                int
                f_1347_3900_3929(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                this_param, string
                key, System.Management.Automation.FunctionInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 3900, 3929);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>.ValueCollection
                f_1347_3530_3556_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 3530, 3556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 3182, 4005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 3182, 4005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<FunctionInfo> ExportedFunctions { get; }

        internal bool UseExportList { get; set; }

        internal bool FunctionsExported { get; set; }

        internal bool FunctionsExportedWithWildcard
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 4737, 4783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 4743, 4781);

                    return _functionsExportedWithWildcard;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 4737, 4783);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 4669, 5076);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 4669, 5076);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 4799, 5065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 4835, 4915);

                    f_1347_4835_4914((value == true), "This property should never be set/reset to false");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 4933, 5050) || true) && (value == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 4933, 5050);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 4992, 5031);

                        _functionsExportedWithWildcard = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 4933, 5050);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 4799, 5065);

                    int
                    f_1347_4835_4914(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 4835, 4914);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 4669, 5076);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 4669, 5076);
                }
            }
        }

        private bool _functionsExportedWithWildcard;

        internal bool ManifestWithExplicitFunctionExport { get; set; }

        internal FunctionInfo GetFunction(string name, CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 5928, 6634);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 6021, 6149) || true) && (f_1347_6025_6051(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 6021, 6149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 6085, 6134);

                    throw f_1347_6091_6133("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 6021, 6149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 6165, 6192);

                FunctionInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 6208, 6269);

                FunctionLookupPath
                lookupPath = f_1347_6240_6268(name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 6285, 6395);

                FunctionScopeItemSearcher
                searcher =
                f_1347_6339_6394(this, lookupPath, origin)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 6411, 6538) || true) && (f_1347_6415_6434(searcher))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 6411, 6538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 6468, 6523);

                    result = f_1347_6477_6522(((IEnumerator<FunctionInfo>)searcher));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 6411, 6538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 6554, 6623);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1347, 6561, 6606) || (((f_1347_6562_6605(this, result, origin)) && DynAbs.Tracing.TraceSender.Conditional_F2(1347, 6609, 6615)) || DynAbs.Tracing.TraceSender.Conditional_F3(1347, 6618, 6622))) ? result : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 5928, 6634);

                bool
                f_1347_6025_6051(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 6025, 6051);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1347_6091_6133(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 6091, 6133);
                    return return_v;
                }


                System.Management.Automation.FunctionLookupPath
                f_1347_6240_6268(string
                path)
                {
                    var return_v = new System.Management.Automation.FunctionLookupPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 6240, 6268);
                    return return_v;
                }


                System.Management.Automation.FunctionScopeItemSearcher
                f_1347_6339_6394(System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.FunctionLookupPath
                lookupPath, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = new System.Management.Automation.FunctionScopeItemSearcher(sessionState, (System.Management.Automation.VariablePath)lookupPath, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 6339, 6394);
                    return return_v;
                }


                bool
                f_1347_6415_6434(System.Management.Automation.FunctionScopeItemSearcher
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 6415, 6434);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1347_6477_6522(System.Collections.Generic.IEnumerator<System.Management.Automation.FunctionInfo>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 6477, 6522);
                    return return_v;
                }


                bool
                f_1347_6562_6605(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.FunctionInfo
                fnInfo, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.IsFunctionVisibleInDebugger(fnInfo, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 6562, 6605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 5928, 6634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 5928, 6634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsFunctionVisibleInDebugger(FunctionInfo fnInfo, CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 6646, 8276);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 7224, 7655) || true) && ((f_1347_7229_7263(f_1347_7229_7250(this)) == PSLanguageMode.FullLanguage) || (DynAbs.Tracing.TraceSender.Expression_False(1347, 7228, 7332) || (fnInfo == null)) || (DynAbs.Tracing.TraceSender.Expression_False(1347, 7228, 7419) || (f_1347_7354_7418(f_1347_7354_7365(fnInfo), "prompt", StringComparison.OrdinalIgnoreCase))) || (DynAbs.Tracing.TraceSender.Expression_False(1347, 7228, 7513) || (f_1347_7441_7512(f_1347_7441_7452(fnInfo), "TabExpansion2", StringComparison.OrdinalIgnoreCase))) || (DynAbs.Tracing.TraceSender.Expression_False(1347, 7228, 7594) || (f_1347_7535_7593(f_1347_7535_7546(fnInfo), "Clear-Host", StringComparison.Ordinal))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 7224, 7655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 7628, 7640);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 7224, 7655);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 7865, 7918);

                var
                runspace = f_1347_7880_7917(f_1347_7880_7901(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 7932, 8237) || true) && ((runspace != null) && (DynAbs.Tracing.TraceSender.Expression_True(1347, 7936, 8045) && (f_1347_7976_7999(runspace) || (DynAbs.Tracing.TraceSender.Expression_False(1347, 7976, 8044) || (f_1347_8004_8035_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1347_8004_8021(runspace), 1347, 8004, 8035)?.InBreakpoint) == true)))) && (DynAbs.Tracing.TraceSender.Expression_True(1347, 7936, 8175) && (f_1347_8067_8103(f_1347_8067_8094(fnInfo)) && (DynAbs.Tracing.TraceSender.Expression_True(1347, 8067, 8174) && (f_1347_8108_8135(fnInfo) != f_1347_8139_8173(f_1347_8139_8160(this)))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 7932, 8237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 8209, 8222);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 7932, 8237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 8253, 8265);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 6646, 8276);

                System.Management.Automation.ExecutionContext
                f_1347_7229_7250(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 7229, 7250);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1347_7229_7263(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 7229, 7263);
                    return return_v;
                }


                string
                f_1347_7354_7365(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 7354, 7365);
                    return return_v;
                }


                bool
                f_1347_7354_7418(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 7354, 7418);
                    return return_v;
                }


                string
                f_1347_7441_7452(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 7441, 7452);
                    return return_v;
                }


                bool
                f_1347_7441_7512(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 7441, 7512);
                    return return_v;
                }


                string
                f_1347_7535_7546(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 7535, 7546);
                    return return_v;
                }


                bool
                f_1347_7535_7593(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 7535, 7593);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1347_7880_7901(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 7880, 7901);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1347_7880_7917(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 7880, 7917);
                    return return_v;
                }


                bool
                f_1347_7976_7999(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.InNestedPrompt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 7976, 7999);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1347_8004_8021(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 8004, 8021);
                    return return_v;
                }


                bool?
                f_1347_8004_8035_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 8004, 8035);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1347_8067_8094(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.DefiningLanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 8067, 8094);
                    return return_v;
                }


                bool
                f_1347_8067_8103(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 8067, 8103);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1347_8108_8135(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.DefiningLanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 8108, 8135);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1347_8139_8160(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 8139, 8160);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1347_8139_8173(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 8139, 8173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 6646, 8276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 6646, 8276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FunctionInfo GetFunction(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 8713, 8844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 8784, 8833);

                return f_1347_8791_8832(this, name, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 8713, 8844);

                System.Management.Automation.FunctionInfo
                f_1347_8791_8832(System.Management.Automation.SessionStateInternal
                this_param, string
                name, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.GetFunction(name, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 8791, 8832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 8713, 8844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 8713, 8844);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<string> GetFunctionAliases(IParameterMetadataProvider ipmp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 8856, 9803);

                var listYield = new List<String>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 8960, 9039) || true) && (ipmp == null || (DynAbs.Tracing.TraceSender.Expression_False(1347, 8964, 9008) || f_1347_8980_9000(f_1347_8980_8989(ipmp)) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 8960, 9039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 9027, 9039);

                    return listYield;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 8960, 9039);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 9055, 9104);

                var
                attributes = f_1347_9072_9103(f_1347_9072_9092(f_1347_9072_9081(ipmp)))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 9118, 9792);
                    foreach (var attributeAst in f_1347_9147_9157_I(attributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 9118, 9792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 9191, 9262);

                        var
                        attributeType = f_1347_9211_9261(f_1347_9211_9232(attributeAst))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 9280, 9777) || true) && (attributeType == typeof(AliasAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 9280, 9777);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 9365, 9429);

                            var
                            cvv = new ConstantValueVisitor { AttributeArgument = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1347, 9375, 9428) }
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 9460, 9465);
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 9451, 9758) || true) && (i < f_1347_9471_9509(f_1347_9471_9503(attributeAst)))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 9511, 9514)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 9451, 9758))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 9451, 9758);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 9564, 9735);

                                    listYield.Add(f_1347_9577_9734(Compiler.s_attrArgToStringConverter, Compiler.s_attrArgToStringConverter, f_1347_9686_9733(f_1347_9686_9721(f_1347_9686_9718(attributeAst), i), cvv)));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1347, 1, 308);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1347, 1, 308);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 9280, 9777);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 9118, 9792);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1347, 1, 675);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1347, 1, 675);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 8856, 9803);

                return listYield;

                System.Management.Automation.Language.ScriptBlockAst
                f_1347_8980_8989(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 8980, 8989);
                    return return_v;
                }


                System.Management.Automation.Language.ParamBlockAst
                f_1347_8980_9000(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 8980, 9000);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1347_9072_9081(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 9072, 9081);
                    return return_v;
                }


                System.Management.Automation.Language.ParamBlockAst
                f_1347_9072_9092(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 9072, 9092);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                f_1347_9072_9103(System.Management.Automation.Language.ParamBlockAst
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 9072, 9103);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1347_9211_9232(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 9211, 9232);
                    return return_v;
                }


                System.Type
                f_1347_9211_9261(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.GetReflectionAttributeType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 9211, 9261);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1347_9471_9503(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.PositionalArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 9471, 9503);
                    return return_v;
                }


                int
                f_1347_9471_9509(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 9471, 9509);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1347_9686_9718(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.PositionalArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 9686, 9718);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1347_9686_9721(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 9686, 9721);
                    return return_v;
                }


                object
                f_1347_9686_9733(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.ConstantValueVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 9686, 9733);
                    return return_v;
                }


                string
                f_1347_9577_9734(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, string>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, string>>
                arg1, object
                arg2)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 9577, 9734);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                f_1347_9147_9157_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 9147, 9157);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 8856, 9803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 8856, 9803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FunctionInfo SetFunctionRaw(
                    string name,
                    ScriptBlock function,
                    CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 10666, 12530);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 10824, 10952) || true) && (f_1347_10828_10854(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 10824, 10952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 10888, 10937);

                    throw f_1347_10894_10936("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 10824, 10952);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 10968, 11094) || true) && (function == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 10968, 11094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 11022, 11079);

                    throw f_1347_11028_11078("function");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 10968, 11094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 11110, 11137);

                string
                originalName = name
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 11153, 11208);

                FunctionLookupPath
                path = f_1347_11179_11207(name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 11222, 11250);

                name = f_1347_11229_11249(path);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 11266, 11742) || true) && (f_1347_11270_11296(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 11266, 11742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 11330, 11691);

                    SessionStateException
                    exception =
                    f_1347_11385_11690(originalName, SessionStateCategory.Function, "ScopedFunctionMustHaveName", f_1347_11587_11633(), ErrorCategory.InvalidArgument)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 11711, 11727);

                    throw exception;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 11266, 11742);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 11758, 11809);

                ScopedItemOptions
                options = ScopedItemOptions.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 11823, 11927) || true) && (f_1347_11827_11841(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 11823, 11927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 11875, 11912);

                    options |= ScopedItemOptions.Private;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 11823, 11927);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 11943, 12111);

                FunctionScopeItemSearcher
                searcher =
                f_1347_11997_12110(this, path, origin)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 12127, 12244);

                var
                functionInfo = f_1347_12146_12243(f_1347_12146_12167(searcher), name, function, null, options, false, origin, f_1347_12226_12242())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 12260, 12483);
                    foreach (var aliasName in f_1347_12286_12348_I(f_1347_12286_12348(this, f_1347_12305_12317(function))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 12260, 12483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 12382, 12468);

                        f_1347_12382_12467(f_1347_12382_12403(searcher), aliasName, name, f_1347_12435_12451(), false, origin);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 12260, 12483);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1347, 1, 224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1347, 1, 224);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 12499, 12519);

                return functionInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 10666, 12530);

                bool
                f_1347_10828_10854(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 10828, 10854);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1347_10894_10936(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 10894, 10936);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1347_11028_11078(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 11028, 11078);
                    return return_v;
                }


                System.Management.Automation.FunctionLookupPath
                f_1347_11179_11207(string
                path)
                {
                    var return_v = new System.Management.Automation.FunctionLookupPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 11179, 11207);
                    return return_v;
                }


                string
                f_1347_11229_11249(System.Management.Automation.FunctionLookupPath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 11229, 11249);
                    return return_v;
                }


                bool
                f_1347_11270_11296(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 11270, 11296);
                    return return_v;
                }


                string
                f_1347_11587_11633()
                {
                    var return_v = SessionStateStrings.ScopedFunctionMustHaveName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 11587, 11633);
                    return return_v;
                }


                System.Management.Automation.SessionStateException
                f_1347_11385_11690(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, System.Management.Automation.ErrorCategory
                errorCategory, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.SessionStateException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, errorCategory, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 11385, 11690);
                    return return_v;
                }


                bool
                f_1347_11827_11841(System.Management.Automation.FunctionLookupPath
                this_param)
                {
                    var return_v = this_param.IsPrivate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 11827, 11841);
                    return return_v;
                }


                System.Management.Automation.FunctionScopeItemSearcher
                f_1347_11997_12110(System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.FunctionLookupPath
                lookupPath, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = new System.Management.Automation.FunctionScopeItemSearcher(sessionState, (System.Management.Automation.VariablePath)lookupPath, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 11997, 12110);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1347_12146_12167(System.Management.Automation.FunctionScopeItemSearcher
                this_param)
                {
                    var return_v = this_param.InitialScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 12146, 12167);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1347_12226_12242()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 12226, 12242);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1347_12146_12243(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.FunctionInfo
                originalFunction, System.Management.Automation.ScopedItemOptions
                options, bool
                force, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = this_param.SetFunction(name, function, originalFunction, options, force, origin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 12146, 12243);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1347_12305_12317(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 12305, 12317);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1347_12286_12348(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Language.Ast
                ipmp)
                {
                    var return_v = this_param.GetFunctionAliases((System.Management.Automation.Language.IParameterMetadataProvider)ipmp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 12286, 12348);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1347_12382_12403(System.Management.Automation.FunctionScopeItemSearcher
                this_param)
                {
                    var return_v = this_param.InitialScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 12382, 12403);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1347_12435_12451()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 12435, 12451);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1347_12382_12467(System.Management.Automation.SessionStateScope
                this_param, string
                name, string
                value, System.Management.Automation.ExecutionContext
                context, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetAliasValue(name, value, context, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 12382, 12467);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1347_12286_12348_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 12286, 12348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 10666, 12530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 10666, 12530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FunctionInfo SetFunction(
                    string name,
                    ScriptBlock function,
                    FunctionInfo originalFunction,
                    ScopedItemOptions options,
                    bool force,
                    CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 13775, 14151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 14039, 14140);

                return f_1347_14046_14139(this, name, function, originalFunction, options, force, origin, f_1347_14116_14132(), null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 13775, 14151);

                System.Management.Automation.ExecutionContext
                f_1347_14116_14132()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 14116, 14132);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1347_14046_14139(System.Management.Automation.SessionStateInternal
                this_param, string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.FunctionInfo
                originalFunction, System.Management.Automation.ScopedItemOptions
                options, bool
                force, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.ExecutionContext
                context, string
                helpFile)
                {
                    var return_v = this_param.SetFunction(name, function, originalFunction, options, force, origin, context, helpFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 14046, 14139);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 13775, 14151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 13775, 14151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FunctionInfo SetFunction(
                    string name,
                    ScriptBlock function,
                    FunctionInfo originalFunction,
                    ScopedItemOptions options,
                    bool force,
                    CommandOrigin origin,
                    string helpFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 15524, 15941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 15818, 15930);

                return f_1347_15825_15929(this, name, function, originalFunction, options, force, origin, f_1347_15895_15911(), helpFile, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 15524, 15941);

                System.Management.Automation.ExecutionContext
                f_1347_15895_15911()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 15895, 15911);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1347_15825_15929(System.Management.Automation.SessionStateInternal
                this_param, string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.FunctionInfo
                originalFunction, System.Management.Automation.ScopedItemOptions
                options, bool
                force, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.ExecutionContext
                context, string
                helpFile, bool
                isPreValidated)
                {
                    var return_v = this_param.SetFunction(name, function, originalFunction, options, force, origin, context, helpFile, isPreValidated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 15825, 15929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 15524, 15941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 15524, 15941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FunctionInfo SetFunction(
                    string name,
                    ScriptBlock function,
                    FunctionInfo originalFunction,
                    ScopedItemOptions options,
                    bool force,
                    CommandOrigin origin,
                    ExecutionContext context,
                    string helpFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 17425, 17872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 17758, 17861);

                return f_1347_17765_17860(this, name, function, originalFunction, options, force, origin, context, helpFile, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 17425, 17872);

                System.Management.Automation.FunctionInfo
                f_1347_17765_17860(System.Management.Automation.SessionStateInternal
                this_param, string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.FunctionInfo
                originalFunction, System.Management.Automation.ScopedItemOptions
                options, bool
                force, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.ExecutionContext
                context, string
                helpFile, bool
                isPreValidated)
                {
                    var return_v = this_param.SetFunction(name, function, originalFunction, options, force, origin, context, helpFile, isPreValidated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 17765, 17860);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 17425, 17872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 17425, 17872);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FunctionInfo SetFunction(
                    string name,
                    ScriptBlock function,
                    FunctionInfo originalFunction,
                    ScopedItemOptions options,
                    bool force,
                    CommandOrigin origin,
                    ExecutionContext context,
                    string helpFile,
                    bool isPreValidated)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 19576, 21310);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 19943, 20071) || true) && (f_1347_19947_19973(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 19943, 20071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 20007, 20056);

                    throw f_1347_20013_20055("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 19943, 20071);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 20087, 20213) || true) && (function == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 20087, 20213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 20141, 20198);

                    throw f_1347_20147_20197("function");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 20087, 20213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 20229, 20256);

                string
                originalName = name
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 20272, 20327);

                FunctionLookupPath
                path = f_1347_20298_20326(name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 20341, 20369);

                name = f_1347_20348_20368(path);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 20385, 20861) || true) && (f_1347_20389_20415(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 20385, 20861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 20449, 20810);

                    SessionStateException
                    exception =
                    f_1347_20504_20809(originalName, SessionStateCategory.Function, "ScopedFunctionMustHaveName", f_1347_20706_20752(), ErrorCategory.InvalidArgument)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 20830, 20846);

                    throw exception;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 20385, 20861);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 20877, 20981) || true) && (f_1347_20881_20895(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 20877, 20981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 20929, 20966);

                    options |= ScopedItemOptions.Private;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 20877, 20981);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 20997, 21165);

                FunctionScopeItemSearcher
                searcher =
                f_1347_21051_21164(this, path, origin)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 21181, 21299);

                return f_1347_21188_21298(f_1347_21188_21209(searcher), name, function, originalFunction, options, force, origin, context, helpFile);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 19576, 21310);

                bool
                f_1347_19947_19973(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 19947, 19973);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1347_20013_20055(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 20013, 20055);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1347_20147_20197(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 20147, 20197);
                    return return_v;
                }


                System.Management.Automation.FunctionLookupPath
                f_1347_20298_20326(string
                path)
                {
                    var return_v = new System.Management.Automation.FunctionLookupPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 20298, 20326);
                    return return_v;
                }


                string
                f_1347_20348_20368(System.Management.Automation.FunctionLookupPath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 20348, 20368);
                    return return_v;
                }


                bool
                f_1347_20389_20415(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 20389, 20415);
                    return return_v;
                }


                string
                f_1347_20706_20752()
                {
                    var return_v = SessionStateStrings.ScopedFunctionMustHaveName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 20706, 20752);
                    return return_v;
                }


                System.Management.Automation.SessionStateException
                f_1347_20504_20809(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, System.Management.Automation.ErrorCategory
                errorCategory, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.SessionStateException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, errorCategory, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 20504, 20809);
                    return return_v;
                }


                bool
                f_1347_20881_20895(System.Management.Automation.FunctionLookupPath
                this_param)
                {
                    var return_v = this_param.IsPrivate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 20881, 20895);
                    return return_v;
                }


                System.Management.Automation.FunctionScopeItemSearcher
                f_1347_21051_21164(System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.FunctionLookupPath
                lookupPath, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = new System.Management.Automation.FunctionScopeItemSearcher(sessionState, (System.Management.Automation.VariablePath)lookupPath, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 21051, 21164);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1347_21188_21209(System.Management.Automation.FunctionScopeItemSearcher
                this_param)
                {
                    var return_v = this_param.InitialScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 21188, 21209);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1347_21188_21298(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.FunctionInfo
                originalFunction, System.Management.Automation.ScopedItemOptions
                options, bool
                force, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.ExecutionContext
                context, string
                helpFile)
                {
                    var return_v = this_param.SetFunction(name, function, originalFunction, options, force, origin, context, helpFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 21188, 21298);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 19576, 21310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 19576, 21310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FunctionInfo SetFunction(
                    string name,
                    ScriptBlock function,
                    FunctionInfo originalFunction,
                    bool force,
                    CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 22609, 25386);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 22833, 22961) || true) && (f_1347_22837_22863(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 22833, 22961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 22897, 22946);

                    throw f_1347_22903_22945("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 22833, 22961);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 22977, 23103) || true) && (function == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 22977, 23103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 23031, 23088);

                    throw f_1347_23037_23087("function");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 22977, 23103);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 23119, 23146);

                string
                originalName = name
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 23162, 23217);

                FunctionLookupPath
                path = f_1347_23188_23216(name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 23231, 23259);

                name = f_1347_23238_23258(path);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 23275, 23751) || true) && (f_1347_23279_23305(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 23275, 23751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 23339, 23700);

                    SessionStateException
                    exception =
                    f_1347_23394_23699(originalName, SessionStateCategory.Function, "ScopedFunctionMustHaveName", f_1347_23596_23642(), ErrorCategory.InvalidArgument)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 23720, 23736);

                    throw exception;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 23275, 23751);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 23767, 23818);

                ScopedItemOptions
                options = ScopedItemOptions.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 23832, 23936) || true) && (f_1347_23836_23850(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 23832, 23936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 23884, 23921);

                    options |= ScopedItemOptions.Private;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 23832, 23936);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 23952, 24120);

                FunctionScopeItemSearcher
                searcher =
                f_1347_24006_24119(this, path, origin)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 24136, 24163);

                FunctionInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 24179, 24227);

                SessionStateScope
                scope = f_1347_24205_24226(searcher)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 24243, 25345) || true) && (f_1347_24247_24266(searcher))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 24243, 25345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 24300, 24336);

                    scope = f_1347_24308_24335(searcher);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 24354, 24375);

                    name = f_1347_24361_24374(searcher);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 24395, 24924) || true) && (f_1347_24399_24413(path))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 24395, 24924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 24508, 24564);

                        FunctionInfo
                        existingFunction = f_1347_24540_24563(scope, name)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 24586, 24622);

                        options |= f_1347_24597_24621(existingFunction);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 24644, 24747);

                        result = f_1347_24653_24746(scope, name, function, originalFunction, options, force, origin, f_1347_24729_24745());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 24395, 24924);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 24395, 24924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 24829, 24905);

                        result = f_1347_24838_24904(scope, name, function, force, origin, f_1347_24887_24903());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 24395, 24924);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 24243, 25345);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 24243, 25345);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 24990, 25330) || true) && (f_1347_24994_25008(path))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 24990, 25330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 25050, 25153);

                        result = f_1347_25059_25152(scope, name, function, originalFunction, options, force, origin, f_1347_25135_25151());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 24990, 25330);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 24990, 25330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 25235, 25311);

                        result = f_1347_25244_25310(scope, name, function, force, origin, f_1347_25293_25309());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 24990, 25330);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 24243, 25345);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 25361, 25375);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 22609, 25386);

                bool
                f_1347_22837_22863(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 22837, 22863);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1347_22903_22945(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 22903, 22945);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1347_23037_23087(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 23037, 23087);
                    return return_v;
                }


                System.Management.Automation.FunctionLookupPath
                f_1347_23188_23216(string
                path)
                {
                    var return_v = new System.Management.Automation.FunctionLookupPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 23188, 23216);
                    return return_v;
                }


                string
                f_1347_23238_23258(System.Management.Automation.FunctionLookupPath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 23238, 23258);
                    return return_v;
                }


                bool
                f_1347_23279_23305(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 23279, 23305);
                    return return_v;
                }


                string
                f_1347_23596_23642()
                {
                    var return_v = SessionStateStrings.ScopedFunctionMustHaveName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 23596, 23642);
                    return return_v;
                }


                System.Management.Automation.SessionStateException
                f_1347_23394_23699(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, System.Management.Automation.ErrorCategory
                errorCategory, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.SessionStateException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, errorCategory, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 23394, 23699);
                    return return_v;
                }


                bool
                f_1347_23836_23850(System.Management.Automation.FunctionLookupPath
                this_param)
                {
                    var return_v = this_param.IsPrivate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 23836, 23850);
                    return return_v;
                }


                System.Management.Automation.FunctionScopeItemSearcher
                f_1347_24006_24119(System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.FunctionLookupPath
                lookupPath, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = new System.Management.Automation.FunctionScopeItemSearcher(sessionState, (System.Management.Automation.VariablePath)lookupPath, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 24006, 24119);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1347_24205_24226(System.Management.Automation.FunctionScopeItemSearcher
                this_param)
                {
                    var return_v = this_param.InitialScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 24205, 24226);
                    return return_v;
                }


                bool
                f_1347_24247_24266(System.Management.Automation.FunctionScopeItemSearcher
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 24247, 24266);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1347_24308_24335(System.Management.Automation.FunctionScopeItemSearcher
                this_param)
                {
                    var return_v = this_param.CurrentLookupScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 24308, 24335);
                    return return_v;
                }


                string
                f_1347_24361_24374(System.Management.Automation.FunctionScopeItemSearcher
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 24361, 24374);
                    return return_v;
                }


                bool
                f_1347_24399_24413(System.Management.Automation.FunctionLookupPath
                this_param)
                {
                    var return_v = this_param.IsPrivate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 24399, 24413);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1347_24540_24563(System.Management.Automation.SessionStateScope
                this_param, string
                name)
                {
                    var return_v = this_param.GetFunction(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 24540, 24563);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1347_24597_24621(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 24597, 24621);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1347_24729_24745()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 24729, 24745);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1347_24653_24746(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.FunctionInfo
                originalFunction, System.Management.Automation.ScopedItemOptions
                options, bool
                force, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = this_param.SetFunction(name, function, originalFunction, options, force, origin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 24653, 24746);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1347_24887_24903()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 24887, 24903);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1347_24838_24904(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.ScriptBlock
                function, bool
                force, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = this_param.SetFunction(name, function, force, origin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 24838, 24904);
                    return return_v;
                }


                bool
                f_1347_24994_25008(System.Management.Automation.FunctionLookupPath
                this_param)
                {
                    var return_v = this_param.IsPrivate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 24994, 25008);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1347_25135_25151()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 25135, 25151);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1347_25059_25152(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.FunctionInfo
                originalFunction, System.Management.Automation.ScopedItemOptions
                options, bool
                force, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = this_param.SetFunction(name, function, originalFunction, options, force, origin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 25059, 25152);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1347_25293_25309()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 25293, 25309);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1347_25244_25310(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.ScriptBlock
                function, bool
                force, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = this_param.SetFunction(name, function, force, origin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 25244, 25310);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 22609, 25386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 22609, 25386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FunctionInfo SetFunction(string name, ScriptBlock function, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 26623, 26811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 26728, 26800);

                return f_1347_26735_26799(this, name, function, null, force, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 26623, 26811);

                System.Management.Automation.FunctionInfo
                f_1347_26735_26799(System.Management.Automation.SessionStateInternal
                this_param, string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.FunctionInfo
                originalFunction, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetFunction(name, function, originalFunction, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 26735, 26799);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 26623, 26811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 26623, 26811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void RemoveFunction(string name, bool force, CommandOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 27538, 28334);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 27638, 27766) || true) && (f_1347_27642_27668(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 27638, 27766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 27702, 27751);

                    throw f_1347_27708_27750("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 27638, 27766);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 27854, 27894);

                SessionStateScope
                scope = _currentScope
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 27910, 27965);

                FunctionLookupPath
                path = f_1347_27936_27964(name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 27981, 28149);

                FunctionScopeItemSearcher
                searcher =
                f_1347_28035_28148(this, path, origin)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 28165, 28273) || true) && (f_1347_28169_28188(searcher))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 28165, 28273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 28222, 28258);

                    scope = f_1347_28230_28257(searcher);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 28165, 28273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 28289, 28323);

                f_1347_28289_28322(
                            scope, name, force);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 27538, 28334);

                bool
                f_1347_27642_27668(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 27642, 27668);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1347_27708_27750(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 27708, 27750);
                    return return_v;
                }


                System.Management.Automation.FunctionLookupPath
                f_1347_27936_27964(string
                path)
                {
                    var return_v = new System.Management.Automation.FunctionLookupPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 27936, 27964);
                    return return_v;
                }


                System.Management.Automation.FunctionScopeItemSearcher
                f_1347_28035_28148(System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.FunctionLookupPath
                lookupPath, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = new System.Management.Automation.FunctionScopeItemSearcher(sessionState, (System.Management.Automation.VariablePath)lookupPath, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 28035, 28148);
                    return return_v;
                }


                bool
                f_1347_28169_28188(System.Management.Automation.FunctionScopeItemSearcher
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 28169, 28188);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1347_28230_28257(System.Management.Automation.FunctionScopeItemSearcher
                this_param)
                {
                    var return_v = this_param.CurrentLookupScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 28230, 28257);
                    return return_v;
                }


                int
                f_1347_28289_28322(System.Management.Automation.SessionStateScope
                this_param, string
                name, bool
                force)
                {
                    this_param.RemoveFunction(name, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 28289, 28322);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 27538, 28334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 27538, 28334);
            }
        }

        internal void RemoveFunction(string name, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 28954, 29095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 29032, 29084);

                f_1347_29032_29083(this, name, force, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 28954, 29095);

                int
                f_1347_29032_29083(System.Management.Automation.SessionStateInternal
                this_param, string
                name, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    this_param.RemoveFunction(name, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 29032, 29083);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 28954, 29095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 28954, 29095);
            }
        }

        internal void RemoveFunction(string name, PSModuleInfo module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1347, 29723, 30258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 29810, 29895);

                f_1347_29810_29894(module != null, "Caller should verify that module parameter is not null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 29911, 29965);

                FunctionInfo
                func = f_1347_29931_29948(this, name) as FunctionInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 29979, 30247) || true) && (func != null && (DynAbs.Tracing.TraceSender.Expression_True(1347, 29983, 30023) && f_1347_29999_30015(func) != null
                ) && (DynAbs.Tracing.TraceSender.Expression_True(1347, 29983, 30073) && f_1347_30044_30065(f_1347_30044_30060(func)) != null
                ) && (DynAbs.Tracing.TraceSender.Expression_True(1347, 29983, 30171) && f_1347_30094_30171(f_1347_30094_30115(f_1347_30094_30110(func)), f_1347_30123_30134(module), StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1347, 29979, 30247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 30205, 30232);

                    f_1347_30205_30231(this, name, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1347, 29979, 30247);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1347, 29723, 30258);

                int
                f_1347_29810_29894(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 29810, 29894);
                    return 0;
                }


                System.Management.Automation.FunctionInfo
                f_1347_29931_29948(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetFunction(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 29931, 29948);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1347_29999_30015(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 29999, 30015);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1347_30044_30060(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 30044, 30060);
                    return return_v;
                }


                string
                f_1347_30044_30065(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 30044, 30065);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1347_30094_30110(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 30094, 30110);
                    return return_v;
                }


                string
                f_1347_30094_30115(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 30094, 30115);
                    return return_v;
                }


                string
                f_1347_30123_30134(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1347, 30123, 30134);
                    return return_v;
                }


                bool
                f_1347_30094_30171(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 30094, 30171);
                    return return_v;
                }


                int
                f_1347_30205_30231(System.Management.Automation.SessionStateInternal
                this_param, string
                name, bool
                force)
                {
                    this_param.RemoveFunction(name, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 30205, 30231);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1347, 29723, 30258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1347, 29723, 30258);
            }
        }
    }
}
