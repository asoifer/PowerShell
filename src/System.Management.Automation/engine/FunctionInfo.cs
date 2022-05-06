// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;
using System.Text;

namespace System.Management.Automation
{
    public class FunctionInfo : CommandInfo, IScriptCommandInfo
    {
        internal FunctionInfo(string name, ScriptBlock function, ExecutionContext context) : this(f_1278_1154_1158_C(name), function, context, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1278, 1064, 1206);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1278, 1064, 1206);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 1064, 1206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 1064, 1206);
            }
        }

        internal FunctionInfo(string name, ScriptBlock function, ExecutionContext context, string helpFile) : base(f_1278_2043_2047_C(name), CommandTypes.Function, context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1278, 1936, 2434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 6378, 6390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 14141, 14174);
                this._options = ScopedItemOptions.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 14839, 14858);
                this._description = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15107, 15127);
                this._verb = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15376, 15396);
                this._noun = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15758, 15782);
                this._helpFile = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 17297, 17313);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 2105, 2231) || true) && (function == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1278, 2105, 2231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 2159, 2216);

                    throw f_1278_2165_2215("function");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1278, 2105, 2231);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 2247, 2271);

                _scriptBlock = function;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 2287, 2342);

                f_1278_2287_2341(name, out _verb, out _noun);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 2358, 2388);

                this.Module = f_1278_2372_2387(function);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 2402, 2423);

                _helpFile = helpFile;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1278, 1936, 2434);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 1936, 2434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 1936, 2434);
            }
        }

        internal FunctionInfo(string name, ScriptBlock function, ScopedItemOptions options, ExecutionContext context) : this(f_1278_3309_3313_C(name), function, options, context, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1278, 3192, 3370);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1278, 3192, 3370);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 3192, 3370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 3192, 3370);
            }
        }

        internal FunctionInfo(string name, ScriptBlock function, ScopedItemOptions options, ExecutionContext context, string helpFile)
        : this(f_1278_4403_4407_C(name), function, context, helpFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1278, 4256, 4492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 4462, 4481);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1278, 4256, 4492);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 4256, 4492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 4256, 4492);
            }
        }

        internal FunctionInfo(FunctionInfo other)
        : base(f_1278_4686_4691_C(other))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1278, 4624, 4755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 6378, 6390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 14141, 14174);
                this._options = ScopedItemOptions.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 14839, 14858);
                this._description = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15107, 15127);
                this._verb = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15376, 15396);
                this._noun = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15758, 15782);
                this._helpFile = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 17297, 17313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 4717, 4744);

                f_1278_4717_4743(this, other);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1278, 4624, 4755);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 4624, 4755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 4624, 4755);
            }
        }

        private void CopyFieldsFromOther(FunctionInfo other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 4767, 5087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 4844, 4864);

                _verb = other._verb;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 4878, 4898);

                _noun = other._noun;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 4912, 4946);

                _scriptBlock = other._scriptBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 4960, 4994);

                _description = other._description;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 5008, 5034);

                _options = other._options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 5048, 5076);

                _helpFile = other._helpFile;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 4767, 5087);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 4767, 5087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 4767, 5087);
            }
        }

        internal FunctionInfo(string name, FunctionInfo other)
        : base(f_1278_5294_5298_C(name), other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1278, 5219, 5492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 6378, 6390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 14141, 14174);
                this._options = ScopedItemOptions.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 14839, 14858);
                this._description = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15107, 15127);
                this._verb = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15376, 15396);
                this._noun = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15758, 15782);
                this._helpFile = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 17297, 17313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 5331, 5358);

                f_1278_5331_5357(this, other);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 5426, 5481);

                f_1278_5426_5480(name, out _verb, out _noun);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1278, 5219, 5492);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 5219, 5492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 5219, 5492);
            }
        }

        internal override CommandInfo CreateGetCommandCopy(object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 5733, 5959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 5828, 5922);

                FunctionInfo
                copy = new FunctionInfo(this) { IsGetCommandCopy = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1278, 5848, 5921), Arguments = arguments }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 5936, 5948);

                return copy;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 5733, 5959);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 5733, 5959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 5733, 5959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override HelpCategory HelpCategory
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 6066, 6103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 6072, 6101);

                    return HelpCategory.Function;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 6066, 6103);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 5998, 6114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 5998, 6114);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ScriptBlock ScriptBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 6307, 6335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 6313, 6333);

                    return _scriptBlock;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 6307, 6335);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 6252, 6346);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 6252, 6346);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ScriptBlock _scriptBlock;

        internal void Update(ScriptBlock newFunction, bool force, ScopedItemOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 7015, 7244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 7124, 7166);

                f_1278_7124_7165(this, newFunction, force, options, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 7180, 7233);

                this.DefiningLanguageMode = f_1278_7208_7232(newFunction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 7015, 7244);

                int
                f_1278_7124_7165(System.Management.Automation.FunctionInfo
                this_param, System.Management.Automation.ScriptBlock
                newFunction, bool
                force, System.Management.Automation.ScopedItemOptions
                options, string
                helpFile)
                {
                    this_param.Update(newFunction, force, options, helpFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 7124, 7165);
                    return 0;
                }


                System.Management.Automation.PSLanguageMode?
                f_1278_7208_7232(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 7208, 7232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 7015, 7244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 7015, 7244);
            }
        }

        protected internal virtual void Update(FunctionInfo newFunction, bool force, ScopedItemOptions options, string helpFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 7280, 7494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 7425, 7483);

                f_1278_7425_7482(this, f_1278_7432_7455(newFunction), force, options, helpFile);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 7280, 7494);

                System.Management.Automation.ScriptBlock
                f_1278_7432_7455(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 7432, 7455);
                    return return_v;
                }


                int
                f_1278_7425_7482(System.Management.Automation.FunctionInfo
                this_param, System.Management.Automation.ScriptBlock
                newFunction, bool
                force, System.Management.Automation.ScopedItemOptions
                options, string
                helpFile)
                {
                    this_param.Update(newFunction, force, options, helpFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 7425, 7482);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 7280, 7494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 7280, 7494);
            }
        }

        internal void Update(ScriptBlock newFunction, bool force, ScopedItemOptions options, string helpFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 8222, 9820);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 8348, 8477) || true) && (newFunction == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1278, 8348, 8477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 8405, 8462);

                    throw f_1278_8411_8461("function");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1278, 8348, 8477);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 8493, 8943) || true) && ((_options & ScopedItemOptions.Constant) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1278, 8493, 8943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 8575, 8900);

                    SessionStateUnauthorizedAccessException
                    e =
                    f_1278_8640_8899(f_1278_8714_8718(), SessionStateCategory.Function, "FunctionIsConstant", f_1278_8860_8898())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 8920, 8928);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1278, 8493, 8943);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 8959, 9419) || true) && (!force && (DynAbs.Tracing.TraceSender.Expression_True(1278, 8963, 9017) && (_options & ScopedItemOptions.ReadOnly) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1278, 8959, 9419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 9051, 9376);

                    SessionStateUnauthorizedAccessException
                    e =
                    f_1278_9116_9375(f_1278_9190_9194(), SessionStateCategory.Function, "FunctionIsReadOnly", f_1278_9336_9374())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 9396, 9404);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1278, 8959, 9419);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 9435, 9462);

                _scriptBlock = newFunction;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 9478, 9511);

                this.Module = f_1278_9492_9510(newFunction);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 9525, 9549);

                _commandMetadata = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 9563, 9590);

                this._parameterSets = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 9604, 9640);

                this.ExternalCommandMetadata = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 9656, 9772) || true) && (options != ScopedItemOptions.Unspecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1278, 9656, 9772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 9734, 9757);

                    this.Options = options;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1278, 9656, 9772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 9788, 9809);

                _helpFile = helpFile;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 8222, 9820);

                System.Management.Automation.PSArgumentNullException
                f_1278_8411_8461(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 8411, 8461);
                    return return_v;
                }


                string
                f_1278_8714_8718()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 8714, 8718);
                    return return_v;
                }


                string
                f_1278_8860_8898()
                {
                    var return_v = SessionStateStrings.FunctionIsConstant;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 8860, 8898);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1278_8640_8899(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 8640, 8899);
                    return return_v;
                }


                string
                f_1278_9190_9194()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 9190, 9194);
                    return return_v;
                }


                string
                f_1278_9336_9374()
                {
                    var return_v = SessionStateStrings.FunctionIsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 9336, 9374);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1278_9116_9375(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 9116, 9375);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1278_9492_9510(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 9492, 9510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 8222, 9820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 8222, 9820);
            }
        }

        public bool CmdletBinding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 10056, 10149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 10092, 10134);

                    return f_1278_10099_10133(f_1278_10099_10115(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 10056, 10149);

                    System.Management.Automation.ScriptBlock
                    f_1278_10099_10115(System.Management.Automation.FunctionInfo
                    this_param)
                    {
                        var return_v = this_param.ScriptBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 10099, 10115);
                        return return_v;
                    }


                    bool
                    f_1278_10099_10133(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.UsesCmdletBinding;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 10099, 10133);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 10006, 10160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 10006, 10160);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string DefaultParameterSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 10471, 10602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 10507, 10587);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1278, 10514, 10532) || ((f_1278_10514_10532(this) && DynAbs.Tracing.TraceSender.Conditional_F2(1278, 10535, 10579)) || DynAbs.Tracing.TraceSender.Conditional_F3(1278, 10582, 10586))) ? f_1278_10535_10579(f_1278_10535_10555(this)) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 10471, 10602);

                    bool
                    f_1278_10514_10532(System.Management.Automation.FunctionInfo
                    this_param)
                    {
                        var return_v = this_param.CmdletBinding;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 10514, 10532);
                        return return_v;
                    }


                    System.Management.Automation.CommandMetadata
                    f_1278_10535_10555(System.Management.Automation.FunctionInfo
                    this_param)
                    {
                        var return_v = this_param.CommandMetadata;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 10535, 10555);
                        return return_v;
                    }


                    string
                    f_1278_10535_10579(System.Management.Automation.CommandMetadata
                    this_param)
                    {
                        var return_v = this_param.DefaultParameterSetName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 10535, 10579);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 10413, 10613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 10413, 10613);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Definition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 10843, 10882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 10849, 10880);

                    return f_1278_10856_10879(_scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 10843, 10882);

                    string
                    f_1278_10856_10879(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 10856, 10879);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 10807, 10884);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 10807, 10884);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ScopedItemOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 11302, 11433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 11338, 11418);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1278, 11345, 11366) || ((f_1278_11345_11358() == null && DynAbs.Tracing.TraceSender.Conditional_F2(1278, 11369, 11377)) || DynAbs.Tracing.TraceSender.Conditional_F3(1278, 11380, 11417))) ? _options : f_1278_11380_11417(((FunctionInfo)f_1278_11395_11408()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 11302, 11433);

                    System.Management.Automation.CommandInfo
                    f_1278_11345_11358()
                    {
                        var return_v = CopiedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 11345, 11358);
                        return return_v;
                    }


                    System.Management.Automation.CommandInfo
                    f_1278_11395_11408()
                    {
                        var return_v = CopiedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 11395, 11408);
                        return return_v;
                    }


                    System.Management.Automation.ScopedItemOptions
                    f_1278_11380_11417(System.Management.Automation.FunctionInfo
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 11380, 11417);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 11245, 14103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 11245, 14103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 11449, 14092);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 11485, 14077) || true) && (f_1278_11489_11502() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1278, 11485, 14077);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 11708, 12230) || true) && ((_options & ScopedItemOptions.Constant) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1278, 11708, 12230);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 11806, 12171);

                            SessionStateUnauthorizedAccessException
                            e =
                            f_1278_11879_12170(f_1278_11961_11965(), SessionStateCategory.Function, "FunctionIsConstant", f_1278_12131_12169())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 12199, 12207);

                            throw e;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1278, 11708, 12230);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 12443, 13149) || true) && ((value & ScopedItemOptions.Constant) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1278, 12443, 13149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 12705, 13090);

                            SessionStateUnauthorizedAccessException
                            e =
                            f_1278_12778_13089(f_1278_12860_12864(), SessionStateCategory.Function, "FunctionCannotBeMadeConstant", f_1278_13040_13088())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 13118, 13126);

                            throw e;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1278, 12443, 13149);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 13254, 13889) || true) && ((value & ScopedItemOptions.AllScope) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1278, 13258, 13372) && (_options & ScopedItemOptions.AllScope) != 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1278, 13254, 13889);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 13422, 13830);

                            SessionStateUnauthorizedAccessException
                            e =
                            f_1278_13495_13829(f_1278_13577_13586(this), SessionStateCategory.Function, "FunctionAllScopeOptionCannotBeRemoved", f_1278_13771_13828())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 13858, 13866);

                            throw e;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1278, 13254, 13889);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 13913, 13930);

                        _options = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1278, 11485, 14077);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1278, 11485, 14077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 14012, 14058);

                        ((FunctionInfo)f_1278_14027_14040()).Options = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1278, 11485, 14077);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 11449, 14092);

                    System.Management.Automation.CommandInfo
                    f_1278_11489_11502()
                    {
                        var return_v = CopiedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 11489, 11502);
                        return return_v;
                    }


                    string
                    f_1278_11961_11965()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 11961, 11965);
                        return return_v;
                    }


                    string
                    f_1278_12131_12169()
                    {
                        var return_v = SessionStateStrings.FunctionIsConstant;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 12131, 12169);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateUnauthorizedAccessException
                    f_1278_11879_12170(string
                    itemName, System.Management.Automation.SessionStateCategory
                    sessionStateCategory, string
                    errorIdAndResourceId, string
                    resourceStr)
                    {
                        var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 11879, 12170);
                        return return_v;
                    }


                    string
                    f_1278_12860_12864()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 12860, 12864);
                        return return_v;
                    }


                    string
                    f_1278_13040_13088()
                    {
                        var return_v = SessionStateStrings.FunctionCannotBeMadeConstant;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 13040, 13088);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateUnauthorizedAccessException
                    f_1278_12778_13089(string
                    itemName, System.Management.Automation.SessionStateCategory
                    sessionStateCategory, string
                    errorIdAndResourceId, string
                    resourceStr)
                    {
                        var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 12778, 13089);
                        return return_v;
                    }


                    string
                    f_1278_13577_13586(System.Management.Automation.FunctionInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 13577, 13586);
                        return return_v;
                    }


                    string
                    f_1278_13771_13828()
                    {
                        var return_v = SessionStateStrings.FunctionAllScopeOptionCannotBeRemoved;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 13771, 13828);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateUnauthorizedAccessException
                    f_1278_13495_13829(string
                    itemName, System.Management.Automation.SessionStateCategory
                    sessionStateCategory, string
                    errorIdAndResourceId, string
                    resourceStr)
                    {
                        var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 13495, 13829);
                        return return_v;
                    }


                    System.Management.Automation.CommandInfo
                    f_1278_14027_14040()
                    {
                        var return_v = CopiedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 14027, 14040);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 11245, 14103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 11245, 14103);
                }
            }
        }

        private ScopedItemOptions _options;

        public string Description
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 14356, 14495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 14392, 14480);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1278, 14399, 14420) || ((f_1278_14399_14412() == null && DynAbs.Tracing.TraceSender.Conditional_F2(1278, 14423, 14435)) || DynAbs.Tracing.TraceSender.Conditional_F3(1278, 14438, 14479))) ? _description : f_1278_14438_14479(((FunctionInfo)f_1278_14453_14466()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 14356, 14495);

                    System.Management.Automation.CommandInfo
                    f_1278_14399_14412()
                    {
                        var return_v = CopiedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 14399, 14412);
                        return return_v;
                    }


                    System.Management.Automation.CommandInfo
                    f_1278_14453_14466()
                    {
                        var return_v = CopiedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 14453, 14466);
                        return return_v;
                    }


                    string
                    f_1278_14438_14479(System.Management.Automation.FunctionInfo
                    this_param)
                    {
                        var return_v = this_param.Description;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 14438, 14479);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 14306, 14812);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 14306, 14812);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 14511, 14801);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 14547, 14786) || true) && (f_1278_14551_14564() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1278, 14547, 14786);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 14614, 14635);

                        _description = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1278, 14547, 14786);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1278, 14547, 14786);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 14717, 14767);

                        ((FunctionInfo)f_1278_14732_14745()).Description = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1278, 14547, 14786);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 14511, 14801);

                    System.Management.Automation.CommandInfo
                    f_1278_14551_14564()
                    {
                        var return_v = CopiedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 14551, 14564);
                        return return_v;
                    }


                    System.Management.Automation.CommandInfo
                    f_1278_14732_14745()
                    {
                        var return_v = CopiedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 14732, 14745);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 14306, 14812);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 14306, 14812);
                }
            }
        }

        private string _description;

        public string Verb
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 15005, 15069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15041, 15054);

                    return _verb;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 15005, 15069);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 14962, 15080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 14962, 15080);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _verb;

        public string Noun
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 15274, 15338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15310, 15323);

                    return _noun;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 15274, 15338);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 15231, 15349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 15231, 15349);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _noun;

        public string HelpFile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 15558, 15626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15594, 15611);

                    return _helpFile;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 15558, 15626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 15511, 15731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 15511, 15731);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 15642, 15720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15687, 15705);

                    _helpFile = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 15642, 15720);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 15511, 15731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 15511, 15731);
                }
            }
        }

        private string _helpFile;

        internal override string Syntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 15944, 16536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 15980, 16025);

                    StringBuilder
                    synopsis = f_1278_16005_16024()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 16045, 16474);
                        foreach (CommandParameterSetInfo parameterSet in f_1278_16094_16107_I(f_1278_16094_16107()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1278, 16045, 16474);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 16149, 16171);

                            f_1278_16149_16170(synopsis);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 16193, 16455);

                            f_1278_16193_16454(synopsis, f_1278_16239_16453(f_1278_16283_16323(), "{0} {1}", f_1278_16394_16398(), f_1278_16429_16452(parameterSet)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1278, 16045, 16474);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1278, 1, 430);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1278, 1, 430);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 16494, 16521);

                    return f_1278_16501_16520(synopsis);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 15944, 16536);

                    System.Text.StringBuilder
                    f_1278_16005_16024()
                    {
                        var return_v = new System.Text.StringBuilder();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 16005, 16024);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                    f_1278_16094_16107()
                    {
                        var return_v = ParameterSets;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 16094, 16107);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_1278_16149_16170(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.AppendLine();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 16149, 16170);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1278_16283_16323()
                    {
                        var return_v = Globalization.CultureInfo.CurrentCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 16283, 16323);
                        return return_v;
                    }


                    string
                    f_1278_16394_16398()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 16394, 16398);
                        return return_v;
                    }


                    string
                    f_1278_16429_16452(System.Management.Automation.CommandParameterSetInfo
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 16429, 16452);
                        return return_v;
                    }


                    string
                    f_1278_16239_16453(System.Globalization.CultureInfo
                    provider, string
                    format, string
                    arg0, string
                    arg1)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 16239, 16453);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_1278_16193_16454(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.AppendLine(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 16193, 16454);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                    f_1278_16094_16107_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 16094, 16107);
                        return return_v;
                    }


                    string
                    f_1278_16501_16520(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 16501, 16520);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 15888, 16547);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 15888, 16547);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool ImplementsDynamicParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 16755, 16803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 16761, 16801);

                    return f_1278_16768_16800(f_1278_16768_16779());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 16755, 16803);

                    System.Management.Automation.ScriptBlock
                    f_1278_16768_16779()
                    {
                        var return_v = ScriptBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 16768, 16779);
                        return return_v;
                    }


                    bool
                    f_1278_16768_16800(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.HasDynamicParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 16768, 16800);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 16680, 16814);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 16680, 16814);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CommandMetadata CommandMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 17009, 17250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 17045, 17235);

                    return _commandMetadata ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.CommandMetadata>(1278, 17052, 17234) ?? (_commandMetadata =
                    f_1278_17141_17233(f_1278_17161_17177(this), f_1278_17179_17188(this), f_1278_17190_17232())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 17009, 17250);

                    System.Management.Automation.ScriptBlock
                    f_1278_17161_17177(System.Management.Automation.FunctionInfo
                    this_param)
                    {
                        var return_v = this_param.ScriptBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 17161, 17177);
                        return return_v;
                    }


                    string
                    f_1278_17179_17188(System.Management.Automation.FunctionInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 17179, 17188);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1278_17190_17232()
                    {
                        var return_v = LocalPipeline.GetExecutionContextFromTLS();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 17190, 17232);
                        return return_v;
                    }


                    System.Management.Automation.CommandMetadata
                    f_1278_17141_17233(System.Management.Automation.ScriptBlock
                    scriptblock, string
                    commandName, System.Management.Automation.ExecutionContext
                    context)
                    {
                        var return_v = new System.Management.Automation.CommandMetadata(scriptblock, commandName, context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 17141, 17233);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 16935, 17261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 16935, 17261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private CommandMetadata _commandMetadata;

        public override ReadOnlyCollection<PSTypeName> OutputType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1278, 17521, 17559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1278, 17527, 17557);

                    return f_1278_17534_17556(f_1278_17534_17545());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1278, 17521, 17559);

                    System.Management.Automation.ScriptBlock
                    f_1278_17534_17545()
                    {
                        var return_v = ScriptBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 17534, 17545);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                    f_1278_17534_17556(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.OutputType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 17534, 17556);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1278, 17439, 17570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 17439, 17570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static FunctionInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1278, 374, 17577);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1278, 374, 17577);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1278, 374, 17577);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1278, 374, 17577);

        static string
        f_1278_1154_1158_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1278, 1064, 1206);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1278_2165_2215(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 2165, 2215);
            return return_v;
        }


        bool
        f_1278_2287_2341(string
        name, out string
        verb, out string
        noun)
        {
            var return_v = CmdletInfo.SplitCmdletName(name, out verb, out noun);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 2287, 2341);
            return return_v;
        }


        System.Management.Automation.PSModuleInfo
        f_1278_2372_2387(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1278, 2372, 2387);
            return return_v;
        }


        static string
        f_1278_2043_2047_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1278, 1936, 2434);
            return return_v;
        }


        static string
        f_1278_3309_3313_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1278, 3192, 3370);
            return return_v;
        }


        static string
        f_1278_4403_4407_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1278, 4256, 4492);
            return return_v;
        }


        int
        f_1278_4717_4743(System.Management.Automation.FunctionInfo
        this_param, System.Management.Automation.FunctionInfo
        other)
        {
            this_param.CopyFieldsFromOther(other);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 4717, 4743);
            return 0;
        }


        static System.Management.Automation.CommandInfo
        f_1278_4686_4691_C(System.Management.Automation.CommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1278, 4624, 4755);
            return return_v;
        }


        int
        f_1278_5331_5357(System.Management.Automation.FunctionInfo
        this_param, System.Management.Automation.FunctionInfo
        other)
        {
            this_param.CopyFieldsFromOther(other);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 5331, 5357);
            return 0;
        }


        bool
        f_1278_5426_5480(string
        name, out string
        verb, out string
        noun)
        {
            var return_v = CmdletInfo.SplitCmdletName(name, out verb, out noun);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1278, 5426, 5480);
            return return_v;
        }


        static string
        f_1278_5294_5298_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1278, 5219, 5492);
            return return_v;
        }

    }
}
