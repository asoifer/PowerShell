// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Globalization;
using System.Management.Automation.Host;
using System.Management.Automation.Language;
using System.Management.Automation.Remoting.Internal;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Security;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.PSTasks
{
    internal sealed class PSTask : PSTaskBase
    {
        private readonly PSTaskDataStreamWriter _dataStreamWriter;

        public PSTask(
                    ScriptBlock scriptBlock,
                    Dictionary<string, object> usingValuesMap,
                    object dollarUnderbar,
                    string currentLocationPath,
                    PSTaskDataStreamWriter dataStreamWriter)
        : base(
        f_1481_1687_1698_C(scriptBlock), usingValuesMap, dollarUnderbar, currentLocationPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 1409, 1876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 796, 813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 1828, 1865);

                _dataStreamWriter = dataStreamWriter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 1409, 1876);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 1409, 1876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 1409, 1876);
            }
        }

        protected override void InitializePowershell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 2029, 2812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 2144, 2202);

                _output.DataAdded += (sender, args) => HandleOutputData();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 2216, 2291);

                f_1481_2216_2241(f_1481_2216_2235(_powershell)).DataAdded += (sender, args) => HandleErrorData();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 2305, 2384);

                f_1481_2305_2332(f_1481_2305_2324(_powershell)).DataAdded += (sender, args) => HandleWarningData();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 2398, 2477);

                f_1481_2398_2425(f_1481_2398_2417(_powershell)).DataAdded += (sender, args) => HandleVerboseData();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 2491, 2566);

                f_1481_2491_2516(f_1481_2491_2510(_powershell)).DataAdded += (sender, args) => HandleDebugData();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 2580, 2667);

                f_1481_2580_2611(f_1481_2580_2599(_powershell)).DataAdded += (sender, args) => HandleInformationData();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 2720, 2801);

                _powershell.InvocationStateChanged += (sender, args) => HandleStateChanged(args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 2029, 2812);

                System.Management.Automation.PSDataStreams
                f_1481_2216_2235(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 2216, 2235);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1481_2216_2241(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 2216, 2241);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1481_2305_2324(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 2305, 2324);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1481_2305_2332(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 2305, 2332);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1481_2398_2417(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 2398, 2417);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1481_2398_2425(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 2398, 2425);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1481_2491_2510(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 2491, 2510);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1481_2491_2516(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 2491, 2516);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1481_2580_2599(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 2580, 2599);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1481_2580_2611(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 2580, 2611);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 2029, 2812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 2029, 2812);
            }
        }

        private void HandleOutputData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 2893, 3144);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 2949, 3133);
                    foreach (var item in f_1481_2970_2987_I(f_1481_2970_2987(_output)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 2949, 3133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 3021, 3118);

                        f_1481_3021_3117(_dataStreamWriter, f_1481_3065_3116(PSStreamObjectType.Output, item));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 2949, 3133);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 185);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 2893, 3144);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1481_2970_2987(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 2970, 2987);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1481_3065_3116(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.PSObject
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3065, 3116);
                    return return_v;
                }


                int
                f_1481_3021_3117(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                streamObject)
                {
                    this_param.Add(streamObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3021, 3117);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1481_2970_2987_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 2970, 2987);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 2893, 3144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 2893, 3144);
            }
        }

        private void HandleErrorData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 3156, 3423);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 3211, 3412);
                    foreach (var item in f_1481_3232_3267_I(f_1481_3232_3267(f_1481_3232_3257(f_1481_3232_3251(_powershell)))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 3211, 3412);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 3301, 3397);

                        f_1481_3301_3396(_dataStreamWriter, f_1481_3345_3395(PSStreamObjectType.Error, item));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 3211, 3412);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 202);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 202);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 3156, 3423);

                System.Management.Automation.PSDataStreams
                f_1481_3232_3251(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 3232, 3251);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1481_3232_3257(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 3232, 3257);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                f_1481_3232_3267(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3232, 3267);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1481_3345_3395(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.ErrorRecord
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3345, 3395);
                    return return_v;
                }


                int
                f_1481_3301_3396(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                streamObject)
                {
                    this_param.Add(streamObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3301, 3396);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                f_1481_3232_3267_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3232, 3267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 3156, 3423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 3156, 3423);
            }
        }

        private void HandleWarningData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 3435, 3716);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 3492, 3705);
                    foreach (var item in f_1481_3513_3550_I(f_1481_3513_3550(f_1481_3513_3540(f_1481_3513_3532(_powershell)))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 3492, 3705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 3584, 3690);

                        f_1481_3584_3689(_dataStreamWriter, f_1481_3628_3688(PSStreamObjectType.Warning, f_1481_3675_3687(item)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 3492, 3705);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 214);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 3435, 3716);

                System.Management.Automation.PSDataStreams
                f_1481_3513_3532(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 3513, 3532);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1481_3513_3540(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 3513, 3540);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WarningRecord>
                f_1481_3513_3550(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3513, 3550);
                    return return_v;
                }


                string
                f_1481_3675_3687(System.Management.Automation.WarningRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 3675, 3687);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1481_3628_3688(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, string
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3628, 3688);
                    return return_v;
                }


                int
                f_1481_3584_3689(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                streamObject)
                {
                    this_param.Add(streamObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3584, 3689);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WarningRecord>
                f_1481_3513_3550_I(System.Collections.ObjectModel.Collection<System.Management.Automation.WarningRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3513, 3550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 3435, 3716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 3435, 3716);
            }
        }

        private void HandleVerboseData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 3728, 4009);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 3785, 3998);
                    foreach (var item in f_1481_3806_3843_I(f_1481_3806_3843(f_1481_3806_3833(f_1481_3806_3825(_powershell)))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 3785, 3998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 3877, 3983);

                        f_1481_3877_3982(_dataStreamWriter, f_1481_3921_3981(PSStreamObjectType.Verbose, f_1481_3968_3980(item)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 3785, 3998);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 214);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 3728, 4009);

                System.Management.Automation.PSDataStreams
                f_1481_3806_3825(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 3806, 3825);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1481_3806_3833(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 3806, 3833);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.VerboseRecord>
                f_1481_3806_3843(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3806, 3843);
                    return return_v;
                }


                string
                f_1481_3968_3980(System.Management.Automation.VerboseRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 3968, 3980);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1481_3921_3981(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, string
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3921, 3981);
                    return return_v;
                }


                int
                f_1481_3877_3982(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                streamObject)
                {
                    this_param.Add(streamObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3877, 3982);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.VerboseRecord>
                f_1481_3806_3843_I(System.Collections.ObjectModel.Collection<System.Management.Automation.VerboseRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 3806, 3843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 3728, 4009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 3728, 4009);
            }
        }

        private void HandleDebugData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 4021, 4296);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 4076, 4285);
                    foreach (var item in f_1481_4097_4132_I(f_1481_4097_4132(f_1481_4097_4122(f_1481_4097_4116(_powershell)))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 4076, 4285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 4166, 4270);

                        f_1481_4166_4269(_dataStreamWriter, f_1481_4210_4268(PSStreamObjectType.Debug, f_1481_4255_4267(item)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 4076, 4285);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 210);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 4021, 4296);

                System.Management.Automation.PSDataStreams
                f_1481_4097_4116(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 4097, 4116);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1481_4097_4122(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 4097, 4122);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.DebugRecord>
                f_1481_4097_4132(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 4097, 4132);
                    return return_v;
                }


                string
                f_1481_4255_4267(System.Management.Automation.DebugRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 4255, 4267);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1481_4210_4268(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, string
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 4210, 4268);
                    return return_v;
                }


                int
                f_1481_4166_4269(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                streamObject)
                {
                    this_param.Add(streamObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 4166, 4269);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.DebugRecord>
                f_1481_4097_4132_I(System.Collections.ObjectModel.Collection<System.Management.Automation.DebugRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 4097, 4132);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 4021, 4296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 4021, 4296);
            }
        }

        private void HandleInformationData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 4308, 4593);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 4369, 4582);
                    foreach (var item in f_1481_4390_4431_I(f_1481_4390_4431(f_1481_4390_4421(f_1481_4390_4409(_powershell)))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 4369, 4582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 4465, 4567);

                        f_1481_4465_4566(_dataStreamWriter, f_1481_4509_4565(PSStreamObjectType.Information, item));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 4369, 4582);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 214);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 4308, 4593);

                System.Management.Automation.PSDataStreams
                f_1481_4390_4409(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 4390, 4409);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1481_4390_4421(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 4390, 4421);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.InformationRecord>
                f_1481_4390_4431(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 4390, 4431);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1481_4509_4565(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.InformationRecord
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 4509, 4565);
                    return return_v;
                }


                int
                f_1481_4465_4566(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                streamObject)
                {
                    this_param.Add(streamObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 4465, 4566);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.InformationRecord>
                f_1481_4390_4431_I(System.Collections.ObjectModel.Collection<System.Management.Automation.InformationRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 4390, 4431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 4308, 4593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 4308, 4593);
            }
        }

        private void HandleStateChanged(PSInvocationStateChangedEventArgs stateChangeInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 4661, 5508);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 4768, 5441) || true) && (_dataStreamWriter != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 4768, 5441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 4917, 4972);

                    var
                    newStateInfo = f_1481_4936_4971(stateChangeInfo)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 4990, 5426) || true) && (f_1481_4994_5013(newStateInfo) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 4990, 5426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 5063, 5276);

                        var
                        errorRecord = f_1481_5081_5275(f_1481_5123_5142(newStateInfo), "PSTaskException", ErrorCategory.InvalidOperation, this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 5300, 5407);

                        f_1481_5300_5406(
                                            _dataStreamWriter, f_1481_5348_5405(PSStreamObjectType.Error, errorRecord));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 4990, 5426);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 4768, 5441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 5457, 5497);

                f_1481_5457_5496(this, stateChangeInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 4661, 5508);

                System.Management.Automation.PSInvocationStateInfo
                f_1481_4936_4971(System.Management.Automation.PSInvocationStateChangedEventArgs
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 4936, 4971);
                    return return_v;
                }


                System.Exception
                f_1481_4994_5013(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 4994, 5013);
                    return return_v;
                }


                System.Exception
                f_1481_5123_5142(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 5123, 5142);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1481_5081_5275(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSTasks.PSTask
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 5081, 5275);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1481_5348_5405(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.ErrorRecord
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 5348, 5405);
                    return return_v;
                }


                int
                f_1481_5300_5406(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                streamObject)
                {
                    this_param.Add(streamObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 5300, 5406);
                    return 0;
                }


                int
                f_1481_5457_5496(System.Management.Automation.PSTasks.PSTask
                this_param, System.Management.Automation.PSInvocationStateChangedEventArgs
                args)
                {
                    this_param.RaiseStateChangedEvent(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 5457, 5496);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 4661, 5508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 4661, 5508);
            }
        }

        static PSTask()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1481, 671, 5537);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1481, 671, 5537);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 671, 5537);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1481, 671, 5537);

        static System.Management.Automation.ScriptBlock
        f_1481_1687_1698_C(System.Management.Automation.ScriptBlock
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1481, 1409, 1876);
            return return_v;
        }

    }
    internal sealed class PSJobTask : PSTaskBase
    {
        private readonly Job _job;

        public PSJobTask(
                    ScriptBlock scriptBlock,
                    Dictionary<string, object> usingValuesMap,
                    object dollarUnderbar,
                    string currentLocationPath,
                    Job job) : base(
        f_1481_6621_6632_C(scriptBlock), usingValuesMap, dollarUnderbar, currentLocationPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 6385, 6784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 5773, 5777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 6762, 6773);

                _job = job;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 6385, 6784);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 6385, 6784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 6385, 6784);
            }
        }

        protected override void InitializePowershell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 6937, 7735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 7049, 7110);

                _output.DataAdded += (sender, args) => HandleJobOutputData();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 7124, 7202);

                f_1481_7124_7149(f_1481_7124_7143(_powershell)).DataAdded += (sender, args) => HandleJobErrorData();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 7216, 7298);

                f_1481_7216_7243(f_1481_7216_7235(_powershell)).DataAdded += (sender, args) => HandleJobWarningData();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 7312, 7394);

                f_1481_7312_7339(f_1481_7312_7331(_powershell)).DataAdded += (sender, args) => HandleJobVerboseData();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 7408, 7486);

                f_1481_7408_7433(f_1481_7408_7427(_powershell)).DataAdded += (sender, args) => HandleJobDebugData();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 7500, 7590);

                f_1481_7500_7531(f_1481_7500_7519(_powershell)).DataAdded += (sender, args) => HandleJobInformationData();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 7643, 7724);

                _powershell.InvocationStateChanged += (sender, args) => HandleStateChanged(args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 6937, 7735);

                System.Management.Automation.PSDataStreams
                f_1481_7124_7143(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 7124, 7143);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1481_7124_7149(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 7124, 7149);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1481_7216_7235(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 7216, 7235);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1481_7216_7243(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 7216, 7243);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1481_7312_7331(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 7312, 7331);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1481_7312_7339(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 7312, 7339);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1481_7408_7427(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 7408, 7427);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1481_7408_7433(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 7408, 7433);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1481_7500_7519(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 7500, 7519);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1481_7500_7531(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 7500, 7531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 6937, 7735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 6937, 7735);
            }
        }

        private void HandleJobOutputData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 7813, 8102);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 7872, 8091);
                    foreach (var item in f_1481_7893_7910_I(f_1481_7893_7910(_output)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 7872, 8091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 7944, 7966);

                        f_1481_7944_7965(f_1481_7944_7955(_job), item);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 7984, 8076);

                        f_1481_7984_8075(f_1481_7984_7996(_job), f_1481_8023_8074(PSStreamObjectType.Output, item));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 7872, 8091);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 220);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 7813, 8102);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1481_7893_7910(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 7893, 7910);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1481_7944_7955(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 7944, 7955);
                    return return_v;
                }


                int
                f_1481_7944_7965(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 7944, 7965);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1481_7984_7996(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 7984, 7996);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1481_8023_8074(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.PSObject
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8023, 8074);
                    return return_v;
                }


                int
                f_1481_7984_8075(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 7984, 8075);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1481_7893_7910_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 7893, 7910);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 7813, 8102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 7813, 8102);
            }
        }

        private void HandleJobErrorData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 8114, 8418);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 8172, 8407);
                    foreach (var item in f_1481_8193_8228_I(f_1481_8193_8228(f_1481_8193_8218(f_1481_8193_8212(_powershell)))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 8172, 8407);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 8262, 8283);

                        f_1481_8262_8282(f_1481_8262_8272(_job), item);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 8301, 8392);

                        f_1481_8301_8391(f_1481_8301_8313(_job), f_1481_8340_8390(PSStreamObjectType.Error, item));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 8172, 8407);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 236);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 8114, 8418);

                System.Management.Automation.PSDataStreams
                f_1481_8193_8212(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 8193, 8212);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1481_8193_8218(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 8193, 8218);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                f_1481_8193_8228(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8193, 8228);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1481_8262_8272(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 8262, 8272);
                    return return_v;
                }


                int
                f_1481_8262_8282(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, System.Management.Automation.ErrorRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8262, 8282);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1481_8301_8313(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 8301, 8313);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1481_8340_8390(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.ErrorRecord
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8340, 8390);
                    return return_v;
                }


                int
                f_1481_8301_8391(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8301, 8391);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                f_1481_8193_8228_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8193, 8228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 8114, 8418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 8114, 8418);
            }
        }

        private void HandleJobWarningData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 8430, 8750);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 8490, 8739);
                    foreach (var item in f_1481_8511_8548_I(f_1481_8511_8548(f_1481_8511_8538(f_1481_8511_8530(_powershell)))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 8490, 8739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 8582, 8605);

                        f_1481_8582_8604(f_1481_8582_8594(_job), item);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 8623, 8724);

                        f_1481_8623_8723(f_1481_8623_8635(_job), f_1481_8662_8722(PSStreamObjectType.Warning, f_1481_8709_8721(item)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 8490, 8739);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 250);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 8430, 8750);

                System.Management.Automation.PSDataStreams
                f_1481_8511_8530(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 8511, 8530);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1481_8511_8538(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 8511, 8538);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WarningRecord>
                f_1481_8511_8548(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8511, 8548);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1481_8582_8594(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 8582, 8594);
                    return return_v;
                }


                int
                f_1481_8582_8604(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                this_param, System.Management.Automation.WarningRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8582, 8604);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1481_8623_8635(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 8623, 8635);
                    return return_v;
                }


                string
                f_1481_8709_8721(System.Management.Automation.WarningRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 8709, 8721);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1481_8662_8722(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, string
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8662, 8722);
                    return return_v;
                }


                int
                f_1481_8623_8723(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8623, 8723);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WarningRecord>
                f_1481_8511_8548_I(System.Collections.ObjectModel.Collection<System.Management.Automation.WarningRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8511, 8548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 8430, 8750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 8430, 8750);
            }
        }

        private void HandleJobVerboseData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 8762, 9082);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 8822, 9071);
                    foreach (var item in f_1481_8843_8880_I(f_1481_8843_8880(f_1481_8843_8870(f_1481_8843_8862(_powershell)))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 8822, 9071);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 8914, 8937);

                        f_1481_8914_8936(f_1481_8914_8926(_job), item);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 8955, 9056);

                        f_1481_8955_9055(f_1481_8955_8967(_job), f_1481_8994_9054(PSStreamObjectType.Verbose, f_1481_9041_9053(item)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 8822, 9071);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 250);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 8762, 9082);

                System.Management.Automation.PSDataStreams
                f_1481_8843_8862(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 8843, 8862);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1481_8843_8870(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 8843, 8870);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.VerboseRecord>
                f_1481_8843_8880(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8843, 8880);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1481_8914_8926(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 8914, 8926);
                    return return_v;
                }


                int
                f_1481_8914_8936(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                this_param, System.Management.Automation.VerboseRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8914, 8936);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1481_8955_8967(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 8955, 8967);
                    return return_v;
                }


                string
                f_1481_9041_9053(System.Management.Automation.VerboseRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 9041, 9053);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1481_8994_9054(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, string
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8994, 9054);
                    return return_v;
                }


                int
                f_1481_8955_9055(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8955, 9055);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.VerboseRecord>
                f_1481_8843_8880_I(System.Collections.ObjectModel.Collection<System.Management.Automation.VerboseRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 8843, 8880);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 8762, 9082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 8762, 9082);
            }
        }

        private void HandleJobDebugData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 9094, 9406);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 9152, 9395);
                    foreach (var item in f_1481_9173_9208_I(f_1481_9173_9208(f_1481_9173_9198(f_1481_9173_9192(_powershell)))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 9152, 9395);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 9242, 9263);

                        f_1481_9242_9262(f_1481_9242_9252(_job), item);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 9281, 9380);

                        f_1481_9281_9379(f_1481_9281_9293(_job), f_1481_9320_9378(PSStreamObjectType.Debug, f_1481_9365_9377(item)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 9152, 9395);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 244);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 9094, 9406);

                System.Management.Automation.PSDataStreams
                f_1481_9173_9192(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 9173, 9192);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1481_9173_9198(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 9173, 9198);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.DebugRecord>
                f_1481_9173_9208(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 9173, 9208);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1481_9242_9252(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 9242, 9252);
                    return return_v;
                }


                int
                f_1481_9242_9262(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                this_param, System.Management.Automation.DebugRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 9242, 9262);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1481_9281_9293(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 9281, 9293);
                    return return_v;
                }


                string
                f_1481_9365_9377(System.Management.Automation.DebugRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 9365, 9377);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1481_9320_9378(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, string
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 9320, 9378);
                    return return_v;
                }


                int
                f_1481_9281_9379(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 9281, 9379);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.DebugRecord>
                f_1481_9173_9208_I(System.Collections.ObjectModel.Collection<System.Management.Automation.DebugRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 9173, 9208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 9094, 9406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 9094, 9406);
            }
        }

        private void HandleJobInformationData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 9418, 9746);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 9482, 9735);
                    foreach (var item in f_1481_9503_9544_I(f_1481_9503_9544(f_1481_9503_9534(f_1481_9503_9522(_powershell)))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 9482, 9735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 9578, 9605);

                        f_1481_9578_9604(f_1481_9578_9594(_job), item);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 9623, 9720);

                        f_1481_9623_9719(f_1481_9623_9635(_job), f_1481_9662_9718(PSStreamObjectType.Information, item));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 9482, 9735);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 254);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 9418, 9746);

                System.Management.Automation.PSDataStreams
                f_1481_9503_9522(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 9503, 9522);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1481_9503_9534(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 9503, 9534);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.InformationRecord>
                f_1481_9503_9544(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 9503, 9544);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1481_9578_9594(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 9578, 9594);
                    return return_v;
                }


                int
                f_1481_9578_9604(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                this_param, System.Management.Automation.InformationRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 9578, 9604);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1481_9623_9635(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 9623, 9635);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1481_9662_9718(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.InformationRecord
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 9662, 9718);
                    return return_v;
                }


                int
                f_1481_9623_9719(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 9623, 9719);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.InformationRecord>
                f_1481_9503_9544_I(System.Collections.ObjectModel.Collection<System.Management.Automation.InformationRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 9503, 9544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 9418, 9746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 9418, 9746);
            }
        }

        private void HandleStateChanged(PSInvocationStateChangedEventArgs stateChangeInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 9814, 9972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 9921, 9961);

                f_1481_9921_9960(this, stateChangeInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 9814, 9972);

                int
                f_1481_9921_9960(System.Management.Automation.PSTasks.PSJobTask
                this_param, System.Management.Automation.PSInvocationStateChangedEventArgs
                args)
                {
                    this_param.RaiseStateChangedEvent(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 9921, 9960);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 9814, 9972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 9814, 9972);
            }
        }

        public Debugger Debugger
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 10164, 10196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 10167, 10196);
                    return f_1481_10167_10196(f_1481_10167_10187(_powershell));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 10164, 10196);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 10111, 10208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 10111, 10208);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSJobTask()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1481, 5664, 10237);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1481, 5664, 10237);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 5664, 10237);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1481, 5664, 10237);

        static System.Management.Automation.ScriptBlock
        f_1481_6621_6632_C(System.Management.Automation.ScriptBlock
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1481, 6385, 6784);
            return return_v;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1481_10167_10187(System.Management.Automation.PowerShell
        this_param)
        {
            var return_v = this_param.Runspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 10167, 10187);
            return return_v;
        }


        System.Management.Automation.Debugger
        f_1481_10167_10196(System.Management.Automation.Runspaces.Runspace
        this_param)
        {
            var return_v = this_param.Debugger;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 10167, 10196);
            return return_v;
        }

    }
    internal abstract class PSTaskBase : IDisposable
    {
        private readonly ScriptBlock _scriptBlockToRun;

        private readonly Dictionary<string, object> _usingValuesMap;

        private readonly object _dollarUnderbar;

        private readonly int _id;

        private readonly string _currentLocationPath;

        private Runspace _runspace;

        protected PowerShell _powershell;

        protected PSDataCollection<PSObject> _output;

        private const string
        RunspaceName = "PSTask"
        ;

        private static int s_taskId;



        /// <summary>
        /// Event that fires when the task running state changes.
        /// </summary>
        public event EventHandler<PSInvocationStateChangedEventArgs>
StateChanged
;

        internal void RaiseStateChangedEvent(PSInvocationStateChangedEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 11229, 11377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 11330, 11366);

                f_1481_11330_11365(StateChanged, this, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 11229, 11377);

                int
                f_1481_11330_11365(System.EventHandler<System.Management.Automation.PSInvocationStateChangedEventArgs>
                eventHandler, System.Management.Automation.PSTasks.PSTaskBase
                sender, System.Management.Automation.PSInvocationStateChangedEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.PSInvocationStateChangedEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 11330, 11365);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 11229, 11377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 11229, 11377);
            }
        }

        public PSInvocationState State
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 11596, 11860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 11632, 11660);

                    PowerShell
                    ps = _powershell
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 11678, 11789) || true) && (ps != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 11678, 11789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 11734, 11770);

                        return f_1481_11741_11769(f_1481_11741_11763(ps));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 11678, 11789);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 11809, 11845);

                    return PSInvocationState.NotStarted;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 11596, 11860);

                    System.Management.Automation.PSInvocationStateInfo
                    f_1481_11741_11763(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.InvocationStateInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 11741, 11763);
                        return return_v;
                    }


                    System.Management.Automation.PSInvocationState
                    f_1481_11741_11769(System.Management.Automation.PSInvocationStateInfo
                    this_param)
                    {
                        var return_v = this_param.State;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 11741, 11769);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 11541, 11871);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 11541, 11871);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Id
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 11977, 11983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 11980, 11983);
                    return _id;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 11977, 11983);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 11957, 11986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 11957, 11986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSTaskBase()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 12051, 12149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 10509, 10526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 10581, 10596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 10631, 10646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 10678, 10681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 10716, 10736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 10764, 10773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 10805, 10816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 10864, 10871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 12096, 12138);

                _id = f_1481_12102_12137(ref s_taskId);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 12051, 12149);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 12051, 12149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 12051, 12149);
            }
        }

        protected PSTaskBase(
                    ScriptBlock scriptBlock,
                    Dictionary<string, object> usingValuesMap,
                    object dollarUnderbar,
                    string currentLocationPath) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 12615, 13035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 12841, 12873);

                _scriptBlockToRun = scriptBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 12887, 12920);

                _usingValuesMap = usingValuesMap;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 12934, 12967);

                _dollarUnderbar = dollarUnderbar;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 12981, 13024);

                _currentLocationPath = currentLocationPath;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 12615, 13035);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 12615, 13035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 12615, 13035);
            }
        }

        protected abstract void InitializePowershell();

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 13396, 13541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 13442, 13462);

                f_1481_13442_13461(_runspace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 13476, 13498);

                f_1481_13476_13497(_powershell);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 13512, 13530);

                f_1481_13512_13529(_output);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 13396, 13541);

                int
                f_1481_13442_13461(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 13442, 13461);
                    return 0;
                }


                int
                f_1481_13476_13497(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 13476, 13497);
                    return 0;
                }


                int
                f_1481_13512_13529(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 13512, 13529);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 13396, 13541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 13396, 13541);
            }
        }

        public void Start()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 13681, 15995);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 13725, 13878) || true) && (_powershell != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 13725, 13878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 13782, 13838);

                    f_1481_13782_13837(false, "A PSTask can be started only once.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 13856, 13863);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 13725, 13878);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 13959, 14006);

                var
                iss = f_1481_13969_14005()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 14020, 14197);

                iss.LanguageMode = (DynAbs.Tracing.TraceSender.Conditional_F1(1481, 14039, 14112) || (((f_1481_14040_14078() == SystemEnforcementMode.Enforce)
                && DynAbs.Tracing.TraceSender.Conditional_F2(1481, 14132, 14166)) || DynAbs.Tracing.TraceSender.Conditional_F3(1481, 14169, 14196))) ? PSLanguageMode.ConstrainedLanguage : PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 14211, 14259);

                _runspace = f_1481_14223_14258(iss);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 14273, 14369);

                _runspace.Name = f_1481_14290_14368(f_1481_14304_14332(), "{0}:{1}", RunspaceName, s_taskId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 14383, 14400);

                f_1481_14383_14399(_runspace);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 14614, 15099) || true) && (_currentLocationPath != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 14614, 15099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 14680, 14730);

                    var
                    oldDefaultRunspace = f_1481_14705_14729()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 14792, 14829);

                        Runspace.DefaultRunspace = _runspace;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 14851, 14934);

                        f_1481_14851_14933(f_1481_14851_14899(f_1481_14851_14890(f_1481_14851_14877(_runspace))), _currentLocationPath);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1481, 14971, 15084);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 15019, 15065);

                        Runspace.DefaultRunspace = oldDefaultRunspace;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1481, 14971, 15084);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 14614, 15099);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 15288, 15331);

                _powershell = f_1481_15302_15330(_runspace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 15424, 15467);

                _output = f_1481_15434_15466();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 15481, 15504);

                f_1481_15481_15503(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 15577, 15629);

                f_1481_15577_15628(
                            // Start the script running in a new thread
                            _powershell, f_1481_15599_15627(_scriptBlockToRun));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 15643, 15709);

                f_1481_15643_15675(f_1481_15643_15672(f_1481_15643_15663(_powershell)), 0).DollarUnderbar = _dollarUnderbar;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 15723, 15896) || true) && (_usingValuesMap != null && (DynAbs.Tracing.TraceSender.Expression_True(1481, 15727, 15779) && f_1481_15754_15775(_usingValuesMap) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 15723, 15896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 15813, 15881);

                    f_1481_15813_15880(_powershell, Parser.VERBATIM_ARGUMENT, _usingValuesMap);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 15723, 15896);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 15912, 15984);

                f_1481_15912_15983(
                            _powershell, input: null, output: _output);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 13681, 15995);

                int
                f_1481_13782_13837(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 13782, 13837);
                    return 0;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1481_13969_14005()
                {
                    var return_v = InitialSessionState.CreateDefault2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 13969, 14005);
                    return return_v;
                }


                System.Management.Automation.Security.SystemEnforcementMode
                f_1481_14040_14078()
                {
                    var return_v = SystemPolicy.GetSystemLockdownPolicy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 14040, 14078);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1481_14223_14258(System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = RunspaceFactory.CreateRunspace(initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 14223, 14258);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1481_14304_14332()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 14304, 14332);
                    return return_v;
                }


                string
                f_1481_14290_14368(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, int
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 14290, 14368);
                    return return_v;
                }


                int
                f_1481_14383_14399(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 14383, 14399);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1481_14705_14729()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 14705, 14729);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1481_14851_14877(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 14851, 14877);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1481_14851_14890(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 14851, 14890);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1481_14851_14899(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 14851, 14899);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1481_14851_14933(System.Management.Automation.SessionStateInternal
                this_param, string
                path)
                {
                    var return_v = this_param.SetLocation(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 14851, 14933);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1481_15302_15330(System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    var return_v = PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 15302, 15330);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1481_15434_15466()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 15434, 15466);
                    return return_v;
                }


                int
                f_1481_15481_15503(System.Management.Automation.PSTasks.PSTaskBase
                this_param)
                {
                    this_param.InitializePowershell();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 15481, 15503);
                    return 0;
                }


                string
                f_1481_15599_15627(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 15599, 15627);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1481_15577_15628(System.Management.Automation.PowerShell
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 15577, 15628);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1481_15643_15663(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 15643, 15663);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1481_15643_15672(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 15643, 15672);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1481_15643_15675(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 15643, 15675);
                    return return_v;
                }


                int
                f_1481_15754_15775(System.Collections.Generic.Dictionary<string, object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 15754, 15775);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1481_15813_15880(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Collections.Generic.Dictionary<string, object>
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 15813, 15880);
                    return return_v;
                }


                System.IAsyncResult
                f_1481_15912_15983(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<object>
                input, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = this_param.BeginInvoke<object, System.Management.Automation.PSObject>(input: input, output: output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 15912, 15983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 13681, 15995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 13681, 15995);
            }
        }

        public void SignalStop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 16101, 16267);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 16150, 16256) || true) && (_powershell != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 16150, 16256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 16207, 16241);

                    f_1481_16207_16240(_powershell, null, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 16150, 16256);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 16101, 16267);

                System.IAsyncResult
                f_1481_16207_16240(System.Management.Automation.PowerShell
                this_param, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginStop(callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 16207, 16240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 16101, 16267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 16101, 16267);
            }
        }

        static PSTaskBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1481, 10388, 16296);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 10905, 10928);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 10960, 10968);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1481, 10388, 16296);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 10388, 16296);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1481, 10388, 16296);

        int
        f_1481_12102_12137(ref int
        location)
        {
            var return_v = Interlocked.Increment(ref location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 12102, 12137);
            return return_v;
        }

    }
    internal sealed class PSTaskDataStreamWriter : IDisposable
    {
        private readonly PSCmdlet _cmdlet;

        private readonly PSDataCollection<PSStreamObject> _dataStream;

        private readonly int _cmdletThreadId;

        internal WaitHandle DataAddedWaitHandle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 17084, 17109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 17087, 17109);
                    return f_1481_17087_17109(_dataStream);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 17084, 17109);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 17016, 17121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 17016, 17121);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSTaskDataStreamWriter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 17186, 17222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 16601, 16608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 16669, 16680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 16712, 16727);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 17186, 17222);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 17186, 17222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 17186, 17222);
            }
        }

        public PSTaskDataStreamWriter(PSCmdlet psCmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 17431, 17670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 16601, 16608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 16669, 16680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 16712, 16727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 17504, 17523);

                _cmdlet = psCmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 17537, 17592);

                _cmdletThreadId = f_1481_17555_17591(f_1481_17555_17575());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 17606, 17659);

                _dataStream = f_1481_17620_17658();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 17431, 17670);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 17431, 17670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 17431, 17670);
            }
        }

        public void Add(PSStreamObject streamObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 17913, 18023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 17982, 18012);

                f_1481_17982_18011(_dataStream, streamObject);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 17913, 18023);

                int
                f_1481_17982_18011(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 17982, 18011);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 17913, 18023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 17913, 18023);
            }
        }

        public void WriteImmediate()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 18166, 18420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 18219, 18239);

                f_1481_18219_18238(this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 18255, 18409);
                    foreach (var item in f_1481_18276_18297_I(f_1481_18276_18297(_dataStream)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 18255, 18409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 18331, 18394);

                        f_1481_18331_18393(item, cmdlet: _cmdlet, overrideInquire: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 18255, 18409);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 155);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 18166, 18420);

                int
                f_1481_18219_18238(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param)
                {
                    this_param.CheckCmdletThread();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 18219, 18238);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1481_18276_18297(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 18276, 18297);
                    return return_v;
                }


                int
                f_1481_18331_18393(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param, System.Management.Automation.PSCmdlet
                cmdlet, bool
                overrideInquire)
                {
                    this_param.WriteStreamObject(cmdlet: (System.Management.Automation.Cmdlet)cmdlet, overrideInquire: overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 18331, 18393);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1481_18276_18297_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 18276, 18297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 18166, 18420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 18166, 18420);
            }
        }

        public void WaitAndWrite()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 18681, 19056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 18732, 18752);

                f_1481_18732_18751(this);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 18768, 19045) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 18768, 19045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 18813, 18846);

                        f_1481_18813_18845(f_1481_18813_18835(_dataStream));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 18864, 18881);

                        f_1481_18864_18880(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 18901, 19030) || true) && (f_1481_18905_18924_M(!_dataStream.IsOpen))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 18901, 19030);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 18966, 18983);

                            f_1481_18966_18982(this);
                            DynAbs.Tracing.TraceSender.TraceBreak(1481, 19005, 19011);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 18901, 19030);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 18768, 19045);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 18768, 19045);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 18768, 19045);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 18681, 19056);

                int
                f_1481_18732_18751(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param)
                {
                    this_param.CheckCmdletThread();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 18732, 18751);
                    return 0;
                }


                System.Threading.WaitHandle
                f_1481_18813_18835(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    var return_v = this_param.WaitHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 18813, 18835);
                    return return_v;
                }


                bool
                f_1481_18813_18845(System.Threading.WaitHandle
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 18813, 18845);
                    return return_v;
                }


                int
                f_1481_18864_18880(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param)
                {
                    this_param.WriteImmediate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 18864, 18880);
                    return 0;
                }


                bool
                f_1481_18905_18924_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 18905, 18924);
                    return return_v;
                }


                int
                f_1481_18966_18982(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param)
                {
                    this_param.WriteImmediate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 18966, 18982);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 18681, 19056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 18681, 19056);
            }
        }

        public void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 19154, 19232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 19198, 19221);

                f_1481_19198_19220(_dataStream);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 19154, 19232);

                int
                f_1481_19198_19220(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 19198, 19220);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 19154, 19232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 19154, 19232);
            }
        }

        private void CheckCmdletThread()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 19301, 19569);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 19358, 19558) || true) && (f_1481_19362_19398(f_1481_19362_19382()) != _cmdletThreadId)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 19358, 19558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 19451, 19543);

                    throw f_1481_19457_19542(f_1481_19489_19541());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 19358, 19558);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 19301, 19569);

                System.Threading.Thread
                f_1481_19362_19382()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 19362, 19382);
                    return return_v;
                }


                int
                f_1481_19362_19398(System.Threading.Thread
                this_param)
                {
                    var return_v = this_param.ManagedThreadId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 19362, 19398);
                    return return_v;
                }


                string
                f_1481_19489_19541()
                {
                    var return_v = InternalCommandStrings.PSTaskStreamWriterWrongThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 19489, 19541);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1481_19457_19542(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 19457, 19542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 19301, 19569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 19301, 19569);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 19721, 19800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 19767, 19789);

                f_1481_19767_19788(_dataStream);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 19721, 19800);

                int
                f_1481_19767_19788(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 19767, 19788);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 19721, 19800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 19721, 19800);
            }
        }

        static PSTaskDataStreamWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1481, 16473, 19829);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1481, 16473, 19829);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 16473, 19829);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1481, 16473, 19829);

        System.Threading.WaitHandle
        f_1481_17087_17109(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
        this_param)
        {
            var return_v = this_param.WaitHandle;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 17087, 17109);
            return return_v;
        }


        System.Threading.Thread
        f_1481_17555_17575()
        {
            var return_v = Thread.CurrentThread;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 17555, 17575);
            return return_v;
        }


        int
        f_1481_17555_17591(System.Threading.Thread
        this_param)
        {
            var return_v = this_param.ManagedThreadId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 17555, 17591);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
        f_1481_17620_17658()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 17620, 17658);
            return return_v;
        }

    }
    internal sealed class PSTaskPool : IDisposable
    {
        private readonly ManualResetEvent _addAvailable;

        private readonly int _sizeLimit;

        private readonly ManualResetEvent _stopAll;

        private readonly object _syncObject;

        private readonly Dictionary<int, PSTaskBase> _taskPool;

        private readonly WaitHandle[] _waitHandles;

        private bool _isOpen;

        private const int
        AddAvailable = 0
        ;

        private const int
        Stop = 1
        ;

        private PSTaskPool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 20587, 20611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20134, 20147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20179, 20189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20234, 20242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20277, 20288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20344, 20353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20394, 20406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20430, 20437);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 20587, 20611);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 20587, 20611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 20587, 20611);
            }
        }

        public PSTaskPool(int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 20850, 21347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20134, 20147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20179, 20189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20234, 20242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20277, 20288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20344, 20353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20394, 20406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20430, 20437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20902, 20920);

                _sizeLimit = size;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20934, 20949);

                _isOpen = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20963, 20990);

                _syncObject = f_1481_20977_20989();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 21004, 21047);

                _addAvailable = f_1481_21020_21046(true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 21061, 21100);

                _stopAll = f_1481_21072_21099(false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 21114, 21272);

                _waitHandles = new WaitHandle[]
                            {
                _addAvailable,      // index 0
                _stopAll,           // index 1
                            };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 21286, 21336);

                _taskPool = f_1481_21298_21335(size);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 20850, 21347);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 20850, 21347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 20850, 21347);
            }
        }



        /// <summary>
        /// Event that fires when pool is closed and drained of all tasks.
        /// </summary>
        public event EventHandler<EventArgs>
PoolComplete
;

        public bool IsOpen
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 21829, 21839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 21832, 21839);
                    return _isOpen;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 21829, 21839);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 21782, 21851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 21782, 21851);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 21995, 22109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 22041, 22065);

                f_1481_22041_22064(_addAvailable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 22079, 22098);

                f_1481_22079_22097(_stopAll);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 21995, 22109);

                int
                f_1481_22041_22064(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 22041, 22064);
                    return 0;
                }


                int
                f_1481_22079_22097(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 22079, 22097);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 21995, 22109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 21995, 22109);
            }
        }

        public bool Add(PSTaskBase task)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 22591, 23692);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 22648, 22722) || true) && (!_isOpen)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 22648, 22722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 22694, 22707);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 22648, 22722);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 22816, 22861);

                var
                index = f_1481_22828_22860(_waitHandles)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 22877, 23681);

                switch (index)
                {

                    case AddAvailable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 22877, 23681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 22964, 23016);

                        task.StateChanged += HandleTaskStateChangedDelegate;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 23044, 23055);
                        lock (_syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 23105, 23215) || true) && (!_isOpen)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 23105, 23215);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 23175, 23188);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 23105, 23215);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 23243, 23272);

                            f_1481_23243_23271(
                                                    _taskPool, f_1481_23257_23264(task), task);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 23298, 23438) || true) && (f_1481_23302_23317(_taskPool) == _sizeLimit)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 23298, 23438);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 23389, 23411);

                                f_1481_23389_23410(_addAvailable);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 23298, 23438);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 23466, 23479);

                            f_1481_23466_23478(
                                                    task);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 23526, 23538);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 22877, 23681);

                    case Stop:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 22877, 23681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 23590, 23603);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 22877, 23681);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 22877, 23681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 23653, 23666);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 22877, 23681);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 22591, 23692);

                int
                f_1481_22828_22860(System.Threading.WaitHandle[]
                waitHandles)
                {
                    var return_v = WaitHandle.WaitAny(waitHandles);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 22828, 22860);
                    return return_v;
                }


                int
                f_1481_23257_23264(System.Management.Automation.PSTasks.PSTaskBase
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 23257, 23264);
                    return return_v;
                }


                int
                f_1481_23243_23271(System.Collections.Generic.Dictionary<int, System.Management.Automation.PSTasks.PSTaskBase>
                this_param, int
                key, System.Management.Automation.PSTasks.PSTaskBase
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 23243, 23271);
                    return 0;
                }


                int
                f_1481_23302_23317(System.Collections.Generic.Dictionary<int, System.Management.Automation.PSTasks.PSTaskBase>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 23302, 23317);
                    return return_v;
                }


                bool
                f_1481_23389_23410(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 23389, 23410);
                    return return_v;
                }


                int
                f_1481_23466_23478(System.Management.Automation.PSTasks.PSTaskBase
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 23466, 23478);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 22591, 23692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 22591, 23692);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Add(PSTaskChildJob childJob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 23947, 24049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 24012, 24038);

                return f_1481_24019_24037(this, f_1481_24023_24036(childJob));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 23947, 24049);

                System.Management.Automation.PSTasks.PSTaskBase
                f_1481_24023_24036(System.Management.Automation.PSTasks.PSTaskChildJob
                this_param)
                {
                    var return_v = this_param.Task;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 24023, 24036);
                    return return_v;
                }


                bool
                f_1481_24019_24037(System.Management.Automation.PSTasks.PSTaskPool
                this_param, System.Management.Automation.PSTasks.PSTaskBase
                task)
                {
                    var return_v = this_param.Add(task);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 24019, 24037);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 23947, 24049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 23947, 24049);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void StopAll()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 24190, 24555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 24273, 24281);

                f_1481_24273_24280(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 24295, 24310);

                f_1481_24295_24309(_stopAll);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 24371, 24382);

                // Stop all running tasks
                lock (_syncObject)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 24416, 24529);
                        foreach (var task in f_1481_24437_24453_I(f_1481_24437_24453(_taskPool)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 24416, 24529);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 24495, 24510);

                            f_1481_24495_24509(task);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 24416, 24529);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 114);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 114);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 24190, 24555);

                int
                f_1481_24273_24280(System.Management.Automation.PSTasks.PSTaskPool
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 24273, 24280);
                    return 0;
                }


                bool
                f_1481_24295_24309(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 24295, 24309);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<int, System.Management.Automation.PSTasks.PSTaskBase>.ValueCollection
                f_1481_24437_24453(System.Collections.Generic.Dictionary<int, System.Management.Automation.PSTasks.PSTaskBase>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 24437, 24453);
                    return return_v;
                }


                int
                f_1481_24495_24509(System.Management.Automation.PSTasks.PSTaskBase
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 24495, 24509);
                    return 0;
                }


                System.Collections.Generic.Dictionary<int, System.Management.Automation.PSTasks.PSTaskBase>.ValueCollection
                f_1481_24437_24453_I(System.Collections.Generic.Dictionary<int, System.Management.Automation.PSTasks.PSTaskBase>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 24437, 24453);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 24190, 24555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 24190, 24555);
            }
        }

        public void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 24688, 24792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 24732, 24748);

                _isOpen = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 24762, 24781);

                f_1481_24762_24780(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 24688, 24792);

                int
                f_1481_24762_24780(System.Management.Automation.PSTasks.PSTaskPool
                this_param)
                {
                    this_param.CheckForComplete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 24762, 24780);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 24688, 24792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 24688, 24792);
            }
        }

        private void HandleTaskStateChangedDelegate(object sender, PSInvocationStateChangedEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 24960, 24999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 24963, 24999);
                f_1481_24963_24999(this, sender, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 24960, 24999);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 24960, 24999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 24960, 24999);
            }

            int
            f_1481_24963_24999(System.Management.Automation.PSTasks.PSTaskPool
            this_param, object
            sender, System.Management.Automation.PSInvocationStateChangedEventArgs
            args)
            {
                this_param.HandleTaskStateChanged(sender, args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 24963, 24999);
                return 0;
            }

        }

        private void HandleTaskStateChanged(object sender, PSInvocationStateChangedEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 25012, 26076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 25127, 25159);

                var
                task = sender as PSTaskBase
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 25173, 25248);

                f_1481_25173_25247(task != null, "State changed sender must always be PSTaskBase");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 25262, 25303);

                var
                stateInfo = f_1481_25278_25302(args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 25317, 26065);

                switch (f_1481_25325_25340(stateInfo))
                {

                    case PSInvocationState.Completed:
                    case PSInvocationState.Stopped:
                    case PSInvocationState.Failed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 25317, 26065);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 25588, 25599);
                        lock (_syncObject)
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 25649, 25675);

                            f_1481_25649_25674(_taskPool, f_1481_25666_25673(task));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 25701, 25845) || true) && (f_1481_25705_25720(_taskPool) == (_sizeLimit - 1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 25701, 25845);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 25798, 25818);

                                f_1481_25798_25817(_addAvailable);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 25701, 25845);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 25892, 25944);

                        task.StateChanged -= HandleTaskStateChangedDelegate;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 25966, 25981);

                        f_1481_25966_25980(task);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 26003, 26022);

                        f_1481_26003_26021(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1481, 26044, 26050);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 25317, 26065);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 25012, 26076);

                int
                f_1481_25173_25247(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 25173, 25247);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1481_25278_25302(System.Management.Automation.PSInvocationStateChangedEventArgs
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 25278, 25302);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1481_25325_25340(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 25325, 25340);
                    return return_v;
                }


                int
                f_1481_25666_25673(System.Management.Automation.PSTasks.PSTaskBase
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 25666, 25673);
                    return return_v;
                }


                bool
                f_1481_25649_25674(System.Collections.Generic.Dictionary<int, System.Management.Automation.PSTasks.PSTaskBase>
                this_param, int
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 25649, 25674);
                    return return_v;
                }


                int
                f_1481_25705_25720(System.Collections.Generic.Dictionary<int, System.Management.Automation.PSTasks.PSTaskBase>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 25705, 25720);
                    return return_v;
                }


                bool
                f_1481_25798_25817(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 25798, 25817);
                    return return_v;
                }


                int
                f_1481_25966_25980(System.Management.Automation.PSTasks.PSTaskBase
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 25966, 25980);
                    return 0;
                }


                int
                f_1481_26003_26021(System.Management.Automation.PSTasks.PSTaskPool
                this_param)
                {
                    this_param.CheckForComplete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 26003, 26021);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 25012, 26076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 25012, 26076);
            }
        }

        private void CheckForComplete()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 26088, 26713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 26144, 26168);

                bool
                isTaskPoolComplete
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 26188, 26199);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 26233, 26287);

                    isTaskPoolComplete = !_isOpen && (DynAbs.Tracing.TraceSender.Expression_True(1481, 26254, 26286) && f_1481_26266_26281(_taskPool) == 0);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 26318, 26702) || true) && (isTaskPoolComplete)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 26318, 26702);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 26418, 26516);

                        f_1481_26418_26515(PoolComplete, this, f_1481_26499_26514());
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1481, 26553, 26687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 26599, 26668);

                        f_1481_26599_26667(false, "Exceptions should not be thrown on event thread");
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1481, 26553, 26687);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 26318, 26702);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 26088, 26713);

                int
                f_1481_26266_26281(System.Collections.Generic.Dictionary<int, System.Management.Automation.PSTasks.PSTaskBase>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 26266, 26281);
                    return return_v;
                }


                System.EventArgs
                f_1481_26499_26514()
                {
                    var return_v = new System.EventArgs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 26499, 26514);
                    return return_v;
                }


                int
                f_1481_26418_26515(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.PSTasks.PSTaskPool
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 26418, 26515);
                    return 0;
                }


                int
                f_1481_26599_26667(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 26599, 26667);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 26088, 26713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 26088, 26713);
            }
        }

        static PSTaskPool()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1481, 20010, 26742);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20468, 20484);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 20513, 20521);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1481, 20010, 26742);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 20010, 26742);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1481, 20010, 26742);

        object
        f_1481_20977_20989()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 20977, 20989);
            return return_v;
        }


        System.Threading.ManualResetEvent
        f_1481_21020_21046(bool
        initialState)
        {
            var return_v = new System.Threading.ManualResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 21020, 21046);
            return return_v;
        }


        System.Threading.ManualResetEvent
        f_1481_21072_21099(bool
        initialState)
        {
            var return_v = new System.Threading.ManualResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 21072, 21099);
            return return_v;
        }


        System.Collections.Generic.Dictionary<int, System.Management.Automation.PSTasks.PSTaskBase>
        f_1481_21298_21335(int
        capacity)
        {
            var return_v = new System.Collections.Generic.Dictionary<int, System.Management.Automation.PSTasks.PSTaskBase>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 21298, 21335);
            return return_v;
        }

    }
    internal sealed class PSTaskJob : Job
    {
        private readonly PSTaskPool _taskPool;

        private bool _isOpen;

        private bool _stopSignaled;

        private PSTaskJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 27166, 27189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 27023, 27032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 27056, 27063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 27087, 27100);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 27166, 27189);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 27166, 27189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 27166, 27189);
            }
        }

        public PSTaskJob(
                    string command,
                    int throttleLimit) : base(f_1481_27552_27559_C(command), string.Empty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 27466, 27826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 27023, 27032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 27056, 27063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 27087, 27100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 27599, 27641);

                _taskPool = f_1481_27611_27640(throttleLimit);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 27655, 27670);

                _isOpen = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 27684, 27718);

                PSJobTypeName = nameof(PSTaskJob);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 27734, 27815);

                _taskPool.PoolComplete += (sender, args) => HandleTaskPoolComplete(sender, args);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 27466, 27826);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 27466, 27826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 27466, 27826);
            }
        }

        public override string Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 28024, 28039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 28027, 28039);
                    return "PowerShell";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 28024, 28039);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 27964, 28051);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 27964, 28051);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasMoreData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 28198, 28486);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 28234, 28438);
                        foreach (var childJob in f_1481_28259_28268_I(f_1481_28259_28268()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 28234, 28438);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 28310, 28419) || true) && (f_1481_28314_28334(childJob))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 28310, 28419);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 28384, 28396);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 28310, 28419);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 28234, 28438);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 205);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 205);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 28458, 28471);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 28198, 28486);

                    System.Collections.Generic.IList<System.Management.Automation.Job>
                    f_1481_28259_28268()
                    {
                        var return_v = ChildJobs;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 28259, 28268);
                        return return_v;
                    }


                    bool
                    f_1481_28314_28334(System.Management.Automation.Job
                    this_param)
                    {
                        var return_v = this_param.HasMoreData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 28314, 28334);
                        return return_v;
                    }


                    System.Collections.Generic.IList<System.Management.Automation.Job>
                    f_1481_28259_28268_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 28259, 28268);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 28141, 28497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 28141, 28497);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string StatusMessage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 28654, 28669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 28657, 28669);
                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 28654, 28669);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 28589, 28681);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 28589, 28681);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void StopJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 28772, 28984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 28827, 28848);

                _stopSignaled = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 28862, 28893);

                f_1481_28862_28892(this, JobState.Stopping);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 28909, 28929);

                f_1481_28909_28928(
                            _taskPool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 28943, 28973);

                f_1481_28943_28972(this, JobState.Stopped);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 28772, 28984);

                int
                f_1481_28862_28892(System.Management.Automation.PSTasks.PSTaskJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 28862, 28892);
                    return 0;
                }


                int
                f_1481_28909_28928(System.Management.Automation.PSTasks.PSTaskPool
                this_param)
                {
                    this_param.StopAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 28909, 28928);
                    return 0;
                }


                int
                f_1481_28943_28972(System.Management.Automation.PSTasks.PSTaskJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 28943, 28972);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 28772, 28984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 28772, 28984);
            }
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 29148, 29353);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 29220, 29302) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 29220, 29302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 29267, 29287);

                    f_1481_29267_29286(_taskPool);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 29220, 29302);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 29318, 29342);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing), 1481, 29318, 29341);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 29148, 29353);

                int
                f_1481_29267_29286(System.Management.Automation.PSTasks.PSTaskPool
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 29267, 29286);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 29148, 29353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 29148, 29353);
            }
        }

        public bool AddJob(PSTaskChildJob childJob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 29653, 29872);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 29721, 29795) || true) && (!_isOpen)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 29721, 29795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 29767, 29780);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 29721, 29795);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 29811, 29835);

                f_1481_29811_29834(f_1481_29811_29820(), childJob);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 29849, 29861);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 29653, 29872);

                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1481_29811_29820()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 29811, 29820);
                    return return_v;
                }


                int
                f_1481_29811_29834(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param, System.Management.Automation.PSTasks.PSTaskChildJob
                item)
                {
                    this_param.Add((System.Management.Automation.Job)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 29811, 29834);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 29653, 29872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 29653, 29872);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Start()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 30074, 30772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 30118, 30134);

                _isOpen = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 30148, 30178);

                f_1481_30148_30177(this, JobState.Running);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 30440, 30761);

                f_1481_30440_30760((_) =>
                                {
                                    foreach (var childJob in ChildJobs)
                                    {
                                        _taskPool.Add((PSTaskChildJob)childJob);
                                    }

                                    _taskPool.Close();
                                });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 30074, 30772);

                int
                f_1481_30148_30177(System.Management.Automation.PSTasks.PSTaskJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 30148, 30177);
                    return 0;
                }


                bool
                f_1481_30440_30760(System.Threading.WaitCallback
                callBack)
                {
                    var return_v = System.Threading.ThreadPool.QueueUserWorkItem(callBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 30440, 30760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 30074, 30772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 30074, 30772);
            }
        }

        private void HandleTaskPoolComplete(object sender, EventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 30841, 31729);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 30968, 31137) || true) && (_stopSignaled)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 30968, 31137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 31027, 31089);

                        f_1481_31027_31088(this, JobState.Stopped, f_1481_31057_31087());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 31111, 31118);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 30968, 31137);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 31256, 31297);

                    JobState
                    finalState = JobState.Completed
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 31315, 31597);
                        foreach (var childJob in f_1481_31340_31349_I(f_1481_31340_31349()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 31315, 31597);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 31391, 31578) || true) && (f_1481_31395_31422(f_1481_31395_31416(childJob)) != JobState.Completed)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 31391, 31578);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 31494, 31523);

                                finalState = JobState.Failed;
                                DynAbs.Tracing.TraceSender.TraceBreak(1481, 31549, 31555);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 31391, 31578);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 31315, 31597);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1481, 1, 283);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1481, 1, 283);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 31617, 31641);

                    f_1481_31617_31640(this, finalState);
                }
                catch (ObjectDisposedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1481, 31670, 31718);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1481, 31670, 31718);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 30841, 31729);

                System.Management.Automation.PipelineStoppedException
                f_1481_31057_31087()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 31057, 31087);
                    return return_v;
                }


                int
                f_1481_31027_31088(System.Management.Automation.PSTasks.PSTaskJob
                this_param, System.Management.Automation.JobState
                state, System.Management.Automation.PipelineStoppedException
                reason)
                {
                    this_param.SetJobState(state, (System.Exception)reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 31027, 31088);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1481_31340_31349()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 31340, 31349);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1481_31395_31416(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 31395, 31416);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1481_31395_31422(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 31395, 31422);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1481_31340_31349_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 31340, 31349);
                    return return_v;
                }


                int
                f_1481_31617_31640(System.Management.Automation.PSTasks.PSTaskJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 31617, 31640);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 30841, 31729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 30841, 31729);
            }
        }

        static PSTaskJob()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1481, 26914, 31758);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1481, 26914, 31758);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 26914, 31758);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1481, 26914, 31758);

        System.Management.Automation.PSTasks.PSTaskPool
        f_1481_27611_27640(int
        size)
        {
            var return_v = new System.Management.Automation.PSTasks.PSTaskPool(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 27611, 27640);
            return return_v;
        }


        static string
        f_1481_27552_27559_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1481, 27466, 27826);
            return return_v;
        }

    }
    internal sealed class PSTaskChildDebugger : Debugger
    {
        private readonly Debugger _wrappedDebugger;

        private readonly string _jobName;

        private PSTaskChildDebugger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 32094, 32127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 31969, 31985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 32020, 32028);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 32094, 32127);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 32094, 32127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 32094, 32127);
            }
        }

        public PSTaskChildDebugger(
                    Debugger debugger,
                    string jobName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 32429, 32966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 31969, 31985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 32020, 32028);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 32542, 32657) || true) && (debugger == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 32542, 32657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 32596, 32642);

                    throw f_1481_32602_32641("debugger");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 32542, 32657);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 32673, 32701);

                _wrappedDebugger = debugger;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 32715, 32750);

                _jobName = jobName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1481, 32726, 32749) ?? string.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 32827, 32889);

                _wrappedDebugger.BreakpointUpdated += HandleBreakpointUpdated;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 32903, 32955);

                _wrappedDebugger.DebuggerStop += HandleDebuggerStop;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 32429, 32966);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 32429, 32966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 32429, 32966);
            }
        }

        public override DebuggerCommandResults ProcessCommand(
                    PSCommand command,
                    PSDataCollection<PSObject> output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 33383, 33861);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 33599, 33778) || true) && (f_1481_33603_33694(f_1481_33603_33641(f_1481_33603_33634(f_1481_33603_33622(f_1481_33603_33619(command), 0))), "prompt", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 33599, 33778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 33728, 33763);

                    return f_1481_33735_33762(this, output);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 33599, 33778);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 33794, 33850);

                return f_1481_33801_33849(_wrappedDebugger, command, output);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 33383, 33861);

                System.Management.Automation.Runspaces.CommandCollection
                f_1481_33603_33619(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 33603, 33619);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1481_33603_33622(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 33603, 33622);
                    return return_v;
                }


                string
                f_1481_33603_33634(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 33603, 33634);
                    return return_v;
                }


                string
                f_1481_33603_33641(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 33603, 33641);
                    return return_v;
                }


                bool
                f_1481_33603_33694(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 33603, 33694);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommandResults
                f_1481_33735_33762(System.Management.Automation.PSTasks.PSTaskChildDebugger
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = this_param.HandlePromptCommand(output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 33735, 33762);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommandResults
                f_1481_33801_33849(System.Management.Automation.Debugger
                this_param, System.Management.Automation.PSCommand
                command, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = this_param.ProcessCommand(command, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 33801, 33849);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 33383, 33861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 33383, 33861);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void SetBreakpoints(IEnumerable<Breakpoint> breakpoints, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 34294, 34366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 34310, 34366);
                f_1481_34310_34366(_wrappedDebugger, breakpoints, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 34294, 34366);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 34294, 34366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 34294, 34366);
            }

            int
            f_1481_34310_34366(System.Management.Automation.Debugger
            this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.Breakpoint>
            breakpoints, int?
            runspaceId)
            {
                this_param.SetBreakpoints(breakpoints, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 34310, 34366);
                return 0;
            }

        }

        public override void SetDebuggerAction(DebuggerResumeAction resumeAction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 34544, 34702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 34642, 34691);

                f_1481_34642_34690(_wrappedDebugger, resumeAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 34544, 34702);

                int
                f_1481_34642_34690(System.Management.Automation.Debugger
                this_param, System.Management.Automation.DebuggerResumeAction
                resumeAction)
                {
                    this_param.SetDebuggerAction(resumeAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 34642, 34690);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 34544, 34702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 34544, 34702);
            }
        }

        public override Breakpoint GetBreakpoint(int id, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 35210, 35272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 35226, 35272);
                return f_1481_35226_35272(_wrappedDebugger, id, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 35210, 35272);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 35210, 35272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 35210, 35272);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Breakpoint
            f_1481_35226_35272(System.Management.Automation.Debugger
            this_param, int
            id, int?
            runspaceId)
            {
                var return_v = this_param.GetBreakpoint(id, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 35226, 35272);
                return return_v;
            }

        }

        public override List<Breakpoint> GetBreakpoints(int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 35663, 35722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 35679, 35722);
                return f_1481_35679_35722(_wrappedDebugger, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 35663, 35722);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 35663, 35722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 35663, 35722);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.List<System.Management.Automation.Breakpoint>
            f_1481_35679_35722(System.Management.Automation.Debugger
            this_param, int?
            runspaceId)
            {
                var return_v = this_param.GetBreakpoints(runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 35679, 35722);
                return return_v;
            }

        }

        public override CommandBreakpoint SetCommandBreakpoint(string command, ScriptBlock action, string path, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 36641, 36729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 36657, 36729);
                return f_1481_36657_36729(_wrappedDebugger, command, action, path, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 36641, 36729);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 36641, 36729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 36641, 36729);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.CommandBreakpoint
            f_1481_36657_36729(System.Management.Automation.Debugger
            this_param, string
            command, System.Management.Automation.ScriptBlock
            action, string
            path, int?
            runspaceId)
            {
                var return_v = this_param.SetCommandBreakpoint(command, action, path, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 36657, 36729);
                return return_v;
            }

        }

        public override VariableBreakpoint SetVariableBreakpoint(string variableName, VariableAccessMode accessMode, ScriptBlock action, string path, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 37833, 37939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 37849, 37939);
                return f_1481_37849_37939(_wrappedDebugger, variableName, accessMode, action, path, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 37833, 37939);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 37833, 37939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 37833, 37939);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.VariableBreakpoint
            f_1481_37849_37939(System.Management.Automation.Debugger
            this_param, string
            variableName, System.Management.Automation.VariableAccessMode
            accessMode, System.Management.Automation.ScriptBlock
            action, string
            path, int?
            runspaceId)
            {
                var return_v = this_param.SetVariableBreakpoint(variableName, accessMode, action, path, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 37849, 37939);
                return return_v;
            }

        }

        public override LineBreakpoint SetLineBreakpoint(string path, int line, int column, ScriptBlock action, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 39000, 39090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 39016, 39090);
                return f_1481_39016_39090(_wrappedDebugger, path, line, column, action, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 39000, 39090);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 39000, 39090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 39000, 39090);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.LineBreakpoint
            f_1481_39016_39090(System.Management.Automation.Debugger
            this_param, string
            path, int
            line, int
            column, System.Management.Automation.ScriptBlock
            action, int?
            runspaceId)
            {
                var return_v = this_param.SetLineBreakpoint(path, line, column, action, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 39016, 39090);
                return return_v;
            }

        }

        public override Breakpoint EnableBreakpoint(Breakpoint breakpoint, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 39676, 39749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 39692, 39749);
                return f_1481_39692_39749(_wrappedDebugger, breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 39676, 39749);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 39676, 39749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 39676, 39749);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Breakpoint
            f_1481_39692_39749(System.Management.Automation.Debugger
            this_param, System.Management.Automation.Breakpoint
            breakpoint, int?
            runspaceId)
            {
                var return_v = this_param.EnableBreakpoint(breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 39692, 39749);
                return return_v;
            }

        }

        public override Breakpoint DisableBreakpoint(Breakpoint breakpoint, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 40337, 40411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 40353, 40411);
                return f_1481_40353_40411(_wrappedDebugger, breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 40337, 40411);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 40337, 40411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 40337, 40411);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Breakpoint
            f_1481_40353_40411(System.Management.Automation.Debugger
            this_param, System.Management.Automation.Breakpoint
            breakpoint, int?
            runspaceId)
            {
                var return_v = this_param.DisableBreakpoint(breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 40353, 40411);
                return return_v;
            }

        }

        public override bool RemoveBreakpoint(Breakpoint breakpoint, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 40972, 41045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 40988, 41045);
                return f_1481_40988_41045(_wrappedDebugger, breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 40972, 41045);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 40972, 41045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 40972, 41045);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_1481_40988_41045(System.Management.Automation.Debugger
            this_param, System.Management.Automation.Breakpoint
            breakpoint, int?
            runspaceId)
            {
                var return_v = this_param.RemoveBreakpoint(breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 40988, 41045);
                return return_v;
            }

        }

        public override void StopProcessCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 41143, 41258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 41209, 41247);

                f_1481_41209_41246(_wrappedDebugger);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 41143, 41258);

                int
                f_1481_41209_41246(System.Management.Automation.Debugger
                this_param)
                {
                    this_param.StopProcessCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 41209, 41246);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 41143, 41258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 41143, 41258);
            }
        }

        public override DebuggerStopEventArgs GetDebuggerStopArgs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 41507, 41648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 41591, 41637);

                return f_1481_41598_41636(_wrappedDebugger);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 41507, 41648);

                System.Management.Automation.DebuggerStopEventArgs
                f_1481_41598_41636(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.GetDebuggerStopArgs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 41598, 41636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 41507, 41648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 41507, 41648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void SetParent(
                    Debugger parent,
                    IEnumerable<Breakpoint> breakPoints,
                    DebuggerResumeAction? startAction,
                    PSHost host,
                    PathInfo path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 42100, 42434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 42397, 42423);

                f_1481_42397_42422(this, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 42100, 42434);

                int
                f_1481_42397_42422(System.Management.Automation.PSTasks.PSTaskChildDebugger
                this_param, bool
                enabled)
                {
                    this_param.SetDebuggerStepMode(enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 42397, 42422);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 42100, 42434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 42100, 42434);
            }
        }

        public override void SetDebugMode(DebugModes mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 42592, 42754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 42667, 42703);

                f_1481_42667_42702(_wrappedDebugger, mode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 42719, 42743);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetDebugMode(mode), 1481, 42719, 42742);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 42592, 42754);

                int
                f_1481_42667_42702(System.Management.Automation.Debugger
                this_param, System.Management.Automation.DebugModes
                mode)
                {
                    this_param.SetDebugMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 42667, 42702);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 42592, 42754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 42592, 42754);
            }
        }

        public override IEnumerable<CallStackFrame> GetCallStack()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 42928, 43061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 43011, 43050);

                return f_1481_43018_43049(_wrappedDebugger);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 42928, 43061);

                System.Collections.Generic.IEnumerable<System.Management.Automation.CallStackFrame>
                f_1481_43018_43049(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.GetCallStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 43018, 43049);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 42928, 43061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 42928, 43061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void SetDebuggerStepMode(bool enabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 43240, 43376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 43319, 43365);

                f_1481_43319_43364(_wrappedDebugger, enabled);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 43240, 43376);

                int
                f_1481_43319_43364(System.Management.Automation.Debugger
                this_param, bool
                enabled)
                {
                    this_param.SetDebuggerStepMode(enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 43319, 43364);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 43240, 43376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 43240, 43376);
            }
        }

        public override bool InBreakpoint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 43576, 43608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 43579, 43608);
                    return f_1481_43579_43608(_wrappedDebugger);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 43576, 43608);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 43514, 43620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 43514, 43620);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void HandleDebuggerStop(object sender, DebuggerStopEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 43689, 43827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 43785, 43816);

                f_1481_43785_43815(this, e);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 43689, 43827);

                int
                f_1481_43785_43815(System.Management.Automation.PSTasks.PSTaskChildDebugger
                this_param, System.Management.Automation.DebuggerStopEventArgs
                args)
                {
                    this_param.RaiseDebuggerStopEvent(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 43785, 43815);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 43689, 43827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 43689, 43827);
            }
        }

        private void HandleBreakpointUpdated(object sender, BreakpointUpdatedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 43839, 43992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 43945, 43981);

                f_1481_43945_43980(this, e);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 43839, 43992);

                int
                f_1481_43945_43980(System.Management.Automation.PSTasks.PSTaskChildDebugger
                this_param, System.Management.Automation.BreakpointUpdatedEventArgs
                args)
                {
                    this_param.RaiseBreakpointUpdatedEvent(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 43945, 43980);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 43839, 43992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 43839, 43992);
            }
        }

        private DebuggerCommandResults HandlePromptCommand(PSDataCollection<PSObject> output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 44004, 44668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 44223, 44418);

                string
                promptScript = "'[DBG]: '" + " + " + "'[" + f_1481_44274_44330(_jobName) + "]: '" + " + " + @"""PS $($executionContext.SessionState.Path.CurrentLocation)>> """
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 44432, 44474);

                PSCommand
                promptCommand = f_1481_44458_44473()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 44488, 44526);

                f_1481_44488_44525(promptCommand, promptScript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 44540, 44595);

                f_1481_44540_44594(_wrappedDebugger, promptCommand, output);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 44611, 44657);

                return f_1481_44618_44656(null, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 44004, 44668);

                string
                f_1481_44274_44330(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 44274, 44330);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1481_44458_44473()
                {
                    var return_v = new System.Management.Automation.PSCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 44458, 44473);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1481_44488_44525(System.Management.Automation.PSCommand
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 44488, 44525);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommandResults
                f_1481_44540_44594(System.Management.Automation.Debugger
                this_param, System.Management.Automation.PSCommand
                command, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = this_param.ProcessCommand(command, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 44540, 44594);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommandResults
                f_1481_44618_44656(System.Management.Automation.DebuggerResumeAction?
                resumeAction, bool
                evaluatedByDebugger)
                {
                    var return_v = new System.Management.Automation.DebuggerCommandResults(resumeAction, evaluatedByDebugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 44618, 44656);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 44004, 44668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 44004, 44668);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSTaskChildDebugger()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1481, 31847, 44697);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1481, 31847, 44697);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 31847, 44697);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1481, 31847, 44697);

        System.Management.Automation.PSArgumentNullException
        f_1481_32602_32641(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 32602, 32641);
            return return_v;
        }


        bool
        f_1481_43579_43608(System.Management.Automation.Debugger
        this_param)
        {
            var return_v = this_param.InBreakpoint;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 43579, 43608);
            return return_v;
        }

    }
    internal sealed class PSTaskChildJob : Job, IJobDebugger
    {
        private readonly PSJobTask _task;

        private PSTaskChildDebugger _jobDebuggerWrapper;

        private PSTaskChildJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 45065, 45093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 44936, 44941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 44980, 44999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 47995, 48028);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 45065, 45093);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 45065, 45093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 45065, 45093);
            }
        }

        public PSTaskChildJob(
                    ScriptBlock scriptBlock,
                    Dictionary<string, object> usingValuesMap,
                    object dollarUnderbar,
                    string currentLocationPath)
        : base(f_1481_45777_45799_C(f_1481_45777_45799(scriptBlock)), string.Empty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1481, 45563, 46089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 44936, 44941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 44980, 44999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 47995, 48028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 45841, 45880);

                PSJobTypeName = nameof(PSTaskChildJob);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 45894, 45988);

                _task = f_1481_45902_45987(scriptBlock, usingValuesMap, dollarUnderbar, currentLocationPath, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 46002, 46078);

                _task.StateChanged += (sender, args) => HandleTaskStateChange(sender, args);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1481, 45563, 46089);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 45563, 46089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 45563, 46089);
            }
        }

        internal PSTaskBase Task
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 46287, 46295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 46290, 46295);
                    return _task;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 46287, 46295);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 46234, 46307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 46234, 46307);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 46505, 46520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 46508, 46520);
                    return "PowerShell";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 46505, 46520);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 46445, 46532);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 46445, 46532);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasMoreData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 46683, 46984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 46686, 46984);
                    return f_1481_46686_46703(f_1481_46686_46697(this)) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(1481, 46686, 46751) || f_1481_46731_46747(f_1481_46731_46741(this)) > 0) || (DynAbs.Tracing.TraceSender.Expression_False(1481, 46686, 46798) || f_1481_46775_46794(f_1481_46775_46788(this)) > 0) || (DynAbs.Tracing.TraceSender.Expression_False(1481, 46686, 46844) || f_1481_46822_46840(f_1481_46822_46834(this)) > 0) || (DynAbs.Tracing.TraceSender.Expression_False(1481, 46686, 46888) || f_1481_46868_46884(f_1481_46868_46878(this)) > 0) || (DynAbs.Tracing.TraceSender.Expression_False(1481, 46686, 46934) || f_1481_46912_46930(f_1481_46912_46924(this)) > 0) || (DynAbs.Tracing.TraceSender.Expression_False(1481, 46686, 46984) || f_1481_46958_46980(f_1481_46958_46974(this)) > 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 46683, 46984);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 46622, 46996);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 46622, 46996);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string StatusMessage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 47153, 47168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 47156, 47168);
                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 47153, 47168);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 47088, 47180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 47088, 47180);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void StopJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 47271, 47356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 47326, 47345);

                f_1481_47326_47344(_task);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 47271, 47356);

                int
                f_1481_47326_47344(System.Management.Automation.PSTasks.PSJobTask
                this_param)
                {
                    this_param.SignalStop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 47326, 47344);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 47271, 47356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 47271, 47356);
            }
        }

        public Debugger Debugger
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 47550, 47864);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 47586, 47802) || true) && (_jobDebuggerWrapper == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 47586, 47802);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 47659, 47783);

                        _jobDebuggerWrapper = f_1481_47681_47782(f_1481_47731_47745(_task), f_1481_47772_47781(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 47586, 47802);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 47822, 47849);

                    return _jobDebuggerWrapper;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 47550, 47864);

                    System.Management.Automation.Debugger
                    f_1481_47731_47745(System.Management.Automation.PSTasks.PSJobTask
                    this_param)
                    {
                        var return_v = this_param.Debugger;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 47731, 47745);
                        return return_v;
                    }


                    string
                    f_1481_47772_47781(System.Management.Automation.PSTasks.PSTaskChildJob
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 47772, 47781);
                        return return_v;
                    }


                    System.Management.Automation.PSTasks.PSTaskChildDebugger
                    f_1481_47681_47782(System.Management.Automation.Debugger
                    debugger, string
                    jobName)
                    {
                        var return_v = new System.Management.Automation.PSTasks.PSTaskChildDebugger(debugger, jobName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 47681, 47782);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 47501, 47875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 47501, 47875);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsAsync { get; set; }

        private void HandleTaskStateChange(object sender, PSInvocationStateChangedEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1481, 48097, 48911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 48211, 48252);

                var
                stateInfo = f_1481_48227_48251(args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 48268, 48900);

                switch (f_1481_48276_48291(stateInfo))
                {

                    case PSInvocationState.Running:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 48268, 48900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 48378, 48408);

                        f_1481_48378_48407(this, JobState.Running);
                        DynAbs.Tracing.TraceSender.TraceBreak(1481, 48430, 48436);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 48268, 48900);

                    case PSInvocationState.Stopped:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 48268, 48900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 48509, 48557);

                        f_1481_48509_48556(this, JobState.Stopped, f_1481_48539_48555(stateInfo));
                        DynAbs.Tracing.TraceSender.TraceBreak(1481, 48579, 48585);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 48268, 48900);

                    case PSInvocationState.Failed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 48268, 48900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 48657, 48704);

                        f_1481_48657_48703(this, JobState.Failed, f_1481_48686_48702(stateInfo));
                        DynAbs.Tracing.TraceSender.TraceBreak(1481, 48726, 48732);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 48268, 48900);

                    case PSInvocationState.Completed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1481, 48268, 48900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1481, 48807, 48857);

                        f_1481_48807_48856(this, JobState.Completed, f_1481_48839_48855(stateInfo));
                        DynAbs.Tracing.TraceSender.TraceBreak(1481, 48879, 48885);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1481, 48268, 48900);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1481, 48097, 48911);

                System.Management.Automation.PSInvocationStateInfo
                f_1481_48227_48251(System.Management.Automation.PSInvocationStateChangedEventArgs
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 48227, 48251);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1481_48276_48291(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 48276, 48291);
                    return return_v;
                }


                int
                f_1481_48378_48407(System.Management.Automation.PSTasks.PSTaskChildJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 48378, 48407);
                    return 0;
                }


                System.Exception
                f_1481_48539_48555(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 48539, 48555);
                    return return_v;
                }


                int
                f_1481_48509_48556(System.Management.Automation.PSTasks.PSTaskChildJob
                this_param, System.Management.Automation.JobState
                state, System.Exception
                reason)
                {
                    this_param.SetJobState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 48509, 48556);
                    return 0;
                }


                System.Exception
                f_1481_48686_48702(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 48686, 48702);
                    return return_v;
                }


                int
                f_1481_48657_48703(System.Management.Automation.PSTasks.PSTaskChildJob
                this_param, System.Management.Automation.JobState
                state, System.Exception
                reason)
                {
                    this_param.SetJobState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 48657, 48703);
                    return 0;
                }


                System.Exception
                f_1481_48839_48855(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 48839, 48855);
                    return return_v;
                }


                int
                f_1481_48807_48856(System.Management.Automation.PSTasks.PSTaskChildJob
                this_param, System.Management.Automation.JobState
                state, System.Exception
                reason)
                {
                    this_param.SetJobState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 48807, 48856);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1481, 48097, 48911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 48097, 48911);
            }
        }

        static PSTaskChildJob()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1481, 44809, 48940);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1481, 44809, 48940);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1481, 44809, 48940);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1481, 44809, 48940);

        static string
        f_1481_45777_45799(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 45777, 45799);
            return return_v;
        }


        System.Management.Automation.PSTasks.PSJobTask
        f_1481_45902_45987(System.Management.Automation.ScriptBlock
        scriptBlock, System.Collections.Generic.Dictionary<string, object>
        usingValuesMap, object
        dollarUnderbar, string
        currentLocationPath, System.Management.Automation.PSTasks.PSTaskChildJob
        job)
        {
            var return_v = new System.Management.Automation.PSTasks.PSJobTask(scriptBlock, usingValuesMap, dollarUnderbar, currentLocationPath, (System.Management.Automation.Job)job);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1481, 45902, 45987);
            return return_v;
        }


        static string
        f_1481_45777_45799_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1481, 45563, 46089);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
        f_1481_46686_46697(System.Management.Automation.PSTasks.PSTaskChildJob
        this_param)
        {
            var return_v = this_param.Output;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46686, 46697);
            return return_v;
        }


        int
        f_1481_46686_46703(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46686, 46703);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
        f_1481_46731_46741(System.Management.Automation.PSTasks.PSTaskChildJob
        this_param)
        {
            var return_v = this_param.Error;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46731, 46741);
            return return_v;
        }


        int
        f_1481_46731_46747(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46731, 46747);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
        f_1481_46775_46788(System.Management.Automation.PSTasks.PSTaskChildJob
        this_param)
        {
            var return_v = this_param.Progress;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46775, 46788);
            return return_v;
        }


        int
        f_1481_46775_46794(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46775, 46794);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
        f_1481_46822_46834(System.Management.Automation.PSTasks.PSTaskChildJob
        this_param)
        {
            var return_v = this_param.Verbose;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46822, 46834);
            return return_v;
        }


        int
        f_1481_46822_46840(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46822, 46840);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
        f_1481_46868_46878(System.Management.Automation.PSTasks.PSTaskChildJob
        this_param)
        {
            var return_v = this_param.Debug;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46868, 46878);
            return return_v;
        }


        int
        f_1481_46868_46884(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46868, 46884);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
        f_1481_46912_46924(System.Management.Automation.PSTasks.PSTaskChildJob
        this_param)
        {
            var return_v = this_param.Warning;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46912, 46924);
            return return_v;
        }


        int
        f_1481_46912_46930(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46912, 46930);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
        f_1481_46958_46974(System.Management.Automation.PSTasks.PSTaskChildJob
        this_param)
        {
            var return_v = this_param.Information;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46958, 46974);
            return return_v;
        }


        int
        f_1481_46958_46980(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1481, 46958, 46980);
            return return_v;
        }

    }

}
