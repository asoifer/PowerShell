// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;

namespace System.Management.Automation.Internal
{
    public sealed class CommonParameters
    {
        internal CommonParameters(MshCommandRuntime commandRuntime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1254, 923, 1205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 8403, 8418);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 1007, 1145) || true) && (commandRuntime == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1254, 1007, 1145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 1067, 1130);

                    throw f_1254_1073_1129("commandRuntime");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1254, 1007, 1145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 1161, 1194);

                _commandRuntime = commandRuntime;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1254, 923, 1205);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 923, 1205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 923, 1205);
            }
        }

        [Parameter]
        [Alias("vb")]
        public SwitchParameter Verbose
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 1658, 1697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 1664, 1695);

                    return f_1254_1671_1694(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 1658, 1697);

                    bool
                    f_1254_1671_1694(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.Verbose;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1254, 1671, 1694);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 1559, 1764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 1559, 1764);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 1713, 1753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 1719, 1751);

                    _commandRuntime.Verbose = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 1713, 1753);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 1559, 1764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 1559, 1764);
                }
            }
        }

        [Parameter]
        [Alias("db")]
        public SwitchParameter Debug
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 2262, 2299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 2268, 2297);

                    return f_1254_2275_2296(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 2262, 2299);

                    bool
                    f_1254_2275_2296(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.Debug;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1254, 2275, 2296);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 2165, 2364);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 2165, 2364);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 2315, 2353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 2321, 2351);

                    _commandRuntime.Debug = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 2315, 2353);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 2165, 2364);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 2165, 2364);
                }
            }
        }

        [Parameter]
        [Alias("ea")]
        public ActionPreference ErrorAction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 2734, 2777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 2740, 2775);

                    return f_1254_2747_2774(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 2734, 2777);

                    System.Management.Automation.ActionPreference
                    f_1254_2747_2774(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.ErrorAction;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1254, 2747, 2774);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 2630, 2848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 2630, 2848);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 2793, 2837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 2799, 2835);

                    _commandRuntime.ErrorAction = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 2793, 2837);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 2630, 2848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 2630, 2848);
                }
            }
        }

        [Parameter]
        [Alias("wa")]
        public ActionPreference WarningAction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 3236, 3285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 3242, 3283);

                    return f_1254_3249_3282(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 3236, 3285);

                    System.Management.Automation.ActionPreference
                    f_1254_3249_3282(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.WarningPreference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1254, 3249, 3282);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 3130, 3362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 3130, 3362);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 3301, 3351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 3307, 3349);

                    _commandRuntime.WarningPreference = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 3301, 3351);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 3130, 3362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 3130, 3362);
                }
            }
        }

        [Parameter]
        [Alias("infa")]
        public ActionPreference InformationAction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 4147, 4200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 4153, 4198);

                    return f_1254_4160_4197(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 4147, 4200);

                    System.Management.Automation.ActionPreference
                    f_1254_4160_4197(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.InformationPreference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1254, 4160, 4197);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 4035, 4281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 4035, 4281);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 4216, 4270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 4222, 4268);

                    _commandRuntime.InformationPreference = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 4216, 4270);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 4035, 4281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 4035, 4281);
                }
            }
        }

        [Parameter]
        [Alias("ev")]
        [ValidateVariableName]
        public string ErrorVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 4947, 4992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 4953, 4990);

                    return f_1254_4960_4989(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 4947, 4992);

                    string
                    f_1254_4960_4989(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.ErrorVariable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1254, 4960, 4989);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 4819, 5065);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 4819, 5065);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 5008, 5054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 5014, 5052);

                    _commandRuntime.ErrorVariable = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 5008, 5054);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 4819, 5065);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 4819, 5065);
                }
            }
        }

        [Parameter]
        [Alias("wv")]
        [ValidateVariableName]
        public string WarningVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 5555, 5602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 5561, 5600);

                    return f_1254_5568_5599(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 5555, 5602);

                    string
                    f_1254_5568_5599(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.WarningVariable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1254, 5568, 5599);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 5425, 5677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 5425, 5677);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 5618, 5666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 5624, 5664);

                    _commandRuntime.WarningVariable = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 5618, 5666);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 5425, 5677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 5425, 5677);
                }
            }
        }

        [Parameter]
        [Alias("iv")]
        [ValidateVariableName]
        public string InformationVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 6187, 6238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 6193, 6236);

                    return f_1254_6200_6235(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 6187, 6238);

                    string
                    f_1254_6200_6235(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.InformationVariable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1254, 6200, 6235);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 6053, 6317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 6053, 6317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 6254, 6306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 6260, 6304);

                    _commandRuntime.InformationVariable = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 6254, 6306);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 6053, 6317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 6053, 6317);
                }
            }
        }

        [Parameter]
        [Alias("ov")]
        [ValidateVariableName]
        public string OutVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 6967, 7010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 6973, 7008);

                    return f_1254_6980_7007(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 6967, 7010);

                    string
                    f_1254_6980_7007(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.OutVariable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1254, 6980, 7007);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 6841, 7081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 6841, 7081);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 7026, 7070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 7032, 7068);

                    _commandRuntime.OutVariable = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 7026, 7070);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 6841, 7081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 6841, 7081);
                }
            }
        }

        [Parameter]
        [ValidateRangeAttribute(0, Int32.MaxValue)]
        [Alias("ob")]
        public int OutBuffer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 7503, 7544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 7509, 7542);

                    return f_1254_7516_7541(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 7503, 7544);

                    int
                    f_1254_7516_7541(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.OutBuffer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1254, 7516, 7541);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 7361, 7613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 7361, 7613);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 7560, 7602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 7566, 7600);

                    _commandRuntime.OutBuffer = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 7560, 7602);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 7361, 7613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 7361, 7613);
                }
            }
        }

        [Parameter]
        [Alias("pv")]
        [ValidateVariableName]
        public string PipelineVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 8208, 8256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 8214, 8254);

                    return f_1254_8221_8253(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 8208, 8256);

                    string
                    f_1254_8221_8253(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.PipelineVariable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1254, 8221, 8253);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 8077, 8332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 8077, 8332);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 8272, 8321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 8278, 8319);

                    _commandRuntime.PipelineVariable = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 8272, 8321);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 8077, 8332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 8077, 8332);
                }
            }
        }

        private MshCommandRuntime _commandRuntime;
        internal class ValidateVariableName : ValidateArgumentsAttribute
        {
            protected override void Validate(object arguments, EngineIntrinsics engineIntrinsics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1254, 8520, 9308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 8638, 8675);

                    string
                    varName = arguments as string
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 8693, 9293) || true) && (varName != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1254, 8693, 9293);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 8754, 8885) || true) && (f_1254_8758_8781(varName, '+'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1254, 8754, 8885);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 8831, 8862);

                            varName = f_1254_8841_8861(varName, 1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1254, 8754, 8885);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 8909, 8955);

                        VariablePath
                        silp = f_1254_8929_8954(varName)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 8977, 9274) || true) && (f_1254_8981_8997_M(!silp.IsVariable))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1254, 8977, 9274);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1254, 9047, 9251);

                            throw f_1254_9053_9250("ArgumentNotValidVariableName", null, f_1254_9211_9240(), varName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1254, 8977, 9274);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1254, 8693, 9293);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1254, 8520, 9308);

                    bool
                    f_1254_8758_8781(string
                    this_param, char
                    value)
                    {
                        var return_v = this_param.StartsWith(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1254, 8758, 8781);
                        return return_v;
                    }


                    string
                    f_1254_8841_8861(string
                    this_param, int
                    startIndex)
                    {
                        var return_v = this_param.Substring(startIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1254, 8841, 8861);
                        return return_v;
                    }


                    System.Management.Automation.VariablePath
                    f_1254_8929_8954(string
                    path)
                    {
                        var return_v = new System.Management.Automation.VariablePath(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1254, 8929, 8954);
                        return return_v;
                    }


                    bool
                    f_1254_8981_8997_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1254, 8981, 8997);
                        return return_v;
                    }


                    string
                    f_1254_9211_9240()
                    {
                        var return_v = Metadata.ValidateVariableName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1254, 9211, 9240);
                        return return_v;
                    }


                    System.Management.Automation.ValidationMetadataException
                    f_1254_9053_9250(string
                    errorId, System.Exception
                    innerException, string
                    resourceStr, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1254, 9053, 9250);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1254, 8520, 9308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 8520, 9308);
                }
            }

            public ValidateVariableName()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1254, 8431, 9319);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1254, 8431, 9319);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 8431, 9319);
            }


            static ValidateVariableName()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1254, 8431, 9319);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1254, 8431, 9319);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 8431, 9319);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1254, 8431, 9319);
        }

        static CommonParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1254, 382, 9326);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1254, 382, 9326);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1254, 382, 9326);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1254, 382, 9326);

        System.Management.Automation.PSArgumentNullException
        f_1254_1073_1129(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1254, 1073, 1129);
            return return_v;
        }

    }
}

