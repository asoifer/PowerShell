// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;

namespace System.Management.Automation
{
    internal class PowerShellExecutionHelper
    {
        internal PowerShellExecutionHelper(PowerShell powershell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1035, 551, 821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 1101, 1148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 1278, 1329);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 633, 763) || true) && (powershell == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 633, 763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 689, 748);

                    throw f_1035_695_747("powershell");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 633, 763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 779, 810);

                CurrentPowerShell = powershell;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1035, 551, 821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1035, 551, 821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 551, 821);
            }
        }

        internal bool CancelTabCompletion { get; set; }

        internal PowerShell CurrentPowerShell { get; set; }

        internal bool IsRunning
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1035, 1440, 1515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 1443, 1515);
                    return f_1035_1443_1486(f_1035_1443_1480(f_1035_1443_1460())) == PSInvocationState.Running;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1035, 1440, 1515);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1035, 1440, 1515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 1440, 1515);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsStopped
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1035, 1630, 1705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 1633, 1705);
                    return f_1035_1633_1676(f_1035_1633_1670(f_1035_1633_1650())) == PSInvocationState.Stopped;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1035, 1630, 1705);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1035, 1630, 1705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 1630, 1705);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Collection<PSObject> ExecuteCommand(string command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1035, 1799, 1981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 1884, 1901);

                Exception
                unused
                = default(Exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 1915, 1970);

                return f_1035_1922_1969(this, command, true, out unused, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1035, 1799, 1981);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1035_1922_1969(System.Management.Automation.PowerShellExecutionHelper
                this_param, string
                command, bool
                isScript, out System.Exception
                exceptionThrown, System.Collections.Hashtable
                args)
                {
                    var return_v = this_param.ExecuteCommand(command, isScript, out exceptionThrown, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 1922, 1969);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1035, 1799, 1981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 1799, 1981);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ExecuteCommandAndGetResultAsBool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1035, 1993, 2505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 2066, 2092);

                Exception
                exceptionThrown
                = default(Exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 2106, 2189);

                Collection<PSObject>
                streamResults = f_1035_2143_2188(this, out exceptionThrown)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 2205, 2347) || true) && (exceptionThrown != null || (DynAbs.Tracing.TraceSender.Expression_False(1035, 2209, 2257) || streamResults == null) || (DynAbs.Tracing.TraceSender.Expression_False(1035, 2209, 2285) || f_1035_2261_2280(streamResults) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 2205, 2347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 2319, 2332);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 2205, 2347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 2412, 2494);

                return (f_1035_2420_2439(streamResults) > 1) || (DynAbs.Tracing.TraceSender.Expression_False(1035, 2419, 2493) || (f_1035_2449_2492(f_1035_2475_2491(streamResults, 0))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1035, 1993, 2505);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1035_2143_2188(System.Management.Automation.PowerShellExecutionHelper
                this_param, out System.Exception
                exceptionThrown)
                {
                    var return_v = this_param.ExecuteCurrentPowerShell(out exceptionThrown);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 2143, 2188);
                    return return_v;
                }


                int
                f_1035_2261_2280(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 2261, 2280);
                    return return_v;
                }


                int
                f_1035_2420_2439(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 2420, 2439);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1035_2475_2491(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 2475, 2491);
                    return return_v;
                }


                bool
                f_1035_2449_2492(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 2449, 2492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1035, 1993, 2505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 1993, 2505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string ExecuteCommandAndGetResultAsString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1035, 2517, 3289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 2594, 2620);

                Exception
                exceptionThrown
                = default(Exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 2634, 2717);

                Collection<PSObject>
                streamResults = f_1035_2671_2716(this, out exceptionThrown)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 2733, 2874) || true) && (exceptionThrown != null || (DynAbs.Tracing.TraceSender.Expression_False(1035, 2737, 2785) || streamResults == null) || (DynAbs.Tracing.TraceSender.Expression_False(1035, 2737, 2813) || f_1035_2789_2808(streamResults) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 2733, 2874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 2847, 2859);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 2733, 2874);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 2966, 3033) || true) && (f_1035_2970_2986(streamResults, 0) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 2966, 3033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 3013, 3033);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 2966, 3033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 3240, 3278);

                return f_1035_3247_3277(f_1035_3260_3276(streamResults, 0));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1035, 2517, 3289);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1035_2671_2716(System.Management.Automation.PowerShellExecutionHelper
                this_param, out System.Exception
                exceptionThrown)
                {
                    var return_v = this_param.ExecuteCurrentPowerShell(out exceptionThrown);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 2671, 2716);
                    return return_v;
                }


                int
                f_1035_2789_2808(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 2789, 2808);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1035_2970_2986(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 2970, 2986);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1035_3260_3276(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 3260, 3276);
                    return return_v;
                }


                string
                f_1035_3247_3277(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = SafeToString((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 3247, 3277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1035, 2517, 3289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 2517, 3289);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<PSObject> ExecuteCommand(string command, bool isScript, out Exception exceptionThrown, Hashtable args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1035, 3301, 4816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 3448, 3524);

                f_1035_3448_3523(command != null, "caller to verify command is not null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 3540, 3563);

                exceptionThrown = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 3673, 3779) || true) && (f_1035_3677_3696())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 3673, 3779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 3730, 3764);

                    return f_1035_3737_3763();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 3673, 3779);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 3795, 3833);

                f_1035_3795_3832(f_1035_3795_3812(), command);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 3849, 3894);

                Command
                cmd = f_1035_3863_3893(command, isScript)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 3908, 4119) || true) && (args != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 3908, 4119);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 3958, 4104);
                        foreach (DictionaryEntry arg in f_1035_3990_3994_I(args))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 3958, 4104);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 4036, 4085);

                            f_1035_4036_4084(f_1035_4036_4050(cmd), (arg.Key), arg.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 3958, 4104);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1035, 1, 147);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1035, 1, 147);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 3908, 4119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 4135, 4171);

                Collection<PSObject>
                results = null
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 4498, 4658) || true) && (f_1035_4502_4511())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 4498, 4658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 4553, 4590);

                        results = f_1035_4563_4589();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 4612, 4639);

                        CancelTabCompletion = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 4498, 4658);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1035, 4687, 4774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 4739, 4759);

                    exceptionThrown = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1035, 4687, 4774);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 4790, 4805);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1035, 3301, 4816);

                int
                f_1035_3448_3523(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 3448, 3523);
                    return 0;
                }


                bool
                f_1035_3677_3696()
                {
                    var return_v = CancelTabCompletion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 3677, 3696);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1035_3737_3763()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 3737, 3763);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1035_3795_3812()
                {
                    var return_v = CurrentPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 3795, 3812);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1035_3795_3832(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 3795, 3832);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1035_3863_3893(string
                command, bool
                isScript)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 3863, 3893);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1035_4036_4050(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 4036, 4050);
                    return return_v;
                }


                int
                f_1035_4036_4084(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, object
                name, object
                value)
                {
                    this_param.Add((string)name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 4036, 4084);
                    return 0;
                }


                System.Collections.Hashtable
                f_1035_3990_3994_I(System.Collections.Hashtable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 3990, 3994);
                    return return_v;
                }


                bool
                f_1035_4502_4511()
                {
                    var return_v = IsStopped;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 4502, 4511);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1035_4563_4589()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 4563, 4589);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1035, 3301, 4816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 3301, 4816);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<PSObject> ExecuteCurrentPowerShell(out Exception exceptionThrown, IEnumerable input = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1035, 4828, 5948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 4964, 4987);

                exceptionThrown = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 5097, 5203) || true) && (f_1035_5101_5120())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 5097, 5203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 5154, 5188);

                    return f_1035_5161_5187();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 5097, 5203);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 5219, 5255);

                Collection<PSObject>
                results = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 5305, 5347);

                    results = f_1035_5315_5346(f_1035_5315_5332(), input);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 5526, 5686) || true) && (f_1035_5530_5539())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 5526, 5686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 5581, 5618);

                        results = f_1035_5591_5617();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 5640, 5667);

                        CancelTabCompletion = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 5526, 5686);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1035, 5715, 5802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 5767, 5787);

                    exceptionThrown = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1035, 5715, 5802);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1035, 5816, 5906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 5856, 5891);

                    f_1035_5856_5890(f_1035_5856_5882(f_1035_5856_5873()));
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1035, 5816, 5906);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 5922, 5937);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1035, 4828, 5948);

                bool
                f_1035_5101_5120()
                {
                    var return_v = CancelTabCompletion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 5101, 5120);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1035_5161_5187()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 5161, 5187);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1035_5315_5332()
                {
                    var return_v = CurrentPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 5315, 5332);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1035_5315_5346(System.Management.Automation.PowerShell
                this_param, System.Collections.IEnumerable
                input)
                {
                    var return_v = this_param.Invoke(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 5315, 5346);
                    return return_v;
                }


                bool
                f_1035_5530_5539()
                {
                    var return_v = IsStopped;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 5530, 5539);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1035_5591_5617()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 5591, 5617);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1035_5856_5873()
                {
                    var return_v = CurrentPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 5856, 5873);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1035_5856_5882(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 5856, 5882);
                    return return_v;
                }


                int
                f_1035_5856_5890(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 5856, 5890);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1035, 4828, 5948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 4828, 5948);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string SafeToString(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1035, 6254, 7243);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 6326, 6410) || true) && (obj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 6326, 6410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 6375, 6395);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 6326, 6410);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 6462, 6493);

                    PSObject
                    pso = obj as PSObject
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 6511, 6525);

                    string
                    result
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 6543, 6973) || true) && (pso != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 6543, 6973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 6600, 6635);

                        object
                        baseObject = f_1035_6620_6634(pso)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 6657, 6848) || true) && (baseObject != null && (DynAbs.Tracing.TraceSender.Expression_True(1035, 6661, 6714) && !(baseObject is PSCustomObject)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 6657, 6848);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 6741, 6772);

                            result = f_1035_6750_6771(baseObject);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 6657, 6848);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 6657, 6848);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 6824, 6848);

                            result = f_1035_6833_6847(pso);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 6657, 6848);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 6543, 6973);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 6543, 6973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 6930, 6954);

                        result = f_1035_6939_6953(obj);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 6543, 6973);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 6993, 7007);

                    return result;
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1035, 7036, 7232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 7197, 7217);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1035, 7036, 7232);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1035, 6254, 7243);

                object
                f_1035_6620_6634(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 6620, 6634);
                    return return_v;
                }


                string?
                f_1035_6750_6771(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 6750, 6771);
                    return return_v;
                }


                string
                f_1035_6833_6847(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 6833, 6847);
                    return return_v;
                }


                string?
                f_1035_6939_6953(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 6939, 6953);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1035, 6254, 7243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 6254, 7243);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void SafeAddToStringList(List<string> list, object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1035, 7536, 7816);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 7632, 7674) || true) && (list == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 7632, 7674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 7667, 7674);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 7632, 7674);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 7688, 7722);

                string
                result = f_1035_7704_7721(obj)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 7736, 7805) || true) && (!f_1035_7741_7769(result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 7736, 7805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 7788, 7805);

                    f_1035_7788_7804(list, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 7736, 7805);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1035, 7536, 7816);

                string
                f_1035_7704_7721(object
                obj)
                {
                    var return_v = SafeToString(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 7704, 7721);
                    return return_v;
                }


                bool
                f_1035_7741_7769(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 7741, 7769);
                    return return_v;
                }


                int
                f_1035_7788_7804(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 7788, 7804);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1035, 7536, 7816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 7536, 7816);
            }
        }

        static PowerShellExecutionHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1035, 297, 7853);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1035, 297, 7853);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 297, 7853);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1035, 297, 7853);

        System.Management.Automation.PSArgumentNullException
        f_1035_695_747(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 695, 747);
            return return_v;
        }


        System.Management.Automation.PowerShell
        f_1035_1443_1460()
        {
            var return_v = CurrentPowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 1443, 1460);
            return return_v;
        }


        System.Management.Automation.PSInvocationStateInfo
        f_1035_1443_1480(System.Management.Automation.PowerShell
        this_param)
        {
            var return_v = this_param.InvocationStateInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 1443, 1480);
            return return_v;
        }


        System.Management.Automation.PSInvocationState
        f_1035_1443_1486(System.Management.Automation.PSInvocationStateInfo
        this_param)
        {
            var return_v = this_param.State;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 1443, 1486);
            return return_v;
        }


        System.Management.Automation.PowerShell
        f_1035_1633_1650()
        {
            var return_v = CurrentPowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 1633, 1650);
            return return_v;
        }


        System.Management.Automation.PSInvocationStateInfo
        f_1035_1633_1670(System.Management.Automation.PowerShell
        this_param)
        {
            var return_v = this_param.InvocationStateInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 1633, 1670);
            return return_v;
        }


        System.Management.Automation.PSInvocationState
        f_1035_1633_1676(System.Management.Automation.PSInvocationStateInfo
        this_param)
        {
            var return_v = this_param.State;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 1633, 1676);
            return return_v;
        }

    }
    internal static class PowerShellExtensionHelpers
    {
        internal static PowerShell AddCommandWithPreferenceSetting(this PowerShellExecutionHelper helper,
                    string command, Type type = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1035, 7926, 8185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 8095, 8174);

                return f_1035_8102_8173(f_1035_8102_8126(helper), command, type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1035, 7926, 8185);

                System.Management.Automation.PowerShell
                f_1035_8102_8126(System.Management.Automation.PowerShellExecutionHelper
                this_param)
                {
                    var return_v = this_param.CurrentPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1035, 8102, 8126);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1035_8102_8173(System.Management.Automation.PowerShell
                powershell, string
                command, System.Type
                type)
                {
                    var return_v = powershell.AddCommandWithPreferenceSetting(command, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 8102, 8173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1035, 7926, 8185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 7926, 8185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PowerShell AddCommandWithPreferenceSetting(this PowerShell powershell, string command, Type type = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1035, 8197, 9243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 8342, 8424);

                f_1035_8342_8423(powershell != null, "the passed-in powershell cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 8438, 8575);

                f_1035_8438_8574(!f_1035_8458_8492(command), "the passed-in command name should not be null or whitespaces");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 8591, 8854) || true) && (type != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 8591, 8854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 8641, 8688);

                    var
                    cmdletInfo = f_1035_8658_8687(command, type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 8708, 8742);

                    f_1035_8708_8741(
                                    powershell, cmdletInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 8591, 8854);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1035, 8591, 8854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 8808, 8839);

                    f_1035_8808_8838(powershell, command);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1035, 8591, 8854);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 8870, 9198);

                f_1035_8870_9197(f_1035_8870_9150(f_1035_8870_9101(f_1035_8870_9024(f_1035_8870_8951(
                            powershell
                , "ErrorAction", ActionPreference.Ignore), "WarningAction", ActionPreference.Ignore), "InformationAction", ActionPreference.Ignore), "Verbose", false), "Debug", false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1035, 9214, 9232);

                return powershell;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1035, 8197, 9243);

                int
                f_1035_8342_8423(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 8342, 8423);
                    return 0;
                }


                bool
                f_1035_8458_8492(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 8458, 8492);
                    return return_v;
                }


                int
                f_1035_8438_8574(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 8438, 8574);
                    return 0;
                }


                System.Management.Automation.CmdletInfo
                f_1035_8658_8687(string
                name, System.Type
                implementingType)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 8658, 8687);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1035_8708_8741(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.CmdletInfo
                commandInfo)
                {
                    var return_v = this_param.AddCommand((System.Management.Automation.CommandInfo)commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 8708, 8741);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1035_8808_8838(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 8808, 8838);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1035_8870_8951(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 8870, 8951);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1035_8870_9024(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 8870, 9024);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1035_8870_9101(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 8870, 9101);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1035_8870_9150(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 8870, 9150);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1035_8870_9197(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1035, 8870, 9197);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1035, 8197, 9243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 8197, 9243);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PowerShellExtensionHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1035, 7861, 9250);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1035, 7861, 9250);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1035, 7861, 9250);
        }

    }
}
