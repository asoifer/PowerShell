// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Reflection;

using PipelineResultTypes = System.Management.Automation.Runspaces.PipelineResultTypes;

namespace System.Management.Automation
{
    /// <summary>
    /// An interface that a
    /// <see cref="Cmdlet"/> or <see cref="Provider.CmdletProvider"/>
    /// must implement to indicate that it has dynamic parameters.
    /// </summary>
    /// <remarks>
    /// Dynamic parameters allow a
    /// <see cref="Cmdlet"/> or <see cref="Provider.CmdletProvider"/>
    /// to define additional parameters based on the value of
    /// the formal arguments.  For example, the parameters of
    /// "set-itemproperty" for the file system provider vary
    /// depending on whether the target object is a file or directory.
    /// </remarks>
    /// <seealso cref="Cmdlet"/>
    /// <seealso cref="PSCmdlet"/>
    /// <seealso cref="RuntimeDefinedParameter"/>
    /// <seealso cref="RuntimeDefinedParameterDictionary"/>
    public interface IDynamicParameters
    {

        object GetDynamicParameters();
    }

    public struct SwitchParameter
    {

        private bool _isPresent;

        public bool IsPresent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 3478, 3504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 3484, 3502);

                    return _isPresent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 3478, 3504);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 3432, 3515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 3432, 3515);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        /// <summary>
        /// Implicit cast operator for casting SwitchParameter to bool.
        /// </summary>
        /// <param name="switchParameter">The SwitchParameter object to convert to bool.</param>
        /// <returns>The corresponding boolean value.</returns>
        public static implicit operator bool(SwitchParameter switchParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1290, 3808, 3946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 3902, 3935);

                return switchParameter.IsPresent;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1290, 3808, 3946);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 3808, 3946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 3808, 3946);
            }
        }
        /// <summary>
        /// Implicit cast operator for casting bool to SwitchParameter.
        /// </summary>
        /// <param name="value">The bool to convert to SwitchParameter.</param>
        /// <returns>The corresponding boolean value.</returns>
        public static implicit operator SwitchParameter(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1290, 4224, 4353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 4308, 4342);

                return f_1290_4315_4341(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1290, 4224, 4353);

                System.Management.Automation.SwitchParameter
                f_1290_4315_4341(bool
                isPresent)
                {
                    var return_v = new System.Management.Automation.SwitchParameter(isPresent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 4315, 4341);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 4224, 4353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 4224, 4353);
            }
        }
        public bool ToBool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 4569, 4643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 4614, 4632);

                return _isPresent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 4569, 4643);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 4569, 4643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 4569, 4643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SwitchParameter(bool isPresent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1290, 4917, 5014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 4980, 5003);

                _isPresent = isPresent;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1290, 4917, 5014);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 4917, 5014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 4917, 5014);
            }
        }

        public static SwitchParameter Present
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1290, 5349, 5390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 5355, 5388);

                    return f_1290_5362_5387(true);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1290, 5349, 5390);

                    System.Management.Automation.SwitchParameter
                    f_1290_5362_5387(bool
                    isPresent)
                    {
                        var return_v = new System.Management.Automation.SwitchParameter(isPresent);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 5362, 5387);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 5287, 5401);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 5287, 5401);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 5663, 6060);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 5727, 6049) || true) && (obj is bool)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 5727, 6049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 5776, 5807);

                    return _isPresent == (bool)obj;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 5727, 6049);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 5727, 6049);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 5841, 6049) || true) && (obj is SwitchParameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 5841, 6049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 5901, 5955);

                        return _isPresent == ((SwitchParameter)obj).IsPresent;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 5841, 6049);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 5841, 6049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 6021, 6034);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 5841, 6049);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 5727, 6049);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 5663, 6060);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 5663, 6060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 5663, 6060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 6243, 6344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 6301, 6333);

                return f_1290_6308_6332(_isPresent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 6243, 6344);

                int
                f_1290_6308_6332(bool
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 6308, 6332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 6243, 6344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 6243, 6344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(SwitchParameter first, SwitchParameter second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1290, 6666, 6807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 6768, 6796);

                return first.Equals(second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1290, 6666, 6807);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 6666, 6807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 6666, 6807);
            }
        }

        public static bool operator !=(SwitchParameter first, SwitchParameter second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1290, 7120, 7262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 7222, 7251);

                return !first.Equals(second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1290, 7120, 7262);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 7120, 7262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 7120, 7262);
            }
        }

        public static bool operator ==(SwitchParameter first, bool second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1290, 7587, 7717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 7678, 7706);

                return first.Equals(second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1290, 7587, 7717);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 7587, 7717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 7587, 7717);
            }
        }

        public static bool operator !=(SwitchParameter first, bool second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1290, 8043, 8174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 8134, 8163);

                return !first.Equals(second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1290, 8043, 8174);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 8043, 8174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 8043, 8174);
            }
        }

        public static bool operator ==(bool first, SwitchParameter second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1290, 8495, 8625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 8586, 8614);

                return f_1290_8593_8613(first, second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1290, 8495, 8625);

                bool
                f_1290_8593_8613(bool
                this_param, System.Management.Automation.SwitchParameter
                obj)
                {
                    var return_v = this_param.Equals((bool)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 8593, 8613);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 8495, 8625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 8495, 8625);
            }
        }

        public static bool operator !=(bool first, SwitchParameter second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1290, 8947, 9078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 9038, 9067);

                return !f_1290_9046_9066(first, second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1290, 8947, 9078);

                bool
                f_1290_9046_9066(bool
                this_param, System.Management.Automation.SwitchParameter
                obj)
                {
                    var return_v = this_param.Equals((bool)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 9046, 9066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 8947, 9078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 8947, 9078);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 9261, 9359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 9319, 9348);

                return f_1290_9326_9347(_isPresent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 9261, 9359);

                string
                f_1290_9326_9347(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 9326, 9347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 9261, 9359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 9261, 9359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SwitchParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1290, 3129, 9366);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1290, 3129, 9366);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 3129, 9366);
        }
    }
    public class CommandInvocationIntrinsics
    {
        private ExecutionContext _context;

        private PSCmdlet _cmdlet;

        private MshCommandRuntime _commandRuntime;

        internal CommandInvocationIntrinsics(ExecutionContext context, PSCmdlet cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1290, 9688, 9999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 9580, 9588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 9616, 9623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 9660, 9675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 13653, 13739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 14022, 14109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 14502, 14590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 14752, 14840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 9792, 9811);

                _context = context;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 9825, 9988) || true) && (cmdlet != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 9825, 9988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 9877, 9894);

                    _cmdlet = cmdlet;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 9912, 9973);

                    _commandRuntime = f_1290_9930_9951(cmdlet) as MshCommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 9825, 9988);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1290, 9688, 9999);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 9688, 9999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 9688, 9999);
            }
        }

        internal CommandInvocationIntrinsics(ExecutionContext context)
        : this(f_1290_10094_10101_C(context), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1290, 10011, 10130);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1290, 10011, 10130);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 10011, 10130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 10011, 10130);
            }
        }

        public bool HasErrors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 10323, 10431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 10359, 10416);

                    return f_1290_10366_10415(f_1290_10366_10399(_commandRuntime));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 10323, 10431);

                    System.Management.Automation.Internal.PipelineProcessor
                    f_1290_10366_10399(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.PipelineProcessor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 10366, 10399);
                        return return_v;
                    }


                    bool
                    f_1290_10366_10415(System.Management.Automation.Internal.PipelineProcessor
                    this_param)
                    {
                        var return_v = this_param.ExecutionFailed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 10366, 10415);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 10277, 10567);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 10277, 10567);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 10447, 10556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 10483, 10541);

                    f_1290_10483_10516(_commandRuntime).ExecutionFailed = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 10447, 10556);

                    System.Management.Automation.Internal.PipelineProcessor
                    f_1290_10483_10516(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.PipelineProcessor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 10483, 10516);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 10277, 10567);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 10277, 10567);
                }
            }
        }

        public string ExpandString(string source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 11005, 11198);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 11071, 11135) || true) && (_cmdlet != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 11071, 11135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 11109, 11135);

                    f_1290_11109_11134(_cmdlet);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 11071, 11135);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 11149, 11187);

                return f_1290_11156_11186(f_1290_11156_11171(_context), source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 11005, 11198);

                int
                f_1290_11109_11134(System.Management.Automation.PSCmdlet
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 11109, 11134);
                    return 0;
                }


                System.Management.Automation.AutomationEngine
                f_1290_11156_11171(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Engine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 11156, 11171);
                    return return_v;
                }


                string
                f_1290_11156_11186(System.Management.Automation.AutomationEngine
                this_param, string
                s)
                {
                    var return_v = this_param.Expand(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 11156, 11186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 11005, 11198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 11005, 11198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CommandInfo GetCommand(string commandName, CommandTypes type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 11379, 11526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 11472, 11515);

                return f_1290_11479_11514(this, commandName, type, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 11379, 11526);

                System.Management.Automation.CommandInfo
                f_1290_11479_11514(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                commandName, System.Management.Automation.CommandTypes
                type, object[]
                arguments)
                {
                    var return_v = this_param.GetCommand(commandName, type, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 11479, 11514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 11379, 11526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 11379, 11526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CommandInfo GetCommand(string commandName, CommandTypes type, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 12075, 13253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 12188, 12214);

                CommandInfo
                result = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 12266, 12319);

                    CommandOrigin
                    commandOrigin = CommandOrigin.Runspace
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 12337, 12628) || true) && (_cmdlet != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 12337, 12628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 12398, 12436);

                        commandOrigin = f_1290_12414_12435(_cmdlet);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 12337, 12628);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 12337, 12628);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 12478, 12628) || true) && (_context != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 12478, 12628);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 12540, 12609);

                            commandOrigin = f_1290_12556_12608(f_1290_12556_12596(f_1290_12556_12583(_context)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 12478, 12628);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 12337, 12628);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 12648, 12766);

                    result = f_1290_12657_12765(commandName, type, SearchResolutionOptions.None, commandOrigin, _context);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 12786, 13147) || true) && ((result != null) && (DynAbs.Tracing.TraceSender.Expression_True(1290, 12790, 12829) && (arguments != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1290, 12790, 12855) && (f_1290_12834_12850(arguments) > 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 12786, 13147);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 12969, 13128) || true) && (f_1290_12973_13007(result))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 12969, 13128);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 13057, 13105);

                            result = f_1290_13066_13104(result, arguments);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 12969, 13128);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 12786, 13147);
                    }
                }
                catch (CommandNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 13176, 13212);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 13176, 13212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 13228, 13242);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 12075, 13253);

                System.Management.Automation.CommandOrigin
                f_1290_12414_12435(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 12414, 12435);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1290_12556_12583(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 12556, 12583);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1290_12556_12596(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 12556, 12596);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1290_12556_12608(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScopeOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 12556, 12608);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1290_12657_12765(string
                commandName, System.Management.Automation.CommandTypes
                commandTypes, System.Management.Automation.SearchResolutionOptions
                searchResolutionOptions, System.Management.Automation.CommandOrigin
                commandOrigin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = CommandDiscovery.LookupCommandInfo(commandName, commandTypes, searchResolutionOptions, commandOrigin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 12657, 12765);
                    return return_v;
                }


                int
                f_1290_12834_12850(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 12834, 12850);
                    return return_v;
                }


                bool
                f_1290_12973_13007(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ImplementsDynamicParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 12973, 13007);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1290_13066_13104(System.Management.Automation.CommandInfo
                this_param, object[]
                argumentList)
                {
                    var return_v = this_param.CreateGetCommandCopy(argumentList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 13066, 13104);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 12075, 13253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 12075, 13253);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public System.EventHandler<CommandLookupEventArgs> CommandNotFoundAction { get; set; }

        public System.EventHandler<CommandLookupEventArgs> PreCommandLookupAction { get; set; }

        public System.EventHandler<CommandLookupEventArgs> PostCommandLookupAction { get; set; }

        public System.EventHandler<LocationChangedEventArgs> LocationChangedAction { get; set; }

        public CmdletInfo GetCmdlet(string commandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 15144, 15267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 15216, 15256);

                return f_1290_15223_15255(commandName, _context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 15144, 15267);

                System.Management.Automation.CmdletInfo
                f_1290_15223_15255(string
                commandName, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = GetCmdlet(commandName, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 15223, 15255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 15144, 15267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 15144, 15267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CmdletInfo GetCmdlet(string commandName, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1290, 15664, 16941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 15771, 15797);

                CmdletInfo
                current = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 15813, 16018);

                CommandSearcher
                searcher = f_1290_15840_16017(commandName, SearchResolutionOptions.None, CommandTypes.Cmdlet, context)
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 16032, 16899);
                            try
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 16111, 16214) || true) && (!f_1290_16116_16135(searcher))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 16111, 16214);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1290, 16185, 16191);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 16111, 16214);
                                }
                            }
                            catch (ArgumentException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 16251, 16345);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 16317, 16326);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 16251, 16345);
                            }
                            catch (PathTooLongException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 16363, 16460);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 16432, 16441);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 16363, 16460);
                            }
                            catch (FileLoadException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 16478, 16572);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 16544, 16553);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 16478, 16572);
                            }
                            catch (MetadataException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 16590, 16684);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 16656, 16665);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 16590, 16684);
                            }
                            catch (FormatException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 16702, 16794);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 16766, 16775);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 16702, 16794);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 16814, 16870);

                            current = f_1290_16824_16855(((IEnumerator)searcher)) as CmdletInfo;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 16032, 16899);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 16032, 16899) || true) && (true)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1290, 16032, 16899);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1290, 16032, 16899);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 16915, 16930);

                return current;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1290, 15664, 16941);

                System.Management.Automation.CommandSearcher
                f_1290_15840_16017(string
                commandName, System.Management.Automation.SearchResolutionOptions
                options, System.Management.Automation.CommandTypes
                commandTypes, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandSearcher(commandName, options, commandTypes, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 15840, 16017);
                    return return_v;
                }


                bool
                f_1290_16116_16135(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 16116, 16135);
                    return return_v;
                }


                object
                f_1290_16824_16855(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 16824, 16855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 15664, 16941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 15664, 16941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CmdletInfo GetCmdletByTypeName(string cmdletTypeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 17445, 18587);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 17530, 17682) || true) && (f_1290_17534_17570(cmdletTypeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 17530, 17682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 17604, 17667);

                    throw f_1290_17610_17666("cmdletTypeName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 17530, 17682);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 17698, 17717);

                Exception
                e = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 17731, 17797);

                Type
                cmdletType = f_1290_17749_17796(cmdletTypeName, out e)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 17811, 17881) || true) && (e != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 17811, 17881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 17858, 17866);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 17811, 17881);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 17897, 17980) || true) && (cmdletType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 17897, 17980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 17953, 17965);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 17897, 17980);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 17996, 18022);

                CmdletAttribute
                ca = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 18036, 18232);
                    foreach (var attr in f_1290_18057_18093_I(f_1290_18057_18093(cmdletType, true)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 18036, 18232);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 18127, 18156);

                        ca = attr as CmdletAttribute;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 18174, 18217) || true) && (ca != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 18174, 18217);
                            DynAbs.Tracing.TraceSender.TraceBreak(1290, 18211, 18217);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 18174, 18217);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 18036, 18232);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1290, 1, 197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1290, 1, 197);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 18248, 18358) || true) && (ca == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 18248, 18358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 18296, 18343);

                    throw f_1290_18302_18342();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 18248, 18358);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 18374, 18400);

                string
                noun = f_1290_18388_18399(ca)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 18414, 18440);

                string
                verb = f_1290_18428_18439(ca)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 18454, 18492);

                string
                cmdletName = verb + "-" + noun
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 18508, 18576);

                return f_1290_18515_18575(cmdletName, cmdletType, null, null, _context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 17445, 18587);

                bool
                f_1290_17534_17570(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 17534, 17570);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1290_17610_17666(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 17610, 17666);
                    return return_v;
                }


                System.Type
                f_1290_17749_17796(string
                strTypeName, out System.Exception
                exception)
                {
                    var return_v = TypeResolver.ResolveType(strTypeName, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 17749, 17796);
                    return return_v;
                }


                object[]
                f_1290_18057_18093(System.Type
                this_param, bool
                inherit)
                {
                    var return_v = this_param.GetCustomAttributes(inherit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 18057, 18093);
                    return return_v;
                }


                object[]
                f_1290_18057_18093_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 18057, 18093);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1290_18302_18342()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 18302, 18342);
                    return return_v;
                }


                string
                f_1290_18388_18399(System.Management.Automation.CmdletAttribute
                this_param)
                {
                    var return_v = this_param.NounName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 18388, 18399);
                    return return_v;
                }


                string
                f_1290_18428_18439(System.Management.Automation.CmdletAttribute
                this_param)
                {
                    var return_v = this_param.VerbName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 18428, 18439);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1290_18515_18575(string
                name, System.Type
                implementingType, string
                helpFile, System.Management.Automation.PSSnapInInfo
                PSSnapin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType, helpFile, PSSnapin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 18515, 18575);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 17445, 18587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 17445, 18587);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public List<CmdletInfo> GetCmdlets()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 18725, 18820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 18786, 18809);

                return f_1290_18793_18808(this, "*");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 18725, 18820);

                System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                f_1290_18793_18808(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                pattern)
                {
                    var return_v = this_param.GetCmdlets(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 18793, 18808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 18725, 18820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 18725, 18820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public List<CmdletInfo> GetCmdlets(string pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 19009, 20524);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 19084, 19178) || true) && (pattern == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 19084, 19178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 19122, 19178);

                    throw f_1290_19128_19177("pattern");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 19084, 19178);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 19194, 19244);

                List<CmdletInfo>
                cmdlets = f_1290_19221_19243()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 19260, 19286);

                CmdletInfo
                current = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 19302, 19520);

                CommandSearcher
                searcher = f_1290_19329_19519(pattern, SearchResolutionOptions.CommandNameIsPattern, CommandTypes.Cmdlet, _context)
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 19534, 20482);
                            try
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 19613, 19716) || true) && (!f_1290_19618_19637(searcher))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 19613, 19716);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1290, 19687, 19693);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 19613, 19716);
                                }
                            }
                            catch (ArgumentException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 19753, 19847);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 19819, 19828);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 19753, 19847);
                            }
                            catch (PathTooLongException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 19865, 19962);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 19934, 19943);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 19865, 19962);
                            }
                            catch (FileLoadException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 19980, 20074);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 20046, 20055);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 19980, 20074);
                            }
                            catch (MetadataException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 20092, 20186);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 20158, 20167);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 20092, 20186);
                            }
                            catch (FormatException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 20204, 20296);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 20268, 20277);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 20204, 20296);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 20316, 20372);

                            current = f_1290_20326_20357(((IEnumerator)searcher)) as CmdletInfo;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 20390, 20453) || true) && (current != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 20390, 20453);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 20432, 20453);

                                f_1290_20432_20452(cmdlets, current);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 20390, 20453);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 19534, 20482);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 19534, 20482) || true) && (true)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1290, 19534, 20482);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1290, 19534, 20482);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 20498, 20513);

                return cmdlets;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 19009, 20524);

                System.Management.Automation.PSArgumentNullException
                f_1290_19128_19177(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 19128, 19177);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                f_1290_19221_19243()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CmdletInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 19221, 19243);
                    return return_v;
                }


                System.Management.Automation.CommandSearcher
                f_1290_19329_19519(string
                commandName, System.Management.Automation.SearchResolutionOptions
                options, System.Management.Automation.CommandTypes
                commandTypes, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandSearcher(commandName, options, commandTypes, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 19329, 19519);
                    return return_v;
                }


                bool
                f_1290_19618_19637(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 19618, 19637);
                    return return_v;
                }


                object
                f_1290_20326_20357(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 20326, 20357);
                    return return_v;
                }


                int
                f_1290_20432_20452(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                this_param, System.Management.Automation.CmdletInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 20432, 20452);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 19009, 20524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 19009, 20524);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public List<string> GetCommandName(string name, bool nameIsPattern, bool returnFullName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 21132, 23135);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 21245, 21363) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 21245, 21363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 21295, 21348);

                    throw f_1290_21301_21347("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 21245, 21363);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 21379, 21422);

                List<string>
                commands = f_1290_21403_21421()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 21438, 23092);
                    foreach (CommandInfo current in f_1290_21470_21525_I(f_1290_21470_21525(this, name, CommandTypes.All, nameIsPattern)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 21438, 23092);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 21559, 23077) || true) && (f_1290_21563_21582(current) == CommandTypes.Application)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 21559, 23077);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 21652, 21716);

                            string
                            cmdExtension = f_1290_21674_21715(f_1290_21702_21714(current))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 21738, 22562) || true) && (!f_1290_21743_21777(cmdExtension))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 21738, 22562);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 21894, 22539);
                                    foreach (string extension in f_1290_21923_21954_I(f_1290_21923_21954()))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 21894, 22539);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 22012, 22512) || true) && (f_1290_22016_22082(extension, cmdExtension, StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 22012, 22512);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 22148, 22481) || true) && (returnFullName)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 22148, 22481);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 22240, 22273);

                                                f_1290_22240_22272(commands, f_1290_22253_22271(current));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 22148, 22481);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 22148, 22481);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 22419, 22446);

                                                f_1290_22419_22445(commands, f_1290_22432_22444(current));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 22148, 22481);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 22012, 22512);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 21894, 22539);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1290, 1, 646);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1290, 1, 646);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 21738, 22562);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 21559, 23077);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 21559, 23077);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 22604, 23077) || true) && (f_1290_22608_22627(current) == CommandTypes.ExternalScript)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 22604, 23077);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 22700, 22949) || true) && (returnFullName)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 22700, 22949);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 22768, 22801);

                                    f_1290_22768_22800(commands, f_1290_22781_22799(current));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 22700, 22949);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 22700, 22949);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 22899, 22926);

                                    f_1290_22899_22925(commands, f_1290_22912_22924(current));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 22700, 22949);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 22604, 23077);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 22604, 23077);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 23031, 23058);

                                f_1290_23031_23057(commands, f_1290_23044_23056(current));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 22604, 23077);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 21559, 23077);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 21438, 23092);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1290, 1, 1655);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1290, 1, 1655);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 23108, 23124);

                return commands;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 21132, 23135);

                System.Management.Automation.PSArgumentNullException
                f_1290_21301_21347(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 21301, 21347);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1290_21403_21421()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 21403, 21421);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1290_21470_21525(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                name, System.Management.Automation.CommandTypes
                commandTypes, bool
                nameIsPattern)
                {
                    var return_v = this_param.GetCommands(name, commandTypes, nameIsPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 21470, 21525);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1290_21563_21582(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 21563, 21582);
                    return return_v;
                }


                string
                f_1290_21702_21714(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 21702, 21714);
                    return return_v;
                }


                string?
                f_1290_21674_21715(string
                path)
                {
                    var return_v = System.IO.Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 21674, 21715);
                    return return_v;
                }


                bool
                f_1290_21743_21777(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 21743, 21777);
                    return return_v;
                }


                string[]
                f_1290_21923_21954()
                {
                    var return_v = CommandDiscovery.PathExtensions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 21923, 21954);
                    return return_v;
                }


                bool
                f_1290_22016_22082(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 22016, 22082);
                    return return_v;
                }


                string
                f_1290_22253_22271(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Definition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 22253, 22271);
                    return return_v;
                }


                int
                f_1290_22240_22272(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 22240, 22272);
                    return 0;
                }


                string
                f_1290_22432_22444(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 22432, 22444);
                    return return_v;
                }


                int
                f_1290_22419_22445(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 22419, 22445);
                    return 0;
                }


                string[]
                f_1290_21923_21954_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 21923, 21954);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1290_22608_22627(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 22608, 22627);
                    return return_v;
                }


                string
                f_1290_22781_22799(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Definition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 22781, 22799);
                    return return_v;
                }


                int
                f_1290_22768_22800(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 22768, 22800);
                    return 0;
                }


                string
                f_1290_22912_22924(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 22912, 22924);
                    return return_v;
                }


                int
                f_1290_22899_22925(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 22899, 22925);
                    return 0;
                }


                string
                f_1290_23044_23056(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 23044, 23056);
                    return return_v;
                }


                int
                f_1290_23031_23057(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 23031, 23057);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1290_21470_21525_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 21470, 21525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 21132, 23135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 21132, 23135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<CommandInfo> GetCommands(string name, CommandTypes commandTypes, bool nameIsPattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 23589, 24185);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 23717, 23835) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 23717, 23835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 23767, 23820);

                    throw f_1290_23773_23819("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 23717, 23835);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 23851, 24110);

                SearchResolutionOptions
                options = (DynAbs.Tracing.TraceSender.Conditional_F1(1290, 23885, 23898) || ((nameIsPattern && DynAbs.Tracing.TraceSender.Conditional_F2(1290, 23918, 24061)) || DynAbs.Tracing.TraceSender.Conditional_F3(1290, 24081, 24109))) ? (SearchResolutionOptions.CommandNameIsPattern | SearchResolutionOptions.ResolveFunctionPatterns | SearchResolutionOptions.ResolveAliasPatterns)
                : SearchResolutionOptions.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 24126, 24174);

                return f_1290_24133_24173(this, name, commandTypes, options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 23589, 24185);

                System.Management.Automation.PSArgumentNullException
                f_1290_23773_23819(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 23773, 23819);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1290_24133_24173(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                name, System.Management.Automation.CommandTypes
                commandTypes, System.Management.Automation.SearchResolutionOptions
                options)
                {
                    var return_v = this_param.GetCommands(name, commandTypes, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 24133, 24173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 23589, 24185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 23589, 24185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<CommandInfo> GetCommands(string name, CommandTypes commandTypes, SearchResolutionOptions options, CommandOrigin? commandOrigin = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 24197, 25705);

                var listYield = new List<CommandInfo>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 24377, 24532);

                CommandSearcher
                searcher = f_1290_24404_24531(name, options, commandTypes, _context)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 24548, 24667) || true) && (commandOrigin != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 24548, 24667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 24607, 24652);

                    searcher.CommandOrigin = f_1290_24632_24651(commandOrigin);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 24548, 24667);
                }
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 24683, 25694);
                            try
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 24762, 24865) || true) && (!f_1290_24767_24786(searcher))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 24762, 24865);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1290, 24836, 24842);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 24762, 24865);
                                }
                            }
                            catch (ArgumentException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 24902, 24996);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 24968, 24977);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 24902, 24996);
                            }
                            catch (PathTooLongException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 25014, 25111);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 25083, 25092);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 25014, 25111);
                            }
                            catch (FileLoadException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 25129, 25223);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 25195, 25204);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 25129, 25223);
                            }
                            catch (MetadataException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 25241, 25335);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 25307, 25316);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 25241, 25335);
                            }
                            catch (FormatException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1290, 25353, 25445);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 25417, 25426);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1290, 25353, 25445);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 25465, 25538);

                            CommandInfo
                            commandInfo = f_1290_25491_25522(((IEnumerator)searcher)) as CommandInfo
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 25556, 25665) || true) && (commandInfo != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 25556, 25665);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 25621, 25646);

                                listYield.Add(commandInfo);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 25556, 25665);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 24683, 25694);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 24683, 25694) || true) && (true)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1290, 24683, 25694);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1290, 24683, 25694);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 24197, 25705);

                return listYield;

                System.Management.Automation.CommandSearcher
                f_1290_24404_24531(string
                commandName, System.Management.Automation.SearchResolutionOptions
                options, System.Management.Automation.CommandTypes
                commandTypes, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandSearcher(commandName, options, commandTypes, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 24404, 24531);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1290_24632_24651(System.Management.Automation.CommandOrigin?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 24632, 24651);
                    return return_v;
                }


                bool
                f_1290_24767_24786(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 24767, 24786);
                    return return_v;
                }


                object
                f_1290_25491_25522(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 25491, 25522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 24197, 25705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 24197, 25705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> InvokeScript(string script)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 26256, 26413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 26336, 26402);

                return f_1290_26343_26401(this, script, true, PipelineResultTypes.None, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 26256, 26413);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1290_26343_26401(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                script, bool
                useNewScope, System.Management.Automation.Runspaces.PipelineResultTypes
                writeToPipeline, System.Collections.IList
                input, params object[]
                args)
                {
                    var return_v = this_param.InvokeScript(script, useNewScope, writeToPipeline, input, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 26343, 26401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 26256, 26413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 26256, 26413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> InvokeScript(string script, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 27033, 27218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 27135, 27207);

                return f_1290_27142_27206(this, script, true, PipelineResultTypes.None, null, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 27033, 27218);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1290_27142_27206(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                script, bool
                useNewScope, System.Management.Automation.Runspaces.PipelineResultTypes
                writeToPipeline, System.Collections.IList
                input, params object[]
                args)
                {
                    var return_v = this_param.InvokeScript(script, useNewScope, writeToPipeline, input, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 27142, 27206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 27033, 27218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 27033, 27218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> InvokeScript(
                    SessionState sessionState, ScriptBlock scriptBlock, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 27448, 28460);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 27601, 27733) || true) && (scriptBlock == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 27601, 27733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 27658, 27718);

                    throw f_1290_27664_27717("scriptBlock");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 27601, 27733);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 27749, 27883) || true) && (sessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 27749, 27883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 27807, 27868);

                    throw f_1290_27813_27867("sessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 27749, 27883);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 27899, 27967);

                SessionStateInternal
                _oldSessionState = f_1290_27939_27966(_context)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 28017, 28069);

                    _context.EngineSessionState = f_1290_28047_28068(sessionState);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 28087, 28318);

                    return f_1290_28094_28317(this, sb: scriptBlock, useNewScope: false, writeToPipeline: PipelineResultTypes.None, input: null, args: args);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1290, 28347, 28449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 28387, 28434);

                    _context.EngineSessionState = _oldSessionState;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1290, 28347, 28449);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 27448, 28460);

                System.Management.Automation.PSArgumentNullException
                f_1290_27664_27717(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 27664, 27717);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1290_27813_27867(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 27813, 27867);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1290_27939_27966(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 27939, 27966);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1290_28047_28068(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 28047, 28068);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1290_28094_28317(System.Management.Automation.CommandInvocationIntrinsics
                this_param, System.Management.Automation.ScriptBlock
                sb, bool
                useNewScope, System.Management.Automation.Runspaces.PipelineResultTypes
                writeToPipeline, System.Collections.IList
                input, params object[]
                args)
                {
                    var return_v = this_param.InvokeScript(sb: sb, useNewScope: useNewScope, writeToPipeline: writeToPipeline, input: input, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 28094, 28317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 27448, 28460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 27448, 28460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> InvokeScript(
                    bool useLocalScope, ScriptBlock scriptBlock, IList input, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 28989, 29960);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 29148, 29280) || true) && (scriptBlock == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 29148, 29280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 29205, 29265);

                    throw f_1290_29211_29264("scriptBlock");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 29148, 29280);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 29479, 29553);

                var
                old = f_1290_29489_29552()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 29567, 29658);

                System.Management.Automation.Runspaces.Runspace.DefaultRunspace = f_1290_29633_29657(_context);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 29708, 29795);

                    return f_1290_29715_29794(this, scriptBlock, useLocalScope, PipelineResultTypes.None, input, args);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1290, 29824, 29949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 29864, 29934);

                    System.Management.Automation.Runspaces.Runspace.DefaultRunspace = old;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1290, 29824, 29949);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 28989, 29960);

                System.Management.Automation.PSArgumentNullException
                f_1290_29211_29264(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 29211, 29264);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1290_29489_29552()
                {
                    var return_v = System.Management.Automation.Runspaces.Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 29489, 29552);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1290_29633_29657(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 29633, 29657);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1290_29715_29794(System.Management.Automation.CommandInvocationIntrinsics
                this_param, System.Management.Automation.ScriptBlock
                sb, bool
                useNewScope, System.Management.Automation.Runspaces.PipelineResultTypes
                writeToPipeline, System.Collections.IList
                input, params object[]
                args)
                {
                    var return_v = this_param.InvokeScript(sb, useNewScope, writeToPipeline, input, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 29715, 29794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 28989, 29960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 28989, 29960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> InvokeScript(string script, bool useNewScope,
                    PipelineResultTypes writeToPipeline, IList input, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 31425, 31924);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 31608, 31687) || true) && (script == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 31608, 31687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 31645, 31687);

                    throw f_1290_31651_31686("script");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 31608, 31687);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 31776, 31830);

                ScriptBlock
                sb = f_1290_31793_31829(_context, script)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 31846, 31913);

                return f_1290_31853_31912(this, sb, useNewScope, writeToPipeline, input, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 31425, 31924);

                System.ArgumentNullException
                f_1290_31651_31686(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 31651, 31686);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1290_31793_31829(System.Management.Automation.ExecutionContext
                context, string
                script)
                {
                    var return_v = ScriptBlock.Create(context, script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 31793, 31829);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1290_31853_31912(System.Management.Automation.CommandInvocationIntrinsics
                this_param, System.Management.Automation.ScriptBlock
                sb, bool
                useNewScope, System.Management.Automation.Runspaces.PipelineResultTypes
                writeToPipeline, System.Collections.IList
                input, params object[]
                args)
                {
                    var return_v = this_param.InvokeScript(sb, useNewScope, writeToPipeline, input, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 31853, 31912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 31425, 31924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 31425, 31924);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Collection<PSObject> InvokeScript(ScriptBlock sb, bool useNewScope,
                    PipelineResultTypes writeToPipeline, IList input, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 31936, 35230);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 32121, 32185) || true) && (_cmdlet != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 32121, 32185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 32159, 32185);

                    f_1290_32159_32184(_cmdlet);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 32121, 32185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 32201, 32227);

                Cmdlet
                cmdletToUse = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 32241, 32358);

                ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior = ScriptBlock.ErrorHandlingBehavior.WriteToExternalErrorPipe
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 32416, 32634) || true) && ((writeToPipeline & PipelineResultTypes.Output) == PipelineResultTypes.Output)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 32416, 32634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 32530, 32552);

                    cmdletToUse = _cmdlet;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 32570, 32619);

                    writeToPipeline &= (~PipelineResultTypes.Output);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 32416, 32634);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 32691, 32966) || true) && ((writeToPipeline & PipelineResultTypes.Error) == PipelineResultTypes.Error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 32691, 32966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 32803, 32885);

                    errorHandlingBehavior = ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 32903, 32951);

                    writeToPipeline &= (~PipelineResultTypes.Error);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 32691, 32966);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 32982, 33191) || true) && (writeToPipeline != PipelineResultTypes.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 32982, 33191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 33127, 33176);

                    throw f_1290_33133_33175();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 32982, 33191);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 33357, 33374);

                object
                rawResult
                = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 33388, 34273) || true) && (cmdletToUse != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 33388, 34273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 33445, 33811);

                    f_1290_33445_33810(sb, contextCmdlet: cmdletToUse, useLocalScope: useNewScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: f_1290_33666_33686(), input: input, scriptThis: f_1290_33756_33776(), args: args);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 33829, 33862);

                    rawResult = f_1290_33841_33861();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 33388, 34273);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 33388, 34273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 33928, 34258);

                    rawResult = f_1290_33940_34257(sb, useLocalScope: useNewScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: f_1290_34113_34133(), input: input, scriptThis: f_1290_34203_34223(), args: args);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 33388, 34273);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 34289, 34409) || true) && (rawResult == f_1290_34306_34326())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 34289, 34409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 34360, 34394);

                    return f_1290_34367_34393();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 34289, 34409);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 34511, 34575);

                Collection<PSObject>
                result = rawResult as Collection<PSObject>
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 34589, 34640) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 34589, 34640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 34626, 34640);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 34589, 34640);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 34656, 34692);

                result = f_1290_34665_34691();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 34708, 34732);

                IEnumerator
                list = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 34746, 34797);

                list = f_1290_34753_34796(rawResult);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 34813, 35189) || true) && (list != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 34813, 35189);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 34863, 35049) || true) && (f_1290_34870_34885(list))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 34863, 35049);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 34927, 34953);

                            object
                            val = f_1290_34940_34952(list)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 34977, 35030);

                            f_1290_34977_35029(
                                                result, f_1290_34988_35028(val));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 34863, 35049);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1290, 34863, 35049);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1290, 34863, 35049);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 34813, 35189);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 34813, 35189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 35115, 35174);

                    f_1290_35115_35173(result, f_1290_35126_35172(rawResult));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 34813, 35189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 35205, 35219);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 31936, 35230);

                int
                f_1290_32159_32184(System.Management.Automation.PSCmdlet
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 32159, 32184);
                    return 0;
                }


                System.Management.Automation.PSNotImplementedException
                f_1290_33133_33175()
                {
                    var return_v = PSTraceSource.NewNotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 33133, 33175);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1290_33666_33686()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 33666, 33686);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1290_33756_33776()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 33756, 33776);
                    return return_v;
                }


                int
                f_1290_33445_33810(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.Cmdlet
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, System.Collections.IList
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 33445, 33810);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1290_33841_33861()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 33841, 33861);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1290_34113_34133()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 34113, 34133);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1290_34203_34223()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 34203, 34223);
                    return return_v;
                }


                object
                f_1290_33940_34257(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, System.Collections.IList
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    var return_v = this_param.DoInvokeReturnAsIs(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 33940, 34257);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1290_34306_34326()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 34306, 34326);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1290_34367_34393()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 34367, 34393);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1290_34665_34691()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 34665, 34691);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1290_34753_34796(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 34753, 34796);
                    return return_v;
                }


                bool
                f_1290_34870_34885(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 34870, 34885);
                    return return_v;
                }


                object
                f_1290_34940_34952(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 34940, 34952);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1290_34988_35028(object
                obj)
                {
                    var return_v = LanguagePrimitives.AsPSObjectOrNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 34988, 35028);
                    return return_v;
                }


                int
                f_1290_34977_35029(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 34977, 35029);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1290_35126_35172(object
                obj)
                {
                    var return_v = LanguagePrimitives.AsPSObjectOrNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 35126, 35172);
                    return return_v;
                }


                int
                f_1290_35115_35173(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 35115, 35173);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 31936, 35230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 31936, 35230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ScriptBlock NewScriptBlock(string scriptText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 35532, 35806);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 35609, 35689) || true) && (_commandRuntime != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 35609, 35689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 35655, 35689);

                    f_1290_35655_35688(_commandRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 35609, 35689);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 35705, 35767);

                ScriptBlock
                result = f_1290_35726_35766(_context, scriptText)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 35781, 35795);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 35532, 35806);

                int
                f_1290_35655_35688(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 35655, 35688);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1290_35726_35766(System.Management.Automation.ExecutionContext
                context, string
                script)
                {
                    var return_v = ScriptBlock.Create(context, script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 35726, 35766);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 35532, 35806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 35532, 35806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommandInvocationIntrinsics()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1290, 9498, 35813);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1290, 9498, 35813);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 9498, 35813);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1290, 9498, 35813);

        System.Management.Automation.ICommandRuntime
        f_1290_9930_9951(System.Management.Automation.PSCmdlet
        this_param)
        {
            var return_v = this_param.CommandRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 9930, 9951);
            return return_v;
        }


        static System.Management.Automation.ExecutionContext
        f_1290_10094_10101_C(System.Management.Automation.ExecutionContext
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1290, 10011, 10130);
            return return_v;
        }

    }
    public abstract partial class PSCmdlet : Cmdlet
    {
        internal bool HasDynamicParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 36613, 36655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 36619, 36653);

                    return this is IDynamicParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 36613, 36655);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 36554, 36666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 36554, 36666);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string ParameterSetName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 36955, 37146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 36991, 37131);
                    using (f_1290_36998_37045())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 37087, 37112);

                        return f_1290_37094_37111();
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1290, 36991, 37131);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 36955, 37146);

                    System.IDisposable
                    f_1290_36998_37045()
                    {
                        var return_v = PSTransactionManager.GetEngineProtectionScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 36998, 37045);
                        return return_v;
                    }


                    string
                    f_1290_37094_37111()
                    {
                        var return_v = _ParameterSetName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 37094, 37111);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 36900, 37157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 36900, 37157);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public new InvocationInfo MyInvocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 37413, 37604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 37449, 37589);
                    using (f_1290_37456_37503())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 37545, 37570);

                        return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.MyInvocation, 1290, 37552, 37569);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1290, 37449, 37589);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 37413, 37604);

                    System.IDisposable
                    f_1290_37456_37503()
                    {
                        var return_v = PSTransactionManager.GetEngineProtectionScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 37456, 37503);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 37350, 37615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 37350, 37615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PagingParameters PagingParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 38038, 38833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 38074, 38818);
                    using (f_1290_38081_38128())
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 38170, 38307) || true) && (!f_1290_38175_38207(f_1290_38175_38191(this)).SupportsPaging)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 38170, 38307);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 38272, 38284);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 38170, 38307);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 38331, 38750) || true) && (_pagingParameters == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 38331, 38750);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 38410, 38489);

                            MshCommandRuntime
                            mshCommandRuntime = f_1290_38448_38467(this) as MshCommandRuntime
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 38515, 38727) || true) && (mshCommandRuntime != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1290, 38515, 38727);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 38602, 38700);

                                _pagingParameters = f_1290_38622_38656(mshCommandRuntime) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PagingParameters>(1290, 38622, 38699) ?? f_1290_38660_38699(mshCommandRuntime));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 38515, 38727);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1290, 38331, 38750);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 38774, 38799);

                        return _pagingParameters;
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1290, 38074, 38818);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 38038, 38833);

                    System.IDisposable
                    f_1290_38081_38128()
                    {
                        var return_v = PSTransactionManager.GetEngineProtectionScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 38081, 38128);
                        return return_v;
                    }


                    System.Management.Automation.CommandInfo
                    f_1290_38175_38191(System.Management.Automation.PSCmdlet
                    this_param)
                    {
                        var return_v = this_param.CommandInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 38175, 38191);
                        return return_v;
                    }


                    System.Management.Automation.CommandMetadata
                    f_1290_38175_38207(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.CommandMetadata;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 38175, 38207);
                        return return_v;
                    }


                    System.Management.Automation.ICommandRuntime
                    f_1290_38448_38467(System.Management.Automation.PSCmdlet
                    this_param)
                    {
                        var return_v = this_param.CommandRuntime;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 38448, 38467);
                        return return_v;
                    }


                    System.Management.Automation.PagingParameters
                    f_1290_38622_38656(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.PagingParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 38622, 38656);
                        return return_v;
                    }


                    System.Management.Automation.PagingParameters
                    f_1290_38660_38699(System.Management.Automation.MshCommandRuntime
                    commandRuntime)
                    {
                        var return_v = new System.Management.Automation.PagingParameters(commandRuntime);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 38660, 38699);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 37973, 38844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 37973, 38844);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PagingParameters _pagingParameters;

        private CommandInvocationIntrinsics _invokeCommand;

        public CommandInvocationIntrinsics InvokeCommand
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1290, 39314, 39571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 39350, 39556);
                    using (f_1290_39357_39404())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 39446, 39537);

                        return _invokeCommand ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.CommandInvocationIntrinsics>(1290, 39453, 39536) ?? (_invokeCommand = f_1290_39489_39535(f_1290_39521_39528(), this)));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1290, 39350, 39556);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1290, 39314, 39571);

                    System.IDisposable
                    f_1290_39357_39404()
                    {
                        var return_v = PSTransactionManager.GetEngineProtectionScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 39357, 39404);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1290_39521_39528()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1290, 39521, 39528);
                        return return_v;
                    }


                    System.Management.Automation.CommandInvocationIntrinsics
                    f_1290_39489_39535(System.Management.Automation.ExecutionContext
                    context, System.Management.Automation.PSCmdlet
                    cmdlet)
                    {
                        var return_v = new System.Management.Automation.CommandInvocationIntrinsics(context, cmdlet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1290, 39489, 39535);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1290, 39241, 39582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1290, 39241, 39582);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
}

