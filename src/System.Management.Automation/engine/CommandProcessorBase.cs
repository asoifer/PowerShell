// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.ObjectModel;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal abstract class CommandProcessorBase : IDisposable
    {
        internal CommandProcessorBase()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1252, 702, 755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 2375, 2383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 2518, 2533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 2908, 2931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 3105, 3151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 4063, 4086);
                this._fromScriptFile = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 4435, 4500);
                this.RedirectShellErrorOutputPipe = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 5897, 5911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 6470, 6484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 9121, 9129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 9378, 9438);
                this.PipelineActivityId = Guid.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 12553, 12616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 12760, 12833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 14838, 14852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 14892, 14920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 15216, 15270);
                this.arguments = f_1252_15228_15270();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 28268, 28291);
                this._firstCallToRead = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 39238, 39247);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1252, 702, 755);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 702, 755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 702, 755);
            }
        }

        internal CommandProcessorBase(CommandInfo commandInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1252, 1013, 2282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 2375, 2383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 2518, 2533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 2908, 2931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 3105, 3151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 4063, 4086);
                this._fromScriptFile = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 4435, 4500);
                this.RedirectShellErrorOutputPipe = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 5897, 5911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 6470, 6484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 9121, 9129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 9378, 9438);
                this.PipelineActivityId = Guid.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 12553, 12616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 12760, 12833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 14838, 14852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 14892, 14920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 15216, 15270);
                this.arguments = f_1252_15228_15270();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 28268, 28291);
                this._firstCallToRead = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 39238, 39247);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 1092, 1224) || true) && (commandInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 1092, 1224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 1149, 1209);

                    throw f_1252_1155_1208("commandInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 1092, 1224);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 1240, 2229) || true) && (commandInfo is IScriptCommandInfo scriptCommand)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 1240, 2229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 1325, 1410);

                    ExperimentalAttribute
                    expAttribute = f_1252_1362_1409(f_1252_1362_1387(scriptCommand))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 1428, 2214) || true) && (expAttribute != null && (DynAbs.Tracing.TraceSender.Expression_True(1252, 1432, 1475) && f_1252_1456_1475(expAttribute)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 1428, 2214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 1517, 1746);

                        string
                        errorTemplate = (DynAbs.Tracing.TraceSender.Conditional_F1(1252, 1540, 1594) || ((f_1252_1540_1569(expAttribute) == ExperimentAction.Hide
                        && DynAbs.Tracing.TraceSender.Conditional_F2(1252, 1622, 1669)) || DynAbs.Tracing.TraceSender.Conditional_F3(1252, 1697, 1745))) ? f_1252_1622_1669() : f_1252_1697_1745()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 1768, 1848);

                        string
                        errorMsg = f_1252_1786_1847(errorTemplate, f_1252_1819_1846(expAttribute))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 1870, 2124);

                        ErrorRecord
                        errorRecord = f_1252_1896_2123(f_1252_1938_1977(errorMsg), "ScriptCommandDisabled", ErrorCategory.InvalidOperation, commandInfo)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 2146, 2195);

                        throw f_1252_2152_2194(errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 1428, 2214);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 1240, 2229);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 2245, 2271);

                CommandInfo = commandInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1252, 1013, 2282);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 1013, 2282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 1013, 2282);
            }
        }

        private InternalCommand _command;

        internal bool RanBeginAlready;

        internal bool AddedToPipelineAlready
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 2776, 2815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 2782, 2813);

                    return _addedToPipelineAlready;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 2776, 2815);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 2715, 2882);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 2715, 2882);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 2831, 2871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 2837, 2869);

                    _addedToPipelineAlready = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 2831, 2871);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 2715, 2882);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 2715, 2882);
                }
            }
        }

        internal bool _addedToPipelineAlready;

        internal CommandInfo CommandInfo { get; set; }

        public bool FromScriptFile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 4003, 4034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 4009, 4032);

                    return _fromScriptFile;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 4003, 4034);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 3974, 4036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 3974, 4036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected bool _fromScriptFile;

        internal bool RedirectShellErrorOutputPipe { get; set; }

        internal InternalCommand Command
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 4662, 4686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 4668, 4684);

                    return _command;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 4662, 4686);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 4605, 5366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 4605, 5366);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 4702, 5355);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 4800, 5303) || true) && (value != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 4800, 5303);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 4859, 4902);

                        value.commandRuntime = this.commandRuntime;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 4924, 5012) || true) && (_command != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 4924, 5012);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 4971, 5012);

                            value.CommandInfo = f_1252_4991_5011(_command);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 4924, 5012);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 5187, 5284) || true) && (f_1252_5191_5204(value) == null && (DynAbs.Tracing.TraceSender.Expression_True(1252, 5191, 5232) && _context != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 5187, 5284);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 5259, 5284);

                            value.Context = _context;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 5187, 5284);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 4800, 5303);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 5323, 5340);

                    _command = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 4702, 5355);

                    System.Management.Automation.CommandInfo
                    f_1252_4991_5011(System.Management.Automation.Internal.InternalCommand
                    this_param)
                    {
                        var return_v = this_param.CommandInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 4991, 5011);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1252_5191_5204(System.Management.Automation.Internal.InternalCommand
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 5191, 5204);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 4605, 5366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 4605, 5366);
                }
            }
        }

        internal virtual ObsoleteAttribute ObsoleteAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 5565, 5585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 5571, 5583);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 5565, 5585);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 5488, 5596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 5488, 5596);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private const string
        FQIDCommandObsolete = "CommandObsolete"
        ;

        protected MshCommandRuntime commandRuntime;

        internal MshCommandRuntime CommandRuntime
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 5988, 6018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 5994, 6016);

                    return commandRuntime;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 5988, 6018);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 5922, 6076);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 5922, 6076);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 6034, 6065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 6040, 6063);

                    commandRuntime = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 6034, 6065);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 5922, 6076);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 5922, 6076);
                }
            }
        }

        internal bool UseLocalScope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 6355, 6385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 6361, 6383);

                    return _useLocalScope;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 6355, 6385);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 6303, 6443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 6303, 6443);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 6401, 6432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 6407, 6430);

                    _useLocalScope = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 6401, 6432);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 6303, 6443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 6303, 6443);
                }
            }
        }

        protected bool _useLocalScope;

        protected static void ValidateCompatibleLanguageMode(
                    ScriptBlock scriptBlock,
                    PSLanguageMode languageMode,
                    InvocationInfo invocationInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1252, 6946, 8980);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 7680, 8969) || true) && ((f_1252_7685_7718(f_1252_7685_7709(scriptBlock))) && (DynAbs.Tracing.TraceSender.Expression_True(1252, 7684, 7782) && (f_1252_7741_7765(scriptBlock) != languageMode)) && (DynAbs.Tracing.TraceSender.Expression_True(1252, 7684, 7929) && ((languageMode == PSLanguageMode.RestrictedLanguage) || (DynAbs.Tracing.TraceSender.Expression_False(1252, 7804, 7928) || (languageMode == PSLanguageMode.ConstrainedLanguage)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 7680, 8969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 8154, 8185);

                    bool
                    isSafeToDotSource = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 8247, 8275);

                        f_1252_8247_8274(scriptBlock);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 8297, 8322);

                        isSafeToDotSource = true;
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1252, 8359, 8414);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1252, 8359, 8414);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 8434, 8954) || true) && (!isSafeToDotSource)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 8434, 8954);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 8498, 8796);

                        ErrorRecord
                        errorRecord = f_1252_8524_8795(f_1252_8562_8656(f_1252_8614_8655()), "DotSourceNotSupported", ErrorCategory.InvalidOperation, null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 8818, 8864);

                        f_1252_8818_8863(errorRecord, invocationInfo);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 8886, 8935);

                        throw f_1252_8892_8934(errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 8434, 8954);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 7680, 8969);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1252, 6946, 8980);

                System.Management.Automation.PSLanguageMode?
                f_1252_7685_7709(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 7685, 7709);
                    return return_v;
                }


                bool
                f_1252_7685_7718(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 7685, 7718);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1252_7741_7765(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 7741, 7765);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1252_8247_8274(System.Management.Automation.ScriptBlock
                this_param, params object[]
                args)
                {
                    var return_v = this_param.GetPowerShell(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 8247, 8274);
                    return return_v;
                }


                string
                f_1252_8614_8655()
                {
                    var return_v = DiscoveryExceptions.DotSourceNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 8614, 8655);
                    return return_v;
                }


                System.NotSupportedException
                f_1252_8562_8656(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 8562, 8656);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1252_8524_8795(System.NotSupportedException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 8524, 8795);
                    return return_v;
                }


                int
                f_1252_8818_8863(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 8818, 8863);
                    return 0;
                }


                System.Management.Automation.CmdletInvocationException
                f_1252_8892_8934(System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    var return_v = new System.Management.Automation.CmdletInvocationException(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 8892, 8934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 6946, 8980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 6946, 8980);
            }
        }

        protected ExecutionContext _context;

        internal ExecutionContext Context
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 9198, 9222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 9204, 9220);

                    return _context;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 9198, 9222);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 9140, 9274);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 9140, 9274);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 9238, 9263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 9244, 9261);

                    _context = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 9238, 9263);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 9140, 9274);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 9140, 9274);
                }
            }
        }

        internal Guid PipelineActivityId { get; set; }

        internal virtual bool IsHelpRequested(out string helpTarget, out HelpCategory helpCategory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 10000, 10392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 10289, 10307);

                helpTarget = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 10321, 10354);

                helpCategory = HelpCategory.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 10368, 10381);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 10000, 10392);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 10000, 10392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 10000, 10392);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CommandProcessorBase CreateGetHelpCommandProcessor(
                    ExecutionContext context,
                    string helpTarget,
                    HelpCategory helpCategory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1252, 10800, 11982);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 11003, 11127) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 11003, 11127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 11056, 11112);

                    throw f_1252_11062_11111("context");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 11003, 11127);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 11143, 11287) || true) && (f_1252_11147_11179(helpTarget))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 11143, 11287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 11213, 11272);

                    throw f_1252_11219_11271("helpTarget");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 11143, 11287);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 11303, 11388);

                CommandProcessorBase
                helpCommandProcessor = f_1252_11347_11387(context, "get-help", false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 11402, 11597);

                var
                cpi = f_1252_11412_11596(null, "Name", "-Name:", null, helpTarget, false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 11611, 11650);

                f_1252_11611_11649(helpCommandProcessor, cpi);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 11664, 11876);

                cpi = f_1252_11670_11875(null, "Category", "-Category:", null, f_1252_11827_11850(helpCategory), false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 11890, 11929);

                f_1252_11890_11928(helpCommandProcessor, cpi);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 11943, 11971);

                return helpCommandProcessor;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1252, 10800, 11982);

                System.Management.Automation.PSArgumentNullException
                f_1252_11062_11111(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 11062, 11111);
                    return return_v;
                }


                bool
                f_1252_11147_11179(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 11147, 11179);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1252_11219_11271(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 11219, 11271);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1252_11347_11387(System.Management.Automation.ExecutionContext
                this_param, string
                command, bool
                dotSource)
                {
                    var return_v = this_param.CreateCommand(command, dotSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 11347, 11387);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1252_11412_11596(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, string
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, (object)value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 11412, 11596);
                    return return_v;
                }


                int
                f_1252_11611_11649(System.Management.Automation.CommandProcessorBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter)
                {
                    this_param.AddParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 11611, 11649);
                    return 0;
                }


                string
                f_1252_11827_11850(System.Management.Automation.HelpCategory
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 11827, 11850);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1252_11670_11875(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, string
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, (object)value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 11670, 11875);
                    return return_v;
                }


                int
                f_1252_11890_11928(System.Management.Automation.CommandProcessorBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter)
                {
                    this_param.AddParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 11890, 11928);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 10800, 11982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 10800, 11982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsPipelineInputExpected()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 12211, 12332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 12275, 12321);

                return f_1252_12282_12320(commandRuntime);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 12211, 12332);

                bool
                f_1252_12282_12320(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsPipelineInputExpected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 12282, 12320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 12211, 12332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 12211, 12332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SessionStateInternal CommandSessionState { get; set; }

        protected internal SessionStateScope CommandScope { get; protected set; }

        protected virtual void OnSetCurrentScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 12845, 12909);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 12845, 12909);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 12845, 12909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 12845, 12909);
            }
        }

        protected virtual void OnRestorePreviousScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 12921, 12990);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 12921, 12990);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 12921, 12990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 12921, 12990);
            }
        }

        internal void SetCurrentScopeToExecutionScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 13231, 14074);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 13519, 13648) || true) && (f_1252_13523_13542() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 13519, 13648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 13584, 13633);

                    CommandSessionState = f_1252_13606_13632(f_1252_13606_13613());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 13519, 13648);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 13708, 13758);

                _previousScope = f_1252_13725_13757(f_1252_13725_13744());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 13772, 13830);

                _previousCommandSessionState = f_1252_13803_13829(f_1252_13803_13810());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 13844, 13893);

                f_1252_13844_13851().EngineSessionState = f_1252_13873_13892();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 13979, 14027);

                f_1252_13979_13998().CurrentScope = f_1252_14014_14026();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 14043, 14063);

                f_1252_14043_14062(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 13231, 14074);

                System.Management.Automation.SessionStateInternal
                f_1252_13523_13542()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 13523, 13542);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1252_13606_13613()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 13606, 13613);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1252_13606_13632(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 13606, 13632);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1252_13725_13744()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 13725, 13744);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1252_13725_13757(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 13725, 13757);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1252_13803_13810()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 13803, 13810);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1252_13803_13829(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 13803, 13829);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1252_13844_13851()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 13844, 13851);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1252_13873_13892()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 13873, 13892);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1252_13979_13998()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 13979, 13998);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1252_14014_14026()
                {
                    var return_v = CommandScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 14014, 14026);
                    return return_v;
                }


                int
                f_1252_14043_14062(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.OnSetCurrentScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 14043, 14062);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 13231, 14074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 13231, 14074);
            }
        }

        internal void RestorePreviousScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 14279, 14800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 14340, 14365);

                f_1252_14340_14364(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 14381, 14439);

                f_1252_14381_14388().EngineSessionState = _previousCommandSessionState;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 14455, 14789) || true) && (_previousScope != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 14455, 14789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 14724, 14774);

                    f_1252_14724_14743().CurrentScope = _previousScope;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 14455, 14789);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 14279, 14800);

                int
                f_1252_14340_14364(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.OnRestorePreviousScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 14340, 14364);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1252_14381_14388()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 14381, 14388);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1252_14724_14743()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 14724, 14743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 14279, 14800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 14279, 14800);
            }
        }

        private SessionStateScope _previousScope;

        private SessionStateInternal _previousCommandSessionState;

        internal Collection<CommandParameterInternal> arguments;

        internal void AddParameter(CommandParameterInternal parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 15494, 15708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 15581, 15658);

                f_1252_15581_15657(parameter != null, "Caller to verify parameter argument");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 15672, 15697);

                f_1252_15672_15696(arguments, parameter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 15494, 15708);

                int
                f_1252_15581_15657(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 15581, 15657);
                    return 0;
                }


                int
                f_1252_15672_15696(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 15672, 15696);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 15494, 15708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 15494, 15708);
            }
        }

        internal abstract void Prepare(IDictionary psDefaultParameterValues);

        private void HandleObsoleteCommand(ObsoleteAttribute obsoleteAttr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 16117, 17068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 16208, 16502);

                string
                commandName =
                (DynAbs.Tracing.TraceSender.Conditional_F1(1252, 16246, 16284) || ((f_1252_16246_16284(f_1252_16267_16283(f_1252_16267_16278())) && DynAbs.Tracing.TraceSender.Conditional_F2(1252, 16308, 16322)) || DynAbs.Tracing.TraceSender.Conditional_F3(1252, 16346, 16501))) ? "script block"
                : f_1252_16346_16501(f_1252_16360_16409(), f_1252_16448_16482(), f_1252_16484_16500(f_1252_16484_16495()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 16518, 16740);

                string
                warningMsg = f_1252_16538_16739(f_1252_16570_16619(), f_1252_16638_16686(), commandName, f_1252_16718_16738(obsoleteAttr))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 16866, 17057);
                using (f_1252_16873_16923(f_1252_16873_16892(this), false))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 16957, 17042);

                    f_1252_16957_17041(f_1252_16957_16976(this), f_1252_16990_17040(FQIDCommandObsolete, warningMsg));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1252, 16866, 17057);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 16117, 17068);

                System.Management.Automation.CommandInfo
                f_1252_16267_16278()
                {
                    var return_v = CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 16267, 16278);
                    return return_v;
                }


                string
                f_1252_16267_16283(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 16267, 16283);
                    return return_v;
                }


                bool
                f_1252_16246_16284(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 16246, 16284);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1252_16360_16409()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 16360, 16409);
                    return return_v;
                }


                string
                f_1252_16448_16482()
                {
                    var return_v = CommandBaseStrings.ObsoleteCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 16448, 16482);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1252_16484_16495()
                {
                    var return_v = CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 16484, 16495);
                    return return_v;
                }


                string
                f_1252_16484_16500(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 16484, 16500);
                    return return_v;
                }


                string
                f_1252_16346_16501(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 16346, 16501);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1252_16570_16619()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 16570, 16619);
                    return return_v;
                }


                string
                f_1252_16638_16686()
                {
                    var return_v = CommandBaseStrings.UseOfDeprecatedCommandWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 16638, 16686);
                    return return_v;
                }


                string
                f_1252_16718_16738(System.ObsoleteAttribute
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 16718, 16738);
                    return return_v;
                }


                string
                f_1252_16538_16739(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 16538, 16739);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1252_16873_16892(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 16873, 16892);
                    return return_v;
                }


                System.IDisposable
                f_1252_16873_16923(System.Management.Automation.MshCommandRuntime
                this_param, bool
                permittedToWriteToPipeline)
                {
                    var return_v = this_param.AllowThisCommandToWrite(permittedToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 16873, 16923);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1252_16957_16976(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 16957, 16976);
                    return return_v;
                }


                System.Management.Automation.WarningRecord
                f_1252_16990_17040(string
                fullyQualifiedWarningId, string
                message)
                {
                    var return_v = new System.Management.Automation.WarningRecord(fullyQualifiedWarningId, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 16990, 17040);
                    return return_v;
                }


                int
                f_1252_16957_17041(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.WarningRecord
                record)
                {
                    this_param.WriteWarning(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 16957, 17041);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 16117, 17068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 16117, 17068);
            }
        }

        internal void DoPrepare(IDictionary psDefaultParameterValues)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 17280, 18621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 17366, 17449);

                CommandProcessorBase
                oldCurrentCommandProcessor = f_1252_17416_17448(_context)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 17499, 17538);

                    f_1252_17499_17506().CurrentCommandProcessor = this;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 17556, 17590);

                    f_1252_17556_17589(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 17608, 17642);

                    f_1252_17608_17641(this, psDefaultParameterValues);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 17774, 18001) || true) && (f_1252_17778_17795() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 17774, 18001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 17941, 17982);

                        f_1252_17941_17981(this, f_1252_17963_17980());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 17774, 18001);
                    }
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1252, 18030, 18439);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 18080, 18398) || true) && (_useLocalScope)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 18080, 18398);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 18333, 18379);

                        f_1252_18333_18378(f_1252_18333_18352(), f_1252_18365_18377());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 18080, 18398);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 18418, 18424);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1252, 18030, 18439);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1252, 18453, 18610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 18493, 18554);

                    f_1252_18493_18500().CurrentCommandProcessor = oldCurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 18572, 18595);

                    f_1252_18572_18594(this);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1252, 18453, 18610);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 17280, 18621);

                System.Management.Automation.CommandProcessorBase
                f_1252_17416_17448(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 17416, 17448);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1252_17499_17506()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 17499, 17506);
                    return return_v;
                }


                int
                f_1252_17556_17589(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.SetCurrentScopeToExecutionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 17556, 17589);
                    return 0;
                }


                int
                f_1252_17608_17641(System.Management.Automation.CommandProcessorBase
                this_param, System.Collections.IDictionary
                psDefaultParameterValues)
                {
                    this_param.Prepare(psDefaultParameterValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 17608, 17641);
                    return 0;
                }


                System.ObsoleteAttribute
                f_1252_17778_17795()
                {
                    var return_v = ObsoleteAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 17778, 17795);
                    return return_v;
                }


                System.ObsoleteAttribute
                f_1252_17963_17980()
                {
                    var return_v = ObsoleteAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 17963, 17980);
                    return return_v;
                }


                int
                f_1252_17941_17981(System.Management.Automation.CommandProcessorBase
                this_param, System.ObsoleteAttribute
                obsoleteAttr)
                {
                    this_param.HandleObsoleteCommand(obsoleteAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 17941, 17981);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1252_18333_18352()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 18333, 18352);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1252_18365_18377()
                {
                    var return_v = CommandScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 18365, 18377);
                    return return_v;
                }


                int
                f_1252_18333_18378(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.SessionStateScope
                scope)
                {
                    this_param.RemoveScope(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 18333, 18378);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1252_18493_18500()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 18493, 18500);
                    return return_v;
                }


                int
                f_1252_18572_18594(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.RestorePreviousScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 18572, 18594);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 17280, 18621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 17280, 18621);
            }
        }

        internal virtual void DoBegin()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 18968, 22521);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 19519, 22510) || true) && (!RanBeginAlready)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 19519, 22510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 19573, 19596);

                    RanBeginAlready = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 19614, 19678);

                    Pipe
                    oldErrorOutputPipe = f_1252_19640_19677(_context)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 19696, 19779);

                    CommandProcessorBase
                    oldCurrentCommandProcessor = f_1252_19746_19778(_context)
                    ;
                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 20982, 21217) || true) && (f_1252_20986_21019(this) || (DynAbs.Tracing.TraceSender.Expression_False(1252, 20986, 21068) || f_1252_21023_21060(_context) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 20982, 21217);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 21118, 21194);

                            _context.ShellFunctionErrorOutputPipe = f_1252_21158_21193(this.commandRuntime);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 20982, 21217);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 21241, 21281);

                        _context.CurrentCommandProcessor = this;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 21303, 21962);
                        using (f_1252_21310_21354(commandRuntime, true))
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 21404, 21939);
                            using (f_1252_21411_21512(ParameterBinderBase.bindingTracer, "CALLING BeginProcessing"))
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 21570, 21604);

                                f_1252_21570_21603(this);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 21636, 21852) || true) && (f_1252_21640_21647()._debuggingMode > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1252, 21640, 21698) && !(f_1252_21672_21679() is PSScriptCmdlet)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 21636, 21852);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 21764, 21821);

                                    f_1252_21764_21820(f_1252_21764_21780(f_1252_21764_21771()), f_1252_21794_21819(f_1252_21794_21806(this)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 21636, 21852);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 21884, 21912);

                                f_1252_21884_21911(f_1252_21884_21891());
                                DynAbs.Tracing.TraceSender.TraceExitUsing(1252, 21404, 21939);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1252, 21303, 21962);
                        }
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1252, 21999, 22222);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 22168, 22203);

                        throw f_1252_22174_22202(this, e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1252, 21999, 22222);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1252, 22240, 22495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 22288, 22347);

                        _context.ShellFunctionErrorOutputPipe = oldErrorOutputPipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 22369, 22431);

                        _context.CurrentCommandProcessor = oldCurrentCommandProcessor;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 22453, 22476);

                        f_1252_22453_22475(this);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1252, 22240, 22495);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 19519, 22510);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 18968, 22521);

                System.Management.Automation.Internal.Pipe
                f_1252_19640_19677(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 19640, 19677);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1252_19746_19778(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 19746, 19778);
                    return return_v;
                }


                bool
                f_1252_20986_21019(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.RedirectShellErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 20986, 21019);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1252_21023_21060(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 21023, 21060);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1252_21158_21193(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 21158, 21193);
                    return return_v;
                }


                System.IDisposable
                f_1252_21310_21354(System.Management.Automation.MshCommandRuntime
                this_param, bool
                permittedToWriteToPipeline)
                {
                    var return_v = this_param.AllowThisCommandToWrite(permittedToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 21310, 21354);
                    return return_v;
                }


                System.IDisposable
                f_1252_21411_21512(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 21411, 21512);
                    return return_v;
                }


                int
                f_1252_21570_21603(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.SetCurrentScopeToExecutionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 21570, 21603);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1252_21640_21647()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 21640, 21647);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1252_21672_21679()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 21672, 21679);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1252_21764_21771()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 21764, 21771);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1252_21764_21780(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 21764, 21780);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1252_21794_21806(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 21794, 21806);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1252_21794_21819(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 21794, 21819);
                    return return_v;
                }


                bool
                f_1252_21764_21820(System.Management.Automation.ScriptDebugger
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = this_param.CheckCommand(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 21764, 21820);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1252_21884_21891()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 21884, 21891);
                    return return_v;
                }


                int
                f_1252_21884_21911(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    this_param.DoBeginProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 21884, 21911);
                    return 0;
                }


                System.Management.Automation.PipelineStoppedException
                f_1252_22174_22202(System.Management.Automation.CommandProcessorBase
                this_param, System.Exception
                e)
                {
                    var return_v = this_param.ManageInvocationException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 22174, 22202);
                    return return_v;
                }


                int
                f_1252_22453_22475(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.RestorePreviousScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 22453, 22475);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 18968, 22521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 18968, 22521);
            }
        }

        internal abstract void ProcessRecord();

        internal void DoExecute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 22991, 23547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 23041, 23076);

                f_1252_23041_23075();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 23092, 23175);

                CommandProcessorBase
                oldCurrentCommandProcessor = f_1252_23142_23174(_context)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 23225, 23264);

                    f_1252_23225_23232().CurrentCommandProcessor = this;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 23282, 23316);

                    f_1252_23282_23315(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 23334, 23350);

                    f_1252_23334_23349(this);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1252, 23379, 23536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 23419, 23480);

                    f_1252_23419_23426().CurrentCommandProcessor = oldCurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 23498, 23521);

                    f_1252_23498_23520(this);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1252, 23379, 23536);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 22991, 23547);

                int
                f_1252_23041_23075()
                {
                    ExecutionContext.CheckStackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 23041, 23075);
                    return 0;
                }


                System.Management.Automation.CommandProcessorBase
                f_1252_23142_23174(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 23142, 23174);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1252_23225_23232()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 23225, 23232);
                    return return_v;
                }


                int
                f_1252_23282_23315(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.SetCurrentScopeToExecutionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 23282, 23315);
                    return 0;
                }


                int
                f_1252_23334_23349(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.ProcessRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 23334, 23349);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1252_23419_23426()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 23419, 23426);
                    return return_v;
                }


                int
                f_1252_23498_23520(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.RestorePreviousScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 23498, 23520);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 22991, 23547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 22991, 23547);
            }
        }

        internal virtual void Complete()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 23892, 24771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 24028, 24044);

                f_1252_24028_24043(this);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 24096, 24414);
                    using (f_1252_24103_24147(commandRuntime, true))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 24189, 24395);
                        using (f_1252_24196_24291(ParameterBinderBase.bindingTracer, "CALLING EndProcessing"))
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 24341, 24372);

                            f_1252_24341_24371(f_1252_24341_24353(this));
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1252, 24189, 24395);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1252, 24096, 24414);
                    }
                }
                // 2004/03/18-JonN This is understood to be
                // an FXCOP violation, cleared by KCwalina.
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1252, 24557, 24760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 24710, 24745);

                    throw f_1252_24716_24744(this, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1252, 24557, 24760);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 23892, 24771);

                int
                f_1252_24028_24043(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.ProcessRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 24028, 24043);
                    return 0;
                }


                System.IDisposable
                f_1252_24103_24147(System.Management.Automation.MshCommandRuntime
                this_param, bool
                permittedToWriteToPipeline)
                {
                    var return_v = this_param.AllowThisCommandToWrite(permittedToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 24103, 24147);
                    return return_v;
                }


                System.IDisposable
                f_1252_24196_24291(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 24196, 24291);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1252_24341_24353(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 24341, 24353);
                    return return_v;
                }


                int
                f_1252_24341_24371(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    this_param.DoEndProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 24341, 24371);
                    return 0;
                }


                System.Management.Automation.PipelineStoppedException
                f_1252_24716_24744(System.Management.Automation.CommandProcessorBase
                this_param, System.Exception
                e)
                {
                    var return_v = this_param.ManageInvocationException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 24716, 24744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 23892, 24771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 23892, 24771);
            }
        }

        internal void DoComplete()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 24928, 27820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 24979, 25043);

                Pipe
                oldErrorOutputPipe = f_1252_25005_25042(_context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 25057, 25140);

                CommandProcessorBase
                oldCurrentCommandProcessor = f_1252_25107_25139(_context)
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 26271, 26494) || true) && (f_1252_26275_26308(this) || (DynAbs.Tracing.TraceSender.Expression_False(1252, 26275, 26357) || f_1252_26312_26349(_context) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 26271, 26494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 26399, 26475);

                        _context.ShellFunctionErrorOutputPipe = f_1252_26439_26474(this.commandRuntime);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 26271, 26494);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 26514, 26554);

                    _context.CurrentCommandProcessor = this;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 26574, 26608);

                    f_1252_26574_26607(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 26626, 26637);

                    f_1252_26626_26636(this);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1252, 26666, 27809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 26706, 26731);

                    f_1252_26706_26730(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 26751, 26810);

                    _context.ShellFunctionErrorOutputPipe = oldErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 26828, 26890);

                    _context.CurrentCommandProcessor = oldCurrentCommandProcessor;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 26987, 27136) || true) && (_useLocalScope && (DynAbs.Tracing.TraceSender.Expression_True(1252, 26991, 27029) && f_1252_27009_27021() != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 26987, 27136);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 27071, 27117);

                        f_1252_27071_27116(f_1252_27071_27090(), f_1252_27103_27115());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 26987, 27136);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 27202, 27560) || true) && (_previousScope != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 27202, 27560);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 27491, 27541);

                        f_1252_27491_27510().CurrentScope = _previousScope;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 27202, 27560);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 27635, 27794) || true) && (_previousCommandSessionState != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 27635, 27794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 27717, 27775);

                        f_1252_27717_27724().EngineSessionState = _previousCommandSessionState;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 27635, 27794);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1252, 26666, 27809);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 24928, 27820);

                System.Management.Automation.Internal.Pipe
                f_1252_25005_25042(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 25005, 25042);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1252_25107_25139(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 25107, 25139);
                    return return_v;
                }


                bool
                f_1252_26275_26308(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.RedirectShellErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 26275, 26308);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1252_26312_26349(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 26312, 26349);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1252_26439_26474(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 26439, 26474);
                    return return_v;
                }


                int
                f_1252_26574_26607(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.SetCurrentScopeToExecutionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 26574, 26607);
                    return 0;
                }


                int
                f_1252_26626_26636(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 26626, 26636);
                    return 0;
                }


                int
                f_1252_26706_26730(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.OnRestorePreviousScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 26706, 26730);
                    return 0;
                }


                System.Management.Automation.SessionStateScope
                f_1252_27009_27021()
                {
                    var return_v = CommandScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 27009, 27021);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1252_27071_27090()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 27071, 27090);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1252_27103_27115()
                {
                    var return_v = CommandScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 27103, 27115);
                    return return_v;
                }


                int
                f_1252_27071_27116(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.SessionStateScope
                scope)
                {
                    this_param.RemoveScope(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 27071, 27116);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1252_27491_27510()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 27491, 27510);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1252_27717_27724()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 27717, 27724);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 24928, 27820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 24928, 27820);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 27917, 28132);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 27975, 28047) || true) && (f_1252_27979_27990() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 27975, 28047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 28017, 28047);

                    return f_1252_28024_28046(f_1252_28024_28035());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 27975, 28047);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 28061, 28088);

                return "<NullCommandInfo>";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 27917, 28132);

                System.Management.Automation.CommandInfo
                f_1252_27979_27990()
                {
                    var return_v = CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 27979, 27990);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1252_28024_28035()
                {
                    var return_v = CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 28024, 28035);
                    return return_v;
                }


                string
                f_1252_28024_28046(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 28024, 28046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 27917, 28132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 27917, 28132);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool _firstCallToRead;

        internal virtual bool Read()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 28744, 29705);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 28888, 28982) || true) && (_firstCallToRead)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 28888, 28982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 28942, 28967);

                    _firstCallToRead = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 28888, 28982);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 29058, 29120);

                object
                inputObject = f_1252_29079_29119(f_1252_29079_29108(this.commandRuntime))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 29136, 29237) || true) && (inputObject == f_1252_29155_29175())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 29136, 29237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 29209, 29222);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 29136, 29237);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 29416, 29569) || true) && (f_1252_29420_29462(f_1252_29420_29445(f_1252_29420_29432(this))) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 29416, 29569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 29501, 29554);

                    f_1252_29501_29548(f_1252_29501_29526(f_1252_29501_29513(this)))[0]++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 29416, 29569);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 29585, 29666);

                f_1252_29585_29592().CurrentPipelineObject = f_1252_29617_29665(inputObject);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 29682, 29694);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 28744, 29705);

                System.Management.Automation.Internal.Pipe
                f_1252_29079_29108(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.InputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 29079, 29108);
                    return return_v;
                }


                object
                f_1252_29079_29119(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.Retrieve();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 29079, 29119);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1252_29155_29175()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 29155, 29175);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1252_29420_29432(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 29420, 29432);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1252_29420_29445(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 29420, 29445);
                    return return_v;
                }


                int
                f_1252_29420_29462(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelinePosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 29420, 29462);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1252_29501_29513(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 29501, 29513);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1252_29501_29526(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 29501, 29526);
                    return return_v;
                }


                int[]
                f_1252_29501_29548(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineIterationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 29501, 29548);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1252_29585_29592()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 29585, 29592);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1252_29617_29665(object
                obj)
                {
                    var return_v = LanguagePrimitives.AsPSObjectOrNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 29617, 29665);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 28744, 29705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 28744, 29705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PipelineStoppedException ManageInvocationException(Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 32168, 37231);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 32301, 36724) || true) && (f_1252_32305_32312() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 32301, 36724);
                        {
                            try
                            {
                                do // false loop

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 32362, 34432);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 32427, 32494);

                                    ProviderInvocationException
                                    pie = e as ProviderInvocationException
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 32520, 33020) || true) && (pie != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 32520, 33020);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 32821, 32957);

                                        e = f_1252_32825_32956(pie, f_1252_32935_32955(f_1252_32935_32942()));
                                        DynAbs.Tracing.TraceSender.TraceBreak(1252, 32987, 32993);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 32520, 33020);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 33364, 33871) || true) && (e is PipelineStoppedException
                                    || (DynAbs.Tracing.TraceSender.Expression_False(1252, 33368, 33460) || e is CmdletInvocationException
                                    ) || (DynAbs.Tracing.TraceSender.Expression_False(1252, 33368, 33527) || e is ActionPreferenceStopException
                                    ) || (DynAbs.Tracing.TraceSender.Expression_False(1252, 33368, 33585) || e is HaltCommandException
                                    ) || (DynAbs.Tracing.TraceSender.Expression_False(1252, 33368, 33643) || e is FlowControlException
                                    ) || (DynAbs.Tracing.TraceSender.Expression_False(1252, 33368, 33705) || e is ScriptCallDepthException))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 33364, 33871);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1252, 33838, 33844);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 33364, 33871);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 33899, 33944);

                                    RuntimeException
                                    rte = e as RuntimeException
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 33970, 34178) || true) && (rte != null && (DynAbs.Tracing.TraceSender.Expression_True(1252, 33974, 34020) && f_1252_33989_34020(rte)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 33970, 34178);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1252, 34145, 34151);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 33970, 34178);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 34260, 34394);

                                    e = f_1252_34264_34393(e, f_1252_34372_34392(f_1252_34372_34379()));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 32362, 34432);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 32362, 34432) || true) && (false)
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1252, 32362, 34432);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1252, 32362, 34432);
                            }
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 34745, 36609) || true) && (f_1252_34749_34778(commandRuntime))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 34745, 36609);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 34969, 35001);

                            bool
                            isTimeoutException = false
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 35027, 35055);

                            Exception
                            tempException = e
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 35081, 35478) || true) && (tempException != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 35081, 35478);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 35167, 35374) || true) && (tempException is System.TimeoutException)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 35167, 35374);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 35277, 35303);

                                        isTimeoutException = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1252, 35337, 35343);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 35167, 35374);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 35406, 35451);

                                    tempException = f_1252_35422_35450(tempException);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 35081, 35478);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1252, 35081, 35478);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1252, 35081, 35478);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 35506, 36116) || true) && (isTimeoutException)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 35506, 36116);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 35586, 35928);

                                ErrorRecord
                                errorRecord = f_1252_35612_35927(f_1252_35662_35769(f_1252_35730_35768()), "TRANSACTION_TIMEOUT", ErrorCategory.InvalidOperation, e)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 35958, 36010);

                                f_1252_35958_36009(errorRecord, f_1252_35988_36008(f_1252_35988_35995()));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 36042, 36089);

                                e = f_1252_36046_36088(errorRecord);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 35506, 36116);
                            }

                            if (
                            (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 36220, 36586) || true) && (f_1252_36254_36296(f_1252_36254_36281(_context)) && (DynAbs.Tracing.TraceSender.Expression_True(1252, 36254, 36430) && f_1252_36358_36404(f_1252_36358_36385(_context)) != RollbackSeverity.Never
                            ))
                                                       )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 36220, 36586);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 36517, 36559);

                                f_1252_36517_36558(f_1252_36517_36543(f_1252_36517_36524()), true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 36220, 36586);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 34745, 36609);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 36633, 36705);

                        return (PipelineStoppedException)f_1252_36666_36704(this.commandRuntime, e);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 32301, 36724);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 36876, 36914);

                    return f_1252_36883_36913();
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1252, 36943, 37220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 37111, 37181);

                    f_1252_37111_37180(false, "This method should not throw exceptions!");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 37199, 37205);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1252, 36943, 37220);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 32168, 37231);

                System.Management.Automation.Internal.InternalCommand
                f_1252_32305_32312()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 32305, 32312);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1252_32935_32942()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 32935, 32942);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1252_32935_32955(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 32935, 32955);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderInvocationException
                f_1252_32825_32956(System.Management.Automation.ProviderInvocationException
                innerException, System.Management.Automation.InvocationInfo
                myInvocation)
                {
                    var return_v = new System.Management.Automation.CmdletProviderInvocationException(innerException, myInvocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 32825, 32956);
                    return return_v;
                }


                bool
                f_1252_33989_34020(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.WasThrownFromThrowStatement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 33989, 34020);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1252_34372_34379()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 34372, 34379);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1252_34372_34392(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 34372, 34392);
                    return return_v;
                }


                System.Management.Automation.CmdletInvocationException
                f_1252_34264_34393(System.Exception
                innerException, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = new System.Management.Automation.CmdletInvocationException(innerException, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 34264, 34393);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1252_34749_34778(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.UseTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 34749, 34778);
                    return return_v;
                }


                System.Exception
                f_1252_35422_35450(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 35422, 35450);
                    return return_v;
                }


                string
                f_1252_35730_35768()
                {
                    var return_v = TransactionStrings.TransactionTimedOut;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 35730, 35768);
                    return return_v;
                }


                System.InvalidOperationException
                f_1252_35662_35769(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 35662, 35769);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1252_35612_35927(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Exception
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 35612, 35927);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1252_35988_35995()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 35988, 35995);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1252_35988_36008(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 35988, 36008);
                    return return_v;
                }


                int
                f_1252_35958_36009(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 35958, 36009);
                    return 0;
                }


                System.Management.Automation.CmdletInvocationException
                f_1252_36046_36088(System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    var return_v = new System.Management.Automation.CmdletInvocationException(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 36046, 36088);
                    return return_v;
                }


                System.Management.Automation.Internal.PSTransactionManager
                f_1252_36254_36281(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TransactionManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 36254, 36281);
                    return return_v;
                }


                bool
                f_1252_36254_36296(System.Management.Automation.Internal.PSTransactionManager
                this_param)
                {
                    var return_v = this_param.HasTransaction
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 36254, 36296);
                    return return_v;
                }


                System.Management.Automation.Internal.PSTransactionManager
                f_1252_36358_36385(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TransactionManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 36358, 36385);
                    return return_v;
                }


                System.Management.Automation.RollbackSeverity
                f_1252_36358_36404(System.Management.Automation.Internal.PSTransactionManager
                this_param)
                {
                    var return_v = this_param.RollbackPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 36358, 36404);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1252_36517_36524()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 36517, 36524);
                    return return_v;
                }


                System.Management.Automation.Internal.PSTransactionManager
                f_1252_36517_36543(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TransactionManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 36517, 36543);
                    return return_v;
                }


                int
                f_1252_36517_36558(System.Management.Automation.Internal.PSTransactionManager
                this_param, bool
                suppressErrors)
                {
                    this_param.Rollback(suppressErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 36517, 36558);
                    return 0;
                }


                System.Exception
                f_1252_36666_36704(System.Management.Automation.MshCommandRuntime
                this_param, System.Exception
                e)
                {
                    var return_v = this_param.ManageException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 36666, 36704);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1252_36883_36913()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 36883, 36913);
                    return return_v;
                }


                int
                f_1252_37111_37180(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 37111, 37180);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 32168, 37231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 32168, 37231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ManageScriptException(RuntimeException e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 37870, 38552);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 37950, 38425) || true) && (f_1252_37954_37961() != null && (DynAbs.Tracing.TraceSender.Expression_True(1252, 37954, 38013) && f_1252_37973_38005(commandRuntime) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 37950, 38425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 38047, 38106);

                    f_1252_38047_38105(f_1252_38047_38079(commandRuntime), e, f_1252_38097_38104());

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 38276, 38410) || true) && (!(e is PipelineStoppedException) && (DynAbs.Tracing.TraceSender.Expression_True(1252, 38280, 38346) && f_1252_38316_38346_M(!e.WasThrownFromThrowStatement)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 38276, 38410);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 38369, 38410);

                        f_1252_38369_38409(commandRuntime, e);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 38276, 38410);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 37950, 38425);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 38504, 38541);

                throw f_1252_38510_38540();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 37870, 38552);

                System.Management.Automation.Internal.InternalCommand
                f_1252_37954_37961()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 37954, 37961);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1252_37973_38005(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 37973, 38005);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1252_38047_38079(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 38047, 38079);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1252_38097_38104()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 38097, 38104);
                    return return_v;
                }


                bool
                f_1252_38047_38105(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.RuntimeException
                e, System.Management.Automation.Internal.InternalCommand
                command)
                {
                    var return_v = this_param.RecordFailure((System.Exception)e, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 38047, 38105);
                    return return_v;
                }


                bool
                f_1252_38316_38346_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 38316, 38346);
                    return return_v;
                }


                int
                f_1252_38369_38409(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.RuntimeException
                obj)
                {
                    this_param.AppendErrorToVariables((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 38369, 38409);
                    return 0;
                }


                System.Management.Automation.PipelineStoppedException
                f_1252_38510_38540()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 38510, 38540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 37870, 38552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 37870, 38552);
            }
        }

        internal void ForgetScriptException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 38756, 38990);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 38818, 38979) || true) && (f_1252_38822_38829() != null && (DynAbs.Tracing.TraceSender.Expression_True(1252, 38822, 38881) && f_1252_38841_38873(commandRuntime) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 38818, 38979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 38915, 38964);

                    f_1252_38915_38963(f_1252_38915_38947(commandRuntime));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 38818, 38979);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 38756, 38990);

                System.Management.Automation.Internal.InternalCommand
                f_1252_38822_38829()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 38822, 38829);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1252_38841_38873(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 38841, 38873);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1252_38915_38947(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 38915, 38947);
                    return return_v;
                }


                int
                f_1252_38915_38963(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    this_param.ForgetFailure();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 38915, 38963);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 38756, 38990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 38756, 38990);
            }
        }

        private bool _disposed;

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 39629, 39740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 39675, 39689);

                f_1252_39675_39688(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 39703, 39729);

                f_1252_39703_39728(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 39629, 39740);

                int
                f_1252_39675_39688(System.Management.Automation.CommandProcessorBase
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 39675, 39688);
                    return 0;
                }


                int
                f_1252_39703_39728(System.Management.Automation.CommandProcessorBase
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 39703, 39728);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 39629, 39740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 39629, 39740);
            }
        }

        private void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1252, 39752, 40316);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 39813, 39852) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 39813, 39852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 39845, 39852);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 39813, 39852);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 39868, 40272) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 39868, 40272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 40111, 40151);

                    IDisposable
                    id = f_1252_40128_40135() as IDisposable
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 40169, 40257) || true) && (id != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1252, 40169, 40257);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 40225, 40238);

                        f_1252_40225_40237(id);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 40169, 40257);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1252, 39868, 40272);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 40288, 40305);

                _disposed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1252, 39752, 40316);

                System.Management.Automation.Internal.InternalCommand
                f_1252_40128_40135()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 40128, 40135);
                    return return_v;
                }


                int
                f_1252_40225_40237(System.IDisposable
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 40225, 40237);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1252, 39752, 40316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 39752, 40316);
            }
        }

        /// <summary>
        /// Finalizer for class CommandProcessorBase.
        /// </summary>
        ~CommandProcessorBase()
        {
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 40478, 40493);

            f_1252_40478_40492(this, false);
        }

        static CommandProcessorBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1252, 522, 40542);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1252, 5690, 5729);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1252, 522, 40542);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1252, 522, 40542);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1252, 522, 40542);

        System.Management.Automation.PSArgumentNullException
        f_1252_1155_1208(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 1155, 1208);
            return return_v;
        }


        System.Management.Automation.ScriptBlock
        f_1252_1362_1387(System.Management.Automation.IScriptCommandInfo
        this_param)
        {
            var return_v = this_param.ScriptBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 1362, 1387);
            return return_v;
        }


        System.Management.Automation.ExperimentalAttribute
        f_1252_1362_1409(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.ExperimentalAttribute;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 1362, 1409);
            return return_v;
        }


        bool
        f_1252_1456_1475(System.Management.Automation.ExperimentalAttribute
        this_param)
        {
            var return_v = this_param.ToHide;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 1456, 1475);
            return return_v;
        }


        System.Management.Automation.ExperimentAction
        f_1252_1540_1569(System.Management.Automation.ExperimentalAttribute
        this_param)
        {
            var return_v = this_param.ExperimentAction;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 1540, 1569);
            return return_v;
        }


        string
        f_1252_1622_1669()
        {
            var return_v = DiscoveryExceptions.ScriptDisabledWhenFeatureOn
            ;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 1622, 1669);
            return return_v;
        }


        string
        f_1252_1697_1745()
        {
            var return_v = DiscoveryExceptions.ScriptDisabledWhenFeatureOff;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 1697, 1745);
            return return_v;
        }


        string
        f_1252_1819_1846(System.Management.Automation.ExperimentalAttribute
        this_param)
        {
            var return_v = this_param.ExperimentName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1252, 1819, 1846);
            return return_v;
        }


        string
        f_1252_1786_1847(string
        formatSpec, string
        o)
        {
            var return_v = StringUtil.Format(formatSpec, (object)o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 1786, 1847);
            return return_v;
        }


        System.InvalidOperationException
        f_1252_1938_1977(string
        message)
        {
            var return_v = new System.InvalidOperationException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 1938, 1977);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1252_1896_2123(System.InvalidOperationException
        exception, string
        errorId, System.Management.Automation.ErrorCategory
        errorCategory, System.Management.Automation.CommandInfo
        targetObject)
        {
            var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 1896, 2123);
            return return_v;
        }


        System.Management.Automation.CmdletInvocationException
        f_1252_2152_2194(System.Management.Automation.ErrorRecord
        errorRecord)
        {
            var return_v = new System.Management.Automation.CmdletInvocationException(errorRecord);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 2152, 2194);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
        f_1252_15228_15270()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 15228, 15270);
            return return_v;
        }


        int
        f_1252_40478_40492(System.Management.Automation.CommandProcessorBase
        this_param, bool
        disposing)
        {
            this_param.Dispose(disposing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1252, 40478, 40492);
            return 0;
        }

    }
}
