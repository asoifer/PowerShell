// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    public sealed class PSCommand
    {
        private PowerShell _owner;

        private CommandCollection _commands;

        private Command _currentCommand;

        public PSCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1479, 837, 921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 510, 516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 553, 562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 589, 604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 880, 910);

                f_1479_880_909(this, null, false, null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1479, 837, 921);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 837, 921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 837, 921);
            }
        }

        internal PSCommand(PSCommand commandToClone)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1479, 1071, 1478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 510, 516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 553, 562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 589, 604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 1140, 1176);

                _commands = f_1479_1152_1175();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 1190, 1467);
                    foreach (Command command in f_1479_1218_1241_I(f_1479_1218_1241(commandToClone)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 1190, 1467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 1275, 1307);

                        Command
                        clone = f_1479_1291_1306(command)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 1389, 1410);

                        f_1479_1389_1409(                // Attach the cloned Command to this instance.
                                        _commands, clone);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 1428, 1452);

                        _currentCommand = clone;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 1190, 1467);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1479, 1, 278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1479, 1, 278);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1479, 1071, 1478);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 1071, 1478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 1071, 1478);
            }
        }

        internal PSCommand(Command command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1479, 1664, 1856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 510, 516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 553, 562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 589, 604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 1724, 1750);

                _currentCommand = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 1764, 1800);

                _commands = f_1479_1776_1799();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 1814, 1845);

                f_1479_1814_1844(_commands, _currentCommand);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1479, 1664, 1856);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 1664, 1856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 1664, 1856);
            }
        }

        public PSCommand AddCommand(string command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 2882, 3336);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 2950, 3073) || true) && (command == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 2950, 3073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 3003, 3058);

                    throw f_1479_3009_3057("cmdlet");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 2950, 3073);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 3089, 3190) || true) && (_owner != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 3089, 3190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 3141, 3175);

                    f_1479_3141_3174(_owner);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 3089, 3190);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 3206, 3252);

                _currentCommand = f_1479_3224_3251(command, false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 3266, 3297);

                f_1479_3266_3296(_commands, _currentCommand);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 3313, 3325);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 2882, 3336);

                System.Management.Automation.PSArgumentNullException
                f_1479_3009_3057(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 3009, 3057);
                    return return_v;
                }


                int
                f_1479_3141_3174(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 3141, 3174);
                    return 0;
                }


                System.Management.Automation.Runspaces.Command
                f_1479_3224_3251(string
                command, bool
                isScript)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 3224, 3251);
                    return return_v;
                }


                int
                f_1479_3266_3296(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 3266, 3296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 2882, 3336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 2882, 3336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSCommand AddCommand(string cmdlet, bool useLocalScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 4413, 4899);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 4500, 4622) || true) && (cmdlet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 4500, 4622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 4552, 4607);

                    throw f_1479_4558_4606("cmdlet");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 4500, 4622);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 4638, 4739) || true) && (_owner != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 4638, 4739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 4690, 4724);

                    f_1479_4690_4723(_owner);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 4638, 4739);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 4755, 4815);

                _currentCommand = f_1479_4773_4814(cmdlet, false, useLocalScope);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 4829, 4860);

                f_1479_4829_4859(_commands, _currentCommand);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 4876, 4888);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 4413, 4899);

                System.Management.Automation.PSArgumentNullException
                f_1479_4558_4606(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 4558, 4606);
                    return return_v;
                }


                int
                f_1479_4690_4723(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 4690, 4723);
                    return 0;
                }


                System.Management.Automation.Runspaces.Command
                f_1479_4773_4814(string
                command, bool
                isScript, bool
                useLocalScope)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 4773, 4814);
                    return return_v;
                }


                int
                f_1479_4829_4859(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 4829, 4859);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 4413, 4899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 4413, 4899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSCommand AddScript(string script)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 5930, 6379);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 5996, 6118) || true) && (script == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 5996, 6118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 6048, 6103);

                    throw f_1479_6054_6102("script");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 5996, 6118);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 6134, 6235) || true) && (_owner != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 6134, 6235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 6186, 6220);

                    f_1479_6186_6219(_owner);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 6134, 6235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 6251, 6295);

                _currentCommand = f_1479_6269_6294(script, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 6309, 6340);

                f_1479_6309_6339(_commands, _currentCommand);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 6356, 6368);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 5930, 6379);

                System.Management.Automation.PSArgumentNullException
                f_1479_6054_6102(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 6054, 6102);
                    return return_v;
                }


                int
                f_1479_6186_6219(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 6186, 6219);
                    return 0;
                }


                System.Management.Automation.Runspaces.Command
                f_1479_6269_6294(string
                command, bool
                isScript)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 6269, 6294);
                    return return_v;
                }


                int
                f_1479_6309_6339(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 6309, 6339);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 5930, 6379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 5930, 6379);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSCommand AddScript(string script, bool useLocalScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 7542, 8026);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 7628, 7750) || true) && (script == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 7628, 7750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 7680, 7735);

                    throw f_1479_7686_7734("script");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 7628, 7750);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 7766, 7867) || true) && (_owner != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 7766, 7867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 7818, 7852);

                    f_1479_7818_7851(_owner);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 7766, 7867);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 7883, 7942);

                _currentCommand = f_1479_7901_7941(script, true, useLocalScope);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 7956, 7987);

                f_1479_7956_7986(_commands, _currentCommand);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 8003, 8015);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 7542, 8026);

                System.Management.Automation.PSArgumentNullException
                f_1479_7686_7734(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 7686, 7734);
                    return return_v;
                }


                int
                f_1479_7818_7851(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 7818, 7851);
                    return 0;
                }


                System.Management.Automation.Runspaces.Command
                f_1479_7901_7941(string
                command, bool
                isScript, bool
                useLocalScope)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 7901, 7941);
                    return return_v;
                }


                int
                f_1479_7956_7986(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 7956, 7986);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 7542, 8026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 7542, 8026);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSCommand AddCommand(Command command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 8765, 9201);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 8834, 8958) || true) && (command == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 8834, 8958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 8887, 8943);

                    throw f_1479_8893_8942("command");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 8834, 8958);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 8974, 9075) || true) && (_owner != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 8974, 9075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 9026, 9060);

                    f_1479_9026_9059(_owner);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 8974, 9075);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 9091, 9117);

                _currentCommand = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 9131, 9162);

                f_1479_9131_9161(_commands, _currentCommand);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 9178, 9190);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 8765, 9201);

                System.Management.Automation.PSArgumentNullException
                f_1479_8893_8942(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 8893, 8942);
                    return return_v;
                }


                int
                f_1479_9026_9059(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 9026, 9059);
                    return 0;
                }


                int
                f_1479_9131_9161(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 9131, 9161);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 8765, 9201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 8765, 9201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSCommand AddParameter(string parameterName, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 10447, 11024);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 10537, 10801) || true) && (_currentCommand == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 10537, 10801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 10598, 10786);

                    throw f_1479_10604_10785(f_1479_10647_10688(), new object[] { "PSCommand" });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 10537, 10801);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 10817, 10918) || true) && (_owner != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 10817, 10918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 10869, 10903);

                    f_1479_10869_10902(_owner);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 10817, 10918);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 10934, 10987);

                f_1479_10934_10986(f_1479_10934_10960(_currentCommand), parameterName, value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 11001, 11013);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 10447, 11024);

                string
                f_1479_10647_10688()
                {
                    var return_v = PSCommandStrings.ParameterRequiresCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1479, 10647, 10688);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1479_10604_10785(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 10604, 10785);
                    return return_v;
                }


                int
                f_1479_10869_10902(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 10869, 10902);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1479_10934_10960(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1479, 10934, 10960);
                    return return_v;
                }


                int
                f_1479_10934_10986(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, string
                name, object
                value)
                {
                    this_param.Add(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 10934, 10986);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 10447, 11024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 10447, 11024);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSCommand AddParameter(string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 12172, 12734);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 12248, 12512) || true) && (_currentCommand == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 12248, 12512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 12309, 12497);

                    throw f_1479_12315_12496(f_1479_12358_12399(), new object[] { "PSCommand" });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 12248, 12512);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 12528, 12629) || true) && (_owner != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 12528, 12629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 12580, 12614);

                    f_1479_12580_12613(_owner);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 12528, 12629);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 12645, 12697);

                f_1479_12645_12696(f_1479_12645_12671(_currentCommand), parameterName, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 12711, 12723);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 12172, 12734);

                string
                f_1479_12358_12399()
                {
                    var return_v = PSCommandStrings.ParameterRequiresCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1479, 12358, 12399);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1479_12315_12496(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 12315, 12496);
                    return return_v;
                }


                int
                f_1479_12580_12613(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 12580, 12613);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1479_12645_12671(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1479, 12645, 12671);
                    return return_v;
                }


                int
                f_1479_12645_12696(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, string
                name, bool
                value)
                {
                    this_param.Add(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 12645, 12696);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 12172, 12734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 12172, 12734);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSCommand AddArgument(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 13968, 14513);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 14035, 14299) || true) && (_currentCommand == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 14035, 14299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 14096, 14284);

                    throw f_1479_14102_14283(f_1479_14145_14186(), new object[] { "PSCommand" });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 14035, 14299);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 14315, 14416) || true) && (_owner != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 14315, 14416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 14367, 14401);

                    f_1479_14367_14400(_owner);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 14315, 14416);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 14432, 14476);

                f_1479_14432_14475(f_1479_14432_14458(_currentCommand), null, value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 14490, 14502);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 13968, 14513);

                string
                f_1479_14145_14186()
                {
                    var return_v = PSCommandStrings.ParameterRequiresCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1479, 14145, 14186);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1479_14102_14283(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 14102, 14283);
                    return return_v;
                }


                int
                f_1479_14367_14400(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 14367, 14400);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1479_14432_14458(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1479, 14432, 14458);
                    return return_v;
                }


                int
                f_1479_14432_14475(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, string
                name, object
                value)
                {
                    this_param.Add(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 14432, 14475);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 13968, 14513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 13968, 14513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSCommand AddStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 15282, 15531);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 15338, 15423) || true) && (f_1479_15342_15357(_commands) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 15338, 15423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 15396, 15408);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 15338, 15423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 15439, 15494);

                f_1479_15439_15469(_commands, f_1479_15449_15464(_commands) - 1).IsEndOfStatement = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 15508, 15520);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 15282, 15531);

                int
                f_1479_15342_15357(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1479, 15342, 15357);
                    return return_v;
                }


                int
                f_1479_15449_15464(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1479, 15449, 15464);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1479_15439_15469(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1479, 15439, 15469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 15282, 15531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 15282, 15531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CommandCollection Commands
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 15800, 15868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 15836, 15853);

                    return _commands;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 15800, 15868);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 15742, 15879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 15742, 15879);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PowerShell Owner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 16098, 16163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 16134, 16148);

                    return _owner;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 16098, 16163);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 16048, 16256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 16048, 16256);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 16179, 16245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 16215, 16230);

                    _owner = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 16179, 16245);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 16048, 16256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 16048, 16256);
                }
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 16351, 16461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 16395, 16413);

                f_1479_16395_16412(_commands);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 16427, 16450);

                _currentCommand = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 16351, 16461);

                int
                f_1479_16395_16412(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 16395, 16412);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 16351, 16461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 16351, 16461);
            }
        }

        public PSCommand Clone()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 16682, 16769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 16731, 16758);

                return f_1479_16738_16757(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 16682, 16769);

                System.Management.Automation.PSCommand
                f_1479_16738_16757(System.Management.Automation.PSCommand
                commandToClone)
                {
                    var return_v = new System.Management.Automation.PSCommand(commandToClone);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 16738, 16757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 16682, 16769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 16682, 16769);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Initialize(string command, bool isScript, bool? useLocalScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1479, 17549, 17893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 17649, 17685);

                _commands = f_1479_17661_17684();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 17701, 17882) || true) && (command != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1479, 17701, 17882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 17754, 17818);

                    _currentCommand = f_1479_17772_17817(command, isScript, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1479, 17836, 17867);

                    f_1479_17836_17866(_commands, _currentCommand);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1479, 17701, 17882);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1479, 17549, 17893);

                System.Management.Automation.Runspaces.CommandCollection
                f_1479_17661_17684()
                {
                    var return_v = new System.Management.Automation.Runspaces.CommandCollection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 17661, 17684);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1479_17772_17817(string
                command, bool
                isScript, bool?
                useLocalScope)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 17772, 17817);
                    return return_v;
                }


                int
                f_1479_17836_17866(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 17836, 17866);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1479, 17549, 17893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 17549, 17893);
            }
        }

        static PSCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1479, 411, 17922);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1479, 411, 17922);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1479, 411, 17922);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1479, 411, 17922);

        int
        f_1479_880_909(System.Management.Automation.PSCommand
        this_param, string
        command, bool
        isScript, bool?
        useLocalScope)
        {
            this_param.Initialize(command, isScript, useLocalScope);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 880, 909);
            return 0;
        }


        System.Management.Automation.Runspaces.CommandCollection
        f_1479_1152_1175()
        {
            var return_v = new System.Management.Automation.Runspaces.CommandCollection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 1152, 1175);
            return return_v;
        }


        System.Management.Automation.Runspaces.CommandCollection
        f_1479_1218_1241(System.Management.Automation.PSCommand
        this_param)
        {
            var return_v = this_param.Commands;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1479, 1218, 1241);
            return return_v;
        }


        System.Management.Automation.Runspaces.Command
        f_1479_1291_1306(System.Management.Automation.Runspaces.Command
        this_param)
        {
            var return_v = this_param.Clone();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 1291, 1306);
            return return_v;
        }


        int
        f_1479_1389_1409(System.Management.Automation.Runspaces.CommandCollection
        this_param, System.Management.Automation.Runspaces.Command
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 1389, 1409);
            return 0;
        }


        System.Management.Automation.Runspaces.CommandCollection
        f_1479_1218_1241_I(System.Management.Automation.Runspaces.CommandCollection
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 1218, 1241);
            return return_v;
        }


        System.Management.Automation.Runspaces.CommandCollection
        f_1479_1776_1799()
        {
            var return_v = new System.Management.Automation.Runspaces.CommandCollection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 1776, 1799);
            return return_v;
        }


        int
        f_1479_1814_1844(System.Management.Automation.Runspaces.CommandCollection
        this_param, System.Management.Automation.Runspaces.Command
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1479, 1814, 1844);
            return 0;
        }

    }
}
