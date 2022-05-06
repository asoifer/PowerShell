// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Provider;
using System.Text;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    internal sealed class LocationGlobber
    {
        [Dbg.TraceSourceAttribute(
                     "LocationGlobber",
                     "The location globber converts PowerShell paths with glob characters to zero or more paths.")]
        private static Dbg.PSTraceSource s_tracer;

        [Dbg.TraceSourceAttribute(
                     "PathResolution",
                     "Traces the path resolution algorithm.")]
        private static Dbg.PSTraceSource s_pathResolutionTracer;

        internal LocationGlobber(SessionState sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1203, 2084, 2356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 66254, 66267);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 2160, 2300) || true) && (sessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 2160, 2300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 2218, 2285);

                    throw f_1203_2224_2284(nameof(sessionState));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 2160, 2300);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 2316, 2345);

                _sessionState = sessionState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1203, 2084, 2356);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 2084, 2356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 2084, 2356);
            }
        }

        internal Collection<PathInfo> GetGlobbedMonadPathsFromMonadPath(
                    string path,
                    bool allowNonexistingPaths,
                    out CmdletProvider providerInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 4320, 4770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 4526, 4642);

                CmdletProviderContext
                context =
                f_1203_4575_4641(f_1203_4601_4640(f_1203_4601_4623(_sessionState)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 4658, 4759);

                return f_1203_4665_4758(this, path, allowNonexistingPaths, context, out providerInstance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 4320, 4770);

                System.Management.Automation.SessionStateInternal
                f_1203_4601_4623(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 4601, 4623);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1203_4601_4640(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 4601, 4640);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1203_4575_4641(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 4575, 4641);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1203_4665_4758(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedMonadPathsFromMonadPath(path, allowNonexistingPaths, context, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 4665, 4758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 4320, 4770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 4320, 4770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<PathInfo> GetGlobbedMonadPathsFromMonadPath(
                    string path,
                    bool allowNonexistingPaths,
                    CmdletProviderContext context,
                    out CmdletProvider providerInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 6935, 10029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 7185, 7209);

                providerInstance = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 7223, 7347) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 7223, 7347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 7273, 7332);

                    throw f_1203_7279_7331(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 7223, 7347);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 7363, 7493) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 7363, 7493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 7416, 7478);

                    throw f_1203_7422_7477(nameof(context));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 7363, 7493);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 7509, 7537);

                Collection<PathInfo>
                result
                = default(Collection<PathInfo>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 7553, 9988);
                using (f_1203_7560_7641(s_pathResolutionTracer, "Resolving MSH path \"{0}\" to MSH path", path))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 7675, 7697);

                    f_1203_7675_7696(context);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 7793, 8053) || true) && (f_1203_7797_7813(path))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 7793, 8053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 7855, 8034);
                        using (f_1203_7862_7928(s_pathResolutionTracer, "Resolving HOME relative path."))
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 7978, 8011);

                            path = f_1203_7985_8010(this, path);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 7855, 8034);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 7793, 8053);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 8131, 8186);

                    bool
                    isProviderDirectPath = f_1203_8159_8185(path)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 8204, 8265);

                    bool
                    isProviderQualifiedPath = f_1203_8235_8264(path)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 8283, 9060) || true) && (isProviderDirectPath || (DynAbs.Tracing.TraceSender.Expression_False(1203, 8287, 8334) || isProviderQualifiedPath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 8283, 9060);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 8376, 8722);

                        result =
                        f_1203_8410_8721(this, path, context, allowNonexistingPaths, isProviderDirectPath, isProviderQualifiedPath, out providerInstance);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 8283, 9060);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 8283, 9060);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 8804, 9041);

                        result =
                        f_1203_8838_9040(this, path, context, allowNonexistingPaths, out providerInstance);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 8283, 9060);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 9080, 9973) || true) && (!allowNonexistingPaths && (DynAbs.Tracing.TraceSender.Expression_True(1203, 9084, 9147) && f_1203_9131_9143(result) < 1) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 9084, 9260) && (!f_1203_9174_9222(path) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 9173, 9259) || f_1203_9226_9259(context)))) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 9084, 9340) && (f_1203_9286_9301(context) == null || (DynAbs.Tracing.TraceSender.Expression_False(1203, 9286, 9339) || f_1203_9313_9334(f_1203_9313_9328(context)) == 0))) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 9084, 9420) && (f_1203_9366_9381(context) == null || (DynAbs.Tracing.TraceSender.Expression_False(1203, 9366, 9419) || f_1203_9393_9414(f_1203_9393_9408(context)) == 0))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 9080, 9973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 9587, 9819);

                        ItemNotFoundException
                        pathNotFound =
                        f_1203_9649_9818(path, "PathNotFound", f_1203_9785_9817())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 9843, 9911);

                        f_1203_9843_9910(
                                            s_pathResolutionTracer, "Item does not exist: {0}", path);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 9935, 9954);

                        throw pathNotFound;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 9080, 9973);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 7553, 9988);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 10004, 10018);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 6935, 10029);

                System.Management.Automation.PSArgumentNullException
                f_1203_7279_7331(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 7279, 7331);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_7422_7477(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 7422, 7477);
                    return return_v;
                }


                System.IDisposable
                f_1203_7560_7641(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 7560, 7641);
                    return return_v;
                }


                int
                f_1203_7675_7696(System.Management.Automation.CmdletProviderContext
                context)
                {
                    TraceFilters(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 7675, 7696);
                    return 0;
                }


                bool
                f_1203_7797_7813(string
                path)
                {
                    var return_v = IsHomePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 7797, 7813);
                    return return_v;
                }


                System.IDisposable
                f_1203_7862_7928(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 7862, 7928);
                    return return_v;
                }


                string
                f_1203_7985_8010(System.Management.Automation.LocationGlobber
                this_param, string
                path)
                {
                    var return_v = this_param.GetHomeRelativePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 7985, 8010);
                    return return_v;
                }


                bool
                f_1203_8159_8185(string
                path)
                {
                    var return_v = IsProviderDirectPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 8159, 8185);
                    return return_v;
                }


                bool
                f_1203_8235_8264(string
                path)
                {
                    var return_v = IsProviderQualifiedPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 8235, 8264);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1203_8410_8721(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, bool
                allowNonexistingPaths, bool
                isProviderDirectPath, bool
                isProviderQualifiedPath, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.ResolvePSPathFromProviderPath(path, context, allowNonexistingPaths, isProviderDirectPath, isProviderQualifiedPath, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 8410, 8721);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1203_8838_9040(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, bool
                allowNonexistingPaths, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.ResolveDriveQualifiedPath(path, context, allowNonexistingPaths, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 8838, 9040);
                    return return_v;
                }


                int
                f_1203_9131_9143(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 9131, 9143);
                    return return_v;
                }


                bool
                f_1203_9174_9222(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 9174, 9222);
                    return return_v;
                }


                bool
                f_1203_9226_9259(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.SuppressWildcardExpansion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 9226, 9259);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_9286_9301(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Include;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 9286, 9301);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_9313_9328(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Include;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 9313, 9328);
                    return return_v;
                }


                int
                f_1203_9313_9334(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 9313, 9334);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_9366_9381(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Exclude;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 9366, 9381);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_9393_9408(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Exclude;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 9393, 9408);
                    return return_v;
                }


                int
                f_1203_9393_9414(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 9393, 9414);
                    return return_v;
                }


                string
                f_1203_9785_9817()
                {
                    var return_v = SessionStateStrings.PathNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 9785, 9817);
                    return return_v;
                }


                System.Management.Automation.ItemNotFoundException
                f_1203_9649_9818(string
                path, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.ItemNotFoundException(path, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 9649, 9818);
                    return return_v;
                }


                int
                f_1203_9843_9910(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 9843, 9910);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 6935, 10029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 6935, 10029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Collection<string> ResolveProviderPathFromProviderPath(
                    string providerPath,
                    string providerId,
                    bool allowNonexistingPaths,
                    CmdletProviderContext context,
                    out CmdletProvider providerInstance
                    )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 10041, 14182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 10408, 10482);

                providerInstance = f_1203_10427_10481(f_1203_10427_10449(_sessionState), providerId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 10496, 10590);

                ContainerCmdletProvider
                containerCmdletProvider = providerInstance as ContainerCmdletProvider
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 10604, 10677);

                ItemCmdletProvider
                itemProvider = providerInstance as ItemCmdletProvider
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 10693, 10752);

                Collection<string>
                stringResult = f_1203_10727_10751()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 10768, 13359) || true) && (f_1203_10772_10806_M(!context.SuppressWildcardExpansion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 10768, 13359);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 10905, 12845) || true) && (f_1203_10909_11089(ProviderCapabilities.ExpandWildcards, f_1203_11059_11088(providerInstance)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 10905, 12845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 11131, 11221);

                        f_1203_11131_11220(s_pathResolutionTracer, "Wildcard matching is being performed by the provider.");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 11366, 11767) || true) && ((itemProvider != null) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 11370, 11479) && (f_1203_11422_11478(providerPath))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 11366, 11767);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 11529, 11615);

                            stringResult = f_1203_11544_11614(f_1203_11567_11613(itemProvider, providerPath, context));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 11366, 11767);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 11366, 11767);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 11713, 11744);

                            f_1203_11713_11743(stringResult, providerPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 11366, 11767);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 10905, 12845);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 10905, 12845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 11849, 11937);

                        f_1203_11849_11936(s_pathResolutionTracer, "Wildcard matching is being performed by the engine.");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 11961, 12826) || true) && (containerCmdletProvider != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 11961, 12826);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 12221, 12509);

                            stringResult =
                            f_1203_12265_12508(this, providerPath, allowNonexistingPaths, containerCmdletProvider, context);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 11961, 12826);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 11961, 12826);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 12772, 12803);

                            f_1203_12772_12802(                        // For simple CmdletProvider instances, we can't resolve the paths any
                                                                       // further, so just return the providerPath
                                                    stringResult, providerPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 11961, 12826);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 10905, 12845);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 10768, 13359);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 10768, 13359);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 12967, 13344) || true) && (itemProvider != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 12967, 13344);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 13033, 13212) || true) && (allowNonexistingPaths || (DynAbs.Tracing.TraceSender.Expression_False(1203, 13037, 13108) || f_1203_13062_13108(itemProvider, providerPath, context)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 13033, 13212);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 13158, 13189);

                            f_1203_13158_13188(stringResult, providerPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 13033, 13212);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 12967, 13344);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 12967, 13344);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 13294, 13325);

                        f_1203_13294_13324(stringResult, providerPath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 12967, 13344);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 10768, 13359);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 13428, 14135) || true) && ((!allowNonexistingPaths) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 13432, 13499) && f_1203_13477_13495(stringResult) < 1) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 13432, 13577) && !f_1203_13521_13577(providerPath)) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 13432, 13653) && (f_1203_13599_13614(context) == null || (DynAbs.Tracing.TraceSender.Expression_False(1203, 13599, 13652) || f_1203_13626_13647(f_1203_13626_13641(context)) == 0))) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 13432, 13729) && (f_1203_13675_13690(context) == null || (DynAbs.Tracing.TraceSender.Expression_False(1203, 13675, 13728) || f_1203_13702_13723(f_1203_13702_13717(context)) == 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 13428, 14135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 13763, 13987);

                    ItemNotFoundException
                    pathNotFound =
                    f_1203_13821_13986(providerPath, "PathNotFound", f_1203_13953_13985())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 14007, 14083);

                    f_1203_14007_14082(
                                    s_pathResolutionTracer, "Item does not exist: {0}", providerPath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 14101, 14120);

                    throw pathNotFound;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 13428, 14135);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 14151, 14171);

                return stringResult;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 10041, 14182);

                System.Management.Automation.SessionStateInternal
                f_1203_10427_10449(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 10427, 10449);
                    return return_v;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1203_10427_10481(System.Management.Automation.SessionStateInternal
                this_param, string
                providerId)
                {
                    var return_v = this_param.GetProviderInstance(providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 10427, 10481);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_10727_10751()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 10727, 10751);
                    return return_v;
                }


                bool
                f_1203_10772_10806_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 10772, 10806);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_11059_11088(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 11059, 11088);
                    return return_v;
                }


                bool
                f_1203_10909_11089(System.Management.Automation.Provider.ProviderCapabilities
                capability, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = CmdletProviderManagementIntrinsics.CheckProviderCapabilities(capability, provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 10909, 11089);
                    return return_v;
                }


                int
                f_1203_11131_11220(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 11131, 11220);
                    return 0;
                }


                bool
                f_1203_11422_11478(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 11422, 11478);
                    return return_v;
                }


                string[]
                f_1203_11567_11613(System.Management.Automation.Provider.ItemCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ExpandPath(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 11567, 11613);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_11544_11614(string[]
                list)
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>((System.Collections.Generic.IList<string>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 11544, 11614);
                    return return_v;
                }


                int
                f_1203_11713_11743(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 11713, 11743);
                    return 0;
                }


                int
                f_1203_11849_11936(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 11849, 11936);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_12265_12508(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, System.Management.Automation.Provider.ContainerCmdletProvider
                containerProvider, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetGlobbedProviderPathsFromProviderPath(path, allowNonexistingPaths, containerProvider, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 12265, 12508);
                    return return_v;
                }


                int
                f_1203_12772_12802(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 12772, 12802);
                    return 0;
                }


                bool
                f_1203_13062_13108(System.Management.Automation.Provider.ItemCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ItemExists(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 13062, 13108);
                    return return_v;
                }


                int
                f_1203_13158_13188(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 13158, 13188);
                    return 0;
                }


                int
                f_1203_13294_13324(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 13294, 13324);
                    return 0;
                }


                int
                f_1203_13477_13495(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 13477, 13495);
                    return return_v;
                }


                bool
                f_1203_13521_13577(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 13521, 13577);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_13599_13614(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Include;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 13599, 13614);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_13626_13641(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Include;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 13626, 13641);
                    return return_v;
                }


                int
                f_1203_13626_13647(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 13626, 13647);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_13675_13690(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Exclude;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 13675, 13690);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_13702_13717(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Exclude;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 13702, 13717);
                    return return_v;
                }


                int
                f_1203_13702_13723(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 13702, 13723);
                    return return_v;
                }


                string
                f_1203_13953_13985()
                {
                    var return_v = SessionStateStrings.PathNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 13953, 13985);
                    return return_v;
                }


                System.Management.Automation.ItemNotFoundException
                f_1203_13821_13986(string
                path, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.ItemNotFoundException(path, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 13821, 13986);
                    return return_v;
                }


                int
                f_1203_14007_14082(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 14007, 14082);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 10041, 14182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 10041, 14182);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Collection<PathInfo> ResolvePSPathFromProviderPath(
                    string path,
                    CmdletProviderContext context,
                    bool allowNonexistingPaths,
                    bool isProviderDirectPath,
                    bool isProviderQualifiedPath,
                    out CmdletProvider providerInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 14194, 17122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 14522, 14579);

                Collection<PathInfo>
                result = f_1203_14552_14578()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 14595, 14619);

                providerInstance = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 14633, 14658);

                string
                providerId = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 14672, 14697);

                PSDriveInfo
                drive = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 14836, 14863);

                string
                providerPath = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 14879, 15361) || true) && (isProviderDirectPath)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 14879, 15361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 14937, 14997);

                    f_1203_14937_14996(s_pathResolutionTracer, "Path is PROVIDER-DIRECT");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 15015, 15035);

                    providerPath = path;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 15053, 15115);

                    providerId = f_1203_15066_15114(f_1203_15066_15109(f_1203_15066_15100(f_1203_15066_15084(_sessionState))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 14879, 15361);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 14879, 15361);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 15149, 15361) || true) && (isProviderQualifiedPath)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 15149, 15361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 15210, 15273);

                        f_1203_15210_15272(s_pathResolutionTracer, "Path is PROVIDER-QUALIFIED");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 15291, 15346);

                        providerPath = f_1203_15306_15345(path, out providerId);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 15149, 15361);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 14879, 15361);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 15377, 15455);

                f_1203_15377_15454(
                            s_pathResolutionTracer, "PROVIDER-INTERNAL path: {0}", providerPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 15469, 15531);

                f_1203_15469_15530(s_pathResolutionTracer, "Provider: {0}", providerId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 15547, 15801);

                Collection<string>
                stringResult = f_1203_15581_15800(this, providerPath, providerId, allowNonexistingPaths, context, out providerInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 15871, 15921);

                drive = f_1203_15879_15920(f_1203_15879_15908(providerInstance));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 15971, 17081);
                    foreach (string globbedPath in f_1203_16002_16014_I(stringResult))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 15971, 17081);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 16048, 16081);

                        string
                        escapedPath = globbedPath
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 16161, 16279) || true) && (f_1203_16165_16181(context))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 16161, 16279);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 16223, 16260);

                            throw f_1203_16229_16259();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 16161, 16279);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 16299, 16337);

                        string
                        constructedProviderPath = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 16357, 16845) || true) && (f_1203_16361_16394(escapedPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 16357, 16845);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 16436, 16474);

                            constructedProviderPath = escapedPath;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 16357, 16845);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 16357, 16845);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 16556, 16826);

                            constructedProviderPath =
                            f_1203_16607_16825(f_1203_16651_16700(), "{0}::{1}", providerId, escapedPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 16357, 16845);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 16865, 16968);

                        f_1203_16865_16967(
                                        result, f_1203_16876_16966(drive, f_1203_16896_16925(providerInstance), constructedProviderPath, _sessionState));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 16986, 17066);

                        f_1203_16986_17065(s_pathResolutionTracer, "RESOLVED PATH: {0}", constructedProviderPath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 15971, 17081);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 1111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 1111);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 17097, 17111);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 14194, 17122);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1203_14552_14578()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 14552, 14578);
                    return return_v;
                }


                int
                f_1203_14937_14996(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 14937, 14996);
                    return 0;
                }


                System.Management.Automation.PathIntrinsics
                f_1203_15066_15084(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 15066, 15084);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1203_15066_15100(System.Management.Automation.PathIntrinsics
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 15066, 15100);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_15066_15109(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 15066, 15109);
                    return return_v;
                }


                string
                f_1203_15066_15114(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 15066, 15114);
                    return return_v;
                }


                int
                f_1203_15210_15272(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 15210, 15272);
                    return 0;
                }


                string
                f_1203_15306_15345(string
                path, out string
                providerId)
                {
                    var return_v = ParseProviderPath(path, out providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 15306, 15345);
                    return return_v;
                }


                int
                f_1203_15377_15454(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 15377, 15454);
                    return 0;
                }


                int
                f_1203_15469_15530(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 15469, 15530);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_15581_15800(System.Management.Automation.LocationGlobber
                this_param, string
                providerPath, string
                providerId, bool
                allowNonexistingPaths, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.ResolveProviderPathFromProviderPath(providerPath, providerId, allowNonexistingPaths, context, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 15581, 15800);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_15879_15908(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 15879, 15908);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_15879_15920(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.HiddenDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 15879, 15920);
                    return return_v;
                }


                bool
                f_1203_16165_16181(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 16165, 16181);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_16229_16259()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 16229, 16259);
                    return return_v;
                }


                bool
                f_1203_16361_16394(string
                path)
                {
                    var return_v = IsProviderDirectPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 16361, 16394);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1203_16651_16700()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 16651, 16700);
                    return return_v;
                }


                string
                f_1203_16607_16825(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 16607, 16825);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_16896_16925(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 16896, 16925);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1203_16876_16966(System.Management.Automation.PSDriveInfo
                drive, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Management.Automation.SessionState
                sessionState)
                {
                    var return_v = new System.Management.Automation.PathInfo(drive, provider, path, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 16876, 16966);
                    return return_v;
                }


                int
                f_1203_16865_16967(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param, System.Management.Automation.PathInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 16865, 16967);
                    return 0;
                }


                int
                f_1203_16986_17065(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 16986, 17065);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_16002_16014_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 16002, 16014);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 14194, 17122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 14194, 17122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Collection<PathInfo> ResolveDriveQualifiedPath(
                    string path,
                    CmdletProviderContext context,
                    bool allowNonexistingPaths,
                    out CmdletProvider providerInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 17134, 23920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 17375, 17399);

                providerInstance = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 17413, 17438);

                PSDriveInfo
                drive = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 17454, 17511);

                Collection<PathInfo>
                result = f_1203_17484_17510()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 17527, 17587);

                f_1203_17527_17586(
                            s_pathResolutionTracer, "Path is DRIVE-QUALIFIED");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 17603, 17867);

                string
                relativePath =
                f_1203_17642_17866(this, path, context, f_1203_17756_17790_M(!context.SuppressWildcardExpansion), out drive, out providerInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 17883, 18029);

                f_1203_17883_18028(drive != null, "GetDriveRootRelativePathFromPSPath should always return a valid drive");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 18045, 18224);

                f_1203_18045_18223(relativePath != null, "There should always be a way to generate a provider path for a " +
                                "given path");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 18240, 18315);

                f_1203_18240_18314(
                            s_pathResolutionTracer, "DRIVE-RELATIVE path: {0}", relativePath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 18329, 18388);

                f_1203_18329_18387(s_pathResolutionTracer, "Drive: {0}", f_1203_18376_18386(drive));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 18402, 18468);

                f_1203_18402_18467(s_pathResolutionTracer, "Provider: {0}", f_1203_18452_18466(drive));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 18539, 18561);

                context.Drive = drive;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 18575, 18662);

                providerInstance = f_1203_18594_18661(f_1203_18594_18616(_sessionState), f_1203_18646_18660(drive));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 18676, 18770);

                ContainerCmdletProvider
                containerCmdletProvider = providerInstance as ContainerCmdletProvider
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 18784, 18857);

                ItemCmdletProvider
                itemProvider = providerInstance as ItemCmdletProvider
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 18873, 18927);

                ProviderInfo
                provider = f_1203_18897_18926(providerInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 18943, 18966);

                string
                userPath = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 18980, 19003);

                string
                itemPath = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 19019, 19366) || true) && (f_1203_19023_19035(drive))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 19019, 19366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 19069, 19129);

                    userPath = f_1203_19080_19128(relativePath, provider);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 19147, 19171);

                    itemPath = relativePath;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 19019, 19366);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 19019, 19366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 19237, 19291);

                    userPath = f_1203_19248_19290(relativePath, drive);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 19309, 19351);

                    itemPath = f_1203_19320_19350(this, path, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 19019, 19366);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 19382, 19447);

                f_1203_19382_19446(
                            s_pathResolutionTracer, "PROVIDER path: {0}", itemPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 19463, 19522);

                Collection<string>
                stringResult = f_1203_19497_19521()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 19538, 21808) || true) && (f_1203_19542_19576_M(!context.SuppressWildcardExpansion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 19538, 21808);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 19675, 21306) || true) && (f_1203_19679_19838(ProviderCapabilities.ExpandWildcards, provider))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 19675, 21306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 19880, 19970);

                        f_1203_19880_19969(s_pathResolutionTracer, "Wildcard matching is being performed by the provider.");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 20115, 20762) || true) && ((itemProvider != null) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 20119, 20228) && (f_1203_20171_20227(relativePath))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 20115, 20762);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 20278, 20556);
                                foreach (string pathResult in f_1203_20308_20350_I(f_1203_20308_20350(itemProvider, itemPath, context)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 20278, 20556);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 20408, 20529);

                                    f_1203_20408_20528(stringResult, f_1203_20459_20527(this, pathResult, drive, context));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 20278, 20556);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 279);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 279);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 20115, 20762);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 20115, 20762);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 20654, 20739);

                            f_1203_20654_20738(stringResult, f_1203_20671_20737(this, itemPath, drive, context));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 20115, 20762);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 19675, 21306);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 19675, 21306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 20844, 20932);

                        f_1203_20844_20931(s_pathResolutionTracer, "Wildcard matching is being performed by the engine.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 21005, 21287);

                        stringResult =
                        f_1203_21045_21286(this, relativePath, allowNonexistingPaths, drive, containerCmdletProvider, context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 19675, 21306);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 19538, 21808);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 19538, 21808);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 21428, 21793) || true) && (itemProvider != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 21428, 21793);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 21494, 21665) || true) && (allowNonexistingPaths || (DynAbs.Tracing.TraceSender.Expression_False(1203, 21498, 21565) || f_1203_21523_21565(itemProvider, itemPath, context)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 21494, 21665);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 21615, 21642);

                            f_1203_21615_21641(stringResult, userPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 21494, 21665);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 21428, 21793);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 21428, 21793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 21747, 21774);

                        f_1203_21747_21773(stringResult, userPath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 21428, 21793);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 19538, 21808);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 21877, 22560) || true) && ((!allowNonexistingPaths) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 21881, 21948) && f_1203_21926_21944(stringResult) < 1) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 21881, 22018) && !f_1203_21970_22018(path)) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 21881, 22094) && (f_1203_22040_22055(context) == null || (DynAbs.Tracing.TraceSender.Expression_False(1203, 22040, 22093) || f_1203_22067_22088(f_1203_22067_22082(context)) == 0))) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 21881, 22170) && (f_1203_22116_22131(context) == null || (DynAbs.Tracing.TraceSender.Expression_False(1203, 22116, 22169) || f_1203_22143_22164(f_1203_22143_22158(context)) == 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 21877, 22560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 22204, 22420);

                    ItemNotFoundException
                    pathNotFound =
                    f_1203_22262_22419(path, "PathNotFound", f_1203_22386_22418())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 22440, 22508);

                    f_1203_22440_22507(
                                    s_pathResolutionTracer, "Item does not exist: {0}", path);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 22526, 22545);

                    throw pathNotFound;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 21877, 22560);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 22610, 23879);
                    foreach (string expandedPath in f_1203_22642_22654_I(stringResult))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 22610, 23879);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 22741, 22859) || true) && (f_1203_22745_22761(context))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 22741, 22859);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 22803, 22840);

                            throw f_1203_22809_22839();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 22741, 22859);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 22932, 22948);

                        userPath = null;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 22968, 23694) || true) && (f_1203_22972_22984(drive))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 22968, 23694);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 23026, 23431) || true) && (f_1203_23030_23064(expandedPath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 23026, 23431);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 23114, 23138);

                                userPath = expandedPath;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 23026, 23431);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 23026, 23431);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 23236, 23408);

                                userPath =
                                f_1203_23276_23407(expandedPath, provider);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 23026, 23431);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 22968, 23694);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 22968, 23694);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 23513, 23675);

                            userPath =
                            f_1203_23549_23674(expandedPath, drive);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 22968, 23694);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 23714, 23781);

                        f_1203_23714_23780(
                                        result, f_1203_23725_23779(drive, provider, userPath, _sessionState));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 23799, 23864);

                        f_1203_23799_23863(s_pathResolutionTracer, "RESOLVED PATH: {0}", userPath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 22610, 23879);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 1270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 1270);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 23895, 23909);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 17134, 23920);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1203_17484_17510()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 17484, 17510);
                    return return_v;
                }


                int
                f_1203_17527_17586(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 17527, 17586);
                    return 0;
                }


                bool
                f_1203_17756_17790_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 17756, 17790);
                    return return_v;
                }


                string
                f_1203_17642_17866(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, bool
                escapeCurrentLocation, out System.Management.Automation.PSDriveInfo
                workingDriveForPath, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetDriveRootRelativePathFromPSPath(path, context, escapeCurrentLocation, out workingDriveForPath, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 17642, 17866);
                    return return_v;
                }


                int
                f_1203_17883_18028(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 17883, 18028);
                    return 0;
                }


                int
                f_1203_18045_18223(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 18045, 18223);
                    return 0;
                }


                int
                f_1203_18240_18314(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 18240, 18314);
                    return 0;
                }


                string
                f_1203_18376_18386(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 18376, 18386);
                    return return_v;
                }


                int
                f_1203_18329_18387(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 18329, 18387);
                    return 0;
                }


                System.Management.Automation.ProviderInfo
                f_1203_18452_18466(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 18452, 18466);
                    return return_v;
                }


                int
                f_1203_18402_18467(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.Automation.ProviderInfo
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 18402, 18467);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_18594_18616(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 18594, 18616);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_18646_18660(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 18646, 18660);
                    return return_v;
                }


                System.Management.Automation.Provider.ContainerCmdletProvider
                f_1203_18594_18661(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetContainerProviderInstance(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 18594, 18661);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_18897_18926(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 18897, 18926);
                    return return_v;
                }


                bool
                f_1203_19023_19035(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Hidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 19023, 19035);
                    return return_v;
                }


                string
                f_1203_19080_19128(string
                path, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = GetProviderQualifiedPath(path, provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 19080, 19128);
                    return return_v;
                }


                string
                f_1203_19248_19290(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = GetDriveQualifiedPath(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 19248, 19290);
                    return return_v;
                }


                string
                f_1203_19320_19350(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetProviderPath(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 19320, 19350);
                    return return_v;
                }


                int
                f_1203_19382_19446(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 19382, 19446);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_19497_19521()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 19497, 19521);
                    return return_v;
                }


                bool
                f_1203_19542_19576_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 19542, 19576);
                    return return_v;
                }


                bool
                f_1203_19679_19838(System.Management.Automation.Provider.ProviderCapabilities
                capability, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = CmdletProviderManagementIntrinsics.CheckProviderCapabilities(capability, provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 19679, 19838);
                    return return_v;
                }


                int
                f_1203_19880_19969(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 19880, 19969);
                    return 0;
                }


                bool
                f_1203_20171_20227(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 20171, 20227);
                    return return_v;
                }


                string[]
                f_1203_20308_20350(System.Management.Automation.Provider.ItemCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ExpandPath(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 20308, 20350);
                    return return_v;
                }


                string
                f_1203_20459_20527(System.Management.Automation.LocationGlobber
                this_param, string
                providerPath, System.Management.Automation.PSDriveInfo
                drive, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetDriveRootRelativePathFromProviderPath(providerPath, drive, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 20459, 20527);
                    return return_v;
                }


                int
                f_1203_20408_20528(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 20408, 20528);
                    return 0;
                }


                string[]
                f_1203_20308_20350_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 20308, 20350);
                    return return_v;
                }


                string
                f_1203_20671_20737(System.Management.Automation.LocationGlobber
                this_param, string
                providerPath, System.Management.Automation.PSDriveInfo
                drive, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetDriveRootRelativePathFromProviderPath(providerPath, drive, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 20671, 20737);
                    return return_v;
                }


                int
                f_1203_20654_20738(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 20654, 20738);
                    return 0;
                }


                int
                f_1203_20844_20931(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 20844, 20931);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_21045_21286(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, System.Management.Automation.PSDriveInfo
                drive, System.Management.Automation.Provider.ContainerCmdletProvider
                provider, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ExpandMshGlobPath(path, allowNonexistingPaths, drive, provider, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 21045, 21286);
                    return return_v;
                }


                bool
                f_1203_21523_21565(System.Management.Automation.Provider.ItemCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ItemExists(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 21523, 21565);
                    return return_v;
                }


                int
                f_1203_21615_21641(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 21615, 21641);
                    return 0;
                }


                int
                f_1203_21747_21773(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 21747, 21773);
                    return 0;
                }


                int
                f_1203_21926_21944(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 21926, 21944);
                    return return_v;
                }


                bool
                f_1203_21970_22018(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 21970, 22018);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_22040_22055(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Include;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 22040, 22055);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_22067_22082(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Include;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 22067, 22082);
                    return return_v;
                }


                int
                f_1203_22067_22088(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 22067, 22088);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_22116_22131(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Exclude;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 22116, 22131);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_22143_22158(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Exclude;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 22143, 22158);
                    return return_v;
                }


                int
                f_1203_22143_22164(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 22143, 22164);
                    return return_v;
                }


                string
                f_1203_22386_22418()
                {
                    var return_v = SessionStateStrings.PathNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 22386, 22418);
                    return return_v;
                }


                System.Management.Automation.ItemNotFoundException
                f_1203_22262_22419(string
                path, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.ItemNotFoundException(path, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 22262, 22419);
                    return return_v;
                }


                int
                f_1203_22440_22507(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 22440, 22507);
                    return 0;
                }


                bool
                f_1203_22745_22761(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 22745, 22761);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_22809_22839()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 22809, 22839);
                    return return_v;
                }


                bool
                f_1203_22972_22984(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Hidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 22972, 22984);
                    return return_v;
                }


                bool
                f_1203_23030_23064(string
                path)
                {
                    var return_v = IsProviderDirectPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 23030, 23064);
                    return return_v;
                }


                string
                f_1203_23276_23407(string
                path, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = LocationGlobber.GetProviderQualifiedPath(path, provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 23276, 23407);
                    return return_v;
                }


                string
                f_1203_23549_23674(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = LocationGlobber.GetDriveQualifiedPath(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 23549, 23674);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1203_23725_23779(System.Management.Automation.PSDriveInfo
                drive, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Management.Automation.SessionState
                sessionState)
                {
                    var return_v = new System.Management.Automation.PathInfo(drive, provider, path, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 23725, 23779);
                    return return_v;
                }


                int
                f_1203_23714_23780(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param, System.Management.Automation.PathInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 23714, 23780);
                    return 0;
                }


                int
                f_1203_23799_23863(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 23799, 23863);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_22642_22654_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 22642, 22654);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 17134, 23920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 17134, 23920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<string> GetGlobbedProviderPathsFromMonadPath(
                    string path,
                    bool allowNonexistingPaths,
                    out ProviderInfo provider,
                    out CmdletProvider providerInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 26762, 27448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 27009, 27033);

                providerInstance = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 27047, 27171) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 27047, 27171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 27097, 27156);

                    throw f_1203_27103_27155(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 27047, 27171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 27187, 27303);

                CmdletProviderContext
                context =
                f_1203_27236_27302(f_1203_27262_27301(f_1203_27262_27284(_sessionState)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 27319, 27437);

                return f_1203_27326_27436(this, path, allowNonexistingPaths, context, out provider, out providerInstance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 26762, 27448);

                System.Management.Automation.PSArgumentNullException
                f_1203_27103_27155(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 27103, 27155);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_27262_27284(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 27262, 27284);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1203_27262_27301(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 27262, 27301);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1203_27236_27302(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 27236, 27302);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_27326_27436(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedProviderPathsFromMonadPath(path, allowNonexistingPaths, context, out provider, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 27326, 27436);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 26762, 27448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 26762, 27448);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<string> GetGlobbedProviderPathsFromMonadPath(
                    string path,
                    bool allowNonexistingPaths,
                    CmdletProviderContext context,
                    out ProviderInfo provider,
                    out CmdletProvider providerInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 30306, 32412);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 30597, 30721) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 30597, 30721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 30647, 30706);

                    throw f_1203_30653_30705(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 30597, 30721);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 30737, 30867) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 30737, 30867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 30790, 30852);

                    throw f_1203_30796_30851(nameof(context));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 30737, 30867);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 30883, 32401);
                using (f_1203_30890_30985(s_pathResolutionTracer, "Resolving MSH path \"{0}\" to PROVIDER-INTERNAL path", path))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 31019, 31041);

                    f_1203_31019_31040(context);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 31159, 31274) || true) && (f_1203_31163_31192(path))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 31159, 31274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 31234, 31255);

                        context.Drive = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 31159, 31274);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 31294, 31319);

                    PSDriveInfo
                    drive = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 31337, 31415);

                    string
                    providerPath = f_1203_31359_31414(this, path, context, out provider, out drive)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 31435, 31796) || true) && (providerPath == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 31435, 31796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 31501, 31525);

                        providerInstance = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 31547, 31624);

                        f_1203_31547_31623(s_tracer, "provider returned a null path so return an empty array");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 31648, 31723);

                        f_1203_31648_31722(
                                            s_pathResolutionTracer, "Provider '{0}' returned null", provider);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 31745, 31777);

                        return f_1203_31752_31776();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 31435, 31796);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 31816, 31916) || true) && (drive != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 31816, 31916);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 31875, 31897);

                        context.Drive = drive;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 31816, 31916);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 31936, 31988);

                    Collection<string>
                    paths = f_1203_31963_31987()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 32008, 32353);
                        foreach (PathInfo currentPath in f_1203_32062_32256_I(f_1203_32062_32256(this, path, allowNonexistingPaths, context, out providerInstance)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 32008, 32353);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 32298, 32334);

                            f_1203_32298_32333(paths, f_1203_32308_32332(currentPath));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 32008, 32353);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 346);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 346);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 32373, 32386);

                    return paths;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 30883, 32401);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 30306, 32412);

                System.Management.Automation.PSArgumentNullException
                f_1203_30653_30705(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 30653, 30705);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_30796_30851(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 30796, 30851);
                    return return_v;
                }


                System.IDisposable
                f_1203_30890_30985(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 30890, 30985);
                    return return_v;
                }


                int
                f_1203_31019_31040(System.Management.Automation.CmdletProviderContext
                context)
                {
                    TraceFilters(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 31019, 31040);
                    return 0;
                }


                bool
                f_1203_31163_31192(string
                path)
                {
                    var return_v = IsProviderQualifiedPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 31163, 31192);
                    return return_v;
                }


                string
                f_1203_31359_31414(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 31359, 31414);
                    return return_v;
                }


                int
                f_1203_31547_31623(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 31547, 31623);
                    return 0;
                }


                int
                f_1203_31648_31722(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.Automation.ProviderInfo
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 31648, 31722);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_31752_31776()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 31752, 31776);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_31963_31987()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 31963, 31987);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1203_32062_32256(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedMonadPathsFromMonadPath(path, allowNonexistingPaths, context, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 32062, 32256);
                    return return_v;
                }


                string
                f_1203_32308_32332(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.ProviderPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 32308, 32332);
                    return return_v;
                }


                int
                f_1203_32298_32333(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 32298, 32333);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1203_32062_32256_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 32062, 32256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 30306, 32412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 30306, 32412);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<string> GetGlobbedProviderPathsFromProviderPath(
                    string path,
                    bool allowNonexistingPaths,
                    string providerId,
                    out CmdletProvider providerInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 34789, 35977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 35031, 35055);

                providerInstance = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 35071, 35195) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 35071, 35195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 35121, 35180);

                    throw f_1203_35127_35179(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 35071, 35195);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 35211, 35327);

                CmdletProviderContext
                context =
                f_1203_35260_35326(f_1203_35286_35325(f_1203_35286_35308(_sessionState)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 35343, 35607);

                Collection<string>
                results =
                f_1203_35389_35606(this, path, allowNonexistingPaths, providerId, context, out providerInstance)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 35623, 35935) || true) && (f_1203_35627_35646(context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 35623, 35935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 35722, 35788);

                    ErrorRecord
                    errorRecord = f_1203_35748_35787(f_1203_35748_35784(context), 0)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 35808, 35920) || true) && (errorRecord != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 35808, 35920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 35873, 35901);

                        throw f_1203_35879_35900(errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 35808, 35920);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 35623, 35935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 35951, 35966);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 34789, 35977);

                System.Management.Automation.PSArgumentNullException
                f_1203_35127_35179(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 35127, 35179);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_35286_35308(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 35286, 35308);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1203_35286_35325(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 35286, 35325);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1203_35260_35326(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 35260, 35326);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_35389_35606(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, string
                providerId, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedProviderPathsFromProviderPath(path, allowNonexistingPaths, providerId, context, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 35389, 35606);
                    return return_v;
                }


                bool
                f_1203_35627_35646(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.HasErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 35627, 35646);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                f_1203_35748_35784(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.GetAccumulatedErrorObjects();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 35748, 35784);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1203_35748_35787(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 35748, 35787);
                    return return_v;
                }


                System.Exception
                f_1203_35879_35900(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 35879, 35900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 34789, 35977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 34789, 35977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<string> GetGlobbedProviderPathsFromProviderPath(
                    string path,
                    bool allowNonexistingPaths,
                    string providerId,
                    CmdletProviderContext context,
                    out CmdletProvider providerInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 38324, 39527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 38610, 38634);

                providerInstance = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 38650, 38774) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 38650, 38774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 38700, 38759);

                    throw f_1203_38706_38758(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 38650, 38774);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 38790, 38926) || true) && (providerId == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 38790, 38926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 38846, 38911);

                    throw f_1203_38852_38910(nameof(providerId));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 38790, 38926);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 38942, 39072) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 38942, 39072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 38995, 39057);

                    throw f_1203_39001_39056(nameof(context));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 38942, 39072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 39088, 39516);
                using (f_1203_39095_39204(s_pathResolutionTracer, "Resolving PROVIDER-INTERNAL path \"{0}\" to PROVIDER-INTERNAL path", path))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 39238, 39260);

                    f_1203_39238_39259(context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 39280, 39501);

                    return f_1203_39287_39500(this, path, providerId, allowNonexistingPaths, context, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 39088, 39516);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 38324, 39527);

                System.Management.Automation.PSArgumentNullException
                f_1203_38706_38758(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 38706, 38758);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_38852_38910(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 38852, 38910);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_39001_39056(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 39001, 39056);
                    return return_v;
                }


                System.IDisposable
                f_1203_39095_39204(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 39095, 39204);
                    return return_v;
                }


                int
                f_1203_39238_39259(System.Management.Automation.CmdletProviderContext
                context)
                {
                    TraceFilters(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 39238, 39259);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_39287_39500(System.Management.Automation.LocationGlobber
                this_param, string
                providerPath, string
                providerId, bool
                allowNonexistingPaths, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.ResolveProviderPathFromProviderPath(providerPath, providerId, allowNonexistingPaths, context, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 39287, 39500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 38324, 39527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 38324, 39527);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetProviderPath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 41442, 41608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 41511, 41540);

                ProviderInfo
                provider = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 41554, 41597);

                return f_1203_41561_41596(this, path, out provider);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 41442, 41608);

                string
                f_1203_41561_41596(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 41561, 41596);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 41442, 41608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 41442, 41608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetProviderPath(string path, out ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 43670, 44546);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 43766, 43890) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 43766, 43890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 43816, 43875);

                    throw f_1203_43822_43874(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 43766, 43890);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 43906, 44022);

                CmdletProviderContext
                context =
                f_1203_43955_44021(f_1203_43981_44020(f_1203_43981_44003(_sessionState)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 44038, 44063);

                PSDriveInfo
                drive = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 44077, 44093);

                provider = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 44109, 44181);

                string
                result = f_1203_44125_44180(this, path, context, out provider, out drive)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 44197, 44505) || true) && (f_1203_44201_44220(context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 44197, 44505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 44254, 44324);

                    Collection<ErrorRecord>
                    errors = f_1203_44287_44323(context)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 44344, 44490) || true) && (errors != null && (DynAbs.Tracing.TraceSender.Expression_True(1203, 44348, 44403) && f_1203_44387_44399(errors) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 44344, 44490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 44445, 44471);

                        throw f_1203_44451_44470(f_1203_44451_44460(errors, 0));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 44344, 44490);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 44197, 44505);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 44521, 44535);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 43670, 44546);

                System.Management.Automation.PSArgumentNullException
                f_1203_43822_43874(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 43822, 43874);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_43981_44003(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 43981, 44003);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1203_43981_44020(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 43981, 44020);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1203_43955_44021(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 43955, 44021);
                    return return_v;
                }


                string
                f_1203_44125_44180(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 44125, 44180);
                    return return_v;
                }


                bool
                f_1203_44201_44220(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.HasErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 44201, 44220);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                f_1203_44287_44323(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.GetAccumulatedErrorObjects();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 44287, 44323);
                    return return_v;
                }


                int
                f_1203_44387_44399(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 44387, 44399);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1203_44451_44460(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 44451, 44460);
                    return return_v;
                }


                System.Exception
                f_1203_44451_44470(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 44451, 44470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 43670, 44546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 43670, 44546);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetProviderPath(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 46568, 47005);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 46668, 46792) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 46668, 46792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 46718, 46777);

                    throw f_1203_46724_46776(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 46668, 46792);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 46808, 46833);

                PSDriveInfo
                drive = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 46847, 46876);

                ProviderInfo
                provider = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 46892, 46964);

                string
                result = f_1203_46908_46963(this, path, context, out provider, out drive)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 46980, 46994);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 46568, 47005);

                System.Management.Automation.PSArgumentNullException
                f_1203_46724_46776(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 46724, 46776);
                    return return_v;
                }


                string
                f_1203_46908_46963(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 46908, 46963);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 46568, 47005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 46568, 47005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetProviderPath(
                    string path,
                    CmdletProviderContext context,
                    out ProviderInfo provider,
                    out PSDriveInfo drive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 49312, 49682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 49515, 49671);

                return f_1203_49522_49670(this, path, context, false, out provider, out drive);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 49312, 49682);

                string
                f_1203_49522_49670(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, bool
                isTrusted, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, isTrusted, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 49522, 49670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 49312, 49682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 49312, 49682);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetProviderPath(
                    string path,
                    CmdletProviderContext context,
                    bool isTrusted,
                    out ProviderInfo provider,
                    out PSDriveInfo drive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 50140, 55029);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 50372, 50496) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 50372, 50496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 50422, 50481);

                    throw f_1203_50428_50480(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 50372, 50496);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 50512, 50642) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 50512, 50642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 50565, 50627);

                    throw f_1203_50571_50626(nameof(context));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 50512, 50642);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 50658, 50679);

                string
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 50693, 50709);

                provider = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 50723, 50736);

                drive = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 50822, 51058) || true) && (f_1203_50826_50842(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 50822, 51058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 50876, 51043);
                    using (f_1203_50883_50949(s_pathResolutionTracer, "Resolving HOME relative path."))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 50991, 51024);

                        path = f_1203_50998_51023(this, path);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 50876, 51043);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 50822, 51058);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 51162, 53658) || true) && (f_1203_51166_51192(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 51162, 53658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 51226, 51286);

                    f_1203_51226_51285(s_pathResolutionTracer, "Path is PROVIDER-DIRECT");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 51385, 51399);

                    result = path;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 51417, 51430);

                    drive = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 51448, 51503);

                    provider = f_1203_51459_51502(f_1203_51459_51493(f_1203_51459_51477(_sessionState)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 51523, 51595);

                    f_1203_51523_51594(
                                    s_pathResolutionTracer, "PROVIDER-INTERNAL path: {0}", result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 51613, 51673);

                    f_1203_51613_51672(s_pathResolutionTracer, "Provider: {0}", provider);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 51162, 53658);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 51162, 53658);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 51707, 53658) || true) && (f_1203_51711_51740(path))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 51707, 53658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 51774, 51837);

                        f_1203_51774_51836(s_pathResolutionTracer, "Path is PROVIDER-QUALIFIED");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 51857, 51882);

                        string
                        providerId = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 51900, 51949);

                        result = f_1203_51909_51948(path, out providerId);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 51967, 51980);

                        drive = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 52042, 52106);

                        provider = f_1203_52053_52105(f_1203_52053_52075(_sessionState), providerId);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 52126, 52198);

                        f_1203_52126_52197(
                                        s_pathResolutionTracer, "PROVIDER-INTERNAL path: {0}", result);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 52216, 52276);

                        f_1203_52216_52275(s_pathResolutionTracer, "Provider: {0}", provider);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 51707, 53658);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 51707, 53658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 52342, 52402);

                        f_1203_52342_52401(s_pathResolutionTracer, "Path is DRIVE-QUALIFIED");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 52422, 52461);

                        CmdletProvider
                        providerInstance = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 52479, 52591);

                        string
                        relativePath = f_1203_52501_52590(this, path, context, false, out drive, out providerInstance)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 52611, 52765);

                        f_1203_52611_52764(drive != null, "GetDriveRootRelativePathFromPSPath should always return a valid drive");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 52785, 52976);

                        f_1203_52785_52975(relativePath != null, "There should always be a way to generate a provider path for a " +
                                            "given path");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 52996, 53071);

                        f_1203_52996_53070(
                                        s_pathResolutionTracer, "DRIVE-RELATIVE path: {0}", relativePath);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 53089, 53148);

                        f_1203_53089_53147(s_pathResolutionTracer, "Drive: {0}", f_1203_53136_53146(drive));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 53166, 53232);

                        f_1203_53166_53231(s_pathResolutionTracer, "Provider: {0}", f_1203_53216_53230(drive));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 53311, 53333);

                        context.Drive = drive;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 53353, 53597) || true) && (f_1203_53357_53369(drive))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 53353, 53597);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 53411, 53433);

                            result = relativePath;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 53353, 53597);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 53353, 53597);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 53515, 53578);

                            result = f_1203_53524_53577(this, drive, relativePath, context);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 53353, 53597);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 53617, 53643);

                        provider = f_1203_53628_53642(drive);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 51707, 53658);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 51162, 53658);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 53674, 53737);

                f_1203_53674_53736(
                            s_pathResolutionTracer, "RESOLVED PATH: {0}", result);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 53853, 54988) || true) && ((provider != null) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 53857, 53913) && (context != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 53857, 53964) && (f_1203_53935_53955(context) != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 53857, 54019) && (f_1203_53986_54010(context) != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 53857, 54094) && (f_1203_54041_54085(f_1203_54041_54065(context)) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 53853, 54988);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 54128, 54973);
                        foreach (Runspaces.SessionStateProviderEntry sessionStateProvider in f_1203_54197_54266_I(f_1203_54197_54266(f_1203_54197_54251(f_1203_54197_54241(f_1203_54197_54221(context))), f_1203_54252_54265(provider))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 54128, 54973);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 54308, 54954) || true) && (!isTrusted && (DynAbs.Tracing.TraceSender.Expression_True(1203, 54312, 54423) && (f_1203_54352_54383(sessionStateProvider) == SessionStateEntryVisibility.Private)) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 54312, 54514) && (f_1203_54453_54487(f_1203_54453_54473(context)) == CommandOrigin.Runspace)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 54308, 54954);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 54564, 54640);

                                f_1203_54564_54639(s_pathResolutionTracer, "Provider is private: {0}", f_1203_54625_54638(provider));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 54668, 54931);

                                throw f_1203_54674_54930(f_1203_54734_54747(provider), SessionStateCategory.CmdletProvider, "ProviderNotFound", f_1203_54893_54929());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 54308, 54954);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 54128, 54973);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 846);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 846);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 53853, 54988);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 55004, 55018);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 50140, 55029);

                System.Management.Automation.PSArgumentNullException
                f_1203_50428_50480(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 50428, 50480);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_50571_50626(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 50571, 50626);
                    return return_v;
                }


                bool
                f_1203_50826_50842(string
                path)
                {
                    var return_v = IsHomePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 50826, 50842);
                    return return_v;
                }


                System.IDisposable
                f_1203_50883_50949(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 50883, 50949);
                    return return_v;
                }


                string
                f_1203_50998_51023(System.Management.Automation.LocationGlobber
                this_param, string
                path)
                {
                    var return_v = this_param.GetHomeRelativePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 50998, 51023);
                    return return_v;
                }


                bool
                f_1203_51166_51192(string
                path)
                {
                    var return_v = IsProviderDirectPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 51166, 51192);
                    return return_v;
                }


                int
                f_1203_51226_51285(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 51226, 51285);
                    return 0;
                }


                System.Management.Automation.PathIntrinsics
                f_1203_51459_51477(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 51459, 51477);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1203_51459_51493(System.Management.Automation.PathIntrinsics
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 51459, 51493);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_51459_51502(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 51459, 51502);
                    return return_v;
                }


                int
                f_1203_51523_51594(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 51523, 51594);
                    return 0;
                }


                int
                f_1203_51613_51672(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.Automation.ProviderInfo
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 51613, 51672);
                    return 0;
                }


                bool
                f_1203_51711_51740(string
                path)
                {
                    var return_v = IsProviderQualifiedPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 51711, 51740);
                    return return_v;
                }


                int
                f_1203_51774_51836(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 51774, 51836);
                    return 0;
                }


                string
                f_1203_51909_51948(string
                path, out string
                providerId)
                {
                    var return_v = ParseProviderPath(path, out providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 51909, 51948);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_52053_52075(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 52053, 52075);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_52053_52105(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetSingleProvider(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 52053, 52105);
                    return return_v;
                }


                int
                f_1203_52126_52197(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 52126, 52197);
                    return 0;
                }


                int
                f_1203_52216_52275(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.Automation.ProviderInfo
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 52216, 52275);
                    return 0;
                }


                int
                f_1203_52342_52401(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 52342, 52401);
                    return 0;
                }


                string
                f_1203_52501_52590(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, bool
                escapeCurrentLocation, out System.Management.Automation.PSDriveInfo
                workingDriveForPath, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetDriveRootRelativePathFromPSPath(path, context, escapeCurrentLocation, out workingDriveForPath, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 52501, 52590);
                    return return_v;
                }


                int
                f_1203_52611_52764(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 52611, 52764);
                    return 0;
                }


                int
                f_1203_52785_52975(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 52785, 52975);
                    return 0;
                }


                int
                f_1203_52996_53070(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 52996, 53070);
                    return 0;
                }


                string
                f_1203_53136_53146(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 53136, 53146);
                    return return_v;
                }


                int
                f_1203_53089_53147(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 53089, 53147);
                    return 0;
                }


                System.Management.Automation.ProviderInfo
                f_1203_53216_53230(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 53216, 53230);
                    return return_v;
                }


                int
                f_1203_53166_53231(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.Automation.ProviderInfo
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 53166, 53231);
                    return 0;
                }


                bool
                f_1203_53357_53369(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Hidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 53357, 53369);
                    return return_v;
                }


                string
                f_1203_53524_53577(System.Management.Automation.LocationGlobber
                this_param, System.Management.Automation.PSDriveInfo
                drive, string
                workingPath, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetProviderSpecificPath(drive, workingPath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 53524, 53577);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_53628_53642(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 53628, 53642);
                    return return_v;
                }


                int
                f_1203_53674_53736(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 53674, 53736);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1203_53935_53955(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 53935, 53955);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1203_53986_54010(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 53986, 54010);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1203_54041_54065(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 54041, 54065);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1203_54041_54085(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InitialSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 54041, 54085);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1203_54197_54221(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 54197, 54221);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1203_54197_54241(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InitialSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 54197, 54241);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
                f_1203_54197_54251(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 54197, 54251);
                    return return_v;
                }


                string
                f_1203_54252_54265(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 54252, 54265);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
                f_1203_54197_54266(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 54197, 54266);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1203_54352_54383(System.Management.Automation.Runspaces.SessionStateProviderEntry
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 54352, 54383);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1203_54453_54473(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 54453, 54473);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1203_54453_54487(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 54453, 54487);
                    return return_v;
                }


                string
                f_1203_54625_54638(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 54625, 54638);
                    return return_v;
                }


                int
                f_1203_54564_54639(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 54564, 54639);
                    return 0;
                }


                string
                f_1203_54734_54747(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 54734, 54747);
                    return return_v;
                }


                string
                f_1203_54893_54929()
                {
                    var return_v = SessionStateStrings.ProviderNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 54893, 54929);
                    return return_v;
                }


                System.Management.Automation.ProviderNotFoundException
                f_1203_54674_54930(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.ProviderNotFoundException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 54674, 54930);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
                f_1203_54197_54266_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 54197, 54266);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 50140, 55029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 50140, 55029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsProviderQualifiedPath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 55706, 55891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 55788, 55813);

                string
                providerId = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 55827, 55880);

                return f_1203_55834_55879(path, out providerId);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 55706, 55891);

                bool
                f_1203_55834_55879(string
                path, out string
                providerId)
                {
                    var return_v = IsProviderQualifiedPath(path, out providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 55834, 55879);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 55706, 55891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 55706, 55891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsProviderQualifiedPath(string path, out string providerId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 56709, 58645);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 56850, 56974) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 56850, 56974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 56900, 56959);

                    throw f_1203_56906_56958(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 56850, 56974);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 56990, 57008);

                providerId = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 57022, 57042);

                bool
                result = false
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 57058, 58604);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 57093, 57286) || true) && (f_1203_57097_57108(path) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 57093, 57286);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 57224, 57239);

                                result = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(1203, 57261, 57267);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 57093, 57286);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 57306, 57725) || true) && (f_1203_57310_57358(path, @".\", StringComparison.Ordinal) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 57310, 57431) || f_1203_57383_57431(path, @"./", StringComparison.Ordinal)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 57306, 57725);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 57663, 57678);

                                result = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(1203, 57700, 57706);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 57306, 57725);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 57745, 57775);

                            int
                            index = f_1203_57757_57774(path, ':')
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 57793, 58088) || true) && (index == -1 || (DynAbs.Tracing.TraceSender.Expression_False(1203, 57797, 57836) || index + 1 >= f_1203_57825_57836(path)) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 57797, 57862) || f_1203_57840_57855(path, index + 1) != ':'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 57793, 58088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 58026, 58041);

                                result = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(1203, 58063, 58069);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 57793, 58088);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 58303, 58574) || true) && (index > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 58303, 58574);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 58358, 58372);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 58442, 58480);

                                providerId = f_1203_58455_58479(path, 0, index);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 58504, 58555);

                                f_1203_58504_58554(
                                                    s_tracer, "providerId = {0}", providerId);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 58303, 58574);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 57058, 58604);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 57058, 58604) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 57058, 58604);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 57058, 58604);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 58620, 58634);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 56709, 58645);

                System.Management.Automation.PSArgumentNullException
                f_1203_56906_56958(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 56906, 56958);
                    return return_v;
                }


                int
                f_1203_57097_57108(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 57097, 57108);
                    return return_v;
                }


                bool
                f_1203_57310_57358(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 57310, 57358);
                    return return_v;
                }


                bool
                f_1203_57383_57431(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 57383, 57431);
                    return return_v;
                }


                int
                f_1203_57757_57774(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 57757, 57774);
                    return return_v;
                }


                int
                f_1203_57825_57836(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 57825, 57836);
                    return return_v;
                }


                char
                f_1203_57840_57855(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 57840, 57855);
                    return return_v;
                }


                string
                f_1203_58455_58479(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 58455, 58479);
                    return return_v;
                }


                int
                f_1203_58504_58554(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 58504, 58554);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 56709, 58645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 56709, 58645);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsSingleFileSystemAbsolutePath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 59362, 59649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 59617, 59630);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 59362, 59649);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 59362, 59649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 59362, 59649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsAbsolutePath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 60122, 62723);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 60231, 60355) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 60231, 60355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 60281, 60340);

                    throw f_1203_60287_60339(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 60231, 60355);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 60371, 60391);

                bool
                result = false
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 60407, 62682);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 60442, 60635) || true) && (f_1203_60446_60457(path) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 60442, 60635);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 60573, 60588);

                                result = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(1203, 60610, 60616);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 60442, 60635);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 60704, 61123) || true) && (f_1203_60708_60756(path, @".\", StringComparison.Ordinal) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 60708, 60829) || f_1203_60781_60829(path, @"./", StringComparison.Ordinal)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 60704, 61123);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 61061, 61076);

                                result = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(1203, 61098, 61104);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 60704, 61123);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 61232, 61375) || true) && (f_1203_61236_61272(path))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 61232, 61375);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 61314, 61328);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1203, 61350, 61356);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 61232, 61375);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 61395, 61425);

                            int
                            index = f_1203_61407_61424(path, ':')
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 61445, 61686) || true) && (index == -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 61445, 61686);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 61624, 61639);

                                result = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(1203, 61661, 61667);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 61445, 61686);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 61896, 62652) || true) && (index > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 61896, 62652);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 62151, 62231);

                                int
                                separator = f_1203_62167_62230(path, StringLiterals.DefaultPathSeparator, 0, index - 1)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 62253, 62423) || true) && (separator == -1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 62253, 62423);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 62322, 62400);

                                    separator = f_1203_62334_62399(path, StringLiterals.AlternatePathSeparator, 0, index - 1);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 62253, 62423);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 62447, 62633) || true) && (separator == -1 || (DynAbs.Tracing.TraceSender.Expression_False(1203, 62451, 62487) || index < separator))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 62447, 62633);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 62596, 62610);

                                    result = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 62447, 62633);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 61896, 62652);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 60407, 62682);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 60407, 62682) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 60407, 62682);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 60407, 62682);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 62698, 62712);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 60122, 62723);

                System.Management.Automation.PSArgumentNullException
                f_1203_60287_60339(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 60287, 60339);
                    return return_v;
                }


                int
                f_1203_60446_60457(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 60446, 60457);
                    return return_v;
                }


                bool
                f_1203_60708_60756(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 60708, 60756);
                    return return_v;
                }


                bool
                f_1203_60781_60829(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 60781, 60829);
                    return return_v;
                }


                bool
                f_1203_61236_61272(string
                path)
                {
                    var return_v = IsSingleFileSystemAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 61236, 61272);
                    return return_v;
                }


                int
                f_1203_61407_61424(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 61407, 61424);
                    return return_v;
                }


                int
                f_1203_62167_62230(string
                this_param, char
                value, int
                startIndex, int
                count)
                {
                    var return_v = this_param.IndexOf(value, startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 62167, 62230);
                    return return_v;
                }


                int
                f_1203_62334_62399(string
                this_param, char
                value, int
                startIndex, int
                count)
                {
                    var return_v = this_param.IndexOf(value, startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 62334, 62399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 60122, 62723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 60122, 62723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsAbsolutePath(string path, out string driveName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 63253, 65980);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 63377, 63501) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 63377, 63501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 63427, 63486);

                    throw f_1203_63433_63485(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 63377, 63501);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 63517, 63537);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 63553, 63769) || true) && (f_1203_63557_63584(f_1203_63557_63576(_sessionState)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 63553, 63769);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 63626, 63671);

                    driveName = f_1203_63638_63670(f_1203_63638_63665(f_1203_63638_63657(_sessionState)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 63553, 63769);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 63553, 63769);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 63737, 63754);

                    driveName = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 63553, 63769);
                }
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 63785, 65535);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 63820, 64013) || true) && (f_1203_63824_63835(path) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 63820, 64013);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 63951, 63966);

                                result = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(1203, 63988, 63994);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 63820, 64013);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 64033, 64452) || true) && (f_1203_64037_64085(path, @".\", StringComparison.Ordinal) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 64037, 64158) || f_1203_64110_64158(path, @"./", StringComparison.Ordinal)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 64033, 64452);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 64390, 64405);

                                result = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(1203, 64427, 64433);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 64033, 64452);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 64561, 64780) || true) && (f_1203_64565_64601(path))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 64561, 64780);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 64643, 64697);

                                driveName = StringLiterals.DefaultPathSeparatorString;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 64719, 64733);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1203, 64755, 64761);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 64561, 64780);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 64800, 64830);

                            int
                            index = f_1203_64812_64829(path, ':')
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 64850, 65091) || true) && (index == -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 64850, 65091);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 65029, 65044);

                                result = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(1203, 65066, 65072);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 64850, 65091);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 65301, 65505) || true) && (index > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 65301, 65505);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 65411, 65448);

                                driveName = f_1203_65423_65447(path, 0, index);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 65472, 65486);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 65301, 65505);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 63785, 65535);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 63785, 65535) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 63785, 65535);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 63785, 65535);
                    }
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 65562, 65931) || true) && (result)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 65562, 65931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 65606, 65804);

                    f_1203_65606_65803(driveName != null, "The drive name should always have a value, " +
                                        "the default is the current working drive");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 65824, 65916);

                    f_1203_65824_65915(
                                    s_tracer, "driveName = {0}", driveName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 65562, 65931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 65955, 65969);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 63253, 65980);

                System.Management.Automation.PSArgumentNullException
                f_1203_63433_63485(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 63433, 63485);
                    return return_v;
                }


                System.Management.Automation.DriveManagementIntrinsics
                f_1203_63557_63576(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 63557, 63576);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_63557_63584(System.Management.Automation.DriveManagementIntrinsics
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 63557, 63584);
                    return return_v;
                }


                System.Management.Automation.DriveManagementIntrinsics
                f_1203_63638_63657(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 63638, 63657);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_63638_63665(System.Management.Automation.DriveManagementIntrinsics
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 63638, 63665);
                    return return_v;
                }


                string
                f_1203_63638_63670(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 63638, 63670);
                    return return_v;
                }


                int
                f_1203_63824_63835(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 63824, 63835);
                    return return_v;
                }


                bool
                f_1203_64037_64085(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 64037, 64085);
                    return return_v;
                }


                bool
                f_1203_64110_64158(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 64110, 64158);
                    return return_v;
                }


                bool
                f_1203_64565_64601(string
                path)
                {
                    var return_v = IsSingleFileSystemAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 64565, 64601);
                    return return_v;
                }


                int
                f_1203_64812_64829(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 64812, 64829);
                    return return_v;
                }


                string
                f_1203_65423_65447(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 65423, 65447);
                    return return_v;
                }


                int
                f_1203_65606_65803(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 65606, 65803);
                    return 0;
                }


                int
                f_1203_65824_65915(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 65824, 65915);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 63253, 65980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 63253, 65980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SessionState _sessionState;

        private static string RemoveGlobEscaping(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 66757, 67063);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 66835, 66959) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 66835, 66959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 66885, 66944);

                    throw f_1203_66891_66943(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 66835, 66959);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 66975, 67022);

                string
                result = f_1203_66991_67021(path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 67038, 67052);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 66757, 67063);

                System.Management.Automation.PSArgumentNullException
                f_1203_66891_66943(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 66891, 66943);
                    return return_v;
                }


                string
                f_1203_66991_67021(string
                pattern)
                {
                    var return_v = WildcardPattern.Unescape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 66991, 67021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 66757, 67063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 66757, 67063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsShellVirtualDrive(string driveName, out SessionStateScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 68455, 69692);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 68560, 68694) || true) && (driveName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 68560, 68694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 68615, 68679);

                    throw f_1203_68621_68678(nameof(driveName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 68560, 68694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 68710, 68730);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 68746, 69651) || true) && (f_1203_68750_68898(driveName, StringLiterals.Global, StringComparison.OrdinalIgnoreCase) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 68746, 69651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 68980, 69042);

                    f_1203_68980_69041(                // It's the global scope.
                                    s_tracer, "match found: {0}", StringLiterals.Global);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 69060, 69074);

                    result = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 69092, 69135);

                    scope = f_1203_69100_69134(f_1203_69100_69122(_sessionState));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 68746, 69651);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 68746, 69651);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 69169, 69651) || true) && (f_1203_69173_69332(driveName, StringLiterals.Local, StringComparison.OrdinalIgnoreCase) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 69169, 69651);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 69413, 69463);

                        f_1203_69413_69462(                // It's the local scope.
                                        s_tracer, "match found: {0}", driveName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 69481, 69495);

                        result = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 69513, 69557);

                        scope = f_1203_69521_69556(f_1203_69521_69543(_sessionState));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 69169, 69651);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 69169, 69651);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 69623, 69636);

                        scope = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 69169, 69651);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 68746, 69651);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 69667, 69681);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 68455, 69692);

                System.Management.Automation.PSArgumentNullException
                f_1203_68621_68678(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 68621, 68678);
                    return return_v;
                }


                int
                f_1203_68750_68898(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 68750, 68898);
                    return return_v;
                }


                int
                f_1203_68980_69041(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 68980, 69041);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_69100_69122(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 69100, 69122);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1203_69100_69134(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 69100, 69134);
                    return return_v;
                }


                int
                f_1203_69173_69332(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 69173, 69332);
                    return return_v;
                }


                int
                f_1203_69413_69462(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 69413, 69462);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_69521_69543(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 69521, 69543);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1203_69521_69556(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 69521, 69556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 68455, 69692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 68455, 69692);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetDriveRootRelativePathFromPSPath(
                    string path,
                    CmdletProviderContext context,
                    bool escapeCurrentLocation,
                    out PSDriveInfo workingDriveForPath,
                    out CmdletProvider providerInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 72721, 78631);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 73044, 73168) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 73044, 73168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 73094, 73153);

                    throw f_1203_73100_73152(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 73044, 73168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 73184, 73211);

                workingDriveForPath = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 73225, 73249);

                string
                driveName = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 73265, 73398) || true) && (f_1203_73269_73296(f_1203_73269_73288(_sessionState)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 73265, 73398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 73338, 73383);

                    driveName = f_1203_73350_73382(f_1203_73350_73377(f_1203_73350_73369(_sessionState)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 73265, 73398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 73479, 73514);

                bool
                isPathForCurrentDrive = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 73530, 77164) || true) && (f_1203_73534_73569(this, path, out driveName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 73530, 77164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 73603, 73741);

                    f_1203_73603_73740(driveName != null, "IsAbsolutePath should be returning the drive name");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 73761, 73853);

                    f_1203_73761_73852(
                                    s_tracer, "Drive Name: {0}", driveName);

                    // This will resolve $GLOBAL, and $LOCAL as needed.
                    // This throws DriveNotFoundException if a drive of the specified
                    // name does not exist. Just let the exception propagate out.
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 74148, 74205);

                        workingDriveForPath = f_1203_74170_74204(f_1203_74170_74189(_sessionState), driveName);
                    }
                    catch (DriveNotFoundException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1203, 74242, 75860);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 74616, 74734) || true) && (f_1203_74620_74647(f_1203_74620_74639(_sessionState)) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 74616, 74734);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 74705, 74711);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 74616, 74734);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 74758, 74925);

                        string
                        normalizedRoot = f_1203_74782_74924(f_1203_74782_74814(f_1203_74782_74809(f_1203_74782_74801(_sessionState))), StringLiterals.AlternatePathSeparator, StringLiterals.DefaultPathSeparator)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 74949, 75712) || true) && (f_1203_74953_74981(normalizedRoot, ':'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 74949, 75712);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 75031, 75144);

                            string
                            normalizedPath = f_1203_75055_75143(path, StringLiterals.AlternatePathSeparator, StringLiterals.DefaultPathSeparator)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 75170, 75689) || true) && (f_1203_75174_75251(normalizedPath, normalizedRoot, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 75170, 75689);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 75309, 75338);

                                isPathForCurrentDrive = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 75368, 75413);

                                path = f_1203_75375_75412(path, f_1203_75390_75411(normalizedRoot));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 75443, 75502);

                                path = f_1203_75450_75501(path, StringLiterals.DefaultPathSeparator);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 75532, 75582);

                                path = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (StringLiterals.DefaultPathSeparator).ToString(), 1203, 75539, 75574) + path;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 75612, 75662);

                                workingDriveForPath = f_1203_75634_75661(f_1203_75634_75653(_sessionState));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 75170, 75689);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 74949, 75712);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 75736, 75841) || true) && (!isPathForCurrentDrive)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 75736, 75841);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 75812, 75818);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 75736, 75841);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1203, 74242, 75860);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 75945, 76949) || true) && (!isPathForCurrentDrive)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 75945, 76949);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 76613, 76930) || true) && (f_1203_76617_76659(workingDriveForPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 76613, 76930);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 76863, 76907);

                            path = f_1203_76870_76906(path, f_1203_76885_76901(driveName) + 1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 76613, 76930);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 75945, 76949);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 73530, 77164);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 73530, 77164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 77099, 77149);

                    workingDriveForPath = f_1203_77121_77148(f_1203_77121_77140(_sessionState));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 73530, 77164);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 77180, 77603) || true) && (workingDriveForPath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 77180, 77603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 77245, 77461);

                    ItemNotFoundException
                    pathNotFound =
                    f_1203_77303_77460(path, "PathNotFound", f_1203_77427_77459())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 77481, 77549);

                    f_1203_77481_77548(
                                    s_pathResolutionTracer, "Item does not exist: {0}", path);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 77569, 77588);

                    throw pathNotFound;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 77180, 77603);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 77655, 77777);

                    providerInstance =
                    f_1203_77695_77776(f_1203_77695_77717(_sessionState), f_1203_77747_77775(workingDriveForPath));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 77917, 77953);

                    context.Drive = workingDriveForPath;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 77973, 78008);

                    string
                    relativePath = string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 78028, 78288);

                    relativePath =
                    f_1203_78064_78287(this, workingDriveForPath, path, escapeCurrentLocation, providerInstance, context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 78308, 78328);

                    return relativePath;
                }
                catch (PSNotSupportedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1203, 78357, 78620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 78543, 78567);

                    providerInstance = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 78585, 78605);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1203, 78357, 78620);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 72721, 78631);

                System.Management.Automation.PSArgumentNullException
                f_1203_73100_73152(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 73100, 73152);
                    return return_v;
                }


                System.Management.Automation.DriveManagementIntrinsics
                f_1203_73269_73288(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 73269, 73288);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_73269_73296(System.Management.Automation.DriveManagementIntrinsics
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 73269, 73296);
                    return return_v;
                }


                System.Management.Automation.DriveManagementIntrinsics
                f_1203_73350_73369(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 73350, 73369);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_73350_73377(System.Management.Automation.DriveManagementIntrinsics
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 73350, 73377);
                    return return_v;
                }


                string
                f_1203_73350_73382(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 73350, 73382);
                    return return_v;
                }


                bool
                f_1203_73534_73569(System.Management.Automation.LocationGlobber
                this_param, string
                path, out string
                driveName)
                {
                    var return_v = this_param.IsAbsolutePath(path, out driveName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 73534, 73569);
                    return return_v;
                }


                int
                f_1203_73603_73740(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 73603, 73740);
                    return 0;
                }


                int
                f_1203_73761_73852(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 73761, 73852);
                    return 0;
                }


                System.Management.Automation.DriveManagementIntrinsics
                f_1203_74170_74189(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 74170, 74189);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_74170_74204(System.Management.Automation.DriveManagementIntrinsics
                this_param, string
                driveName)
                {
                    var return_v = this_param.Get(driveName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 74170, 74204);
                    return return_v;
                }


                System.Management.Automation.DriveManagementIntrinsics
                f_1203_74620_74639(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 74620, 74639);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_74620_74647(System.Management.Automation.DriveManagementIntrinsics
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 74620, 74647);
                    return return_v;
                }


                System.Management.Automation.DriveManagementIntrinsics
                f_1203_74782_74801(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 74782, 74801);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_74782_74809(System.Management.Automation.DriveManagementIntrinsics
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 74782, 74809);
                    return return_v;
                }


                string
                f_1203_74782_74814(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 74782, 74814);
                    return return_v;
                }


                string
                f_1203_74782_74924(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 74782, 74924);
                    return return_v;
                }


                bool
                f_1203_74953_74981(string
                this_param, char
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 74953, 74981);
                    return return_v;
                }


                string
                f_1203_75055_75143(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 75055, 75143);
                    return return_v;
                }


                bool
                f_1203_75174_75251(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 75174, 75251);
                    return return_v;
                }


                int
                f_1203_75390_75411(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 75390, 75411);
                    return return_v;
                }


                string
                f_1203_75375_75412(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 75375, 75412);
                    return return_v;
                }


                string
                f_1203_75450_75501(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimStart(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 75450, 75501);
                    return return_v;
                }


                System.Management.Automation.DriveManagementIntrinsics
                f_1203_75634_75653(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 75634, 75653);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_75634_75661(System.Management.Automation.DriveManagementIntrinsics
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 75634, 75661);
                    return return_v;
                }


                bool
                f_1203_76617_76659(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.VolumeSeparatedByColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 76617, 76659);
                    return return_v;
                }


                int
                f_1203_76885_76901(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 76885, 76901);
                    return return_v;
                }


                string
                f_1203_76870_76906(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 76870, 76906);
                    return return_v;
                }


                System.Management.Automation.DriveManagementIntrinsics
                f_1203_77121_77140(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 77121, 77140);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_77121_77148(System.Management.Automation.DriveManagementIntrinsics
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 77121, 77148);
                    return return_v;
                }


                string
                f_1203_77427_77459()
                {
                    var return_v = SessionStateStrings.PathNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 77427, 77459);
                    return return_v;
                }


                System.Management.Automation.ItemNotFoundException
                f_1203_77303_77460(string
                path, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.ItemNotFoundException(path, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 77303, 77460);
                    return return_v;
                }


                int
                f_1203_77481_77548(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 77481, 77548);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_77695_77717(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 77695, 77717);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_77747_77775(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 77747, 77775);
                    return return_v;
                }


                System.Management.Automation.Provider.ContainerCmdletProvider
                f_1203_77695_77776(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetContainerProviderInstance(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 77695, 77776);
                    return return_v;
                }


                string
                f_1203_78064_78287(System.Management.Automation.LocationGlobber
                this_param, System.Management.Automation.PSDriveInfo
                drive, string
                path, bool
                escapeCurrentLocation, System.Management.Automation.Provider.CmdletProvider
                providerInstance, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GenerateRelativePath(drive, path, escapeCurrentLocation, providerInstance, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 78064, 78287);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 72721, 78631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 72721, 78631);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetDriveRootRelativePathFromProviderPath(
                    string providerPath,
                    PSDriveInfo drive,
                    CmdletProviderContext context
                    )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 78643, 80627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 78848, 78880);

                string
                childPath = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 78896, 79015);

                CmdletProvider
                providerInstance =
                f_1203_78947_79014(f_1203_78947_78969(_sessionState), f_1203_78999_79013(drive))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 79029, 79120);

                NavigationCmdletProvider
                navigationProvider = providerInstance as NavigationCmdletProvider
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 79172, 79284);

                providerPath = f_1203_79187_79283(providerPath, StringLiterals.AlternatePathSeparator, StringLiterals.DefaultPathSeparator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 79298, 79371);

                providerPath = f_1203_79313_79370(providerPath, StringLiterals.DefaultPathSeparator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 79385, 79499);

                string
                driveRoot = f_1203_79404_79498(f_1203_79404_79414(drive), StringLiterals.AlternatePathSeparator, StringLiterals.DefaultPathSeparator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 79513, 79580);

                driveRoot = f_1203_79525_79579(driveRoot, StringLiterals.DefaultPathSeparator);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 79705, 80583) || true) && ((!f_1203_79714_79748(providerPath)) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 79712, 79839) && (!f_1203_79772_79838(providerPath, driveRoot, StringComparison.OrdinalIgnoreCase))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 79705, 80583);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 79873, 80358) || true) && (!f_1203_79878_79909(childPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 79873, 80358);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 79951, 80190);

                            childPath = f_1203_79963_80189(f_1203_79963_79985(_sessionState), providerInstance, f_1203_80064_80118(navigationProvider, providerPath, context), childPath, context);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 79873, 80358);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 79873, 80358);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 80272, 80339);

                            childPath = f_1203_80284_80338(navigationProvider, providerPath, context);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 79873, 80358);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 80378, 80568);

                        providerPath = f_1203_80393_80567(f_1203_80393_80415(_sessionState), providerInstance, providerPath, f_1203_80526_80536(drive), context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 79705, 80583);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 79705, 80583);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 79705, 80583);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 80599, 80616);

                return childPath;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 78643, 80627);

                System.Management.Automation.SessionStateInternal
                f_1203_78947_78969(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 78947, 78969);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_78999_79013(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 78999, 79013);
                    return return_v;
                }


                System.Management.Automation.Provider.ContainerCmdletProvider
                f_1203_78947_79014(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetContainerProviderInstance(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 78947, 79014);
                    return return_v;
                }


                string
                f_1203_79187_79283(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 79187, 79283);
                    return return_v;
                }


                string
                f_1203_79313_79370(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 79313, 79370);
                    return return_v;
                }


                string
                f_1203_79404_79414(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 79404, 79414);
                    return return_v;
                }


                string
                f_1203_79404_79498(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 79404, 79498);
                    return return_v;
                }


                string
                f_1203_79525_79579(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 79525, 79579);
                    return return_v;
                }


                bool
                f_1203_79714_79748(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 79714, 79748);
                    return return_v;
                }


                bool
                f_1203_79772_79838(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 79772, 79838);
                    return return_v;
                }


                bool
                f_1203_79878_79909(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 79878, 79909);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_79963_79985(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 79963, 79985);
                    return return_v;
                }


                string
                f_1203_80064_80118(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetChildName(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 80064, 80118);
                    return return_v;
                }


                string
                f_1203_79963_80189(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Provider.CmdletProvider
                providerInstance, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(providerInstance, parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 79963, 80189);
                    return return_v;
                }


                string
                f_1203_80284_80338(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetChildName(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 80284, 80338);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_80393_80415(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 80393, 80415);
                    return return_v;
                }


                string
                f_1203_80526_80536(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 80526, 80536);
                    return return_v;
                }


                string
                f_1203_80393_80567(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Provider.CmdletProvider
                providerInstance, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetParentPath(providerInstance, path, root, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 80393, 80567);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 78643, 80627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 78643, 80627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GenerateRelativePath(
                    PSDriveInfo drive,
                    string path,
                    bool escapeCurrentLocation,
                    CmdletProvider providerInstance,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 82468, 92082);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 82755, 82879) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 82755, 82879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 82805, 82864);

                    throw f_1203_82811_82863(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 82755, 82879);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 82895, 83021) || true) && (drive == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 82895, 83021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 82946, 83006);

                    throw f_1203_82952_83005(nameof(drive));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 82895, 83021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 83194, 83254);

                string
                driveRootRelativeWorkingPath = f_1203_83232_83253(drive)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 83268, 83563) || true) && ((!f_1203_83274_83324(driveRootRelativeWorkingPath) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 83273, 83424) && (f_1203_83346_83423(driveRootRelativeWorkingPath, f_1203_83386_83396(drive), StringComparison.Ordinal)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 83268, 83563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 83459, 83548);

                    driveRootRelativeWorkingPath = f_1203_83490_83547(driveRootRelativeWorkingPath, f_1203_83529_83546(f_1203_83529_83539(drive)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 83268, 83563);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 83579, 83694) || true) && (escapeCurrentLocation)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 83579, 83694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 83608, 83692);

                    driveRootRelativeWorkingPath = f_1203_83639_83691(driveRootRelativeWorkingPath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 83579, 83694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 83901, 83955);

                const char
                monadRelativePathSeparatorBackslash = '\\'
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 83969, 84025);

                const char
                monadRelativePathSeparatorForwardslash = '/'
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 84039, 84075);

                const string
                currentDirSymbol = "."
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 84089, 84125);

                const string
                parentDirSymbol = ".."
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 84139, 84175);

                const int
                parentDirSymbolLength = 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 84189, 84244);

                const string
                currentDirRelativeSymbolBackslash = ".\\"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 84258, 84315);

                const string
                currentDirRelativeSymbolForwardslash = "./"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 84541, 90485) || true) && (f_1203_84545_84571(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 84541, 90485);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 84541, 90485);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 84541, 90485);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 84659, 90485) || true) && (f_1203_84663_84670(path, 0) == monadRelativePathSeparatorBackslash || (DynAbs.Tracing.TraceSender.Expression_False(1203, 84663, 84784) || f_1203_84735_84742(path, 0) == monadRelativePathSeparatorForwardslash))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 84659, 90485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 85172, 85216);

                        driveRootRelativeWorkingPath = string.Empty;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 85325, 85350);

                        path = f_1203_85332_85349(path, 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 85370, 85452);

                        f_1203_85370_85451(
                                        s_tracer, "path = {0}", path);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 84659, 90485);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 84659, 90485);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 85620, 90470) || true) && ((f_1203_85628_85639(path) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 85627, 85675) && f_1203_85648_85675(this, path)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 85620, 90470);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 85717, 85847) || true) && (f_1203_85721_85737(context))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 85717, 85847);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 85787, 85824);

                                    throw f_1203_85793_85823();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 85717, 85847);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 85871, 85903);

                                bool
                                processedSomething = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 85994, 86084);

                                bool
                                pathStartsWithDirSymbol = f_1203_86025_86083(path, parentDirSymbol, StringComparison.Ordinal)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 86106, 86182);

                                bool
                                pathLengthEqualsParentDirSymbol = f_1203_86145_86156(path) == parentDirSymbolLength
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 86204, 86507);

                                bool
                                pathDirSymbolFollowedBySeparator =
                                                        (f_1203_86270_86281(path) > parentDirSymbolLength) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 86269, 86506) && ((f_1203_86337_86364(path, parentDirSymbolLength) == monadRelativePathSeparatorBackslash) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 86336, 86505) || (f_1203_86435_86462(path, parentDirSymbolLength) == monadRelativePathSeparatorForwardslash))))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 86531, 88986) || true) && (pathStartsWithDirSymbol && (DynAbs.Tracing.TraceSender.Expression_True(1203, 86535, 86682) && (pathLengthEqualsParentDirSymbol || (DynAbs.Tracing.TraceSender.Expression_False(1203, 86588, 86681) || pathDirSymbolFollowedBySeparator))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 86531, 88986);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 86732, 87266) || true) && (!f_1203_86737_86787(driveRootRelativeWorkingPath))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 86732, 87266);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 86920, 87239);

                                        driveRootRelativeWorkingPath =
                                        f_1203_86984_87238(f_1203_86984_87006(_sessionState), providerInstance, driveRootRelativeWorkingPath, f_1203_87181_87191(drive), context);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 86732, 87266);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 87294, 87423);

                                    f_1203_87294_87422(
                                                            s_tracer, "Parent path = {0}", driveRootRelativeWorkingPath);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 87562, 87666);

                                    path =
                                    f_1203_87598_87665(path, parentDirSymbolLength);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 87694, 87792);

                                    f_1203_87694_87791(
                                                            s_tracer, "path = {0}", path);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 87820, 87846);

                                    processedSomething = true;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 87872, 87983) || true) && (f_1203_87876_87887(path) == 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 87872, 87983);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1203, 87950, 87956);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 87872, 87983);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 88138, 88380) || true) && (f_1203_88142_88149(path, 0) == monadRelativePathSeparatorBackslash || (DynAbs.Tracing.TraceSender.Expression_False(1203, 88142, 88270) || f_1203_88221_88228(path, 0) == monadRelativePathSeparatorForwardslash))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 88138, 88380);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 88328, 88353);

                                        path = f_1203_88335_88352(path, 1);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 88138, 88380);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 88408, 88506);

                                    f_1203_88408_88505(
                                                            s_tracer, "path = {0}", path);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 88608, 88719) || true) && (f_1203_88612_88623(path) == 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 88608, 88719);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1203, 88686, 88692);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 88608, 88719);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 88954, 88963);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 86531, 88986);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 89077, 89323) || true) && (f_1203_89081_89146(path, currentDirSymbol, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 89077, 89323);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 89196, 89222);

                                    processedSomething = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 89248, 89268);

                                    path = string.Empty;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1203, 89294, 89300);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 89077, 89323);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 89347, 89987) || true) && (f_1203_89351_89427(path, currentDirRelativeSymbolBackslash, StringComparison.Ordinal) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 89351, 89535) || f_1203_89456_89535(path, currentDirRelativeSymbolForwardslash, StringComparison.Ordinal)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 89347, 89987);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 89585, 89649);

                                    path = f_1203_89592_89648(path, f_1203_89607_89647(currentDirRelativeSymbolBackslash));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 89675, 89701);

                                    processedSomething = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 89727, 89825);

                                    f_1203_89727_89824(s_tracer, "path = {0}", path);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 89853, 89964) || true) && (f_1203_89857_89868(path) == 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 89853, 89964);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1203, 89931, 89937);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 89853, 89964);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 89347, 89987);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 90121, 90220) || true) && (f_1203_90125_90136(path) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 90121, 90220);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1203, 90191, 90197);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 90121, 90220);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 90244, 90451) || true) && (!processedSomething)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 90244, 90451);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1203, 90422, 90428);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 90244, 90451);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 85620, 90470);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 85620, 90470);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 85620, 90470);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 84659, 90485);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 84541, 90485);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 90601, 90929) || true) && (!f_1203_90606_90632(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 90601, 90929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 90666, 90914);

                    driveRootRelativeWorkingPath =
                    f_1203_90718_90913(f_1203_90718_90740(_sessionState), providerInstance, driveRootRelativeWorkingPath, path, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 90601, 90929);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 90945, 91036);

                NavigationCmdletProvider
                navigationProvider = providerInstance as NavigationCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 91050, 91903) || true) && (navigationProvider != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 91050, 91903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 91114, 91225);

                    string
                    rootedPath = f_1203_91134_91224(f_1203_91134_91156(_sessionState), f_1203_91166_91184(f_1203_91166_91179(context)), driveRootRelativeWorkingPath, context)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 91243, 91363);

                    string
                    normalizedRelativePath = f_1203_91275_91362(navigationProvider, rootedPath, f_1203_91327_91345(f_1203_91327_91340(context)), false, context)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 91383, 91888) || true) && (!f_1203_91388_91432(normalizedRelativePath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 91383, 91888);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 91474, 91781) || true) && (f_1203_91478_91557(normalizedRelativePath, f_1203_91512_91530(f_1203_91512_91525(context)), StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 91474, 91781);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 91584, 91675);

                            driveRootRelativeWorkingPath = f_1203_91615_91674(normalizedRelativePath, f_1203_91648_91673(f_1203_91648_91666(f_1203_91648_91661(context))));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 91474, 91781);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 91474, 91781);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 91727, 91781);

                            driveRootRelativeWorkingPath = normalizedRelativePath;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 91474, 91781);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 91383, 91888);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 91383, 91888);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 91844, 91888);

                        driveRootRelativeWorkingPath = string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 91383, 91888);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 91050, 91903);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 91919, 92019);

                f_1203_91919_92018(
                            s_tracer, "result = {0}", driveRootRelativeWorkingPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 92035, 92071);

                return driveRootRelativeWorkingPath;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 82468, 92082);

                System.Management.Automation.PSArgumentNullException
                f_1203_82811_82863(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 82811, 82863);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_82952_83005(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 82952, 83005);
                    return return_v;
                }


                string
                f_1203_83232_83253(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 83232, 83253);
                    return return_v;
                }


                bool
                f_1203_83274_83324(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 83274, 83324);
                    return return_v;
                }


                string
                f_1203_83386_83396(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 83386, 83396);
                    return return_v;
                }


                bool
                f_1203_83346_83423(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 83346, 83423);
                    return return_v;
                }


                string
                f_1203_83529_83539(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 83529, 83539);
                    return return_v;
                }


                int
                f_1203_83529_83546(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 83529, 83546);
                    return return_v;
                }


                string
                f_1203_83490_83547(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 83490, 83547);
                    return return_v;
                }


                string
                f_1203_83639_83691(string
                pattern)
                {
                    var return_v = WildcardPattern.Escape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 83639, 83691);
                    return return_v;
                }


                bool
                f_1203_84545_84571(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 84545, 84571);
                    return return_v;
                }


                char
                f_1203_84663_84670(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 84663, 84670);
                    return return_v;
                }


                char
                f_1203_84735_84742(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 84735, 84742);
                    return return_v;
                }


                string
                f_1203_85332_85349(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 85332, 85349);
                    return return_v;
                }


                int
                f_1203_85370_85451(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 85370, 85451);
                    return 0;
                }


                int
                f_1203_85628_85639(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 85628, 85639);
                    return return_v;
                }


                bool
                f_1203_85648_85675(System.Management.Automation.LocationGlobber
                this_param, string
                path)
                {
                    var return_v = this_param.HasRelativePathTokens(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 85648, 85675);
                    return return_v;
                }


                bool
                f_1203_85721_85737(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 85721, 85737);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_85793_85823()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 85793, 85823);
                    return return_v;
                }


                bool
                f_1203_86025_86083(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 86025, 86083);
                    return return_v;
                }


                int
                f_1203_86145_86156(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 86145, 86156);
                    return return_v;
                }


                int
                f_1203_86270_86281(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 86270, 86281);
                    return return_v;
                }


                char
                f_1203_86337_86364(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 86337, 86364);
                    return return_v;
                }


                char
                f_1203_86435_86462(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 86435, 86462);
                    return return_v;
                }


                bool
                f_1203_86737_86787(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 86737, 86787);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_86984_87006(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 86984, 87006);
                    return return_v;
                }


                string
                f_1203_87181_87191(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 87181, 87191);
                    return return_v;
                }


                string
                f_1203_86984_87238(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Provider.CmdletProvider
                providerInstance, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetParentPath(providerInstance, path, root, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 86984, 87238);
                    return return_v;
                }


                int
                f_1203_87294_87422(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 87294, 87422);
                    return 0;
                }


                string
                f_1203_87598_87665(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 87598, 87665);
                    return return_v;
                }


                int
                f_1203_87694_87791(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 87694, 87791);
                    return 0;
                }


                int
                f_1203_87876_87887(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 87876, 87887);
                    return return_v;
                }


                char
                f_1203_88142_88149(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 88142, 88149);
                    return return_v;
                }


                char
                f_1203_88221_88228(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 88221, 88228);
                    return return_v;
                }


                string
                f_1203_88335_88352(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 88335, 88352);
                    return return_v;
                }


                int
                f_1203_88408_88505(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 88408, 88505);
                    return 0;
                }


                int
                f_1203_88612_88623(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 88612, 88623);
                    return return_v;
                }


                bool
                f_1203_89081_89146(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 89081, 89146);
                    return return_v;
                }


                bool
                f_1203_89351_89427(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 89351, 89427);
                    return return_v;
                }


                bool
                f_1203_89456_89535(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 89456, 89535);
                    return return_v;
                }


                int
                f_1203_89607_89647(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 89607, 89647);
                    return return_v;
                }


                string
                f_1203_89592_89648(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 89592, 89648);
                    return return_v;
                }


                int
                f_1203_89727_89824(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 89727, 89824);
                    return 0;
                }


                int
                f_1203_89857_89868(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 89857, 89868);
                    return return_v;
                }


                int
                f_1203_90125_90136(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 90125, 90136);
                    return return_v;
                }


                bool
                f_1203_90606_90632(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 90606, 90632);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_90718_90740(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 90718, 90740);
                    return return_v;
                }


                string
                f_1203_90718_90913(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Provider.CmdletProvider
                providerInstance, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(providerInstance, parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 90718, 90913);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_91134_91156(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 91134, 91156);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_91166_91179(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 91166, 91179);
                    return return_v;
                }


                string
                f_1203_91166_91184(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 91166, 91184);
                    return return_v;
                }


                string
                f_1203_91134_91224(System.Management.Automation.SessionStateInternal
                this_param, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 91134, 91224);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_91327_91340(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 91327, 91340);
                    return return_v;
                }


                string
                f_1203_91327_91345(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 91327, 91345);
                    return return_v;
                }


                string
                f_1203_91275_91362(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, string
                basePath, bool
                allowNonExistingPaths, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ContractRelativePath(path, basePath, allowNonExistingPaths, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 91275, 91362);
                    return return_v;
                }


                bool
                f_1203_91388_91432(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 91388, 91432);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_91512_91525(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 91512, 91525);
                    return return_v;
                }


                string
                f_1203_91512_91530(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 91512, 91530);
                    return return_v;
                }


                bool
                f_1203_91478_91557(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 91478, 91557);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_91648_91661(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 91648, 91661);
                    return return_v;
                }


                string
                f_1203_91648_91666(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 91648, 91666);
                    return return_v;
                }


                int
                f_1203_91648_91673(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 91648, 91673);
                    return return_v;
                }


                string
                f_1203_91615_91674(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 91615, 91674);
                    return return_v;
                }


                int
                f_1203_91919_92018(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 91919, 92018);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 82468, 92082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 82468, 92082);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasRelativePathTokens(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 92094, 92897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 92166, 92211);

                string
                comparePath = f_1203_92187_92210(path, '/', '\\')
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 92227, 92886);

                return (
                f_1203_92253_92312(comparePath, ".", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 92253, 92393) || f_1203_92333_92393(comparePath, "..", StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 92253, 92443) || f_1203_92414_92443(comparePath, "\\.\\")) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 92253, 92494) || f_1203_92464_92494(comparePath, "\\..\\")) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 92253, 92579) || f_1203_92515_92579(comparePath, "\\..", StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 92253, 92663) || f_1203_92600_92663(comparePath, "\\.", StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 92253, 92750) || f_1203_92684_92750(comparePath, "..\\", StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 92253, 92836) || f_1203_92771_92836(comparePath, ".\\", StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 92253, 92884) || f_1203_92857_92884(comparePath, '~')));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 92094, 92897);

                string
                f_1203_92187_92210(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 92187, 92210);
                    return return_v;
                }


                bool
                f_1203_92253_92312(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 92253, 92312);
                    return return_v;
                }


                bool
                f_1203_92333_92393(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 92333, 92393);
                    return return_v;
                }


                bool
                f_1203_92414_92443(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 92414, 92443);
                    return return_v;
                }


                bool
                f_1203_92464_92494(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 92464, 92494);
                    return return_v;
                }


                bool
                f_1203_92515_92579(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 92515, 92579);
                    return return_v;
                }


                bool
                f_1203_92600_92663(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 92600, 92663);
                    return return_v;
                }


                bool
                f_1203_92684_92750(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 92684, 92750);
                    return return_v;
                }


                bool
                f_1203_92771_92836(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 92771, 92836);
                    return return_v;
                }


                bool
                f_1203_92857_92884(string
                this_param, char
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 92857, 92884);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 92094, 92897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 92094, 92897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetProviderSpecificPath(
                    PSDriveInfo drive,
                    string workingPath,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 93953, 95131);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 94126, 94252) || true) && (drive == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 94126, 94252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 94177, 94237);

                    throw f_1203_94183_94236(nameof(drive));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 94126, 94252);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 94268, 94406) || true) && (workingPath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 94268, 94406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 94325, 94391);

                    throw f_1203_94331_94390(nameof(workingPath));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 94268, 94406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 94457, 94471);

                f_1203_94457_94470(
                            // Trace the inputs

                            drive);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 94485, 94573);

                f_1203_94485_94572(s_tracer, "workingPath = {0}", workingPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 94589, 94616);

                string
                result = f_1203_94605_94615(drive)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 94668, 94877);

                    result =
                    f_1203_94698_94876(f_1203_94698_94720(_sessionState), f_1203_94756_94770(drive), result, workingPath, context);
                }
                catch (NotSupportedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1203, 94906, 95090);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1203, 94906, 95090);
                    // This is valid if the provider doesn't support MakePath.  The
                    // drive should be enough.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 95106, 95120);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 93953, 95131);

                System.Management.Automation.PSArgumentNullException
                f_1203_94183_94236(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 94183, 94236);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_94331_94390(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 94331, 94390);
                    return return_v;
                }


                int
                f_1203_94457_94470(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    this_param.Trace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 94457, 94470);
                    return 0;
                }


                int
                f_1203_94485_94572(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 94485, 94572);
                    return 0;
                }


                string
                f_1203_94605_94615(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 94605, 94615);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_94698_94720(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 94698, 94720);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_94756_94770(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 94756, 94770);
                    return return_v;
                }


                string
                f_1203_94698_94876(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(provider, parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 94698, 94876);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 93953, 95131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 93953, 95131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string ParseProviderPath(string path, out string providerId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 95949, 96835);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 96049, 96173) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 96049, 96173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 96099, 96158);

                    throw f_1203_96105_96157(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 96049, 96173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 96189, 96297);

                int
                providerIdSeparatorIndex = f_1203_96220_96296(path, StringLiterals.ProviderPathSeparator, StringComparison.Ordinal)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 96313, 96604) || true) && (providerIdSeparatorIndex <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 96313, 96604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 96380, 96563);

                    ArgumentException
                    e =
                    f_1203_96423_96562("path", f_1203_96517_96561())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 96581, 96589);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 96313, 96604);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 96620, 96677);

                providerId = f_1203_96633_96676(path, 0, providerIdSeparatorIndex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 96691, 96794);

                string
                result = f_1203_96707_96793(path, providerIdSeparatorIndex + f_1203_96749_96792(StringLiterals.ProviderPathSeparator))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 96810, 96824);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 95949, 96835);

                System.Management.Automation.PSArgumentNullException
                f_1203_96105_96157(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 96105, 96157);
                    return return_v;
                }


                int
                f_1203_96220_96296(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 96220, 96296);
                    return return_v;
                }


                string
                f_1203_96517_96561()
                {
                    var return_v = SessionStateStrings.NotProviderQualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 96517, 96561);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1203_96423_96562(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 96423, 96562);
                    return return_v;
                }


                string
                f_1203_96633_96676(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 96633, 96676);
                    return return_v;
                }


                int
                f_1203_96749_96792(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 96749, 96792);
                    return return_v;
                }


                string
                f_1203_96707_96793(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 96707, 96793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 95949, 96835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 95949, 96835);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<string> GetGlobbedProviderPathsFromProviderPath(
                    string path,
                    bool allowNonexistingPaths,
                    ContainerCmdletProvider containerProvider,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 99140, 100109);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 99400, 99524) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 99400, 99524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 99450, 99509);

                    throw f_1203_99456_99508(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 99400, 99524);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 99540, 99690) || true) && (containerProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 99540, 99690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 99603, 99675);

                    throw f_1203_99609_99674(nameof(containerProvider));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 99540, 99690);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 99706, 99836) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 99706, 99836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 99759, 99821);

                    throw f_1203_99765_99820(nameof(context));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 99706, 99836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 99852, 100061);

                Collection<string>
                expandedPaths =
                f_1203_99904_100060(this, path, allowNonexistingPaths, containerProvider, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 100077, 100098);

                return expandedPaths;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 99140, 100109);

                System.Management.Automation.PSArgumentNullException
                f_1203_99456_99508(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 99456, 99508);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_99609_99674(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 99609, 99674);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_99765_99820(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 99765, 99820);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_99904_100060(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, System.Management.Automation.Provider.ContainerCmdletProvider
                provider, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ExpandGlobPath(path, allowNonexistingPaths, provider, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 99904, 100060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 99140, 100109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 99140, 100109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool StringContainsGlobCharacters(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 100679, 100973);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 100766, 100890) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 100766, 100890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 100816, 100875);

                    throw f_1203_100822_100874(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 100766, 100890);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 100906, 100962);

                return f_1203_100913_100961(path);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 100679, 100973);

                System.Management.Automation.PSArgumentNullException
                f_1203_100822_100874(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 100822, 100874);
                    return return_v;
                }


                bool
                f_1203_100913_100961(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 100913, 100961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 100679, 100973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 100679, 100973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ShouldPerformGlobbing(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 101623, 102990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 101734, 101774);

                bool
                pathContainsGlobCharacters = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 101790, 101919) || true) && (path != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 101790, 101919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 101840, 101904);

                    pathContainsGlobCharacters = f_1203_101869_101903(path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 101790, 101919);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 101935, 101978);

                bool
                contextContainsIncludeExclude = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 101992, 102027);

                bool
                contextContainsNoGlob = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 102043, 102747) || true) && (context != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 102043, 102747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 102096, 102171);

                    bool
                    includePresent = f_1203_102118_102133(context) != null && (DynAbs.Tracing.TraceSender.Expression_True(1203, 102118, 102170) && f_1203_102145_102166(f_1203_102145_102160(context)) > 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 102189, 102269);

                    f_1203_102189_102268(s_pathResolutionTracer, "INCLUDE filter present: {0}", includePresent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 102289, 102364);

                    bool
                    excludePresent = f_1203_102311_102326(context) != null && (DynAbs.Tracing.TraceSender.Expression_True(1203, 102311, 102363) && f_1203_102338_102359(f_1203_102338_102353(context)) > 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 102382, 102462);

                    f_1203_102382_102461(s_pathResolutionTracer, "EXCLUDE filter present: {0}", excludePresent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 102482, 102547);

                    contextContainsIncludeExclude = includePresent || (DynAbs.Tracing.TraceSender.Expression_False(1203, 102514, 102546) || excludePresent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 102567, 102625);

                    contextContainsNoGlob = f_1203_102591_102624(context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 102643, 102732);

                    f_1203_102643_102731(s_pathResolutionTracer, "NOGLOB parameter present: {0}", contextContainsNoGlob);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 102043, 102747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 102763, 102866);

                f_1203_102763_102865(
                            s_pathResolutionTracer, "Path contains wildcard characters: {0}", pathContainsGlobCharacters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 102882, 102979);

                return (pathContainsGlobCharacters || (DynAbs.Tracing.TraceSender.Expression_False(1203, 102890, 102949) || contextContainsIncludeExclude)) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 102889, 102978) && (!contextContainsNoGlob));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 101623, 102990);

                bool
                f_1203_101869_101903(string
                path)
                {
                    var return_v = StringContainsGlobCharacters(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 101869, 101903);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_102118_102133(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Include;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 102118, 102133);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_102145_102160(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Include;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 102145, 102160);
                    return return_v;
                }


                int
                f_1203_102145_102166(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 102145, 102166);
                    return return_v;
                }


                int
                f_1203_102189_102268(System.Management.Automation.PSTraceSource
                this_param, string
                format, bool
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 102189, 102268);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_102311_102326(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Exclude;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 102311, 102326);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_102338_102353(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Exclude;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 102338, 102353);
                    return return_v;
                }


                int
                f_1203_102338_102359(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 102338, 102359);
                    return return_v;
                }


                int
                f_1203_102382_102461(System.Management.Automation.PSTraceSource
                this_param, string
                format, bool
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 102382, 102461);
                    return 0;
                }


                bool
                f_1203_102591_102624(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.SuppressWildcardExpansion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 102591, 102624);
                    return return_v;
                }


                int
                f_1203_102643_102731(System.Management.Automation.PSTraceSource
                this_param, string
                format, bool
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 102643, 102731);
                    return 0;
                }


                int
                f_1203_102763_102865(System.Management.Automation.PSTraceSource
                this_param, string
                format, bool
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 102763, 102865);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 101623, 102990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 101623, 102990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Collection<string> ExpandMshGlobPath(
                    string path,
                    bool allowNonexistingPaths,
                    PSDriveInfo drive,
                    ContainerCmdletProvider provider,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 107073, 122059);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 107333, 107457) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 107333, 107457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 107383, 107442);

                    throw f_1203_107389_107441(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 107333, 107457);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 107473, 107605) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 107473, 107605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 107527, 107590);

                    throw f_1203_107533_107589(nameof(provider));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 107473, 107605);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 107621, 107747) || true) && (drive == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 107621, 107747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 107672, 107732);

                    throw f_1203_107678_107731(nameof(drive));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 107621, 107747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 107763, 107802);

                f_1203_107763_107801(
                            s_tracer, "path = {0}", path);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 107818, 107901);

                NavigationCmdletProvider
                navigationProvider = provider as NavigationCmdletProvider
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 107917, 107970);

                Collection<string>
                result = f_1203_107945_107969()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 107986, 121847);
                using (f_1203_107993_108049(s_pathResolutionTracer, "EXPANDING WILDCARDS"))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 108083, 121832) || true) && (f_1203_108087_108123(path, context))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 108083, 121832);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 108518, 108557);

                        List<string>
                        dirs = f_1203_108538_108556()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 108751, 108800);

                        Stack<string>
                        leafElements = f_1203_108780_108799()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 108824, 114108);
                        using (f_1203_108831_108883(s_pathResolutionTracer, "Tokenizing path"))
                        {
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 109212, 112720) || true) && (f_1203_109219_109253(path))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 109212, 112720);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 109376, 109530) || true) && (f_1203_109380_109396(context))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 109376, 109530);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 109462, 109499);

                                        throw f_1203_109468_109498();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 109376, 109530);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 109644, 109670);

                                    string
                                    leafElement = path
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 109702, 109890) || true) && (navigationProvider != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 109702, 109890);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 109798, 109859);

                                        leafElement = f_1203_109812_109858(navigationProvider, path, context);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 109702, 109890);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 109922, 110062) || true) && (f_1203_109926_109959(leafElement))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 109922, 110062);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1203, 110025, 110031);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 109922, 110062);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 110094, 110155);

                                    f_1203_110094_110154(
                                                                s_tracer, "Pushing leaf element: {0}", leafElement);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 110187, 110254);

                                    f_1203_110187_110253(
                                                                s_pathResolutionTracer, "Leaf element: {0}", leafElement);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 110385, 110416);

                                    f_1203_110385_110415(
                                                                // Push the leaf element onto the leaf element stack for future use

                                                                leafElements, leafElement);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 110529, 112528) || true) && (navigationProvider != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 110529, 112528);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 110700, 110783);

                                        string
                                        newParentPath = f_1203_110723_110782(navigationProvider, path, f_1203_110762_110772(drive), context)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 110819, 112001) || true) && (f_1203_110823_111017(newParentPath, path, StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 110819, 112001);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 111548, 111905);

                                            PSInvalidOperationException
                                            invalidOperation =
                                            f_1203_111636_111904(f_1203_111725_111779(), f_1203_111826_111852(f_1203_111826_111847(provider)), path)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 111943, 111966);

                                            throw invalidOperation;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 110819, 112001);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 112037, 112058);

                                        path = newParentPath;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 110529, 112528);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 110529, 112528);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 112477, 112497);

                                        path = string.Empty;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 110529, 112528);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 112560, 112602);

                                    f_1203_112560_112601(
                                                                s_tracer, "New path: {0}", path);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 112634, 112693);

                                    f_1203_112634_112692(
                                                                s_pathResolutionTracer, "Parent path: {0}", path);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 109212, 112720);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 109212, 112720);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 109212, 112720);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 112748, 112801);

                            f_1203_112748_112800(
                                                    s_tracer, "Base container path: {0}", path);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 113072, 113986) || true) && (f_1203_113076_113094(leafElements) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 113072, 113986);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 113157, 113183);

                                string
                                leafElement = path
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 113215, 113797) || true) && (navigationProvider != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 113215, 113797);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 113311, 113372);

                                    leafElement = f_1203_113325_113371(navigationProvider, path, context);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 113408, 113616) || true) && (!f_1203_113413_113446(leafElement))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 113408, 113616);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 113520, 113581);

                                        path = f_1203_113527_113580(navigationProvider, path, null, context);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 113408, 113616);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 113215, 113797);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 113215, 113797);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 113746, 113766);

                                    path = string.Empty;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 113215, 113797);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 113829, 113860);

                                f_1203_113829_113859(
                                                            leafElements, leafElement);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 113892, 113959);

                                f_1203_113892_113958(
                                                            s_pathResolutionTracer, "Leaf element: {0}", leafElement);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 113072, 113986);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 114014, 114085);

                            f_1203_114014_114084(
                                                    s_pathResolutionTracer, "Root path of resolution: {0}", path);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 108824, 114108);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 114293, 114308);

                        f_1203_114293_114307(
                                            // Once the container path with no glob characters are found store it
                                            // so that it's children can be iterated over.

                                            dirs, path);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 114479, 118602) || true) && (f_1203_114486_114504(leafElements) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 114479, 118602);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 114619, 114761) || true) && (f_1203_114623_114639(context))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 114619, 114761);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 114697, 114734);

                                    throw f_1203_114703_114733();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 114619, 114761);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 114789, 114829);

                                string
                                leafElement = f_1203_114810_114828(leafElements)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 114857, 115104);

                                f_1203_114857_115103(leafElement != null, "I am only pushing strings onto this stack so I should be able " +
                                                            "to cast any Pop to a string without failure.");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 115132, 115468);

                                dirs =
                                f_1203_115168_115467(this, dirs, drive, leafElement, f_1203_115358_115376(leafElements) == 0, provider, context);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 115721, 118579) || true) && (f_1203_115725_115743(leafElements) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 115721, 118579);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 115805, 118552);
                                    using (f_1203_115812_115895(s_pathResolutionTracer, "Checking matches to ensure they are containers"))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 115961, 115975);

                                        int
                                        index = 0
                                        ;
                                        try
                                        {
                                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 116011, 118521) || true) && (index < f_1203_116026_116036(dirs))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 116011, 118521);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 116183, 116361) || true) && (f_1203_116187_116203(context))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 116183, 116361);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 116285, 116322);

                                                    throw f_1203_116291_116321();
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 116183, 116361);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 116401, 116504);

                                                string
                                                resolvedPath =
                                                f_1203_116464_116503(f_1203_116484_116495(dirs, index), drive)
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 116635, 118486) || true) && (navigationProvider != null && (DynAbs.Tracing.TraceSender.Expression_True(1203, 116639, 116863) && !f_1203_116711_116863(f_1203_116711_116733(_sessionState), resolvedPath, context)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 116635, 118486);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 117029, 117198);

                                                    f_1203_117029_117197(                                        // If not, remove it from the collection

                                                                                            s_tracer, "Removing {0} because it is not a container", f_1203_117185_117196(dirs, index));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 117242, 117314);

                                                    f_1203_117242_117313(
                                                                                            s_pathResolutionTracer, "{0} is not a container", f_1203_117301_117312(dirs, index));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 117356, 117377);

                                                    f_1203_117356_117376(dirs, index);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 116635, 118486);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 116635, 118486);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 117459, 118486) || true) && (navigationProvider == null)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 117459, 118486);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 117571, 118075);

                                                        f_1203_117571_118074(navigationProvider != null, "The path in the dirs should never be a container unless " +
                                                                                                    "the provider implements the NavigationCmdletProvider interface. If it " +
                                                                                                    "doesn't, there should be no more leafElements in the stack " +
                                                                                                    "when this check is done");
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 117459, 118486);
                                                    }

                                                    else

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 117459, 118486);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 118237, 118305);

                                                        f_1203_118237_118304(s_pathResolutionTracer, "{0} is a container", f_1203_118292_118303(dirs, index));
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 118439, 118447);

                                                        ++index;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 117459, 118486);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 116635, 118486);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 116011, 118521);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 116011, 118521);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 116011, 118521);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 115805, 118552);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 115721, 118579);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 114479, 118602);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 114479, 118602);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 114479, 118602);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 118626, 118860);

                        f_1203_118626_118859(dirs != null, "GenerateNewPathsWithGlobLeaf() should return the base path as an element " +
                                                "even if there are no globing characters");
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 118884, 119086);
                            foreach (string dir in f_1203_118907_118911_I(dirs))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 118884, 119086);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 118961, 119021);

                                f_1203_118961_119020(s_pathResolutionTracer, "RESOLVED PATH: {0}", dir);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 119047, 119063);

                                f_1203_119047_119062(result, dir);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 118884, 119086);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 203);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 203);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 119110, 119328);

                        f_1203_119110_119327(f_1203_119159_119169(dirs) == f_1203_119173_119185(result), "The result of copying the globed strings should be the same " +
                                                "as from the collection");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 108083, 121832);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 108083, 121832);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 119410, 119501);

                        string
                        unescapedPath = (DynAbs.Tracing.TraceSender.Conditional_F1(1203, 119433, 119466) || ((f_1203_119433_119466(context) && DynAbs.Tracing.TraceSender.Conditional_F2(1203, 119469, 119473)) || DynAbs.Tracing.TraceSender.Conditional_F3(1203, 119476, 119500))) ? path : f_1203_119476_119500(path)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 119525, 119600);

                        string
                        formatString = "{0}:" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (StringLiterals.DefaultPathSeparator).ToString(), 1203, 119556, 119591) + "{1}"
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 119693, 120331) || true) && (f_1203_119697_119709(drive))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 119693, 120331);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 119759, 120044) || true) && (f_1203_119763_119798(unescapedPath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 119759, 120044);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 119856, 119877);

                                formatString = "{1}";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 119759, 120044);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 119759, 120044);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 119991, 120017);

                                formatString = "{0}::{1}";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 119759, 120044);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 119693, 120331);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 119693, 120331);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 120142, 120308) || true) && (f_1203_120146_120198(path, StringLiterals.DefaultPathSeparator))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 120142, 120308);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 120256, 120281);

                                formatString = "{0}:{1}";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 120142, 120308);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 119693, 120331);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 120476, 120606) || true) && (f_1203_120480_120509_M(!drive.VolumeSeparatedByColon))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 120476, 120606);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 120559, 120583);

                            formatString = "{0}{1}";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 120476, 120606);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 120630, 120900);

                        string
                        resolvedPath =
                        f_1203_120677_120899(f_1203_120721_120770(), formatString, f_1203_120844_120854(drive), unescapedPath)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 121001, 121813) || true) && (allowNonexistingPaths || (DynAbs.Tracing.TraceSender.Expression_False(1203, 121005, 121123) || f_1203_121055_121123(provider, f_1203_121075_121113(this, resolvedPath, context), context)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 121001, 121813);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 121173, 121242);

                            f_1203_121173_121241(s_pathResolutionTracer, "RESOLVED PATH: {0}", resolvedPath);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 121268, 121293);

                            f_1203_121268_121292(result, resolvedPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 121001, 121813);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 121001, 121813);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 121391, 121647);

                            ItemNotFoundException
                            pathNotFound =
                            f_1203_121457_121646(resolvedPath, "PathNotFound", f_1203_121613_121645())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 121675, 121743);

                            f_1203_121675_121742(
                                                    s_pathResolutionTracer, "Item does not exist: {0}", path);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 121771, 121790);

                            throw pathNotFound;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 121001, 121813);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 108083, 121832);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 107986, 121847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 121863, 122018);

                f_1203_121863_122017(result != null, "This method should at least return the path or more if it has glob characters");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 122034, 122048);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 107073, 122059);

                System.Management.Automation.PSArgumentNullException
                f_1203_107389_107441(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 107389, 107441);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_107533_107589(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 107533, 107589);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_107678_107731(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 107678, 107731);
                    return return_v;
                }


                int
                f_1203_107763_107801(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 107763, 107801);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_107945_107969()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 107945, 107969);
                    return return_v;
                }


                System.IDisposable
                f_1203_107993_108049(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 107993, 108049);
                    return return_v;
                }


                bool
                f_1203_108087_108123(string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = ShouldPerformGlobbing(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 108087, 108123);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1203_108538_108556()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 108538, 108556);
                    return return_v;
                }


                System.Collections.Generic.Stack<string>
                f_1203_108780_108799()
                {
                    var return_v = new System.Collections.Generic.Stack<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 108780, 108799);
                    return return_v;
                }


                System.IDisposable
                f_1203_108831_108883(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 108831, 108883);
                    return return_v;
                }


                bool
                f_1203_109219_109253(string
                path)
                {
                    var return_v = StringContainsGlobCharacters(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 109219, 109253);
                    return return_v;
                }


                bool
                f_1203_109380_109396(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 109380, 109396);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_109468_109498()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 109468, 109498);
                    return return_v;
                }


                string
                f_1203_109812_109858(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetChildName(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 109812, 109858);
                    return return_v;
                }


                bool
                f_1203_109926_109959(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 109926, 109959);
                    return return_v;
                }


                int
                f_1203_110094_110154(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 110094, 110154);
                    return 0;
                }


                int
                f_1203_110187_110253(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 110187, 110253);
                    return 0;
                }


                int
                f_1203_110385_110415(System.Collections.Generic.Stack<string>
                this_param, string
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 110385, 110415);
                    return 0;
                }


                string
                f_1203_110762_110772(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 110762, 110772);
                    return return_v;
                }


                string
                f_1203_110723_110782(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetParentPath(path, root, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 110723, 110782);
                    return return_v;
                }


                bool
                f_1203_110823_111017(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 110823, 111017);
                    return return_v;
                }


                string
                f_1203_111725_111779()
                {
                    var return_v = SessionStateStrings.ProviderImplementationInconsistent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 111725, 111779);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_111826_111847(System.Management.Automation.Provider.ContainerCmdletProvider
                this_param)
                {
                    var return_v = this_param.ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 111826, 111847);
                    return return_v;
                }


                string
                f_1203_111826_111852(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 111826, 111852);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1203_111636_111904(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 111636, 111904);
                    return return_v;
                }


                int
                f_1203_112560_112601(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 112560, 112601);
                    return 0;
                }


                int
                f_1203_112634_112692(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 112634, 112692);
                    return 0;
                }


                int
                f_1203_112748_112800(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 112748, 112800);
                    return 0;
                }


                int
                f_1203_113076_113094(System.Collections.Generic.Stack<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 113076, 113094);
                    return return_v;
                }


                string
                f_1203_113325_113371(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetChildName(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 113325, 113371);
                    return return_v;
                }


                bool
                f_1203_113413_113446(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 113413, 113446);
                    return return_v;
                }


                string
                f_1203_113527_113580(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetParentPath(path, root, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 113527, 113580);
                    return return_v;
                }


                int
                f_1203_113829_113859(System.Collections.Generic.Stack<string>
                this_param, string
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 113829, 113859);
                    return 0;
                }


                int
                f_1203_113892_113958(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 113892, 113958);
                    return 0;
                }


                int
                f_1203_114014_114084(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 114014, 114084);
                    return 0;
                }


                int
                f_1203_114293_114307(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 114293, 114307);
                    return 0;
                }


                int
                f_1203_114486_114504(System.Collections.Generic.Stack<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 114486, 114504);
                    return return_v;
                }


                bool
                f_1203_114623_114639(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 114623, 114639);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_114703_114733()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 114703, 114733);
                    return return_v;
                }


                string
                f_1203_114810_114828(System.Collections.Generic.Stack<string>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 114810, 114828);
                    return return_v;
                }


                int
                f_1203_114857_115103(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 114857, 115103);
                    return 0;
                }


                int
                f_1203_115358_115376(System.Collections.Generic.Stack<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 115358, 115376);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1203_115168_115467(System.Management.Automation.LocationGlobber
                this_param, System.Collections.Generic.List<string>
                currentDirs, System.Management.Automation.PSDriveInfo
                drive, string
                leafElement, bool
                isLastLeaf, System.Management.Automation.Provider.ContainerCmdletProvider
                provider, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GenerateNewPSPathsWithGlobLeaf(currentDirs, drive, leafElement, isLastLeaf, provider, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 115168, 115467);
                    return return_v;
                }


                int
                f_1203_115725_115743(System.Collections.Generic.Stack<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 115725, 115743);
                    return return_v;
                }


                System.IDisposable
                f_1203_115812_115895(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 115812, 115895);
                    return return_v;
                }


                int
                f_1203_116026_116036(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 116026, 116036);
                    return return_v;
                }


                bool
                f_1203_116187_116203(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 116187, 116203);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_116291_116321()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 116291, 116321);
                    return return_v;
                }


                string
                f_1203_116484_116495(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 116484, 116495);
                    return return_v;
                }


                string
                f_1203_116464_116503(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = GetMshQualifiedPath(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 116464, 116503);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_116711_116733(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 116711, 116733);
                    return return_v;
                }


                bool
                f_1203_116711_116863(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.IsItemContainer(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 116711, 116863);
                    return return_v;
                }


                string
                f_1203_117185_117196(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 117185, 117196);
                    return return_v;
                }


                int
                f_1203_117029_117197(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 117029, 117197);
                    return 0;
                }


                string
                f_1203_117301_117312(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 117301, 117312);
                    return return_v;
                }


                int
                f_1203_117242_117313(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 117242, 117313);
                    return 0;
                }


                int
                f_1203_117356_117376(System.Collections.Generic.List<string>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 117356, 117376);
                    return 0;
                }


                int
                f_1203_117571_118074(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 117571, 118074);
                    return 0;
                }


                string
                f_1203_118292_118303(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 118292, 118303);
                    return return_v;
                }


                int
                f_1203_118237_118304(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 118237, 118304);
                    return 0;
                }


                int
                f_1203_118626_118859(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 118626, 118859);
                    return 0;
                }


                int
                f_1203_118961_119020(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 118961, 119020);
                    return 0;
                }


                int
                f_1203_119047_119062(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 119047, 119062);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1203_118907_118911_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 118907, 118911);
                    return return_v;
                }


                int
                f_1203_119159_119169(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 119159, 119169);
                    return return_v;
                }


                int
                f_1203_119173_119185(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 119173, 119185);
                    return return_v;
                }


                int
                f_1203_119110_119327(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 119110, 119327);
                    return 0;
                }


                bool
                f_1203_119433_119466(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.SuppressWildcardExpansion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 119433, 119466);
                    return return_v;
                }


                string
                f_1203_119476_119500(string
                path)
                {
                    var return_v = RemoveGlobEscaping(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 119476, 119500);
                    return return_v;
                }


                bool
                f_1203_119697_119709(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Hidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 119697, 119709);
                    return return_v;
                }


                bool
                f_1203_119763_119798(string
                path)
                {
                    var return_v = IsProviderDirectPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 119763, 119798);
                    return return_v;
                }


                bool
                f_1203_120146_120198(string
                this_param, char
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 120146, 120198);
                    return return_v;
                }


                bool
                f_1203_120480_120509_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 120480, 120509);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1203_120721_120770()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 120721, 120770);
                    return return_v;
                }


                string
                f_1203_120844_120854(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 120844, 120854);
                    return return_v;
                }


                string
                f_1203_120677_120899(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 120677, 120899);
                    return return_v;
                }


                string
                f_1203_121075_121113(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetProviderPath(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 121075, 121113);
                    return return_v;
                }


                bool
                f_1203_121055_121123(System.Management.Automation.Provider.ContainerCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ItemExists(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 121055, 121123);
                    return return_v;
                }


                int
                f_1203_121173_121241(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 121173, 121241);
                    return 0;
                }


                int
                f_1203_121268_121292(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 121268, 121292);
                    return 0;
                }


                string
                f_1203_121613_121645()
                {
                    var return_v = SessionStateStrings.PathNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 121613, 121645);
                    return return_v;
                }


                System.Management.Automation.ItemNotFoundException
                f_1203_121457_121646(string
                path, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.ItemNotFoundException(path, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 121457, 121646);
                    return return_v;
                }


                int
                f_1203_121675_121742(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 121675, 121742);
                    return 0;
                }


                int
                f_1203_121863_122017(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 121863, 122017);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 107073, 122059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 107073, 122059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetMshQualifiedPath(string path, PSDriveInfo drive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 122933, 123694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 123032, 123166);

                f_1203_123032_123165(drive != null, "The caller should verify drive before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 123182, 123203);

                string
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 123219, 123653) || true) && (f_1203_123223_123235(drive))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 123219, 123653);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 123269, 123528) || true) && (f_1203_123273_123315(path))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 123269, 123528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 123357, 123371);

                        result = path;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 123269, 123528);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 123269, 123528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 123453, 123509);

                        result = f_1203_123462_123508(path, f_1203_123493_123507(drive));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 123269, 123528);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 123219, 123653);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 123219, 123653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 123594, 123638);

                    result = f_1203_123603_123637(path, drive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 123219, 123653);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 123669, 123683);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 122933, 123694);

                int
                f_1203_123032_123165(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 123032, 123165);
                    return 0;
                }


                bool
                f_1203_123223_123235(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Hidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 123223, 123235);
                    return return_v;
                }


                bool
                f_1203_123273_123315(string
                path)
                {
                    var return_v = LocationGlobber.IsProviderDirectPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 123273, 123315);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_123493_123507(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 123493, 123507);
                    return return_v;
                }


                string
                f_1203_123462_123508(string
                path, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = GetProviderQualifiedPath(path, provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 123462, 123508);
                    return return_v;
                }


                string
                f_1203_123603_123637(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = GetDriveQualifiedPath(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 123603, 123637);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 122933, 123694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 122933, 123694);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string RemoveMshQualifier(string path, PSDriveInfo drive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 124229, 124909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 124327, 124461);

                f_1203_124327_124460(drive != null, "The caller should verify drive before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 124477, 124609);

                f_1203_124477_124608(path != null, "The caller should verify path before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 124625, 124646);

                string
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 124662, 124868) || true) && (f_1203_124666_124678(drive))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 124662, 124868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 124712, 124751);

                    result = f_1203_124721_124750(path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 124662, 124868);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 124662, 124868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 124817, 124853);

                    result = f_1203_124826_124852(path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 124662, 124868);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 124884, 124898);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 124229, 124909);

                int
                f_1203_124327_124460(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 124327, 124460);
                    return 0;
                }


                int
                f_1203_124477_124608(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 124477, 124608);
                    return 0;
                }


                bool
                f_1203_124666_124678(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Hidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 124666, 124678);
                    return return_v;
                }


                string
                f_1203_124721_124750(string
                path)
                {
                    var return_v = RemoveProviderQualifier(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 124721, 124750);
                    return return_v;
                }


                string
                f_1203_124826_124852(string
                path)
                {
                    var return_v = RemoveDriveQualifier(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 124826, 124852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 124229, 124909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 124229, 124909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetDriveQualifiedPath(string path, PSDriveInfo drive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 125616, 128611);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 125717, 125841) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 125717, 125841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 125767, 125826);

                    throw f_1203_125773_125825(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 125717, 125841);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 125857, 125983) || true) && (drive == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 125857, 125983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 125908, 125968);

                    throw f_1203_125914_125967(nameof(drive));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 125857, 125983);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 125999, 126020);

                string
                result = path
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 126034, 126062);

                bool
                treatAsRelative = true
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 126078, 127757) || true) && (f_1203_126082_126110(drive))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 126078, 127757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 126322, 126352);

                    int
                    index = f_1203_126334_126351(path, ':')
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 126372, 127567) || true) && (index != -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 126372, 127567);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 126429, 126911) || true) && (f_1203_126433_126445(drive))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 126429, 126911);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 126495, 126519);

                            treatAsRelative = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 126429, 126911);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 126429, 126911);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 126617, 126669);

                            string
                            possibleDriveName = f_1203_126644_126668(path, 0, index)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 126695, 126888) || true) && (f_1203_126699_126779(possibleDriveName, f_1203_126732_126742(drive), StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 126695, 126888);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 126837, 126861);

                                treatAsRelative = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 126695, 126888);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 126429, 126911);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 126372, 127567);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 126372, 127567);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 127291, 127548) || true) && (f_1203_127295_127306(path) > 1 && (DynAbs.Tracing.TraceSender.Expression_True(1203, 127295, 127451) && (f_1203_127315_127367(path, StringLiterals.DefaultPathSeparator) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 127315, 127450) || f_1203_127396_127450(path, StringLiterals.AlternatePathSeparator)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 127291, 127548);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 127501, 127525);

                            treatAsRelative = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 127291, 127548);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 126372, 127567);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 126078, 127757);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 126078, 127757);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 127633, 127742) || true) && (f_1203_127637_127657(path))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 127633, 127742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 127699, 127723);

                        treatAsRelative = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 127633, 127742);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 126078, 127757);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 127773, 128570) || true) && (treatAsRelative)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 127773, 128570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 127826, 127846);

                    string
                    formatString
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 127864, 128307) || true) && (f_1203_127868_127896(drive))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 127864, 128307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 127938, 128006);

                        formatString = "{0}:" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (StringLiterals.DefaultPathSeparator).ToString(), 1203, 127962, 127997) + "{1}";

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 128028, 128182) || true) && (f_1203_128032_128084(path, StringLiterals.DefaultPathSeparator))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 128028, 128182);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 128134, 128159);

                            formatString = "{0}:{1}";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 128028, 128182);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 127864, 128307);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 127864, 128307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 128264, 128288);

                        formatString = "{0}{1}";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 127864, 128307);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 128327, 128555);

                    result =
                    f_1203_128357_128554(f_1203_128397_128446(), formatString, f_1203_128512_128522(drive), path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 127773, 128570);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 128586, 128600);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 125616, 128611);

                System.Management.Automation.PSArgumentNullException
                f_1203_125773_125825(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 125773, 125825);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_125914_125967(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 125914, 125967);
                    return return_v;
                }


                bool
                f_1203_126082_126110(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.VolumeSeparatedByColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 126082, 126110);
                    return return_v;
                }


                int
                f_1203_126334_126351(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 126334, 126351);
                    return return_v;
                }


                bool
                f_1203_126433_126445(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Hidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 126433, 126445);
                    return return_v;
                }


                string
                f_1203_126644_126668(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 126644, 126668);
                    return return_v;
                }


                string
                f_1203_126732_126742(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 126732, 126742);
                    return return_v;
                }


                bool
                f_1203_126699_126779(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 126699, 126779);
                    return return_v;
                }


                int
                f_1203_127295_127306(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 127295, 127306);
                    return return_v;
                }


                bool
                f_1203_127315_127367(string
                this_param, char
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 127315, 127367);
                    return return_v;
                }


                bool
                f_1203_127396_127450(string
                this_param, char
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 127396, 127450);
                    return return_v;
                }


                bool
                f_1203_127637_127657(string
                path)
                {
                    var return_v = IsAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 127637, 127657);
                    return return_v;
                }


                bool
                f_1203_127868_127896(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.VolumeSeparatedByColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 127868, 127896);
                    return return_v;
                }


                bool
                f_1203_128032_128084(string
                this_param, char
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 128032, 128084);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1203_128397_128446()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 128397, 128446);
                    return return_v;
                }


                string
                f_1203_128512_128522(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 128512, 128522);
                    return return_v;
                }


                string
                f_1203_128357_128554(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 128357, 128554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 125616, 128611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 125616, 128611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string RemoveDriveQualifier(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 128955, 130081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 129035, 129136);

                f_1203_129035_129135(path != null, "Caller should verify path");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 129152, 129173);

                string
                result = path
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 129269, 129299);

                int
                index = f_1203_129281_129298(path, ':')
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 129313, 130040) || true) && (index != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 129313, 130040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 129362, 129438);

                    int
                    separator = f_1203_129378_129437(path, StringLiterals.DefaultPathSeparator, 0, index)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 129456, 129610) || true) && (separator == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 129456, 129610);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 129517, 129591);

                        separator = f_1203_129529_129590(path, StringLiterals.AlternatePathSeparator, 0, index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 129456, 129610);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 129630, 130025) || true) && (separator == -1 || (DynAbs.Tracing.TraceSender.Expression_False(1203, 129634, 129670) || index < separator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 129630, 130025);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 129788, 129947) || true) && (f_1203_129792_129807(path, index + 1) == '\\' || (DynAbs.Tracing.TraceSender.Expression_False(1203, 129792, 129866) || f_1203_129844_129859(path, index + 1) == '/'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 129788, 129947);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 129916, 129924);

                            ++index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 129788, 129947);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 129971, 130006);

                        result = f_1203_129980_130005(path, index + 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 129630, 130025);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 129313, 130040);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 130056, 130070);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 128955, 130081);

                int
                f_1203_129035_129135(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 129035, 129135);
                    return 0;
                }


                int
                f_1203_129281_129298(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 129281, 129298);
                    return return_v;
                }


                int
                f_1203_129378_129437(string
                this_param, char
                value, int
                startIndex, int
                count)
                {
                    var return_v = this_param.IndexOf(value, startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 129378, 129437);
                    return return_v;
                }


                int
                f_1203_129529_129590(string
                this_param, char
                value, int
                startIndex, int
                count)
                {
                    var return_v = this_param.IndexOf(value, startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 129529, 129590);
                    return return_v;
                }


                char
                f_1203_129792_129807(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 129792, 129807);
                    return return_v;
                }


                char
                f_1203_129844_129859(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 129844, 129859);
                    return return_v;
                }


                string
                f_1203_129980_130005(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 129980, 130005);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 128955, 130081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 128955, 130081);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetProviderQualifiedPath(string path, ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 130770, 132115);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 130878, 131002) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 130878, 131002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 130928, 130987);

                    throw f_1203_130934_130986(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 130878, 131002);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 131018, 131150) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 131018, 131150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 131072, 131135);

                    throw f_1203_131078_131134(nameof(provider));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 131018, 131150);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 131166, 131187);

                string
                result = path
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 131201, 131227);

                bool
                pathResolved = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 131316, 131390);

                int
                providerSeparatorIndex = f_1203_131345_131389(path, "::", StringComparison.Ordinal)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 131404, 131695) || true) && (providerSeparatorIndex != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 131404, 131695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 131470, 131538);

                    string
                    possibleProvider = f_1203_131496_131537(path, 0, providerSeparatorIndex)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 131558, 131680) || true) && (f_1203_131562_131599(provider, possibleProvider))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 131558, 131680);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 131641, 131661);

                        pathResolved = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 131558, 131680);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 131404, 131695);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 131711, 132074) || true) && (!pathResolved)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 131711, 132074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 131762, 132059);

                    result =
                    f_1203_131792_132058(f_1203_131832_131881(), "{0}{1}{2}", f_1203_131946_131963(provider), StringLiterals.ProviderPathSeparator, path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 131711, 132074);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 132090, 132104);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 130770, 132115);

                System.Management.Automation.PSArgumentNullException
                f_1203_130934_130986(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 130934, 130986);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_131078_131134(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 131078, 131134);
                    return return_v;
                }


                int
                f_1203_131345_131389(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 131345, 131389);
                    return return_v;
                }


                string
                f_1203_131496_131537(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 131496, 131537);
                    return return_v;
                }


                bool
                f_1203_131562_131599(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 131562, 131599);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1203_131832_131881()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 131832, 131881);
                    return return_v;
                }


                string
                f_1203_131946_131963(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 131946, 131963);
                    return return_v;
                }


                string
                f_1203_131792_132058(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 131792, 132058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 130770, 132115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 130770, 132115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string RemoveProviderQualifier(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 132471, 133081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 132555, 132656);

                f_1203_132555_132655(path != null, "Caller should verify path");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 132672, 132693);

                string
                result = path
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 132752, 132841);

                int
                index = f_1203_132764_132840(path, StringLiterals.ProviderPathSeparator, StringComparison.Ordinal)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 132857, 133040) || true) && (index != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 132857, 133040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 132948, 133025);

                    result = f_1203_132957_133024(path, index + f_1203_132980_133023(StringLiterals.ProviderPathSeparator));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 132857, 133040);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 133056, 133070);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 132471, 133081);

                int
                f_1203_132555_132655(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 132555, 132655);
                    return 0;
                }


                int
                f_1203_132764_132840(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 132764, 132840);
                    return return_v;
                }


                int
                f_1203_132980_133023(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 132980, 133023);
                    return return_v;
                }


                string
                f_1203_132957_133024(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 132957, 133024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 132471, 133081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 132471, 133081);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<string> GenerateNewPSPathsWithGlobLeaf(
                    List<string> currentDirs,
                    PSDriveInfo drive,
                    string leafElement,
                    bool isLastLeaf,
                    ContainerCmdletProvider provider,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 136363, 144000);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 136665, 136803) || true) && (currentDirs == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 136665, 136803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 136722, 136788);

                    throw f_1203_136728_136787(nameof(currentDirs));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 136665, 136803);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 136819, 136951) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 136819, 136951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 136873, 136936);

                    throw f_1203_136879_136935(nameof(provider));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 136819, 136951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 136967, 137050);

                NavigationCmdletProvider
                navigationProvider = provider as NavigationCmdletProvider
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 137066, 137108);

                List<string>
                newDirs = f_1203_137089_137107()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 137221, 143958) || true) && (!f_1203_137226_137259(leafElement) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 137225, 137321) && f_1203_137280_137321(leafElement)) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 137225, 137352) || isLastLeaf))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 137221, 143958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 137386, 137462);

                    string
                    regexEscapedLeafElement = f_1203_137419_137461(leafElement)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 137530, 137707);

                    WildcardPattern
                    stringMatcher =
                    f_1203_137583_137706(regexEscapedLeafElement, WildcardOptions.IgnoreCase)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 137778, 137989);

                    Collection<WildcardPattern>
                    includeMatcher =
                    f_1203_137844_137988(f_1203_137919_137934(context), WildcardOptions.IgnoreCase)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 138060, 138271);

                    Collection<WildcardPattern>
                    excludeMatcher =
                    f_1203_138126_138270(f_1203_138201_138216(context), WildcardOptions.IgnoreCase)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 138376, 141970);
                        foreach (string dir in f_1203_138399_138410_I(currentDirs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 138376, 141970);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 138452, 141951);
                            using (f_1203_138459_138542(s_pathResolutionTracer, "Expanding wildcards for items under '{0}'", dir))
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 138653, 138795) || true) && (f_1203_138657_138673(context))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 138653, 138795);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 138731, 138768);

                                    throw f_1203_138737_138767();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 138653, 138795);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 138903, 138948);

                                string
                                mshQualifiedParentPath = string.Empty
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 138974, 139424);

                                Collection<PSObject>
                                childNamesObjectArray =
                                f_1203_139048_139423(this, dir, leafElement, !isLastLeaf, context, false, drive, provider, out mshQualifiedParentPath)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 139452, 139773) || true) && (childNamesObjectArray == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 139452, 139773);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 139543, 139602);

                                    f_1203_139543_139601(s_tracer, "GetChildNames returned a null array");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 139632, 139707);

                                    f_1203_139632_139706(s_pathResolutionTracer, "No child names returned for '{0}'", dir);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 139737, 139746);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 139452, 139773);
                                }
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 139896, 141928);
                                    foreach (PSObject childObject in f_1203_139929_139950_I(childNamesObjectArray))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 139896, 141928);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 140073, 140227) || true) && (f_1203_140077_140093(context))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 140073, 140227);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 140159, 140196);

                                            throw f_1203_140165_140195();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 140073, 140227);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 140259, 140287);

                                        string
                                        child = string.Empty
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 140319, 141901) || true) && (f_1203_140323_140597(childObject, stringMatcher, includeMatcher, excludeMatcher, out child))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 140319, 141901);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 140663, 140688);

                                            string
                                            childPath = child
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 140724, 141135) || true) && (navigationProvider != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 140724, 141135);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 140828, 140898);

                                                string
                                                parentPath = f_1203_140848_140897(mshQualifiedParentPath, drive)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 140938, 141010);

                                                childPath = f_1203_140950_141009(f_1203_140950_140972(_sessionState), parentPath, child, context);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 141050, 141100);

                                                childPath = f_1203_141062_141099(childPath, drive);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 140724, 141135);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 141171, 141234);

                                            f_1203_141171_141233(
                                                                            s_tracer, "Adding child path to dirs {0}", childPath);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 141742, 141813);

                                            childPath = (DynAbs.Tracing.TraceSender.Conditional_F1(1203, 141754, 141764) || ((isLastLeaf && DynAbs.Tracing.TraceSender.Conditional_F2(1203, 141767, 141776)) || DynAbs.Tracing.TraceSender.Conditional_F3(1203, 141779, 141812))) ? childPath : f_1203_141779_141812(childPath);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 141847, 141870);

                                            f_1203_141847_141869(newDirs, childPath);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 140319, 141901);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 139896, 141928);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 2033);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 2033);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 138452, 141951);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 138376, 141970);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 3595);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 3595);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 137221, 143958);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 137221, 143958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 142036, 142146);

                    f_1203_142036_142145(s_tracer, "LeafElement does not contain any glob characters so do a MakePath");
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 142282, 143943);
                        foreach (string dir in f_1203_142305_142316_I(currentDirs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 142282, 143943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 142358, 143924);
                            using (f_1203_142365_142452(s_pathResolutionTracer, "Expanding intermediate containers under '{0}'", dir))
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 142563, 142705) || true) && (f_1203_142567_142583(context))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 142563, 142705);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 142641, 142678);

                                    throw f_1203_142647_142677();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 142563, 142705);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 142733, 142813);

                                string
                                backslashEscapedLeafElement = f_1203_142770_142812(leafElement)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 142841, 142929);

                                string
                                unescapedDir = (DynAbs.Tracing.TraceSender.Conditional_F1(1203, 142863, 142896) || ((f_1203_142863_142896(context) && DynAbs.Tracing.TraceSender.Conditional_F2(1203, 142899, 142902)) || DynAbs.Tracing.TraceSender.Conditional_F3(1203, 142905, 142928))) ? dir : f_1203_142905_142928(dir)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 142955, 143018);

                                string
                                resolvedPath = f_1203_142977_143017(unescapedDir, drive)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 143046, 143093);

                                string
                                childPath = backslashEscapedLeafElement
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 143121, 143502) || true) && (navigationProvider != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 143121, 143502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 143209, 143269);

                                    string
                                    parentPath = f_1203_143229_143268(resolvedPath, drive)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 143301, 143395);

                                    childPath = f_1203_143313_143394(f_1203_143313_143335(_sessionState), parentPath, backslashEscapedLeafElement, context);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 143425, 143475);

                                    childPath = f_1203_143437_143474(childPath, drive);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 143121, 143502);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 143530, 143901) || true) && (f_1203_143534_143587(f_1203_143534_143556(_sessionState), childPath, context))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 143530, 143901);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 143645, 143708);

                                    f_1203_143645_143707(s_tracer, "Adding child path to dirs {0}", childPath);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 143738, 143819);

                                    f_1203_143738_143818(s_pathResolutionTracer, "Valid intermediate container: {0}", childPath);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 143851, 143874);

                                    f_1203_143851_143873(
                                                                newDirs, childPath);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 143530, 143901);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 142358, 143924);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 142282, 143943);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 1662);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 1662);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 137221, 143958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 143974, 143989);

                return newDirs;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 136363, 144000);

                System.Management.Automation.PSArgumentNullException
                f_1203_136728_136787(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 136728, 136787);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_136879_136935(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 136879, 136935);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1203_137089_137107()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 137089, 137107);
                    return return_v;
                }


                bool
                f_1203_137226_137259(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 137226, 137259);
                    return return_v;
                }


                bool
                f_1203_137280_137321(string
                path)
                {
                    var return_v = StringContainsGlobCharacters(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 137280, 137321);
                    return return_v;
                }


                string
                f_1203_137419_137461(string
                path)
                {
                    var return_v = ConvertMshEscapeToRegexEscape(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 137419, 137461);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1203_137583_137706(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 137583, 137706);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_137919_137934(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Include;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 137919, 137934);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                f_1203_137844_137988(System.Collections.ObjectModel.Collection<string>
                globPatterns, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = SessionStateUtilities.CreateWildcardsFromStrings((System.Collections.Generic.IEnumerable<string>)globPatterns, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 137844, 137988);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_138201_138216(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Exclude;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 138201, 138216);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                f_1203_138126_138270(System.Collections.ObjectModel.Collection<string>
                globPatterns, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = SessionStateUtilities.CreateWildcardsFromStrings((System.Collections.Generic.IEnumerable<string>)globPatterns, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 138126, 138270);
                    return return_v;
                }


                System.IDisposable
                f_1203_138459_138542(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 138459, 138542);
                    return return_v;
                }


                bool
                f_1203_138657_138673(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 138657, 138673);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_138737_138767()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 138737, 138767);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1203_139048_139423(System.Management.Automation.LocationGlobber
                this_param, string
                dir, string
                leafElement, bool
                getAllContainers, System.Management.Automation.CmdletProviderContext
                context, bool
                dirIsProviderPath, System.Management.Automation.PSDriveInfo
                drive, System.Management.Automation.Provider.ContainerCmdletProvider
                provider, out string
                modifiedDirPath)
                {
                    var return_v = this_param.GetChildNamesInDir(dir, leafElement, getAllContainers, context, dirIsProviderPath, drive, provider, out modifiedDirPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 139048, 139423);
                    return return_v;
                }


                int
                f_1203_139543_139601(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 139543, 139601);
                    return 0;
                }


                int
                f_1203_139632_139706(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 139632, 139706);
                    return 0;
                }


                bool
                f_1203_140077_140093(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 140077, 140093);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_140165_140195()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 140165, 140195);
                    return return_v;
                }


                bool
                f_1203_140323_140597(System.Management.Automation.PSObject
                childObject, System.Management.Automation.WildcardPattern
                stringMatcher, System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                includeMatcher, System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                excludeMatcher, out string
                childName)
                {
                    var return_v = IsChildNameAMatch(childObject, stringMatcher, includeMatcher, excludeMatcher, out childName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 140323, 140597);
                    return return_v;
                }


                string
                f_1203_140848_140897(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = RemoveMshQualifier(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 140848, 140897);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_140950_140972(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 140950, 140972);
                    return return_v;
                }


                string
                f_1203_140950_141009(System.Management.Automation.SessionStateInternal
                this_param, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 140950, 141009);
                    return return_v;
                }


                string
                f_1203_141062_141099(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = GetMshQualifiedPath(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 141062, 141099);
                    return return_v;
                }


                int
                f_1203_141171_141233(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 141171, 141233);
                    return 0;
                }


                string
                f_1203_141779_141812(string
                pattern)
                {
                    var return_v = WildcardPattern.Escape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 141779, 141812);
                    return return_v;
                }


                int
                f_1203_141847_141869(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 141847, 141869);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1203_139929_139950_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 139929, 139950);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1203_138399_138410_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 138399, 138410);
                    return return_v;
                }


                int
                f_1203_142036_142145(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 142036, 142145);
                    return 0;
                }


                System.IDisposable
                f_1203_142365_142452(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 142365, 142452);
                    return return_v;
                }


                bool
                f_1203_142567_142583(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 142567, 142583);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_142647_142677()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 142647, 142677);
                    return return_v;
                }


                string
                f_1203_142770_142812(string
                path)
                {
                    var return_v = ConvertMshEscapeToRegexEscape(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 142770, 142812);
                    return return_v;
                }


                bool
                f_1203_142863_142896(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.SuppressWildcardExpansion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 142863, 142896);
                    return return_v;
                }


                string
                f_1203_142905_142928(string
                path)
                {
                    var return_v = RemoveGlobEscaping(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 142905, 142928);
                    return return_v;
                }


                string
                f_1203_142977_143017(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = GetMshQualifiedPath(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 142977, 143017);
                    return return_v;
                }


                string
                f_1203_143229_143268(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = RemoveMshQualifier(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 143229, 143268);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_143313_143335(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 143313, 143335);
                    return return_v;
                }


                string
                f_1203_143313_143394(System.Management.Automation.SessionStateInternal
                this_param, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 143313, 143394);
                    return return_v;
                }


                string
                f_1203_143437_143474(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = GetMshQualifiedPath(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 143437, 143474);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_143534_143556(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 143534, 143556);
                    return return_v;
                }


                bool
                f_1203_143534_143587(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ItemExists(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 143534, 143587);
                    return return_v;
                }


                int
                f_1203_143645_143707(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 143645, 143707);
                    return 0;
                }


                int
                f_1203_143738_143818(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 143738, 143818);
                    return 0;
                }


                int
                f_1203_143851_143873(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 143851, 143873);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1203_142305_142316_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 142305, 142316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 136363, 144000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 136363, 144000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<string> ExpandGlobPath(
                    string path,
                    bool allowNonexistingPaths,
                    ContainerCmdletProvider provider,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 147348, 162089);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 147574, 147698) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 147574, 147698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 147624, 147683);

                    throw f_1203_147630_147682(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 147574, 147698);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 147714, 147846) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 147714, 147846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 147768, 147831);

                    throw f_1203_147774_147830(nameof(provider));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 147714, 147846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 147935, 147963);

                string
                convertedPath = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 147977, 148007);

                string
                convertedFilter = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148021, 148060);

                string
                originalFilter = f_1203_148045_148059(context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148074, 148193);

                bool
                changedPathOrFilter = f_1203_148101_148192(provider, path, f_1203_148128_148142(context), ref convertedPath, ref convertedFilter, context)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148209, 148825) || true) && (changedPathOrFilter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 148209, 148825);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148266, 148719) || true) && (f_1203_148270_148288(s_tracer))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 148266, 148719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148330, 148388);

                        f_1203_148330_148387(s_tracer, "Provider converted path and filter.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148410, 148457);

                        f_1203_148410_148456(s_tracer, "Original path: {0}", path);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148479, 148536);

                        f_1203_148479_148535(s_tracer, "Converted path: {0}", convertedPath);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148558, 148617);

                        f_1203_148558_148616(s_tracer, "Original filter: {0}", f_1203_148601_148615(context));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148639, 148700);

                        f_1203_148639_148699(s_tracer, "Converted filter: {0}", convertedFilter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 148266, 148719);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148739, 148760);

                    path = convertedPath;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148778, 148810);

                    originalFilter = f_1203_148795_148809(context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 148209, 148825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148841, 148924);

                NavigationCmdletProvider
                navigationProvider = provider as NavigationCmdletProvider
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148940, 148979);

                f_1203_148940_148978(
                            s_tracer, "path = {0}", path);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 148995, 149048);

                Collection<string>
                result = f_1203_149023_149047()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 149064, 161757);
                using (f_1203_149071_149127(s_pathResolutionTracer, "EXPANDING WILDCARDS"))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 149161, 161742) || true) && (f_1203_149165_149201(path, context))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 149161, 161742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 149596, 149635);

                        List<string>
                        dirs = f_1203_149616_149634()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 149829, 149878);

                        Stack<string>
                        leafElements = f_1203_149858_149877()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 149902, 155715);
                        using (f_1203_149909_149961(s_pathResolutionTracer, "Tokenizing path"))
                        {
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 150290, 154329) || true) && (f_1203_150297_150331(path))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 150290, 154329);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 150454, 150608) || true) && (f_1203_150458_150474(context))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 150454, 150608);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 150540, 150577);

                                        throw f_1203_150546_150576();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 150454, 150608);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 150722, 150748);

                                    string
                                    leafElement = path
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 150780, 150968) || true) && (navigationProvider != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 150780, 150968);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 150876, 150937);

                                        leafElement = f_1203_150890_150936(navigationProvider, path, context);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 150780, 150968);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 151000, 151140) || true) && (f_1203_151004_151037(leafElement))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 151000, 151140);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1203, 151103, 151109);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 151000, 151140);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 151172, 151233);

                                    f_1203_151172_151232(
                                                                s_tracer, "Pushing leaf element: {0}", leafElement);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 151265, 151332);

                                    f_1203_151265_151331(
                                                                s_pathResolutionTracer, "Leaf element: {0}", leafElement);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 151463, 151494);

                                    f_1203_151463_151493(
                                                                // Push the leaf element onto the leaf element stack for future use

                                                                leafElements, leafElement);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 151607, 154139) || true) && (navigationProvider != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 151607, 154139);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 151785, 151812);

                                        string
                                        root = string.Empty
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 151848, 152206) || true) && (context != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 151848, 152206);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 151941, 151975);

                                            PSDriveInfo
                                            drive = f_1203_151961_151974(context)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 152015, 152171) || true) && (drive != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 152015, 152171);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 152114, 152132);

                                                root = f_1203_152121_152131(drive);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 152015, 152171);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 151848, 152206);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 152317, 152394);

                                        string
                                        newParentPath = f_1203_152340_152393(navigationProvider, path, root, context)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 152430, 153612) || true) && (f_1203_152434_152628(newParentPath, path, StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 152430, 153612);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 153159, 153516);

                                            PSInvalidOperationException
                                            invalidOperation =
                                            f_1203_153247_153515(f_1203_153336_153390(), f_1203_153437_153463(f_1203_153437_153458(provider)), path)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 153554, 153577);

                                            throw invalidOperation;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 152430, 153612);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 153648, 153669);

                                        path = newParentPath;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 151607, 154139);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 151607, 154139);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 154088, 154108);

                                        path = string.Empty;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 151607, 154139);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 154171, 154213);

                                    f_1203_154171_154212(
                                                                s_tracer, "New path: {0}", path);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 154243, 154302);

                                    f_1203_154243_154301(s_pathResolutionTracer, "Parent path: {0}", path);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 150290, 154329);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 150290, 154329);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 150290, 154329);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 154357, 154410);

                            f_1203_154357_154409(
                                                    s_tracer, "Base container path: {0}", path);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 154681, 155593) || true) && (f_1203_154685_154703(leafElements) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 154681, 155593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 154766, 154792);

                                string
                                leafElement = path
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 154824, 155406) || true) && (navigationProvider != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 154824, 155406);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 154920, 154981);

                                    leafElement = f_1203_154934_154980(navigationProvider, path, context);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 155017, 155225) || true) && (!f_1203_155022_155055(leafElement))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 155017, 155225);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 155129, 155190);

                                        path = f_1203_155136_155189(navigationProvider, path, null, context);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 155017, 155225);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 154824, 155406);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 154824, 155406);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 155355, 155375);

                                    path = string.Empty;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 154824, 155406);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 155438, 155469);

                                f_1203_155438_155468(
                                                            leafElements, leafElement);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 155499, 155566);

                                f_1203_155499_155565(s_pathResolutionTracer, "Leaf element: {0}", leafElement);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 154681, 155593);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 155621, 155692);

                            f_1203_155621_155691(
                                                    s_pathResolutionTracer, "Root path of resolution: {0}", path);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 149902, 155715);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 155898, 155913);

                        f_1203_155898_155912(                    // Once the container path with no glob characters are found store it
                                                                 // so that it's children can be iterated over.

                                            dirs, path);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 156086, 160019) || true) && (f_1203_156093_156111(leafElements) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 156086, 160019);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 156226, 156368) || true) && (f_1203_156230_156246(context))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 156226, 156368);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 156304, 156341);

                                    throw f_1203_156310_156340();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 156226, 156368);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 156396, 156436);

                                string
                                leafElement = f_1203_156417_156435(leafElements)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 156464, 156711);

                                f_1203_156464_156710(leafElement != null, "I am only pushing strings onto this stack so I should be able " +
                                                            "to cast any Pop to a string without failure.");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 156739, 157033);

                                dirs =
                                f_1203_156775_157032(this, dirs, leafElement, f_1203_156923_156941(leafElements) == 0, provider, context);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 157286, 159996) || true) && (f_1203_157290_157308(leafElements) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 157286, 159996);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 157370, 159969);
                                    using (f_1203_157377_157460(s_pathResolutionTracer, "Checking matches to ensure they are containers"))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 157526, 157540);

                                        int
                                        index = 0
                                        ;
                                        try
                                        {
                                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 157576, 159938) || true) && (index < f_1203_157591_157601(dirs))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 157576, 159938);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 157748, 157926) || true) && (f_1203_157752_157768(context))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 157748, 157926);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 157850, 157887);

                                                    throw f_1203_157856_157886();
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 157748, 157926);
                                                }

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 158057, 159903) || true) && (navigationProvider != null && (DynAbs.Tracing.TraceSender.Expression_True(1203, 158061, 158280) && !f_1203_158133_158280(navigationProvider, f_1203_158214_158225(dirs, index), context)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 158057, 159903);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 158446, 158615);

                                                    f_1203_158446_158614(                                        // If not, remove it from the collection

                                                                                            s_tracer, "Removing {0} because it is not a container", f_1203_158602_158613(dirs, index));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 158659, 158731);

                                                    f_1203_158659_158730(
                                                                                            s_pathResolutionTracer, "{0} is not a container", f_1203_158718_158729(dirs, index));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 158773, 158794);

                                                    f_1203_158773_158793(dirs, index);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 158057, 159903);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 158057, 159903);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 158876, 159903) || true) && (navigationProvider == null)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 158876, 159903);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 158988, 159492);

                                                        f_1203_158988_159491(navigationProvider != null, "The path in the dirs should never be a container unless " +
                                                                                                    "the provider implements the NavigationCmdletProvider interface. If it " +
                                                                                                    "doesn't, there should be no more leafElements in the stack " +
                                                                                                    "when this check is done");
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 158876, 159903);
                                                    }

                                                    else

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 158876, 159903);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 159654, 159722);

                                                        f_1203_159654_159721(s_pathResolutionTracer, "{0} is a container", f_1203_159709_159720(dirs, index));
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 159856, 159864);

                                                        ++index;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 158876, 159903);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 158057, 159903);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 157576, 159938);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 157576, 159938);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 157576, 159938);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 157370, 159969);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 157286, 159996);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 156086, 160019);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 156086, 160019);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 156086, 160019);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 160043, 160277);

                        f_1203_160043_160276(dirs != null, "GenerateNewPathsWithGlobLeaf() should return the base path as an element " +
                                                "even if there are no globing characters");
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 160301, 160503);
                            foreach (string dir in f_1203_160324_160328_I(dirs))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 160301, 160503);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 160378, 160438);

                                f_1203_160378_160437(s_pathResolutionTracer, "RESOLVED PATH: {0}", dir);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 160464, 160480);

                                f_1203_160464_160479(result, dir);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 160301, 160503);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 203);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 203);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 160527, 160745);

                        f_1203_160527_160744(f_1203_160576_160586(dirs) == f_1203_160590_160602(result), "The result of copying the globed strings should be the same " +
                                                "as from the collection");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 149161, 161742);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 149161, 161742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 160827, 160918);

                        string
                        unescapedPath = (DynAbs.Tracing.TraceSender.Conditional_F1(1203, 160850, 160883) || ((f_1203_160850_160883(context) && DynAbs.Tracing.TraceSender.Conditional_F2(1203, 160886, 160890)) || DynAbs.Tracing.TraceSender.Conditional_F3(1203, 160893, 160917))) ? path : f_1203_160893_160917(path)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 160942, 161723) || true) && (allowNonexistingPaths || (DynAbs.Tracing.TraceSender.Expression_False(1203, 160946, 161039) || f_1203_160996_161039(provider, unescapedPath, context)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 160942, 161723);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 161089, 161159);

                            f_1203_161089_161158(s_pathResolutionTracer, "RESOLVED PATH: {0}", unescapedPath);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 161185, 161211);

                            f_1203_161185_161210(result, unescapedPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 160942, 161723);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 160942, 161723);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 161309, 161557);

                            ItemNotFoundException
                            pathNotFound =
                            f_1203_161375_161556(path, "PathNotFound", f_1203_161523_161555())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 161585, 161653);

                            f_1203_161585_161652(
                                                    s_pathResolutionTracer, "Item does not exist: {0}", path);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 161681, 161700);

                            throw pathNotFound;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 160942, 161723);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 149161, 161742);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 149064, 161757);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 161773, 161928);

                f_1203_161773_161927(result != null, "This method should at least return the path or more if it has glob characters");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 161944, 162048) || true) && (changedPathOrFilter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 161944, 162048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 162001, 162033);

                    context.Filter = originalFilter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 161944, 162048);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 162064, 162078);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 147348, 162089);

                System.Management.Automation.PSArgumentNullException
                f_1203_147630_147682(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 147630, 147682);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_147774_147830(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 147774, 147830);
                    return return_v;
                }


                string
                f_1203_148045_148059(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 148045, 148059);
                    return return_v;
                }


                string
                f_1203_148128_148142(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 148128, 148142);
                    return return_v;
                }


                bool
                f_1203_148101_148192(System.Management.Automation.Provider.ContainerCmdletProvider
                this_param, string
                path, string
                filter, ref string
                updatedPath, ref string
                updatedFilter, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ConvertPath(path, filter, ref updatedPath, ref updatedFilter, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 148101, 148192);
                    return return_v;
                }


                bool
                f_1203_148270_148288(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.IsEnabled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 148270, 148288);
                    return return_v;
                }


                int
                f_1203_148330_148387(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 148330, 148387);
                    return 0;
                }


                int
                f_1203_148410_148456(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 148410, 148456);
                    return 0;
                }


                int
                f_1203_148479_148535(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 148479, 148535);
                    return 0;
                }


                string
                f_1203_148601_148615(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 148601, 148615);
                    return return_v;
                }


                int
                f_1203_148558_148616(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 148558, 148616);
                    return 0;
                }


                int
                f_1203_148639_148699(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 148639, 148699);
                    return 0;
                }


                string
                f_1203_148795_148809(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 148795, 148809);
                    return return_v;
                }


                int
                f_1203_148940_148978(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 148940, 148978);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_149023_149047()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 149023, 149047);
                    return return_v;
                }


                System.IDisposable
                f_1203_149071_149127(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 149071, 149127);
                    return return_v;
                }


                bool
                f_1203_149165_149201(string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = ShouldPerformGlobbing(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 149165, 149201);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1203_149616_149634()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 149616, 149634);
                    return return_v;
                }


                System.Collections.Generic.Stack<string>
                f_1203_149858_149877()
                {
                    var return_v = new System.Collections.Generic.Stack<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 149858, 149877);
                    return return_v;
                }


                System.IDisposable
                f_1203_149909_149961(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 149909, 149961);
                    return return_v;
                }


                bool
                f_1203_150297_150331(string
                path)
                {
                    var return_v = StringContainsGlobCharacters(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 150297, 150331);
                    return return_v;
                }


                bool
                f_1203_150458_150474(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 150458, 150474);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_150546_150576()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 150546, 150576);
                    return return_v;
                }


                string
                f_1203_150890_150936(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetChildName(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 150890, 150936);
                    return return_v;
                }


                bool
                f_1203_151004_151037(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 151004, 151037);
                    return return_v;
                }


                int
                f_1203_151172_151232(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 151172, 151232);
                    return 0;
                }


                int
                f_1203_151265_151331(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 151265, 151331);
                    return 0;
                }


                int
                f_1203_151463_151493(System.Collections.Generic.Stack<string>
                this_param, string
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 151463, 151493);
                    return 0;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_151961_151974(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 151961, 151974);
                    return return_v;
                }


                string
                f_1203_152121_152131(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 152121, 152131);
                    return return_v;
                }


                string
                f_1203_152340_152393(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetParentPath(path, root, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 152340, 152393);
                    return return_v;
                }


                bool
                f_1203_152434_152628(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 152434, 152628);
                    return return_v;
                }


                string
                f_1203_153336_153390()
                {
                    var return_v = SessionStateStrings.ProviderImplementationInconsistent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 153336, 153390);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_153437_153458(System.Management.Automation.Provider.ContainerCmdletProvider
                this_param)
                {
                    var return_v = this_param.ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 153437, 153458);
                    return return_v;
                }


                string
                f_1203_153437_153463(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 153437, 153463);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1203_153247_153515(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 153247, 153515);
                    return return_v;
                }


                int
                f_1203_154171_154212(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 154171, 154212);
                    return 0;
                }


                int
                f_1203_154243_154301(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 154243, 154301);
                    return 0;
                }


                int
                f_1203_154357_154409(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 154357, 154409);
                    return 0;
                }


                int
                f_1203_154685_154703(System.Collections.Generic.Stack<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 154685, 154703);
                    return return_v;
                }


                string
                f_1203_154934_154980(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetChildName(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 154934, 154980);
                    return return_v;
                }


                bool
                f_1203_155022_155055(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 155022, 155055);
                    return return_v;
                }


                string
                f_1203_155136_155189(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetParentPath(path, root, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 155136, 155189);
                    return return_v;
                }


                int
                f_1203_155438_155468(System.Collections.Generic.Stack<string>
                this_param, string
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 155438, 155468);
                    return 0;
                }


                int
                f_1203_155499_155565(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 155499, 155565);
                    return 0;
                }


                int
                f_1203_155621_155691(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 155621, 155691);
                    return 0;
                }


                int
                f_1203_155898_155912(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 155898, 155912);
                    return 0;
                }


                int
                f_1203_156093_156111(System.Collections.Generic.Stack<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 156093, 156111);
                    return return_v;
                }


                bool
                f_1203_156230_156246(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 156230, 156246);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_156310_156340()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 156310, 156340);
                    return return_v;
                }


                string
                f_1203_156417_156435(System.Collections.Generic.Stack<string>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 156417, 156435);
                    return return_v;
                }


                int
                f_1203_156464_156710(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 156464, 156710);
                    return 0;
                }


                int
                f_1203_156923_156941(System.Collections.Generic.Stack<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 156923, 156941);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1203_156775_157032(System.Management.Automation.LocationGlobber
                this_param, System.Collections.Generic.List<string>
                currentDirs, string
                leafElement, bool
                isLastLeaf, System.Management.Automation.Provider.ContainerCmdletProvider
                provider, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GenerateNewPathsWithGlobLeaf(currentDirs, leafElement, isLastLeaf, provider, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 156775, 157032);
                    return return_v;
                }


                int
                f_1203_157290_157308(System.Collections.Generic.Stack<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 157290, 157308);
                    return return_v;
                }


                System.IDisposable
                f_1203_157377_157460(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 157377, 157460);
                    return return_v;
                }


                int
                f_1203_157591_157601(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 157591, 157601);
                    return return_v;
                }


                bool
                f_1203_157752_157768(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 157752, 157768);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_157856_157886()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 157856, 157886);
                    return return_v;
                }


                string
                f_1203_158214_158225(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 158214, 158225);
                    return return_v;
                }


                bool
                f_1203_158133_158280(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.IsItemContainer(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 158133, 158280);
                    return return_v;
                }


                string
                f_1203_158602_158613(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 158602, 158613);
                    return return_v;
                }


                int
                f_1203_158446_158614(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 158446, 158614);
                    return 0;
                }


                string
                f_1203_158718_158729(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 158718, 158729);
                    return return_v;
                }


                int
                f_1203_158659_158730(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 158659, 158730);
                    return 0;
                }


                int
                f_1203_158773_158793(System.Collections.Generic.List<string>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 158773, 158793);
                    return 0;
                }


                int
                f_1203_158988_159491(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 158988, 159491);
                    return 0;
                }


                string
                f_1203_159709_159720(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 159709, 159720);
                    return return_v;
                }


                int
                f_1203_159654_159721(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 159654, 159721);
                    return 0;
                }


                int
                f_1203_160043_160276(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 160043, 160276);
                    return 0;
                }


                int
                f_1203_160378_160437(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 160378, 160437);
                    return 0;
                }


                int
                f_1203_160464_160479(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 160464, 160479);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1203_160324_160328_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 160324, 160328);
                    return return_v;
                }


                int
                f_1203_160576_160586(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 160576, 160586);
                    return return_v;
                }


                int
                f_1203_160590_160602(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 160590, 160602);
                    return return_v;
                }


                int
                f_1203_160527_160744(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 160527, 160744);
                    return 0;
                }


                bool
                f_1203_160850_160883(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.SuppressWildcardExpansion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 160850, 160883);
                    return return_v;
                }


                string
                f_1203_160893_160917(string
                path)
                {
                    var return_v = RemoveGlobEscaping(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 160893, 160917);
                    return return_v;
                }


                bool
                f_1203_160996_161039(System.Management.Automation.Provider.ContainerCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ItemExists(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 160996, 161039);
                    return return_v;
                }


                int
                f_1203_161089_161158(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 161089, 161158);
                    return 0;
                }


                int
                f_1203_161185_161210(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 161185, 161210);
                    return 0;
                }


                string
                f_1203_161523_161555()
                {
                    var return_v = SessionStateStrings.PathNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 161523, 161555);
                    return return_v;
                }


                System.Management.Automation.ItemNotFoundException
                f_1203_161375_161556(string
                path, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.ItemNotFoundException(path, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 161375, 161556);
                    return return_v;
                }


                int
                f_1203_161585_161652(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 161585, 161652);
                    return 0;
                }


                int
                f_1203_161773_161927(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 161773, 161927);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 147348, 162089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 147348, 162089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<string> GenerateNewPathsWithGlobLeaf(
                    List<string> currentDirs,
                    string leafElement,
                    bool isLastLeaf,
                    ContainerCmdletProvider provider,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 164739, 170928);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 165008, 165146) || true) && (currentDirs == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 165008, 165146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 165065, 165131);

                    throw f_1203_165071_165130(nameof(currentDirs));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 165008, 165146);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 165162, 165294) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 165162, 165294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 165216, 165279);

                    throw f_1203_165222_165278(nameof(provider));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 165162, 165294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 165310, 165393);

                NavigationCmdletProvider
                navigationProvider = provider as NavigationCmdletProvider
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 165409, 165451);

                List<string>
                newDirs = f_1203_165432_165450()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 165564, 170886) || true) && (!f_1203_165569_165602(leafElement) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 165568, 165698) && (f_1203_165624_165665(leafElement) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 165624, 165697) || isLastLeaf))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 165564, 170886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 165732, 165808);

                    string
                    regexEscapedLeafElement = f_1203_165765_165807(leafElement)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 165876, 166053);

                    WildcardPattern
                    stringMatcher =
                    f_1203_165929_166052(regexEscapedLeafElement, WildcardOptions.IgnoreCase)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 166124, 166335);

                    Collection<WildcardPattern>
                    includeMatcher =
                    f_1203_166190_166334(f_1203_166265_166280(context), WildcardOptions.IgnoreCase)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 166406, 166617);

                    Collection<WildcardPattern>
                    excludeMatcher =
                    f_1203_166472_166616(f_1203_166547_166562(context), WildcardOptions.IgnoreCase)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 166722, 168978);
                        foreach (string dir in f_1203_166745_166756_I(currentDirs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 166722, 168978);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 166798, 168959);
                            using (f_1203_166805_166888(s_pathResolutionTracer, "Expanding wildcards for items under '{0}'", dir))
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 166999, 167141) || true) && (f_1203_167003_167019(context))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 166999, 167141);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 167077, 167114);

                                    throw f_1203_167083_167113();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 166999, 167141);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 167169, 167196);

                                string
                                unescapedDir = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 167224, 167397);

                                Collection<PSObject>
                                childNamesObjectArray =
                                f_1203_167298_167396(this, dir, leafElement, !isLastLeaf, context, true, null, provider, out unescapedDir)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 167425, 167748) || true) && (childNamesObjectArray == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 167425, 167748);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 167516, 167575);

                                    f_1203_167516_167574(s_tracer, "GetChildNames returned a null array");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 167607, 167682);

                                    f_1203_167607_167681(
                                                                s_pathResolutionTracer, "No child names returned for '{0}'", dir);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 167712, 167721);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 167425, 167748);
                                }
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 167871, 168936);
                                    foreach (PSObject childObject in f_1203_167904_167925_I(childNamesObjectArray))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 167871, 168936);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 168048, 168202) || true) && (f_1203_168052_168068(context))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 168048, 168202);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 168134, 168171);

                                            throw f_1203_168140_168170();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 168048, 168202);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 168234, 168262);

                                        string
                                        child = string.Empty
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 168292, 168909) || true) && (f_1203_168296_168384(childObject, stringMatcher, includeMatcher, excludeMatcher, out child))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 168292, 168909);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 168450, 168475);

                                            string
                                            childPath = child
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 168511, 168720) || true) && (navigationProvider != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 168511, 168720);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 168615, 168685);

                                                childPath = f_1203_168627_168684(navigationProvider, unescapedDir, child, context);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 168511, 168720);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 168756, 168819);

                                            f_1203_168756_168818(
                                                                            s_tracer, "Adding child path to dirs {0}", childPath);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 168855, 168878);

                                            f_1203_168855_168877(
                                                                            newDirs, childPath);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 168292, 168909);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 167871, 168936);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 1066);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 1066);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 166798, 168959);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 166722, 168978);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 2257);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 2257);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 165564, 170886);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 165564, 170886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 169044, 169154);

                    f_1203_169044_169153(s_tracer, "LeafElement does not contain any glob characters so do a MakePath");
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 169290, 170871);
                        foreach (string dir in f_1203_169313_169324_I(currentDirs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 169290, 170871);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 169366, 170852);
                            using (f_1203_169373_169460(s_pathResolutionTracer, "Expanding intermediate containers under '{0}'", dir))
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 169571, 169713) || true) && (f_1203_169575_169591(context))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 169571, 169713);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 169649, 169686);

                                    throw f_1203_169655_169685();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 169571, 169713);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 169741, 169821);

                                string
                                backslashEscapedLeafElement = f_1203_169778_169820(leafElement)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 169849, 169937);

                                string
                                unescapedDir = (DynAbs.Tracing.TraceSender.Conditional_F1(1203, 169871, 169904) || ((f_1203_169871_169904(context) && DynAbs.Tracing.TraceSender.Conditional_F2(1203, 169907, 169910)) || DynAbs.Tracing.TraceSender.Conditional_F3(1203, 169913, 169936))) ? dir : f_1203_169913_169936(dir)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 169965, 170012);

                                string
                                childPath = backslashEscapedLeafElement
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 170040, 170442) || true) && (navigationProvider != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 170040, 170442);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 170128, 170415);

                                    childPath =
                                    f_1203_170173_170414(navigationProvider, unescapedDir, backslashEscapedLeafElement, context);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 170040, 170442);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 170470, 170829) || true) && (f_1203_170474_170513(provider, childPath, context))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 170470, 170829);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 170571, 170634);

                                    f_1203_170571_170633(s_tracer, "Adding child path to dirs {0}", childPath);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 170666, 170689);

                                    f_1203_170666_170688(
                                                                newDirs, childPath);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 170721, 170802);

                                    f_1203_170721_170801(
                                                                s_pathResolutionTracer, "Valid intermediate container: {0}", childPath);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 170470, 170829);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitUsing(1203, 169366, 170852);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 169290, 170871);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 1582);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 1582);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 165564, 170886);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 170902, 170917);

                return newDirs;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 164739, 170928);

                System.Management.Automation.PSArgumentNullException
                f_1203_165071_165130(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 165071, 165130);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1203_165222_165278(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 165222, 165278);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1203_165432_165450()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 165432, 165450);
                    return return_v;
                }


                bool
                f_1203_165569_165602(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 165569, 165602);
                    return return_v;
                }


                bool
                f_1203_165624_165665(string
                path)
                {
                    var return_v = StringContainsGlobCharacters(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 165624, 165665);
                    return return_v;
                }


                string
                f_1203_165765_165807(string
                path)
                {
                    var return_v = ConvertMshEscapeToRegexEscape(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 165765, 165807);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1203_165929_166052(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 165929, 166052);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_166265_166280(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Include;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 166265, 166280);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                f_1203_166190_166334(System.Collections.ObjectModel.Collection<string>
                globPatterns, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = SessionStateUtilities.CreateWildcardsFromStrings((System.Collections.Generic.IEnumerable<string>)globPatterns, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 166190, 166334);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_166547_166562(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Exclude;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 166547, 166562);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                f_1203_166472_166616(System.Collections.ObjectModel.Collection<string>
                globPatterns, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = SessionStateUtilities.CreateWildcardsFromStrings((System.Collections.Generic.IEnumerable<string>)globPatterns, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 166472, 166616);
                    return return_v;
                }


                System.IDisposable
                f_1203_166805_166888(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 166805, 166888);
                    return return_v;
                }


                bool
                f_1203_167003_167019(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 167003, 167019);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_167083_167113()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 167083, 167113);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1203_167298_167396(System.Management.Automation.LocationGlobber
                this_param, string
                dir, string
                leafElement, bool
                getAllContainers, System.Management.Automation.CmdletProviderContext
                context, bool
                dirIsProviderPath, System.Management.Automation.PSDriveInfo
                drive, System.Management.Automation.Provider.ContainerCmdletProvider
                provider, out string
                modifiedDirPath)
                {
                    var return_v = this_param.GetChildNamesInDir(dir, leafElement, getAllContainers, context, dirIsProviderPath, drive, provider, out modifiedDirPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 167298, 167396);
                    return return_v;
                }


                int
                f_1203_167516_167574(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 167516, 167574);
                    return 0;
                }


                int
                f_1203_167607_167681(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 167607, 167681);
                    return 0;
                }


                bool
                f_1203_168052_168068(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 168052, 168068);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_168140_168170()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 168140, 168170);
                    return return_v;
                }


                bool
                f_1203_168296_168384(System.Management.Automation.PSObject
                childObject, System.Management.Automation.WildcardPattern
                stringMatcher, System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                includeMatcher, System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                excludeMatcher, out string
                childName)
                {
                    var return_v = IsChildNameAMatch(childObject, stringMatcher, includeMatcher, excludeMatcher, out childName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 168296, 168384);
                    return return_v;
                }


                string
                f_1203_168627_168684(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 168627, 168684);
                    return return_v;
                }


                int
                f_1203_168756_168818(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 168756, 168818);
                    return 0;
                }


                int
                f_1203_168855_168877(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 168855, 168877);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1203_167904_167925_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 167904, 167925);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1203_166745_166756_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 166745, 166756);
                    return return_v;
                }


                int
                f_1203_169044_169153(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 169044, 169153);
                    return 0;
                }


                System.IDisposable
                f_1203_169373_169460(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 169373, 169460);
                    return return_v;
                }


                bool
                f_1203_169575_169591(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 169575, 169591);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1203_169655_169685()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 169655, 169685);
                    return return_v;
                }


                string
                f_1203_169778_169820(string
                path)
                {
                    var return_v = ConvertMshEscapeToRegexEscape(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 169778, 169820);
                    return return_v;
                }


                bool
                f_1203_169871_169904(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.SuppressWildcardExpansion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 169871, 169904);
                    return return_v;
                }


                string
                f_1203_169913_169936(string
                path)
                {
                    var return_v = RemoveGlobEscaping(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 169913, 169936);
                    return return_v;
                }


                string
                f_1203_170173_170414(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 170173, 170414);
                    return return_v;
                }


                bool
                f_1203_170474_170513(System.Management.Automation.Provider.ContainerCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ItemExists(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 170474, 170513);
                    return return_v;
                }


                int
                f_1203_170571_170633(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 170571, 170633);
                    return 0;
                }


                int
                f_1203_170666_170688(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 170666, 170688);
                    return 0;
                }


                int
                f_1203_170721_170801(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 170721, 170801);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1203_169313_169324_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 169313, 169324);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 164739, 170928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 164739, 170928);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Collection<PSObject> GetChildNamesInDir(
                    string dir,
                    string leafElement,
                    bool getAllContainers,
                    CmdletProviderContext context,
                    bool dirIsProviderPath,
                    PSDriveInfo drive,
                    ContainerCmdletProvider provider,
                    out string modifiedDirPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 174528, 180568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 174969, 174997);

                string
                convertedPath = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175011, 175041);

                string
                convertedFilter = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175055, 175094);

                string
                originalFilter = f_1203_175079_175093(context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175108, 175234);

                bool
                changedPathOrFilter = f_1203_175135_175233(provider, leafElement, f_1203_175169_175183(context), ref convertedPath, ref convertedFilter, context)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175250, 175881) || true) && (changedPathOrFilter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 175250, 175881);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175307, 175767) || true) && (f_1203_175311_175329(s_tracer))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 175307, 175767);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175371, 175429);

                        f_1203_175371_175428(s_tracer, "Provider converted path and filter.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175451, 175505);

                        f_1203_175451_175504(s_tracer, "Original path: {0}", leafElement);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175527, 175584);

                        f_1203_175527_175583(s_tracer, "Converted path: {0}", convertedPath);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175606, 175665);

                        f_1203_175606_175664(s_tracer, "Original filter: {0}", f_1203_175649_175663(context));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175687, 175748);

                        f_1203_175687_175747(s_tracer, "Converted filter: {0}", convertedFilter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 175307, 175767);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175787, 175815);

                    leafElement = convertedPath;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175833, 175866);

                    context.Filter = convertedFilter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 175250, 175881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175897, 175970);

                ReturnContainers
                returnContainers = ReturnContainers.ReturnAllContainers
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 175984, 176115) || true) && (!getAllContainers)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 175984, 176115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 176039, 176100);

                    returnContainers = ReturnContainers.ReturnMatchingContainers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 175984, 176115);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 176131, 176228);

                CmdletProviderContext
                getChildNamesContext =
                f_1203_176193_176227(context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 176316, 176468);

                f_1203_176316_176467(
                            // Remove the include/exclude filters from the new context
                            getChildNamesContext, f_1203_176366_176390(), f_1203_176409_176433(), f_1203_176452_176466(context));

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 176577, 176604);

                    string
                    unescapedDir = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 176622, 176645);

                    modifiedDirPath = null;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 176665, 179185) || true) && (dirIsProviderPath)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 176665, 179185);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 176728, 176827);

                        modifiedDirPath = unescapedDir = (DynAbs.Tracing.TraceSender.Conditional_F1(1203, 176761, 176794) || ((f_1203_176761_176794(context) && DynAbs.Tracing.TraceSender.Conditional_F2(1203, 176797, 176800)) || DynAbs.Tracing.TraceSender.Conditional_F3(1203, 176803, 176826))) ? dir : f_1203_176803_176826(dir);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 176665, 179185);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 176665, 179185);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 176909, 177077);

                        f_1203_176909_177076(drive != null, "Caller should verify that drive is not null when dirIsProviderPath is false");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 177582, 177632);

                        modifiedDirPath = f_1203_177600_177631(dir, drive);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 177656, 177692);

                        ProviderInfo
                        providerIgnored = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 177714, 177760);

                        CmdletProvider
                        providerInstanceIgnored = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 177782, 178121);

                        Collection<string>
                        resolvedPaths =
                        f_1203_177842_178120(this, modifiedDirPath, false, getChildNamesContext, out providerIgnored, out providerInstanceIgnored)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 178241, 178435);

                        modifiedDirPath = (DynAbs.Tracing.TraceSender.Conditional_F1(1203, 178259, 178292) || ((f_1203_178259_178292(context) && DynAbs.Tracing.TraceSender.Conditional_F2(1203, 178338, 178353)) || DynAbs.Tracing.TraceSender.Conditional_F3(1203, 178399, 178434))) ? modifiedDirPath
                        : f_1203_178399_178434(modifiedDirPath);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 178457, 179166) || true) && (f_1203_178461_178480(resolvedPaths) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 178457, 179166);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 178534, 178566);

                            unescapedDir = f_1203_178549_178565(resolvedPaths, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 178457, 179166);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 178457, 179166);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 178941, 179081) || true) && (changedPathOrFilter)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 178941, 179081);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 179022, 179054);

                                context.Filter = originalFilter;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 178941, 179081);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 179109, 179143);

                            return f_1203_179116_179142();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 178457, 179166);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 176665, 179185);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 179205, 179481) || true) && (f_1203_179209_179267(provider, unescapedDir, getChildNamesContext))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 179205, 179481);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 179309, 179462);

                        f_1203_179309_179461(provider, unescapedDir, returnContainers, getChildNamesContext);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 179205, 179481);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 179637, 180136) || true) && (f_1203_179641_179673(getChildNamesContext))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 179637, 180136);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 179715, 179798);

                        Collection<ErrorRecord>
                        errors = f_1203_179748_179797(getChildNamesContext)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 179822, 180117) || true) && (errors != null && (DynAbs.Tracing.TraceSender.Expression_True(1203, 179826, 179885) && f_1203_179869_179881(errors) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 179822, 180117);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 179935, 180094);
                                foreach (ErrorRecord errorRecord in f_1203_179971_179977_I(errors))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 179935, 180094);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 180035, 180067);

                                    f_1203_180035_180066(context, errorRecord);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 179935, 180094);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 160);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 160);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 179822, 180117);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 179637, 180136);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 180156, 180246);

                    Collection<PSObject>
                    childNamesObjectArray = f_1203_180201_180245(getChildNamesContext)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 180266, 180382) || true) && (changedPathOrFilter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 180266, 180382);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 180331, 180363);

                        context.Filter = originalFilter;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 180266, 180382);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 180402, 180431);

                    return childNamesObjectArray;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1203, 180460, 180557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 180500, 180542);

                    f_1203_180500_180541(getChildNamesContext);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1203, 180460, 180557);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 174528, 180568);

                string
                f_1203_175079_175093(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 175079, 175093);
                    return return_v;
                }


                string
                f_1203_175169_175183(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 175169, 175183);
                    return return_v;
                }


                bool
                f_1203_175135_175233(System.Management.Automation.Provider.ContainerCmdletProvider
                this_param, string
                path, string
                filter, ref string
                updatedPath, ref string
                updatedFilter, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ConvertPath(path, filter, ref updatedPath, ref updatedFilter, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 175135, 175233);
                    return return_v;
                }


                bool
                f_1203_175311_175329(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.IsEnabled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 175311, 175329);
                    return return_v;
                }


                int
                f_1203_175371_175428(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 175371, 175428);
                    return 0;
                }


                int
                f_1203_175451_175504(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 175451, 175504);
                    return 0;
                }


                int
                f_1203_175527_175583(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 175527, 175583);
                    return 0;
                }


                string
                f_1203_175649_175663(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 175649, 175663);
                    return return_v;
                }


                int
                f_1203_175606_175664(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 175606, 175664);
                    return 0;
                }


                int
                f_1203_175687_175747(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 175687, 175747);
                    return 0;
                }


                System.Management.Automation.CmdletProviderContext
                f_1203_176193_176227(System.Management.Automation.CmdletProviderContext
                contextToCopyFrom)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(contextToCopyFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 176193, 176227);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_176366_176390()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 176366, 176390);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_176409_176433()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 176409, 176433);
                    return return_v;
                }


                string
                f_1203_176452_176466(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 176452, 176466);
                    return return_v;
                }


                int
                f_1203_176316_176467(System.Management.Automation.CmdletProviderContext
                this_param, System.Collections.ObjectModel.Collection<string>
                include, System.Collections.ObjectModel.Collection<string>
                exclude, string
                filter)
                {
                    this_param.SetFilters(include, exclude, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 176316, 176467);
                    return 0;
                }


                bool
                f_1203_176761_176794(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.SuppressWildcardExpansion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 176761, 176794);
                    return return_v;
                }


                string
                f_1203_176803_176826(string
                path)
                {
                    var return_v = RemoveGlobEscaping(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 176803, 176826);
                    return return_v;
                }


                int
                f_1203_176909_177076(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 176909, 177076);
                    return 0;
                }


                string
                f_1203_177600_177631(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = GetMshQualifiedPath(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 177600, 177631);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_177842_178120(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedProviderPathsFromMonadPath(path, allowNonexistingPaths, context, out provider, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 177842, 178120);
                    return return_v;
                }


                bool
                f_1203_178259_178292(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.SuppressWildcardExpansion
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 178259, 178292);
                    return return_v;
                }


                string
                f_1203_178399_178434(string
                path)
                {
                    var return_v = RemoveGlobEscaping(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 178399, 178434);
                    return return_v;
                }


                int
                f_1203_178461_178480(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 178461, 178480);
                    return return_v;
                }


                string
                f_1203_178549_178565(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 178549, 178565);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1203_179116_179142()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 179116, 179142);
                    return return_v;
                }


                bool
                f_1203_179209_179267(System.Management.Automation.Provider.ContainerCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.HasChildItems(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 179209, 179267);
                    return return_v;
                }


                int
                f_1203_179309_179461(System.Management.Automation.Provider.ContainerCmdletProvider
                this_param, string
                path, System.Management.Automation.ReturnContainers
                returnContainers, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.GetChildNames(path, returnContainers, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 179309, 179461);
                    return 0;
                }


                bool
                f_1203_179641_179673(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.HasErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 179641, 179673);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                f_1203_179748_179797(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.GetAccumulatedErrorObjects();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 179748, 179797);
                    return return_v;
                }


                int
                f_1203_179869_179881(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 179869, 179881);
                    return return_v;
                }


                int
                f_1203_180035_180066(System.Management.Automation.CmdletProviderContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 180035, 180066);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                f_1203_179971_179977_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 179971, 179977);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1203_180201_180245(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.GetAccumulatedObjects();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 180201, 180245);
                    return return_v;
                }


                int
                f_1203_180500_180541(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.RemoveStopReferral();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 180500, 180541);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 174528, 180568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 174528, 180568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsChildNameAMatch(
                    PSObject childObject,
                    WildcardPattern stringMatcher,
                    Collection<WildcardPattern> includeMatcher,
                    Collection<WildcardPattern> excludeMatcher,
                    out string childName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 181606, 184785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 181897, 181917);

                bool
                result = false
                ;
                {
                    try
                    {
                        do // false loop

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 181933, 184648);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 181982, 181999);

                            childName = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 182017, 182060);

                            object
                            baseObject = f_1203_182037_182059(childObject)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 182078, 182259) || true) && (baseObject is PSCustomObject)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 182078, 182259);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 182152, 182212);

                                f_1203_182152_182211(s_tracer, "GetChildNames returned a null object");
                                DynAbs.Tracing.TraceSender.TraceBreak(1203, 182234, 182240);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 182078, 182259);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 182279, 182312);

                            childName = baseObject as string;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 182332, 182519) || true) && (childName == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 182332, 182519);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 182395, 182472);

                                f_1203_182395_182471(s_tracer, "GetChildNames returned an object that wasn't a string");
                                DynAbs.Tracing.TraceSender.TraceBreak(1203, 182494, 182500);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 182332, 182519);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 182539, 182619);

                            f_1203_182539_182618(
                                            s_pathResolutionTracer, "Name returned from provider: {0}", childName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 182758, 182841);

                            bool
                            isGlobbed = f_1203_182775_182840(f_1203_182818_182839(stringMatcher))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 182859, 182912);

                            bool
                            isChildMatch = f_1203_182879_182911(stringMatcher, childName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 182930, 182985);

                            f_1203_182930_182984(s_tracer, "isChildMatch = {0}", isChildMatch);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 183005, 183058);

                            bool
                            isIncludeSpecified = (f_1203_183032_183052(includeMatcher) > 0)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 183076, 183129);

                            bool
                            isExcludeSpecified = (f_1203_183103_183123(excludeMatcher) > 0)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 183147, 183348);

                            bool
                            isIncludeMatch =
                            f_1203_183191_183347(childName, includeMatcher, true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 183368, 183427);

                            f_1203_183368_183426(
                                            s_tracer, "isIncludeMatch = {0}", isIncludeMatch);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 183523, 184618) || true) && (isChildMatch || (DynAbs.Tracing.TraceSender.Expression_False(1203, 183527, 183594) || (isGlobbed && (DynAbs.Tracing.TraceSender.Expression_True(1203, 183544, 183575) && isIncludeSpecified) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 183544, 183593) && isIncludeMatch))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 183523, 184618);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 183636, 183708);

                                f_1203_183636_183707(s_pathResolutionTracer, "Path wildcard match: {0}", childName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 183730, 183744);

                                result = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 183825, 184051) || true) && (isIncludeSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1203, 183829, 183866) && !isIncludeMatch))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 183825, 184051);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 183916, 183987);

                                    f_1203_183916_183986(s_pathResolutionTracer, "Not included match: {0}", childName);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 184013, 184028);

                                    result = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 183825, 184051);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 184128, 184441) || true) && (isExcludeSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1203, 184132, 184260) && f_1203_184179_184260(childName, excludeMatcher, false)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 184128, 184441);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 184310, 184377);

                                    f_1203_184310_184376(s_pathResolutionTracer, "Excluded match: {0}", childName);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 184403, 184418);

                                    result = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 184128, 184441);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 183523, 184618);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 183523, 184618);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 184523, 184599);

                                f_1203_184523_184598(s_pathResolutionTracer, "NOT path wildcard match: {0}", childName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 183523, 184618);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 181933, 184648);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 181933, 184648) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 181933, 184648);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 181933, 184648);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 184664, 184746);

                f_1203_184664_184745(
                            s_tracer, "result = {0}; childName = {1}", f_1203_184716_184733(result), childName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 184760, 184774);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 181606, 184785);

                object
                f_1203_182037_182059(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 182037, 182059);
                    return return_v;
                }


                int
                f_1203_182152_182211(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 182152, 182211);
                    return 0;
                }


                int
                f_1203_182395_182471(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 182395, 182471);
                    return 0;
                }


                int
                f_1203_182539_182618(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 182539, 182618);
                    return 0;
                }


                string
                f_1203_182818_182839(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 182818, 182839);
                    return return_v;
                }


                bool
                f_1203_182775_182840(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 182775, 182840);
                    return return_v;
                }


                bool
                f_1203_182879_182911(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 182879, 182911);
                    return return_v;
                }


                int
                f_1203_182930_182984(System.Management.Automation.PSTraceSource
                this_param, string
                format, bool
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 182930, 182984);
                    return 0;
                }


                int
                f_1203_183032_183052(System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 183032, 183052);
                    return return_v;
                }


                int
                f_1203_183103_183123(System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 183103, 183123);
                    return return_v;
                }


                bool
                f_1203_183191_183347(string
                text, System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 183191, 183347);
                    return return_v;
                }


                int
                f_1203_183368_183426(System.Management.Automation.PSTraceSource
                this_param, string
                format, bool
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 183368, 183426);
                    return 0;
                }


                int
                f_1203_183636_183707(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 183636, 183707);
                    return 0;
                }


                int
                f_1203_183916_183986(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 183916, 183986);
                    return 0;
                }


                bool
                f_1203_184179_184260(string
                text, System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 184179, 184260);
                    return return_v;
                }


                int
                f_1203_184310_184376(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 184310, 184376);
                    return 0;
                }


                int
                f_1203_184523_184598(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 184523, 184598);
                    return 0;
                }


                string
                f_1203_184716_184733(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 184716, 184733);
                    return return_v;
                }


                int
                f_1203_184664_184745(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 184664, 184745);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 181606, 184785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 181606, 184785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string ConvertMshEscapeToRegexEscape(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 185852, 188725);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 185941, 186065) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 185941, 186065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 185991, 186050);

                    throw f_1203_185997_186049(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 185941, 186065);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 186081, 186112);

                const char
                mshEscapeChar = '`'
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 186126, 186160);

                const char
                regexEscapeChar = '\\'
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 186176, 186216);

                char[]
                workerArray = f_1203_186197_186215(path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 186232, 186275);

                StringBuilder
                result = f_1203_186255_186274()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 186300, 186309);

                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 186291, 188521) || true) && (index < f_1203_186319_186343(workerArray, 0))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 186345, 186352)
        , ++index, DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 186291, 188521))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 186291, 188521);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 186437, 188506) || true) && (workerArray[index] == mshEscapeChar)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 186437, 188506);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 186518, 187928) || true) && (index + 1 < f_1203_186534_186558(workerArray, 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 186518, 187928);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 186608, 187447) || true) && (workerArray[index + 1] == mshEscapeChar)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 186608, 187447);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 186932, 186961);

                                    f_1203_186932_186960(                            // Since there are two escape characters in a row,
                                                                                     // the string really wanted a back tick so add that to
                                                                                     // the result and continue.

                                                                result, mshEscapeChar);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 187088, 187096);

                                    ++index;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 186608, 187447);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 186608, 187447);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 187389, 187420);

                                    f_1203_187389_187419(                            // Since the escape character wasn't followed by another
                                                                                     // escape character, convert it to a back slash and continue.

                                                                result, regexEscapeChar);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 186608, 187447);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 186518, 187928);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 186518, 187928);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 187874, 187905);

                                f_1203_187874_187904(                        // Since the escape character was the last character in the string
                                                                             // just convert it. Most likely this is an error condition in the
                                                                             // Regex class but I will let that fail instead of pretending to
                                                                             // know what the user meant.

                                                        result, regexEscapeChar);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 186518, 187928);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 186437, 188506);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 186437, 188506);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 187970, 188506) || true) && (workerArray[index] == regexEscapeChar)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 187970, 188506);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 188220, 188242);

                                f_1203_188220_188241(                    // For backslashes we need to append two back slashes so that
                                                                         // the regex processor doesn't think its an escape character

                                                    result, "\\\\");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 187970, 188506);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 187970, 188506);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 188453, 188487);

                                f_1203_188453_188486(                    // The character is not an escape character so add it to the result
                                                                         // and continue.

                                                    result, workerArray[index]);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 187970, 188506);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 186437, 188506);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 2231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 2231);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 188537, 188673);

                f_1203_188537_188672(
                            s_tracer, "Original path: {0} Converted to: {1}", path, f_1203_188654_188671(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 188689, 188714);

                return f_1203_188696_188713(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 185852, 188725);

                System.Management.Automation.PSArgumentNullException
                f_1203_185997_186049(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 185997, 186049);
                    return return_v;
                }


                char[]
                f_1203_186197_186215(string
                this_param)
                {
                    var return_v = this_param.ToCharArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 186197, 186215);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1203_186255_186274()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 186255, 186274);
                    return return_v;
                }


                int
                f_1203_186319_186343(char[]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLength(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 186319, 186343);
                    return return_v;
                }


                int
                f_1203_186534_186558(char[]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLength(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 186534, 186558);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1203_186932_186960(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 186932, 186960);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1203_187389_187419(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 187389, 187419);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1203_187874_187904(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 187874, 187904);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1203_188220_188241(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 188220, 188241);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1203_188453_188486(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 188453, 188486);
                    return return_v;
                }


                string
                f_1203_188654_188671(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 188654, 188671);
                    return return_v;
                }


                int
                f_1203_188537_188672(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 188537, 188672);
                    return 0;
                }


                string
                f_1203_188696_188713(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 188696, 188713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 185852, 188725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 185852, 188725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsHomePath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 189325, 190467);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 189394, 189518) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 189394, 189518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 189444, 189503);

                    throw f_1203_189450_189502(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 189394, 189518);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 189534, 189554);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 189570, 189977) || true) && (f_1203_189574_189603(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 189570, 189977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 189702, 189791);

                    int
                    index = f_1203_189714_189790(path, StringLiterals.ProviderPathSeparator, StringComparison.Ordinal)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 189811, 189962) || true) && (index != -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 189811, 189962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 189868, 189943);

                        path = f_1203_189875_189942(path, index + f_1203_189898_189941(StringLiterals.ProviderPathSeparator));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 189811, 189962);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 189570, 189977);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 189993, 190426) || true) && (f_1203_189997_190060(path, StringLiterals.HomePath, StringComparison.Ordinal) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 189993, 190426);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 190142, 190411) || true) && (f_1203_190146_190157(path) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 190142, 190411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 190185, 190199);

                        result = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 190142, 190411);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 190142, 190411);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 190263, 190411) || true) && ((f_1203_190268_190279(path) > 1) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 190267, 190374) && (f_1203_190314_190321(path, 1) == '\\' || (DynAbs.Tracing.TraceSender.Expression_False(1203, 190314, 190373) || f_1203_190359_190366(path, 1) == '/'))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 190263, 190411);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 190397, 190411);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 190263, 190411);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 190142, 190411);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 189993, 190426);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 190442, 190456);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 189325, 190467);

                System.Management.Automation.PSArgumentNullException
                f_1203_189450_189502(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 189450, 189502);
                    return return_v;
                }


                bool
                f_1203_189574_189603(string
                path)
                {
                    var return_v = IsProviderQualifiedPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 189574, 189603);
                    return return_v;
                }


                int
                f_1203_189714_189790(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 189714, 189790);
                    return return_v;
                }


                int
                f_1203_189898_189941(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 189898, 189941);
                    return return_v;
                }


                string
                f_1203_189875_189942(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 189875, 189942);
                    return return_v;
                }


                int
                f_1203_189997_190060(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 189997, 190060);
                    return return_v;
                }


                int
                f_1203_190146_190157(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 190146, 190157);
                    return return_v;
                }


                int
                f_1203_190268_190279(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 190268, 190279);
                    return return_v;
                }


                char
                f_1203_190314_190321(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 190314, 190321);
                    return return_v;
                }


                char
                f_1203_190359_190366(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 190359, 190366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 189325, 190467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 189325, 190467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsProviderDirectPath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 191005, 191431);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 191084, 191208) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 191084, 191208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 191134, 191193);

                    throw f_1203_191140_191192(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 191084, 191208);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 191224, 191420);

                return f_1203_191231_191312(path, StringLiterals.DefaultRemotePathPrefix, StringComparison.Ordinal) || (DynAbs.Tracing.TraceSender.Expression_False(1203, 191231, 191419) || f_1203_191336_191419(path, StringLiterals.AlternateRemotePathPrefix, StringComparison.Ordinal));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 191005, 191431);

                System.Management.Automation.PSArgumentNullException
                f_1203_191140_191192(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 191140, 191192);
                    return return_v;
                }


                bool
                f_1203_191231_191312(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 191231, 191312);
                    return return_v;
                }


                bool
                f_1203_191336_191419(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 191336, 191419);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 191005, 191431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 191005, 191431);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetHomeRelativePath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1203, 192837, 196216);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 192910, 193034) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 192910, 193034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 192960, 193019);

                    throw f_1203_192966_193018(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 192910, 193034);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 193050, 193071);

                string
                result = path
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 193087, 196175) || true) && (f_1203_193091_193107(path) && (DynAbs.Tracing.TraceSender.Expression_True(1203, 193091, 193146) && f_1203_193111_193138(f_1203_193111_193130(_sessionState)) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 193087, 196175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 193180, 193241);

                    ProviderInfo
                    provider = f_1203_193204_193240(f_1203_193204_193231(f_1203_193204_193223(_sessionState)))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 193261, 193996) || true) && (f_1203_193265_193294(path))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 193261, 193996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 193405, 193494);

                        int
                        index = f_1203_193417_193493(path, StringLiterals.ProviderPathSeparator, StringComparison.Ordinal)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 193518, 193977) || true) && (index != -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 193518, 193977);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 193712, 193759);

                            string
                            providerName = f_1203_193734_193758(path, 0, index)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 193787, 193853);

                            provider = f_1203_193798_193852(f_1203_193798_193820(_sessionState), providerName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 193879, 193954);

                            path = f_1203_193886_193953(path, index + f_1203_193909_193952(StringLiterals.ProviderPathSeparator));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 193518, 193977);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 193261, 193996);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 194016, 196126) || true) && (f_1203_194020_194083(path, StringLiterals.HomePath, StringComparison.Ordinal) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 194016, 196126);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 194197, 194527) || true) && (f_1203_194201_194212(path) > 1 && (DynAbs.Tracing.TraceSender.Expression_True(1203, 194201, 194306) && (f_1203_194246_194253(path, 1) == '\\' || (DynAbs.Tracing.TraceSender.Expression_False(1203, 194246, 194305) || f_1203_194291_194298(path, 1) == '/'))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 194197, 194527);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 194356, 194381);

                            path = f_1203_194363_194380(path, 2);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 194197, 194527);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 194197, 194527);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 194479, 194504);

                            path = f_1203_194486_194503(path, 1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 194197, 194527);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 194693, 196107) || true) && (f_1203_194697_194710(provider) != null && (DynAbs.Tracing.TraceSender.Expression_True(1203, 194697, 194771) && f_1203_194747_194767(f_1203_194747_194760(provider)) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 194693, 196107);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 194821, 194949);

                            CmdletProviderContext
                            context =
                            f_1203_194882_194948(f_1203_194908_194947(f_1203_194908_194930(_sessionState)))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 194977, 195064);

                            f_1203_194977_195063(
                                                    s_pathResolutionTracer, "Getting home path for provider: {0}", f_1203_195049_195062(provider));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 195090, 195165);

                            f_1203_195090_195164(s_pathResolutionTracer, "Provider HOME path: {0}", f_1203_195150_195163(provider));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 195193, 195522) || true) && (f_1203_195197_195223(path))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 195193, 195522);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 195281, 195302);

                                path = f_1203_195288_195301(provider);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 195193, 195522);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 195193, 195522);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 195416, 195495);

                                path = f_1203_195423_195494(f_1203_195423_195445(_sessionState), provider, f_1203_195465_195478(provider), path, context);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 195193, 195522);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 195550, 195616);

                            f_1203_195550_195615(
                                                    s_pathResolutionTracer, "HOME relative path: {0}", path);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 194693, 196107);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 194693, 196107);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 195714, 195934);

                            InvalidOperationException
                            e =
                            f_1203_195773_195933(f_1203_195850_195884(), f_1203_195919_195932(provider))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 195962, 196050);

                            f_1203_195962_196049(
                                                    s_pathResolutionTracer, "HOME path not set for provider: {0}", f_1203_196035_196048(provider));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 196076, 196084);

                            throw e;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 194693, 196107);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 194016, 196126);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 196146, 196160);

                    result = path;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 193087, 196175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 196191, 196205);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1203, 192837, 196216);

                System.Management.Automation.PSArgumentNullException
                f_1203_192966_193018(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 192966, 193018);
                    return return_v;
                }


                bool
                f_1203_193091_193107(string
                path)
                {
                    var return_v = IsHomePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 193091, 193107);
                    return return_v;
                }


                System.Management.Automation.DriveManagementIntrinsics
                f_1203_193111_193130(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 193111, 193130);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_193111_193138(System.Management.Automation.DriveManagementIntrinsics
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 193111, 193138);
                    return return_v;
                }


                System.Management.Automation.DriveManagementIntrinsics
                f_1203_193204_193223(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 193204, 193223);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1203_193204_193231(System.Management.Automation.DriveManagementIntrinsics
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 193204, 193231);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_193204_193240(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 193204, 193240);
                    return return_v;
                }


                bool
                f_1203_193265_193294(string
                path)
                {
                    var return_v = IsProviderQualifiedPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 193265, 193294);
                    return return_v;
                }


                int
                f_1203_193417_193493(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 193417, 193493);
                    return return_v;
                }


                string
                f_1203_193734_193758(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 193734, 193758);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_193798_193820(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 193798, 193820);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1203_193798_193852(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetSingleProvider(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 193798, 193852);
                    return return_v;
                }


                int
                f_1203_193909_193952(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 193909, 193952);
                    return return_v;
                }


                string
                f_1203_193886_193953(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 193886, 193953);
                    return return_v;
                }


                int
                f_1203_194020_194083(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 194020, 194083);
                    return return_v;
                }


                int
                f_1203_194201_194212(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 194201, 194212);
                    return return_v;
                }


                char
                f_1203_194246_194253(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 194246, 194253);
                    return return_v;
                }


                char
                f_1203_194291_194298(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 194291, 194298);
                    return return_v;
                }


                string
                f_1203_194363_194380(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 194363, 194380);
                    return return_v;
                }


                string
                f_1203_194486_194503(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 194486, 194503);
                    return return_v;
                }


                string
                f_1203_194697_194710(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Home;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 194697, 194710);
                    return return_v;
                }


                string
                f_1203_194747_194760(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Home;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 194747, 194760);
                    return return_v;
                }


                int
                f_1203_194747_194767(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 194747, 194767);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_194908_194930(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 194908, 194930);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1203_194908_194947(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 194908, 194947);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1203_194882_194948(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 194882, 194948);
                    return return_v;
                }


                string
                f_1203_195049_195062(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 195049, 195062);
                    return return_v;
                }


                int
                f_1203_194977_195063(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 194977, 195063);
                    return 0;
                }


                string
                f_1203_195150_195163(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Home;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 195150, 195163);
                    return return_v;
                }


                int
                f_1203_195090_195164(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 195090, 195164);
                    return 0;
                }


                bool
                f_1203_195197_195223(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 195197, 195223);
                    return return_v;
                }


                string
                f_1203_195288_195301(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Home;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 195288, 195301);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1203_195423_195445(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 195423, 195445);
                    return return_v;
                }


                string
                f_1203_195465_195478(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Home;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 195465, 195478);
                    return return_v;
                }


                string
                f_1203_195423_195494(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(provider, parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 195423, 195494);
                    return return_v;
                }


                int
                f_1203_195550_195615(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 195550, 195615);
                    return 0;
                }


                string
                f_1203_195850_195884()
                {
                    var return_v = SessionStateStrings.HomePathNotSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 195850, 195884);
                    return return_v;
                }


                string
                f_1203_195919_195932(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 195919, 195932);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1203_195773_195933(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 195773, 195933);
                    return return_v;
                }


                string
                f_1203_196035_196048(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 196035, 196048);
                    return return_v;
                }


                int
                f_1203_195962_196049(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 195962, 196049);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 192837, 196216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 192837, 196216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void TraceFilters(CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1203, 196228, 197567);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 196316, 197556) || true) && ((f_1203_196321_196351(s_pathResolutionTracer) & PSTraceSourceOptions.WriteLine) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 196316, 197556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 196461, 196541);

                    f_1203_196461_196540(                // Trace the filter
                                    s_pathResolutionTracer, "Filter: {0}", f_1203_196509_196523(context) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1203, 196509, 196539) ?? string.Empty));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 196561, 197041) || true) && (f_1203_196565_196580(context) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 196561, 197041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 196680, 196730);

                        StringBuilder
                        includeString = f_1203_196710_196729()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 196752, 196923);
                            foreach (string includeFilter in f_1203_196785_196800_I(f_1203_196785_196800(context)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 196752, 196923);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 196850, 196900);

                                f_1203_196850_196899(includeString, "{0} ", includeFilter);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 196752, 196923);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 172);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 172);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 196947, 197022);

                        f_1203_196947_197021(
                                            s_pathResolutionTracer, "Include: {0}", f_1203_196996_197020(includeString));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 196561, 197041);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 197061, 197541) || true) && (f_1203_197065_197080(context) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 197061, 197541);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 197180, 197230);

                        StringBuilder
                        excludeString = f_1203_197210_197229()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 197252, 197423);
                            foreach (string excludeFilter in f_1203_197285_197300_I(f_1203_197285_197300(context)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1203, 197252, 197423);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 197350, 197400);

                                f_1203_197350_197399(excludeString, "{0} ", excludeFilter);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 197252, 197423);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1203, 1, 172);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1203, 1, 172);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 197447, 197522);

                        f_1203_197447_197521(
                                            s_pathResolutionTracer, "Exclude: {0}", f_1203_197496_197520(excludeString));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 197061, 197541);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1203, 196316, 197556);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1203, 196228, 197567);

                System.Management.Automation.PSTraceSourceOptions
                f_1203_196321_196351(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 196321, 196351);
                    return return_v;
                }


                string
                f_1203_196509_196523(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 196509, 196523);
                    return return_v;
                }


                int
                f_1203_196461_196540(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 196461, 196540);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_196565_196580(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Include;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 196565, 196580);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1203_196710_196729()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 196710, 196729);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_196785_196800(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Include;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 196785, 196800);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1203_196850_196899(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 196850, 196899);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_196785_196800_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 196785, 196800);
                    return return_v;
                }


                string
                f_1203_196996_197020(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 196996, 197020);
                    return return_v;
                }


                int
                f_1203_196947_197021(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 196947, 197021);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_197065_197080(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Exclude;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 197065, 197080);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1203_197210_197229()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 197210, 197229);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_197285_197300(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Exclude;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1203, 197285, 197300);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1203_197350_197399(System.Text.StringBuilder
                this_param, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 197350, 197399);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1203_197285_197300_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 197285, 197300);
                    return return_v;
                }


                string
                f_1203_197496_197520(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 197496, 197520);
                    return return_v;
                }


                int
                f_1203_197447_197521(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 197447, 197521);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1203, 196228, 197567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 196228, 197567);
            }
        }

        static LocationGlobber()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1203, 484, 197613);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 956, 1134);
            s_tracer = f_1203_980_1134("LocationGlobber", "The location globber converts PowerShell paths with glob characters to zero or more paths.");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1203, 1404, 1587);
            s_pathResolutionTracer = f_1203_1442_1587("PathResolution", "Traces the path resolution algorithm.", false);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1203, 484, 197613);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1203, 484, 197613);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1203, 484, 197613);

        static System.Management.Automation.PSTraceSource
        f_1203_980_1134(string
        name, string
        description)
        {
            var return_v = Dbg.PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 980, 1134);
            return return_v;
        }


        static System.Management.Automation.PSTraceSource
        f_1203_1442_1587(string
        name, string
        description, bool
        traceHeaders)
        {
            var return_v = Dbg.PSTraceSource.GetTracer(name, description, traceHeaders);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 1442, 1587);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1203_2224_2284(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1203, 2224, 2284);
            return return_v;
        }

    }
}
