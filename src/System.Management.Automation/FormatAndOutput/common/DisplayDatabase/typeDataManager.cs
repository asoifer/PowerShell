// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Threading;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class TypeInfoDataBaseManager
    {
        internal TypeInfoDataBase Database { get; private set; }

        internal object databaseLock;

        internal object updateDatabaseLock;

        internal bool isShared;

        private List<string> _formatFileList;

        internal bool DisableFormatTableUpdates { get; set; }

        internal TypeInfoDataBaseManager()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1127, 1388, 1526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 842, 898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 967, 994);
                this.databaseLock = f_1127_982_994();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 1068, 1101);
                this.updateDatabaseLock = f_1127_1089_1101();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 1201, 1209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 1241, 1256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 1269, 1322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 1447, 1464);

                isShared = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 1478, 1515);

                _formatFileList = f_1127_1496_1514();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1127, 1388, 1526);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 1388, 1526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 1388, 1526);
            }
        }

        internal TypeInfoDataBaseManager(
                    IEnumerable<string> formatFiles,
                    bool isShared,
                    AuthorizationManager authorizationManager,
                    PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1127, 2441, 4059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 842, 898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 967, 994);
                this.databaseLock = f_1127_982_994();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 1068, 1101);
                this.updateDatabaseLock = f_1127_1089_1101();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 1201, 1209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 1241, 1256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 1269, 1322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 2655, 2692);

                _formatFileList = f_1127_2673_2691();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 2708, 2808);

                Collection<PSSnapInTypeAndFormatErrors>
                filesToLoad = f_1127_2762_2807()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 2822, 2881);

                ConcurrentBag<string>
                errors = f_1127_2853_2880()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 2895, 3497);
                    foreach (string formatFile in f_1127_2925_2936_I(formatFiles))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 2895, 3497);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 2970, 3222) || true) && (f_1127_2974_3006(formatFile) || (DynAbs.Tracing.TraceSender.Expression_False(1127, 2974, 3042) || (!f_1127_3012_3041(formatFile))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 2970, 3222);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 3084, 3203);

                            throw f_1127_3090_3202("formatFiles", f_1127_3140_3189(), formatFile);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 2970, 3222);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 3242, 3341);

                        PSSnapInTypeAndFormatErrors
                        fileToLoad = f_1127_3283_3340(string.Empty, formatFile)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 3359, 3386);

                        fileToLoad.Errors = errors;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 3404, 3432);

                        f_1127_3404_3431(filesToLoad, fileToLoad);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 3450, 3482);

                        f_1127_3450_3481(_formatFileList, formatFile);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 2895, 3497);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1127, 1, 603);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1127, 1, 603);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 3513, 3595);

                PSPropertyExpressionFactory
                expressionFactory = f_1127_3561_3594()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 3609, 3654);

                List<XmlLoaderLoggerEntry>
                logEntries = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 3701, 3803);

                f_1127_3701_3802(this, filesToLoad, expressionFactory, true, authorizationManager, host, false, out logEntries);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 3817, 3842);

                this.isShared = isShared;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 3936, 4048) || true) && (f_1127_3940_3952(errors) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 3936, 4048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 3990, 4033);

                    throw f_1127_3996_4032(errors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 3936, 4048);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1127, 2441, 4059);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 2441, 4059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 2441, 4059);
            }
        }

        internal TypeInfoDataBase GetTypeInfoDataBase()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1127, 4093, 4192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 4165, 4181);

                return f_1127_4172_4180();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1127, 4093, 4192);

                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                f_1127_4172_4180()
                {
                    var return_v = Database;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 4172, 4180);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 4093, 4192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 4093, 4192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Add(string formatFile, bool shouldPrepend)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1127, 4684, 5331);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 4765, 5004) || true) && (f_1127_4769_4801(formatFile) || (DynAbs.Tracing.TraceSender.Expression_False(1127, 4769, 4837) || (!f_1127_4807_4836(formatFile))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 4765, 5004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 4871, 4989);

                    throw f_1127_4877_4988("formatFile", f_1127_4926_4975(), formatFile);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 4765, 5004);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 5026, 5041);

                lock (_formatFileList)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 5075, 5305) || true) && (shouldPrepend)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 5075, 5305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 5134, 5172);

                        f_1127_5134_5171(_formatFileList, 0, formatFile);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 5075, 5305);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 5075, 5305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 5254, 5286);

                        f_1127_5254_5285(_formatFileList, formatFile);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 5075, 5305);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1127, 4684, 5331);

                bool
                f_1127_4769_4801(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 4769, 4801);
                    return return_v;
                }


                bool
                f_1127_4807_4836(string
                path)
                {
                    var return_v = Path.IsPathRooted(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 4807, 4836);
                    return return_v;
                }


                string
                f_1127_4926_4975()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.FormatFileNotRooted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 4926, 4975);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1127_4877_4988(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 4877, 4988);
                    return return_v;
                }


                int
                f_1127_5134_5171(System.Collections.Generic.List<string>
                this_param, int
                index, string
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 5134, 5171);
                    return 0;
                }


                int
                f_1127_5254_5285(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 5254, 5285);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 4684, 5331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 4684, 5331);
            }
        }

        internal void Remove(string formatFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1127, 5615, 5795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 5685, 5700);
                lock (_formatFileList)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 5734, 5769);

                    f_1127_5734_5768(_formatFileList, formatFile);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1127, 5615, 5795);

                bool
                f_1127_5734_5768(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 5734, 5768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 5615, 5795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 5615, 5795);
            }
        }

        internal void AddFormatData(IEnumerable<ExtendedTypeDefinition> formatData, bool shouldPrepend)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1127, 6332, 8845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 6452, 6563);

                f_1127_6452_6562(isShared, "this method should only be called from FormatTable to update a shared database");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 6579, 6679);

                Collection<PSSnapInTypeAndFormatErrors>
                filesToLoad = f_1127_6633_6678()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 6693, 6752);

                ConcurrentBag<string>
                errors = f_1127_6724_6751()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 6766, 7333) || true) && (shouldPrepend)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 6766, 7333);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 6817, 7143);
                        foreach (ExtendedTypeDefinition typeDefinition in f_1127_6867_6877_I(formatData))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 6817, 7143);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 6919, 7023);

                            PSSnapInTypeAndFormatErrors
                            entryToLoad = f_1127_6961_7022(string.Empty, typeDefinition)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 7045, 7073);

                            entryToLoad.Errors = errors;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 7095, 7124);

                            f_1127_7095_7123(filesToLoad, entryToLoad);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 6817, 7143);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1127, 1, 327);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1127, 1, 327);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 7224, 7318) || true) && (f_1127_7228_7245(filesToLoad) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 7224, 7318);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 7292, 7299);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 7224, 7318);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 6766, 7333);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 7355, 7370);

                lock (_formatFileList)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 7404, 7708);
                        foreach (string formatFile in f_1127_7434_7449_I(_formatFileList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 7404, 7708);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 7491, 7590);

                            PSSnapInTypeAndFormatErrors
                            fileToLoad = f_1127_7532_7589(string.Empty, formatFile)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 7612, 7639);

                            fileToLoad.Errors = errors;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 7661, 7689);

                            f_1127_7661_7688(filesToLoad, fileToLoad);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 7404, 7708);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1127, 1, 305);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1127, 1, 305);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 7739, 8327) || true) && (!shouldPrepend)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 7739, 8327);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 7791, 8117);
                        foreach (ExtendedTypeDefinition typeDefinition in f_1127_7841_7851_I(formatData))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 7791, 8117);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 7893, 7997);

                            PSSnapInTypeAndFormatErrors
                            entryToLoad = f_1127_7935_7996(string.Empty, typeDefinition)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 8019, 8047);

                            entryToLoad.Errors = errors;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 8069, 8098);

                            f_1127_8069_8097(filesToLoad, entryToLoad);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 7791, 8117);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1127, 1, 327);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1127, 1, 327);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 8198, 8312) || true) && (f_1127_8202_8219(filesToLoad) == f_1127_8223_8244(_formatFileList))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 8198, 8312);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 8286, 8293);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 8198, 8312);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 7739, 8327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 8343, 8425);

                PSPropertyExpressionFactory
                expressionFactory = f_1127_8391_8424()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 8439, 8484);

                List<XmlLoaderLoggerEntry>
                logEntries = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 8541, 8628);

                f_1127_8541_8627(this, filesToLoad, expressionFactory, false, null, null, false, out logEntries);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 8722, 8834) || true) && (f_1127_8726_8738(errors) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 8722, 8834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 8776, 8819);

                    throw f_1127_8782_8818(errors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 8722, 8834);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1127, 6332, 8845);

                int
                f_1127_6452_6562(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 6452, 6562);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                f_1127_6633_6678()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 6633, 6678);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentBag<string>
                f_1127_6724_6751()
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentBag<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 6724, 6751);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                f_1127_6961_7022(string
                psSnapinName, System.Management.Automation.ExtendedTypeDefinition
                typeDefinition)
                {
                    var return_v = new System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors(psSnapinName, typeDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 6961, 7022);
                    return return_v;
                }


                int
                f_1127_7095_7123(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                this_param, System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 7095, 7123);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>
                f_1127_6867_6877_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 6867, 6877);
                    return return_v;
                }


                int
                f_1127_7228_7245(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 7228, 7245);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                f_1127_7532_7589(string
                psSnapinName, string
                fullPath)
                {
                    var return_v = new System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors(psSnapinName, fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 7532, 7589);
                    return return_v;
                }


                int
                f_1127_7661_7688(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                this_param, System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 7661, 7688);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1127_7434_7449_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 7434, 7449);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                f_1127_7935_7996(string
                psSnapinName, System.Management.Automation.ExtendedTypeDefinition
                typeDefinition)
                {
                    var return_v = new System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors(psSnapinName, typeDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 7935, 7996);
                    return return_v;
                }


                int
                f_1127_8069_8097(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                this_param, System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 8069, 8097);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>
                f_1127_7841_7851_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 7841, 7851);
                    return return_v;
                }


                int
                f_1127_8202_8219(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 8202, 8219);
                    return return_v;
                }


                int
                f_1127_8223_8244(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 8223, 8244);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                f_1127_8391_8424()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 8391, 8424);
                    return return_v;
                }


                bool
                f_1127_8541_8627(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                files, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, bool
                acceptLoadingErrors, System.Management.Automation.AuthorizationManager
                authorizationManager, System.Management.Automation.Host.PSHost
                host, bool
                preValidated, out System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                logEntries)
                {
                    var return_v = this_param.LoadFromFile(files, expressionFactory, acceptLoadingErrors, authorizationManager, host, preValidated, out logEntries);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 8541, 8627);
                    return return_v;
                }


                int
                f_1127_8726_8738(System.Collections.Concurrent.ConcurrentBag<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 8726, 8738);
                    return return_v;
                }


                System.Management.Automation.Runspaces.FormatTableLoadException
                f_1127_8782_8818(System.Collections.Concurrent.ConcurrentBag<string>
                loadErrors)
                {
                    var return_v = new System.Management.Automation.Runspaces.FormatTableLoadException(loadErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 8782, 8818);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 6332, 8845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 6332, 8845);
            }
        }

        internal void Update(AuthorizationManager authorizationManager, PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1127, 9477, 10398);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 9578, 9663) || true) && (f_1127_9582_9607())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 9578, 9663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 9641, 9648);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 9578, 9663);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 9679, 9853) || true) && (isShared)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 9679, 9853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 9725, 9838);

                    throw f_1127_9731_9837(f_1127_9774_9836());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 9679, 9853);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 9869, 9969);

                Collection<PSSnapInTypeAndFormatErrors>
                filesToLoad = f_1127_9923_9968()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 9989, 10004);
                lock (_formatFileList)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 10038, 10293);
                        foreach (string formatFile in f_1127_10068_10083_I(_formatFileList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 10038, 10293);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 10125, 10224);

                            PSSnapInTypeAndFormatErrors
                            fileToLoad = f_1127_10166_10223(string.Empty, formatFile)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 10246, 10274);

                            f_1127_10246_10273(filesToLoad, fileToLoad);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 10038, 10293);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1127, 1, 256);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1127, 1, 256);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 10324, 10387);

                f_1127_10324_10386(this, filesToLoad, authorizationManager, host, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1127, 9477, 10398);

                bool
                f_1127_9582_9607()
                {
                    var return_v = DisableFormatTableUpdates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 9582, 9607);
                    return return_v;
                }


                string
                f_1127_9774_9836()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.SharedFormatTableCannotBeUpdated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 9774, 9836);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1127_9731_9837(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 9731, 9837);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                f_1127_9923_9968()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 9923, 9968);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                f_1127_10166_10223(string
                psSnapinName, string
                fullPath)
                {
                    var return_v = new System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors(psSnapinName, fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 10166, 10223);
                    return return_v;
                }


                int
                f_1127_10246_10273(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                this_param, System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 10246, 10273);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1127_10068_10083_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 10068, 10083);
                    return return_v;
                }


                int
                f_1127_10324_10386(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                mshsnapins, System.Management.Automation.AuthorizationManager
                authorizationManager, System.Management.Automation.Host.PSHost
                host, bool
                preValidated)
                {
                    this_param.UpdateDataBase(mshsnapins, authorizationManager, host, preValidated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 10324, 10386);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 9477, 10398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 9477, 10398);
            }
        }

        internal void UpdateDataBase(
                    Collection<PSSnapInTypeAndFormatErrors> mshsnapins,
                    AuthorizationManager authorizationManager,
                    PSHost host,
                    bool preValidated
                    )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1127, 11425, 12238);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 11672, 11757) || true) && (f_1127_11676_11701())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 11672, 11757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 11735, 11742);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 11672, 11757);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 11773, 11947) || true) && (isShared)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 11773, 11947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 11819, 11932);

                    throw f_1127_11825_11931(f_1127_11868_11930());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 11773, 11947);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 11963, 12045);

                PSPropertyExpressionFactory
                expressionFactory = f_1127_12011_12044()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 12059, 12104);

                List<XmlLoaderLoggerEntry>
                logEntries = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 12118, 12227);

                f_1127_12118_12226(this, mshsnapins, expressionFactory, false, authorizationManager, host, preValidated, out logEntries);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1127, 11425, 12238);

                bool
                f_1127_11676_11701()
                {
                    var return_v = DisableFormatTableUpdates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 11676, 11701);
                    return return_v;
                }


                string
                f_1127_11868_11930()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.SharedFormatTableCannotBeUpdated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 11868, 11930);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1127_11825_11931(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 11825, 11931);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                f_1127_12011_12044()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 12011, 12044);
                    return return_v;
                }


                bool
                f_1127_12118_12226(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                files, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, bool
                acceptLoadingErrors, System.Management.Automation.AuthorizationManager
                authorizationManager, System.Management.Automation.Host.PSHost
                host, bool
                preValidated, out System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                logEntries)
                {
                    var return_v = this_param.LoadFromFile(files, expressionFactory, acceptLoadingErrors, authorizationManager, host, preValidated, out logEntries);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 12118, 12226);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 11425, 12238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 11425, 12238);
            }
        }

        internal bool LoadFromFile(
                    Collection<PSSnapInTypeAndFormatErrors> files,
                    PSPropertyExpressionFactory expressionFactory,
                    bool acceptLoadingErrors,
                    AuthorizationManager authorizationManager,
                    PSHost host,
                    bool preValidated,
                    out List<XmlLoaderLoggerEntry> logEntries)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1127, 13457, 15109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 13838, 13851);

                bool
                success
                = default(bool);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 13901, 13937);

                    TypeInfoDataBase
                    newDataBase = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 13961, 13979);
                    lock (updateDatabaseLock)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 14021, 14151);

                        newDataBase = f_1127_14035_14150(files, expressionFactory, authorizationManager, host, preValidated, out logEntries, out success);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 14297, 14309);
                    // if we have a valid database, assign it to the
                    // current database
                    lock (databaseLock)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 14351, 14435) || true) && (acceptLoadingErrors || (DynAbs.Tracing.TraceSender.Expression_False(1127, 14355, 14385) || success))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 14351, 14435);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 14412, 14435);

                            Database = newDataBase;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 14351, 14435);
                        }
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1127, 14483, 15067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 14658, 14670);
                    // if, for any reason, we failed the load, we initialize the
                    // data base to an empty instance
                    lock (databaseLock)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 14712, 15033) || true) && (f_1127_14716_14724() == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 14712, 15033);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 14782, 14837);

                            TypeInfoDataBase
                            tempDataBase = f_1127_14814_14836()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 14863, 14898);

                            f_1127_14863_14897(tempDataBase);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 14924, 14960);

                            f_1127_14924_14959(tempDataBase);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 14986, 15010);

                            Database = tempDataBase;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 14712, 15033);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1127, 14483, 15067);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 15083, 15098);

                return success;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1127, 13457, 15109);

                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                f_1127_14035_14150(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                files, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, System.Management.Automation.AuthorizationManager
                authorizationManager, System.Management.Automation.Host.PSHost
                host, bool
                preValidated, out System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                logEntries, out bool
                success)
                {
                    var return_v = LoadFromFileHelper(files, expressionFactory, authorizationManager, host, preValidated, out logEntries, out success);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 14035, 14150);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                f_1127_14716_14724()
                {
                    var return_v = Database;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 14716, 14724);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                f_1127_14814_14836()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 14814, 14836);
                    return return_v;
                }


                int
                f_1127_14863_14897(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db)
                {
                    AddPreLoadIntrinsics(db);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 14863, 14897);
                    return 0;
                }


                int
                f_1127_14924_14959(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db)
                {
                    AddPostLoadIntrinsics(db);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 14924, 14959);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 13457, 15109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 13457, 15109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeInfoDataBase LoadFromFileHelper(
                    Collection<PSSnapInTypeAndFormatErrors> files,
                    PSPropertyExpressionFactory expressionFactory,
                    AuthorizationManager authorizationManager,
                    PSHost host,
                    bool preValidated,
                    out List<XmlLoaderLoggerEntry> logEntries,
                    out bool success)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1127, 16234, 19440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 16631, 16646);

                success = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 16726, 16772);

                logEntries = f_1127_16739_16771();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 16835, 16880);

                TypeInfoDataBase
                db = f_1127_16857_16879()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 16972, 16997);

                f_1127_16972_16996(db);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 17013, 17066);

                var
                etwEnabled = f_1127_17030_17065(RunspaceEventSource.Log)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 17174, 19303);
                    foreach (PSSnapInTypeAndFormatErrors file in f_1127_17219_17224_I(files))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 17174, 19303);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 17337, 17594) || true) && (f_1127_17341_17356(file) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 17337, 17594);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 17406, 17544);

                            f_1127_17406_17543(f_1127_17427_17442(file), expressionFactory, logEntries, ref success, file, db, isBuiltInFormatData: false, isForHelp: false);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 17566, 17575);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 17337, 17594);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 17614, 17692) || true) && (etwEnabled)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 17614, 17692);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 17630, 17692);

                            f_1127_17630_17691(RunspaceEventSource.Log, f_1127_17677_17690(file));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 17614, 17692);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 17712, 19191) || true) && (!f_1127_17717_17785(file, db, expressionFactory, logEntries, ref success))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 17712, 19191);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 17903, 18051);

                            XmlFileLoadInfo
                            info =
                            f_1127_17951_18050(f_1127_17971_18002(f_1127_17988_18001(file)), f_1127_18004_18017(file), f_1127_18019_18030(file), f_1127_18032_18049(file))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 18073, 19172);
                            using (TypeInfoDataBaseLoader
                            loader = f_1127_18112_18140()
                            )
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 18190, 18331) || true) && (!f_1127_18195_18284(loader, info, db, expressionFactory, authorizationManager, host, preValidated))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 18190, 18331);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 18315, 18331);

                                    success = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 18190, 18331);
                                }
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 18359, 19027);
                                    foreach (XmlLoaderLoggerEntry entry in f_1127_18398_18415_I(f_1127_18398_18415(loader)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 18359, 19027);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 18552, 19000) || true) && (entry.entryType == XmlLoaderLoggerEntry.EntryType.Error)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 18552, 19000);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 18677, 18810);

                                            string
                                            mshsnapinMessage = f_1127_18703_18809(f_1127_18721_18774(), info.psSnapinName, entry.message)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 18844, 18878);

                                            f_1127_18844_18877(info.errors, mshsnapinMessage);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 18912, 18969) || true) && (entry.failToLoadFile)
                                            )
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 18912, 18969);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 18940, 18967);

                                                file.FailToLoadFile = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 18912, 18969);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 18552, 19000);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 18359, 19027);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1127, 1, 669);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1127, 1, 669);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 19110, 19149);

                                f_1127_19110_19148(                        // now aggregate the entries...
                                                        logEntries, f_1127_19130_19147(loader));
                                DynAbs.Tracing.TraceSender.TraceExitUsing(1127, 18073, 19172);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 17712, 19191);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 19211, 19288) || true) && (etwEnabled)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 19211, 19288);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 19227, 19288);

                            f_1127_19227_19287(RunspaceEventSource.Log, f_1127_19273_19286(file));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 19211, 19288);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 17174, 19303);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1127, 1, 2130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1127, 1, 2130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 19377, 19403);

                f_1127_19377_19402(db);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 19419, 19429);

                return db;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1127, 16234, 19440);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                f_1127_16739_16771()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 16739, 16771);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                f_1127_16857_16879()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 16857, 16879);
                    return return_v;
                }


                int
                f_1127_16972_16996(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db)
                {
                    AddPreLoadIntrinsics(db);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 16972, 16996);
                    return 0;
                }


                bool
                f_1127_17030_17065(System.Management.Automation.Runspaces.RunspaceEventSource
                this_param)
                {
                    var return_v = this_param.IsEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 17030, 17065);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1127_17341_17356(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                this_param)
                {
                    var return_v = this_param.FormatData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 17341, 17356);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1127_17427_17442(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                this_param)
                {
                    var return_v = this_param.FormatData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 17427, 17442);
                    return return_v;
                }


                int
                f_1127_17406_17543(System.Management.Automation.ExtendedTypeDefinition
                formatData, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                logEntries, ref bool
                success, System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                file, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, bool
                isBuiltInFormatData, bool
                isForHelp)
                {
                    LoadFormatDataHelper(formatData, expressionFactory, logEntries, ref success, file, db, isBuiltInFormatData: isBuiltInFormatData, isForHelp: isForHelp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 17406, 17543);
                    return 0;
                }


                string
                f_1127_17677_17690(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                this_param)
                {
                    var return_v = this_param.FullPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 17677, 17690);
                    return return_v;
                }


                int
                f_1127_17630_17691(System.Management.Automation.Runspaces.RunspaceEventSource
                this_param, string
                FileName)
                {
                    this_param.ProcessFormatFileStart(FileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 17630, 17691);
                    return 0;
                }


                bool
                f_1127_17717_17785(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                file, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                logEntries, ref bool
                success)
                {
                    var return_v = ProcessBuiltin(file, db, expressionFactory, logEntries, ref success);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 17717, 17785);
                    return return_v;
                }


                string
                f_1127_17988_18001(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                this_param)
                {
                    var return_v = this_param.FullPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 17988, 18001);
                    return return_v;
                }


                string?
                f_1127_17971_18002(string
                path)
                {
                    var return_v = Path.GetPathRoot(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 17971, 18002);
                    return return_v;
                }


                string
                f_1127_18004_18017(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                this_param)
                {
                    var return_v = this_param.FullPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 18004, 18017);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentBag<string>
                f_1127_18019_18030(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                this_param)
                {
                    var return_v = this_param.Errors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 18019, 18030);
                    return return_v;
                }


                string
                f_1127_18032_18049(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                this_param)
                {
                    var return_v = this_param.PSSnapinName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 18032, 18049);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.XmlFileLoadInfo
                f_1127_17951_18050(string
                dir, string
                path, System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                psSnapinName)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.XmlFileLoadInfo(dir, path, errors, psSnapinName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 17951, 18050);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                f_1127_18112_18140()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 18112, 18140);
                    return return_v;
                }


                bool
                f_1127_18195_18284(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.XmlFileLoadInfo
                info, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, System.Management.Automation.AuthorizationManager
                authorizationManager, System.Management.Automation.Host.PSHost
                host, bool
                preValidated)
                {
                    var return_v = this_param.LoadXmlFile(info, db, expressionFactory, authorizationManager, host, preValidated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 18195, 18284);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                f_1127_18398_18415(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.LogEntries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 18398, 18415);
                    return return_v;
                }


                string
                f_1127_18721_18774()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.MshSnapinQualifiedError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 18721, 18774);
                    return return_v;
                }


                string
                f_1127_18703_18809(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 18703, 18809);
                    return return_v;
                }


                int
                f_1127_18844_18877(System.Collections.Concurrent.ConcurrentBag<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 18844, 18877);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                f_1127_18398_18415_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 18398, 18415);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                f_1127_19130_19147(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.LogEntries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 19130, 19147);
                    return return_v;
                }


                int
                f_1127_19110_19148(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 19110, 19148);
                    return 0;
                }


                string
                f_1127_19273_19286(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                this_param)
                {
                    var return_v = this_param.FullPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 19273, 19286);
                    return return_v;
                }


                int
                f_1127_19227_19287(System.Management.Automation.Runspaces.RunspaceEventSource
                this_param, string
                FileName)
                {
                    this_param.ProcessFormatFileStop(FileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 19227, 19287);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                f_1127_17219_17224_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 17219, 17224);
                    return return_v;
                }


                int
                f_1127_19377_19402(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db)
                {
                    AddPostLoadIntrinsics(db);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 19377, 19402);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 16234, 19440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 16234, 19440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void LoadFormatDataHelper(
                    ExtendedTypeDefinition formatData,
                    PSPropertyExpressionFactory expressionFactory, List<XmlLoaderLoggerEntry> logEntries, ref bool success,
                    PSSnapInTypeAndFormatErrors file, TypeInfoDataBase db,
                    bool isBuiltInFormatData,
                    bool isForHelp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1127, 19452, 20750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 19819, 20739);
                using (TypeInfoDataBaseLoader
                loader = f_1127_19858_19886()
                )
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 19920, 20056) || true) && (!f_1127_19925_20017(loader, formatData, db, expressionFactory, isBuiltInFormatData, isForHelp))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 19920, 20056);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 20040, 20056);

                        success = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 19920, 20056);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 20076, 20618);
                        foreach (XmlLoaderLoggerEntry entry in f_1127_20115_20132_I(f_1127_20115_20132(loader)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 20076, 20618);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 20245, 20599) || true) && (entry.entryType == XmlLoaderLoggerEntry.EntryType.Error)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 20245, 20599);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 20354, 20516);

                                string
                                mshsnapinMessage = f_1127_20380_20515(f_1127_20398_20451(), f_1127_20482_20499(file), entry.message)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 20542, 20576);

                                f_1127_20542_20575(f_1127_20542_20553(file), mshsnapinMessage);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 20245, 20599);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 20076, 20618);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1127, 1, 543);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1127, 1, 543);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 20685, 20724);

                    f_1127_20685_20723(                // now aggregate the entries...
                                    logEntries, f_1127_20705_20722(loader));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1127, 19819, 20739);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1127, 19452, 20750);

                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                f_1127_19858_19886()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 19858, 19886);
                    return return_v;
                }


                bool
                f_1127_19925_20017(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.ExtendedTypeDefinition
                typeDefinition, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, bool
                isBuiltInFormatData, bool
                isForHelp)
                {
                    var return_v = this_param.LoadFormattingData(typeDefinition, db, expressionFactory, isBuiltInFormatData, isForHelp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 19925, 20017);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                f_1127_20115_20132(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.LogEntries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 20115, 20132);
                    return return_v;
                }


                string
                f_1127_20398_20451()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.MshSnapinQualifiedError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 20398, 20451);
                    return return_v;
                }


                string
                f_1127_20482_20499(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                this_param)
                {
                    var return_v = this_param.PSSnapinName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 20482, 20499);
                    return return_v;
                }


                string
                f_1127_20380_20515(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 20380, 20515);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentBag<string>
                f_1127_20542_20553(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                this_param)
                {
                    var return_v = this_param.Errors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 20542, 20553);
                    return return_v;
                }


                int
                f_1127_20542_20575(System.Collections.Concurrent.ConcurrentBag<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 20542, 20575);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                f_1127_20115_20132_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 20115, 20132);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                f_1127_20705_20722(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.LogEntries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 20705, 20722);
                    return return_v;
                }


                int
                f_1127_20685_20723(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 20685, 20723);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 19452, 20750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 19452, 20750);
            }
        }

        private delegate IEnumerable<ExtendedTypeDefinition> TypeGenerator();

        private static Dictionary<string, Tuple<bool, TypeGenerator>> s_builtinGenerators;

        private static Tuple<bool, TypeGenerator> GetBuiltin(bool isForHelp, TypeGenerator generator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1127, 20935, 21124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 21053, 21113);

                return f_1127_21060_21112(isForHelp, generator);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1127, 20935, 21124);

                System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                f_1127_21060_21112(bool
                item1, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator
                item2)
                {
                    var return_v = new System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 21060, 21112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 20935, 21124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 20935, 21124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ProcessBuiltin(
                    PSSnapInTypeAndFormatErrors file,
                    TypeInfoDataBase db,
                    PSPropertyExpressionFactory expressionFactory,
                    List<XmlLoaderLoggerEntry> logEntries,
                    ref bool success)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1127, 21136, 23734);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 21420, 23390) || true) && (s_builtinGenerators == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 21420, 23390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 21485, 21594);

                    var
                    builtInGenerators = f_1127_21509_21593(f_1127_21560_21592())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 21614, 21658);

                    var
                    psHome = f_1127_21627_21657()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 21678, 21811);

                    f_1127_21678_21810(
                                    builtInGenerators, f_1127_21700_21749(psHome, "Certificate.format.ps1xml"), f_1127_21751_21809(false, Certificate_Format_Ps1Xml.GetFormatData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 21829, 21962);

                    f_1127_21829_21961(builtInGenerators, f_1127_21851_21900(psHome, "Diagnostics.Format.ps1xml"), f_1127_21902_21960(false, Diagnostics_Format_Ps1Xml.GetFormatData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 21980, 22113);

                    f_1127_21980_22112(builtInGenerators, f_1127_22002_22051(psHome, "DotNetTypes.format.ps1xml"), f_1127_22053_22111(false, DotNetTypes_Format_Ps1Xml.GetFormatData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 22131, 22252);

                    f_1127_22131_22251(builtInGenerators, f_1127_22153_22196(psHome, "Event.Format.ps1xml"), f_1127_22198_22250(false, Event_Format_Ps1Xml.GetFormatData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 22270, 22401);

                    f_1127_22270_22400(builtInGenerators, f_1127_22292_22340(psHome, "FileSystem.format.ps1xml"), f_1127_22342_22399(false, FileSystem_Format_Ps1Xml.GetFormatData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 22419, 22537);

                    f_1127_22419_22536(builtInGenerators, f_1127_22441_22483(psHome, "Help.format.ps1xml"), f_1127_22485_22535(true, Help_Format_Ps1Xml.GetFormatData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 22555, 22677);

                    f_1127_22555_22676(builtInGenerators, f_1127_22577_22621(psHome, "HelpV3.format.ps1xml"), f_1127_22623_22675(true, HelpV3_Format_Ps1Xml.GetFormatData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 22695, 22834);

                    f_1127_22695_22833(builtInGenerators, f_1127_22717_22769(psHome, "PowerShellCore.format.ps1xml"), f_1127_22771_22832(false, PowerShellCore_Format_Ps1Xml.GetFormatData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 22852, 22993);

                    f_1127_22852_22992(builtInGenerators, f_1127_22874_22927(psHome, "PowerShellTrace.format.ps1xml"), f_1127_22929_22991(false, PowerShellTrace_Format_Ps1Xml.GetFormatData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 23011, 23138);

                    f_1127_23011_23137(builtInGenerators, f_1127_23033_23079(psHome, "Registry.format.ps1xml"), f_1127_23081_23136(false, Registry_Format_Ps1Xml.GetFormatData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 23156, 23277);

                    f_1127_23156_23276(builtInGenerators, f_1127_23178_23221(psHome, "WSMan.Format.ps1xml"), f_1127_23223_23275(false, WSMan_Format_Ps1Xml.GetFormatData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 23297, 23375);

                    f_1127_23297_23374(ref s_builtinGenerators, builtInGenerators, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 21420, 23390);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 23406, 23443);

                Tuple<bool, TypeGenerator>
                generator
                = default(Tuple<bool, TypeGenerator>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 23457, 23555) || true) && (!f_1127_23462_23523(s_builtinGenerators, f_1127_23494_23507(file), out generator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 23457, 23555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 23542, 23555);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 23457, 23555);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 23571, 23697);

                f_1127_23571_23696(f_1127_23607_23624(generator), db, expressionFactory, file, logEntries, f_1127_23667_23682(generator), ref success);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 23711, 23723);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1127, 21136, 23734);

                System.StringComparer
                f_1127_21560_21592()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 21560, 21592);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                f_1127_21509_21593(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 21509, 21593);
                    return return_v;
                }


                string
                f_1127_21627_21657()
                {
                    var return_v = Utils.DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 21627, 21657);
                    return return_v;
                }


                string
                f_1127_21700_21749(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 21700, 21749);
                    return return_v;
                }


                System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                f_1127_21751_21809(bool
                isForHelp, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator
                generator)
                {
                    var return_v = GetBuiltin(isForHelp, generator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 21751, 21809);
                    return return_v;
                }


                int
                f_1127_21678_21810(System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                this_param, string
                key, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 21678, 21810);
                    return 0;
                }


                string
                f_1127_21851_21900(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 21851, 21900);
                    return return_v;
                }


                System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                f_1127_21902_21960(bool
                isForHelp, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator
                generator)
                {
                    var return_v = GetBuiltin(isForHelp, generator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 21902, 21960);
                    return return_v;
                }


                int
                f_1127_21829_21961(System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                this_param, string
                key, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 21829, 21961);
                    return 0;
                }


                string
                f_1127_22002_22051(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22002, 22051);
                    return return_v;
                }


                System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                f_1127_22053_22111(bool
                isForHelp, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator
                generator)
                {
                    var return_v = GetBuiltin(isForHelp, generator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22053, 22111);
                    return return_v;
                }


                int
                f_1127_21980_22112(System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                this_param, string
                key, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 21980, 22112);
                    return 0;
                }


                string
                f_1127_22153_22196(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22153, 22196);
                    return return_v;
                }


                System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                f_1127_22198_22250(bool
                isForHelp, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator
                generator)
                {
                    var return_v = GetBuiltin(isForHelp, generator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22198, 22250);
                    return return_v;
                }


                int
                f_1127_22131_22251(System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                this_param, string
                key, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22131, 22251);
                    return 0;
                }


                string
                f_1127_22292_22340(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22292, 22340);
                    return return_v;
                }


                System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                f_1127_22342_22399(bool
                isForHelp, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator
                generator)
                {
                    var return_v = GetBuiltin(isForHelp, generator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22342, 22399);
                    return return_v;
                }


                int
                f_1127_22270_22400(System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                this_param, string
                key, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22270, 22400);
                    return 0;
                }


                string
                f_1127_22441_22483(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22441, 22483);
                    return return_v;
                }


                System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                f_1127_22485_22535(bool
                isForHelp, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator
                generator)
                {
                    var return_v = GetBuiltin(isForHelp, generator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22485, 22535);
                    return return_v;
                }


                int
                f_1127_22419_22536(System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                this_param, string
                key, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22419, 22536);
                    return 0;
                }


                string
                f_1127_22577_22621(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22577, 22621);
                    return return_v;
                }


                System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                f_1127_22623_22675(bool
                isForHelp, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator
                generator)
                {
                    var return_v = GetBuiltin(isForHelp, generator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22623, 22675);
                    return return_v;
                }


                int
                f_1127_22555_22676(System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                this_param, string
                key, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22555, 22676);
                    return 0;
                }


                string
                f_1127_22717_22769(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22717, 22769);
                    return return_v;
                }


                System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                f_1127_22771_22832(bool
                isForHelp, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator
                generator)
                {
                    var return_v = GetBuiltin(isForHelp, generator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22771, 22832);
                    return return_v;
                }


                int
                f_1127_22695_22833(System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                this_param, string
                key, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22695, 22833);
                    return 0;
                }


                string
                f_1127_22874_22927(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22874, 22927);
                    return return_v;
                }


                System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                f_1127_22929_22991(bool
                isForHelp, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator
                generator)
                {
                    var return_v = GetBuiltin(isForHelp, generator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22929, 22991);
                    return return_v;
                }


                int
                f_1127_22852_22992(System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                this_param, string
                key, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 22852, 22992);
                    return 0;
                }


                string
                f_1127_23033_23079(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 23033, 23079);
                    return return_v;
                }


                System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                f_1127_23081_23136(bool
                isForHelp, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator
                generator)
                {
                    var return_v = GetBuiltin(isForHelp, generator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 23081, 23136);
                    return return_v;
                }


                int
                f_1127_23011_23137(System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                this_param, string
                key, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 23011, 23137);
                    return 0;
                }


                string
                f_1127_23178_23221(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 23178, 23221);
                    return return_v;
                }


                System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                f_1127_23223_23275(bool
                isForHelp, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator
                generator)
                {
                    var return_v = GetBuiltin(isForHelp, generator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 23223, 23275);
                    return return_v;
                }


                int
                f_1127_23156_23276(System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                this_param, string
                key, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 23156, 23276);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                f_1127_23297_23374(ref System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                location1, System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                value, System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 23297, 23374);
                    return return_v;
                }


                string
                f_1127_23494_23507(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                this_param)
                {
                    var return_v = this_param.FullPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 23494, 23507);
                    return return_v;
                }


                bool
                f_1127_23462_23523(System.Collections.Generic.Dictionary<string, System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>>
                this_param, string
                key, out System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 23462, 23523);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>
                f_1127_23607_23624(System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                this_param)
                {
                    var return_v = this_param.Item2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 23607, 23624);
                    return return_v;
                }


                bool
                f_1127_23667_23682(System.Tuple<bool, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager.TypeGenerator>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 23667, 23682);
                    return return_v;
                }


                int
                f_1127_23571_23696(System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>
                views, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                file, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                logEntries, bool
                isForHelp, ref bool
                success)
                {
                    ProcessBuiltinFormatViewDefinitions(views, db, expressionFactory, file, logEntries, isForHelp, ref success);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 23571, 23696);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 21136, 23734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 21136, 23734);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ProcessBuiltinFormatViewDefinitions(
                    IEnumerable<ExtendedTypeDefinition> views,
                    TypeInfoDataBase db,
                    PSPropertyExpressionFactory expressionFactory,
                    PSSnapInTypeAndFormatErrors file,
                    List<XmlLoaderLoggerEntry> logEntries,
                    bool isForHelp,
                    ref bool success)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1127, 23746, 24346);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 24136, 24335);
                    foreach (var v in f_1127_24154_24159_I(views))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1127, 24136, 24335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 24193, 24320);

                        f_1127_24193_24319(v, expressionFactory, logEntries, ref success, file, db, isBuiltInFormatData: true, isForHelp: isForHelp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1127, 24136, 24335);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1127, 1, 200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1127, 1, 200);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1127, 23746, 24346);

                int
                f_1127_24193_24319(System.Management.Automation.ExtendedTypeDefinition
                formatData, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                logEntries, ref bool
                success, System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
                file, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, bool
                isBuiltInFormatData, bool
                isForHelp)
                {
                    LoadFormatDataHelper(formatData, expressionFactory, logEntries, ref success, file, db, isBuiltInFormatData: isBuiltInFormatData, isForHelp: isForHelp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 24193, 24319);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>
                f_1127_24154_24159_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 24154, 24159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 23746, 24346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 23746, 24346);
            }
        }

        private static void AddPreLoadIntrinsics(TypeInfoDataBase db)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1127, 24530, 24690);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1127, 24530, 24690);
                // NOTE: nothing to add for the time being. Add here if needed.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 24530, 24690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 24530, 24690);
            }
        }

        private static void AddPostLoadIntrinsics(TypeInfoDataBase db)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1127, 24875, 25528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 25149, 25215);

                FormatShapeSelectionOnType
                sel = f_1127_25182_25214()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 25229, 25261);

                sel.appliesTo = f_1127_25245_25260();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 25275, 25361);

                f_1127_25275_25360(sel.appliesTo, "Microsoft.PowerShell.Commands.FormatDataLoadingInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 25375, 25410);

                sel.formatShape = FormatShape.List;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 25426, 25517);

                f_1127_25426_25516(
                            db.defaultSettingsSection.shapeSelectionDirectives.formatShapeSelectionOnTypeList, sel);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1127, 24875, 25528);

                Microsoft.PowerShell.Commands.Internal.Format.FormatShapeSelectionOnType
                f_1127_25182_25214()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatShapeSelectionOnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 25182, 25214);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1127_25245_25260()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.AppliesTo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 25245, 25260);
                    return return_v;
                }


                int
                f_1127_25275_25360(Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                this_param, string
                typeName)
                {
                    this_param.AddAppliesToType(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 25275, 25360);
                    return 0;
                }


                int
                f_1127_25426_25516(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatShapeSelectionOnType>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatShapeSelectionOnType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 25426, 25516);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1127, 24875, 25528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 24875, 25528);
            }
        }

        static TypeInfoDataBaseManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1127, 619, 25535);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1127, 20903, 20922);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1127, 619, 25535);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1127, 619, 25535);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1127, 619, 25535);

        object
        f_1127_982_994()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 982, 994);
            return return_v;
        }


        object
        f_1127_1089_1101()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 1089, 1101);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1127_1496_1514()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 1496, 1514);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1127_2673_2691()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 2673, 2691);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
        f_1127_2762_2807()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 2762, 2807);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentBag<string>
        f_1127_2853_2880()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentBag<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 2853, 2880);
            return return_v;
        }


        bool
        f_1127_2974_3006(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 2974, 3006);
            return return_v;
        }


        bool
        f_1127_3012_3041(string
        path)
        {
            var return_v = Path.IsPathRooted(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 3012, 3041);
            return return_v;
        }


        string
        f_1127_3140_3189()
        {
            var return_v = FormatAndOutXmlLoadingStrings.FormatFileNotRooted;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 3140, 3189);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1127_3090_3202(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 3090, 3202);
            return return_v;
        }


        System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
        f_1127_3283_3340(string
        psSnapinName, string
        fullPath)
        {
            var return_v = new System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors(psSnapinName, fullPath);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 3283, 3340);
            return return_v;
        }


        int
        f_1127_3404_3431(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
        this_param, System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 3404, 3431);
            return 0;
        }


        int
        f_1127_3450_3481(System.Collections.Generic.List<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 3450, 3481);
            return 0;
        }


        System.Collections.Generic.IEnumerable<string>
        f_1127_2925_2936_I(System.Collections.Generic.IEnumerable<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 2925, 2936);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
        f_1127_3561_3594()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 3561, 3594);
            return return_v;
        }


        bool
        f_1127_3701_3802(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
        this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
        files, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
        expressionFactory, bool
        acceptLoadingErrors, System.Management.Automation.AuthorizationManager
        authorizationManager, System.Management.Automation.Host.PSHost
        host, bool
        preValidated, out System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
        logEntries)
        {
            var return_v = this_param.LoadFromFile(files, expressionFactory, acceptLoadingErrors, authorizationManager, host, preValidated, out logEntries);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 3701, 3802);
            return return_v;
        }


        int
        f_1127_3940_3952(System.Collections.Concurrent.ConcurrentBag<string>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1127, 3940, 3952);
            return return_v;
        }


        System.Management.Automation.Runspaces.FormatTableLoadException
        f_1127_3996_4032(System.Collections.Concurrent.ConcurrentBag<string>
        loadErrors)
        {
            var return_v = new System.Management.Automation.Runspaces.FormatTableLoadException(loadErrors);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1127, 3996, 4032);
            return return_v;
        }

    }
}

