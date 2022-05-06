// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal class CommandPathSearch : IEnumerable<string>, IEnumerator<string>
    {
        [TraceSource("CommandSearch", "CommandSearch")]
        private static PSTraceSource s_tracer;

        internal CommandPathSearch(
                    IEnumerable<string> patterns,
                    IEnumerable<string> lookupPaths,
                    ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1250, 1307, 1535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 21274, 21286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 21424, 21446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 21655, 21679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 21820, 21854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 21987, 21996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22130, 22148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22302, 22310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22503, 22513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22700, 22727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22757, 22772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22810, 22833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22859, 22881);
                this._useFuzzyMatch = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 1487, 1524);

                f_1250_1487_1523(this, patterns, lookupPaths, context);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1250, 1307, 1535);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 1307, 1535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 1307, 1535);
            }
        }

        internal CommandPathSearch(
                    string commandName,
                    IEnumerable<string> lookupPaths,
                    ExecutionContext context,
                    Collection<string> acceptableCommandNames,
                    bool useFuzzyMatch = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1250, 1547, 3359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 21274, 21286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 21424, 21446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 21655, 21679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 21820, 21854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 21987, 21996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22130, 22148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22302, 22310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22503, 22513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22700, 22727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22757, 22772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22810, 22833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 22859, 22881);
                this._useFuzzyMatch = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 1814, 1845);

                _useFuzzyMatch = useFuzzyMatch;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 1859, 1884);

                string[]
                commandPatterns
                = default(string[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 1898, 3208) || true) && (acceptableCommandNames != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 1898, 3208);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 2281, 2867) || true) && (f_1250_2285_2303())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 2281, 2867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 2345, 2392);

                        commandPatterns = new[] { commandName + ".*" };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 2281, 2867);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 2281, 2867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 2786, 2848);

                        commandPatterns = new[] { commandName, commandName + ".ps1" };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 2281, 2867);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 2887, 2952);

                    _postProcessEnumeratedFiles = CheckAgainstAcceptableCommandNames;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 2970, 3019);

                    _acceptableCommandNames = acceptableCommandNames;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 1898, 3208);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 1898, 3208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 3085, 3125);

                    commandPatterns = new[] { commandName };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 3143, 3193);

                    _postProcessEnumeratedFiles = JustCheckExtensions;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 1898, 3208);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 3224, 3268);

                f_1250_3224_3267(this, commandPatterns, lookupPaths, context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 3282, 3348);

                _orderedPathExt = f_1250_3300_3347();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1250, 1547, 3359);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 1547, 3359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 1547, 3359);
            }
        }

        private void Init(IEnumerable<string> commandPatterns, IEnumerable<string> searchPath, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1250, 3371, 3815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 3593, 3612);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 3626, 3654);

                _patterns = commandPatterns;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 3670, 3722);

                _lookupPaths = f_1250_3685_3721(searchPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 3736, 3775);

                f_1250_3736_3774(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 3791, 3804);

                f_1250_3791_3803(
                            this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1250, 3371, 3815);

                System.Management.Automation.LookupPathCollection
                f_1250_3685_3721(System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    var return_v = new System.Management.Automation.LookupPathCollection(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 3685, 3721);
                    return return_v;
                }


                int
                f_1250_3736_3774(System.Management.Automation.CommandPathSearch
                this_param)
                {
                    this_param.ResolveCurrentDirectoryInLookupPaths();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 3736, 3774);
                    return 0;
                }


                int
                f_1250_3791_3803(System.Management.Automation.CommandPathSearch
                this_param)
                {
                    this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 3791, 3803);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 3371, 3815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 3371, 3815);
            }
        }

        private void ResolveCurrentDirectoryInLookupPaths()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1250, 3985, 9653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 4061, 4116);

                var
                indexesToRemove = f_1250_4083_4115()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 4130, 4155);

                int
                removalListCount = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 4171, 4237);

                string
                fileSystemProviderName = f_1250_4203_4236(f_1250_4203_4225(_context))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 4253, 4317);

                SessionStateInternal
                sessionState = f_1250_4289_4316(_context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 4418, 4660);

                bool
                isCurrentDriveValid =
                f_1250_4462_4487(sessionState) != null && (DynAbs.Tracing.TraceSender.Expression_True(1250, 4462, 4585) && f_1250_4516_4585(f_1250_4516_4550(f_1250_4516_4541(sessionState)), fileSystemProviderName)) && (DynAbs.Tracing.TraceSender.Expression_True(1250, 4462, 4659) && f_1250_4606_4659(sessionState, fileSystemProviderName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 4676, 4745);

                string
                environmentCurrentDirectory = f_1250_4713_4744()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 4761, 4817);

                LocationGlobber
                pathResolver = f_1250_4792_4816(_context)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 4900, 9180);
                    foreach (int index in f_1250_4922_4956_I(f_1250_4922_4956(_lookupPaths)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 4900, 9180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 4990, 5022);

                        string
                        resolvedDirectory = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 5040, 5067);

                        string
                        resolvedPath = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 5087, 5278);

                        f_1250_5087_5277(
                                        CommandDiscovery.discoveryTracer, "Lookup directory \"{0}\" appears to be a relative path. Attempting resolution...", f_1250_5257_5276(_lookupPaths, index));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 5298, 7534) || true) && (isCurrentDriveValid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 5298, 7534);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 5415, 5437);

                                ProviderInfo
                                provider
                                = default(ProviderInfo);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 5463, 5638);

                                resolvedPath =
                                f_1250_5507_5637(pathResolver, f_1250_5570_5589(_lookupPaths, index), out provider);
                            }
                            catch (ProviderInvocationException providerInvocationException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1250, 5683, 6104);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 5795, 6081);

                                f_1250_5795_6080(CommandDiscovery.discoveryTracer, "The relative path '{0}', could not be resolved because the provider threw an exception: '{1}'", f_1250_5994_6013(_lookupPaths, index), f_1250_6044_6079(providerInvocationException));
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1250, 5683, 6104);
                            }
                            catch (InvalidOperationException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1250, 6126, 6434);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 6208, 6411);

                                f_1250_6208_6410(CommandDiscovery.discoveryTracer, "The relative path '{0}', could not resolve a home directory for the provider", f_1250_6390_6409(_lookupPaths, index));
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1250, 6126, 6434);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 6559, 7161) || true) && (!f_1250_6564_6598(resolvedPath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 6559, 7161);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 6648, 6803);

                                f_1250_6648_6802(CommandDiscovery.discoveryTracer, "The relative path resolved to: {0}", resolvedPath);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 6831, 6864);

                                resolvedDirectory = resolvedPath;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 6559, 7161);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 6559, 7161);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 6962, 7138);

                                f_1250_6962_7137(CommandDiscovery.discoveryTracer, "The relative path was not a file system path. {0}", f_1250_7117_7136(_lookupPaths, index));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 6559, 7161);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 5298, 7534);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 5298, 7534);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 7243, 7443);

                            f_1250_7243_7442(CommandDiscovery.discoveryTracer, "The current drive is not set, using the process current directory: {0}", environmentCurrentDirectory);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 7467, 7515);

                            resolvedDirectory = environmentCurrentDirectory;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 5298, 7534);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 7726, 9165) || true) && (resolvedDirectory != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 7726, 9165);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 7797, 7857);

                            int
                            existingIndex = f_1250_7817_7856(_lookupPaths, resolvedDirectory)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 7881, 8896) || true) && (existingIndex != -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 7881, 8896);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 7954, 8658) || true) && (existingIndex > index)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 7954, 8658);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 8188, 8243);

                                    f_1250_8188_8242(                            // The relative path index is less than the explicit path,
                                                                                 // so remove the explicit path.

                                                                indexesToRemove, removalListCount++, existingIndex);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 8273, 8313);

                                    _lookupPaths[index] = resolvedDirectory;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 7954, 8658);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 7954, 8658);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 8584, 8631);

                                    f_1250_8584_8630(                            // The explicit path index is less than the relative path
                                                                                 // index, so remove the relative path.

                                                                indexesToRemove, removalListCount++, index);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 7954, 8658);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 7881, 8896);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 7881, 8896);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 8833, 8873);

                                _lookupPaths[index] = resolvedDirectory;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 7881, 8896);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 7726, 9165);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 7726, 9165);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 9099, 9146);

                            f_1250_9099_9145(                    // The directory couldn't be resolved so remove it from the
                                                                 // lookup paths.

                                                indexesToRemove, removalListCount++, index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 7726, 9165);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 4900, 9180);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1250, 1, 4281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1250, 1, 4281);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 9418, 9453);

                    // Now remove all the duplicates starting from the back of the collection.
                    // As each element is removed, elements that follow are moved up to occupy
                    // the emptied index.

                    for (int
        removeIndex = f_1250_9432_9453(indexesToRemove)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 9409, 9642) || true) && (removeIndex > 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 9472, 9485)
        , --removeIndex, DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 9409, 9642))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 9409, 9642);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 9519, 9572);

                        int
                        indexToRemove = f_1250_9539_9571(indexesToRemove, removeIndex - 1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 9590, 9627);

                        f_1250_9590_9626(_lookupPaths, indexToRemove);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1250, 1, 234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1250, 1, 234);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1250, 3985, 9653);

                System.Collections.Generic.SortedDictionary<int, int>
                f_1250_4083_4115()
                {
                    var return_v = new System.Collections.Generic.SortedDictionary<int, int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 4083, 4115);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1250_4203_4225(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 4203, 4225);
                    return return_v;
                }


                string
                f_1250_4203_4236(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 4203, 4236);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1250_4289_4316(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 4289, 4316);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1250_4462_4487(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 4462, 4487);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1250_4516_4541(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 4516, 4541);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1250_4516_4550(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 4516, 4550);
                    return return_v;
                }


                bool
                f_1250_4516_4585(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 4516, 4585);
                    return return_v;
                }


                bool
                f_1250_4606_4659(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.IsProviderLoaded(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 4606, 4659);
                    return return_v;
                }


                string
                f_1250_4713_4744()
                {
                    var return_v = Directory.GetCurrentDirectory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 4713, 4744);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1250_4792_4816(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LocationGlobber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 4792, 4816);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<int>
                f_1250_4922_4956(System.Management.Automation.LookupPathCollection
                this_param)
                {
                    var return_v = this_param.IndexOfRelativePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 4922, 4956);
                    return return_v;
                }


                string
                f_1250_5257_5276(System.Management.Automation.LookupPathCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 5257, 5276);
                    return return_v;
                }


                int
                f_1250_5087_5277(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 5087, 5277);
                    return 0;
                }


                string
                f_1250_5570_5589(System.Management.Automation.LookupPathCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 5570, 5589);
                    return return_v;
                }


                string
                f_1250_5507_5637(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 5507, 5637);
                    return return_v;
                }


                string
                f_1250_5994_6013(System.Management.Automation.LookupPathCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 5994, 6013);
                    return return_v;
                }


                string
                f_1250_6044_6079(System.Management.Automation.ProviderInvocationException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 6044, 6079);
                    return return_v;
                }


                int
                f_1250_5795_6080(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 5795, 6080);
                    return 0;
                }


                string
                f_1250_6390_6409(System.Management.Automation.LookupPathCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 6390, 6409);
                    return return_v;
                }


                int
                f_1250_6208_6410(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 6208, 6410);
                    return 0;
                }


                bool
                f_1250_6564_6598(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 6564, 6598);
                    return return_v;
                }


                int
                f_1250_6648_6802(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 6648, 6802);
                    return 0;
                }


                string
                f_1250_7117_7136(System.Management.Automation.LookupPathCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 7117, 7136);
                    return return_v;
                }


                int
                f_1250_6962_7137(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 6962, 7137);
                    return 0;
                }


                int
                f_1250_7243_7442(System.Management.Automation.PSTraceSource
                this_param, string
                warningMessageFormat, params object[]
                args)
                {
                    this_param.TraceWarning(warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 7243, 7442);
                    return 0;
                }


                int
                f_1250_7817_7856(System.Management.Automation.LookupPathCollection
                this_param, string
                item)
                {
                    var return_v = this_param.IndexOf(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 7817, 7856);
                    return return_v;
                }


                int
                f_1250_8188_8242(System.Collections.Generic.SortedDictionary<int, int>
                this_param, int
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 8188, 8242);
                    return 0;
                }


                int
                f_1250_8584_8630(System.Collections.Generic.SortedDictionary<int, int>
                this_param, int
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 8584, 8630);
                    return 0;
                }


                int
                f_1250_9099_9145(System.Collections.Generic.SortedDictionary<int, int>
                this_param, int
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 9099, 9145);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<int>
                f_1250_4922_4956_I(System.Collections.ObjectModel.Collection<int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 4922, 4956);
                    return return_v;
                }


                int
                f_1250_9432_9453(System.Collections.Generic.SortedDictionary<int, int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 9432, 9453);
                    return return_v;
                }


                int
                f_1250_9539_9571(System.Collections.Generic.SortedDictionary<int, int>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 9539, 9571);
                    return return_v;
                }


                int
                f_1250_9590_9626(System.Management.Automation.LookupPathCollection
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 9590, 9626);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 3985, 9653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 3985, 9653);
            }
        }

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1250, 9869, 9972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 9949, 9961);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1250, 9869, 9972);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 9869, 9972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 9869, 9972);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1250, 10188, 10275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 10252, 10264);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1250, 10188, 10275);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 10188, 10275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 10188, 10275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool MoveNext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1250, 10520, 13656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 10567, 10587);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 10603, 11196) || true) && (_justReset)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 10603, 11196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 10651, 10670);

                    _justReset = false;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 10690, 10870) || true) && (!f_1250_10695_10724(_patternEnumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 10690, 10870);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 10766, 10816);

                        f_1250_10766_10815(s_tracer, "No patterns were specified");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 10838, 10851);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 10690, 10870);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 10890, 11078) || true) && (!f_1250_10895_10928(_lookupPathsEnumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 10890, 11078);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 10970, 11024);

                        f_1250_10970_11023(s_tracer, "No lookup paths were specified");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 11046, 11059);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 10890, 11078);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 11098, 11181);

                    f_1250_11098_11180(this, f_1250_11121_11147(_patternEnumerator), f_1250_11149_11179(_lookupPathsEnumerator));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 10603, 11196);
                }
                {
                    try
                    {
                        do // while lookupPathsEnumerator is valid

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 11212, 13615);
                            {
                                try
                                {
                                    do // while patternEnumerator is valid

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 11287, 12620);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 11443, 12492) || true) && (!f_1250_11448_11493(_currentDirectoryResultsEnumerator))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 11443, 12492);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 11543, 11603);

                                            f_1250_11543_11602(s_tracer, "Current directory results are invalid");

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 11773, 12035) || true) && (!f_1250_11778_11807(_patternEnumerator))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 11773, 12035);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 11865, 11972);

                                                f_1250_11865_11971(s_tracer, "Current patterns exhausted in current directory: {0}", f_1250_11940_11970(_lookupPathsEnumerator));
                                                DynAbs.Tracing.TraceSender.TraceBreak(1250, 12002, 12008);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 11773, 12035);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 12129, 12212);

                                            f_1250_12129_12211(this, f_1250_12152_12178(_patternEnumerator), f_1250_12180_12210(_lookupPathsEnumerator));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 11443, 12492);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 11443, 12492);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 12310, 12397);

                                            f_1250_12310_12396(s_tracer, "Next path found: {0}", f_1250_12353_12395(_currentDirectoryResultsEnumerator));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 12423, 12437);

                                            result = true;
                                            DynAbs.Tracing.TraceSender.TraceBreak(1250, 12463, 12469);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 11443, 12492);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 11287, 12620);
                                    }
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 11287, 12620) || true) && (true)
                                    );
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1250, 11287, 12620);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1250, 11287, 12620);
                                }
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 12640, 12717) || true) && (result)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 12640, 12717);
                                DynAbs.Tracing.TraceSender.TraceBreak(1250, 12692, 12698);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 12640, 12717);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 12895, 13101) || true) && (!f_1250_12900_12933(_lookupPathsEnumerator))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 12895, 13101);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 12975, 13054);

                                f_1250_12975_13053(s_tracer, "All lookup paths exhausted, no more matches can be found");
                                DynAbs.Tracing.TraceSender.TraceBreak(1250, 13076, 13082);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 12895, 13101);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 13218, 13265);

                            _patternEnumerator = f_1250_13239_13264(_patterns);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 13285, 13483) || true) && (!f_1250_13290_13319(_patternEnumerator))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 13285, 13483);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 13361, 13436);

                                f_1250_13361_13435(s_tracer, "All patterns exhausted, no more matches can be found");
                                DynAbs.Tracing.TraceSender.TraceBreak(1250, 13458, 13464);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 13285, 13483);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 13503, 13586);

                            f_1250_13503_13585(this, f_1250_13526_13552(_patternEnumerator), f_1250_13554_13584(_lookupPathsEnumerator));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 11212, 13615);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 11212, 13615) || true) && (true)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1250, 11212, 13615);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1250, 11212, 13615);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 13631, 13645);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1250, 10520, 13656);

                bool
                f_1250_10695_10724(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 10695, 10724);
                    return return_v;
                }


                int
                f_1250_10766_10815(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 10766, 10815);
                    return 0;
                }


                bool
                f_1250_10895_10928(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 10895, 10928);
                    return return_v;
                }


                int
                f_1250_10970_11023(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 10970, 11023);
                    return 0;
                }


                string
                f_1250_11121_11147(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 11121, 11147);
                    return return_v;
                }


                string
                f_1250_11149_11179(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 11149, 11179);
                    return return_v;
                }


                int
                f_1250_11098_11180(System.Management.Automation.CommandPathSearch
                this_param, string
                pattern, string
                directory)
                {
                    this_param.GetNewDirectoryResults(pattern, directory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 11098, 11180);
                    return 0;
                }


                bool
                f_1250_11448_11493(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 11448, 11493);
                    return return_v;
                }


                int
                f_1250_11543_11602(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 11543, 11602);
                    return 0;
                }


                bool
                f_1250_11778_11807(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 11778, 11807);
                    return return_v;
                }


                string
                f_1250_11940_11970(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 11940, 11970);
                    return return_v;
                }


                int
                f_1250_11865_11971(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 11865, 11971);
                    return 0;
                }


                string
                f_1250_12152_12178(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 12152, 12178);
                    return return_v;
                }


                string
                f_1250_12180_12210(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 12180, 12210);
                    return return_v;
                }


                int
                f_1250_12129_12211(System.Management.Automation.CommandPathSearch
                this_param, string
                pattern, string
                directory)
                {
                    this_param.GetNewDirectoryResults(pattern, directory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 12129, 12211);
                    return 0;
                }


                string
                f_1250_12353_12395(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 12353, 12395);
                    return return_v;
                }


                int
                f_1250_12310_12396(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 12310, 12396);
                    return 0;
                }


                bool
                f_1250_12900_12933(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 12900, 12933);
                    return return_v;
                }


                int
                f_1250_12975_13053(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 12975, 13053);
                    return 0;
                }


                System.Collections.Generic.IEnumerator<string>
                f_1250_13239_13264(System.Collections.Generic.IEnumerable<string>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 13239, 13264);
                    return return_v;
                }


                bool
                f_1250_13290_13319(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 13290, 13319);
                    return return_v;
                }


                int
                f_1250_13361_13435(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 13361, 13435);
                    return 0;
                }


                string
                f_1250_13526_13552(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 13526, 13552);
                    return return_v;
                }


                string
                f_1250_13554_13584(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 13554, 13584);
                    return return_v;
                }


                int
                f_1250_13503_13585(System.Management.Automation.CommandPathSearch
                this_param, string
                pattern, string
                directory)
                {
                    this_param.GetNewDirectoryResults(pattern, directory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 13503, 13585);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 10520, 13656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 10520, 13656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Reset()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1250, 13785, 14142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 13829, 13883);

                _lookupPathsEnumerator = f_1250_13854_13882(_lookupPaths);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 13897, 13944);

                _patternEnumerator = f_1250_13918_13943(_patterns);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 13958, 14007);

                _currentDirectoryResults = f_1250_13985_14006();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 14021, 14099);

                _currentDirectoryResultsEnumerator = f_1250_14058_14098(_currentDirectoryResults);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 14113, 14131);

                _justReset = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1250, 13785, 14142);

                System.Collections.Generic.IEnumerator<string>
                f_1250_13854_13882(System.Management.Automation.LookupPathCollection
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 13854, 13882);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<string>
                f_1250_13918_13943(System.Collections.Generic.IEnumerable<string>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 13918, 13943);
                    return return_v;
                }


                string[]
                f_1250_13985_14006()
                {
                    var return_v = Array.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 13985, 14006);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<string>
                f_1250_14058_14098(System.Collections.Generic.IEnumerable<string>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 14058, 14098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 13785, 14142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 13785, 14142);
            }
        }

        string IEnumerator<string>.Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1250, 14555, 14824);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 14591, 14739) || true) && (_currentDirectoryResults == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 14591, 14739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 14669, 14720);

                        throw f_1250_14675_14719();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 14591, 14739);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 14759, 14809);

                    return f_1250_14766_14808(_currentDirectoryResultsEnumerator);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1250, 14555, 14824);

                    System.Management.Automation.PSInvalidOperationException
                    f_1250_14675_14719()
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 14675, 14719);
                        return return_v;
                    }


                    string
                    f_1250_14766_14808(System.Collections.Generic.IEnumerator<string>
                    this_param)
                    {
                        var return_v = this_param.Current;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 14766, 14808);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 14496, 14835);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 14496, 14835);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        object IEnumerator.Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1250, 14898, 14992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 14934, 14977);

                    return f_1250_14941_14976(((IEnumerator<string>)this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1250, 14898, 14992);

                    string
                    f_1250_14941_14976(System.Collections.Generic.IEnumerator<string>
                    this_param)
                    {
                        var return_v = this_param.Current;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 14941, 14976);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 14847, 15003);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 14847, 15003);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1250, 15156, 15261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 15202, 15210);

                f_1250_15202_15209(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 15224, 15250);

                f_1250_15224_15249(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1250, 15156, 15261);

                int
                f_1250_15202_15209(System.Management.Automation.CommandPathSearch
                this_param)
                {
                    this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 15202, 15209);
                    return 0;
                }


                int
                f_1250_15224_15249(System.Management.Automation.CommandPathSearch
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 15224, 15249);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 15156, 15261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 15156, 15261);
            }
        }

        private void GetNewDirectoryResults(string pattern, string directory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1250, 15773, 18881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 15867, 15901);

                IEnumerable<string>
                result = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 15951, 16040);

                    f_1250_15951_16039(CommandDiscovery.discoveryTracer, "Looking for {0} in {1}", pattern, directory);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 16120, 18031) || true) && (f_1250_16124_16151(directory))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 16120, 18031);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 16735, 18012) || true) && (f_1250_16739_16753(pattern) != 1 || (DynAbs.Tracing.TraceSender.Expression_False(1250, 16739, 16779) || f_1250_16762_16772(pattern, 0) != '.'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 16735, 18012);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 16829, 17989) || true) && (_useFuzzyMatch)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 16829, 17989);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 16905, 16936);

                                var
                                files = f_1250_16917_16935()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 16966, 17022);

                                var
                                matchingFiles = f_1250_16986_17021(directory)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 17052, 17373);
                                    foreach (string file in f_1250_17076_17089_I(matchingFiles))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 17052, 17373);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 17155, 17342) || true) && (f_1250_17159_17217(f_1250_17185_17207(file), pattern))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 17155, 17342);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 17291, 17307);

                                            f_1250_17291_17306(files, file);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 17155, 17342);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 17052, 17373);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1250, 1, 322);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1250, 1, 322);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 17405, 17571);

                                result = (DynAbs.Tracing.TraceSender.Conditional_F1(1250, 17414, 17449) || ((_postProcessEnumeratedFiles != null
                                && DynAbs.Tracing.TraceSender.Conditional_F2(1250, 17485, 17529)) || DynAbs.Tracing.TraceSender.Conditional_F3(1250, 17565, 17570))) ? f_1250_17485_17529(this, f_1250_17513_17528(files)) : files;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 16829, 17989);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 16829, 17989);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 17685, 17750);

                                var
                                matchingFiles = f_1250_17705_17749(directory, pattern)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 17780, 17962);

                                result = (DynAbs.Tracing.TraceSender.Conditional_F1(1250, 17789, 17824) || ((_postProcessEnumeratedFiles != null
                                && DynAbs.Tracing.TraceSender.Conditional_F2(1250, 17860, 17912)) || DynAbs.Tracing.TraceSender.Conditional_F3(1250, 17948, 17961))) ? f_1250_17860_17912(this, f_1250_17888_17911(matchingFiles)) : matchingFiles;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 16829, 17989);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 16735, 18012);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 16120, 18031);
                    }
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1250, 18060, 18188);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1250, 18060, 18188);
                    // The pattern contained illegal file system characters
                }
                catch (IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1250, 18202, 18351);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1250, 18202, 18351);
                    // A directory specified in the lookup path was not
                    // accessible
                }
                catch (UnauthorizedAccessException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1250, 18365, 18530);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1250, 18365, 18530);
                    // A directory specified in the lookup path was not
                    // accessible
                }
                catch (NotSupportedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1250, 18544, 18703);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1250, 18544, 18703);
                    // A directory specified in the lookup path was not
                    // accessible
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 18719, 18778);

                _currentDirectoryResults = result ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEnumerable<string>>(1250, 18746, 18777) ?? f_1250_18756_18777());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 18792, 18870);

                _currentDirectoryResultsEnumerator = f_1250_18829_18869(_currentDirectoryResults);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1250, 15773, 18881);

                int
                f_1250_15951_16039(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 15951, 16039);
                    return 0;
                }


                bool
                f_1250_16124_16151(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 16124, 16151);
                    return return_v;
                }


                int
                f_1250_16739_16753(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 16739, 16753);
                    return return_v;
                }


                char
                f_1250_16762_16772(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 16762, 16772);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1250_16917_16935()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 16917, 16935);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1250_16986_17021(string
                path)
                {
                    var return_v = Directory.EnumerateFiles(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 16986, 17021);
                    return return_v;
                }


                string?
                f_1250_17185_17207(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 17185, 17207);
                    return return_v;
                }


                bool
                f_1250_17159_17217(string
                string1, string
                string2)
                {
                    var return_v = FuzzyMatcher.IsFuzzyMatch(string1, string2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 17159, 17217);
                    return return_v;
                }


                int
                f_1250_17291_17306(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 17291, 17306);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1250_17076_17089_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 17076, 17089);
                    return return_v;
                }


                string[]
                f_1250_17513_17528(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 17513, 17528);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1250_17485_17529(System.Management.Automation.CommandPathSearch
                this_param, string[]
                arg)
                {
                    var return_v = this_param._postProcessEnumeratedFiles(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 17485, 17529);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1250_17705_17749(string
                path, string
                searchPattern)
                {
                    var return_v = Directory.EnumerateFiles(path, searchPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 17705, 17749);
                    return return_v;
                }


                string[]
                f_1250_17888_17911(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 17888, 17911);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1250_17860_17912(System.Management.Automation.CommandPathSearch
                this_param, string[]
                arg)
                {
                    var return_v = this_param._postProcessEnumeratedFiles(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 17860, 17912);
                    return return_v;
                }


                string[]
                f_1250_18756_18777()
                {
                    var return_v = Array.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 18756, 18777);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<string>
                f_1250_18829_18869(System.Collections.Generic.IEnumerable<string>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 18829, 18869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 15773, 18881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 15773, 18881);
            }
        }

        private IEnumerable<string> CheckAgainstAcceptableCommandNames(string[] fileNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1250, 18893, 20102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 19000, 19061);

                var
                baseNames = f_1250_19016_19060(f_1250_19016_19050(fileNames, Path.GetFileName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 19299, 19332);

                Collection<string>
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 19346, 20061) || true) && (f_1250_19350_19366(baseNames) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 19346, 20061);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 19404, 20046);
                        foreach (var name in f_1250_19425_19448_I(_acceptableCommandNames))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 19404, 20046);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 19499, 19504);
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 19490, 20027) || true) && (i < f_1250_19510_19526(baseNames))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 19528, 19531)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 19490, 20027))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 19490, 20027);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 19581, 20004) || true) && (f_1250_19585_19646(name, baseNames[i], StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1250, 19585, 19741) || (f_1250_19680_19699_M(!Platform.IsWindows) && (DynAbs.Tracing.TraceSender.Expression_True(1250, 19680, 19740) && f_1250_19703_19740(name)))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 19581, 20004);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 19799, 19886) || true) && (result == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 19799, 19886);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 19852, 19886);

                                            result = f_1250_19861_19885();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 19799, 19886);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 19916, 19941);

                                        f_1250_19916_19940(result, fileNames[i]);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1250, 19971, 19977);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 19581, 20004);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1250, 1, 538);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1250, 1, 538);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 19404, 20046);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1250, 1, 643);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1250, 1, 643);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 19346, 20061);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 20077, 20091);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1250, 18893, 20102);

                System.Collections.Generic.IEnumerable<string>
                f_1250_19016_19050(string[]
                source, System.Func<string, string>
                selector)
                {
                    var return_v = source.Select<string, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 19016, 19050);
                    return return_v;
                }


                string[]
                f_1250_19016_19060(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 19016, 19060);
                    return return_v;
                }


                int
                f_1250_19350_19366(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 19350, 19366);
                    return return_v;
                }


                int
                f_1250_19510_19526(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 19510, 19526);
                    return return_v;
                }


                bool
                f_1250_19585_19646(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 19585, 19646);
                    return return_v;
                }


                bool
                f_1250_19680_19699_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 19680, 19699);
                    return return_v;
                }


                bool
                f_1250_19703_19740(string
                path)
                {
                    var return_v = Platform.NonWindowsIsExecutable(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 19703, 19740);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1250_19861_19885()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 19861, 19885);
                    return return_v;
                }


                int
                f_1250_19916_19940(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 19916, 19940);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1250_19425_19448_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 19425, 19448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 18893, 20102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 18893, 20102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<string> JustCheckExtensions(string[] fileNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1250, 20114, 21057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 20416, 20449);

                Collection<string>
                result = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 20463, 21016);
                    foreach (var allowedExt in f_1250_20490_20505_I(_orderedPathExt))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 20463, 21016);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 20539, 21001);
                            foreach (var fileName in f_1250_20564_20573_I(fileNames))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 20539, 21001);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 20615, 20982) || true) && (f_1250_20619_20684(fileName, allowedExt, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1250, 20619, 20779) || (f_1250_20714_20733_M(!Platform.IsWindows) && (DynAbs.Tracing.TraceSender.Expression_True(1250, 20714, 20778) && f_1250_20737_20778(fileName)))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 20615, 20982);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 20829, 20912) || true) && (result == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1250, 20829, 20912);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 20878, 20912);

                                        result = f_1250_20887_20911();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 20829, 20912);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 20938, 20959);

                                    f_1250_20938_20958(result, fileName);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 20615, 20982);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 20539, 21001);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1250, 1, 463);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1250, 1, 463);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1250, 20463, 21016);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1250, 1, 554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1250, 1, 554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 21032, 21046);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1250, 20114, 21057);

                bool
                f_1250_20619_20684(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 20619, 20684);
                    return return_v;
                }


                bool
                f_1250_20714_20733_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 20714, 20733);
                    return return_v;
                }


                bool
                f_1250_20737_20778(string
                path)
                {
                    var return_v = Platform.NonWindowsIsExecutable(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 20737, 20778);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1250_20887_20911()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 20887, 20911);
                    return return_v;
                }


                int
                f_1250_20938_20958(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 20938, 20958);
                    return 0;
                }


                string[]
                f_1250_20564_20573_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 20564, 20573);
                    return return_v;
                }


                string[]
                f_1250_20490_20505_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 20490, 20505);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1250, 20114, 21057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 20114, 21057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LookupPathCollection _lookupPaths;

        private IEnumerator<string> _lookupPathsEnumerator;

        private IEnumerable<string> _currentDirectoryResults;

        private IEnumerator<string> _currentDirectoryResultsEnumerator;

        private IEnumerable<string> _patterns;

        private IEnumerator<string> _patternEnumerator;

        private ExecutionContext _context;

        private bool _justReset;

        private Func<string[], IEnumerable<string>> _postProcessEnumeratedFiles;

        private string[] _orderedPathExt;

        private Collection<string> _acceptableCommandNames;

        private bool _useFuzzyMatch;

        static CommandPathSearch()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1250, 486, 22927);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1250, 664, 732);
            s_tracer = f_1250_675_732("CommandSearch", "CommandSearch");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1250, 486, 22927);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1250, 486, 22927);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1250, 486, 22927);

        static System.Management.Automation.PSTraceSource
        f_1250_675_732(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 675, 732);
            return return_v;
        }


        int
        f_1250_1487_1523(System.Management.Automation.CommandPathSearch
        this_param, System.Collections.Generic.IEnumerable<string>
        commandPatterns, System.Collections.Generic.IEnumerable<string>
        searchPath, System.Management.Automation.ExecutionContext
        context)
        {
            this_param.Init(commandPatterns, searchPath, context);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 1487, 1523);
            return 0;
        }


        bool
        f_1250_2285_2303()
        {
            var return_v = Platform.IsWindows;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 2285, 2303);
            return return_v;
        }


        int
        f_1250_3224_3267(System.Management.Automation.CommandPathSearch
        this_param, string[]
        commandPatterns, System.Collections.Generic.IEnumerable<string>
        searchPath, System.Management.Automation.ExecutionContext
        context)
        {
            this_param.Init((System.Collections.Generic.IEnumerable<string>)commandPatterns, searchPath, context);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1250, 3224, 3267);
            return 0;
        }


        string[]
        f_1250_3300_3347()
        {
            var return_v = CommandDiscovery.PathExtensionsWithPs1Prepended;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1250, 3300, 3347);
            return return_v;
        }

    }
}

